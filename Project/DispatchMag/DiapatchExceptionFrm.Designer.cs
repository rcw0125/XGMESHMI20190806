namespace DispatchMag
{
    partial class DiapatchExceptionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiapatchExceptionFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsSteelExange = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelExchange = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteelExchange = new System.Data.DataTable();
            this.coldsSteelExchangeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableNAME = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableOBJECTID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableAPP_REASON = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEX_TIME = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEX_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEX_FLAG = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableCheckFlag = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSteelExchange = new System.Windows.Forms.ToolStripButton();
            this.btnSteelTurn = new System.Windows.Forms.ToolStripButton();
            this.btnSteelBack = new System.Windows.Forms.ToolStripButton();
            this.btnSteelDiv = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvLabElement = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.dvHeatExcept = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHeatExcept = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatExcept = new AppSvrHMI.L3DataSet();
            this.schemadsHeatExcept = new System.Data.DataTable();
            this.coldsHeatExceptL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableName = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableProcess_Count = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableClassify = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableExceptional_Time = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSteelExchange = new System.Windows.Forms.TabPage();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSteelExchange = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelChangeReason = new AppSvrHMI.L3DataSet();
            this.schemadsSteelChangeReason = new System.Data.DataTable();
            this.coldsSteelChangeReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelChangeReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.eXTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSteelTurn = new System.Windows.Forms.TabPage();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvSteelTurn = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNITIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOPERATORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPREASONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelTrunReason = new AppSvrHMI.L3DataSet();
            this.schemadsSteelTrunReason = new System.Data.DataTable();
            this.coldsSteelTrunReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelTrunReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.tURNTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURNOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURN_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLTURNFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelTurn = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelTurn = new AppSvrHMI.L3DataSet();
            this.schemadsSteelTurn = new System.Data.DataTable();
            this.coldsSteelTurnL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableNAME = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableOBJECTID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAPP_REASON = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTURN_TIME = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTURN_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTURN_FLAG = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSteelBack = new System.Windows.Forms.TabPage();
            this.hmiRootPanel4 = new HMIBase.HMIRootPanel();
            this.dvSteelBack = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNITIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTIMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOPERATORDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPREASONDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelBackReason = new AppSvrHMI.L3DataSet();
            this.schemadsSteelBackReason = new System.Data.DataTable();
            this.coldsSteelBackReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelBackReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bACKUNITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACKTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACKOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BACK_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelBack = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelBack = new AppSvrHMI.L3DataSet();
            this.schemadsSteelBack = new System.Data.DataTable();
            this.coldsSteelBackL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableNAME = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableOBJECTID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableAPP_REASON = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBACK_UNITID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBACK_TIME = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBACK_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBACK_FLAG = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSteelDiv = new System.Windows.Forms.TabPage();
            this.hmiRootPanel5 = new HMIBase.HMIRootPanel();
            this.dvSteelDiv = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTIMEDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOPERATORDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNITIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVUNITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIV_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPREASONDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelDivReason = new AppSvrHMI.L3DataSet();
            this.schemadsSteelDivReason = new System.Data.DataTable();
            this.coldsSteelDivReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelDivReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.gUIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelDiv = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelDiv = new AppSvrHMI.L3DataSet();
            this.schemadsSteelDiv = new System.Data.DataTable();
            this.coldsSteelDivL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableNAME = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableOBJECTID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableDIV_UNITID = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableDIV_TIME = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableDIV_OPERATOR = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableDIV_FLAG = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableAPP_REASON = new System.Data.DataColumn();
            this.coldsSteelDivL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.dsExchangeSend = new AppSvrHMI.L3DataSet();
            this.schemadsExchangeSend = new System.Data.DataTable();
            this.coldsExchangeSendL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableName = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableEx_Time = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableEx_Operator = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableEx_Flag = new System.Data.DataColumn();
            this.coldsExchangeSendL3DataTableEx_SteelGradeIndex = new System.Data.DataColumn();
            this.dsTurnSend = new AppSvrHMI.L3DataSet();
            this.schemadsTurnSend = new System.Data.DataTable();
            this.coldsTurnSendL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableName = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableTurn_Time = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableTurn_Operator = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableTurn_Flag = new System.Data.DataColumn();
            this.coldsTurnSendL3DataTableAll_Turn_Flag = new System.Data.DataColumn();
            this.dsBackSend = new AppSvrHMI.L3DataSet();
            this.schemadsBackSend = new System.Data.DataTable();
            this.coldsBackSendL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableName = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableBack_UnitID = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableBack_Time = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableBack_Operator = new System.Data.DataColumn();
            this.coldsBackSendL3DataTableBack_Flag = new System.Data.DataColumn();
            this.dsDivSend = new AppSvrHMI.L3DataSet();
            this.schemadsDivSend = new System.Data.DataTable();
            this.coldsDivSendL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableName = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableDiv_UnitID = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableDiv_Time = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableDiv_Operator = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableDiv_Flag = new System.Data.DataColumn();
            this.coldsDivSendL3DataTableApp_Reason = new System.Data.DataColumn();
            this.dsElement = new AppSvrHMI.L3DataSet();
            this.schemadsElementStd = new System.Data.DataTable();
            this.coldsElementStdL3DataTableGUID = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableName = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableAppID = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableC = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSi = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableMn = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableP = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableS = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableCu = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableNi = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableCr = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableMo = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableV = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableNb = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableAl = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableAlS = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableTi = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableB = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSb = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableAs = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableSn = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableZn = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableCa = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableW = new System.Data.DataColumn();
            this.coldsElementStdL3DataTablePb = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableRe = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableCeq = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableN = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableH = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableO = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsElementStdL3DataTableDataLogMode = new System.Data.DataColumn();
            this.dsEleStd = new AppSvrHMI.L3DataSet();
            this.schemadsEleStd = new System.Data.DataTable();
            this.coldsEleStdL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableName = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLadle_Brick = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLadle_Use = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLadle_Pre_SteelGrade = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLadle_Stay = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableBOF_Type = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLadle_Tapped_Proc = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableLF_Type = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableRH_Type = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCaster_Type = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableC_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableC_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableC_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSi_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSi_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSi_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMn_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMn_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMn_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableP_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableS_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCu_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCu_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCu_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNi_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNi_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNi_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCr_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCr_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCr_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMo_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMo_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableMo_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableV_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableV_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableV_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNb_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNb_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableNb_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAl_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAl_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAl_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAlS_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAlS_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAlS_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableTi_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableTi_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableTi_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableB_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableB_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableB_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSb_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSb_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSb_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSn_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSn_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableSn_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAs_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAs_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableAs_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZn_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZn_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZn_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZr_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZr_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableZr_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCa_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCa_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCa_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableW_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableW_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableW_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTablePb_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTablePb_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTablePb_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableRe_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableRe_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableRe_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCeq_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCeq_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableCeq_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableN_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableN_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableN_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableH_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableH_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableH_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableO_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableO_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableO_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther1_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther1_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther1_Max = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther2_Min = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther2_Aim = new System.Data.DataColumn();
            this.coldsEleStdL3DataTableOther2_Max = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelExange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelExchange)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLabElement)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSteelExchange.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabSteelTurn.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTrunReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTrunReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.tabSteelBack.SuspendLayout();
            this.hmiRootPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBackReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBackReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            this.tabSteelDiv.SuspendLayout();
            this.hmiRootPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelDivReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelDivReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchangeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExchangeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTurnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTurnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBackSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBackSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDivSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDivSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElementStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEleStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEleStd)).BeginInit();
            this.SuspendLayout();
            // 
            // bsSteelExange
            // 
            this.bsSteelExange.DataMember = "L3DataTable";
            this.bsSteelExange.DataSource = this.dsSteelExchange;
            // 
            // dsSteelExchange
            // 
            this.dsSteelExchange.AutoLoad = true;
            this.dsSteelExchange.AutoSubscribe = true;
            this.dsSteelExchange.DataSetName = "L3DataSet";
            this.dsSteelExchange.DeleteMethod = "";
            this.dsSteelExchange.InsertMethod = "";
            this.dsSteelExchange.L3DataAdapter = this.Adapter;
            this.dsSteelExchange.LoadEvent = "Click";
            this.dsSteelExchange.LoadTrigger = null;
            this.dsSteelExchange.RefreshValve = 1000;
            this.dsSteelExchange.SourceCommand = null;
            this.dsSteelExchange.SourceCondition = null;
            this.dsSteelExchange.SourceMethod = "GetCurSteelExInfor";
            this.dsSteelExchange.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteelExchange.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsSteelExchange.SubscribeTarget = null;
            this.dsSteelExchange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelExchange});
            this.dsSteelExchange.UpdateEvent = "Click";
            this.dsSteelExchange.UpdateMethod = "";
            this.dsSteelExchange.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteelExchange
            // 
            this.schemadsSteelExchange.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelExchangeL3DataTableGUID,
            this.coldsSteelExchangeL3DataTableNAME,
            this.coldsSteelExchangeL3DataTableOBJECTID,
            this.coldsSteelExchangeL3DataTablePREHEATID,
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX,
            this.coldsSteelExchangeL3DataTableHEATID,
            this.coldsSteelExchangeL3DataTableAPP_UNITID,
            this.coldsSteelExchangeL3DataTableAPP_TIME,
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT,
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR,
            this.coldsSteelExchangeL3DataTableAPP_REASON,
            this.coldsSteelExchangeL3DataTableEX_TIME,
            this.coldsSteelExchangeL3DataTableEX_OPERATOR,
            this.coldsSteelExchangeL3DataTableEX_FLAG,
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX,
            this.coldsSteelExchangeL3DataTableCheckFlag});
            this.schemadsSteelExchange.TableName = "L3DataTable";
            // 
            // coldsSteelExchangeL3DataTableGUID
            // 
            this.coldsSteelExchangeL3DataTableGUID.Caption = "GUID";
            this.coldsSteelExchangeL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelExchangeL3DataTableGUID.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableNAME
            // 
            this.coldsSteelExchangeL3DataTableNAME.Caption = "NAME";
            this.coldsSteelExchangeL3DataTableNAME.ColumnName = "NAME";
            this.coldsSteelExchangeL3DataTableNAME.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableNAME.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableOBJECTID
            // 
            this.coldsSteelExchangeL3DataTableOBJECTID.Caption = "OBJECTID";
            this.coldsSteelExchangeL3DataTableOBJECTID.ColumnName = "OBJECTID";
            this.coldsSteelExchangeL3DataTableOBJECTID.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableOBJECTID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTablePREHEATID
            // 
            this.coldsSteelExchangeL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsSteelExchangeL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsSteelExchangeL3DataTablePREHEATID.DefaultValue = "";
            this.coldsSteelExchangeL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableHEATID
            // 
            this.coldsSteelExchangeL3DataTableHEATID.Caption = "HEATID";
            this.coldsSteelExchangeL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsSteelExchangeL3DataTableHEATID.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableHEATID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableAPP_UNITID
            // 
            this.coldsSteelExchangeL3DataTableAPP_UNITID.Caption = "APP_UNITID";
            this.coldsSteelExchangeL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsSteelExchangeL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableAPP_TIME
            // 
            this.coldsSteelExchangeL3DataTableAPP_TIME.Caption = "APP_TIME";
            this.coldsSteelExchangeL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsSteelExchangeL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelExchangeL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT
            // 
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT.Caption = "APP_STEEL_WEIGHT";
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT.ColumnName = "APP_STEEL_WEIGHT";
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT.DataType = typeof(double);
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT.DefaultValue = 0;
            this.coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableAPP_OPERATOR
            // 
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR.Caption = "APP_OPERATOR";
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableAPP_REASON
            // 
            this.coldsSteelExchangeL3DataTableAPP_REASON.Caption = "APP_REASON";
            this.coldsSteelExchangeL3DataTableAPP_REASON.ColumnName = "APP_REASON";
            this.coldsSteelExchangeL3DataTableAPP_REASON.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableAPP_REASON.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEX_TIME
            // 
            this.coldsSteelExchangeL3DataTableEX_TIME.Caption = "EX_TIME";
            this.coldsSteelExchangeL3DataTableEX_TIME.ColumnName = "EX_TIME";
            this.coldsSteelExchangeL3DataTableEX_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelExchangeL3DataTableEX_TIME.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEX_OPERATOR
            // 
            this.coldsSteelExchangeL3DataTableEX_OPERATOR.Caption = "EX_OPERATOR";
            this.coldsSteelExchangeL3DataTableEX_OPERATOR.ColumnName = "EX_OPERATOR";
            this.coldsSteelExchangeL3DataTableEX_OPERATOR.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableEX_OPERATOR.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEX_FLAG
            // 
            this.coldsSteelExchangeL3DataTableEX_FLAG.Caption = "EX_FLAG";
            this.coldsSteelExchangeL3DataTableEX_FLAG.ColumnName = "EX_FLAG";
            this.coldsSteelExchangeL3DataTableEX_FLAG.DataType = typeof(int);
            this.coldsSteelExchangeL3DataTableEX_FLAG.DefaultValue = 0;
            this.coldsSteelExchangeL3DataTableEX_FLAG.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX
            // 
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX.Caption = "EX_STEELGRADEINDEX";
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX.ColumnName = "EX_STEELGRADEINDEX";
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableCheckFlag
            // 
            this.coldsSteelExchangeL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSteelExchangeL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSteelExchangeL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSteelExchangeL3DataTableCheckFlag.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.toolStripSeparator1,
            this.btnSteelExchange,
            this.btnSteelTurn,
            this.btnSteelBack,
            this.btnSteelDiv,
            this.btnLog,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(65, 40);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnSteelExchange
            // 
            this.btnSteelExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnSteelExchange.Image")));
            this.btnSteelExchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSteelExchange.Name = "btnSteelExchange";
            this.btnSteelExchange.Size = new System.Drawing.Size(65, 40);
            this.btnSteelExchange.Text = "改钢";
            this.btnSteelExchange.Click += new System.EventHandler(this.btnSteelExchange_Click);
            // 
            // btnSteelTurn
            // 
            this.btnSteelTurn.Image = ((System.Drawing.Image)(resources.GetObject("btnSteelTurn.Image")));
            this.btnSteelTurn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSteelTurn.Name = "btnSteelTurn";
            this.btnSteelTurn.Size = new System.Drawing.Size(89, 40);
            this.btnSteelTurn.Text = "钢水回炉";
            this.btnSteelTurn.Click += new System.EventHandler(this.btnSteelTurn_Click);
            // 
            // btnSteelBack
            // 
            this.btnSteelBack.Image = ((System.Drawing.Image)(resources.GetObject("btnSteelBack.Image")));
            this.btnSteelBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSteelBack.Name = "btnSteelBack";
            this.btnSteelBack.Size = new System.Drawing.Size(89, 40);
            this.btnSteelBack.Text = "钢水返送";
            this.btnSteelBack.Click += new System.EventHandler(this.btnSteelBack_Click);
            // 
            // btnSteelDiv
            // 
            this.btnSteelDiv.Image = ((System.Drawing.Image)(resources.GetObject("btnSteelDiv.Image")));
            this.btnSteelDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSteelDiv.Name = "btnSteelDiv";
            this.btnSteelDiv.Size = new System.Drawing.Size(89, 40);
            this.btnSteelDiv.Text = "炉次分割";
            this.btnSteelDiv.Click += new System.EventHandler(this.btnSteelDiv_Click);
            // 
            // btnLog
            // 
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(89, 40);
            this.btnLog.Text = "调度记事";
            this.btnLog.Visible = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 40);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvLabElement);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 324);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成分标准";
            // 
            // dvLabElement
            // 
            this.dvLabElement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvLabElement.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvLabElement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvLabElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLabElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dvLabElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLabElement.Enabled = false;
            this.dvLabElement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvLabElement.Location = new System.Drawing.Point(3, 17);
            this.dvLabElement.Name = "dvLabElement";
            this.dvLabElement.ReadOnly = true;
            this.dvLabElement.RowTemplate.Height = 23;
            this.dvLabElement.Size = new System.Drawing.Size(994, 304);
            this.dvLabElement.TabIndex = 180;
            this.dvLabElement.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Colum";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Colum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Colum";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Colum";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Colum";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Colum";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Colum";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Colum";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Colum";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Colum";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Colum";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Colum";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.Frozen = true;
            this.Column13.HeaderText = "Colum";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 60;
            // 
            // Column14
            // 
            this.Column14.Frozen = true;
            this.Column14.HeaderText = "Colum";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.Frozen = true;
            this.Column15.HeaderText = "Colum";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 60;
            // 
            // Column16
            // 
            this.Column16.FillWeight = 60F;
            this.Column16.Frozen = true;
            this.Column16.HeaderText = "Colum";
            this.Column16.MinimumWidth = 60;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hmiRootPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 333);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "质量信息";
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.Controls.Add(this.dvHeatExcept);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(3, 17);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(313, 313);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // dvHeatExcept
            // 
            this.dvHeatExcept.AllowUserToAddRows = false;
            this.dvHeatExcept.AutoGenerateColumns = false;
            this.dvHeatExcept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvHeatExcept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvHeatExcept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatExcept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn4,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn4,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn4,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.decideCodeDataGridViewTextBoxColumn,
            this.classifyDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn,
            this.iDObjectDataGridViewTextBoxColumn});
            this.dvHeatExcept.DataSource = this.bsHeatExcept;
            this.dvHeatExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatExcept.Location = new System.Drawing.Point(0, 0);
            this.dvHeatExcept.Name = "dvHeatExcept";
            this.dvHeatExcept.ReadOnly = true;
            this.dvHeatExcept.RowTemplate.Height = 23;
            this.dvHeatExcept.Size = new System.Drawing.Size(313, 313);
            this.dvHeatExcept.TabIndex = 0;
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            this.heatIDDataGridViewTextBoxColumn4.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn4.Width = 54;
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.HeaderText = "处理次数";
            this.processCountDataGridViewTextBoxColumn.Name = "processCountDataGridViewTextBoxColumn";
            this.processCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.processCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            this.unitTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitTypeIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位ID";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // preHeatIDDataGridViewTextBoxColumn4
            // 
            this.preHeatIDDataGridViewTextBoxColumn4.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn4.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn4.Name = "preHeatIDDataGridViewTextBoxColumn4";
            this.preHeatIDDataGridViewTextBoxColumn4.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn4.Width = 78;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn4
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn4.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn4.HeaderText = "作业炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn4.Name = "steelGradeIndexDataGridViewTextBoxColumn4";
            this.steelGradeIndexDataGridViewTextBoxColumn4.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn4.Width = 102;
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.exceptionalCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // decideCodeDataGridViewTextBoxColumn
            // 
            this.decideCodeDataGridViewTextBoxColumn.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.HeaderText = "处置代码";
            this.decideCodeDataGridViewTextBoxColumn.Name = "decideCodeDataGridViewTextBoxColumn";
            this.decideCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.decideCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "优先级";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.ReadOnly = true;
            this.classifyDataGridViewTextBoxColumn.Width = 66;
            // 
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            this.exceptionalTimeDataGridViewTextBoxColumn.HeaderText = "异常产生时间";
            this.exceptionalTimeDataGridViewTextBoxColumn.Name = "exceptionalTimeDataGridViewTextBoxColumn";
            this.exceptionalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.exceptionalTimeDataGridViewTextBoxColumn.Width = 102;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "身份标识";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDObjectDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsHeatExcept
            // 
            this.bsHeatExcept.DataMember = "L3DataTable";
            this.bsHeatExcept.DataSource = this.dsHeatExcept;
            // 
            // dsHeatExcept
            // 
            this.dsHeatExcept.AutoLoad = true;
            this.dsHeatExcept.AutoSubscribe = true;
            this.dsHeatExcept.DataSetName = "L3DataSet";
            this.dsHeatExcept.DeleteMethod = null;
            this.dsHeatExcept.InsertMethod = null;
            this.dsHeatExcept.L3DataAdapter = null;
            this.dsHeatExcept.LoadEvent = "Click";
            this.dsHeatExcept.LoadTrigger = null;
            this.dsHeatExcept.RefreshValve = 1000;
            this.dsHeatExcept.SourceCommand = null;
            this.dsHeatExcept.SourceCondition = null;
            this.dsHeatExcept.SourceMethod = "";
            this.dsHeatExcept.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatExcept.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Prod_Except";
            this.dsHeatExcept.SubscribeTarget = null;
            this.dsHeatExcept.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatExcept});
            this.dsHeatExcept.UpdateEvent = "Click";
            this.dsHeatExcept.UpdateMethod = null;
            this.dsHeatExcept.UpdateTrigger = null;
            // 
            // schemadsHeatExcept
            // 
            this.schemadsHeatExcept.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatExceptL3DataTableGUID,
            this.coldsHeatExceptL3DataTableName,
            this.coldsHeatExceptL3DataTableID_Object,
            this.coldsHeatExceptL3DataTableHeatID,
            this.coldsHeatExceptL3DataTableProcess_Count,
            this.coldsHeatExceptL3DataTableUnitTypeID,
            this.coldsHeatExceptL3DataTableUnitID,
            this.coldsHeatExceptL3DataTablePreHeatID,
            this.coldsHeatExceptL3DataTablePre_SteelGradeIndex,
            this.coldsHeatExceptL3DataTableSteelGradeIndex,
            this.coldsHeatExceptL3DataTableExceptional_Code,
            this.coldsHeatExceptL3DataTableDecide_Code,
            this.coldsHeatExceptL3DataTableClassify,
            this.coldsHeatExceptL3DataTableExceptional_Time});
            this.schemadsHeatExcept.TableName = "L3DataTable";
            // 
            // coldsHeatExceptL3DataTableGUID
            // 
            this.coldsHeatExceptL3DataTableGUID.Caption = "GUID";
            this.coldsHeatExceptL3DataTableGUID.ColumnName = "GUID";
            this.coldsHeatExceptL3DataTableGUID.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableName
            // 
            this.coldsHeatExceptL3DataTableName.Caption = "Name";
            this.coldsHeatExceptL3DataTableName.ColumnName = "Name";
            this.coldsHeatExceptL3DataTableName.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableID_Object
            // 
            this.coldsHeatExceptL3DataTableID_Object.Caption = "ID_Object";
            this.coldsHeatExceptL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsHeatExceptL3DataTableID_Object.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableHeatID
            // 
            this.coldsHeatExceptL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatExceptL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatExceptL3DataTableHeatID.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableProcess_Count
            // 
            this.coldsHeatExceptL3DataTableProcess_Count.Caption = "Process_Count";
            this.coldsHeatExceptL3DataTableProcess_Count.ColumnName = "Process_Count";
            this.coldsHeatExceptL3DataTableProcess_Count.DataType = typeof(int);
            this.coldsHeatExceptL3DataTableProcess_Count.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableUnitTypeID
            // 
            this.coldsHeatExceptL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsHeatExceptL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsHeatExceptL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableUnitID
            // 
            this.coldsHeatExceptL3DataTableUnitID.Caption = "UnitID";
            this.coldsHeatExceptL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsHeatExceptL3DataTableUnitID.Namespace = "";
            // 
            // coldsHeatExceptL3DataTablePreHeatID
            // 
            this.coldsHeatExceptL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsHeatExceptL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsHeatExceptL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsHeatExceptL3DataTablePre_SteelGradeIndex
            // 
            this.coldsHeatExceptL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsHeatExceptL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsHeatExceptL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableSteelGradeIndex
            // 
            this.coldsHeatExceptL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsHeatExceptL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsHeatExceptL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableExceptional_Code
            // 
            this.coldsHeatExceptL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsHeatExceptL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsHeatExceptL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableDecide_Code
            // 
            this.coldsHeatExceptL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsHeatExceptL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsHeatExceptL3DataTableDecide_Code.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableClassify
            // 
            this.coldsHeatExceptL3DataTableClassify.Caption = "Classify";
            this.coldsHeatExceptL3DataTableClassify.ColumnName = "Classify";
            this.coldsHeatExceptL3DataTableClassify.DataType = typeof(int);
            this.coldsHeatExceptL3DataTableClassify.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableExceptional_Time
            // 
            this.coldsHeatExceptL3DataTableExceptional_Time.Caption = "Exceptional_Time";
            this.coldsHeatExceptL3DataTableExceptional_Time.ColumnName = "Exceptional_Time";
            this.coldsHeatExceptL3DataTableExceptional_Time.DataType = typeof(System.DateTime);
            this.coldsHeatExceptL3DataTableExceptional_Time.Namespace = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSteelExchange);
            this.tabControl1.Controls.Add(this.tabSteelTurn);
            this.tabControl1.Controls.Add(this.tabSteelBack);
            this.tabControl1.Controls.Add(this.tabSteelDiv);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(319, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 333);
            this.tabControl1.TabIndex = 32;
            // 
            // tabSteelExchange
            // 
            this.tabSteelExchange.Controls.Add(this.hmiRootPanel1);
            this.tabSteelExchange.Location = new System.Drawing.Point(4, 21);
            this.tabSteelExchange.Name = "tabSteelExchange";
            this.tabSteelExchange.Size = new System.Drawing.Size(673, 308);
            this.tabSteelExchange.TabIndex = 0;
            this.tabSteelExchange.Text = "改钢申请";
            this.tabSteelExchange.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvSteelExchange);
            this.hmiRootPanel1.Controls.Add(this.bindingNavigator2);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(673, 308);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvSteelExchange
            // 
            this.dvSteelExchange.AllowUserToAddRows = false;
            this.dvSteelExchange.AutoGenerateColumns = false;
            this.dvSteelExchange.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvSteelExchange.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteelExchange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.pREHEATIDDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.aPPUNITIDDataGridViewTextBoxColumn,
            this.aPPTIMEDataGridViewTextBoxColumn,
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn,
            this.aPPOPERATORDataGridViewTextBoxColumn,
            this.aPPREASONDataGridViewTextBoxColumn,
            this.eXTIMEDataGridViewTextBoxColumn,
            this.eXOPERATORDataGridViewTextBoxColumn,
            this.EX_FLAG,
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.oBJECTIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvSteelExchange.DataSource = this.bsSteelExange;
            this.dvSteelExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelExchange.Location = new System.Drawing.Point(0, 25);
            this.dvSteelExchange.Name = "dvSteelExchange";
            this.dvSteelExchange.RowHeadersVisible = false;
            this.dvSteelExchange.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSteelExchange.RowTemplate.Height = 23;
            this.dvSteelExchange.Size = new System.Drawing.Size(669, 279);
            this.dvSteelExchange.TabIndex = 1;
            this.dvSteelExchange.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvSteelExchange_CellPainting);
            this.dvSteelExchange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            this.dvSteelExchange.CurrentCellDirtyStateChanged += new System.EventHandler(this.dv_CurrentCellDirtyStateChanged);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // pREHEATIDDataGridViewTextBoxColumn
            // 
            this.pREHEATIDDataGridViewTextBoxColumn.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn.Name = "pREHEATIDDataGridViewTextBoxColumn";
            this.pREHEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPUNITIDDataGridViewTextBoxColumn
            // 
            this.aPPUNITIDDataGridViewTextBoxColumn.DataPropertyName = "APP_UNITID";
            this.aPPUNITIDDataGridViewTextBoxColumn.HeaderText = "申请工序";
            this.aPPUNITIDDataGridViewTextBoxColumn.Name = "aPPUNITIDDataGridViewTextBoxColumn";
            this.aPPUNITIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPTIMEDataGridViewTextBoxColumn
            // 
            this.aPPTIMEDataGridViewTextBoxColumn.DataPropertyName = "APP_TIME";
            this.aPPTIMEDataGridViewTextBoxColumn.HeaderText = "申请时刻";
            this.aPPTIMEDataGridViewTextBoxColumn.Name = "aPPTIMEDataGridViewTextBoxColumn";
            this.aPPTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPSTEELWEIGHTDataGridViewTextBoxColumn
            // 
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "APP_STEEL_WEIGHT";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn.HeaderText = "申请钢量";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn.Name = "aPPSTEELWEIGHTDataGridViewTextBoxColumn";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPOPERATORDataGridViewTextBoxColumn
            // 
            this.aPPOPERATORDataGridViewTextBoxColumn.DataPropertyName = "APP_OPERATOR";
            this.aPPOPERATORDataGridViewTextBoxColumn.HeaderText = "申请人";
            this.aPPOPERATORDataGridViewTextBoxColumn.Name = "aPPOPERATORDataGridViewTextBoxColumn";
            this.aPPOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPREASONDataGridViewTextBoxColumn
            // 
            this.aPPREASONDataGridViewTextBoxColumn.DataPropertyName = "APP_REASON";
            this.aPPREASONDataGridViewTextBoxColumn.DataSource = this.dsSteelChangeReason;
            this.aPPREASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.aPPREASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.aPPREASONDataGridViewTextBoxColumn.HeaderText = "申请原因";
            this.aPPREASONDataGridViewTextBoxColumn.Name = "aPPREASONDataGridViewTextBoxColumn";
            this.aPPREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPPREASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPPREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aPPREASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelChangeReason
            // 
            this.dsSteelChangeReason.AutoLoad = true;
            this.dsSteelChangeReason.AutoSubscribe = true;
            this.dsSteelChangeReason.DataSetName = "L3DataSet";
            this.dsSteelChangeReason.DeleteMethod = null;
            this.dsSteelChangeReason.InsertMethod = null;
            this.dsSteelChangeReason.L3DataAdapter = this.Adapter;
            this.dsSteelChangeReason.LoadEvent = "Click";
            this.dsSteelChangeReason.LoadTrigger = null;
            this.dsSteelChangeReason.RefreshValve = 1000;
            this.dsSteelChangeReason.SourceCommand = null;
            this.dsSteelChangeReason.SourceCondition = "CODE_GROUP = \'SteelChangeReason\'";
            this.dsSteelChangeReason.SourceMethod = "";
            this.dsSteelChangeReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelChangeReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelChangeReason.SubscribeTarget = null;
            this.dsSteelChangeReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelChangeReason});
            this.dsSteelChangeReason.UpdateEvent = "Click";
            this.dsSteelChangeReason.UpdateMethod = null;
            this.dsSteelChangeReason.UpdateTrigger = null;
            // 
            // schemadsSteelChangeReason
            // 
            this.schemadsSteelChangeReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelChangeReasonL3DataTableCode,
            this.coldsSteelChangeReasonL3DataTableCode_Des});
            this.schemadsSteelChangeReason.TableName = "L3DataTable";
            // 
            // coldsSteelChangeReasonL3DataTableCode
            // 
            this.coldsSteelChangeReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelChangeReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelChangeReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelChangeReasonL3DataTableCode_Des
            // 
            this.coldsSteelChangeReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelChangeReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelChangeReasonL3DataTableCode_Des.Namespace = "";
            // 
            // eXTIMEDataGridViewTextBoxColumn
            // 
            this.eXTIMEDataGridViewTextBoxColumn.DataPropertyName = "EX_TIME";
            this.eXTIMEDataGridViewTextBoxColumn.HeaderText = "改钢时刻";
            this.eXTIMEDataGridViewTextBoxColumn.Name = "eXTIMEDataGridViewTextBoxColumn";
            this.eXTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXOPERATORDataGridViewTextBoxColumn
            // 
            this.eXOPERATORDataGridViewTextBoxColumn.DataPropertyName = "EX_OPERATOR";
            this.eXOPERATORDataGridViewTextBoxColumn.HeaderText = "改钢人";
            this.eXOPERATORDataGridViewTextBoxColumn.Name = "eXOPERATORDataGridViewTextBoxColumn";
            this.eXOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EX_FLAG
            // 
            this.EX_FLAG.DataPropertyName = "EX_FLAG";
            this.EX_FLAG.HeaderText = "改钢标志";
            this.EX_FLAG.Name = "EX_FLAG";
            this.EX_FLAG.ReadOnly = true;
            // 
            // eXSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "EX_STEELGRADEINDEX";
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "eXSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.eXSTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBJECTIDDataGridViewTextBoxColumn
            // 
            this.oBJECTIDDataGridViewTextBoxColumn.DataPropertyName = "OBJECTID";
            this.oBJECTIDDataGridViewTextBoxColumn.HeaderText = "";
            this.oBJECTIDDataGridViewTextBoxColumn.Name = "oBJECTIDDataGridViewTextBoxColumn";
            this.oBJECTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.bsSteelExange;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(669, 25);
            this.bindingNavigator2.TabIndex = 0;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tabSteelTurn
            // 
            this.tabSteelTurn.Controls.Add(this.hmiRootPanel2);
            this.tabSteelTurn.Location = new System.Drawing.Point(4, 21);
            this.tabSteelTurn.Name = "tabSteelTurn";
            this.tabSteelTurn.Size = new System.Drawing.Size(673, 308);
            this.tabSteelTurn.TabIndex = 1;
            this.tabSteelTurn.Text = "全回炉申请";
            this.tabSteelTurn.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel2.Controls.Add(this.dvSteelTurn);
            this.hmiRootPanel2.Controls.Add(this.bindingNavigator3);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(673, 308);
            this.hmiRootPanel2.TabIndex = 1;
            // 
            // dvSteelTurn
            // 
            this.dvSteelTurn.AllowUserToAddRows = false;
            this.dvSteelTurn.AutoGenerateColumns = false;
            this.dvSteelTurn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvSteelTurn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteelTurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn4,
            this.pREHEATIDDataGridViewTextBoxColumn1,
            this.hEATIDDataGridViewTextBoxColumn1,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1,
            this.aPPTIMEDataGridViewTextBoxColumn1,
            this.aPPUNITIDDataGridViewTextBoxColumn1,
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1,
            this.aPPOPERATORDataGridViewTextBoxColumn1,
            this.aPPREASONDataGridViewTextBoxColumn1,
            this.tURNTIMEDataGridViewTextBoxColumn,
            this.tURNOPERATORDataGridViewTextBoxColumn,
            this.TURN_FLAG,
            this.aLLTURNFLAGDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1,
            this.oBJECTIDDataGridViewTextBoxColumn1});
            this.dvSteelTurn.DataSource = this.bsSteelTurn;
            this.dvSteelTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelTurn.Location = new System.Drawing.Point(0, 25);
            this.dvSteelTurn.Name = "dvSteelTurn";
            this.dvSteelTurn.RowTemplate.Height = 23;
            this.dvSteelTurn.Size = new System.Drawing.Size(669, 279);
            this.dvSteelTurn.TabIndex = 1;
            this.dvSteelTurn.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvSteelTurn_CellPainting);
            this.dvSteelTurn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            this.dvSteelTurn.CurrentCellDirtyStateChanged += new System.EventHandler(this.dv_CurrentCellDirtyStateChanged);
            // 
            // checkFlagDataGridViewTextBoxColumn4
            // 
            this.checkFlagDataGridViewTextBoxColumn4.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn4.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn4.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn4.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn4.Name = "checkFlagDataGridViewTextBoxColumn4";
            this.checkFlagDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn4.TrueValue = "1";
            // 
            // pREHEATIDDataGridViewTextBoxColumn1
            // 
            this.pREHEATIDDataGridViewTextBoxColumn1.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn1.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn1.Name = "pREHEATIDDataGridViewTextBoxColumn1";
            this.pREHEATIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hEATIDDataGridViewTextBoxColumn1
            // 
            this.hEATIDDataGridViewTextBoxColumn1.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn1.Name = "hEATIDDataGridViewTextBoxColumn1";
            this.hEATIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn1
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn1";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aPPTIMEDataGridViewTextBoxColumn1
            // 
            this.aPPTIMEDataGridViewTextBoxColumn1.DataPropertyName = "APP_TIME";
            this.aPPTIMEDataGridViewTextBoxColumn1.HeaderText = "申请时刻";
            this.aPPTIMEDataGridViewTextBoxColumn1.Name = "aPPTIMEDataGridViewTextBoxColumn1";
            this.aPPTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aPPUNITIDDataGridViewTextBoxColumn1
            // 
            this.aPPUNITIDDataGridViewTextBoxColumn1.DataPropertyName = "APP_UNITID";
            this.aPPUNITIDDataGridViewTextBoxColumn1.HeaderText = "申请工序";
            this.aPPUNITIDDataGridViewTextBoxColumn1.Name = "aPPUNITIDDataGridViewTextBoxColumn1";
            this.aPPUNITIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aPPSTEELWEIGHTDataGridViewTextBoxColumn1
            // 
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1.DataPropertyName = "APP_STEEL_WEIGHT";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1.HeaderText = "申请钢量";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1.Name = "aPPSTEELWEIGHTDataGridViewTextBoxColumn1";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aPPOPERATORDataGridViewTextBoxColumn1
            // 
            this.aPPOPERATORDataGridViewTextBoxColumn1.DataPropertyName = "APP_OPERATOR";
            this.aPPOPERATORDataGridViewTextBoxColumn1.HeaderText = "申请人";
            this.aPPOPERATORDataGridViewTextBoxColumn1.Name = "aPPOPERATORDataGridViewTextBoxColumn1";
            this.aPPOPERATORDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aPPREASONDataGridViewTextBoxColumn1
            // 
            this.aPPREASONDataGridViewTextBoxColumn1.DataPropertyName = "APP_REASON";
            this.aPPREASONDataGridViewTextBoxColumn1.DataSource = this.dsSteelTrunReason;
            this.aPPREASONDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.aPPREASONDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.aPPREASONDataGridViewTextBoxColumn1.HeaderText = "申请原因";
            this.aPPREASONDataGridViewTextBoxColumn1.Name = "aPPREASONDataGridViewTextBoxColumn1";
            this.aPPREASONDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aPPREASONDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPPREASONDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aPPREASONDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelTrunReason
            // 
            this.dsSteelTrunReason.AutoLoad = true;
            this.dsSteelTrunReason.AutoSubscribe = true;
            this.dsSteelTrunReason.DataSetName = "L3DataSet";
            this.dsSteelTrunReason.DeleteMethod = null;
            this.dsSteelTrunReason.InsertMethod = null;
            this.dsSteelTrunReason.L3DataAdapter = this.Adapter;
            this.dsSteelTrunReason.LoadEvent = "Click";
            this.dsSteelTrunReason.LoadTrigger = null;
            this.dsSteelTrunReason.RefreshValve = 1000;
            this.dsSteelTrunReason.SourceCommand = null;
            this.dsSteelTrunReason.SourceCondition = "CODE_GROUP = \'SteelTrunReason\'";
            this.dsSteelTrunReason.SourceMethod = "";
            this.dsSteelTrunReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelTrunReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelTrunReason.SubscribeTarget = null;
            this.dsSteelTrunReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelTrunReason});
            this.dsSteelTrunReason.UpdateEvent = "Click";
            this.dsSteelTrunReason.UpdateMethod = null;
            this.dsSteelTrunReason.UpdateTrigger = null;
            // 
            // schemadsSteelTrunReason
            // 
            this.schemadsSteelTrunReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelTrunReasonL3DataTableCode,
            this.coldsSteelTrunReasonL3DataTableCode_Des});
            this.schemadsSteelTrunReason.TableName = "L3DataTable";
            // 
            // coldsSteelTrunReasonL3DataTableCode
            // 
            this.coldsSteelTrunReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelTrunReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelTrunReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelTrunReasonL3DataTableCode_Des
            // 
            this.coldsSteelTrunReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelTrunReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelTrunReasonL3DataTableCode_Des.Namespace = "";
            // 
            // tURNTIMEDataGridViewTextBoxColumn
            // 
            this.tURNTIMEDataGridViewTextBoxColumn.DataPropertyName = "TURN_TIME";
            this.tURNTIMEDataGridViewTextBoxColumn.HeaderText = "回炉时刻";
            this.tURNTIMEDataGridViewTextBoxColumn.Name = "tURNTIMEDataGridViewTextBoxColumn";
            this.tURNTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tURNOPERATORDataGridViewTextBoxColumn
            // 
            this.tURNOPERATORDataGridViewTextBoxColumn.DataPropertyName = "TURN_OPERATOR";
            this.tURNOPERATORDataGridViewTextBoxColumn.HeaderText = "回炉人";
            this.tURNOPERATORDataGridViewTextBoxColumn.Name = "tURNOPERATORDataGridViewTextBoxColumn";
            this.tURNOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TURN_FLAG
            // 
            this.TURN_FLAG.DataPropertyName = "TURN_FLAG";
            this.TURN_FLAG.HeaderText = "回炉标志";
            this.TURN_FLAG.Name = "TURN_FLAG";
            this.TURN_FLAG.ReadOnly = true;
            // 
            // aLLTURNFLAGDataGridViewTextBoxColumn
            // 
            this.aLLTURNFLAGDataGridViewTextBoxColumn.DataPropertyName = "ALL_TURN_FLAG";
            this.aLLTURNFLAGDataGridViewTextBoxColumn.HeaderText = "全回炉标志";
            this.aLLTURNFLAGDataGridViewTextBoxColumn.Name = "aLLTURNFLAGDataGridViewTextBoxColumn";
            this.aLLTURNFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // oBJECTIDDataGridViewTextBoxColumn1
            // 
            this.oBJECTIDDataGridViewTextBoxColumn1.DataPropertyName = "OBJECTID";
            this.oBJECTIDDataGridViewTextBoxColumn1.HeaderText = "";
            this.oBJECTIDDataGridViewTextBoxColumn1.Name = "oBJECTIDDataGridViewTextBoxColumn1";
            this.oBJECTIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsSteelTurn
            // 
            this.bsSteelTurn.DataMember = "L3DataTable";
            this.bsSteelTurn.DataSource = this.dsSteelTurn;
            // 
            // dsSteelTurn
            // 
            this.dsSteelTurn.AutoLoad = true;
            this.dsSteelTurn.AutoSubscribe = true;
            this.dsSteelTurn.DataSetName = "L3DataSet";
            this.dsSteelTurn.DeleteMethod = "";
            this.dsSteelTurn.InsertMethod = "";
            this.dsSteelTurn.L3DataAdapter = this.Adapter;
            this.dsSteelTurn.LoadEvent = "Click";
            this.dsSteelTurn.LoadTrigger = null;
            this.dsSteelTurn.RefreshValve = 1000;
            this.dsSteelTurn.SourceCommand = null;
            this.dsSteelTurn.SourceCondition = null;
            this.dsSteelTurn.SourceMethod = "GetCurSteelTurnInfor";
            this.dsSteelTurn.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteelTurn.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsSteelTurn.SubscribeTarget = null;
            this.dsSteelTurn.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelTurn});
            this.dsSteelTurn.UpdateEvent = "Click";
            this.dsSteelTurn.UpdateMethod = "";
            this.dsSteelTurn.UpdateTrigger = null;
            // 
            // schemadsSteelTurn
            // 
            this.schemadsSteelTurn.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelTurnL3DataTableGUID,
            this.coldsSteelTurnL3DataTableNAME,
            this.coldsSteelTurnL3DataTableOBJECTID,
            this.coldsSteelTurnL3DataTablePREHEATID,
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX,
            this.coldsSteelTurnL3DataTableHEATID,
            this.coldsSteelTurnL3DataTableAPP_TIME,
            this.coldsSteelTurnL3DataTableAPP_UNITID,
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT,
            this.coldsSteelTurnL3DataTableAPP_OPERATOR,
            this.coldsSteelTurnL3DataTableAPP_REASON,
            this.coldsSteelTurnL3DataTableTURN_TIME,
            this.coldsSteelTurnL3DataTableTURN_OPERATOR,
            this.coldsSteelTurnL3DataTableTURN_FLAG,
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG,
            this.coldsSteelTurnL3DataTableCheckFlag});
            this.schemadsSteelTurn.TableName = "L3DataTable";
            // 
            // coldsSteelTurnL3DataTableGUID
            // 
            this.coldsSteelTurnL3DataTableGUID.Caption = "GUID";
            this.coldsSteelTurnL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelTurnL3DataTableGUID.DefaultValue = "";
            this.coldsSteelTurnL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableNAME
            // 
            this.coldsSteelTurnL3DataTableNAME.Caption = "NAME";
            this.coldsSteelTurnL3DataTableNAME.ColumnName = "NAME";
            this.coldsSteelTurnL3DataTableNAME.DefaultValue = "";
            this.coldsSteelTurnL3DataTableNAME.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableOBJECTID
            // 
            this.coldsSteelTurnL3DataTableOBJECTID.Caption = "OBJECTID";
            this.coldsSteelTurnL3DataTableOBJECTID.ColumnName = "OBJECTID";
            this.coldsSteelTurnL3DataTableOBJECTID.DefaultValue = "";
            this.coldsSteelTurnL3DataTableOBJECTID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTablePREHEATID
            // 
            this.coldsSteelTurnL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsSteelTurnL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsSteelTurnL3DataTablePREHEATID.DefaultValue = "";
            this.coldsSteelTurnL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSteelTurnL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableHEATID
            // 
            this.coldsSteelTurnL3DataTableHEATID.Caption = "HEATID";
            this.coldsSteelTurnL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsSteelTurnL3DataTableHEATID.DefaultValue = "";
            this.coldsSteelTurnL3DataTableHEATID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAPP_TIME
            // 
            this.coldsSteelTurnL3DataTableAPP_TIME.Caption = "APP_TIME";
            this.coldsSteelTurnL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsSteelTurnL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelTurnL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAPP_UNITID
            // 
            this.coldsSteelTurnL3DataTableAPP_UNITID.Caption = "APP_UNITID";
            this.coldsSteelTurnL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsSteelTurnL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsSteelTurnL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT
            // 
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT.Caption = "APP_STEEL_WEIGHT";
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT.ColumnName = "APP_STEEL_WEIGHT";
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT.DataType = typeof(double);
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT.DefaultValue = 0;
            this.coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAPP_OPERATOR
            // 
            this.coldsSteelTurnL3DataTableAPP_OPERATOR.Caption = "APP_OPERATOR";
            this.coldsSteelTurnL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsSteelTurnL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsSteelTurnL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAPP_REASON
            // 
            this.coldsSteelTurnL3DataTableAPP_REASON.Caption = "APP_REASON";
            this.coldsSteelTurnL3DataTableAPP_REASON.ColumnName = "APP_REASON";
            this.coldsSteelTurnL3DataTableAPP_REASON.DefaultValue = "";
            this.coldsSteelTurnL3DataTableAPP_REASON.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTURN_TIME
            // 
            this.coldsSteelTurnL3DataTableTURN_TIME.Caption = "TURN_TIME";
            this.coldsSteelTurnL3DataTableTURN_TIME.ColumnName = "TURN_TIME";
            this.coldsSteelTurnL3DataTableTURN_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelTurnL3DataTableTURN_TIME.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTURN_OPERATOR
            // 
            this.coldsSteelTurnL3DataTableTURN_OPERATOR.Caption = "TURN_OPERATOR";
            this.coldsSteelTurnL3DataTableTURN_OPERATOR.ColumnName = "TURN_OPERATOR";
            this.coldsSteelTurnL3DataTableTURN_OPERATOR.DefaultValue = "";
            this.coldsSteelTurnL3DataTableTURN_OPERATOR.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTURN_FLAG
            // 
            this.coldsSteelTurnL3DataTableTURN_FLAG.Caption = "TURN_FLAG";
            this.coldsSteelTurnL3DataTableTURN_FLAG.ColumnName = "TURN_FLAG";
            this.coldsSteelTurnL3DataTableTURN_FLAG.DataType = typeof(int);
            this.coldsSteelTurnL3DataTableTURN_FLAG.DefaultValue = 0;
            this.coldsSteelTurnL3DataTableTURN_FLAG.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableALL_TURN_FLAG
            // 
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG.Caption = "ALL_TURN_FLAG";
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG.ColumnName = "ALL_TURN_FLAG";
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG.DataType = typeof(int);
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG.DefaultValue = 0;
            this.coldsSteelTurnL3DataTableALL_TURN_FLAG.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableCheckFlag
            // 
            this.coldsSteelTurnL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSteelTurnL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSteelTurnL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSteelTurnL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.bsSteelTurn;
            this.bindingNavigator3.CountItem = this.toolStripLabel3;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator3.Size = new System.Drawing.Size(669, 25);
            this.bindingNavigator3.TabIndex = 0;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "总项数";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一条记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最后一条记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tabSteelBack
            // 
            this.tabSteelBack.Controls.Add(this.hmiRootPanel4);
            this.tabSteelBack.Location = new System.Drawing.Point(4, 21);
            this.tabSteelBack.Name = "tabSteelBack";
            this.tabSteelBack.Size = new System.Drawing.Size(673, 308);
            this.tabSteelBack.TabIndex = 2;
            this.tabSteelBack.Text = "返送申请";
            this.tabSteelBack.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel4
            // 
            this.hmiRootPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel4.Controls.Add(this.dvSteelBack);
            this.hmiRootPanel4.Controls.Add(this.bindingNavigator4);
            this.hmiRootPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel4.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel4.Name = "hmiRootPanel4";
            this.hmiRootPanel4.Size = new System.Drawing.Size(673, 308);
            this.hmiRootPanel4.TabIndex = 1;
            // 
            // dvSteelBack
            // 
            this.dvSteelBack.AllowUserToAddRows = false;
            this.dvSteelBack.AutoGenerateColumns = false;
            this.dvSteelBack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvSteelBack.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteelBack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn2,
            this.pREHEATIDDataGridViewTextBoxColumn2,
            this.hEATIDDataGridViewTextBoxColumn2,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2,
            this.aPPUNITIDDataGridViewTextBoxColumn2,
            this.aPPTIMEDataGridViewTextBoxColumn2,
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2,
            this.aPPOPERATORDataGridViewTextBoxColumn2,
            this.aPPREASONDataGridViewTextBoxColumn2,
            this.bACKUNITIDDataGridViewTextBoxColumn,
            this.bACKTIMEDataGridViewTextBoxColumn,
            this.bACKOPERATORDataGridViewTextBoxColumn,
            this.BACK_FLAG,
            this.nAMEDataGridViewTextBoxColumn2,
            this.oBJECTIDDataGridViewTextBoxColumn2,
            this.gUIDDataGridViewTextBoxColumn2});
            this.dvSteelBack.DataSource = this.bsSteelBack;
            this.dvSteelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelBack.Location = new System.Drawing.Point(0, 25);
            this.dvSteelBack.Name = "dvSteelBack";
            this.dvSteelBack.RowTemplate.Height = 23;
            this.dvSteelBack.Size = new System.Drawing.Size(669, 279);
            this.dvSteelBack.TabIndex = 1;
            this.dvSteelBack.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvSteelBack_CellPainting);
            this.dvSteelBack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            this.dvSteelBack.CurrentCellDirtyStateChanged += new System.EventHandler(this.dv_CurrentCellDirtyStateChanged);
            // 
            // checkFlagDataGridViewTextBoxColumn2
            // 
            this.checkFlagDataGridViewTextBoxColumn2.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn2.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn2.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn2.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn2.Name = "checkFlagDataGridViewTextBoxColumn2";
            this.checkFlagDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn2.TrueValue = "1";
            // 
            // pREHEATIDDataGridViewTextBoxColumn2
            // 
            this.pREHEATIDDataGridViewTextBoxColumn2.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn2.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn2.Name = "pREHEATIDDataGridViewTextBoxColumn2";
            this.pREHEATIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // hEATIDDataGridViewTextBoxColumn2
            // 
            this.hEATIDDataGridViewTextBoxColumn2.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn2.Name = "hEATIDDataGridViewTextBoxColumn2";
            this.hEATIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn2
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn2";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // aPPUNITIDDataGridViewTextBoxColumn2
            // 
            this.aPPUNITIDDataGridViewTextBoxColumn2.DataPropertyName = "APP_UNITID";
            this.aPPUNITIDDataGridViewTextBoxColumn2.HeaderText = "申请工序";
            this.aPPUNITIDDataGridViewTextBoxColumn2.Name = "aPPUNITIDDataGridViewTextBoxColumn2";
            this.aPPUNITIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // aPPTIMEDataGridViewTextBoxColumn2
            // 
            this.aPPTIMEDataGridViewTextBoxColumn2.DataPropertyName = "APP_TIME";
            this.aPPTIMEDataGridViewTextBoxColumn2.HeaderText = "申请时刻";
            this.aPPTIMEDataGridViewTextBoxColumn2.Name = "aPPTIMEDataGridViewTextBoxColumn2";
            this.aPPTIMEDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // aPPSTEELWEIGHTDataGridViewTextBoxColumn2
            // 
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2.DataPropertyName = "APP_STEEL_WEIGHT";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2.HeaderText = "申请钢量";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2.Name = "aPPSTEELWEIGHTDataGridViewTextBoxColumn2";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // aPPOPERATORDataGridViewTextBoxColumn2
            // 
            this.aPPOPERATORDataGridViewTextBoxColumn2.DataPropertyName = "APP_OPERATOR";
            this.aPPOPERATORDataGridViewTextBoxColumn2.HeaderText = "申请人";
            this.aPPOPERATORDataGridViewTextBoxColumn2.Name = "aPPOPERATORDataGridViewTextBoxColumn2";
            this.aPPOPERATORDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // aPPREASONDataGridViewTextBoxColumn2
            // 
            this.aPPREASONDataGridViewTextBoxColumn2.DataPropertyName = "APP_REASON";
            this.aPPREASONDataGridViewTextBoxColumn2.DataSource = this.dsSteelBackReason;
            this.aPPREASONDataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.aPPREASONDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.aPPREASONDataGridViewTextBoxColumn2.HeaderText = "申请原因";
            this.aPPREASONDataGridViewTextBoxColumn2.Name = "aPPREASONDataGridViewTextBoxColumn2";
            this.aPPREASONDataGridViewTextBoxColumn2.ReadOnly = true;
            this.aPPREASONDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPPREASONDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aPPREASONDataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelBackReason
            // 
            this.dsSteelBackReason.AutoLoad = true;
            this.dsSteelBackReason.AutoSubscribe = true;
            this.dsSteelBackReason.DataSetName = "L3DataSet";
            this.dsSteelBackReason.DeleteMethod = null;
            this.dsSteelBackReason.InsertMethod = null;
            this.dsSteelBackReason.L3DataAdapter = this.Adapter;
            this.dsSteelBackReason.LoadEvent = "Click";
            this.dsSteelBackReason.LoadTrigger = null;
            this.dsSteelBackReason.RefreshValve = 1000;
            this.dsSteelBackReason.SourceCommand = null;
            this.dsSteelBackReason.SourceCondition = "CODE_GROUP = \'SteelBackReason\'";
            this.dsSteelBackReason.SourceMethod = "";
            this.dsSteelBackReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelBackReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelBackReason.SubscribeTarget = null;
            this.dsSteelBackReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelBackReason});
            this.dsSteelBackReason.UpdateEvent = "Click";
            this.dsSteelBackReason.UpdateMethod = null;
            this.dsSteelBackReason.UpdateTrigger = null;
            // 
            // schemadsSteelBackReason
            // 
            this.schemadsSteelBackReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelBackReasonL3DataTableCode,
            this.coldsSteelBackReasonL3DataTableCode_Des});
            this.schemadsSteelBackReason.TableName = "L3DataTable";
            // 
            // coldsSteelBackReasonL3DataTableCode
            // 
            this.coldsSteelBackReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelBackReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelBackReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelBackReasonL3DataTableCode_Des
            // 
            this.coldsSteelBackReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelBackReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelBackReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bACKUNITIDDataGridViewTextBoxColumn
            // 
            this.bACKUNITIDDataGridViewTextBoxColumn.DataPropertyName = "BACK_UNITID";
            this.bACKUNITIDDataGridViewTextBoxColumn.HeaderText = "返送工序";
            this.bACKUNITIDDataGridViewTextBoxColumn.Name = "bACKUNITIDDataGridViewTextBoxColumn";
            this.bACKUNITIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bACKTIMEDataGridViewTextBoxColumn
            // 
            this.bACKTIMEDataGridViewTextBoxColumn.DataPropertyName = "BACK_TIME";
            this.bACKTIMEDataGridViewTextBoxColumn.HeaderText = "返送时刻";
            this.bACKTIMEDataGridViewTextBoxColumn.Name = "bACKTIMEDataGridViewTextBoxColumn";
            this.bACKTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bACKOPERATORDataGridViewTextBoxColumn
            // 
            this.bACKOPERATORDataGridViewTextBoxColumn.DataPropertyName = "BACK_OPERATOR";
            this.bACKOPERATORDataGridViewTextBoxColumn.HeaderText = "返送人";
            this.bACKOPERATORDataGridViewTextBoxColumn.Name = "bACKOPERATORDataGridViewTextBoxColumn";
            this.bACKOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BACK_FLAG
            // 
            this.BACK_FLAG.DataPropertyName = "BACK_FLAG";
            this.BACK_FLAG.HeaderText = "返送标志";
            this.BACK_FLAG.Name = "BACK_FLAG";
            this.BACK_FLAG.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn2
            // 
            this.nAMEDataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn2.Name = "nAMEDataGridViewTextBoxColumn2";
            this.nAMEDataGridViewTextBoxColumn2.Visible = false;
            // 
            // oBJECTIDDataGridViewTextBoxColumn2
            // 
            this.oBJECTIDDataGridViewTextBoxColumn2.DataPropertyName = "OBJECTID";
            this.oBJECTIDDataGridViewTextBoxColumn2.HeaderText = "";
            this.oBJECTIDDataGridViewTextBoxColumn2.Name = "oBJECTIDDataGridViewTextBoxColumn2";
            this.oBJECTIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn2
            // 
            this.gUIDDataGridViewTextBoxColumn2.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.Name = "gUIDDataGridViewTextBoxColumn2";
            this.gUIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // bsSteelBack
            // 
            this.bsSteelBack.DataMember = "L3DataTable";
            this.bsSteelBack.DataSource = this.dsSteelBack;
            // 
            // dsSteelBack
            // 
            this.dsSteelBack.AutoLoad = true;
            this.dsSteelBack.AutoSubscribe = true;
            this.dsSteelBack.DataSetName = "L3DataSet";
            this.dsSteelBack.DeleteMethod = "";
            this.dsSteelBack.InsertMethod = "";
            this.dsSteelBack.L3DataAdapter = this.Adapter;
            this.dsSteelBack.LoadEvent = "Click";
            this.dsSteelBack.LoadTrigger = null;
            this.dsSteelBack.RefreshValve = 1000;
            this.dsSteelBack.SourceCommand = null;
            this.dsSteelBack.SourceCondition = null;
            this.dsSteelBack.SourceMethod = "GetCurSteelBackInfor";
            this.dsSteelBack.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteelBack.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsSteelBack.SubscribeTarget = null;
            this.dsSteelBack.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelBack});
            this.dsSteelBack.UpdateEvent = "Click";
            this.dsSteelBack.UpdateMethod = "";
            this.dsSteelBack.UpdateTrigger = null;
            // 
            // schemadsSteelBack
            // 
            this.schemadsSteelBack.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelBackL3DataTableGUID,
            this.coldsSteelBackL3DataTableNAME,
            this.coldsSteelBackL3DataTableOBJECTID,
            this.coldsSteelBackL3DataTablePREHEATID,
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX,
            this.coldsSteelBackL3DataTableHEATID,
            this.coldsSteelBackL3DataTableAPP_UNITID,
            this.coldsSteelBackL3DataTableAPP_TIME,
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT,
            this.coldsSteelBackL3DataTableAPP_OPERATOR,
            this.coldsSteelBackL3DataTableAPP_REASON,
            this.coldsSteelBackL3DataTableBACK_UNITID,
            this.coldsSteelBackL3DataTableBACK_TIME,
            this.coldsSteelBackL3DataTableBACK_OPERATOR,
            this.coldsSteelBackL3DataTableBACK_FLAG,
            this.coldsSteelBackL3DataTableCheckFlag});
            this.schemadsSteelBack.TableName = "L3DataTable";
            // 
            // coldsSteelBackL3DataTableGUID
            // 
            this.coldsSteelBackL3DataTableGUID.Caption = "GUID";
            this.coldsSteelBackL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelBackL3DataTableGUID.DefaultValue = "";
            this.coldsSteelBackL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableNAME
            // 
            this.coldsSteelBackL3DataTableNAME.Caption = "NAME";
            this.coldsSteelBackL3DataTableNAME.ColumnName = "NAME";
            this.coldsSteelBackL3DataTableNAME.DefaultValue = "";
            this.coldsSteelBackL3DataTableNAME.Namespace = "";
            // 
            // coldsSteelBackL3DataTableOBJECTID
            // 
            this.coldsSteelBackL3DataTableOBJECTID.Caption = "OBJECTID";
            this.coldsSteelBackL3DataTableOBJECTID.ColumnName = "OBJECTID";
            this.coldsSteelBackL3DataTableOBJECTID.DefaultValue = "";
            this.coldsSteelBackL3DataTableOBJECTID.Namespace = "";
            // 
            // coldsSteelBackL3DataTablePREHEATID
            // 
            this.coldsSteelBackL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsSteelBackL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsSteelBackL3DataTablePREHEATID.DefaultValue = "";
            this.coldsSteelBackL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSteelBackL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSteelBackL3DataTableHEATID
            // 
            this.coldsSteelBackL3DataTableHEATID.Caption = "HEATID";
            this.coldsSteelBackL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsSteelBackL3DataTableHEATID.DefaultValue = "";
            this.coldsSteelBackL3DataTableHEATID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableAPP_UNITID
            // 
            this.coldsSteelBackL3DataTableAPP_UNITID.Caption = "APP_UNITID";
            this.coldsSteelBackL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsSteelBackL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsSteelBackL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableAPP_TIME
            // 
            this.coldsSteelBackL3DataTableAPP_TIME.Caption = "APP_TIME";
            this.coldsSteelBackL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsSteelBackL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelBackL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsSteelBackL3DataTableAPP_STEEL_WEIGHT
            // 
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT.Caption = "APP_STEEL_WEIGHT";
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT.ColumnName = "APP_STEEL_WEIGHT";
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT.DataType = typeof(double);
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT.DefaultValue = 0;
            this.coldsSteelBackL3DataTableAPP_STEEL_WEIGHT.Namespace = "";
            // 
            // coldsSteelBackL3DataTableAPP_OPERATOR
            // 
            this.coldsSteelBackL3DataTableAPP_OPERATOR.Caption = "APP_OPERATOR";
            this.coldsSteelBackL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsSteelBackL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsSteelBackL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsSteelBackL3DataTableAPP_REASON
            // 
            this.coldsSteelBackL3DataTableAPP_REASON.Caption = "APP_REASON";
            this.coldsSteelBackL3DataTableAPP_REASON.ColumnName = "APP_REASON";
            this.coldsSteelBackL3DataTableAPP_REASON.DefaultValue = "";
            this.coldsSteelBackL3DataTableAPP_REASON.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBACK_UNITID
            // 
            this.coldsSteelBackL3DataTableBACK_UNITID.Caption = "BACK_UNITID";
            this.coldsSteelBackL3DataTableBACK_UNITID.ColumnName = "BACK_UNITID";
            this.coldsSteelBackL3DataTableBACK_UNITID.DefaultValue = "";
            this.coldsSteelBackL3DataTableBACK_UNITID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBACK_TIME
            // 
            this.coldsSteelBackL3DataTableBACK_TIME.Caption = "BACK_TIME";
            this.coldsSteelBackL3DataTableBACK_TIME.ColumnName = "BACK_TIME";
            this.coldsSteelBackL3DataTableBACK_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelBackL3DataTableBACK_TIME.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBACK_OPERATOR
            // 
            this.coldsSteelBackL3DataTableBACK_OPERATOR.Caption = "BACK_OPERATOR";
            this.coldsSteelBackL3DataTableBACK_OPERATOR.ColumnName = "BACK_OPERATOR";
            this.coldsSteelBackL3DataTableBACK_OPERATOR.DefaultValue = "";
            this.coldsSteelBackL3DataTableBACK_OPERATOR.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBACK_FLAG
            // 
            this.coldsSteelBackL3DataTableBACK_FLAG.Caption = "BACK_FLAG";
            this.coldsSteelBackL3DataTableBACK_FLAG.ColumnName = "BACK_FLAG";
            this.coldsSteelBackL3DataTableBACK_FLAG.DataType = typeof(int);
            this.coldsSteelBackL3DataTableBACK_FLAG.DefaultValue = 0;
            this.coldsSteelBackL3DataTableBACK_FLAG.Namespace = "";
            // 
            // coldsSteelBackL3DataTableCheckFlag
            // 
            this.coldsSteelBackL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSteelBackL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSteelBackL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSteelBackL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.BindingSource = this.bsSteelBack;
            this.bindingNavigator4.CountItem = this.toolStripLabel4;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator5,
            this.toolStripTextBox2,
            this.toolStripLabel4,
            this.toolStripSeparator6,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator7});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton7;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton14;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton13;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton8;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator4.Size = new System.Drawing.Size(669, 25);
            this.bindingNavigator4.TabIndex = 0;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到第一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到上一条记录";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "位置";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "当前位置";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "移到下一条记录";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "移到最后一条记录";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tabSteelDiv
            // 
            this.tabSteelDiv.Controls.Add(this.hmiRootPanel5);
            this.tabSteelDiv.Location = new System.Drawing.Point(4, 21);
            this.tabSteelDiv.Name = "tabSteelDiv";
            this.tabSteelDiv.Size = new System.Drawing.Size(673, 308);
            this.tabSteelDiv.TabIndex = 3;
            this.tabSteelDiv.Text = "炉次分割申请";
            this.tabSteelDiv.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel5
            // 
            this.hmiRootPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel5.Controls.Add(this.dvSteelDiv);
            this.hmiRootPanel5.Controls.Add(this.bindingNavigator5);
            this.hmiRootPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel5.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel5.Name = "hmiRootPanel5";
            this.hmiRootPanel5.Size = new System.Drawing.Size(673, 308);
            this.hmiRootPanel5.TabIndex = 1;
            // 
            // dvSteelDiv
            // 
            this.dvSteelDiv.AllowUserToAddRows = false;
            this.dvSteelDiv.AutoGenerateColumns = false;
            this.dvSteelDiv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvSteelDiv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteelDiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn3,
            this.pREHEATIDDataGridViewTextBoxColumn3,
            this.hEATIDDataGridViewTextBoxColumn3,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3,
            this.aPPTIMEDataGridViewTextBoxColumn3,
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn3,
            this.aPPOPERATORDataGridViewTextBoxColumn3,
            this.aPPUNITIDDataGridViewTextBoxColumn3,
            this.dIVUNITIDDataGridViewTextBoxColumn,
            this.dIVTIMEDataGridViewTextBoxColumn,
            this.dIVOPERATORDataGridViewTextBoxColumn,
            this.DIV_FLAG,
            this.aPPREASONDataGridViewTextBoxColumn3,
            this.gUIDDataGridViewTextBoxColumn3,
            this.nAMEDataGridViewTextBoxColumn3,
            this.oBJECTIDDataGridViewTextBoxColumn3});
            this.dvSteelDiv.DataSource = this.bsSteelDiv;
            this.dvSteelDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelDiv.Location = new System.Drawing.Point(0, 25);
            this.dvSteelDiv.Name = "dvSteelDiv";
            this.dvSteelDiv.RowTemplate.Height = 23;
            this.dvSteelDiv.Size = new System.Drawing.Size(669, 279);
            this.dvSteelDiv.TabIndex = 1;
            this.dvSteelDiv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
            // 
            // checkFlagDataGridViewTextBoxColumn3
            // 
            this.checkFlagDataGridViewTextBoxColumn3.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn3.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn3.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn3.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn3.Name = "checkFlagDataGridViewTextBoxColumn3";
            this.checkFlagDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn3.TrueValue = "1";
            // 
            // pREHEATIDDataGridViewTextBoxColumn3
            // 
            this.pREHEATIDDataGridViewTextBoxColumn3.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn3.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn3.Name = "pREHEATIDDataGridViewTextBoxColumn3";
            // 
            // hEATIDDataGridViewTextBoxColumn3
            // 
            this.hEATIDDataGridViewTextBoxColumn3.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn3.Name = "hEATIDDataGridViewTextBoxColumn3";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn3
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn3";
            // 
            // aPPTIMEDataGridViewTextBoxColumn3
            // 
            this.aPPTIMEDataGridViewTextBoxColumn3.DataPropertyName = "APP_TIME";
            this.aPPTIMEDataGridViewTextBoxColumn3.HeaderText = "申请时刻";
            this.aPPTIMEDataGridViewTextBoxColumn3.Name = "aPPTIMEDataGridViewTextBoxColumn3";
            // 
            // aPPSTEELWEIGHTDataGridViewTextBoxColumn3
            // 
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn3.DataPropertyName = "APP_STEEL_WEIGHT";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn3.HeaderText = "申请钢量";
            this.aPPSTEELWEIGHTDataGridViewTextBoxColumn3.Name = "aPPSTEELWEIGHTDataGridViewTextBoxColumn3";
            // 
            // aPPOPERATORDataGridViewTextBoxColumn3
            // 
            this.aPPOPERATORDataGridViewTextBoxColumn3.DataPropertyName = "APP_OPERATOR";
            this.aPPOPERATORDataGridViewTextBoxColumn3.HeaderText = "申请人";
            this.aPPOPERATORDataGridViewTextBoxColumn3.Name = "aPPOPERATORDataGridViewTextBoxColumn3";
            // 
            // aPPUNITIDDataGridViewTextBoxColumn3
            // 
            this.aPPUNITIDDataGridViewTextBoxColumn3.DataPropertyName = "APP_UNITID";
            this.aPPUNITIDDataGridViewTextBoxColumn3.HeaderText = "申请工序";
            this.aPPUNITIDDataGridViewTextBoxColumn3.Name = "aPPUNITIDDataGridViewTextBoxColumn3";
            // 
            // dIVUNITIDDataGridViewTextBoxColumn
            // 
            this.dIVUNITIDDataGridViewTextBoxColumn.DataPropertyName = "DIV_UNITID";
            this.dIVUNITIDDataGridViewTextBoxColumn.HeaderText = "分割工序";
            this.dIVUNITIDDataGridViewTextBoxColumn.Name = "dIVUNITIDDataGridViewTextBoxColumn";
            // 
            // dIVTIMEDataGridViewTextBoxColumn
            // 
            this.dIVTIMEDataGridViewTextBoxColumn.DataPropertyName = "DIV_TIME";
            this.dIVTIMEDataGridViewTextBoxColumn.HeaderText = "分割时刻";
            this.dIVTIMEDataGridViewTextBoxColumn.Name = "dIVTIMEDataGridViewTextBoxColumn";
            // 
            // dIVOPERATORDataGridViewTextBoxColumn
            // 
            this.dIVOPERATORDataGridViewTextBoxColumn.DataPropertyName = "DIV_OPERATOR";
            this.dIVOPERATORDataGridViewTextBoxColumn.HeaderText = "分割人";
            this.dIVOPERATORDataGridViewTextBoxColumn.Name = "dIVOPERATORDataGridViewTextBoxColumn";
            // 
            // DIV_FLAG
            // 
            this.DIV_FLAG.DataPropertyName = "DIV_FLAG";
            this.DIV_FLAG.HeaderText = "分割标志";
            this.DIV_FLAG.Name = "DIV_FLAG";
            // 
            // aPPREASONDataGridViewTextBoxColumn3
            // 
            this.aPPREASONDataGridViewTextBoxColumn3.DataPropertyName = "APP_REASON";
            this.aPPREASONDataGridViewTextBoxColumn3.DataSource = this.dsSteelDivReason;
            this.aPPREASONDataGridViewTextBoxColumn3.DisplayMember = "L3DataTable.Code_Des";
            this.aPPREASONDataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.aPPREASONDataGridViewTextBoxColumn3.HeaderText = "申请原因";
            this.aPPREASONDataGridViewTextBoxColumn3.Name = "aPPREASONDataGridViewTextBoxColumn3";
            this.aPPREASONDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPPREASONDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aPPREASONDataGridViewTextBoxColumn3.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelDivReason
            // 
            this.dsSteelDivReason.AutoLoad = true;
            this.dsSteelDivReason.AutoSubscribe = true;
            this.dsSteelDivReason.DataSetName = "L3DataSet";
            this.dsSteelDivReason.DeleteMethod = null;
            this.dsSteelDivReason.InsertMethod = null;
            this.dsSteelDivReason.L3DataAdapter = this.Adapter;
            this.dsSteelDivReason.LoadEvent = "Click";
            this.dsSteelDivReason.LoadTrigger = null;
            this.dsSteelDivReason.RefreshValve = 1000;
            this.dsSteelDivReason.SourceCommand = null;
            this.dsSteelDivReason.SourceCondition = "CODE_GROUP = \'SteelDivReason\'";
            this.dsSteelDivReason.SourceMethod = "";
            this.dsSteelDivReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelDivReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelDivReason.SubscribeTarget = null;
            this.dsSteelDivReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelDivReason});
            this.dsSteelDivReason.UpdateEvent = "Click";
            this.dsSteelDivReason.UpdateMethod = null;
            this.dsSteelDivReason.UpdateTrigger = null;
            // 
            // schemadsSteelDivReason
            // 
            this.schemadsSteelDivReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelDivReasonL3DataTableCode,
            this.coldsSteelDivReasonL3DataTableCode_Des});
            this.schemadsSteelDivReason.TableName = "L3DataTable";
            // 
            // coldsSteelDivReasonL3DataTableCode
            // 
            this.coldsSteelDivReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelDivReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelDivReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelDivReasonL3DataTableCode_Des
            // 
            this.coldsSteelDivReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelDivReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelDivReasonL3DataTableCode_Des.Namespace = "";
            // 
            // gUIDDataGridViewTextBoxColumn3
            // 
            this.gUIDDataGridViewTextBoxColumn3.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn3.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn3.Name = "gUIDDataGridViewTextBoxColumn3";
            this.gUIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn3
            // 
            this.nAMEDataGridViewTextBoxColumn3.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn3.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn3.Name = "nAMEDataGridViewTextBoxColumn3";
            this.nAMEDataGridViewTextBoxColumn3.Visible = false;
            // 
            // oBJECTIDDataGridViewTextBoxColumn3
            // 
            this.oBJECTIDDataGridViewTextBoxColumn3.DataPropertyName = "OBJECTID";
            this.oBJECTIDDataGridViewTextBoxColumn3.HeaderText = "";
            this.oBJECTIDDataGridViewTextBoxColumn3.Name = "oBJECTIDDataGridViewTextBoxColumn3";
            this.oBJECTIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // bsSteelDiv
            // 
            this.bsSteelDiv.DataMember = "L3DataTable";
            this.bsSteelDiv.DataSource = this.dsSteelDiv;
            // 
            // dsSteelDiv
            // 
            this.dsSteelDiv.AutoLoad = true;
            this.dsSteelDiv.AutoSubscribe = true;
            this.dsSteelDiv.DataSetName = "L3DataSet";
            this.dsSteelDiv.DeleteMethod = "";
            this.dsSteelDiv.InsertMethod = "";
            this.dsSteelDiv.L3DataAdapter = this.Adapter;
            this.dsSteelDiv.LoadEvent = "Click";
            this.dsSteelDiv.LoadTrigger = null;
            this.dsSteelDiv.RefreshValve = 1000;
            this.dsSteelDiv.SourceCommand = null;
            this.dsSteelDiv.SourceCondition = null;
            this.dsSteelDiv.SourceMethod = "GetCurSteelDivInfor";
            this.dsSteelDiv.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteelDiv.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsSteelDiv.SubscribeTarget = null;
            this.dsSteelDiv.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelDiv});
            this.dsSteelDiv.UpdateEvent = "Click";
            this.dsSteelDiv.UpdateMethod = "";
            this.dsSteelDiv.UpdateTrigger = null;
            // 
            // schemadsSteelDiv
            // 
            this.schemadsSteelDiv.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelDivL3DataTableGUID,
            this.coldsSteelDivL3DataTableNAME,
            this.coldsSteelDivL3DataTableOBJECTID,
            this.coldsSteelDivL3DataTablePREHEATID,
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX,
            this.coldsSteelDivL3DataTableHEATID,
            this.coldsSteelDivL3DataTableAPP_TIME,
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT,
            this.coldsSteelDivL3DataTableAPP_OPERATOR,
            this.coldsSteelDivL3DataTableAPP_UNITID,
            this.coldsSteelDivL3DataTableDIV_UNITID,
            this.coldsSteelDivL3DataTableDIV_TIME,
            this.coldsSteelDivL3DataTableDIV_OPERATOR,
            this.coldsSteelDivL3DataTableDIV_FLAG,
            this.coldsSteelDivL3DataTableAPP_REASON,
            this.coldsSteelDivL3DataTableCheckFlag});
            this.schemadsSteelDiv.TableName = "L3DataTable";
            // 
            // coldsSteelDivL3DataTableGUID
            // 
            this.coldsSteelDivL3DataTableGUID.Caption = "GUID";
            this.coldsSteelDivL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelDivL3DataTableGUID.DefaultValue = "";
            this.coldsSteelDivL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelDivL3DataTableNAME
            // 
            this.coldsSteelDivL3DataTableNAME.Caption = "NAME";
            this.coldsSteelDivL3DataTableNAME.ColumnName = "NAME";
            this.coldsSteelDivL3DataTableNAME.DefaultValue = "";
            this.coldsSteelDivL3DataTableNAME.Namespace = "";
            // 
            // coldsSteelDivL3DataTableOBJECTID
            // 
            this.coldsSteelDivL3DataTableOBJECTID.Caption = "OBJECTID";
            this.coldsSteelDivL3DataTableOBJECTID.ColumnName = "OBJECTID";
            this.coldsSteelDivL3DataTableOBJECTID.DefaultValue = "";
            this.coldsSteelDivL3DataTableOBJECTID.Namespace = "";
            // 
            // coldsSteelDivL3DataTablePREHEATID
            // 
            this.coldsSteelDivL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsSteelDivL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsSteelDivL3DataTablePREHEATID.DefaultValue = "";
            this.coldsSteelDivL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsSteelDivL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSteelDivL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSteelDivL3DataTableHEATID
            // 
            this.coldsSteelDivL3DataTableHEATID.Caption = "HEATID";
            this.coldsSteelDivL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsSteelDivL3DataTableHEATID.DefaultValue = "";
            this.coldsSteelDivL3DataTableHEATID.Namespace = "";
            // 
            // coldsSteelDivL3DataTableAPP_TIME
            // 
            this.coldsSteelDivL3DataTableAPP_TIME.Caption = "APP_TIME";
            this.coldsSteelDivL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsSteelDivL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelDivL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsSteelDivL3DataTableAPP_STEEL_WEIGHT
            // 
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT.Caption = "APP_STEEL_WEIGHT";
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT.ColumnName = "APP_STEEL_WEIGHT";
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT.DataType = typeof(double);
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT.DefaultValue = 0;
            this.coldsSteelDivL3DataTableAPP_STEEL_WEIGHT.Namespace = "";
            // 
            // coldsSteelDivL3DataTableAPP_OPERATOR
            // 
            this.coldsSteelDivL3DataTableAPP_OPERATOR.Caption = "APP_OPERATOR";
            this.coldsSteelDivL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsSteelDivL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsSteelDivL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsSteelDivL3DataTableAPP_UNITID
            // 
            this.coldsSteelDivL3DataTableAPP_UNITID.Caption = "APP_UNITID";
            this.coldsSteelDivL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsSteelDivL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsSteelDivL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsSteelDivL3DataTableDIV_UNITID
            // 
            this.coldsSteelDivL3DataTableDIV_UNITID.Caption = "DIV_UNITID";
            this.coldsSteelDivL3DataTableDIV_UNITID.ColumnName = "DIV_UNITID";
            this.coldsSteelDivL3DataTableDIV_UNITID.DefaultValue = "";
            this.coldsSteelDivL3DataTableDIV_UNITID.Namespace = "";
            // 
            // coldsSteelDivL3DataTableDIV_TIME
            // 
            this.coldsSteelDivL3DataTableDIV_TIME.Caption = "DIV_TIME";
            this.coldsSteelDivL3DataTableDIV_TIME.ColumnName = "DIV_TIME";
            this.coldsSteelDivL3DataTableDIV_TIME.DataType = typeof(System.DateTime);
            this.coldsSteelDivL3DataTableDIV_TIME.Namespace = "";
            // 
            // coldsSteelDivL3DataTableDIV_OPERATOR
            // 
            this.coldsSteelDivL3DataTableDIV_OPERATOR.Caption = "DIV_OPERATOR";
            this.coldsSteelDivL3DataTableDIV_OPERATOR.ColumnName = "DIV_OPERATOR";
            this.coldsSteelDivL3DataTableDIV_OPERATOR.DefaultValue = "";
            this.coldsSteelDivL3DataTableDIV_OPERATOR.Namespace = "";
            // 
            // coldsSteelDivL3DataTableDIV_FLAG
            // 
            this.coldsSteelDivL3DataTableDIV_FLAG.Caption = "DIV_FLAG";
            this.coldsSteelDivL3DataTableDIV_FLAG.ColumnName = "DIV_FLAG";
            this.coldsSteelDivL3DataTableDIV_FLAG.DataType = typeof(int);
            this.coldsSteelDivL3DataTableDIV_FLAG.DefaultValue = 0;
            this.coldsSteelDivL3DataTableDIV_FLAG.Namespace = "";
            // 
            // coldsSteelDivL3DataTableAPP_REASON
            // 
            this.coldsSteelDivL3DataTableAPP_REASON.Caption = "APP_REASON";
            this.coldsSteelDivL3DataTableAPP_REASON.ColumnName = "APP_REASON";
            this.coldsSteelDivL3DataTableAPP_REASON.DefaultValue = "";
            this.coldsSteelDivL3DataTableAPP_REASON.Namespace = "";
            // 
            // coldsSteelDivL3DataTableCheckFlag
            // 
            this.coldsSteelDivL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSteelDivL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSteelDivL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSteelDivL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = null;
            this.bindingNavigator5.BindingSource = this.bsSteelDiv;
            this.bindingNavigator5.CountItem = this.toolStripLabel5;
            this.bindingNavigator5.DeleteItem = null;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripSeparator8,
            this.toolStripTextBox3,
            this.toolStripLabel5,
            this.toolStripSeparator9,
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator10});
            this.bindingNavigator5.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator5.MoveFirstItem = this.toolStripButton15;
            this.bindingNavigator5.MoveLastItem = this.toolStripButton18;
            this.bindingNavigator5.MoveNextItem = this.toolStripButton17;
            this.bindingNavigator5.MovePreviousItem = this.toolStripButton16;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator5.Size = new System.Drawing.Size(669, 25);
            this.bindingNavigator5.TabIndex = 0;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "/ {0}";
            this.toolStripLabel5.ToolTipText = "总项数";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "移到第一条记录";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "移到上一条记录";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "位置";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "当前位置";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "移到下一条记录";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "移到最后一条记录";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // dsExchangeSend
            // 
            this.dsExchangeSend.AutoLoad = true;
            this.dsExchangeSend.AutoSubscribe = true;
            this.dsExchangeSend.DataSetName = "L3DataSet";
            this.dsExchangeSend.DeleteMethod = null;
            this.dsExchangeSend.InsertMethod = null;
            this.dsExchangeSend.L3DataAdapter = null;
            this.dsExchangeSend.LoadEvent = "Click";
            this.dsExchangeSend.LoadTrigger = null;
            this.dsExchangeSend.RefreshValve = 1000;
            this.dsExchangeSend.SourceCommand = null;
            this.dsExchangeSend.SourceCondition = "";
            this.dsExchangeSend.SourceMethod = "";
            this.dsExchangeSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsExchangeSend.SourceURI = "";
            this.dsExchangeSend.SubscribeTarget = "";
            this.dsExchangeSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExchangeSend});
            this.dsExchangeSend.UpdateEvent = "Click";
            this.dsExchangeSend.UpdateMethod = null;
            this.dsExchangeSend.UpdateTrigger = null;
            // 
            // schemadsExchangeSend
            // 
            this.schemadsExchangeSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExchangeSendL3DataTableGUID,
            this.coldsExchangeSendL3DataTableName,
            this.coldsExchangeSendL3DataTableObjectID,
            this.coldsExchangeSendL3DataTablePreHeatID,
            this.coldsExchangeSendL3DataTableSteelGradeIndex,
            this.coldsExchangeSendL3DataTableHeatID,
            this.coldsExchangeSendL3DataTableApp_UnitID,
            this.coldsExchangeSendL3DataTableApp_Time,
            this.coldsExchangeSendL3DataTableApp_Steel_Weight,
            this.coldsExchangeSendL3DataTableApp_Operator,
            this.coldsExchangeSendL3DataTableApp_Reason,
            this.coldsExchangeSendL3DataTableEx_Time,
            this.coldsExchangeSendL3DataTableEx_Operator,
            this.coldsExchangeSendL3DataTableEx_Flag,
            this.coldsExchangeSendL3DataTableEx_SteelGradeIndex});
            this.schemadsExchangeSend.TableName = "L3DataTable";
            // 
            // coldsExchangeSendL3DataTableGUID
            // 
            this.coldsExchangeSendL3DataTableGUID.Caption = "GUID";
            this.coldsExchangeSendL3DataTableGUID.ColumnName = "GUID";
            this.coldsExchangeSendL3DataTableGUID.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableName
            // 
            this.coldsExchangeSendL3DataTableName.Caption = "Name";
            this.coldsExchangeSendL3DataTableName.ColumnName = "Name";
            this.coldsExchangeSendL3DataTableName.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableObjectID
            // 
            this.coldsExchangeSendL3DataTableObjectID.Caption = "ObjectID";
            this.coldsExchangeSendL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsExchangeSendL3DataTableObjectID.Namespace = "";
            // 
            // coldsExchangeSendL3DataTablePreHeatID
            // 
            this.coldsExchangeSendL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsExchangeSendL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsExchangeSendL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableSteelGradeIndex
            // 
            this.coldsExchangeSendL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsExchangeSendL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsExchangeSendL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableHeatID
            // 
            this.coldsExchangeSendL3DataTableHeatID.Caption = "HeatID";
            this.coldsExchangeSendL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsExchangeSendL3DataTableHeatID.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableApp_UnitID
            // 
            this.coldsExchangeSendL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsExchangeSendL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsExchangeSendL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableApp_Time
            // 
            this.coldsExchangeSendL3DataTableApp_Time.Caption = "App_Time";
            this.coldsExchangeSendL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsExchangeSendL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsExchangeSendL3DataTableApp_Time.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableApp_Steel_Weight
            // 
            this.coldsExchangeSendL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsExchangeSendL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsExchangeSendL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsExchangeSendL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableApp_Operator
            // 
            this.coldsExchangeSendL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsExchangeSendL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsExchangeSendL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableApp_Reason
            // 
            this.coldsExchangeSendL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsExchangeSendL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsExchangeSendL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableEx_Time
            // 
            this.coldsExchangeSendL3DataTableEx_Time.Caption = "Ex_Time";
            this.coldsExchangeSendL3DataTableEx_Time.ColumnName = "Ex_Time";
            this.coldsExchangeSendL3DataTableEx_Time.DataType = typeof(System.DateTime);
            this.coldsExchangeSendL3DataTableEx_Time.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableEx_Operator
            // 
            this.coldsExchangeSendL3DataTableEx_Operator.Caption = "Ex_Operator";
            this.coldsExchangeSendL3DataTableEx_Operator.ColumnName = "Ex_Operator";
            this.coldsExchangeSendL3DataTableEx_Operator.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableEx_Flag
            // 
            this.coldsExchangeSendL3DataTableEx_Flag.Caption = "Ex_Flag";
            this.coldsExchangeSendL3DataTableEx_Flag.ColumnName = "Ex_Flag";
            this.coldsExchangeSendL3DataTableEx_Flag.DataType = typeof(int);
            this.coldsExchangeSendL3DataTableEx_Flag.Namespace = "";
            // 
            // coldsExchangeSendL3DataTableEx_SteelGradeIndex
            // 
            this.coldsExchangeSendL3DataTableEx_SteelGradeIndex.Caption = "Ex_SteelGradeIndex";
            this.coldsExchangeSendL3DataTableEx_SteelGradeIndex.ColumnName = "Ex_SteelGradeIndex";
            this.coldsExchangeSendL3DataTableEx_SteelGradeIndex.Namespace = "";
            // 
            // dsTurnSend
            // 
            this.dsTurnSend.AutoLoad = true;
            this.dsTurnSend.AutoSubscribe = true;
            this.dsTurnSend.DataSetName = "L3DataSet";
            this.dsTurnSend.DeleteMethod = null;
            this.dsTurnSend.InsertMethod = null;
            this.dsTurnSend.L3DataAdapter = null;
            this.dsTurnSend.LoadEvent = "Click";
            this.dsTurnSend.LoadTrigger = null;
            this.dsTurnSend.RefreshValve = 1000;
            this.dsTurnSend.SourceCommand = null;
            this.dsTurnSend.SourceCondition = "";
            this.dsTurnSend.SourceMethod = "";
            this.dsTurnSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTurnSend.SourceURI = "";
            this.dsTurnSend.SubscribeTarget = "";
            this.dsTurnSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTurnSend});
            this.dsTurnSend.UpdateEvent = "Click";
            this.dsTurnSend.UpdateMethod = null;
            this.dsTurnSend.UpdateTrigger = null;
            // 
            // schemadsTurnSend
            // 
            this.schemadsTurnSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTurnSendL3DataTableGUID,
            this.coldsTurnSendL3DataTableName,
            this.coldsTurnSendL3DataTableObjectID,
            this.coldsTurnSendL3DataTablePreHeatID,
            this.coldsTurnSendL3DataTableSteelGradeIndex,
            this.coldsTurnSendL3DataTableHeatID,
            this.coldsTurnSendL3DataTableApp_Time,
            this.coldsTurnSendL3DataTableApp_UnitID,
            this.coldsTurnSendL3DataTableApp_Steel_Weight,
            this.coldsTurnSendL3DataTableApp_Operator,
            this.coldsTurnSendL3DataTableApp_Reason,
            this.coldsTurnSendL3DataTableTurn_Time,
            this.coldsTurnSendL3DataTableTurn_Operator,
            this.coldsTurnSendL3DataTableTurn_Flag,
            this.coldsTurnSendL3DataTableAll_Turn_Flag});
            this.schemadsTurnSend.TableName = "L3DataTable";
            // 
            // coldsTurnSendL3DataTableGUID
            // 
            this.coldsTurnSendL3DataTableGUID.Caption = "GUID";
            this.coldsTurnSendL3DataTableGUID.ColumnName = "GUID";
            this.coldsTurnSendL3DataTableGUID.Namespace = "";
            // 
            // coldsTurnSendL3DataTableName
            // 
            this.coldsTurnSendL3DataTableName.Caption = "Name";
            this.coldsTurnSendL3DataTableName.ColumnName = "Name";
            this.coldsTurnSendL3DataTableName.Namespace = "";
            // 
            // coldsTurnSendL3DataTableObjectID
            // 
            this.coldsTurnSendL3DataTableObjectID.Caption = "ObjectID";
            this.coldsTurnSendL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsTurnSendL3DataTableObjectID.Namespace = "";
            // 
            // coldsTurnSendL3DataTablePreHeatID
            // 
            this.coldsTurnSendL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsTurnSendL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsTurnSendL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsTurnSendL3DataTableSteelGradeIndex
            // 
            this.coldsTurnSendL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsTurnSendL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsTurnSendL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsTurnSendL3DataTableHeatID
            // 
            this.coldsTurnSendL3DataTableHeatID.Caption = "HeatID";
            this.coldsTurnSendL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTurnSendL3DataTableHeatID.Namespace = "";
            // 
            // coldsTurnSendL3DataTableApp_Time
            // 
            this.coldsTurnSendL3DataTableApp_Time.Caption = "App_Time";
            this.coldsTurnSendL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsTurnSendL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsTurnSendL3DataTableApp_Time.Namespace = "";
            // 
            // coldsTurnSendL3DataTableApp_UnitID
            // 
            this.coldsTurnSendL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsTurnSendL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsTurnSendL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsTurnSendL3DataTableApp_Steel_Weight
            // 
            this.coldsTurnSendL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsTurnSendL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsTurnSendL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsTurnSendL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsTurnSendL3DataTableApp_Operator
            // 
            this.coldsTurnSendL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsTurnSendL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsTurnSendL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsTurnSendL3DataTableApp_Reason
            // 
            this.coldsTurnSendL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsTurnSendL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsTurnSendL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsTurnSendL3DataTableTurn_Time
            // 
            this.coldsTurnSendL3DataTableTurn_Time.Caption = "Turn_Time";
            this.coldsTurnSendL3DataTableTurn_Time.ColumnName = "Turn_Time";
            this.coldsTurnSendL3DataTableTurn_Time.DataType = typeof(System.DateTime);
            this.coldsTurnSendL3DataTableTurn_Time.Namespace = "";
            // 
            // coldsTurnSendL3DataTableTurn_Operator
            // 
            this.coldsTurnSendL3DataTableTurn_Operator.Caption = "Turn_Operator";
            this.coldsTurnSendL3DataTableTurn_Operator.ColumnName = "Turn_Operator";
            this.coldsTurnSendL3DataTableTurn_Operator.Namespace = "";
            // 
            // coldsTurnSendL3DataTableTurn_Flag
            // 
            this.coldsTurnSendL3DataTableTurn_Flag.Caption = "Turn_Flag";
            this.coldsTurnSendL3DataTableTurn_Flag.ColumnName = "Turn_Flag";
            this.coldsTurnSendL3DataTableTurn_Flag.DataType = typeof(int);
            this.coldsTurnSendL3DataTableTurn_Flag.Namespace = "";
            // 
            // coldsTurnSendL3DataTableAll_Turn_Flag
            // 
            this.coldsTurnSendL3DataTableAll_Turn_Flag.Caption = "All_Turn_Flag";
            this.coldsTurnSendL3DataTableAll_Turn_Flag.ColumnName = "All_Turn_Flag";
            this.coldsTurnSendL3DataTableAll_Turn_Flag.DataType = typeof(int);
            this.coldsTurnSendL3DataTableAll_Turn_Flag.Namespace = "";
            // 
            // dsBackSend
            // 
            this.dsBackSend.AutoLoad = true;
            this.dsBackSend.AutoSubscribe = true;
            this.dsBackSend.DataSetName = "L3DataSet";
            this.dsBackSend.DeleteMethod = null;
            this.dsBackSend.InsertMethod = null;
            this.dsBackSend.L3DataAdapter = null;
            this.dsBackSend.LoadEvent = "Click";
            this.dsBackSend.LoadTrigger = null;
            this.dsBackSend.RefreshValve = 1000;
            this.dsBackSend.SourceCommand = null;
            this.dsBackSend.SourceCondition = "";
            this.dsBackSend.SourceMethod = "";
            this.dsBackSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBackSend.SourceURI = "";
            this.dsBackSend.SubscribeTarget = "";
            this.dsBackSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBackSend});
            this.dsBackSend.UpdateEvent = "Click";
            this.dsBackSend.UpdateMethod = null;
            this.dsBackSend.UpdateTrigger = null;
            // 
            // schemadsBackSend
            // 
            this.schemadsBackSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBackSendL3DataTableGUID,
            this.coldsBackSendL3DataTableName,
            this.coldsBackSendL3DataTableObjectID,
            this.coldsBackSendL3DataTablePreHeatID,
            this.coldsBackSendL3DataTableSteelGradeIndex,
            this.coldsBackSendL3DataTableHeatID,
            this.coldsBackSendL3DataTableApp_UnitID,
            this.coldsBackSendL3DataTableApp_Time,
            this.coldsBackSendL3DataTableApp_Steel_Weight,
            this.coldsBackSendL3DataTableApp_Operator,
            this.coldsBackSendL3DataTableApp_Reason,
            this.coldsBackSendL3DataTableBack_UnitID,
            this.coldsBackSendL3DataTableBack_Time,
            this.coldsBackSendL3DataTableBack_Operator,
            this.coldsBackSendL3DataTableBack_Flag});
            this.schemadsBackSend.TableName = "L3DataTable";
            // 
            // coldsBackSendL3DataTableGUID
            // 
            this.coldsBackSendL3DataTableGUID.Caption = "GUID";
            this.coldsBackSendL3DataTableGUID.ColumnName = "GUID";
            this.coldsBackSendL3DataTableGUID.Namespace = "";
            // 
            // coldsBackSendL3DataTableName
            // 
            this.coldsBackSendL3DataTableName.Caption = "Name";
            this.coldsBackSendL3DataTableName.ColumnName = "Name";
            this.coldsBackSendL3DataTableName.Namespace = "";
            // 
            // coldsBackSendL3DataTableObjectID
            // 
            this.coldsBackSendL3DataTableObjectID.Caption = "ObjectID";
            this.coldsBackSendL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsBackSendL3DataTableObjectID.Namespace = "";
            // 
            // coldsBackSendL3DataTablePreHeatID
            // 
            this.coldsBackSendL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsBackSendL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsBackSendL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsBackSendL3DataTableSteelGradeIndex
            // 
            this.coldsBackSendL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBackSendL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBackSendL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBackSendL3DataTableHeatID
            // 
            this.coldsBackSendL3DataTableHeatID.Caption = "HeatID";
            this.coldsBackSendL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBackSendL3DataTableHeatID.Namespace = "";
            // 
            // coldsBackSendL3DataTableApp_UnitID
            // 
            this.coldsBackSendL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsBackSendL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsBackSendL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsBackSendL3DataTableApp_Time
            // 
            this.coldsBackSendL3DataTableApp_Time.Caption = "App_Time";
            this.coldsBackSendL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsBackSendL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsBackSendL3DataTableApp_Time.Namespace = "";
            // 
            // coldsBackSendL3DataTableApp_Steel_Weight
            // 
            this.coldsBackSendL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsBackSendL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsBackSendL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsBackSendL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsBackSendL3DataTableApp_Operator
            // 
            this.coldsBackSendL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsBackSendL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsBackSendL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsBackSendL3DataTableApp_Reason
            // 
            this.coldsBackSendL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsBackSendL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsBackSendL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsBackSendL3DataTableBack_UnitID
            // 
            this.coldsBackSendL3DataTableBack_UnitID.Caption = "Back_UnitID";
            this.coldsBackSendL3DataTableBack_UnitID.ColumnName = "Back_UnitID";
            this.coldsBackSendL3DataTableBack_UnitID.Namespace = "";
            // 
            // coldsBackSendL3DataTableBack_Time
            // 
            this.coldsBackSendL3DataTableBack_Time.Caption = "Back_Time";
            this.coldsBackSendL3DataTableBack_Time.ColumnName = "Back_Time";
            this.coldsBackSendL3DataTableBack_Time.DataType = typeof(System.DateTime);
            this.coldsBackSendL3DataTableBack_Time.Namespace = "";
            // 
            // coldsBackSendL3DataTableBack_Operator
            // 
            this.coldsBackSendL3DataTableBack_Operator.Caption = "Back_Operator";
            this.coldsBackSendL3DataTableBack_Operator.ColumnName = "Back_Operator";
            this.coldsBackSendL3DataTableBack_Operator.Namespace = "";
            // 
            // coldsBackSendL3DataTableBack_Flag
            // 
            this.coldsBackSendL3DataTableBack_Flag.Caption = "Back_Flag";
            this.coldsBackSendL3DataTableBack_Flag.ColumnName = "Back_Flag";
            this.coldsBackSendL3DataTableBack_Flag.DataType = typeof(int);
            this.coldsBackSendL3DataTableBack_Flag.Namespace = "";
            // 
            // dsDivSend
            // 
            this.dsDivSend.AutoLoad = true;
            this.dsDivSend.AutoSubscribe = true;
            this.dsDivSend.DataSetName = "L3DataSet";
            this.dsDivSend.DeleteMethod = null;
            this.dsDivSend.InsertMethod = null;
            this.dsDivSend.L3DataAdapter = null;
            this.dsDivSend.LoadEvent = "Click";
            this.dsDivSend.LoadTrigger = null;
            this.dsDivSend.RefreshValve = 1000;
            this.dsDivSend.SourceCommand = null;
            this.dsDivSend.SourceCondition = "";
            this.dsDivSend.SourceMethod = "";
            this.dsDivSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsDivSend.SourceURI = "";
            this.dsDivSend.SubscribeTarget = "";
            this.dsDivSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDivSend});
            this.dsDivSend.UpdateEvent = "Click";
            this.dsDivSend.UpdateMethod = null;
            this.dsDivSend.UpdateTrigger = null;
            // 
            // schemadsDivSend
            // 
            this.schemadsDivSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDivSendL3DataTableGUID,
            this.coldsDivSendL3DataTableName,
            this.coldsDivSendL3DataTableObjectID,
            this.coldsDivSendL3DataTablePreHeatID,
            this.coldsDivSendL3DataTableSteelGradeIndex,
            this.coldsDivSendL3DataTableHeatID,
            this.coldsDivSendL3DataTableApp_Time,
            this.coldsDivSendL3DataTableApp_Steel_Weight,
            this.coldsDivSendL3DataTableApp_Operator,
            this.coldsDivSendL3DataTableApp_UnitID,
            this.coldsDivSendL3DataTableDiv_UnitID,
            this.coldsDivSendL3DataTableDiv_Time,
            this.coldsDivSendL3DataTableDiv_Operator,
            this.coldsDivSendL3DataTableDiv_Flag,
            this.coldsDivSendL3DataTableApp_Reason});
            this.schemadsDivSend.TableName = "L3DataTable";
            // 
            // coldsDivSendL3DataTableGUID
            // 
            this.coldsDivSendL3DataTableGUID.Caption = "GUID";
            this.coldsDivSendL3DataTableGUID.ColumnName = "GUID";
            this.coldsDivSendL3DataTableGUID.Namespace = "";
            // 
            // coldsDivSendL3DataTableName
            // 
            this.coldsDivSendL3DataTableName.Caption = "Name";
            this.coldsDivSendL3DataTableName.ColumnName = "Name";
            this.coldsDivSendL3DataTableName.Namespace = "";
            // 
            // coldsDivSendL3DataTableObjectID
            // 
            this.coldsDivSendL3DataTableObjectID.Caption = "ObjectID";
            this.coldsDivSendL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsDivSendL3DataTableObjectID.Namespace = "";
            // 
            // coldsDivSendL3DataTablePreHeatID
            // 
            this.coldsDivSendL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsDivSendL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsDivSendL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsDivSendL3DataTableSteelGradeIndex
            // 
            this.coldsDivSendL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsDivSendL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsDivSendL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsDivSendL3DataTableHeatID
            // 
            this.coldsDivSendL3DataTableHeatID.Caption = "HeatID";
            this.coldsDivSendL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsDivSendL3DataTableHeatID.Namespace = "";
            // 
            // coldsDivSendL3DataTableApp_Time
            // 
            this.coldsDivSendL3DataTableApp_Time.Caption = "App_Time";
            this.coldsDivSendL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsDivSendL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsDivSendL3DataTableApp_Time.Namespace = "";
            // 
            // coldsDivSendL3DataTableApp_Steel_Weight
            // 
            this.coldsDivSendL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsDivSendL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsDivSendL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsDivSendL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsDivSendL3DataTableApp_Operator
            // 
            this.coldsDivSendL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsDivSendL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsDivSendL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsDivSendL3DataTableApp_UnitID
            // 
            this.coldsDivSendL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsDivSendL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsDivSendL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsDivSendL3DataTableDiv_UnitID
            // 
            this.coldsDivSendL3DataTableDiv_UnitID.Caption = "Div_UnitID";
            this.coldsDivSendL3DataTableDiv_UnitID.ColumnName = "Div_UnitID";
            this.coldsDivSendL3DataTableDiv_UnitID.Namespace = "";
            // 
            // coldsDivSendL3DataTableDiv_Time
            // 
            this.coldsDivSendL3DataTableDiv_Time.Caption = "Div_Time";
            this.coldsDivSendL3DataTableDiv_Time.ColumnName = "Div_Time";
            this.coldsDivSendL3DataTableDiv_Time.DataType = typeof(System.DateTime);
            this.coldsDivSendL3DataTableDiv_Time.Namespace = "";
            // 
            // coldsDivSendL3DataTableDiv_Operator
            // 
            this.coldsDivSendL3DataTableDiv_Operator.Caption = "Div_Operator";
            this.coldsDivSendL3DataTableDiv_Operator.ColumnName = "Div_Operator";
            this.coldsDivSendL3DataTableDiv_Operator.Namespace = "";
            // 
            // coldsDivSendL3DataTableDiv_Flag
            // 
            this.coldsDivSendL3DataTableDiv_Flag.Caption = "Div_Flag";
            this.coldsDivSendL3DataTableDiv_Flag.ColumnName = "Div_Flag";
            this.coldsDivSendL3DataTableDiv_Flag.DataType = typeof(int);
            this.coldsDivSendL3DataTableDiv_Flag.Namespace = "";
            // 
            // coldsDivSendL3DataTableApp_Reason
            // 
            this.coldsDivSendL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsDivSendL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsDivSendL3DataTableApp_Reason.Namespace = "";
            // 
            // dsElement
            // 
            this.dsElement.AutoLoad = true;
            this.dsElement.AutoSubscribe = true;
            this.dsElement.DataSetName = "L3DataSet";
            this.dsElement.DeleteMethod = null;
            this.dsElement.InsertMethod = null;
            this.dsElement.L3DataAdapter = null;
            this.dsElement.LoadEvent = "Click";
            this.dsElement.LoadTrigger = null;
            this.dsElement.RefreshValve = 1000;
            this.dsElement.SourceCommand = null;
            this.dsElement.SourceCondition = null;
            this.dsElement.SourceMethod = "";
            this.dsElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsElement.SourceURI = "XGMESLogic\\QualityMag\\CQA_Lab_Element";
            this.dsElement.SubscribeTarget = null;
            this.dsElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsElementStd});
            this.dsElement.UpdateEvent = "Click";
            this.dsElement.UpdateMethod = null;
            this.dsElement.UpdateTrigger = null;
            // 
            // schemadsElementStd
            // 
            this.schemadsElementStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsElementStdL3DataTableGUID,
            this.coldsElementStdL3DataTableName,
            this.coldsElementStdL3DataTableAppID,
            this.coldsElementStdL3DataTableSample_Code,
            this.coldsElementStdL3DataTableArrive_Date,
            this.coldsElementStdL3DataTableReport_Date,
            this.coldsElementStdL3DataTableHeatID,
            this.coldsElementStdL3DataTableUnitTypeID,
            this.coldsElementStdL3DataTableUnitID,
            this.coldsElementStdL3DataTableSample_Address,
            this.coldsElementStdL3DataTableSample_Type,
            this.coldsElementStdL3DataTableSample_Count,
            this.coldsElementStdL3DataTableC,
            this.coldsElementStdL3DataTableSi,
            this.coldsElementStdL3DataTableMn,
            this.coldsElementStdL3DataTableP,
            this.coldsElementStdL3DataTableS,
            this.coldsElementStdL3DataTableCu,
            this.coldsElementStdL3DataTableNi,
            this.coldsElementStdL3DataTableCr,
            this.coldsElementStdL3DataTableMo,
            this.coldsElementStdL3DataTableV,
            this.coldsElementStdL3DataTableNb,
            this.coldsElementStdL3DataTableAl,
            this.coldsElementStdL3DataTableAlS,
            this.coldsElementStdL3DataTableTi,
            this.coldsElementStdL3DataTableB,
            this.coldsElementStdL3DataTableSb,
            this.coldsElementStdL3DataTableAs,
            this.coldsElementStdL3DataTableSn,
            this.coldsElementStdL3DataTableZn,
            this.coldsElementStdL3DataTableCa,
            this.coldsElementStdL3DataTableW,
            this.coldsElementStdL3DataTablePb,
            this.coldsElementStdL3DataTableRe,
            this.coldsElementStdL3DataTableCeq,
            this.coldsElementStdL3DataTableN,
            this.coldsElementStdL3DataTableH,
            this.coldsElementStdL3DataTableO,
            this.coldsElementStdL3DataTableOther1,
            this.coldsElementStdL3DataTableOther2,
            this.coldsElementStdL3DataTableLogTime,
            this.coldsElementStdL3DataTableDataLogMode});
            this.schemadsElementStd.TableName = "L3DataTable";
            // 
            // coldsElementStdL3DataTableGUID
            // 
            this.coldsElementStdL3DataTableGUID.Caption = "GUID";
            this.coldsElementStdL3DataTableGUID.ColumnName = "GUID";
            this.coldsElementStdL3DataTableGUID.Namespace = "";
            // 
            // coldsElementStdL3DataTableName
            // 
            this.coldsElementStdL3DataTableName.Caption = "Name";
            this.coldsElementStdL3DataTableName.ColumnName = "Name";
            this.coldsElementStdL3DataTableName.Namespace = "";
            // 
            // coldsElementStdL3DataTableAppID
            // 
            this.coldsElementStdL3DataTableAppID.Caption = "AppID";
            this.coldsElementStdL3DataTableAppID.ColumnName = "AppID";
            this.coldsElementStdL3DataTableAppID.Namespace = "";
            // 
            // coldsElementStdL3DataTableSample_Code
            // 
            this.coldsElementStdL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsElementStdL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsElementStdL3DataTableSample_Code.Namespace = "";
            // 
            // coldsElementStdL3DataTableArrive_Date
            // 
            this.coldsElementStdL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsElementStdL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsElementStdL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsElementStdL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsElementStdL3DataTableReport_Date
            // 
            this.coldsElementStdL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsElementStdL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsElementStdL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsElementStdL3DataTableReport_Date.Namespace = "";
            // 
            // coldsElementStdL3DataTableHeatID
            // 
            this.coldsElementStdL3DataTableHeatID.Caption = "HeatID";
            this.coldsElementStdL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsElementStdL3DataTableHeatID.Namespace = "";
            // 
            // coldsElementStdL3DataTableUnitTypeID
            // 
            this.coldsElementStdL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsElementStdL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsElementStdL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsElementStdL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsElementStdL3DataTableUnitID
            // 
            this.coldsElementStdL3DataTableUnitID.Caption = "UnitID";
            this.coldsElementStdL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsElementStdL3DataTableUnitID.DataType = typeof(int);
            this.coldsElementStdL3DataTableUnitID.Namespace = "";
            // 
            // coldsElementStdL3DataTableSample_Address
            // 
            this.coldsElementStdL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsElementStdL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsElementStdL3DataTableSample_Address.Namespace = "";
            // 
            // coldsElementStdL3DataTableSample_Type
            // 
            this.coldsElementStdL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsElementStdL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsElementStdL3DataTableSample_Type.Namespace = "";
            // 
            // coldsElementStdL3DataTableSample_Count
            // 
            this.coldsElementStdL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsElementStdL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsElementStdL3DataTableSample_Count.Namespace = "";
            // 
            // coldsElementStdL3DataTableC
            // 
            this.coldsElementStdL3DataTableC.Caption = "C";
            this.coldsElementStdL3DataTableC.ColumnName = "C";
            this.coldsElementStdL3DataTableC.DataType = typeof(double);
            this.coldsElementStdL3DataTableC.Namespace = "";
            // 
            // coldsElementStdL3DataTableSi
            // 
            this.coldsElementStdL3DataTableSi.Caption = "Si";
            this.coldsElementStdL3DataTableSi.ColumnName = "Si";
            this.coldsElementStdL3DataTableSi.DataType = typeof(double);
            this.coldsElementStdL3DataTableSi.Namespace = "";
            // 
            // coldsElementStdL3DataTableMn
            // 
            this.coldsElementStdL3DataTableMn.Caption = "Mn";
            this.coldsElementStdL3DataTableMn.ColumnName = "Mn";
            this.coldsElementStdL3DataTableMn.DataType = typeof(double);
            this.coldsElementStdL3DataTableMn.Namespace = "";
            // 
            // coldsElementStdL3DataTableP
            // 
            this.coldsElementStdL3DataTableP.Caption = "P";
            this.coldsElementStdL3DataTableP.ColumnName = "P";
            this.coldsElementStdL3DataTableP.DataType = typeof(double);
            this.coldsElementStdL3DataTableP.Namespace = "";
            // 
            // coldsElementStdL3DataTableS
            // 
            this.coldsElementStdL3DataTableS.Caption = "S";
            this.coldsElementStdL3DataTableS.ColumnName = "S";
            this.coldsElementStdL3DataTableS.DataType = typeof(double);
            this.coldsElementStdL3DataTableS.Namespace = "";
            // 
            // coldsElementStdL3DataTableCu
            // 
            this.coldsElementStdL3DataTableCu.Caption = "Cu";
            this.coldsElementStdL3DataTableCu.ColumnName = "Cu";
            this.coldsElementStdL3DataTableCu.DataType = typeof(double);
            this.coldsElementStdL3DataTableCu.Namespace = "";
            // 
            // coldsElementStdL3DataTableNi
            // 
            this.coldsElementStdL3DataTableNi.Caption = "Ni";
            this.coldsElementStdL3DataTableNi.ColumnName = "Ni";
            this.coldsElementStdL3DataTableNi.DataType = typeof(double);
            this.coldsElementStdL3DataTableNi.Namespace = "";
            // 
            // coldsElementStdL3DataTableCr
            // 
            this.coldsElementStdL3DataTableCr.Caption = "Cr";
            this.coldsElementStdL3DataTableCr.ColumnName = "Cr";
            this.coldsElementStdL3DataTableCr.DataType = typeof(double);
            this.coldsElementStdL3DataTableCr.Namespace = "";
            // 
            // coldsElementStdL3DataTableMo
            // 
            this.coldsElementStdL3DataTableMo.Caption = "Mo";
            this.coldsElementStdL3DataTableMo.ColumnName = "Mo";
            this.coldsElementStdL3DataTableMo.DataType = typeof(double);
            this.coldsElementStdL3DataTableMo.Namespace = "";
            // 
            // coldsElementStdL3DataTableV
            // 
            this.coldsElementStdL3DataTableV.Caption = "V";
            this.coldsElementStdL3DataTableV.ColumnName = "V";
            this.coldsElementStdL3DataTableV.DataType = typeof(double);
            this.coldsElementStdL3DataTableV.Namespace = "";
            // 
            // coldsElementStdL3DataTableNb
            // 
            this.coldsElementStdL3DataTableNb.Caption = "Nb";
            this.coldsElementStdL3DataTableNb.ColumnName = "Nb";
            this.coldsElementStdL3DataTableNb.DataType = typeof(double);
            this.coldsElementStdL3DataTableNb.Namespace = "";
            // 
            // coldsElementStdL3DataTableAl
            // 
            this.coldsElementStdL3DataTableAl.Caption = "Al";
            this.coldsElementStdL3DataTableAl.ColumnName = "Al";
            this.coldsElementStdL3DataTableAl.DataType = typeof(double);
            this.coldsElementStdL3DataTableAl.Namespace = "";
            // 
            // coldsElementStdL3DataTableAlS
            // 
            this.coldsElementStdL3DataTableAlS.Caption = "AlS";
            this.coldsElementStdL3DataTableAlS.ColumnName = "AlS";
            this.coldsElementStdL3DataTableAlS.DataType = typeof(double);
            this.coldsElementStdL3DataTableAlS.Namespace = "";
            // 
            // coldsElementStdL3DataTableTi
            // 
            this.coldsElementStdL3DataTableTi.Caption = "Ti";
            this.coldsElementStdL3DataTableTi.ColumnName = "Ti";
            this.coldsElementStdL3DataTableTi.DataType = typeof(double);
            this.coldsElementStdL3DataTableTi.Namespace = "";
            // 
            // coldsElementStdL3DataTableB
            // 
            this.coldsElementStdL3DataTableB.Caption = "B";
            this.coldsElementStdL3DataTableB.ColumnName = "B";
            this.coldsElementStdL3DataTableB.DataType = typeof(double);
            this.coldsElementStdL3DataTableB.Namespace = "";
            // 
            // coldsElementStdL3DataTableSb
            // 
            this.coldsElementStdL3DataTableSb.Caption = "Sb";
            this.coldsElementStdL3DataTableSb.ColumnName = "Sb";
            this.coldsElementStdL3DataTableSb.DataType = typeof(double);
            this.coldsElementStdL3DataTableSb.Namespace = "";
            // 
            // coldsElementStdL3DataTableAs
            // 
            this.coldsElementStdL3DataTableAs.Caption = "As";
            this.coldsElementStdL3DataTableAs.ColumnName = "As";
            this.coldsElementStdL3DataTableAs.DataType = typeof(double);
            this.coldsElementStdL3DataTableAs.Namespace = "";
            // 
            // coldsElementStdL3DataTableSn
            // 
            this.coldsElementStdL3DataTableSn.Caption = "Sn";
            this.coldsElementStdL3DataTableSn.ColumnName = "Sn";
            this.coldsElementStdL3DataTableSn.DataType = typeof(double);
            this.coldsElementStdL3DataTableSn.Namespace = "";
            // 
            // coldsElementStdL3DataTableZn
            // 
            this.coldsElementStdL3DataTableZn.Caption = "Zn";
            this.coldsElementStdL3DataTableZn.ColumnName = "Zn";
            this.coldsElementStdL3DataTableZn.DataType = typeof(double);
            this.coldsElementStdL3DataTableZn.Namespace = "";
            // 
            // coldsElementStdL3DataTableCa
            // 
            this.coldsElementStdL3DataTableCa.Caption = "Ca";
            this.coldsElementStdL3DataTableCa.ColumnName = "Ca";
            this.coldsElementStdL3DataTableCa.DataType = typeof(double);
            this.coldsElementStdL3DataTableCa.Namespace = "";
            // 
            // coldsElementStdL3DataTableW
            // 
            this.coldsElementStdL3DataTableW.Caption = "W";
            this.coldsElementStdL3DataTableW.ColumnName = "W";
            this.coldsElementStdL3DataTableW.DataType = typeof(double);
            this.coldsElementStdL3DataTableW.Namespace = "";
            // 
            // coldsElementStdL3DataTablePb
            // 
            this.coldsElementStdL3DataTablePb.Caption = "Pb";
            this.coldsElementStdL3DataTablePb.ColumnName = "Pb";
            this.coldsElementStdL3DataTablePb.DataType = typeof(double);
            this.coldsElementStdL3DataTablePb.Namespace = "";
            // 
            // coldsElementStdL3DataTableRe
            // 
            this.coldsElementStdL3DataTableRe.Caption = "Re";
            this.coldsElementStdL3DataTableRe.ColumnName = "Re";
            this.coldsElementStdL3DataTableRe.DataType = typeof(double);
            this.coldsElementStdL3DataTableRe.Namespace = "";
            // 
            // coldsElementStdL3DataTableCeq
            // 
            this.coldsElementStdL3DataTableCeq.Caption = "Ceq";
            this.coldsElementStdL3DataTableCeq.ColumnName = "Ceq";
            this.coldsElementStdL3DataTableCeq.DataType = typeof(double);
            this.coldsElementStdL3DataTableCeq.Namespace = "";
            // 
            // coldsElementStdL3DataTableN
            // 
            this.coldsElementStdL3DataTableN.Caption = "N";
            this.coldsElementStdL3DataTableN.ColumnName = "N";
            this.coldsElementStdL3DataTableN.DataType = typeof(double);
            this.coldsElementStdL3DataTableN.Namespace = "";
            // 
            // coldsElementStdL3DataTableH
            // 
            this.coldsElementStdL3DataTableH.Caption = "H";
            this.coldsElementStdL3DataTableH.ColumnName = "H";
            this.coldsElementStdL3DataTableH.DataType = typeof(double);
            this.coldsElementStdL3DataTableH.Namespace = "";
            // 
            // coldsElementStdL3DataTableO
            // 
            this.coldsElementStdL3DataTableO.Caption = "O";
            this.coldsElementStdL3DataTableO.ColumnName = "O";
            this.coldsElementStdL3DataTableO.DataType = typeof(double);
            this.coldsElementStdL3DataTableO.Namespace = "";
            // 
            // coldsElementStdL3DataTableOther1
            // 
            this.coldsElementStdL3DataTableOther1.Caption = "Other1";
            this.coldsElementStdL3DataTableOther1.ColumnName = "Other1";
            this.coldsElementStdL3DataTableOther1.DataType = typeof(double);
            this.coldsElementStdL3DataTableOther1.Namespace = "";
            // 
            // coldsElementStdL3DataTableOther2
            // 
            this.coldsElementStdL3DataTableOther2.Caption = "Other2";
            this.coldsElementStdL3DataTableOther2.ColumnName = "Other2";
            this.coldsElementStdL3DataTableOther2.DataType = typeof(double);
            this.coldsElementStdL3DataTableOther2.Namespace = "";
            // 
            // coldsElementStdL3DataTableLogTime
            // 
            this.coldsElementStdL3DataTableLogTime.Caption = "LogTime";
            this.coldsElementStdL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsElementStdL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsElementStdL3DataTableLogTime.Namespace = "";
            // 
            // coldsElementStdL3DataTableDataLogMode
            // 
            this.coldsElementStdL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsElementStdL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsElementStdL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsElementStdL3DataTableDataLogMode.Namespace = "";
            // 
            // dsEleStd
            // 
            this.dsEleStd.AutoLoad = true;
            this.dsEleStd.AutoSubscribe = true;
            this.dsEleStd.DataSetName = "L3DataSet";
            this.dsEleStd.DeleteMethod = null;
            this.dsEleStd.InsertMethod = null;
            this.dsEleStd.L3DataAdapter = null;
            this.dsEleStd.LoadEvent = "Click";
            this.dsEleStd.LoadTrigger = null;
            this.dsEleStd.RefreshValve = 1000;
            this.dsEleStd.SourceCommand = null;
            this.dsEleStd.SourceCondition = null;
            this.dsEleStd.SourceMethod = "";
            this.dsEleStd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsEleStd.SourceURI = "XGMESLogic\\QualityMag\\CQA_Product_Sheet";
            this.dsEleStd.SubscribeTarget = null;
            this.dsEleStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEleStd});
            this.dsEleStd.UpdateEvent = "Click";
            this.dsEleStd.UpdateMethod = null;
            this.dsEleStd.UpdateTrigger = null;
            // 
            // schemadsEleStd
            // 
            this.schemadsEleStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEleStdL3DataTableGUID,
            this.coldsEleStdL3DataTableName,
            this.coldsEleStdL3DataTableSteelGradeIndex,
            this.coldsEleStdL3DataTableLadle_Brick,
            this.coldsEleStdL3DataTableLadle_Use,
            this.coldsEleStdL3DataTableLadle_Pre_SteelGrade,
            this.coldsEleStdL3DataTableLadle_Stay,
            this.coldsEleStdL3DataTableBOF_Type,
            this.coldsEleStdL3DataTableLadle_Tapped_Proc,
            this.coldsEleStdL3DataTableLF_Type,
            this.coldsEleStdL3DataTableRH_Type,
            this.coldsEleStdL3DataTableCaster_Type,
            this.coldsEleStdL3DataTableHot_Send_Flag,
            this.coldsEleStdL3DataTableC_Min,
            this.coldsEleStdL3DataTableC_Aim,
            this.coldsEleStdL3DataTableC_Max,
            this.coldsEleStdL3DataTableSi_Min,
            this.coldsEleStdL3DataTableSi_Aim,
            this.coldsEleStdL3DataTableSi_Max,
            this.coldsEleStdL3DataTableMn_Min,
            this.coldsEleStdL3DataTableMn_Aim,
            this.coldsEleStdL3DataTableMn_Max,
            this.coldsEleStdL3DataTableP_Min,
            this.coldsEleStdL3DataTableP_Aim,
            this.coldsEleStdL3DataTableP_Max,
            this.coldsEleStdL3DataTableS_Min,
            this.coldsEleStdL3DataTableS_Aim,
            this.coldsEleStdL3DataTableS_Max,
            this.coldsEleStdL3DataTableCu_Min,
            this.coldsEleStdL3DataTableCu_Aim,
            this.coldsEleStdL3DataTableCu_Max,
            this.coldsEleStdL3DataTableNi_Min,
            this.coldsEleStdL3DataTableNi_Aim,
            this.coldsEleStdL3DataTableNi_Max,
            this.coldsEleStdL3DataTableCr_Min,
            this.coldsEleStdL3DataTableCr_Aim,
            this.coldsEleStdL3DataTableCr_Max,
            this.coldsEleStdL3DataTableMo_Min,
            this.coldsEleStdL3DataTableMo_Aim,
            this.coldsEleStdL3DataTableMo_Max,
            this.coldsEleStdL3DataTableV_Min,
            this.coldsEleStdL3DataTableV_Aim,
            this.coldsEleStdL3DataTableV_Max,
            this.coldsEleStdL3DataTableNb_Min,
            this.coldsEleStdL3DataTableNb_Aim,
            this.coldsEleStdL3DataTableNb_Max,
            this.coldsEleStdL3DataTableAl_Min,
            this.coldsEleStdL3DataTableAl_Aim,
            this.coldsEleStdL3DataTableAl_Max,
            this.coldsEleStdL3DataTableAlS_Min,
            this.coldsEleStdL3DataTableAlS_Aim,
            this.coldsEleStdL3DataTableAlS_Max,
            this.coldsEleStdL3DataTableTi_Min,
            this.coldsEleStdL3DataTableTi_Aim,
            this.coldsEleStdL3DataTableTi_Max,
            this.coldsEleStdL3DataTableB_Min,
            this.coldsEleStdL3DataTableB_Aim,
            this.coldsEleStdL3DataTableB_Max,
            this.coldsEleStdL3DataTableSb_Min,
            this.coldsEleStdL3DataTableSb_Aim,
            this.coldsEleStdL3DataTableSb_Max,
            this.coldsEleStdL3DataTableSn_Min,
            this.coldsEleStdL3DataTableSn_Aim,
            this.coldsEleStdL3DataTableSn_Max,
            this.coldsEleStdL3DataTableAs_Min,
            this.coldsEleStdL3DataTableAs_Aim,
            this.coldsEleStdL3DataTableAs_Max,
            this.coldsEleStdL3DataTableZn_Min,
            this.coldsEleStdL3DataTableZn_Aim,
            this.coldsEleStdL3DataTableZn_Max,
            this.coldsEleStdL3DataTableZr_Min,
            this.coldsEleStdL3DataTableZr_Aim,
            this.coldsEleStdL3DataTableZr_Max,
            this.coldsEleStdL3DataTableCa_Min,
            this.coldsEleStdL3DataTableCa_Aim,
            this.coldsEleStdL3DataTableCa_Max,
            this.coldsEleStdL3DataTableW_Min,
            this.coldsEleStdL3DataTableW_Aim,
            this.coldsEleStdL3DataTableW_Max,
            this.coldsEleStdL3DataTablePb_Min,
            this.coldsEleStdL3DataTablePb_Aim,
            this.coldsEleStdL3DataTablePb_Max,
            this.coldsEleStdL3DataTableRe_Min,
            this.coldsEleStdL3DataTableRe_Aim,
            this.coldsEleStdL3DataTableRe_Max,
            this.coldsEleStdL3DataTableCeq_Min,
            this.coldsEleStdL3DataTableCeq_Aim,
            this.coldsEleStdL3DataTableCeq_Max,
            this.coldsEleStdL3DataTableN_Min,
            this.coldsEleStdL3DataTableN_Aim,
            this.coldsEleStdL3DataTableN_Max,
            this.coldsEleStdL3DataTableH_Min,
            this.coldsEleStdL3DataTableH_Aim,
            this.coldsEleStdL3DataTableH_Max,
            this.coldsEleStdL3DataTableO_Min,
            this.coldsEleStdL3DataTableO_Aim,
            this.coldsEleStdL3DataTableO_Max,
            this.coldsEleStdL3DataTableOther1_Min,
            this.coldsEleStdL3DataTableOther1_Aim,
            this.coldsEleStdL3DataTableOther1_Max,
            this.coldsEleStdL3DataTableOther2_Min,
            this.coldsEleStdL3DataTableOther2_Aim,
            this.coldsEleStdL3DataTableOther2_Max});
            this.schemadsEleStd.TableName = "L3DataTable";
            // 
            // coldsEleStdL3DataTableGUID
            // 
            this.coldsEleStdL3DataTableGUID.Caption = "GUID";
            this.coldsEleStdL3DataTableGUID.ColumnName = "GUID";
            this.coldsEleStdL3DataTableGUID.Namespace = "";
            // 
            // coldsEleStdL3DataTableName
            // 
            this.coldsEleStdL3DataTableName.Caption = "Name";
            this.coldsEleStdL3DataTableName.ColumnName = "Name";
            this.coldsEleStdL3DataTableName.Namespace = "";
            // 
            // coldsEleStdL3DataTableSteelGradeIndex
            // 
            this.coldsEleStdL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsEleStdL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsEleStdL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsEleStdL3DataTableLadle_Brick
            // 
            this.coldsEleStdL3DataTableLadle_Brick.Caption = "Ladle_Brick";
            this.coldsEleStdL3DataTableLadle_Brick.ColumnName = "Ladle_Brick";
            this.coldsEleStdL3DataTableLadle_Brick.Namespace = "";
            // 
            // coldsEleStdL3DataTableLadle_Use
            // 
            this.coldsEleStdL3DataTableLadle_Use.Caption = "Ladle_Use";
            this.coldsEleStdL3DataTableLadle_Use.ColumnName = "Ladle_Use";
            this.coldsEleStdL3DataTableLadle_Use.Namespace = "";
            // 
            // coldsEleStdL3DataTableLadle_Pre_SteelGrade
            // 
            this.coldsEleStdL3DataTableLadle_Pre_SteelGrade.Caption = "Ladle_Pre_SteelGrade";
            this.coldsEleStdL3DataTableLadle_Pre_SteelGrade.ColumnName = "Ladle_Pre_SteelGrade";
            this.coldsEleStdL3DataTableLadle_Pre_SteelGrade.Namespace = "";
            // 
            // coldsEleStdL3DataTableLadle_Stay
            // 
            this.coldsEleStdL3DataTableLadle_Stay.Caption = "Ladle_Stay";
            this.coldsEleStdL3DataTableLadle_Stay.ColumnName = "Ladle_Stay";
            this.coldsEleStdL3DataTableLadle_Stay.Namespace = "";
            // 
            // coldsEleStdL3DataTableBOF_Type
            // 
            this.coldsEleStdL3DataTableBOF_Type.Caption = "BOF_Type";
            this.coldsEleStdL3DataTableBOF_Type.ColumnName = "BOF_Type";
            this.coldsEleStdL3DataTableBOF_Type.Namespace = "";
            // 
            // coldsEleStdL3DataTableLadle_Tapped_Proc
            // 
            this.coldsEleStdL3DataTableLadle_Tapped_Proc.Caption = "Ladle_Tapped_Proc";
            this.coldsEleStdL3DataTableLadle_Tapped_Proc.ColumnName = "Ladle_Tapped_Proc";
            this.coldsEleStdL3DataTableLadle_Tapped_Proc.Namespace = "";
            // 
            // coldsEleStdL3DataTableLF_Type
            // 
            this.coldsEleStdL3DataTableLF_Type.Caption = "LF_Type";
            this.coldsEleStdL3DataTableLF_Type.ColumnName = "LF_Type";
            this.coldsEleStdL3DataTableLF_Type.Namespace = "";
            // 
            // coldsEleStdL3DataTableRH_Type
            // 
            this.coldsEleStdL3DataTableRH_Type.Caption = "RH_Type";
            this.coldsEleStdL3DataTableRH_Type.ColumnName = "RH_Type";
            this.coldsEleStdL3DataTableRH_Type.Namespace = "";
            // 
            // coldsEleStdL3DataTableCaster_Type
            // 
            this.coldsEleStdL3DataTableCaster_Type.Caption = "Caster_Type";
            this.coldsEleStdL3DataTableCaster_Type.ColumnName = "Caster_Type";
            this.coldsEleStdL3DataTableCaster_Type.Namespace = "";
            // 
            // coldsEleStdL3DataTableHot_Send_Flag
            // 
            this.coldsEleStdL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsEleStdL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsEleStdL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsEleStdL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsEleStdL3DataTableC_Min
            // 
            this.coldsEleStdL3DataTableC_Min.Caption = "C_Min";
            this.coldsEleStdL3DataTableC_Min.ColumnName = "C_Min";
            this.coldsEleStdL3DataTableC_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableC_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableC_Aim
            // 
            this.coldsEleStdL3DataTableC_Aim.Caption = "C_Aim";
            this.coldsEleStdL3DataTableC_Aim.ColumnName = "C_Aim";
            this.coldsEleStdL3DataTableC_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableC_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableC_Max
            // 
            this.coldsEleStdL3DataTableC_Max.Caption = "C_Max";
            this.coldsEleStdL3DataTableC_Max.ColumnName = "C_Max";
            this.coldsEleStdL3DataTableC_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableC_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableSi_Min
            // 
            this.coldsEleStdL3DataTableSi_Min.Caption = "Si_Min";
            this.coldsEleStdL3DataTableSi_Min.ColumnName = "Si_Min";
            this.coldsEleStdL3DataTableSi_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableSi_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableSi_Aim
            // 
            this.coldsEleStdL3DataTableSi_Aim.Caption = "Si_Aim";
            this.coldsEleStdL3DataTableSi_Aim.ColumnName = "Si_Aim";
            this.coldsEleStdL3DataTableSi_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableSi_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableSi_Max
            // 
            this.coldsEleStdL3DataTableSi_Max.Caption = "Si_Max";
            this.coldsEleStdL3DataTableSi_Max.ColumnName = "Si_Max";
            this.coldsEleStdL3DataTableSi_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableSi_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableMn_Min
            // 
            this.coldsEleStdL3DataTableMn_Min.Caption = "Mn_Min";
            this.coldsEleStdL3DataTableMn_Min.ColumnName = "Mn_Min";
            this.coldsEleStdL3DataTableMn_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableMn_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableMn_Aim
            // 
            this.coldsEleStdL3DataTableMn_Aim.Caption = "Mn_Aim";
            this.coldsEleStdL3DataTableMn_Aim.ColumnName = "Mn_Aim";
            this.coldsEleStdL3DataTableMn_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableMn_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableMn_Max
            // 
            this.coldsEleStdL3DataTableMn_Max.Caption = "Mn_Max";
            this.coldsEleStdL3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coldsEleStdL3DataTableMn_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableMn_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableP_Min
            // 
            this.coldsEleStdL3DataTableP_Min.Caption = "P_Min";
            this.coldsEleStdL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsEleStdL3DataTableP_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableP_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableP_Aim
            // 
            this.coldsEleStdL3DataTableP_Aim.Caption = "P_Aim";
            this.coldsEleStdL3DataTableP_Aim.ColumnName = "P_Aim";
            this.coldsEleStdL3DataTableP_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableP_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableP_Max
            // 
            this.coldsEleStdL3DataTableP_Max.Caption = "P_Max";
            this.coldsEleStdL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsEleStdL3DataTableP_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableP_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableS_Min
            // 
            this.coldsEleStdL3DataTableS_Min.Caption = "S_Min";
            this.coldsEleStdL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsEleStdL3DataTableS_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableS_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableS_Aim
            // 
            this.coldsEleStdL3DataTableS_Aim.Caption = "S_Aim";
            this.coldsEleStdL3DataTableS_Aim.ColumnName = "S_Aim";
            this.coldsEleStdL3DataTableS_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableS_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableS_Max
            // 
            this.coldsEleStdL3DataTableS_Max.Caption = "S_Max";
            this.coldsEleStdL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsEleStdL3DataTableS_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableS_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableCu_Min
            // 
            this.coldsEleStdL3DataTableCu_Min.Caption = "Cu_Min";
            this.coldsEleStdL3DataTableCu_Min.ColumnName = "Cu_Min";
            this.coldsEleStdL3DataTableCu_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableCu_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableCu_Aim
            // 
            this.coldsEleStdL3DataTableCu_Aim.Caption = "Cu_Aim";
            this.coldsEleStdL3DataTableCu_Aim.ColumnName = "Cu_Aim";
            this.coldsEleStdL3DataTableCu_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableCu_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableCu_Max
            // 
            this.coldsEleStdL3DataTableCu_Max.Caption = "Cu_Max";
            this.coldsEleStdL3DataTableCu_Max.ColumnName = "Cu_Max";
            this.coldsEleStdL3DataTableCu_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableCu_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableNi_Min
            // 
            this.coldsEleStdL3DataTableNi_Min.Caption = "Ni_Min";
            this.coldsEleStdL3DataTableNi_Min.ColumnName = "Ni_Min";
            this.coldsEleStdL3DataTableNi_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableNi_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableNi_Aim
            // 
            this.coldsEleStdL3DataTableNi_Aim.Caption = "Ni_Aim";
            this.coldsEleStdL3DataTableNi_Aim.ColumnName = "Ni_Aim";
            this.coldsEleStdL3DataTableNi_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableNi_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableNi_Max
            // 
            this.coldsEleStdL3DataTableNi_Max.Caption = "Ni_Max";
            this.coldsEleStdL3DataTableNi_Max.ColumnName = "Ni_Max";
            this.coldsEleStdL3DataTableNi_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableNi_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableCr_Min
            // 
            this.coldsEleStdL3DataTableCr_Min.Caption = "Cr_Min";
            this.coldsEleStdL3DataTableCr_Min.ColumnName = "Cr_Min";
            this.coldsEleStdL3DataTableCr_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableCr_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableCr_Aim
            // 
            this.coldsEleStdL3DataTableCr_Aim.Caption = "Cr_Aim";
            this.coldsEleStdL3DataTableCr_Aim.ColumnName = "Cr_Aim";
            this.coldsEleStdL3DataTableCr_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableCr_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableCr_Max
            // 
            this.coldsEleStdL3DataTableCr_Max.Caption = "Cr_Max";
            this.coldsEleStdL3DataTableCr_Max.ColumnName = "Cr_Max";
            this.coldsEleStdL3DataTableCr_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableCr_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableMo_Min
            // 
            this.coldsEleStdL3DataTableMo_Min.Caption = "Mo_Min";
            this.coldsEleStdL3DataTableMo_Min.ColumnName = "Mo_Min";
            this.coldsEleStdL3DataTableMo_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableMo_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableMo_Aim
            // 
            this.coldsEleStdL3DataTableMo_Aim.Caption = "Mo_Aim";
            this.coldsEleStdL3DataTableMo_Aim.ColumnName = "Mo_Aim";
            this.coldsEleStdL3DataTableMo_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableMo_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableMo_Max
            // 
            this.coldsEleStdL3DataTableMo_Max.Caption = "Mo_Max";
            this.coldsEleStdL3DataTableMo_Max.ColumnName = "Mo_Max";
            this.coldsEleStdL3DataTableMo_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableMo_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableV_Min
            // 
            this.coldsEleStdL3DataTableV_Min.Caption = "V_Min";
            this.coldsEleStdL3DataTableV_Min.ColumnName = "V_Min";
            this.coldsEleStdL3DataTableV_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableV_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableV_Aim
            // 
            this.coldsEleStdL3DataTableV_Aim.Caption = "V_Aim";
            this.coldsEleStdL3DataTableV_Aim.ColumnName = "V_Aim";
            this.coldsEleStdL3DataTableV_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableV_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableV_Max
            // 
            this.coldsEleStdL3DataTableV_Max.Caption = "V_Max";
            this.coldsEleStdL3DataTableV_Max.ColumnName = "V_Max";
            this.coldsEleStdL3DataTableV_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableV_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableNb_Min
            // 
            this.coldsEleStdL3DataTableNb_Min.Caption = "Nb_Min";
            this.coldsEleStdL3DataTableNb_Min.ColumnName = "Nb_Min";
            this.coldsEleStdL3DataTableNb_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableNb_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableNb_Aim
            // 
            this.coldsEleStdL3DataTableNb_Aim.Caption = "Nb_Aim";
            this.coldsEleStdL3DataTableNb_Aim.ColumnName = "Nb_Aim";
            this.coldsEleStdL3DataTableNb_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableNb_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableNb_Max
            // 
            this.coldsEleStdL3DataTableNb_Max.Caption = "Nb_Max";
            this.coldsEleStdL3DataTableNb_Max.ColumnName = "Nb_Max";
            this.coldsEleStdL3DataTableNb_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableNb_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableAl_Min
            // 
            this.coldsEleStdL3DataTableAl_Min.Caption = "Al_Min";
            this.coldsEleStdL3DataTableAl_Min.ColumnName = "Al_Min";
            this.coldsEleStdL3DataTableAl_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableAl_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableAl_Aim
            // 
            this.coldsEleStdL3DataTableAl_Aim.Caption = "Al_Aim";
            this.coldsEleStdL3DataTableAl_Aim.ColumnName = "Al_Aim";
            this.coldsEleStdL3DataTableAl_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableAl_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableAl_Max
            // 
            this.coldsEleStdL3DataTableAl_Max.Caption = "Al_Max";
            this.coldsEleStdL3DataTableAl_Max.ColumnName = "Al_Max";
            this.coldsEleStdL3DataTableAl_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableAl_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableAlS_Min
            // 
            this.coldsEleStdL3DataTableAlS_Min.Caption = "AlS_Min";
            this.coldsEleStdL3DataTableAlS_Min.ColumnName = "AlS_Min";
            this.coldsEleStdL3DataTableAlS_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableAlS_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableAlS_Aim
            // 
            this.coldsEleStdL3DataTableAlS_Aim.Caption = "AlS_Aim";
            this.coldsEleStdL3DataTableAlS_Aim.ColumnName = "AlS_Aim";
            this.coldsEleStdL3DataTableAlS_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableAlS_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableAlS_Max
            // 
            this.coldsEleStdL3DataTableAlS_Max.Caption = "AlS_Max";
            this.coldsEleStdL3DataTableAlS_Max.ColumnName = "AlS_Max";
            this.coldsEleStdL3DataTableAlS_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableAlS_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableTi_Min
            // 
            this.coldsEleStdL3DataTableTi_Min.Caption = "Ti_Min";
            this.coldsEleStdL3DataTableTi_Min.ColumnName = "Ti_Min";
            this.coldsEleStdL3DataTableTi_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableTi_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableTi_Aim
            // 
            this.coldsEleStdL3DataTableTi_Aim.Caption = "Ti_Aim";
            this.coldsEleStdL3DataTableTi_Aim.ColumnName = "Ti_Aim";
            this.coldsEleStdL3DataTableTi_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableTi_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableTi_Max
            // 
            this.coldsEleStdL3DataTableTi_Max.Caption = "Ti_Max";
            this.coldsEleStdL3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coldsEleStdL3DataTableTi_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableTi_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableB_Min
            // 
            this.coldsEleStdL3DataTableB_Min.Caption = "B_Min";
            this.coldsEleStdL3DataTableB_Min.ColumnName = "B_Min";
            this.coldsEleStdL3DataTableB_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableB_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableB_Aim
            // 
            this.coldsEleStdL3DataTableB_Aim.Caption = "B_Aim";
            this.coldsEleStdL3DataTableB_Aim.ColumnName = "B_Aim";
            this.coldsEleStdL3DataTableB_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableB_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableB_Max
            // 
            this.coldsEleStdL3DataTableB_Max.Caption = "B_Max";
            this.coldsEleStdL3DataTableB_Max.ColumnName = "B_Max";
            this.coldsEleStdL3DataTableB_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableB_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableSb_Min
            // 
            this.coldsEleStdL3DataTableSb_Min.Caption = "Sb_Min";
            this.coldsEleStdL3DataTableSb_Min.ColumnName = "Sb_Min";
            this.coldsEleStdL3DataTableSb_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableSb_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableSb_Aim
            // 
            this.coldsEleStdL3DataTableSb_Aim.Caption = "Sb_Aim";
            this.coldsEleStdL3DataTableSb_Aim.ColumnName = "Sb_Aim";
            this.coldsEleStdL3DataTableSb_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableSb_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableSb_Max
            // 
            this.coldsEleStdL3DataTableSb_Max.Caption = "Sb_Max";
            this.coldsEleStdL3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coldsEleStdL3DataTableSb_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableSb_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableSn_Min
            // 
            this.coldsEleStdL3DataTableSn_Min.Caption = "Sn_Min";
            this.coldsEleStdL3DataTableSn_Min.ColumnName = "Sn_Min";
            this.coldsEleStdL3DataTableSn_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableSn_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableSn_Aim
            // 
            this.coldsEleStdL3DataTableSn_Aim.Caption = "Sn_Aim";
            this.coldsEleStdL3DataTableSn_Aim.ColumnName = "Sn_Aim";
            this.coldsEleStdL3DataTableSn_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableSn_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableSn_Max
            // 
            this.coldsEleStdL3DataTableSn_Max.Caption = "Sn_Max";
            this.coldsEleStdL3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coldsEleStdL3DataTableSn_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableSn_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableAs_Min
            // 
            this.coldsEleStdL3DataTableAs_Min.Caption = "As_Min";
            this.coldsEleStdL3DataTableAs_Min.ColumnName = "As_Min";
            this.coldsEleStdL3DataTableAs_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableAs_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableAs_Aim
            // 
            this.coldsEleStdL3DataTableAs_Aim.Caption = "As_Aim";
            this.coldsEleStdL3DataTableAs_Aim.ColumnName = "As_Aim";
            this.coldsEleStdL3DataTableAs_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableAs_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableAs_Max
            // 
            this.coldsEleStdL3DataTableAs_Max.Caption = "As_Max";
            this.coldsEleStdL3DataTableAs_Max.ColumnName = "As_Max";
            this.coldsEleStdL3DataTableAs_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableAs_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableZn_Min
            // 
            this.coldsEleStdL3DataTableZn_Min.Caption = "Zn_Min";
            this.coldsEleStdL3DataTableZn_Min.ColumnName = "Zn_Min";
            this.coldsEleStdL3DataTableZn_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableZn_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableZn_Aim
            // 
            this.coldsEleStdL3DataTableZn_Aim.Caption = "Zn_Aim";
            this.coldsEleStdL3DataTableZn_Aim.ColumnName = "Zn_Aim";
            this.coldsEleStdL3DataTableZn_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableZn_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableZn_Max
            // 
            this.coldsEleStdL3DataTableZn_Max.Caption = "Zn_Max";
            this.coldsEleStdL3DataTableZn_Max.ColumnName = "Zn_Max";
            this.coldsEleStdL3DataTableZn_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableZn_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableZr_Min
            // 
            this.coldsEleStdL3DataTableZr_Min.Caption = "Zr_Min";
            this.coldsEleStdL3DataTableZr_Min.ColumnName = "Zr_Min";
            this.coldsEleStdL3DataTableZr_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableZr_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableZr_Aim
            // 
            this.coldsEleStdL3DataTableZr_Aim.Caption = "Zr_Aim";
            this.coldsEleStdL3DataTableZr_Aim.ColumnName = "Zr_Aim";
            this.coldsEleStdL3DataTableZr_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableZr_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableZr_Max
            // 
            this.coldsEleStdL3DataTableZr_Max.Caption = "Zr_Max";
            this.coldsEleStdL3DataTableZr_Max.ColumnName = "Zr_Max";
            this.coldsEleStdL3DataTableZr_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableZr_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableCa_Min
            // 
            this.coldsEleStdL3DataTableCa_Min.Caption = "Ca_Min";
            this.coldsEleStdL3DataTableCa_Min.ColumnName = "Ca_Min";
            this.coldsEleStdL3DataTableCa_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableCa_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableCa_Aim
            // 
            this.coldsEleStdL3DataTableCa_Aim.Caption = "Ca_Aim";
            this.coldsEleStdL3DataTableCa_Aim.ColumnName = "Ca_Aim";
            this.coldsEleStdL3DataTableCa_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableCa_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableCa_Max
            // 
            this.coldsEleStdL3DataTableCa_Max.Caption = "Ca_Max";
            this.coldsEleStdL3DataTableCa_Max.ColumnName = "Ca_Max";
            this.coldsEleStdL3DataTableCa_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableCa_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableW_Min
            // 
            this.coldsEleStdL3DataTableW_Min.Caption = "W_Min";
            this.coldsEleStdL3DataTableW_Min.ColumnName = "W_Min";
            this.coldsEleStdL3DataTableW_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableW_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableW_Aim
            // 
            this.coldsEleStdL3DataTableW_Aim.Caption = "W_Aim";
            this.coldsEleStdL3DataTableW_Aim.ColumnName = "W_Aim";
            this.coldsEleStdL3DataTableW_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableW_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableW_Max
            // 
            this.coldsEleStdL3DataTableW_Max.Caption = "W_Max";
            this.coldsEleStdL3DataTableW_Max.ColumnName = "W_Max";
            this.coldsEleStdL3DataTableW_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableW_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTablePb_Min
            // 
            this.coldsEleStdL3DataTablePb_Min.Caption = "Pb_Min";
            this.coldsEleStdL3DataTablePb_Min.ColumnName = "Pb_Min";
            this.coldsEleStdL3DataTablePb_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTablePb_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTablePb_Aim
            // 
            this.coldsEleStdL3DataTablePb_Aim.Caption = "Pb_Aim";
            this.coldsEleStdL3DataTablePb_Aim.ColumnName = "Pb_Aim";
            this.coldsEleStdL3DataTablePb_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTablePb_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTablePb_Max
            // 
            this.coldsEleStdL3DataTablePb_Max.Caption = "Pb_Max";
            this.coldsEleStdL3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coldsEleStdL3DataTablePb_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTablePb_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableRe_Min
            // 
            this.coldsEleStdL3DataTableRe_Min.Caption = "Re_Min";
            this.coldsEleStdL3DataTableRe_Min.ColumnName = "Re_Min";
            this.coldsEleStdL3DataTableRe_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableRe_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableRe_Aim
            // 
            this.coldsEleStdL3DataTableRe_Aim.Caption = "Re_Aim";
            this.coldsEleStdL3DataTableRe_Aim.ColumnName = "Re_Aim";
            this.coldsEleStdL3DataTableRe_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableRe_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableRe_Max
            // 
            this.coldsEleStdL3DataTableRe_Max.Caption = "Re_Max";
            this.coldsEleStdL3DataTableRe_Max.ColumnName = "Re_Max";
            this.coldsEleStdL3DataTableRe_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableRe_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableCeq_Min
            // 
            this.coldsEleStdL3DataTableCeq_Min.Caption = "Ceq_Min";
            this.coldsEleStdL3DataTableCeq_Min.ColumnName = "Ceq_Min";
            this.coldsEleStdL3DataTableCeq_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableCeq_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableCeq_Aim
            // 
            this.coldsEleStdL3DataTableCeq_Aim.Caption = "Ceq_Aim";
            this.coldsEleStdL3DataTableCeq_Aim.ColumnName = "Ceq_Aim";
            this.coldsEleStdL3DataTableCeq_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableCeq_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableCeq_Max
            // 
            this.coldsEleStdL3DataTableCeq_Max.Caption = "Ceq_Max";
            this.coldsEleStdL3DataTableCeq_Max.ColumnName = "Ceq_Max";
            this.coldsEleStdL3DataTableCeq_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableCeq_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableN_Min
            // 
            this.coldsEleStdL3DataTableN_Min.Caption = "N_Min";
            this.coldsEleStdL3DataTableN_Min.ColumnName = "N_Min";
            this.coldsEleStdL3DataTableN_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableN_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableN_Aim
            // 
            this.coldsEleStdL3DataTableN_Aim.Caption = "N_Aim";
            this.coldsEleStdL3DataTableN_Aim.ColumnName = "N_Aim";
            this.coldsEleStdL3DataTableN_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableN_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableN_Max
            // 
            this.coldsEleStdL3DataTableN_Max.Caption = "N_Max";
            this.coldsEleStdL3DataTableN_Max.ColumnName = "N_Max";
            this.coldsEleStdL3DataTableN_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableN_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableH_Min
            // 
            this.coldsEleStdL3DataTableH_Min.Caption = "H_Min";
            this.coldsEleStdL3DataTableH_Min.ColumnName = "H_Min";
            this.coldsEleStdL3DataTableH_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableH_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableH_Aim
            // 
            this.coldsEleStdL3DataTableH_Aim.Caption = "H_Aim";
            this.coldsEleStdL3DataTableH_Aim.ColumnName = "H_Aim";
            this.coldsEleStdL3DataTableH_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableH_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableH_Max
            // 
            this.coldsEleStdL3DataTableH_Max.Caption = "H_Max";
            this.coldsEleStdL3DataTableH_Max.ColumnName = "H_Max";
            this.coldsEleStdL3DataTableH_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableH_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableO_Min
            // 
            this.coldsEleStdL3DataTableO_Min.Caption = "O_Min";
            this.coldsEleStdL3DataTableO_Min.ColumnName = "O_Min";
            this.coldsEleStdL3DataTableO_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableO_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableO_Aim
            // 
            this.coldsEleStdL3DataTableO_Aim.Caption = "O_Aim";
            this.coldsEleStdL3DataTableO_Aim.ColumnName = "O_Aim";
            this.coldsEleStdL3DataTableO_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableO_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableO_Max
            // 
            this.coldsEleStdL3DataTableO_Max.Caption = "O_Max";
            this.coldsEleStdL3DataTableO_Max.ColumnName = "O_Max";
            this.coldsEleStdL3DataTableO_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableO_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther1_Min
            // 
            this.coldsEleStdL3DataTableOther1_Min.Caption = "Other1_Min";
            this.coldsEleStdL3DataTableOther1_Min.ColumnName = "Other1_Min";
            this.coldsEleStdL3DataTableOther1_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther1_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther1_Aim
            // 
            this.coldsEleStdL3DataTableOther1_Aim.Caption = "Other1_Aim";
            this.coldsEleStdL3DataTableOther1_Aim.ColumnName = "Other1_Aim";
            this.coldsEleStdL3DataTableOther1_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther1_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther1_Max
            // 
            this.coldsEleStdL3DataTableOther1_Max.Caption = "Other1_Max";
            this.coldsEleStdL3DataTableOther1_Max.ColumnName = "Other1_Max";
            this.coldsEleStdL3DataTableOther1_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther1_Max.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther2_Min
            // 
            this.coldsEleStdL3DataTableOther2_Min.Caption = "Other2_Min";
            this.coldsEleStdL3DataTableOther2_Min.ColumnName = "Other2_Min";
            this.coldsEleStdL3DataTableOther2_Min.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther2_Min.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther2_Aim
            // 
            this.coldsEleStdL3DataTableOther2_Aim.Caption = "Other2_Aim";
            this.coldsEleStdL3DataTableOther2_Aim.ColumnName = "Other2_Aim";
            this.coldsEleStdL3DataTableOther2_Aim.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther2_Aim.Namespace = "";
            // 
            // coldsEleStdL3DataTableOther2_Max
            // 
            this.coldsEleStdL3DataTableOther2_Max.Caption = "Other2_Max";
            this.coldsEleStdL3DataTableOther2_Max.ColumnName = "Other2_Max";
            this.coldsEleStdL3DataTableOther2_Max.DataType = typeof(double);
            this.coldsEleStdL3DataTableOther2_Max.Namespace = "";
            // 
            // DiapatchExceptionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiapatchExceptionFrm";
            this.TabText = "工艺异常处理";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.DiapatchExceptionFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiapatchExceptionFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelExange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelExchange)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvLabElement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSteelExchange.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabSteelTurn.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            this.hmiRootPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTrunReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTrunReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.tabSteelBack.ResumeLayout(false);
            this.hmiRootPanel4.ResumeLayout(false);
            this.hmiRootPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBackReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBackReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.tabSteelDiv.ResumeLayout(false);
            this.hmiRootPanel5.ResumeLayout(false);
            this.hmiRootPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelDivReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelDivReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchangeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExchangeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTurnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTurnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBackSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBackSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDivSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDivSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElementStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEleStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEleStd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsSteelExchange;
        private System.Windows.Forms.BindingSource bsSteelExange;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSteelTurn;
        private System.Windows.Forms.ToolStripButton btnSteelBack;
        private System.Windows.Forms.ToolStripButton btnSteelDiv;
        private System.Windows.Forms.ToolStripButton btnSteelExchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSteelExchange;
        private System.Windows.Forms.TabPage tabSteelTurn;
        private System.Windows.Forms.TabPage tabSteelBack;
        private System.Windows.Forms.TabPage tabSteelDiv;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSteelExchange;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.DataGridView dvSteelTurn;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private HMIBase.HMIRootPanel hmiRootPanel4;
        private System.Windows.Forms.DataGridView dvSteelBack;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private HMIBase.HMIRootPanel hmiRootPanel5;
        private System.Windows.Forms.DataGridView dvSteelDiv;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Data.DataTable schemadsSteelExchange;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableGUID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableNAME;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableOBJECTID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTablePREHEATID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableHEATID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableAPP_STEEL_WEIGHT;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableAPP_REASON;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEX_TIME;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEX_OPERATOR;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEX_FLAG;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEX_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsSteelTurn;
        private System.Data.DataTable schemadsSteelTurn;
        private System.Data.DataColumn coldsSteelTurnL3DataTableGUID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableNAME;
        private System.Data.DataColumn coldsSteelTurnL3DataTableOBJECTID;
        private System.Data.DataColumn coldsSteelTurnL3DataTablePREHEATID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSteelTurnL3DataTableHEATID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAPP_STEEL_WEIGHT;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAPP_REASON;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTURN_TIME;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTURN_OPERATOR;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTURN_FLAG;
        private System.Data.DataColumn coldsSteelTurnL3DataTableALL_TURN_FLAG;
        private System.Windows.Forms.BindingSource bsSteelTurn;
        private AppSvrHMI.L3DataSet dsSteelBack;
        private System.Windows.Forms.BindingSource bsSteelBack;
        private System.Data.DataTable schemadsSteelBack;
        private System.Data.DataColumn coldsSteelBackL3DataTableGUID;
        private System.Data.DataColumn coldsSteelBackL3DataTableNAME;
        private System.Data.DataColumn coldsSteelBackL3DataTableOBJECTID;
        private System.Data.DataColumn coldsSteelBackL3DataTablePREHEATID;
        private System.Data.DataColumn coldsSteelBackL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSteelBackL3DataTableHEATID;
        private System.Data.DataColumn coldsSteelBackL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsSteelBackL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsSteelBackL3DataTableAPP_STEEL_WEIGHT;
        private System.Data.DataColumn coldsSteelBackL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsSteelBackL3DataTableAPP_REASON;
        private System.Data.DataColumn coldsSteelBackL3DataTableBACK_UNITID;
        private System.Data.DataColumn coldsSteelBackL3DataTableBACK_TIME;
        private System.Data.DataColumn coldsSteelBackL3DataTableBACK_OPERATOR;
        private System.Data.DataColumn coldsSteelBackL3DataTableBACK_FLAG;
        private System.Data.DataColumn coldsSteelBackL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsSteelDiv;
        private System.Data.DataTable schemadsSteelDiv;
        private System.Data.DataColumn coldsSteelDivL3DataTableGUID;
        private System.Data.DataColumn coldsSteelDivL3DataTableNAME;
        private System.Data.DataColumn coldsSteelDivL3DataTableOBJECTID;
        private System.Data.DataColumn coldsSteelDivL3DataTablePREHEATID;
        private System.Data.DataColumn coldsSteelDivL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSteelDivL3DataTableHEATID;
        private System.Data.DataColumn coldsSteelDivL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsSteelDivL3DataTableAPP_STEEL_WEIGHT;
        private System.Data.DataColumn coldsSteelDivL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsSteelDivL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsSteelDivL3DataTableDIV_UNITID;
        private System.Data.DataColumn coldsSteelDivL3DataTableDIV_TIME;
        private System.Data.DataColumn coldsSteelDivL3DataTableDIV_OPERATOR;
        private System.Data.DataColumn coldsSteelDivL3DataTableDIV_FLAG;
        private System.Data.DataColumn coldsSteelDivL3DataTableAPP_REASON;
        private System.Data.DataColumn coldsSteelDivL3DataTableCheckFlag;
        private System.Windows.Forms.BindingSource bsSteelDiv;
        private AppSvrHMI.L3DataSet dsExchangeSend;
        private System.Data.DataTable schemadsExchangeSend;
        private System.Data.DataColumn coldsExchangeSendL3DataTableGUID;
        private System.Data.DataColumn coldsExchangeSendL3DataTableName;
        private System.Data.DataColumn coldsExchangeSendL3DataTableObjectID;
        private System.Data.DataColumn coldsExchangeSendL3DataTablePreHeatID;
        private System.Data.DataColumn coldsExchangeSendL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsExchangeSendL3DataTableHeatID;
        private System.Data.DataColumn coldsExchangeSendL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsExchangeSendL3DataTableApp_Time;
        private System.Data.DataColumn coldsExchangeSendL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsExchangeSendL3DataTableApp_Operator;
        private System.Data.DataColumn coldsExchangeSendL3DataTableApp_Reason;
        private System.Data.DataColumn coldsExchangeSendL3DataTableEx_Time;
        private System.Data.DataColumn coldsExchangeSendL3DataTableEx_Operator;
        private System.Data.DataColumn coldsExchangeSendL3DataTableEx_Flag;
        private System.Data.DataColumn coldsExchangeSendL3DataTableEx_SteelGradeIndex;
        private AppSvrHMI.L3DataSet dsTurnSend;
        private System.Data.DataTable schemadsTurnSend;
        private System.Data.DataColumn coldsTurnSendL3DataTableGUID;
        private System.Data.DataColumn coldsTurnSendL3DataTableName;
        private System.Data.DataColumn coldsTurnSendL3DataTableObjectID;
        private System.Data.DataColumn coldsTurnSendL3DataTablePreHeatID;
        private System.Data.DataColumn coldsTurnSendL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsTurnSendL3DataTableHeatID;
        private System.Data.DataColumn coldsTurnSendL3DataTableApp_Time;
        private System.Data.DataColumn coldsTurnSendL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsTurnSendL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsTurnSendL3DataTableApp_Operator;
        private System.Data.DataColumn coldsTurnSendL3DataTableApp_Reason;
        private System.Data.DataColumn coldsTurnSendL3DataTableTurn_Time;
        private System.Data.DataColumn coldsTurnSendL3DataTableTurn_Operator;
        private System.Data.DataColumn coldsTurnSendL3DataTableTurn_Flag;
        private System.Data.DataColumn coldsTurnSendL3DataTableAll_Turn_Flag;
        private System.Data.DataColumn coldsSteelTurnL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsBackSend;
        private System.Data.DataTable schemadsBackSend;
        private System.Data.DataColumn coldsBackSendL3DataTableGUID;
        private System.Data.DataColumn coldsBackSendL3DataTableName;
        private System.Data.DataColumn coldsBackSendL3DataTableObjectID;
        private System.Data.DataColumn coldsBackSendL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBackSendL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBackSendL3DataTableHeatID;
        private System.Data.DataColumn coldsBackSendL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsBackSendL3DataTableApp_Time;
        private System.Data.DataColumn coldsBackSendL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsBackSendL3DataTableApp_Operator;
        private System.Data.DataColumn coldsBackSendL3DataTableApp_Reason;
        private System.Data.DataColumn coldsBackSendL3DataTableBack_UnitID;
        private System.Data.DataColumn coldsBackSendL3DataTableBack_Time;
        private System.Data.DataColumn coldsBackSendL3DataTableBack_Operator;
        private System.Data.DataColumn coldsBackSendL3DataTableBack_Flag;
        private AppSvrHMI.L3DataSet dsDivSend;
        private System.Data.DataTable schemadsDivSend;
        private System.Data.DataColumn coldsDivSendL3DataTableGUID;
        private System.Data.DataColumn coldsDivSendL3DataTableName;
        private System.Data.DataColumn coldsDivSendL3DataTableObjectID;
        private System.Data.DataColumn coldsDivSendL3DataTablePreHeatID;
        private System.Data.DataColumn coldsDivSendL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsDivSendL3DataTableHeatID;
        private System.Data.DataColumn coldsDivSendL3DataTableApp_Time;
        private System.Data.DataColumn coldsDivSendL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsDivSendL3DataTableApp_Operator;
        private System.Data.DataColumn coldsDivSendL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsDivSendL3DataTableDiv_UnitID;
        private System.Data.DataColumn coldsDivSendL3DataTableDiv_Time;
        private System.Data.DataColumn coldsDivSendL3DataTableDiv_Operator;
        private System.Data.DataColumn coldsDivSendL3DataTableDiv_Flag;
        private System.Data.DataColumn coldsDivSendL3DataTableApp_Reason;
        private System.Windows.Forms.ToolStripButton btnLog;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.DataGridView dvHeatExcept;
        private AppSvrHMI.L3DataSet dsHeatExcept;
        private System.Data.DataTable schemadsHeatExcept;
        private System.Data.DataColumn coldsHeatExceptL3DataTableGUID;
        private System.Data.DataColumn coldsHeatExceptL3DataTableName;
        private System.Data.DataColumn coldsHeatExceptL3DataTableID_Object;
        private System.Data.DataColumn coldsHeatExceptL3DataTableHeatID;
        private System.Data.DataColumn coldsHeatExceptL3DataTableProcess_Count;
        private System.Data.DataColumn coldsHeatExceptL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsHeatExceptL3DataTableUnitID;
        private System.Data.DataColumn coldsHeatExceptL3DataTablePreHeatID;
        private System.Data.DataColumn coldsHeatExceptL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsHeatExceptL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsHeatExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsHeatExceptL3DataTableDecide_Code;
        private System.Data.DataColumn coldsHeatExceptL3DataTableClassify;
        private System.Data.DataColumn coldsHeatExceptL3DataTableExceptional_Time;
        private System.Windows.Forms.BindingSource bsHeatExcept;
        private System.Windows.Forms.DataGridView dvLabElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private AppSvrHMI.L3DataSet dsElement;
        private System.Data.DataTable schemadsElementStd;
        private System.Data.DataColumn coldsElementStdL3DataTableGUID;
        private System.Data.DataColumn coldsElementStdL3DataTableName;
        private System.Data.DataColumn coldsElementStdL3DataTableAppID;
        private System.Data.DataColumn coldsElementStdL3DataTableSample_Code;
        private System.Data.DataColumn coldsElementStdL3DataTableArrive_Date;
        private System.Data.DataColumn coldsElementStdL3DataTableReport_Date;
        private System.Data.DataColumn coldsElementStdL3DataTableHeatID;
        private System.Data.DataColumn coldsElementStdL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsElementStdL3DataTableUnitID;
        private System.Data.DataColumn coldsElementStdL3DataTableSample_Address;
        private System.Data.DataColumn coldsElementStdL3DataTableSample_Type;
        private System.Data.DataColumn coldsElementStdL3DataTableSample_Count;
        private System.Data.DataColumn coldsElementStdL3DataTableC;
        private System.Data.DataColumn coldsElementStdL3DataTableSi;
        private System.Data.DataColumn coldsElementStdL3DataTableMn;
        private System.Data.DataColumn coldsElementStdL3DataTableP;
        private System.Data.DataColumn coldsElementStdL3DataTableS;
        private System.Data.DataColumn coldsElementStdL3DataTableCu;
        private System.Data.DataColumn coldsElementStdL3DataTableNi;
        private System.Data.DataColumn coldsElementStdL3DataTableCr;
        private System.Data.DataColumn coldsElementStdL3DataTableMo;
        private System.Data.DataColumn coldsElementStdL3DataTableV;
        private System.Data.DataColumn coldsElementStdL3DataTableNb;
        private System.Data.DataColumn coldsElementStdL3DataTableAl;
        private System.Data.DataColumn coldsElementStdL3DataTableAlS;
        private System.Data.DataColumn coldsElementStdL3DataTableTi;
        private System.Data.DataColumn coldsElementStdL3DataTableB;
        private System.Data.DataColumn coldsElementStdL3DataTableSb;
        private System.Data.DataColumn coldsElementStdL3DataTableAs;
        private System.Data.DataColumn coldsElementStdL3DataTableSn;
        private System.Data.DataColumn coldsElementStdL3DataTableZn;
        private System.Data.DataColumn coldsElementStdL3DataTableCa;
        private System.Data.DataColumn coldsElementStdL3DataTableW;
        private System.Data.DataColumn coldsElementStdL3DataTablePb;
        private System.Data.DataColumn coldsElementStdL3DataTableRe;
        private System.Data.DataColumn coldsElementStdL3DataTableCeq;
        private System.Data.DataColumn coldsElementStdL3DataTableN;
        private System.Data.DataColumn coldsElementStdL3DataTableH;
        private System.Data.DataColumn coldsElementStdL3DataTableO;
        private System.Data.DataColumn coldsElementStdL3DataTableOther1;
        private System.Data.DataColumn coldsElementStdL3DataTableOther2;
        private System.Data.DataColumn coldsElementStdL3DataTableLogTime;
        private System.Data.DataColumn coldsElementStdL3DataTableDataLogMode;
        private AppSvrHMI.L3DataSet dsEleStd;
        private System.Data.DataTable schemadsEleStd;
        private System.Data.DataColumn coldsEleStdL3DataTableGUID;
        private System.Data.DataColumn coldsEleStdL3DataTableName;
        private System.Data.DataColumn coldsEleStdL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsEleStdL3DataTableLadle_Brick;
        private System.Data.DataColumn coldsEleStdL3DataTableLadle_Use;
        private System.Data.DataColumn coldsEleStdL3DataTableLadle_Pre_SteelGrade;
        private System.Data.DataColumn coldsEleStdL3DataTableLadle_Stay;
        private System.Data.DataColumn coldsEleStdL3DataTableBOF_Type;
        private System.Data.DataColumn coldsEleStdL3DataTableLadle_Tapped_Proc;
        private System.Data.DataColumn coldsEleStdL3DataTableLF_Type;
        private System.Data.DataColumn coldsEleStdL3DataTableRH_Type;
        private System.Data.DataColumn coldsEleStdL3DataTableCaster_Type;
        private System.Data.DataColumn coldsEleStdL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsEleStdL3DataTableC_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableC_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableC_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableSi_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableSi_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableSi_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableMn_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableMn_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableMn_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableP_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableP_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableP_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableS_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableS_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableS_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableCu_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableCu_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableCu_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableNi_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableNi_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableNi_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableCr_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableCr_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableCr_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableMo_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableMo_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableMo_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableV_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableV_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableV_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableNb_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableNb_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableNb_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableAl_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableAl_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableAl_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableAlS_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableAlS_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableAlS_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableTi_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableTi_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableTi_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableB_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableB_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableB_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableSb_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableSb_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableSb_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableSn_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableSn_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableSn_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableAs_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableAs_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableAs_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableZn_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableZn_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableZn_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableZr_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableZr_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableZr_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableCa_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableCa_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableCa_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableW_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableW_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableW_Max;
        private System.Data.DataColumn coldsEleStdL3DataTablePb_Min;
        private System.Data.DataColumn coldsEleStdL3DataTablePb_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTablePb_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableRe_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableRe_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableRe_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableCeq_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableCeq_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableCeq_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableN_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableN_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableN_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableH_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableH_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableH_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableO_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableO_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableO_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableOther1_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableOther1_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableOther1_Max;
        private System.Data.DataColumn coldsEleStdL3DataTableOther2_Min;
        private System.Data.DataColumn coldsEleStdL3DataTableOther2_Aim;
        private System.Data.DataColumn coldsEleStdL3DataTableOther2_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsSteelTrunReason;
        private System.Data.DataTable schemadsSteelTrunReason;
        private System.Data.DataColumn coldsSteelTrunReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelTrunReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSteelChangeReason;
        private System.Data.DataTable schemadsSteelChangeReason;
        private System.Data.DataColumn coldsSteelChangeReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelChangeReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSteelBackReason;
        private System.Data.DataTable schemadsSteelBackReason;
        private System.Data.DataColumn coldsSteelBackReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelBackReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTIMEDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTEELWEIGHTDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOPERATORDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPUNITIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVUNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIV_FLAG;
        private System.Windows.Forms.DataGridViewComboBoxColumn aPPREASONDataGridViewTextBoxColumn3;
        private AppSvrHMI.L3DataSet dsSteelDivReason;
        private System.Data.DataTable schemadsSteelDivReason;
        private System.Data.DataColumn coldsSteelDivReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelDivReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBJECTIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPUNITIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTIMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTEELWEIGHTDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOPERATORDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn aPPREASONDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACKUNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACKTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACKOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BACK_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBJECTIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPUNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTEELWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aPPREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPUNITIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTEELWEIGHTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOPERATORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn aPPREASONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURNTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURNOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURN_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLLTURNFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBJECTIDDataGridViewTextBoxColumn1;
    }
}