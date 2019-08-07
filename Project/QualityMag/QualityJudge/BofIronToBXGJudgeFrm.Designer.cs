namespace QualityMag
{
    partial class BofIronToBXGJudgeFrm
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
            System.Windows.Forms.Label label36;
            System.Windows.Forms.Label lblSbMax;
            System.Windows.Forms.Label lblReMin;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsChemicalStd = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdChemicalStd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsChemicalStd = new System.Data.DataTable();
            this.coldsChemicalStdL3DataTableName = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLadle_Brick = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLadle_Use = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLadle_Pre_SteelGrade = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLadle_Stay = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableBOF_Type = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLadle_Tapped_Proc = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLF_Type = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRH_Type = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCaster_Type = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSi_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSi_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSi_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMn_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMn_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMn_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCu_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCu_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCu_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNi_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNi_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNi_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCr_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCr_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCr_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMo_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMo_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMo_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNb_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNb_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNb_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAl_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAl_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAl_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAlS_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAlS_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAlS_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTi_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTi_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTi_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSb_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSb_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSb_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSn_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSn_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSn_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAs_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAs_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAs_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZn_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZn_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZn_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZr_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZr_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZr_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCa_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCa_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCa_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePb_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePb_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePb_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRe_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRe_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRe_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCeq_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCeq_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCeq_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther1_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther1_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther1_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther2_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther2_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther2_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Max = new System.Data.DataColumn();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.schemadsHeatID = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableHeatID = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvHeatID = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.myLine5 = new buttonHide.MyLine();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrMoNiCuMax = new System.Windows.Forms.Label();
            this.lblOMax = new System.Windows.Forms.Label();
            this.lblNMax = new System.Windows.Forms.Label();
            this.lblHMax = new System.Windows.Forms.Label();
            this.lblCeqMax = new System.Windows.Forms.Label();
            this.lblReMax = new System.Windows.Forms.Label();
            this.lblPbMax = new System.Windows.Forms.Label();
            this.lblWMax = new System.Windows.Forms.Label();
            this.lblCaMax = new System.Windows.Forms.Label();
            this.lblZrMax = new System.Windows.Forms.Label();
            this.lblZnMax = new System.Windows.Forms.Label();
            this.lblAsMax = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblSnMax = new System.Windows.Forms.Label();
            this.lblCrMoNiCuMin = new System.Windows.Forms.Label();
            this.lblHMin = new System.Windows.Forms.Label();
            this.lblOMin = new System.Windows.Forms.Label();
            this.lblNMin = new System.Windows.Forms.Label();
            this.lblCeqMin = new System.Windows.Forms.Label();
            this.lblPbMin = new System.Windows.Forms.Label();
            this.lblWMin = new System.Windows.Forms.Label();
            this.lblCaMin = new System.Windows.Forms.Label();
            this.lblZrMin = new System.Windows.Forms.Label();
            this.lblZnMin = new System.Windows.Forms.Label();
            this.lblAsMin = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSnMin = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblSbMin = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBMax = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblBMin = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTiMax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTiMin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAlsMax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAlsMin = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblAlMax = new System.Windows.Forms.Label();
            this.lblAlMin = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.lblNbMax = new System.Windows.Forms.Label();
            this.lblNbMin = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.lblVMax = new System.Windows.Forms.Label();
            this.lblVMin = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.lblMoMax = new System.Windows.Forms.Label();
            this.lblMoMin = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.lblCrMax = new System.Windows.Forms.Label();
            this.lblCrMin = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lblNiMax = new System.Windows.Forms.Label();
            this.lblNiMin = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.lblCuMax = new System.Windows.Forms.Label();
            this.lblCuMin = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lblSMax = new System.Windows.Forms.Label();
            this.lblSMin = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.lblPMax = new System.Windows.Forms.Label();
            this.lblPMin = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblMnMax = new System.Windows.Forms.Label();
            this.lblMnMin = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.lblSiMax = new System.Windows.Forms.Label();
            this.lblSiMin = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lblCMax = new System.Windows.Forms.Label();
            this.lblCMin = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dvHeatExcept = new System.Windows.Forms.DataGridView();
            this.exceptionalTimeDataGridViewTextBoxColumn = new DataGridValid.DataGridViewValidateCellColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHeatExcept = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatExcept = new AppSvrHMI.L3DataSet();
            this.schemadsHeatExcept = new System.Data.DataTable();
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
            this.dvRefineThirdEle = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crNiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crNiCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalJudgeFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRefineThirdEle = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefineThirdEle = new AppSvrHMI.L3DataSet();
            this.cmdRefineThirdEle = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemadsRefineThirdEle = new System.Data.DataTable();
            this.coldsRefineThirdEleL3DataTableName = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAppID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableC = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSi = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableMn = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableP = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCu = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableNi = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCr = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableMo = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableV = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableNb = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAl = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAlS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableTi = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableB = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSb = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAs = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSn = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableZn = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCa = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableW = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTablePb = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableRe = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCeq = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableN = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableH = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableO = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOperator = new System.Data.DataColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dvFinalChemical = new System.Windows.Forms.DataGridView();
            this.bsFinalChemical = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinalChemical = new AppSvrHMI.L3DataSet();
            this.cmdFinalChemical = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.schemadsFinalChemical = new System.Data.DataTable();
            this.coldsFinalChemicalL3DataTableName = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAppID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableC = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSi = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableMn = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableP = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCu = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableNi = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCr = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableMo = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableV = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableNb = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAl = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAlS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableTi = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableB = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSb = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAs = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSn = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableZn = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCa = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableW = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTablePb = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableRe = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCeq = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableN = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableH = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableO = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOperator = new System.Data.DataColumn();
            this.AcoldsFinalChemicalL3DataTableCheckFlag = new System.Data.DataColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJudge = new System.Windows.Forms.Button();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsHeatGrade = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatGrade = new AppSvrHMI.L3DataSet();
            this.schemadsHeatGrade = new System.Data.DataTable();
            this.coldsHeatGradeL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableProcessCount = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableHeatGrade = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsHeatGradeL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCheckFlag = new System.Data.DataColumn();
            this.cmdJudge = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn96 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn97 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn98 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn99 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn106 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn108 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn109 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn115 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn116 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn117 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn118 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn119 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crNiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crNiCuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalJudgeFlagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label36 = new System.Windows.Forms.Label();
            lblSbMax = new System.Windows.Forms.Label();
            lblReMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemicalStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemicalStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).BeginInit();
            this.panel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefineThirdEle)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinalChemical)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other2_Max", true));
            label36.Location = new System.Drawing.Point(823, 168);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(23, 12);
            label36.TabIndex = 250;
            label36.Text = "XXX";
            // 
            // dsChemicalStd
            // 
            this.dsChemicalStd.AutoLoad = true;
            this.dsChemicalStd.AutoSubscribe = false;
            this.dsChemicalStd.DataSetName = "L3DataSet";
            this.dsChemicalStd.DeleteMethod = "";
            this.dsChemicalStd.InsertMethod = "";
            this.dsChemicalStd.L3DataAdapter = this.Adapter;
            this.dsChemicalStd.LoadEvent = "Click";
            this.dsChemicalStd.LoadTrigger = null;
            this.dsChemicalStd.RefreshValve = 1000;
            this.dsChemicalStd.SourceCommand = this.cmdChemicalStd;
            this.dsChemicalStd.SourceCondition = null;
            this.dsChemicalStd.SourceMethod = "GetBloomStdEle";
            this.dsChemicalStd.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsChemicalStd.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.dsChemicalStd.SubscribeTarget = null;
            this.dsChemicalStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChemicalStd});
            this.dsChemicalStd.UpdateEvent = "Click";
            this.dsChemicalStd.UpdateMethod = "";
            this.dsChemicalStd.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdChemicalStd
            // 
            this.cmdChemicalStd.Adapter = null;
            this.cmdChemicalStd.MergeReturnTarget = false;
            this.cmdChemicalStd.Method = "GetBloomStdEle";
            this.cmdChemicalStd.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdChemicalStd.Parameters.Add(this.l3CommandParameter1);
            this.cmdChemicalStd.ReturnTarget = null;
            this.cmdChemicalStd.ReturnTargetProperty = null;
            this.cmdChemicalStd.Trigger = null;
            this.cmdChemicalStd.TriggerEvent = "Click";
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
            // schemadsChemicalStd
            // 
            this.schemadsChemicalStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChemicalStdL3DataTableName,
            this.coldsChemicalStdL3DataTableSteelGradeIndex,
            this.coldsChemicalStdL3DataTableLadle_Brick,
            this.coldsChemicalStdL3DataTableLadle_Use,
            this.coldsChemicalStdL3DataTableLadle_Pre_SteelGrade,
            this.coldsChemicalStdL3DataTableLadle_Stay,
            this.coldsChemicalStdL3DataTableBOF_Type,
            this.coldsChemicalStdL3DataTableLadle_Tapped_Proc,
            this.coldsChemicalStdL3DataTableLF_Type,
            this.coldsChemicalStdL3DataTableRH_Type,
            this.coldsChemicalStdL3DataTableCaster_Type,
            this.coldsChemicalStdL3DataTableHot_Send_Flag,
            this.coldsChemicalStdL3DataTableC_Min,
            this.coldsChemicalStdL3DataTableC_Aim,
            this.coldsChemicalStdL3DataTableC_Max,
            this.coldsChemicalStdL3DataTableSi_Min,
            this.coldsChemicalStdL3DataTableSi_Aim,
            this.coldsChemicalStdL3DataTableSi_Max,
            this.coldsChemicalStdL3DataTableMn_Min,
            this.coldsChemicalStdL3DataTableMn_Aim,
            this.coldsChemicalStdL3DataTableMn_Max,
            this.coldsChemicalStdL3DataTableP_Min,
            this.coldsChemicalStdL3DataTableP_Aim,
            this.coldsChemicalStdL3DataTableP_Max,
            this.coldsChemicalStdL3DataTableS_Min,
            this.coldsChemicalStdL3DataTableS_Aim,
            this.coldsChemicalStdL3DataTableS_Max,
            this.coldsChemicalStdL3DataTableCu_Min,
            this.coldsChemicalStdL3DataTableCu_Aim,
            this.coldsChemicalStdL3DataTableCu_Max,
            this.coldsChemicalStdL3DataTableNi_Min,
            this.coldsChemicalStdL3DataTableNi_Aim,
            this.coldsChemicalStdL3DataTableNi_Max,
            this.coldsChemicalStdL3DataTableCr_Min,
            this.coldsChemicalStdL3DataTableCr_Aim,
            this.coldsChemicalStdL3DataTableCr_Max,
            this.coldsChemicalStdL3DataTableMo_Min,
            this.coldsChemicalStdL3DataTableMo_Aim,
            this.coldsChemicalStdL3DataTableMo_Max,
            this.coldsChemicalStdL3DataTableV_Min,
            this.coldsChemicalStdL3DataTableV_Aim,
            this.coldsChemicalStdL3DataTableV_Max,
            this.coldsChemicalStdL3DataTableNb_Min,
            this.coldsChemicalStdL3DataTableNb_Aim,
            this.coldsChemicalStdL3DataTableNb_Max,
            this.coldsChemicalStdL3DataTableAl_Min,
            this.coldsChemicalStdL3DataTableAl_Aim,
            this.coldsChemicalStdL3DataTableAl_Max,
            this.coldsChemicalStdL3DataTableAlS_Min,
            this.coldsChemicalStdL3DataTableAlS_Aim,
            this.coldsChemicalStdL3DataTableAlS_Max,
            this.coldsChemicalStdL3DataTableTi_Min,
            this.coldsChemicalStdL3DataTableTi_Aim,
            this.coldsChemicalStdL3DataTableTi_Max,
            this.coldsChemicalStdL3DataTableB_Min,
            this.coldsChemicalStdL3DataTableB_Aim,
            this.coldsChemicalStdL3DataTableB_Max,
            this.coldsChemicalStdL3DataTableSb_Min,
            this.coldsChemicalStdL3DataTableSb_Aim,
            this.coldsChemicalStdL3DataTableSb_Max,
            this.coldsChemicalStdL3DataTableSn_Min,
            this.coldsChemicalStdL3DataTableSn_Aim,
            this.coldsChemicalStdL3DataTableSn_Max,
            this.coldsChemicalStdL3DataTableAs_Min,
            this.coldsChemicalStdL3DataTableAs_Aim,
            this.coldsChemicalStdL3DataTableAs_Max,
            this.coldsChemicalStdL3DataTableZn_Min,
            this.coldsChemicalStdL3DataTableZn_Aim,
            this.coldsChemicalStdL3DataTableZn_Max,
            this.coldsChemicalStdL3DataTableZr_Min,
            this.coldsChemicalStdL3DataTableZr_Aim,
            this.coldsChemicalStdL3DataTableZr_Max,
            this.coldsChemicalStdL3DataTableCa_Min,
            this.coldsChemicalStdL3DataTableCa_Aim,
            this.coldsChemicalStdL3DataTableCa_Max,
            this.coldsChemicalStdL3DataTableW_Min,
            this.coldsChemicalStdL3DataTableW_Aim,
            this.coldsChemicalStdL3DataTableW_Max,
            this.coldsChemicalStdL3DataTablePb_Min,
            this.coldsChemicalStdL3DataTablePb_Aim,
            this.coldsChemicalStdL3DataTablePb_Max,
            this.coldsChemicalStdL3DataTableRe_Min,
            this.coldsChemicalStdL3DataTableRe_Aim,
            this.coldsChemicalStdL3DataTableRe_Max,
            this.coldsChemicalStdL3DataTableCeq_Min,
            this.coldsChemicalStdL3DataTableCeq_Aim,
            this.coldsChemicalStdL3DataTableCeq_Max,
            this.coldsChemicalStdL3DataTableN_Min,
            this.coldsChemicalStdL3DataTableN_Aim,
            this.coldsChemicalStdL3DataTableN_Max,
            this.coldsChemicalStdL3DataTableH_Min,
            this.coldsChemicalStdL3DataTableH_Aim,
            this.coldsChemicalStdL3DataTableH_Max,
            this.coldsChemicalStdL3DataTableO_Min,
            this.coldsChemicalStdL3DataTableO_Aim,
            this.coldsChemicalStdL3DataTableO_Max,
            this.coldsChemicalStdL3DataTableCrNi_Min,
            this.coldsChemicalStdL3DataTableCrNi_Aim,
            this.coldsChemicalStdL3DataTableCrNi_Max,
            this.coldsChemicalStdL3DataTableCrCu_Min,
            this.coldsChemicalStdL3DataTableCrCu_Aim,
            this.coldsChemicalStdL3DataTableCrCu_Max,
            this.coldsChemicalStdL3DataTableCrNiCu_Min,
            this.coldsChemicalStdL3DataTableCrNiCu_Aim,
            this.coldsChemicalStdL3DataTableCrNiCu_Max,
            this.coldsChemicalStdL3DataTableOther1_Min,
            this.coldsChemicalStdL3DataTableOther1_Aim,
            this.coldsChemicalStdL3DataTableOther1_Max,
            this.coldsChemicalStdL3DataTableOther2_Min,
            this.coldsChemicalStdL3DataTableOther2_Aim,
            this.coldsChemicalStdL3DataTableOther2_Max,
            this.coldsChemicalStdL3DataTableOther3_Min,
            this.coldsChemicalStdL3DataTableOther3_Aim,
            this.coldsChemicalStdL3DataTableOther3_Max});
            this.schemadsChemicalStd.TableName = "L3DataTable";
            // 
            // coldsChemicalStdL3DataTableName
            // 
            this.coldsChemicalStdL3DataTableName.Caption = "Name";
            this.coldsChemicalStdL3DataTableName.ColumnName = "Name";
            this.coldsChemicalStdL3DataTableName.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSteelGradeIndex
            // 
            this.coldsChemicalStdL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsChemicalStdL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsChemicalStdL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLadle_Brick
            // 
            this.coldsChemicalStdL3DataTableLadle_Brick.Caption = "Ladle_Brick";
            this.coldsChemicalStdL3DataTableLadle_Brick.ColumnName = "Ladle_Brick";
            this.coldsChemicalStdL3DataTableLadle_Brick.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLadle_Use
            // 
            this.coldsChemicalStdL3DataTableLadle_Use.Caption = "Ladle_Use";
            this.coldsChemicalStdL3DataTableLadle_Use.ColumnName = "Ladle_Use";
            this.coldsChemicalStdL3DataTableLadle_Use.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLadle_Pre_SteelGrade
            // 
            this.coldsChemicalStdL3DataTableLadle_Pre_SteelGrade.Caption = "Ladle_Pre_SteelGrade";
            this.coldsChemicalStdL3DataTableLadle_Pre_SteelGrade.ColumnName = "Ladle_Pre_SteelGrade";
            this.coldsChemicalStdL3DataTableLadle_Pre_SteelGrade.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLadle_Stay
            // 
            this.coldsChemicalStdL3DataTableLadle_Stay.Caption = "Ladle_Stay";
            this.coldsChemicalStdL3DataTableLadle_Stay.ColumnName = "Ladle_Stay";
            this.coldsChemicalStdL3DataTableLadle_Stay.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableBOF_Type
            // 
            this.coldsChemicalStdL3DataTableBOF_Type.Caption = "BOF_Type";
            this.coldsChemicalStdL3DataTableBOF_Type.ColumnName = "BOF_Type";
            this.coldsChemicalStdL3DataTableBOF_Type.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLadle_Tapped_Proc
            // 
            this.coldsChemicalStdL3DataTableLadle_Tapped_Proc.Caption = "Ladle_Tapped_Proc";
            this.coldsChemicalStdL3DataTableLadle_Tapped_Proc.ColumnName = "Ladle_Tapped_Proc";
            this.coldsChemicalStdL3DataTableLadle_Tapped_Proc.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLF_Type
            // 
            this.coldsChemicalStdL3DataTableLF_Type.Caption = "LF_Type";
            this.coldsChemicalStdL3DataTableLF_Type.ColumnName = "LF_Type";
            this.coldsChemicalStdL3DataTableLF_Type.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRH_Type
            // 
            this.coldsChemicalStdL3DataTableRH_Type.Caption = "RH_Type";
            this.coldsChemicalStdL3DataTableRH_Type.ColumnName = "RH_Type";
            this.coldsChemicalStdL3DataTableRH_Type.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCaster_Type
            // 
            this.coldsChemicalStdL3DataTableCaster_Type.Caption = "Caster_Type";
            this.coldsChemicalStdL3DataTableCaster_Type.ColumnName = "Caster_Type";
            this.coldsChemicalStdL3DataTableCaster_Type.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableHot_Send_Flag
            // 
            this.coldsChemicalStdL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsChemicalStdL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsChemicalStdL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsChemicalStdL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_Min
            // 
            this.coldsChemicalStdL3DataTableC_Min.Caption = "C_Min";
            this.coldsChemicalStdL3DataTableC_Min.ColumnName = "C_Min";
            this.coldsChemicalStdL3DataTableC_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_Aim
            // 
            this.coldsChemicalStdL3DataTableC_Aim.Caption = "C_Aim";
            this.coldsChemicalStdL3DataTableC_Aim.ColumnName = "C_Aim";
            this.coldsChemicalStdL3DataTableC_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_Max
            // 
            this.coldsChemicalStdL3DataTableC_Max.Caption = "C_Max";
            this.coldsChemicalStdL3DataTableC_Max.ColumnName = "C_Max";
            this.coldsChemicalStdL3DataTableC_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSi_Min
            // 
            this.coldsChemicalStdL3DataTableSi_Min.Caption = "Si_Min";
            this.coldsChemicalStdL3DataTableSi_Min.ColumnName = "Si_Min";
            this.coldsChemicalStdL3DataTableSi_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSi_Aim
            // 
            this.coldsChemicalStdL3DataTableSi_Aim.Caption = "Si_Aim";
            this.coldsChemicalStdL3DataTableSi_Aim.ColumnName = "Si_Aim";
            this.coldsChemicalStdL3DataTableSi_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSi_Max
            // 
            this.coldsChemicalStdL3DataTableSi_Max.Caption = "Si_Max";
            this.coldsChemicalStdL3DataTableSi_Max.ColumnName = "Si_Max";
            this.coldsChemicalStdL3DataTableSi_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMn_Min
            // 
            this.coldsChemicalStdL3DataTableMn_Min.Caption = "Mn_Min";
            this.coldsChemicalStdL3DataTableMn_Min.ColumnName = "Mn_Min";
            this.coldsChemicalStdL3DataTableMn_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMn_Aim
            // 
            this.coldsChemicalStdL3DataTableMn_Aim.Caption = "Mn_Aim";
            this.coldsChemicalStdL3DataTableMn_Aim.ColumnName = "Mn_Aim";
            this.coldsChemicalStdL3DataTableMn_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMn_Max
            // 
            this.coldsChemicalStdL3DataTableMn_Max.Caption = "Mn_Max";
            this.coldsChemicalStdL3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coldsChemicalStdL3DataTableMn_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_Min
            // 
            this.coldsChemicalStdL3DataTableP_Min.Caption = "P_Min";
            this.coldsChemicalStdL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsChemicalStdL3DataTableP_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_Aim
            // 
            this.coldsChemicalStdL3DataTableP_Aim.Caption = "P_Aim";
            this.coldsChemicalStdL3DataTableP_Aim.ColumnName = "P_Aim";
            this.coldsChemicalStdL3DataTableP_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_Max
            // 
            this.coldsChemicalStdL3DataTableP_Max.Caption = "P_Max";
            this.coldsChemicalStdL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsChemicalStdL3DataTableP_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_Min
            // 
            this.coldsChemicalStdL3DataTableS_Min.Caption = "S_Min";
            this.coldsChemicalStdL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsChemicalStdL3DataTableS_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_Aim
            // 
            this.coldsChemicalStdL3DataTableS_Aim.Caption = "S_Aim";
            this.coldsChemicalStdL3DataTableS_Aim.ColumnName = "S_Aim";
            this.coldsChemicalStdL3DataTableS_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_Max
            // 
            this.coldsChemicalStdL3DataTableS_Max.Caption = "S_Max";
            this.coldsChemicalStdL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsChemicalStdL3DataTableS_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCu_Min
            // 
            this.coldsChemicalStdL3DataTableCu_Min.Caption = "Cu_Min";
            this.coldsChemicalStdL3DataTableCu_Min.ColumnName = "Cu_Min";
            this.coldsChemicalStdL3DataTableCu_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCu_Aim
            // 
            this.coldsChemicalStdL3DataTableCu_Aim.Caption = "Cu_Aim";
            this.coldsChemicalStdL3DataTableCu_Aim.ColumnName = "Cu_Aim";
            this.coldsChemicalStdL3DataTableCu_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCu_Max
            // 
            this.coldsChemicalStdL3DataTableCu_Max.Caption = "Cu_Max";
            this.coldsChemicalStdL3DataTableCu_Max.ColumnName = "Cu_Max";
            this.coldsChemicalStdL3DataTableCu_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNi_Min
            // 
            this.coldsChemicalStdL3DataTableNi_Min.Caption = "Ni_Min";
            this.coldsChemicalStdL3DataTableNi_Min.ColumnName = "Ni_Min";
            this.coldsChemicalStdL3DataTableNi_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNi_Aim
            // 
            this.coldsChemicalStdL3DataTableNi_Aim.Caption = "Ni_Aim";
            this.coldsChemicalStdL3DataTableNi_Aim.ColumnName = "Ni_Aim";
            this.coldsChemicalStdL3DataTableNi_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNi_Max
            // 
            this.coldsChemicalStdL3DataTableNi_Max.Caption = "Ni_Max";
            this.coldsChemicalStdL3DataTableNi_Max.ColumnName = "Ni_Max";
            this.coldsChemicalStdL3DataTableNi_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCr_Min
            // 
            this.coldsChemicalStdL3DataTableCr_Min.Caption = "Cr_Min";
            this.coldsChemicalStdL3DataTableCr_Min.ColumnName = "Cr_Min";
            this.coldsChemicalStdL3DataTableCr_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCr_Aim
            // 
            this.coldsChemicalStdL3DataTableCr_Aim.Caption = "Cr_Aim";
            this.coldsChemicalStdL3DataTableCr_Aim.ColumnName = "Cr_Aim";
            this.coldsChemicalStdL3DataTableCr_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCr_Max
            // 
            this.coldsChemicalStdL3DataTableCr_Max.Caption = "Cr_Max";
            this.coldsChemicalStdL3DataTableCr_Max.ColumnName = "Cr_Max";
            this.coldsChemicalStdL3DataTableCr_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMo_Min
            // 
            this.coldsChemicalStdL3DataTableMo_Min.Caption = "Mo_Min";
            this.coldsChemicalStdL3DataTableMo_Min.ColumnName = "Mo_Min";
            this.coldsChemicalStdL3DataTableMo_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMo_Aim
            // 
            this.coldsChemicalStdL3DataTableMo_Aim.Caption = "Mo_Aim";
            this.coldsChemicalStdL3DataTableMo_Aim.ColumnName = "Mo_Aim";
            this.coldsChemicalStdL3DataTableMo_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMo_Max
            // 
            this.coldsChemicalStdL3DataTableMo_Max.Caption = "Mo_Max";
            this.coldsChemicalStdL3DataTableMo_Max.ColumnName = "Mo_Max";
            this.coldsChemicalStdL3DataTableMo_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_Min
            // 
            this.coldsChemicalStdL3DataTableV_Min.Caption = "V_Min";
            this.coldsChemicalStdL3DataTableV_Min.ColumnName = "V_Min";
            this.coldsChemicalStdL3DataTableV_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_Aim
            // 
            this.coldsChemicalStdL3DataTableV_Aim.Caption = "V_Aim";
            this.coldsChemicalStdL3DataTableV_Aim.ColumnName = "V_Aim";
            this.coldsChemicalStdL3DataTableV_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_Max
            // 
            this.coldsChemicalStdL3DataTableV_Max.Caption = "V_Max";
            this.coldsChemicalStdL3DataTableV_Max.ColumnName = "V_Max";
            this.coldsChemicalStdL3DataTableV_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNb_Min
            // 
            this.coldsChemicalStdL3DataTableNb_Min.Caption = "Nb_Min";
            this.coldsChemicalStdL3DataTableNb_Min.ColumnName = "Nb_Min";
            this.coldsChemicalStdL3DataTableNb_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNb_Aim
            // 
            this.coldsChemicalStdL3DataTableNb_Aim.Caption = "Nb_Aim";
            this.coldsChemicalStdL3DataTableNb_Aim.ColumnName = "Nb_Aim";
            this.coldsChemicalStdL3DataTableNb_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNb_Max
            // 
            this.coldsChemicalStdL3DataTableNb_Max.Caption = "Nb_Max";
            this.coldsChemicalStdL3DataTableNb_Max.ColumnName = "Nb_Max";
            this.coldsChemicalStdL3DataTableNb_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAl_Min
            // 
            this.coldsChemicalStdL3DataTableAl_Min.Caption = "Al_Min";
            this.coldsChemicalStdL3DataTableAl_Min.ColumnName = "Al_Min";
            this.coldsChemicalStdL3DataTableAl_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAl_Aim
            // 
            this.coldsChemicalStdL3DataTableAl_Aim.Caption = "Al_Aim";
            this.coldsChemicalStdL3DataTableAl_Aim.ColumnName = "Al_Aim";
            this.coldsChemicalStdL3DataTableAl_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAl_Max
            // 
            this.coldsChemicalStdL3DataTableAl_Max.Caption = "Al_Max";
            this.coldsChemicalStdL3DataTableAl_Max.ColumnName = "Al_Max";
            this.coldsChemicalStdL3DataTableAl_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAlS_Min
            // 
            this.coldsChemicalStdL3DataTableAlS_Min.Caption = "AlS_Min";
            this.coldsChemicalStdL3DataTableAlS_Min.ColumnName = "AlS_Min";
            this.coldsChemicalStdL3DataTableAlS_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAlS_Aim
            // 
            this.coldsChemicalStdL3DataTableAlS_Aim.Caption = "AlS_Aim";
            this.coldsChemicalStdL3DataTableAlS_Aim.ColumnName = "AlS_Aim";
            this.coldsChemicalStdL3DataTableAlS_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAlS_Max
            // 
            this.coldsChemicalStdL3DataTableAlS_Max.Caption = "AlS_Max";
            this.coldsChemicalStdL3DataTableAlS_Max.ColumnName = "AlS_Max";
            this.coldsChemicalStdL3DataTableAlS_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTi_Min
            // 
            this.coldsChemicalStdL3DataTableTi_Min.Caption = "Ti_Min";
            this.coldsChemicalStdL3DataTableTi_Min.ColumnName = "Ti_Min";
            this.coldsChemicalStdL3DataTableTi_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTi_Aim
            // 
            this.coldsChemicalStdL3DataTableTi_Aim.Caption = "Ti_Aim";
            this.coldsChemicalStdL3DataTableTi_Aim.ColumnName = "Ti_Aim";
            this.coldsChemicalStdL3DataTableTi_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTi_Max
            // 
            this.coldsChemicalStdL3DataTableTi_Max.Caption = "Ti_Max";
            this.coldsChemicalStdL3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coldsChemicalStdL3DataTableTi_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_Min
            // 
            this.coldsChemicalStdL3DataTableB_Min.Caption = "B_Min";
            this.coldsChemicalStdL3DataTableB_Min.ColumnName = "B_Min";
            this.coldsChemicalStdL3DataTableB_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_Aim
            // 
            this.coldsChemicalStdL3DataTableB_Aim.Caption = "B_Aim";
            this.coldsChemicalStdL3DataTableB_Aim.ColumnName = "B_Aim";
            this.coldsChemicalStdL3DataTableB_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_Max
            // 
            this.coldsChemicalStdL3DataTableB_Max.Caption = "B_Max";
            this.coldsChemicalStdL3DataTableB_Max.ColumnName = "B_Max";
            this.coldsChemicalStdL3DataTableB_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSb_Min
            // 
            this.coldsChemicalStdL3DataTableSb_Min.Caption = "Sb_Min";
            this.coldsChemicalStdL3DataTableSb_Min.ColumnName = "Sb_Min";
            this.coldsChemicalStdL3DataTableSb_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSb_Aim
            // 
            this.coldsChemicalStdL3DataTableSb_Aim.Caption = "Sb_Aim";
            this.coldsChemicalStdL3DataTableSb_Aim.ColumnName = "Sb_Aim";
            this.coldsChemicalStdL3DataTableSb_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSb_Max
            // 
            this.coldsChemicalStdL3DataTableSb_Max.Caption = "Sb_Max";
            this.coldsChemicalStdL3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coldsChemicalStdL3DataTableSb_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSn_Min
            // 
            this.coldsChemicalStdL3DataTableSn_Min.Caption = "Sn_Min";
            this.coldsChemicalStdL3DataTableSn_Min.ColumnName = "Sn_Min";
            this.coldsChemicalStdL3DataTableSn_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSn_Aim
            // 
            this.coldsChemicalStdL3DataTableSn_Aim.Caption = "Sn_Aim";
            this.coldsChemicalStdL3DataTableSn_Aim.ColumnName = "Sn_Aim";
            this.coldsChemicalStdL3DataTableSn_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSn_Max
            // 
            this.coldsChemicalStdL3DataTableSn_Max.Caption = "Sn_Max";
            this.coldsChemicalStdL3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coldsChemicalStdL3DataTableSn_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAs_Min
            // 
            this.coldsChemicalStdL3DataTableAs_Min.Caption = "As_Min";
            this.coldsChemicalStdL3DataTableAs_Min.ColumnName = "As_Min";
            this.coldsChemicalStdL3DataTableAs_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAs_Aim
            // 
            this.coldsChemicalStdL3DataTableAs_Aim.Caption = "As_Aim";
            this.coldsChemicalStdL3DataTableAs_Aim.ColumnName = "As_Aim";
            this.coldsChemicalStdL3DataTableAs_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAs_Max
            // 
            this.coldsChemicalStdL3DataTableAs_Max.Caption = "As_Max";
            this.coldsChemicalStdL3DataTableAs_Max.ColumnName = "As_Max";
            this.coldsChemicalStdL3DataTableAs_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZn_Min
            // 
            this.coldsChemicalStdL3DataTableZn_Min.Caption = "Zn_Min";
            this.coldsChemicalStdL3DataTableZn_Min.ColumnName = "Zn_Min";
            this.coldsChemicalStdL3DataTableZn_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZn_Aim
            // 
            this.coldsChemicalStdL3DataTableZn_Aim.Caption = "Zn_Aim";
            this.coldsChemicalStdL3DataTableZn_Aim.ColumnName = "Zn_Aim";
            this.coldsChemicalStdL3DataTableZn_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZn_Max
            // 
            this.coldsChemicalStdL3DataTableZn_Max.Caption = "Zn_Max";
            this.coldsChemicalStdL3DataTableZn_Max.ColumnName = "Zn_Max";
            this.coldsChemicalStdL3DataTableZn_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZr_Min
            // 
            this.coldsChemicalStdL3DataTableZr_Min.Caption = "Zr_Min";
            this.coldsChemicalStdL3DataTableZr_Min.ColumnName = "Zr_Min";
            this.coldsChemicalStdL3DataTableZr_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZr_Aim
            // 
            this.coldsChemicalStdL3DataTableZr_Aim.Caption = "Zr_Aim";
            this.coldsChemicalStdL3DataTableZr_Aim.ColumnName = "Zr_Aim";
            this.coldsChemicalStdL3DataTableZr_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZr_Max
            // 
            this.coldsChemicalStdL3DataTableZr_Max.Caption = "Zr_Max";
            this.coldsChemicalStdL3DataTableZr_Max.ColumnName = "Zr_Max";
            this.coldsChemicalStdL3DataTableZr_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCa_Min
            // 
            this.coldsChemicalStdL3DataTableCa_Min.Caption = "Ca_Min";
            this.coldsChemicalStdL3DataTableCa_Min.ColumnName = "Ca_Min";
            this.coldsChemicalStdL3DataTableCa_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCa_Aim
            // 
            this.coldsChemicalStdL3DataTableCa_Aim.Caption = "Ca_Aim";
            this.coldsChemicalStdL3DataTableCa_Aim.ColumnName = "Ca_Aim";
            this.coldsChemicalStdL3DataTableCa_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCa_Max
            // 
            this.coldsChemicalStdL3DataTableCa_Max.Caption = "Ca_Max";
            this.coldsChemicalStdL3DataTableCa_Max.ColumnName = "Ca_Max";
            this.coldsChemicalStdL3DataTableCa_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_Min
            // 
            this.coldsChemicalStdL3DataTableW_Min.Caption = "W_Min";
            this.coldsChemicalStdL3DataTableW_Min.ColumnName = "W_Min";
            this.coldsChemicalStdL3DataTableW_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_Aim
            // 
            this.coldsChemicalStdL3DataTableW_Aim.Caption = "W_Aim";
            this.coldsChemicalStdL3DataTableW_Aim.ColumnName = "W_Aim";
            this.coldsChemicalStdL3DataTableW_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_Max
            // 
            this.coldsChemicalStdL3DataTableW_Max.Caption = "W_Max";
            this.coldsChemicalStdL3DataTableW_Max.ColumnName = "W_Max";
            this.coldsChemicalStdL3DataTableW_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePb_Min
            // 
            this.coldsChemicalStdL3DataTablePb_Min.Caption = "Pb_Min";
            this.coldsChemicalStdL3DataTablePb_Min.ColumnName = "Pb_Min";
            this.coldsChemicalStdL3DataTablePb_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePb_Aim
            // 
            this.coldsChemicalStdL3DataTablePb_Aim.Caption = "Pb_Aim";
            this.coldsChemicalStdL3DataTablePb_Aim.ColumnName = "Pb_Aim";
            this.coldsChemicalStdL3DataTablePb_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePb_Max
            // 
            this.coldsChemicalStdL3DataTablePb_Max.Caption = "Pb_Max";
            this.coldsChemicalStdL3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coldsChemicalStdL3DataTablePb_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRe_Min
            // 
            this.coldsChemicalStdL3DataTableRe_Min.Caption = "Re_Min";
            this.coldsChemicalStdL3DataTableRe_Min.ColumnName = "Re_Min";
            this.coldsChemicalStdL3DataTableRe_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRe_Aim
            // 
            this.coldsChemicalStdL3DataTableRe_Aim.Caption = "Re_Aim";
            this.coldsChemicalStdL3DataTableRe_Aim.ColumnName = "Re_Aim";
            this.coldsChemicalStdL3DataTableRe_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRe_Max
            // 
            this.coldsChemicalStdL3DataTableRe_Max.Caption = "Re_Max";
            this.coldsChemicalStdL3DataTableRe_Max.ColumnName = "Re_Max";
            this.coldsChemicalStdL3DataTableRe_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCeq_Min
            // 
            this.coldsChemicalStdL3DataTableCeq_Min.Caption = "Ceq_Min";
            this.coldsChemicalStdL3DataTableCeq_Min.ColumnName = "Ceq_Min";
            this.coldsChemicalStdL3DataTableCeq_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCeq_Aim
            // 
            this.coldsChemicalStdL3DataTableCeq_Aim.Caption = "Ceq_Aim";
            this.coldsChemicalStdL3DataTableCeq_Aim.ColumnName = "Ceq_Aim";
            this.coldsChemicalStdL3DataTableCeq_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCeq_Max
            // 
            this.coldsChemicalStdL3DataTableCeq_Max.Caption = "Ceq_Max";
            this.coldsChemicalStdL3DataTableCeq_Max.ColumnName = "Ceq_Max";
            this.coldsChemicalStdL3DataTableCeq_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_Min
            // 
            this.coldsChemicalStdL3DataTableN_Min.Caption = "N_Min";
            this.coldsChemicalStdL3DataTableN_Min.ColumnName = "N_Min";
            this.coldsChemicalStdL3DataTableN_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_Aim
            // 
            this.coldsChemicalStdL3DataTableN_Aim.Caption = "N_Aim";
            this.coldsChemicalStdL3DataTableN_Aim.ColumnName = "N_Aim";
            this.coldsChemicalStdL3DataTableN_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_Max
            // 
            this.coldsChemicalStdL3DataTableN_Max.Caption = "N_Max";
            this.coldsChemicalStdL3DataTableN_Max.ColumnName = "N_Max";
            this.coldsChemicalStdL3DataTableN_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_Min
            // 
            this.coldsChemicalStdL3DataTableH_Min.Caption = "H_Min";
            this.coldsChemicalStdL3DataTableH_Min.ColumnName = "H_Min";
            this.coldsChemicalStdL3DataTableH_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_Aim
            // 
            this.coldsChemicalStdL3DataTableH_Aim.Caption = "H_Aim";
            this.coldsChemicalStdL3DataTableH_Aim.ColumnName = "H_Aim";
            this.coldsChemicalStdL3DataTableH_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_Max
            // 
            this.coldsChemicalStdL3DataTableH_Max.Caption = "H_Max";
            this.coldsChemicalStdL3DataTableH_Max.ColumnName = "H_Max";
            this.coldsChemicalStdL3DataTableH_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_Min
            // 
            this.coldsChemicalStdL3DataTableO_Min.Caption = "O_Min";
            this.coldsChemicalStdL3DataTableO_Min.ColumnName = "O_Min";
            this.coldsChemicalStdL3DataTableO_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_Aim
            // 
            this.coldsChemicalStdL3DataTableO_Aim.Caption = "O_Aim";
            this.coldsChemicalStdL3DataTableO_Aim.ColumnName = "O_Aim";
            this.coldsChemicalStdL3DataTableO_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_Max
            // 
            this.coldsChemicalStdL3DataTableO_Max.Caption = "O_Max";
            this.coldsChemicalStdL3DataTableO_Max.ColumnName = "O_Max";
            this.coldsChemicalStdL3DataTableO_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNi_Min
            // 
            this.coldsChemicalStdL3DataTableCrNi_Min.Caption = "CrNi_Min";
            this.coldsChemicalStdL3DataTableCrNi_Min.ColumnName = "CrNi_Min";
            this.coldsChemicalStdL3DataTableCrNi_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNi_Aim
            // 
            this.coldsChemicalStdL3DataTableCrNi_Aim.Caption = "CrNi_Aim";
            this.coldsChemicalStdL3DataTableCrNi_Aim.ColumnName = "CrNi_Aim";
            this.coldsChemicalStdL3DataTableCrNi_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNi_Max
            // 
            this.coldsChemicalStdL3DataTableCrNi_Max.Caption = "CrNi_Max";
            this.coldsChemicalStdL3DataTableCrNi_Max.ColumnName = "CrNi_Max";
            this.coldsChemicalStdL3DataTableCrNi_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrCu_Min
            // 
            this.coldsChemicalStdL3DataTableCrCu_Min.Caption = "CrCu_Min";
            this.coldsChemicalStdL3DataTableCrCu_Min.ColumnName = "CrCu_Min";
            this.coldsChemicalStdL3DataTableCrCu_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrCu_Aim
            // 
            this.coldsChemicalStdL3DataTableCrCu_Aim.Caption = "CrCu_Aim";
            this.coldsChemicalStdL3DataTableCrCu_Aim.ColumnName = "CrCu_Aim";
            this.coldsChemicalStdL3DataTableCrCu_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrCu_Max
            // 
            this.coldsChemicalStdL3DataTableCrCu_Max.Caption = "CrCu_Max";
            this.coldsChemicalStdL3DataTableCrCu_Max.ColumnName = "CrCu_Max";
            this.coldsChemicalStdL3DataTableCrCu_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNiCu_Min
            // 
            this.coldsChemicalStdL3DataTableCrNiCu_Min.Caption = "CrNiCu_Min";
            this.coldsChemicalStdL3DataTableCrNiCu_Min.ColumnName = "CrNiCu_Min";
            this.coldsChemicalStdL3DataTableCrNiCu_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNiCu_Aim
            // 
            this.coldsChemicalStdL3DataTableCrNiCu_Aim.Caption = "CrNiCu_Aim";
            this.coldsChemicalStdL3DataTableCrNiCu_Aim.ColumnName = "CrNiCu_Aim";
            this.coldsChemicalStdL3DataTableCrNiCu_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCrNiCu_Max
            // 
            this.coldsChemicalStdL3DataTableCrNiCu_Max.Caption = "CrNiCu_Max";
            this.coldsChemicalStdL3DataTableCrNiCu_Max.ColumnName = "CrNiCu_Max";
            this.coldsChemicalStdL3DataTableCrNiCu_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther1_Min
            // 
            this.coldsChemicalStdL3DataTableOther1_Min.Caption = "Other1_Min";
            this.coldsChemicalStdL3DataTableOther1_Min.ColumnName = "Other1_Min";
            this.coldsChemicalStdL3DataTableOther1_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther1_Aim
            // 
            this.coldsChemicalStdL3DataTableOther1_Aim.Caption = "Other1_Aim";
            this.coldsChemicalStdL3DataTableOther1_Aim.ColumnName = "Other1_Aim";
            this.coldsChemicalStdL3DataTableOther1_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther1_Max
            // 
            this.coldsChemicalStdL3DataTableOther1_Max.Caption = "Other1_Max";
            this.coldsChemicalStdL3DataTableOther1_Max.ColumnName = "Other1_Max";
            this.coldsChemicalStdL3DataTableOther1_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther2_Min
            // 
            this.coldsChemicalStdL3DataTableOther2_Min.Caption = "Other2_Min";
            this.coldsChemicalStdL3DataTableOther2_Min.ColumnName = "Other2_Min";
            this.coldsChemicalStdL3DataTableOther2_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther2_Aim
            // 
            this.coldsChemicalStdL3DataTableOther2_Aim.Caption = "Other2_Aim";
            this.coldsChemicalStdL3DataTableOther2_Aim.ColumnName = "Other2_Aim";
            this.coldsChemicalStdL3DataTableOther2_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther2_Max
            // 
            this.coldsChemicalStdL3DataTableOther2_Max.Caption = "Other2_Max";
            this.coldsChemicalStdL3DataTableOther2_Max.ColumnName = "Other2_Max";
            this.coldsChemicalStdL3DataTableOther2_Max.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther3_Min
            // 
            this.coldsChemicalStdL3DataTableOther3_Min.Caption = "Other3_Min";
            this.coldsChemicalStdL3DataTableOther3_Min.ColumnName = "Other3_Min";
            this.coldsChemicalStdL3DataTableOther3_Min.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther3_Aim
            // 
            this.coldsChemicalStdL3DataTableOther3_Aim.Caption = "Other3_Aim";
            this.coldsChemicalStdL3DataTableOther3_Aim.ColumnName = "Other3_Aim";
            this.coldsChemicalStdL3DataTableOther3_Aim.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOther3_Max
            // 
            this.coldsChemicalStdL3DataTableOther3_Max.Caption = "Other3_Max";
            this.coldsChemicalStdL3DataTableOther3_Max.ColumnName = "Other3_Max";
            this.coldsChemicalStdL3DataTableOther3_Max.Namespace = "";
            // 
            // lblSbMax
            // 
            lblSbMax.AutoSize = true;
            lblSbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SB_MAX", true));
            lblSbMax.Location = new System.Drawing.Point(823, 79);
            lblSbMax.Name = "lblSbMax";
            lblSbMax.Size = new System.Drawing.Size(23, 12);
            lblSbMax.TabIndex = 251;
            lblSbMax.Text = "XXX";
            // 
            // lblReMin
            // 
            lblReMin.AutoSize = true;
            lblReMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.RE_MIN", true));
            lblReMin.Location = new System.Drawing.Point(418, 144);
            lblReMin.Name = "lblReMin";
            lblReMin.Size = new System.Drawing.Size(23, 12);
            lblReMin.TabIndex = 244;
            lblReMin.Text = "XXX";
            // 
            // dsHeatID
            // 
            this.dsHeatID.AutoLoad = true;
            this.dsHeatID.AutoSubscribe = true;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = null;
            this.dsHeatID.InsertMethod = null;
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "Click";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = null;
            this.dsHeatID.SourceCondition = null;
            this.dsHeatID.SourceMethod = "GetBofSteelJudgeHeat";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatID});
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = null;
            this.dsHeatID.UpdateTrigger = null;
            // 
            // schemadsHeatID
            // 
            this.schemadsHeatID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatIDL3DataTableHeatID});
            this.schemadsHeatID.TableName = "L3DataTable";
            // 
            // coldsHeatIDL3DataTableHeatID
            // 
            this.coldsHeatIDL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatIDL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatIDL3DataTableHeatID.Namespace = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hmiRootPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 768);
            this.panel1.TabIndex = 1;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.splitContainer1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1172, 768);
            this.hmiRootPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 768);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvHeatID);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 768);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待终判炉次信息";
            // 
            // dvHeatID
            // 
            this.dvHeatID.AllowUserToAddRows = false;
            this.dvHeatID.AutoGenerateColumns = false;
            this.dvHeatID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvHeatID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHeatID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn});
            this.dvHeatID.DataSource = this.bindingSource1;
            this.dvHeatID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatID.Location = new System.Drawing.Point(3, 40);
            this.dvHeatID.MultiSelect = false;
            this.dvHeatID.Name = "dvHeatID";
            this.dvHeatID.ReadOnly = true;
            this.dvHeatID.RowTemplate.Height = 23;
            this.dvHeatID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvHeatID.Size = new System.Drawing.Size(148, 725);
            this.dvHeatID.TabIndex = 2;
            this.dvHeatID.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvHeatID_RowPostPaint);
            this.dvHeatID.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvHeatID_DataError);
            this.dvHeatID.Click += new System.EventHandler(this.dvHeatID_Click);
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "熔炼号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "L3DataTable";
            this.bindingSource1.DataSource = this.dsHeatID;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Location = new System.Drawing.Point(3, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新炉次信息";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.07792F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.63204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.29004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.myLine5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblCrMoNiCuMax);
            this.groupBox4.Controls.Add(this.lblOMax);
            this.groupBox4.Controls.Add(this.lblNMax);
            this.groupBox4.Controls.Add(this.lblHMax);
            this.groupBox4.Controls.Add(this.lblCeqMax);
            this.groupBox4.Controls.Add(this.lblReMax);
            this.groupBox4.Controls.Add(this.lblPbMax);
            this.groupBox4.Controls.Add(this.lblWMax);
            this.groupBox4.Controls.Add(this.lblCaMax);
            this.groupBox4.Controls.Add(this.lblZrMax);
            this.groupBox4.Controls.Add(this.lblZnMax);
            this.groupBox4.Controls.Add(this.lblAsMax);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.lblSnMax);
            this.groupBox4.Controls.Add(label36);
            this.groupBox4.Controls.Add(lblSbMax);
            this.groupBox4.Controls.Add(this.lblCrMoNiCuMin);
            this.groupBox4.Controls.Add(this.lblHMin);
            this.groupBox4.Controls.Add(this.lblOMin);
            this.groupBox4.Controls.Add(this.lblNMin);
            this.groupBox4.Controls.Add(this.lblCeqMin);
            this.groupBox4.Controls.Add(lblReMin);
            this.groupBox4.Controls.Add(this.lblPbMin);
            this.groupBox4.Controls.Add(this.lblWMin);
            this.groupBox4.Controls.Add(this.lblCaMin);
            this.groupBox4.Controls.Add(this.lblZrMin);
            this.groupBox4.Controls.Add(this.lblZnMin);
            this.groupBox4.Controls.Add(this.lblAsMin);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.lblSnMin);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.lblSbMin);
            this.groupBox4.Controls.Add(this.label186);
            this.groupBox4.Controls.Add(this.label182);
            this.groupBox4.Controls.Add(this.label185);
            this.groupBox4.Controls.Add(this.label183);
            this.groupBox4.Controls.Add(this.label181);
            this.groupBox4.Controls.Add(this.label180);
            this.groupBox4.Controls.Add(this.label179);
            this.groupBox4.Controls.Add(this.label178);
            this.groupBox4.Controls.Add(this.label177);
            this.groupBox4.Controls.Add(this.label176);
            this.groupBox4.Controls.Add(this.label175);
            this.groupBox4.Controls.Add(this.label174);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label173);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label172);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblBMax);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lblBMin);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblTiMax);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblTiMin);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblAlsMax);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblAlsMin);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.lblAlMax);
            this.groupBox4.Controls.Add(this.lblAlMin);
            this.groupBox4.Controls.Add(this.label94);
            this.groupBox4.Controls.Add(this.lblNbMax);
            this.groupBox4.Controls.Add(this.lblNbMin);
            this.groupBox4.Controls.Add(this.label89);
            this.groupBox4.Controls.Add(this.lblVMax);
            this.groupBox4.Controls.Add(this.lblVMin);
            this.groupBox4.Controls.Add(this.label84);
            this.groupBox4.Controls.Add(this.lblMoMax);
            this.groupBox4.Controls.Add(this.lblMoMin);
            this.groupBox4.Controls.Add(this.label79);
            this.groupBox4.Controls.Add(this.lblCrMax);
            this.groupBox4.Controls.Add(this.lblCrMin);
            this.groupBox4.Controls.Add(this.label74);
            this.groupBox4.Controls.Add(this.lblNiMax);
            this.groupBox4.Controls.Add(this.lblNiMin);
            this.groupBox4.Controls.Add(this.label69);
            this.groupBox4.Controls.Add(this.lblCuMax);
            this.groupBox4.Controls.Add(this.lblCuMin);
            this.groupBox4.Controls.Add(this.label64);
            this.groupBox4.Controls.Add(this.lblSMax);
            this.groupBox4.Controls.Add(this.lblSMin);
            this.groupBox4.Controls.Add(this.label59);
            this.groupBox4.Controls.Add(this.lblPMax);
            this.groupBox4.Controls.Add(this.lblPMin);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.lblMnMax);
            this.groupBox4.Controls.Add(this.lblMnMin);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.lblSiMax);
            this.groupBox4.Controls.Add(this.lblSiMin);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.lblCMax);
            this.groupBox4.Controls.Add(this.lblCMin);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1008, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "成品成分标准";
            // 
            // myLine5
            // 
            this.myLine5.BackColor = System.Drawing.SystemColors.Control;
            this.myLine5.Location = new System.Drawing.Point(96, 105);
            this.myLine5.Name = "myLine5";
            this.myLine5.Size = new System.Drawing.Size(817, 10);
            this.myLine5.TabIndex = 257;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 265;
            this.label2.Text = "最大:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 264;
            this.label4.Text = "最小:";
            // 
            // lblCrMoNiCuMax
            // 
            this.lblCrMoNiCuMax.AutoSize = true;
            this.lblCrMoNiCuMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNi_Max", true));
            this.lblCrMoNiCuMax.Location = new System.Drawing.Point(643, 168);
            this.lblCrMoNiCuMax.Name = "lblCrMoNiCuMax";
            this.lblCrMoNiCuMax.Size = new System.Drawing.Size(23, 12);
            this.lblCrMoNiCuMax.TabIndex = 262;
            this.lblCrMoNiCuMax.Text = "XXX";
            // 
            // lblOMax
            // 
            this.lblOMax.AutoSize = true;
            this.lblOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.O_MAX", true));
            this.lblOMax.Location = new System.Drawing.Point(553, 168);
            this.lblOMax.Name = "lblOMax";
            this.lblOMax.Size = new System.Drawing.Size(23, 12);
            this.lblOMax.TabIndex = 263;
            this.lblOMax.Text = "XXX";
            // 
            // lblNMax
            // 
            this.lblNMax.AutoSize = true;
            this.lblNMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.N_MAX", true));
            this.lblNMax.Location = new System.Drawing.Point(508, 168);
            this.lblNMax.Name = "lblNMax";
            this.lblNMax.Size = new System.Drawing.Size(23, 12);
            this.lblNMax.TabIndex = 260;
            this.lblNMax.Text = "XXX";
            // 
            // lblHMax
            // 
            this.lblHMax.AutoSize = true;
            this.lblHMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.H_MAX", true));
            this.lblHMax.Location = new System.Drawing.Point(598, 168);
            this.lblHMax.Name = "lblHMax";
            this.lblHMax.Size = new System.Drawing.Size(23, 12);
            this.lblHMax.TabIndex = 261;
            this.lblHMax.Text = "XXX";
            // 
            // lblCeqMax
            // 
            this.lblCeqMax.AutoSize = true;
            this.lblCeqMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CEQ_MAX", true));
            this.lblCeqMax.Location = new System.Drawing.Point(463, 168);
            this.lblCeqMax.Name = "lblCeqMax";
            this.lblCeqMax.Size = new System.Drawing.Size(23, 12);
            this.lblCeqMax.TabIndex = 255;
            this.lblCeqMax.Text = "XXX";
            // 
            // lblReMax
            // 
            this.lblReMax.AutoSize = true;
            this.lblReMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.RE_MAX", true));
            this.lblReMax.Location = new System.Drawing.Point(418, 168);
            this.lblReMax.Name = "lblReMax";
            this.lblReMax.Size = new System.Drawing.Size(23, 12);
            this.lblReMax.TabIndex = 254;
            this.lblReMax.Text = "XXX";
            // 
            // lblPbMax
            // 
            this.lblPbMax.AutoSize = true;
            this.lblPbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.PB_MAX", true));
            this.lblPbMax.Location = new System.Drawing.Point(373, 168);
            this.lblPbMax.Name = "lblPbMax";
            this.lblPbMax.Size = new System.Drawing.Size(23, 12);
            this.lblPbMax.TabIndex = 256;
            this.lblPbMax.Text = "XXX";
            // 
            // lblWMax
            // 
            this.lblWMax.AutoSize = true;
            this.lblWMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.W_MAX", true));
            this.lblWMax.Location = new System.Drawing.Point(328, 168);
            this.lblWMax.Name = "lblWMax";
            this.lblWMax.Size = new System.Drawing.Size(23, 12);
            this.lblWMax.TabIndex = 259;
            this.lblWMax.Text = "XXX";
            // 
            // lblCaMax
            // 
            this.lblCaMax.AutoSize = true;
            this.lblCaMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CA_MAX", true));
            this.lblCaMax.Location = new System.Drawing.Point(283, 168);
            this.lblCaMax.Name = "lblCaMax";
            this.lblCaMax.Size = new System.Drawing.Size(23, 12);
            this.lblCaMax.TabIndex = 258;
            this.lblCaMax.Text = "XXX";
            // 
            // lblZrMax
            // 
            this.lblZrMax.AutoSize = true;
            this.lblZrMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZR_MAX", true));
            this.lblZrMax.Location = new System.Drawing.Point(238, 168);
            this.lblZrMax.Name = "lblZrMax";
            this.lblZrMax.Size = new System.Drawing.Size(23, 12);
            this.lblZrMax.TabIndex = 248;
            this.lblZrMax.Text = "XXX";
            // 
            // lblZnMax
            // 
            this.lblZnMax.AutoSize = true;
            this.lblZnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZN_MAX", true));
            this.lblZnMax.Location = new System.Drawing.Point(193, 168);
            this.lblZnMax.Name = "lblZnMax";
            this.lblZnMax.Size = new System.Drawing.Size(23, 12);
            this.lblZnMax.TabIndex = 247;
            this.lblZnMax.Text = "XXX";
            // 
            // lblAsMax
            // 
            this.lblAsMax.AutoSize = true;
            this.lblAsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AS_MAX", true));
            this.lblAsMax.Location = new System.Drawing.Point(148, 168);
            this.lblAsMax.Name = "lblAsMax";
            this.lblAsMax.Size = new System.Drawing.Size(23, 12);
            this.lblAsMax.TabIndex = 249;
            this.lblAsMax.Text = "XXX";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other3_Max", true));
            this.label41.Location = new System.Drawing.Point(868, 168);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(23, 12);
            this.label41.TabIndex = 253;
            this.label41.Text = "XXX";
            // 
            // lblSnMax
            // 
            this.lblSnMax.AutoSize = true;
            this.lblSnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SN_MAX", true));
            this.lblSnMax.Location = new System.Drawing.Point(868, 79);
            this.lblSnMax.Name = "lblSnMax";
            this.lblSnMax.Size = new System.Drawing.Size(23, 12);
            this.lblSnMax.TabIndex = 252;
            this.lblSnMax.Text = "XXX";
            // 
            // lblCrMoNiCuMin
            // 
            this.lblCrMoNiCuMin.AutoSize = true;
            this.lblCrMoNiCuMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNi_Min", true));
            this.lblCrMoNiCuMin.Location = new System.Drawing.Point(643, 144);
            this.lblCrMoNiCuMin.Name = "lblCrMoNiCuMin";
            this.lblCrMoNiCuMin.Size = new System.Drawing.Size(23, 12);
            this.lblCrMoNiCuMin.TabIndex = 246;
            this.lblCrMoNiCuMin.Text = "XXX";
            // 
            // lblHMin
            // 
            this.lblHMin.AutoSize = true;
            this.lblHMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.H_MIN", true));
            this.lblHMin.Location = new System.Drawing.Point(598, 144);
            this.lblHMin.Name = "lblHMin";
            this.lblHMin.Size = new System.Drawing.Size(23, 12);
            this.lblHMin.TabIndex = 245;
            this.lblHMin.Text = "XXX";
            // 
            // lblOMin
            // 
            this.lblOMin.AutoSize = true;
            this.lblOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.O_MIN", true));
            this.lblOMin.Location = new System.Drawing.Point(553, 144);
            this.lblOMin.Name = "lblOMin";
            this.lblOMin.Size = new System.Drawing.Size(23, 12);
            this.lblOMin.TabIndex = 241;
            this.lblOMin.Text = "XXX";
            // 
            // lblNMin
            // 
            this.lblNMin.AutoSize = true;
            this.lblNMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.N_MIN", true));
            this.lblNMin.Location = new System.Drawing.Point(508, 144);
            this.lblNMin.Name = "lblNMin";
            this.lblNMin.Size = new System.Drawing.Size(23, 12);
            this.lblNMin.TabIndex = 240;
            this.lblNMin.Text = "XXX";
            // 
            // lblCeqMin
            // 
            this.lblCeqMin.AutoSize = true;
            this.lblCeqMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CEQ_MIN", true));
            this.lblCeqMin.Location = new System.Drawing.Point(463, 144);
            this.lblCeqMin.Name = "lblCeqMin";
            this.lblCeqMin.Size = new System.Drawing.Size(23, 12);
            this.lblCeqMin.TabIndex = 239;
            this.lblCeqMin.Text = "XXX";
            // 
            // lblPbMin
            // 
            this.lblPbMin.AutoSize = true;
            this.lblPbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.PB_MIN", true));
            this.lblPbMin.Location = new System.Drawing.Point(373, 144);
            this.lblPbMin.Name = "lblPbMin";
            this.lblPbMin.Size = new System.Drawing.Size(23, 12);
            this.lblPbMin.TabIndex = 243;
            this.lblPbMin.Text = "XXX";
            // 
            // lblWMin
            // 
            this.lblWMin.AutoSize = true;
            this.lblWMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.W_MIN", true));
            this.lblWMin.Location = new System.Drawing.Point(328, 144);
            this.lblWMin.Name = "lblWMin";
            this.lblWMin.Size = new System.Drawing.Size(23, 12);
            this.lblWMin.TabIndex = 242;
            this.lblWMin.Text = "XXX";
            // 
            // lblCaMin
            // 
            this.lblCaMin.AutoSize = true;
            this.lblCaMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CA_MIN", true));
            this.lblCaMin.Location = new System.Drawing.Point(283, 144);
            this.lblCaMin.Name = "lblCaMin";
            this.lblCaMin.Size = new System.Drawing.Size(23, 12);
            this.lblCaMin.TabIndex = 233;
            this.lblCaMin.Text = "XXX";
            // 
            // lblZrMin
            // 
            this.lblZrMin.AutoSize = true;
            this.lblZrMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZR_MIN", true));
            this.lblZrMin.Location = new System.Drawing.Point(238, 144);
            this.lblZrMin.Name = "lblZrMin";
            this.lblZrMin.Size = new System.Drawing.Size(23, 12);
            this.lblZrMin.TabIndex = 232;
            this.lblZrMin.Text = "XXX";
            // 
            // lblZnMin
            // 
            this.lblZnMin.AutoSize = true;
            this.lblZnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZN_AIM", true));
            this.lblZnMin.Location = new System.Drawing.Point(193, 144);
            this.lblZnMin.Name = "lblZnMin";
            this.lblZnMin.Size = new System.Drawing.Size(23, 12);
            this.lblZnMin.TabIndex = 231;
            this.lblZnMin.Text = "XXX";
            // 
            // lblAsMin
            // 
            this.lblAsMin.AutoSize = true;
            this.lblAsMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AS_MIN", true));
            this.lblAsMin.Location = new System.Drawing.Point(148, 144);
            this.lblAsMin.Name = "lblAsMin";
            this.lblAsMin.Size = new System.Drawing.Size(23, 12);
            this.lblAsMin.TabIndex = 238;
            this.lblAsMin.Text = "XXX";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other3_Min", true));
            this.label26.Location = new System.Drawing.Point(868, 144);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 12);
            this.label26.TabIndex = 237;
            this.label26.Text = "XXX";
            // 
            // lblSnMin
            // 
            this.lblSnMin.AutoSize = true;
            this.lblSnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SN_MIN", true));
            this.lblSnMin.Location = new System.Drawing.Point(868, 51);
            this.lblSnMin.Name = "lblSnMin";
            this.lblSnMin.Size = new System.Drawing.Size(23, 12);
            this.lblSnMin.TabIndex = 236;
            this.lblSnMin.Text = "XXX";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other2_Min", true));
            this.label24.Location = new System.Drawing.Point(823, 144);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 12);
            this.label24.TabIndex = 234;
            this.label24.Text = "XXX";
            // 
            // lblSbMin
            // 
            this.lblSbMin.AutoSize = true;
            this.lblSbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SB_MIN", true));
            this.lblSbMin.Location = new System.Drawing.Point(823, 51);
            this.lblSbMin.Name = "lblSbMin";
            this.lblSbMin.Size = new System.Drawing.Size(23, 12);
            this.lblSbMin.TabIndex = 235;
            this.lblSbMin.Text = "XXX";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(642, 119);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(29, 12);
            this.label186.TabIndex = 230;
            this.label186.Text = "CrNi";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(603, 119);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(11, 12);
            this.label182.TabIndex = 229;
            this.label182.Text = "H";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(559, 119);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(11, 12);
            this.label185.TabIndex = 225;
            this.label185.Text = "0";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(515, 119);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(11, 12);
            this.label183.TabIndex = 224;
            this.label183.Text = "N";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(464, 119);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(23, 12);
            this.label181.TabIndex = 223;
            this.label181.Text = "Ceq";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(422, 119);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(17, 12);
            this.label180.TabIndex = 228;
            this.label180.Text = "Re";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(377, 119);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(17, 12);
            this.label179.TabIndex = 227;
            this.label179.Text = "Pb";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(335, 119);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(11, 12);
            this.label178.TabIndex = 226;
            this.label178.Text = "W";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(287, 119);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(17, 12);
            this.label177.TabIndex = 217;
            this.label177.Text = "Ca";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(242, 119);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(17, 12);
            this.label176.TabIndex = 216;
            this.label176.Text = "Zr";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(197, 119);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(17, 12);
            this.label175.TabIndex = 215;
            this.label175.Text = "Zn";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(152, 119);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(17, 12);
            this.label174.TabIndex = 222;
            this.label174.Text = "As";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(861, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 221;
            this.label22.Text = "Other3";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(865, 25);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(17, 12);
            this.label173.TabIndex = 220;
            this.label173.Text = "Sn";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(816, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 219;
            this.label21.Text = "Other2";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(822, 25);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(17, 12);
            this.label172.TabIndex = 218;
            this.label172.Text = "Sb";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other1_Max", true));
            this.label20.Location = new System.Drawing.Point(778, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 208;
            this.label20.Text = "XXX";
            // 
            // lblBMax
            // 
            this.lblBMax.AutoSize = true;
            this.lblBMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.B_MAX", true));
            this.lblBMax.Location = new System.Drawing.Point(778, 79);
            this.lblBMax.Name = "lblBMax";
            this.lblBMax.Size = new System.Drawing.Size(23, 12);
            this.lblBMax.TabIndex = 207;
            this.lblBMax.Text = "XXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other1_Min", true));
            this.label18.Location = new System.Drawing.Point(778, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 209;
            this.label18.Text = "XXX";
            // 
            // lblBMin
            // 
            this.lblBMin.AutoSize = true;
            this.lblBMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.B_MIN", true));
            this.lblBMin.Location = new System.Drawing.Point(778, 51);
            this.lblBMin.Name = "lblBMin";
            this.lblBMin.Size = new System.Drawing.Size(23, 12);
            this.lblBMin.TabIndex = 210;
            this.lblBMin.Text = "XXX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(772, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 214;
            this.label17.Text = "Other1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(778, 25);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(11, 12);
            this.label40.TabIndex = 213;
            this.label40.Text = "B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNiCu_Max", true));
            this.label16.Location = new System.Drawing.Point(733, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 211;
            this.label16.Text = "XXX";
            // 
            // lblTiMax
            // 
            this.lblTiMax.AutoSize = true;
            this.lblTiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.TI_MAX", true));
            this.lblTiMax.Location = new System.Drawing.Point(733, 79);
            this.lblTiMax.Name = "lblTiMax";
            this.lblTiMax.Size = new System.Drawing.Size(23, 12);
            this.lblTiMax.TabIndex = 212;
            this.lblTiMax.Text = "XXX";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNiCu_Min", true));
            this.label15.Location = new System.Drawing.Point(733, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 199;
            this.label15.Text = "XXX";
            // 
            // lblTiMin
            // 
            this.lblTiMin.AutoSize = true;
            this.lblTiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.TI_MIN", true));
            this.lblTiMin.Location = new System.Drawing.Point(733, 51);
            this.lblTiMin.Name = "lblTiMin";
            this.lblTiMin.Size = new System.Drawing.Size(23, 12);
            this.lblTiMin.TabIndex = 200;
            this.lblTiMin.Text = "XXX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(726, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 197;
            this.label14.Text = "CrNiCu";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(731, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 12);
            this.label38.TabIndex = 198;
            this.label38.Text = "Ti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrCu_Max", true));
            this.label13.Location = new System.Drawing.Point(688, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 201;
            this.label13.Text = "XXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrCu_Min", true));
            this.label12.Location = new System.Drawing.Point(688, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 205;
            this.label12.Text = "XXX";
            // 
            // lblAlsMax
            // 
            this.lblAlsMax.AutoSize = true;
            this.lblAlsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ALS_MAX", true));
            this.lblAlsMax.Location = new System.Drawing.Point(688, 79);
            this.lblAlsMax.Name = "lblAlsMax";
            this.lblAlsMax.Size = new System.Drawing.Size(23, 12);
            this.lblAlsMax.TabIndex = 202;
            this.lblAlsMax.Text = "XXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(687, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 203;
            this.label11.Text = "CrCu";
            // 
            // lblAlsMin
            // 
            this.lblAlsMin.AutoSize = true;
            this.lblAlsMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ALS_MIN", true));
            this.lblAlsMin.Location = new System.Drawing.Point(688, 51);
            this.lblAlsMin.Name = "lblAlsMin";
            this.lblAlsMin.Size = new System.Drawing.Size(23, 12);
            this.lblAlsMin.TabIndex = 206;
            this.lblAlsMin.Text = "XXX";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(685, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 12);
            this.label37.TabIndex = 204;
            this.label37.Text = "Als";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(107, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 12);
            this.label32.TabIndex = 185;
            this.label32.Text = "最大:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(107, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 184;
            this.label30.Text = "最小:";
            // 
            // lblAlMax
            // 
            this.lblAlMax.AutoSize = true;
            this.lblAlMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AL_MAX", true));
            this.lblAlMax.Location = new System.Drawing.Point(643, 79);
            this.lblAlMax.Name = "lblAlMax";
            this.lblAlMax.Size = new System.Drawing.Size(23, 12);
            this.lblAlMax.TabIndex = 187;
            this.lblAlMax.Text = "XXX";
            // 
            // lblAlMin
            // 
            this.lblAlMin.AutoSize = true;
            this.lblAlMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AL_MIN", true));
            this.lblAlMin.Location = new System.Drawing.Point(643, 51);
            this.lblAlMin.Name = "lblAlMin";
            this.lblAlMin.Size = new System.Drawing.Size(23, 12);
            this.lblAlMin.TabIndex = 186;
            this.lblAlMin.Text = "XXX";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(641, 25);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(17, 12);
            this.label94.TabIndex = 180;
            this.label94.Text = "Al";
            // 
            // lblNbMax
            // 
            this.lblNbMax.AutoSize = true;
            this.lblNbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NB_MAX", true));
            this.lblNbMax.Location = new System.Drawing.Point(598, 79);
            this.lblNbMax.Name = "lblNbMax";
            this.lblNbMax.Size = new System.Drawing.Size(23, 12);
            this.lblNbMax.TabIndex = 179;
            this.lblNbMax.Text = "XXX";
            // 
            // lblNbMin
            // 
            this.lblNbMin.AutoSize = true;
            this.lblNbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NB_MIN", true));
            this.lblNbMin.Location = new System.Drawing.Point(598, 51);
            this.lblNbMin.Name = "lblNbMin";
            this.lblNbMin.Size = new System.Drawing.Size(23, 12);
            this.lblNbMin.TabIndex = 182;
            this.lblNbMin.Text = "XXX";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(598, 25);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(17, 12);
            this.label89.TabIndex = 183;
            this.label89.Text = "Nb";
            // 
            // lblVMax
            // 
            this.lblVMax.AutoSize = true;
            this.lblVMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.V_MAX", true));
            this.lblVMax.Location = new System.Drawing.Point(553, 79);
            this.lblVMax.Name = "lblVMax";
            this.lblVMax.Size = new System.Drawing.Size(23, 12);
            this.lblVMax.TabIndex = 181;
            this.lblVMax.Text = "XXX";
            // 
            // lblVMin
            // 
            this.lblVMin.AutoSize = true;
            this.lblVMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.V_MIN", true));
            this.lblVMin.Location = new System.Drawing.Point(553, 51);
            this.lblVMin.Name = "lblVMin";
            this.lblVMin.Size = new System.Drawing.Size(23, 12);
            this.lblVMin.TabIndex = 193;
            this.lblVMin.Text = "XXX";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(554, 25);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(11, 12);
            this.label84.TabIndex = 192;
            this.label84.Text = "V";
            // 
            // lblMoMax
            // 
            this.lblMoMax.AutoSize = true;
            this.lblMoMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MO_MAX", true));
            this.lblMoMax.Location = new System.Drawing.Point(508, 79);
            this.lblMoMax.Name = "lblMoMax";
            this.lblMoMax.Size = new System.Drawing.Size(23, 12);
            this.lblMoMax.TabIndex = 196;
            this.lblMoMax.Text = "XXX";
            // 
            // lblMoMin
            // 
            this.lblMoMin.AutoSize = true;
            this.lblMoMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MO_MIN", true));
            this.lblMoMin.Location = new System.Drawing.Point(508, 51);
            this.lblMoMin.Name = "lblMoMin";
            this.lblMoMin.Size = new System.Drawing.Size(23, 12);
            this.lblMoMin.TabIndex = 194;
            this.lblMoMin.Text = "XXX";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(507, 25);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(17, 12);
            this.label79.TabIndex = 195;
            this.label79.Text = "Mo";
            // 
            // lblCrMax
            // 
            this.lblCrMax.AutoSize = true;
            this.lblCrMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CR_MAX", true));
            this.lblCrMax.Location = new System.Drawing.Point(463, 79);
            this.lblCrMax.Name = "lblCrMax";
            this.lblCrMax.Size = new System.Drawing.Size(23, 12);
            this.lblCrMax.TabIndex = 189;
            this.lblCrMax.Text = "XXX";
            // 
            // lblCrMin
            // 
            this.lblCrMin.AutoSize = true;
            this.lblCrMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CR_MIN", true));
            this.lblCrMin.Location = new System.Drawing.Point(463, 51);
            this.lblCrMin.Name = "lblCrMin";
            this.lblCrMin.Size = new System.Drawing.Size(23, 12);
            this.lblCrMin.TabIndex = 188;
            this.lblCrMin.Text = "XXX";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(462, 25);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(17, 12);
            this.label74.TabIndex = 191;
            this.label74.Text = "Cr";
            // 
            // lblNiMax
            // 
            this.lblNiMax.AutoSize = true;
            this.lblNiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NI_MAX", true));
            this.lblNiMax.Location = new System.Drawing.Point(418, 79);
            this.lblNiMax.Name = "lblNiMax";
            this.lblNiMax.Size = new System.Drawing.Size(23, 12);
            this.lblNiMax.TabIndex = 190;
            this.lblNiMax.Text = "XXX";
            // 
            // lblNiMin
            // 
            this.lblNiMin.AutoSize = true;
            this.lblNiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NI_MIN", true));
            this.lblNiMin.Location = new System.Drawing.Point(418, 51);
            this.lblNiMin.Name = "lblNiMin";
            this.lblNiMin.Size = new System.Drawing.Size(23, 12);
            this.lblNiMin.TabIndex = 165;
            this.lblNiMin.Text = "XXX";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(417, 25);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(17, 12);
            this.label69.TabIndex = 166;
            this.label69.Text = "Ni";
            // 
            // lblCuMax
            // 
            this.lblCuMax.AutoSize = true;
            this.lblCuMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CU_MAX", true));
            this.lblCuMax.Location = new System.Drawing.Point(372, 79);
            this.lblCuMax.Name = "lblCuMax";
            this.lblCuMax.Size = new System.Drawing.Size(23, 12);
            this.lblCuMax.TabIndex = 164;
            this.lblCuMax.Text = "XXX";
            // 
            // lblCuMin
            // 
            this.lblCuMin.AutoSize = true;
            this.lblCuMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CU_MIN", true));
            this.lblCuMin.Location = new System.Drawing.Point(373, 51);
            this.lblCuMin.Name = "lblCuMin";
            this.lblCuMin.Size = new System.Drawing.Size(23, 12);
            this.lblCuMin.TabIndex = 168;
            this.lblCuMin.Text = "XXX";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(372, 25);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 12);
            this.label64.TabIndex = 167;
            this.label64.Text = "Cu";
            // 
            // lblSMax
            // 
            this.lblSMax.AutoSize = true;
            this.lblSMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.S_MAX", true));
            this.lblSMax.Location = new System.Drawing.Point(328, 79);
            this.lblSMax.Name = "lblSMax";
            this.lblSMax.Size = new System.Drawing.Size(23, 12);
            this.lblSMax.TabIndex = 161;
            this.lblSMax.Text = "XXX";
            // 
            // lblSMin
            // 
            this.lblSMin.AutoSize = true;
            this.lblSMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.S_MIN", true));
            this.lblSMin.Location = new System.Drawing.Point(328, 51);
            this.lblSMin.Name = "lblSMin";
            this.lblSMin.Size = new System.Drawing.Size(23, 12);
            this.lblSMin.TabIndex = 159;
            this.lblSMin.Text = "XXX";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(330, 25);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(11, 12);
            this.label59.TabIndex = 160;
            this.label59.Text = "S";
            // 
            // lblPMax
            // 
            this.lblPMax.AutoSize = true;
            this.lblPMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.P_MAX", true));
            this.lblPMax.Location = new System.Drawing.Point(283, 79);
            this.lblPMax.Name = "lblPMax";
            this.lblPMax.Size = new System.Drawing.Size(23, 12);
            this.lblPMax.TabIndex = 163;
            this.lblPMax.Text = "XXX";
            // 
            // lblPMin
            // 
            this.lblPMin.AutoSize = true;
            this.lblPMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.P_MIN", true));
            this.lblPMin.Location = new System.Drawing.Point(283, 51);
            this.lblPMin.Name = "lblPMin";
            this.lblPMin.Size = new System.Drawing.Size(23, 12);
            this.lblPMin.TabIndex = 162;
            this.lblPMin.Text = "XXX";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(285, 25);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(11, 12);
            this.label54.TabIndex = 175;
            this.label54.Text = "P";
            // 
            // lblMnMax
            // 
            this.lblMnMax.AutoSize = true;
            this.lblMnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MN_MAX", true));
            this.lblMnMax.Location = new System.Drawing.Point(238, 79);
            this.lblMnMax.Name = "lblMnMax";
            this.lblMnMax.Size = new System.Drawing.Size(23, 12);
            this.lblMnMax.TabIndex = 174;
            this.lblMnMax.Tag = "";
            this.lblMnMax.Text = "XXX";
            // 
            // lblMnMin
            // 
            this.lblMnMin.AutoSize = true;
            this.lblMnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MN_MIN", true));
            this.lblMnMin.Location = new System.Drawing.Point(238, 51);
            this.lblMnMin.Name = "lblMnMin";
            this.lblMnMin.Size = new System.Drawing.Size(23, 12);
            this.lblMnMin.TabIndex = 177;
            this.lblMnMin.Tag = "";
            this.lblMnMin.Text = "XXX";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(237, 25);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(17, 12);
            this.label49.TabIndex = 178;
            this.label49.Text = "Mn";
            // 
            // lblSiMax
            // 
            this.lblSiMax.AutoSize = true;
            this.lblSiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SI_MAX", true));
            this.lblSiMax.Location = new System.Drawing.Point(193, 79);
            this.lblSiMax.Name = "lblSiMax";
            this.lblSiMax.Size = new System.Drawing.Size(23, 12);
            this.lblSiMax.TabIndex = 176;
            this.lblSiMax.Tag = "Si";
            this.lblSiMax.Text = "XXX";
            // 
            // lblSiMin
            // 
            this.lblSiMin.AutoSize = true;
            this.lblSiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SI_MIN", true));
            this.lblSiMin.Location = new System.Drawing.Point(193, 51);
            this.lblSiMin.Name = "lblSiMin";
            this.lblSiMin.Size = new System.Drawing.Size(23, 12);
            this.lblSiMin.TabIndex = 170;
            this.lblSiMin.Tag = "Si";
            this.lblSiMin.Text = "XXX";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(192, 25);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(17, 12);
            this.label44.TabIndex = 169;
            this.label44.Text = "Si";
            // 
            // lblCMax
            // 
            this.lblCMax.AutoSize = true;
            this.lblCMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.C_MAX", true));
            this.lblCMax.Location = new System.Drawing.Point(148, 79);
            this.lblCMax.Name = "lblCMax";
            this.lblCMax.Size = new System.Drawing.Size(23, 12);
            this.lblCMax.TabIndex = 173;
            this.lblCMax.Tag = "C";
            this.lblCMax.Text = "XXX";
            // 
            // lblCMin
            // 
            this.lblCMin.AutoSize = true;
            this.lblCMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.C_MIN", true));
            this.lblCMin.Location = new System.Drawing.Point(148, 51);
            this.lblCMin.Name = "lblCMin";
            this.lblCMin.Size = new System.Drawing.Size(23, 12);
            this.lblCMin.TabIndex = 171;
            this.lblCMin.Tag = "C";
            this.lblCMin.Text = "XXX";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(150, 25);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(11, 12);
            this.label39.TabIndex = 172;
            this.label39.Text = "C";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dvRefineThirdEle);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1008, 165);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "转炉中铁水样";
            // 
            // dvHeatExcept
            // 
            this.dvHeatExcept.AllowUserToAddRows = false;
            this.dvHeatExcept.AutoGenerateColumns = false;
            this.dvHeatExcept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvHeatExcept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHeatExcept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exceptionalTimeDataGridViewTextBoxColumn,
            this.iDObjectDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn1,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.processCountDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.decideCodeDataGridViewTextBoxColumn,
            this.classifyDataGridViewTextBoxColumn});
            this.dvHeatExcept.DataSource = this.bsHeatExcept;
            this.dvHeatExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatExcept.Location = new System.Drawing.Point(3, 17);
            this.dvHeatExcept.Name = "dvHeatExcept";
            this.dvHeatExcept.RowHeadersVisible = false;
            this.dvHeatExcept.RowTemplate.Height = 23;
            this.dvHeatExcept.Size = new System.Drawing.Size(1002, 83);
            this.dvHeatExcept.TabIndex = 2;
            this.dvHeatExcept.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvHeatExcept_DataError);
            // 
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            dataGridViewCellStyle10.Format = "F";
            dataGridViewCellStyle10.NullValue = null;
            this.exceptionalTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.exceptionalTimeDataGridViewTextBoxColumn.DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewColumnHeaderCell);
            this.exceptionalTimeDataGridViewTextBoxColumn.EnableNull = true;
            this.exceptionalTimeDataGridViewTextBoxColumn.HeaderText = "异常时间";
            this.exceptionalTimeDataGridViewTextBoxColumn.Length = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.Max = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.MaxInputLength = 32767;
            this.exceptionalTimeDataGridViewTextBoxColumn.MaxLength = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.Min = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.MinLength = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.Name = "exceptionalTimeDataGridViewTextBoxColumn";
            this.exceptionalTimeDataGridViewTextBoxColumn.Precision = 0;
            this.exceptionalTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalTimeDataGridViewTextBoxColumn.ValidEable = true;
            this.exceptionalTimeDataGridViewTextBoxColumn.ValidType = DataGridValid.DataGridViewValidateCellColumn.TypeEnum.Integer;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            this.heatIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.HeaderText = "处理次数";
            this.processCountDataGridViewTextBoxColumn.Name = "processCountDataGridViewTextBoxColumn";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "生产炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            // 
            // decideCodeDataGridViewTextBoxColumn
            // 
            this.decideCodeDataGridViewTextBoxColumn.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.HeaderText = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.Name = "decideCodeDataGridViewTextBoxColumn";
            this.decideCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "Classify";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsHeatExcept
            // 
            this.bsHeatExcept.DataMember = "L3DataTable";
            this.bsHeatExcept.DataSource = this.dsHeatExcept;
            // 
            // dsHeatExcept
            // 
            this.dsHeatExcept.AutoLoad = true;
            this.dsHeatExcept.AutoSubscribe = false;
            this.dsHeatExcept.DataSetName = "L3DataSet";
            this.dsHeatExcept.DeleteMethod = null;
            this.dsHeatExcept.InsertMethod = null;
            this.dsHeatExcept.L3DataAdapter = this.Adapter;
            this.dsHeatExcept.LoadEvent = "Click";
            this.dsHeatExcept.LoadTrigger = null;
            this.dsHeatExcept.RefreshValve = 1000;
            this.dsHeatExcept.SourceCommand = null;
            this.dsHeatExcept.SourceCondition = "1=2";
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
            // dvRefineThirdEle
            // 
            this.dvRefineThirdEle.AllowUserToAddRows = false;
            this.dvRefineThirdEle.AutoGenerateColumns = false;
            this.dvRefineThirdEle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvRefineThirdEle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRefineThirdEle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.appIDDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn2,
            this.heatIDDataGridViewTextBoxColumn3,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.cuDataGridViewTextBoxColumn,
            this.niDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.nbDataGridViewTextBoxColumn,
            this.alDataGridViewTextBoxColumn,
            this.alSDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.sbDataGridViewTextBoxColumn,
            this.asDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.znDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.ceqDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.crNiDataGridViewTextBoxColumn,
            this.crCuDataGridViewTextBoxColumn,
            this.crNiCuDataGridViewTextBoxColumn,
            this.other1DataGridViewTextBoxColumn,
            this.other2DataGridViewTextBoxColumn,
            this.other3DataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn2,
            this.sampleCountDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn1,
            this.finalJudgeFlagDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn});
            this.dvRefineThirdEle.DataSource = this.bsRefineThirdEle;
            this.dvRefineThirdEle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRefineThirdEle.Location = new System.Drawing.Point(3, 17);
            this.dvRefineThirdEle.Name = "dvRefineThirdEle";
            this.dvRefineThirdEle.ReadOnly = true;
            this.dvRefineThirdEle.RowHeadersVisible = false;
            this.dvRefineThirdEle.RowTemplate.Height = 23;
            this.dvRefineThirdEle.Size = new System.Drawing.Size(1002, 145);
            this.dvRefineThirdEle.TabIndex = 0;
            this.dvRefineThirdEle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvRefineThirdEle_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 35;
            // 
            // sampleCodeDataGridViewTextBoxColumn
            // 
            this.sampleCodeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn.Name = "sampleCodeDataGridViewTextBoxColumn";
            this.sampleCodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "委托单编码";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // sampleTypeDataGridViewTextBoxColumn
            // 
            this.sampleTypeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Type";
            this.sampleTypeDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sampleTypeDataGridViewTextBoxColumn.Name = "sampleTypeDataGridViewTextBoxColumn";
            this.sampleTypeDataGridViewTextBoxColumn.Width = 61;
            // 
            // sampleAddressDataGridViewTextBoxColumn
            // 
            this.sampleAddressDataGridViewTextBoxColumn.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sampleAddressDataGridViewTextBoxColumn.Name = "sampleAddressDataGridViewTextBoxColumn";
            this.sampleAddressDataGridViewTextBoxColumn.Width = 61;
            // 
            // unitTypeIDDataGridViewTextBoxColumn2
            // 
            this.unitTypeIDDataGridViewTextBoxColumn2.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn2.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn2.Name = "unitTypeIDDataGridViewTextBoxColumn2";
            this.unitTypeIDDataGridViewTextBoxColumn2.Width = 51;
            // 
            // heatIDDataGridViewTextBoxColumn3
            // 
            this.heatIDDataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn3.HeaderText = "熔炼号";
            this.heatIDDataGridViewTextBoxColumn3.Name = "heatIDDataGridViewTextBoxColumn3";
            this.heatIDDataGridViewTextBoxColumn3.Width = 61;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // cuDataGridViewTextBoxColumn
            // 
            this.cuDataGridViewTextBoxColumn.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn.Name = "cuDataGridViewTextBoxColumn";
            this.cuDataGridViewTextBoxColumn.Width = 42;
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            this.niDataGridViewTextBoxColumn.Width = 42;
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            this.crDataGridViewTextBoxColumn.Width = 42;
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            this.moDataGridViewTextBoxColumn.Width = 42;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.Width = 36;
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            this.nbDataGridViewTextBoxColumn.Width = 42;
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            this.alDataGridViewTextBoxColumn.Width = 42;
            // 
            // alSDataGridViewTextBoxColumn
            // 
            this.alSDataGridViewTextBoxColumn.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn.Name = "alSDataGridViewTextBoxColumn";
            this.alSDataGridViewTextBoxColumn.Width = 48;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.Width = 36;
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            this.sbDataGridViewTextBoxColumn.Width = 42;
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            this.asDataGridViewTextBoxColumn.Width = 42;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.Width = 42;
            // 
            // znDataGridViewTextBoxColumn
            // 
            this.znDataGridViewTextBoxColumn.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn.Name = "znDataGridViewTextBoxColumn";
            this.znDataGridViewTextBoxColumn.Width = 42;
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            this.caDataGridViewTextBoxColumn.Width = 42;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.Width = 36;
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            this.pbDataGridViewTextBoxColumn.Width = 42;
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            this.reDataGridViewTextBoxColumn.Width = 42;
            // 
            // ceqDataGridViewTextBoxColumn
            // 
            this.ceqDataGridViewTextBoxColumn.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn.Name = "ceqDataGridViewTextBoxColumn";
            this.ceqDataGridViewTextBoxColumn.Width = 48;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.Width = 36;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.Width = 36;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.Width = 36;
            // 
            // crNiDataGridViewTextBoxColumn
            // 
            this.crNiDataGridViewTextBoxColumn.DataPropertyName = "CrNi";
            this.crNiDataGridViewTextBoxColumn.HeaderText = "CrNi";
            this.crNiDataGridViewTextBoxColumn.Name = "crNiDataGridViewTextBoxColumn";
            this.crNiDataGridViewTextBoxColumn.Width = 54;
            // 
            // crCuDataGridViewTextBoxColumn
            // 
            this.crCuDataGridViewTextBoxColumn.DataPropertyName = "CrCu";
            this.crCuDataGridViewTextBoxColumn.HeaderText = "CrCu";
            this.crCuDataGridViewTextBoxColumn.Name = "crCuDataGridViewTextBoxColumn";
            this.crCuDataGridViewTextBoxColumn.Width = 54;
            // 
            // crNiCuDataGridViewTextBoxColumn
            // 
            this.crNiCuDataGridViewTextBoxColumn.DataPropertyName = "CrNiCu";
            this.crNiCuDataGridViewTextBoxColumn.HeaderText = "CrNiCu";
            this.crNiCuDataGridViewTextBoxColumn.Name = "crNiCuDataGridViewTextBoxColumn";
            this.crNiCuDataGridViewTextBoxColumn.Width = 66;
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            this.other1DataGridViewTextBoxColumn.Width = 51;
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "其他2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            this.other2DataGridViewTextBoxColumn.Width = 51;
            // 
            // other3DataGridViewTextBoxColumn
            // 
            this.other3DataGridViewTextBoxColumn.DataPropertyName = "Other3";
            this.other3DataGridViewTextBoxColumn.HeaderText = "其他3";
            this.other3DataGridViewTextBoxColumn.Name = "other3DataGridViewTextBoxColumn";
            this.other3DataGridViewTextBoxColumn.Width = 51;
            // 
            // arriveDateDataGridViewTextBoxColumn
            // 
            this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "Arrive_Date";
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "发报告单时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // unitIDDataGridViewTextBoxColumn2
            // 
            this.unitIDDataGridViewTextBoxColumn2.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn2.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn2.Name = "unitIDDataGridViewTextBoxColumn2";
            this.unitIDDataGridViewTextBoxColumn2.Width = 51;
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "检验次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            this.sampleCountDataGridViewTextBoxColumn.Width = 61;
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // dataLogModeDataGridViewTextBoxColumn1
            // 
            this.dataLogModeDataGridViewTextBoxColumn1.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn1.HeaderText = "数据生产方式";
            this.dataLogModeDataGridViewTextBoxColumn1.Name = "dataLogModeDataGridViewTextBoxColumn1";
            this.dataLogModeDataGridViewTextBoxColumn1.Width = 72;
            // 
            // finalJudgeFlagDataGridViewTextBoxColumn
            // 
            this.finalJudgeFlagDataGridViewTextBoxColumn.DataPropertyName = "FinalJudgeFlag";
            this.finalJudgeFlagDataGridViewTextBoxColumn.HeaderText = "FinalJudgeFlag";
            this.finalJudgeFlagDataGridViewTextBoxColumn.Name = "finalJudgeFlagDataGridViewTextBoxColumn";
            this.finalJudgeFlagDataGridViewTextBoxColumn.Visible = false;
            this.finalJudgeFlagDataGridViewTextBoxColumn.Width = 114;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "检验人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Width = 61;
            // 
            // bsRefineThirdEle
            // 
            this.bsRefineThirdEle.DataMember = "L3DataTable";
            this.bsRefineThirdEle.DataSource = this.dsRefineThirdEle;
            // 
            // dsRefineThirdEle
            // 
            this.dsRefineThirdEle.AutoLoad = true;
            this.dsRefineThirdEle.AutoSubscribe = false;
            this.dsRefineThirdEle.DataSetName = "L3DataSet";
            this.dsRefineThirdEle.DeleteMethod = "";
            this.dsRefineThirdEle.InsertMethod = "";
            this.dsRefineThirdEle.L3DataAdapter = this.Adapter;
            this.dsRefineThirdEle.LoadEvent = "Click";
            this.dsRefineThirdEle.LoadTrigger = null;
            this.dsRefineThirdEle.RefreshValve = 1000;
            this.dsRefineThirdEle.SourceCommand = this.cmdRefineThirdEle;
            this.dsRefineThirdEle.SourceCondition = null;
            this.dsRefineThirdEle.SourceMethod = "GetRefineThirdEle";
            this.dsRefineThirdEle.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsRefineThirdEle.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.dsRefineThirdEle.SubscribeTarget = null;
            this.dsRefineThirdEle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefineThirdEle});
            this.dsRefineThirdEle.UpdateEvent = "Click";
            this.dsRefineThirdEle.UpdateMethod = "";
            this.dsRefineThirdEle.UpdateTrigger = null;
            // 
            // cmdRefineThirdEle
            // 
            this.cmdRefineThirdEle.Adapter = null;
            this.cmdRefineThirdEle.MergeReturnTarget = false;
            this.cmdRefineThirdEle.Method = "GetRefineThirdEle";
            this.cmdRefineThirdEle.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdRefineThirdEle.Parameters.Add(this.l3CommandParameter2);
            this.cmdRefineThirdEle.ReturnTarget = null;
            this.cmdRefineThirdEle.ReturnTargetProperty = null;
            this.cmdRefineThirdEle.Trigger = null;
            this.cmdRefineThirdEle.TriggerEvent = "Click";
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
            // schemadsRefineThirdEle
            // 
            this.schemadsRefineThirdEle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefineThirdEleL3DataTableName,
            this.coldsRefineThirdEleL3DataTableAppID,
            this.coldsRefineThirdEleL3DataTableSample_Code,
            this.coldsRefineThirdEleL3DataTableArrive_Date,
            this.coldsRefineThirdEleL3DataTableReport_Date,
            this.coldsRefineThirdEleL3DataTableHeatID,
            this.coldsRefineThirdEleL3DataTableUnitTypeID,
            this.coldsRefineThirdEleL3DataTableUnitID,
            this.coldsRefineThirdEleL3DataTableSample_Address,
            this.coldsRefineThirdEleL3DataTableSample_Type,
            this.coldsRefineThirdEleL3DataTableSample_Count,
            this.coldsRefineThirdEleL3DataTableC,
            this.coldsRefineThirdEleL3DataTableSi,
            this.coldsRefineThirdEleL3DataTableMn,
            this.coldsRefineThirdEleL3DataTableP,
            this.coldsRefineThirdEleL3DataTableS,
            this.coldsRefineThirdEleL3DataTableCu,
            this.coldsRefineThirdEleL3DataTableNi,
            this.coldsRefineThirdEleL3DataTableCr,
            this.coldsRefineThirdEleL3DataTableMo,
            this.coldsRefineThirdEleL3DataTableV,
            this.coldsRefineThirdEleL3DataTableNb,
            this.coldsRefineThirdEleL3DataTableAl,
            this.coldsRefineThirdEleL3DataTableAlS,
            this.coldsRefineThirdEleL3DataTableTi,
            this.coldsRefineThirdEleL3DataTableB,
            this.coldsRefineThirdEleL3DataTableSb,
            this.coldsRefineThirdEleL3DataTableAs,
            this.coldsRefineThirdEleL3DataTableSn,
            this.coldsRefineThirdEleL3DataTableZn,
            this.coldsRefineThirdEleL3DataTableCa,
            this.coldsRefineThirdEleL3DataTableW,
            this.coldsRefineThirdEleL3DataTablePb,
            this.coldsRefineThirdEleL3DataTableRe,
            this.coldsRefineThirdEleL3DataTableCeq,
            this.coldsRefineThirdEleL3DataTableN,
            this.coldsRefineThirdEleL3DataTableH,
            this.coldsRefineThirdEleL3DataTableO,
            this.coldsRefineThirdEleL3DataTableCrNi,
            this.coldsRefineThirdEleL3DataTableCrCu,
            this.coldsRefineThirdEleL3DataTableCrNiCu,
            this.coldsRefineThirdEleL3DataTableOther1,
            this.coldsRefineThirdEleL3DataTableOther2,
            this.coldsRefineThirdEleL3DataTableOther3,
            this.coldsRefineThirdEleL3DataTableLogTime,
            this.coldsRefineThirdEleL3DataTableDataLogMode,
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag,
            this.coldsRefineThirdEleL3DataTableOperator});
            this.schemadsRefineThirdEle.TableName = "L3DataTable";
            // 
            // coldsRefineThirdEleL3DataTableName
            // 
            this.coldsRefineThirdEleL3DataTableName.Caption = "Name";
            this.coldsRefineThirdEleL3DataTableName.ColumnName = "Name";
            this.coldsRefineThirdEleL3DataTableName.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAppID
            // 
            this.coldsRefineThirdEleL3DataTableAppID.Caption = "AppID";
            this.coldsRefineThirdEleL3DataTableAppID.ColumnName = "AppID";
            this.coldsRefineThirdEleL3DataTableAppID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSample_Code
            // 
            this.coldsRefineThirdEleL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsRefineThirdEleL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsRefineThirdEleL3DataTableSample_Code.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableArrive_Date
            // 
            this.coldsRefineThirdEleL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsRefineThirdEleL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsRefineThirdEleL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableReport_Date
            // 
            this.coldsRefineThirdEleL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsRefineThirdEleL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsRefineThirdEleL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableReport_Date.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableHeatID
            // 
            this.coldsRefineThirdEleL3DataTableHeatID.Caption = "HeatID";
            this.coldsRefineThirdEleL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsRefineThirdEleL3DataTableHeatID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableUnitTypeID
            // 
            this.coldsRefineThirdEleL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsRefineThirdEleL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsRefineThirdEleL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableUnitID
            // 
            this.coldsRefineThirdEleL3DataTableUnitID.Caption = "UnitID";
            this.coldsRefineThirdEleL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsRefineThirdEleL3DataTableUnitID.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableUnitID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSample_Address
            // 
            this.coldsRefineThirdEleL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsRefineThirdEleL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsRefineThirdEleL3DataTableSample_Address.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSample_Type
            // 
            this.coldsRefineThirdEleL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsRefineThirdEleL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsRefineThirdEleL3DataTableSample_Type.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSample_Count
            // 
            this.coldsRefineThirdEleL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsRefineThirdEleL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsRefineThirdEleL3DataTableSample_Count.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableC
            // 
            this.coldsRefineThirdEleL3DataTableC.Caption = "C";
            this.coldsRefineThirdEleL3DataTableC.ColumnName = "C";
            this.coldsRefineThirdEleL3DataTableC.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSi
            // 
            this.coldsRefineThirdEleL3DataTableSi.Caption = "Si";
            this.coldsRefineThirdEleL3DataTableSi.ColumnName = "Si";
            this.coldsRefineThirdEleL3DataTableSi.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableMn
            // 
            this.coldsRefineThirdEleL3DataTableMn.Caption = "Mn";
            this.coldsRefineThirdEleL3DataTableMn.ColumnName = "Mn";
            this.coldsRefineThirdEleL3DataTableMn.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableP
            // 
            this.coldsRefineThirdEleL3DataTableP.Caption = "P";
            this.coldsRefineThirdEleL3DataTableP.ColumnName = "P";
            this.coldsRefineThirdEleL3DataTableP.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableS
            // 
            this.coldsRefineThirdEleL3DataTableS.Caption = "S";
            this.coldsRefineThirdEleL3DataTableS.ColumnName = "S";
            this.coldsRefineThirdEleL3DataTableS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCu
            // 
            this.coldsRefineThirdEleL3DataTableCu.Caption = "Cu";
            this.coldsRefineThirdEleL3DataTableCu.ColumnName = "Cu";
            this.coldsRefineThirdEleL3DataTableCu.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableNi
            // 
            this.coldsRefineThirdEleL3DataTableNi.Caption = "Ni";
            this.coldsRefineThirdEleL3DataTableNi.ColumnName = "Ni";
            this.coldsRefineThirdEleL3DataTableNi.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCr
            // 
            this.coldsRefineThirdEleL3DataTableCr.Caption = "Cr";
            this.coldsRefineThirdEleL3DataTableCr.ColumnName = "Cr";
            this.coldsRefineThirdEleL3DataTableCr.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableMo
            // 
            this.coldsRefineThirdEleL3DataTableMo.Caption = "Mo";
            this.coldsRefineThirdEleL3DataTableMo.ColumnName = "Mo";
            this.coldsRefineThirdEleL3DataTableMo.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableV
            // 
            this.coldsRefineThirdEleL3DataTableV.Caption = "V";
            this.coldsRefineThirdEleL3DataTableV.ColumnName = "V";
            this.coldsRefineThirdEleL3DataTableV.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableNb
            // 
            this.coldsRefineThirdEleL3DataTableNb.Caption = "Nb";
            this.coldsRefineThirdEleL3DataTableNb.ColumnName = "Nb";
            this.coldsRefineThirdEleL3DataTableNb.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAl
            // 
            this.coldsRefineThirdEleL3DataTableAl.Caption = "Al";
            this.coldsRefineThirdEleL3DataTableAl.ColumnName = "Al";
            this.coldsRefineThirdEleL3DataTableAl.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAlS
            // 
            this.coldsRefineThirdEleL3DataTableAlS.Caption = "AlS";
            this.coldsRefineThirdEleL3DataTableAlS.ColumnName = "AlS";
            this.coldsRefineThirdEleL3DataTableAlS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableTi
            // 
            this.coldsRefineThirdEleL3DataTableTi.Caption = "Ti";
            this.coldsRefineThirdEleL3DataTableTi.ColumnName = "Ti";
            this.coldsRefineThirdEleL3DataTableTi.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableB
            // 
            this.coldsRefineThirdEleL3DataTableB.Caption = "B";
            this.coldsRefineThirdEleL3DataTableB.ColumnName = "B";
            this.coldsRefineThirdEleL3DataTableB.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSb
            // 
            this.coldsRefineThirdEleL3DataTableSb.Caption = "Sb";
            this.coldsRefineThirdEleL3DataTableSb.ColumnName = "Sb";
            this.coldsRefineThirdEleL3DataTableSb.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAs
            // 
            this.coldsRefineThirdEleL3DataTableAs.Caption = "As";
            this.coldsRefineThirdEleL3DataTableAs.ColumnName = "As";
            this.coldsRefineThirdEleL3DataTableAs.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSn
            // 
            this.coldsRefineThirdEleL3DataTableSn.Caption = "Sn";
            this.coldsRefineThirdEleL3DataTableSn.ColumnName = "Sn";
            this.coldsRefineThirdEleL3DataTableSn.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableZn
            // 
            this.coldsRefineThirdEleL3DataTableZn.Caption = "Zn";
            this.coldsRefineThirdEleL3DataTableZn.ColumnName = "Zn";
            this.coldsRefineThirdEleL3DataTableZn.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCa
            // 
            this.coldsRefineThirdEleL3DataTableCa.Caption = "Ca";
            this.coldsRefineThirdEleL3DataTableCa.ColumnName = "Ca";
            this.coldsRefineThirdEleL3DataTableCa.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableW
            // 
            this.coldsRefineThirdEleL3DataTableW.Caption = "W";
            this.coldsRefineThirdEleL3DataTableW.ColumnName = "W";
            this.coldsRefineThirdEleL3DataTableW.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTablePb
            // 
            this.coldsRefineThirdEleL3DataTablePb.Caption = "Pb";
            this.coldsRefineThirdEleL3DataTablePb.ColumnName = "Pb";
            this.coldsRefineThirdEleL3DataTablePb.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableRe
            // 
            this.coldsRefineThirdEleL3DataTableRe.Caption = "Re";
            this.coldsRefineThirdEleL3DataTableRe.ColumnName = "Re";
            this.coldsRefineThirdEleL3DataTableRe.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCeq
            // 
            this.coldsRefineThirdEleL3DataTableCeq.Caption = "Ceq";
            this.coldsRefineThirdEleL3DataTableCeq.ColumnName = "Ceq";
            this.coldsRefineThirdEleL3DataTableCeq.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableN
            // 
            this.coldsRefineThirdEleL3DataTableN.Caption = "N";
            this.coldsRefineThirdEleL3DataTableN.ColumnName = "N";
            this.coldsRefineThirdEleL3DataTableN.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableH
            // 
            this.coldsRefineThirdEleL3DataTableH.Caption = "H";
            this.coldsRefineThirdEleL3DataTableH.ColumnName = "H";
            this.coldsRefineThirdEleL3DataTableH.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableO
            // 
            this.coldsRefineThirdEleL3DataTableO.Caption = "O";
            this.coldsRefineThirdEleL3DataTableO.ColumnName = "O";
            this.coldsRefineThirdEleL3DataTableO.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCrNi
            // 
            this.coldsRefineThirdEleL3DataTableCrNi.Caption = "CrNi";
            this.coldsRefineThirdEleL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsRefineThirdEleL3DataTableCrNi.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCrCu
            // 
            this.coldsRefineThirdEleL3DataTableCrCu.Caption = "CrCu";
            this.coldsRefineThirdEleL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsRefineThirdEleL3DataTableCrCu.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCrNiCu
            // 
            this.coldsRefineThirdEleL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsRefineThirdEleL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsRefineThirdEleL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOther1
            // 
            this.coldsRefineThirdEleL3DataTableOther1.Caption = "Other1";
            this.coldsRefineThirdEleL3DataTableOther1.ColumnName = "Other1";
            this.coldsRefineThirdEleL3DataTableOther1.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOther2
            // 
            this.coldsRefineThirdEleL3DataTableOther2.Caption = "Other2";
            this.coldsRefineThirdEleL3DataTableOther2.ColumnName = "Other2";
            this.coldsRefineThirdEleL3DataTableOther2.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOther3
            // 
            this.coldsRefineThirdEleL3DataTableOther3.Caption = "Other3";
            this.coldsRefineThirdEleL3DataTableOther3.ColumnName = "Other3";
            this.coldsRefineThirdEleL3DataTableOther3.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableLogTime
            // 
            this.coldsRefineThirdEleL3DataTableLogTime.Caption = "LogTime";
            this.coldsRefineThirdEleL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsRefineThirdEleL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableLogTime.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableDataLogMode
            // 
            this.coldsRefineThirdEleL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsRefineThirdEleL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsRefineThirdEleL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableFinalJudgeFlag
            // 
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag.Caption = "FinalJudgeFlag";
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag.ColumnName = "FinalJudgeFlag";
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableFinalJudgeFlag.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOperator
            // 
            this.coldsRefineThirdEleL3DataTableOperator.Caption = "Operator";
            this.coldsRefineThirdEleL3DataTableOperator.ColumnName = "Operator";
            this.coldsRefineThirdEleL3DataTableOperator.Namespace = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dvFinalChemical);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 483);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1008, 208);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "转炉中炉中样";
            // 
            // dvFinalChemical
            // 
            this.dvFinalChemical.AllowUserToAddRows = false;
            this.dvFinalChemical.AutoGenerateColumns = false;
            this.dvFinalChemical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFinalChemical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFinalChemical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.nameDataGridViewTextBoxColumn1,
            this.sampleCodeDataGridViewTextBoxColumn1,
            this.appIDDataGridViewTextBoxColumn1,
            this.sampleTypeDataGridViewTextBoxColumn1,
            this.sampleAddressDataGridViewTextBoxColumn1,
            this.heatIDDataGridViewTextBoxColumn4,
            this.unitTypeIDDataGridViewTextBoxColumn3,
            this.unitIDDataGridViewTextBoxColumn3,
            this.reportDateDataGridViewTextBoxColumn1,
            this.logTimeDataGridViewTextBoxColumn1,
            this.arriveDateDataGridViewTextBoxColumn1,
            this.sampleCountDataGridViewTextBoxColumn1,
            this.cDataGridViewTextBoxColumn1,
            this.siDataGridViewTextBoxColumn1,
            this.mnDataGridViewTextBoxColumn1,
            this.pDataGridViewTextBoxColumn1,
            this.sDataGridViewTextBoxColumn1,
            this.cuDataGridViewTextBoxColumn1,
            this.niDataGridViewTextBoxColumn1,
            this.crDataGridViewTextBoxColumn1,
            this.moDataGridViewTextBoxColumn1,
            this.vDataGridViewTextBoxColumn1,
            this.nbDataGridViewTextBoxColumn1,
            this.alDataGridViewTextBoxColumn1,
            this.alSDataGridViewTextBoxColumn1,
            this.tiDataGridViewTextBoxColumn1,
            this.bDataGridViewTextBoxColumn1,
            this.sbDataGridViewTextBoxColumn1,
            this.asDataGridViewTextBoxColumn1,
            this.snDataGridViewTextBoxColumn1,
            this.znDataGridViewTextBoxColumn1,
            this.caDataGridViewTextBoxColumn1,
            this.wDataGridViewTextBoxColumn1,
            this.pbDataGridViewTextBoxColumn1,
            this.reDataGridViewTextBoxColumn1,
            this.ceqDataGridViewTextBoxColumn1,
            this.nDataGridViewTextBoxColumn1,
            this.hDataGridViewTextBoxColumn1,
            this.oDataGridViewTextBoxColumn1,
            this.crNiDataGridViewTextBoxColumn1,
            this.crCuDataGridViewTextBoxColumn1,
            this.crNiCuDataGridViewTextBoxColumn1,
            this.other1DataGridViewTextBoxColumn1,
            this.other2DataGridViewTextBoxColumn1,
            this.other3DataGridViewTextBoxColumn1,
            this.dataLogModeDataGridViewTextBoxColumn2,
            this.finalJudgeFlagDataGridViewTextBoxColumn1,
            this.operatorDataGridViewTextBoxColumn1});
            this.dvFinalChemical.DataSource = this.bsFinalChemical;
            this.dvFinalChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFinalChemical.Location = new System.Drawing.Point(3, 17);
            this.dvFinalChemical.MultiSelect = false;
            this.dvFinalChemical.Name = "dvFinalChemical";
            this.dvFinalChemical.RowHeadersVisible = false;
            this.dvFinalChemical.RowTemplate.Height = 23;
            this.dvFinalChemical.Size = new System.Drawing.Size(1002, 188);
            this.dvFinalChemical.TabIndex = 0;
            this.dvFinalChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFinalChemical_DataError);
            // 
            // bsFinalChemical
            // 
            this.bsFinalChemical.DataMember = "L3DataTable";
            this.bsFinalChemical.DataSource = this.dsFinalChemical;
            // 
            // dsFinalChemical
            // 
            this.dsFinalChemical.AutoLoad = true;
            this.dsFinalChemical.AutoSubscribe = false;
            this.dsFinalChemical.DataSetName = "L3DataSet";
            this.dsFinalChemical.DeleteMethod = "";
            this.dsFinalChemical.InsertMethod = "";
            this.dsFinalChemical.L3DataAdapter = null;
            this.dsFinalChemical.LoadEvent = "Click";
            this.dsFinalChemical.LoadTrigger = null;
            this.dsFinalChemical.RefreshValve = 1000;
            this.dsFinalChemical.SourceCommand = this.cmdFinalChemical;
            this.dsFinalChemical.SourceCondition = null;
            this.dsFinalChemical.SourceMethod = "GetBloomTerminalEle";
            this.dsFinalChemical.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsFinalChemical.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.dsFinalChemical.SubscribeTarget = null;
            this.dsFinalChemical.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFinalChemical});
            this.dsFinalChemical.UpdateEvent = "Click";
            this.dsFinalChemical.UpdateMethod = "";
            this.dsFinalChemical.UpdateTrigger = null;
            // 
            // cmdFinalChemical
            // 
            this.cmdFinalChemical.Adapter = null;
            this.cmdFinalChemical.MergeReturnTarget = false;
            this.cmdFinalChemical.Method = "GetBloomTerminalEle";
            this.cmdFinalChemical.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdFinalChemical.Parameters.Add(this.l3CommandParameter3);
            this.cmdFinalChemical.ReturnTarget = null;
            this.cmdFinalChemical.ReturnTargetProperty = null;
            this.cmdFinalChemical.Trigger = null;
            this.cmdFinalChemical.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // schemadsFinalChemical
            // 
            this.schemadsFinalChemical.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFinalChemicalL3DataTableName,
            this.coldsFinalChemicalL3DataTableAppID,
            this.coldsFinalChemicalL3DataTableHeatID,
            this.coldsFinalChemicalL3DataTableSample_Code,
            this.coldsFinalChemicalL3DataTableSample_Address,
            this.coldsFinalChemicalL3DataTableSample_Type,
            this.coldsFinalChemicalL3DataTableSample_Count,
            this.coldsFinalChemicalL3DataTableArrive_Date,
            this.coldsFinalChemicalL3DataTableReport_Date,
            this.coldsFinalChemicalL3DataTableUnitTypeID,
            this.coldsFinalChemicalL3DataTableUnitID,
            this.coldsFinalChemicalL3DataTableC,
            this.coldsFinalChemicalL3DataTableSi,
            this.coldsFinalChemicalL3DataTableMn,
            this.coldsFinalChemicalL3DataTableP,
            this.coldsFinalChemicalL3DataTableS,
            this.coldsFinalChemicalL3DataTableCu,
            this.coldsFinalChemicalL3DataTableNi,
            this.coldsFinalChemicalL3DataTableCr,
            this.coldsFinalChemicalL3DataTableMo,
            this.coldsFinalChemicalL3DataTableV,
            this.coldsFinalChemicalL3DataTableNb,
            this.coldsFinalChemicalL3DataTableAl,
            this.coldsFinalChemicalL3DataTableAlS,
            this.coldsFinalChemicalL3DataTableTi,
            this.coldsFinalChemicalL3DataTableB,
            this.coldsFinalChemicalL3DataTableSb,
            this.coldsFinalChemicalL3DataTableAs,
            this.coldsFinalChemicalL3DataTableSn,
            this.coldsFinalChemicalL3DataTableZn,
            this.coldsFinalChemicalL3DataTableCa,
            this.coldsFinalChemicalL3DataTableW,
            this.coldsFinalChemicalL3DataTablePb,
            this.coldsFinalChemicalL3DataTableRe,
            this.coldsFinalChemicalL3DataTableCeq,
            this.coldsFinalChemicalL3DataTableN,
            this.coldsFinalChemicalL3DataTableH,
            this.coldsFinalChemicalL3DataTableO,
            this.coldsFinalChemicalL3DataTableCrNi,
            this.coldsFinalChemicalL3DataTableCrCu,
            this.coldsFinalChemicalL3DataTableCrNiCu,
            this.coldsFinalChemicalL3DataTableOther1,
            this.coldsFinalChemicalL3DataTableOther2,
            this.coldsFinalChemicalL3DataTableOther3,
            this.coldsFinalChemicalL3DataTableLogTime,
            this.coldsFinalChemicalL3DataTableDataLogMode,
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag,
            this.coldsFinalChemicalL3DataTableOperator,
            this.AcoldsFinalChemicalL3DataTableCheckFlag});
            this.schemadsFinalChemical.TableName = "L3DataTable";
            // 
            // coldsFinalChemicalL3DataTableName
            // 
            this.coldsFinalChemicalL3DataTableName.Caption = "Name";
            this.coldsFinalChemicalL3DataTableName.ColumnName = "Name";
            this.coldsFinalChemicalL3DataTableName.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAppID
            // 
            this.coldsFinalChemicalL3DataTableAppID.Caption = "AppID";
            this.coldsFinalChemicalL3DataTableAppID.ColumnName = "AppID";
            this.coldsFinalChemicalL3DataTableAppID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableHeatID
            // 
            this.coldsFinalChemicalL3DataTableHeatID.Caption = "HeatID";
            this.coldsFinalChemicalL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsFinalChemicalL3DataTableHeatID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSample_Code
            // 
            this.coldsFinalChemicalL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsFinalChemicalL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsFinalChemicalL3DataTableSample_Code.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSample_Address
            // 
            this.coldsFinalChemicalL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsFinalChemicalL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsFinalChemicalL3DataTableSample_Address.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSample_Type
            // 
            this.coldsFinalChemicalL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsFinalChemicalL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsFinalChemicalL3DataTableSample_Type.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSample_Count
            // 
            this.coldsFinalChemicalL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsFinalChemicalL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsFinalChemicalL3DataTableSample_Count.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableArrive_Date
            // 
            this.coldsFinalChemicalL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsFinalChemicalL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsFinalChemicalL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableReport_Date
            // 
            this.coldsFinalChemicalL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsFinalChemicalL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsFinalChemicalL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableReport_Date.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableUnitTypeID
            // 
            this.coldsFinalChemicalL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsFinalChemicalL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsFinalChemicalL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableUnitID
            // 
            this.coldsFinalChemicalL3DataTableUnitID.Caption = "UnitID";
            this.coldsFinalChemicalL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsFinalChemicalL3DataTableUnitID.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableUnitID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableC
            // 
            this.coldsFinalChemicalL3DataTableC.Caption = "C";
            this.coldsFinalChemicalL3DataTableC.ColumnName = "C";
            this.coldsFinalChemicalL3DataTableC.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSi
            // 
            this.coldsFinalChemicalL3DataTableSi.Caption = "Si";
            this.coldsFinalChemicalL3DataTableSi.ColumnName = "Si";
            this.coldsFinalChemicalL3DataTableSi.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableMn
            // 
            this.coldsFinalChemicalL3DataTableMn.Caption = "Mn";
            this.coldsFinalChemicalL3DataTableMn.ColumnName = "Mn";
            this.coldsFinalChemicalL3DataTableMn.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableP
            // 
            this.coldsFinalChemicalL3DataTableP.Caption = "P";
            this.coldsFinalChemicalL3DataTableP.ColumnName = "P";
            this.coldsFinalChemicalL3DataTableP.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableS
            // 
            this.coldsFinalChemicalL3DataTableS.Caption = "S";
            this.coldsFinalChemicalL3DataTableS.ColumnName = "S";
            this.coldsFinalChemicalL3DataTableS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCu
            // 
            this.coldsFinalChemicalL3DataTableCu.Caption = "Cu";
            this.coldsFinalChemicalL3DataTableCu.ColumnName = "Cu";
            this.coldsFinalChemicalL3DataTableCu.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableNi
            // 
            this.coldsFinalChemicalL3DataTableNi.Caption = "Ni";
            this.coldsFinalChemicalL3DataTableNi.ColumnName = "Ni";
            this.coldsFinalChemicalL3DataTableNi.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCr
            // 
            this.coldsFinalChemicalL3DataTableCr.Caption = "Cr";
            this.coldsFinalChemicalL3DataTableCr.ColumnName = "Cr";
            this.coldsFinalChemicalL3DataTableCr.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableMo
            // 
            this.coldsFinalChemicalL3DataTableMo.Caption = "Mo";
            this.coldsFinalChemicalL3DataTableMo.ColumnName = "Mo";
            this.coldsFinalChemicalL3DataTableMo.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableV
            // 
            this.coldsFinalChemicalL3DataTableV.Caption = "V";
            this.coldsFinalChemicalL3DataTableV.ColumnName = "V";
            this.coldsFinalChemicalL3DataTableV.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableNb
            // 
            this.coldsFinalChemicalL3DataTableNb.Caption = "Nb";
            this.coldsFinalChemicalL3DataTableNb.ColumnName = "Nb";
            this.coldsFinalChemicalL3DataTableNb.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAl
            // 
            this.coldsFinalChemicalL3DataTableAl.Caption = "Al";
            this.coldsFinalChemicalL3DataTableAl.ColumnName = "Al";
            this.coldsFinalChemicalL3DataTableAl.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAlS
            // 
            this.coldsFinalChemicalL3DataTableAlS.Caption = "AlS";
            this.coldsFinalChemicalL3DataTableAlS.ColumnName = "AlS";
            this.coldsFinalChemicalL3DataTableAlS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableTi
            // 
            this.coldsFinalChemicalL3DataTableTi.Caption = "Ti";
            this.coldsFinalChemicalL3DataTableTi.ColumnName = "Ti";
            this.coldsFinalChemicalL3DataTableTi.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableB
            // 
            this.coldsFinalChemicalL3DataTableB.Caption = "B";
            this.coldsFinalChemicalL3DataTableB.ColumnName = "B";
            this.coldsFinalChemicalL3DataTableB.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSb
            // 
            this.coldsFinalChemicalL3DataTableSb.Caption = "Sb";
            this.coldsFinalChemicalL3DataTableSb.ColumnName = "Sb";
            this.coldsFinalChemicalL3DataTableSb.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAs
            // 
            this.coldsFinalChemicalL3DataTableAs.Caption = "As";
            this.coldsFinalChemicalL3DataTableAs.ColumnName = "As";
            this.coldsFinalChemicalL3DataTableAs.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSn
            // 
            this.coldsFinalChemicalL3DataTableSn.Caption = "Sn";
            this.coldsFinalChemicalL3DataTableSn.ColumnName = "Sn";
            this.coldsFinalChemicalL3DataTableSn.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableZn
            // 
            this.coldsFinalChemicalL3DataTableZn.Caption = "Zn";
            this.coldsFinalChemicalL3DataTableZn.ColumnName = "Zn";
            this.coldsFinalChemicalL3DataTableZn.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCa
            // 
            this.coldsFinalChemicalL3DataTableCa.Caption = "Ca";
            this.coldsFinalChemicalL3DataTableCa.ColumnName = "Ca";
            this.coldsFinalChemicalL3DataTableCa.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableW
            // 
            this.coldsFinalChemicalL3DataTableW.Caption = "W";
            this.coldsFinalChemicalL3DataTableW.ColumnName = "W";
            this.coldsFinalChemicalL3DataTableW.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTablePb
            // 
            this.coldsFinalChemicalL3DataTablePb.Caption = "Pb";
            this.coldsFinalChemicalL3DataTablePb.ColumnName = "Pb";
            this.coldsFinalChemicalL3DataTablePb.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableRe
            // 
            this.coldsFinalChemicalL3DataTableRe.Caption = "Re";
            this.coldsFinalChemicalL3DataTableRe.ColumnName = "Re";
            this.coldsFinalChemicalL3DataTableRe.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCeq
            // 
            this.coldsFinalChemicalL3DataTableCeq.Caption = "Ceq";
            this.coldsFinalChemicalL3DataTableCeq.ColumnName = "Ceq";
            this.coldsFinalChemicalL3DataTableCeq.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableN
            // 
            this.coldsFinalChemicalL3DataTableN.Caption = "N";
            this.coldsFinalChemicalL3DataTableN.ColumnName = "N";
            this.coldsFinalChemicalL3DataTableN.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableH
            // 
            this.coldsFinalChemicalL3DataTableH.Caption = "H";
            this.coldsFinalChemicalL3DataTableH.ColumnName = "H";
            this.coldsFinalChemicalL3DataTableH.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableO
            // 
            this.coldsFinalChemicalL3DataTableO.Caption = "O";
            this.coldsFinalChemicalL3DataTableO.ColumnName = "O";
            this.coldsFinalChemicalL3DataTableO.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCrNi
            // 
            this.coldsFinalChemicalL3DataTableCrNi.Caption = "CrNi";
            this.coldsFinalChemicalL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsFinalChemicalL3DataTableCrNi.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCrCu
            // 
            this.coldsFinalChemicalL3DataTableCrCu.Caption = "CrCu";
            this.coldsFinalChemicalL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsFinalChemicalL3DataTableCrCu.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCrNiCu
            // 
            this.coldsFinalChemicalL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsFinalChemicalL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsFinalChemicalL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOther1
            // 
            this.coldsFinalChemicalL3DataTableOther1.Caption = "Other1";
            this.coldsFinalChemicalL3DataTableOther1.ColumnName = "Other1";
            this.coldsFinalChemicalL3DataTableOther1.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOther2
            // 
            this.coldsFinalChemicalL3DataTableOther2.Caption = "Other2";
            this.coldsFinalChemicalL3DataTableOther2.ColumnName = "Other2";
            this.coldsFinalChemicalL3DataTableOther2.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOther3
            // 
            this.coldsFinalChemicalL3DataTableOther3.Caption = "Other3";
            this.coldsFinalChemicalL3DataTableOther3.ColumnName = "Other3";
            this.coldsFinalChemicalL3DataTableOther3.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableLogTime
            // 
            this.coldsFinalChemicalL3DataTableLogTime.Caption = "LogTime";
            this.coldsFinalChemicalL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsFinalChemicalL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableLogTime.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableDataLogMode
            // 
            this.coldsFinalChemicalL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsFinalChemicalL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsFinalChemicalL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableFinalJudgeFlag
            // 
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag.Caption = "FinalJudgeFlag";
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag.ColumnName = "FinalJudgeFlag";
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableFinalJudgeFlag.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOperator
            // 
            this.coldsFinalChemicalL3DataTableOperator.Caption = "Operator";
            this.coldsFinalChemicalL3DataTableOperator.ColumnName = "Operator";
            this.coldsFinalChemicalL3DataTableOperator.Namespace = "";
            // 
            // AcoldsFinalChemicalL3DataTableCheckFlag
            // 
            this.AcoldsFinalChemicalL3DataTableCheckFlag.Caption = "CheckFlag";
            this.AcoldsFinalChemicalL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.AcoldsFinalChemicalL3DataTableCheckFlag.DataType = typeof(short);
            this.AcoldsFinalChemicalL3DataTableCheckFlag.Namespace = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 697);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1008, 68);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "判定";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnJudge);
            this.panel2.Controls.Add(this.rBtnYes);
            this.panel2.Controls.Add(this.rBtnNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(553, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 48);
            this.panel2.TabIndex = 4;
            // 
            // btnJudge
            // 
            this.btnJudge.Font = new System.Drawing.Font("宋体", 8.55F);
            this.btnJudge.Location = new System.Drawing.Point(321, 14);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 24);
            this.btnJudge.TabIndex = 2;
            this.btnJudge.Text = "判 定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Checked = true;
            this.rBtnYes.Location = new System.Drawing.Point(90, 18);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(53, 16);
            this.rBtnYes.TabIndex = 1;
            this.rBtnYes.TabStop = true;
            this.rBtnYes.Text = "合 格";
            this.rBtnYes.UseVisualStyleBackColor = true;
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(188, 18);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(59, 16);
            this.rBtnNo.TabIndex = 0;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "不合格";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvHeatExcept);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 103);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "炉次异常";
            // 
            // bsHeatGrade
            // 
            this.bsHeatGrade.DataMember = "L3DataTable";
            this.bsHeatGrade.DataSource = this.dsHeatGrade;
            // 
            // dsHeatGrade
            // 
            this.dsHeatGrade.AutoLoad = true;
            this.dsHeatGrade.AutoSubscribe = false;
            this.dsHeatGrade.DataSetName = "L3DataSet";
            this.dsHeatGrade.DeleteMethod = null;
            this.dsHeatGrade.InsertMethod = null;
            this.dsHeatGrade.L3DataAdapter = this.Adapter;
            this.dsHeatGrade.LoadEvent = "Click";
            this.dsHeatGrade.LoadTrigger = null;
            this.dsHeatGrade.RefreshValve = 1000;
            this.dsHeatGrade.SourceCommand = null;
            this.dsHeatGrade.SourceCondition = "1=2";
            this.dsHeatGrade.SourceMethod = "";
            this.dsHeatGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeData";
            this.dsHeatGrade.SubscribeTarget = null;
            this.dsHeatGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatGrade});
            this.dsHeatGrade.UpdateEvent = "Click";
            this.dsHeatGrade.UpdateMethod = null;
            this.dsHeatGrade.UpdateTrigger = null;
            // 
            // schemadsHeatGrade
            // 
            this.schemadsHeatGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatGradeL3DataTableID_Object,
            this.coldsHeatGradeL3DataTableHeatID,
            this.coldsHeatGradeL3DataTableProcessCount,
            this.coldsHeatGradeL3DataTableUnitTypeID,
            this.coldsHeatGradeL3DataTableUnitID,
            this.coldsHeatGradeL3DataTableExceptional_Code,
            this.coldsHeatGradeL3DataTableDecide_Code,
            this.coldsHeatGradeL3DataTableHeatGrade,
            this.coldsHeatGradeL3DataTablePreHeatID,
            this.coldsHeatGradeL3DataTablePre_SteelGradeIndex,
            this.coldsHeatGradeL3DataTableSteelGradeIndex,
            this.coldsHeatGradeL3DataTableDataLogMode});
            this.schemadsHeatGrade.TableName = "L3DataTable";
            // 
            // coldsHeatGradeL3DataTableID_Object
            // 
            this.coldsHeatGradeL3DataTableID_Object.Caption = "ID_Object";
            this.coldsHeatGradeL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsHeatGradeL3DataTableID_Object.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableHeatID
            // 
            this.coldsHeatGradeL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatGradeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatGradeL3DataTableHeatID.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableProcessCount
            // 
            this.coldsHeatGradeL3DataTableProcessCount.Caption = "ProcessCount";
            this.coldsHeatGradeL3DataTableProcessCount.ColumnName = "ProcessCount";
            this.coldsHeatGradeL3DataTableProcessCount.DataType = typeof(int);
            this.coldsHeatGradeL3DataTableProcessCount.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableUnitTypeID
            // 
            this.coldsHeatGradeL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsHeatGradeL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsHeatGradeL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsHeatGradeL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableUnitID
            // 
            this.coldsHeatGradeL3DataTableUnitID.Caption = "UnitID";
            this.coldsHeatGradeL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsHeatGradeL3DataTableUnitID.DataType = typeof(int);
            this.coldsHeatGradeL3DataTableUnitID.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableExceptional_Code
            // 
            this.coldsHeatGradeL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsHeatGradeL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsHeatGradeL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableDecide_Code
            // 
            this.coldsHeatGradeL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsHeatGradeL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsHeatGradeL3DataTableDecide_Code.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableHeatGrade
            // 
            this.coldsHeatGradeL3DataTableHeatGrade.Caption = "HeatGrade";
            this.coldsHeatGradeL3DataTableHeatGrade.ColumnName = "HeatGrade";
            this.coldsHeatGradeL3DataTableHeatGrade.Namespace = "";
            // 
            // coldsHeatGradeL3DataTablePreHeatID
            // 
            this.coldsHeatGradeL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsHeatGradeL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsHeatGradeL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsHeatGradeL3DataTablePre_SteelGradeIndex
            // 
            this.coldsHeatGradeL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsHeatGradeL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsHeatGradeL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableSteelGradeIndex
            // 
            this.coldsHeatGradeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsHeatGradeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsHeatGradeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsHeatGradeL3DataTableDataLogMode
            // 
            this.coldsHeatGradeL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsHeatGradeL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsHeatGradeL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsHeatGradeL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCheckFlag
            // 
            this.coldsFinalChemicalL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsFinalChemicalL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsFinalChemicalL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsFinalChemicalL3DataTableCheckFlag.Namespace = "";
            // 
            // cmdJudge
            // 
            this.cmdJudge.Adapter = this.Adapter;
            this.cmdJudge.MergeReturnTarget = false;
            this.cmdJudge.Method = "BofSteelQualityJudge";
            this.cmdJudge.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdJudge.Parameters.Add(this.l3CommandParameter4);
            this.cmdJudge.ReturnTarget = null;
            this.cmdJudge.ReturnTargetProperty = null;
            this.cmdJudge.Trigger = null;
            this.cmdJudge.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "熔炼号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Object";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Object";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn3.HeaderText = "HeatID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 47;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Exceptional_Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "异常代码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProcessCount";
            this.dataGridViewTextBoxColumn5.HeaderText = "处理次数";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn6.HeaderText = "工序";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 51;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn7.HeaderText = "工位";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 51;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Decide_Code";
            this.dataGridViewTextBoxColumn8.HeaderText = "Decide_Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 96;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "HeatGrade";
            this.dataGridViewTextBoxColumn9.HeaderText = "炉次等级";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 61;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PreHeatID";
            this.dataGridViewTextBoxColumn10.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 61;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pre_SteelGradeIndex";
            this.dataGridViewTextBoxColumn11.HeaderText = "预定炼钢记号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 72;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn12.HeaderText = "生产炼钢记号";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 72;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DataLogMode";
            this.dataGridViewTextBoxColumn13.HeaderText = "数据产生方式";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 72;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ID_Object";
            this.dataGridViewTextBoxColumn14.HeaderText = "ID_Object";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 84;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn15.HeaderText = "HeatID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 66;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn16.HeaderText = "工序";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 51;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Exceptional_Code";
            this.dataGridViewTextBoxColumn17.HeaderText = "异常代码";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 61;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Process_Count";
            this.dataGridViewTextBoxColumn18.HeaderText = "处理次数";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 61;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn19.HeaderText = "工位";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 51;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PreHeatID";
            this.dataGridViewTextBoxColumn20.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 61;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Pre_SteelGradeIndex";
            this.dataGridViewTextBoxColumn21.HeaderText = "预定炼钢记号";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 72;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn22.HeaderText = "生产炼钢记号";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 72;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Decide_Code";
            this.dataGridViewTextBoxColumn23.HeaderText = "Decide_Code";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            this.dataGridViewTextBoxColumn23.Width = 96;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Classify";
            this.dataGridViewTextBoxColumn24.HeaderText = "Classify";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Visible = false;
            this.dataGridViewTextBoxColumn24.Width = 78;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn25.HeaderText = "Name";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            this.dataGridViewTextBoxColumn25.Width = 54;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Sample_Code";
            this.dataGridViewTextBoxColumn26.HeaderText = "试样编码";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 61;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn27.HeaderText = "委托单编码";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 72;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Sample_Type";
            this.dataGridViewTextBoxColumn28.HeaderText = "试样类别";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 61;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Sample_Address";
            this.dataGridViewTextBoxColumn29.HeaderText = "取样地点";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 61;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn30.HeaderText = "工序";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 51;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn31.HeaderText = "熔炼号";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 61;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn32.HeaderText = "C";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 36;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn33.HeaderText = "Si";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 42;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn34.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 42;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn35.HeaderText = "P";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 36;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn36.HeaderText = "S";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 36;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Cu";
            this.dataGridViewTextBoxColumn37.HeaderText = "Cu";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 42;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Ni";
            this.dataGridViewTextBoxColumn38.HeaderText = "Ni";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 42;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Cr";
            this.dataGridViewTextBoxColumn39.HeaderText = "Cr";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 42;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Mo";
            this.dataGridViewTextBoxColumn40.HeaderText = "Mo";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 42;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "V";
            this.dataGridViewTextBoxColumn41.HeaderText = "V";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Width = 36;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Nb";
            this.dataGridViewTextBoxColumn42.HeaderText = "Nb";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.Width = 42;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Al";
            this.dataGridViewTextBoxColumn43.HeaderText = "Al";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Width = 42;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "AlS";
            this.dataGridViewTextBoxColumn44.HeaderText = "AlS";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 48;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn45.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.Width = 42;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn46.HeaderText = "B";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Width = 36;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn47.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 42;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn48.HeaderText = "As";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Width = 42;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn49.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 42;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Zn";
            this.dataGridViewTextBoxColumn50.HeaderText = "Zn";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 42;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn51.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 42;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn52.HeaderText = "W";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 36;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn53.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Width = 42;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Re";
            this.dataGridViewTextBoxColumn54.HeaderText = "Re";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.Width = 42;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Ceq";
            this.dataGridViewTextBoxColumn55.HeaderText = "Ceq";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Width = 48;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "N";
            this.dataGridViewTextBoxColumn56.HeaderText = "N";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Width = 36;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "H";
            this.dataGridViewTextBoxColumn57.HeaderText = "H";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Width = 36;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn58.HeaderText = "O";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Width = 36;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "CrNi";
            this.dataGridViewTextBoxColumn59.HeaderText = "CrNi";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 54;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "CrCu";
            this.dataGridViewTextBoxColumn60.HeaderText = "CrCu";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.Width = 54;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "CrNiCu";
            this.dataGridViewTextBoxColumn61.HeaderText = "CrNiCu";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.Width = 66;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Other1";
            this.dataGridViewTextBoxColumn62.HeaderText = "其他1";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.Width = 51;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Other2";
            this.dataGridViewTextBoxColumn63.HeaderText = "其他2";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.Width = 51;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Other3";
            this.dataGridViewTextBoxColumn64.HeaderText = "其他3";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.Width = 51;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Arrive_Date";
            this.dataGridViewTextBoxColumn65.HeaderText = "到样时间";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.Width = 61;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "Report_Date";
            this.dataGridViewTextBoxColumn66.HeaderText = "发报告单时间";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.Width = 72;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn67.HeaderText = "工位";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.Width = 51;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Sample_Count";
            this.dataGridViewTextBoxColumn68.HeaderText = "检验次数";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.Width = 61;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "LogTime";
            this.dataGridViewTextBoxColumn69.HeaderText = "LogTime";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.Width = 72;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "DataLogMode";
            this.dataGridViewTextBoxColumn70.HeaderText = "数据生产方式";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.Width = 72;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "FinalJudgeFlag";
            this.dataGridViewTextBoxColumn71.HeaderText = "FinalJudgeFlag";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.Visible = false;
            this.dataGridViewTextBoxColumn71.Width = 114;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn72.HeaderText = "检验人";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.Width = 61;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn73.HeaderText = "Name";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.Visible = false;
            this.dataGridViewTextBoxColumn73.Width = 54;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "Sample_Code";
            this.dataGridViewTextBoxColumn74.HeaderText = "试样编码";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.Width = 61;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn75.HeaderText = "委托单编码";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.Width = 72;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "Sample_Type";
            this.dataGridViewTextBoxColumn76.HeaderText = "取样类型";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.Width = 61;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "Sample_Address";
            this.dataGridViewTextBoxColumn77.HeaderText = "取样地点";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.Width = 61;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn78.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.Visible = false;
            this.dataGridViewTextBoxColumn78.Width = 54;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn79.HeaderText = "工序";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.Width = 51;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn80.HeaderText = "工位";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.Width = 51;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "Report_Date";
            this.dataGridViewTextBoxColumn81.HeaderText = "报告时间";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.Width = 61;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "LogTime";
            this.dataGridViewTextBoxColumn82.HeaderText = "数据记录时间";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.Width = 72;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "Arrive_Date";
            this.dataGridViewTextBoxColumn83.HeaderText = "到样时间";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.Width = 61;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "Sample_Count";
            this.dataGridViewTextBoxColumn84.HeaderText = "取样次数";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            this.dataGridViewTextBoxColumn84.Visible = false;
            this.dataGridViewTextBoxColumn84.Width = 61;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn85.HeaderText = "C";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            this.dataGridViewTextBoxColumn85.Width = 36;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn86.HeaderText = "Si";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.Width = 42;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn87.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.Width = 42;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn88.HeaderText = "P";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.Width = 36;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn89.HeaderText = "S";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.Width = 36;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "Cu";
            this.dataGridViewTextBoxColumn90.HeaderText = "Cu";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.Width = 42;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "Ni";
            this.dataGridViewTextBoxColumn91.HeaderText = "Ni";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.Width = 42;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "Cr";
            this.dataGridViewTextBoxColumn92.HeaderText = "Cr";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            this.dataGridViewTextBoxColumn92.Width = 42;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "Mo";
            this.dataGridViewTextBoxColumn93.HeaderText = "Mo";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.Width = 42;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "V";
            this.dataGridViewTextBoxColumn94.HeaderText = "V";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.Width = 36;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.DataPropertyName = "Nb";
            this.dataGridViewTextBoxColumn95.HeaderText = "Nb";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.Width = 42;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.DataPropertyName = "Al";
            this.dataGridViewTextBoxColumn96.HeaderText = "Al";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.Width = 42;
            // 
            // dataGridViewTextBoxColumn97
            // 
            this.dataGridViewTextBoxColumn97.DataPropertyName = "AlS";
            this.dataGridViewTextBoxColumn97.HeaderText = "AlS";
            this.dataGridViewTextBoxColumn97.Name = "dataGridViewTextBoxColumn97";
            this.dataGridViewTextBoxColumn97.Width = 48;
            // 
            // dataGridViewTextBoxColumn98
            // 
            this.dataGridViewTextBoxColumn98.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn98.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn98.Name = "dataGridViewTextBoxColumn98";
            this.dataGridViewTextBoxColumn98.Width = 42;
            // 
            // dataGridViewTextBoxColumn99
            // 
            this.dataGridViewTextBoxColumn99.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn99.HeaderText = "B";
            this.dataGridViewTextBoxColumn99.Name = "dataGridViewTextBoxColumn99";
            this.dataGridViewTextBoxColumn99.Width = 36;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn100.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.Width = 42;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn101.HeaderText = "As";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.Width = 42;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn102.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.Width = 42;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.DataPropertyName = "Zn";
            this.dataGridViewTextBoxColumn103.HeaderText = "Zn";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.Width = 42;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn104.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.Width = 42;
            // 
            // dataGridViewTextBoxColumn105
            // 
            this.dataGridViewTextBoxColumn105.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn105.HeaderText = "W";
            this.dataGridViewTextBoxColumn105.Name = "dataGridViewTextBoxColumn105";
            this.dataGridViewTextBoxColumn105.Width = 36;
            // 
            // dataGridViewTextBoxColumn106
            // 
            this.dataGridViewTextBoxColumn106.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn106.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn106.Name = "dataGridViewTextBoxColumn106";
            this.dataGridViewTextBoxColumn106.Width = 42;
            // 
            // dataGridViewTextBoxColumn107
            // 
            this.dataGridViewTextBoxColumn107.DataPropertyName = "Re";
            this.dataGridViewTextBoxColumn107.HeaderText = "Re";
            this.dataGridViewTextBoxColumn107.Name = "dataGridViewTextBoxColumn107";
            this.dataGridViewTextBoxColumn107.Width = 42;
            // 
            // dataGridViewTextBoxColumn108
            // 
            this.dataGridViewTextBoxColumn108.DataPropertyName = "Ceq";
            this.dataGridViewTextBoxColumn108.HeaderText = "Ceq";
            this.dataGridViewTextBoxColumn108.Name = "dataGridViewTextBoxColumn108";
            this.dataGridViewTextBoxColumn108.Width = 48;
            // 
            // dataGridViewTextBoxColumn109
            // 
            this.dataGridViewTextBoxColumn109.DataPropertyName = "N";
            this.dataGridViewTextBoxColumn109.HeaderText = "N";
            this.dataGridViewTextBoxColumn109.Name = "dataGridViewTextBoxColumn109";
            this.dataGridViewTextBoxColumn109.Width = 36;
            // 
            // dataGridViewTextBoxColumn110
            // 
            this.dataGridViewTextBoxColumn110.DataPropertyName = "H";
            this.dataGridViewTextBoxColumn110.HeaderText = "H";
            this.dataGridViewTextBoxColumn110.Name = "dataGridViewTextBoxColumn110";
            this.dataGridViewTextBoxColumn110.Width = 36;
            // 
            // dataGridViewTextBoxColumn111
            // 
            this.dataGridViewTextBoxColumn111.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn111.HeaderText = "O";
            this.dataGridViewTextBoxColumn111.Name = "dataGridViewTextBoxColumn111";
            this.dataGridViewTextBoxColumn111.Width = 36;
            // 
            // dataGridViewTextBoxColumn112
            // 
            this.dataGridViewTextBoxColumn112.DataPropertyName = "CrNi";
            this.dataGridViewTextBoxColumn112.HeaderText = "CrNi";
            this.dataGridViewTextBoxColumn112.Name = "dataGridViewTextBoxColumn112";
            this.dataGridViewTextBoxColumn112.Width = 54;
            // 
            // dataGridViewTextBoxColumn113
            // 
            this.dataGridViewTextBoxColumn113.DataPropertyName = "CrCu";
            this.dataGridViewTextBoxColumn113.HeaderText = "CrCu";
            this.dataGridViewTextBoxColumn113.Name = "dataGridViewTextBoxColumn113";
            this.dataGridViewTextBoxColumn113.Width = 54;
            // 
            // dataGridViewTextBoxColumn114
            // 
            this.dataGridViewTextBoxColumn114.DataPropertyName = "CrNiCu";
            this.dataGridViewTextBoxColumn114.HeaderText = "CrNiCu";
            this.dataGridViewTextBoxColumn114.Name = "dataGridViewTextBoxColumn114";
            this.dataGridViewTextBoxColumn114.Width = 66;
            // 
            // dataGridViewTextBoxColumn115
            // 
            this.dataGridViewTextBoxColumn115.DataPropertyName = "Other1";
            this.dataGridViewTextBoxColumn115.HeaderText = "Other1";
            this.dataGridViewTextBoxColumn115.Name = "dataGridViewTextBoxColumn115";
            this.dataGridViewTextBoxColumn115.Width = 66;
            // 
            // dataGridViewTextBoxColumn116
            // 
            this.dataGridViewTextBoxColumn116.DataPropertyName = "Other2";
            this.dataGridViewTextBoxColumn116.HeaderText = "Other2";
            this.dataGridViewTextBoxColumn116.Name = "dataGridViewTextBoxColumn116";
            this.dataGridViewTextBoxColumn116.Width = 66;
            // 
            // dataGridViewTextBoxColumn117
            // 
            this.dataGridViewTextBoxColumn117.DataPropertyName = "Other3";
            this.dataGridViewTextBoxColumn117.HeaderText = "Other3";
            this.dataGridViewTextBoxColumn117.Name = "dataGridViewTextBoxColumn117";
            this.dataGridViewTextBoxColumn117.Width = 66;
            // 
            // dataGridViewTextBoxColumn118
            // 
            this.dataGridViewTextBoxColumn118.DataPropertyName = "DataLogMode";
            this.dataGridViewTextBoxColumn118.HeaderText = "DataLogMode";
            this.dataGridViewTextBoxColumn118.Name = "dataGridViewTextBoxColumn118";
            this.dataGridViewTextBoxColumn118.Width = 96;
            // 
            // dataGridViewTextBoxColumn119
            // 
            this.dataGridViewTextBoxColumn119.DataPropertyName = "FinalJudgeFlag";
            this.dataGridViewTextBoxColumn119.HeaderText = "FinalJudgeFlag";
            this.dataGridViewTextBoxColumn119.Name = "dataGridViewTextBoxColumn119";
            this.dataGridViewTextBoxColumn119.Width = 114;
            // 
            // dataGridViewTextBoxColumn120
            // 
            this.dataGridViewTextBoxColumn120.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn120.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn120.Name = "dataGridViewTextBoxColumn120";
            this.dataGridViewTextBoxColumn120.Width = 78;
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.Frozen = true;
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.IndeterminateValue = "0";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            this.nameDataGridViewTextBoxColumn1.Width = 54;
            // 
            // sampleCodeDataGridViewTextBoxColumn1
            // 
            this.sampleCodeDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn1.Frozen = true;
            this.sampleCodeDataGridViewTextBoxColumn1.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn1.Name = "sampleCodeDataGridViewTextBoxColumn1";
            this.sampleCodeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // appIDDataGridViewTextBoxColumn1
            // 
            this.appIDDataGridViewTextBoxColumn1.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn1.Frozen = true;
            this.appIDDataGridViewTextBoxColumn1.HeaderText = "委托单编码";
            this.appIDDataGridViewTextBoxColumn1.Name = "appIDDataGridViewTextBoxColumn1";
            this.appIDDataGridViewTextBoxColumn1.Width = 90;
            // 
            // sampleTypeDataGridViewTextBoxColumn1
            // 
            this.sampleTypeDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Type";
            this.sampleTypeDataGridViewTextBoxColumn1.HeaderText = "取样类型";
            this.sampleTypeDataGridViewTextBoxColumn1.Name = "sampleTypeDataGridViewTextBoxColumn1";
            this.sampleTypeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // sampleAddressDataGridViewTextBoxColumn1
            // 
            this.sampleAddressDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn1.HeaderText = "取样地点";
            this.sampleAddressDataGridViewTextBoxColumn1.Name = "sampleAddressDataGridViewTextBoxColumn1";
            this.sampleAddressDataGridViewTextBoxColumn1.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            this.heatIDDataGridViewTextBoxColumn4.Visible = false;
            this.heatIDDataGridViewTextBoxColumn4.Width = 54;
            // 
            // unitTypeIDDataGridViewTextBoxColumn3
            // 
            this.unitTypeIDDataGridViewTextBoxColumn3.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn3.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn3.Name = "unitTypeIDDataGridViewTextBoxColumn3";
            this.unitTypeIDDataGridViewTextBoxColumn3.Width = 54;
            // 
            // unitIDDataGridViewTextBoxColumn3
            // 
            this.unitIDDataGridViewTextBoxColumn3.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn3.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn3.Name = "unitIDDataGridViewTextBoxColumn3";
            this.unitIDDataGridViewTextBoxColumn3.Width = 54;
            // 
            // reportDateDataGridViewTextBoxColumn1
            // 
            this.reportDateDataGridViewTextBoxColumn1.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn1.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn1.Name = "reportDateDataGridViewTextBoxColumn1";
            this.reportDateDataGridViewTextBoxColumn1.Width = 78;
            // 
            // logTimeDataGridViewTextBoxColumn1
            // 
            this.logTimeDataGridViewTextBoxColumn1.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn1.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn1.Name = "logTimeDataGridViewTextBoxColumn1";
            this.logTimeDataGridViewTextBoxColumn1.Width = 72;
            // 
            // arriveDateDataGridViewTextBoxColumn1
            // 
            this.arriveDateDataGridViewTextBoxColumn1.DataPropertyName = "Arrive_Date";
            this.arriveDateDataGridViewTextBoxColumn1.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn1.Name = "arriveDateDataGridViewTextBoxColumn1";
            this.arriveDateDataGridViewTextBoxColumn1.Width = 61;
            // 
            // sampleCountDataGridViewTextBoxColumn1
            // 
            this.sampleCountDataGridViewTextBoxColumn1.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn1.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn1.Name = "sampleCountDataGridViewTextBoxColumn1";
            this.sampleCountDataGridViewTextBoxColumn1.Visible = false;
            this.sampleCountDataGridViewTextBoxColumn1.Width = 61;
            // 
            // cDataGridViewTextBoxColumn1
            // 
            this.cDataGridViewTextBoxColumn1.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn1.HeaderText = "C";
            this.cDataGridViewTextBoxColumn1.Name = "cDataGridViewTextBoxColumn1";
            this.cDataGridViewTextBoxColumn1.Width = 36;
            // 
            // siDataGridViewTextBoxColumn1
            // 
            this.siDataGridViewTextBoxColumn1.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn1.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn1.Name = "siDataGridViewTextBoxColumn1";
            this.siDataGridViewTextBoxColumn1.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn1
            // 
            this.mnDataGridViewTextBoxColumn1.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn1.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn1.Name = "mnDataGridViewTextBoxColumn1";
            this.mnDataGridViewTextBoxColumn1.Width = 42;
            // 
            // pDataGridViewTextBoxColumn1
            // 
            this.pDataGridViewTextBoxColumn1.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn1.HeaderText = "P";
            this.pDataGridViewTextBoxColumn1.Name = "pDataGridViewTextBoxColumn1";
            this.pDataGridViewTextBoxColumn1.Width = 36;
            // 
            // sDataGridViewTextBoxColumn1
            // 
            this.sDataGridViewTextBoxColumn1.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn1.HeaderText = "S";
            this.sDataGridViewTextBoxColumn1.Name = "sDataGridViewTextBoxColumn1";
            this.sDataGridViewTextBoxColumn1.Width = 36;
            // 
            // cuDataGridViewTextBoxColumn1
            // 
            this.cuDataGridViewTextBoxColumn1.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn1.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn1.Name = "cuDataGridViewTextBoxColumn1";
            this.cuDataGridViewTextBoxColumn1.Width = 42;
            // 
            // niDataGridViewTextBoxColumn1
            // 
            this.niDataGridViewTextBoxColumn1.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn1.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn1.Name = "niDataGridViewTextBoxColumn1";
            this.niDataGridViewTextBoxColumn1.Width = 42;
            // 
            // crDataGridViewTextBoxColumn1
            // 
            this.crDataGridViewTextBoxColumn1.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn1.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn1.Name = "crDataGridViewTextBoxColumn1";
            this.crDataGridViewTextBoxColumn1.Width = 42;
            // 
            // moDataGridViewTextBoxColumn1
            // 
            this.moDataGridViewTextBoxColumn1.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn1.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn1.Name = "moDataGridViewTextBoxColumn1";
            this.moDataGridViewTextBoxColumn1.Width = 42;
            // 
            // vDataGridViewTextBoxColumn1
            // 
            this.vDataGridViewTextBoxColumn1.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn1.HeaderText = "V";
            this.vDataGridViewTextBoxColumn1.Name = "vDataGridViewTextBoxColumn1";
            this.vDataGridViewTextBoxColumn1.Width = 36;
            // 
            // nbDataGridViewTextBoxColumn1
            // 
            this.nbDataGridViewTextBoxColumn1.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn1.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn1.Name = "nbDataGridViewTextBoxColumn1";
            this.nbDataGridViewTextBoxColumn1.Width = 42;
            // 
            // alDataGridViewTextBoxColumn1
            // 
            this.alDataGridViewTextBoxColumn1.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn1.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn1.Name = "alDataGridViewTextBoxColumn1";
            this.alDataGridViewTextBoxColumn1.Width = 42;
            // 
            // alSDataGridViewTextBoxColumn1
            // 
            this.alSDataGridViewTextBoxColumn1.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn1.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn1.Name = "alSDataGridViewTextBoxColumn1";
            this.alSDataGridViewTextBoxColumn1.Width = 48;
            // 
            // tiDataGridViewTextBoxColumn1
            // 
            this.tiDataGridViewTextBoxColumn1.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn1.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn1.Name = "tiDataGridViewTextBoxColumn1";
            this.tiDataGridViewTextBoxColumn1.Width = 42;
            // 
            // bDataGridViewTextBoxColumn1
            // 
            this.bDataGridViewTextBoxColumn1.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn1.HeaderText = "B";
            this.bDataGridViewTextBoxColumn1.Name = "bDataGridViewTextBoxColumn1";
            this.bDataGridViewTextBoxColumn1.Width = 36;
            // 
            // sbDataGridViewTextBoxColumn1
            // 
            this.sbDataGridViewTextBoxColumn1.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn1.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn1.Name = "sbDataGridViewTextBoxColumn1";
            this.sbDataGridViewTextBoxColumn1.Width = 42;
            // 
            // asDataGridViewTextBoxColumn1
            // 
            this.asDataGridViewTextBoxColumn1.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn1.HeaderText = "As";
            this.asDataGridViewTextBoxColumn1.Name = "asDataGridViewTextBoxColumn1";
            this.asDataGridViewTextBoxColumn1.Width = 42;
            // 
            // snDataGridViewTextBoxColumn1
            // 
            this.snDataGridViewTextBoxColumn1.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn1.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn1.Name = "snDataGridViewTextBoxColumn1";
            this.snDataGridViewTextBoxColumn1.Width = 42;
            // 
            // znDataGridViewTextBoxColumn1
            // 
            this.znDataGridViewTextBoxColumn1.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn1.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn1.Name = "znDataGridViewTextBoxColumn1";
            this.znDataGridViewTextBoxColumn1.Width = 42;
            // 
            // caDataGridViewTextBoxColumn1
            // 
            this.caDataGridViewTextBoxColumn1.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn1.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn1.Name = "caDataGridViewTextBoxColumn1";
            this.caDataGridViewTextBoxColumn1.Width = 42;
            // 
            // wDataGridViewTextBoxColumn1
            // 
            this.wDataGridViewTextBoxColumn1.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn1.HeaderText = "W";
            this.wDataGridViewTextBoxColumn1.Name = "wDataGridViewTextBoxColumn1";
            this.wDataGridViewTextBoxColumn1.Width = 36;
            // 
            // pbDataGridViewTextBoxColumn1
            // 
            this.pbDataGridViewTextBoxColumn1.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn1.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn1.Name = "pbDataGridViewTextBoxColumn1";
            this.pbDataGridViewTextBoxColumn1.Width = 42;
            // 
            // reDataGridViewTextBoxColumn1
            // 
            this.reDataGridViewTextBoxColumn1.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn1.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn1.Name = "reDataGridViewTextBoxColumn1";
            this.reDataGridViewTextBoxColumn1.Width = 42;
            // 
            // ceqDataGridViewTextBoxColumn1
            // 
            this.ceqDataGridViewTextBoxColumn1.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn1.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn1.Name = "ceqDataGridViewTextBoxColumn1";
            this.ceqDataGridViewTextBoxColumn1.Width = 48;
            // 
            // nDataGridViewTextBoxColumn1
            // 
            this.nDataGridViewTextBoxColumn1.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn1.HeaderText = "N";
            this.nDataGridViewTextBoxColumn1.Name = "nDataGridViewTextBoxColumn1";
            this.nDataGridViewTextBoxColumn1.Width = 36;
            // 
            // hDataGridViewTextBoxColumn1
            // 
            this.hDataGridViewTextBoxColumn1.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn1.HeaderText = "H";
            this.hDataGridViewTextBoxColumn1.Name = "hDataGridViewTextBoxColumn1";
            this.hDataGridViewTextBoxColumn1.Width = 36;
            // 
            // oDataGridViewTextBoxColumn1
            // 
            this.oDataGridViewTextBoxColumn1.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn1.HeaderText = "O";
            this.oDataGridViewTextBoxColumn1.Name = "oDataGridViewTextBoxColumn1";
            this.oDataGridViewTextBoxColumn1.Width = 36;
            // 
            // crNiDataGridViewTextBoxColumn1
            // 
            this.crNiDataGridViewTextBoxColumn1.DataPropertyName = "CrNi";
            this.crNiDataGridViewTextBoxColumn1.HeaderText = "CrNi";
            this.crNiDataGridViewTextBoxColumn1.Name = "crNiDataGridViewTextBoxColumn1";
            this.crNiDataGridViewTextBoxColumn1.Width = 54;
            // 
            // crCuDataGridViewTextBoxColumn1
            // 
            this.crCuDataGridViewTextBoxColumn1.DataPropertyName = "CrCu";
            this.crCuDataGridViewTextBoxColumn1.HeaderText = "CrCu";
            this.crCuDataGridViewTextBoxColumn1.Name = "crCuDataGridViewTextBoxColumn1";
            this.crCuDataGridViewTextBoxColumn1.Width = 54;
            // 
            // crNiCuDataGridViewTextBoxColumn1
            // 
            this.crNiCuDataGridViewTextBoxColumn1.DataPropertyName = "CrNiCu";
            this.crNiCuDataGridViewTextBoxColumn1.HeaderText = "CrNiCu";
            this.crNiCuDataGridViewTextBoxColumn1.Name = "crNiCuDataGridViewTextBoxColumn1";
            this.crNiCuDataGridViewTextBoxColumn1.Width = 66;
            // 
            // other1DataGridViewTextBoxColumn1
            // 
            this.other1DataGridViewTextBoxColumn1.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn1.HeaderText = "Other1";
            this.other1DataGridViewTextBoxColumn1.Name = "other1DataGridViewTextBoxColumn1";
            this.other1DataGridViewTextBoxColumn1.Width = 66;
            // 
            // other2DataGridViewTextBoxColumn1
            // 
            this.other2DataGridViewTextBoxColumn1.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn1.HeaderText = "Other2";
            this.other2DataGridViewTextBoxColumn1.Name = "other2DataGridViewTextBoxColumn1";
            this.other2DataGridViewTextBoxColumn1.Width = 66;
            // 
            // other3DataGridViewTextBoxColumn1
            // 
            this.other3DataGridViewTextBoxColumn1.DataPropertyName = "Other3";
            this.other3DataGridViewTextBoxColumn1.HeaderText = "Other3";
            this.other3DataGridViewTextBoxColumn1.Name = "other3DataGridViewTextBoxColumn1";
            this.other3DataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataLogModeDataGridViewTextBoxColumn2
            // 
            this.dataLogModeDataGridViewTextBoxColumn2.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn2.HeaderText = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn2.Name = "dataLogModeDataGridViewTextBoxColumn2";
            this.dataLogModeDataGridViewTextBoxColumn2.Width = 96;
            // 
            // finalJudgeFlagDataGridViewTextBoxColumn1
            // 
            this.finalJudgeFlagDataGridViewTextBoxColumn1.DataPropertyName = "FinalJudgeFlag";
            this.finalJudgeFlagDataGridViewTextBoxColumn1.HeaderText = "FinalJudgeFlag";
            this.finalJudgeFlagDataGridViewTextBoxColumn1.Name = "finalJudgeFlagDataGridViewTextBoxColumn1";
            this.finalJudgeFlagDataGridViewTextBoxColumn1.Width = 114;
            // 
            // operatorDataGridViewTextBoxColumn1
            // 
            this.operatorDataGridViewTextBoxColumn1.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn1.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn1.Name = "operatorDataGridViewTextBoxColumn1";
            this.operatorDataGridViewTextBoxColumn1.Width = 78;
            // 
            // BofIronToBXGJudgeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BofIronToBXGJudgeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "转炉钢水直送不锈钢质量判定";
            this.Text = "转炉钢水直送不锈钢质量判定";
            ((System.ComponentModel.ISupportInitialize)(this.dsChemicalStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemicalStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefineThirdEle)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinalChemical)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3DataSet dsHeatID;
        private AppSvrHMI.L3Adapter Adapter;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Data.DataTable schemadsHeatID;
        private System.Data.DataColumn coldsHeatIDL3DataTableHeatID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvHeatID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AppSvrHMI.L3DataSet dsHeatGrade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource bsHeatGrade;
        private System.Data.DataTable schemadsHeatGrade;
        private System.Data.DataColumn coldsHeatGradeL3DataTableID_Object;
        private System.Data.DataColumn coldsHeatGradeL3DataTableHeatID;
        private System.Data.DataColumn coldsHeatGradeL3DataTableProcessCount;
        private System.Data.DataColumn coldsHeatGradeL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsHeatGradeL3DataTableUnitID;
        private System.Data.DataColumn coldsHeatGradeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsHeatGradeL3DataTableDecide_Code;
        private System.Data.DataColumn coldsHeatGradeL3DataTableHeatGrade;
        private System.Data.DataColumn coldsHeatGradeL3DataTablePreHeatID;
        private System.Data.DataColumn coldsHeatGradeL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsHeatGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsHeatGradeL3DataTableDataLogMode;
        private AppSvrHMI.L3DataSet dsHeatExcept;
        private System.Windows.Forms.BindingSource bsHeatExcept;
        private System.Data.DataTable schemadsHeatExcept;
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
        private AppSvrHMI.L3DataSet dsChemicalStd;
        private System.Data.DataTable schemadsChemicalStd;
        private System.Data.DataColumn coldsChemicalStdL3DataTableName;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLadle_Brick;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLadle_Use;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLadle_Pre_SteelGrade;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLadle_Stay;
        private System.Data.DataColumn coldsChemicalStdL3DataTableBOF_Type;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLadle_Tapped_Proc;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLF_Type;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRH_Type;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCaster_Type;
        private System.Data.DataColumn coldsChemicalStdL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSi_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSi_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSi_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMn_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMn_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMn_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCu_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCu_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCu_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNi_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNi_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNi_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCr_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCr_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCr_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMo_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMo_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMo_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNb_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNb_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNb_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAl_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAl_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAl_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAlS_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAlS_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAlS_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTi_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTi_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTi_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSb_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSb_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSb_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSn_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSn_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSn_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAs_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAs_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAs_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZn_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZn_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZn_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZr_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZr_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZr_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCa_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCa_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCa_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePb_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePb_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePb_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRe_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRe_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRe_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCeq_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCeq_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCeq_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther1_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther1_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther1_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther2_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther2_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther2_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Max;
        private AppSvrHMI.L3Command cmdChemicalStd;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dvRefineThirdEle;
        private System.Windows.Forms.DataGridView dvFinalChemical;
        private AppSvrHMI.L3DataSet dsRefineThirdEle;
        private System.Data.DataTable schemadsRefineThirdEle;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableName;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAppID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSample_Code;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableArrive_Date;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableReport_Date;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableHeatID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableUnitID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSample_Address;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSample_Type;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSample_Count;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableC;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSi;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableMn;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableP;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCu;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableNi;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCr;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableMo;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableV;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableNb;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAl;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAlS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableTi;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableB;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSb;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAs;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSn;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableZn;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCa;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableW;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTablePb;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableRe;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCeq;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableN;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableH;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableO;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrNi;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrCu;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrNiCu;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOther1;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOther2;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOther3;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableLogTime;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableDataLogMode;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableFinalJudgeFlag;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOperator;
        private System.Windows.Forms.BindingSource bsRefineThirdEle;
        private AppSvrHMI.L3Command cmdRefineThirdEle;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crNiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crNiCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalJudgeFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsFinalChemical;
        private System.Data.DataTable schemadsFinalChemical;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableName;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAppID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableHeatID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSample_Code;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSample_Address;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSample_Type;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSample_Count;
        private System.Windows.Forms.BindingSource bsFinalChemical;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableArrive_Date;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableReport_Date;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableUnitID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableC;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSi;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableMn;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableP;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCu;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableNi;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCr;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableMo;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableV;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableNb;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAl;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAlS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableTi;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableB;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSb;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAs;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSn;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableZn;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCa;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableW;
        private System.Data.DataColumn coldsFinalChemicalL3DataTablePb;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableRe;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCeq;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableN;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableH;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableO;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOther1;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOther2;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOther3;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableLogTime;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableDataLogMode;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableFinalJudgeFlag;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOperator;
        private AppSvrHMI.L3Command cmdFinalChemical;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCheckFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private AppSvrHMI.L3Command cmdJudge;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private buttonHide.MyLine myLine5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCrMoNiCuMax;
        private System.Windows.Forms.Label lblOMax;
        private System.Windows.Forms.Label lblNMax;
        private System.Windows.Forms.Label lblHMax;
        private System.Windows.Forms.Label lblCeqMax;
        private System.Windows.Forms.Label lblReMax;
        private System.Windows.Forms.Label lblPbMax;
        private System.Windows.Forms.Label lblWMax;
        private System.Windows.Forms.Label lblCaMax;
        private System.Windows.Forms.Label lblZrMax;
        private System.Windows.Forms.Label lblZnMax;
        private System.Windows.Forms.Label lblAsMax;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblSnMax;
        private System.Windows.Forms.Label lblCrMoNiCuMin;
        private System.Windows.Forms.Label lblHMin;
        private System.Windows.Forms.Label lblOMin;
        private System.Windows.Forms.Label lblNMin;
        private System.Windows.Forms.Label lblCeqMin;
        private System.Windows.Forms.Label lblPbMin;
        private System.Windows.Forms.Label lblWMin;
        private System.Windows.Forms.Label lblCaMin;
        private System.Windows.Forms.Label lblZrMin;
        private System.Windows.Forms.Label lblZnMin;
        private System.Windows.Forms.Label lblAsMin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblSnMin;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblSbMin;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBMax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblBMin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTiMax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTiMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAlsMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAlsMin;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblAlMax;
        private System.Windows.Forms.Label lblAlMin;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label lblNbMax;
        private System.Windows.Forms.Label lblNbMin;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label lblVMax;
        private System.Windows.Forms.Label lblVMin;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label lblMoMax;
        private System.Windows.Forms.Label lblMoMin;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label lblCrMax;
        private System.Windows.Forms.Label lblCrMin;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label lblNiMax;
        private System.Windows.Forms.Label lblNiMin;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lblCuMax;
        private System.Windows.Forms.Label lblCuMin;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lblSMax;
        private System.Windows.Forms.Label lblSMin;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label lblPMax;
        private System.Windows.Forms.Label lblPMin;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblMnMax;
        private System.Windows.Forms.Label lblMnMin;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label lblSiMax;
        private System.Windows.Forms.Label lblSiMin;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label lblCMax;
        private System.Windows.Forms.Label lblCMin;
        private System.Windows.Forms.Label label39;
        private System.Data.DataColumn AcoldsFinalChemicalL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.DataGridView dvHeatExcept;
        private DataGridValid.DataGridViewValidateCellColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn znDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crNiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crNiCuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn other3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalJudgeFlagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn1;
    }
}