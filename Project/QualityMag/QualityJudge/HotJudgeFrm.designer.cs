namespace QualityMag.QualityJudge
{
    partial class HotJudgeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotJudgeFrm));
            this.bsBloom = new System.Windows.Forms.BindingSource(this.components);
            this.dsBloom = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableMaterialID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableStatus = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePosition = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableQAStatus = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableQALevel = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOrderContractID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableProduceContractID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSalesContractID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCasting_No = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCut_SteelGradeIndex = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFinal_SteelGradeIndex = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLength = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWidth = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableThickness = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Area = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Section_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Pile_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Layer_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Seq_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCur_Bay_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableDestination = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableProcess_Type = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePlan_Ord_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableProduce_Date = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFinish_Flag = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFinishedTime = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBloom_Count = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCal_Weight = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableRight_Count = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableRight_Weight = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Count = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Count = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Weight = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Count1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Weight1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Reason1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Count2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Weight2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Reason2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Count3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Weight3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWrong_Reason3 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSufaceDefactDes = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableReason = new System.Data.DataColumn();
            this.coldsBloomL3DataTableCasterID = new System.Data.DataColumn();
            this.bsWrongReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWrongReason = new AppSvrHMI.L3DataSet();
            this.schemadsWrongReason = new System.Data.DataTable();
            this.coldsWrongReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWrongReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsWrongReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWrongReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWasterReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsWasterReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWasterReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBloom = new System.Windows.Forms.DataGridView();
            this.produceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBloomStatus = new AppSvrHMI.L3DataSet();
            this.schemadsBloomStatus = new System.Data.DataTable();
            this.coldsBloomStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBloomStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingHeatCntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curSectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curPileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsPile = new AppSvrHMI.L3DataSet();
            this.schemadsPile = new System.Data.DataTable();
            this.coldsPileL3DataTableCode = new System.Data.DataColumn();
            this.coldsPileL3DataTableCode_Des = new System.Data.DataColumn();
            this.curLayerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curSeqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curBayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotSendFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planOrdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloomCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sufaceDefactDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbWrongReason3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbWrongReason2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWrongReason1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbWasterReason3 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbWasterReason2 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbWasterReason1 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.lblSufaceDefactDes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWrong_Weight3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblWrong_Count3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblWrong_Weight1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblWaster_Weight3 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblWrong_Count1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWaster_Count3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblWrong_Weight2 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblWrong_Weight = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblWrong_Count2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWrong_Count = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lblWaster_Weight2 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.lblWaster_Count2 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.lblWaster_Weight1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblWaster_Count1 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblWaster_Weight = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lblWaster_Count = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblRight_Weight = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.lblRight_Count = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblCal_Weight = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblBloom_Count = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.lblSteelGradeIndex = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.lblHeatID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHotJudge = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCCMID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtProduceDate = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dsCCMID = new AppSvrHMI.L3DataSet();
            this.schemadsCCMID = new System.Data.DataTable();
            this.coldsCCMIDL3DataTableCode = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBloom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBloom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBloom
            // 
            this.bsBloom.DataMember = "L3DataTable";
            this.bsBloom.DataSource = this.dsBloom;
            // 
            // dsBloom
            // 
            this.dsBloom.AutoSubscribe = true;
            this.dsBloom.DataSetName = "L3DataSet";
            this.dsBloom.DeleteMethod = null;
            this.dsBloom.InsertMethod = null;
            this.dsBloom.L3DataAdapter = this.Adapter;
            this.dsBloom.LoadEvent = "Click";
            this.dsBloom.LoadTrigger = null;
            this.dsBloom.RefreshValve = 1000;
            this.dsBloom.SourceCommand = null;
            this.dsBloom.SourceCondition = "1=2";
            this.dsBloom.SourceMethod = "";
            this.dsBloom.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBloom.SourceURI = "MES\\MaterialData\\CBloom_Data";
            this.dsBloom.SubscribeTarget = null;
            this.dsBloom.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsBloom.UpdateEvent = "Click";
            this.dsBloom.UpdateMethod = null;
            this.dsBloom.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableMaterialID,
            this.coll3DataSet1L3DataTableStatus,
            this.coll3DataSet1L3DataTablePosition,
            this.coll3DataSet1L3DataTableQAStatus,
            this.coll3DataSet1L3DataTableQALevel,
            this.coll3DataSet1L3DataTableOrderContractID,
            this.coll3DataSet1L3DataTableProduceContractID,
            this.coll3DataSet1L3DataTableSalesContractID,
            this.coll3DataSet1L3DataTableCasting_No,
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt,
            this.coll3DataSet1L3DataTablePre_SteelGradeIndex,
            this.coll3DataSet1L3DataTableSteelGradeIndex,
            this.coll3DataSet1L3DataTableCut_SteelGradeIndex,
            this.coll3DataSet1L3DataTableFinal_SteelGradeIndex,
            this.coll3DataSet1L3DataTableLength,
            this.coll3DataSet1L3DataTableWidth,
            this.coll3DataSet1L3DataTableThickness,
            this.coll3DataSet1L3DataTableCur_Area,
            this.coll3DataSet1L3DataTableCur_Section_ID,
            this.coll3DataSet1L3DataTableCur_Pile_ID,
            this.coll3DataSet1L3DataTableCur_Layer_ID,
            this.coll3DataSet1L3DataTableCur_Seq_ID,
            this.coll3DataSet1L3DataTableCur_Bay_ID,
            this.coll3DataSet1L3DataTableDestination,
            this.coll3DataSet1L3DataTableHot_Send_Flag,
            this.coll3DataSet1L3DataTableProcess_Type,
            this.coll3DataSet1L3DataTablePlan_Ord_ID,
            this.coll3DataSet1L3DataTableProduce_Date,
            this.coll3DataSet1L3DataTableFinish_Flag,
            this.coll3DataSet1L3DataTableFinishedTime,
            this.coll3DataSet1L3DataTableBloom_Count,
            this.coll3DataSet1L3DataTableCal_Weight,
            this.coll3DataSet1L3DataTableRight_Count,
            this.coll3DataSet1L3DataTableRight_Weight,
            this.coll3DataSet1L3DataTableWaster_Count,
            this.coll3DataSet1L3DataTableWaster_Weight,
            this.coll3DataSet1L3DataTableWaster_Count1,
            this.coll3DataSet1L3DataTableWaster_Weight1,
            this.coll3DataSet1L3DataTableWaster_Reason1,
            this.coll3DataSet1L3DataTableWaster_Count2,
            this.coll3DataSet1L3DataTableWaster_Weight2,
            this.coll3DataSet1L3DataTableWaster_Reason2,
            this.coll3DataSet1L3DataTableWaster_Count3,
            this.coll3DataSet1L3DataTableWaster_Weight3,
            this.coll3DataSet1L3DataTableWaster_Reason3,
            this.coll3DataSet1L3DataTableWrong_Count,
            this.coll3DataSet1L3DataTableWrong_Weight,
            this.coll3DataSet1L3DataTableWrong_Count1,
            this.coll3DataSet1L3DataTableWrong_Weight1,
            this.coll3DataSet1L3DataTableWrong_Reason1,
            this.coll3DataSet1L3DataTableWrong_Count2,
            this.coll3DataSet1L3DataTableWrong_Weight2,
            this.coll3DataSet1L3DataTableWrong_Reason2,
            this.coll3DataSet1L3DataTableWrong_Count3,
            this.coll3DataSet1L3DataTableWrong_Weight3,
            this.coll3DataSet1L3DataTableWrong_Reason3,
            this.coll3DataSet1L3DataTableSufaceDefactDes,
            this.coll3DataSet1L3DataTableReason,
            this.coldsBloomL3DataTableCasterID});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableName
            // 
            this.coll3DataSet1L3DataTableName.Caption = "Name";
            this.coll3DataSet1L3DataTableName.ColumnName = "Name";
            this.coll3DataSet1L3DataTableName.Namespace = "";
            // 
            // coll3DataSet1L3DataTableMaterialID
            // 
            this.coll3DataSet1L3DataTableMaterialID.Caption = "MaterialID";
            this.coll3DataSet1L3DataTableMaterialID.ColumnName = "MaterialID";
            this.coll3DataSet1L3DataTableMaterialID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableStatus
            // 
            this.coll3DataSet1L3DataTableStatus.Caption = "Status";
            this.coll3DataSet1L3DataTableStatus.ColumnName = "Status";
            this.coll3DataSet1L3DataTableStatus.DataType = typeof(int);
            this.coll3DataSet1L3DataTableStatus.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePosition
            // 
            this.coll3DataSet1L3DataTablePosition.Caption = "Position";
            this.coll3DataSet1L3DataTablePosition.ColumnName = "Position";
            this.coll3DataSet1L3DataTablePosition.Namespace = "";
            // 
            // coll3DataSet1L3DataTableQAStatus
            // 
            this.coll3DataSet1L3DataTableQAStatus.Caption = "QAStatus";
            this.coll3DataSet1L3DataTableQAStatus.ColumnName = "QAStatus";
            this.coll3DataSet1L3DataTableQAStatus.DataType = typeof(int);
            this.coll3DataSet1L3DataTableQAStatus.Namespace = "";
            // 
            // coll3DataSet1L3DataTableQALevel
            // 
            this.coll3DataSet1L3DataTableQALevel.Caption = "QALevel";
            this.coll3DataSet1L3DataTableQALevel.ColumnName = "QALevel";
            this.coll3DataSet1L3DataTableQALevel.DataType = typeof(int);
            this.coll3DataSet1L3DataTableQALevel.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOrderContractID
            // 
            this.coll3DataSet1L3DataTableOrderContractID.Caption = "OrderContractID";
            this.coll3DataSet1L3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coll3DataSet1L3DataTableOrderContractID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableProduceContractID
            // 
            this.coll3DataSet1L3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coll3DataSet1L3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coll3DataSet1L3DataTableProduceContractID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSalesContractID
            // 
            this.coll3DataSet1L3DataTableSalesContractID.Caption = "SalesContractID";
            this.coll3DataSet1L3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coll3DataSet1L3DataTableSalesContractID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCasting_No
            // 
            this.coll3DataSet1L3DataTableCasting_No.Caption = "Casting_No";
            this.coll3DataSet1L3DataTableCasting_No.ColumnName = "Casting_No";
            this.coll3DataSet1L3DataTableCasting_No.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCasting_Heat_Cnt
            // 
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt.Caption = "Casting_Heat_Cnt";
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt.ColumnName = "Casting_Heat_Cnt";
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt.DataType = typeof(int);
            this.coll3DataSet1L3DataTableCasting_Heat_Cnt.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePre_SteelGradeIndex
            // 
            this.coll3DataSet1L3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coll3DataSet1L3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coll3DataSet1L3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSteelGradeIndex
            // 
            this.coll3DataSet1L3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coll3DataSet1L3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coll3DataSet1L3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCut_SteelGradeIndex
            // 
            this.coll3DataSet1L3DataTableCut_SteelGradeIndex.Caption = "Cut_SteelGradeIndex";
            this.coll3DataSet1L3DataTableCut_SteelGradeIndex.ColumnName = "Cut_SteelGradeIndex";
            this.coll3DataSet1L3DataTableCut_SteelGradeIndex.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFinal_SteelGradeIndex
            // 
            this.coll3DataSet1L3DataTableFinal_SteelGradeIndex.Caption = "Final_SteelGradeIndex";
            this.coll3DataSet1L3DataTableFinal_SteelGradeIndex.ColumnName = "Final_SteelGradeIndex";
            this.coll3DataSet1L3DataTableFinal_SteelGradeIndex.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLength
            // 
            this.coll3DataSet1L3DataTableLength.Caption = "Length";
            this.coll3DataSet1L3DataTableLength.ColumnName = "Length";
            this.coll3DataSet1L3DataTableLength.DataType = typeof(int);
            this.coll3DataSet1L3DataTableLength.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWidth
            // 
            this.coll3DataSet1L3DataTableWidth.Caption = "Width";
            this.coll3DataSet1L3DataTableWidth.ColumnName = "Width";
            this.coll3DataSet1L3DataTableWidth.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWidth.Namespace = "";
            // 
            // coll3DataSet1L3DataTableThickness
            // 
            this.coll3DataSet1L3DataTableThickness.Caption = "Thickness";
            this.coll3DataSet1L3DataTableThickness.ColumnName = "Thickness";
            this.coll3DataSet1L3DataTableThickness.DataType = typeof(int);
            this.coll3DataSet1L3DataTableThickness.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Area
            // 
            this.coll3DataSet1L3DataTableCur_Area.Caption = "Cur_Area";
            this.coll3DataSet1L3DataTableCur_Area.ColumnName = "Cur_Area";
            this.coll3DataSet1L3DataTableCur_Area.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Section_ID
            // 
            this.coll3DataSet1L3DataTableCur_Section_ID.Caption = "Cur_Section_ID";
            this.coll3DataSet1L3DataTableCur_Section_ID.ColumnName = "Cur_Section_ID";
            this.coll3DataSet1L3DataTableCur_Section_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Pile_ID
            // 
            this.coll3DataSet1L3DataTableCur_Pile_ID.Caption = "Cur_Pile_ID";
            this.coll3DataSet1L3DataTableCur_Pile_ID.ColumnName = "Cur_Pile_ID";
            this.coll3DataSet1L3DataTableCur_Pile_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Layer_ID
            // 
            this.coll3DataSet1L3DataTableCur_Layer_ID.Caption = "Cur_Layer_ID";
            this.coll3DataSet1L3DataTableCur_Layer_ID.ColumnName = "Cur_Layer_ID";
            this.coll3DataSet1L3DataTableCur_Layer_ID.DataType = typeof(int);
            this.coll3DataSet1L3DataTableCur_Layer_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Seq_ID
            // 
            this.coll3DataSet1L3DataTableCur_Seq_ID.Caption = "Cur_Seq_ID";
            this.coll3DataSet1L3DataTableCur_Seq_ID.ColumnName = "Cur_Seq_ID";
            this.coll3DataSet1L3DataTableCur_Seq_ID.DataType = typeof(int);
            this.coll3DataSet1L3DataTableCur_Seq_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCur_Bay_ID
            // 
            this.coll3DataSet1L3DataTableCur_Bay_ID.Caption = "Cur_Bay_ID";
            this.coll3DataSet1L3DataTableCur_Bay_ID.ColumnName = "Cur_Bay_ID";
            this.coll3DataSet1L3DataTableCur_Bay_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableDestination
            // 
            this.coll3DataSet1L3DataTableDestination.Caption = "Destination";
            this.coll3DataSet1L3DataTableDestination.ColumnName = "Destination";
            this.coll3DataSet1L3DataTableDestination.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHot_Send_Flag
            // 
            this.coll3DataSet1L3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coll3DataSet1L3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coll3DataSet1L3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coll3DataSet1L3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coll3DataSet1L3DataTableProcess_Type
            // 
            this.coll3DataSet1L3DataTableProcess_Type.Caption = "Process_Type";
            this.coll3DataSet1L3DataTableProcess_Type.ColumnName = "Process_Type";
            this.coll3DataSet1L3DataTableProcess_Type.DataType = typeof(int);
            this.coll3DataSet1L3DataTableProcess_Type.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePlan_Ord_ID
            // 
            this.coll3DataSet1L3DataTablePlan_Ord_ID.Caption = "Plan_Ord_ID";
            this.coll3DataSet1L3DataTablePlan_Ord_ID.ColumnName = "Plan_Ord_ID";
            this.coll3DataSet1L3DataTablePlan_Ord_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableProduce_Date
            // 
            this.coll3DataSet1L3DataTableProduce_Date.Caption = "Produce_Date";
            this.coll3DataSet1L3DataTableProduce_Date.ColumnName = "Produce_Date";
            this.coll3DataSet1L3DataTableProduce_Date.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableProduce_Date.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFinish_Flag
            // 
            this.coll3DataSet1L3DataTableFinish_Flag.Caption = "Finish_Flag";
            this.coll3DataSet1L3DataTableFinish_Flag.ColumnName = "Finish_Flag";
            this.coll3DataSet1L3DataTableFinish_Flag.DataType = typeof(int);
            this.coll3DataSet1L3DataTableFinish_Flag.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFinishedTime
            // 
            this.coll3DataSet1L3DataTableFinishedTime.Caption = "FinishedTime";
            this.coll3DataSet1L3DataTableFinishedTime.ColumnName = "FinishedTime";
            this.coll3DataSet1L3DataTableFinishedTime.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableFinishedTime.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBloom_Count
            // 
            this.coll3DataSet1L3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coll3DataSet1L3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coll3DataSet1L3DataTableBloom_Count.DataType = typeof(int);
            this.coll3DataSet1L3DataTableBloom_Count.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCal_Weight
            // 
            this.coll3DataSet1L3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coll3DataSet1L3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coll3DataSet1L3DataTableCal_Weight.DataType = typeof(float);
            this.coll3DataSet1L3DataTableCal_Weight.Namespace = "";
            // 
            // coll3DataSet1L3DataTableRight_Count
            // 
            this.coll3DataSet1L3DataTableRight_Count.Caption = "Right_Count";
            this.coll3DataSet1L3DataTableRight_Count.ColumnName = "Right_Count";
            this.coll3DataSet1L3DataTableRight_Count.DataType = typeof(int);
            this.coll3DataSet1L3DataTableRight_Count.Namespace = "";
            // 
            // coll3DataSet1L3DataTableRight_Weight
            // 
            this.coll3DataSet1L3DataTableRight_Weight.Caption = "Right_Weight";
            this.coll3DataSet1L3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coll3DataSet1L3DataTableRight_Weight.DataType = typeof(float);
            this.coll3DataSet1L3DataTableRight_Weight.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Count
            // 
            this.coll3DataSet1L3DataTableWaster_Count.Caption = "Waster_Count";
            this.coll3DataSet1L3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coll3DataSet1L3DataTableWaster_Count.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Count.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Weight
            // 
            this.coll3DataSet1L3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coll3DataSet1L3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coll3DataSet1L3DataTableWaster_Weight.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Weight.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Count1
            // 
            this.coll3DataSet1L3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coll3DataSet1L3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coll3DataSet1L3DataTableWaster_Count1.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Count1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Weight1
            // 
            this.coll3DataSet1L3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coll3DataSet1L3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coll3DataSet1L3DataTableWaster_Weight1.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Weight1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Reason1
            // 
            this.coll3DataSet1L3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coll3DataSet1L3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coll3DataSet1L3DataTableWaster_Reason1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Count2
            // 
            this.coll3DataSet1L3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coll3DataSet1L3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coll3DataSet1L3DataTableWaster_Count2.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Count2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Weight2
            // 
            this.coll3DataSet1L3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coll3DataSet1L3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coll3DataSet1L3DataTableWaster_Weight2.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Weight2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Reason2
            // 
            this.coll3DataSet1L3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coll3DataSet1L3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coll3DataSet1L3DataTableWaster_Reason2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Count3
            // 
            this.coll3DataSet1L3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coll3DataSet1L3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coll3DataSet1L3DataTableWaster_Count3.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Count3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Weight3
            // 
            this.coll3DataSet1L3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coll3DataSet1L3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coll3DataSet1L3DataTableWaster_Weight3.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWaster_Weight3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWaster_Reason3
            // 
            this.coll3DataSet1L3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coll3DataSet1L3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coll3DataSet1L3DataTableWaster_Reason3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Count
            // 
            this.coll3DataSet1L3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coll3DataSet1L3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coll3DataSet1L3DataTableWrong_Count.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWrong_Count.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Weight
            // 
            this.coll3DataSet1L3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coll3DataSet1L3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coll3DataSet1L3DataTableWrong_Weight.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWrong_Weight.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Count1
            // 
            this.coll3DataSet1L3DataTableWrong_Count1.Caption = "Wrong_Count1";
            this.coll3DataSet1L3DataTableWrong_Count1.ColumnName = "Wrong_Count1";
            this.coll3DataSet1L3DataTableWrong_Count1.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWrong_Count1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Weight1
            // 
            this.coll3DataSet1L3DataTableWrong_Weight1.Caption = "Wrong_Weight1";
            this.coll3DataSet1L3DataTableWrong_Weight1.ColumnName = "Wrong_Weight1";
            this.coll3DataSet1L3DataTableWrong_Weight1.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWrong_Weight1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Reason1
            // 
            this.coll3DataSet1L3DataTableWrong_Reason1.Caption = "Wrong_Reason1";
            this.coll3DataSet1L3DataTableWrong_Reason1.ColumnName = "Wrong_Reason1";
            this.coll3DataSet1L3DataTableWrong_Reason1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Count2
            // 
            this.coll3DataSet1L3DataTableWrong_Count2.Caption = "Wrong_Count2";
            this.coll3DataSet1L3DataTableWrong_Count2.ColumnName = "Wrong_Count2";
            this.coll3DataSet1L3DataTableWrong_Count2.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWrong_Count2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Weight2
            // 
            this.coll3DataSet1L3DataTableWrong_Weight2.Caption = "Wrong_Weight2";
            this.coll3DataSet1L3DataTableWrong_Weight2.ColumnName = "Wrong_Weight2";
            this.coll3DataSet1L3DataTableWrong_Weight2.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWrong_Weight2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Reason2
            // 
            this.coll3DataSet1L3DataTableWrong_Reason2.Caption = "Wrong_Reason2";
            this.coll3DataSet1L3DataTableWrong_Reason2.ColumnName = "Wrong_Reason2";
            this.coll3DataSet1L3DataTableWrong_Reason2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Count3
            // 
            this.coll3DataSet1L3DataTableWrong_Count3.Caption = "Wrong_Count3";
            this.coll3DataSet1L3DataTableWrong_Count3.ColumnName = "Wrong_Count3";
            this.coll3DataSet1L3DataTableWrong_Count3.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWrong_Count3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Weight3
            // 
            this.coll3DataSet1L3DataTableWrong_Weight3.Caption = "Wrong_Weight3";
            this.coll3DataSet1L3DataTableWrong_Weight3.ColumnName = "Wrong_Weight3";
            this.coll3DataSet1L3DataTableWrong_Weight3.DataType = typeof(float);
            this.coll3DataSet1L3DataTableWrong_Weight3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWrong_Reason3
            // 
            this.coll3DataSet1L3DataTableWrong_Reason3.Caption = "Wrong_Reason3";
            this.coll3DataSet1L3DataTableWrong_Reason3.ColumnName = "Wrong_Reason3";
            this.coll3DataSet1L3DataTableWrong_Reason3.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSufaceDefactDes
            // 
            this.coll3DataSet1L3DataTableSufaceDefactDes.Caption = "SufaceDefactDes";
            this.coll3DataSet1L3DataTableSufaceDefactDes.ColumnName = "SufaceDefactDes";
            this.coll3DataSet1L3DataTableSufaceDefactDes.Namespace = "";
            // 
            // coll3DataSet1L3DataTableReason
            // 
            this.coll3DataSet1L3DataTableReason.Caption = "Reason";
            this.coll3DataSet1L3DataTableReason.ColumnName = "Reason";
            this.coll3DataSet1L3DataTableReason.Namespace = "";
            // 
            // coldsBloomL3DataTableCasterID
            // 
            this.coldsBloomL3DataTableCasterID.Caption = "CasterID";
            this.coldsBloomL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsBloomL3DataTableCasterID.Namespace = "";
            // 
            // bsWrongReason3
            // 
            this.bsWrongReason3.DataMember = "L3DataTable";
            this.bsWrongReason3.DataSource = this.dsWrongReason;
            // 
            // dsWrongReason
            // 
            this.dsWrongReason.AutoSubscribe = true;
            this.dsWrongReason.DataSetName = "L3DataSet";
            this.dsWrongReason.DeleteMethod = null;
            this.dsWrongReason.InsertMethod = null;
            this.dsWrongReason.L3DataAdapter = this.Adapter;
            this.dsWrongReason.LoadEvent = "Click";
            this.dsWrongReason.LoadTrigger = null;
            this.dsWrongReason.RefreshValve = 1000;
            this.dsWrongReason.SourceCommand = null;
            this.dsWrongReason.SourceCondition = "CODE_GROUP = \'WRONG_REASON_CODE\'";
            this.dsWrongReason.SourceMethod = "";
            this.dsWrongReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWrongReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWrongReason.SubscribeTarget = null;
            this.dsWrongReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWrongReason});
            this.dsWrongReason.UpdateEvent = "Click";
            this.dsWrongReason.UpdateMethod = null;
            this.dsWrongReason.UpdateTrigger = null;
            // 
            // schemadsWrongReason
            // 
            this.schemadsWrongReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWrongReasonL3DataTableCode,
            this.coldsWrongReasonL3DataTableCode_Des});
            this.schemadsWrongReason.TableName = "L3DataTable";
            // 
            // coldsWrongReasonL3DataTableCode
            // 
            this.coldsWrongReasonL3DataTableCode.Caption = "Code";
            this.coldsWrongReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWrongReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWrongReasonL3DataTableCode_Des
            // 
            this.coldsWrongReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsWrongReason2
            // 
            this.bsWrongReason2.DataMember = "L3DataTable";
            this.bsWrongReason2.DataSource = this.dsWrongReason;
            // 
            // bsWrongReason1
            // 
            this.bsWrongReason1.DataMember = "L3DataTable";
            this.bsWrongReason1.DataSource = this.dsWrongReason;
            // 
            // bsWasterReason3
            // 
            this.bsWasterReason3.DataMember = "L3DataTable";
            this.bsWasterReason3.DataSource = this.dsWasterReason;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoSubscribe = true;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsWasterReason2
            // 
            this.bsWasterReason2.DataMember = "L3DataTable";
            this.bsWasterReason2.DataSource = this.dsWasterReason;
            // 
            // bsWasterReason1
            // 
            this.bsWasterReason1.DataMember = "L3DataTable";
            this.bsWasterReason1.DataSource = this.dsWasterReason;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBloom);
            this.hmiRootPanel1.Controls.Add(this.groupBox1);
            this.hmiRootPanel1.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 700);
            this.hmiRootPanel1.TabIndex = 35;
            // 
            // dvBloom
            // 
            this.dvBloom.AllowUserToAddRows = false;
            this.dvBloom.AutoGenerateColumns = false;
            this.dvBloom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBloom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produceDateDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.qAStatusDataGridViewTextBoxColumn,
            this.qALevelDataGridViewTextBoxColumn,
            this.orderContractIDDataGridViewTextBoxColumn,
            this.produceContractIDDataGridViewTextBoxColumn,
            this.salesContractIDDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn,
            this.castingNoDataGridViewTextBoxColumn,
            this.castingHeatCntDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.cutSteelGradeIndexDataGridViewTextBoxColumn,
            this.finalSteelGradeIndexDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.curAreaDataGridViewTextBoxColumn,
            this.curSectionIDDataGridViewTextBoxColumn,
            this.curPileIDDataGridViewTextBoxColumn,
            this.curLayerIDDataGridViewTextBoxColumn,
            this.curSeqIDDataGridViewTextBoxColumn,
            this.curBayIDDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.hotSendFlagDataGridViewTextBoxColumn,
            this.processTypeDataGridViewTextBoxColumn,
            this.planOrdIDDataGridViewTextBoxColumn,
            this.finishFlagDataGridViewTextBoxColumn,
            this.finishedTimeDataGridViewTextBoxColumn,
            this.bloomCountDataGridViewTextBoxColumn,
            this.calWeightDataGridViewTextBoxColumn,
            this.rightCountDataGridViewTextBoxColumn,
            this.rightWeightDataGridViewTextBoxColumn,
            this.wasterCountDataGridViewTextBoxColumn,
            this.wasterWeightDataGridViewTextBoxColumn,
            this.wasterCount1DataGridViewTextBoxColumn,
            this.wasterWeight1DataGridViewTextBoxColumn,
            this.wasterReason1DataGridViewTextBoxColumn,
            this.wasterCount2DataGridViewTextBoxColumn,
            this.wasterWeight2DataGridViewTextBoxColumn,
            this.wasterReason2DataGridViewTextBoxColumn,
            this.wasterCount3DataGridViewTextBoxColumn,
            this.wasterWeight3DataGridViewTextBoxColumn,
            this.wasterReason3DataGridViewTextBoxColumn,
            this.wrongCountDataGridViewTextBoxColumn,
            this.wrongWeightDataGridViewTextBoxColumn,
            this.wrongCount1DataGridViewTextBoxColumn,
            this.wrongWeight1DataGridViewTextBoxColumn,
            this.wrongReason1DataGridViewTextBoxColumn,
            this.wrongCount2DataGridViewTextBoxColumn,
            this.wrongWeight2DataGridViewTextBoxColumn,
            this.wrongReason2DataGridViewTextBoxColumn,
            this.wrongCount3DataGridViewTextBoxColumn,
            this.wrongWeight3DataGridViewTextBoxColumn,
            this.wrongReason3DataGridViewTextBoxColumn,
            this.sufaceDefactDesDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.dvBloom.DataSource = this.bsBloom;
            this.dvBloom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBloom.Location = new System.Drawing.Point(0, 289);
            this.dvBloom.MultiSelect = false;
            this.dvBloom.Name = "dvBloom";
            this.dvBloom.ReadOnly = true;
            this.dvBloom.RowTemplate.Height = 23;
            this.dvBloom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBloom.Size = new System.Drawing.Size(1000, 411);
            this.dvBloom.TabIndex = 39;
            this.dvBloom.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBloom_DataBindingComplete);
            this.dvBloom.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvBloom_CellMouseDoubleClick);
            this.dvBloom.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBloom_DataError);
            // 
            // produceDateDataGridViewTextBoxColumn
            // 
            this.produceDateDataGridViewTextBoxColumn.DataPropertyName = "Produce_Date";
            this.produceDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.produceDateDataGridViewTextBoxColumn.Name = "produceDateDataGridViewTextBoxColumn";
            this.produceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsBloomStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsBloomStatus
            // 
            this.dsBloomStatus.AutoSubscribe = true;
            this.dsBloomStatus.DataSetName = "L3DataSet";
            this.dsBloomStatus.DeleteMethod = null;
            this.dsBloomStatus.InsertMethod = null;
            this.dsBloomStatus.L3DataAdapter = this.Adapter;
            this.dsBloomStatus.LoadEvent = "Click";
            this.dsBloomStatus.LoadTrigger = null;
            this.dsBloomStatus.RefreshValve = 1000;
            this.dsBloomStatus.SourceCommand = null;
            this.dsBloomStatus.SourceCondition = "CODE_GROUP = \'BLOOM_STATUS\'";
            this.dsBloomStatus.SourceMethod = "";
            this.dsBloomStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBloomStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBloomStatus.SubscribeTarget = null;
            this.dsBloomStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBloomStatus});
            this.dsBloomStatus.UpdateEvent = "Click";
            this.dsBloomStatus.UpdateMethod = null;
            this.dsBloomStatus.UpdateTrigger = null;
            // 
            // schemadsBloomStatus
            // 
            this.schemadsBloomStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomStatusL3DataTableCode_Des,
            this.coldsBloomStatusL3DataTableCode_Val_Long});
            this.schemadsBloomStatus.TableName = "L3DataTable";
            // 
            // coldsBloomStatusL3DataTableCode_Des
            // 
            this.coldsBloomStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBloomStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBloomStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBloomStatusL3DataTableCode_Val_Long
            // 
            this.coldsBloomStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBloomStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBloomStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBloomStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "位置";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qAStatusDataGridViewTextBoxColumn
            // 
            this.qAStatusDataGridViewTextBoxColumn.DataPropertyName = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.HeaderText = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.Name = "qAStatusDataGridViewTextBoxColumn";
            this.qAStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.qAStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // qALevelDataGridViewTextBoxColumn
            // 
            this.qALevelDataGridViewTextBoxColumn.DataPropertyName = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.HeaderText = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.Name = "qALevelDataGridViewTextBoxColumn";
            this.qALevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.qALevelDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderContractIDDataGridViewTextBoxColumn
            // 
            this.orderContractIDDataGridViewTextBoxColumn.DataPropertyName = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.HeaderText = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.Name = "orderContractIDDataGridViewTextBoxColumn";
            this.orderContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderContractIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // produceContractIDDataGridViewTextBoxColumn
            // 
            this.produceContractIDDataGridViewTextBoxColumn.DataPropertyName = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.HeaderText = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.Name = "produceContractIDDataGridViewTextBoxColumn";
            this.produceContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.produceContractIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // salesContractIDDataGridViewTextBoxColumn
            // 
            this.salesContractIDDataGridViewTextBoxColumn.DataPropertyName = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.HeaderText = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.Name = "salesContractIDDataGridViewTextBoxColumn";
            this.salesContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesContractIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castingNoDataGridViewTextBoxColumn
            // 
            this.castingNoDataGridViewTextBoxColumn.DataPropertyName = "Casting_No";
            this.castingNoDataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.castingNoDataGridViewTextBoxColumn.Name = "castingNoDataGridViewTextBoxColumn";
            this.castingNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castingHeatCntDataGridViewTextBoxColumn
            // 
            this.castingHeatCntDataGridViewTextBoxColumn.DataPropertyName = "Casting_Heat_Cnt";
            this.castingHeatCntDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.castingHeatCntDataGridViewTextBoxColumn.Name = "castingHeatCntDataGridViewTextBoxColumn";
            this.castingHeatCntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cutSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Cut_SteelGradeIndex";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Name = "cutSteelGradeIndexDataGridViewTextBoxColumn";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Final_SteelGradeIndex";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.Name = "finalSteelGradeIndexDataGridViewTextBoxColumn";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curAreaDataGridViewTextBoxColumn
            // 
            this.curAreaDataGridViewTextBoxColumn.DataPropertyName = "Cur_Area";
            this.curAreaDataGridViewTextBoxColumn.HeaderText = "Cur_Area";
            this.curAreaDataGridViewTextBoxColumn.Name = "curAreaDataGridViewTextBoxColumn";
            this.curAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.curAreaDataGridViewTextBoxColumn.Visible = false;
            // 
            // curSectionIDDataGridViewTextBoxColumn
            // 
            this.curSectionIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Section_ID";
            this.curSectionIDDataGridViewTextBoxColumn.HeaderText = "当前区";
            this.curSectionIDDataGridViewTextBoxColumn.Name = "curSectionIDDataGridViewTextBoxColumn";
            this.curSectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curSectionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // curPileIDDataGridViewTextBoxColumn
            // 
            this.curPileIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Pile_ID";
            this.curPileIDDataGridViewTextBoxColumn.DataSource = this.dsPile;
            this.curPileIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.curPileIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.curPileIDDataGridViewTextBoxColumn.HeaderText = "当前垛";
            this.curPileIDDataGridViewTextBoxColumn.Name = "curPileIDDataGridViewTextBoxColumn";
            this.curPileIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curPileIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.curPileIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.curPileIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.curPileIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsPile
            // 
            this.dsPile.AutoSubscribe = true;
            this.dsPile.DataSetName = "L3DataSet";
            this.dsPile.DeleteMethod = null;
            this.dsPile.InsertMethod = null;
            this.dsPile.L3DataAdapter = this.Adapter;
            this.dsPile.LoadEvent = "Click";
            this.dsPile.LoadTrigger = null;
            this.dsPile.RefreshValve = 1000;
            this.dsPile.SourceCommand = null;
            this.dsPile.SourceCondition = "CODE_GROUP = \'BLOOM_SPILE\'";
            this.dsPile.SourceMethod = "";
            this.dsPile.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPile.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPile.SubscribeTarget = null;
            this.dsPile.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPile});
            this.dsPile.UpdateEvent = "Click";
            this.dsPile.UpdateMethod = null;
            this.dsPile.UpdateTrigger = null;
            // 
            // schemadsPile
            // 
            this.schemadsPile.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPileL3DataTableCode,
            this.coldsPileL3DataTableCode_Des});
            this.schemadsPile.TableName = "L3DataTable";
            // 
            // coldsPileL3DataTableCode
            // 
            this.coldsPileL3DataTableCode.Caption = "Code";
            this.coldsPileL3DataTableCode.ColumnName = "Code";
            this.coldsPileL3DataTableCode.Namespace = "";
            // 
            // coldsPileL3DataTableCode_Des
            // 
            this.coldsPileL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPileL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPileL3DataTableCode_Des.Namespace = "";
            // 
            // curLayerIDDataGridViewTextBoxColumn
            // 
            this.curLayerIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Layer_ID";
            this.curLayerIDDataGridViewTextBoxColumn.HeaderText = "当前层";
            this.curLayerIDDataGridViewTextBoxColumn.Name = "curLayerIDDataGridViewTextBoxColumn";
            this.curLayerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curLayerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // curSeqIDDataGridViewTextBoxColumn
            // 
            this.curSeqIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Seq_ID";
            this.curSeqIDDataGridViewTextBoxColumn.HeaderText = "当前顺序";
            this.curSeqIDDataGridViewTextBoxColumn.Name = "curSeqIDDataGridViewTextBoxColumn";
            this.curSeqIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curSeqIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // curBayIDDataGridViewTextBoxColumn
            // 
            this.curBayIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Bay_ID";
            this.curBayIDDataGridViewTextBoxColumn.HeaderText = "当前跨";
            this.curBayIDDataGridViewTextBoxColumn.Name = "curBayIDDataGridViewTextBoxColumn";
            this.curBayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curBayIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "去向";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotSendFlagDataGridViewTextBoxColumn
            // 
            this.hotSendFlagDataGridViewTextBoxColumn.DataPropertyName = "Hot_Send_Flag";
            this.hotSendFlagDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hotSendFlagDataGridViewTextBoxColumn.Name = "hotSendFlagDataGridViewTextBoxColumn";
            this.hotSendFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processTypeDataGridViewTextBoxColumn
            // 
            this.processTypeDataGridViewTextBoxColumn.DataPropertyName = "Process_Type";
            this.processTypeDataGridViewTextBoxColumn.HeaderText = "处置方式";
            this.processTypeDataGridViewTextBoxColumn.Name = "processTypeDataGridViewTextBoxColumn";
            this.processTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.processTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // planOrdIDDataGridViewTextBoxColumn
            // 
            this.planOrdIDDataGridViewTextBoxColumn.DataPropertyName = "Plan_Ord_ID";
            this.planOrdIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.planOrdIDDataGridViewTextBoxColumn.Name = "planOrdIDDataGridViewTextBoxColumn";
            this.planOrdIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishFlagDataGridViewTextBoxColumn
            // 
            this.finishFlagDataGridViewTextBoxColumn.DataPropertyName = "Finish_Flag";
            this.finishFlagDataGridViewTextBoxColumn.HeaderText = "质量抽检标志";
            this.finishFlagDataGridViewTextBoxColumn.Name = "finishFlagDataGridViewTextBoxColumn";
            this.finishFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishedTimeDataGridViewTextBoxColumn
            // 
            this.finishedTimeDataGridViewTextBoxColumn.DataPropertyName = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn.HeaderText = "质量抽检时间";
            this.finishedTimeDataGridViewTextBoxColumn.Name = "finishedTimeDataGridViewTextBoxColumn";
            this.finishedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloomCountDataGridViewTextBoxColumn
            // 
            this.bloomCountDataGridViewTextBoxColumn.DataPropertyName = "Bloom_Count";
            this.bloomCountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bloomCountDataGridViewTextBoxColumn.Name = "bloomCountDataGridViewTextBoxColumn";
            this.bloomCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calWeightDataGridViewTextBoxColumn
            // 
            this.calWeightDataGridViewTextBoxColumn.DataPropertyName = "Cal_Weight";
            this.calWeightDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.calWeightDataGridViewTextBoxColumn.Name = "calWeightDataGridViewTextBoxColumn";
            this.calWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rightCountDataGridViewTextBoxColumn
            // 
            this.rightCountDataGridViewTextBoxColumn.DataPropertyName = "Right_Count";
            this.rightCountDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rightCountDataGridViewTextBoxColumn.Name = "rightCountDataGridViewTextBoxColumn";
            this.rightCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rightWeightDataGridViewTextBoxColumn
            // 
            this.rightWeightDataGridViewTextBoxColumn.DataPropertyName = "Right_Weight";
            this.rightWeightDataGridViewTextBoxColumn.HeaderText = "合格重量";
            this.rightWeightDataGridViewTextBoxColumn.Name = "rightWeightDataGridViewTextBoxColumn";
            this.rightWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterCountDataGridViewTextBoxColumn
            // 
            this.wasterCountDataGridViewTextBoxColumn.DataPropertyName = "Waster_Count";
            this.wasterCountDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总长度";
            this.wasterCountDataGridViewTextBoxColumn.Name = "wasterCountDataGridViewTextBoxColumn";
            this.wasterCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeightDataGridViewTextBoxColumn
            // 
            this.wasterWeightDataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight";
            this.wasterWeightDataGridViewTextBoxColumn.HeaderText = "甩废重量";
            this.wasterWeightDataGridViewTextBoxColumn.Name = "wasterWeightDataGridViewTextBoxColumn";
            this.wasterWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterCount1DataGridViewTextBoxColumn
            // 
            this.wasterCount1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count1";
            this.wasterCount1DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度1";
            this.wasterCount1DataGridViewTextBoxColumn.Name = "wasterCount1DataGridViewTextBoxColumn";
            this.wasterCount1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight1DataGridViewTextBoxColumn
            // 
            this.wasterWeight1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight1";
            this.wasterWeight1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wasterWeight1DataGridViewTextBoxColumn.Name = "wasterWeight1DataGridViewTextBoxColumn";
            this.wasterWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // wasterReason1DataGridViewTextBoxColumn
            // 
            this.wasterReason1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason1";
            this.wasterReason1DataGridViewTextBoxColumn.DataSource = this.bsWasterReason1;
            this.wasterReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wasterReason1DataGridViewTextBoxColumn.Name = "wasterReason1DataGridViewTextBoxColumn";
            this.wasterReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wasterCount2DataGridViewTextBoxColumn
            // 
            this.wasterCount2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count2";
            this.wasterCount2DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度2";
            this.wasterCount2DataGridViewTextBoxColumn.Name = "wasterCount2DataGridViewTextBoxColumn";
            this.wasterCount2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight2DataGridViewTextBoxColumn
            // 
            this.wasterWeight2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight2";
            this.wasterWeight2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wasterWeight2DataGridViewTextBoxColumn.Name = "wasterWeight2DataGridViewTextBoxColumn";
            this.wasterWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterReason2DataGridViewTextBoxColumn
            // 
            this.wasterReason2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason2";
            this.wasterReason2DataGridViewTextBoxColumn.DataSource = this.bsWasterReason2;
            this.wasterReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wasterReason2DataGridViewTextBoxColumn.Name = "wasterReason2DataGridViewTextBoxColumn";
            this.wasterReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wasterCount3DataGridViewTextBoxColumn
            // 
            this.wasterCount3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count3";
            this.wasterCount3DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度3";
            this.wasterCount3DataGridViewTextBoxColumn.Name = "wasterCount3DataGridViewTextBoxColumn";
            this.wasterCount3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight3DataGridViewTextBoxColumn
            // 
            this.wasterWeight3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight3";
            this.wasterWeight3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wasterWeight3DataGridViewTextBoxColumn.Name = "wasterWeight3DataGridViewTextBoxColumn";
            this.wasterWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterReason3DataGridViewTextBoxColumn
            // 
            this.wasterReason3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason3";
            this.wasterReason3DataGridViewTextBoxColumn.DataSource = this.bsWasterReason3;
            this.wasterReason3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wasterReason3DataGridViewTextBoxColumn.Name = "wasterReason3DataGridViewTextBoxColumn";
            this.wasterReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason3DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wrongCountDataGridViewTextBoxColumn
            // 
            this.wrongCountDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count";
            this.wrongCountDataGridViewTextBoxColumn.HeaderText = "不合格钢坯总支数";
            this.wrongCountDataGridViewTextBoxColumn.Name = "wrongCountDataGridViewTextBoxColumn";
            this.wrongCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongWeightDataGridViewTextBoxColumn
            // 
            this.wrongWeightDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight";
            this.wrongWeightDataGridViewTextBoxColumn.HeaderText = "不合格总重量";
            this.wrongWeightDataGridViewTextBoxColumn.Name = "wrongWeightDataGridViewTextBoxColumn";
            this.wrongWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongCount1DataGridViewTextBoxColumn
            // 
            this.wrongCount1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count1";
            this.wrongCount1DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数1";
            this.wrongCount1DataGridViewTextBoxColumn.Name = "wrongCount1DataGridViewTextBoxColumn";
            this.wrongCount1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongWeight1DataGridViewTextBoxColumn
            // 
            this.wrongWeight1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight1";
            this.wrongWeight1DataGridViewTextBoxColumn.HeaderText = "不合格重量1";
            this.wrongWeight1DataGridViewTextBoxColumn.Name = "wrongWeight1DataGridViewTextBoxColumn";
            this.wrongWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongReason1DataGridViewTextBoxColumn
            // 
            this.wrongReason1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason1";
            this.wrongReason1DataGridViewTextBoxColumn.DataSource = this.bsWrongReason1;
            this.wrongReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason1DataGridViewTextBoxColumn.HeaderText = "不合格原因1";
            this.wrongReason1DataGridViewTextBoxColumn.Name = "wrongReason1DataGridViewTextBoxColumn";
            this.wrongReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wrongCount2DataGridViewTextBoxColumn
            // 
            this.wrongCount2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count2";
            this.wrongCount2DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数2";
            this.wrongCount2DataGridViewTextBoxColumn.Name = "wrongCount2DataGridViewTextBoxColumn";
            this.wrongCount2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongWeight2DataGridViewTextBoxColumn
            // 
            this.wrongWeight2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight2";
            this.wrongWeight2DataGridViewTextBoxColumn.HeaderText = "不合格重量2";
            this.wrongWeight2DataGridViewTextBoxColumn.Name = "wrongWeight2DataGridViewTextBoxColumn";
            this.wrongWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongReason2DataGridViewTextBoxColumn
            // 
            this.wrongReason2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason2";
            this.wrongReason2DataGridViewTextBoxColumn.DataSource = this.bsWrongReason2;
            this.wrongReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason2DataGridViewTextBoxColumn.HeaderText = "不合格原因2";
            this.wrongReason2DataGridViewTextBoxColumn.Name = "wrongReason2DataGridViewTextBoxColumn";
            this.wrongReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wrongCount3DataGridViewTextBoxColumn
            // 
            this.wrongCount3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count3";
            this.wrongCount3DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数3";
            this.wrongCount3DataGridViewTextBoxColumn.Name = "wrongCount3DataGridViewTextBoxColumn";
            this.wrongCount3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrongWeight3DataGridViewTextBoxColumn
            // 
            this.wrongWeight3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight3";
            this.wrongWeight3DataGridViewTextBoxColumn.DataSource = this.bsWrongReason3;
            this.wrongWeight3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongWeight3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongWeight3DataGridViewTextBoxColumn.HeaderText = "不合格重量3";
            this.wrongWeight3DataGridViewTextBoxColumn.Name = "wrongWeight3DataGridViewTextBoxColumn";
            this.wrongWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongWeight3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongWeight3DataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // wrongReason3DataGridViewTextBoxColumn
            // 
            this.wrongReason3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason3";
            this.wrongReason3DataGridViewTextBoxColumn.HeaderText = "不合格原因3";
            this.wrongReason3DataGridViewTextBoxColumn.Name = "wrongReason3DataGridViewTextBoxColumn";
            this.wrongReason3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sufaceDefactDesDataGridViewTextBoxColumn
            // 
            this.sufaceDefactDesDataGridViewTextBoxColumn.DataPropertyName = "SufaceDefactDes";
            this.sufaceDefactDesDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sufaceDefactDesDataGridViewTextBoxColumn.Name = "sufaceDefactDesDataGridViewTextBoxColumn";
            this.sufaceDefactDesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 264);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "炉坯详细信息";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmbWrongReason3);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cmbWrongReason2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbWrongReason1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbWasterReason3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cmbWasterReason2);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.cmbWasterReason1);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.lblSufaceDefactDes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblWrong_Weight3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblWrong_Count3);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lblWrong_Weight1);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.lblWaster_Weight3);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.lblWrong_Count1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblWaster_Count3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblWrong_Weight2);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.lblWrong_Weight);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.lblWrong_Count2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblWrong_Count);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.lblWaster_Weight2);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.lblWaster_Count2);
            this.panel1.Controls.Add(this.label63);
            this.panel1.Controls.Add(this.lblWaster_Weight1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblWaster_Count1);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.lblWaster_Weight);
            this.panel1.Controls.Add(this.label64);
            this.panel1.Controls.Add(this.lblWaster_Count);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.lblRight_Weight);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Controls.Add(this.lblRight_Count);
            this.panel1.Controls.Add(this.label65);
            this.panel1.Controls.Add(this.lblCal_Weight);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.lblBloom_Count);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.lblThickness);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.lblLength);
            this.panel1.Controls.Add(this.label57);
            this.panel1.Controls.Add(this.lblSteelGradeIndex);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.lblHeatID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 246);
            this.panel1.TabIndex = 38;
            // 
            // cmbWrongReason3
            // 
            this.cmbWrongReason3.BackColor = System.Drawing.SystemColors.Window;
            this.cmbWrongReason3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Wrong_Reason3", true));
            this.cmbWrongReason3.DataSource = this.bsWrongReason3;
            this.cmbWrongReason3.DisplayMember = "Code_Des";
            this.cmbWrongReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason3.Enabled = false;
            this.cmbWrongReason3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWrongReason3.FormattingEnabled = true;
            this.cmbWrongReason3.Location = new System.Drawing.Point(641, 216);
            this.cmbWrongReason3.Name = "cmbWrongReason3";
            this.cmbWrongReason3.Size = new System.Drawing.Size(220, 20);
            this.cmbWrongReason3.TabIndex = 105;
            this.cmbWrongReason3.ValueMember = "Code";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(396, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "甩废重量1:";
            // 
            // cmbWrongReason2
            // 
            this.cmbWrongReason2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Wrong_Reason2", true));
            this.cmbWrongReason2.DataSource = this.bsWrongReason2;
            this.cmbWrongReason2.DisplayMember = "Code_Des";
            this.cmbWrongReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason2.Enabled = false;
            this.cmbWrongReason2.FormattingEnabled = true;
            this.cmbWrongReason2.Location = new System.Drawing.Point(641, 187);
            this.cmbWrongReason2.Name = "cmbWrongReason2";
            this.cmbWrongReason2.Size = new System.Drawing.Size(220, 20);
            this.cmbWrongReason2.TabIndex = 104;
            this.cmbWrongReason2.ValueMember = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号:";
            // 
            // cmbWrongReason1
            // 
            this.cmbWrongReason1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Wrong_Reason1", true));
            this.cmbWrongReason1.DataSource = this.bsWrongReason1;
            this.cmbWrongReason1.DisplayMember = "Code_Des";
            this.cmbWrongReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason1.Enabled = false;
            this.cmbWrongReason1.FormattingEnabled = true;
            this.cmbWrongReason1.Location = new System.Drawing.Point(641, 158);
            this.cmbWrongReason1.Name = "cmbWrongReason1";
            this.cmbWrongReason1.Size = new System.Drawing.Size(220, 20);
            this.cmbWrongReason1.TabIndex = 103;
            this.cmbWrongReason1.ValueMember = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "炼钢记号:";
            // 
            // cmbWasterReason3
            // 
            this.cmbWasterReason3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Waster_Reason3", true));
            this.cmbWasterReason3.DataSource = this.bsWasterReason3;
            this.cmbWasterReason3.DisplayMember = "Code_Des";
            this.cmbWasterReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason3.Enabled = false;
            this.cmbWasterReason3.FormattingEnabled = true;
            this.cmbWasterReason3.Location = new System.Drawing.Point(641, 129);
            this.cmbWasterReason3.Name = "cmbWasterReason3";
            this.cmbWasterReason3.Size = new System.Drawing.Size(220, 20);
            this.cmbWasterReason3.TabIndex = 102;
            this.cmbWasterReason3.ValueMember = "Code";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(426, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "长度:";
            // 
            // cmbWasterReason2
            // 
            this.cmbWasterReason2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Waster_Reason2", true));
            this.cmbWasterReason2.DataSource = this.bsWasterReason2;
            this.cmbWasterReason2.DisplayMember = "Code_Des";
            this.cmbWasterReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason2.Enabled = false;
            this.cmbWasterReason2.FormattingEnabled = true;
            this.cmbWasterReason2.Location = new System.Drawing.Point(641, 100);
            this.cmbWasterReason2.Name = "cmbWasterReason2";
            this.cmbWasterReason2.Size = new System.Drawing.Size(220, 20);
            this.cmbWasterReason2.TabIndex = 101;
            this.cmbWasterReason2.ValueMember = "Code";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(597, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "宽度:";
            // 
            // cmbWasterReason1
            // 
            this.cmbWasterReason1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloom, "Waster_Reason1", true));
            this.cmbWasterReason1.DataSource = this.bsWasterReason1;
            this.cmbWasterReason1.DisplayMember = "Code_Des";
            this.cmbWasterReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason1.Enabled = false;
            this.cmbWasterReason1.FormattingEnabled = true;
            this.cmbWasterReason1.Location = new System.Drawing.Point(641, 71);
            this.cmbWasterReason1.Name = "cmbWasterReason1";
            this.cmbWasterReason1.Size = new System.Drawing.Size(220, 20);
            this.cmbWasterReason1.TabIndex = 100;
            this.cmbWasterReason1.ValueMember = "Code";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(742, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(35, 12);
            this.label35.TabIndex = 0;
            this.label35.Text = "厚度:";
            // 
            // lblSufaceDefactDes
            // 
            this.lblSufaceDefactDes.AutoSize = true;
            this.lblSufaceDefactDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "SufaceDefactDes", true));
            this.lblSufaceDefactDes.Location = new System.Drawing.Point(467, 46);
            this.lblSufaceDefactDes.Name = "lblSufaceDefactDes";
            this.lblSufaceDefactDes.Size = new System.Drawing.Size(245, 12);
            this.lblSufaceDefactDes.TabIndex = 0;
            this.lblSufaceDefactDes.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "钢坯支数:";
            // 
            // lblWrong_Weight3
            // 
            this.lblWrong_Weight3.AutoSize = true;
            this.lblWrong_Weight3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight3", true));
            this.lblWrong_Weight3.Location = new System.Drawing.Point(467, 220);
            this.lblWrong_Weight3.Name = "lblWrong_Weight3";
            this.lblWrong_Weight3.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Weight3.TabIndex = 0;
            this.lblWrong_Weight3.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "理论重量:";
            // 
            // lblWrong_Count3
            // 
            this.lblWrong_Count3.AutoSize = true;
            this.lblWrong_Count3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Count3", true));
            this.lblWrong_Count3.Location = new System.Drawing.Point(309, 220);
            this.lblWrong_Count3.Name = "lblWrong_Count3";
            this.lblWrong_Count3.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Count3.TabIndex = 0;
            this.lblWrong_Count3.Text = "label1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(81, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "合格支数:";
            // 
            // lblWrong_Weight1
            // 
            this.lblWrong_Weight1.AutoSize = true;
            this.lblWrong_Weight1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Wrong_Weight1", true));
            this.lblWrong_Weight1.Location = new System.Drawing.Point(467, 162);
            this.lblWrong_Weight1.Name = "lblWrong_Weight1";
            this.lblWrong_Weight1.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Weight1.TabIndex = 0;
            this.lblWrong_Weight1.Text = "label1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(81, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "出坯总重量:";
            // 
            // lblWaster_Weight3
            // 
            this.lblWaster_Weight3.AutoSize = true;
            this.lblWaster_Weight3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight3", true));
            this.lblWaster_Weight3.Location = new System.Drawing.Point(467, 133);
            this.lblWaster_Weight3.Name = "lblWaster_Weight3";
            this.lblWaster_Weight3.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Weight3.TabIndex = 0;
            this.lblWaster_Weight3.Text = "label1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(69, 133);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 12);
            this.label36.TabIndex = 0;
            this.label36.Text = "甩废总长度:";
            // 
            // lblWrong_Count1
            // 
            this.lblWrong_Count1.AutoSize = true;
            this.lblWrong_Count1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Wrong_Count1", true));
            this.lblWrong_Count1.Location = new System.Drawing.Point(309, 162);
            this.lblWrong_Count1.Name = "lblWrong_Count1";
            this.lblWrong_Count1.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Count1.TabIndex = 0;
            this.lblWrong_Count1.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "甩废总重量:";
            // 
            // lblWaster_Count3
            // 
            this.lblWaster_Count3.AutoSize = true;
            this.lblWaster_Count3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Count3", true));
            this.lblWaster_Count3.Location = new System.Drawing.Point(309, 133);
            this.lblWaster_Count3.Name = "lblWaster_Count3";
            this.lblWaster_Count3.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Count3.TabIndex = 0;
            this.lblWaster_Count3.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "甩废长度1:";
            // 
            // lblWrong_Weight2
            // 
            this.lblWrong_Weight2.AutoSize = true;
            this.lblWrong_Weight2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight2", true));
            this.lblWrong_Weight2.Location = new System.Drawing.Point(467, 191);
            this.lblWrong_Weight2.Name = "lblWrong_Weight2";
            this.lblWrong_Weight2.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Weight2.TabIndex = 0;
            this.lblWrong_Weight2.Text = "label1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(567, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "甩废原因1:";
            // 
            // lblWrong_Weight
            // 
            this.lblWrong_Weight.AutoSize = true;
            this.lblWrong_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Wrong_Weight", true));
            this.lblWrong_Weight.Location = new System.Drawing.Point(160, 220);
            this.lblWrong_Weight.Name = "lblWrong_Weight";
            this.lblWrong_Weight.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Weight.TabIndex = 0;
            this.lblWrong_Weight.Text = "label1";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(238, 104);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 0;
            this.label37.Text = "甩废长度2:";
            // 
            // lblWrong_Count2
            // 
            this.lblWrong_Count2.AutoSize = true;
            this.lblWrong_Count2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Wrong_Count2", true));
            this.lblWrong_Count2.Location = new System.Drawing.Point(309, 191);
            this.lblWrong_Count2.Name = "lblWrong_Count2";
            this.lblWrong_Count2.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Count2.TabIndex = 0;
            this.lblWrong_Count2.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "甩废重量2:";
            // 
            // lblWrong_Count
            // 
            this.lblWrong_Count.AutoSize = true;
            this.lblWrong_Count.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Wrong_Count", true));
            this.lblWrong_Count.Location = new System.Drawing.Point(160, 191);
            this.lblWrong_Count.Name = "lblWrong_Count";
            this.lblWrong_Count.Size = new System.Drawing.Size(41, 12);
            this.lblWrong_Count.TabIndex = 0;
            this.lblWrong_Count.Text = "label1";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(555, 220);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 12);
            this.label43.TabIndex = 0;
            this.label43.Text = "不合格原因3:";
            // 
            // lblWaster_Weight2
            // 
            this.lblWaster_Weight2.AutoSize = true;
            this.lblWaster_Weight2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight2", true));
            this.lblWaster_Weight2.Location = new System.Drawing.Point(467, 104);
            this.lblWaster_Weight2.Name = "lblWaster_Weight2";
            this.lblWaster_Weight2.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Weight2.TabIndex = 0;
            this.lblWaster_Weight2.Text = "label1";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(57, 191);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(83, 12);
            this.label53.TabIndex = 0;
            this.label53.Text = "不合格总支数:";
            // 
            // lblWaster_Count2
            // 
            this.lblWaster_Count2.AutoSize = true;
            this.lblWaster_Count2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Count2", true));
            this.lblWaster_Count2.Location = new System.Drawing.Point(309, 104);
            this.lblWaster_Count2.Name = "lblWaster_Count2";
            this.lblWaster_Count2.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Count2.TabIndex = 0;
            this.lblWaster_Count2.Text = "label1";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(226, 191);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(77, 12);
            this.label63.TabIndex = 0;
            this.label63.Text = "不合格支数2:";
            // 
            // lblWaster_Weight1
            // 
            this.lblWaster_Weight1.AutoSize = true;
            this.lblWaster_Weight1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight1", true));
            this.lblWaster_Weight1.Location = new System.Drawing.Point(467, 75);
            this.lblWaster_Weight1.Name = "lblWaster_Weight1";
            this.lblWaster_Weight1.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Weight1.TabIndex = 0;
            this.lblWaster_Weight1.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(567, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "甩废原因2:";
            // 
            // lblWaster_Count1
            // 
            this.lblWaster_Count1.AutoSize = true;
            this.lblWaster_Count1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Count1", true));
            this.lblWaster_Count1.Location = new System.Drawing.Point(309, 75);
            this.lblWaster_Count1.Name = "lblWaster_Count1";
            this.lblWaster_Count1.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Count1.TabIndex = 0;
            this.lblWaster_Count1.Text = "label1";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(57, 220);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 12);
            this.label54.TabIndex = 0;
            this.label54.Text = "不合格总重量:";
            // 
            // lblWaster_Weight
            // 
            this.lblWaster_Weight.AutoSize = true;
            this.lblWaster_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Weight", true));
            this.lblWaster_Weight.Location = new System.Drawing.Point(160, 162);
            this.lblWaster_Weight.Name = "lblWaster_Weight";
            this.lblWaster_Weight.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Weight.TabIndex = 0;
            this.lblWaster_Weight.Text = "label1";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(384, 191);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(77, 12);
            this.label64.TabIndex = 0;
            this.label64.Text = "不合格重量2:";
            // 
            // lblWaster_Count
            // 
            this.lblWaster_Count.AutoSize = true;
            this.lblWaster_Count.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Waster_Count", true));
            this.lblWaster_Count.Location = new System.Drawing.Point(160, 133);
            this.lblWaster_Count.Name = "lblWaster_Count";
            this.lblWaster_Count.Size = new System.Drawing.Size(41, 12);
            this.lblWaster_Count.TabIndex = 0;
            this.lblWaster_Count.Text = "label1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(238, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "甩废长度3:";
            // 
            // lblRight_Weight
            // 
            this.lblRight_Weight.AutoSize = true;
            this.lblRight_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Right_Weight", true));
            this.lblRight_Weight.Location = new System.Drawing.Point(160, 75);
            this.lblRight_Weight.Name = "lblRight_Weight";
            this.lblRight_Weight.Size = new System.Drawing.Size(41, 12);
            this.lblRight_Weight.TabIndex = 0;
            this.lblRight_Weight.Text = "label1";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(226, 162);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(77, 12);
            this.label55.TabIndex = 0;
            this.label55.Text = "不合格支数1:";
            // 
            // lblRight_Count
            // 
            this.lblRight_Count.AutoSize = true;
            this.lblRight_Count.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Right_Count", true));
            this.lblRight_Count.Location = new System.Drawing.Point(160, 104);
            this.lblRight_Count.Name = "lblRight_Count";
            this.lblRight_Count.Size = new System.Drawing.Size(41, 12);
            this.lblRight_Count.TabIndex = 0;
            this.lblRight_Count.Text = "label1";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(555, 191);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(77, 12);
            this.label65.TabIndex = 0;
            this.label65.Text = "不合格原因2:";
            // 
            // lblCal_Weight
            // 
            this.lblCal_Weight.AutoSize = true;
            this.lblCal_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Cal_Weight", true));
            this.lblCal_Weight.Location = new System.Drawing.Point(309, 46);
            this.lblCal_Weight.Name = "lblCal_Weight";
            this.lblCal_Weight.Size = new System.Drawing.Size(41, 12);
            this.lblCal_Weight.TabIndex = 0;
            this.lblCal_Weight.Text = "label1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(396, 133);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "甩废重量3:";
            // 
            // lblBloom_Count
            // 
            this.lblBloom_Count.AutoSize = true;
            this.lblBloom_Count.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Bloom_Count", true));
            this.lblBloom_Count.Location = new System.Drawing.Point(160, 46);
            this.lblBloom_Count.Name = "lblBloom_Count";
            this.lblBloom_Count.Size = new System.Drawing.Size(41, 12);
            this.lblBloom_Count.TabIndex = 0;
            this.lblBloom_Count.Text = "label1";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(384, 162);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(77, 12);
            this.label56.TabIndex = 0;
            this.label56.Text = "不合格重量1:";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Thickness", true));
            this.lblThickness.Location = new System.Drawing.Point(783, 17);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(41, 12);
            this.lblThickness.TabIndex = 0;
            this.lblThickness.Text = "label1";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(226, 220);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(77, 12);
            this.label66.TabIndex = 0;
            this.label66.Text = "不合格支数3:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Width", true));
            this.lblWidth.Location = new System.Drawing.Point(639, 17);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 12);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "label1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(567, 133);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(65, 12);
            this.label38.TabIndex = 0;
            this.label38.Text = "甩废原因3:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "Length", true));
            this.lblLength.Location = new System.Drawing.Point(467, 17);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(41, 12);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "label1";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(555, 162);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(77, 12);
            this.label57.TabIndex = 0;
            this.label57.Text = "不合格原因1:";
            // 
            // lblSteelGradeIndex
            // 
            this.lblSteelGradeIndex.AutoSize = true;
            this.lblSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "SteelGradeIndex", true));
            this.lblSteelGradeIndex.Location = new System.Drawing.Point(309, 17);
            this.lblSteelGradeIndex.Name = "lblSteelGradeIndex";
            this.lblSteelGradeIndex.Size = new System.Drawing.Size(41, 12);
            this.lblSteelGradeIndex.TabIndex = 0;
            this.lblSteelGradeIndex.Text = "label1";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(384, 220);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(77, 12);
            this.label67.TabIndex = 0;
            this.label67.Text = "不合格重量3:";
            // 
            // lblHeatID
            // 
            this.lblHeatID.AutoSize = true;
            this.lblHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloom, "MaterialID", true));
            this.lblHeatID.Location = new System.Drawing.Point(160, 17);
            this.lblHeatID.Name = "lblHeatID";
            this.lblHeatID.Size = new System.Drawing.Size(41, 12);
            this.lblHeatID.TabIndex = 0;
            this.lblHeatID.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "表面缺陷描述:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsBloom;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnHotJudge,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel5,
            this.cmbCCMID,
            this.toolStripLabel3,
            this.dtProduceDate,
            this.toolStripLabel6});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 37;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel1.Text = "待热检炉批信息";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // btnHotJudge
            // 
            this.btnHotJudge.Image = ((System.Drawing.Image)(resources.GetObject("btnHotJudge.Image")));
            this.btnHotJudge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHotJudge.Name = "btnHotJudge";
            this.btnHotJudge.Size = new System.Drawing.Size(73, 22);
            this.btnHotJudge.Text = "质量判定";
            this.btnHotJudge.Click += new System.EventHandler(this.btnHotJudge_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "  ";
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
            // cmbCCMID
            // 
            this.cmbCCMID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCCMID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCCMID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCCMID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCMID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCCMID.Name = "cmbCCMID";
            this.cmbCCMID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel3.Text = "铸机号:";
            // 
            // dtProduceDate
            // 
            this.dtProduceDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtProduceDate.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtProduceDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtProduceDate.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtProduceDate.CustomFormat = "yyyy-MM-dd";
            this.dtProduceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProduceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtProduceDate.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtProduceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtProduceDate.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtProduceDate.Name = "dtProduceDate";
            this.dtProduceDate.Size = new System.Drawing.Size(100, 22);
            this.dtProduceDate.Text = "2008-11-16";
            this.dtProduceDate.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            this.dtProduceDate.Visible = false;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "生产日期:";
            this.toolStripLabel6.Visible = false;
            // 
            // dsCCMID
            // 
            this.dsCCMID.AutoSubscribe = true;
            this.dsCCMID.DataSetName = "L3DataSet";
            this.dsCCMID.DeleteMethod = "";
            this.dsCCMID.InsertMethod = "";
            this.dsCCMID.L3DataAdapter = this.Adapter;
            this.dsCCMID.LoadEvent = "";
            this.dsCCMID.LoadTrigger = null;
            this.dsCCMID.RefreshValve = 1000;
            this.dsCCMID.SourceCommand = null;
            this.dsCCMID.SourceCondition = "Code_Group = \'Caster\' order by Code";
            this.dsCCMID.SourceMethod = "";
            this.dsCCMID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCMID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCCMID.SubscribeTarget = null;
            this.dsCCMID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMID});
            this.dsCCMID.UpdateEvent = "";
            this.dsCCMID.UpdateMethod = "";
            this.dsCCMID.UpdateTrigger = null;
            // 
            // schemadsCCMID
            // 
            this.schemadsCCMID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMIDL3DataTableCode});
            this.schemadsCCMID.TableName = "L3DataTable";
            // 
            // coldsCCMIDL3DataTableCode
            // 
            this.coldsCCMIDL3DataTableCode.Caption = "Code";
            this.coldsCCMIDL3DataTableCode.ColumnName = "Code";
            this.coldsCCMIDL3DataTableCode.Namespace = "";
            // 
            // HotJudgeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotJudgeFrm";
            this.TabText = "热检质量判定管理";
            this.Text = "热检质量判定判定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotJudgeFrm_FormClosing);
            this.Load += new System.EventHandler(this.HotJudgeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBloom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBloom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsBloom;
        private System.Windows.Forms.BindingSource bsBloom;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableMaterialID;
        private System.Data.DataColumn coll3DataSet1L3DataTableStatus;
        private System.Data.DataColumn coll3DataSet1L3DataTablePosition;
        private System.Data.DataColumn coll3DataSet1L3DataTableQAStatus;
        private System.Data.DataColumn coll3DataSet1L3DataTableQALevel;
        private System.Data.DataColumn coll3DataSet1L3DataTableOrderContractID;
        private System.Data.DataColumn coll3DataSet1L3DataTableProduceContractID;
        private System.Data.DataColumn coll3DataSet1L3DataTableSalesContractID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCasting_No;
        private System.Data.DataColumn coll3DataSet1L3DataTableCasting_Heat_Cnt;
        private System.Data.DataColumn coll3DataSet1L3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coll3DataSet1L3DataTableSteelGradeIndex;
        private System.Data.DataColumn coll3DataSet1L3DataTableCut_SteelGradeIndex;
        private System.Data.DataColumn coll3DataSet1L3DataTableFinal_SteelGradeIndex;
        private System.Data.DataColumn coll3DataSet1L3DataTableLength;
        private System.Data.DataColumn coll3DataSet1L3DataTableWidth;
        private System.Data.DataColumn coll3DataSet1L3DataTableThickness;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Area;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Section_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Pile_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Layer_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Seq_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCur_Bay_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableDestination;
        private System.Data.DataColumn coll3DataSet1L3DataTableHot_Send_Flag;
        private System.Data.DataColumn coll3DataSet1L3DataTableProcess_Type;
        private System.Data.DataColumn coll3DataSet1L3DataTablePlan_Ord_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableProduce_Date;
        private System.Data.DataColumn coll3DataSet1L3DataTableFinish_Flag;
        private System.Data.DataColumn coll3DataSet1L3DataTableFinishedTime;
        private System.Data.DataColumn coll3DataSet1L3DataTableBloom_Count;
        private System.Data.DataColumn coll3DataSet1L3DataTableCal_Weight;
        private System.Data.DataColumn coll3DataSet1L3DataTableRight_Count;
        private System.Data.DataColumn coll3DataSet1L3DataTableRight_Weight;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Count;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Weight;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Count1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Weight1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Reason1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Count2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Weight2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Reason2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Count3;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Weight3;
        private System.Data.DataColumn coll3DataSet1L3DataTableWaster_Reason3;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Count;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Weight;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Count1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Weight1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Reason1;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Count2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Weight2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Reason2;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Count3;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Weight3;
        private System.Data.DataColumn coll3DataSet1L3DataTableWrong_Reason3;
        private System.Data.DataColumn coll3DataSet1L3DataTableSufaceDefactDes;
        private System.Data.DataColumn coll3DataSet1L3DataTableReason;
        private System.Windows.Forms.BindingSource bsWrongReason3;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWrongReason2;
        private System.Windows.Forms.BindingSource bsWrongReason1;
        private System.Windows.Forms.BindingSource bsWasterReason3;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWasterReason2;
        private System.Windows.Forms.BindingSource bsWasterReason1;
        private AppSvrHMI.L3DataSet dsPile;
        private System.Data.DataTable schemadsPile;
        private System.Data.DataColumn coldsPileL3DataTableCode;
        private System.Data.DataColumn coldsPileL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBloomStatus;
        private System.Data.DataTable schemadsBloomStatus;
        private System.Data.DataColumn coldsBloomStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsBloomStatusL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnHotJudge;
        private System.Data.DataColumn coldsBloomL3DataTableCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dvBloom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbWrongReason3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbWrongReason2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWrongReason1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbWasterReason3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbWasterReason2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbWasterReason1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblSufaceDefactDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWrong_Weight3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblWrong_Count3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblWrong_Weight1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblWaster_Weight3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblWrong_Count1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWaster_Count3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblWrong_Weight2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblWrong_Weight;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblWrong_Count2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWrong_Count;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblWaster_Weight2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lblWaster_Count2;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label lblWaster_Weight1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblWaster_Count1;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblWaster_Weight;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lblWaster_Count;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblRight_Weight;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label lblRight_Count;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblCal_Weight;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblBloom_Count;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label lblSteelGradeIndex;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lblHeatID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbCCMID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtProduceDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castingNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castingHeatCntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curSectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn curPileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curLayerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curSeqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curBayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotSendFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planOrdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloomCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sufaceDefactDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsCCMID;
        private System.Data.DataTable schemadsCCMID;
        private System.Data.DataColumn coldsCCMIDL3DataTableCode;
    }
}