namespace QualityMag.QualityJudge
{
    partial class SteelWaterToBXGJudgeFrm
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
            System.Windows.Forms.Label lblSbMax;
            System.Windows.Forms.Label lblReMin;
            System.Windows.Forms.Label label36;
            this.dsChemicalStd = new AppSvrHMI.L3DataSet();
            this.cmdChemicalStd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.schemadsChemicalStd = new System.Data.DataTable();
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLADLE_BRICK = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLADLE_USE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLADLE_STAY = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableBOF_TYPE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableLF_TYPE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRH_TYPE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCASTER_TYPE = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableC_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSI_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSI_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSI_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMN_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMN_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMN_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableP_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableS_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCU_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCU_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCU_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNI_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNI_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNI_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCR_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCR_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCR_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMO_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMO_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableMO_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableV_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNB_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNB_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableNB_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAL_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAL_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAL_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableALS_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableALS_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableALS_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTI_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTI_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableTI_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableB_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSB_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSB_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSB_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSN_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSN_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableSN_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAS_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAS_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableAS_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZN_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZN_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZN_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZR_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZR_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableZR_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCA_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCA_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCA_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableW_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePB_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePB_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTablePB_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRE_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRE_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableRE_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCEQ_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCEQ_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCEQ_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableN_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableH_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableO_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNi_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrCu_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableCrNiCu_Max = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER1_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER1_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER1_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER2_MIN = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER2_AIM = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOTHER2_MAX = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Min = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Aim = new System.Data.DataColumn();
            this.coldsChemicalStdL3DataTableOther3_Max = new System.Data.DataColumn();
            this.bsHeatID = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsHeatID = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableHEATID = new System.Data.DataColumn();
            this.cmdHeatID = new AppSvrHMI.L3Command(this.components);
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
            this.bsHeatGrade = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatGrade = new AppSvrHMI.L3DataSet();
            this.schemadsHeatGrade = new System.Data.DataTable();
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
            this.bsRefineThirdEle = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefineThirdEle = new AppSvrHMI.L3DataSet();
            this.cmdRefineThirdEle = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.schemadsRefineThirdEle = new System.Data.DataTable();
            this.coldsRefineThirdEleL3DataTableAPPID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableREPORT_DATE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableUNITTYPEID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableUNITID = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableC = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSI = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableMN = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableP = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCU = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableNI = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCR = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableMO = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableV = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableNB = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAL = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableALS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableTI = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableB = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSB = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableAS = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableSN = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableZN = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCA = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableW = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTablePB = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableRE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCEQ = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableN = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableH = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableO = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOTHER1 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOTHER2 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableLOGTIME = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableDATALOGMODE = new System.Data.DataColumn();
            this.coldsRefineThirdEleL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bsFinalChemical = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinalChemical = new AppSvrHMI.L3DataSet();
            this.cmdFinalChemical = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.schemadsFinalChemical = new System.Data.DataTable();
            this.coldsFinalChemicalL3DataTableAPPID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableARRIVE_DATE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableREPORT_DATE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableUNITTYPEID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableUNITID = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableC = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSI = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableMN = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableP = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCU = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableNI = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCR = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableMO = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableV = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableNB = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAL = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableALS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableTI = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableB = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSB = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableAS = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableSN = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableZN = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCA = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableW = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTablePB = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableRE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCEQ = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableN = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableH = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableO = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOTHER1 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOTHER2 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableLOGTIME = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableDATALOGMODE = new System.Data.DataColumn();
            this.coldsFinalChemicalL3DataTableCheckFlag = new System.Data.DataColumn();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpds = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpAppID = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanelMain = new HMIBase.HMIRootPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvHeatID = new System.Windows.Forms.DataGridView();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvRefineThirdEle = new System.Windows.Forms.DataGridView();
            this.sAMPLECODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APPIDRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLETYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uNITTYPEIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEQDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCuL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCuL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTHER1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHER22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLECOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVEDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPORTDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALOGMODEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFinalChemical = new System.Windows.Forms.GroupBox();
            this.dvFinalChemical = new System.Windows.Forms.DataGridView();
            this.CheckFlagFin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sAMPLECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APPIDFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAMPLE_TYPE1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sAMPLEADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uNITTYPEIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rEPORTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCuP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCuP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTHER1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHER21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATALOGMODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJudge = new System.Windows.Forms.Button();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.gbxChemicalStd = new System.Windows.Forms.GroupBox();
            this.myLine5 = new buttonHide.MyLine();
            this.myLine4 = new buttonHide.MyLine();
            this.myLine3 = new buttonHide.MyLine();
            this.myLine2 = new buttonHide.MyLine();
            this.myLine1 = new buttonHide.MyLine();
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbxHeatExcept = new System.Windows.Forms.GroupBox();
            this.dvHeatExcept = new System.Windows.Forms.DataGridView();
            this.unitTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxHeatGrade = new System.Windows.Forms.GroupBox();
            this.dvHeatGrade = new System.Windows.Forms.DataGridView();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3cmdpSteelGrade = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpSteelGradeIndex = new AppSvrHMI.L3CommandParameter();
            this.cmdJudge = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
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
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            lblSbMax = new System.Windows.Forms.Label();
            lblReMin = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemicalStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemicalStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefineThirdEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinalChemical)).BeginInit();
            this.hmiRootPanelMain.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatID)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRefineThirdEle)).BeginInit();
            this.gbxFinalChemical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalChemical)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxChemicalStd.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbxHeatExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).BeginInit();
            this.gbxHeatGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSbMax
            // 
            lblSbMax.AutoSize = true;
            lblSbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SB_MAX", true));
            lblSbMax.Location = new System.Drawing.Point(772, 88);
            lblSbMax.Name = "lblSbMax";
            lblSbMax.Size = new System.Drawing.Size(23, 12);
            lblSbMax.TabIndex = 128;
            lblSbMax.Text = "XXX";
            // 
            // dsChemicalStd
            // 
            this.dsChemicalStd.AutoLoad = true;
            this.dsChemicalStd.AutoSubscribe = false;
            this.dsChemicalStd.DataSetName = "L3DataSet";
            this.dsChemicalStd.DeleteMethod = "";
            this.dsChemicalStd.InsertMethod = "";
            this.dsChemicalStd.L3DataAdapter = null;
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
            // cmdChemicalStd
            // 
            this.cmdChemicalStd.Adapter = null;
            this.cmdChemicalStd.MergeReturnTarget = false;
            this.cmdChemicalStd.Method = "GetBloomStdEle";
            this.cmdChemicalStd.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdChemicalStd.Parameters.Add(this.l3CommandParameter10);
            this.cmdChemicalStd.ReturnTarget = null;
            this.cmdChemicalStd.ReturnTargetProperty = null;
            this.cmdChemicalStd.Trigger = null;
            this.cmdChemicalStd.TriggerEvent = "Click";
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
            // schemadsChemicalStd
            // 
            this.schemadsChemicalStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX,
            this.coldsChemicalStdL3DataTableLADLE_BRICK,
            this.coldsChemicalStdL3DataTableLADLE_USE,
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE,
            this.coldsChemicalStdL3DataTableLADLE_STAY,
            this.coldsChemicalStdL3DataTableBOF_TYPE,
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC,
            this.coldsChemicalStdL3DataTableLF_TYPE,
            this.coldsChemicalStdL3DataTableRH_TYPE,
            this.coldsChemicalStdL3DataTableCASTER_TYPE,
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG,
            this.coldsChemicalStdL3DataTableC_MIN,
            this.coldsChemicalStdL3DataTableC_AIM,
            this.coldsChemicalStdL3DataTableC_MAX,
            this.coldsChemicalStdL3DataTableSI_MIN,
            this.coldsChemicalStdL3DataTableSI_AIM,
            this.coldsChemicalStdL3DataTableSI_MAX,
            this.coldsChemicalStdL3DataTableMN_MIN,
            this.coldsChemicalStdL3DataTableMN_AIM,
            this.coldsChemicalStdL3DataTableMN_MAX,
            this.coldsChemicalStdL3DataTableP_MIN,
            this.coldsChemicalStdL3DataTableP_AIM,
            this.coldsChemicalStdL3DataTableP_MAX,
            this.coldsChemicalStdL3DataTableS_MIN,
            this.coldsChemicalStdL3DataTableS_AIM,
            this.coldsChemicalStdL3DataTableS_MAX,
            this.coldsChemicalStdL3DataTableCU_MIN,
            this.coldsChemicalStdL3DataTableCU_AIM,
            this.coldsChemicalStdL3DataTableCU_MAX,
            this.coldsChemicalStdL3DataTableNI_MIN,
            this.coldsChemicalStdL3DataTableNI_AIM,
            this.coldsChemicalStdL3DataTableNI_MAX,
            this.coldsChemicalStdL3DataTableCR_MIN,
            this.coldsChemicalStdL3DataTableCR_AIM,
            this.coldsChemicalStdL3DataTableCR_MAX,
            this.coldsChemicalStdL3DataTableMO_MIN,
            this.coldsChemicalStdL3DataTableMO_AIM,
            this.coldsChemicalStdL3DataTableMO_MAX,
            this.coldsChemicalStdL3DataTableV_MIN,
            this.coldsChemicalStdL3DataTableV_AIM,
            this.coldsChemicalStdL3DataTableV_MAX,
            this.coldsChemicalStdL3DataTableNB_MIN,
            this.coldsChemicalStdL3DataTableNB_AIM,
            this.coldsChemicalStdL3DataTableNB_MAX,
            this.coldsChemicalStdL3DataTableAL_MIN,
            this.coldsChemicalStdL3DataTableAL_AIM,
            this.coldsChemicalStdL3DataTableAL_MAX,
            this.coldsChemicalStdL3DataTableALS_MIN,
            this.coldsChemicalStdL3DataTableALS_AIM,
            this.coldsChemicalStdL3DataTableALS_MAX,
            this.coldsChemicalStdL3DataTableTI_MIN,
            this.coldsChemicalStdL3DataTableTI_AIM,
            this.coldsChemicalStdL3DataTableTI_MAX,
            this.coldsChemicalStdL3DataTableB_MIN,
            this.coldsChemicalStdL3DataTableB_AIM,
            this.coldsChemicalStdL3DataTableB_MAX,
            this.coldsChemicalStdL3DataTableSB_MIN,
            this.coldsChemicalStdL3DataTableSB_AIM,
            this.coldsChemicalStdL3DataTableSB_MAX,
            this.coldsChemicalStdL3DataTableSN_MIN,
            this.coldsChemicalStdL3DataTableSN_AIM,
            this.coldsChemicalStdL3DataTableSN_MAX,
            this.coldsChemicalStdL3DataTableAS_MIN,
            this.coldsChemicalStdL3DataTableAS_AIM,
            this.coldsChemicalStdL3DataTableAS_MAX,
            this.coldsChemicalStdL3DataTableZN_MIN,
            this.coldsChemicalStdL3DataTableZN_AIM,
            this.coldsChemicalStdL3DataTableZN_MAX,
            this.coldsChemicalStdL3DataTableZR_MIN,
            this.coldsChemicalStdL3DataTableZR_AIM,
            this.coldsChemicalStdL3DataTableZR_MAX,
            this.coldsChemicalStdL3DataTableCA_MIN,
            this.coldsChemicalStdL3DataTableCA_AIM,
            this.coldsChemicalStdL3DataTableCA_MAX,
            this.coldsChemicalStdL3DataTableW_MIN,
            this.coldsChemicalStdL3DataTableW_AIM,
            this.coldsChemicalStdL3DataTableW_MAX,
            this.coldsChemicalStdL3DataTablePB_MIN,
            this.coldsChemicalStdL3DataTablePB_AIM,
            this.coldsChemicalStdL3DataTablePB_MAX,
            this.coldsChemicalStdL3DataTableRE_MIN,
            this.coldsChemicalStdL3DataTableRE_AIM,
            this.coldsChemicalStdL3DataTableRE_MAX,
            this.coldsChemicalStdL3DataTableCEQ_MIN,
            this.coldsChemicalStdL3DataTableCEQ_AIM,
            this.coldsChemicalStdL3DataTableCEQ_MAX,
            this.coldsChemicalStdL3DataTableN_MIN,
            this.coldsChemicalStdL3DataTableN_AIM,
            this.coldsChemicalStdL3DataTableN_MAX,
            this.coldsChemicalStdL3DataTableH_MIN,
            this.coldsChemicalStdL3DataTableH_AIM,
            this.coldsChemicalStdL3DataTableH_MAX,
            this.coldsChemicalStdL3DataTableO_MIN,
            this.coldsChemicalStdL3DataTableO_AIM,
            this.coldsChemicalStdL3DataTableO_MAX,
            this.coldsChemicalStdL3DataTableCrNi_Min,
            this.coldsChemicalStdL3DataTableCrNi_Aim,
            this.coldsChemicalStdL3DataTableCrNi_Max,
            this.coldsChemicalStdL3DataTableCrCu_Min,
            this.coldsChemicalStdL3DataTableCrCu_Aim,
            this.coldsChemicalStdL3DataTableCrCu_Max,
            this.coldsChemicalStdL3DataTableCrNiCu_Min,
            this.coldsChemicalStdL3DataTableCrNiCu_Aim,
            this.coldsChemicalStdL3DataTableCrNiCu_Max,
            this.coldsChemicalStdL3DataTableOTHER1_MIN,
            this.coldsChemicalStdL3DataTableOTHER1_AIM,
            this.coldsChemicalStdL3DataTableOTHER1_MAX,
            this.coldsChemicalStdL3DataTableOTHER2_MIN,
            this.coldsChemicalStdL3DataTableOTHER2_AIM,
            this.coldsChemicalStdL3DataTableOTHER2_MAX,
            this.coldsChemicalStdL3DataTableOther3_Min,
            this.coldsChemicalStdL3DataTableOther3_Aim,
            this.coldsChemicalStdL3DataTableOther3_Max});
            this.schemadsChemicalStd.TableName = "L3DataTable";
            // 
            // coldsChemicalStdL3DataTableSTEELGRADEINDEX
            // 
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsChemicalStdL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLADLE_BRICK
            // 
            this.coldsChemicalStdL3DataTableLADLE_BRICK.Caption = "LADLE_BRICK";
            this.coldsChemicalStdL3DataTableLADLE_BRICK.ColumnName = "LADLE_BRICK";
            this.coldsChemicalStdL3DataTableLADLE_BRICK.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLADLE_BRICK.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLADLE_USE
            // 
            this.coldsChemicalStdL3DataTableLADLE_USE.Caption = "LADLE_USE";
            this.coldsChemicalStdL3DataTableLADLE_USE.ColumnName = "LADLE_USE";
            this.coldsChemicalStdL3DataTableLADLE_USE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLADLE_USE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE
            // 
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE.Caption = "LADLE_PRE_STEELGRADE";
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE.ColumnName = "LADLE_PRE_STEELGRADE";
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLADLE_STAY
            // 
            this.coldsChemicalStdL3DataTableLADLE_STAY.Caption = "LADLE_STAY";
            this.coldsChemicalStdL3DataTableLADLE_STAY.ColumnName = "LADLE_STAY";
            this.coldsChemicalStdL3DataTableLADLE_STAY.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLADLE_STAY.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableBOF_TYPE
            // 
            this.coldsChemicalStdL3DataTableBOF_TYPE.Caption = "BOF_TYPE";
            this.coldsChemicalStdL3DataTableBOF_TYPE.ColumnName = "BOF_TYPE";
            this.coldsChemicalStdL3DataTableBOF_TYPE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableBOF_TYPE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLADLE_TAPPED_PROC
            // 
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC.Caption = "LADLE_TAPPED_PROC";
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC.ColumnName = "LADLE_TAPPED_PROC";
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLADLE_TAPPED_PROC.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableLF_TYPE
            // 
            this.coldsChemicalStdL3DataTableLF_TYPE.Caption = "LF_TYPE";
            this.coldsChemicalStdL3DataTableLF_TYPE.ColumnName = "LF_TYPE";
            this.coldsChemicalStdL3DataTableLF_TYPE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableLF_TYPE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRH_TYPE
            // 
            this.coldsChemicalStdL3DataTableRH_TYPE.Caption = "RH_TYPE";
            this.coldsChemicalStdL3DataTableRH_TYPE.ColumnName = "RH_TYPE";
            this.coldsChemicalStdL3DataTableRH_TYPE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableRH_TYPE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCASTER_TYPE
            // 
            this.coldsChemicalStdL3DataTableCASTER_TYPE.Caption = "CASTER_TYPE";
            this.coldsChemicalStdL3DataTableCASTER_TYPE.ColumnName = "CASTER_TYPE";
            this.coldsChemicalStdL3DataTableCASTER_TYPE.DefaultValue = "";
            this.coldsChemicalStdL3DataTableCASTER_TYPE.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableHOT_SEND_FLAG
            // 
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_MIN
            // 
            this.coldsChemicalStdL3DataTableC_MIN.Caption = "C_MIN";
            this.coldsChemicalStdL3DataTableC_MIN.ColumnName = "C_MIN";
            this.coldsChemicalStdL3DataTableC_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableC_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_AIM
            // 
            this.coldsChemicalStdL3DataTableC_AIM.Caption = "C_AIM";
            this.coldsChemicalStdL3DataTableC_AIM.ColumnName = "C_AIM";
            this.coldsChemicalStdL3DataTableC_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableC_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableC_MAX
            // 
            this.coldsChemicalStdL3DataTableC_MAX.Caption = "C_MAX";
            this.coldsChemicalStdL3DataTableC_MAX.ColumnName = "C_MAX";
            this.coldsChemicalStdL3DataTableC_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableC_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSI_MIN
            // 
            this.coldsChemicalStdL3DataTableSI_MIN.Caption = "SI_MIN";
            this.coldsChemicalStdL3DataTableSI_MIN.ColumnName = "SI_MIN";
            this.coldsChemicalStdL3DataTableSI_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSI_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSI_AIM
            // 
            this.coldsChemicalStdL3DataTableSI_AIM.Caption = "SI_AIM";
            this.coldsChemicalStdL3DataTableSI_AIM.ColumnName = "SI_AIM";
            this.coldsChemicalStdL3DataTableSI_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSI_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSI_MAX
            // 
            this.coldsChemicalStdL3DataTableSI_MAX.Caption = "SI_MAX";
            this.coldsChemicalStdL3DataTableSI_MAX.ColumnName = "SI_MAX";
            this.coldsChemicalStdL3DataTableSI_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSI_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMN_MIN
            // 
            this.coldsChemicalStdL3DataTableMN_MIN.Caption = "MN_MIN";
            this.coldsChemicalStdL3DataTableMN_MIN.ColumnName = "MN_MIN";
            this.coldsChemicalStdL3DataTableMN_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMN_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMN_AIM
            // 
            this.coldsChemicalStdL3DataTableMN_AIM.Caption = "MN_AIM";
            this.coldsChemicalStdL3DataTableMN_AIM.ColumnName = "MN_AIM";
            this.coldsChemicalStdL3DataTableMN_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMN_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMN_MAX
            // 
            this.coldsChemicalStdL3DataTableMN_MAX.Caption = "MN_MAX";
            this.coldsChemicalStdL3DataTableMN_MAX.ColumnName = "MN_MAX";
            this.coldsChemicalStdL3DataTableMN_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMN_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_MIN
            // 
            this.coldsChemicalStdL3DataTableP_MIN.Caption = "P_MIN";
            this.coldsChemicalStdL3DataTableP_MIN.ColumnName = "P_MIN";
            this.coldsChemicalStdL3DataTableP_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableP_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_AIM
            // 
            this.coldsChemicalStdL3DataTableP_AIM.Caption = "P_AIM";
            this.coldsChemicalStdL3DataTableP_AIM.ColumnName = "P_AIM";
            this.coldsChemicalStdL3DataTableP_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableP_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableP_MAX
            // 
            this.coldsChemicalStdL3DataTableP_MAX.Caption = "P_MAX";
            this.coldsChemicalStdL3DataTableP_MAX.ColumnName = "P_MAX";
            this.coldsChemicalStdL3DataTableP_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableP_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_MIN
            // 
            this.coldsChemicalStdL3DataTableS_MIN.Caption = "S_MIN";
            this.coldsChemicalStdL3DataTableS_MIN.ColumnName = "S_MIN";
            this.coldsChemicalStdL3DataTableS_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableS_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_AIM
            // 
            this.coldsChemicalStdL3DataTableS_AIM.Caption = "S_AIM";
            this.coldsChemicalStdL3DataTableS_AIM.ColumnName = "S_AIM";
            this.coldsChemicalStdL3DataTableS_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableS_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableS_MAX
            // 
            this.coldsChemicalStdL3DataTableS_MAX.Caption = "S_MAX";
            this.coldsChemicalStdL3DataTableS_MAX.ColumnName = "S_MAX";
            this.coldsChemicalStdL3DataTableS_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableS_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCU_MIN
            // 
            this.coldsChemicalStdL3DataTableCU_MIN.Caption = "CU_MIN";
            this.coldsChemicalStdL3DataTableCU_MIN.ColumnName = "CU_MIN";
            this.coldsChemicalStdL3DataTableCU_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCU_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCU_AIM
            // 
            this.coldsChemicalStdL3DataTableCU_AIM.Caption = "CU_AIM";
            this.coldsChemicalStdL3DataTableCU_AIM.ColumnName = "CU_AIM";
            this.coldsChemicalStdL3DataTableCU_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCU_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCU_MAX
            // 
            this.coldsChemicalStdL3DataTableCU_MAX.Caption = "CU_MAX";
            this.coldsChemicalStdL3DataTableCU_MAX.ColumnName = "CU_MAX";
            this.coldsChemicalStdL3DataTableCU_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCU_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNI_MIN
            // 
            this.coldsChemicalStdL3DataTableNI_MIN.Caption = "NI_MIN";
            this.coldsChemicalStdL3DataTableNI_MIN.ColumnName = "NI_MIN";
            this.coldsChemicalStdL3DataTableNI_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNI_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNI_AIM
            // 
            this.coldsChemicalStdL3DataTableNI_AIM.Caption = "NI_AIM";
            this.coldsChemicalStdL3DataTableNI_AIM.ColumnName = "NI_AIM";
            this.coldsChemicalStdL3DataTableNI_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNI_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNI_MAX
            // 
            this.coldsChemicalStdL3DataTableNI_MAX.Caption = "NI_MAX";
            this.coldsChemicalStdL3DataTableNI_MAX.ColumnName = "NI_MAX";
            this.coldsChemicalStdL3DataTableNI_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNI_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCR_MIN
            // 
            this.coldsChemicalStdL3DataTableCR_MIN.Caption = "CR_MIN";
            this.coldsChemicalStdL3DataTableCR_MIN.ColumnName = "CR_MIN";
            this.coldsChemicalStdL3DataTableCR_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCR_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCR_AIM
            // 
            this.coldsChemicalStdL3DataTableCR_AIM.Caption = "CR_AIM";
            this.coldsChemicalStdL3DataTableCR_AIM.ColumnName = "CR_AIM";
            this.coldsChemicalStdL3DataTableCR_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCR_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCR_MAX
            // 
            this.coldsChemicalStdL3DataTableCR_MAX.Caption = "CR_MAX";
            this.coldsChemicalStdL3DataTableCR_MAX.ColumnName = "CR_MAX";
            this.coldsChemicalStdL3DataTableCR_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCR_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMO_MIN
            // 
            this.coldsChemicalStdL3DataTableMO_MIN.Caption = "MO_MIN";
            this.coldsChemicalStdL3DataTableMO_MIN.ColumnName = "MO_MIN";
            this.coldsChemicalStdL3DataTableMO_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMO_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMO_AIM
            // 
            this.coldsChemicalStdL3DataTableMO_AIM.Caption = "MO_AIM";
            this.coldsChemicalStdL3DataTableMO_AIM.ColumnName = "MO_AIM";
            this.coldsChemicalStdL3DataTableMO_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMO_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableMO_MAX
            // 
            this.coldsChemicalStdL3DataTableMO_MAX.Caption = "MO_MAX";
            this.coldsChemicalStdL3DataTableMO_MAX.ColumnName = "MO_MAX";
            this.coldsChemicalStdL3DataTableMO_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableMO_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_MIN
            // 
            this.coldsChemicalStdL3DataTableV_MIN.Caption = "V_MIN";
            this.coldsChemicalStdL3DataTableV_MIN.ColumnName = "V_MIN";
            this.coldsChemicalStdL3DataTableV_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableV_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_AIM
            // 
            this.coldsChemicalStdL3DataTableV_AIM.Caption = "V_AIM";
            this.coldsChemicalStdL3DataTableV_AIM.ColumnName = "V_AIM";
            this.coldsChemicalStdL3DataTableV_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableV_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableV_MAX
            // 
            this.coldsChemicalStdL3DataTableV_MAX.Caption = "V_MAX";
            this.coldsChemicalStdL3DataTableV_MAX.ColumnName = "V_MAX";
            this.coldsChemicalStdL3DataTableV_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableV_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNB_MIN
            // 
            this.coldsChemicalStdL3DataTableNB_MIN.Caption = "NB_MIN";
            this.coldsChemicalStdL3DataTableNB_MIN.ColumnName = "NB_MIN";
            this.coldsChemicalStdL3DataTableNB_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNB_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNB_AIM
            // 
            this.coldsChemicalStdL3DataTableNB_AIM.Caption = "NB_AIM";
            this.coldsChemicalStdL3DataTableNB_AIM.ColumnName = "NB_AIM";
            this.coldsChemicalStdL3DataTableNB_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNB_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableNB_MAX
            // 
            this.coldsChemicalStdL3DataTableNB_MAX.Caption = "NB_MAX";
            this.coldsChemicalStdL3DataTableNB_MAX.ColumnName = "NB_MAX";
            this.coldsChemicalStdL3DataTableNB_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableNB_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAL_MIN
            // 
            this.coldsChemicalStdL3DataTableAL_MIN.Caption = "AL_MIN";
            this.coldsChemicalStdL3DataTableAL_MIN.ColumnName = "AL_MIN";
            this.coldsChemicalStdL3DataTableAL_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAL_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAL_AIM
            // 
            this.coldsChemicalStdL3DataTableAL_AIM.Caption = "AL_AIM";
            this.coldsChemicalStdL3DataTableAL_AIM.ColumnName = "AL_AIM";
            this.coldsChemicalStdL3DataTableAL_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAL_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAL_MAX
            // 
            this.coldsChemicalStdL3DataTableAL_MAX.Caption = "AL_MAX";
            this.coldsChemicalStdL3DataTableAL_MAX.ColumnName = "AL_MAX";
            this.coldsChemicalStdL3DataTableAL_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAL_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableALS_MIN
            // 
            this.coldsChemicalStdL3DataTableALS_MIN.Caption = "ALS_MIN";
            this.coldsChemicalStdL3DataTableALS_MIN.ColumnName = "ALS_MIN";
            this.coldsChemicalStdL3DataTableALS_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableALS_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableALS_AIM
            // 
            this.coldsChemicalStdL3DataTableALS_AIM.Caption = "ALS_AIM";
            this.coldsChemicalStdL3DataTableALS_AIM.ColumnName = "ALS_AIM";
            this.coldsChemicalStdL3DataTableALS_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableALS_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableALS_MAX
            // 
            this.coldsChemicalStdL3DataTableALS_MAX.Caption = "ALS_MAX";
            this.coldsChemicalStdL3DataTableALS_MAX.ColumnName = "ALS_MAX";
            this.coldsChemicalStdL3DataTableALS_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableALS_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTI_MIN
            // 
            this.coldsChemicalStdL3DataTableTI_MIN.Caption = "TI_MIN";
            this.coldsChemicalStdL3DataTableTI_MIN.ColumnName = "TI_MIN";
            this.coldsChemicalStdL3DataTableTI_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableTI_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTI_AIM
            // 
            this.coldsChemicalStdL3DataTableTI_AIM.Caption = "TI_AIM";
            this.coldsChemicalStdL3DataTableTI_AIM.ColumnName = "TI_AIM";
            this.coldsChemicalStdL3DataTableTI_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableTI_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableTI_MAX
            // 
            this.coldsChemicalStdL3DataTableTI_MAX.Caption = "TI_MAX";
            this.coldsChemicalStdL3DataTableTI_MAX.ColumnName = "TI_MAX";
            this.coldsChemicalStdL3DataTableTI_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableTI_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_MIN
            // 
            this.coldsChemicalStdL3DataTableB_MIN.Caption = "B_MIN";
            this.coldsChemicalStdL3DataTableB_MIN.ColumnName = "B_MIN";
            this.coldsChemicalStdL3DataTableB_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableB_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_AIM
            // 
            this.coldsChemicalStdL3DataTableB_AIM.Caption = "B_AIM";
            this.coldsChemicalStdL3DataTableB_AIM.ColumnName = "B_AIM";
            this.coldsChemicalStdL3DataTableB_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableB_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableB_MAX
            // 
            this.coldsChemicalStdL3DataTableB_MAX.Caption = "B_MAX";
            this.coldsChemicalStdL3DataTableB_MAX.ColumnName = "B_MAX";
            this.coldsChemicalStdL3DataTableB_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableB_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSB_MIN
            // 
            this.coldsChemicalStdL3DataTableSB_MIN.Caption = "SB_MIN";
            this.coldsChemicalStdL3DataTableSB_MIN.ColumnName = "SB_MIN";
            this.coldsChemicalStdL3DataTableSB_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSB_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSB_AIM
            // 
            this.coldsChemicalStdL3DataTableSB_AIM.Caption = "SB_AIM";
            this.coldsChemicalStdL3DataTableSB_AIM.ColumnName = "SB_AIM";
            this.coldsChemicalStdL3DataTableSB_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSB_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSB_MAX
            // 
            this.coldsChemicalStdL3DataTableSB_MAX.Caption = "SB_MAX";
            this.coldsChemicalStdL3DataTableSB_MAX.ColumnName = "SB_MAX";
            this.coldsChemicalStdL3DataTableSB_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSB_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSN_MIN
            // 
            this.coldsChemicalStdL3DataTableSN_MIN.Caption = "SN_MIN";
            this.coldsChemicalStdL3DataTableSN_MIN.ColumnName = "SN_MIN";
            this.coldsChemicalStdL3DataTableSN_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSN_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSN_AIM
            // 
            this.coldsChemicalStdL3DataTableSN_AIM.Caption = "SN_AIM";
            this.coldsChemicalStdL3DataTableSN_AIM.ColumnName = "SN_AIM";
            this.coldsChemicalStdL3DataTableSN_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSN_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableSN_MAX
            // 
            this.coldsChemicalStdL3DataTableSN_MAX.Caption = "SN_MAX";
            this.coldsChemicalStdL3DataTableSN_MAX.ColumnName = "SN_MAX";
            this.coldsChemicalStdL3DataTableSN_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableSN_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAS_MIN
            // 
            this.coldsChemicalStdL3DataTableAS_MIN.Caption = "AS_MIN";
            this.coldsChemicalStdL3DataTableAS_MIN.ColumnName = "AS_MIN";
            this.coldsChemicalStdL3DataTableAS_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAS_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAS_AIM
            // 
            this.coldsChemicalStdL3DataTableAS_AIM.Caption = "AS_AIM";
            this.coldsChemicalStdL3DataTableAS_AIM.ColumnName = "AS_AIM";
            this.coldsChemicalStdL3DataTableAS_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAS_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableAS_MAX
            // 
            this.coldsChemicalStdL3DataTableAS_MAX.Caption = "AS_MAX";
            this.coldsChemicalStdL3DataTableAS_MAX.ColumnName = "AS_MAX";
            this.coldsChemicalStdL3DataTableAS_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableAS_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZN_MIN
            // 
            this.coldsChemicalStdL3DataTableZN_MIN.Caption = "ZN_MIN";
            this.coldsChemicalStdL3DataTableZN_MIN.ColumnName = "ZN_MIN";
            this.coldsChemicalStdL3DataTableZN_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZN_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZN_AIM
            // 
            this.coldsChemicalStdL3DataTableZN_AIM.Caption = "ZN_AIM";
            this.coldsChemicalStdL3DataTableZN_AIM.ColumnName = "ZN_AIM";
            this.coldsChemicalStdL3DataTableZN_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZN_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZN_MAX
            // 
            this.coldsChemicalStdL3DataTableZN_MAX.Caption = "ZN_MAX";
            this.coldsChemicalStdL3DataTableZN_MAX.ColumnName = "ZN_MAX";
            this.coldsChemicalStdL3DataTableZN_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZN_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZR_MIN
            // 
            this.coldsChemicalStdL3DataTableZR_MIN.Caption = "ZR_MIN";
            this.coldsChemicalStdL3DataTableZR_MIN.ColumnName = "ZR_MIN";
            this.coldsChemicalStdL3DataTableZR_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZR_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZR_AIM
            // 
            this.coldsChemicalStdL3DataTableZR_AIM.Caption = "ZR_AIM";
            this.coldsChemicalStdL3DataTableZR_AIM.ColumnName = "ZR_AIM";
            this.coldsChemicalStdL3DataTableZR_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZR_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableZR_MAX
            // 
            this.coldsChemicalStdL3DataTableZR_MAX.Caption = "ZR_MAX";
            this.coldsChemicalStdL3DataTableZR_MAX.ColumnName = "ZR_MAX";
            this.coldsChemicalStdL3DataTableZR_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableZR_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCA_MIN
            // 
            this.coldsChemicalStdL3DataTableCA_MIN.Caption = "CA_MIN";
            this.coldsChemicalStdL3DataTableCA_MIN.ColumnName = "CA_MIN";
            this.coldsChemicalStdL3DataTableCA_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCA_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCA_AIM
            // 
            this.coldsChemicalStdL3DataTableCA_AIM.Caption = "CA_AIM";
            this.coldsChemicalStdL3DataTableCA_AIM.ColumnName = "CA_AIM";
            this.coldsChemicalStdL3DataTableCA_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCA_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCA_MAX
            // 
            this.coldsChemicalStdL3DataTableCA_MAX.Caption = "CA_MAX";
            this.coldsChemicalStdL3DataTableCA_MAX.ColumnName = "CA_MAX";
            this.coldsChemicalStdL3DataTableCA_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCA_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_MIN
            // 
            this.coldsChemicalStdL3DataTableW_MIN.Caption = "W_MIN";
            this.coldsChemicalStdL3DataTableW_MIN.ColumnName = "W_MIN";
            this.coldsChemicalStdL3DataTableW_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableW_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_AIM
            // 
            this.coldsChemicalStdL3DataTableW_AIM.Caption = "W_AIM";
            this.coldsChemicalStdL3DataTableW_AIM.ColumnName = "W_AIM";
            this.coldsChemicalStdL3DataTableW_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableW_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableW_MAX
            // 
            this.coldsChemicalStdL3DataTableW_MAX.Caption = "W_MAX";
            this.coldsChemicalStdL3DataTableW_MAX.ColumnName = "W_MAX";
            this.coldsChemicalStdL3DataTableW_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableW_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePB_MIN
            // 
            this.coldsChemicalStdL3DataTablePB_MIN.Caption = "PB_MIN";
            this.coldsChemicalStdL3DataTablePB_MIN.ColumnName = "PB_MIN";
            this.coldsChemicalStdL3DataTablePB_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTablePB_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePB_AIM
            // 
            this.coldsChemicalStdL3DataTablePB_AIM.Caption = "PB_AIM";
            this.coldsChemicalStdL3DataTablePB_AIM.ColumnName = "PB_AIM";
            this.coldsChemicalStdL3DataTablePB_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTablePB_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTablePB_MAX
            // 
            this.coldsChemicalStdL3DataTablePB_MAX.Caption = "PB_MAX";
            this.coldsChemicalStdL3DataTablePB_MAX.ColumnName = "PB_MAX";
            this.coldsChemicalStdL3DataTablePB_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTablePB_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRE_MIN
            // 
            this.coldsChemicalStdL3DataTableRE_MIN.Caption = "RE_MIN";
            this.coldsChemicalStdL3DataTableRE_MIN.ColumnName = "RE_MIN";
            this.coldsChemicalStdL3DataTableRE_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableRE_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRE_AIM
            // 
            this.coldsChemicalStdL3DataTableRE_AIM.Caption = "RE_AIM";
            this.coldsChemicalStdL3DataTableRE_AIM.ColumnName = "RE_AIM";
            this.coldsChemicalStdL3DataTableRE_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableRE_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableRE_MAX
            // 
            this.coldsChemicalStdL3DataTableRE_MAX.Caption = "RE_MAX";
            this.coldsChemicalStdL3DataTableRE_MAX.ColumnName = "RE_MAX";
            this.coldsChemicalStdL3DataTableRE_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableRE_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCEQ_MIN
            // 
            this.coldsChemicalStdL3DataTableCEQ_MIN.Caption = "CEQ_MIN";
            this.coldsChemicalStdL3DataTableCEQ_MIN.ColumnName = "CEQ_MIN";
            this.coldsChemicalStdL3DataTableCEQ_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCEQ_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCEQ_AIM
            // 
            this.coldsChemicalStdL3DataTableCEQ_AIM.Caption = "CEQ_AIM";
            this.coldsChemicalStdL3DataTableCEQ_AIM.ColumnName = "CEQ_AIM";
            this.coldsChemicalStdL3DataTableCEQ_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCEQ_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableCEQ_MAX
            // 
            this.coldsChemicalStdL3DataTableCEQ_MAX.Caption = "CEQ_MAX";
            this.coldsChemicalStdL3DataTableCEQ_MAX.ColumnName = "CEQ_MAX";
            this.coldsChemicalStdL3DataTableCEQ_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableCEQ_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_MIN
            // 
            this.coldsChemicalStdL3DataTableN_MIN.Caption = "N_MIN";
            this.coldsChemicalStdL3DataTableN_MIN.ColumnName = "N_MIN";
            this.coldsChemicalStdL3DataTableN_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableN_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_AIM
            // 
            this.coldsChemicalStdL3DataTableN_AIM.Caption = "N_AIM";
            this.coldsChemicalStdL3DataTableN_AIM.ColumnName = "N_AIM";
            this.coldsChemicalStdL3DataTableN_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableN_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableN_MAX
            // 
            this.coldsChemicalStdL3DataTableN_MAX.Caption = "N_MAX";
            this.coldsChemicalStdL3DataTableN_MAX.ColumnName = "N_MAX";
            this.coldsChemicalStdL3DataTableN_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableN_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_MIN
            // 
            this.coldsChemicalStdL3DataTableH_MIN.Caption = "H_MIN";
            this.coldsChemicalStdL3DataTableH_MIN.ColumnName = "H_MIN";
            this.coldsChemicalStdL3DataTableH_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableH_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_AIM
            // 
            this.coldsChemicalStdL3DataTableH_AIM.Caption = "H_AIM";
            this.coldsChemicalStdL3DataTableH_AIM.ColumnName = "H_AIM";
            this.coldsChemicalStdL3DataTableH_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableH_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableH_MAX
            // 
            this.coldsChemicalStdL3DataTableH_MAX.Caption = "H_MAX";
            this.coldsChemicalStdL3DataTableH_MAX.ColumnName = "H_MAX";
            this.coldsChemicalStdL3DataTableH_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableH_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_MIN
            // 
            this.coldsChemicalStdL3DataTableO_MIN.Caption = "O_MIN";
            this.coldsChemicalStdL3DataTableO_MIN.ColumnName = "O_MIN";
            this.coldsChemicalStdL3DataTableO_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableO_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_AIM
            // 
            this.coldsChemicalStdL3DataTableO_AIM.Caption = "O_AIM";
            this.coldsChemicalStdL3DataTableO_AIM.ColumnName = "O_AIM";
            this.coldsChemicalStdL3DataTableO_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableO_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableO_MAX
            // 
            this.coldsChemicalStdL3DataTableO_MAX.Caption = "O_MAX";
            this.coldsChemicalStdL3DataTableO_MAX.ColumnName = "O_MAX";
            this.coldsChemicalStdL3DataTableO_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableO_MAX.Namespace = "";
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
            // coldsChemicalStdL3DataTableOTHER1_MIN
            // 
            this.coldsChemicalStdL3DataTableOTHER1_MIN.Caption = "OTHER1_MIN";
            this.coldsChemicalStdL3DataTableOTHER1_MIN.ColumnName = "OTHER1_MIN";
            this.coldsChemicalStdL3DataTableOTHER1_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER1_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOTHER1_AIM
            // 
            this.coldsChemicalStdL3DataTableOTHER1_AIM.Caption = "OTHER1_AIM";
            this.coldsChemicalStdL3DataTableOTHER1_AIM.ColumnName = "OTHER1_AIM";
            this.coldsChemicalStdL3DataTableOTHER1_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER1_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOTHER1_MAX
            // 
            this.coldsChemicalStdL3DataTableOTHER1_MAX.Caption = "OTHER1_MAX";
            this.coldsChemicalStdL3DataTableOTHER1_MAX.ColumnName = "OTHER1_MAX";
            this.coldsChemicalStdL3DataTableOTHER1_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER1_MAX.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOTHER2_MIN
            // 
            this.coldsChemicalStdL3DataTableOTHER2_MIN.Caption = "OTHER2_MIN";
            this.coldsChemicalStdL3DataTableOTHER2_MIN.ColumnName = "OTHER2_MIN";
            this.coldsChemicalStdL3DataTableOTHER2_MIN.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER2_MIN.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOTHER2_AIM
            // 
            this.coldsChemicalStdL3DataTableOTHER2_AIM.Caption = "OTHER2_AIM";
            this.coldsChemicalStdL3DataTableOTHER2_AIM.ColumnName = "OTHER2_AIM";
            this.coldsChemicalStdL3DataTableOTHER2_AIM.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER2_AIM.Namespace = "";
            // 
            // coldsChemicalStdL3DataTableOTHER2_MAX
            // 
            this.coldsChemicalStdL3DataTableOTHER2_MAX.Caption = "OTHER2_MAX";
            this.coldsChemicalStdL3DataTableOTHER2_MAX.ColumnName = "OTHER2_MAX";
            this.coldsChemicalStdL3DataTableOTHER2_MAX.DefaultValue = "0";
            this.coldsChemicalStdL3DataTableOTHER2_MAX.Namespace = "";
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
            // lblReMin
            // 
            lblReMin.AutoSize = true;
            lblReMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.RE_MIN", true));
            lblReMin.Location = new System.Drawing.Point(367, 170);
            lblReMin.Name = "lblReMin";
            lblReMin.Size = new System.Drawing.Size(23, 12);
            lblReMin.TabIndex = 106;
            lblReMin.Text = "XXX";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other2_Max", true));
            label36.Location = new System.Drawing.Point(772, 194);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(23, 12);
            label36.TabIndex = 128;
            label36.Text = "XXX";
            // 
            // bsHeatID
            // 
            this.bsHeatID.DataMember = "L3DataTable";
            this.bsHeatID.DataSource = this.dsHeatID;
            // 
            // dsHeatID
            // 
            this.dsHeatID.AutoLoad = true;
            this.dsHeatID.AutoSubscribe = false;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = "";
            this.dsHeatID.InsertMethod = "";
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "Click";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = this.cmdHeatID;
            this.dsHeatID.SourceCondition = null;
            this.dsHeatID.SourceMethod = "GetBofSteelJudgeHeat";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.dsHeatID.SubscribeTarget = "";
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatID});
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = "";
            this.dsHeatID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsHeatID
            // 
            this.schemadsHeatID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatIDL3DataTableHEATID});
            this.schemadsHeatID.TableName = "L3DataTable";
            // 
            // coldsHeatIDL3DataTableHEATID
            // 
            this.coldsHeatIDL3DataTableHEATID.Caption = "HeatID";
            this.coldsHeatIDL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsHeatIDL3DataTableHEATID.DefaultValue = "";
            this.coldsHeatIDL3DataTableHEATID.Namespace = "";
            // 
            // cmdHeatID
            // 
            this.cmdHeatID.Adapter = null;
            this.cmdHeatID.MergeReturnTarget = false;
            this.cmdHeatID.Method = "GetBofSteelJudgeHeat";
            this.cmdHeatID.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdHeatID.ReturnTarget = null;
            this.cmdHeatID.ReturnTargetProperty = null;
            this.cmdHeatID.Trigger = null;
            this.cmdHeatID.TriggerEvent = "Click";
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
            this.dsHeatGrade.L3DataAdapter = null;
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
            this.dsRefineThirdEle.L3DataAdapter = null;
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
            this.cmdRefineThirdEle.Parameters.Add(this.l3CommandParameter9);
            this.cmdRefineThirdEle.ReturnTarget = null;
            this.cmdRefineThirdEle.ReturnTargetProperty = null;
            this.cmdRefineThirdEle.Trigger = null;
            this.cmdRefineThirdEle.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // schemadsRefineThirdEle
            // 
            this.schemadsRefineThirdEle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefineThirdEleL3DataTableAPPID,
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE,
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE,
            this.coldsRefineThirdEleL3DataTableREPORT_DATE,
            this.coldsRefineThirdEleL3DataTableHEATID,
            this.coldsRefineThirdEleL3DataTableUNITTYPEID,
            this.coldsRefineThirdEleL3DataTableUNITID,
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS,
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE,
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT,
            this.coldsRefineThirdEleL3DataTableC,
            this.coldsRefineThirdEleL3DataTableSI,
            this.coldsRefineThirdEleL3DataTableMN,
            this.coldsRefineThirdEleL3DataTableP,
            this.coldsRefineThirdEleL3DataTableS,
            this.coldsRefineThirdEleL3DataTableCU,
            this.coldsRefineThirdEleL3DataTableNI,
            this.coldsRefineThirdEleL3DataTableCR,
            this.coldsRefineThirdEleL3DataTableMO,
            this.coldsRefineThirdEleL3DataTableV,
            this.coldsRefineThirdEleL3DataTableNB,
            this.coldsRefineThirdEleL3DataTableAL,
            this.coldsRefineThirdEleL3DataTableALS,
            this.coldsRefineThirdEleL3DataTableTI,
            this.coldsRefineThirdEleL3DataTableB,
            this.coldsRefineThirdEleL3DataTableSB,
            this.coldsRefineThirdEleL3DataTableAS,
            this.coldsRefineThirdEleL3DataTableSN,
            this.coldsRefineThirdEleL3DataTableZN,
            this.coldsRefineThirdEleL3DataTableCA,
            this.coldsRefineThirdEleL3DataTableW,
            this.coldsRefineThirdEleL3DataTablePB,
            this.coldsRefineThirdEleL3DataTableRE,
            this.coldsRefineThirdEleL3DataTableCEQ,
            this.coldsRefineThirdEleL3DataTableN,
            this.coldsRefineThirdEleL3DataTableH,
            this.coldsRefineThirdEleL3DataTableO,
            this.coldsRefineThirdEleL3DataTableCrNi,
            this.coldsRefineThirdEleL3DataTableCrCu,
            this.coldsRefineThirdEleL3DataTableCrNiCu,
            this.coldsRefineThirdEleL3DataTableOTHER1,
            this.coldsRefineThirdEleL3DataTableOTHER2,
            this.coldsRefineThirdEleL3DataTableOther3,
            this.coldsRefineThirdEleL3DataTableLOGTIME,
            this.coldsRefineThirdEleL3DataTableDATALOGMODE,
            this.coldsRefineThirdEleL3DataTableCheckFlag});
            this.schemadsRefineThirdEle.TableName = "L3DataTable";
            // 
            // coldsRefineThirdEleL3DataTableAPPID
            // 
            this.coldsRefineThirdEleL3DataTableAPPID.Caption = "APPID";
            this.coldsRefineThirdEleL3DataTableAPPID.ColumnName = "APPID";
            this.coldsRefineThirdEleL3DataTableAPPID.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableAPPID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSAMPLE_CODE
            // 
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE.Caption = "SAMPLE_CODE";
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE.ColumnName = "SAMPLE_CODE";
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableSAMPLE_CODE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableARRIVE_DATE
            // 
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE.Caption = "ARRIVE_DATE";
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE.ColumnName = "ARRIVE_DATE";
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableARRIVE_DATE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableREPORT_DATE
            // 
            this.coldsRefineThirdEleL3DataTableREPORT_DATE.Caption = "REPORT_DATE";
            this.coldsRefineThirdEleL3DataTableREPORT_DATE.ColumnName = "REPORT_DATE";
            this.coldsRefineThirdEleL3DataTableREPORT_DATE.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableREPORT_DATE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableHEATID
            // 
            this.coldsRefineThirdEleL3DataTableHEATID.Caption = "HEATID";
            this.coldsRefineThirdEleL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsRefineThirdEleL3DataTableHEATID.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableHEATID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableUNITTYPEID
            // 
            this.coldsRefineThirdEleL3DataTableUNITTYPEID.Caption = "UNITTYPEID";
            this.coldsRefineThirdEleL3DataTableUNITTYPEID.ColumnName = "UNITTYPEID";
            this.coldsRefineThirdEleL3DataTableUNITTYPEID.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableUNITTYPEID.DefaultValue = 0;
            this.coldsRefineThirdEleL3DataTableUNITTYPEID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableUNITID
            // 
            this.coldsRefineThirdEleL3DataTableUNITID.Caption = "UNITID";
            this.coldsRefineThirdEleL3DataTableUNITID.ColumnName = "UNITID";
            this.coldsRefineThirdEleL3DataTableUNITID.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableUNITID.DefaultValue = 0;
            this.coldsRefineThirdEleL3DataTableUNITID.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS
            // 
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS.Caption = "SAMPLE_ADDRESS";
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS.ColumnName = "SAMPLE_ADDRESS";
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSAMPLE_TYPE
            // 
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE.Caption = "SAMPLE_TYPE";
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE.ColumnName = "SAMPLE_TYPE";
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableSAMPLE_TYPE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSAMPLE_COUNT
            // 
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT.Caption = "SAMPLE_COUNT";
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT.ColumnName = "SAMPLE_COUNT";
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT.DefaultValue = "";
            this.coldsRefineThirdEleL3DataTableSAMPLE_COUNT.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableC
            // 
            this.coldsRefineThirdEleL3DataTableC.Caption = "C";
            this.coldsRefineThirdEleL3DataTableC.ColumnName = "C";
            this.coldsRefineThirdEleL3DataTableC.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableC.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSI
            // 
            this.coldsRefineThirdEleL3DataTableSI.Caption = "SI";
            this.coldsRefineThirdEleL3DataTableSI.ColumnName = "SI";
            this.coldsRefineThirdEleL3DataTableSI.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableSI.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableMN
            // 
            this.coldsRefineThirdEleL3DataTableMN.Caption = "MN";
            this.coldsRefineThirdEleL3DataTableMN.ColumnName = "MN";
            this.coldsRefineThirdEleL3DataTableMN.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableMN.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableP
            // 
            this.coldsRefineThirdEleL3DataTableP.Caption = "P";
            this.coldsRefineThirdEleL3DataTableP.ColumnName = "P";
            this.coldsRefineThirdEleL3DataTableP.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableP.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableS
            // 
            this.coldsRefineThirdEleL3DataTableS.Caption = "S";
            this.coldsRefineThirdEleL3DataTableS.ColumnName = "S";
            this.coldsRefineThirdEleL3DataTableS.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCU
            // 
            this.coldsRefineThirdEleL3DataTableCU.Caption = "CU";
            this.coldsRefineThirdEleL3DataTableCU.ColumnName = "CU";
            this.coldsRefineThirdEleL3DataTableCU.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableCU.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableNI
            // 
            this.coldsRefineThirdEleL3DataTableNI.Caption = "NI";
            this.coldsRefineThirdEleL3DataTableNI.ColumnName = "NI";
            this.coldsRefineThirdEleL3DataTableNI.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableNI.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCR
            // 
            this.coldsRefineThirdEleL3DataTableCR.Caption = "CR";
            this.coldsRefineThirdEleL3DataTableCR.ColumnName = "CR";
            this.coldsRefineThirdEleL3DataTableCR.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableCR.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableMO
            // 
            this.coldsRefineThirdEleL3DataTableMO.Caption = "MO";
            this.coldsRefineThirdEleL3DataTableMO.ColumnName = "MO";
            this.coldsRefineThirdEleL3DataTableMO.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableMO.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableV
            // 
            this.coldsRefineThirdEleL3DataTableV.Caption = "V";
            this.coldsRefineThirdEleL3DataTableV.ColumnName = "V";
            this.coldsRefineThirdEleL3DataTableV.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableV.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableNB
            // 
            this.coldsRefineThirdEleL3DataTableNB.Caption = "NB";
            this.coldsRefineThirdEleL3DataTableNB.ColumnName = "NB";
            this.coldsRefineThirdEleL3DataTableNB.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableNB.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAL
            // 
            this.coldsRefineThirdEleL3DataTableAL.Caption = "AL";
            this.coldsRefineThirdEleL3DataTableAL.ColumnName = "AL";
            this.coldsRefineThirdEleL3DataTableAL.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableAL.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableALS
            // 
            this.coldsRefineThirdEleL3DataTableALS.Caption = "ALS";
            this.coldsRefineThirdEleL3DataTableALS.ColumnName = "ALS";
            this.coldsRefineThirdEleL3DataTableALS.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableALS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableTI
            // 
            this.coldsRefineThirdEleL3DataTableTI.Caption = "TI";
            this.coldsRefineThirdEleL3DataTableTI.ColumnName = "TI";
            this.coldsRefineThirdEleL3DataTableTI.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableTI.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableB
            // 
            this.coldsRefineThirdEleL3DataTableB.Caption = "B";
            this.coldsRefineThirdEleL3DataTableB.ColumnName = "B";
            this.coldsRefineThirdEleL3DataTableB.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableB.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSB
            // 
            this.coldsRefineThirdEleL3DataTableSB.Caption = "SB";
            this.coldsRefineThirdEleL3DataTableSB.ColumnName = "SB";
            this.coldsRefineThirdEleL3DataTableSB.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableSB.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableAS
            // 
            this.coldsRefineThirdEleL3DataTableAS.Caption = "AS";
            this.coldsRefineThirdEleL3DataTableAS.ColumnName = "AS";
            this.coldsRefineThirdEleL3DataTableAS.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableAS.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableSN
            // 
            this.coldsRefineThirdEleL3DataTableSN.Caption = "SN";
            this.coldsRefineThirdEleL3DataTableSN.ColumnName = "SN";
            this.coldsRefineThirdEleL3DataTableSN.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableSN.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableZN
            // 
            this.coldsRefineThirdEleL3DataTableZN.Caption = "ZN";
            this.coldsRefineThirdEleL3DataTableZN.ColumnName = "ZN";
            this.coldsRefineThirdEleL3DataTableZN.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableZN.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCA
            // 
            this.coldsRefineThirdEleL3DataTableCA.Caption = "CA";
            this.coldsRefineThirdEleL3DataTableCA.ColumnName = "CA";
            this.coldsRefineThirdEleL3DataTableCA.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableCA.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableW
            // 
            this.coldsRefineThirdEleL3DataTableW.Caption = "W";
            this.coldsRefineThirdEleL3DataTableW.ColumnName = "W";
            this.coldsRefineThirdEleL3DataTableW.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableW.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTablePB
            // 
            this.coldsRefineThirdEleL3DataTablePB.Caption = "PB";
            this.coldsRefineThirdEleL3DataTablePB.ColumnName = "PB";
            this.coldsRefineThirdEleL3DataTablePB.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTablePB.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableRE
            // 
            this.coldsRefineThirdEleL3DataTableRE.Caption = "RE";
            this.coldsRefineThirdEleL3DataTableRE.ColumnName = "RE";
            this.coldsRefineThirdEleL3DataTableRE.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableRE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCEQ
            // 
            this.coldsRefineThirdEleL3DataTableCEQ.Caption = "CEQ";
            this.coldsRefineThirdEleL3DataTableCEQ.ColumnName = "CEQ";
            this.coldsRefineThirdEleL3DataTableCEQ.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableCEQ.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableN
            // 
            this.coldsRefineThirdEleL3DataTableN.Caption = "N";
            this.coldsRefineThirdEleL3DataTableN.ColumnName = "N";
            this.coldsRefineThirdEleL3DataTableN.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableN.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableH
            // 
            this.coldsRefineThirdEleL3DataTableH.Caption = "H";
            this.coldsRefineThirdEleL3DataTableH.ColumnName = "H";
            this.coldsRefineThirdEleL3DataTableH.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableH.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableO
            // 
            this.coldsRefineThirdEleL3DataTableO.Caption = "O";
            this.coldsRefineThirdEleL3DataTableO.ColumnName = "O";
            this.coldsRefineThirdEleL3DataTableO.DefaultValue = "0";
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
            // coldsRefineThirdEleL3DataTableOTHER1
            // 
            this.coldsRefineThirdEleL3DataTableOTHER1.Caption = "OTHER1";
            this.coldsRefineThirdEleL3DataTableOTHER1.ColumnName = "OTHER1";
            this.coldsRefineThirdEleL3DataTableOTHER1.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableOTHER1.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOTHER2
            // 
            this.coldsRefineThirdEleL3DataTableOTHER2.Caption = "OTHER2";
            this.coldsRefineThirdEleL3DataTableOTHER2.ColumnName = "OTHER2";
            this.coldsRefineThirdEleL3DataTableOTHER2.DefaultValue = "0";
            this.coldsRefineThirdEleL3DataTableOTHER2.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableOther3
            // 
            this.coldsRefineThirdEleL3DataTableOther3.Caption = "Other3";
            this.coldsRefineThirdEleL3DataTableOther3.ColumnName = "Other3";
            this.coldsRefineThirdEleL3DataTableOther3.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableLOGTIME
            // 
            this.coldsRefineThirdEleL3DataTableLOGTIME.Caption = "LOGTIME";
            this.coldsRefineThirdEleL3DataTableLOGTIME.ColumnName = "LOGTIME";
            this.coldsRefineThirdEleL3DataTableLOGTIME.DataType = typeof(System.DateTime);
            this.coldsRefineThirdEleL3DataTableLOGTIME.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableDATALOGMODE
            // 
            this.coldsRefineThirdEleL3DataTableDATALOGMODE.Caption = "DATALOGMODE";
            this.coldsRefineThirdEleL3DataTableDATALOGMODE.ColumnName = "DATALOGMODE";
            this.coldsRefineThirdEleL3DataTableDATALOGMODE.DataType = typeof(int);
            this.coldsRefineThirdEleL3DataTableDATALOGMODE.DefaultValue = 0;
            this.coldsRefineThirdEleL3DataTableDATALOGMODE.Namespace = "";
            // 
            // coldsRefineThirdEleL3DataTableCheckFlag
            // 
            this.coldsRefineThirdEleL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsRefineThirdEleL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsRefineThirdEleL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsRefineThirdEleL3DataTableCheckFlag.Namespace = "";
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
            this.cmdFinalChemical.Parameters.Add(this.l3CommandParameter8);
            this.cmdFinalChemical.ReturnTarget = null;
            this.cmdFinalChemical.ReturnTargetProperty = null;
            this.cmdFinalChemical.Trigger = null;
            this.cmdFinalChemical.TriggerEvent = "Click";
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
            // schemadsFinalChemical
            // 
            this.schemadsFinalChemical.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFinalChemicalL3DataTableAPPID,
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE,
            this.coldsFinalChemicalL3DataTableARRIVE_DATE,
            this.coldsFinalChemicalL3DataTableREPORT_DATE,
            this.coldsFinalChemicalL3DataTableHEATID,
            this.coldsFinalChemicalL3DataTableUNITTYPEID,
            this.coldsFinalChemicalL3DataTableUNITID,
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS,
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE,
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT,
            this.coldsFinalChemicalL3DataTableC,
            this.coldsFinalChemicalL3DataTableSI,
            this.coldsFinalChemicalL3DataTableMN,
            this.coldsFinalChemicalL3DataTableP,
            this.coldsFinalChemicalL3DataTableS,
            this.coldsFinalChemicalL3DataTableCU,
            this.coldsFinalChemicalL3DataTableNI,
            this.coldsFinalChemicalL3DataTableCR,
            this.coldsFinalChemicalL3DataTableMO,
            this.coldsFinalChemicalL3DataTableV,
            this.coldsFinalChemicalL3DataTableNB,
            this.coldsFinalChemicalL3DataTableAL,
            this.coldsFinalChemicalL3DataTableALS,
            this.coldsFinalChemicalL3DataTableTI,
            this.coldsFinalChemicalL3DataTableB,
            this.coldsFinalChemicalL3DataTableSB,
            this.coldsFinalChemicalL3DataTableAS,
            this.coldsFinalChemicalL3DataTableSN,
            this.coldsFinalChemicalL3DataTableZN,
            this.coldsFinalChemicalL3DataTableCA,
            this.coldsFinalChemicalL3DataTableW,
            this.coldsFinalChemicalL3DataTablePB,
            this.coldsFinalChemicalL3DataTableRE,
            this.coldsFinalChemicalL3DataTableCEQ,
            this.coldsFinalChemicalL3DataTableN,
            this.coldsFinalChemicalL3DataTableH,
            this.coldsFinalChemicalL3DataTableO,
            this.coldsFinalChemicalL3DataTableCrNi,
            this.coldsFinalChemicalL3DataTableCrCu,
            this.coldsFinalChemicalL3DataTableCrNiCu,
            this.coldsFinalChemicalL3DataTableOTHER1,
            this.coldsFinalChemicalL3DataTableOTHER2,
            this.coldsFinalChemicalL3DataTableOther3,
            this.coldsFinalChemicalL3DataTableLOGTIME,
            this.coldsFinalChemicalL3DataTableDATALOGMODE,
            this.coldsFinalChemicalL3DataTableCheckFlag});
            this.schemadsFinalChemical.TableName = "L3DataTable";
            // 
            // coldsFinalChemicalL3DataTableAPPID
            // 
            this.coldsFinalChemicalL3DataTableAPPID.Caption = "APPID";
            this.coldsFinalChemicalL3DataTableAPPID.ColumnName = "APPID";
            this.coldsFinalChemicalL3DataTableAPPID.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableAPPID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSAMPLE_CODE
            // 
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE.Caption = "SAMPLE_CODE";
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE.ColumnName = "SAMPLE_CODE";
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableSAMPLE_CODE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableARRIVE_DATE
            // 
            this.coldsFinalChemicalL3DataTableARRIVE_DATE.Caption = "ARRIVE_DATE";
            this.coldsFinalChemicalL3DataTableARRIVE_DATE.ColumnName = "ARRIVE_DATE";
            this.coldsFinalChemicalL3DataTableARRIVE_DATE.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableARRIVE_DATE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableREPORT_DATE
            // 
            this.coldsFinalChemicalL3DataTableREPORT_DATE.Caption = "REPORT_DATE";
            this.coldsFinalChemicalL3DataTableREPORT_DATE.ColumnName = "REPORT_DATE";
            this.coldsFinalChemicalL3DataTableREPORT_DATE.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableREPORT_DATE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableHEATID
            // 
            this.coldsFinalChemicalL3DataTableHEATID.Caption = "HEATID";
            this.coldsFinalChemicalL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsFinalChemicalL3DataTableHEATID.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableHEATID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableUNITTYPEID
            // 
            this.coldsFinalChemicalL3DataTableUNITTYPEID.Caption = "UNITTYPEID";
            this.coldsFinalChemicalL3DataTableUNITTYPEID.ColumnName = "UNITTYPEID";
            this.coldsFinalChemicalL3DataTableUNITTYPEID.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableUNITTYPEID.DefaultValue = 0;
            this.coldsFinalChemicalL3DataTableUNITTYPEID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableUNITID
            // 
            this.coldsFinalChemicalL3DataTableUNITID.Caption = "UNITID";
            this.coldsFinalChemicalL3DataTableUNITID.ColumnName = "UNITID";
            this.coldsFinalChemicalL3DataTableUNITID.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableUNITID.DefaultValue = 0;
            this.coldsFinalChemicalL3DataTableUNITID.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSAMPLE_ADDRESS
            // 
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS.Caption = "SAMPLE_ADDRESS";
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS.ColumnName = "SAMPLE_ADDRESS";
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableSAMPLE_ADDRESS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSAMPLE_TYPE
            // 
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE.Caption = "SAMPLE_TYPE";
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE.ColumnName = "SAMPLE_TYPE";
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableSAMPLE_TYPE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSAMPLE_COUNT
            // 
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT.Caption = "SAMPLE_COUNT";
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT.ColumnName = "SAMPLE_COUNT";
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT.DefaultValue = "";
            this.coldsFinalChemicalL3DataTableSAMPLE_COUNT.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableC
            // 
            this.coldsFinalChemicalL3DataTableC.Caption = "C";
            this.coldsFinalChemicalL3DataTableC.ColumnName = "C";
            this.coldsFinalChemicalL3DataTableC.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableC.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSI
            // 
            this.coldsFinalChemicalL3DataTableSI.Caption = "SI";
            this.coldsFinalChemicalL3DataTableSI.ColumnName = "SI";
            this.coldsFinalChemicalL3DataTableSI.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableSI.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableMN
            // 
            this.coldsFinalChemicalL3DataTableMN.Caption = "MN";
            this.coldsFinalChemicalL3DataTableMN.ColumnName = "MN";
            this.coldsFinalChemicalL3DataTableMN.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableMN.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableP
            // 
            this.coldsFinalChemicalL3DataTableP.Caption = "P";
            this.coldsFinalChemicalL3DataTableP.ColumnName = "P";
            this.coldsFinalChemicalL3DataTableP.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableP.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableS
            // 
            this.coldsFinalChemicalL3DataTableS.Caption = "S";
            this.coldsFinalChemicalL3DataTableS.ColumnName = "S";
            this.coldsFinalChemicalL3DataTableS.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCU
            // 
            this.coldsFinalChemicalL3DataTableCU.Caption = "CU";
            this.coldsFinalChemicalL3DataTableCU.ColumnName = "CU";
            this.coldsFinalChemicalL3DataTableCU.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableCU.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableNI
            // 
            this.coldsFinalChemicalL3DataTableNI.Caption = "NI";
            this.coldsFinalChemicalL3DataTableNI.ColumnName = "NI";
            this.coldsFinalChemicalL3DataTableNI.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableNI.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCR
            // 
            this.coldsFinalChemicalL3DataTableCR.Caption = "CR";
            this.coldsFinalChemicalL3DataTableCR.ColumnName = "CR";
            this.coldsFinalChemicalL3DataTableCR.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableCR.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableMO
            // 
            this.coldsFinalChemicalL3DataTableMO.Caption = "MO";
            this.coldsFinalChemicalL3DataTableMO.ColumnName = "MO";
            this.coldsFinalChemicalL3DataTableMO.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableMO.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableV
            // 
            this.coldsFinalChemicalL3DataTableV.Caption = "V";
            this.coldsFinalChemicalL3DataTableV.ColumnName = "V";
            this.coldsFinalChemicalL3DataTableV.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableV.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableNB
            // 
            this.coldsFinalChemicalL3DataTableNB.Caption = "NB";
            this.coldsFinalChemicalL3DataTableNB.ColumnName = "NB";
            this.coldsFinalChemicalL3DataTableNB.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableNB.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAL
            // 
            this.coldsFinalChemicalL3DataTableAL.Caption = "AL";
            this.coldsFinalChemicalL3DataTableAL.ColumnName = "AL";
            this.coldsFinalChemicalL3DataTableAL.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableAL.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableALS
            // 
            this.coldsFinalChemicalL3DataTableALS.Caption = "ALS";
            this.coldsFinalChemicalL3DataTableALS.ColumnName = "ALS";
            this.coldsFinalChemicalL3DataTableALS.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableALS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableTI
            // 
            this.coldsFinalChemicalL3DataTableTI.Caption = "TI";
            this.coldsFinalChemicalL3DataTableTI.ColumnName = "TI";
            this.coldsFinalChemicalL3DataTableTI.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableTI.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableB
            // 
            this.coldsFinalChemicalL3DataTableB.Caption = "B";
            this.coldsFinalChemicalL3DataTableB.ColumnName = "B";
            this.coldsFinalChemicalL3DataTableB.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableB.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSB
            // 
            this.coldsFinalChemicalL3DataTableSB.Caption = "SB";
            this.coldsFinalChemicalL3DataTableSB.ColumnName = "SB";
            this.coldsFinalChemicalL3DataTableSB.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableSB.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableAS
            // 
            this.coldsFinalChemicalL3DataTableAS.Caption = "AS";
            this.coldsFinalChemicalL3DataTableAS.ColumnName = "AS";
            this.coldsFinalChemicalL3DataTableAS.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableAS.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableSN
            // 
            this.coldsFinalChemicalL3DataTableSN.Caption = "SN";
            this.coldsFinalChemicalL3DataTableSN.ColumnName = "SN";
            this.coldsFinalChemicalL3DataTableSN.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableSN.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableZN
            // 
            this.coldsFinalChemicalL3DataTableZN.Caption = "ZN";
            this.coldsFinalChemicalL3DataTableZN.ColumnName = "ZN";
            this.coldsFinalChemicalL3DataTableZN.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableZN.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCA
            // 
            this.coldsFinalChemicalL3DataTableCA.Caption = "CA";
            this.coldsFinalChemicalL3DataTableCA.ColumnName = "CA";
            this.coldsFinalChemicalL3DataTableCA.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableCA.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableW
            // 
            this.coldsFinalChemicalL3DataTableW.Caption = "W";
            this.coldsFinalChemicalL3DataTableW.ColumnName = "W";
            this.coldsFinalChemicalL3DataTableW.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableW.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTablePB
            // 
            this.coldsFinalChemicalL3DataTablePB.Caption = "PB";
            this.coldsFinalChemicalL3DataTablePB.ColumnName = "PB";
            this.coldsFinalChemicalL3DataTablePB.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTablePB.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableRE
            // 
            this.coldsFinalChemicalL3DataTableRE.Caption = "RE";
            this.coldsFinalChemicalL3DataTableRE.ColumnName = "RE";
            this.coldsFinalChemicalL3DataTableRE.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableRE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCEQ
            // 
            this.coldsFinalChemicalL3DataTableCEQ.Caption = "CEQ";
            this.coldsFinalChemicalL3DataTableCEQ.ColumnName = "CEQ";
            this.coldsFinalChemicalL3DataTableCEQ.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableCEQ.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableN
            // 
            this.coldsFinalChemicalL3DataTableN.Caption = "N";
            this.coldsFinalChemicalL3DataTableN.ColumnName = "N";
            this.coldsFinalChemicalL3DataTableN.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableN.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableH
            // 
            this.coldsFinalChemicalL3DataTableH.Caption = "H";
            this.coldsFinalChemicalL3DataTableH.ColumnName = "H";
            this.coldsFinalChemicalL3DataTableH.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableH.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableO
            // 
            this.coldsFinalChemicalL3DataTableO.Caption = "O";
            this.coldsFinalChemicalL3DataTableO.ColumnName = "O";
            this.coldsFinalChemicalL3DataTableO.DefaultValue = "0";
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
            // coldsFinalChemicalL3DataTableOTHER1
            // 
            this.coldsFinalChemicalL3DataTableOTHER1.Caption = "OTHER1";
            this.coldsFinalChemicalL3DataTableOTHER1.ColumnName = "OTHER1";
            this.coldsFinalChemicalL3DataTableOTHER1.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableOTHER1.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOTHER2
            // 
            this.coldsFinalChemicalL3DataTableOTHER2.Caption = "OTHER2";
            this.coldsFinalChemicalL3DataTableOTHER2.ColumnName = "OTHER2";
            this.coldsFinalChemicalL3DataTableOTHER2.DefaultValue = "0";
            this.coldsFinalChemicalL3DataTableOTHER2.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableOther3
            // 
            this.coldsFinalChemicalL3DataTableOther3.Caption = "Other3";
            this.coldsFinalChemicalL3DataTableOther3.ColumnName = "Other3";
            this.coldsFinalChemicalL3DataTableOther3.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableLOGTIME
            // 
            this.coldsFinalChemicalL3DataTableLOGTIME.Caption = "LOGTIME";
            this.coldsFinalChemicalL3DataTableLOGTIME.ColumnName = "LOGTIME";
            this.coldsFinalChemicalL3DataTableLOGTIME.DataType = typeof(System.DateTime);
            this.coldsFinalChemicalL3DataTableLOGTIME.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableDATALOGMODE
            // 
            this.coldsFinalChemicalL3DataTableDATALOGMODE.Caption = "DATALOGMODE";
            this.coldsFinalChemicalL3DataTableDATALOGMODE.ColumnName = "DATALOGMODE";
            this.coldsFinalChemicalL3DataTableDATALOGMODE.DataType = typeof(int);
            this.coldsFinalChemicalL3DataTableDATALOGMODE.DefaultValue = 0;
            this.coldsFinalChemicalL3DataTableDATALOGMODE.Namespace = "";
            // 
            // coldsFinalChemicalL3DataTableCheckFlag
            // 
            this.coldsFinalChemicalL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsFinalChemicalL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsFinalChemicalL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsFinalChemicalL3DataTableCheckFlag.Namespace = "";
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = null;
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = null;
            this.l3CommandParameter7.SourceObject = null;
            this.l3CommandParameter7.SourceProperty = null;
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // l3cmdpHeatID
            // 
            this.l3cmdpHeatID.AcceptAfterExecuted = false;
            this.l3cmdpHeatID.ConstantValue = null;
            this.l3cmdpHeatID.MergeTarget = false;
            this.l3cmdpHeatID.SourceFilter = null;
            this.l3cmdpHeatID.SourceObject = null;
            this.l3cmdpHeatID.SourceProperty = null;
            this.l3cmdpHeatID.TargetObject = null;
            this.l3cmdpHeatID.TargetProperty = null;
            // 
            // l3cmdpds
            // 
            this.l3cmdpds.AcceptAfterExecuted = false;
            this.l3cmdpds.ConstantValue = null;
            this.l3cmdpds.MergeTarget = false;
            this.l3cmdpds.SourceFilter = null;
            this.l3cmdpds.SourceObject = null;
            this.l3cmdpds.SourceProperty = null;
            this.l3cmdpds.TargetObject = null;
            this.l3cmdpds.TargetProperty = null;
            // 
            // l3cmdpAppID
            // 
            this.l3cmdpAppID.AcceptAfterExecuted = false;
            this.l3cmdpAppID.ConstantValue = null;
            this.l3cmdpAppID.MergeTarget = false;
            this.l3cmdpAppID.SourceFilter = null;
            this.l3cmdpAppID.SourceObject = null;
            this.l3cmdpAppID.SourceProperty = null;
            this.l3cmdpAppID.TargetObject = null;
            this.l3cmdpAppID.TargetProperty = null;
            // 
            // hmiRootPanelMain
            // 
            this.hmiRootPanelMain.Controls.Add(this.splitContainerMain);
            this.hmiRootPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelMain.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanelMain.Name = "hmiRootPanelMain";
            this.hmiRootPanelMain.Size = new System.Drawing.Size(1036, 695);
            this.hmiRootPanelMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerMain.Panel2.Controls.Add(this.gbxFinalChemical);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerMain.Panel2.Controls.Add(this.gbxChemicalStd);
            this.splitContainerMain.Panel2.Controls.Add(this.pnlTop);
            this.splitContainerMain.Size = new System.Drawing.Size(1036, 695);
            this.splitContainerMain.SplitterDistance = 175;
            this.splitContainerMain.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvHeatID);
            this.groupBox1.Controls.Add(this.panelFill);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(171, 691);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待终判信息";
            // 
            // dvHeatID
            // 
            this.dvHeatID.AllowUserToAddRows = false;
            this.dvHeatID.AutoGenerateColumns = false;
            this.dvHeatID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvHeatID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvHeatID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hEATIDDataGridViewTextBoxColumn});
            this.dvHeatID.DataSource = this.bsHeatID;
            this.dvHeatID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatID.Location = new System.Drawing.Point(0, 65);
            this.dvHeatID.Margin = new System.Windows.Forms.Padding(0);
            this.dvHeatID.Name = "dvHeatID";
            this.dvHeatID.ReadOnly = true;
            this.dvHeatID.RowTemplate.Height = 23;
            this.dvHeatID.Size = new System.Drawing.Size(171, 626);
            this.dvHeatID.TabIndex = 1;
            this.dvHeatID.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvHeatID_RowPostPaint);
            this.dvHeatID.Click += new System.EventHandler(this.dvHeatID_Click);
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 65);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(171, 626);
            this.panelFill.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(34, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 22);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "刷新";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvRefineThirdEle);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 136);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "转炉中铁水样";
            // 
            // dvRefineThirdEle
            // 
            this.dvRefineThirdEle.AllowUserToAddRows = false;
            this.dvRefineThirdEle.AutoGenerateColumns = false;
            this.dvRefineThirdEle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvRefineThirdEle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRefineThirdEle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvRefineThirdEle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sAMPLECODEDataGridViewTextBoxColumn1,
            this.APPIDRef,
            this.sAMPLETYPEDataGridViewTextBoxColumn1,
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1,
            this.uNITTYPEIDDataGridViewTextBoxColumn3,
            this.hEATIDDataGridViewTextBoxColumn4,
            this.CL,
            this.sIDataGridViewTextBoxColumn1,
            this.mNDataGridViewTextBoxColumn1,
            this.pDataGridViewTextBoxColumn1,
            this.sDataGridViewTextBoxColumn1,
            this.cUDataGridViewTextBoxColumn1,
            this.nIDataGridViewTextBoxColumn1,
            this.cRDataGridViewTextBoxColumn1,
            this.mODataGridViewTextBoxColumn1,
            this.vDataGridViewTextBoxColumn1,
            this.nBDataGridViewTextBoxColumn1,
            this.aLDataGridViewTextBoxColumn1,
            this.aLSDataGridViewTextBoxColumn1,
            this.tIDataGridViewTextBoxColumn1,
            this.bDataGridViewTextBoxColumn1,
            this.sBDataGridViewTextBoxColumn1,
            this.aSDataGridViewTextBoxColumn1,
            this.sNDataGridViewTextBoxColumn1,
            this.zNDataGridViewTextBoxColumn1,
            this.cADataGridViewTextBoxColumn1,
            this.wDataGridViewTextBoxColumn1,
            this.pBDataGridViewTextBoxColumn1,
            this.rEDataGridViewTextBoxColumn1,
            this.cEQDataGridViewTextBoxColumn1,
            this.nDataGridViewTextBoxColumn1,
            this.hDataGridViewTextBoxColumn1,
            this.oDataGridViewTextBoxColumn1,
            this.CrNiL,
            this.CrCuL,
            this.CrNiCuL,
            this.oTHER1DataGridViewTextBoxColumn1,
            this.OTHER22,
            this.Other3L,
            this.sAMPLECOUNTDataGridViewTextBoxColumn1,
            this.aRRIVEDATEDataGridViewTextBoxColumn1,
            this.rEPORTDATEDataGridViewTextBoxColumn1,
            this.uNITIDDataGridViewTextBoxColumn3,
            this.lOGTIMEDataGridViewTextBoxColumn1,
            this.dATALOGMODEDataGridViewTextBoxColumn2});
            this.dvRefineThirdEle.DataSource = this.bsRefineThirdEle;
            this.dvRefineThirdEle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRefineThirdEle.Location = new System.Drawing.Point(3, 17);
            this.dvRefineThirdEle.Margin = new System.Windows.Forms.Padding(0);
            this.dvRefineThirdEle.Name = "dvRefineThirdEle";
            this.dvRefineThirdEle.RowHeadersVisible = false;
            this.dvRefineThirdEle.RowTemplate.Height = 23;
            this.dvRefineThirdEle.Size = new System.Drawing.Size(847, 116);
            this.dvRefineThirdEle.TabIndex = 3;
            this.dvRefineThirdEle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvRefineThirdEle_RowPostPaint);
            // 
            // sAMPLECODEDataGridViewTextBoxColumn1
            // 
            this.sAMPLECODEDataGridViewTextBoxColumn1.DataPropertyName = "SAMPLE_CODE";
            this.sAMPLECODEDataGridViewTextBoxColumn1.HeaderText = "试样编码";
            this.sAMPLECODEDataGridViewTextBoxColumn1.Name = "sAMPLECODEDataGridViewTextBoxColumn1";
            this.sAMPLECODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sAMPLECODEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // APPIDRef
            // 
            this.APPIDRef.DataPropertyName = "APPID";
            this.APPIDRef.HeaderText = "委托单编号";
            this.APPIDRef.Name = "APPIDRef";
            this.APPIDRef.ReadOnly = true;
            this.APPIDRef.Width = 90;
            // 
            // sAMPLETYPEDataGridViewTextBoxColumn1
            // 
            this.sAMPLETYPEDataGridViewTextBoxColumn1.DataPropertyName = "SAMPLE_TYPE";
            this.sAMPLETYPEDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sAMPLETYPEDataGridViewTextBoxColumn1.HeaderText = "试样类别";
            this.sAMPLETYPEDataGridViewTextBoxColumn1.Name = "sAMPLETYPEDataGridViewTextBoxColumn1";
            this.sAMPLETYPEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sAMPLETYPEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sAMPLETYPEDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sAMPLETYPEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // sAMPLEADDRESSDataGridViewTextBoxColumn1
            // 
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.DataPropertyName = "SAMPLE_ADDRESS";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.HeaderText = "取样地点";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.Name = "sAMPLEADDRESSDataGridViewTextBoxColumn1";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn1.Width = 78;
            // 
            // uNITTYPEIDDataGridViewTextBoxColumn3
            // 
            this.uNITTYPEIDDataGridViewTextBoxColumn3.DataPropertyName = "UNITTYPEID";
            this.uNITTYPEIDDataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.uNITTYPEIDDataGridViewTextBoxColumn3.HeaderText = "工序";
            this.uNITTYPEIDDataGridViewTextBoxColumn3.Name = "uNITTYPEIDDataGridViewTextBoxColumn3";
            this.uNITTYPEIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.uNITTYPEIDDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uNITTYPEIDDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uNITTYPEIDDataGridViewTextBoxColumn3.Width = 54;
            // 
            // hEATIDDataGridViewTextBoxColumn4
            // 
            this.hEATIDDataGridViewTextBoxColumn4.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn4.Name = "hEATIDDataGridViewTextBoxColumn4";
            this.hEATIDDataGridViewTextBoxColumn4.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn4.Width = 60;
            // 
            // CL
            // 
            this.CL.DataPropertyName = "C";
            this.CL.HeaderText = "C";
            this.CL.Name = "CL";
            this.CL.ReadOnly = true;
            this.CL.Width = 50;
            // 
            // sIDataGridViewTextBoxColumn1
            // 
            this.sIDataGridViewTextBoxColumn1.DataPropertyName = "SI";
            this.sIDataGridViewTextBoxColumn1.HeaderText = "Si";
            this.sIDataGridViewTextBoxColumn1.Name = "sIDataGridViewTextBoxColumn1";
            this.sIDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sIDataGridViewTextBoxColumn1.Width = 50;
            // 
            // mNDataGridViewTextBoxColumn1
            // 
            this.mNDataGridViewTextBoxColumn1.DataPropertyName = "MN";
            this.mNDataGridViewTextBoxColumn1.HeaderText = "Mn";
            this.mNDataGridViewTextBoxColumn1.Name = "mNDataGridViewTextBoxColumn1";
            this.mNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mNDataGridViewTextBoxColumn1.Width = 50;
            // 
            // pDataGridViewTextBoxColumn1
            // 
            this.pDataGridViewTextBoxColumn1.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn1.HeaderText = "P";
            this.pDataGridViewTextBoxColumn1.Name = "pDataGridViewTextBoxColumn1";
            this.pDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sDataGridViewTextBoxColumn1
            // 
            this.sDataGridViewTextBoxColumn1.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn1.HeaderText = "S";
            this.sDataGridViewTextBoxColumn1.Name = "sDataGridViewTextBoxColumn1";
            this.sDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cUDataGridViewTextBoxColumn1
            // 
            this.cUDataGridViewTextBoxColumn1.DataPropertyName = "CU";
            this.cUDataGridViewTextBoxColumn1.HeaderText = "Cu";
            this.cUDataGridViewTextBoxColumn1.Name = "cUDataGridViewTextBoxColumn1";
            this.cUDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cUDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nIDataGridViewTextBoxColumn1
            // 
            this.nIDataGridViewTextBoxColumn1.DataPropertyName = "NI";
            this.nIDataGridViewTextBoxColumn1.HeaderText = "Ni";
            this.nIDataGridViewTextBoxColumn1.Name = "nIDataGridViewTextBoxColumn1";
            this.nIDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nIDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cRDataGridViewTextBoxColumn1
            // 
            this.cRDataGridViewTextBoxColumn1.DataPropertyName = "CR";
            this.cRDataGridViewTextBoxColumn1.HeaderText = "Cr";
            this.cRDataGridViewTextBoxColumn1.Name = "cRDataGridViewTextBoxColumn1";
            this.cRDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cRDataGridViewTextBoxColumn1.Width = 50;
            // 
            // mODataGridViewTextBoxColumn1
            // 
            this.mODataGridViewTextBoxColumn1.DataPropertyName = "MO";
            this.mODataGridViewTextBoxColumn1.HeaderText = "Mo";
            this.mODataGridViewTextBoxColumn1.Name = "mODataGridViewTextBoxColumn1";
            this.mODataGridViewTextBoxColumn1.ReadOnly = true;
            this.mODataGridViewTextBoxColumn1.Width = 50;
            // 
            // vDataGridViewTextBoxColumn1
            // 
            this.vDataGridViewTextBoxColumn1.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn1.HeaderText = "V";
            this.vDataGridViewTextBoxColumn1.Name = "vDataGridViewTextBoxColumn1";
            this.vDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nBDataGridViewTextBoxColumn1
            // 
            this.nBDataGridViewTextBoxColumn1.DataPropertyName = "NB";
            this.nBDataGridViewTextBoxColumn1.HeaderText = "Nb";
            this.nBDataGridViewTextBoxColumn1.Name = "nBDataGridViewTextBoxColumn1";
            this.nBDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nBDataGridViewTextBoxColumn1.Width = 50;
            // 
            // aLDataGridViewTextBoxColumn1
            // 
            this.aLDataGridViewTextBoxColumn1.DataPropertyName = "AL";
            this.aLDataGridViewTextBoxColumn1.HeaderText = "Al";
            this.aLDataGridViewTextBoxColumn1.Name = "aLDataGridViewTextBoxColumn1";
            this.aLDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aLDataGridViewTextBoxColumn1.Width = 50;
            // 
            // aLSDataGridViewTextBoxColumn1
            // 
            this.aLSDataGridViewTextBoxColumn1.DataPropertyName = "ALS";
            this.aLSDataGridViewTextBoxColumn1.HeaderText = "AlS";
            this.aLSDataGridViewTextBoxColumn1.Name = "aLSDataGridViewTextBoxColumn1";
            this.aLSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aLSDataGridViewTextBoxColumn1.Width = 50;
            // 
            // tIDataGridViewTextBoxColumn1
            // 
            this.tIDataGridViewTextBoxColumn1.DataPropertyName = "TI";
            this.tIDataGridViewTextBoxColumn1.HeaderText = "Ti";
            this.tIDataGridViewTextBoxColumn1.Name = "tIDataGridViewTextBoxColumn1";
            this.tIDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tIDataGridViewTextBoxColumn1.Width = 50;
            // 
            // bDataGridViewTextBoxColumn1
            // 
            this.bDataGridViewTextBoxColumn1.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn1.HeaderText = "B";
            this.bDataGridViewTextBoxColumn1.Name = "bDataGridViewTextBoxColumn1";
            this.bDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sBDataGridViewTextBoxColumn1
            // 
            this.sBDataGridViewTextBoxColumn1.DataPropertyName = "SB";
            this.sBDataGridViewTextBoxColumn1.HeaderText = "Sb";
            this.sBDataGridViewTextBoxColumn1.Name = "sBDataGridViewTextBoxColumn1";
            this.sBDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sBDataGridViewTextBoxColumn1.Width = 50;
            // 
            // aSDataGridViewTextBoxColumn1
            // 
            this.aSDataGridViewTextBoxColumn1.DataPropertyName = "AS";
            this.aSDataGridViewTextBoxColumn1.HeaderText = "As";
            this.aSDataGridViewTextBoxColumn1.Name = "aSDataGridViewTextBoxColumn1";
            this.aSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aSDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sNDataGridViewTextBoxColumn1
            // 
            this.sNDataGridViewTextBoxColumn1.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn1.HeaderText = "Sn";
            this.sNDataGridViewTextBoxColumn1.Name = "sNDataGridViewTextBoxColumn1";
            this.sNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sNDataGridViewTextBoxColumn1.Width = 50;
            // 
            // zNDataGridViewTextBoxColumn1
            // 
            this.zNDataGridViewTextBoxColumn1.DataPropertyName = "ZN";
            this.zNDataGridViewTextBoxColumn1.HeaderText = "Zn";
            this.zNDataGridViewTextBoxColumn1.Name = "zNDataGridViewTextBoxColumn1";
            this.zNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zNDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cADataGridViewTextBoxColumn1
            // 
            this.cADataGridViewTextBoxColumn1.DataPropertyName = "CA";
            this.cADataGridViewTextBoxColumn1.HeaderText = "Ca";
            this.cADataGridViewTextBoxColumn1.Name = "cADataGridViewTextBoxColumn1";
            this.cADataGridViewTextBoxColumn1.ReadOnly = true;
            this.cADataGridViewTextBoxColumn1.Width = 50;
            // 
            // wDataGridViewTextBoxColumn1
            // 
            this.wDataGridViewTextBoxColumn1.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn1.HeaderText = "W";
            this.wDataGridViewTextBoxColumn1.Name = "wDataGridViewTextBoxColumn1";
            this.wDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wDataGridViewTextBoxColumn1.Width = 50;
            // 
            // pBDataGridViewTextBoxColumn1
            // 
            this.pBDataGridViewTextBoxColumn1.DataPropertyName = "PB";
            this.pBDataGridViewTextBoxColumn1.HeaderText = "Pb";
            this.pBDataGridViewTextBoxColumn1.Name = "pBDataGridViewTextBoxColumn1";
            this.pBDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pBDataGridViewTextBoxColumn1.Width = 50;
            // 
            // rEDataGridViewTextBoxColumn1
            // 
            this.rEDataGridViewTextBoxColumn1.DataPropertyName = "RE";
            this.rEDataGridViewTextBoxColumn1.HeaderText = "Re";
            this.rEDataGridViewTextBoxColumn1.Name = "rEDataGridViewTextBoxColumn1";
            this.rEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rEDataGridViewTextBoxColumn1.Width = 50;
            // 
            // cEQDataGridViewTextBoxColumn1
            // 
            this.cEQDataGridViewTextBoxColumn1.DataPropertyName = "CEQ";
            this.cEQDataGridViewTextBoxColumn1.HeaderText = "Ceq";
            this.cEQDataGridViewTextBoxColumn1.Name = "cEQDataGridViewTextBoxColumn1";
            this.cEQDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cEQDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nDataGridViewTextBoxColumn1
            // 
            this.nDataGridViewTextBoxColumn1.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn1.HeaderText = "N";
            this.nDataGridViewTextBoxColumn1.Name = "nDataGridViewTextBoxColumn1";
            this.nDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nDataGridViewTextBoxColumn1.Width = 50;
            // 
            // hDataGridViewTextBoxColumn1
            // 
            this.hDataGridViewTextBoxColumn1.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn1.HeaderText = "H";
            this.hDataGridViewTextBoxColumn1.Name = "hDataGridViewTextBoxColumn1";
            this.hDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hDataGridViewTextBoxColumn1.Width = 50;
            // 
            // oDataGridViewTextBoxColumn1
            // 
            this.oDataGridViewTextBoxColumn1.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn1.HeaderText = "O";
            this.oDataGridViewTextBoxColumn1.Name = "oDataGridViewTextBoxColumn1";
            this.oDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oDataGridViewTextBoxColumn1.Width = 50;
            // 
            // CrNiL
            // 
            this.CrNiL.DataPropertyName = "CrNi";
            this.CrNiL.HeaderText = "CrNi";
            this.CrNiL.Name = "CrNiL";
            this.CrNiL.ReadOnly = true;
            this.CrNiL.Width = 54;
            // 
            // CrCuL
            // 
            this.CrCuL.DataPropertyName = "CrCu";
            this.CrCuL.HeaderText = "CrCu";
            this.CrCuL.Name = "CrCuL";
            this.CrCuL.ReadOnly = true;
            this.CrCuL.Width = 54;
            // 
            // CrNiCuL
            // 
            this.CrNiCuL.DataPropertyName = "CrNiCu";
            this.CrNiCuL.HeaderText = "CrNiCu";
            this.CrNiCuL.Name = "CrNiCuL";
            this.CrNiCuL.ReadOnly = true;
            this.CrNiCuL.Width = 66;
            // 
            // oTHER1DataGridViewTextBoxColumn1
            // 
            this.oTHER1DataGridViewTextBoxColumn1.DataPropertyName = "OTHER1";
            this.oTHER1DataGridViewTextBoxColumn1.HeaderText = "其他1";
            this.oTHER1DataGridViewTextBoxColumn1.Name = "oTHER1DataGridViewTextBoxColumn1";
            this.oTHER1DataGridViewTextBoxColumn1.ReadOnly = true;
            this.oTHER1DataGridViewTextBoxColumn1.Width = 60;
            // 
            // OTHER22
            // 
            this.OTHER22.DataPropertyName = "OTHER2";
            this.OTHER22.HeaderText = "其他2";
            this.OTHER22.Name = "OTHER22";
            this.OTHER22.ReadOnly = true;
            this.OTHER22.Width = 60;
            // 
            // Other3L
            // 
            this.Other3L.DataPropertyName = "Other3";
            this.Other3L.HeaderText = "其他3";
            this.Other3L.Name = "Other3L";
            this.Other3L.ReadOnly = true;
            this.Other3L.Width = 60;
            // 
            // sAMPLECOUNTDataGridViewTextBoxColumn1
            // 
            this.sAMPLECOUNTDataGridViewTextBoxColumn1.DataPropertyName = "SAMPLE_COUNT";
            this.sAMPLECOUNTDataGridViewTextBoxColumn1.HeaderText = "取样次数";
            this.sAMPLECOUNTDataGridViewTextBoxColumn1.Name = "sAMPLECOUNTDataGridViewTextBoxColumn1";
            this.sAMPLECOUNTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sAMPLECOUNTDataGridViewTextBoxColumn1.Width = 78;
            // 
            // aRRIVEDATEDataGridViewTextBoxColumn1
            // 
            this.aRRIVEDATEDataGridViewTextBoxColumn1.DataPropertyName = "ARRIVE_DATE";
            this.aRRIVEDATEDataGridViewTextBoxColumn1.HeaderText = "到样时间";
            this.aRRIVEDATEDataGridViewTextBoxColumn1.Name = "aRRIVEDATEDataGridViewTextBoxColumn1";
            this.aRRIVEDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aRRIVEDATEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // rEPORTDATEDataGridViewTextBoxColumn1
            // 
            this.rEPORTDATEDataGridViewTextBoxColumn1.DataPropertyName = "REPORT_DATE";
            this.rEPORTDATEDataGridViewTextBoxColumn1.HeaderText = "报告时间";
            this.rEPORTDATEDataGridViewTextBoxColumn1.Name = "rEPORTDATEDataGridViewTextBoxColumn1";
            this.rEPORTDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rEPORTDATEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // uNITIDDataGridViewTextBoxColumn3
            // 
            this.uNITIDDataGridViewTextBoxColumn3.DataPropertyName = "UNITID";
            this.uNITIDDataGridViewTextBoxColumn3.HeaderText = "工位";
            this.uNITIDDataGridViewTextBoxColumn3.Name = "uNITIDDataGridViewTextBoxColumn3";
            this.uNITIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.uNITIDDataGridViewTextBoxColumn3.Width = 54;
            // 
            // lOGTIMEDataGridViewTextBoxColumn1
            // 
            this.lOGTIMEDataGridViewTextBoxColumn1.DataPropertyName = "LOGTIME";
            this.lOGTIMEDataGridViewTextBoxColumn1.HeaderText = "数据记录时间";
            this.lOGTIMEDataGridViewTextBoxColumn1.Name = "lOGTIMEDataGridViewTextBoxColumn1";
            this.lOGTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lOGTIMEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // dATALOGMODEDataGridViewTextBoxColumn2
            // 
            this.dATALOGMODEDataGridViewTextBoxColumn2.DataPropertyName = "DATALOGMODE";
            this.dATALOGMODEDataGridViewTextBoxColumn2.HeaderText = "数据产生方式";
            this.dATALOGMODEDataGridViewTextBoxColumn2.Name = "dATALOGMODEDataGridViewTextBoxColumn2";
            this.dATALOGMODEDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dATALOGMODEDataGridViewTextBoxColumn2.Width = 102;
            // 
            // gbxFinalChemical
            // 
            this.gbxFinalChemical.Controls.Add(this.dvFinalChemical);
            this.gbxFinalChemical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxFinalChemical.Location = new System.Drawing.Point(0, 455);
            this.gbxFinalChemical.Margin = new System.Windows.Forms.Padding(0);
            this.gbxFinalChemical.Name = "gbxFinalChemical";
            this.gbxFinalChemical.Padding = new System.Windows.Forms.Padding(0);
            this.gbxFinalChemical.Size = new System.Drawing.Size(853, 172);
            this.gbxFinalChemical.TabIndex = 15;
            this.gbxFinalChemical.TabStop = false;
            this.gbxFinalChemical.Text = "炉中样";
            // 
            // dvFinalChemical
            // 
            this.dvFinalChemical.AllowUserToAddRows = false;
            this.dvFinalChemical.AutoGenerateColumns = false;
            this.dvFinalChemical.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvFinalChemical.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvFinalChemical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvFinalChemical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlagFin,
            this.sAMPLECODEDataGridViewTextBoxColumn,
            this.APPIDFin,
            this.SAMPLE_TYPE1,
            this.sAMPLEADDRESSDataGridViewTextBoxColumn,
            this.uNITTYPEIDDataGridViewTextBoxColumn2,
            this.rEPORTDATEDataGridViewTextBoxColumn,
            this.lOGTIMEDataGridViewTextBoxColumn,
            this.aRRIVEDATEDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn3,
            this.CP,
            this.sIDataGridViewTextBoxColumn,
            this.mNDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.cUDataGridViewTextBoxColumn,
            this.nIDataGridViewTextBoxColumn,
            this.cRDataGridViewTextBoxColumn,
            this.mODataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.nBDataGridViewTextBoxColumn,
            this.aLDataGridViewTextBoxColumn,
            this.aLSDataGridViewTextBoxColumn,
            this.tIDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.sBDataGridViewTextBoxColumn,
            this.aSDataGridViewTextBoxColumn,
            this.sNDataGridViewTextBoxColumn,
            this.zNDataGridViewTextBoxColumn,
            this.cADataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.pBDataGridViewTextBoxColumn,
            this.rEDataGridViewTextBoxColumn,
            this.cEQDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.CrNiP,
            this.CrCuP,
            this.CrNiCuP,
            this.oTHER1DataGridViewTextBoxColumn,
            this.OTHER21,
            this.Other3P,
            this.sAMPLECOUNTDataGridViewTextBoxColumn,
            this.uNITIDDataGridViewTextBoxColumn2,
            this.dATALOGMODEDataGridViewTextBoxColumn1});
            this.dvFinalChemical.DataSource = this.bsFinalChemical;
            this.dvFinalChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFinalChemical.Location = new System.Drawing.Point(0, 14);
            this.dvFinalChemical.Margin = new System.Windows.Forms.Padding(0);
            this.dvFinalChemical.MultiSelect = false;
            this.dvFinalChemical.Name = "dvFinalChemical";
            this.dvFinalChemical.RowHeadersVisible = false;
            this.dvFinalChemical.RowTemplate.Height = 23;
            this.dvFinalChemical.Size = new System.Drawing.Size(853, 158);
            this.dvFinalChemical.TabIndex = 3;
            this.dvFinalChemical.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvFinalChemical_RowPostPaint);
            this.dvFinalChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFinalChemical_DataError);
            // 
            // CheckFlagFin
            // 
            this.CheckFlagFin.FalseValue = "0";
            this.CheckFlagFin.HeaderText = "选择";
            this.CheckFlagFin.Name = "CheckFlagFin";
            this.CheckFlagFin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlagFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlagFin.TrueValue = "1";
            this.CheckFlagFin.Width = 54;
            // 
            // sAMPLECODEDataGridViewTextBoxColumn
            // 
            this.sAMPLECODEDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_CODE";
            this.sAMPLECODEDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sAMPLECODEDataGridViewTextBoxColumn.Name = "sAMPLECODEDataGridViewTextBoxColumn";
            this.sAMPLECODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLECODEDataGridViewTextBoxColumn.Width = 78;
            // 
            // APPIDFin
            // 
            this.APPIDFin.DataPropertyName = "APPID";
            this.APPIDFin.HeaderText = "委托单编号";
            this.APPIDFin.Name = "APPIDFin";
            this.APPIDFin.ReadOnly = true;
            this.APPIDFin.Width = 90;
            // 
            // SAMPLE_TYPE1
            // 
            this.SAMPLE_TYPE1.DataPropertyName = "SAMPLE_TYPE";
            this.SAMPLE_TYPE1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SAMPLE_TYPE1.HeaderText = "试样类别";
            this.SAMPLE_TYPE1.Name = "SAMPLE_TYPE1";
            this.SAMPLE_TYPE1.ReadOnly = true;
            this.SAMPLE_TYPE1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SAMPLE_TYPE1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SAMPLE_TYPE1.Width = 78;
            // 
            // sAMPLEADDRESSDataGridViewTextBoxColumn
            // 
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_ADDRESS";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Name = "sAMPLEADDRESSDataGridViewTextBoxColumn";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Width = 78;
            // 
            // uNITTYPEIDDataGridViewTextBoxColumn2
            // 
            this.uNITTYPEIDDataGridViewTextBoxColumn2.DataPropertyName = "UNITTYPEID";
            this.uNITTYPEIDDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.uNITTYPEIDDataGridViewTextBoxColumn2.HeaderText = "工序";
            this.uNITTYPEIDDataGridViewTextBoxColumn2.Name = "uNITTYPEIDDataGridViewTextBoxColumn2";
            this.uNITTYPEIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.uNITTYPEIDDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uNITTYPEIDDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uNITTYPEIDDataGridViewTextBoxColumn2.Width = 54;
            // 
            // rEPORTDATEDataGridViewTextBoxColumn
            // 
            this.rEPORTDATEDataGridViewTextBoxColumn.DataPropertyName = "REPORT_DATE";
            this.rEPORTDATEDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.rEPORTDATEDataGridViewTextBoxColumn.Name = "rEPORTDATEDataGridViewTextBoxColumn";
            this.rEPORTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPORTDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // lOGTIMEDataGridViewTextBoxColumn
            // 
            this.lOGTIMEDataGridViewTextBoxColumn.DataPropertyName = "LOGTIME";
            this.lOGTIMEDataGridViewTextBoxColumn.HeaderText = "数据记录时间";
            this.lOGTIMEDataGridViewTextBoxColumn.Name = "lOGTIMEDataGridViewTextBoxColumn";
            this.lOGTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // aRRIVEDATEDataGridViewTextBoxColumn
            // 
            this.aRRIVEDATEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVE_DATE";
            this.aRRIVEDATEDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.aRRIVEDATEDataGridViewTextBoxColumn.Name = "aRRIVEDATEDataGridViewTextBoxColumn";
            this.aRRIVEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aRRIVEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // hEATIDDataGridViewTextBoxColumn3
            // 
            this.hEATIDDataGridViewTextBoxColumn3.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn3.Name = "hEATIDDataGridViewTextBoxColumn3";
            this.hEATIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn3.Width = 60;
            // 
            // CP
            // 
            this.CP.DataPropertyName = "C";
            this.CP.HeaderText = "C";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Width = 50;
            // 
            // sIDataGridViewTextBoxColumn
            // 
            this.sIDataGridViewTextBoxColumn.DataPropertyName = "SI";
            this.sIDataGridViewTextBoxColumn.HeaderText = "Si";
            this.sIDataGridViewTextBoxColumn.Name = "sIDataGridViewTextBoxColumn";
            this.sIDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDataGridViewTextBoxColumn.Width = 50;
            // 
            // mNDataGridViewTextBoxColumn
            // 
            this.mNDataGridViewTextBoxColumn.DataPropertyName = "MN";
            this.mNDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mNDataGridViewTextBoxColumn.Name = "mNDataGridViewTextBoxColumn";
            this.mNDataGridViewTextBoxColumn.ReadOnly = true;
            this.mNDataGridViewTextBoxColumn.Width = 50;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 50;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 50;
            // 
            // cUDataGridViewTextBoxColumn
            // 
            this.cUDataGridViewTextBoxColumn.DataPropertyName = "CU";
            this.cUDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cUDataGridViewTextBoxColumn.Name = "cUDataGridViewTextBoxColumn";
            this.cUDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUDataGridViewTextBoxColumn.Width = 50;
            // 
            // nIDataGridViewTextBoxColumn
            // 
            this.nIDataGridViewTextBoxColumn.DataPropertyName = "NI";
            this.nIDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.nIDataGridViewTextBoxColumn.Name = "nIDataGridViewTextBoxColumn";
            this.nIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIDataGridViewTextBoxColumn.Width = 50;
            // 
            // cRDataGridViewTextBoxColumn
            // 
            this.cRDataGridViewTextBoxColumn.DataPropertyName = "CR";
            this.cRDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.cRDataGridViewTextBoxColumn.Name = "cRDataGridViewTextBoxColumn";
            this.cRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRDataGridViewTextBoxColumn.Width = 50;
            // 
            // mODataGridViewTextBoxColumn
            // 
            this.mODataGridViewTextBoxColumn.DataPropertyName = "MO";
            this.mODataGridViewTextBoxColumn.HeaderText = "Mo";
            this.mODataGridViewTextBoxColumn.Name = "mODataGridViewTextBoxColumn";
            this.mODataGridViewTextBoxColumn.ReadOnly = true;
            this.mODataGridViewTextBoxColumn.Width = 50;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.ReadOnly = true;
            this.vDataGridViewTextBoxColumn.Width = 50;
            // 
            // nBDataGridViewTextBoxColumn
            // 
            this.nBDataGridViewTextBoxColumn.DataPropertyName = "NB";
            this.nBDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nBDataGridViewTextBoxColumn.Name = "nBDataGridViewTextBoxColumn";
            this.nBDataGridViewTextBoxColumn.ReadOnly = true;
            this.nBDataGridViewTextBoxColumn.Width = 50;
            // 
            // aLDataGridViewTextBoxColumn
            // 
            this.aLDataGridViewTextBoxColumn.DataPropertyName = "AL";
            this.aLDataGridViewTextBoxColumn.HeaderText = "Al";
            this.aLDataGridViewTextBoxColumn.Name = "aLDataGridViewTextBoxColumn";
            this.aLDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLDataGridViewTextBoxColumn.Width = 50;
            // 
            // aLSDataGridViewTextBoxColumn
            // 
            this.aLSDataGridViewTextBoxColumn.DataPropertyName = "ALS";
            this.aLSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.aLSDataGridViewTextBoxColumn.Name = "aLSDataGridViewTextBoxColumn";
            this.aLSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLSDataGridViewTextBoxColumn.Width = 50;
            // 
            // tIDataGridViewTextBoxColumn
            // 
            this.tIDataGridViewTextBoxColumn.DataPropertyName = "TI";
            this.tIDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tIDataGridViewTextBoxColumn.Name = "tIDataGridViewTextBoxColumn";
            this.tIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDataGridViewTextBoxColumn.Width = 50;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDataGridViewTextBoxColumn.Width = 50;
            // 
            // sBDataGridViewTextBoxColumn
            // 
            this.sBDataGridViewTextBoxColumn.DataPropertyName = "SB";
            this.sBDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sBDataGridViewTextBoxColumn.Name = "sBDataGridViewTextBoxColumn";
            this.sBDataGridViewTextBoxColumn.ReadOnly = true;
            this.sBDataGridViewTextBoxColumn.Width = 50;
            // 
            // aSDataGridViewTextBoxColumn
            // 
            this.aSDataGridViewTextBoxColumn.DataPropertyName = "AS";
            this.aSDataGridViewTextBoxColumn.HeaderText = "As";
            this.aSDataGridViewTextBoxColumn.Name = "aSDataGridViewTextBoxColumn";
            this.aSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSDataGridViewTextBoxColumn.Width = 50;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNDataGridViewTextBoxColumn.Width = 50;
            // 
            // zNDataGridViewTextBoxColumn
            // 
            this.zNDataGridViewTextBoxColumn.DataPropertyName = "ZN";
            this.zNDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.zNDataGridViewTextBoxColumn.Name = "zNDataGridViewTextBoxColumn";
            this.zNDataGridViewTextBoxColumn.ReadOnly = true;
            this.zNDataGridViewTextBoxColumn.Width = 50;
            // 
            // cADataGridViewTextBoxColumn
            // 
            this.cADataGridViewTextBoxColumn.DataPropertyName = "CA";
            this.cADataGridViewTextBoxColumn.HeaderText = "Ca";
            this.cADataGridViewTextBoxColumn.Name = "cADataGridViewTextBoxColumn";
            this.cADataGridViewTextBoxColumn.ReadOnly = true;
            this.cADataGridViewTextBoxColumn.Width = 50;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.ReadOnly = true;
            this.wDataGridViewTextBoxColumn.Width = 50;
            // 
            // pBDataGridViewTextBoxColumn
            // 
            this.pBDataGridViewTextBoxColumn.DataPropertyName = "PB";
            this.pBDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pBDataGridViewTextBoxColumn.Name = "pBDataGridViewTextBoxColumn";
            this.pBDataGridViewTextBoxColumn.ReadOnly = true;
            this.pBDataGridViewTextBoxColumn.Width = 50;
            // 
            // rEDataGridViewTextBoxColumn
            // 
            this.rEDataGridViewTextBoxColumn.DataPropertyName = "RE";
            this.rEDataGridViewTextBoxColumn.HeaderText = "Re";
            this.rEDataGridViewTextBoxColumn.Name = "rEDataGridViewTextBoxColumn";
            this.rEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEDataGridViewTextBoxColumn.Width = 50;
            // 
            // cEQDataGridViewTextBoxColumn
            // 
            this.cEQDataGridViewTextBoxColumn.DataPropertyName = "CEQ";
            this.cEQDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.cEQDataGridViewTextBoxColumn.Name = "cEQDataGridViewTextBoxColumn";
            this.cEQDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEQDataGridViewTextBoxColumn.Width = 50;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDataGridViewTextBoxColumn.Width = 50;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDataGridViewTextBoxColumn.Width = 50;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            this.oDataGridViewTextBoxColumn.Width = 50;
            // 
            // CrNiP
            // 
            this.CrNiP.DataPropertyName = "CrNi";
            this.CrNiP.HeaderText = "CrNi";
            this.CrNiP.Name = "CrNiP";
            this.CrNiP.ReadOnly = true;
            this.CrNiP.Width = 54;
            // 
            // CrCuP
            // 
            this.CrCuP.DataPropertyName = "CrCu";
            this.CrCuP.HeaderText = "CrCu";
            this.CrCuP.Name = "CrCuP";
            this.CrCuP.ReadOnly = true;
            this.CrCuP.Width = 54;
            // 
            // CrNiCuP
            // 
            this.CrNiCuP.DataPropertyName = "CrNiCu";
            this.CrNiCuP.HeaderText = "CrNiCu";
            this.CrNiCuP.Name = "CrNiCuP";
            this.CrNiCuP.ReadOnly = true;
            this.CrNiCuP.Width = 66;
            // 
            // oTHER1DataGridViewTextBoxColumn
            // 
            this.oTHER1DataGridViewTextBoxColumn.DataPropertyName = "OTHER1";
            this.oTHER1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.oTHER1DataGridViewTextBoxColumn.Name = "oTHER1DataGridViewTextBoxColumn";
            this.oTHER1DataGridViewTextBoxColumn.ReadOnly = true;
            this.oTHER1DataGridViewTextBoxColumn.Width = 60;
            // 
            // OTHER21
            // 
            this.OTHER21.DataPropertyName = "OTHER2";
            this.OTHER21.HeaderText = "其他2";
            this.OTHER21.Name = "OTHER21";
            this.OTHER21.ReadOnly = true;
            this.OTHER21.Width = 60;
            // 
            // Other3P
            // 
            this.Other3P.DataPropertyName = "Other3";
            this.Other3P.HeaderText = "其他3";
            this.Other3P.Name = "Other3P";
            this.Other3P.ReadOnly = true;
            this.Other3P.Width = 60;
            // 
            // sAMPLECOUNTDataGridViewTextBoxColumn
            // 
            this.sAMPLECOUNTDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_COUNT";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.Name = "sAMPLECOUNTDataGridViewTextBoxColumn";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLECOUNTDataGridViewTextBoxColumn.Width = 78;
            // 
            // uNITIDDataGridViewTextBoxColumn2
            // 
            this.uNITIDDataGridViewTextBoxColumn2.DataPropertyName = "UNITID";
            this.uNITIDDataGridViewTextBoxColumn2.HeaderText = "工位";
            this.uNITIDDataGridViewTextBoxColumn2.Name = "uNITIDDataGridViewTextBoxColumn2";
            this.uNITIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.uNITIDDataGridViewTextBoxColumn2.Width = 54;
            // 
            // dATALOGMODEDataGridViewTextBoxColumn1
            // 
            this.dATALOGMODEDataGridViewTextBoxColumn1.DataPropertyName = "DATALOGMODE";
            this.dATALOGMODEDataGridViewTextBoxColumn1.HeaderText = "数据产生方式";
            this.dATALOGMODEDataGridViewTextBoxColumn1.Name = "dATALOGMODEDataGridViewTextBoxColumn1";
            this.dATALOGMODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dATALOGMODEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 627);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(853, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "判 定";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnJudge);
            this.panel2.Controls.Add(this.rBtnYes);
            this.panel2.Controls.Add(this.rBtnNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(401, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 50);
            this.panel2.TabIndex = 3;
            // 
            // btnJudge
            // 
            this.btnJudge.Font = new System.Drawing.Font("宋体", 8.55F);
            this.btnJudge.Location = new System.Drawing.Point(343, 11);
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
            this.rBtnYes.Location = new System.Drawing.Point(90, 17);
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
            this.rBtnNo.Location = new System.Drawing.Point(188, 17);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(59, 16);
            this.rBtnNo.TabIndex = 0;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "不合格";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // gbxChemicalStd
            // 
            this.gbxChemicalStd.Controls.Add(this.myLine5);
            this.gbxChemicalStd.Controls.Add(this.myLine4);
            this.gbxChemicalStd.Controls.Add(this.myLine3);
            this.gbxChemicalStd.Controls.Add(this.myLine2);
            this.gbxChemicalStd.Controls.Add(this.myLine1);
            this.gbxChemicalStd.Controls.Add(this.label2);
            this.gbxChemicalStd.Controls.Add(this.label4);
            this.gbxChemicalStd.Controls.Add(this.lblCrMoNiCuMax);
            this.gbxChemicalStd.Controls.Add(this.lblOMax);
            this.gbxChemicalStd.Controls.Add(this.lblNMax);
            this.gbxChemicalStd.Controls.Add(this.lblHMax);
            this.gbxChemicalStd.Controls.Add(this.lblCeqMax);
            this.gbxChemicalStd.Controls.Add(this.lblReMax);
            this.gbxChemicalStd.Controls.Add(this.lblPbMax);
            this.gbxChemicalStd.Controls.Add(this.lblWMax);
            this.gbxChemicalStd.Controls.Add(this.lblCaMax);
            this.gbxChemicalStd.Controls.Add(this.lblZrMax);
            this.gbxChemicalStd.Controls.Add(this.lblZnMax);
            this.gbxChemicalStd.Controls.Add(this.lblAsMax);
            this.gbxChemicalStd.Controls.Add(this.label41);
            this.gbxChemicalStd.Controls.Add(this.lblSnMax);
            this.gbxChemicalStd.Controls.Add(label36);
            this.gbxChemicalStd.Controls.Add(lblSbMax);
            this.gbxChemicalStd.Controls.Add(this.lblCrMoNiCuMin);
            this.gbxChemicalStd.Controls.Add(this.lblHMin);
            this.gbxChemicalStd.Controls.Add(this.lblOMin);
            this.gbxChemicalStd.Controls.Add(this.lblNMin);
            this.gbxChemicalStd.Controls.Add(this.lblCeqMin);
            this.gbxChemicalStd.Controls.Add(lblReMin);
            this.gbxChemicalStd.Controls.Add(this.lblPbMin);
            this.gbxChemicalStd.Controls.Add(this.lblWMin);
            this.gbxChemicalStd.Controls.Add(this.lblCaMin);
            this.gbxChemicalStd.Controls.Add(this.lblZrMin);
            this.gbxChemicalStd.Controls.Add(this.lblZnMin);
            this.gbxChemicalStd.Controls.Add(this.lblAsMin);
            this.gbxChemicalStd.Controls.Add(this.label26);
            this.gbxChemicalStd.Controls.Add(this.lblSnMin);
            this.gbxChemicalStd.Controls.Add(this.label24);
            this.gbxChemicalStd.Controls.Add(this.lblSbMin);
            this.gbxChemicalStd.Controls.Add(this.label186);
            this.gbxChemicalStd.Controls.Add(this.label182);
            this.gbxChemicalStd.Controls.Add(this.label185);
            this.gbxChemicalStd.Controls.Add(this.label183);
            this.gbxChemicalStd.Controls.Add(this.label181);
            this.gbxChemicalStd.Controls.Add(this.label180);
            this.gbxChemicalStd.Controls.Add(this.label179);
            this.gbxChemicalStd.Controls.Add(this.label178);
            this.gbxChemicalStd.Controls.Add(this.label177);
            this.gbxChemicalStd.Controls.Add(this.label176);
            this.gbxChemicalStd.Controls.Add(this.label175);
            this.gbxChemicalStd.Controls.Add(this.label174);
            this.gbxChemicalStd.Controls.Add(this.label22);
            this.gbxChemicalStd.Controls.Add(this.label173);
            this.gbxChemicalStd.Controls.Add(this.label21);
            this.gbxChemicalStd.Controls.Add(this.label172);
            this.gbxChemicalStd.Controls.Add(this.label20);
            this.gbxChemicalStd.Controls.Add(this.lblBMax);
            this.gbxChemicalStd.Controls.Add(this.label18);
            this.gbxChemicalStd.Controls.Add(this.lblBMin);
            this.gbxChemicalStd.Controls.Add(this.label17);
            this.gbxChemicalStd.Controls.Add(this.label40);
            this.gbxChemicalStd.Controls.Add(this.label16);
            this.gbxChemicalStd.Controls.Add(this.lblTiMax);
            this.gbxChemicalStd.Controls.Add(this.label15);
            this.gbxChemicalStd.Controls.Add(this.lblTiMin);
            this.gbxChemicalStd.Controls.Add(this.label14);
            this.gbxChemicalStd.Controls.Add(this.label38);
            this.gbxChemicalStd.Controls.Add(this.label13);
            this.gbxChemicalStd.Controls.Add(this.label12);
            this.gbxChemicalStd.Controls.Add(this.lblAlsMax);
            this.gbxChemicalStd.Controls.Add(this.label11);
            this.gbxChemicalStd.Controls.Add(this.lblAlsMin);
            this.gbxChemicalStd.Controls.Add(this.label37);
            this.gbxChemicalStd.Controls.Add(this.label32);
            this.gbxChemicalStd.Controls.Add(this.label30);
            this.gbxChemicalStd.Controls.Add(this.lblAlMax);
            this.gbxChemicalStd.Controls.Add(this.lblAlMin);
            this.gbxChemicalStd.Controls.Add(this.label94);
            this.gbxChemicalStd.Controls.Add(this.lblNbMax);
            this.gbxChemicalStd.Controls.Add(this.lblNbMin);
            this.gbxChemicalStd.Controls.Add(this.label89);
            this.gbxChemicalStd.Controls.Add(this.lblVMax);
            this.gbxChemicalStd.Controls.Add(this.lblVMin);
            this.gbxChemicalStd.Controls.Add(this.label84);
            this.gbxChemicalStd.Controls.Add(this.lblMoMax);
            this.gbxChemicalStd.Controls.Add(this.lblMoMin);
            this.gbxChemicalStd.Controls.Add(this.label79);
            this.gbxChemicalStd.Controls.Add(this.lblCrMax);
            this.gbxChemicalStd.Controls.Add(this.lblCrMin);
            this.gbxChemicalStd.Controls.Add(this.label74);
            this.gbxChemicalStd.Controls.Add(this.lblNiMax);
            this.gbxChemicalStd.Controls.Add(this.lblNiMin);
            this.gbxChemicalStd.Controls.Add(this.label69);
            this.gbxChemicalStd.Controls.Add(this.lblCuMax);
            this.gbxChemicalStd.Controls.Add(this.lblCuMin);
            this.gbxChemicalStd.Controls.Add(this.label64);
            this.gbxChemicalStd.Controls.Add(this.lblSMax);
            this.gbxChemicalStd.Controls.Add(this.lblSMin);
            this.gbxChemicalStd.Controls.Add(this.label59);
            this.gbxChemicalStd.Controls.Add(this.lblPMax);
            this.gbxChemicalStd.Controls.Add(this.lblPMin);
            this.gbxChemicalStd.Controls.Add(this.label54);
            this.gbxChemicalStd.Controls.Add(this.lblMnMax);
            this.gbxChemicalStd.Controls.Add(this.lblMnMin);
            this.gbxChemicalStd.Controls.Add(this.label49);
            this.gbxChemicalStd.Controls.Add(this.lblSiMax);
            this.gbxChemicalStd.Controls.Add(this.lblSiMin);
            this.gbxChemicalStd.Controls.Add(this.label44);
            this.gbxChemicalStd.Controls.Add(this.lblCMax);
            this.gbxChemicalStd.Controls.Add(this.lblCMin);
            this.gbxChemicalStd.Controls.Add(this.label39);
            this.gbxChemicalStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxChemicalStd.Location = new System.Drawing.Point(0, 100);
            this.gbxChemicalStd.Margin = new System.Windows.Forms.Padding(0);
            this.gbxChemicalStd.Name = "gbxChemicalStd";
            this.gbxChemicalStd.Padding = new System.Windows.Forms.Padding(0);
            this.gbxChemicalStd.Size = new System.Drawing.Size(853, 591);
            this.gbxChemicalStd.TabIndex = 5;
            this.gbxChemicalStd.TabStop = false;
            this.gbxChemicalStd.Text = "成品成份标准";
            // 
            // myLine5
            // 
            this.myLine5.BackColor = System.Drawing.SystemColors.Control;
            this.myLine5.Location = new System.Drawing.Point(45, 114);
            this.myLine5.Name = "myLine5";
            this.myLine5.Size = new System.Drawing.Size(817, 10);
            this.myLine5.TabIndex = 133;
            // 
            // myLine4
            // 
            this.myLine4.BackColor = System.Drawing.SystemColors.Control;
            this.myLine4.Location = new System.Drawing.Point(264, 286);
            this.myLine4.Name = "myLine4";
            this.myLine4.Size = new System.Drawing.Size(285, 10);
            this.myLine4.TabIndex = 162;
            // 
            // myLine3
            // 
            this.myLine3.BackColor = System.Drawing.SystemColors.Control;
            this.myLine3.Location = new System.Drawing.Point(355, 278);
            this.myLine3.Name = "myLine3";
            this.myLine3.Size = new System.Drawing.Size(186, 10);
            this.myLine3.TabIndex = 161;
            // 
            // myLine2
            // 
            this.myLine2.BackColor = System.Drawing.SystemColors.Control;
            this.myLine2.Location = new System.Drawing.Point(16, 286);
            this.myLine2.Name = "myLine2";
            this.myLine2.Size = new System.Drawing.Size(880, 10);
            this.myLine2.TabIndex = 160;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(8, 278);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(880, 10);
            this.myLine1.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 158;
            this.label2.Text = "最大:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 156;
            this.label4.Text = "最小:";
            // 
            // lblCrMoNiCuMax
            // 
            this.lblCrMoNiCuMax.AutoSize = true;
            this.lblCrMoNiCuMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNi_Max", true));
            this.lblCrMoNiCuMax.Location = new System.Drawing.Point(592, 194);
            this.lblCrMoNiCuMax.Name = "lblCrMoNiCuMax";
            this.lblCrMoNiCuMax.Size = new System.Drawing.Size(23, 12);
            this.lblCrMoNiCuMax.TabIndex = 138;
            this.lblCrMoNiCuMax.Text = "XXX";
            // 
            // lblOMax
            // 
            this.lblOMax.AutoSize = true;
            this.lblOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.O_MAX", true));
            this.lblOMax.Location = new System.Drawing.Point(502, 194);
            this.lblOMax.Name = "lblOMax";
            this.lblOMax.Size = new System.Drawing.Size(23, 12);
            this.lblOMax.TabIndex = 139;
            this.lblOMax.Text = "XXX";
            // 
            // lblNMax
            // 
            this.lblNMax.AutoSize = true;
            this.lblNMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.N_MAX", true));
            this.lblNMax.Location = new System.Drawing.Point(457, 194);
            this.lblNMax.Name = "lblNMax";
            this.lblNMax.Size = new System.Drawing.Size(23, 12);
            this.lblNMax.TabIndex = 135;
            this.lblNMax.Text = "XXX";
            // 
            // lblHMax
            // 
            this.lblHMax.AutoSize = true;
            this.lblHMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.H_MAX", true));
            this.lblHMax.Location = new System.Drawing.Point(547, 194);
            this.lblHMax.Name = "lblHMax";
            this.lblHMax.Size = new System.Drawing.Size(23, 12);
            this.lblHMax.TabIndex = 136;
            this.lblHMax.Text = "XXX";
            // 
            // lblCeqMax
            // 
            this.lblCeqMax.AutoSize = true;
            this.lblCeqMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CEQ_MAX", true));
            this.lblCeqMax.Location = new System.Drawing.Point(412, 194);
            this.lblCeqMax.Name = "lblCeqMax";
            this.lblCeqMax.Size = new System.Drawing.Size(23, 12);
            this.lblCeqMax.TabIndex = 131;
            this.lblCeqMax.Text = "XXX";
            // 
            // lblReMax
            // 
            this.lblReMax.AutoSize = true;
            this.lblReMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.RE_MAX", true));
            this.lblReMax.Location = new System.Drawing.Point(367, 194);
            this.lblReMax.Name = "lblReMax";
            this.lblReMax.Size = new System.Drawing.Size(23, 12);
            this.lblReMax.TabIndex = 130;
            this.lblReMax.Text = "XXX";
            // 
            // lblPbMax
            // 
            this.lblPbMax.AutoSize = true;
            this.lblPbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.PB_MAX", true));
            this.lblPbMax.Location = new System.Drawing.Point(322, 194);
            this.lblPbMax.Name = "lblPbMax";
            this.lblPbMax.Size = new System.Drawing.Size(23, 12);
            this.lblPbMax.TabIndex = 132;
            this.lblPbMax.Text = "XXX";
            // 
            // lblWMax
            // 
            this.lblWMax.AutoSize = true;
            this.lblWMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.W_MAX", true));
            this.lblWMax.Location = new System.Drawing.Point(277, 194);
            this.lblWMax.Name = "lblWMax";
            this.lblWMax.Size = new System.Drawing.Size(23, 12);
            this.lblWMax.TabIndex = 134;
            this.lblWMax.Text = "XXX";
            // 
            // lblCaMax
            // 
            this.lblCaMax.AutoSize = true;
            this.lblCaMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CA_MAX", true));
            this.lblCaMax.Location = new System.Drawing.Point(232, 194);
            this.lblCaMax.Name = "lblCaMax";
            this.lblCaMax.Size = new System.Drawing.Size(23, 12);
            this.lblCaMax.TabIndex = 133;
            this.lblCaMax.Text = "XXX";
            // 
            // lblZrMax
            // 
            this.lblZrMax.AutoSize = true;
            this.lblZrMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZR_MAX", true));
            this.lblZrMax.Location = new System.Drawing.Point(187, 194);
            this.lblZrMax.Name = "lblZrMax";
            this.lblZrMax.Size = new System.Drawing.Size(23, 12);
            this.lblZrMax.TabIndex = 126;
            this.lblZrMax.Text = "XXX";
            // 
            // lblZnMax
            // 
            this.lblZnMax.AutoSize = true;
            this.lblZnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZN_MAX", true));
            this.lblZnMax.Location = new System.Drawing.Point(142, 194);
            this.lblZnMax.Name = "lblZnMax";
            this.lblZnMax.Size = new System.Drawing.Size(23, 12);
            this.lblZnMax.TabIndex = 125;
            this.lblZnMax.Text = "XXX";
            // 
            // lblAsMax
            // 
            this.lblAsMax.AutoSize = true;
            this.lblAsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AS_MAX", true));
            this.lblAsMax.Location = new System.Drawing.Point(97, 194);
            this.lblAsMax.Name = "lblAsMax";
            this.lblAsMax.Size = new System.Drawing.Size(23, 12);
            this.lblAsMax.TabIndex = 127;
            this.lblAsMax.Text = "XXX";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other3_Max", true));
            this.label41.Location = new System.Drawing.Point(817, 194);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(23, 12);
            this.label41.TabIndex = 129;
            this.label41.Text = "XXX";
            // 
            // lblSnMax
            // 
            this.lblSnMax.AutoSize = true;
            this.lblSnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SN_MAX", true));
            this.lblSnMax.Location = new System.Drawing.Point(817, 88);
            this.lblSnMax.Name = "lblSnMax";
            this.lblSnMax.Size = new System.Drawing.Size(23, 12);
            this.lblSnMax.TabIndex = 129;
            this.lblSnMax.Text = "XXX";
            // 
            // lblCrMoNiCuMin
            // 
            this.lblCrMoNiCuMin.AutoSize = true;
            this.lblCrMoNiCuMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNi_Min", true));
            this.lblCrMoNiCuMin.Location = new System.Drawing.Point(592, 170);
            this.lblCrMoNiCuMin.Name = "lblCrMoNiCuMin";
            this.lblCrMoNiCuMin.Size = new System.Drawing.Size(23, 12);
            this.lblCrMoNiCuMin.TabIndex = 109;
            this.lblCrMoNiCuMin.Text = "XXX";
            // 
            // lblHMin
            // 
            this.lblHMin.AutoSize = true;
            this.lblHMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.H_MIN", true));
            this.lblHMin.Location = new System.Drawing.Point(547, 170);
            this.lblHMin.Name = "lblHMin";
            this.lblHMin.Size = new System.Drawing.Size(23, 12);
            this.lblHMin.TabIndex = 107;
            this.lblHMin.Text = "XXX";
            // 
            // lblOMin
            // 
            this.lblOMin.AutoSize = true;
            this.lblOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.O_MIN", true));
            this.lblOMin.Location = new System.Drawing.Point(502, 170);
            this.lblOMin.Name = "lblOMin";
            this.lblOMin.Size = new System.Drawing.Size(23, 12);
            this.lblOMin.TabIndex = 103;
            this.lblOMin.Text = "XXX";
            // 
            // lblNMin
            // 
            this.lblNMin.AutoSize = true;
            this.lblNMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.N_MIN", true));
            this.lblNMin.Location = new System.Drawing.Point(457, 170);
            this.lblNMin.Name = "lblNMin";
            this.lblNMin.Size = new System.Drawing.Size(23, 12);
            this.lblNMin.TabIndex = 102;
            this.lblNMin.Text = "XXX";
            // 
            // lblCeqMin
            // 
            this.lblCeqMin.AutoSize = true;
            this.lblCeqMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CEQ_MIN", true));
            this.lblCeqMin.Location = new System.Drawing.Point(412, 170);
            this.lblCeqMin.Name = "lblCeqMin";
            this.lblCeqMin.Size = new System.Drawing.Size(23, 12);
            this.lblCeqMin.TabIndex = 101;
            this.lblCeqMin.Text = "XXX";
            // 
            // lblPbMin
            // 
            this.lblPbMin.AutoSize = true;
            this.lblPbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.PB_MIN", true));
            this.lblPbMin.Location = new System.Drawing.Point(322, 170);
            this.lblPbMin.Name = "lblPbMin";
            this.lblPbMin.Size = new System.Drawing.Size(23, 12);
            this.lblPbMin.TabIndex = 105;
            this.lblPbMin.Text = "XXX";
            // 
            // lblWMin
            // 
            this.lblWMin.AutoSize = true;
            this.lblWMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.W_MIN", true));
            this.lblWMin.Location = new System.Drawing.Point(277, 170);
            this.lblWMin.Name = "lblWMin";
            this.lblWMin.Size = new System.Drawing.Size(23, 12);
            this.lblWMin.TabIndex = 104;
            this.lblWMin.Text = "XXX";
            // 
            // lblCaMin
            // 
            this.lblCaMin.AutoSize = true;
            this.lblCaMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CA_MIN", true));
            this.lblCaMin.Location = new System.Drawing.Point(232, 170);
            this.lblCaMin.Name = "lblCaMin";
            this.lblCaMin.Size = new System.Drawing.Size(23, 12);
            this.lblCaMin.TabIndex = 97;
            this.lblCaMin.Text = "XXX";
            // 
            // lblZrMin
            // 
            this.lblZrMin.AutoSize = true;
            this.lblZrMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZR_MIN", true));
            this.lblZrMin.Location = new System.Drawing.Point(187, 170);
            this.lblZrMin.Name = "lblZrMin";
            this.lblZrMin.Size = new System.Drawing.Size(23, 12);
            this.lblZrMin.TabIndex = 96;
            this.lblZrMin.Text = "XXX";
            // 
            // lblZnMin
            // 
            this.lblZnMin.AutoSize = true;
            this.lblZnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ZN_AIM", true));
            this.lblZnMin.Location = new System.Drawing.Point(142, 170);
            this.lblZnMin.Name = "lblZnMin";
            this.lblZnMin.Size = new System.Drawing.Size(23, 12);
            this.lblZnMin.TabIndex = 95;
            this.lblZnMin.Text = "XXX";
            // 
            // lblAsMin
            // 
            this.lblAsMin.AutoSize = true;
            this.lblAsMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AS_MIN", true));
            this.lblAsMin.Location = new System.Drawing.Point(97, 170);
            this.lblAsMin.Name = "lblAsMin";
            this.lblAsMin.Size = new System.Drawing.Size(23, 12);
            this.lblAsMin.TabIndex = 100;
            this.lblAsMin.Text = "XXX";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other3_Min", true));
            this.label26.Location = new System.Drawing.Point(817, 170);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 12);
            this.label26.TabIndex = 99;
            this.label26.Text = "XXX";
            // 
            // lblSnMin
            // 
            this.lblSnMin.AutoSize = true;
            this.lblSnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SN_MIN", true));
            this.lblSnMin.Location = new System.Drawing.Point(817, 60);
            this.lblSnMin.Name = "lblSnMin";
            this.lblSnMin.Size = new System.Drawing.Size(23, 12);
            this.lblSnMin.TabIndex = 99;
            this.lblSnMin.Text = "XXX";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other2_Min", true));
            this.label24.Location = new System.Drawing.Point(772, 170);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 12);
            this.label24.TabIndex = 98;
            this.label24.Text = "XXX";
            // 
            // lblSbMin
            // 
            this.lblSbMin.AutoSize = true;
            this.lblSbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SB_MIN", true));
            this.lblSbMin.Location = new System.Drawing.Point(772, 60);
            this.lblSbMin.Name = "lblSbMin";
            this.lblSbMin.Size = new System.Drawing.Size(23, 12);
            this.lblSbMin.TabIndex = 98;
            this.lblSbMin.Text = "XXX";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(591, 133);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(29, 12);
            this.label186.TabIndex = 94;
            this.label186.Text = "CrNi";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(552, 133);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(11, 12);
            this.label182.TabIndex = 92;
            this.label182.Text = "H";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(508, 133);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(11, 12);
            this.label185.TabIndex = 88;
            this.label185.Text = "0";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(464, 133);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(11, 12);
            this.label183.TabIndex = 87;
            this.label183.Text = "N";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(413, 133);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(23, 12);
            this.label181.TabIndex = 86;
            this.label181.Text = "Ceq";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(371, 133);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(17, 12);
            this.label180.TabIndex = 91;
            this.label180.Text = "Re";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(326, 133);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(17, 12);
            this.label179.TabIndex = 90;
            this.label179.Text = "Pb";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(284, 133);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(11, 12);
            this.label178.TabIndex = 89;
            this.label178.Text = "W";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(236, 133);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(17, 12);
            this.label177.TabIndex = 82;
            this.label177.Text = "Ca";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(191, 133);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(17, 12);
            this.label176.TabIndex = 81;
            this.label176.Text = "Zr";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(146, 133);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(17, 12);
            this.label175.TabIndex = 80;
            this.label175.Text = "Zn";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(101, 133);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(17, 12);
            this.label174.TabIndex = 85;
            this.label174.Text = "As";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(810, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 84;
            this.label22.Text = "Other3";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(814, 27);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(17, 12);
            this.label173.TabIndex = 84;
            this.label173.Text = "Sn";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(765, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 83;
            this.label21.Text = "Other2";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(771, 27);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(17, 12);
            this.label172.TabIndex = 83;
            this.label172.Text = "Sb";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other1_Max", true));
            this.label20.Location = new System.Drawing.Point(727, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 74;
            this.label20.Text = "XXX";
            // 
            // lblBMax
            // 
            this.lblBMax.AutoSize = true;
            this.lblBMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.B_MAX", true));
            this.lblBMax.Location = new System.Drawing.Point(727, 88);
            this.lblBMax.Name = "lblBMax";
            this.lblBMax.Size = new System.Drawing.Size(23, 12);
            this.lblBMax.TabIndex = 74;
            this.lblBMax.Text = "XXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.Other1_Min", true));
            this.label18.Location = new System.Drawing.Point(727, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 76;
            this.label18.Text = "XXX";
            // 
            // lblBMin
            // 
            this.lblBMin.AutoSize = true;
            this.lblBMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.B_MIN", true));
            this.lblBMin.Location = new System.Drawing.Point(727, 60);
            this.lblBMin.Name = "lblBMin";
            this.lblBMin.Size = new System.Drawing.Size(23, 12);
            this.lblBMin.TabIndex = 76;
            this.lblBMin.Text = "XXX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(721, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 79;
            this.label17.Text = "Other1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(727, 27);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(11, 12);
            this.label40.TabIndex = 79;
            this.label40.Text = "B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNiCu_Max", true));
            this.label16.Location = new System.Drawing.Point(682, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 77;
            this.label16.Text = "XXX";
            // 
            // lblTiMax
            // 
            this.lblTiMax.AutoSize = true;
            this.lblTiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.TI_MAX", true));
            this.lblTiMax.Location = new System.Drawing.Point(682, 88);
            this.lblTiMax.Name = "lblTiMax";
            this.lblTiMax.Size = new System.Drawing.Size(23, 12);
            this.lblTiMax.TabIndex = 77;
            this.lblTiMax.Text = "XXX";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrNiCu_Min", true));
            this.label15.Location = new System.Drawing.Point(682, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 67;
            this.label15.Text = "XXX";
            // 
            // lblTiMin
            // 
            this.lblTiMin.AutoSize = true;
            this.lblTiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.TI_MIN", true));
            this.lblTiMin.Location = new System.Drawing.Point(682, 60);
            this.lblTiMin.Name = "lblTiMin";
            this.lblTiMin.Size = new System.Drawing.Size(23, 12);
            this.lblTiMin.TabIndex = 67;
            this.lblTiMin.Text = "XXX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(675, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 66;
            this.label14.Text = "CrNiCu";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(680, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 12);
            this.label38.TabIndex = 66;
            this.label38.Text = "Ti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrCu_Max", true));
            this.label13.Location = new System.Drawing.Point(637, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 68;
            this.label13.Text = "XXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CrCu_Min", true));
            this.label12.Location = new System.Drawing.Point(637, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 70;
            this.label12.Text = "XXX";
            // 
            // lblAlsMax
            // 
            this.lblAlsMax.AutoSize = true;
            this.lblAlsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ALS_MAX", true));
            this.lblAlsMax.Location = new System.Drawing.Point(637, 88);
            this.lblAlsMax.Name = "lblAlsMax";
            this.lblAlsMax.Size = new System.Drawing.Size(23, 12);
            this.lblAlsMax.TabIndex = 68;
            this.lblAlsMax.Text = "XXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 69;
            this.label11.Text = "CrCu";
            // 
            // lblAlsMin
            // 
            this.lblAlsMin.AutoSize = true;
            this.lblAlsMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.ALS_MIN", true));
            this.lblAlsMin.Location = new System.Drawing.Point(637, 60);
            this.lblAlsMin.Name = "lblAlsMin";
            this.lblAlsMin.Size = new System.Drawing.Size(23, 12);
            this.lblAlsMin.TabIndex = 70;
            this.lblAlsMin.Text = "XXX";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(634, 27);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 12);
            this.label37.TabIndex = 69;
            this.label37.Text = "Als";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(56, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 12);
            this.label32.TabIndex = 44;
            this.label32.Text = "最大:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(56, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 42;
            this.label30.Text = "最小:";
            // 
            // lblAlMax
            // 
            this.lblAlMax.AutoSize = true;
            this.lblAlMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AL_MAX", true));
            this.lblAlMax.Location = new System.Drawing.Point(592, 88);
            this.lblAlMax.Name = "lblAlMax";
            this.lblAlMax.Size = new System.Drawing.Size(23, 12);
            this.lblAlMax.TabIndex = 48;
            this.lblAlMax.Text = "XXX";
            // 
            // lblAlMin
            // 
            this.lblAlMin.AutoSize = true;
            this.lblAlMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.AL_MIN", true));
            this.lblAlMin.Location = new System.Drawing.Point(592, 60);
            this.lblAlMin.Name = "lblAlMin";
            this.lblAlMin.Size = new System.Drawing.Size(23, 12);
            this.lblAlMin.TabIndex = 46;
            this.lblAlMin.Text = "XXX";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(590, 27);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(17, 12);
            this.label94.TabIndex = 35;
            this.label94.Text = "Al";
            // 
            // lblNbMax
            // 
            this.lblNbMax.AutoSize = true;
            this.lblNbMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NB_MAX", true));
            this.lblNbMax.Location = new System.Drawing.Point(547, 88);
            this.lblNbMax.Name = "lblNbMax";
            this.lblNbMax.Size = new System.Drawing.Size(23, 12);
            this.lblNbMax.TabIndex = 33;
            this.lblNbMax.Text = "XXX";
            // 
            // lblNbMin
            // 
            this.lblNbMin.AutoSize = true;
            this.lblNbMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NB_MIN", true));
            this.lblNbMin.Location = new System.Drawing.Point(547, 60);
            this.lblNbMin.Name = "lblNbMin";
            this.lblNbMin.Size = new System.Drawing.Size(23, 12);
            this.lblNbMin.TabIndex = 39;
            this.lblNbMin.Text = "XXX";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(547, 27);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(17, 12);
            this.label89.TabIndex = 40;
            this.label89.Text = "Nb";
            // 
            // lblVMax
            // 
            this.lblVMax.AutoSize = true;
            this.lblVMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.V_MAX", true));
            this.lblVMax.Location = new System.Drawing.Point(502, 88);
            this.lblVMax.Name = "lblVMax";
            this.lblVMax.Size = new System.Drawing.Size(23, 12);
            this.lblVMax.TabIndex = 38;
            this.lblVMax.Text = "XXX";
            // 
            // lblVMin
            // 
            this.lblVMin.AutoSize = true;
            this.lblVMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.V_MIN", true));
            this.lblVMin.Location = new System.Drawing.Point(502, 60);
            this.lblVMin.Name = "lblVMin";
            this.lblVMin.Size = new System.Drawing.Size(23, 12);
            this.lblVMin.TabIndex = 60;
            this.lblVMin.Text = "XXX";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(503, 27);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(11, 12);
            this.label84.TabIndex = 57;
            this.label84.Text = "V";
            // 
            // lblMoMax
            // 
            this.lblMoMax.AutoSize = true;
            this.lblMoMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MO_MAX", true));
            this.lblMoMax.Location = new System.Drawing.Point(457, 88);
            this.lblMoMax.Name = "lblMoMax";
            this.lblMoMax.Size = new System.Drawing.Size(23, 12);
            this.lblMoMax.TabIndex = 63;
            this.lblMoMax.Text = "XXX";
            // 
            // lblMoMin
            // 
            this.lblMoMin.AutoSize = true;
            this.lblMoMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MO_MIN", true));
            this.lblMoMin.Location = new System.Drawing.Point(457, 60);
            this.lblMoMin.Name = "lblMoMin";
            this.lblMoMin.Size = new System.Drawing.Size(23, 12);
            this.lblMoMin.TabIndex = 61;
            this.lblMoMin.Text = "XXX";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(456, 27);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(17, 12);
            this.label79.TabIndex = 62;
            this.label79.Text = "Mo";
            // 
            // lblCrMax
            // 
            this.lblCrMax.AutoSize = true;
            this.lblCrMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CR_MAX", true));
            this.lblCrMax.Location = new System.Drawing.Point(412, 88);
            this.lblCrMax.Name = "lblCrMax";
            this.lblCrMax.Size = new System.Drawing.Size(23, 12);
            this.lblCrMax.TabIndex = 52;
            this.lblCrMax.Text = "XXX";
            // 
            // lblCrMin
            // 
            this.lblCrMin.AutoSize = true;
            this.lblCrMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CR_MIN", true));
            this.lblCrMin.Location = new System.Drawing.Point(412, 60);
            this.lblCrMin.Name = "lblCrMin";
            this.lblCrMin.Size = new System.Drawing.Size(23, 12);
            this.lblCrMin.TabIndex = 50;
            this.lblCrMin.Text = "XXX";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(411, 27);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(17, 12);
            this.label74.TabIndex = 55;
            this.label74.Text = "Cr";
            // 
            // lblNiMax
            // 
            this.lblNiMax.AutoSize = true;
            this.lblNiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NI_MAX", true));
            this.lblNiMax.Location = new System.Drawing.Point(367, 88);
            this.lblNiMax.Name = "lblNiMax";
            this.lblNiMax.Size = new System.Drawing.Size(23, 12);
            this.lblNiMax.TabIndex = 53;
            this.lblNiMax.Text = "XXX";
            // 
            // lblNiMin
            // 
            this.lblNiMin.AutoSize = true;
            this.lblNiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.NI_MIN", true));
            this.lblNiMin.Location = new System.Drawing.Point(367, 60);
            this.lblNiMin.Name = "lblNiMin";
            this.lblNiMin.Size = new System.Drawing.Size(23, 12);
            this.lblNiMin.TabIndex = 11;
            this.lblNiMin.Text = "XXX";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(366, 27);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(17, 12);
            this.label69.TabIndex = 12;
            this.label69.Text = "Ni";
            // 
            // lblCuMax
            // 
            this.lblCuMax.AutoSize = true;
            this.lblCuMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CU_MAX", true));
            this.lblCuMax.Location = new System.Drawing.Point(321, 88);
            this.lblCuMax.Name = "lblCuMax";
            this.lblCuMax.Size = new System.Drawing.Size(23, 12);
            this.lblCuMax.TabIndex = 10;
            this.lblCuMax.Text = "XXX";
            // 
            // lblCuMin
            // 
            this.lblCuMin.AutoSize = true;
            this.lblCuMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.CU_MIN", true));
            this.lblCuMin.Location = new System.Drawing.Point(322, 60);
            this.lblCuMin.Name = "lblCuMin";
            this.lblCuMin.Size = new System.Drawing.Size(23, 12);
            this.lblCuMin.TabIndex = 16;
            this.lblCuMin.Text = "XXX";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(321, 27);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 12);
            this.label64.TabIndex = 13;
            this.label64.Text = "Cu";
            // 
            // lblSMax
            // 
            this.lblSMax.AutoSize = true;
            this.lblSMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.S_MAX", true));
            this.lblSMax.Location = new System.Drawing.Point(277, 88);
            this.lblSMax.Name = "lblSMax";
            this.lblSMax.Size = new System.Drawing.Size(23, 12);
            this.lblSMax.TabIndex = 3;
            this.lblSMax.Text = "XXX";
            // 
            // lblSMin
            // 
            this.lblSMin.AutoSize = true;
            this.lblSMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.S_MIN", true));
            this.lblSMin.Location = new System.Drawing.Point(277, 60);
            this.lblSMin.Name = "lblSMin";
            this.lblSMin.Size = new System.Drawing.Size(23, 12);
            this.lblSMin.TabIndex = 1;
            this.lblSMin.Text = "XXX";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(279, 27);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(11, 12);
            this.label59.TabIndex = 2;
            this.label59.Text = "S";
            // 
            // lblPMax
            // 
            this.lblPMax.AutoSize = true;
            this.lblPMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.P_MAX", true));
            this.lblPMax.Location = new System.Drawing.Point(232, 88);
            this.lblPMax.Name = "lblPMax";
            this.lblPMax.Size = new System.Drawing.Size(23, 12);
            this.lblPMax.TabIndex = 8;
            this.lblPMax.Text = "XXX";
            // 
            // lblPMin
            // 
            this.lblPMin.AutoSize = true;
            this.lblPMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.P_MIN", true));
            this.lblPMin.Location = new System.Drawing.Point(232, 60);
            this.lblPMin.Name = "lblPMin";
            this.lblPMin.Size = new System.Drawing.Size(23, 12);
            this.lblPMin.TabIndex = 6;
            this.lblPMin.Text = "XXX";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(234, 27);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(11, 12);
            this.label54.TabIndex = 27;
            this.label54.Text = "P";
            // 
            // lblMnMax
            // 
            this.lblMnMax.AutoSize = true;
            this.lblMnMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MN_MAX", true));
            this.lblMnMax.Location = new System.Drawing.Point(187, 88);
            this.lblMnMax.Name = "lblMnMax";
            this.lblMnMax.Size = new System.Drawing.Size(23, 12);
            this.lblMnMax.TabIndex = 25;
            this.lblMnMax.Tag = "";
            this.lblMnMax.Text = "XXX";
            // 
            // lblMnMin
            // 
            this.lblMnMin.AutoSize = true;
            this.lblMnMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.MN_MIN", true));
            this.lblMnMin.Location = new System.Drawing.Point(187, 60);
            this.lblMnMin.Name = "lblMnMin";
            this.lblMnMin.Size = new System.Drawing.Size(23, 12);
            this.lblMnMin.TabIndex = 31;
            this.lblMnMin.Tag = "";
            this.lblMnMin.Text = "XXX";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(186, 27);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(17, 12);
            this.label49.TabIndex = 32;
            this.label49.Text = "Mn";
            // 
            // lblSiMax
            // 
            this.lblSiMax.AutoSize = true;
            this.lblSiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SI_MAX", true));
            this.lblSiMax.Location = new System.Drawing.Point(142, 88);
            this.lblSiMax.Name = "lblSiMax";
            this.lblSiMax.Size = new System.Drawing.Size(23, 12);
            this.lblSiMax.TabIndex = 30;
            this.lblSiMax.Tag = "Si";
            this.lblSiMax.Text = "XXX";
            // 
            // lblSiMin
            // 
            this.lblSiMin.AutoSize = true;
            this.lblSiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.SI_MIN", true));
            this.lblSiMin.Location = new System.Drawing.Point(142, 60);
            this.lblSiMin.Name = "lblSiMin";
            this.lblSiMin.Size = new System.Drawing.Size(23, 12);
            this.lblSiMin.TabIndex = 20;
            this.lblSiMin.Tag = "Si";
            this.lblSiMin.Text = "XXX";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(141, 27);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(17, 12);
            this.label44.TabIndex = 17;
            this.label44.Text = "Si";
            // 
            // lblCMax
            // 
            this.lblCMax.AutoSize = true;
            this.lblCMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.C_MAX", true));
            this.lblCMax.Location = new System.Drawing.Point(97, 88);
            this.lblCMax.Name = "lblCMax";
            this.lblCMax.Size = new System.Drawing.Size(23, 12);
            this.lblCMax.TabIndex = 23;
            this.lblCMax.Tag = "C";
            this.lblCMax.Text = "XXX";
            // 
            // lblCMin
            // 
            this.lblCMin.AutoSize = true;
            this.lblCMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsChemicalStd, "L3DataTable.C_MIN", true));
            this.lblCMin.Location = new System.Drawing.Point(97, 60);
            this.lblCMin.Name = "lblCMin";
            this.lblCMin.Size = new System.Drawing.Size(23, 12);
            this.lblCMin.TabIndex = 21;
            this.lblCMin.Tag = "C";
            this.lblCMin.Text = "XXX";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(99, 27);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(11, 12);
            this.label39.TabIndex = 22;
            this.label39.Text = "C";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.gbxHeatExcept);
            this.pnlTop.Controls.Add(this.gbxHeatGrade);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(853, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // gbxHeatExcept
            // 
            this.gbxHeatExcept.Controls.Add(this.dvHeatExcept);
            this.gbxHeatExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxHeatExcept.Location = new System.Drawing.Point(191, 0);
            this.gbxHeatExcept.Name = "gbxHeatExcept";
            this.gbxHeatExcept.Padding = new System.Windows.Forms.Padding(0);
            this.gbxHeatExcept.Size = new System.Drawing.Size(662, 100);
            this.gbxHeatExcept.TabIndex = 2;
            this.gbxHeatExcept.TabStop = false;
            this.gbxHeatExcept.Text = "炉次异常";
            // 
            // dvHeatExcept
            // 
            this.dvHeatExcept.AllowUserToAddRows = false;
            this.dvHeatExcept.AutoGenerateColumns = false;
            this.dvHeatExcept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvHeatExcept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dvHeatExcept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatExcept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvHeatExcept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitTypeIDDataGridViewTextBoxColumn1,
            this.exceptionalCodeDataGridViewTextBoxColumn1,
            this.iDObjectDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn2,
            this.processCountDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.preHeatIDDataGridViewTextBoxColumn1,
            this.preSteelGradeIndexDataGridViewTextBoxColumn1,
            this.steelGradeIndexDataGridViewTextBoxColumn1,
            this.decideCodeDataGridViewTextBoxColumn1,
            this.classifyDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn});
            this.dvHeatExcept.DataSource = this.bsHeatExcept;
            this.dvHeatExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatExcept.Location = new System.Drawing.Point(0, 14);
            this.dvHeatExcept.Name = "dvHeatExcept";
            this.dvHeatExcept.ReadOnly = true;
            this.dvHeatExcept.RowTemplate.Height = 23;
            this.dvHeatExcept.Size = new System.Drawing.Size(662, 86);
            this.dvHeatExcept.TabIndex = 3;
            this.dvHeatExcept.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvHeatExcept_RowPostPaint);
            // 
            // unitTypeIDDataGridViewTextBoxColumn1
            // 
            this.unitTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitTypeIDDataGridViewTextBoxColumn1.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn1.Name = "unitTypeIDDataGridViewTextBoxColumn1";
            this.unitTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitTypeIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitTypeIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitTypeIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // exceptionalCodeDataGridViewTextBoxColumn1
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn1.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.exceptionalCodeDataGridViewTextBoxColumn1.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn1.Name = "exceptionalCodeDataGridViewTextBoxColumn1";
            this.exceptionalCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.exceptionalCodeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalCodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalCodeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "身份标识";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            this.iDObjectDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            this.heatIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn2.Width = 54;
            // 
            // processCountDataGridViewTextBoxColumn1
            // 
            this.processCountDataGridViewTextBoxColumn1.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn1.HeaderText = "处理次数";
            this.processCountDataGridViewTextBoxColumn1.Name = "processCountDataGridViewTextBoxColumn1";
            this.processCountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.processCountDataGridViewTextBoxColumn1.Width = 78;
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // preHeatIDDataGridViewTextBoxColumn1
            // 
            this.preHeatIDDataGridViewTextBoxColumn1.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn1.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn1.Name = "preHeatIDDataGridViewTextBoxColumn1";
            this.preHeatIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn1
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn1.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn1.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn1.Name = "preSteelGradeIndexDataGridViewTextBoxColumn1";
            this.preSteelGradeIndexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn1.Width = 102;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn1
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn1.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn1.HeaderText = "作业炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn1.Name = "steelGradeIndexDataGridViewTextBoxColumn1";
            this.steelGradeIndexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn1.Width = 102;
            // 
            // decideCodeDataGridViewTextBoxColumn1
            // 
            this.decideCodeDataGridViewTextBoxColumn1.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn1.HeaderText = "处置代码";
            this.decideCodeDataGridViewTextBoxColumn1.Name = "decideCodeDataGridViewTextBoxColumn1";
            this.decideCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.decideCodeDataGridViewTextBoxColumn1.Visible = false;
            this.decideCodeDataGridViewTextBoxColumn1.Width = 78;
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
            // gbxHeatGrade
            // 
            this.gbxHeatGrade.Controls.Add(this.dvHeatGrade);
            this.gbxHeatGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxHeatGrade.Location = new System.Drawing.Point(0, 0);
            this.gbxHeatGrade.Name = "gbxHeatGrade";
            this.gbxHeatGrade.Padding = new System.Windows.Forms.Padding(0);
            this.gbxHeatGrade.Size = new System.Drawing.Size(191, 100);
            this.gbxHeatGrade.TabIndex = 0;
            this.gbxHeatGrade.TabStop = false;
            this.gbxHeatGrade.Text = "炉次品质";
            this.gbxHeatGrade.Visible = false;
            // 
            // dvHeatGrade
            // 
            this.dvHeatGrade.AllowUserToAddRows = false;
            this.dvHeatGrade.AutoGenerateColumns = false;
            this.dvHeatGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvHeatGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dvHeatGrade.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvHeatGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn1,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.heatGradeDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn});
            this.dvHeatGrade.DataSource = this.bsHeatGrade;
            this.dvHeatGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatGrade.Location = new System.Drawing.Point(0, 14);
            this.dvHeatGrade.Name = "dvHeatGrade";
            this.dvHeatGrade.ReadOnly = true;
            this.dvHeatGrade.RowTemplate.Height = 23;
            this.dvHeatGrade.Size = new System.Drawing.Size(191, 86);
            this.dvHeatGrade.TabIndex = 2;
            this.dvHeatGrade.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvHeatGrade_RowPostPaint);
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.exceptionalCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            this.heatIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "ProcessCount";
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
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // heatGradeDataGridViewTextBoxColumn
            // 
            this.heatGradeDataGridViewTextBoxColumn.DataPropertyName = "HeatGrade";
            this.heatGradeDataGridViewTextBoxColumn.HeaderText = "炉次等级";
            this.heatGradeDataGridViewTextBoxColumn.Name = "heatGradeDataGridViewTextBoxColumn";
            this.heatGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatGradeDataGridViewTextBoxColumn.Width = 78;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "作业炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // dataLogModeDataGridViewTextBoxColumn
            // 
            this.dataLogModeDataGridViewTextBoxColumn.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn.HeaderText = "数据产生方式";
            this.dataLogModeDataGridViewTextBoxColumn.Name = "dataLogModeDataGridViewTextBoxColumn";
            this.dataLogModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLogModeDataGridViewTextBoxColumn.Width = 102;
            // 
            // l3cmdpSteelGrade
            // 
            this.l3cmdpSteelGrade.AcceptAfterExecuted = false;
            this.l3cmdpSteelGrade.ConstantValue = null;
            this.l3cmdpSteelGrade.MergeTarget = false;
            this.l3cmdpSteelGrade.SourceFilter = null;
            this.l3cmdpSteelGrade.SourceObject = null;
            this.l3cmdpSteelGrade.SourceProperty = null;
            this.l3cmdpSteelGrade.TargetObject = null;
            this.l3cmdpSteelGrade.TargetProperty = null;
            // 
            // l3cmdpSteelGradeIndex
            // 
            this.l3cmdpSteelGradeIndex.AcceptAfterExecuted = false;
            this.l3cmdpSteelGradeIndex.ConstantValue = null;
            this.l3cmdpSteelGradeIndex.MergeTarget = false;
            this.l3cmdpSteelGradeIndex.SourceFilter = null;
            this.l3cmdpSteelGradeIndex.SourceObject = null;
            this.l3cmdpSteelGradeIndex.SourceProperty = null;
            this.l3cmdpSteelGradeIndex.TargetObject = null;
            this.l3cmdpSteelGradeIndex.TargetProperty = null;
            // 
            // cmdJudge
            // 
            this.cmdJudge.Adapter = this.Adapter;
            this.cmdJudge.MergeReturnTarget = false;
            this.cmdJudge.Method = "BofSteelQualityJudge";
            this.cmdJudge.Object = "XGMESLogic\\QualityMag\\CQA_HeatGradeAssume_Mag\\QA_HeatGradeAssume_Mag";
            this.cmdJudge.Parameters.Add(this.l3CommandParameter2);
            this.cmdJudge.ReturnTarget = null;
            this.cmdJudge.ReturnTargetProperty = null;
            this.cmdJudge.Trigger = null;
            this.cmdJudge.TriggerEvent = "Click";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HEATID";
            this.dataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HEATID";
            this.dataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn3.HeaderText = "C";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Si";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn6.HeaderText = "P";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn7.HeaderText = "S";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CU";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cu";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NI";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ni";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CR";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cr";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "V";
            this.dataGridViewTextBoxColumn12.HeaderText = "V";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "NB";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nb";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AL";
            this.dataGridViewTextBoxColumn14.HeaderText = "Al";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ALS";
            this.dataGridViewTextBoxColumn15.HeaderText = "AlS";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TI";
            this.dataGridViewTextBoxColumn16.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn17.HeaderText = "B";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 50;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SB";
            this.dataGridViewTextBoxColumn18.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 50;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "AS";
            this.dataGridViewTextBoxColumn19.HeaderText = "As";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 50;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "SN";
            this.dataGridViewTextBoxColumn20.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ZN";
            this.dataGridViewTextBoxColumn21.HeaderText = "Zn";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CA";
            this.dataGridViewTextBoxColumn22.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn23.HeaderText = "W";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "PB";
            this.dataGridViewTextBoxColumn24.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 50;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "RE";
            this.dataGridViewTextBoxColumn25.HeaderText = "Re";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 50;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CEQ";
            this.dataGridViewTextBoxColumn26.HeaderText = "Ceq";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "N";
            this.dataGridViewTextBoxColumn27.HeaderText = "N";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 50;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "H";
            this.dataGridViewTextBoxColumn28.HeaderText = "H";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 50;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn29.HeaderText = "O";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 50;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "CrNi";
            this.dataGridViewTextBoxColumn30.HeaderText = "CrNi";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 54;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "CrCu";
            this.dataGridViewTextBoxColumn31.HeaderText = "CrCu";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 54;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "CrNiCu";
            this.dataGridViewTextBoxColumn32.HeaderText = "CrNiCu";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 66;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "OTHER1";
            this.dataGridViewTextBoxColumn33.HeaderText = "其他1";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 60;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "OTHER2";
            this.dataGridViewTextBoxColumn34.HeaderText = "其他2";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 60;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Other3";
            this.dataGridViewTextBoxColumn35.HeaderText = "其他3";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 60;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "SAMPLE_COUNT";
            this.dataGridViewTextBoxColumn36.HeaderText = "取样次数";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 78;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "SAMPLE_CODE";
            this.dataGridViewTextBoxColumn37.HeaderText = "试样编码";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 78;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "ARRIVE_DATE";
            this.dataGridViewTextBoxColumn38.HeaderText = "到样时间";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 78;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "REPORT_DATE";
            this.dataGridViewTextBoxColumn39.HeaderText = "报告时间";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 78;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "UNITID";
            this.dataGridViewTextBoxColumn40.HeaderText = "工位";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 54;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "LOGTIME";
            this.dataGridViewTextBoxColumn41.HeaderText = "数据记录时间";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 102;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "DATALOGMODE";
            this.dataGridViewTextBoxColumn42.HeaderText = "数据产生方式";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 102;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "APPID";
            this.dataGridViewTextBoxColumn43.HeaderText = "委托单编号";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 90;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "HEATID";
            this.dataGridViewTextBoxColumn44.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 60;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn45.HeaderText = "C";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Width = 50;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "SI";
            this.dataGridViewTextBoxColumn46.HeaderText = "Si";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Width = 50;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "MN";
            this.dataGridViewTextBoxColumn47.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Width = 50;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn48.HeaderText = "P";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Width = 50;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn49.HeaderText = "S";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Width = 50;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "CU";
            this.dataGridViewTextBoxColumn50.HeaderText = "Cu";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Width = 50;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "NI";
            this.dataGridViewTextBoxColumn51.HeaderText = "Ni";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 50;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "CR";
            this.dataGridViewTextBoxColumn52.HeaderText = "Cr";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Width = 50;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "MO";
            this.dataGridViewTextBoxColumn53.HeaderText = "Mo";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Width = 50;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "V";
            this.dataGridViewTextBoxColumn54.HeaderText = "V";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 50;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "NB";
            this.dataGridViewTextBoxColumn55.HeaderText = "Nb";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 50;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "AL";
            this.dataGridViewTextBoxColumn56.HeaderText = "Al";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Width = 50;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "ALS";
            this.dataGridViewTextBoxColumn57.HeaderText = "AlS";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Width = 50;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "TI";
            this.dataGridViewTextBoxColumn58.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Width = 50;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn59.HeaderText = "B";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Width = 50;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "SB";
            this.dataGridViewTextBoxColumn60.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Width = 50;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "AS";
            this.dataGridViewTextBoxColumn61.HeaderText = "As";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 50;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "SN";
            this.dataGridViewTextBoxColumn62.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 50;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "ZN";
            this.dataGridViewTextBoxColumn63.HeaderText = "Zn";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 50;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "CA";
            this.dataGridViewTextBoxColumn64.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Width = 50;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn65.HeaderText = "W";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Width = 50;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "PB";
            this.dataGridViewTextBoxColumn66.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            this.dataGridViewTextBoxColumn66.Width = 50;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "RE";
            this.dataGridViewTextBoxColumn67.HeaderText = "Re";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            this.dataGridViewTextBoxColumn67.Width = 50;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "CEQ";
            this.dataGridViewTextBoxColumn68.HeaderText = "Ceq";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Width = 50;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "N";
            this.dataGridViewTextBoxColumn69.HeaderText = "N";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Width = 50;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "H";
            this.dataGridViewTextBoxColumn70.HeaderText = "H";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            this.dataGridViewTextBoxColumn70.Width = 50;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn71.HeaderText = "O";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.Width = 50;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "CrNi";
            this.dataGridViewTextBoxColumn72.HeaderText = "CrNi";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.Width = 54;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "CrCu";
            this.dataGridViewTextBoxColumn73.HeaderText = "CrCu";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            this.dataGridViewTextBoxColumn73.Width = 54;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "CrNiCu";
            this.dataGridViewTextBoxColumn74.HeaderText = "CrNiCu";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Width = 66;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "OTHER1";
            this.dataGridViewTextBoxColumn75.HeaderText = "其他1";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Width = 60;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "OTHER2";
            this.dataGridViewTextBoxColumn76.HeaderText = "其他2";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Width = 60;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "Other3";
            this.dataGridViewTextBoxColumn77.HeaderText = "其他3";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            this.dataGridViewTextBoxColumn77.Width = 60;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "SAMPLE_COUNT";
            this.dataGridViewTextBoxColumn78.HeaderText = "取样次数";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            this.dataGridViewTextBoxColumn78.Width = 78;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "SAMPLE_CODE";
            this.dataGridViewTextBoxColumn79.HeaderText = "试样编码";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Width = 78;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "ARRIVE_DATE";
            this.dataGridViewTextBoxColumn80.HeaderText = "到样时间";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Width = 78;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "REPORT_DATE";
            this.dataGridViewTextBoxColumn81.HeaderText = "报告时间";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            this.dataGridViewTextBoxColumn81.Width = 78;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "UNITID";
            this.dataGridViewTextBoxColumn82.HeaderText = "工位";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            this.dataGridViewTextBoxColumn82.Width = 54;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "LOGTIME";
            this.dataGridViewTextBoxColumn83.HeaderText = "数据记录时间";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            this.dataGridViewTextBoxColumn83.Width = 102;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "DATALOGMODE";
            this.dataGridViewTextBoxColumn84.HeaderText = "数据产生方式";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            this.dataGridViewTextBoxColumn84.ReadOnly = true;
            this.dataGridViewTextBoxColumn84.Width = 102;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "APPID";
            this.dataGridViewTextBoxColumn85.HeaderText = "委托单编号";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            this.dataGridViewTextBoxColumn85.ReadOnly = true;
            this.dataGridViewTextBoxColumn85.Width = 90;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "ID_Object";
            this.dataGridViewTextBoxColumn86.HeaderText = "身份标识";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            this.dataGridViewTextBoxColumn86.Visible = false;
            this.dataGridViewTextBoxColumn86.Width = 78;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn87.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.ReadOnly = true;
            this.dataGridViewTextBoxColumn87.Width = 54;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "Process_Count";
            this.dataGridViewTextBoxColumn88.HeaderText = "处理次数";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.ReadOnly = true;
            this.dataGridViewTextBoxColumn88.Width = 78;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn89.HeaderText = "工位";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            this.dataGridViewTextBoxColumn89.Width = 54;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "PreHeatID";
            this.dataGridViewTextBoxColumn90.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.ReadOnly = true;
            this.dataGridViewTextBoxColumn90.Width = 78;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "Pre_SteelGradeIndex";
            this.dataGridViewTextBoxColumn91.HeaderText = "预定炼钢记号";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.ReadOnly = true;
            this.dataGridViewTextBoxColumn91.Width = 102;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn92.HeaderText = "作业炼钢记号";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            this.dataGridViewTextBoxColumn92.ReadOnly = true;
            this.dataGridViewTextBoxColumn92.Width = 102;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "Decide_Code";
            this.dataGridViewTextBoxColumn93.HeaderText = "处置代码";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.ReadOnly = true;
            this.dataGridViewTextBoxColumn93.Visible = false;
            this.dataGridViewTextBoxColumn93.Width = 78;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "Classify";
            this.dataGridViewTextBoxColumn94.HeaderText = "优先级";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.ReadOnly = true;
            this.dataGridViewTextBoxColumn94.Width = 66;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.DataPropertyName = "Exceptional_Time";
            this.dataGridViewTextBoxColumn95.HeaderText = "异常产生时间";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.ReadOnly = true;
            this.dataGridViewTextBoxColumn95.Width = 102;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn96.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.ReadOnly = true;
            this.dataGridViewTextBoxColumn96.Width = 54;
            // 
            // dataGridViewTextBoxColumn97
            // 
            this.dataGridViewTextBoxColumn97.DataPropertyName = "ProcessCount";
            this.dataGridViewTextBoxColumn97.HeaderText = "处理次数";
            this.dataGridViewTextBoxColumn97.Name = "dataGridViewTextBoxColumn97";
            this.dataGridViewTextBoxColumn97.ReadOnly = true;
            this.dataGridViewTextBoxColumn97.Width = 78;
            // 
            // dataGridViewTextBoxColumn98
            // 
            this.dataGridViewTextBoxColumn98.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn98.HeaderText = "工序";
            this.dataGridViewTextBoxColumn98.Name = "dataGridViewTextBoxColumn98";
            this.dataGridViewTextBoxColumn98.ReadOnly = true;
            this.dataGridViewTextBoxColumn98.Width = 54;
            // 
            // dataGridViewTextBoxColumn99
            // 
            this.dataGridViewTextBoxColumn99.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn99.HeaderText = "工位";
            this.dataGridViewTextBoxColumn99.Name = "dataGridViewTextBoxColumn99";
            this.dataGridViewTextBoxColumn99.ReadOnly = true;
            this.dataGridViewTextBoxColumn99.Width = 54;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.DataPropertyName = "HeatGrade";
            this.dataGridViewTextBoxColumn100.HeaderText = "炉次等级";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.ReadOnly = true;
            this.dataGridViewTextBoxColumn100.Width = 78;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.DataPropertyName = "PreHeatID";
            this.dataGridViewTextBoxColumn101.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.ReadOnly = true;
            this.dataGridViewTextBoxColumn101.Width = 78;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.DataPropertyName = "Pre_SteelGradeIndex";
            this.dataGridViewTextBoxColumn102.HeaderText = "预定炼钢记号";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.ReadOnly = true;
            this.dataGridViewTextBoxColumn102.Width = 102;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn103.HeaderText = "作业炼钢记号";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.ReadOnly = true;
            this.dataGridViewTextBoxColumn103.Width = 102;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.DataPropertyName = "DataLogMode";
            this.dataGridViewTextBoxColumn104.HeaderText = "数据产生方式";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.ReadOnly = true;
            this.dataGridViewTextBoxColumn104.Width = 102;
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
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = null;
            this.l3CommandParameter8.SourceObject = null;
            this.l3CommandParameter8.SourceProperty = null;
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = null;
            this.l3CommandParameter9.SourceObject = null;
            this.l3CommandParameter9.SourceProperty = null;
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // l3CommandParameter10
            // 
            this.l3CommandParameter10.AcceptAfterExecuted = false;
            this.l3CommandParameter10.ConstantValue = null;
            this.l3CommandParameter10.MergeTarget = false;
            this.l3CommandParameter10.SourceFilter = null;
            this.l3CommandParameter10.SourceObject = null;
            this.l3CommandParameter10.SourceProperty = null;
            this.l3CommandParameter10.TargetObject = null;
            this.l3CommandParameter10.TargetProperty = null;
            // 
            // SteelWaterToBXGJudgeFrm
            // 
            this.Adapter.SetAccessRight(this, "BofSteelWaterToBXGJudge");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 695);
            this.Controls.Add(this.hmiRootPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelWaterToBXGJudgeFrm";
            this.TabText = "转炉钢水直送不锈钢判定";
            this.Text = "转炉钢水直送不锈钢质量判定";
            this.Load += new System.EventHandler(this.SteelWaterToBXGJudgeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsChemicalStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemicalStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefineThirdEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinalChemical)).EndInit();
            this.hmiRootPanelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvRefineThirdEle)).EndInit();
            this.gbxFinalChemical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalChemical)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxChemicalStd.ResumeLayout(false);
            this.gbxChemicalStd.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.gbxHeatExcept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcept)).EndInit();
            this.gbxHeatGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsHeatID;
        private System.Windows.Forms.BindingSource bsHeatID;
        private System.Data.DataTable schemadsHeatID;
        private System.Data.DataColumn coldsHeatIDL3DataTableHEATID;
        private AppSvrHMI.L3Command cmdHeatID;
        private AppSvrHMI.L3DataSet dsHeatGrade;
        private System.Data.DataTable schemadsHeatGrade;
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
        private System.Windows.Forms.BindingSource bsHeatGrade;
        private AppSvrHMI.L3DataSet dsHeatExcept;
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
        private System.Windows.Forms.BindingSource bsHeatExcept;
        private AppSvrHMI.L3DataSet dsChemicalStd;
        private AppSvrHMI.L3Command cmdChemicalStd;
        private System.Data.DataTable schemadsChemicalStd;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLADLE_BRICK;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLADLE_USE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLADLE_PRE_STEELGRADE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLADLE_STAY;
        private System.Data.DataColumn coldsChemicalStdL3DataTableBOF_TYPE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLADLE_TAPPED_PROC;
        private System.Data.DataColumn coldsChemicalStdL3DataTableLF_TYPE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRH_TYPE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCASTER_TYPE;
        private System.Data.DataColumn coldsChemicalStdL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableC_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSI_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSI_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSI_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMN_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMN_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMN_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableP_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableS_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCU_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCU_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCU_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNI_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNI_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNI_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCR_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCR_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCR_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMO_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMO_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableMO_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableV_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNB_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNB_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableNB_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAL_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAL_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAL_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableALS_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableALS_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableALS_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTI_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTI_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableTI_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableB_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSB_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSB_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSB_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSN_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSN_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableSN_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAS_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAS_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableAS_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZN_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZN_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZN_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZR_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZR_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableZR_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCA_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCA_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCA_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableW_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePB_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePB_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTablePB_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRE_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRE_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableRE_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCEQ_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCEQ_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCEQ_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableN_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableH_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableO_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER1_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER1_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER1_MAX;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER2_MIN;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER2_AIM;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOTHER2_MAX;
        private AppSvrHMI.L3DataSet dsFinalChemical;
        private AppSvrHMI.L3Command cmdFinalChemical;
        private System.Data.DataTable schemadsFinalChemical;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAPPID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSAMPLE_CODE;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableARRIVE_DATE;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableREPORT_DATE;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableHEATID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableUNITTYPEID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableUNITID;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSAMPLE_ADDRESS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSAMPLE_TYPE;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSAMPLE_COUNT;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableC;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSI;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableMN;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableP;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCU;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableNI;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCR;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableMO;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableV;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableNB;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAL;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableALS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableTI;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableB;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSB;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableAS;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableSN;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableZN;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCA;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableW;
        private System.Data.DataColumn coldsFinalChemicalL3DataTablePB;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableRE;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCEQ;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableN;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableH;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableO;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOTHER1;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOTHER2;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableLOGTIME;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableDATALOGMODE;
        private System.Windows.Forms.BindingSource bsFinalChemical;
        private AppSvrHMI.L3DataSet dsRefineThirdEle;
        private AppSvrHMI.L3Command cmdRefineThirdEle;
        private System.Data.DataTable schemadsRefineThirdEle;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAPPID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSAMPLE_CODE;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableARRIVE_DATE;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableREPORT_DATE;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableHEATID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableUNITTYPEID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableUNITID;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSAMPLE_ADDRESS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSAMPLE_TYPE;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSAMPLE_COUNT;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableC;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSI;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableMN;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableP;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCU;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableNI;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCR;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableMO;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableV;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableNB;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAL;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableALS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableTI;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableB;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSB;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableAS;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableSN;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableZN;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCA;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableW;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTablePB;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableRE;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCEQ;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableN;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableH;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableO;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOTHER1;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOTHER2;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableLOGTIME;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableDATALOGMODE;
        private System.Windows.Forms.BindingSource bsRefineThirdEle;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpds;
        private HMIBase.HMIRootPanel hmiRootPanelMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvHeatID;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxChemicalStd;
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
        private System.Windows.Forms.Label lblSnMin;
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
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label lblBMax;
        private System.Windows.Forms.Label lblBMin;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblTiMax;
        private System.Windows.Forms.Label lblTiMin;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblAlsMax;
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
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbxHeatExcept;
        private System.Windows.Forms.DataGridView dvHeatExcept;
        private System.Windows.Forms.GroupBox gbxHeatGrade;
        private System.Windows.Forms.DataGridView dvHeatGrade;
        private AppSvrHMI.L3CommandParameter l3cmdpSteelGrade;
        private System.Windows.Forms.DataGridView dvFinalChemical;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxFinalChemical;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNi_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrCu_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableCrNiCu_Max;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Min;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Aim;
        private System.Data.DataColumn coldsChemicalStdL3DataTableOther3_Max;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableOther3;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrNi;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrCu;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCrNiCu;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableOther3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Data.DataColumn coldsFinalChemicalL3DataTableCheckFlag;
        private System.Data.DataColumn coldsRefineThirdEleL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3cmdpAppID;
        private AppSvrHMI.L3CommandParameter l3cmdpSteelGradeIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private buttonHide.MyLine myLine1;
        private buttonHide.MyLine myLine2;
        private buttonHide.MyLine myLine3;
        private buttonHide.MyLine myLine4;
        private System.Windows.Forms.DataGridView dvRefineThirdEle;
        private buttonHide.MyLine myLine5;
        private AppSvrHMI.L3Command cmdJudge;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
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
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPIDRef;
        private System.Windows.Forms.DataGridViewComboBoxColumn sAMPLETYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sAMPLEADDRESSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn uNITTYPEIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEQDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCuL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCuL;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHER1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHER22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3L;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECOUNTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVEDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPORTDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALOGMODEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlagFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPIDFin;
        private System.Windows.Forms.DataGridViewComboBoxColumn SAMPLE_TYPE1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sAMPLEADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uNITTYPEIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPORTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCuP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCuP;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHER1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHER21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3P;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATALOGMODEDataGridViewTextBoxColumn1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
       
    }
}