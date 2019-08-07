namespace QualityMag.QualityStandard
{
    partial class ProduceSheetMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduceSheetMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsProduceSheetMainten = new System.Windows.Forms.BindingSource(this.components);
            this.dsProduceSheetMainten = new AppSvrHMI.L3DataSet();
            this.schemadsProduceSheetMainten = new System.Data.DataTable();
            this.coldsProduceSheetMaintenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableName = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLadle_Brick = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLadle_Use = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLadle_Stay = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableBOF_Type = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableLF_Type = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableRH_Type = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCaster_Type = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableC_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableC_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableC_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSi_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSi_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSi_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMn_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMn_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMn_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableP_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableS_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCu_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCu_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCu_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNi_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNi_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNi_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCr_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCr_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCr_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMo_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMo_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableMo_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableV_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableV_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableV_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNb_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNb_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableNb_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAl_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAl_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAl_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAlS_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAlS_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAlS_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableTi_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableTi_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableTi_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableB_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableB_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableB_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSb_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSb_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSb_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSn_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSn_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableSn_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAs_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAs_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAs_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZn_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZn_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZn_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZr_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZr_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableZr_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCa_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCa_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCa_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableW_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableW_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableW_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTablePb_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTablePb_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTablePb_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableRe_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableRe_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableRe_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCeq_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCeq_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCeq_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableN_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableN_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableN_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableH_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableH_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableH_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableO_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableO_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableO_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther1_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther1_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther1_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther2_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther2_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther2_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNi_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNi_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNi_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrCu_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrCu_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrCu_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Max = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther3_Min = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther3_Aim = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableOther3_Max = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanelProduceSheetMainten = new HMIBase.HMIRootPanel();
            this.dvProduceSheetMainten = new System.Windows.Forms.DataGridView();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsProduceSheetMaintenL3DataTableAOD_Type = new System.Data.DataColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleBrickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladlePreSteelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleTappedProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AOD_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotSendFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi_Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi_Aim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi_Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu_Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu_Aim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu_Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu_Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu_Aim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu_Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1MinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1AimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1MaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2MinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2AimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2MaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3_Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3_Aim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3_Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduceSheetMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduceSheetMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProduceSheetMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProduceSheetMainten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProduceSheetMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnProdSheet");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnProdSheet");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnProdSheet");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnProdSheet");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnProdSheet");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 14;
            this.toolStripMain.Text = "toolStrip1";
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
            // bsProduceSheetMainten
            // 
            this.bsProduceSheetMainten.DataMember = "L3DataTable";
            this.bsProduceSheetMainten.DataSource = this.dsProduceSheetMainten;
            // 
            // dsProduceSheetMainten
            // 
            this.dsProduceSheetMainten.AutoLoad = true;
            this.dsProduceSheetMainten.AutoSubscribe = false;
            this.dsProduceSheetMainten.DataSetName = "L3DataSet";
            this.dsProduceSheetMainten.DeleteMethod = null;
            this.dsProduceSheetMainten.InsertMethod = null;
            this.dsProduceSheetMainten.L3DataAdapter = this.Adapter;
            this.dsProduceSheetMainten.LoadEvent = "Click";
            this.dsProduceSheetMainten.LoadTrigger = null;
            this.dsProduceSheetMainten.RefreshValve = 1000;
            this.dsProduceSheetMainten.SourceCommand = null;
            this.dsProduceSheetMainten.SourceCondition = "1=2";
            this.dsProduceSheetMainten.SourceMethod = "";
            this.dsProduceSheetMainten.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProduceSheetMainten.SourceURI = "XGMESLogic\\QualityMag\\CQA_Product_Sheet";
            this.dsProduceSheetMainten.SubscribeTarget = null;
            this.dsProduceSheetMainten.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProduceSheetMainten});
            this.dsProduceSheetMainten.UpdateEvent = "Click";
            this.dsProduceSheetMainten.UpdateMethod = null;
            this.dsProduceSheetMainten.UpdateTrigger = null;
            // 
            // schemadsProduceSheetMainten
            // 
            this.schemadsProduceSheetMainten.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProduceSheetMaintenL3DataTableGUID,
            this.coldsProduceSheetMaintenL3DataTableName,
            this.coldsProduceSheetMaintenL3DataTableSteelGradeIndex,
            this.coldsProduceSheetMaintenL3DataTableLadle_Brick,
            this.coldsProduceSheetMaintenL3DataTableLadle_Use,
            this.coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade,
            this.coldsProduceSheetMaintenL3DataTableLadle_Stay,
            this.coldsProduceSheetMaintenL3DataTableBOF_Type,
            this.coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc,
            this.coldsProduceSheetMaintenL3DataTableLF_Type,
            this.coldsProduceSheetMaintenL3DataTableRH_Type,
            this.coldsProduceSheetMaintenL3DataTableCaster_Type,
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag,
            this.coldsProduceSheetMaintenL3DataTableC_Min,
            this.coldsProduceSheetMaintenL3DataTableC_Aim,
            this.coldsProduceSheetMaintenL3DataTableC_Max,
            this.coldsProduceSheetMaintenL3DataTableSi_Min,
            this.coldsProduceSheetMaintenL3DataTableSi_Aim,
            this.coldsProduceSheetMaintenL3DataTableSi_Max,
            this.coldsProduceSheetMaintenL3DataTableMn_Min,
            this.coldsProduceSheetMaintenL3DataTableMn_Aim,
            this.coldsProduceSheetMaintenL3DataTableMn_Max,
            this.coldsProduceSheetMaintenL3DataTableP_Min,
            this.coldsProduceSheetMaintenL3DataTableP_Aim,
            this.coldsProduceSheetMaintenL3DataTableP_Max,
            this.coldsProduceSheetMaintenL3DataTableS_Min,
            this.coldsProduceSheetMaintenL3DataTableS_Aim,
            this.coldsProduceSheetMaintenL3DataTableS_Max,
            this.coldsProduceSheetMaintenL3DataTableCu_Min,
            this.coldsProduceSheetMaintenL3DataTableCu_Aim,
            this.coldsProduceSheetMaintenL3DataTableCu_Max,
            this.coldsProduceSheetMaintenL3DataTableNi_Min,
            this.coldsProduceSheetMaintenL3DataTableNi_Aim,
            this.coldsProduceSheetMaintenL3DataTableNi_Max,
            this.coldsProduceSheetMaintenL3DataTableCr_Min,
            this.coldsProduceSheetMaintenL3DataTableCr_Aim,
            this.coldsProduceSheetMaintenL3DataTableCr_Max,
            this.coldsProduceSheetMaintenL3DataTableMo_Min,
            this.coldsProduceSheetMaintenL3DataTableMo_Aim,
            this.coldsProduceSheetMaintenL3DataTableMo_Max,
            this.coldsProduceSheetMaintenL3DataTableV_Min,
            this.coldsProduceSheetMaintenL3DataTableV_Aim,
            this.coldsProduceSheetMaintenL3DataTableV_Max,
            this.coldsProduceSheetMaintenL3DataTableNb_Min,
            this.coldsProduceSheetMaintenL3DataTableNb_Aim,
            this.coldsProduceSheetMaintenL3DataTableNb_Max,
            this.coldsProduceSheetMaintenL3DataTableAl_Min,
            this.coldsProduceSheetMaintenL3DataTableAl_Aim,
            this.coldsProduceSheetMaintenL3DataTableAl_Max,
            this.coldsProduceSheetMaintenL3DataTableAlS_Min,
            this.coldsProduceSheetMaintenL3DataTableAlS_Aim,
            this.coldsProduceSheetMaintenL3DataTableAlS_Max,
            this.coldsProduceSheetMaintenL3DataTableTi_Min,
            this.coldsProduceSheetMaintenL3DataTableTi_Aim,
            this.coldsProduceSheetMaintenL3DataTableTi_Max,
            this.coldsProduceSheetMaintenL3DataTableB_Min,
            this.coldsProduceSheetMaintenL3DataTableB_Aim,
            this.coldsProduceSheetMaintenL3DataTableB_Max,
            this.coldsProduceSheetMaintenL3DataTableSb_Min,
            this.coldsProduceSheetMaintenL3DataTableSb_Aim,
            this.coldsProduceSheetMaintenL3DataTableSb_Max,
            this.coldsProduceSheetMaintenL3DataTableSn_Min,
            this.coldsProduceSheetMaintenL3DataTableSn_Aim,
            this.coldsProduceSheetMaintenL3DataTableSn_Max,
            this.coldsProduceSheetMaintenL3DataTableAs_Min,
            this.coldsProduceSheetMaintenL3DataTableAs_Aim,
            this.coldsProduceSheetMaintenL3DataTableAs_Max,
            this.coldsProduceSheetMaintenL3DataTableZn_Min,
            this.coldsProduceSheetMaintenL3DataTableZn_Aim,
            this.coldsProduceSheetMaintenL3DataTableZn_Max,
            this.coldsProduceSheetMaintenL3DataTableZr_Min,
            this.coldsProduceSheetMaintenL3DataTableZr_Aim,
            this.coldsProduceSheetMaintenL3DataTableZr_Max,
            this.coldsProduceSheetMaintenL3DataTableCa_Min,
            this.coldsProduceSheetMaintenL3DataTableCa_Aim,
            this.coldsProduceSheetMaintenL3DataTableCa_Max,
            this.coldsProduceSheetMaintenL3DataTableW_Min,
            this.coldsProduceSheetMaintenL3DataTableW_Aim,
            this.coldsProduceSheetMaintenL3DataTableW_Max,
            this.coldsProduceSheetMaintenL3DataTablePb_Min,
            this.coldsProduceSheetMaintenL3DataTablePb_Aim,
            this.coldsProduceSheetMaintenL3DataTablePb_Max,
            this.coldsProduceSheetMaintenL3DataTableRe_Min,
            this.coldsProduceSheetMaintenL3DataTableRe_Aim,
            this.coldsProduceSheetMaintenL3DataTableRe_Max,
            this.coldsProduceSheetMaintenL3DataTableCeq_Min,
            this.coldsProduceSheetMaintenL3DataTableCeq_Aim,
            this.coldsProduceSheetMaintenL3DataTableCeq_Max,
            this.coldsProduceSheetMaintenL3DataTableN_Min,
            this.coldsProduceSheetMaintenL3DataTableN_Aim,
            this.coldsProduceSheetMaintenL3DataTableN_Max,
            this.coldsProduceSheetMaintenL3DataTableH_Min,
            this.coldsProduceSheetMaintenL3DataTableH_Aim,
            this.coldsProduceSheetMaintenL3DataTableH_Max,
            this.coldsProduceSheetMaintenL3DataTableO_Min,
            this.coldsProduceSheetMaintenL3DataTableO_Aim,
            this.coldsProduceSheetMaintenL3DataTableO_Max,
            this.coldsProduceSheetMaintenL3DataTableOther1_Min,
            this.coldsProduceSheetMaintenL3DataTableOther1_Aim,
            this.coldsProduceSheetMaintenL3DataTableOther1_Max,
            this.coldsProduceSheetMaintenL3DataTableOther2_Min,
            this.coldsProduceSheetMaintenL3DataTableOther2_Aim,
            this.coldsProduceSheetMaintenL3DataTableOther2_Max,
            this.coldsProduceSheetMaintenL3DataTableCrNi_Min,
            this.coldsProduceSheetMaintenL3DataTableCrNi_Aim,
            this.coldsProduceSheetMaintenL3DataTableCrNi_Max,
            this.coldsProduceSheetMaintenL3DataTableCrCu_Min,
            this.coldsProduceSheetMaintenL3DataTableCrCu_Aim,
            this.coldsProduceSheetMaintenL3DataTableCrCu_Max,
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Min,
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Aim,
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Max,
            this.coldsProduceSheetMaintenL3DataTableOther3_Min,
            this.coldsProduceSheetMaintenL3DataTableOther3_Aim,
            this.coldsProduceSheetMaintenL3DataTableOther3_Max,
            this.coldsProduceSheetMaintenL3DataTableAOD_Type});
            this.schemadsProduceSheetMainten.TableName = "L3DataTable";
            // 
            // coldsProduceSheetMaintenL3DataTableGUID
            // 
            this.coldsProduceSheetMaintenL3DataTableGUID.Caption = "GUID";
            this.coldsProduceSheetMaintenL3DataTableGUID.ColumnName = "GUID";
            this.coldsProduceSheetMaintenL3DataTableGUID.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableName
            // 
            this.coldsProduceSheetMaintenL3DataTableName.Caption = "Name";
            this.coldsProduceSheetMaintenL3DataTableName.ColumnName = "Name";
            this.coldsProduceSheetMaintenL3DataTableName.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSteelGradeIndex
            // 
            this.coldsProduceSheetMaintenL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsProduceSheetMaintenL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsProduceSheetMaintenL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLadle_Brick
            // 
            this.coldsProduceSheetMaintenL3DataTableLadle_Brick.Caption = "Ladle_Brick";
            this.coldsProduceSheetMaintenL3DataTableLadle_Brick.ColumnName = "Ladle_Brick";
            this.coldsProduceSheetMaintenL3DataTableLadle_Brick.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLadle_Use
            // 
            this.coldsProduceSheetMaintenL3DataTableLadle_Use.Caption = "Ladle_Use";
            this.coldsProduceSheetMaintenL3DataTableLadle_Use.ColumnName = "Ladle_Use";
            this.coldsProduceSheetMaintenL3DataTableLadle_Use.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade
            // 
            this.coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade.Caption = "Ladle_Pre_SteelGrade";
            this.coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade.ColumnName = "Ladle_Pre_SteelGrade";
            this.coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLadle_Stay
            // 
            this.coldsProduceSheetMaintenL3DataTableLadle_Stay.Caption = "Ladle_Stay";
            this.coldsProduceSheetMaintenL3DataTableLadle_Stay.ColumnName = "Ladle_Stay";
            this.coldsProduceSheetMaintenL3DataTableLadle_Stay.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableBOF_Type
            // 
            this.coldsProduceSheetMaintenL3DataTableBOF_Type.Caption = "BOF_Type";
            this.coldsProduceSheetMaintenL3DataTableBOF_Type.ColumnName = "BOF_Type";
            this.coldsProduceSheetMaintenL3DataTableBOF_Type.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc
            // 
            this.coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc.Caption = "Ladle_Tapped_Proc";
            this.coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc.ColumnName = "Ladle_Tapped_Proc";
            this.coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableLF_Type
            // 
            this.coldsProduceSheetMaintenL3DataTableLF_Type.Caption = "LF_Type";
            this.coldsProduceSheetMaintenL3DataTableLF_Type.ColumnName = "LF_Type";
            this.coldsProduceSheetMaintenL3DataTableLF_Type.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableRH_Type
            // 
            this.coldsProduceSheetMaintenL3DataTableRH_Type.Caption = "RH_Type";
            this.coldsProduceSheetMaintenL3DataTableRH_Type.ColumnName = "RH_Type";
            this.coldsProduceSheetMaintenL3DataTableRH_Type.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCaster_Type
            // 
            this.coldsProduceSheetMaintenL3DataTableCaster_Type.Caption = "Caster_Type";
            this.coldsProduceSheetMaintenL3DataTableCaster_Type.ColumnName = "Caster_Type";
            this.coldsProduceSheetMaintenL3DataTableCaster_Type.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableHot_Send_Flag
            // 
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsProduceSheetMaintenL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableC_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableC_Min.Caption = "C_Min";
            this.coldsProduceSheetMaintenL3DataTableC_Min.ColumnName = "C_Min";
            this.coldsProduceSheetMaintenL3DataTableC_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableC_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableC_Aim.Caption = "C_Aim";
            this.coldsProduceSheetMaintenL3DataTableC_Aim.ColumnName = "C_Aim";
            this.coldsProduceSheetMaintenL3DataTableC_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableC_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableC_Max.Caption = "C_Max";
            this.coldsProduceSheetMaintenL3DataTableC_Max.ColumnName = "C_Max";
            this.coldsProduceSheetMaintenL3DataTableC_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSi_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableSi_Min.Caption = "Si_Min";
            this.coldsProduceSheetMaintenL3DataTableSi_Min.ColumnName = "Si_Min";
            this.coldsProduceSheetMaintenL3DataTableSi_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSi_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableSi_Aim.Caption = "Si_Aim";
            this.coldsProduceSheetMaintenL3DataTableSi_Aim.ColumnName = "Si_Aim";
            this.coldsProduceSheetMaintenL3DataTableSi_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSi_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableSi_Max.Caption = "Si_Max";
            this.coldsProduceSheetMaintenL3DataTableSi_Max.ColumnName = "Si_Max";
            this.coldsProduceSheetMaintenL3DataTableSi_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMn_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableMn_Min.Caption = "Mn_Min";
            this.coldsProduceSheetMaintenL3DataTableMn_Min.ColumnName = "Mn_Min";
            this.coldsProduceSheetMaintenL3DataTableMn_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMn_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableMn_Aim.Caption = "Mn_Aim";
            this.coldsProduceSheetMaintenL3DataTableMn_Aim.ColumnName = "Mn_Aim";
            this.coldsProduceSheetMaintenL3DataTableMn_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMn_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableMn_Max.Caption = "Mn_Max";
            this.coldsProduceSheetMaintenL3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coldsProduceSheetMaintenL3DataTableMn_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableP_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableP_Min.Caption = "P_Min";
            this.coldsProduceSheetMaintenL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsProduceSheetMaintenL3DataTableP_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableP_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableP_Aim.Caption = "P_Aim";
            this.coldsProduceSheetMaintenL3DataTableP_Aim.ColumnName = "P_Aim";
            this.coldsProduceSheetMaintenL3DataTableP_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableP_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableP_Max.Caption = "P_Max";
            this.coldsProduceSheetMaintenL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsProduceSheetMaintenL3DataTableP_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableS_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableS_Min.Caption = "S_Min";
            this.coldsProduceSheetMaintenL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsProduceSheetMaintenL3DataTableS_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableS_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableS_Aim.Caption = "S_Aim";
            this.coldsProduceSheetMaintenL3DataTableS_Aim.ColumnName = "S_Aim";
            this.coldsProduceSheetMaintenL3DataTableS_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableS_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableS_Max.Caption = "S_Max";
            this.coldsProduceSheetMaintenL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsProduceSheetMaintenL3DataTableS_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCu_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCu_Min.Caption = "Cu_Min";
            this.coldsProduceSheetMaintenL3DataTableCu_Min.ColumnName = "Cu_Min";
            this.coldsProduceSheetMaintenL3DataTableCu_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCu_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCu_Aim.Caption = "Cu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCu_Aim.ColumnName = "Cu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCu_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCu_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCu_Max.Caption = "Cu_Max";
            this.coldsProduceSheetMaintenL3DataTableCu_Max.ColumnName = "Cu_Max";
            this.coldsProduceSheetMaintenL3DataTableCu_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNi_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableNi_Min.Caption = "Ni_Min";
            this.coldsProduceSheetMaintenL3DataTableNi_Min.ColumnName = "Ni_Min";
            this.coldsProduceSheetMaintenL3DataTableNi_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNi_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableNi_Aim.Caption = "Ni_Aim";
            this.coldsProduceSheetMaintenL3DataTableNi_Aim.ColumnName = "Ni_Aim";
            this.coldsProduceSheetMaintenL3DataTableNi_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNi_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableNi_Max.Caption = "Ni_Max";
            this.coldsProduceSheetMaintenL3DataTableNi_Max.ColumnName = "Ni_Max";
            this.coldsProduceSheetMaintenL3DataTableNi_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCr_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCr_Min.Caption = "Cr_Min";
            this.coldsProduceSheetMaintenL3DataTableCr_Min.ColumnName = "Cr_Min";
            this.coldsProduceSheetMaintenL3DataTableCr_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCr_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCr_Aim.Caption = "Cr_Aim";
            this.coldsProduceSheetMaintenL3DataTableCr_Aim.ColumnName = "Cr_Aim";
            this.coldsProduceSheetMaintenL3DataTableCr_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCr_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCr_Max.Caption = "Cr_Max";
            this.coldsProduceSheetMaintenL3DataTableCr_Max.ColumnName = "Cr_Max";
            this.coldsProduceSheetMaintenL3DataTableCr_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMo_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableMo_Min.Caption = "Mo_Min";
            this.coldsProduceSheetMaintenL3DataTableMo_Min.ColumnName = "Mo_Min";
            this.coldsProduceSheetMaintenL3DataTableMo_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMo_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableMo_Aim.Caption = "Mo_Aim";
            this.coldsProduceSheetMaintenL3DataTableMo_Aim.ColumnName = "Mo_Aim";
            this.coldsProduceSheetMaintenL3DataTableMo_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableMo_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableMo_Max.Caption = "Mo_Max";
            this.coldsProduceSheetMaintenL3DataTableMo_Max.ColumnName = "Mo_Max";
            this.coldsProduceSheetMaintenL3DataTableMo_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableV_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableV_Min.Caption = "V_Min";
            this.coldsProduceSheetMaintenL3DataTableV_Min.ColumnName = "V_Min";
            this.coldsProduceSheetMaintenL3DataTableV_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableV_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableV_Aim.Caption = "V_Aim";
            this.coldsProduceSheetMaintenL3DataTableV_Aim.ColumnName = "V_Aim";
            this.coldsProduceSheetMaintenL3DataTableV_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableV_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableV_Max.Caption = "V_Max";
            this.coldsProduceSheetMaintenL3DataTableV_Max.ColumnName = "V_Max";
            this.coldsProduceSheetMaintenL3DataTableV_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNb_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableNb_Min.Caption = "Nb_Min";
            this.coldsProduceSheetMaintenL3DataTableNb_Min.ColumnName = "Nb_Min";
            this.coldsProduceSheetMaintenL3DataTableNb_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNb_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableNb_Aim.Caption = "Nb_Aim";
            this.coldsProduceSheetMaintenL3DataTableNb_Aim.ColumnName = "Nb_Aim";
            this.coldsProduceSheetMaintenL3DataTableNb_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableNb_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableNb_Max.Caption = "Nb_Max";
            this.coldsProduceSheetMaintenL3DataTableNb_Max.ColumnName = "Nb_Max";
            this.coldsProduceSheetMaintenL3DataTableNb_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAl_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableAl_Min.Caption = "Al_Min";
            this.coldsProduceSheetMaintenL3DataTableAl_Min.ColumnName = "Al_Min";
            this.coldsProduceSheetMaintenL3DataTableAl_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAl_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableAl_Aim.Caption = "Al_Aim";
            this.coldsProduceSheetMaintenL3DataTableAl_Aim.ColumnName = "Al_Aim";
            this.coldsProduceSheetMaintenL3DataTableAl_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAl_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableAl_Max.Caption = "Al_Max";
            this.coldsProduceSheetMaintenL3DataTableAl_Max.ColumnName = "Al_Max";
            this.coldsProduceSheetMaintenL3DataTableAl_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAlS_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableAlS_Min.Caption = "AlS_Min";
            this.coldsProduceSheetMaintenL3DataTableAlS_Min.ColumnName = "AlS_Min";
            this.coldsProduceSheetMaintenL3DataTableAlS_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAlS_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableAlS_Aim.Caption = "AlS_Aim";
            this.coldsProduceSheetMaintenL3DataTableAlS_Aim.ColumnName = "AlS_Aim";
            this.coldsProduceSheetMaintenL3DataTableAlS_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAlS_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableAlS_Max.Caption = "AlS_Max";
            this.coldsProduceSheetMaintenL3DataTableAlS_Max.ColumnName = "AlS_Max";
            this.coldsProduceSheetMaintenL3DataTableAlS_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableTi_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableTi_Min.Caption = "Ti_Min";
            this.coldsProduceSheetMaintenL3DataTableTi_Min.ColumnName = "Ti_Min";
            this.coldsProduceSheetMaintenL3DataTableTi_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableTi_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableTi_Aim.Caption = "Ti_Aim";
            this.coldsProduceSheetMaintenL3DataTableTi_Aim.ColumnName = "Ti_Aim";
            this.coldsProduceSheetMaintenL3DataTableTi_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableTi_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableTi_Max.Caption = "Ti_Max";
            this.coldsProduceSheetMaintenL3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coldsProduceSheetMaintenL3DataTableTi_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableB_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableB_Min.Caption = "B_Min";
            this.coldsProduceSheetMaintenL3DataTableB_Min.ColumnName = "B_Min";
            this.coldsProduceSheetMaintenL3DataTableB_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableB_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableB_Aim.Caption = "B_Aim";
            this.coldsProduceSheetMaintenL3DataTableB_Aim.ColumnName = "B_Aim";
            this.coldsProduceSheetMaintenL3DataTableB_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableB_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableB_Max.Caption = "B_Max";
            this.coldsProduceSheetMaintenL3DataTableB_Max.ColumnName = "B_Max";
            this.coldsProduceSheetMaintenL3DataTableB_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSb_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableSb_Min.Caption = "Sb_Min";
            this.coldsProduceSheetMaintenL3DataTableSb_Min.ColumnName = "Sb_Min";
            this.coldsProduceSheetMaintenL3DataTableSb_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSb_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableSb_Aim.Caption = "Sb_Aim";
            this.coldsProduceSheetMaintenL3DataTableSb_Aim.ColumnName = "Sb_Aim";
            this.coldsProduceSheetMaintenL3DataTableSb_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSb_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableSb_Max.Caption = "Sb_Max";
            this.coldsProduceSheetMaintenL3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coldsProduceSheetMaintenL3DataTableSb_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSn_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableSn_Min.Caption = "Sn_Min";
            this.coldsProduceSheetMaintenL3DataTableSn_Min.ColumnName = "Sn_Min";
            this.coldsProduceSheetMaintenL3DataTableSn_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSn_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableSn_Aim.Caption = "Sn_Aim";
            this.coldsProduceSheetMaintenL3DataTableSn_Aim.ColumnName = "Sn_Aim";
            this.coldsProduceSheetMaintenL3DataTableSn_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableSn_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableSn_Max.Caption = "Sn_Max";
            this.coldsProduceSheetMaintenL3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coldsProduceSheetMaintenL3DataTableSn_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAs_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableAs_Min.Caption = "As_Min";
            this.coldsProduceSheetMaintenL3DataTableAs_Min.ColumnName = "As_Min";
            this.coldsProduceSheetMaintenL3DataTableAs_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAs_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableAs_Aim.Caption = "As_Aim";
            this.coldsProduceSheetMaintenL3DataTableAs_Aim.ColumnName = "As_Aim";
            this.coldsProduceSheetMaintenL3DataTableAs_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAs_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableAs_Max.Caption = "As_Max";
            this.coldsProduceSheetMaintenL3DataTableAs_Max.ColumnName = "As_Max";
            this.coldsProduceSheetMaintenL3DataTableAs_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZn_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableZn_Min.Caption = "Zn_Min";
            this.coldsProduceSheetMaintenL3DataTableZn_Min.ColumnName = "Zn_Min";
            this.coldsProduceSheetMaintenL3DataTableZn_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZn_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableZn_Aim.Caption = "Zn_Aim";
            this.coldsProduceSheetMaintenL3DataTableZn_Aim.ColumnName = "Zn_Aim";
            this.coldsProduceSheetMaintenL3DataTableZn_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZn_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableZn_Max.Caption = "Zn_Max";
            this.coldsProduceSheetMaintenL3DataTableZn_Max.ColumnName = "Zn_Max";
            this.coldsProduceSheetMaintenL3DataTableZn_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZr_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableZr_Min.Caption = "Zr_Min";
            this.coldsProduceSheetMaintenL3DataTableZr_Min.ColumnName = "Zr_Min";
            this.coldsProduceSheetMaintenL3DataTableZr_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZr_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableZr_Aim.Caption = "Zr_Aim";
            this.coldsProduceSheetMaintenL3DataTableZr_Aim.ColumnName = "Zr_Aim";
            this.coldsProduceSheetMaintenL3DataTableZr_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableZr_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableZr_Max.Caption = "Zr_Max";
            this.coldsProduceSheetMaintenL3DataTableZr_Max.ColumnName = "Zr_Max";
            this.coldsProduceSheetMaintenL3DataTableZr_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCa_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCa_Min.Caption = "Ca_Min";
            this.coldsProduceSheetMaintenL3DataTableCa_Min.ColumnName = "Ca_Min";
            this.coldsProduceSheetMaintenL3DataTableCa_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCa_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCa_Aim.Caption = "Ca_Aim";
            this.coldsProduceSheetMaintenL3DataTableCa_Aim.ColumnName = "Ca_Aim";
            this.coldsProduceSheetMaintenL3DataTableCa_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCa_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCa_Max.Caption = "Ca_Max";
            this.coldsProduceSheetMaintenL3DataTableCa_Max.ColumnName = "Ca_Max";
            this.coldsProduceSheetMaintenL3DataTableCa_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableW_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableW_Min.Caption = "W_Min";
            this.coldsProduceSheetMaintenL3DataTableW_Min.ColumnName = "W_Min";
            this.coldsProduceSheetMaintenL3DataTableW_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableW_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableW_Aim.Caption = "W_Aim";
            this.coldsProduceSheetMaintenL3DataTableW_Aim.ColumnName = "W_Aim";
            this.coldsProduceSheetMaintenL3DataTableW_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableW_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableW_Max.Caption = "W_Max";
            this.coldsProduceSheetMaintenL3DataTableW_Max.ColumnName = "W_Max";
            this.coldsProduceSheetMaintenL3DataTableW_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTablePb_Min
            // 
            this.coldsProduceSheetMaintenL3DataTablePb_Min.Caption = "Pb_Min";
            this.coldsProduceSheetMaintenL3DataTablePb_Min.ColumnName = "Pb_Min";
            this.coldsProduceSheetMaintenL3DataTablePb_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTablePb_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTablePb_Aim.Caption = "Pb_Aim";
            this.coldsProduceSheetMaintenL3DataTablePb_Aim.ColumnName = "Pb_Aim";
            this.coldsProduceSheetMaintenL3DataTablePb_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTablePb_Max
            // 
            this.coldsProduceSheetMaintenL3DataTablePb_Max.Caption = "Pb_Max";
            this.coldsProduceSheetMaintenL3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coldsProduceSheetMaintenL3DataTablePb_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableRe_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableRe_Min.Caption = "Re_Min";
            this.coldsProduceSheetMaintenL3DataTableRe_Min.ColumnName = "Re_Min";
            this.coldsProduceSheetMaintenL3DataTableRe_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableRe_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableRe_Aim.Caption = "Re_Aim";
            this.coldsProduceSheetMaintenL3DataTableRe_Aim.ColumnName = "Re_Aim";
            this.coldsProduceSheetMaintenL3DataTableRe_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableRe_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableRe_Max.Caption = "Re_Max";
            this.coldsProduceSheetMaintenL3DataTableRe_Max.ColumnName = "Re_Max";
            this.coldsProduceSheetMaintenL3DataTableRe_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCeq_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCeq_Min.Caption = "Ceq_Min";
            this.coldsProduceSheetMaintenL3DataTableCeq_Min.ColumnName = "Ceq_Min";
            this.coldsProduceSheetMaintenL3DataTableCeq_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCeq_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCeq_Aim.Caption = "Ceq_Aim";
            this.coldsProduceSheetMaintenL3DataTableCeq_Aim.ColumnName = "Ceq_Aim";
            this.coldsProduceSheetMaintenL3DataTableCeq_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCeq_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCeq_Max.Caption = "Ceq_Max";
            this.coldsProduceSheetMaintenL3DataTableCeq_Max.ColumnName = "Ceq_Max";
            this.coldsProduceSheetMaintenL3DataTableCeq_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableN_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableN_Min.Caption = "N_Min";
            this.coldsProduceSheetMaintenL3DataTableN_Min.ColumnName = "N_Min";
            this.coldsProduceSheetMaintenL3DataTableN_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableN_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableN_Aim.Caption = "N_Aim";
            this.coldsProduceSheetMaintenL3DataTableN_Aim.ColumnName = "N_Aim";
            this.coldsProduceSheetMaintenL3DataTableN_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableN_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableN_Max.Caption = "N_Max";
            this.coldsProduceSheetMaintenL3DataTableN_Max.ColumnName = "N_Max";
            this.coldsProduceSheetMaintenL3DataTableN_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableH_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableH_Min.Caption = "H_Min";
            this.coldsProduceSheetMaintenL3DataTableH_Min.ColumnName = "H_Min";
            this.coldsProduceSheetMaintenL3DataTableH_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableH_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableH_Aim.Caption = "H_Aim";
            this.coldsProduceSheetMaintenL3DataTableH_Aim.ColumnName = "H_Aim";
            this.coldsProduceSheetMaintenL3DataTableH_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableH_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableH_Max.Caption = "H_Max";
            this.coldsProduceSheetMaintenL3DataTableH_Max.ColumnName = "H_Max";
            this.coldsProduceSheetMaintenL3DataTableH_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableO_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableO_Min.Caption = "O_Min";
            this.coldsProduceSheetMaintenL3DataTableO_Min.ColumnName = "O_Min";
            this.coldsProduceSheetMaintenL3DataTableO_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableO_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableO_Aim.Caption = "O_Aim";
            this.coldsProduceSheetMaintenL3DataTableO_Aim.ColumnName = "O_Aim";
            this.coldsProduceSheetMaintenL3DataTableO_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableO_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableO_Max.Caption = "O_Max";
            this.coldsProduceSheetMaintenL3DataTableO_Max.ColumnName = "O_Max";
            this.coldsProduceSheetMaintenL3DataTableO_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther1_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableOther1_Min.Caption = "Other1_Min";
            this.coldsProduceSheetMaintenL3DataTableOther1_Min.ColumnName = "Other1_Min";
            this.coldsProduceSheetMaintenL3DataTableOther1_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther1_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableOther1_Aim.Caption = "Other1_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther1_Aim.ColumnName = "Other1_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther1_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther1_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableOther1_Max.Caption = "Other1_Max";
            this.coldsProduceSheetMaintenL3DataTableOther1_Max.ColumnName = "Other1_Max";
            this.coldsProduceSheetMaintenL3DataTableOther1_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther2_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableOther2_Min.Caption = "Other2_Min";
            this.coldsProduceSheetMaintenL3DataTableOther2_Min.ColumnName = "Other2_Min";
            this.coldsProduceSheetMaintenL3DataTableOther2_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther2_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableOther2_Aim.Caption = "Other2_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther2_Aim.ColumnName = "Other2_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther2_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther2_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableOther2_Max.Caption = "Other2_Max";
            this.coldsProduceSheetMaintenL3DataTableOther2_Max.ColumnName = "Other2_Max";
            this.coldsProduceSheetMaintenL3DataTableOther2_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNi_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNi_Min.Caption = "CrNi_Min";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Min.ColumnName = "CrNi_Min";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNi_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNi_Aim.Caption = "CrNi_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Aim.ColumnName = "CrNi_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNi_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNi_Max.Caption = "CrNi_Max";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Max.ColumnName = "CrNi_Max";
            this.coldsProduceSheetMaintenL3DataTableCrNi_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrCu_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCrCu_Min.Caption = "CrCu_Min";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Min.ColumnName = "CrCu_Min";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrCu_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCrCu_Aim.Caption = "CrCu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Aim.ColumnName = "CrCu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrCu_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCrCu_Max.Caption = "CrCu_Max";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Max.ColumnName = "CrCu_Max";
            this.coldsProduceSheetMaintenL3DataTableCrCu_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNiCu_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Min.Caption = "CrNiCu_Min";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Min.ColumnName = "CrNiCu_Min";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNiCu_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Aim.Caption = "CrNiCu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Aim.ColumnName = "CrNiCu_Aim";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableCrNiCu_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Max.Caption = "CrNiCu_Max";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Max.ColumnName = "CrNiCu_Max";
            this.coldsProduceSheetMaintenL3DataTableCrNiCu_Max.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther3_Min
            // 
            this.coldsProduceSheetMaintenL3DataTableOther3_Min.Caption = "Other3_Min";
            this.coldsProduceSheetMaintenL3DataTableOther3_Min.ColumnName = "Other3_Min";
            this.coldsProduceSheetMaintenL3DataTableOther3_Min.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther3_Aim
            // 
            this.coldsProduceSheetMaintenL3DataTableOther3_Aim.Caption = "Other3_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther3_Aim.ColumnName = "Other3_Aim";
            this.coldsProduceSheetMaintenL3DataTableOther3_Aim.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableOther3_Max
            // 
            this.coldsProduceSheetMaintenL3DataTableOther3_Max.Caption = "Other3_Max";
            this.coldsProduceSheetMaintenL3DataTableOther3_Max.ColumnName = "Other3_Max";
            this.coldsProduceSheetMaintenL3DataTableOther3_Max.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsProduceSheetMainten;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel3,
            this.tscmbSteelGradeIndex,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.txtSteelGrade});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "　";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel3.Text = " ";
            // 
            // tscmbSteelGradeIndex
            // 
            this.tscmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbSteelGradeIndex.Name = "tscmbSteelGradeIndex";
            this.tscmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "炼钢记号:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "钢种";
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.ReadOnly = true;
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // hmiRootPanelProduceSheetMainten
            // 
            this.hmiRootPanelProduceSheetMainten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelProduceSheetMainten.Controls.Add(this.dvProduceSheetMainten);
            this.hmiRootPanelProduceSheetMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProduceSheetMainten.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProduceSheetMainten.Name = "hmiRootPanelProduceSheetMainten";
            this.hmiRootPanelProduceSheetMainten.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProduceSheetMainten.TabIndex = 17;
            // 
            // dvProduceSheetMainten
            // 
            this.dvProduceSheetMainten.AllowUserToAddRows = false;
            this.dvProduceSheetMainten.AutoGenerateColumns = false;
            this.dvProduceSheetMainten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvProduceSheetMainten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvProduceSheetMainten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProduceSheetMainten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.ladleBrickDataGridViewTextBoxColumn,
            this.ladleUseDataGridViewTextBoxColumn,
            this.ladlePreSteelGradeDataGridViewTextBoxColumn,
            this.ladleStayDataGridViewTextBoxColumn,
            this.bOFTypeDataGridViewTextBoxColumn,
            this.ladleTappedProcDataGridViewTextBoxColumn,
            this.AOD_Type,
            this.lFTypeDataGridViewTextBoxColumn,
            this.rHTypeDataGridViewTextBoxColumn,
            this.casterTypeDataGridViewTextBoxColumn,
            this.hotSendFlagDataGridViewTextBoxColumn,
            this.cMinDataGridViewTextBoxColumn,
            this.cAimDataGridViewTextBoxColumn,
            this.cMaxDataGridViewTextBoxColumn,
            this.siMinDataGridViewTextBoxColumn,
            this.siAimDataGridViewTextBoxColumn,
            this.siMaxDataGridViewTextBoxColumn,
            this.mnMinDataGridViewTextBoxColumn,
            this.mnAimDataGridViewTextBoxColumn,
            this.mnMaxDataGridViewTextBoxColumn,
            this.pMinDataGridViewTextBoxColumn,
            this.pAimDataGridViewTextBoxColumn,
            this.pMaxDataGridViewTextBoxColumn,
            this.sMinDataGridViewTextBoxColumn,
            this.sAimDataGridViewTextBoxColumn,
            this.sMaxDataGridViewTextBoxColumn,
            this.cuMinDataGridViewTextBoxColumn,
            this.cuAimDataGridViewTextBoxColumn,
            this.cuMaxDataGridViewTextBoxColumn,
            this.niMinDataGridViewTextBoxColumn,
            this.niAimDataGridViewTextBoxColumn,
            this.niMaxDataGridViewTextBoxColumn,
            this.crMinDataGridViewTextBoxColumn,
            this.crAimDataGridViewTextBoxColumn,
            this.crMaxDataGridViewTextBoxColumn,
            this.moMinDataGridViewTextBoxColumn,
            this.moAimDataGridViewTextBoxColumn,
            this.moMaxDataGridViewTextBoxColumn,
            this.vMinDataGridViewTextBoxColumn,
            this.vAimDataGridViewTextBoxColumn,
            this.vMaxDataGridViewTextBoxColumn,
            this.nbMinDataGridViewTextBoxColumn,
            this.nbAimDataGridViewTextBoxColumn,
            this.nbMaxDataGridViewTextBoxColumn,
            this.alMinDataGridViewTextBoxColumn,
            this.alAimDataGridViewTextBoxColumn,
            this.alMaxDataGridViewTextBoxColumn,
            this.alSMinDataGridViewTextBoxColumn,
            this.alSAimDataGridViewTextBoxColumn,
            this.alSMaxDataGridViewTextBoxColumn,
            this.tiMinDataGridViewTextBoxColumn,
            this.tiAimDataGridViewTextBoxColumn,
            this.tiMaxDataGridViewTextBoxColumn,
            this.bMinDataGridViewTextBoxColumn,
            this.bAimDataGridViewTextBoxColumn,
            this.bMaxDataGridViewTextBoxColumn,
            this.sbMinDataGridViewTextBoxColumn,
            this.sbAimDataGridViewTextBoxColumn,
            this.sbMaxDataGridViewTextBoxColumn,
            this.snMinDataGridViewTextBoxColumn,
            this.snAimDataGridViewTextBoxColumn,
            this.snMaxDataGridViewTextBoxColumn,
            this.asMinDataGridViewTextBoxColumn,
            this.asAimDataGridViewTextBoxColumn,
            this.asMaxDataGridViewTextBoxColumn,
            this.znMinDataGridViewTextBoxColumn,
            this.znAimDataGridViewTextBoxColumn,
            this.znMaxDataGridViewTextBoxColumn,
            this.zrMinDataGridViewTextBoxColumn,
            this.zrAimDataGridViewTextBoxColumn,
            this.zrMaxDataGridViewTextBoxColumn,
            this.caMinDataGridViewTextBoxColumn,
            this.caAimDataGridViewTextBoxColumn,
            this.caMaxDataGridViewTextBoxColumn,
            this.wMinDataGridViewTextBoxColumn,
            this.wAimDataGridViewTextBoxColumn,
            this.wMaxDataGridViewTextBoxColumn,
            this.pbMinDataGridViewTextBoxColumn,
            this.pbAimDataGridViewTextBoxColumn,
            this.pbMaxDataGridViewTextBoxColumn,
            this.reMinDataGridViewTextBoxColumn,
            this.reAimDataGridViewTextBoxColumn,
            this.reMaxDataGridViewTextBoxColumn,
            this.ceqMinDataGridViewTextBoxColumn,
            this.ceqAimDataGridViewTextBoxColumn,
            this.ceqMaxDataGridViewTextBoxColumn,
            this.nMinDataGridViewTextBoxColumn,
            this.nAimDataGridViewTextBoxColumn,
            this.nMaxDataGridViewTextBoxColumn,
            this.hMinDataGridViewTextBoxColumn,
            this.hAimDataGridViewTextBoxColumn,
            this.hMaxDataGridViewTextBoxColumn,
            this.oMinDataGridViewTextBoxColumn,
            this.oAimDataGridViewTextBoxColumn,
            this.oMaxDataGridViewTextBoxColumn,
            this.CrNi_Min,
            this.CrNi_Aim,
            this.CrNi_Max,
            this.CrCu_Min,
            this.CrCu_Aim,
            this.CrCu_Max,
            this.CrNiCu_Min,
            this.CrNiCu_Aim,
            this.CrNiCu_Max,
            this.other1MinDataGridViewTextBoxColumn,
            this.other1AimDataGridViewTextBoxColumn,
            this.other1MaxDataGridViewTextBoxColumn,
            this.other2MinDataGridViewTextBoxColumn,
            this.other2AimDataGridViewTextBoxColumn,
            this.other2MaxDataGridViewTextBoxColumn,
            this.Other3_Min,
            this.Other3_Aim,
            this.Other3_Max,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvProduceSheetMainten.DataSource = this.bsProduceSheetMainten;
            this.dvProduceSheetMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProduceSheetMainten.Location = new System.Drawing.Point(0, 0);
            this.dvProduceSheetMainten.Name = "dvProduceSheetMainten";
            this.dvProduceSheetMainten.ReadOnly = true;
            this.dvProduceSheetMainten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvProduceSheetMainten.RowTemplate.Height = 23;
            this.dvProduceSheetMainten.Size = new System.Drawing.Size(1016, 608);
            this.dvProduceSheetMainten.TabIndex = 0;
            this.dvProduceSheetMainten.Sorted += new System.EventHandler(this.dvProduceSheetMainten_Sorted);
            this.dvProduceSheetMainten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvProduceSheetMainten_CellDoubleClick);
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoLoad = true;
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = "SteelGradeIndex is not null order by SteelGradeIndex";
            this.dsSteelGradeIndex.SourceMethod = "";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = null;
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = "";
            this.dsSteelGrade.InsertMethod = "";
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "1=2";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "";
            this.dsSteelGrade.UpdateMethod = "";
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGradeIndex,
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsProduceSheetMaintenL3DataTableAOD_Type
            // 
            this.coldsProduceSheetMaintenL3DataTableAOD_Type.Caption = "AOD_Type";
            this.coldsProduceSheetMaintenL3DataTableAOD_Type.ColumnName = "AOD_Type";
            this.coldsProduceSheetMaintenL3DataTableAOD_Type.Namespace = "";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // ladleBrickDataGridViewTextBoxColumn
            // 
            this.ladleBrickDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Brick";
            this.ladleBrickDataGridViewTextBoxColumn.HeaderText = "衬砖材质";
            this.ladleBrickDataGridViewTextBoxColumn.Name = "ladleBrickDataGridViewTextBoxColumn";
            this.ladleBrickDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleBrickDataGridViewTextBoxColumn.Width = 78;
            // 
            // ladleUseDataGridViewTextBoxColumn
            // 
            this.ladleUseDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Use";
            this.ladleUseDataGridViewTextBoxColumn.HeaderText = "使用状况";
            this.ladleUseDataGridViewTextBoxColumn.Name = "ladleUseDataGridViewTextBoxColumn";
            this.ladleUseDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleUseDataGridViewTextBoxColumn.Width = 78;
            // 
            // ladlePreSteelGradeDataGridViewTextBoxColumn
            // 
            this.ladlePreSteelGradeDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Pre_SteelGrade";
            this.ladlePreSteelGradeDataGridViewTextBoxColumn.HeaderText = "上炉钢种限制";
            this.ladlePreSteelGradeDataGridViewTextBoxColumn.Name = "ladlePreSteelGradeDataGridViewTextBoxColumn";
            this.ladlePreSteelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladlePreSteelGradeDataGridViewTextBoxColumn.Width = 102;
            // 
            // ladleStayDataGridViewTextBoxColumn
            // 
            this.ladleStayDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Stay";
            this.ladleStayDataGridViewTextBoxColumn.HeaderText = "停留时间";
            this.ladleStayDataGridViewTextBoxColumn.Name = "ladleStayDataGridViewTextBoxColumn";
            this.ladleStayDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleStayDataGridViewTextBoxColumn.Width = 78;
            // 
            // bOFTypeDataGridViewTextBoxColumn
            // 
            this.bOFTypeDataGridViewTextBoxColumn.DataPropertyName = "BOF_Type";
            this.bOFTypeDataGridViewTextBoxColumn.HeaderText = "转炉区分";
            this.bOFTypeDataGridViewTextBoxColumn.Name = "bOFTypeDataGridViewTextBoxColumn";
            this.bOFTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // ladleTappedProcDataGridViewTextBoxColumn
            // 
            this.ladleTappedProcDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Tapped_Proc";
            this.ladleTappedProcDataGridViewTextBoxColumn.HeaderText = "钢包炉后处理基准";
            this.ladleTappedProcDataGridViewTextBoxColumn.Name = "ladleTappedProcDataGridViewTextBoxColumn";
            this.ladleTappedProcDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleTappedProcDataGridViewTextBoxColumn.Width = 126;
            // 
            // AOD_Type
            // 
            this.AOD_Type.DataPropertyName = "AOD_Type";
            this.AOD_Type.HeaderText = "AOD炉区分";
            this.AOD_Type.Name = "AOD_Type";
            this.AOD_Type.ReadOnly = true;
            this.AOD_Type.Width = 84;
            // 
            // lFTypeDataGridViewTextBoxColumn
            // 
            this.lFTypeDataGridViewTextBoxColumn.DataPropertyName = "LF_Type";
            this.lFTypeDataGridViewTextBoxColumn.HeaderText = "LF精炼炉区分";
            this.lFTypeDataGridViewTextBoxColumn.Name = "lFTypeDataGridViewTextBoxColumn";
            this.lFTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lFTypeDataGridViewTextBoxColumn.Width = 102;
            // 
            // rHTypeDataGridViewTextBoxColumn
            // 
            this.rHTypeDataGridViewTextBoxColumn.DataPropertyName = "RH_Type";
            this.rHTypeDataGridViewTextBoxColumn.HeaderText = "RH精炼炉区分";
            this.rHTypeDataGridViewTextBoxColumn.Name = "rHTypeDataGridViewTextBoxColumn";
            this.rHTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rHTypeDataGridViewTextBoxColumn.Width = 102;
            // 
            // casterTypeDataGridViewTextBoxColumn
            // 
            this.casterTypeDataGridViewTextBoxColumn.DataPropertyName = "Caster_Type";
            this.casterTypeDataGridViewTextBoxColumn.HeaderText = "连铸机区分";
            this.casterTypeDataGridViewTextBoxColumn.Name = "casterTypeDataGridViewTextBoxColumn";
            this.casterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // hotSendFlagDataGridViewTextBoxColumn
            // 
            this.hotSendFlagDataGridViewTextBoxColumn.DataPropertyName = "Hot_Send_Flag";
            this.hotSendFlagDataGridViewTextBoxColumn.HeaderText = "送坯方式";
            this.hotSendFlagDataGridViewTextBoxColumn.Name = "hotSendFlagDataGridViewTextBoxColumn";
            this.hotSendFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotSendFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // cMinDataGridViewTextBoxColumn
            // 
            this.cMinDataGridViewTextBoxColumn.DataPropertyName = "C_Min";
            this.cMinDataGridViewTextBoxColumn.HeaderText = "C最小";
            this.cMinDataGridViewTextBoxColumn.Name = "cMinDataGridViewTextBoxColumn";
            this.cMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // cAimDataGridViewTextBoxColumn
            // 
            this.cAimDataGridViewTextBoxColumn.DataPropertyName = "C_Aim";
            this.cAimDataGridViewTextBoxColumn.HeaderText = "C目标";
            this.cAimDataGridViewTextBoxColumn.Name = "cAimDataGridViewTextBoxColumn";
            this.cAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.cAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // cMaxDataGridViewTextBoxColumn
            // 
            this.cMaxDataGridViewTextBoxColumn.DataPropertyName = "C_Max";
            this.cMaxDataGridViewTextBoxColumn.HeaderText = "C最大";
            this.cMaxDataGridViewTextBoxColumn.Name = "cMaxDataGridViewTextBoxColumn";
            this.cMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // siMinDataGridViewTextBoxColumn
            // 
            this.siMinDataGridViewTextBoxColumn.DataPropertyName = "Si_Min";
            this.siMinDataGridViewTextBoxColumn.HeaderText = "Si最小";
            this.siMinDataGridViewTextBoxColumn.Name = "siMinDataGridViewTextBoxColumn";
            this.siMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.siMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // siAimDataGridViewTextBoxColumn
            // 
            this.siAimDataGridViewTextBoxColumn.DataPropertyName = "Si_Aim";
            this.siAimDataGridViewTextBoxColumn.HeaderText = "Si目标";
            this.siAimDataGridViewTextBoxColumn.Name = "siAimDataGridViewTextBoxColumn";
            this.siAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.siAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // siMaxDataGridViewTextBoxColumn
            // 
            this.siMaxDataGridViewTextBoxColumn.DataPropertyName = "Si_Max";
            this.siMaxDataGridViewTextBoxColumn.HeaderText = "Si最大";
            this.siMaxDataGridViewTextBoxColumn.Name = "siMaxDataGridViewTextBoxColumn";
            this.siMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.siMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMinDataGridViewTextBoxColumn
            // 
            this.mnMinDataGridViewTextBoxColumn.DataPropertyName = "Mn_Min";
            this.mnMinDataGridViewTextBoxColumn.HeaderText = "Mn最小";
            this.mnMinDataGridViewTextBoxColumn.Name = "mnMinDataGridViewTextBoxColumn";
            this.mnMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnAimDataGridViewTextBoxColumn
            // 
            this.mnAimDataGridViewTextBoxColumn.DataPropertyName = "Mn_Aim";
            this.mnAimDataGridViewTextBoxColumn.HeaderText = "Mn目标";
            this.mnAimDataGridViewTextBoxColumn.Name = "mnAimDataGridViewTextBoxColumn";
            this.mnAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMaxDataGridViewTextBoxColumn
            // 
            this.mnMaxDataGridViewTextBoxColumn.DataPropertyName = "Mn_Max";
            this.mnMaxDataGridViewTextBoxColumn.HeaderText = "Mn最大";
            this.mnMaxDataGridViewTextBoxColumn.Name = "mnMaxDataGridViewTextBoxColumn";
            this.mnMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // pMinDataGridViewTextBoxColumn
            // 
            this.pMinDataGridViewTextBoxColumn.DataPropertyName = "P_Min";
            this.pMinDataGridViewTextBoxColumn.HeaderText = "P最小";
            this.pMinDataGridViewTextBoxColumn.Name = "pMinDataGridViewTextBoxColumn";
            this.pMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // pAimDataGridViewTextBoxColumn
            // 
            this.pAimDataGridViewTextBoxColumn.DataPropertyName = "P_Aim";
            this.pAimDataGridViewTextBoxColumn.HeaderText = "P目标";
            this.pAimDataGridViewTextBoxColumn.Name = "pAimDataGridViewTextBoxColumn";
            this.pAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // pMaxDataGridViewTextBoxColumn
            // 
            this.pMaxDataGridViewTextBoxColumn.DataPropertyName = "P_Max";
            this.pMaxDataGridViewTextBoxColumn.HeaderText = "P最大";
            this.pMaxDataGridViewTextBoxColumn.Name = "pMaxDataGridViewTextBoxColumn";
            this.pMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMinDataGridViewTextBoxColumn
            // 
            this.sMinDataGridViewTextBoxColumn.DataPropertyName = "S_Min";
            this.sMinDataGridViewTextBoxColumn.HeaderText = "S最小";
            this.sMinDataGridViewTextBoxColumn.Name = "sMinDataGridViewTextBoxColumn";
            this.sMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // sAimDataGridViewTextBoxColumn
            // 
            this.sAimDataGridViewTextBoxColumn.DataPropertyName = "S_Aim";
            this.sAimDataGridViewTextBoxColumn.HeaderText = "S目标";
            this.sAimDataGridViewTextBoxColumn.Name = "sAimDataGridViewTextBoxColumn";
            this.sAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMaxDataGridViewTextBoxColumn
            // 
            this.sMaxDataGridViewTextBoxColumn.DataPropertyName = "S_Max";
            this.sMaxDataGridViewTextBoxColumn.HeaderText = "S最大";
            this.sMaxDataGridViewTextBoxColumn.Name = "sMaxDataGridViewTextBoxColumn";
            this.sMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // cuMinDataGridViewTextBoxColumn
            // 
            this.cuMinDataGridViewTextBoxColumn.DataPropertyName = "Cu_Min";
            this.cuMinDataGridViewTextBoxColumn.HeaderText = "Cu最小";
            this.cuMinDataGridViewTextBoxColumn.Name = "cuMinDataGridViewTextBoxColumn";
            this.cuMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // cuAimDataGridViewTextBoxColumn
            // 
            this.cuAimDataGridViewTextBoxColumn.DataPropertyName = "Cu_Aim";
            this.cuAimDataGridViewTextBoxColumn.HeaderText = "Cu目标";
            this.cuAimDataGridViewTextBoxColumn.Name = "cuAimDataGridViewTextBoxColumn";
            this.cuAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // cuMaxDataGridViewTextBoxColumn
            // 
            this.cuMaxDataGridViewTextBoxColumn.DataPropertyName = "Cu_Max";
            this.cuMaxDataGridViewTextBoxColumn.HeaderText = "Cu最大";
            this.cuMaxDataGridViewTextBoxColumn.Name = "cuMaxDataGridViewTextBoxColumn";
            this.cuMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // niMinDataGridViewTextBoxColumn
            // 
            this.niMinDataGridViewTextBoxColumn.DataPropertyName = "Ni_Min";
            this.niMinDataGridViewTextBoxColumn.HeaderText = "Ni最小";
            this.niMinDataGridViewTextBoxColumn.Name = "niMinDataGridViewTextBoxColumn";
            this.niMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.niMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // niAimDataGridViewTextBoxColumn
            // 
            this.niAimDataGridViewTextBoxColumn.DataPropertyName = "Ni_Aim";
            this.niAimDataGridViewTextBoxColumn.HeaderText = "Ni目标";
            this.niAimDataGridViewTextBoxColumn.Name = "niAimDataGridViewTextBoxColumn";
            this.niAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.niAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // niMaxDataGridViewTextBoxColumn
            // 
            this.niMaxDataGridViewTextBoxColumn.DataPropertyName = "Ni_Max";
            this.niMaxDataGridViewTextBoxColumn.HeaderText = "Ni最大";
            this.niMaxDataGridViewTextBoxColumn.Name = "niMaxDataGridViewTextBoxColumn";
            this.niMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.niMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // crMinDataGridViewTextBoxColumn
            // 
            this.crMinDataGridViewTextBoxColumn.DataPropertyName = "Cr_Min";
            this.crMinDataGridViewTextBoxColumn.HeaderText = "Cr最小";
            this.crMinDataGridViewTextBoxColumn.Name = "crMinDataGridViewTextBoxColumn";
            this.crMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.crMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // crAimDataGridViewTextBoxColumn
            // 
            this.crAimDataGridViewTextBoxColumn.DataPropertyName = "Cr_Aim";
            this.crAimDataGridViewTextBoxColumn.HeaderText = "Cr目标";
            this.crAimDataGridViewTextBoxColumn.Name = "crAimDataGridViewTextBoxColumn";
            this.crAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.crAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // crMaxDataGridViewTextBoxColumn
            // 
            this.crMaxDataGridViewTextBoxColumn.DataPropertyName = "Cr_Max";
            this.crMaxDataGridViewTextBoxColumn.HeaderText = "Cr最大";
            this.crMaxDataGridViewTextBoxColumn.Name = "crMaxDataGridViewTextBoxColumn";
            this.crMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.crMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // moMinDataGridViewTextBoxColumn
            // 
            this.moMinDataGridViewTextBoxColumn.DataPropertyName = "Mo_Min";
            this.moMinDataGridViewTextBoxColumn.HeaderText = "Mo最小";
            this.moMinDataGridViewTextBoxColumn.Name = "moMinDataGridViewTextBoxColumn";
            this.moMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.moMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // moAimDataGridViewTextBoxColumn
            // 
            this.moAimDataGridViewTextBoxColumn.DataPropertyName = "Mo_Aim";
            this.moAimDataGridViewTextBoxColumn.HeaderText = "Mo目标";
            this.moAimDataGridViewTextBoxColumn.Name = "moAimDataGridViewTextBoxColumn";
            this.moAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.moAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // moMaxDataGridViewTextBoxColumn
            // 
            this.moMaxDataGridViewTextBoxColumn.DataPropertyName = "Mo_Max";
            this.moMaxDataGridViewTextBoxColumn.HeaderText = "Mo最大";
            this.moMaxDataGridViewTextBoxColumn.Name = "moMaxDataGridViewTextBoxColumn";
            this.moMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.moMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // vMinDataGridViewTextBoxColumn
            // 
            this.vMinDataGridViewTextBoxColumn.DataPropertyName = "V_Min";
            this.vMinDataGridViewTextBoxColumn.HeaderText = "V最小";
            this.vMinDataGridViewTextBoxColumn.Name = "vMinDataGridViewTextBoxColumn";
            this.vMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.vMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // vAimDataGridViewTextBoxColumn
            // 
            this.vAimDataGridViewTextBoxColumn.DataPropertyName = "V_Aim";
            this.vAimDataGridViewTextBoxColumn.HeaderText = "V目标";
            this.vAimDataGridViewTextBoxColumn.Name = "vAimDataGridViewTextBoxColumn";
            this.vAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.vAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // vMaxDataGridViewTextBoxColumn
            // 
            this.vMaxDataGridViewTextBoxColumn.DataPropertyName = "V_Max";
            this.vMaxDataGridViewTextBoxColumn.HeaderText = "V最大";
            this.vMaxDataGridViewTextBoxColumn.Name = "vMaxDataGridViewTextBoxColumn";
            this.vMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.vMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // nbMinDataGridViewTextBoxColumn
            // 
            this.nbMinDataGridViewTextBoxColumn.DataPropertyName = "Nb_Min";
            this.nbMinDataGridViewTextBoxColumn.HeaderText = "Nb最小";
            this.nbMinDataGridViewTextBoxColumn.Name = "nbMinDataGridViewTextBoxColumn";
            this.nbMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // nbAimDataGridViewTextBoxColumn
            // 
            this.nbAimDataGridViewTextBoxColumn.DataPropertyName = "Nb_Aim";
            this.nbAimDataGridViewTextBoxColumn.HeaderText = "Nb目标";
            this.nbAimDataGridViewTextBoxColumn.Name = "nbAimDataGridViewTextBoxColumn";
            this.nbAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // nbMaxDataGridViewTextBoxColumn
            // 
            this.nbMaxDataGridViewTextBoxColumn.DataPropertyName = "Nb_Max";
            this.nbMaxDataGridViewTextBoxColumn.HeaderText = "Nb最大";
            this.nbMaxDataGridViewTextBoxColumn.Name = "nbMaxDataGridViewTextBoxColumn";
            this.nbMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // alMinDataGridViewTextBoxColumn
            // 
            this.alMinDataGridViewTextBoxColumn.DataPropertyName = "Al_Min";
            this.alMinDataGridViewTextBoxColumn.HeaderText = "Al最小";
            this.alMinDataGridViewTextBoxColumn.Name = "alMinDataGridViewTextBoxColumn";
            this.alMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.alMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // alAimDataGridViewTextBoxColumn
            // 
            this.alAimDataGridViewTextBoxColumn.DataPropertyName = "Al_Aim";
            this.alAimDataGridViewTextBoxColumn.HeaderText = "Al目标";
            this.alAimDataGridViewTextBoxColumn.Name = "alAimDataGridViewTextBoxColumn";
            this.alAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.alAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // alMaxDataGridViewTextBoxColumn
            // 
            this.alMaxDataGridViewTextBoxColumn.DataPropertyName = "Al_Max";
            this.alMaxDataGridViewTextBoxColumn.HeaderText = "Al最大";
            this.alMaxDataGridViewTextBoxColumn.Name = "alMaxDataGridViewTextBoxColumn";
            this.alMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.alMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // alSMinDataGridViewTextBoxColumn
            // 
            this.alSMinDataGridViewTextBoxColumn.DataPropertyName = "AlS_Min";
            this.alSMinDataGridViewTextBoxColumn.HeaderText = "AlS最小";
            this.alSMinDataGridViewTextBoxColumn.Name = "alSMinDataGridViewTextBoxColumn";
            this.alSMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.alSMinDataGridViewTextBoxColumn.Width = 72;
            // 
            // alSAimDataGridViewTextBoxColumn
            // 
            this.alSAimDataGridViewTextBoxColumn.DataPropertyName = "AlS_Aim";
            this.alSAimDataGridViewTextBoxColumn.HeaderText = "AlS目标";
            this.alSAimDataGridViewTextBoxColumn.Name = "alSAimDataGridViewTextBoxColumn";
            this.alSAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.alSAimDataGridViewTextBoxColumn.Width = 72;
            // 
            // alSMaxDataGridViewTextBoxColumn
            // 
            this.alSMaxDataGridViewTextBoxColumn.DataPropertyName = "AlS_Max";
            this.alSMaxDataGridViewTextBoxColumn.HeaderText = "AlS最大";
            this.alSMaxDataGridViewTextBoxColumn.Name = "alSMaxDataGridViewTextBoxColumn";
            this.alSMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.alSMaxDataGridViewTextBoxColumn.Width = 72;
            // 
            // tiMinDataGridViewTextBoxColumn
            // 
            this.tiMinDataGridViewTextBoxColumn.DataPropertyName = "Ti_Min";
            this.tiMinDataGridViewTextBoxColumn.HeaderText = "Ti最小";
            this.tiMinDataGridViewTextBoxColumn.Name = "tiMinDataGridViewTextBoxColumn";
            this.tiMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // tiAimDataGridViewTextBoxColumn
            // 
            this.tiAimDataGridViewTextBoxColumn.DataPropertyName = "Ti_Aim";
            this.tiAimDataGridViewTextBoxColumn.HeaderText = "Ti目标";
            this.tiAimDataGridViewTextBoxColumn.Name = "tiAimDataGridViewTextBoxColumn";
            this.tiAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // tiMaxDataGridViewTextBoxColumn
            // 
            this.tiMaxDataGridViewTextBoxColumn.DataPropertyName = "Ti_Max";
            this.tiMaxDataGridViewTextBoxColumn.HeaderText = "Ti最大";
            this.tiMaxDataGridViewTextBoxColumn.Name = "tiMaxDataGridViewTextBoxColumn";
            this.tiMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // bMinDataGridViewTextBoxColumn
            // 
            this.bMinDataGridViewTextBoxColumn.DataPropertyName = "B_Min";
            this.bMinDataGridViewTextBoxColumn.HeaderText = "B最小";
            this.bMinDataGridViewTextBoxColumn.Name = "bMinDataGridViewTextBoxColumn";
            this.bMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.bMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // bAimDataGridViewTextBoxColumn
            // 
            this.bAimDataGridViewTextBoxColumn.DataPropertyName = "B_Aim";
            this.bAimDataGridViewTextBoxColumn.HeaderText = "B目标";
            this.bAimDataGridViewTextBoxColumn.Name = "bAimDataGridViewTextBoxColumn";
            this.bAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.bAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // bMaxDataGridViewTextBoxColumn
            // 
            this.bMaxDataGridViewTextBoxColumn.DataPropertyName = "B_Max";
            this.bMaxDataGridViewTextBoxColumn.HeaderText = "B最大";
            this.bMaxDataGridViewTextBoxColumn.Name = "bMaxDataGridViewTextBoxColumn";
            this.bMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.bMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // sbMinDataGridViewTextBoxColumn
            // 
            this.sbMinDataGridViewTextBoxColumn.DataPropertyName = "Sb_Min";
            this.sbMinDataGridViewTextBoxColumn.HeaderText = "Sb最小";
            this.sbMinDataGridViewTextBoxColumn.Name = "sbMinDataGridViewTextBoxColumn";
            this.sbMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbAimDataGridViewTextBoxColumn
            // 
            this.sbAimDataGridViewTextBoxColumn.DataPropertyName = "Sb_Aim";
            this.sbAimDataGridViewTextBoxColumn.HeaderText = "Sb目标";
            this.sbAimDataGridViewTextBoxColumn.Name = "sbAimDataGridViewTextBoxColumn";
            this.sbAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbMaxDataGridViewTextBoxColumn
            // 
            this.sbMaxDataGridViewTextBoxColumn.DataPropertyName = "Sb_Max";
            this.sbMaxDataGridViewTextBoxColumn.HeaderText = "Sb最大";
            this.sbMaxDataGridViewTextBoxColumn.Name = "sbMaxDataGridViewTextBoxColumn";
            this.sbMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMinDataGridViewTextBoxColumn
            // 
            this.snMinDataGridViewTextBoxColumn.DataPropertyName = "Sn_Min";
            this.snMinDataGridViewTextBoxColumn.HeaderText = "Sn最小";
            this.snMinDataGridViewTextBoxColumn.Name = "snMinDataGridViewTextBoxColumn";
            this.snMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.snMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // snAimDataGridViewTextBoxColumn
            // 
            this.snAimDataGridViewTextBoxColumn.DataPropertyName = "Sn_Aim";
            this.snAimDataGridViewTextBoxColumn.HeaderText = "Sn目标";
            this.snAimDataGridViewTextBoxColumn.Name = "snAimDataGridViewTextBoxColumn";
            this.snAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.snAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMaxDataGridViewTextBoxColumn
            // 
            this.snMaxDataGridViewTextBoxColumn.DataPropertyName = "Sn_Max";
            this.snMaxDataGridViewTextBoxColumn.HeaderText = "Sn最大";
            this.snMaxDataGridViewTextBoxColumn.Name = "snMaxDataGridViewTextBoxColumn";
            this.snMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.snMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMinDataGridViewTextBoxColumn
            // 
            this.asMinDataGridViewTextBoxColumn.DataPropertyName = "As_Min";
            this.asMinDataGridViewTextBoxColumn.HeaderText = "As最小";
            this.asMinDataGridViewTextBoxColumn.Name = "asMinDataGridViewTextBoxColumn";
            this.asMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.asMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // asAimDataGridViewTextBoxColumn
            // 
            this.asAimDataGridViewTextBoxColumn.DataPropertyName = "As_Aim";
            this.asAimDataGridViewTextBoxColumn.HeaderText = "As目标";
            this.asAimDataGridViewTextBoxColumn.Name = "asAimDataGridViewTextBoxColumn";
            this.asAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.asAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMaxDataGridViewTextBoxColumn
            // 
            this.asMaxDataGridViewTextBoxColumn.DataPropertyName = "As_Max";
            this.asMaxDataGridViewTextBoxColumn.HeaderText = "As最大";
            this.asMaxDataGridViewTextBoxColumn.Name = "asMaxDataGridViewTextBoxColumn";
            this.asMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.asMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // znMinDataGridViewTextBoxColumn
            // 
            this.znMinDataGridViewTextBoxColumn.DataPropertyName = "Zn_Min";
            this.znMinDataGridViewTextBoxColumn.HeaderText = "Zn最小";
            this.znMinDataGridViewTextBoxColumn.Name = "znMinDataGridViewTextBoxColumn";
            this.znMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.znMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // znAimDataGridViewTextBoxColumn
            // 
            this.znAimDataGridViewTextBoxColumn.DataPropertyName = "Zn_Aim";
            this.znAimDataGridViewTextBoxColumn.HeaderText = "Zn目标";
            this.znAimDataGridViewTextBoxColumn.Name = "znAimDataGridViewTextBoxColumn";
            this.znAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.znAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // znMaxDataGridViewTextBoxColumn
            // 
            this.znMaxDataGridViewTextBoxColumn.DataPropertyName = "Zn_Max";
            this.znMaxDataGridViewTextBoxColumn.HeaderText = "Zn最大";
            this.znMaxDataGridViewTextBoxColumn.Name = "znMaxDataGridViewTextBoxColumn";
            this.znMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.znMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // zrMinDataGridViewTextBoxColumn
            // 
            this.zrMinDataGridViewTextBoxColumn.DataPropertyName = "Zr_Min";
            this.zrMinDataGridViewTextBoxColumn.HeaderText = "Zr最小";
            this.zrMinDataGridViewTextBoxColumn.Name = "zrMinDataGridViewTextBoxColumn";
            this.zrMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.zrMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // zrAimDataGridViewTextBoxColumn
            // 
            this.zrAimDataGridViewTextBoxColumn.DataPropertyName = "Zr_Aim";
            this.zrAimDataGridViewTextBoxColumn.HeaderText = "Zr目标";
            this.zrAimDataGridViewTextBoxColumn.Name = "zrAimDataGridViewTextBoxColumn";
            this.zrAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.zrAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // zrMaxDataGridViewTextBoxColumn
            // 
            this.zrMaxDataGridViewTextBoxColumn.DataPropertyName = "Zr_Max";
            this.zrMaxDataGridViewTextBoxColumn.HeaderText = "Zr最大";
            this.zrMaxDataGridViewTextBoxColumn.Name = "zrMaxDataGridViewTextBoxColumn";
            this.zrMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.zrMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // caMinDataGridViewTextBoxColumn
            // 
            this.caMinDataGridViewTextBoxColumn.DataPropertyName = "Ca_Min";
            this.caMinDataGridViewTextBoxColumn.HeaderText = "Ca最小";
            this.caMinDataGridViewTextBoxColumn.Name = "caMinDataGridViewTextBoxColumn";
            this.caMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.caMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // caAimDataGridViewTextBoxColumn
            // 
            this.caAimDataGridViewTextBoxColumn.DataPropertyName = "Ca_Aim";
            this.caAimDataGridViewTextBoxColumn.HeaderText = "Ca目标";
            this.caAimDataGridViewTextBoxColumn.Name = "caAimDataGridViewTextBoxColumn";
            this.caAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.caAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // caMaxDataGridViewTextBoxColumn
            // 
            this.caMaxDataGridViewTextBoxColumn.DataPropertyName = "Ca_Max";
            this.caMaxDataGridViewTextBoxColumn.HeaderText = "Ca最大";
            this.caMaxDataGridViewTextBoxColumn.Name = "caMaxDataGridViewTextBoxColumn";
            this.caMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.caMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // wMinDataGridViewTextBoxColumn
            // 
            this.wMinDataGridViewTextBoxColumn.DataPropertyName = "W_Min";
            this.wMinDataGridViewTextBoxColumn.HeaderText = "W最小";
            this.wMinDataGridViewTextBoxColumn.Name = "wMinDataGridViewTextBoxColumn";
            this.wMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.wMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // wAimDataGridViewTextBoxColumn
            // 
            this.wAimDataGridViewTextBoxColumn.DataPropertyName = "W_Aim";
            this.wAimDataGridViewTextBoxColumn.HeaderText = "W目标";
            this.wAimDataGridViewTextBoxColumn.Name = "wAimDataGridViewTextBoxColumn";
            this.wAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.wAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // wMaxDataGridViewTextBoxColumn
            // 
            this.wMaxDataGridViewTextBoxColumn.DataPropertyName = "W_Max";
            this.wMaxDataGridViewTextBoxColumn.HeaderText = "W最大";
            this.wMaxDataGridViewTextBoxColumn.Name = "wMaxDataGridViewTextBoxColumn";
            this.wMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.wMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // pbMinDataGridViewTextBoxColumn
            // 
            this.pbMinDataGridViewTextBoxColumn.DataPropertyName = "Pb_Min";
            this.pbMinDataGridViewTextBoxColumn.HeaderText = "Pb最小";
            this.pbMinDataGridViewTextBoxColumn.Name = "pbMinDataGridViewTextBoxColumn";
            this.pbMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbAimDataGridViewTextBoxColumn
            // 
            this.pbAimDataGridViewTextBoxColumn.DataPropertyName = "Pb_Aim";
            this.pbAimDataGridViewTextBoxColumn.HeaderText = "Pb目标";
            this.pbAimDataGridViewTextBoxColumn.Name = "pbAimDataGridViewTextBoxColumn";
            this.pbAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbMaxDataGridViewTextBoxColumn
            // 
            this.pbMaxDataGridViewTextBoxColumn.DataPropertyName = "Pb_Max";
            this.pbMaxDataGridViewTextBoxColumn.HeaderText = "Pb最大";
            this.pbMaxDataGridViewTextBoxColumn.Name = "pbMaxDataGridViewTextBoxColumn";
            this.pbMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // reMinDataGridViewTextBoxColumn
            // 
            this.reMinDataGridViewTextBoxColumn.DataPropertyName = "Re_Min";
            this.reMinDataGridViewTextBoxColumn.HeaderText = "Re最小";
            this.reMinDataGridViewTextBoxColumn.Name = "reMinDataGridViewTextBoxColumn";
            this.reMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.reMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // reAimDataGridViewTextBoxColumn
            // 
            this.reAimDataGridViewTextBoxColumn.DataPropertyName = "Re_Aim";
            this.reAimDataGridViewTextBoxColumn.HeaderText = "Re目标";
            this.reAimDataGridViewTextBoxColumn.Name = "reAimDataGridViewTextBoxColumn";
            this.reAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.reAimDataGridViewTextBoxColumn.Width = 66;
            // 
            // reMaxDataGridViewTextBoxColumn
            // 
            this.reMaxDataGridViewTextBoxColumn.DataPropertyName = "Re_Max";
            this.reMaxDataGridViewTextBoxColumn.HeaderText = "Re最大";
            this.reMaxDataGridViewTextBoxColumn.Name = "reMaxDataGridViewTextBoxColumn";
            this.reMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.reMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // ceqMinDataGridViewTextBoxColumn
            // 
            this.ceqMinDataGridViewTextBoxColumn.DataPropertyName = "Ceq_Min";
            this.ceqMinDataGridViewTextBoxColumn.HeaderText = "Ceq最小";
            this.ceqMinDataGridViewTextBoxColumn.Name = "ceqMinDataGridViewTextBoxColumn";
            this.ceqMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.ceqMinDataGridViewTextBoxColumn.Width = 72;
            // 
            // ceqAimDataGridViewTextBoxColumn
            // 
            this.ceqAimDataGridViewTextBoxColumn.DataPropertyName = "Ceq_Aim";
            this.ceqAimDataGridViewTextBoxColumn.HeaderText = "Ceq目标";
            this.ceqAimDataGridViewTextBoxColumn.Name = "ceqAimDataGridViewTextBoxColumn";
            this.ceqAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.ceqAimDataGridViewTextBoxColumn.Width = 72;
            // 
            // ceqMaxDataGridViewTextBoxColumn
            // 
            this.ceqMaxDataGridViewTextBoxColumn.DataPropertyName = "Ceq_Max";
            this.ceqMaxDataGridViewTextBoxColumn.HeaderText = "Ceq最大";
            this.ceqMaxDataGridViewTextBoxColumn.Name = "ceqMaxDataGridViewTextBoxColumn";
            this.ceqMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.ceqMaxDataGridViewTextBoxColumn.Width = 72;
            // 
            // nMinDataGridViewTextBoxColumn
            // 
            this.nMinDataGridViewTextBoxColumn.DataPropertyName = "N_Min";
            this.nMinDataGridViewTextBoxColumn.HeaderText = "N最小";
            this.nMinDataGridViewTextBoxColumn.Name = "nMinDataGridViewTextBoxColumn";
            this.nMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.nMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // nAimDataGridViewTextBoxColumn
            // 
            this.nAimDataGridViewTextBoxColumn.DataPropertyName = "N_Aim";
            this.nAimDataGridViewTextBoxColumn.HeaderText = "N目标";
            this.nAimDataGridViewTextBoxColumn.Name = "nAimDataGridViewTextBoxColumn";
            this.nAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // nMaxDataGridViewTextBoxColumn
            // 
            this.nMaxDataGridViewTextBoxColumn.DataPropertyName = "N_Max";
            this.nMaxDataGridViewTextBoxColumn.HeaderText = "N最大";
            this.nMaxDataGridViewTextBoxColumn.Name = "nMaxDataGridViewTextBoxColumn";
            this.nMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // hMinDataGridViewTextBoxColumn
            // 
            this.hMinDataGridViewTextBoxColumn.DataPropertyName = "H_Min";
            this.hMinDataGridViewTextBoxColumn.HeaderText = "H最小";
            this.hMinDataGridViewTextBoxColumn.Name = "hMinDataGridViewTextBoxColumn";
            this.hMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.hMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // hAimDataGridViewTextBoxColumn
            // 
            this.hAimDataGridViewTextBoxColumn.DataPropertyName = "H_Aim";
            this.hAimDataGridViewTextBoxColumn.HeaderText = "H目标";
            this.hAimDataGridViewTextBoxColumn.Name = "hAimDataGridViewTextBoxColumn";
            this.hAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.hAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // hMaxDataGridViewTextBoxColumn
            // 
            this.hMaxDataGridViewTextBoxColumn.DataPropertyName = "H_Max";
            this.hMaxDataGridViewTextBoxColumn.HeaderText = "H最大";
            this.hMaxDataGridViewTextBoxColumn.Name = "hMaxDataGridViewTextBoxColumn";
            this.hMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.hMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // oMinDataGridViewTextBoxColumn
            // 
            this.oMinDataGridViewTextBoxColumn.DataPropertyName = "O_Min";
            this.oMinDataGridViewTextBoxColumn.HeaderText = "O最小";
            this.oMinDataGridViewTextBoxColumn.Name = "oMinDataGridViewTextBoxColumn";
            this.oMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.oMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // oAimDataGridViewTextBoxColumn
            // 
            this.oAimDataGridViewTextBoxColumn.DataPropertyName = "O_Aim";
            this.oAimDataGridViewTextBoxColumn.HeaderText = "O目标";
            this.oAimDataGridViewTextBoxColumn.Name = "oAimDataGridViewTextBoxColumn";
            this.oAimDataGridViewTextBoxColumn.ReadOnly = true;
            this.oAimDataGridViewTextBoxColumn.Width = 60;
            // 
            // oMaxDataGridViewTextBoxColumn
            // 
            this.oMaxDataGridViewTextBoxColumn.DataPropertyName = "O_Max";
            this.oMaxDataGridViewTextBoxColumn.HeaderText = "O最大";
            this.oMaxDataGridViewTextBoxColumn.Name = "oMaxDataGridViewTextBoxColumn";
            this.oMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.oMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // CrNi_Min
            // 
            this.CrNi_Min.DataPropertyName = "CrNi_Min";
            this.CrNi_Min.HeaderText = "CrNi最小";
            this.CrNi_Min.Name = "CrNi_Min";
            this.CrNi_Min.ReadOnly = true;
            this.CrNi_Min.Width = 78;
            // 
            // CrNi_Aim
            // 
            this.CrNi_Aim.DataPropertyName = "CrNi_Aim";
            this.CrNi_Aim.HeaderText = "CrNi目标";
            this.CrNi_Aim.Name = "CrNi_Aim";
            this.CrNi_Aim.ReadOnly = true;
            this.CrNi_Aim.Width = 78;
            // 
            // CrNi_Max
            // 
            this.CrNi_Max.DataPropertyName = "CrNi_Max";
            this.CrNi_Max.HeaderText = "CrNi最大";
            this.CrNi_Max.Name = "CrNi_Max";
            this.CrNi_Max.ReadOnly = true;
            this.CrNi_Max.Width = 78;
            // 
            // CrCu_Min
            // 
            this.CrCu_Min.DataPropertyName = "CrCu_Min";
            this.CrCu_Min.HeaderText = "CrCu最小";
            this.CrCu_Min.Name = "CrCu_Min";
            this.CrCu_Min.ReadOnly = true;
            this.CrCu_Min.Width = 78;
            // 
            // CrCu_Aim
            // 
            this.CrCu_Aim.DataPropertyName = "CrCu_Aim";
            this.CrCu_Aim.HeaderText = "CrCu目标";
            this.CrCu_Aim.Name = "CrCu_Aim";
            this.CrCu_Aim.ReadOnly = true;
            this.CrCu_Aim.Width = 78;
            // 
            // CrCu_Max
            // 
            this.CrCu_Max.DataPropertyName = "CrCu_Max";
            this.CrCu_Max.HeaderText = "CrCu最大";
            this.CrCu_Max.Name = "CrCu_Max";
            this.CrCu_Max.ReadOnly = true;
            this.CrCu_Max.Width = 78;
            // 
            // CrNiCu_Min
            // 
            this.CrNiCu_Min.DataPropertyName = "CrNiCu_Min";
            this.CrNiCu_Min.HeaderText = "CrNiCu最小";
            this.CrNiCu_Min.Name = "CrNiCu_Min";
            this.CrNiCu_Min.ReadOnly = true;
            this.CrNiCu_Min.Width = 90;
            // 
            // CrNiCu_Aim
            // 
            this.CrNiCu_Aim.DataPropertyName = "CrNiCu_Aim";
            this.CrNiCu_Aim.HeaderText = "CrNiCu目标";
            this.CrNiCu_Aim.Name = "CrNiCu_Aim";
            this.CrNiCu_Aim.ReadOnly = true;
            this.CrNiCu_Aim.Width = 90;
            // 
            // CrNiCu_Max
            // 
            this.CrNiCu_Max.DataPropertyName = "CrNiCu_Max";
            this.CrNiCu_Max.HeaderText = "CrNiCu最大";
            this.CrNiCu_Max.Name = "CrNiCu_Max";
            this.CrNiCu_Max.ReadOnly = true;
            this.CrNiCu_Max.Width = 90;
            // 
            // other1MinDataGridViewTextBoxColumn
            // 
            this.other1MinDataGridViewTextBoxColumn.DataPropertyName = "Other1_Min";
            this.other1MinDataGridViewTextBoxColumn.HeaderText = "Other1最小";
            this.other1MinDataGridViewTextBoxColumn.Name = "other1MinDataGridViewTextBoxColumn";
            this.other1MinDataGridViewTextBoxColumn.ReadOnly = true;
            this.other1MinDataGridViewTextBoxColumn.Width = 90;
            // 
            // other1AimDataGridViewTextBoxColumn
            // 
            this.other1AimDataGridViewTextBoxColumn.DataPropertyName = "Other1_Aim";
            this.other1AimDataGridViewTextBoxColumn.HeaderText = "Other1目标";
            this.other1AimDataGridViewTextBoxColumn.Name = "other1AimDataGridViewTextBoxColumn";
            this.other1AimDataGridViewTextBoxColumn.ReadOnly = true;
            this.other1AimDataGridViewTextBoxColumn.Width = 90;
            // 
            // other1MaxDataGridViewTextBoxColumn
            // 
            this.other1MaxDataGridViewTextBoxColumn.DataPropertyName = "Other1_Max";
            this.other1MaxDataGridViewTextBoxColumn.HeaderText = "Other1最大";
            this.other1MaxDataGridViewTextBoxColumn.Name = "other1MaxDataGridViewTextBoxColumn";
            this.other1MaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.other1MaxDataGridViewTextBoxColumn.Width = 90;
            // 
            // other2MinDataGridViewTextBoxColumn
            // 
            this.other2MinDataGridViewTextBoxColumn.DataPropertyName = "Other2_Min";
            this.other2MinDataGridViewTextBoxColumn.HeaderText = "Other2最小";
            this.other2MinDataGridViewTextBoxColumn.Name = "other2MinDataGridViewTextBoxColumn";
            this.other2MinDataGridViewTextBoxColumn.ReadOnly = true;
            this.other2MinDataGridViewTextBoxColumn.Width = 90;
            // 
            // other2AimDataGridViewTextBoxColumn
            // 
            this.other2AimDataGridViewTextBoxColumn.DataPropertyName = "Other2_Aim";
            this.other2AimDataGridViewTextBoxColumn.HeaderText = "Other2目标";
            this.other2AimDataGridViewTextBoxColumn.Name = "other2AimDataGridViewTextBoxColumn";
            this.other2AimDataGridViewTextBoxColumn.ReadOnly = true;
            this.other2AimDataGridViewTextBoxColumn.Width = 90;
            // 
            // other2MaxDataGridViewTextBoxColumn
            // 
            this.other2MaxDataGridViewTextBoxColumn.DataPropertyName = "Other2_Max";
            this.other2MaxDataGridViewTextBoxColumn.HeaderText = "Other2最大";
            this.other2MaxDataGridViewTextBoxColumn.Name = "other2MaxDataGridViewTextBoxColumn";
            this.other2MaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.other2MaxDataGridViewTextBoxColumn.Width = 90;
            // 
            // Other3_Min
            // 
            this.Other3_Min.DataPropertyName = "Other3_Min";
            this.Other3_Min.HeaderText = "Other3最小";
            this.Other3_Min.Name = "Other3_Min";
            this.Other3_Min.ReadOnly = true;
            this.Other3_Min.Width = 90;
            // 
            // Other3_Aim
            // 
            this.Other3_Aim.DataPropertyName = "Other3_Aim";
            this.Other3_Aim.HeaderText = "Other3目标";
            this.Other3_Aim.Name = "Other3_Aim";
            this.Other3_Aim.ReadOnly = true;
            this.Other3_Aim.Width = 90;
            // 
            // Other3_Max
            // 
            this.Other3_Max.DataPropertyName = "Other3_Max";
            this.Other3_Max.HeaderText = "Other3最大";
            this.Other3_Max.Name = "Other3_Max";
            this.Other3_Max.ReadOnly = true;
            this.Other3_Max.Width = 90;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
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
            // ProduceSheetMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProduceSheetMainten);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduceSheetMaintenFrm";
            this.TabText = "工艺卡维护";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.ProduceSheetMaintenFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProduceSheetMaintenFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduceSheetMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduceSheetMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProduceSheetMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProduceSheetMainten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProduceSheetMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsProduceSheetMainten;
        private AppSvrHMI.L3DataSet dsProduceSheetMainten;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanelProduceSheetMainten;
        private System.Windows.Forms.ToolStripComboBox tscmbSteelGradeIndex;
        private System.Data.DataTable schemadsProduceSheetMainten;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableGUID;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableName;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLadle_Brick;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLadle_Use;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLadle_Pre_SteelGrade;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLadle_Stay;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableBOF_Type;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLadle_Tapped_Proc;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableLF_Type;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableRH_Type;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCaster_Type;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableC_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableC_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableC_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSi_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSi_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSi_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMn_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMn_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMn_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableP_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableP_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableP_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableS_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableS_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableS_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCu_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCu_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCu_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNi_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNi_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNi_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCr_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCr_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCr_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMo_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMo_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableMo_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableV_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableV_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableV_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNb_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNb_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableNb_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAl_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAl_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAl_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAlS_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAlS_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAlS_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableTi_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableTi_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableTi_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableB_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableB_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableB_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSb_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSb_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSb_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSn_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSn_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableSn_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAs_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAs_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAs_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZn_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZn_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZn_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZr_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZr_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableZr_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCa_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCa_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCa_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableW_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableW_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableW_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTablePb_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTablePb_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTablePb_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableRe_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableRe_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableRe_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCeq_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCeq_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCeq_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableN_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableN_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableN_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableH_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableH_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableH_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableO_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableO_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableO_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther1_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther1_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther1_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther2_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther2_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther2_Max;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Windows.Forms.DataGridView dvProduceSheetMainten;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNi_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNi_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNi_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrCu_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrCu_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrCu_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNiCu_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNiCu_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableCrNiCu_Max;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther3_Min;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther3_Aim;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableOther3_Max;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private System.Data.DataColumn coldsProduceSheetMaintenL3DataTableAOD_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleBrickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleUseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladlePreSteelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleTappedProcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AOD_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotSendFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi_Aim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu_Aim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu_Aim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1MinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1AimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1MaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2MinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2AimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2MaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3_Aim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
    }
}