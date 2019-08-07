namespace EquipMag.TundishMag
{
    partial class TundishMag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishMag));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnMag = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsMag = new System.Windows.Forms.BindingSource(this.components);
            this.dsMag = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMag = new System.Data.DataTable();
            this.coldsMagL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMagL3DataTableName = new System.Data.DataColumn();
            this.coldsMagL3DataTableCreat_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsMagL3DataTableVehicle_ID = new System.Data.DataColumn();
            this.coldsMagL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsMagL3DataTableInner_Tie_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableInner_Tie_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableInner_Small_Fire_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableInner_Close_Fire_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableDaub_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableDaub_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableHot_Big_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableCast_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableCast_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsMagL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsMagL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsMagL3DataTableHot_Small_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableInstall_Start_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableInstall_End_Time = new System.Data.DataColumn();
            this.coldsMagL3DataTableConfirmFlag = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDataConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.bsInnerBuild = new System.Windows.Forms.BindingSource(this.components);
            this.dsInnerBuild = new AppSvrHMI.L3DataSet();
            this.schemadsInnerBuild = new System.Data.DataTable();
            this.coldsInnerBuildL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableInner_Use_Count = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTie_Start_Time = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTie_End_Time = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableCheck_Date = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableRefra_Fac = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableRefra_ID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableWaste = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableNote = new System.Data.DataColumn();
            this.bsInnerbuildShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsInnerBuildTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.bsInnerFire = new System.Windows.Forms.BindingSource(this.components);
            this.dsInnerFire = new AppSvrHMI.L3DataSet();
            this.schemadsInnerFire = new System.Data.DataTable();
            this.coldsInnerFireL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableSmall_Fire_Time = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableSmall_Fire_Operator = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableMid_Fire_Time = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableMid_Fire_Operator = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableBig_Fire_Time = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableBig_Fire_Operator = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableClose_Fire_Time = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableClose_Fire_Operator = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInnerFireL3DataTableNote = new System.Data.DataColumn();
            this.bsInnerFireShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.bsInnerFireTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsDaub = new System.Windows.Forms.BindingSource(this.components);
            this.dsDaub = new AppSvrHMI.L3DataSet();
            this.schemadsDaub = new System.Data.DataTable();
            this.coldsDaubL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableInner_Use_Count = new System.Data.DataColumn();
            this.coldsDaubL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsDaubL3DataTableProject = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGap_Bri_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGap_Bri_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWard_Dregs_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWard_Dregs_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTranq_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTranq_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDaub_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDaub_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDry_Flap_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDry_Flap_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGluemud_Fac = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGluemud_Consume = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDaub_Start_Time = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDaub_End_Time = new System.Data.DataColumn();
            this.coldsDaubL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsDaubL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableOperator = new System.Data.DataColumn();
            this.coldsDaubL3DataTableNote = new System.Data.DataColumn();
            this.bsDaubShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.bsDaubTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsOTInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsOTInstall = new AppSvrHMI.L3DataSet();
            this.schemadsOTInstall = new System.Data.DataTable();
            this.coldsOTInstallL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableVehicleID = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableDaub_Fac = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableFra_Case = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableSlip_Blo_Fac = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableGap_Fac = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableInstall_Per = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableInstall_Time = new System.Data.DataColumn();
            this.coldsOTInstallL3DataTableNote = new System.Data.DataColumn();
            this.bsOTIstallShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.bsTFFInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsTFFInstall = new AppSvrHMI.L3DataSet();
            this.schemadsTFFInstall = new System.Data.DataTable();
            this.coldsTFFInstallL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableDaub_Fac = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableRefra_Fac = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableFra_Switch_Case = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableCon_Per = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableGap_Fac = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableGap_Pro_Date = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableFirst_Gap_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableSecond_Gap_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableThird_Gap_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableFourth_Gap_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableStu_Sti_Fac = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableFirst_Stu_Sti_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableSecond_Stu_Sti_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableThird_Stu_Sti_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableFourth_Stu_Sti_ID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableInstall_Per = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableInstall_Time = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableNote = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableTundish_Bottom_Insulation = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableTundish_Wall_Insulation = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableChecker = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableUpper_Core = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableLower_Core = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableCore_Install_Per = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableName = new System.Data.DataColumn();
            this.coldsTFFInstallL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.bsTFFInstallShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.bsTFFInstallTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsTFFFireInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsTFFFireInfo = new AppSvrHMI.L3DataSet();
            this.schemadsTFFFireInfo = new System.Data.DataTable();
            this.coldsTFFFireInfoL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFirst_Fra_ID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSecond_Fra_ID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableThird_Fra_ID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFourth_Fra_ID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSmall_End_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableMid_Start_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableMid_End_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableBig_Start_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableBig_End_Time = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableNote = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableCrane_TeamID = new System.Data.DataColumn();
            this.coldsTFFFireInfoL3DataTableVehicleID = new System.Data.DataColumn();
            this.bsTFFHotShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.bsTFFHotTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsOTFireInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsOTFireInfo = new AppSvrHMI.L3DataSet();
            this.schemadsOTFireInfo = new System.Data.DataTable();
            this.coldsOTFireInfoL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableTundish_SeqNo = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableAdjust_Per = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableAdjust_TeamID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableMove_Case = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableNote = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableFire_Temp = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableCrane_TeamID = new System.Data.DataColumn();
            this.coldsOTFireInfoL3DataTableVehicleID = new System.Data.DataColumn();
            this.bsOTHotTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsOTHotShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.hmiRootPanel = new HMIBase.HMIRootPanel();
            this.dvMag = new System.Windows.Forms.DataGridView();
            this.creatTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TundishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerTieStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerTieEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerSmallFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerCloseFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daubStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daubEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Install_Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Install_End_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotSmallStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotBigEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMag = new System.Windows.Forms.TabControl();
            this.tabInnerBuild = new System.Windows.Forms.TabPage();
            this.pnlInnerBuild = new System.Windows.Forms.Panel();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.dtTieStartTime = new System.Windows.Forms.DateTimePicker();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dtTieEndTime = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new PxDataValid.PxTextBox();
            this.cmbRefraFac = new PxDataValid.PxComboBox();
            this.dsInnerRefraFac = new AppSvrHMI.L3DataSet();
            this.schemadsInnerRefraFac = new System.Data.DataTable();
            this.coldsInnerRefraFacL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtWaste = new PxDataValid.PxTextBox();
            this.label180 = new System.Windows.Forms.Label();
            this.cmbRefraID = new PxDataValid.PxComboBox();
            this.dsInnerRefraName = new AppSvrHMI.L3DataSet();
            this.schemadsInnerRefraName = new System.Data.DataTable();
            this.coldsInnerRefraNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCheckDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabInnerFire = new System.Windows.Forms.TabPage();
            this.textBox8 = new PxDataValid.PxTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.richTextBox1 = new PxDataValid.PxRichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtStopFireTime = new System.Windows.Forms.DateTimePicker();
            this.dtLFireTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox7 = new PxDataValid.PxTextBox();
            this.txtStopFireOper = new PxDataValid.PxTextBox();
            this.txtLFireOper = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtMFireTime = new System.Windows.Forms.DateTimePicker();
            this.dtSFireTime = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMFireOper = new PxDataValid.PxTextBox();
            this.txtSFireOper = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabDaub = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new PxDataValid.PxRichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pxComboBox4 = new PxDataValid.PxComboBox();
            this.pxComboBox5 = new PxDataValid.PxComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dtFireEnd = new System.Windows.Forms.DateTimePicker();
            this.dtFireStart = new System.Windows.Forms.DateTimePicker();
            this.dtBuildEnd = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.dtBuildStart = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtGluemudWaste = new PxDataValid.PxTextBox();
            this.txtDryFlapWaste = new PxDataValid.PxTextBox();
            this.txtDaubWaste = new PxDataValid.PxTextBox();
            this.cmbGluemudFac = new PxDataValid.PxComboBox();
            this.dsGluemudFac = new AppSvrHMI.L3DataSet();
            this.schemadsGluemudFac = new System.Data.DataTable();
            this.coldsGluemudFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbDryFlapFac = new PxDataValid.PxComboBox();
            this.dsDryMatFac = new AppSvrHMI.L3DataSet();
            this.schemadsDryMatFac = new System.Data.DataTable();
            this.coldsDryMatFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbDaubFac = new PxDataValid.PxComboBox();
            this.dsDaubFac = new AppSvrHMI.L3DataSet();
            this.schemadsDaubFac = new System.Data.DataTable();
            this.coldsDaubFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtTranqFac = new PxDataValid.PxTextBox();
            this.txtWardDregsWaste = new PxDataValid.PxTextBox();
            this.txtGapBriWaste = new PxDataValid.PxTextBox();
            this.cmbTranqFac = new PxDataValid.PxComboBox();
            this.dsTranqFac = new AppSvrHMI.L3DataSet();
            this.schemadsTranqFac = new System.Data.DataTable();
            this.coldsTranqFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbWardDregsFac = new PxDataValid.PxComboBox();
            this.dsWardDregsFac = new AppSvrHMI.L3DataSet();
            this.schemadsWardDregsFac = new System.Data.DataTable();
            this.coldsWardDregsFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbGapBriFac = new PxDataValid.PxComboBox();
            this.dsGapBriFac = new AppSvrHMI.L3DataSet();
            this.schemadsGapBriFac = new System.Data.DataTable();
            this.coldsGapBriFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtForeverFloorCount = new PxDataValid.PxTextBox();
            this.textBox9 = new PxDataValid.PxTextBox();
            this.textBox13 = new PxDataValid.PxTextBox();
            this.txtForeverFloorID = new PxDataValid.PxTextBox();
            this.cmbProject = new PxDataValid.PxComboBox();
            this.dsProject = new AppSvrHMI.L3DataSet();
            this.schemadsProject = new System.Data.DataTable();
            this.coldsProjectL3DataTableCode = new System.Data.DataColumn();
            this.coldsProjectL3DataTableCode_Des = new System.Data.DataColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tabInstall = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.dsUpGapFac = new AppSvrHMI.L3DataSet();
            this.schemadsUpGapFac = new System.Data.DataTable();
            this.coldsUpGapFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.dsSmoothBlock = new AppSvrHMI.L3DataSet();
            this.schemadsSmoothBlock = new System.Data.DataTable();
            this.coldsSmoothBlockL3DataTableMatFactory = new System.Data.DataColumn();
            this.tabTFFInstall = new System.Windows.Forms.TabPage();
            this.label104 = new System.Windows.Forms.Label();
            this.pxTextBox12 = new PxDataValid.PxTextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.pxTextBox11 = new PxDataValid.PxTextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.pxTextBox10 = new PxDataValid.PxTextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.pxTextBox9 = new PxDataValid.PxTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.pxTextBox8 = new PxDataValid.PxTextBox();
            this.pxTextBox7 = new PxDataValid.PxTextBox();
            this.richTextBox8 = new PxDataValid.PxRichTextBox();
            this.label155 = new System.Windows.Forms.Label();
            this.dateTimePicker20 = new System.Windows.Forms.DateTimePicker();
            this.label156 = new System.Windows.Forms.Label();
            this.pxComboBox32 = new PxDataValid.PxComboBox();
            this.dsStuStiFac = new AppSvrHMI.L3DataSet();
            this.schemadsStuStiFac = new System.Data.DataTable();
            this.coldsStuStiFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.dateTimePicker21 = new System.Windows.Forms.DateTimePicker();
            this.label162 = new System.Windows.Forms.Label();
            this.pxComboBox41 = new PxDataValid.PxComboBox();
            this.dsGapFac = new AppSvrHMI.L3DataSet();
            this.schemadsGapFac = new System.Data.DataTable();
            this.coldsGapFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.pxTextBox44 = new PxDataValid.PxTextBox();
            this.pxTextBox40 = new PxDataValid.PxTextBox();
            this.pxTextBox43 = new PxDataValid.PxTextBox();
            this.pxTextBox39 = new PxDataValid.PxTextBox();
            this.pxTextBox42 = new PxDataValid.PxTextBox();
            this.pxTextBox38 = new PxDataValid.PxTextBox();
            this.pxTextBox41 = new PxDataValid.PxTextBox();
            this.pxTextBox37 = new PxDataValid.PxTextBox();
            this.pxTextBox35 = new PxDataValid.PxTextBox();
            this.pxTextBox36 = new PxDataValid.PxTextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.dateTimePicker23 = new System.Windows.Forms.DateTimePicker();
            this.label174 = new System.Windows.Forms.Label();
            this.textBox3 = new PxDataValid.PxTextBox();
            this.textBox18 = new PxDataValid.PxTextBox();
            this.textBox12 = new PxDataValid.PxTextBox();
            this.label176 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.tabHotFire = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bsOTHotCraneTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.bsAdjustTeam = new System.Windows.Forms.BindingSource(this.components);
            this.tabTFFFire = new System.Windows.Forms.TabPage();
            this.label170 = new System.Windows.Forms.Label();
            this.textBox16 = new PxDataValid.PxTextBox();
            this.textBox15 = new PxDataValid.PxTextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.richTextBox4 = new PxDataValid.PxRichTextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.pxComboBox11 = new PxDataValid.PxComboBox();
            this.pxComboBox14 = new PxDataValid.PxComboBox();
            this.pxComboBox12 = new PxDataValid.PxComboBox();
            this.pxComboBox19 = new PxDataValid.PxComboBox();
            this.bsTTFHotCraneTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.pxComboBox15 = new PxDataValid.PxComboBox();
            this.pxTextBox48 = new PxDataValid.PxTextBox();
            this.pxTextBox47 = new PxDataValid.PxTextBox();
            this.pxTextBox46 = new PxDataValid.PxTextBox();
            this.pxTextBox45 = new PxDataValid.PxTextBox();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.label92 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.tabRefra = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.bsStopCastingReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsStopCastingReason = new AppSvrHMI.L3DataSet();
            this.schemadsStopCastingReason = new System.Data.DataTable();
            this.coldsStopCastingReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsStopCastingReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsCoverCaseOT = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoverCase = new AppSvrHMI.L3DataSet();
            this.schemadsCoverCaseOT = new System.Data.DataTable();
            this.coldsCoverCaseOTL3DataTableCode = new System.Data.DataColumn();
            this.coldsCoverCaseOTL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCoverCaseOTL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsProtect_Use_Case1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtect_Use_Case = new AppSvrHMI.L3DataSet();
            this.schemadsProtect_Use_Case = new System.Data.DataTable();
            this.coldsProtect_Use_CaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsProtect_Use_CaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsDaubUseCaseOT = new System.Windows.Forms.BindingSource(this.components);
            this.dsDaubUseCase = new AppSvrHMI.L3DataSet();
            this.schemadsDaubUseCaseOT = new System.Data.DataTable();
            this.coldsDaubUseCaseOTL3DataTableCode = new System.Data.DataColumn();
            this.coldsDaubUseCaseOTL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsTranqCase = new AppSvrHMI.L3DataSet();
            this.schemadsTranqCase = new System.Data.DataTable();
            this.coldsTranqCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsTranqCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsRefraOT = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefraOT = new AppSvrHMI.L3DataSet();
            this.schemadsRefraOT = new System.Data.DataTable();
            this.coldsRefraOTL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableName = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableStop_Cast_Reason = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableCover_Use_Case = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableProtect_Use_Case = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableDaub_Use_Case = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableTranq_Case = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableNote = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableOperator = new System.Data.DataColumn();
            this.coldsRefraOTL3DataTableTundishNO = new System.Data.DataColumn();
            this.tabRefraTFF = new System.Windows.Forms.TabPage();
            this.dvRefraTFF = new System.Windows.Forms.DataGridView();
            this.tundishNODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopCastReasonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsStopCastingReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.daubUseCaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsDaubUseCaseTTF = new System.Windows.Forms.BindingSource(this.components);
            this.tranqCaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fristTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTuckStickCase1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTuckStickCase = new AppSvrHMI.L3DataSet();
            this.schemadsTuckStickCase = new System.Data.DataTable();
            this.coldsTuckStickCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsTuckStickCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTuckStickCaseL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.secTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTuckStickCase2 = new System.Windows.Forms.BindingSource(this.components);
            this.thrTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTuckStickCase3 = new System.Windows.Forms.BindingSource(this.components);
            this.forTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTuckStickCase4 = new System.Windows.Forms.BindingSource(this.components);
            this.fristWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBigGapCase1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBigGapCase = new AppSvrHMI.L3DataSet();
            this.schemadsBigGapCase = new System.Data.DataTable();
            this.coldsBigGapCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsBigGapCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBigGapCaseL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.secWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBigGapCase2 = new System.Windows.Forms.BindingSource(this.components);
            this.thrWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBigGapCase3 = new System.Windows.Forms.BindingSource(this.components);
            this.forWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBigGapCase4 = new System.Windows.Forms.BindingSource(this.components);
            this.wardDregsCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWard_Dregs_Case = new AppSvrHMI.L3DataSet();
            this.schemadsWard_Dregs_Case = new System.Data.DataTable();
            this.coldsWard_Dregs_CaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsWard_Dregs_CaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coverUseCaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsCoverCaseTFF = new System.Windows.Forms.BindingSource(this.components);
            this.protectUseCaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsProtect_Use_Case2 = new System.Windows.Forms.BindingSource(this.components);
            this.proTempUseCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHoldTempMat_Use = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTempMat_Use = new System.Data.DataTable();
            this.coldsHoldTempMat_UseL3DataTableCode = new System.Data.DataColumn();
            this.coldsHoldTempMat_UseL3DataTableCode_Des = new System.Data.DataColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRefraTFF = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefraTFF = new AppSvrHMI.L3DataSet();
            this.schemadsRefraTFF = new System.Data.DataTable();
            this.coldsRefraTFFL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableName = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableStop_Cast_Reason = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableDaub_Use_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableTranq_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableSec_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableThr_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableFor_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableFrist_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableSec_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableThr_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableFor_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableWard_Dregs_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableCover_Use_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableProtect_Use_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTablePro_Temp_Use_Case = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableNote = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableOperator = new System.Data.DataColumn();
            this.coldsRefraTFFL3DataTableTundishNO = new System.Data.DataColumn();
            this.cmdMag = new AppSvrHMI.L3Command(this.components);
            this.richTextBox3 = new PxDataValid.PxRichTextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.pxComboBox7 = new PxDataValid.PxComboBox();
            this.cmbFourthFraID = new PxDataValid.PxComboBox();
            this.cmbSecondFraID = new PxDataValid.PxComboBox();
            this.pxComboBox8 = new PxDataValid.PxComboBox();
            this.pxComboBox9 = new PxDataValid.PxComboBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.dtBigEnd = new System.Windows.Forms.DateTimePicker();
            this.dtMiddleEnd = new System.Windows.Forms.DateTimePicker();
            this.dtSmallEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBigStart = new System.Windows.Forms.DateTimePicker();
            this.dtMiddleStart = new System.Windows.Forms.DateTimePicker();
            this.dtSmallStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.txtEigGapTemp = new PxDataValid.PxTextBox();
            this.txtEigWallTemp = new PxDataValid.PxTextBox();
            this.txtEigGasPress = new PxDataValid.PxTextBox();
            this.txtEigGasFlux = new PxDataValid.PxTextBox();
            this.txtSevGapTemp = new PxDataValid.PxTextBox();
            this.txtSevWallTemp = new PxDataValid.PxTextBox();
            this.txtSevGasPress = new PxDataValid.PxTextBox();
            this.txtSevGasFlux = new PxDataValid.PxTextBox();
            this.textBox40 = new PxDataValid.PxTextBox();
            this.txtSixWallTemp = new PxDataValid.PxTextBox();
            this.txtSixGasPress = new PxDataValid.PxTextBox();
            this.txtSixGasFlux = new PxDataValid.PxTextBox();
            this.textBox39 = new PxDataValid.PxTextBox();
            this.txtFouWallTemp = new PxDataValid.PxTextBox();
            this.txtFouGasPress = new PxDataValid.PxTextBox();
            this.txtFouGasFlux = new PxDataValid.PxTextBox();
            this.txtThiGapTemp = new PxDataValid.PxTextBox();
            this.txtThiWallTemp = new PxDataValid.PxTextBox();
            this.txtThiGasPress = new PxDataValid.PxTextBox();
            this.txtThiGasFlux = new PxDataValid.PxTextBox();
            this.txtSecGapTemp = new PxDataValid.PxTextBox();
            this.txtSecWallTemp = new PxDataValid.PxTextBox();
            this.txtSecGasPress = new PxDataValid.PxTextBox();
            this.txtSecGasFlux = new PxDataValid.PxTextBox();
            this.txtFirGapTemp = new PxDataValid.PxTextBox();
            this.txtFirWallTemp = new PxDataValid.PxTextBox();
            this.txtFirGasPress = new PxDataValid.PxTextBox();
            this.txtFirGasFlux = new PxDataValid.PxTextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.cmbThirdFraID = new PxDataValid.PxComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.cmbFirstFraID = new PxDataValid.PxComboBox();
            this.label83 = new System.Windows.Forms.Label();
            this.pxComboBox10 = new PxDataValid.PxComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.richTextBox6 = new PxDataValid.PxRichTextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.pxComboBox22 = new PxDataValid.PxComboBox();
            this.label134 = new System.Windows.Forms.Label();
            this.pxComboBox23 = new PxDataValid.PxComboBox();
            this.txtInstallPer = new PxDataValid.PxTextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.cmbGapFac = new PxDataValid.PxComboBox();
            this.label137 = new System.Windows.Forms.Label();
            this.txtFraCase = new PxDataValid.PxTextBox();
            this.cmbSlipBloFac = new PxDataValid.PxComboBox();
            this.pxComboBox24 = new PxDataValid.PxComboBox();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.dtInstallDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker17 = new System.Windows.Forms.DateTimePicker();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.pxComboBox25 = new PxDataValid.PxComboBox();
            this.label143 = new System.Windows.Forms.Label();
            this.bsOTInstallTeamID = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnMag)).BeginInit();
            this.bnMag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerbuildShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuildTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFireShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFireTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOTInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTIstallShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTFFInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTFFInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstallShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstallTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTFFFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTFFFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFHotShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFHotTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOTFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.hmiRootPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMag)).BeginInit();
            this.tabControlMag.SuspendLayout();
            this.tabInnerBuild.SuspendLayout();
            this.pnlInnerBuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerRefraFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerRefraFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerRefraName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerRefraName)).BeginInit();
            this.tabInnerFire.SuspendLayout();
            this.tabDaub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGluemudFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGluemudFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDryMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDryMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWardDregsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWardDregsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBriFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBriFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProject)).BeginInit();
            this.tabInstall.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUpGapFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpGapFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).BeginInit();
            this.tabTFFInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStuStiFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStuStiFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapFac)).BeginInit();
            this.tabHotFire.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotCraneTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustTeam)).BeginInit();
            this.tabTFFFire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTFHotCraneTeamID)).BeginInit();
            this.tabRefra.SuspendLayout();
            this.tabControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStopCastingReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopCastingReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopCastingReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoverCaseOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverCaseOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtect_Use_Case1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtect_Use_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtect_Use_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubUseCaseOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubUseCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubUseCaseOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraOT)).BeginInit();
            this.tabRefraTFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRefraTFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStopCastingReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubUseCaseTTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuckStickCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuckStickCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWard_Dregs_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWard_Dregs_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoverCaseTFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtect_Use_Case2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat_Use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat_Use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraTFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraTFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraTFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTInstallTeamID)).BeginInit();
            this.SuspendLayout();
            // 
            // bnMag
            // 
            this.bnMag.AddNewItem = null;
            this.bnMag.AutoSize = false;
            this.bnMag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnMag.BackgroundImage")));
            this.bnMag.BindingSource = this.bsMag;
            this.bnMag.CountItem = this.bindingNavigatorCountItem;
            this.bnMag.DeleteItem = null;
            this.bnMag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel4,
            this.tsCmbTundishID,
            this.toolStripLabel7,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel5,
            this.btnSave,
            this.btnDataConfirm,
            this.btnOutput});
            this.bnMag.Location = new System.Drawing.Point(0, 0);
            this.bnMag.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMag.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMag.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMag.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMag.Name = "bnMag";
            this.bnMag.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMag.Size = new System.Drawing.Size(1020, 25);
            this.bnMag.TabIndex = 28;
            this.bnMag.Text = "bindingNavigator1";
            // 
            // bsMag
            // 
            this.bsMag.DataMember = "L3DataTable";
            this.bsMag.DataSource = this.dsMag;
            this.bsMag.CurrentChanged += new System.EventHandler(this.bsMag_CurrentChanged);
            // 
            // dsMag
            // 
            this.dsMag.AutoLoad = true;
            this.dsMag.AutoSubscribe = true;
            this.dsMag.DataSetName = "L3DataSet";
            this.dsMag.DeleteMethod = null;
            this.dsMag.InsertMethod = null;
            this.dsMag.L3DataAdapter = this.Adapter;
            this.dsMag.LoadEvent = "Click";
            this.dsMag.LoadTrigger = null;
            this.dsMag.RefreshValve = 1000;
            this.dsMag.SourceCommand = null;
            this.dsMag.SourceCondition = "1=2";
            this.dsMag.SourceMethod = "";
            this.dsMag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMag.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Use_Info";
            this.dsMag.SubscribeTarget = null;
            this.dsMag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMag});
            this.dsMag.UpdateEvent = "Click";
            this.dsMag.UpdateMethod = null;
            this.dsMag.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMag
            // 
            this.schemadsMag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMagL3DataTableGUID,
            this.coldsMagL3DataTableName,
            this.coldsMagL3DataTableCreat_Time,
            this.coldsMagL3DataTableTundishID,
            this.coldsMagL3DataTableVehicle_ID,
            this.coldsMagL3DataTableCast_ID,
            this.coldsMagL3DataTableInner_Tie_Start_Time,
            this.coldsMagL3DataTableInner_Tie_End_Time,
            this.coldsMagL3DataTableInner_Small_Fire_Time,
            this.coldsMagL3DataTableInner_Close_Fire_Time,
            this.coldsMagL3DataTableDaub_Start_Time,
            this.coldsMagL3DataTableDaub_End_Time,
            this.coldsMagL3DataTableFire_Start_Time,
            this.coldsMagL3DataTableFire_End_Time,
            this.coldsMagL3DataTableHot_Big_End_Time,
            this.coldsMagL3DataTableCast_Start_Time,
            this.coldsMagL3DataTableCast_End_Time,
            this.coldsMagL3DataTableTundishNo,
            this.coldsMagL3DataTableInnerID,
            this.coldsMagL3DataTableWorkID,
            this.coldsMagL3DataTableHot_Small_Start_Time,
            this.coldsMagL3DataTableInstall_Start_Time,
            this.coldsMagL3DataTableInstall_End_Time,
            this.coldsMagL3DataTableConfirmFlag});
            this.schemadsMag.TableName = "L3DataTable";
            // 
            // coldsMagL3DataTableGUID
            // 
            this.coldsMagL3DataTableGUID.Caption = "GUID";
            this.coldsMagL3DataTableGUID.ColumnName = "GUID";
            this.coldsMagL3DataTableGUID.Namespace = "";
            // 
            // coldsMagL3DataTableName
            // 
            this.coldsMagL3DataTableName.Caption = "Name";
            this.coldsMagL3DataTableName.ColumnName = "Name";
            this.coldsMagL3DataTableName.Namespace = "";
            // 
            // coldsMagL3DataTableCreat_Time
            // 
            this.coldsMagL3DataTableCreat_Time.Caption = "Creat_Time";
            this.coldsMagL3DataTableCreat_Time.ColumnName = "Creat_Time";
            this.coldsMagL3DataTableCreat_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableCreat_Time.Namespace = "";
            // 
            // coldsMagL3DataTableTundishID
            // 
            this.coldsMagL3DataTableTundishID.Caption = "TundishID";
            this.coldsMagL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsMagL3DataTableTundishID.Namespace = "";
            // 
            // coldsMagL3DataTableVehicle_ID
            // 
            this.coldsMagL3DataTableVehicle_ID.Caption = "Vehicle_ID";
            this.coldsMagL3DataTableVehicle_ID.ColumnName = "Vehicle_ID";
            this.coldsMagL3DataTableVehicle_ID.Namespace = "";
            // 
            // coldsMagL3DataTableCast_ID
            // 
            this.coldsMagL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsMagL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsMagL3DataTableCast_ID.Namespace = "";
            // 
            // coldsMagL3DataTableInner_Tie_Start_Time
            // 
            this.coldsMagL3DataTableInner_Tie_Start_Time.Caption = "Inner_Tie_Start_Time";
            this.coldsMagL3DataTableInner_Tie_Start_Time.ColumnName = "Inner_Tie_Start_Time";
            this.coldsMagL3DataTableInner_Tie_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInner_Tie_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableInner_Tie_End_Time
            // 
            this.coldsMagL3DataTableInner_Tie_End_Time.Caption = "Inner_Tie_End_Time";
            this.coldsMagL3DataTableInner_Tie_End_Time.ColumnName = "Inner_Tie_End_Time";
            this.coldsMagL3DataTableInner_Tie_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInner_Tie_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableInner_Small_Fire_Time
            // 
            this.coldsMagL3DataTableInner_Small_Fire_Time.Caption = "Inner_Small_Fire_Time";
            this.coldsMagL3DataTableInner_Small_Fire_Time.ColumnName = "Inner_Small_Fire_Time";
            this.coldsMagL3DataTableInner_Small_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInner_Small_Fire_Time.Namespace = "";
            // 
            // coldsMagL3DataTableInner_Close_Fire_Time
            // 
            this.coldsMagL3DataTableInner_Close_Fire_Time.Caption = "Inner_Close_Fire_Time";
            this.coldsMagL3DataTableInner_Close_Fire_Time.ColumnName = "Inner_Close_Fire_Time";
            this.coldsMagL3DataTableInner_Close_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInner_Close_Fire_Time.Namespace = "";
            // 
            // coldsMagL3DataTableDaub_Start_Time
            // 
            this.coldsMagL3DataTableDaub_Start_Time.Caption = "Daub_Start_Time";
            this.coldsMagL3DataTableDaub_Start_Time.ColumnName = "Daub_Start_Time";
            this.coldsMagL3DataTableDaub_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableDaub_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableDaub_End_Time
            // 
            this.coldsMagL3DataTableDaub_End_Time.Caption = "Daub_End_Time";
            this.coldsMagL3DataTableDaub_End_Time.ColumnName = "Daub_End_Time";
            this.coldsMagL3DataTableDaub_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableDaub_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableFire_Start_Time
            // 
            this.coldsMagL3DataTableFire_Start_Time.Caption = "Fire_Start_Time";
            this.coldsMagL3DataTableFire_Start_Time.ColumnName = "Fire_Start_Time";
            this.coldsMagL3DataTableFire_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableFire_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableFire_End_Time
            // 
            this.coldsMagL3DataTableFire_End_Time.Caption = "Fire_End_Time";
            this.coldsMagL3DataTableFire_End_Time.ColumnName = "Fire_End_Time";
            this.coldsMagL3DataTableFire_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableFire_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableHot_Big_End_Time
            // 
            this.coldsMagL3DataTableHot_Big_End_Time.Caption = "Hot_Big_End_Time";
            this.coldsMagL3DataTableHot_Big_End_Time.ColumnName = "Hot_Big_End_Time";
            this.coldsMagL3DataTableHot_Big_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableHot_Big_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableCast_Start_Time
            // 
            this.coldsMagL3DataTableCast_Start_Time.Caption = "Cast_Start_Time";
            this.coldsMagL3DataTableCast_Start_Time.ColumnName = "Cast_Start_Time";
            this.coldsMagL3DataTableCast_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableCast_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableCast_End_Time
            // 
            this.coldsMagL3DataTableCast_End_Time.Caption = "Cast_End_Time";
            this.coldsMagL3DataTableCast_End_Time.ColumnName = "Cast_End_Time";
            this.coldsMagL3DataTableCast_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableCast_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableTundishNo
            // 
            this.coldsMagL3DataTableTundishNo.Caption = "TundishNO";
            this.coldsMagL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsMagL3DataTableTundishNo.Namespace = "";
            // 
            // coldsMagL3DataTableInnerID
            // 
            this.coldsMagL3DataTableInnerID.Caption = "InnerID";
            this.coldsMagL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsMagL3DataTableInnerID.Namespace = "";
            // 
            // coldsMagL3DataTableWorkID
            // 
            this.coldsMagL3DataTableWorkID.Caption = "WorkID";
            this.coldsMagL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsMagL3DataTableWorkID.Namespace = "";
            // 
            // coldsMagL3DataTableHot_Small_Start_Time
            // 
            this.coldsMagL3DataTableHot_Small_Start_Time.Caption = "Hot_Small_Start_Time";
            this.coldsMagL3DataTableHot_Small_Start_Time.ColumnName = "Hot_Small_Start_Time";
            this.coldsMagL3DataTableHot_Small_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableHot_Small_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableInstall_Start_Time
            // 
            this.coldsMagL3DataTableInstall_Start_Time.Caption = "Install_Start_Time";
            this.coldsMagL3DataTableInstall_Start_Time.ColumnName = "Install_Start_Time";
            this.coldsMagL3DataTableInstall_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInstall_Start_Time.Namespace = "";
            // 
            // coldsMagL3DataTableInstall_End_Time
            // 
            this.coldsMagL3DataTableInstall_End_Time.Caption = "Install_End_Time";
            this.coldsMagL3DataTableInstall_End_Time.ColumnName = "Install_End_Time";
            this.coldsMagL3DataTableInstall_End_Time.DataType = typeof(System.DateTime);
            this.coldsMagL3DataTableInstall_End_Time.Namespace = "";
            // 
            // coldsMagL3DataTableConfirmFlag
            // 
            this.coldsMagL3DataTableConfirmFlag.Caption = "Confirm_Flag";
            this.coldsMagL3DataTableConfirmFlag.ColumnName = "Confirm_Flag";
            this.coldsMagL3DataTableConfirmFlag.DataType = typeof(int);
            this.coldsMagL3DataTableConfirmFlag.Namespace = "";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel6.Text = "中包时间履历";
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = " ";
            // 
            // tsCmbTundishID
            // 
            this.tsCmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCmbTundishID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsCmbTundishID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tsCmbTundishID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsCmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsCmbTundishID.Name = "tsCmbTundishID";
            this.tsCmbTundishID.Size = new System.Drawing.Size(75, 25);
            this.tsCmbTundishID.DropDownClosed += new System.EventHandler(this.tsCmbTundishID_DropDownClosed);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel7.Text = "中包号:";
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "创建日期:";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 22);
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDataConfirm
            // 
            this.btnDataConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnDataConfirm.Image")));
            this.btnDataConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataConfirm.Name = "btnDataConfirm";
            this.btnDataConfirm.Size = new System.Drawing.Size(73, 22);
            this.btnDataConfirm.Text = "数据确认";
            this.btnDataConfirm.Visible = false;
            this.btnDataConfirm.Click += new System.EventHandler(this.btnDataConfirm_Click);
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
            // bsInnerBuild
            // 
            this.bsInnerBuild.DataMember = "L3DataTable";
            this.bsInnerBuild.DataSource = this.dsInnerBuild;
            this.bsInnerBuild.Sort = "";
            // 
            // dsInnerBuild
            // 
            this.dsInnerBuild.AutoLoad = true;
            this.dsInnerBuild.AutoSubscribe = true;
            this.dsInnerBuild.DataSetName = "L3DataSet";
            this.dsInnerBuild.DeleteMethod = "";
            this.dsInnerBuild.InsertMethod = "";
            this.dsInnerBuild.L3DataAdapter = null;
            this.dsInnerBuild.LoadEvent = "Click";
            this.dsInnerBuild.LoadTrigger = null;
            this.dsInnerBuild.RefreshValve = 1000;
            this.dsInnerBuild.SourceCommand = null;
            this.dsInnerBuild.SourceCondition = "";
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
            // schemadsInnerBuild
            // 
            this.schemadsInnerBuild.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerBuildL3DataTableTundishID,
            this.coldsInnerBuildL3DataTableInnerID,
            this.coldsInnerBuildL3DataTableInner_Use_Count,
            this.coldsInnerBuildL3DataTableTundishNO,
            this.coldsInnerBuildL3DataTableTie_Start_Time,
            this.coldsInnerBuildL3DataTableTie_End_Time,
            this.coldsInnerBuildL3DataTableCheck_Date,
            this.coldsInnerBuildL3DataTableRefra_Fac,
            this.coldsInnerBuildL3DataTableRefra_ID,
            this.coldsInnerBuildL3DataTableWaste,
            this.coldsInnerBuildL3DataTableTeamID,
            this.coldsInnerBuildL3DataTableShiftID,
            this.coldsInnerBuildL3DataTableOperator,
            this.coldsInnerBuildL3DataTableNote});
            this.schemadsInnerBuild.TableName = "L3DataTable";
            // 
            // coldsInnerBuildL3DataTableTundishID
            // 
            this.coldsInnerBuildL3DataTableTundishID.Caption = "TundishID";
            this.coldsInnerBuildL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsInnerBuildL3DataTableTundishID.Namespace = "";
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
            // coldsInnerBuildL3DataTableTundishNO
            // 
            this.coldsInnerBuildL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsInnerBuildL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsInnerBuildL3DataTableTundishNO.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTie_Start_Time
            // 
            this.coldsInnerBuildL3DataTableTie_Start_Time.Caption = "Tie_Start_Time";
            this.coldsInnerBuildL3DataTableTie_Start_Time.ColumnName = "Tie_Start_Time";
            this.coldsInnerBuildL3DataTableTie_Start_Time.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableTie_Start_Time.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTie_End_Time
            // 
            this.coldsInnerBuildL3DataTableTie_End_Time.Caption = "Tie_End_Time";
            this.coldsInnerBuildL3DataTableTie_End_Time.ColumnName = "Tie_End_Time";
            this.coldsInnerBuildL3DataTableTie_End_Time.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableTie_End_Time.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableCheck_Date
            // 
            this.coldsInnerBuildL3DataTableCheck_Date.Caption = "Check_Date";
            this.coldsInnerBuildL3DataTableCheck_Date.ColumnName = "Check_Date";
            this.coldsInnerBuildL3DataTableCheck_Date.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableCheck_Date.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableRefra_Fac
            // 
            this.coldsInnerBuildL3DataTableRefra_Fac.Caption = "Refra_Fac";
            this.coldsInnerBuildL3DataTableRefra_Fac.ColumnName = "Refra_Fac";
            this.coldsInnerBuildL3DataTableRefra_Fac.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableRefra_ID
            // 
            this.coldsInnerBuildL3DataTableRefra_ID.Caption = "Refra_ID";
            this.coldsInnerBuildL3DataTableRefra_ID.ColumnName = "Refra_ID";
            this.coldsInnerBuildL3DataTableRefra_ID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableWaste
            // 
            this.coldsInnerBuildL3DataTableWaste.Caption = "Waste";
            this.coldsInnerBuildL3DataTableWaste.ColumnName = "Waste";
            this.coldsInnerBuildL3DataTableWaste.DataType = typeof(double);
            this.coldsInnerBuildL3DataTableWaste.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTeamID
            // 
            this.coldsInnerBuildL3DataTableTeamID.Caption = "TeamID";
            this.coldsInnerBuildL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsInnerBuildL3DataTableTeamID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableShiftID
            // 
            this.coldsInnerBuildL3DataTableShiftID.Caption = "ShiftID";
            this.coldsInnerBuildL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsInnerBuildL3DataTableShiftID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableOperator
            // 
            this.coldsInnerBuildL3DataTableOperator.Caption = "Operator";
            this.coldsInnerBuildL3DataTableOperator.ColumnName = "Operator";
            this.coldsInnerBuildL3DataTableOperator.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableNote
            // 
            this.coldsInnerBuildL3DataTableNote.Caption = "Note";
            this.coldsInnerBuildL3DataTableNote.ColumnName = "Note";
            this.coldsInnerBuildL3DataTableNote.Namespace = "";
            // 
            // bsInnerbuildShiftID
            // 
            this.bsInnerbuildShiftID.DataMember = "L3DataTable";
            this.bsInnerbuildShiftID.DataSource = this.dsShiftID;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = true;
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
            // bsInnerBuildTeamID
            // 
            this.bsInnerBuildTeamID.DataMember = "L3DataTable";
            this.bsInnerBuildTeamID.DataSource = this.dsTeamID;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = true;
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
            this.coldsTeamIDL3DataTableCode_des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_des
            // 
            this.coldsTeamIDL3DataTableCode_des.Caption = "Code_des";
            this.coldsTeamIDL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsTeamIDL3DataTableCode_des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // bsInnerFire
            // 
            this.bsInnerFire.DataMember = "L3DataTable";
            this.bsInnerFire.DataSource = this.dsInnerFire;
            // 
            // dsInnerFire
            // 
            this.dsInnerFire.AutoLoad = true;
            this.dsInnerFire.AutoSubscribe = true;
            this.dsInnerFire.DataSetName = "L3DataSet";
            this.dsInnerFire.DeleteMethod = null;
            this.dsInnerFire.InsertMethod = null;
            this.dsInnerFire.L3DataAdapter = null;
            this.dsInnerFire.LoadEvent = "Click";
            this.dsInnerFire.LoadTrigger = null;
            this.dsInnerFire.RefreshValve = 1000;
            this.dsInnerFire.SourceCommand = null;
            this.dsInnerFire.SourceCondition = null;
            this.dsInnerFire.SourceMethod = "";
            this.dsInnerFire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInnerFire.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Inner_Fire";
            this.dsInnerFire.SubscribeTarget = null;
            this.dsInnerFire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInnerFire});
            this.dsInnerFire.UpdateEvent = "Click";
            this.dsInnerFire.UpdateMethod = null;
            this.dsInnerFire.UpdateTrigger = null;
            // 
            // schemadsInnerFire
            // 
            this.schemadsInnerFire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerFireL3DataTableTundishID,
            this.coldsInnerFireL3DataTableInnerID,
            this.coldsInnerFireL3DataTableTundishNO,
            this.coldsInnerFireL3DataTableSmall_Fire_Time,
            this.coldsInnerFireL3DataTableSmall_Fire_Operator,
            this.coldsInnerFireL3DataTableMid_Fire_Time,
            this.coldsInnerFireL3DataTableMid_Fire_Operator,
            this.coldsInnerFireL3DataTableBig_Fire_Time,
            this.coldsInnerFireL3DataTableBig_Fire_Operator,
            this.coldsInnerFireL3DataTableClose_Fire_Time,
            this.coldsInnerFireL3DataTableClose_Fire_Operator,
            this.coldsInnerFireL3DataTableTeamID,
            this.coldsInnerFireL3DataTableShiftID,
            this.coldsInnerFireL3DataTableOperator,
            this.coldsInnerFireL3DataTableNote});
            this.schemadsInnerFire.TableName = "L3DataTable";
            // 
            // coldsInnerFireL3DataTableTundishID
            // 
            this.coldsInnerFireL3DataTableTundishID.Caption = "TundishID";
            this.coldsInnerFireL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsInnerFireL3DataTableTundishID.Namespace = "";
            // 
            // coldsInnerFireL3DataTableInnerID
            // 
            this.coldsInnerFireL3DataTableInnerID.Caption = "InnerID";
            this.coldsInnerFireL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsInnerFireL3DataTableInnerID.Namespace = "";
            // 
            // coldsInnerFireL3DataTableTundishNO
            // 
            this.coldsInnerFireL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsInnerFireL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsInnerFireL3DataTableTundishNO.Namespace = "";
            // 
            // coldsInnerFireL3DataTableSmall_Fire_Time
            // 
            this.coldsInnerFireL3DataTableSmall_Fire_Time.Caption = "Small_Fire_Time";
            this.coldsInnerFireL3DataTableSmall_Fire_Time.ColumnName = "Small_Fire_Time";
            this.coldsInnerFireL3DataTableSmall_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsInnerFireL3DataTableSmall_Fire_Time.Namespace = "";
            // 
            // coldsInnerFireL3DataTableSmall_Fire_Operator
            // 
            this.coldsInnerFireL3DataTableSmall_Fire_Operator.Caption = "Small_Fire_Operator";
            this.coldsInnerFireL3DataTableSmall_Fire_Operator.ColumnName = "Small_Fire_Operator";
            this.coldsInnerFireL3DataTableSmall_Fire_Operator.Namespace = "";
            // 
            // coldsInnerFireL3DataTableMid_Fire_Time
            // 
            this.coldsInnerFireL3DataTableMid_Fire_Time.Caption = "Mid_Fire_Time";
            this.coldsInnerFireL3DataTableMid_Fire_Time.ColumnName = "Mid_Fire_Time";
            this.coldsInnerFireL3DataTableMid_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsInnerFireL3DataTableMid_Fire_Time.Namespace = "";
            // 
            // coldsInnerFireL3DataTableMid_Fire_Operator
            // 
            this.coldsInnerFireL3DataTableMid_Fire_Operator.Caption = "Mid_Fire_Operator";
            this.coldsInnerFireL3DataTableMid_Fire_Operator.ColumnName = "Mid_Fire_Operator";
            this.coldsInnerFireL3DataTableMid_Fire_Operator.Namespace = "";
            // 
            // coldsInnerFireL3DataTableBig_Fire_Time
            // 
            this.coldsInnerFireL3DataTableBig_Fire_Time.Caption = "Big_Fire_Time";
            this.coldsInnerFireL3DataTableBig_Fire_Time.ColumnName = "Big_Fire_Time";
            this.coldsInnerFireL3DataTableBig_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsInnerFireL3DataTableBig_Fire_Time.Namespace = "";
            // 
            // coldsInnerFireL3DataTableBig_Fire_Operator
            // 
            this.coldsInnerFireL3DataTableBig_Fire_Operator.Caption = "Big_Fire_Operator";
            this.coldsInnerFireL3DataTableBig_Fire_Operator.ColumnName = "Big_Fire_Operator";
            this.coldsInnerFireL3DataTableBig_Fire_Operator.Namespace = "";
            // 
            // coldsInnerFireL3DataTableClose_Fire_Time
            // 
            this.coldsInnerFireL3DataTableClose_Fire_Time.Caption = "Close_Fire_Time";
            this.coldsInnerFireL3DataTableClose_Fire_Time.ColumnName = "Close_Fire_Time";
            this.coldsInnerFireL3DataTableClose_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsInnerFireL3DataTableClose_Fire_Time.Namespace = "";
            // 
            // coldsInnerFireL3DataTableClose_Fire_Operator
            // 
            this.coldsInnerFireL3DataTableClose_Fire_Operator.Caption = "Close_Fire_Operator";
            this.coldsInnerFireL3DataTableClose_Fire_Operator.ColumnName = "Close_Fire_Operator";
            this.coldsInnerFireL3DataTableClose_Fire_Operator.Namespace = "";
            // 
            // coldsInnerFireL3DataTableTeamID
            // 
            this.coldsInnerFireL3DataTableTeamID.Caption = "TeamID";
            this.coldsInnerFireL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsInnerFireL3DataTableTeamID.Namespace = "";
            // 
            // coldsInnerFireL3DataTableShiftID
            // 
            this.coldsInnerFireL3DataTableShiftID.Caption = "ShiftID";
            this.coldsInnerFireL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsInnerFireL3DataTableShiftID.Namespace = "";
            // 
            // coldsInnerFireL3DataTableOperator
            // 
            this.coldsInnerFireL3DataTableOperator.Caption = "Operator";
            this.coldsInnerFireL3DataTableOperator.ColumnName = "Operator";
            this.coldsInnerFireL3DataTableOperator.Namespace = "";
            // 
            // coldsInnerFireL3DataTableNote
            // 
            this.coldsInnerFireL3DataTableNote.Caption = "Note";
            this.coldsInnerFireL3DataTableNote.ColumnName = "Note";
            this.coldsInnerFireL3DataTableNote.Namespace = "";
            // 
            // bsInnerFireShiftID
            // 
            this.bsInnerFireShiftID.DataMember = "L3DataTable";
            this.bsInnerFireShiftID.DataSource = this.dsShiftID;
            // 
            // bsInnerFireTeamID
            // 
            this.bsInnerFireTeamID.DataMember = "L3DataTable";
            this.bsInnerFireTeamID.DataSource = this.dsTeamID;
            // 
            // bsDaub
            // 
            this.bsDaub.DataMember = "L3DataTable";
            this.bsDaub.DataSource = this.dsDaub;
            // 
            // dsDaub
            // 
            this.dsDaub.AutoLoad = true;
            this.dsDaub.AutoSubscribe = true;
            this.dsDaub.DataSetName = "L3DataSet";
            this.dsDaub.DeleteMethod = null;
            this.dsDaub.InsertMethod = null;
            this.dsDaub.L3DataAdapter = null;
            this.dsDaub.LoadEvent = "Click";
            this.dsDaub.LoadTrigger = null;
            this.dsDaub.RefreshValve = 1000;
            this.dsDaub.SourceCommand = null;
            this.dsDaub.SourceCondition = "";
            this.dsDaub.SourceMethod = "";
            this.dsDaub.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDaub.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Daub";
            this.dsDaub.SubscribeTarget = null;
            this.dsDaub.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDaub});
            this.dsDaub.UpdateEvent = "Click";
            this.dsDaub.UpdateMethod = null;
            this.dsDaub.UpdateTrigger = null;
            // 
            // schemadsDaub
            // 
            this.schemadsDaub.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDaubL3DataTableTundishID,
            this.coldsDaubL3DataTableWorkID,
            this.coldsDaubL3DataTableInnerID,
            this.coldsDaubL3DataTableInner_Use_Count,
            this.coldsDaubL3DataTableCast_ID,
            this.coldsDaubL3DataTableTundishNo,
            this.coldsDaubL3DataTableProject,
            this.coldsDaubL3DataTableGap_Bri_Fac,
            this.coldsDaubL3DataTableGap_Bri_Consume,
            this.coldsDaubL3DataTableWard_Dregs_Fac,
            this.coldsDaubL3DataTableWard_Dregs_Consume,
            this.coldsDaubL3DataTableTranq_Fac,
            this.coldsDaubL3DataTableTranq_Consume,
            this.coldsDaubL3DataTableDaub_Fac,
            this.coldsDaubL3DataTableDaub_Consume,
            this.coldsDaubL3DataTableDry_Flap_Fac,
            this.coldsDaubL3DataTableDry_Flap_Consume,
            this.coldsDaubL3DataTableGluemud_Fac,
            this.coldsDaubL3DataTableGluemud_Consume,
            this.coldsDaubL3DataTableDaub_Start_Time,
            this.coldsDaubL3DataTableDaub_End_Time,
            this.coldsDaubL3DataTableFire_Start_Time,
            this.coldsDaubL3DataTableFire_End_Time,
            this.coldsDaubL3DataTableTeamID,
            this.coldsDaubL3DataTableShiftID,
            this.coldsDaubL3DataTableOperator,
            this.coldsDaubL3DataTableNote});
            this.schemadsDaub.TableName = "L3DataTable";
            // 
            // coldsDaubL3DataTableTundishID
            // 
            this.coldsDaubL3DataTableTundishID.Caption = "TundishID";
            this.coldsDaubL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsDaubL3DataTableTundishID.Namespace = "";
            // 
            // coldsDaubL3DataTableWorkID
            // 
            this.coldsDaubL3DataTableWorkID.Caption = "WorkID";
            this.coldsDaubL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsDaubL3DataTableWorkID.Namespace = "";
            // 
            // coldsDaubL3DataTableInnerID
            // 
            this.coldsDaubL3DataTableInnerID.Caption = "InnerID";
            this.coldsDaubL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsDaubL3DataTableInnerID.Namespace = "";
            // 
            // coldsDaubL3DataTableInner_Use_Count
            // 
            this.coldsDaubL3DataTableInner_Use_Count.Caption = "Inner_Use_Count";
            this.coldsDaubL3DataTableInner_Use_Count.ColumnName = "Inner_Use_Count";
            this.coldsDaubL3DataTableInner_Use_Count.DataType = typeof(short);
            this.coldsDaubL3DataTableInner_Use_Count.Namespace = "";
            // 
            // coldsDaubL3DataTableCast_ID
            // 
            this.coldsDaubL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsDaubL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsDaubL3DataTableCast_ID.Namespace = "";
            // 
            // coldsDaubL3DataTableTundishNo
            // 
            this.coldsDaubL3DataTableTundishNo.Caption = "TundishNo";
            this.coldsDaubL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsDaubL3DataTableTundishNo.Namespace = "";
            // 
            // coldsDaubL3DataTableProject
            // 
            this.coldsDaubL3DataTableProject.Caption = "Project";
            this.coldsDaubL3DataTableProject.ColumnName = "Project";
            this.coldsDaubL3DataTableProject.Namespace = "";
            // 
            // coldsDaubL3DataTableGap_Bri_Fac
            // 
            this.coldsDaubL3DataTableGap_Bri_Fac.Caption = "Gap_Bri_Fac";
            this.coldsDaubL3DataTableGap_Bri_Fac.ColumnName = "Gap_Bri_Fac";
            this.coldsDaubL3DataTableGap_Bri_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableGap_Bri_Consume
            // 
            this.coldsDaubL3DataTableGap_Bri_Consume.Caption = "Gap_Bri_Consume";
            this.coldsDaubL3DataTableGap_Bri_Consume.ColumnName = "Gap_Bri_Consume";
            this.coldsDaubL3DataTableGap_Bri_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableGap_Bri_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableWard_Dregs_Fac
            // 
            this.coldsDaubL3DataTableWard_Dregs_Fac.Caption = "Ward_Dregs_Fac";
            this.coldsDaubL3DataTableWard_Dregs_Fac.ColumnName = "Ward_Dregs_Fac";
            this.coldsDaubL3DataTableWard_Dregs_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableWard_Dregs_Consume
            // 
            this.coldsDaubL3DataTableWard_Dregs_Consume.Caption = "Ward_Dregs_Consume";
            this.coldsDaubL3DataTableWard_Dregs_Consume.ColumnName = "Ward_Dregs_Consume";
            this.coldsDaubL3DataTableWard_Dregs_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableWard_Dregs_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableTranq_Fac
            // 
            this.coldsDaubL3DataTableTranq_Fac.Caption = "Tranq_Fac";
            this.coldsDaubL3DataTableTranq_Fac.ColumnName = "Tranq_Fac";
            this.coldsDaubL3DataTableTranq_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableTranq_Consume
            // 
            this.coldsDaubL3DataTableTranq_Consume.Caption = "Tranq_Consume";
            this.coldsDaubL3DataTableTranq_Consume.ColumnName = "Tranq_Consume";
            this.coldsDaubL3DataTableTranq_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableTranq_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableDaub_Fac
            // 
            this.coldsDaubL3DataTableDaub_Fac.Caption = "Daub_Fac";
            this.coldsDaubL3DataTableDaub_Fac.ColumnName = "Daub_Fac";
            this.coldsDaubL3DataTableDaub_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableDaub_Consume
            // 
            this.coldsDaubL3DataTableDaub_Consume.Caption = "Daub_Consume";
            this.coldsDaubL3DataTableDaub_Consume.ColumnName = "Daub_Consume";
            this.coldsDaubL3DataTableDaub_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableDaub_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableDry_Flap_Fac
            // 
            this.coldsDaubL3DataTableDry_Flap_Fac.Caption = "Dry_Flap_Fac";
            this.coldsDaubL3DataTableDry_Flap_Fac.ColumnName = "Dry_Flap_Fac";
            this.coldsDaubL3DataTableDry_Flap_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableDry_Flap_Consume
            // 
            this.coldsDaubL3DataTableDry_Flap_Consume.Caption = "Dry_Flap_Consume";
            this.coldsDaubL3DataTableDry_Flap_Consume.ColumnName = "Dry_Flap_Consume";
            this.coldsDaubL3DataTableDry_Flap_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableDry_Flap_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableGluemud_Fac
            // 
            this.coldsDaubL3DataTableGluemud_Fac.Caption = "Gluemud_Fac";
            this.coldsDaubL3DataTableGluemud_Fac.ColumnName = "Gluemud_Fac";
            this.coldsDaubL3DataTableGluemud_Fac.Namespace = "";
            // 
            // coldsDaubL3DataTableGluemud_Consume
            // 
            this.coldsDaubL3DataTableGluemud_Consume.Caption = "Gluemud_Consume";
            this.coldsDaubL3DataTableGluemud_Consume.ColumnName = "Gluemud_Consume";
            this.coldsDaubL3DataTableGluemud_Consume.DataType = typeof(double);
            this.coldsDaubL3DataTableGluemud_Consume.Namespace = "";
            // 
            // coldsDaubL3DataTableDaub_Start_Time
            // 
            this.coldsDaubL3DataTableDaub_Start_Time.Caption = "Daub_Start_Time";
            this.coldsDaubL3DataTableDaub_Start_Time.ColumnName = "Daub_Start_Time";
            this.coldsDaubL3DataTableDaub_Start_Time.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableDaub_Start_Time.Namespace = "";
            // 
            // coldsDaubL3DataTableDaub_End_Time
            // 
            this.coldsDaubL3DataTableDaub_End_Time.Caption = "Daub_End_Time";
            this.coldsDaubL3DataTableDaub_End_Time.ColumnName = "Daub_End_Time";
            this.coldsDaubL3DataTableDaub_End_Time.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableDaub_End_Time.Namespace = "";
            // 
            // coldsDaubL3DataTableFire_Start_Time
            // 
            this.coldsDaubL3DataTableFire_Start_Time.Caption = "Fire_Start_Time";
            this.coldsDaubL3DataTableFire_Start_Time.ColumnName = "Fire_Start_Time";
            this.coldsDaubL3DataTableFire_Start_Time.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableFire_Start_Time.Namespace = "";
            // 
            // coldsDaubL3DataTableFire_End_Time
            // 
            this.coldsDaubL3DataTableFire_End_Time.Caption = "Fire_End_Time";
            this.coldsDaubL3DataTableFire_End_Time.ColumnName = "Fire_End_Time";
            this.coldsDaubL3DataTableFire_End_Time.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableFire_End_Time.Namespace = "";
            // 
            // coldsDaubL3DataTableTeamID
            // 
            this.coldsDaubL3DataTableTeamID.Caption = "TeamID";
            this.coldsDaubL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsDaubL3DataTableTeamID.Namespace = "";
            // 
            // coldsDaubL3DataTableShiftID
            // 
            this.coldsDaubL3DataTableShiftID.Caption = "ShiftID";
            this.coldsDaubL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsDaubL3DataTableShiftID.Namespace = "";
            // 
            // coldsDaubL3DataTableOperator
            // 
            this.coldsDaubL3DataTableOperator.Caption = "Operator";
            this.coldsDaubL3DataTableOperator.ColumnName = "Operator";
            this.coldsDaubL3DataTableOperator.Namespace = "";
            // 
            // coldsDaubL3DataTableNote
            // 
            this.coldsDaubL3DataTableNote.Caption = "Note";
            this.coldsDaubL3DataTableNote.ColumnName = "Note";
            this.coldsDaubL3DataTableNote.Namespace = "";
            // 
            // bsDaubShiftID
            // 
            this.bsDaubShiftID.DataMember = "L3DataTable";
            this.bsDaubShiftID.DataSource = this.dsShiftID;
            // 
            // bsDaubTeamID
            // 
            this.bsDaubTeamID.DataMember = "L3DataTable";
            this.bsDaubTeamID.DataSource = this.dsTeamID;
            // 
            // bsOTInstall
            // 
            this.bsOTInstall.DataMember = "L3DataTable";
            this.bsOTInstall.DataSource = this.dsOTInstall;
            // 
            // dsOTInstall
            // 
            this.dsOTInstall.AutoLoad = true;
            this.dsOTInstall.AutoSubscribe = true;
            this.dsOTInstall.DataSetName = "L3DataSet";
            this.dsOTInstall.DeleteMethod = null;
            this.dsOTInstall.InsertMethod = null;
            this.dsOTInstall.L3DataAdapter = null;
            this.dsOTInstall.LoadEvent = "Click";
            this.dsOTInstall.LoadTrigger = null;
            this.dsOTInstall.RefreshValve = 1000;
            this.dsOTInstall.SourceCommand = null;
            this.dsOTInstall.SourceCondition = null;
            this.dsOTInstall.SourceMethod = "";
            this.dsOTInstall.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOTInstall.SourceURI = "XGMESLogic\\TundishMag\\CTundish_OT_Install";
            this.dsOTInstall.SubscribeTarget = null;
            this.dsOTInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOTInstall});
            this.dsOTInstall.UpdateEvent = "Click";
            this.dsOTInstall.UpdateMethod = null;
            this.dsOTInstall.UpdateTrigger = null;
            // 
            // schemadsOTInstall
            // 
            this.schemadsOTInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOTInstallL3DataTableTundishID,
            this.coldsOTInstallL3DataTableWorkID,
            this.coldsOTInstallL3DataTableVehicleID,
            this.coldsOTInstallL3DataTableTundishNo,
            this.coldsOTInstallL3DataTableDaub_Fac,
            this.coldsOTInstallL3DataTableFra_Case,
            this.coldsOTInstallL3DataTableSlip_Blo_Fac,
            this.coldsOTInstallL3DataTableGap_Fac,
            this.coldsOTInstallL3DataTableInstall_Per,
            this.coldsOTInstallL3DataTableInstall_Time,
            this.coldsOTInstallL3DataTableNote});
            this.schemadsOTInstall.TableName = "L3DataTable";
            // 
            // coldsOTInstallL3DataTableTundishID
            // 
            this.coldsOTInstallL3DataTableTundishID.Caption = "TundishID";
            this.coldsOTInstallL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsOTInstallL3DataTableTundishID.Namespace = "";
            // 
            // coldsOTInstallL3DataTableWorkID
            // 
            this.coldsOTInstallL3DataTableWorkID.Caption = "WorkID";
            this.coldsOTInstallL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsOTInstallL3DataTableWorkID.Namespace = "";
            // 
            // coldsOTInstallL3DataTableVehicleID
            // 
            this.coldsOTInstallL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsOTInstallL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsOTInstallL3DataTableVehicleID.Namespace = "";
            // 
            // coldsOTInstallL3DataTableTundishNo
            // 
            this.coldsOTInstallL3DataTableTundishNo.Caption = "TundishNo";
            this.coldsOTInstallL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsOTInstallL3DataTableTundishNo.Namespace = "";
            // 
            // coldsOTInstallL3DataTableDaub_Fac
            // 
            this.coldsOTInstallL3DataTableDaub_Fac.Caption = "Daub_Fac";
            this.coldsOTInstallL3DataTableDaub_Fac.ColumnName = "Daub_Fac";
            this.coldsOTInstallL3DataTableDaub_Fac.Namespace = "";
            // 
            // coldsOTInstallL3DataTableFra_Case
            // 
            this.coldsOTInstallL3DataTableFra_Case.Caption = "Fra_Case";
            this.coldsOTInstallL3DataTableFra_Case.ColumnName = "Fra_Case";
            this.coldsOTInstallL3DataTableFra_Case.Namespace = "";
            // 
            // coldsOTInstallL3DataTableSlip_Blo_Fac
            // 
            this.coldsOTInstallL3DataTableSlip_Blo_Fac.Caption = "Slip_Blo_Fac";
            this.coldsOTInstallL3DataTableSlip_Blo_Fac.ColumnName = "Slip_Blo_Fac";
            this.coldsOTInstallL3DataTableSlip_Blo_Fac.Namespace = "";
            // 
            // coldsOTInstallL3DataTableGap_Fac
            // 
            this.coldsOTInstallL3DataTableGap_Fac.Caption = "Gap_Fac";
            this.coldsOTInstallL3DataTableGap_Fac.ColumnName = "Gap_Fac";
            this.coldsOTInstallL3DataTableGap_Fac.Namespace = "";
            // 
            // coldsOTInstallL3DataTableInstall_Per
            // 
            this.coldsOTInstallL3DataTableInstall_Per.Caption = "Install_Per";
            this.coldsOTInstallL3DataTableInstall_Per.ColumnName = "Install_Per";
            this.coldsOTInstallL3DataTableInstall_Per.Namespace = "";
            // 
            // coldsOTInstallL3DataTableInstall_Time
            // 
            this.coldsOTInstallL3DataTableInstall_Time.Caption = "Install_Time";
            this.coldsOTInstallL3DataTableInstall_Time.ColumnName = "Install_Time";
            this.coldsOTInstallL3DataTableInstall_Time.DataType = typeof(System.DateTime);
            this.coldsOTInstallL3DataTableInstall_Time.Namespace = "";
            // 
            // coldsOTInstallL3DataTableNote
            // 
            this.coldsOTInstallL3DataTableNote.Caption = "Note";
            this.coldsOTInstallL3DataTableNote.ColumnName = "Note";
            this.coldsOTInstallL3DataTableNote.Namespace = "";
            // 
            // bsOTIstallShiftID
            // 
            this.bsOTIstallShiftID.DataMember = "L3DataTable";
            this.bsOTIstallShiftID.DataSource = this.dsShiftID;
            // 
            // bsTFFInstall
            // 
            this.bsTFFInstall.DataMember = "L3DataTable";
            this.bsTFFInstall.DataSource = this.dsTFFInstall;
            // 
            // dsTFFInstall
            // 
            this.dsTFFInstall.AutoLoad = true;
            this.dsTFFInstall.AutoSubscribe = true;
            this.dsTFFInstall.DataSetName = "L3DataSet";
            this.dsTFFInstall.DeleteMethod = null;
            this.dsTFFInstall.InsertMethod = null;
            this.dsTFFInstall.L3DataAdapter = null;
            this.dsTFFInstall.LoadEvent = "Click";
            this.dsTFFInstall.LoadTrigger = null;
            this.dsTFFInstall.RefreshValve = 1000;
            this.dsTFFInstall.SourceCommand = null;
            this.dsTFFInstall.SourceCondition = null;
            this.dsTFFInstall.SourceMethod = "";
            this.dsTFFInstall.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTFFInstall.SourceURI = "XGMESLogic\\TundishMag\\CTundish_TFF_Install";
            this.dsTFFInstall.SubscribeTarget = null;
            this.dsTFFInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTFFInstall});
            this.dsTFFInstall.UpdateEvent = "Click";
            this.dsTFFInstall.UpdateMethod = null;
            this.dsTFFInstall.UpdateTrigger = null;
            // 
            // schemadsTFFInstall
            // 
            this.schemadsTFFInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTFFInstallL3DataTableTundishID,
            this.coldsTFFInstallL3DataTableWorkID,
            this.coldsTFFInstallL3DataTableDaub_Fac,
            this.coldsTFFInstallL3DataTableRefra_Fac,
            this.coldsTFFInstallL3DataTableFra_Switch_Case,
            this.coldsTFFInstallL3DataTableCon_Per,
            this.coldsTFFInstallL3DataTableGap_Fac,
            this.coldsTFFInstallL3DataTableGap_Pro_Date,
            this.coldsTFFInstallL3DataTableFirst_Gap_ID,
            this.coldsTFFInstallL3DataTableSecond_Gap_ID,
            this.coldsTFFInstallL3DataTableThird_Gap_ID,
            this.coldsTFFInstallL3DataTableFourth_Gap_ID,
            this.coldsTFFInstallL3DataTableStu_Sti_Fac,
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date,
            this.coldsTFFInstallL3DataTableFirst_Stu_Sti_ID,
            this.coldsTFFInstallL3DataTableSecond_Stu_Sti_ID,
            this.coldsTFFInstallL3DataTableThird_Stu_Sti_ID,
            this.coldsTFFInstallL3DataTableFourth_Stu_Sti_ID,
            this.coldsTFFInstallL3DataTableInstall_Per,
            this.coldsTFFInstallL3DataTableInstall_Time,
            this.coldsTFFInstallL3DataTableNote,
            this.coldsTFFInstallL3DataTableTundish_Bottom_Insulation,
            this.coldsTFFInstallL3DataTableTundish_Wall_Insulation,
            this.coldsTFFInstallL3DataTableChecker,
            this.coldsTFFInstallL3DataTableUpper_Core,
            this.coldsTFFInstallL3DataTableLower_Core,
            this.coldsTFFInstallL3DataTableCore_Install_Per,
            this.coldsTFFInstallL3DataTableGUID,
            this.coldsTFFInstallL3DataTableName,
            this.coldsTFFInstallL3DataTableConfirm_Flag});
            this.schemadsTFFInstall.TableName = "L3DataTable";
            // 
            // coldsTFFInstallL3DataTableTundishID
            // 
            this.coldsTFFInstallL3DataTableTundishID.Caption = "TundishID";
            this.coldsTFFInstallL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTFFInstallL3DataTableTundishID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableWorkID
            // 
            this.coldsTFFInstallL3DataTableWorkID.Caption = "WorkID";
            this.coldsTFFInstallL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsTFFInstallL3DataTableWorkID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableDaub_Fac
            // 
            this.coldsTFFInstallL3DataTableDaub_Fac.Caption = "Daub_Fac";
            this.coldsTFFInstallL3DataTableDaub_Fac.ColumnName = "Daub_Fac";
            this.coldsTFFInstallL3DataTableDaub_Fac.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableRefra_Fac
            // 
            this.coldsTFFInstallL3DataTableRefra_Fac.Caption = "Refra_Fac";
            this.coldsTFFInstallL3DataTableRefra_Fac.ColumnName = "Refra_Fac";
            this.coldsTFFInstallL3DataTableRefra_Fac.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableFra_Switch_Case
            // 
            this.coldsTFFInstallL3DataTableFra_Switch_Case.Caption = "Fra_Switch_Case";
            this.coldsTFFInstallL3DataTableFra_Switch_Case.ColumnName = "Fra_Switch_Case";
            this.coldsTFFInstallL3DataTableFra_Switch_Case.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableCon_Per
            // 
            this.coldsTFFInstallL3DataTableCon_Per.Caption = "Con_Per";
            this.coldsTFFInstallL3DataTableCon_Per.ColumnName = "Con_Per";
            this.coldsTFFInstallL3DataTableCon_Per.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableGap_Fac
            // 
            this.coldsTFFInstallL3DataTableGap_Fac.Caption = "Gap_Fac";
            this.coldsTFFInstallL3DataTableGap_Fac.ColumnName = "Gap_Fac";
            this.coldsTFFInstallL3DataTableGap_Fac.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableGap_Pro_Date
            // 
            this.coldsTFFInstallL3DataTableGap_Pro_Date.Caption = "Gap_Pro_Date";
            this.coldsTFFInstallL3DataTableGap_Pro_Date.ColumnName = "Gap_Pro_Date";
            this.coldsTFFInstallL3DataTableGap_Pro_Date.DataType = typeof(System.DateTime);
            this.coldsTFFInstallL3DataTableGap_Pro_Date.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableFirst_Gap_ID
            // 
            this.coldsTFFInstallL3DataTableFirst_Gap_ID.Caption = "First_Gap_ID";
            this.coldsTFFInstallL3DataTableFirst_Gap_ID.ColumnName = "First_Gap_ID";
            this.coldsTFFInstallL3DataTableFirst_Gap_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableSecond_Gap_ID
            // 
            this.coldsTFFInstallL3DataTableSecond_Gap_ID.Caption = "Second_Gap_ID";
            this.coldsTFFInstallL3DataTableSecond_Gap_ID.ColumnName = "Second_Gap_ID";
            this.coldsTFFInstallL3DataTableSecond_Gap_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableThird_Gap_ID
            // 
            this.coldsTFFInstallL3DataTableThird_Gap_ID.Caption = "Third_Gap_ID";
            this.coldsTFFInstallL3DataTableThird_Gap_ID.ColumnName = "Third_Gap_ID";
            this.coldsTFFInstallL3DataTableThird_Gap_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableFourth_Gap_ID
            // 
            this.coldsTFFInstallL3DataTableFourth_Gap_ID.Caption = "Fourth_Gap_ID";
            this.coldsTFFInstallL3DataTableFourth_Gap_ID.ColumnName = "Fourth_Gap_ID";
            this.coldsTFFInstallL3DataTableFourth_Gap_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableStu_Sti_Fac
            // 
            this.coldsTFFInstallL3DataTableStu_Sti_Fac.Caption = "Stu_Sti_Fac";
            this.coldsTFFInstallL3DataTableStu_Sti_Fac.ColumnName = "Stu_Sti_Fac";
            this.coldsTFFInstallL3DataTableStu_Sti_Fac.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableStu_Sti_Pro_Date
            // 
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date.Caption = "Stu_Sti_Pro_Date";
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date.ColumnName = "Stu_Sti_Pro_Date";
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date.DataType = typeof(System.DateTime);
            this.coldsTFFInstallL3DataTableStu_Sti_Pro_Date.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableFirst_Stu_Sti_ID
            // 
            this.coldsTFFInstallL3DataTableFirst_Stu_Sti_ID.Caption = "First_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableFirst_Stu_Sti_ID.ColumnName = "First_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableFirst_Stu_Sti_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableSecond_Stu_Sti_ID
            // 
            this.coldsTFFInstallL3DataTableSecond_Stu_Sti_ID.Caption = "Second_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableSecond_Stu_Sti_ID.ColumnName = "Second_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableSecond_Stu_Sti_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableThird_Stu_Sti_ID
            // 
            this.coldsTFFInstallL3DataTableThird_Stu_Sti_ID.Caption = "Third_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableThird_Stu_Sti_ID.ColumnName = "Third_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableThird_Stu_Sti_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableFourth_Stu_Sti_ID
            // 
            this.coldsTFFInstallL3DataTableFourth_Stu_Sti_ID.Caption = "Fourth_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableFourth_Stu_Sti_ID.ColumnName = "Fourth_Stu_Sti_ID";
            this.coldsTFFInstallL3DataTableFourth_Stu_Sti_ID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableInstall_Per
            // 
            this.coldsTFFInstallL3DataTableInstall_Per.Caption = "Install_Per";
            this.coldsTFFInstallL3DataTableInstall_Per.ColumnName = "Install_Per";
            this.coldsTFFInstallL3DataTableInstall_Per.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableInstall_Time
            // 
            this.coldsTFFInstallL3DataTableInstall_Time.Caption = "Install_Time";
            this.coldsTFFInstallL3DataTableInstall_Time.ColumnName = "Install_Time";
            this.coldsTFFInstallL3DataTableInstall_Time.DataType = typeof(System.DateTime);
            this.coldsTFFInstallL3DataTableInstall_Time.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableNote
            // 
            this.coldsTFFInstallL3DataTableNote.Caption = "Note";
            this.coldsTFFInstallL3DataTableNote.ColumnName = "Note";
            this.coldsTFFInstallL3DataTableNote.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableTundish_Bottom_Insulation
            // 
            this.coldsTFFInstallL3DataTableTundish_Bottom_Insulation.Caption = "Tundish_Bottom_Insulation";
            this.coldsTFFInstallL3DataTableTundish_Bottom_Insulation.ColumnName = "Tundish_Bottom_Insulation";
            this.coldsTFFInstallL3DataTableTundish_Bottom_Insulation.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableTundish_Wall_Insulation
            // 
            this.coldsTFFInstallL3DataTableTundish_Wall_Insulation.Caption = "Tundish_Wall_Insulation";
            this.coldsTFFInstallL3DataTableTundish_Wall_Insulation.ColumnName = "Tundish_Wall_Insulation";
            this.coldsTFFInstallL3DataTableTundish_Wall_Insulation.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableChecker
            // 
            this.coldsTFFInstallL3DataTableChecker.Caption = "Checker";
            this.coldsTFFInstallL3DataTableChecker.ColumnName = "Checker";
            this.coldsTFFInstallL3DataTableChecker.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableUpper_Core
            // 
            this.coldsTFFInstallL3DataTableUpper_Core.Caption = "Upper_Core";
            this.coldsTFFInstallL3DataTableUpper_Core.ColumnName = "Upper_Core";
            this.coldsTFFInstallL3DataTableUpper_Core.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableLower_Core
            // 
            this.coldsTFFInstallL3DataTableLower_Core.Caption = "Lower_Core";
            this.coldsTFFInstallL3DataTableLower_Core.ColumnName = "Lower_Core";
            this.coldsTFFInstallL3DataTableLower_Core.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableCore_Install_Per
            // 
            this.coldsTFFInstallL3DataTableCore_Install_Per.Caption = "Core_Install_Per";
            this.coldsTFFInstallL3DataTableCore_Install_Per.ColumnName = "Core_Install_Per";
            this.coldsTFFInstallL3DataTableCore_Install_Per.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableGUID
            // 
            this.coldsTFFInstallL3DataTableGUID.Caption = "GUID";
            this.coldsTFFInstallL3DataTableGUID.ColumnName = "GUID";
            this.coldsTFFInstallL3DataTableGUID.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableName
            // 
            this.coldsTFFInstallL3DataTableName.Caption = "Name";
            this.coldsTFFInstallL3DataTableName.ColumnName = "Name";
            this.coldsTFFInstallL3DataTableName.Namespace = "";
            // 
            // coldsTFFInstallL3DataTableConfirm_Flag
            // 
            this.coldsTFFInstallL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsTFFInstallL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsTFFInstallL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsTFFInstallL3DataTableConfirm_Flag.Namespace = "";
            // 
            // bsTFFInstallShiftID
            // 
            this.bsTFFInstallShiftID.DataMember = "L3DataTable";
            this.bsTFFInstallShiftID.DataSource = this.dsShiftID;
            // 
            // bsTFFInstallTeamID
            // 
            this.bsTFFInstallTeamID.DataMember = "L3DataTable";
            this.bsTFFInstallTeamID.DataSource = this.dsTeamID;
            // 
            // bsTFFFireInfo
            // 
            this.bsTFFFireInfo.DataMember = "L3DataTable";
            this.bsTFFFireInfo.DataSource = this.dsTFFFireInfo;
            // 
            // dsTFFFireInfo
            // 
            this.dsTFFFireInfo.AutoLoad = true;
            this.dsTFFFireInfo.AutoSubscribe = true;
            this.dsTFFFireInfo.DataSetName = "L3DataSet";
            this.dsTFFFireInfo.DeleteMethod = null;
            this.dsTFFFireInfo.InsertMethod = null;
            this.dsTFFFireInfo.L3DataAdapter = null;
            this.dsTFFFireInfo.LoadEvent = "Click";
            this.dsTFFFireInfo.LoadTrigger = null;
            this.dsTFFFireInfo.RefreshValve = 1000;
            this.dsTFFFireInfo.SourceCommand = null;
            this.dsTFFFireInfo.SourceCondition = null;
            this.dsTFFFireInfo.SourceMethod = "";
            this.dsTFFFireInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTFFFireInfo.SourceURI = "XGMESLogic\\TundishMag\\CTundish_TFF_Hot_Fire";
            this.dsTFFFireInfo.SubscribeTarget = null;
            this.dsTFFFireInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTFFFireInfo});
            this.dsTFFFireInfo.UpdateEvent = "Click";
            this.dsTFFFireInfo.UpdateMethod = null;
            this.dsTFFFireInfo.UpdateTrigger = null;
            // 
            // schemadsTFFFireInfo
            // 
            this.schemadsTFFFireInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTFFFireInfoL3DataTableTundishID,
            this.coldsTFFFireInfoL3DataTableWorkID,
            this.coldsTFFFireInfoL3DataTableCast_ID,
            this.coldsTFFFireInfoL3DataTableTundishNO,
            this.coldsTFFFireInfoL3DataTableFirst_Fra_ID,
            this.coldsTFFFireInfoL3DataTableSecond_Fra_ID,
            this.coldsTFFFireInfoL3DataTableThird_Fra_ID,
            this.coldsTFFFireInfoL3DataTableFourth_Fra_ID,
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time,
            this.coldsTFFFireInfoL3DataTableSmall_End_Time,
            this.coldsTFFFireInfoL3DataTableMid_Start_Time,
            this.coldsTFFFireInfoL3DataTableMid_End_Time,
            this.coldsTFFFireInfoL3DataTableBig_Start_Time,
            this.coldsTFFFireInfoL3DataTableBig_End_Time,
            this.coldsTFFFireInfoL3DataTableNote,
            this.coldsTFFFireInfoL3DataTableTeamID,
            this.coldsTFFFireInfoL3DataTableShiftID,
            this.coldsTFFFireInfoL3DataTableOperator,
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press,
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press,
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press,
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp,
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp,
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press,
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp,
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp,
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press,
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp,
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp,
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press,
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp,
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp,
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux,
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press,
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp,
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp,
            this.coldsTFFFireInfoL3DataTableCrane_TeamID,
            this.coldsTFFFireInfoL3DataTableVehicleID});
            this.schemadsTFFFireInfo.TableName = "L3DataTable";
            // 
            // coldsTFFFireInfoL3DataTableTundishID
            // 
            this.coldsTFFFireInfoL3DataTableTundishID.Caption = "TundishID";
            this.coldsTFFFireInfoL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTFFFireInfoL3DataTableTundishID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableWorkID
            // 
            this.coldsTFFFireInfoL3DataTableWorkID.Caption = "WorkID";
            this.coldsTFFFireInfoL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsTFFFireInfoL3DataTableWorkID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableCast_ID
            // 
            this.coldsTFFFireInfoL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsTFFFireInfoL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsTFFFireInfoL3DataTableCast_ID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableTundishNO
            // 
            this.coldsTFFFireInfoL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsTFFFireInfoL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsTFFFireInfoL3DataTableTundishNO.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFirst_Fra_ID
            // 
            this.coldsTFFFireInfoL3DataTableFirst_Fra_ID.Caption = "First_Fra_ID";
            this.coldsTFFFireInfoL3DataTableFirst_Fra_ID.ColumnName = "First_Fra_ID";
            this.coldsTFFFireInfoL3DataTableFirst_Fra_ID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSecond_Fra_ID
            // 
            this.coldsTFFFireInfoL3DataTableSecond_Fra_ID.Caption = "Second_Fra_ID";
            this.coldsTFFFireInfoL3DataTableSecond_Fra_ID.ColumnName = "Second_Fra_ID";
            this.coldsTFFFireInfoL3DataTableSecond_Fra_ID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableThird_Fra_ID
            // 
            this.coldsTFFFireInfoL3DataTableThird_Fra_ID.Caption = "Third_Fra_ID";
            this.coldsTFFFireInfoL3DataTableThird_Fra_ID.ColumnName = "Third_Fra_ID";
            this.coldsTFFFireInfoL3DataTableThird_Fra_ID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFourth_Fra_ID
            // 
            this.coldsTFFFireInfoL3DataTableFourth_Fra_ID.Caption = "Fourth_Fra_ID";
            this.coldsTFFFireInfoL3DataTableFourth_Fra_ID.ColumnName = "Fourth_Fra_ID";
            this.coldsTFFFireInfoL3DataTableFourth_Fra_ID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSmall_Start_Time
            // 
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time.Caption = "Small_Start_Time";
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time.ColumnName = "Small_Start_Time";
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableSmall_Start_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSmall_End_Time
            // 
            this.coldsTFFFireInfoL3DataTableSmall_End_Time.Caption = "Small_End_Time";
            this.coldsTFFFireInfoL3DataTableSmall_End_Time.ColumnName = "Small_End_Time";
            this.coldsTFFFireInfoL3DataTableSmall_End_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableSmall_End_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableMid_Start_Time
            // 
            this.coldsTFFFireInfoL3DataTableMid_Start_Time.Caption = "Mid_Start_Time";
            this.coldsTFFFireInfoL3DataTableMid_Start_Time.ColumnName = "Mid_Start_Time";
            this.coldsTFFFireInfoL3DataTableMid_Start_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableMid_Start_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableMid_End_Time
            // 
            this.coldsTFFFireInfoL3DataTableMid_End_Time.Caption = "Mid_End_Time";
            this.coldsTFFFireInfoL3DataTableMid_End_Time.ColumnName = "Mid_End_Time";
            this.coldsTFFFireInfoL3DataTableMid_End_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableMid_End_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableBig_Start_Time
            // 
            this.coldsTFFFireInfoL3DataTableBig_Start_Time.Caption = "Big_Start_Time";
            this.coldsTFFFireInfoL3DataTableBig_Start_Time.ColumnName = "Big_Start_Time";
            this.coldsTFFFireInfoL3DataTableBig_Start_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableBig_Start_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableBig_End_Time
            // 
            this.coldsTFFFireInfoL3DataTableBig_End_Time.Caption = "Big_End_Time";
            this.coldsTFFFireInfoL3DataTableBig_End_Time.ColumnName = "Big_End_Time";
            this.coldsTFFFireInfoL3DataTableBig_End_Time.DataType = typeof(System.DateTime);
            this.coldsTFFFireInfoL3DataTableBig_End_Time.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableNote
            // 
            this.coldsTFFFireInfoL3DataTableNote.Caption = "Note";
            this.coldsTFFFireInfoL3DataTableNote.ColumnName = "Note";
            this.coldsTFFFireInfoL3DataTableNote.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableTeamID
            // 
            this.coldsTFFFireInfoL3DataTableTeamID.Caption = "TeamID";
            this.coldsTFFFireInfoL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsTFFFireInfoL3DataTableTeamID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableShiftID
            // 
            this.coldsTFFFireInfoL3DataTableShiftID.Caption = "ShiftID";
            this.coldsTFFFireInfoL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsTFFFireInfoL3DataTableShiftID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableOperator
            // 
            this.coldsTFFFireInfoL3DataTableOperator.Caption = "Operator";
            this.coldsTFFFireInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsTFFFireInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFir_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux.Caption = "Fir_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux.ColumnName = "Fir_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFir_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFir_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press.Caption = "Fir_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press.ColumnName = "Fir_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFir_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSec_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux.Caption = "Sec_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux.ColumnName = "Sec_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSec_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSec_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press.Caption = "Sec_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press.ColumnName = "Sec_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSec_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableThi_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux.Caption = "Thi_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux.ColumnName = "Thi_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableThi_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableThi_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press.Caption = "Thi_Gas_Press";
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press.ColumnName = "Thi_Gas_Press";
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableThi_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableThi_Wall_Temp
            // 
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp.Caption = "Thi_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp.ColumnName = "Thi_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableThi_Wall_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableThi_Gap_Temp
            // 
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp.Caption = "Thi_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp.ColumnName = "Thi_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableThi_Gap_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFou_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux.Caption = "Fou_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux.ColumnName = "Fou_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFou_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFou_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press.Caption = "Fou_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press.ColumnName = "Fou_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFou_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFou_Wall_Temp
            // 
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp.Caption = "Fou_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp.ColumnName = "Fou_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFou_Wall_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFou_Gap_Temp
            // 
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp.Caption = "Fou_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp.ColumnName = "Fou_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFou_Gap_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFiv_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux.Caption = "Fiv_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux.ColumnName = "Fiv_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFiv_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press.Caption = "Fiv_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press.ColumnName = "Fiv_Gas_Press";
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFiv_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFiv_Wall_Temp
            // 
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp.Caption = "Fiv_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp.ColumnName = "Fiv_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFiv_Wall_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableFiv_Gap_Temp
            // 
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp.Caption = "Fiv_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp.ColumnName = "Fiv_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableFiv_Gap_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSix_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux.Caption = "Six_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux.ColumnName = "Six_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSix_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSix_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press.Caption = "Six_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press.ColumnName = "Six_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSix_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSix_Wall_Temp
            // 
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp.Caption = "Six_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp.ColumnName = "Six_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSix_Wall_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSix_Gap_Temp
            // 
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp.Caption = "Six_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp.ColumnName = "Six_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSix_Gap_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSev_Gas_Flux
            // 
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux.Caption = "Sev_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux.ColumnName = "Sev_Gas_Flux";
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSev_Gas_Flux.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSev_Gas_Press
            // 
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press.Caption = "Sev_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press.ColumnName = "Sev_Gas_Press";
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSev_Gas_Press.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSev_Wall_Temp
            // 
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp.Caption = "Sev_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp.ColumnName = "Sev_Wall_Temp";
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSev_Wall_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableSev_Gap_Temp
            // 
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp.Caption = "Sev_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp.ColumnName = "Sev_Gap_Temp";
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp.DataType = typeof(double);
            this.coldsTFFFireInfoL3DataTableSev_Gap_Temp.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableCrane_TeamID
            // 
            this.coldsTFFFireInfoL3DataTableCrane_TeamID.Caption = "Crane_TeamID";
            this.coldsTFFFireInfoL3DataTableCrane_TeamID.ColumnName = "Crane_TeamID";
            this.coldsTFFFireInfoL3DataTableCrane_TeamID.Namespace = "";
            // 
            // coldsTFFFireInfoL3DataTableVehicleID
            // 
            this.coldsTFFFireInfoL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsTFFFireInfoL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsTFFFireInfoL3DataTableVehicleID.Namespace = "";
            // 
            // bsTFFHotShiftID
            // 
            this.bsTFFHotShiftID.DataMember = "L3DataTable";
            this.bsTFFHotShiftID.DataSource = this.dsShiftID;
            // 
            // bsTFFHotTeamID
            // 
            this.bsTFFHotTeamID.DataMember = "L3DataTable";
            this.bsTFFHotTeamID.DataSource = this.dsTeamID;
            // 
            // bsOTFireInfo
            // 
            this.bsOTFireInfo.DataMember = "L3DataTable";
            this.bsOTFireInfo.DataSource = this.dsOTFireInfo;
            // 
            // dsOTFireInfo
            // 
            this.dsOTFireInfo.AutoLoad = true;
            this.dsOTFireInfo.AutoSubscribe = true;
            this.dsOTFireInfo.DataSetName = "L3DataSet";
            this.dsOTFireInfo.DeleteMethod = null;
            this.dsOTFireInfo.InsertMethod = null;
            this.dsOTFireInfo.L3DataAdapter = null;
            this.dsOTFireInfo.LoadEvent = "Click";
            this.dsOTFireInfo.LoadTrigger = null;
            this.dsOTFireInfo.RefreshValve = 1000;
            this.dsOTFireInfo.SourceCommand = null;
            this.dsOTFireInfo.SourceCondition = "";
            this.dsOTFireInfo.SourceMethod = "";
            this.dsOTFireInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOTFireInfo.SourceURI = "XGMESLogic\\TundishMag\\CTundish_OT_Hot_Fire";
            this.dsOTFireInfo.SubscribeTarget = null;
            this.dsOTFireInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOTFireInfo});
            this.dsOTFireInfo.UpdateEvent = "Click";
            this.dsOTFireInfo.UpdateMethod = null;
            this.dsOTFireInfo.UpdateTrigger = null;
            // 
            // schemadsOTFireInfo
            // 
            this.schemadsOTFireInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOTFireInfoL3DataTableTundishID,
            this.coldsOTFireInfoL3DataTableWorkID,
            this.coldsOTFireInfoL3DataTableTundish_SeqNo,
            this.coldsOTFireInfoL3DataTableCast_ID,
            this.coldsOTFireInfoL3DataTableAdjust_Per,
            this.coldsOTFireInfoL3DataTableAdjust_TeamID,
            this.coldsOTFireInfoL3DataTableMove_Case,
            this.coldsOTFireInfoL3DataTableNote,
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre,
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre,
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre,
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre,
            this.coldsOTFireInfoL3DataTableFire_Start_Time,
            this.coldsOTFireInfoL3DataTableFire_End_Time,
            this.coldsOTFireInfoL3DataTableFire_Temp,
            this.coldsOTFireInfoL3DataTableTeamID,
            this.coldsOTFireInfoL3DataTableShiftID,
            this.coldsOTFireInfoL3DataTableOperator,
            this.coldsOTFireInfoL3DataTableCrane_TeamID,
            this.coldsOTFireInfoL3DataTableVehicleID});
            this.schemadsOTFireInfo.TableName = "L3DataTable";
            // 
            // coldsOTFireInfoL3DataTableTundishID
            // 
            this.coldsOTFireInfoL3DataTableTundishID.Caption = "TundishID";
            this.coldsOTFireInfoL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsOTFireInfoL3DataTableTundishID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableWorkID
            // 
            this.coldsOTFireInfoL3DataTableWorkID.Caption = "WorkID";
            this.coldsOTFireInfoL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsOTFireInfoL3DataTableWorkID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableTundish_SeqNo
            // 
            this.coldsOTFireInfoL3DataTableTundish_SeqNo.Caption = "Tundish_SeqNo";
            this.coldsOTFireInfoL3DataTableTundish_SeqNo.ColumnName = "Tundish_SeqNo";
            this.coldsOTFireInfoL3DataTableTundish_SeqNo.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableCast_ID
            // 
            this.coldsOTFireInfoL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsOTFireInfoL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsOTFireInfoL3DataTableCast_ID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableAdjust_Per
            // 
            this.coldsOTFireInfoL3DataTableAdjust_Per.Caption = "Adjust_Per";
            this.coldsOTFireInfoL3DataTableAdjust_Per.ColumnName = "Adjust_Per";
            this.coldsOTFireInfoL3DataTableAdjust_Per.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableAdjust_TeamID
            // 
            this.coldsOTFireInfoL3DataTableAdjust_TeamID.Caption = "Adjust_TeamID";
            this.coldsOTFireInfoL3DataTableAdjust_TeamID.ColumnName = "Adjust_TeamID";
            this.coldsOTFireInfoL3DataTableAdjust_TeamID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableMove_Case
            // 
            this.coldsOTFireInfoL3DataTableMove_Case.Caption = "Move_Case";
            this.coldsOTFireInfoL3DataTableMove_Case.ColumnName = "Move_Case";
            this.coldsOTFireInfoL3DataTableMove_Case.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableNote
            // 
            this.coldsOTFireInfoL3DataTableNote.Caption = "Note";
            this.coldsOTFireInfoL3DataTableNote.ColumnName = "Note";
            this.coldsOTFireInfoL3DataTableNote.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableFirst_Hyd_Pre
            // 
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre.Caption = "First_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre.ColumnName = "First_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre.DataType = typeof(double);
            this.coldsOTFireInfoL3DataTableFirst_Hyd_Pre.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableSecond_Hyd_Pre
            // 
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre.Caption = "Second_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre.ColumnName = "Second_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre.DataType = typeof(double);
            this.coldsOTFireInfoL3DataTableSecond_Hyd_Pre.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableThird_Hyd_Pre
            // 
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre.Caption = "Third_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre.ColumnName = "Third_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre.DataType = typeof(double);
            this.coldsOTFireInfoL3DataTableThird_Hyd_Pre.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableFourth_Hyd_Pre
            // 
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre.Caption = "Fourth_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre.ColumnName = "Fourth_Hyd_Pre";
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre.DataType = typeof(double);
            this.coldsOTFireInfoL3DataTableFourth_Hyd_Pre.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableFire_Start_Time
            // 
            this.coldsOTFireInfoL3DataTableFire_Start_Time.Caption = "Fire_Start_Time";
            this.coldsOTFireInfoL3DataTableFire_Start_Time.ColumnName = "Fire_Start_Time";
            this.coldsOTFireInfoL3DataTableFire_Start_Time.DataType = typeof(System.DateTime);
            this.coldsOTFireInfoL3DataTableFire_Start_Time.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableFire_End_Time
            // 
            this.coldsOTFireInfoL3DataTableFire_End_Time.Caption = "Fire_End_Time";
            this.coldsOTFireInfoL3DataTableFire_End_Time.ColumnName = "Fire_End_Time";
            this.coldsOTFireInfoL3DataTableFire_End_Time.DataType = typeof(System.DateTime);
            this.coldsOTFireInfoL3DataTableFire_End_Time.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableFire_Temp
            // 
            this.coldsOTFireInfoL3DataTableFire_Temp.Caption = "Fire_Temp";
            this.coldsOTFireInfoL3DataTableFire_Temp.ColumnName = "Fire_Temp";
            this.coldsOTFireInfoL3DataTableFire_Temp.DataType = typeof(double);
            this.coldsOTFireInfoL3DataTableFire_Temp.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableTeamID
            // 
            this.coldsOTFireInfoL3DataTableTeamID.Caption = "TeamID";
            this.coldsOTFireInfoL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsOTFireInfoL3DataTableTeamID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableShiftID
            // 
            this.coldsOTFireInfoL3DataTableShiftID.Caption = "ShiftID";
            this.coldsOTFireInfoL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsOTFireInfoL3DataTableShiftID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableOperator
            // 
            this.coldsOTFireInfoL3DataTableOperator.Caption = "Operator";
            this.coldsOTFireInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsOTFireInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableCrane_TeamID
            // 
            this.coldsOTFireInfoL3DataTableCrane_TeamID.Caption = "Crane_TeamID";
            this.coldsOTFireInfoL3DataTableCrane_TeamID.ColumnName = "Crane_TeamID";
            this.coldsOTFireInfoL3DataTableCrane_TeamID.Namespace = "";
            // 
            // coldsOTFireInfoL3DataTableVehicleID
            // 
            this.coldsOTFireInfoL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsOTFireInfoL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsOTFireInfoL3DataTableVehicleID.Namespace = "";
            // 
            // bsOTHotTeamID
            // 
            this.bsOTHotTeamID.DataMember = "L3DataTable";
            this.bsOTHotTeamID.DataSource = this.dsTeamID;
            // 
            // bsOTHotShiftID
            // 
            this.bsOTHotShiftID.DataMember = "L3DataTable";
            this.bsOTHotShiftID.DataSource = this.dsShiftID;
            // 
            // dsTundishID
            // 
            this.dsTundishID.AutoLoad = true;
            this.dsTundishID.AutoSubscribe = true;
            this.dsTundishID.DataSetName = "L3DataSet";
            this.dsTundishID.DeleteMethod = null;
            this.dsTundishID.InsertMethod = null;
            this.dsTundishID.L3DataAdapter = this.Adapter;
            this.dsTundishID.LoadEvent = "Click";
            this.dsTundishID.LoadTrigger = null;
            this.dsTundishID.RefreshValve = 1000;
            this.dsTundishID.SourceCommand = null;
            this.dsTundishID.SourceCondition = "TundishID is not null order by TundishID";
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
            // hmiRootPanel
            // 
            this.hmiRootPanel.Controls.Add(this.dvMag);
            this.hmiRootPanel.Controls.Add(this.tabControlMag);
            this.hmiRootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel.Name = "hmiRootPanel";
            this.hmiRootPanel.Size = new System.Drawing.Size(1020, 655);
            this.hmiRootPanel.TabIndex = 30;
            // 
            // dvMag
            // 
            this.dvMag.AllowUserToAddRows = false;
            this.dvMag.AutoGenerateColumns = false;
            this.dvMag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dvMag.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvMag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvMag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creatTimeDataGridViewTextBoxColumn,
            this.TundishID,
            this.innerIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.castIDDataGridViewTextBoxColumn,
            this.tundishNoDataGridViewTextBoxColumn,
            this.innerTieStartTimeDataGridViewTextBoxColumn,
            this.innerTieEndTimeDataGridViewTextBoxColumn,
            this.innerSmallFireTimeDataGridViewTextBoxColumn,
            this.innerCloseFireTimeDataGridViewTextBoxColumn,
            this.daubStartTimeDataGridViewTextBoxColumn,
            this.daubEndTimeDataGridViewTextBoxColumn,
            this.fireStartTimeDataGridViewTextBoxColumn,
            this.fireEndTimeDataGridViewTextBoxColumn,
            this.Install_Start_Time,
            this.Install_End_Time,
            this.hotSmallStartTimeDataGridViewTextBoxColumn,
            this.hotBigEndTimeDataGridViewTextBoxColumn,
            this.castStartTimeDataGridViewTextBoxColumn,
            this.castEndTimeDataGridViewTextBoxColumn,
            this.GUID,
            this.ConfirmFlag,
            this.nameDataGridViewTextBoxColumn});
            this.dvMag.DataSource = this.bsMag;
            this.dvMag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMag.Location = new System.Drawing.Point(0, 0);
            this.dvMag.MultiSelect = false;
            this.dvMag.Name = "dvMag";
            this.dvMag.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvMag.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvMag.RowTemplate.Height = 23;
            this.dvMag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvMag.Size = new System.Drawing.Size(1020, 322);
            this.dvMag.TabIndex = 4;
            this.dvMag.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            this.dvMag.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMag_DataBindingComplete);
            // 
            // creatTimeDataGridViewTextBoxColumn
            // 
            this.creatTimeDataGridViewTextBoxColumn.DataPropertyName = "Creat_Time";
            this.creatTimeDataGridViewTextBoxColumn.Frozen = true;
            this.creatTimeDataGridViewTextBoxColumn.HeaderText = "创建日期";
            this.creatTimeDataGridViewTextBoxColumn.Name = "creatTimeDataGridViewTextBoxColumn";
            this.creatTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatTimeDataGridViewTextBoxColumn.Width = 61;
            // 
            // TundishID
            // 
            this.TundishID.DataPropertyName = "TundishID";
            this.TundishID.Frozen = true;
            this.TundishID.HeaderText = "中包包号";
            this.TundishID.Name = "TundishID";
            this.TundishID.ReadOnly = true;
            this.TundishID.Width = 61;
            // 
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.Frozen = true;
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.Frozen = true;
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "中包车号";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Visible = false;
            this.vehicleIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // castIDDataGridViewTextBoxColumn
            // 
            this.castIDDataGridViewTextBoxColumn.DataPropertyName = "Cast_ID";
            this.castIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.castIDDataGridViewTextBoxColumn.Name = "castIDDataGridViewTextBoxColumn";
            this.castIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.castIDDataGridViewTextBoxColumn.Width = 51;
            // 
            // tundishNoDataGridViewTextBoxColumn
            // 
            this.tundishNoDataGridViewTextBoxColumn.DataPropertyName = "TundishNo";
            this.tundishNoDataGridViewTextBoxColumn.HeaderText = "包次号";
            this.tundishNoDataGridViewTextBoxColumn.Name = "tundishNoDataGridViewTextBoxColumn";
            this.tundishNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishNoDataGridViewTextBoxColumn.Width = 61;
            // 
            // innerTieStartTimeDataGridViewTextBoxColumn
            // 
            this.innerTieStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Inner_Tie_Start_Time";
            this.innerTieStartTimeDataGridViewTextBoxColumn.HeaderText = "永久层打结开始时间";
            this.innerTieStartTimeDataGridViewTextBoxColumn.Name = "innerTieStartTimeDataGridViewTextBoxColumn";
            this.innerTieStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerTieStartTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // innerTieEndTimeDataGridViewTextBoxColumn
            // 
            this.innerTieEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Inner_Tie_End_Time";
            this.innerTieEndTimeDataGridViewTextBoxColumn.HeaderText = "永久层打结结束时间";
            this.innerTieEndTimeDataGridViewTextBoxColumn.Name = "innerTieEndTimeDataGridViewTextBoxColumn";
            this.innerTieEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerTieEndTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // innerSmallFireTimeDataGridViewTextBoxColumn
            // 
            this.innerSmallFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Inner_Small_Fire_Time";
            this.innerSmallFireTimeDataGridViewTextBoxColumn.HeaderText = "永久层开始烘烤时间";
            this.innerSmallFireTimeDataGridViewTextBoxColumn.Name = "innerSmallFireTimeDataGridViewTextBoxColumn";
            this.innerSmallFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerSmallFireTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // innerCloseFireTimeDataGridViewTextBoxColumn
            // 
            this.innerCloseFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Inner_Close_Fire_Time";
            this.innerCloseFireTimeDataGridViewTextBoxColumn.HeaderText = "永久层结束烘烤时间";
            this.innerCloseFireTimeDataGridViewTextBoxColumn.Name = "innerCloseFireTimeDataGridViewTextBoxColumn";
            this.innerCloseFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerCloseFireTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // daubStartTimeDataGridViewTextBoxColumn
            // 
            this.daubStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Daub_Start_Time";
            this.daubStartTimeDataGridViewTextBoxColumn.HeaderText = "涂抹(干振)开始时间";
            this.daubStartTimeDataGridViewTextBoxColumn.Name = "daubStartTimeDataGridViewTextBoxColumn";
            this.daubStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.daubStartTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // daubEndTimeDataGridViewTextBoxColumn
            // 
            this.daubEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Daub_End_Time";
            this.daubEndTimeDataGridViewTextBoxColumn.HeaderText = "涂抹(干振)结束时间";
            this.daubEndTimeDataGridViewTextBoxColumn.Name = "daubEndTimeDataGridViewTextBoxColumn";
            this.daubEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.daubEndTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // fireStartTimeDataGridViewTextBoxColumn
            // 
            this.fireStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Fire_Start_Time";
            this.fireStartTimeDataGridViewTextBoxColumn.HeaderText = "工作层烘烤开始时间";
            this.fireStartTimeDataGridViewTextBoxColumn.Name = "fireStartTimeDataGridViewTextBoxColumn";
            this.fireStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fireStartTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // fireEndTimeDataGridViewTextBoxColumn
            // 
            this.fireEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Fire_End_Time";
            this.fireEndTimeDataGridViewTextBoxColumn.HeaderText = "工作层烘烤结束时间";
            this.fireEndTimeDataGridViewTextBoxColumn.Name = "fireEndTimeDataGridViewTextBoxColumn";
            this.fireEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fireEndTimeDataGridViewTextBoxColumn.Width = 94;
            // 
            // Install_Start_Time
            // 
            this.Install_Start_Time.DataPropertyName = "Install_Start_Time";
            this.Install_Start_Time.HeaderText = "上件开始时间";
            this.Install_Start_Time.Name = "Install_Start_Time";
            this.Install_Start_Time.ReadOnly = true;
            this.Install_Start_Time.Width = 72;
            // 
            // Install_End_Time
            // 
            this.Install_End_Time.DataPropertyName = "Install_End_Time";
            this.Install_End_Time.HeaderText = "上件结束时间";
            this.Install_End_Time.Name = "Install_End_Time";
            this.Install_End_Time.ReadOnly = true;
            this.Install_End_Time.Width = 72;
            // 
            // hotSmallStartTimeDataGridViewTextBoxColumn
            // 
            this.hotSmallStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Hot_Small_Start_Time";
            this.hotSmallStartTimeDataGridViewTextBoxColumn.HeaderText = "热备烘烤开始时间";
            this.hotSmallStartTimeDataGridViewTextBoxColumn.Name = "hotSmallStartTimeDataGridViewTextBoxColumn";
            this.hotSmallStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotSmallStartTimeDataGridViewTextBoxColumn.Width = 83;
            // 
            // hotBigEndTimeDataGridViewTextBoxColumn
            // 
            this.hotBigEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Hot_Big_End_Time";
            this.hotBigEndTimeDataGridViewTextBoxColumn.HeaderText = "热备烘烤结束时间";
            this.hotBigEndTimeDataGridViewTextBoxColumn.Name = "hotBigEndTimeDataGridViewTextBoxColumn";
            this.hotBigEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotBigEndTimeDataGridViewTextBoxColumn.Width = 83;
            // 
            // castStartTimeDataGridViewTextBoxColumn
            // 
            this.castStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Cast_Start_Time";
            this.castStartTimeDataGridViewTextBoxColumn.HeaderText = "中包上线时间";
            this.castStartTimeDataGridViewTextBoxColumn.Name = "castStartTimeDataGridViewTextBoxColumn";
            this.castStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.castStartTimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // castEndTimeDataGridViewTextBoxColumn
            // 
            this.castEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Cast_End_Time";
            this.castEndTimeDataGridViewTextBoxColumn.HeaderText = "中包下线时间";
            this.castEndTimeDataGridViewTextBoxColumn.Name = "castEndTimeDataGridViewTextBoxColumn";
            this.castEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.castEndTimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // GUID
            // 
            this.GUID.DataPropertyName = "GUID";
            this.GUID.HeaderText = "GUID";
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.Visible = false;
            this.GUID.Width = 54;
            // 
            // ConfirmFlag
            // 
            this.ConfirmFlag.DataPropertyName = "Confirm_Flag";
            this.ConfirmFlag.HeaderText = "实绩确认标志";
            this.ConfirmFlag.Name = "ConfirmFlag";
            this.ConfirmFlag.ReadOnly = true;
            this.ConfirmFlag.Width = 72;
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
            // tabControlMag
            // 
            this.tabControlMag.Controls.Add(this.tabInnerBuild);
            this.tabControlMag.Controls.Add(this.tabInnerFire);
            this.tabControlMag.Controls.Add(this.tabDaub);
            this.tabControlMag.Controls.Add(this.tabInstall);
            this.tabControlMag.Controls.Add(this.tabHotFire);
            this.tabControlMag.Controls.Add(this.tabRefra);
            this.tabControlMag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMag.Location = new System.Drawing.Point(0, 322);
            this.tabControlMag.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMag.Name = "tabControlMag";
            this.tabControlMag.SelectedIndex = 0;
            this.tabControlMag.Size = new System.Drawing.Size(1020, 333);
            this.tabControlMag.TabIndex = 3;
            // 
            // tabInnerBuild
            // 
            this.tabInnerBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInnerBuild.Controls.Add(this.pnlInnerBuild);
            this.tabInnerBuild.Location = new System.Drawing.Point(4, 21);
            this.tabInnerBuild.Name = "tabInnerBuild";
            this.tabInnerBuild.Padding = new System.Windows.Forms.Padding(3);
            this.tabInnerBuild.Size = new System.Drawing.Size(1012, 308);
            this.tabInnerBuild.TabIndex = 1;
            this.tabInnerBuild.Text = "永久层打结";
            this.tabInnerBuild.UseVisualStyleBackColor = true;
            // 
            // pnlInnerBuild
            // 
            this.pnlInnerBuild.Controls.Add(this.rtxtNote);
            this.pnlInnerBuild.Controls.Add(this.cmbShiftID);
            this.pnlInnerBuild.Controls.Add(this.label46);
            this.pnlInnerBuild.Controls.Add(this.txtOperator);
            this.pnlInnerBuild.Controls.Add(this.label2);
            this.pnlInnerBuild.Controls.Add(this.label44);
            this.pnlInnerBuild.Controls.Add(this.label1);
            this.pnlInnerBuild.Controls.Add(this.label47);
            this.pnlInnerBuild.Controls.Add(this.dtTieStartTime);
            this.pnlInnerBuild.Controls.Add(this.cmbTeamID);
            this.pnlInnerBuild.Controls.Add(this.dtTieEndTime);
            this.pnlInnerBuild.Controls.Add(this.label45);
            this.pnlInnerBuild.Controls.Add(this.label5);
            this.pnlInnerBuild.Controls.Add(this.textBox6);
            this.pnlInnerBuild.Controls.Add(this.label4);
            this.pnlInnerBuild.Controls.Add(this.textBox5);
            this.pnlInnerBuild.Controls.Add(this.label3);
            this.pnlInnerBuild.Controls.Add(this.textBox2);
            this.pnlInnerBuild.Controls.Add(this.cmbRefraFac);
            this.pnlInnerBuild.Controls.Add(this.txtWaste);
            this.pnlInnerBuild.Controls.Add(this.label180);
            this.pnlInnerBuild.Controls.Add(this.cmbRefraID);
            this.pnlInnerBuild.Controls.Add(this.label9);
            this.pnlInnerBuild.Controls.Add(this.label8);
            this.pnlInnerBuild.Controls.Add(this.dtCheckDate);
            this.pnlInnerBuild.Controls.Add(this.label6);
            this.pnlInnerBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInnerBuild.Location = new System.Drawing.Point(3, 3);
            this.pnlInnerBuild.Name = "pnlInnerBuild";
            this.pnlInnerBuild.Size = new System.Drawing.Size(1004, 300);
            this.pnlInnerBuild.TabIndex = 109;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(112, 88);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(760, 91);
            this.rtxtNote.TabIndex = 12;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInnerBuild, "ShiftID", true));
            this.cmbShiftID.DataSource = this.bsInnerbuildShiftID;
            this.cmbShiftID.DisplayMember = "Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(731, 35);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 10;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "Code";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(71, 91);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 108;
            this.label46.Text = "备注:";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(731, 61);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 11;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(223, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "打结开始时间:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(692, 39);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 105;
            this.label44.Text = "班次:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(223, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "打结结束时间:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(680, 65);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 104;
            this.label47.Text = "责任人:";
            // 
            // dtTieStartTime
            // 
            this.dtTieStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerBuild, "Tie_Start_Time", true));
            this.dtTieStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieStartTime.Location = new System.Drawing.Point(309, 5);
            this.dtTieStartTime.Name = "dtTieStartTime";
            this.dtTieStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtTieStartTime.TabIndex = 3;
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInnerBuild, "TeamID", true));
            this.cmbTeamID.DataSource = this.bsInnerBuildTeamID;
            this.cmbTeamID.DisplayMember = "Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(731, 9);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 9;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "Code";
            // 
            // dtTieEndTime
            // 
            this.dtTieEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerBuild, "Tie_End_Time", true));
            this.dtTieEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieEndTime.Location = new System.Drawing.Point(309, 31);
            this.dtTieEndTime.Name = "dtTieEndTime";
            this.dtTieEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtTieEndTime.TabIndex = 4;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(692, 13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 102;
            this.label45.Text = "班别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(71, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "包号:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Inner_Use_Count", true));
            this.textBox6.EnableNull = true;
            this.textBox6.ErropPr = null;
            this.textBox6.Length = 0;
            this.textBox6.Location = new System.Drawing.Point(112, 61);
            this.textBox6.Max = 0;
            this.textBox6.MaxStrLength = 0;
            this.textBox6.Min = 0;
            this.textBox6.MinStrLength = 0;
            this.textBox6.Name = "textBox6";
            this.textBox6.Precision = 0;
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 2;
            this.textBox6.ToolTipValid = null;
            this.textBox6.ValidEable = true;
            this.textBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(464, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "耐材厂家:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "InnerID", true));
            this.textBox5.EnableNull = true;
            this.textBox5.ErropPr = null;
            this.textBox5.Length = 0;
            this.textBox5.Location = new System.Drawing.Point(112, 35);
            this.textBox5.Max = 0;
            this.textBox5.MaxStrLength = 0;
            this.textBox5.Min = 0;
            this.textBox5.MinStrLength = 0;
            this.textBox5.Name = "textBox5";
            this.textBox5.Precision = 0;
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 1;
            this.textBox5.ToolTipValid = null;
            this.textBox5.ValidEable = true;
            this.textBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "永久层编号:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "TundishID", true));
            this.textBox2.EnableNull = true;
            this.textBox2.ErropPr = null;
            this.textBox2.Length = 0;
            this.textBox2.Location = new System.Drawing.Point(112, 9);
            this.textBox2.Max = 0;
            this.textBox2.MaxStrLength = 0;
            this.textBox2.Min = 0;
            this.textBox2.MinStrLength = 0;
            this.textBox2.Name = "textBox2";
            this.textBox2.Precision = 0;
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.ToolTipValid = null;
            this.textBox2.ValidEable = true;
            this.textBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbRefraFac
            // 
            this.cmbRefraFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbRefraFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Refra_Fac", true));
            this.cmbRefraFac.DataSource = this.dsInnerRefraFac;
            this.cmbRefraFac.DisplayMember = "L3DataTable.Code_Des";
            this.cmbRefraFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefraFac.EnableNull = true;
            this.cmbRefraFac.ErropPr = null;
            this.cmbRefraFac.FormattingEnabled = true;
            this.cmbRefraFac.Location = new System.Drawing.Point(526, 9);
            this.cmbRefraFac.Name = "cmbRefraFac";
            this.cmbRefraFac.Size = new System.Drawing.Size(141, 20);
            this.cmbRefraFac.TabIndex = 6;
            this.cmbRefraFac.ToolTipValid = null;
            this.cmbRefraFac.ValidEable = true;
            this.cmbRefraFac.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsInnerRefraFac
            // 
            this.dsInnerRefraFac.AutoLoad = true;
            this.dsInnerRefraFac.AutoSubscribe = true;
            this.dsInnerRefraFac.DataSetName = "L3DataSet";
            this.dsInnerRefraFac.DeleteMethod = "";
            this.dsInnerRefraFac.InsertMethod = "";
            this.dsInnerRefraFac.L3DataAdapter = this.Adapter;
            this.dsInnerRefraFac.LoadEvent = "";
            this.dsInnerRefraFac.LoadTrigger = null;
            this.dsInnerRefraFac.RefreshValve = 1000;
            this.dsInnerRefraFac.SourceCommand = null;
            this.dsInnerRefraFac.SourceCondition = "Code_Group = \'Tundish_InnerRefra_Fac\' order by Code_Des";
            this.dsInnerRefraFac.SourceMethod = "";
            this.dsInnerRefraFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInnerRefraFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsInnerRefraFac.SubscribeTarget = null;
            this.dsInnerRefraFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInnerRefraFac});
            this.dsInnerRefraFac.UpdateEvent = "";
            this.dsInnerRefraFac.UpdateMethod = "";
            this.dsInnerRefraFac.UpdateTrigger = null;
            // 
            // schemadsInnerRefraFac
            // 
            this.schemadsInnerRefraFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerRefraFacL3DataTableCode_Des});
            this.schemadsInnerRefraFac.TableName = "L3DataTable";
            // 
            // coldsInnerRefraFacL3DataTableCode_Des
            // 
            this.coldsInnerRefraFacL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsInnerRefraFacL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsInnerRefraFacL3DataTableCode_Des.Namespace = "";
            // 
            // txtWaste
            // 
            this.txtWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Waste", true));
            this.txtWaste.EnableNull = false;
            this.txtWaste.ErropPr = this.errorProvider1;
            this.txtWaste.Length = 0;
            this.txtWaste.Location = new System.Drawing.Point(526, 61);
            this.txtWaste.Max = 999;
            this.txtWaste.MaxStrLength = 0;
            this.txtWaste.Min = 0;
            this.txtWaste.MinStrLength = 0;
            this.txtWaste.Name = "txtWaste";
            this.txtWaste.Precision = 2;
            this.txtWaste.Size = new System.Drawing.Size(141, 21);
            this.txtWaste.TabIndex = 8;
            this.txtWaste.ToolTipValid = this.toolTip1;
            this.txtWaste.ValidEable = true;
            this.txtWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWaste.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.BackColor = System.Drawing.Color.Transparent;
            this.label180.Location = new System.Drawing.Point(11, 61);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(95, 12);
            this.label180.TabIndex = 39;
            this.label180.Text = "永久层使用次数:";
            // 
            // cmbRefraID
            // 
            this.cmbRefraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbRefraID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Refra_ID", true));
            this.cmbRefraID.DataSource = this.dsInnerRefraName;
            this.cmbRefraID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbRefraID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefraID.EnableNull = true;
            this.cmbRefraID.ErropPr = null;
            this.cmbRefraID.FormattingEnabled = true;
            this.cmbRefraID.Location = new System.Drawing.Point(526, 35);
            this.cmbRefraID.Name = "cmbRefraID";
            this.cmbRefraID.Size = new System.Drawing.Size(141, 20);
            this.cmbRefraID.TabIndex = 7;
            this.cmbRefraID.ToolTipValid = null;
            this.cmbRefraID.ValidEable = true;
            this.cmbRefraID.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsInnerRefraName
            // 
            this.dsInnerRefraName.AutoLoad = true;
            this.dsInnerRefraName.AutoSubscribe = true;
            this.dsInnerRefraName.DataSetName = "L3DataSet";
            this.dsInnerRefraName.DeleteMethod = "";
            this.dsInnerRefraName.InsertMethod = "";
            this.dsInnerRefraName.L3DataAdapter = this.Adapter;
            this.dsInnerRefraName.LoadEvent = "";
            this.dsInnerRefraName.LoadTrigger = null;
            this.dsInnerRefraName.RefreshValve = 1000;
            this.dsInnerRefraName.SourceCommand = null;
            this.dsInnerRefraName.SourceCondition = "Code_Group = \'Tundish_InnerRefra_Name\' order by Code_Des";
            this.dsInnerRefraName.SourceMethod = "";
            this.dsInnerRefraName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInnerRefraName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsInnerRefraName.SubscribeTarget = null;
            this.dsInnerRefraName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInnerRefraName});
            this.dsInnerRefraName.UpdateEvent = "";
            this.dsInnerRefraName.UpdateMethod = "";
            this.dsInnerRefraName.UpdateTrigger = null;
            // 
            // schemadsInnerRefraName
            // 
            this.schemadsInnerRefraName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerRefraNameL3DataTableCode_Des});
            this.schemadsInnerRefraName.TableName = "L3DataTable";
            // 
            // coldsInnerRefraNameL3DataTableCode_Des
            // 
            this.coldsInnerRefraNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsInnerRefraNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsInnerRefraNameL3DataTableCode_Des.Namespace = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(247, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "脱模时间:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(476, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 98;
            this.label8.Text = "消耗量:";
            // 
            // dtCheckDate
            // 
            this.dtCheckDate.CustomFormat = "yyyy-MM-dd";
            this.dtCheckDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "Check_Date", true));
            this.dtCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckDate.Location = new System.Drawing.Point(309, 57);
            this.dtCheckDate.Name = "dtCheckDate";
            this.dtCheckDate.Size = new System.Drawing.Size(141, 21);
            this.dtCheckDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(464, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 99;
            this.label6.Text = "耐材名称:";
            // 
            // tabInnerFire
            // 
            this.tabInnerFire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInnerFire.Controls.Add(this.textBox8);
            this.tabInnerFire.Controls.Add(this.label20);
            this.tabInnerFire.Controls.Add(this.richTextBox1);
            this.tabInnerFire.Controls.Add(this.label7);
            this.tabInnerFire.Controls.Add(this.pxComboBox1);
            this.tabInnerFire.Controls.Add(this.pxComboBox2);
            this.tabInnerFire.Controls.Add(this.pxTextBox1);
            this.tabInnerFire.Controls.Add(this.label10);
            this.tabInnerFire.Controls.Add(this.label11);
            this.tabInnerFire.Controls.Add(this.label12);
            this.tabInnerFire.Controls.Add(this.dtStopFireTime);
            this.tabInnerFire.Controls.Add(this.dtLFireTime);
            this.tabInnerFire.Controls.Add(this.label13);
            this.tabInnerFire.Controls.Add(this.label19);
            this.tabInnerFire.Controls.Add(this.textBox7);
            this.tabInnerFire.Controls.Add(this.txtStopFireOper);
            this.tabInnerFire.Controls.Add(this.txtLFireOper);
            this.tabInnerFire.Controls.Add(this.label21);
            this.tabInnerFire.Controls.Add(this.label22);
            this.tabInnerFire.Controls.Add(this.dtMFireTime);
            this.tabInnerFire.Controls.Add(this.dtSFireTime);
            this.tabInnerFire.Controls.Add(this.label14);
            this.tabInnerFire.Controls.Add(this.label15);
            this.tabInnerFire.Controls.Add(this.txtMFireOper);
            this.tabInnerFire.Controls.Add(this.txtSFireOper);
            this.tabInnerFire.Controls.Add(this.label16);
            this.tabInnerFire.Controls.Add(this.label17);
            this.tabInnerFire.Controls.Add(this.label24);
            this.tabInnerFire.Location = new System.Drawing.Point(4, 21);
            this.tabInnerFire.Name = "tabInnerFire";
            this.tabInnerFire.Padding = new System.Windows.Forms.Padding(3);
            this.tabInnerFire.Size = new System.Drawing.Size(1012, 308);
            this.tabInnerFire.TabIndex = 2;
            this.tabInnerFire.Text = "永久层烘烤";
            this.tabInnerFire.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerBuild, "InnerID", true));
            this.textBox8.EnableNull = true;
            this.textBox8.ErropPr = null;
            this.textBox8.Length = 0;
            this.textBox8.Location = new System.Drawing.Point(334, 11);
            this.textBox8.Max = 0;
            this.textBox8.MaxStrLength = 0;
            this.textBox8.Min = 0;
            this.textBox8.MinStrLength = 0;
            this.textBox8.Name = "textBox8";
            this.textBox8.Precision = 0;
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(141, 21);
            this.textBox8.TabIndex = 1;
            this.textBox8.ToolTipValid = null;
            this.textBox8.ValidEable = true;
            this.textBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(257, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 12);
            this.label20.TabIndex = 106;
            this.label20.Text = "永久层编号:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Note", true));
            this.richTextBox1.EnableNull = true;
            this.richTextBox1.ErropPr = this.errorProvider1;
            this.richTextBox1.Location = new System.Drawing.Point(79, 142);
            this.richTextBox1.MaxStrLength = 125;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 157);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.ToolTipValid = this.toolTip1;
            this.richTextBox1.ValidEable = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(39, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 104;
            this.label7.Text = "备注:";
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInnerFire, "ShiftID", true));
            this.pxComboBox1.DataSource = this.bsInnerFireShiftID;
            this.pxComboBox1.DisplayMember = "Code_Des";
            this.pxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox1.EnableNull = true;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Location = new System.Drawing.Point(556, 38);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox1.TabIndex = 11;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            this.pxComboBox1.ValueMember = "Code";
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInnerFire, "TeamID", true));
            this.pxComboBox2.DataSource = this.bsInnerFireTeamID;
            this.pxComboBox2.DisplayMember = "Code_des";
            this.pxComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Location = new System.Drawing.Point(556, 12);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox2.TabIndex = 10;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            this.pxComboBox2.ValueMember = "Code";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Operator", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(556, 64);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox1.TabIndex = 12;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(516, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 99;
            this.label10.Text = "班次:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(516, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 100;
            this.label11.Text = "班别:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(504, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 98;
            this.label12.Text = "责任人:";
            // 
            // dtStopFireTime
            // 
            this.dtStopFireTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStopFireTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerFire, "Close_Fire_Time", true));
            this.dtStopFireTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStopFireTime.Location = new System.Drawing.Point(79, 119);
            this.dtStopFireTime.Name = "dtStopFireTime";
            this.dtStopFireTime.Size = new System.Drawing.Size(141, 21);
            this.dtStopFireTime.TabIndex = 5;
            // 
            // dtLFireTime
            // 
            this.dtLFireTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLFireTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerFire, "Big_Fire_Time", true));
            this.dtLFireTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLFireTime.Location = new System.Drawing.Point(79, 92);
            this.dtLFireTime.Name = "dtLFireTime";
            this.dtLFireTime.Size = new System.Drawing.Size(141, 21);
            this.dtLFireTime.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(15, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 52;
            this.label13.Text = "停火时间:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(15, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 53;
            this.label19.Text = "大火时间:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "TundishID", true));
            this.textBox7.EnableNull = true;
            this.textBox7.ErropPr = null;
            this.textBox7.Length = 0;
            this.textBox7.Location = new System.Drawing.Point(79, 11);
            this.textBox7.Max = 0;
            this.textBox7.MaxStrLength = 0;
            this.textBox7.Min = 0;
            this.textBox7.MinStrLength = 0;
            this.textBox7.Name = "textBox7";
            this.textBox7.Precision = 0;
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(141, 21);
            this.textBox7.TabIndex = 0;
            this.textBox7.ToolTipValid = null;
            this.textBox7.ValidEable = true;
            this.textBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtStopFireOper
            // 
            this.txtStopFireOper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Close_Fire_Operator", true));
            this.txtStopFireOper.EnableNull = true;
            this.txtStopFireOper.ErropPr = null;
            this.txtStopFireOper.Length = 5;
            this.txtStopFireOper.Location = new System.Drawing.Point(334, 119);
            this.txtStopFireOper.Max = 0;
            this.txtStopFireOper.MaxLength = 5;
            this.txtStopFireOper.MaxStrLength = 0;
            this.txtStopFireOper.Min = 0;
            this.txtStopFireOper.MinStrLength = 0;
            this.txtStopFireOper.Name = "txtStopFireOper";
            this.txtStopFireOper.Precision = 0;
            this.txtStopFireOper.Size = new System.Drawing.Size(141, 21);
            this.txtStopFireOper.TabIndex = 9;
            this.txtStopFireOper.ToolTipValid = null;
            this.txtStopFireOper.ValidEable = true;
            this.txtStopFireOper.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtStopFireOper.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtLFireOper
            // 
            this.txtLFireOper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Big_Fire_Operator", true));
            this.txtLFireOper.EnableNull = true;
            this.txtLFireOper.ErropPr = null;
            this.txtLFireOper.Length = 0;
            this.txtLFireOper.Location = new System.Drawing.Point(334, 92);
            this.txtLFireOper.Max = 0;
            this.txtLFireOper.MaxStrLength = 0;
            this.txtLFireOper.Min = 0;
            this.txtLFireOper.MinStrLength = 0;
            this.txtLFireOper.Name = "txtLFireOper";
            this.txtLFireOper.Precision = 0;
            this.txtLFireOper.Size = new System.Drawing.Size(141, 21);
            this.txtLFireOper.TabIndex = 8;
            this.txtLFireOper.ToolTipValid = null;
            this.txtLFireOper.ValidEable = true;
            this.txtLFireOper.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(257, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "停火操作者:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(257, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 12);
            this.label22.TabIndex = 49;
            this.label22.Text = "大火操作者:";
            // 
            // dtMFireTime
            // 
            this.dtMFireTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtMFireTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerFire, "Mid_Fire_Time", true));
            this.dtMFireTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMFireTime.Location = new System.Drawing.Point(79, 65);
            this.dtMFireTime.Name = "dtMFireTime";
            this.dtMFireTime.Size = new System.Drawing.Size(141, 21);
            this.dtMFireTime.TabIndex = 3;
            // 
            // dtSFireTime
            // 
            this.dtSFireTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSFireTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInnerFire, "Small_Fire_Time", true));
            this.dtSFireTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSFireTime.Location = new System.Drawing.Point(79, 38);
            this.dtSFireTime.Name = "dtSFireTime";
            this.dtSFireTime.Size = new System.Drawing.Size(141, 21);
            this.dtSFireTime.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(15, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "中火时间:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(15, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 45;
            this.label15.Text = "小火时间:";
            // 
            // txtMFireOper
            // 
            this.txtMFireOper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Mid_Fire_Operator", true));
            this.txtMFireOper.EnableNull = true;
            this.txtMFireOper.ErropPr = null;
            this.txtMFireOper.Length = 0;
            this.txtMFireOper.Location = new System.Drawing.Point(334, 65);
            this.txtMFireOper.Max = 0;
            this.txtMFireOper.MaxStrLength = 0;
            this.txtMFireOper.Min = 0;
            this.txtMFireOper.MinStrLength = 0;
            this.txtMFireOper.Name = "txtMFireOper";
            this.txtMFireOper.Precision = 0;
            this.txtMFireOper.Size = new System.Drawing.Size(141, 21);
            this.txtMFireOper.TabIndex = 7;
            this.txtMFireOper.ToolTipValid = null;
            this.txtMFireOper.ValidEable = true;
            this.txtMFireOper.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSFireOper
            // 
            this.txtSFireOper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInnerFire, "Small_Fire_Operator", true));
            this.txtSFireOper.EnableNull = true;
            this.txtSFireOper.ErropPr = null;
            this.txtSFireOper.Length = 0;
            this.txtSFireOper.Location = new System.Drawing.Point(334, 38);
            this.txtSFireOper.Max = 0;
            this.txtSFireOper.MaxStrLength = 0;
            this.txtSFireOper.Min = 0;
            this.txtSFireOper.MinStrLength = 0;
            this.txtSFireOper.Name = "txtSFireOper";
            this.txtSFireOper.Precision = 0;
            this.txtSFireOper.Size = new System.Drawing.Size(141, 21);
            this.txtSFireOper.TabIndex = 6;
            this.txtSFireOper.ToolTipValid = null;
            this.txtSFireOper.ValidEable = true;
            this.txtSFireOper.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(257, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 40;
            this.label16.Text = "中火操作者:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(257, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "小火操作者:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(39, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 33;
            this.label24.Text = "包号:";
            // 
            // tabDaub
            // 
            this.tabDaub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDaub.Controls.Add(this.richTextBox2);
            this.tabDaub.Controls.Add(this.label25);
            this.tabDaub.Controls.Add(this.pxComboBox4);
            this.tabDaub.Controls.Add(this.pxComboBox5);
            this.tabDaub.Controls.Add(this.label26);
            this.tabDaub.Controls.Add(this.label27);
            this.tabDaub.Controls.Add(this.dtFireEnd);
            this.tabDaub.Controls.Add(this.dtFireStart);
            this.tabDaub.Controls.Add(this.dtBuildEnd);
            this.tabDaub.Controls.Add(this.label29);
            this.tabDaub.Controls.Add(this.dtBuildStart);
            this.tabDaub.Controls.Add(this.label30);
            this.tabDaub.Controls.Add(this.label31);
            this.tabDaub.Controls.Add(this.label32);
            this.tabDaub.Controls.Add(this.txtGluemudWaste);
            this.tabDaub.Controls.Add(this.txtDryFlapWaste);
            this.tabDaub.Controls.Add(this.txtDaubWaste);
            this.tabDaub.Controls.Add(this.cmbGluemudFac);
            this.tabDaub.Controls.Add(this.cmbDryFlapFac);
            this.tabDaub.Controls.Add(this.cmbDaubFac);
            this.tabDaub.Controls.Add(this.label28);
            this.tabDaub.Controls.Add(this.label33);
            this.tabDaub.Controls.Add(this.label34);
            this.tabDaub.Controls.Add(this.label35);
            this.tabDaub.Controls.Add(this.label36);
            this.tabDaub.Controls.Add(this.label37);
            this.tabDaub.Controls.Add(this.txtTranqFac);
            this.tabDaub.Controls.Add(this.txtWardDregsWaste);
            this.tabDaub.Controls.Add(this.txtGapBriWaste);
            this.tabDaub.Controls.Add(this.cmbTranqFac);
            this.tabDaub.Controls.Add(this.cmbWardDregsFac);
            this.tabDaub.Controls.Add(this.cmbGapBriFac);
            this.tabDaub.Controls.Add(this.label38);
            this.tabDaub.Controls.Add(this.label39);
            this.tabDaub.Controls.Add(this.label40);
            this.tabDaub.Controls.Add(this.label41);
            this.tabDaub.Controls.Add(this.label42);
            this.tabDaub.Controls.Add(this.label43);
            this.tabDaub.Controls.Add(this.pxTextBox2);
            this.tabDaub.Controls.Add(this.label48);
            this.tabDaub.Controls.Add(this.txtForeverFloorCount);
            this.tabDaub.Controls.Add(this.textBox9);
            this.tabDaub.Controls.Add(this.textBox13);
            this.tabDaub.Controls.Add(this.txtForeverFloorID);
            this.tabDaub.Controls.Add(this.cmbProject);
            this.tabDaub.Controls.Add(this.label18);
            this.tabDaub.Controls.Add(this.label50);
            this.tabDaub.Controls.Add(this.label51);
            this.tabDaub.Controls.Add(this.label52);
            this.tabDaub.Controls.Add(this.label54);
            this.tabDaub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDaub.Location = new System.Drawing.Point(4, 21);
            this.tabDaub.Name = "tabDaub";
            this.tabDaub.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaub.Size = new System.Drawing.Size(1012, 308);
            this.tabDaub.TabIndex = 3;
            this.tabDaub.Text = "工作层涂抹/干振";
            this.tabDaub.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Note", true));
            this.richTextBox2.EnableNull = true;
            this.richTextBox2.ErropPr = this.errorProvider1;
            this.richTextBox2.Location = new System.Drawing.Point(98, 173);
            this.richTextBox2.MaxStrLength = 125;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(908, 81);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            this.richTextBox2.ToolTipValid = this.toolTip1;
            this.richTextBox2.ValidEable = true;
            this.richTextBox2.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(58, 176);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 51;
            this.label25.Text = "备注:";
            // 
            // pxComboBox4
            // 
            this.pxComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDaub, "ShiftID", true));
            this.pxComboBox4.DataSource = this.bsDaubShiftID;
            this.pxComboBox4.DisplayMember = "Code_Des";
            this.pxComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox4.EnableNull = true;
            this.pxComboBox4.ErropPr = null;
            this.pxComboBox4.FormattingEnabled = true;
            this.pxComboBox4.Location = new System.Drawing.Point(372, 147);
            this.pxComboBox4.Name = "pxComboBox4";
            this.pxComboBox4.Size = new System.Drawing.Size(144, 20);
            this.pxComboBox4.TabIndex = 23;
            this.pxComboBox4.ToolTipValid = null;
            this.pxComboBox4.ValidEable = true;
            this.pxComboBox4.ValueMember = "Code";
            // 
            // pxComboBox5
            // 
            this.pxComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDaub, "TeamID", true));
            this.pxComboBox5.DataSource = this.bsDaubTeamID;
            this.pxComboBox5.DisplayMember = "Code_des";
            this.pxComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox5.EnableNull = true;
            this.pxComboBox5.ErropPr = null;
            this.pxComboBox5.FormattingEnabled = true;
            this.pxComboBox5.Location = new System.Drawing.Point(372, 121);
            this.pxComboBox5.Name = "pxComboBox5";
            this.pxComboBox5.Size = new System.Drawing.Size(144, 20);
            this.pxComboBox5.TabIndex = 22;
            this.pxComboBox5.ToolTipValid = null;
            this.pxComboBox5.ValidEable = true;
            this.pxComboBox5.ValueMember = "Code";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(332, 151);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 49;
            this.label26.Text = "班次:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(332, 125);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 12);
            this.label27.TabIndex = 48;
            this.label27.Text = "班别:";
            // 
            // dtFireEnd
            // 
            this.dtFireEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDaub, "Fire_End_Time", true));
            this.dtFireEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireEnd.Location = new System.Drawing.Point(372, 93);
            this.dtFireEnd.Name = "dtFireEnd";
            this.dtFireEnd.Size = new System.Drawing.Size(144, 21);
            this.dtFireEnd.TabIndex = 9;
            // 
            // dtFireStart
            // 
            this.dtFireStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDaub, "Fire_Start_Time", true));
            this.dtFireStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireStart.Location = new System.Drawing.Point(372, 67);
            this.dtFireStart.Name = "dtFireStart";
            this.dtFireStart.Size = new System.Drawing.Size(144, 21);
            this.dtFireStart.TabIndex = 8;
            // 
            // dtBuildEnd
            // 
            this.dtBuildEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDaub, "Daub_End_Time", true));
            this.dtBuildEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildEnd.Location = new System.Drawing.Point(372, 41);
            this.dtBuildEnd.Name = "dtBuildEnd";
            this.dtBuildEnd.Size = new System.Drawing.Size(144, 21);
            this.dtBuildEnd.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(284, 99);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 12);
            this.label29.TabIndex = 35;
            this.label29.Text = "烘烤结束时间:";
            // 
            // dtBuildStart
            // 
            this.dtBuildStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDaub, "Daub_Start_Time", true));
            this.dtBuildStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildStart.Location = new System.Drawing.Point(372, 15);
            this.dtBuildStart.Name = "dtBuildStart";
            this.dtBuildStart.Size = new System.Drawing.Size(144, 21);
            this.dtBuildStart.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(284, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 12);
            this.label30.TabIndex = 34;
            this.label30.Text = "烘烤开始时间:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(248, 47);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 33;
            this.label31.Text = "涂抹(干振)结束时间:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(248, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 12);
            this.label32.TabIndex = 32;
            this.label32.Text = "涂抹(干振)开始时间:";
            // 
            // txtGluemudWaste
            // 
            this.txtGluemudWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Gluemud_Consume", true));
            this.txtGluemudWaste.EnableNull = true;
            this.txtGluemudWaste.ErropPr = null;
            this.txtGluemudWaste.Length = 0;
            this.txtGluemudWaste.Location = new System.Drawing.Point(862, 63);
            this.txtGluemudWaste.Max = 0;
            this.txtGluemudWaste.MaxStrLength = 0;
            this.txtGluemudWaste.Min = 0;
            this.txtGluemudWaste.MinStrLength = 0;
            this.txtGluemudWaste.Name = "txtGluemudWaste";
            this.txtGluemudWaste.Precision = 0;
            this.txtGluemudWaste.Size = new System.Drawing.Size(144, 21);
            this.txtGluemudWaste.TabIndex = 15;
            this.txtGluemudWaste.ToolTipValid = null;
            this.txtGluemudWaste.ValidEable = true;
            this.txtGluemudWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtDryFlapWaste
            // 
            this.txtDryFlapWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Dry_Flap_Consume", true));
            this.txtDryFlapWaste.EnableNull = true;
            this.txtDryFlapWaste.ErropPr = null;
            this.txtDryFlapWaste.Length = 0;
            this.txtDryFlapWaste.Location = new System.Drawing.Point(862, 11);
            this.txtDryFlapWaste.Max = 0;
            this.txtDryFlapWaste.MaxStrLength = 0;
            this.txtDryFlapWaste.Min = 0;
            this.txtDryFlapWaste.MinStrLength = 0;
            this.txtDryFlapWaste.Name = "txtDryFlapWaste";
            this.txtDryFlapWaste.Precision = 0;
            this.txtDryFlapWaste.Size = new System.Drawing.Size(144, 21);
            this.txtDryFlapWaste.TabIndex = 11;
            this.txtDryFlapWaste.ToolTipValid = null;
            this.txtDryFlapWaste.ValidEable = true;
            this.txtDryFlapWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtDaubWaste
            // 
            this.txtDaubWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Daub_Consume", true));
            this.txtDaubWaste.EnableNull = true;
            this.txtDaubWaste.ErropPr = null;
            this.txtDaubWaste.Length = 0;
            this.txtDaubWaste.Location = new System.Drawing.Point(862, 37);
            this.txtDaubWaste.Max = 0;
            this.txtDaubWaste.MaxStrLength = 0;
            this.txtDaubWaste.Min = 0;
            this.txtDaubWaste.MinStrLength = 0;
            this.txtDaubWaste.Name = "txtDaubWaste";
            this.txtDaubWaste.Precision = 0;
            this.txtDaubWaste.Size = new System.Drawing.Size(144, 21);
            this.txtDaubWaste.TabIndex = 13;
            this.txtDaubWaste.ToolTipValid = null;
            this.txtDaubWaste.ValidEable = true;
            this.txtDaubWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbGluemudFac
            // 
            this.cmbGluemudFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGluemudFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGluemudFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGluemudFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Gluemud_Fac", true));
            this.cmbGluemudFac.DataSource = this.dsGluemudFac;
            this.cmbGluemudFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbGluemudFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGluemudFac.EnableNull = true;
            this.cmbGluemudFac.ErropPr = null;
            this.cmbGluemudFac.FormattingEnabled = true;
            this.cmbGluemudFac.Location = new System.Drawing.Point(614, 63);
            this.cmbGluemudFac.Name = "cmbGluemudFac";
            this.cmbGluemudFac.Size = new System.Drawing.Size(144, 20);
            this.cmbGluemudFac.TabIndex = 14;
            this.cmbGluemudFac.ToolTipValid = null;
            this.cmbGluemudFac.ValidEable = true;
            this.cmbGluemudFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsGluemudFac
            // 
            this.dsGluemudFac.AutoLoad = true;
            this.dsGluemudFac.AutoSubscribe = true;
            this.dsGluemudFac.DataSetName = "L3DataSet";
            this.dsGluemudFac.DeleteMethod = null;
            this.dsGluemudFac.InsertMethod = null;
            this.dsGluemudFac.L3DataAdapter = this.Adapter;
            this.dsGluemudFac.LoadEvent = "Click";
            this.dsGluemudFac.LoadTrigger = null;
            this.dsGluemudFac.RefreshValve = 1000;
            this.dsGluemudFac.SourceCommand = null;
            this.dsGluemudFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'胶泥\'";
            this.dsGluemudFac.SourceMethod = "";
            this.dsGluemudFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGluemudFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsGluemudFac.SubscribeTarget = null;
            this.dsGluemudFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGluemudFac});
            this.dsGluemudFac.UpdateEvent = "Click";
            this.dsGluemudFac.UpdateMethod = null;
            this.dsGluemudFac.UpdateTrigger = null;
            // 
            // schemadsGluemudFac
            // 
            this.schemadsGluemudFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGluemudFacL3DataTableMATFACTORY});
            this.schemadsGluemudFac.TableName = "L3DataTable";
            // 
            // coldsGluemudFacL3DataTableMATFACTORY
            // 
            this.coldsGluemudFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsGluemudFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsGluemudFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbDryFlapFac
            // 
            this.cmbDryFlapFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDryFlapFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDryFlapFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDryFlapFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Dry_Flap_Fac", true));
            this.cmbDryFlapFac.DataSource = this.dsDryMatFac;
            this.cmbDryFlapFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbDryFlapFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDryFlapFac.EnableNull = true;
            this.cmbDryFlapFac.ErropPr = null;
            this.cmbDryFlapFac.FormattingEnabled = true;
            this.cmbDryFlapFac.Location = new System.Drawing.Point(614, 11);
            this.cmbDryFlapFac.Name = "cmbDryFlapFac";
            this.cmbDryFlapFac.Size = new System.Drawing.Size(144, 20);
            this.cmbDryFlapFac.TabIndex = 10;
            this.cmbDryFlapFac.ToolTipValid = null;
            this.cmbDryFlapFac.ValidEable = true;
            this.cmbDryFlapFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsDryMatFac
            // 
            this.dsDryMatFac.AutoLoad = true;
            this.dsDryMatFac.AutoSubscribe = true;
            this.dsDryMatFac.DataSetName = "L3DataSet";
            this.dsDryMatFac.DeleteMethod = null;
            this.dsDryMatFac.InsertMethod = null;
            this.dsDryMatFac.L3DataAdapter = this.Adapter;
            this.dsDryMatFac.LoadEvent = "Click";
            this.dsDryMatFac.LoadTrigger = null;
            this.dsDryMatFac.RefreshValve = 1000;
            this.dsDryMatFac.SourceCommand = null;
            this.dsDryMatFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'干振料\'";
            this.dsDryMatFac.SourceMethod = "";
            this.dsDryMatFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDryMatFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsDryMatFac.SubscribeTarget = null;
            this.dsDryMatFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDryMatFac});
            this.dsDryMatFac.UpdateEvent = "Click";
            this.dsDryMatFac.UpdateMethod = null;
            this.dsDryMatFac.UpdateTrigger = null;
            // 
            // schemadsDryMatFac
            // 
            this.schemadsDryMatFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDryMatFacL3DataTableMATFACTORY});
            this.schemadsDryMatFac.TableName = "L3DataTable";
            // 
            // coldsDryMatFacL3DataTableMATFACTORY
            // 
            this.coldsDryMatFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsDryMatFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsDryMatFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbDaubFac
            // 
            this.cmbDaubFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDaubFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDaubFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDaubFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Daub_Fac", true));
            this.cmbDaubFac.DataSource = this.dsDaubFac;
            this.cmbDaubFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbDaubFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDaubFac.EnableNull = true;
            this.cmbDaubFac.ErropPr = null;
            this.cmbDaubFac.FormattingEnabled = true;
            this.cmbDaubFac.Location = new System.Drawing.Point(614, 37);
            this.cmbDaubFac.Name = "cmbDaubFac";
            this.cmbDaubFac.Size = new System.Drawing.Size(144, 20);
            this.cmbDaubFac.TabIndex = 12;
            this.cmbDaubFac.ToolTipValid = null;
            this.cmbDaubFac.ValidEable = true;
            this.cmbDaubFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsDaubFac
            // 
            this.dsDaubFac.AutoLoad = true;
            this.dsDaubFac.AutoSubscribe = true;
            this.dsDaubFac.DataSetName = "L3DataSet";
            this.dsDaubFac.DeleteMethod = null;
            this.dsDaubFac.InsertMethod = null;
            this.dsDaubFac.L3DataAdapter = this.Adapter;
            this.dsDaubFac.LoadEvent = "Click";
            this.dsDaubFac.LoadTrigger = null;
            this.dsDaubFac.RefreshValve = 1000;
            this.dsDaubFac.SourceCommand = null;
            this.dsDaubFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'涂抹料\'";
            this.dsDaubFac.SourceMethod = "";
            this.dsDaubFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDaubFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsDaubFac.SubscribeTarget = null;
            this.dsDaubFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDaubFac});
            this.dsDaubFac.UpdateEvent = "Click";
            this.dsDaubFac.UpdateMethod = null;
            this.dsDaubFac.UpdateTrigger = null;
            // 
            // schemadsDaubFac
            // 
            this.schemadsDaubFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDaubFacL3DataTableMATFACTORY});
            this.schemadsDaubFac.TableName = "L3DataTable";
            // 
            // coldsDaubFacL3DataTableMATFACTORY
            // 
            this.coldsDaubFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsDaubFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsDaubFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(786, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 12);
            this.label28.TabIndex = 39;
            this.label28.Text = "胶泥消耗量:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(774, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 12);
            this.label33.TabIndex = 37;
            this.label33.Text = "干振料消耗量:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(774, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 12);
            this.label34.TabIndex = 47;
            this.label34.Text = "涂抹料消耗量:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(550, 67);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 38;
            this.label35.Text = "胶泥厂家:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(538, 15);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 12);
            this.label36.TabIndex = 36;
            this.label36.Text = "干振料厂家:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(538, 41);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 12);
            this.label37.TabIndex = 46;
            this.label37.Text = "涂抹料厂家:";
            // 
            // txtTranqFac
            // 
            this.txtTranqFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Tranq_Consume", true));
            this.txtTranqFac.EnableNull = true;
            this.txtTranqFac.ErropPr = null;
            this.txtTranqFac.Length = 0;
            this.txtTranqFac.Location = new System.Drawing.Point(862, 141);
            this.txtTranqFac.Max = 0;
            this.txtTranqFac.MaxStrLength = 0;
            this.txtTranqFac.Min = 0;
            this.txtTranqFac.MinStrLength = 0;
            this.txtTranqFac.Name = "txtTranqFac";
            this.txtTranqFac.Precision = 0;
            this.txtTranqFac.Size = new System.Drawing.Size(144, 21);
            this.txtTranqFac.TabIndex = 21;
            this.txtTranqFac.ToolTipValid = null;
            this.txtTranqFac.ValidEable = true;
            this.txtTranqFac.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWardDregsWaste
            // 
            this.txtWardDregsWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Ward_Dregs_Consume", true));
            this.txtWardDregsWaste.EnableNull = true;
            this.txtWardDregsWaste.ErropPr = null;
            this.txtWardDregsWaste.Length = 0;
            this.txtWardDregsWaste.Location = new System.Drawing.Point(862, 115);
            this.txtWardDregsWaste.Max = 0;
            this.txtWardDregsWaste.MaxStrLength = 0;
            this.txtWardDregsWaste.Min = 0;
            this.txtWardDregsWaste.MinStrLength = 0;
            this.txtWardDregsWaste.Name = "txtWardDregsWaste";
            this.txtWardDregsWaste.Precision = 0;
            this.txtWardDregsWaste.Size = new System.Drawing.Size(144, 21);
            this.txtWardDregsWaste.TabIndex = 19;
            this.txtWardDregsWaste.ToolTipValid = null;
            this.txtWardDregsWaste.ValidEable = true;
            this.txtWardDregsWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtGapBriWaste
            // 
            this.txtGapBriWaste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Gap_Bri_Consume", true));
            this.txtGapBriWaste.EnableNull = true;
            this.txtGapBriWaste.ErropPr = null;
            this.txtGapBriWaste.Length = 0;
            this.txtGapBriWaste.Location = new System.Drawing.Point(862, 89);
            this.txtGapBriWaste.Max = 0;
            this.txtGapBriWaste.MaxStrLength = 0;
            this.txtGapBriWaste.Min = 0;
            this.txtGapBriWaste.MinStrLength = 0;
            this.txtGapBriWaste.Name = "txtGapBriWaste";
            this.txtGapBriWaste.Precision = 0;
            this.txtGapBriWaste.Size = new System.Drawing.Size(144, 21);
            this.txtGapBriWaste.TabIndex = 17;
            this.txtGapBriWaste.ToolTipValid = null;
            this.txtGapBriWaste.ValidEable = true;
            this.txtGapBriWaste.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbTranqFac
            // 
            this.cmbTranqFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTranqFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTranqFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTranqFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Tranq_Fac", true));
            this.cmbTranqFac.DataSource = this.dsTranqFac;
            this.cmbTranqFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbTranqFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranqFac.EnableNull = true;
            this.cmbTranqFac.ErropPr = null;
            this.cmbTranqFac.FormattingEnabled = true;
            this.cmbTranqFac.Location = new System.Drawing.Point(614, 141);
            this.cmbTranqFac.Name = "cmbTranqFac";
            this.cmbTranqFac.Size = new System.Drawing.Size(144, 20);
            this.cmbTranqFac.TabIndex = 20;
            this.cmbTranqFac.ToolTipValid = null;
            this.cmbTranqFac.ValidEable = true;
            this.cmbTranqFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsTranqFac
            // 
            this.dsTranqFac.AutoLoad = true;
            this.dsTranqFac.AutoSubscribe = true;
            this.dsTranqFac.DataSetName = "L3DataSet";
            this.dsTranqFac.DeleteMethod = null;
            this.dsTranqFac.InsertMethod = null;
            this.dsTranqFac.L3DataAdapter = this.Adapter;
            this.dsTranqFac.LoadEvent = "Click";
            this.dsTranqFac.LoadTrigger = null;
            this.dsTranqFac.RefreshValve = 1000;
            this.dsTranqFac.SourceCommand = null;
            this.dsTranqFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'紊流器\'";
            this.dsTranqFac.SourceMethod = "";
            this.dsTranqFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTranqFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsTranqFac.SubscribeTarget = null;
            this.dsTranqFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTranqFac});
            this.dsTranqFac.UpdateEvent = "Click";
            this.dsTranqFac.UpdateMethod = null;
            this.dsTranqFac.UpdateTrigger = null;
            // 
            // schemadsTranqFac
            // 
            this.schemadsTranqFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTranqFacL3DataTableMATFACTORY});
            this.schemadsTranqFac.TableName = "L3DataTable";
            // 
            // coldsTranqFacL3DataTableMATFACTORY
            // 
            this.coldsTranqFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsTranqFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsTranqFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbWardDregsFac
            // 
            this.cmbWardDregsFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWardDregsFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWardDregsFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbWardDregsFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Ward_Dregs_Fac", true));
            this.cmbWardDregsFac.DataSource = this.dsWardDregsFac;
            this.cmbWardDregsFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbWardDregsFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWardDregsFac.EnableNull = true;
            this.cmbWardDregsFac.ErropPr = null;
            this.cmbWardDregsFac.FormattingEnabled = true;
            this.cmbWardDregsFac.Location = new System.Drawing.Point(614, 115);
            this.cmbWardDregsFac.Name = "cmbWardDregsFac";
            this.cmbWardDregsFac.Size = new System.Drawing.Size(144, 20);
            this.cmbWardDregsFac.TabIndex = 18;
            this.cmbWardDregsFac.ToolTipValid = null;
            this.cmbWardDregsFac.ValidEable = true;
            this.cmbWardDregsFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsWardDregsFac
            // 
            this.dsWardDregsFac.AutoLoad = true;
            this.dsWardDregsFac.AutoSubscribe = true;
            this.dsWardDregsFac.DataSetName = "L3DataSet";
            this.dsWardDregsFac.DeleteMethod = null;
            this.dsWardDregsFac.InsertMethod = null;
            this.dsWardDregsFac.L3DataAdapter = this.Adapter;
            this.dsWardDregsFac.LoadEvent = "Click";
            this.dsWardDregsFac.LoadTrigger = null;
            this.dsWardDregsFac.RefreshValve = 1000;
            this.dsWardDregsFac.SourceCommand = null;
            this.dsWardDregsFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'挡渣墙\'";
            this.dsWardDregsFac.SourceMethod = "";
            this.dsWardDregsFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWardDregsFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsWardDregsFac.SubscribeTarget = null;
            this.dsWardDregsFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWardDregsFac});
            this.dsWardDregsFac.UpdateEvent = "Click";
            this.dsWardDregsFac.UpdateMethod = null;
            this.dsWardDregsFac.UpdateTrigger = null;
            // 
            // schemadsWardDregsFac
            // 
            this.schemadsWardDregsFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWardDregsFacL3DataTableMATFACTORY});
            this.schemadsWardDregsFac.TableName = "L3DataTable";
            // 
            // coldsWardDregsFacL3DataTableMATFACTORY
            // 
            this.coldsWardDregsFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsWardDregsFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsWardDregsFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbGapBriFac
            // 
            this.cmbGapBriFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGapBriFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGapBriFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGapBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Gap_Bri_Fac", true));
            this.cmbGapBriFac.DataSource = this.dsGapBriFac;
            this.cmbGapBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbGapBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGapBriFac.EnableNull = true;
            this.cmbGapBriFac.ErropPr = null;
            this.cmbGapBriFac.FormattingEnabled = true;
            this.cmbGapBriFac.Location = new System.Drawing.Point(614, 89);
            this.cmbGapBriFac.Name = "cmbGapBriFac";
            this.cmbGapBriFac.Size = new System.Drawing.Size(144, 20);
            this.cmbGapBriFac.TabIndex = 16;
            this.cmbGapBriFac.ToolTipValid = null;
            this.cmbGapBriFac.ValidEable = true;
            this.cmbGapBriFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsGapBriFac
            // 
            this.dsGapBriFac.AutoLoad = true;
            this.dsGapBriFac.AutoSubscribe = true;
            this.dsGapBriFac.DataSetName = "L3DataSet";
            this.dsGapBriFac.DeleteMethod = null;
            this.dsGapBriFac.InsertMethod = null;
            this.dsGapBriFac.L3DataAdapter = this.Adapter;
            this.dsGapBriFac.LoadEvent = "Click";
            this.dsGapBriFac.LoadTrigger = null;
            this.dsGapBriFac.RefreshValve = 1000;
            this.dsGapBriFac.SourceCommand = null;
            this.dsGapBriFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'座砖\'";
            this.dsGapBriFac.SourceMethod = "";
            this.dsGapBriFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGapBriFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsGapBriFac.SubscribeTarget = null;
            this.dsGapBriFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGapBriFac});
            this.dsGapBriFac.UpdateEvent = "Click";
            this.dsGapBriFac.UpdateMethod = null;
            this.dsGapBriFac.UpdateTrigger = null;
            // 
            // schemadsGapBriFac
            // 
            this.schemadsGapBriFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGapBriFacL3DataTableMATFACTORY});
            this.schemadsGapBriFac.TableName = "L3DataTable";
            // 
            // coldsGapBriFacL3DataTableMATFACTORY
            // 
            this.coldsGapBriFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsGapBriFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsGapBriFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(774, 145);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(83, 12);
            this.label38.TabIndex = 45;
            this.label38.Text = "紊流器消耗量:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(774, 119);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(83, 12);
            this.label39.TabIndex = 43;
            this.label39.Text = "挡渣墙消耗量:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(786, 93);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 12);
            this.label40.TabIndex = 41;
            this.label40.Text = "座砖消耗量:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(538, 145);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 12);
            this.label41.TabIndex = 44;
            this.label41.Text = "紊流器厂家:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(538, 119);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 12);
            this.label42.TabIndex = 42;
            this.label42.Text = "挡渣墙厂家:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(550, 93);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 12);
            this.label43.TabIndex = 40;
            this.label43.Text = "座砖厂家:";
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Operator", true));
            this.pxTextBox2.EnableNull = true;
            this.pxTextBox2.ErropPr = null;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(98, 145);
            this.pxTextBox2.Max = 0;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox2.TabIndex = 24;
            this.pxTextBox2.ToolTipValid = null;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Location = new System.Drawing.Point(45, 149);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(47, 12);
            this.label48.TabIndex = 50;
            this.label48.Text = "责任人:";
            // 
            // txtForeverFloorCount
            // 
            this.txtForeverFloorCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "Inner_Use_Count", true));
            this.txtForeverFloorCount.EnableNull = true;
            this.txtForeverFloorCount.ErropPr = null;
            this.txtForeverFloorCount.Length = 0;
            this.txtForeverFloorCount.Location = new System.Drawing.Point(98, 94);
            this.txtForeverFloorCount.Max = 0;
            this.txtForeverFloorCount.MaxStrLength = 0;
            this.txtForeverFloorCount.Min = 0;
            this.txtForeverFloorCount.MinStrLength = 0;
            this.txtForeverFloorCount.Name = "txtForeverFloorCount";
            this.txtForeverFloorCount.Precision = 0;
            this.txtForeverFloorCount.ReadOnly = true;
            this.txtForeverFloorCount.Size = new System.Drawing.Size(144, 21);
            this.txtForeverFloorCount.TabIndex = 3;
            this.txtForeverFloorCount.ToolTipValid = null;
            this.txtForeverFloorCount.ValidEable = true;
            this.txtForeverFloorCount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "TundishID", true));
            this.textBox9.EnableNull = true;
            this.textBox9.ErropPr = null;
            this.textBox9.Length = 0;
            this.textBox9.Location = new System.Drawing.Point(98, 16);
            this.textBox9.Max = 0;
            this.textBox9.MaxStrLength = 0;
            this.textBox9.Min = 0;
            this.textBox9.MinStrLength = 0;
            this.textBox9.Name = "textBox9";
            this.textBox9.Precision = 0;
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(144, 21);
            this.textBox9.TabIndex = 0;
            this.textBox9.ToolTipValid = null;
            this.textBox9.ValidEable = true;
            this.textBox9.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "InnerID", true));
            this.textBox13.EnableNull = true;
            this.textBox13.ErropPr = null;
            this.textBox13.Length = 0;
            this.textBox13.Location = new System.Drawing.Point(98, 68);
            this.textBox13.Max = 0;
            this.textBox13.MaxStrLength = 0;
            this.textBox13.Min = 0;
            this.textBox13.MinStrLength = 0;
            this.textBox13.Name = "textBox13";
            this.textBox13.Precision = 0;
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(144, 21);
            this.textBox13.TabIndex = 2;
            this.textBox13.ToolTipValid = null;
            this.textBox13.ValidEable = true;
            this.textBox13.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtForeverFloorID
            // 
            this.txtForeverFloorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaub, "WorkID", true));
            this.txtForeverFloorID.EnableNull = true;
            this.txtForeverFloorID.ErropPr = null;
            this.txtForeverFloorID.Length = 0;
            this.txtForeverFloorID.Location = new System.Drawing.Point(98, 42);
            this.txtForeverFloorID.Max = 0;
            this.txtForeverFloorID.MaxStrLength = 0;
            this.txtForeverFloorID.Min = 0;
            this.txtForeverFloorID.MinStrLength = 0;
            this.txtForeverFloorID.Name = "txtForeverFloorID";
            this.txtForeverFloorID.Precision = 0;
            this.txtForeverFloorID.ReadOnly = true;
            this.txtForeverFloorID.Size = new System.Drawing.Size(144, 21);
            this.txtForeverFloorID.TabIndex = 1;
            this.txtForeverFloorID.ToolTipValid = null;
            this.txtForeverFloorID.ValidEable = true;
            this.txtForeverFloorID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbProject
            // 
            this.cmbProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProject.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDaub, "Project", true));
            this.cmbProject.DataSource = this.dsProject;
            this.cmbProject.DisplayMember = "L3DataTable.Code_Des";
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.EnableNull = true;
            this.cmbProject.ErropPr = null;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(98, 120);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(144, 20);
            this.cmbProject.TabIndex = 4;
            this.cmbProject.ToolTipValid = null;
            this.cmbProject.ValidEable = true;
            this.cmbProject.ValueMember = "L3DataTable.Code";
            // 
            // dsProject
            // 
            this.dsProject.AutoLoad = true;
            this.dsProject.AutoSubscribe = false;
            this.dsProject.DataSetName = "L3DataSet";
            this.dsProject.DeleteMethod = "";
            this.dsProject.InsertMethod = "";
            this.dsProject.L3DataAdapter = this.Adapter;
            this.dsProject.LoadEvent = "";
            this.dsProject.LoadTrigger = null;
            this.dsProject.RefreshValve = 1000;
            this.dsProject.SourceCommand = null;
            this.dsProject.SourceCondition = "Code_Group = \'Tundish_Project\'　and Code is not null order by Code";
            this.dsProject.SourceMethod = "";
            this.dsProject.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProject.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProject.SubscribeTarget = null;
            this.dsProject.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProject});
            this.dsProject.UpdateEvent = "";
            this.dsProject.UpdateMethod = "";
            this.dsProject.UpdateTrigger = null;
            // 
            // schemadsProject
            // 
            this.schemadsProject.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProjectL3DataTableCode,
            this.coldsProjectL3DataTableCode_Des});
            this.schemadsProject.TableName = "L3DataTable";
            // 
            // coldsProjectL3DataTableCode
            // 
            this.coldsProjectL3DataTableCode.Caption = "Code";
            this.coldsProjectL3DataTableCode.ColumnName = "Code";
            this.coldsProjectL3DataTableCode.Namespace = "";
            // 
            // coldsProjectL3DataTableCode_Des
            // 
            this.coldsProjectL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProjectL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProjectL3DataTableCode_Des.Namespace = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(22, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 30;
            this.label18.Text = "永久层编号:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Location = new System.Drawing.Point(-2, 98);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(95, 12);
            this.label50.TabIndex = 31;
            this.label50.Text = "永久层使用次数:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Location = new System.Drawing.Point(22, 46);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 12);
            this.label51.TabIndex = 30;
            this.label51.Text = "工作层编号:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Location = new System.Drawing.Point(58, 124);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(35, 12);
            this.label52.TabIndex = 29;
            this.label52.Text = "项目:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Location = new System.Drawing.Point(58, 20);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(35, 12);
            this.label54.TabIndex = 27;
            this.label54.Text = "包号:";
            // 
            // tabInstall
            // 
            this.tabInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInstall.Controls.Add(this.tabControl2);
            this.tabInstall.Location = new System.Drawing.Point(4, 21);
            this.tabInstall.Name = "tabInstall";
            this.tabInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstall.Size = new System.Drawing.Size(1012, 308);
            this.tabInstall.TabIndex = 5;
            this.tabInstall.Text = "上件";
            this.tabInstall.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabTFFInstall);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1004, 300);
            this.tabControl2.TabIndex = 1;
            // 
            // dsUpGapFac
            // 
            this.dsUpGapFac.AutoLoad = true;
            this.dsUpGapFac.AutoSubscribe = true;
            this.dsUpGapFac.DataSetName = "L3DataSet";
            this.dsUpGapFac.DeleteMethod = "";
            this.dsUpGapFac.InsertMethod = "";
            this.dsUpGapFac.L3DataAdapter = this.Adapter;
            this.dsUpGapFac.LoadEvent = "";
            this.dsUpGapFac.LoadTrigger = null;
            this.dsUpGapFac.RefreshValve = 1000;
            this.dsUpGapFac.SourceCommand = null;
            this.dsUpGapFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'上水口\'";
            this.dsUpGapFac.SourceMethod = "";
            this.dsUpGapFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUpGapFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsUpGapFac.SubscribeTarget = null;
            this.dsUpGapFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUpGapFac});
            this.dsUpGapFac.UpdateEvent = "";
            this.dsUpGapFac.UpdateMethod = "";
            this.dsUpGapFac.UpdateTrigger = null;
            // 
            // schemadsUpGapFac
            // 
            this.schemadsUpGapFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUpGapFacL3DataTableMatFactory});
            this.schemadsUpGapFac.TableName = "L3DataTable";
            // 
            // coldsUpGapFacL3DataTableMatFactory
            // 
            this.coldsUpGapFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsUpGapFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsUpGapFacL3DataTableMatFactory.Namespace = "";
            // 
            // dsSmoothBlock
            // 
            this.dsSmoothBlock.AutoLoad = true;
            this.dsSmoothBlock.AutoSubscribe = true;
            this.dsSmoothBlock.DataSetName = "L3DataSet";
            this.dsSmoothBlock.DeleteMethod = "";
            this.dsSmoothBlock.InsertMethod = "";
            this.dsSmoothBlock.L3DataAdapter = this.Adapter;
            this.dsSmoothBlock.LoadEvent = "";
            this.dsSmoothBlock.LoadTrigger = null;
            this.dsSmoothBlock.RefreshValve = 1000;
            this.dsSmoothBlock.SourceCommand = null;
            this.dsSmoothBlock.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'滑块\'";
            this.dsSmoothBlock.SourceMethod = "";
            this.dsSmoothBlock.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSmoothBlock.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsSmoothBlock.SubscribeTarget = null;
            this.dsSmoothBlock.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSmoothBlock});
            this.dsSmoothBlock.UpdateEvent = "";
            this.dsSmoothBlock.UpdateMethod = "";
            this.dsSmoothBlock.UpdateTrigger = null;
            // 
            // schemadsSmoothBlock
            // 
            this.schemadsSmoothBlock.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSmoothBlockL3DataTableMatFactory});
            this.schemadsSmoothBlock.TableName = "L3DataTable";
            // 
            // coldsSmoothBlockL3DataTableMatFactory
            // 
            this.coldsSmoothBlockL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsSmoothBlockL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsSmoothBlockL3DataTableMatFactory.Namespace = "";
            // 
            // tabTFFInstall
            // 
            this.tabTFFInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTFFInstall.Controls.Add(this.label104);
            this.tabTFFInstall.Controls.Add(this.pxTextBox12);
            this.tabTFFInstall.Controls.Add(this.label103);
            this.tabTFFInstall.Controls.Add(this.pxTextBox11);
            this.tabTFFInstall.Controls.Add(this.label101);
            this.tabTFFInstall.Controls.Add(this.pxTextBox10);
            this.tabTFFInstall.Controls.Add(this.label94);
            this.tabTFFInstall.Controls.Add(this.label93);
            this.tabTFFInstall.Controls.Add(this.pxTextBox9);
            this.tabTFFInstall.Controls.Add(this.label53);
            this.tabTFFInstall.Controls.Add(this.pxTextBox8);
            this.tabTFFInstall.Controls.Add(this.pxTextBox7);
            this.tabTFFInstall.Controls.Add(this.richTextBox8);
            this.tabTFFInstall.Controls.Add(this.label155);
            this.tabTFFInstall.Controls.Add(this.dateTimePicker20);
            this.tabTFFInstall.Controls.Add(this.label156);
            this.tabTFFInstall.Controls.Add(this.pxComboBox32);
            this.tabTFFInstall.Controls.Add(this.label157);
            this.tabTFFInstall.Controls.Add(this.label158);
            this.tabTFFInstall.Controls.Add(this.label159);
            this.tabTFFInstall.Controls.Add(this.label160);
            this.tabTFFInstall.Controls.Add(this.label161);
            this.tabTFFInstall.Controls.Add(this.dateTimePicker21);
            this.tabTFFInstall.Controls.Add(this.label162);
            this.tabTFFInstall.Controls.Add(this.pxComboBox41);
            this.tabTFFInstall.Controls.Add(this.label163);
            this.tabTFFInstall.Controls.Add(this.label164);
            this.tabTFFInstall.Controls.Add(this.label165);
            this.tabTFFInstall.Controls.Add(this.label166);
            this.tabTFFInstall.Controls.Add(this.label167);
            this.tabTFFInstall.Controls.Add(this.pxTextBox44);
            this.tabTFFInstall.Controls.Add(this.pxTextBox40);
            this.tabTFFInstall.Controls.Add(this.pxTextBox43);
            this.tabTFFInstall.Controls.Add(this.pxTextBox39);
            this.tabTFFInstall.Controls.Add(this.pxTextBox42);
            this.tabTFFInstall.Controls.Add(this.pxTextBox38);
            this.tabTFFInstall.Controls.Add(this.pxTextBox41);
            this.tabTFFInstall.Controls.Add(this.pxTextBox37);
            this.tabTFFInstall.Controls.Add(this.pxTextBox35);
            this.tabTFFInstall.Controls.Add(this.pxTextBox36);
            this.tabTFFInstall.Controls.Add(this.label169);
            this.tabTFFInstall.Controls.Add(this.label172);
            this.tabTFFInstall.Controls.Add(this.dateTimePicker23);
            this.tabTFFInstall.Controls.Add(this.label174);
            this.tabTFFInstall.Controls.Add(this.textBox3);
            this.tabTFFInstall.Controls.Add(this.textBox18);
            this.tabTFFInstall.Controls.Add(this.textBox12);
            this.tabTFFInstall.Controls.Add(this.label176);
            this.tabTFFInstall.Controls.Add(this.label99);
            this.tabTFFInstall.Controls.Add(this.label179);
            this.tabTFFInstall.Location = new System.Drawing.Point(4, 21);
            this.tabTFFInstall.Name = "tabTFFInstall";
            this.tabTFFInstall.Size = new System.Drawing.Size(996, 275);
            this.tabTFFInstall.TabIndex = 1;
            this.tabTFFInstall.Text = "上3/4/5/7#铸机";
            this.tabTFFInstall.UseVisualStyleBackColor = true;
            this.tabTFFInstall.Click += new System.EventHandler(this.tabTFFInstall_Click);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.BackColor = System.Drawing.Color.Transparent;
            this.label104.Location = new System.Drawing.Point(502, 182);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(71, 12);
            this.label104.TabIndex = 146;
            this.label104.Text = "铁芯安装人:";
            // 
            // pxTextBox12
            // 
            this.pxTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Core_Install_Per", true));
            this.pxTextBox12.EnableNull = true;
            this.pxTextBox12.ErropPr = null;
            this.pxTextBox12.Length = 0;
            this.pxTextBox12.Location = new System.Drawing.Point(579, 175);
            this.pxTextBox12.Max = 0;
            this.pxTextBox12.MaxStrLength = 0;
            this.pxTextBox12.Min = 0;
            this.pxTextBox12.MinStrLength = 0;
            this.pxTextBox12.Name = "pxTextBox12";
            this.pxTextBox12.Precision = 0;
            this.pxTextBox12.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox12.TabIndex = 145;
            this.pxTextBox12.ToolTipValid = null;
            this.pxTextBox12.ValidEable = true;
            this.pxTextBox12.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.Color.Transparent;
            this.label103.Location = new System.Drawing.Point(751, 156);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(71, 12);
            this.label103.TabIndex = 144;
            this.label103.Text = "下铁芯编号:";
            // 
            // pxTextBox11
            // 
            this.pxTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Lower_Core", true));
            this.pxTextBox11.EnableNull = true;
            this.pxTextBox11.ErropPr = null;
            this.pxTextBox11.Length = 0;
            this.pxTextBox11.Location = new System.Drawing.Point(828, 150);
            this.pxTextBox11.Max = 0;
            this.pxTextBox11.MaxStrLength = 0;
            this.pxTextBox11.Min = 0;
            this.pxTextBox11.MinStrLength = 0;
            this.pxTextBox11.Name = "pxTextBox11";
            this.pxTextBox11.Precision = 0;
            this.pxTextBox11.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox11.TabIndex = 143;
            this.pxTextBox11.ToolTipValid = null;
            this.pxTextBox11.ValidEable = true;
            this.pxTextBox11.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.Location = new System.Drawing.Point(502, 156);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(71, 12);
            this.label101.TabIndex = 142;
            this.label101.Text = "上铁芯编号:";
            // 
            // pxTextBox10
            // 
            this.pxTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Upper_Core", true));
            this.pxTextBox10.EnableNull = true;
            this.pxTextBox10.ErropPr = null;
            this.pxTextBox10.Length = 0;
            this.pxTextBox10.Location = new System.Drawing.Point(579, 150);
            this.pxTextBox10.Max = 0;
            this.pxTextBox10.MaxStrLength = 0;
            this.pxTextBox10.Min = 0;
            this.pxTextBox10.MinStrLength = 0;
            this.pxTextBox10.Name = "pxTextBox10";
            this.pxTextBox10.Precision = 0;
            this.pxTextBox10.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox10.TabIndex = 141;
            this.pxTextBox10.ToolTipValid = null;
            this.pxTextBox10.ValidEable = true;
            this.pxTextBox10.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.Color.Transparent;
            this.label94.Location = new System.Drawing.Point(257, 133);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(71, 12);
            this.label94.TabIndex = 140;
            this.label94.Text = "绝缘检测人:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Transparent;
            this.label93.Location = new System.Drawing.Point(10, 163);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(83, 12);
            this.label93.TabIndex = 139;
            this.label93.Text = "包壁绝缘情况:";
            // 
            // pxTextBox9
            // 
            this.pxTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Tundish_Wall_Insulation", true));
            this.pxTextBox9.EnableNull = true;
            this.pxTextBox9.ErropPr = null;
            this.pxTextBox9.Length = 0;
            this.pxTextBox9.Location = new System.Drawing.Point(99, 159);
            this.pxTextBox9.Max = 0;
            this.pxTextBox9.MaxStrLength = 0;
            this.pxTextBox9.Min = 0;
            this.pxTextBox9.MinStrLength = 0;
            this.pxTextBox9.Name = "pxTextBox9";
            this.pxTextBox9.Precision = 0;
            this.pxTextBox9.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox9.TabIndex = 138;
            this.pxTextBox9.ToolTipValid = null;
            this.pxTextBox9.ValidEable = true;
            this.pxTextBox9.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Location = new System.Drawing.Point(10, 133);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(83, 12);
            this.label53.TabIndex = 137;
            this.label53.Text = "包底绝缘情况:";
            // 
            // pxTextBox8
            // 
            this.pxTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Tundish_Bottom_Insulation", true));
            this.pxTextBox8.EnableNull = true;
            this.pxTextBox8.ErropPr = null;
            this.pxTextBox8.Length = 0;
            this.pxTextBox8.Location = new System.Drawing.Point(99, 129);
            this.pxTextBox8.Max = 0;
            this.pxTextBox8.MaxStrLength = 0;
            this.pxTextBox8.Min = 0;
            this.pxTextBox8.MinStrLength = 0;
            this.pxTextBox8.Name = "pxTextBox8";
            this.pxTextBox8.Precision = 0;
            this.pxTextBox8.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox8.TabIndex = 136;
            this.pxTextBox8.ToolTipValid = null;
            this.pxTextBox8.ValidEable = true;
            this.pxTextBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox7
            // 
            this.pxTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Checker", true));
            this.pxTextBox7.EnableNull = true;
            this.pxTextBox7.ErropPr = null;
            this.pxTextBox7.Length = 0;
            this.pxTextBox7.Location = new System.Drawing.Point(334, 126);
            this.pxTextBox7.Max = 0;
            this.pxTextBox7.MaxStrLength = 0;
            this.pxTextBox7.Min = 0;
            this.pxTextBox7.MinStrLength = 0;
            this.pxTextBox7.Name = "pxTextBox7";
            this.pxTextBox7.Precision = 0;
            this.pxTextBox7.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox7.TabIndex = 135;
            this.pxTextBox7.ToolTipValid = null;
            this.pxTextBox7.ValidEable = true;
            this.pxTextBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // richTextBox8
            // 
            this.richTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Note", true));
            this.richTextBox8.EnableNull = true;
            this.richTextBox8.ErropPr = this.errorProvider1;
            this.richTextBox8.Location = new System.Drawing.Point(94, 202);
            this.richTextBox8.MaxStrLength = 125;
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(875, 68);
            this.richTextBox8.TabIndex = 24;
            this.richTextBox8.Text = "";
            this.richTextBox8.ToolTipValid = this.toolTip1;
            this.richTextBox8.ValidEable = true;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.BackColor = System.Drawing.Color.Transparent;
            this.label155.Location = new System.Drawing.Point(53, 192);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(35, 12);
            this.label155.TabIndex = 134;
            this.label155.Text = "备注:";
            // 
            // dateTimePicker20
            // 
            this.dateTimePicker20.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Stu_Sti_Pro_Date", true));
            this.dateTimePicker20.Enabled = false;
            this.dateTimePicker20.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker20.Location = new System.Drawing.Point(579, 28);
            this.dateTimePicker20.Name = "dateTimePicker20";
            this.dateTimePicker20.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker20.TabIndex = 19;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.BackColor = System.Drawing.Color.Transparent;
            this.label156.Location = new System.Drawing.Point(490, 33);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(83, 12);
            this.label156.TabIndex = 132;
            this.label156.Text = "塞棒生产日期:";
            // 
            // pxComboBox32
            // 
            this.pxComboBox32.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox32.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Stu_Sti_Fac", true));
            this.pxComboBox32.DataSource = this.dsStuStiFac;
            this.pxComboBox32.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox32.EnableNull = true;
            this.pxComboBox32.ErropPr = null;
            this.pxComboBox32.FormattingEnabled = true;
            this.pxComboBox32.Location = new System.Drawing.Point(579, 5);
            this.pxComboBox32.Name = "pxComboBox32";
            this.pxComboBox32.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox32.TabIndex = 18;
            this.pxComboBox32.ToolTipValid = null;
            this.pxComboBox32.ValidEable = true;
            this.pxComboBox32.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsStuStiFac
            // 
            this.dsStuStiFac.AutoLoad = true;
            this.dsStuStiFac.AutoSubscribe = true;
            this.dsStuStiFac.DataSetName = "L3DataSet";
            this.dsStuStiFac.DeleteMethod = null;
            this.dsStuStiFac.InsertMethod = null;
            this.dsStuStiFac.L3DataAdapter = this.Adapter;
            this.dsStuStiFac.LoadEvent = "Click";
            this.dsStuStiFac.LoadTrigger = null;
            this.dsStuStiFac.RefreshValve = 1000;
            this.dsStuStiFac.SourceCommand = null;
            this.dsStuStiFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'塞棒\'";
            this.dsStuStiFac.SourceMethod = "";
            this.dsStuStiFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStuStiFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsStuStiFac.SubscribeTarget = null;
            this.dsStuStiFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStuStiFac});
            this.dsStuStiFac.UpdateEvent = "Click";
            this.dsStuStiFac.UpdateMethod = null;
            this.dsStuStiFac.UpdateTrigger = null;
            // 
            // schemadsStuStiFac
            // 
            this.schemadsStuStiFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStuStiFacL3DataTableMatFactory});
            this.schemadsStuStiFac.TableName = "L3DataTable";
            // 
            // coldsStuStiFacL3DataTableMatFactory
            // 
            this.coldsStuStiFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsStuStiFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsStuStiFacL3DataTableMatFactory.Namespace = "";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.BackColor = System.Drawing.Color.Transparent;
            this.label157.Location = new System.Drawing.Point(514, 9);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(59, 12);
            this.label157.TabIndex = 123;
            this.label157.Text = "塞棒厂家:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BackColor = System.Drawing.Color.Transparent;
            this.label158.Location = new System.Drawing.Point(496, 129);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(77, 12);
            this.label158.TabIndex = 122;
            this.label158.Text = "4流塞棒编号:";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.BackColor = System.Drawing.Color.Transparent;
            this.label159.Location = new System.Drawing.Point(496, 105);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(77, 12);
            this.label159.TabIndex = 124;
            this.label159.Text = "3流塞棒编号:";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.BackColor = System.Drawing.Color.Transparent;
            this.label160.Location = new System.Drawing.Point(496, 81);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(77, 12);
            this.label160.TabIndex = 126;
            this.label160.Text = "2流塞棒编号:";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.BackColor = System.Drawing.Color.Transparent;
            this.label161.Location = new System.Drawing.Point(496, 57);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(77, 12);
            this.label161.TabIndex = 125;
            this.label161.Text = "1流塞棒编号:";
            // 
            // dateTimePicker21
            // 
            this.dateTimePicker21.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Gap_Pro_Date", true));
            this.dateTimePicker21.Enabled = false;
            this.dateTimePicker21.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker21.Location = new System.Drawing.Point(828, 28);
            this.dateTimePicker21.Name = "dateTimePicker21";
            this.dateTimePicker21.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker21.TabIndex = 13;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.BackColor = System.Drawing.Color.Transparent;
            this.label162.Location = new System.Drawing.Point(739, 32);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(83, 12);
            this.label162.TabIndex = 120;
            this.label162.Text = "水口生产日期:";
            // 
            // pxComboBox41
            // 
            this.pxComboBox41.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox41.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Gap_Fac", true));
            this.pxComboBox41.DataSource = this.dsGapFac;
            this.pxComboBox41.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox41.EnableNull = true;
            this.pxComboBox41.ErropPr = null;
            this.pxComboBox41.FormattingEnabled = true;
            this.pxComboBox41.Location = new System.Drawing.Point(828, 5);
            this.pxComboBox41.Name = "pxComboBox41";
            this.pxComboBox41.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox41.TabIndex = 12;
            this.pxComboBox41.ToolTipValid = null;
            this.pxComboBox41.ValidEable = true;
            this.pxComboBox41.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsGapFac
            // 
            this.dsGapFac.AutoLoad = true;
            this.dsGapFac.AutoSubscribe = true;
            this.dsGapFac.DataSetName = "L3DataSet";
            this.dsGapFac.DeleteMethod = "";
            this.dsGapFac.InsertMethod = "";
            this.dsGapFac.L3DataAdapter = this.Adapter;
            this.dsGapFac.LoadEvent = "";
            this.dsGapFac.LoadTrigger = null;
            this.dsGapFac.RefreshValve = 1000;
            this.dsGapFac.SourceCommand = null;
            this.dsGapFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'侵入式水口\'";
            this.dsGapFac.SourceMethod = "";
            this.dsGapFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGapFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsGapFac.SubscribeTarget = null;
            this.dsGapFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGapFac});
            this.dsGapFac.UpdateEvent = "";
            this.dsGapFac.UpdateMethod = "";
            this.dsGapFac.UpdateTrigger = null;
            // 
            // schemadsGapFac
            // 
            this.schemadsGapFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGapFacL3DataTableMatFactory});
            this.schemadsGapFac.TableName = "L3DataTable";
            // 
            // coldsGapFacL3DataTableMatFactory
            // 
            this.coldsGapFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsGapFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsGapFacL3DataTableMatFactory.Namespace = "";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.BackColor = System.Drawing.Color.Transparent;
            this.label163.Location = new System.Drawing.Point(745, 129);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(77, 12);
            this.label163.TabIndex = 111;
            this.label163.Text = "4流水口编号:";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.BackColor = System.Drawing.Color.Transparent;
            this.label164.Location = new System.Drawing.Point(745, 105);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(77, 12);
            this.label164.TabIndex = 110;
            this.label164.Text = "3流水口编号:";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.BackColor = System.Drawing.Color.Transparent;
            this.label165.Location = new System.Drawing.Point(745, 81);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(77, 12);
            this.label165.TabIndex = 112;
            this.label165.Text = "2流水口编号:";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.BackColor = System.Drawing.Color.Transparent;
            this.label166.Location = new System.Drawing.Point(745, 57);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(77, 12);
            this.label166.TabIndex = 114;
            this.label166.Text = "1流水口编号:";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.BackColor = System.Drawing.Color.Transparent;
            this.label167.Location = new System.Drawing.Point(763, 9);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(59, 12);
            this.label167.TabIndex = 113;
            this.label167.Text = "水口厂家:";
            // 
            // pxTextBox44
            // 
            this.pxTextBox44.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Fourth_Stu_Sti_ID", true));
            this.pxTextBox44.EnableNull = true;
            this.pxTextBox44.ErropPr = null;
            this.pxTextBox44.Length = 0;
            this.pxTextBox44.Location = new System.Drawing.Point(828, 124);
            this.pxTextBox44.Max = 0;
            this.pxTextBox44.MaxStrLength = 0;
            this.pxTextBox44.Min = 0;
            this.pxTextBox44.MinStrLength = 0;
            this.pxTextBox44.Name = "pxTextBox44";
            this.pxTextBox44.Precision = 0;
            this.pxTextBox44.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox44.TabIndex = 6;
            this.pxTextBox44.ToolTipValid = null;
            this.pxTextBox44.ValidEable = true;
            this.pxTextBox44.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox40
            // 
            this.pxTextBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Fourth_Stu_Sti_ID", true));
            this.pxTextBox40.EnableNull = true;
            this.pxTextBox40.ErropPr = null;
            this.pxTextBox40.Length = 0;
            this.pxTextBox40.Location = new System.Drawing.Point(579, 124);
            this.pxTextBox40.Max = 0;
            this.pxTextBox40.MaxStrLength = 0;
            this.pxTextBox40.Min = 0;
            this.pxTextBox40.MinStrLength = 0;
            this.pxTextBox40.Name = "pxTextBox40";
            this.pxTextBox40.Precision = 0;
            this.pxTextBox40.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox40.TabIndex = 6;
            this.pxTextBox40.ToolTipValid = null;
            this.pxTextBox40.ValidEable = true;
            this.pxTextBox40.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox43
            // 
            this.pxTextBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Third_Gap_ID", true));
            this.pxTextBox43.EnableNull = true;
            this.pxTextBox43.ErropPr = null;
            this.pxTextBox43.Length = 0;
            this.pxTextBox43.Location = new System.Drawing.Point(828, 100);
            this.pxTextBox43.Max = 0;
            this.pxTextBox43.MaxStrLength = 0;
            this.pxTextBox43.Min = 0;
            this.pxTextBox43.MinStrLength = 0;
            this.pxTextBox43.Name = "pxTextBox43";
            this.pxTextBox43.Precision = 0;
            this.pxTextBox43.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox43.TabIndex = 6;
            this.pxTextBox43.ToolTipValid = null;
            this.pxTextBox43.ValidEable = true;
            this.pxTextBox43.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox39
            // 
            this.pxTextBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Third_Stu_Sti_ID", true));
            this.pxTextBox39.EnableNull = true;
            this.pxTextBox39.ErropPr = null;
            this.pxTextBox39.Length = 0;
            this.pxTextBox39.Location = new System.Drawing.Point(579, 100);
            this.pxTextBox39.Max = 0;
            this.pxTextBox39.MaxStrLength = 0;
            this.pxTextBox39.Min = 0;
            this.pxTextBox39.MinStrLength = 0;
            this.pxTextBox39.Name = "pxTextBox39";
            this.pxTextBox39.Precision = 0;
            this.pxTextBox39.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox39.TabIndex = 6;
            this.pxTextBox39.ToolTipValid = null;
            this.pxTextBox39.ValidEable = true;
            this.pxTextBox39.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox42
            // 
            this.pxTextBox42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Second_Gap_ID", true));
            this.pxTextBox42.EnableNull = true;
            this.pxTextBox42.ErropPr = null;
            this.pxTextBox42.Length = 0;
            this.pxTextBox42.Location = new System.Drawing.Point(828, 76);
            this.pxTextBox42.Max = 0;
            this.pxTextBox42.MaxStrLength = 0;
            this.pxTextBox42.Min = 0;
            this.pxTextBox42.MinStrLength = 0;
            this.pxTextBox42.Name = "pxTextBox42";
            this.pxTextBox42.Precision = 0;
            this.pxTextBox42.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox42.TabIndex = 6;
            this.pxTextBox42.ToolTipValid = null;
            this.pxTextBox42.ValidEable = true;
            this.pxTextBox42.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox38
            // 
            this.pxTextBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Second_Stu_Sti_ID", true));
            this.pxTextBox38.EnableNull = true;
            this.pxTextBox38.ErropPr = null;
            this.pxTextBox38.Length = 0;
            this.pxTextBox38.Location = new System.Drawing.Point(579, 76);
            this.pxTextBox38.Max = 0;
            this.pxTextBox38.MaxStrLength = 0;
            this.pxTextBox38.Min = 0;
            this.pxTextBox38.MinStrLength = 0;
            this.pxTextBox38.Name = "pxTextBox38";
            this.pxTextBox38.Precision = 0;
            this.pxTextBox38.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox38.TabIndex = 6;
            this.pxTextBox38.ToolTipValid = null;
            this.pxTextBox38.ValidEable = true;
            this.pxTextBox38.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox41
            // 
            this.pxTextBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "First_Gap_ID", true));
            this.pxTextBox41.EnableNull = true;
            this.pxTextBox41.ErropPr = null;
            this.pxTextBox41.Length = 0;
            this.pxTextBox41.Location = new System.Drawing.Point(828, 52);
            this.pxTextBox41.Max = 0;
            this.pxTextBox41.MaxStrLength = 0;
            this.pxTextBox41.Min = 0;
            this.pxTextBox41.MinStrLength = 0;
            this.pxTextBox41.Name = "pxTextBox41";
            this.pxTextBox41.Precision = 0;
            this.pxTextBox41.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox41.TabIndex = 6;
            this.pxTextBox41.ToolTipValid = null;
            this.pxTextBox41.ValidEable = true;
            this.pxTextBox41.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox37
            // 
            this.pxTextBox37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "First_Stu_Sti_ID", true));
            this.pxTextBox37.EnableNull = true;
            this.pxTextBox37.ErropPr = null;
            this.pxTextBox37.Length = 0;
            this.pxTextBox37.Location = new System.Drawing.Point(579, 52);
            this.pxTextBox37.Max = 0;
            this.pxTextBox37.MaxStrLength = 0;
            this.pxTextBox37.Min = 0;
            this.pxTextBox37.MinStrLength = 0;
            this.pxTextBox37.Name = "pxTextBox37";
            this.pxTextBox37.Precision = 0;
            this.pxTextBox37.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox37.TabIndex = 6;
            this.pxTextBox37.ToolTipValid = null;
            this.pxTextBox37.ValidEable = true;
            this.pxTextBox37.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox35
            // 
            this.pxTextBox35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Con_Per", true));
            this.pxTextBox35.EnableNull = true;
            this.pxTextBox35.ErropPr = null;
            this.pxTextBox35.Length = 0;
            this.pxTextBox35.Location = new System.Drawing.Point(334, 56);
            this.pxTextBox35.Max = 0;
            this.pxTextBox35.MaxStrLength = 0;
            this.pxTextBox35.Min = 0;
            this.pxTextBox35.MinStrLength = 0;
            this.pxTextBox35.Name = "pxTextBox35";
            this.pxTextBox35.Precision = 0;
            this.pxTextBox35.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox35.TabIndex = 6;
            this.pxTextBox35.ToolTipValid = null;
            this.pxTextBox35.ValidEable = true;
            this.pxTextBox35.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox36
            // 
            this.pxTextBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Install_Per", true));
            this.pxTextBox36.EnableNull = true;
            this.pxTextBox36.ErropPr = null;
            this.pxTextBox36.Length = 0;
            this.pxTextBox36.Location = new System.Drawing.Point(334, 83);
            this.pxTextBox36.Max = 0;
            this.pxTextBox36.MaxStrLength = 0;
            this.pxTextBox36.Min = 0;
            this.pxTextBox36.MinStrLength = 0;
            this.pxTextBox36.Name = "pxTextBox36";
            this.pxTextBox36.Precision = 0;
            this.pxTextBox36.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox36.TabIndex = 8;
            this.pxTextBox36.ToolTipValid = null;
            this.pxTextBox36.ValidEable = true;
            this.pxTextBox36.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.BackColor = System.Drawing.Color.Transparent;
            this.label169.Location = new System.Drawing.Point(281, 60);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(47, 12);
            this.label169.TabIndex = 100;
            this.label169.Text = "确认人:";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.BackColor = System.Drawing.Color.Transparent;
            this.label172.Location = new System.Drawing.Point(281, 87);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(47, 12);
            this.label172.TabIndex = 101;
            this.label172.Text = "安装人:";
            // 
            // dateTimePicker23
            // 
            this.dateTimePicker23.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Install_Time", true));
            this.dateTimePicker23.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker23.Location = new System.Drawing.Point(99, 83);
            this.dateTimePicker23.Name = "dateTimePicker23";
            this.dateTimePicker23.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker23.TabIndex = 1;
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.BackColor = System.Drawing.Color.Transparent;
            this.label174.Location = new System.Drawing.Point(34, 87);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(59, 12);
            this.label174.TabIndex = 36;
            this.label174.Text = "安装日期:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "Fra_Switch_Case", true));
            this.textBox3.EnableNull = true;
            this.textBox3.ErropPr = null;
            this.textBox3.Length = 0;
            this.textBox3.Location = new System.Drawing.Point(334, 27);
            this.textBox3.Max = 0;
            this.textBox3.MaxStrLength = 0;
            this.textBox3.Min = 0;
            this.textBox3.MinStrLength = 0;
            this.textBox3.Name = "textBox3";
            this.textBox3.Precision = 0;
            this.textBox3.Size = new System.Drawing.Size(141, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.ToolTipValid = null;
            this.textBox3.ValidEable = true;
            this.textBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "WorkID", true));
            this.textBox18.EnableNull = true;
            this.textBox18.ErropPr = null;
            this.textBox18.Length = 0;
            this.textBox18.Location = new System.Drawing.Point(99, 56);
            this.textBox18.Max = 0;
            this.textBox18.MaxStrLength = 0;
            this.textBox18.Min = 0;
            this.textBox18.MinStrLength = 0;
            this.textBox18.Name = "textBox18";
            this.textBox18.Precision = 0;
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(141, 21);
            this.textBox18.TabIndex = 4;
            this.textBox18.ToolTipValid = null;
            this.textBox18.ValidEable = true;
            this.textBox18.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFInstall, "TundishID", true));
            this.textBox12.EnableNull = true;
            this.textBox12.ErropPr = null;
            this.textBox12.Length = 0;
            this.textBox12.Location = new System.Drawing.Point(99, 27);
            this.textBox12.Max = 0;
            this.textBox12.MaxStrLength = 0;
            this.textBox12.Min = 0;
            this.textBox12.MinStrLength = 0;
            this.textBox12.Name = "textBox12";
            this.textBox12.Precision = 0;
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(141, 21);
            this.textBox12.TabIndex = 4;
            this.textBox12.ToolTipValid = null;
            this.textBox12.ValidEable = true;
            this.textBox12.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.BackColor = System.Drawing.Color.Transparent;
            this.label176.Location = new System.Drawing.Point(245, 31);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(83, 12);
            this.label176.TabIndex = 29;
            this.label176.Text = "机构闸刀情况:";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Location = new System.Drawing.Point(22, 60);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(71, 12);
            this.label99.TabIndex = 31;
            this.label99.Text = "工作层编号:";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.BackColor = System.Drawing.Color.Transparent;
            this.label179.Location = new System.Drawing.Point(58, 31);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(35, 12);
            this.label179.TabIndex = 31;
            this.label179.Text = "包号:";
            // 
            // tabHotFire
            // 
            this.tabHotFire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHotFire.Controls.Add(this.tabControl1);
            this.tabHotFire.Location = new System.Drawing.Point(4, 21);
            this.tabHotFire.Name = "tabHotFire";
            this.tabHotFire.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotFire.Size = new System.Drawing.Size(1012, 308);
            this.tabHotFire.TabIndex = 4;
            this.tabHotFire.Text = "热备烘烤";
            this.tabHotFire.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTFFFire);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // bsOTHotCraneTeamID
            // 
            this.bsOTHotCraneTeamID.DataMember = "L3DataTable";
            this.bsOTHotCraneTeamID.DataSource = this.dsTeamID;
            // 
            // bsAdjustTeam
            // 
            this.bsAdjustTeam.DataMember = "L3DataTable";
            this.bsAdjustTeam.DataSource = this.dsTeamID;
            // 
            // tabTFFFire
            // 
            this.tabTFFFire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTFFFire.Controls.Add(this.label170);
            this.tabTFFFire.Controls.Add(this.textBox16);
            this.tabTFFFire.Controls.Add(this.textBox15);
            this.tabTFFFire.Controls.Add(this.label49);
            this.tabTFFFire.Controls.Add(this.richTextBox4);
            this.tabTFFFire.Controls.Add(this.label85);
            this.tabTFFFire.Controls.Add(this.pxComboBox11);
            this.tabTFFFire.Controls.Add(this.pxComboBox14);
            this.tabTFFFire.Controls.Add(this.pxComboBox12);
            this.tabTFFFire.Controls.Add(this.pxComboBox19);
            this.tabTFFFire.Controls.Add(this.pxComboBox15);
            this.tabTFFFire.Controls.Add(this.pxTextBox48);
            this.tabTFFFire.Controls.Add(this.pxTextBox47);
            this.tabTFFFire.Controls.Add(this.pxTextBox46);
            this.tabTFFFire.Controls.Add(this.pxTextBox45);
            this.tabTFFFire.Controls.Add(this.pxTextBox4);
            this.tabTFFFire.Controls.Add(this.label86);
            this.tabTFFFire.Controls.Add(this.label87);
            this.tabTFFFire.Controls.Add(this.label88);
            this.tabTFFFire.Controls.Add(this.label211);
            this.tabTFFFire.Controls.Add(this.label89);
            this.tabTFFFire.Controls.Add(this.label90);
            this.tabTFFFire.Controls.Add(this.label91);
            this.tabTFFFire.Controls.Add(this.dateTimePicker4);
            this.tabTFFFire.Controls.Add(this.dateTimePicker8);
            this.tabTFFFire.Controls.Add(this.dateTimePicker9);
            this.tabTFFFire.Controls.Add(this.dateTimePicker10);
            this.tabTFFFire.Controls.Add(this.label92);
            this.tabTFFFire.Controls.Add(this.label95);
            this.tabTFFFire.Controls.Add(this.label96);
            this.tabTFFFire.Controls.Add(this.label97);
            this.tabTFFFire.Controls.Add(this.pxTextBox5);
            this.tabTFFFire.Controls.Add(this.pxTextBox6);
            this.tabTFFFire.Controls.Add(this.label100);
            this.tabTFFFire.Controls.Add(this.label102);
            this.tabTFFFire.Controls.Add(this.label112);
            this.tabTFFFire.Controls.Add(this.label113);
            this.tabTFFFire.Controls.Add(this.label114);
            this.tabTFFFire.Location = new System.Drawing.Point(4, 21);
            this.tabTFFFire.Name = "tabTFFFire";
            this.tabTFFFire.Padding = new System.Windows.Forms.Padding(3);
            this.tabTFFFire.Size = new System.Drawing.Size(996, 275);
            this.tabTFFFire.TabIndex = 1;
            this.tabTFFFire.Text = "上3/4/5/7#铸机";
            this.tabTFFFire.UseVisualStyleBackColor = true;
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.BackColor = System.Drawing.Color.Transparent;
            this.label170.Location = new System.Drawing.Point(50, 116);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(35, 12);
            this.label170.TabIndex = 178;
            this.label170.Text = "车号:";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "TundishID", true));
            this.textBox16.EnableNull = true;
            this.textBox16.ErropPr = null;
            this.textBox16.Length = 0;
            this.textBox16.Location = new System.Drawing.Point(91, 8);
            this.textBox16.Max = 0;
            this.textBox16.MaxStrLength = 0;
            this.textBox16.Min = 0;
            this.textBox16.MinStrLength = 0;
            this.textBox16.Name = "textBox16";
            this.textBox16.Precision = 0;
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(141, 21);
            this.textBox16.TabIndex = 0;
            this.textBox16.ToolTipValid = null;
            this.textBox16.ValidEable = true;
            this.textBox16.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "WorkID", true));
            this.textBox15.EnableNull = true;
            this.textBox15.ErropPr = null;
            this.textBox15.Length = 0;
            this.textBox15.Location = new System.Drawing.Point(91, 35);
            this.textBox15.Max = 0;
            this.textBox15.MaxStrLength = 0;
            this.textBox15.Min = 0;
            this.textBox15.MinStrLength = 0;
            this.textBox15.Name = "textBox15";
            this.textBox15.Precision = 0;
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(141, 21);
            this.textBox15.TabIndex = 1;
            this.textBox15.ToolTipValid = null;
            this.textBox15.ValidEable = true;
            this.textBox15.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Location = new System.Drawing.Point(14, 38);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(71, 12);
            this.label49.TabIndex = 176;
            this.label49.Text = "工作层编号:";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Note", true));
            this.richTextBox4.EnableNull = true;
            this.richTextBox4.ErropPr = this.errorProvider1;
            this.richTextBox4.Location = new System.Drawing.Point(91, 167);
            this.richTextBox4.MaxStrLength = 125;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(665, 53);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            this.richTextBox4.ToolTipValid = this.toolTip1;
            this.richTextBox4.ValidEable = true;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Transparent;
            this.label85.Location = new System.Drawing.Point(50, 170);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(35, 12);
            this.label85.TabIndex = 174;
            this.label85.Text = "备注:";
            // 
            // pxComboBox11
            // 
            this.pxComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox11.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTFFFireInfo, "ShiftID", true));
            this.pxComboBox11.DataSource = this.bsTFFHotShiftID;
            this.pxComboBox11.DisplayMember = "Code_Des";
            this.pxComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox11.EnableNull = true;
            this.pxComboBox11.ErropPr = null;
            this.pxComboBox11.FormattingEnabled = true;
            this.pxComboBox11.Location = new System.Drawing.Point(337, 137);
            this.pxComboBox11.Name = "pxComboBox11";
            this.pxComboBox11.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox11.TabIndex = 11;
            this.pxComboBox11.ToolTipValid = null;
            this.pxComboBox11.ValidEable = true;
            this.pxComboBox11.ValueMember = "Code";
            // 
            // pxComboBox14
            // 
            this.pxComboBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Cast_ID", true));
            this.pxComboBox14.EnableNull = true;
            this.pxComboBox14.ErropPr = null;
            this.pxComboBox14.FormattingEnabled = true;
            this.pxComboBox14.Items.AddRange(new object[] {
            "",
            "S63",
            "S64",
            "S65"});
            this.pxComboBox14.Location = new System.Drawing.Point(91, 62);
            this.pxComboBox14.Name = "pxComboBox14";
            this.pxComboBox14.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox14.TabIndex = 2;
            this.pxComboBox14.ToolTipValid = null;
            this.pxComboBox14.ValidEable = true;
            // 
            // pxComboBox12
            // 
            this.pxComboBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "VehicleID", true));
            this.pxComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.pxComboBox12.EnableNull = true;
            this.pxComboBox12.ErropPr = null;
            this.pxComboBox12.FormattingEnabled = true;
            this.pxComboBox12.Location = new System.Drawing.Point(91, 114);
            this.pxComboBox12.Name = "pxComboBox12";
            this.pxComboBox12.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox12.TabIndex = 4;
            this.pxComboBox12.ToolTipValid = null;
            this.pxComboBox12.ValidEable = true;
            // 
            // pxComboBox19
            // 
            this.pxComboBox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox19.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTFFFireInfo, "Crane_TeamID", true));
            this.pxComboBox19.DataSource = this.bsTTFHotCraneTeamID;
            this.pxComboBox19.DisplayMember = "Code_des";
            this.pxComboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox19.EnableNull = true;
            this.pxComboBox19.ErropPr = null;
            this.pxComboBox19.FormattingEnabled = true;
            this.pxComboBox19.Location = new System.Drawing.Point(91, 88);
            this.pxComboBox19.Name = "pxComboBox19";
            this.pxComboBox19.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox19.TabIndex = 3;
            this.pxComboBox19.ToolTipValid = null;
            this.pxComboBox19.ValidEable = true;
            this.pxComboBox19.ValueMember = "Code";
            // 
            // bsTTFHotCraneTeamID
            // 
            this.bsTTFHotCraneTeamID.DataMember = "L3DataTable";
            this.bsTTFHotCraneTeamID.DataSource = this.dsTeamID;
            // 
            // pxComboBox15
            // 
            this.pxComboBox15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox15.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTFFFireInfo, "TeamID", true));
            this.pxComboBox15.DataSource = this.bsTFFHotTeamID;
            this.pxComboBox15.DisplayMember = "Code_des";
            this.pxComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox15.EnableNull = true;
            this.pxComboBox15.ErropPr = null;
            this.pxComboBox15.FormattingEnabled = true;
            this.pxComboBox15.Location = new System.Drawing.Point(337, 112);
            this.pxComboBox15.Name = "pxComboBox15";
            this.pxComboBox15.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox15.TabIndex = 10;
            this.pxComboBox15.ToolTipValid = null;
            this.pxComboBox15.ValidEable = true;
            this.pxComboBox15.ValueMember = "Code";
            // 
            // pxTextBox48
            // 
            this.pxTextBox48.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fourth_Fra_ID", true));
            this.pxTextBox48.EnableNull = true;
            this.pxTextBox48.ErropPr = null;
            this.pxTextBox48.Length = 0;
            this.pxTextBox48.Location = new System.Drawing.Point(615, 86);
            this.pxTextBox48.Max = 0;
            this.pxTextBox48.MaxStrLength = 0;
            this.pxTextBox48.Min = 0;
            this.pxTextBox48.MinStrLength = 0;
            this.pxTextBox48.Name = "pxTextBox48";
            this.pxTextBox48.Precision = 0;
            this.pxTextBox48.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox48.TabIndex = 15;
            this.pxTextBox48.ToolTipValid = null;
            this.pxTextBox48.ValidEable = true;
            this.pxTextBox48.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox47
            // 
            this.pxTextBox47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Third_Fra_ID", true));
            this.pxTextBox47.EnableNull = true;
            this.pxTextBox47.ErropPr = null;
            this.pxTextBox47.Length = 0;
            this.pxTextBox47.Location = new System.Drawing.Point(615, 60);
            this.pxTextBox47.Max = 0;
            this.pxTextBox47.MaxStrLength = 0;
            this.pxTextBox47.Min = 0;
            this.pxTextBox47.MinStrLength = 0;
            this.pxTextBox47.Name = "pxTextBox47";
            this.pxTextBox47.Precision = 0;
            this.pxTextBox47.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox47.TabIndex = 14;
            this.pxTextBox47.ToolTipValid = null;
            this.pxTextBox47.ValidEable = true;
            this.pxTextBox47.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox46
            // 
            this.pxTextBox46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Second_Fra_ID", true));
            this.pxTextBox46.EnableNull = true;
            this.pxTextBox46.ErropPr = null;
            this.pxTextBox46.Length = 0;
            this.pxTextBox46.Location = new System.Drawing.Point(615, 34);
            this.pxTextBox46.Max = 0;
            this.pxTextBox46.MaxStrLength = 0;
            this.pxTextBox46.Min = 0;
            this.pxTextBox46.MinStrLength = 0;
            this.pxTextBox46.Name = "pxTextBox46";
            this.pxTextBox46.Precision = 0;
            this.pxTextBox46.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox46.TabIndex = 13;
            this.pxTextBox46.ToolTipValid = null;
            this.pxTextBox46.ValidEable = true;
            this.pxTextBox46.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox45
            // 
            this.pxTextBox45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "First_Fra_ID", true));
            this.pxTextBox45.EnableNull = true;
            this.pxTextBox45.ErropPr = null;
            this.pxTextBox45.Length = 0;
            this.pxTextBox45.Location = new System.Drawing.Point(615, 8);
            this.pxTextBox45.Max = 0;
            this.pxTextBox45.MaxStrLength = 0;
            this.pxTextBox45.Min = 0;
            this.pxTextBox45.MinStrLength = 0;
            this.pxTextBox45.Name = "pxTextBox45";
            this.pxTextBox45.Precision = 0;
            this.pxTextBox45.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox45.TabIndex = 12;
            this.pxTextBox45.ToolTipValid = null;
            this.pxTextBox45.ValidEable = true;
            this.pxTextBox45.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Operator", true));
            this.pxTextBox4.EnableNull = true;
            this.pxTextBox4.ErropPr = null;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(91, 140);
            this.pxTextBox4.Max = 0;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox4.TabIndex = 5;
            this.pxTextBox4.ToolTipValid = null;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Transparent;
            this.label86.Location = new System.Drawing.Point(296, 142);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(35, 12);
            this.label86.TabIndex = 163;
            this.label86.Text = "班次:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Transparent;
            this.label87.Location = new System.Drawing.Point(532, 90);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(77, 12);
            this.label87.TabIndex = 164;
            this.label87.Text = "4流机构编号:";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Location = new System.Drawing.Point(532, 38);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(77, 12);
            this.label88.TabIndex = 167;
            this.label88.Text = "2流机构编号:";
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.BackColor = System.Drawing.Color.Transparent;
            this.label211.Location = new System.Drawing.Point(26, 90);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(59, 12);
            this.label211.TabIndex = 165;
            this.label211.Text = "吊包班组:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.Transparent;
            this.label89.Location = new System.Drawing.Point(50, 64);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(35, 12);
            this.label89.TabIndex = 166;
            this.label89.Text = "去向:";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.Location = new System.Drawing.Point(272, 116);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(59, 12);
            this.label90.TabIndex = 165;
            this.label90.Text = "烤包班组:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.Transparent;
            this.label91.Location = new System.Drawing.Point(38, 142);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(47, 12);
            this.label91.TabIndex = 162;
            this.label91.Text = "责任人:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Big_End_Time", true));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(337, 86);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Big_Start_Time", true));
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(337, 60);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker8.TabIndex = 8;
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Mid_Start_Time", true));
            this.dateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker9.Location = new System.Drawing.Point(337, 34);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker9.TabIndex = 7;
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker10.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Small_Start_Time", true));
            this.dateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker10.Location = new System.Drawing.Point(337, 8);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker10.TabIndex = 6;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.Location = new System.Drawing.Point(248, 90);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(83, 12);
            this.label92.TabIndex = 150;
            this.label92.Text = "大火结束时间:";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.Color.Transparent;
            this.label95.Location = new System.Drawing.Point(248, 64);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(83, 12);
            this.label95.TabIndex = 153;
            this.label95.Text = "大火开始时间:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.BackColor = System.Drawing.Color.Transparent;
            this.label96.Location = new System.Drawing.Point(248, 38);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(83, 12);
            this.label96.TabIndex = 152;
            this.label96.Text = "中火开始时间:";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.BackColor = System.Drawing.Color.Transparent;
            this.label97.Location = new System.Drawing.Point(248, 12);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(83, 12);
            this.label97.TabIndex = 151;
            this.label97.Text = "小火开始时间:";
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Gap_Temp", true));
            this.pxTextBox5.EnableNull = true;
            this.pxTextBox5.ErropPr = null;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(615, 138);
            this.pxTextBox5.Max = 0;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox5.TabIndex = 17;
            this.pxTextBox5.ToolTipValid = null;
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Wall_Temp", true));
            this.pxTextBox6.EnableNull = true;
            this.pxTextBox6.ErropPr = null;
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(615, 112);
            this.pxTextBox6.Max = 0;
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0;
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            this.pxTextBox6.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox6.TabIndex = 16;
            this.pxTextBox6.ToolTipValid = null;
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.BackColor = System.Drawing.Color.Transparent;
            this.label100.Location = new System.Drawing.Point(526, 142);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(83, 12);
            this.label100.TabIndex = 106;
            this.label100.Text = "水口温度[℃]:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.Location = new System.Drawing.Point(502, 116);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(107, 12);
            this.label102.TabIndex = 108;
            this.label102.Text = "中间包壁温度[℃]:";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.Color.Transparent;
            this.label112.Location = new System.Drawing.Point(532, 64);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(77, 12);
            this.label112.TabIndex = 109;
            this.label112.Text = "3流机构编号:";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.BackColor = System.Drawing.Color.Transparent;
            this.label113.Location = new System.Drawing.Point(532, 12);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(77, 12);
            this.label113.TabIndex = 12;
            this.label113.Text = "1流机构编号:";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.Color.Transparent;
            this.label114.Location = new System.Drawing.Point(50, 12);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(35, 12);
            this.label114.TabIndex = 111;
            this.label114.Text = "包号:";
            // 
            // tabRefra
            // 
            this.tabRefra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRefra.Controls.Add(this.tabControl4);
            this.tabRefra.Location = new System.Drawing.Point(4, 21);
            this.tabRefra.Name = "tabRefra";
            this.tabRefra.Size = new System.Drawing.Size(1012, 308);
            this.tabRefra.TabIndex = 7;
            this.tabRefra.Text = "耐材";
            this.tabRefra.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabRefraTFF);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1010, 306);
            this.tabControl4.TabIndex = 0;
            // 
            // bsStopCastingReason1
            // 
            this.bsStopCastingReason1.DataMember = "L3DataTable";
            this.bsStopCastingReason1.DataSource = this.dsStopCastingReason;
            // 
            // dsStopCastingReason
            // 
            this.dsStopCastingReason.AutoLoad = true;
            this.dsStopCastingReason.AutoSubscribe = true;
            this.dsStopCastingReason.DataSetName = "L3DataSet";
            this.dsStopCastingReason.DeleteMethod = "";
            this.dsStopCastingReason.InsertMethod = "";
            this.dsStopCastingReason.L3DataAdapter = this.Adapter;
            this.dsStopCastingReason.LoadEvent = "";
            this.dsStopCastingReason.LoadTrigger = null;
            this.dsStopCastingReason.RefreshValve = 1000;
            this.dsStopCastingReason.SourceCommand = null;
            this.dsStopCastingReason.SourceCondition = "Code_Group = \'TundishNO_Stop_Reason\' order by Code";
            this.dsStopCastingReason.SourceMethod = "";
            this.dsStopCastingReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStopCastingReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStopCastingReason.SubscribeTarget = null;
            this.dsStopCastingReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStopCastingReason});
            this.dsStopCastingReason.UpdateEvent = "";
            this.dsStopCastingReason.UpdateMethod = "";
            this.dsStopCastingReason.UpdateTrigger = null;
            // 
            // schemadsStopCastingReason
            // 
            this.schemadsStopCastingReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStopCastingReasonL3DataTableCode,
            this.coldsStopCastingReasonL3DataTableCode_Des});
            this.schemadsStopCastingReason.TableName = "L3DataTable";
            // 
            // coldsStopCastingReasonL3DataTableCode
            // 
            this.coldsStopCastingReasonL3DataTableCode.Caption = "Code";
            this.coldsStopCastingReasonL3DataTableCode.ColumnName = "Code";
            this.coldsStopCastingReasonL3DataTableCode.Namespace = "";
            // 
            // coldsStopCastingReasonL3DataTableCode_Des
            // 
            this.coldsStopCastingReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStopCastingReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStopCastingReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsCoverCaseOT
            // 
            this.bsCoverCaseOT.DataMember = "L3DataTable";
            this.bsCoverCaseOT.DataSource = this.dsCoverCase;
            // 
            // dsCoverCase
            // 
            this.dsCoverCase.AutoLoad = true;
            this.dsCoverCase.AutoSubscribe = true;
            this.dsCoverCase.DataSetName = "L3DataSet";
            this.dsCoverCase.DeleteMethod = null;
            this.dsCoverCase.InsertMethod = null;
            this.dsCoverCase.L3DataAdapter = this.Adapter;
            this.dsCoverCase.LoadEvent = "Click";
            this.dsCoverCase.LoadTrigger = null;
            this.dsCoverCase.RefreshValve = 1000;
            this.dsCoverCase.SourceCommand = null;
            this.dsCoverCase.SourceCondition = "Code_Group = \'Cover_Use_Case\'";
            this.dsCoverCase.SourceMethod = "";
            this.dsCoverCase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCoverCase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCoverCase.SubscribeTarget = null;
            this.dsCoverCase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCoverCaseOT});
            this.dsCoverCase.UpdateEvent = "Click";
            this.dsCoverCase.UpdateMethod = null;
            this.dsCoverCase.UpdateTrigger = null;
            // 
            // schemadsCoverCaseOT
            // 
            this.schemadsCoverCaseOT.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCoverCaseOTL3DataTableCode,
            this.coldsCoverCaseOTL3DataTableCode_Des,
            this.coldsCoverCaseOTL3DataTableCode_Val_Long});
            this.schemadsCoverCaseOT.TableName = "L3DataTable";
            // 
            // coldsCoverCaseOTL3DataTableCode
            // 
            this.coldsCoverCaseOTL3DataTableCode.Caption = "Code";
            this.coldsCoverCaseOTL3DataTableCode.ColumnName = "Code";
            this.coldsCoverCaseOTL3DataTableCode.Namespace = "";
            // 
            // coldsCoverCaseOTL3DataTableCode_Des
            // 
            this.coldsCoverCaseOTL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCoverCaseOTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCoverCaseOTL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCoverCaseOTL3DataTableCode_Val_Long
            // 
            this.coldsCoverCaseOTL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCoverCaseOTL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCoverCaseOTL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCoverCaseOTL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsProtect_Use_Case1
            // 
            this.bsProtect_Use_Case1.DataMember = "L3DataTable";
            this.bsProtect_Use_Case1.DataSource = this.dsProtect_Use_Case;
            // 
            // dsProtect_Use_Case
            // 
            this.dsProtect_Use_Case.AutoLoad = true;
            this.dsProtect_Use_Case.AutoSubscribe = true;
            this.dsProtect_Use_Case.DataSetName = "L3DataSet";
            this.dsProtect_Use_Case.DeleteMethod = "";
            this.dsProtect_Use_Case.InsertMethod = "";
            this.dsProtect_Use_Case.L3DataAdapter = this.Adapter;
            this.dsProtect_Use_Case.LoadEvent = "";
            this.dsProtect_Use_Case.LoadTrigger = null;
            this.dsProtect_Use_Case.RefreshValve = 1000;
            this.dsProtect_Use_Case.SourceCommand = null;
            this.dsProtect_Use_Case.SourceCondition = "Code_Group = \'Protect_Use_Case\' order by Code\r\n";
            this.dsProtect_Use_Case.SourceMethod = "";
            this.dsProtect_Use_Case.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtect_Use_Case.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProtect_Use_Case.SubscribeTarget = null;
            this.dsProtect_Use_Case.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtect_Use_Case});
            this.dsProtect_Use_Case.UpdateEvent = "";
            this.dsProtect_Use_Case.UpdateMethod = "";
            this.dsProtect_Use_Case.UpdateTrigger = null;
            // 
            // schemadsProtect_Use_Case
            // 
            this.schemadsProtect_Use_Case.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtect_Use_CaseL3DataTableCode,
            this.coldsProtect_Use_CaseL3DataTableCode_Des,
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long});
            this.schemadsProtect_Use_Case.TableName = "L3DataTable";
            // 
            // coldsProtect_Use_CaseL3DataTableCode
            // 
            this.coldsProtect_Use_CaseL3DataTableCode.Caption = "Code";
            this.coldsProtect_Use_CaseL3DataTableCode.ColumnName = "Code";
            this.coldsProtect_Use_CaseL3DataTableCode.Namespace = "";
            // 
            // coldsProtect_Use_CaseL3DataTableCode_Des
            // 
            this.coldsProtect_Use_CaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProtect_Use_CaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProtect_Use_CaseL3DataTableCode_Des.Namespace = "";
            // 
            // coldsProtect_Use_CaseL3DataTableCode_Val_Long
            // 
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsProtect_Use_CaseL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsDaubUseCaseOT
            // 
            this.bsDaubUseCaseOT.DataMember = "L3DataTable";
            this.bsDaubUseCaseOT.DataSource = this.dsDaubUseCase;
            // 
            // dsDaubUseCase
            // 
            this.dsDaubUseCase.AutoLoad = true;
            this.dsDaubUseCase.AutoSubscribe = true;
            this.dsDaubUseCase.DataSetName = "L3DataSet";
            this.dsDaubUseCase.DeleteMethod = null;
            this.dsDaubUseCase.InsertMethod = null;
            this.dsDaubUseCase.L3DataAdapter = this.Adapter;
            this.dsDaubUseCase.LoadEvent = "Click";
            this.dsDaubUseCase.LoadTrigger = null;
            this.dsDaubUseCase.RefreshValve = 1000;
            this.dsDaubUseCase.SourceCommand = null;
            this.dsDaubUseCase.SourceCondition = "Code_Group = \'Daub_Case\'";
            this.dsDaubUseCase.SourceMethod = "";
            this.dsDaubUseCase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDaubUseCase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDaubUseCase.SubscribeTarget = null;
            this.dsDaubUseCase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDaubUseCaseOT});
            this.dsDaubUseCase.UpdateEvent = "Click";
            this.dsDaubUseCase.UpdateMethod = null;
            this.dsDaubUseCase.UpdateTrigger = null;
            // 
            // schemadsDaubUseCaseOT
            // 
            this.schemadsDaubUseCaseOT.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDaubUseCaseOTL3DataTableCode,
            this.coldsDaubUseCaseOTL3DataTableCode_Des,
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long});
            this.schemadsDaubUseCaseOT.TableName = "L3DataTable";
            // 
            // coldsDaubUseCaseOTL3DataTableCode
            // 
            this.coldsDaubUseCaseOTL3DataTableCode.Caption = "Code";
            this.coldsDaubUseCaseOTL3DataTableCode.ColumnName = "Code";
            this.coldsDaubUseCaseOTL3DataTableCode.Namespace = "";
            // 
            // coldsDaubUseCaseOTL3DataTableCode_Des
            // 
            this.coldsDaubUseCaseOTL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDaubUseCaseOTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDaubUseCaseOTL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDaubUseCaseOTL3DataTableCode_Val_Long
            // 
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsDaubUseCaseOTL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsTranqCase
            // 
            this.dsTranqCase.AutoLoad = true;
            this.dsTranqCase.AutoSubscribe = false;
            this.dsTranqCase.DataSetName = "L3DataSet";
            this.dsTranqCase.DeleteMethod = "";
            this.dsTranqCase.InsertMethod = "";
            this.dsTranqCase.L3DataAdapter = this.Adapter;
            this.dsTranqCase.LoadEvent = "";
            this.dsTranqCase.LoadTrigger = null;
            this.dsTranqCase.RefreshValve = 1000;
            this.dsTranqCase.SourceCommand = null;
            this.dsTranqCase.SourceCondition = "Code_Group = \'Tranq_Case\'";
            this.dsTranqCase.SourceMethod = "";
            this.dsTranqCase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTranqCase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTranqCase.SubscribeTarget = null;
            this.dsTranqCase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTranqCase});
            this.dsTranqCase.UpdateEvent = "";
            this.dsTranqCase.UpdateMethod = "";
            this.dsTranqCase.UpdateTrigger = null;
            // 
            // schemadsTranqCase
            // 
            this.schemadsTranqCase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTranqCaseL3DataTableCode,
            this.coldsTranqCaseL3DataTableCode_Des});
            this.schemadsTranqCase.TableName = "L3DataTable";
            // 
            // coldsTranqCaseL3DataTableCode
            // 
            this.coldsTranqCaseL3DataTableCode.Caption = "Code";
            this.coldsTranqCaseL3DataTableCode.ColumnName = "Code";
            this.coldsTranqCaseL3DataTableCode.Namespace = "";
            // 
            // coldsTranqCaseL3DataTableCode_Des
            // 
            this.coldsTranqCaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTranqCaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTranqCaseL3DataTableCode_Des.Namespace = "";
            // 
            // bsRefraOT
            // 
            this.bsRefraOT.DataMember = "L3DataTable";
            this.bsRefraOT.DataSource = this.dsRefraOT;
            // 
            // dsRefraOT
            // 
            this.dsRefraOT.AutoLoad = true;
            this.dsRefraOT.AutoSubscribe = false;
            this.dsRefraOT.DataSetName = "L3DataSet";
            this.dsRefraOT.DeleteMethod = null;
            this.dsRefraOT.InsertMethod = null;
            this.dsRefraOT.L3DataAdapter = null;
            this.dsRefraOT.LoadEvent = "Click";
            this.dsRefraOT.LoadTrigger = null;
            this.dsRefraOT.RefreshValve = 1000;
            this.dsRefraOT.SourceCommand = null;
            this.dsRefraOT.SourceCondition = null;
            this.dsRefraOT.SourceMethod = "";
            this.dsRefraOT.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraOT.SourceURI = "XGMESLogic\\TundishMag\\CTundish_OT_Refra_Use";
            this.dsRefraOT.SubscribeTarget = null;
            this.dsRefraOT.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraOT});
            this.dsRefraOT.UpdateEvent = "Click";
            this.dsRefraOT.UpdateMethod = null;
            this.dsRefraOT.UpdateTrigger = null;
            // 
            // schemadsRefraOT
            // 
            this.schemadsRefraOT.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraOTL3DataTableGUID,
            this.coldsRefraOTL3DataTableName,
            this.coldsRefraOTL3DataTableInput_Time,
            this.coldsRefraOTL3DataTableTundishID,
            this.coldsRefraOTL3DataTableCast_ID,
            this.coldsRefraOTL3DataTableStop_Cast_Reason,
            this.coldsRefraOTL3DataTableCover_Use_Case,
            this.coldsRefraOTL3DataTableProtect_Use_Case,
            this.coldsRefraOTL3DataTableDaub_Use_Case,
            this.coldsRefraOTL3DataTableTranq_Case,
            this.coldsRefraOTL3DataTableNote,
            this.coldsRefraOTL3DataTableTeamID,
            this.coldsRefraOTL3DataTableShiftID,
            this.coldsRefraOTL3DataTableOperator,
            this.coldsRefraOTL3DataTableTundishNO});
            this.schemadsRefraOT.TableName = "L3DataTable";
            // 
            // coldsRefraOTL3DataTableGUID
            // 
            this.coldsRefraOTL3DataTableGUID.Caption = "GUID";
            this.coldsRefraOTL3DataTableGUID.ColumnName = "GUID";
            this.coldsRefraOTL3DataTableGUID.Namespace = "";
            // 
            // coldsRefraOTL3DataTableName
            // 
            this.coldsRefraOTL3DataTableName.Caption = "Name";
            this.coldsRefraOTL3DataTableName.ColumnName = "Name";
            this.coldsRefraOTL3DataTableName.Namespace = "";
            // 
            // coldsRefraOTL3DataTableInput_Time
            // 
            this.coldsRefraOTL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsRefraOTL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsRefraOTL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsRefraOTL3DataTableInput_Time.Namespace = "";
            // 
            // coldsRefraOTL3DataTableTundishID
            // 
            this.coldsRefraOTL3DataTableTundishID.Caption = "TundishID";
            this.coldsRefraOTL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsRefraOTL3DataTableTundishID.Namespace = "";
            // 
            // coldsRefraOTL3DataTableCast_ID
            // 
            this.coldsRefraOTL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsRefraOTL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsRefraOTL3DataTableCast_ID.Namespace = "";
            // 
            // coldsRefraOTL3DataTableStop_Cast_Reason
            // 
            this.coldsRefraOTL3DataTableStop_Cast_Reason.Caption = "Stop_Cast_Reason";
            this.coldsRefraOTL3DataTableStop_Cast_Reason.ColumnName = "Stop_Cast_Reason";
            this.coldsRefraOTL3DataTableStop_Cast_Reason.Namespace = "";
            // 
            // coldsRefraOTL3DataTableCover_Use_Case
            // 
            this.coldsRefraOTL3DataTableCover_Use_Case.Caption = "Cover_Use_Case";
            this.coldsRefraOTL3DataTableCover_Use_Case.ColumnName = "Cover_Use_Case";
            this.coldsRefraOTL3DataTableCover_Use_Case.Namespace = "";
            // 
            // coldsRefraOTL3DataTableProtect_Use_Case
            // 
            this.coldsRefraOTL3DataTableProtect_Use_Case.Caption = "Protect_Use_Case";
            this.coldsRefraOTL3DataTableProtect_Use_Case.ColumnName = "Protect_Use_Case";
            this.coldsRefraOTL3DataTableProtect_Use_Case.Namespace = "";
            // 
            // coldsRefraOTL3DataTableDaub_Use_Case
            // 
            this.coldsRefraOTL3DataTableDaub_Use_Case.Caption = "Daub_Use_Case";
            this.coldsRefraOTL3DataTableDaub_Use_Case.ColumnName = "Daub_Use_Case";
            this.coldsRefraOTL3DataTableDaub_Use_Case.Namespace = "";
            // 
            // coldsRefraOTL3DataTableTranq_Case
            // 
            this.coldsRefraOTL3DataTableTranq_Case.Caption = "Tranq_Case";
            this.coldsRefraOTL3DataTableTranq_Case.ColumnName = "Tranq_Case";
            this.coldsRefraOTL3DataTableTranq_Case.Namespace = "";
            // 
            // coldsRefraOTL3DataTableNote
            // 
            this.coldsRefraOTL3DataTableNote.Caption = "Note";
            this.coldsRefraOTL3DataTableNote.ColumnName = "Note";
            this.coldsRefraOTL3DataTableNote.Namespace = "";
            // 
            // coldsRefraOTL3DataTableTeamID
            // 
            this.coldsRefraOTL3DataTableTeamID.Caption = "TeamID";
            this.coldsRefraOTL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsRefraOTL3DataTableTeamID.Namespace = "";
            // 
            // coldsRefraOTL3DataTableShiftID
            // 
            this.coldsRefraOTL3DataTableShiftID.Caption = "ShiftID";
            this.coldsRefraOTL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsRefraOTL3DataTableShiftID.Namespace = "";
            // 
            // coldsRefraOTL3DataTableOperator
            // 
            this.coldsRefraOTL3DataTableOperator.Caption = "Operator";
            this.coldsRefraOTL3DataTableOperator.ColumnName = "Operator";
            this.coldsRefraOTL3DataTableOperator.Namespace = "";
            // 
            // coldsRefraOTL3DataTableTundishNO
            // 
            this.coldsRefraOTL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsRefraOTL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsRefraOTL3DataTableTundishNO.Namespace = "";
            // 
            // tabRefraTFF
            // 
            this.tabRefraTFF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRefraTFF.Controls.Add(this.dvRefraTFF);
            this.tabRefraTFF.Location = new System.Drawing.Point(4, 21);
            this.tabRefraTFF.Name = "tabRefraTFF";
            this.tabRefraTFF.Size = new System.Drawing.Size(1002, 281);
            this.tabRefraTFF.TabIndex = 4;
            this.tabRefraTFF.Text = "3/4/5/7/6#铸机中包";
            this.tabRefraTFF.UseVisualStyleBackColor = true;
            // 
            // dvRefraTFF
            // 
            this.dvRefraTFF.AllowUserToAddRows = false;
            this.dvRefraTFF.AutoGenerateColumns = false;
            this.dvRefraTFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvRefraTFF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvRefraTFF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishNODataGridViewTextBoxColumn2,
            this.inputTimeDataGridViewTextBoxColumn1,
            this.tundishIDDataGridViewTextBoxColumn1,
            this.castIDDataGridViewTextBoxColumn2,
            this.stopCastReasonDataGridViewTextBoxColumn1,
            this.daubUseCaseDataGridViewTextBoxColumn1,
            this.tranqCaseDataGridViewTextBoxColumn1,
            this.fristTuckStickCaseDataGridViewTextBoxColumn,
            this.secTuckStickCaseDataGridViewTextBoxColumn,
            this.thrTuckStickCaseDataGridViewTextBoxColumn,
            this.forTuckStickCaseDataGridViewTextBoxColumn,
            this.fristWaterGapCaseDataGridViewTextBoxColumn,
            this.secWaterGapCaseDataGridViewTextBoxColumn,
            this.thrWaterGapCaseDataGridViewTextBoxColumn,
            this.forWaterGapCaseDataGridViewTextBoxColumn,
            this.wardDregsCaseDataGridViewTextBoxColumn,
            this.coverUseCaseDataGridViewTextBoxColumn1,
            this.protectUseCaseDataGridViewTextBoxColumn1,
            this.proTempUseCaseDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1,
            this.teamIDDataGridViewTextBoxColumn1,
            this.shiftIDDataGridViewTextBoxColumn1,
            this.operatorDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.gUIDDataGridViewTextBoxColumn1});
            this.dvRefraTFF.DataSource = this.bsRefraTFF;
            this.dvRefraTFF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRefraTFF.Location = new System.Drawing.Point(0, 0);
            this.dvRefraTFF.Name = "dvRefraTFF";
            this.dvRefraTFF.RowTemplate.Height = 23;
            this.dvRefraTFF.Size = new System.Drawing.Size(1000, 279);
            this.dvRefraTFF.TabIndex = 1;
            this.dvRefraTFF.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            // 
            // tundishNODataGridViewTextBoxColumn2
            // 
            this.tundishNODataGridViewTextBoxColumn2.DataPropertyName = "TundishNO";
            this.tundishNODataGridViewTextBoxColumn2.HeaderText = "包次号";
            this.tundishNODataGridViewTextBoxColumn2.Name = "tundishNODataGridViewTextBoxColumn2";
            this.tundishNODataGridViewTextBoxColumn2.ReadOnly = true;
            this.tundishNODataGridViewTextBoxColumn2.Width = 66;
            // 
            // inputTimeDataGridViewTextBoxColumn1
            // 
            this.inputTimeDataGridViewTextBoxColumn1.DataPropertyName = "Input_Time";
            this.inputTimeDataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.inputTimeDataGridViewTextBoxColumn1.Name = "inputTimeDataGridViewTextBoxColumn1";
            this.inputTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.inputTimeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // tundishIDDataGridViewTextBoxColumn1
            // 
            this.tundishIDDataGridViewTextBoxColumn1.DataPropertyName = "TundishID";
            this.tundishIDDataGridViewTextBoxColumn1.HeaderText = "中包号";
            this.tundishIDDataGridViewTextBoxColumn1.Name = "tundishIDDataGridViewTextBoxColumn1";
            this.tundishIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tundishIDDataGridViewTextBoxColumn1.Width = 66;
            // 
            // castIDDataGridViewTextBoxColumn2
            // 
            this.castIDDataGridViewTextBoxColumn2.DataPropertyName = "Cast_ID";
            this.castIDDataGridViewTextBoxColumn2.HeaderText = "铸机号";
            this.castIDDataGridViewTextBoxColumn2.Name = "castIDDataGridViewTextBoxColumn2";
            this.castIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.castIDDataGridViewTextBoxColumn2.Visible = false;
            this.castIDDataGridViewTextBoxColumn2.Width = 66;
            // 
            // stopCastReasonDataGridViewTextBoxColumn1
            // 
            this.stopCastReasonDataGridViewTextBoxColumn1.DataPropertyName = "Stop_Cast_Reason";
            this.stopCastReasonDataGridViewTextBoxColumn1.DataSource = this.bsStopCastingReason2;
            this.stopCastReasonDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.stopCastReasonDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stopCastReasonDataGridViewTextBoxColumn1.HeaderText = "停浇原因";
            this.stopCastReasonDataGridViewTextBoxColumn1.Name = "stopCastReasonDataGridViewTextBoxColumn1";
            this.stopCastReasonDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stopCastReasonDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stopCastReasonDataGridViewTextBoxColumn1.ValueMember = "Code";
            this.stopCastReasonDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bsStopCastingReason2
            // 
            this.bsStopCastingReason2.DataMember = "L3DataTable";
            this.bsStopCastingReason2.DataSource = this.dsStopCastingReason;
            // 
            // daubUseCaseDataGridViewTextBoxColumn1
            // 
            this.daubUseCaseDataGridViewTextBoxColumn1.DataPropertyName = "Daub_Use_Case";
            this.daubUseCaseDataGridViewTextBoxColumn1.DataSource = this.bsDaubUseCaseTTF;
            this.daubUseCaseDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.daubUseCaseDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.daubUseCaseDataGridViewTextBoxColumn1.HeaderText = "涂抹(干振)料使用情况";
            this.daubUseCaseDataGridViewTextBoxColumn1.Name = "daubUseCaseDataGridViewTextBoxColumn1";
            this.daubUseCaseDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.daubUseCaseDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.daubUseCaseDataGridViewTextBoxColumn1.ValueMember = "Code";
            this.daubUseCaseDataGridViewTextBoxColumn1.Width = 150;
            // 
            // bsDaubUseCaseTTF
            // 
            this.bsDaubUseCaseTTF.DataMember = "L3DataTable";
            this.bsDaubUseCaseTTF.DataSource = this.dsDaubUseCase;
            // 
            // tranqCaseDataGridViewTextBoxColumn1
            // 
            this.tranqCaseDataGridViewTextBoxColumn1.DataPropertyName = "Tranq_Case";
            this.tranqCaseDataGridViewTextBoxColumn1.DataSource = this.dsTranqCase;
            this.tranqCaseDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.tranqCaseDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tranqCaseDataGridViewTextBoxColumn1.HeaderText = "稳流器使用情况";
            this.tranqCaseDataGridViewTextBoxColumn1.Name = "tranqCaseDataGridViewTextBoxColumn1";
            this.tranqCaseDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tranqCaseDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tranqCaseDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.tranqCaseDataGridViewTextBoxColumn1.Width = 114;
            // 
            // fristTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Frist_Tuck_Stick_Case";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.bsTuckStickCase1;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "1流塞棒使用情况";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Name = "fristTuckStickCaseDataGridViewTextBoxColumn";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsTuckStickCase1
            // 
            this.bsTuckStickCase1.DataMember = "L3DataTable";
            this.bsTuckStickCase1.DataSource = this.dsTuckStickCase;
            // 
            // dsTuckStickCase
            // 
            this.dsTuckStickCase.AutoLoad = true;
            this.dsTuckStickCase.AutoSubscribe = true;
            this.dsTuckStickCase.DataSetName = "L3DataSet";
            this.dsTuckStickCase.DeleteMethod = null;
            this.dsTuckStickCase.InsertMethod = null;
            this.dsTuckStickCase.L3DataAdapter = this.Adapter;
            this.dsTuckStickCase.LoadEvent = "Click";
            this.dsTuckStickCase.LoadTrigger = null;
            this.dsTuckStickCase.RefreshValve = 1000;
            this.dsTuckStickCase.SourceCommand = null;
            this.dsTuckStickCase.SourceCondition = "Code_Group = \'Tuck_Stick_Case\'";
            this.dsTuckStickCase.SourceMethod = "";
            this.dsTuckStickCase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTuckStickCase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTuckStickCase.SubscribeTarget = null;
            this.dsTuckStickCase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTuckStickCase});
            this.dsTuckStickCase.UpdateEvent = "Click";
            this.dsTuckStickCase.UpdateMethod = null;
            this.dsTuckStickCase.UpdateTrigger = null;
            // 
            // schemadsTuckStickCase
            // 
            this.schemadsTuckStickCase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTuckStickCaseL3DataTableCode,
            this.coldsTuckStickCaseL3DataTableCode_Des,
            this.coldsTuckStickCaseL3DataTableCode_Val_Long});
            this.schemadsTuckStickCase.TableName = "L3DataTable";
            // 
            // coldsTuckStickCaseL3DataTableCode
            // 
            this.coldsTuckStickCaseL3DataTableCode.Caption = "Code";
            this.coldsTuckStickCaseL3DataTableCode.ColumnName = "Code";
            this.coldsTuckStickCaseL3DataTableCode.Namespace = "";
            // 
            // coldsTuckStickCaseL3DataTableCode_Des
            // 
            this.coldsTuckStickCaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTuckStickCaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTuckStickCaseL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTuckStickCaseL3DataTableCode_Val_Long
            // 
            this.coldsTuckStickCaseL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTuckStickCaseL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTuckStickCaseL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsTuckStickCaseL3DataTableCode_Val_Long.Namespace = "";
            // 
            // secTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.secTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Sec_Tuck_Stick_Case";
            this.secTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.bsTuckStickCase2;
            this.secTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.secTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.secTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "2流塞棒使用情况";
            this.secTuckStickCaseDataGridViewTextBoxColumn.Name = "secTuckStickCaseDataGridViewTextBoxColumn";
            this.secTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.secTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsTuckStickCase2
            // 
            this.bsTuckStickCase2.DataMember = "L3DataTable";
            this.bsTuckStickCase2.DataSource = this.dsTuckStickCase;
            // 
            // thrTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Thr_Tuck_Stick_Case";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.bsTuckStickCase3;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "3流塞棒使用情况";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Name = "thrTuckStickCaseDataGridViewTextBoxColumn";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsTuckStickCase3
            // 
            this.bsTuckStickCase3.DataMember = "L3DataTable";
            this.bsTuckStickCase3.DataSource = this.dsTuckStickCase;
            // 
            // forTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.forTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "For_Tuck_Stick_Case";
            this.forTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.bsTuckStickCase4;
            this.forTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.forTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.forTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "4流塞棒使用情况";
            this.forTuckStickCaseDataGridViewTextBoxColumn.Name = "forTuckStickCaseDataGridViewTextBoxColumn";
            this.forTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.forTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.forTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.forTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsTuckStickCase4
            // 
            this.bsTuckStickCase4.DataMember = "L3DataTable";
            this.bsTuckStickCase4.DataSource = this.dsTuckStickCase;
            // 
            // fristWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Frist_Water_Gap_Case";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.bsBigGapCase1;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "1流水口使用情况";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Name = "fristWaterGapCaseDataGridViewTextBoxColumn";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsBigGapCase1
            // 
            this.bsBigGapCase1.DataMember = "L3DataTable";
            this.bsBigGapCase1.DataSource = this.dsBigGapCase;
            // 
            // dsBigGapCase
            // 
            this.dsBigGapCase.AutoLoad = true;
            this.dsBigGapCase.AutoSubscribe = true;
            this.dsBigGapCase.DataSetName = "L3DataSet";
            this.dsBigGapCase.DeleteMethod = null;
            this.dsBigGapCase.InsertMethod = null;
            this.dsBigGapCase.L3DataAdapter = this.Adapter;
            this.dsBigGapCase.LoadEvent = "Click";
            this.dsBigGapCase.LoadTrigger = null;
            this.dsBigGapCase.RefreshValve = 1000;
            this.dsBigGapCase.SourceCommand = null;
            this.dsBigGapCase.SourceCondition = "Code_Group = \'Big_Gap_Case\'";
            this.dsBigGapCase.SourceMethod = "";
            this.dsBigGapCase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBigGapCase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBigGapCase.SubscribeTarget = null;
            this.dsBigGapCase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBigGapCase});
            this.dsBigGapCase.UpdateEvent = "Click";
            this.dsBigGapCase.UpdateMethod = null;
            this.dsBigGapCase.UpdateTrigger = null;
            // 
            // schemadsBigGapCase
            // 
            this.schemadsBigGapCase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBigGapCaseL3DataTableCode,
            this.coldsBigGapCaseL3DataTableCode_Des,
            this.coldsBigGapCaseL3DataTableCode_Val_Long});
            this.schemadsBigGapCase.TableName = "L3DataTable";
            // 
            // coldsBigGapCaseL3DataTableCode
            // 
            this.coldsBigGapCaseL3DataTableCode.Caption = "Code";
            this.coldsBigGapCaseL3DataTableCode.ColumnName = "Code";
            this.coldsBigGapCaseL3DataTableCode.Namespace = "";
            // 
            // coldsBigGapCaseL3DataTableCode_Des
            // 
            this.coldsBigGapCaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBigGapCaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBigGapCaseL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBigGapCaseL3DataTableCode_Val_Long
            // 
            this.coldsBigGapCaseL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBigGapCaseL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBigGapCaseL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBigGapCaseL3DataTableCode_Val_Long.Namespace = "";
            // 
            // secWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.secWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Sec_Water_Gap_Case";
            this.secWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.bsBigGapCase2;
            this.secWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.secWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.secWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "2流水口使用情况";
            this.secWaterGapCaseDataGridViewTextBoxColumn.Name = "secWaterGapCaseDataGridViewTextBoxColumn";
            this.secWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.secWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsBigGapCase2
            // 
            this.bsBigGapCase2.DataMember = "L3DataTable";
            this.bsBigGapCase2.DataSource = this.dsBigGapCase;
            // 
            // thrWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Thr_Water_Gap_Case";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.bsBigGapCase3;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "3流水口使用情况";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Name = "thrWaterGapCaseDataGridViewTextBoxColumn";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsBigGapCase3
            // 
            this.bsBigGapCase3.DataMember = "L3DataTable";
            this.bsBigGapCase3.DataSource = this.dsBigGapCase;
            // 
            // forWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.forWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "For_Water_Gap_Case";
            this.forWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.bsBigGapCase4;
            this.forWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.forWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.forWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "4流水口使用情况";
            this.forWaterGapCaseDataGridViewTextBoxColumn.Name = "forWaterGapCaseDataGridViewTextBoxColumn";
            this.forWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.forWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.forWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "Code";
            this.forWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsBigGapCase4
            // 
            this.bsBigGapCase4.DataMember = "L3DataTable";
            this.bsBigGapCase4.DataSource = this.dsBigGapCase;
            // 
            // wardDregsCaseDataGridViewTextBoxColumn
            // 
            this.wardDregsCaseDataGridViewTextBoxColumn.DataPropertyName = "Ward_Dregs_Case";
            this.wardDregsCaseDataGridViewTextBoxColumn.DataSource = this.dsWard_Dregs_Case;
            this.wardDregsCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wardDregsCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wardDregsCaseDataGridViewTextBoxColumn.HeaderText = "挡渣墙使用情况";
            this.wardDregsCaseDataGridViewTextBoxColumn.Name = "wardDregsCaseDataGridViewTextBoxColumn";
            this.wardDregsCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wardDregsCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wardDregsCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.wardDregsCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsWard_Dregs_Case
            // 
            this.dsWard_Dregs_Case.AutoLoad = true;
            this.dsWard_Dregs_Case.AutoSubscribe = true;
            this.dsWard_Dregs_Case.DataSetName = "L3DataSet";
            this.dsWard_Dregs_Case.DeleteMethod = "";
            this.dsWard_Dregs_Case.InsertMethod = "";
            this.dsWard_Dregs_Case.L3DataAdapter = this.Adapter;
            this.dsWard_Dregs_Case.LoadEvent = "";
            this.dsWard_Dregs_Case.LoadTrigger = null;
            this.dsWard_Dregs_Case.RefreshValve = 1000;
            this.dsWard_Dregs_Case.SourceCommand = null;
            this.dsWard_Dregs_Case.SourceCondition = "Code_Group = \'Ward_Dregs_Case\' order by Code";
            this.dsWard_Dregs_Case.SourceMethod = "";
            this.dsWard_Dregs_Case.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWard_Dregs_Case.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWard_Dregs_Case.SubscribeTarget = null;
            this.dsWard_Dregs_Case.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWard_Dregs_Case});
            this.dsWard_Dregs_Case.UpdateEvent = "";
            this.dsWard_Dregs_Case.UpdateMethod = "";
            this.dsWard_Dregs_Case.UpdateTrigger = null;
            // 
            // schemadsWard_Dregs_Case
            // 
            this.schemadsWard_Dregs_Case.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWard_Dregs_CaseL3DataTableCode,
            this.coldsWard_Dregs_CaseL3DataTableCode_Des});
            this.schemadsWard_Dregs_Case.TableName = "L3DataTable";
            // 
            // coldsWard_Dregs_CaseL3DataTableCode
            // 
            this.coldsWard_Dregs_CaseL3DataTableCode.Caption = "Code";
            this.coldsWard_Dregs_CaseL3DataTableCode.ColumnName = "Code";
            this.coldsWard_Dregs_CaseL3DataTableCode.Namespace = "";
            // 
            // coldsWard_Dregs_CaseL3DataTableCode_Des
            // 
            this.coldsWard_Dregs_CaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWard_Dregs_CaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWard_Dregs_CaseL3DataTableCode_Des.Namespace = "";
            // 
            // coverUseCaseDataGridViewTextBoxColumn1
            // 
            this.coverUseCaseDataGridViewTextBoxColumn1.DataPropertyName = "Cover_Use_Case";
            this.coverUseCaseDataGridViewTextBoxColumn1.DataSource = this.bsCoverCaseTFF;
            this.coverUseCaseDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.coverUseCaseDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.coverUseCaseDataGridViewTextBoxColumn1.HeaderText = "覆盖剂使用情况";
            this.coverUseCaseDataGridViewTextBoxColumn1.Name = "coverUseCaseDataGridViewTextBoxColumn1";
            this.coverUseCaseDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coverUseCaseDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coverUseCaseDataGridViewTextBoxColumn1.ValueMember = "Code";
            this.coverUseCaseDataGridViewTextBoxColumn1.Width = 114;
            // 
            // bsCoverCaseTFF
            // 
            this.bsCoverCaseTFF.DataMember = "L3DataTable";
            this.bsCoverCaseTFF.DataSource = this.dsCoverCase;
            // 
            // protectUseCaseDataGridViewTextBoxColumn1
            // 
            this.protectUseCaseDataGridViewTextBoxColumn1.DataPropertyName = "Protect_Use_Case";
            this.protectUseCaseDataGridViewTextBoxColumn1.DataSource = this.bsProtect_Use_Case2;
            this.protectUseCaseDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.protectUseCaseDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.protectUseCaseDataGridViewTextBoxColumn1.HeaderText = "保护渣使用情况";
            this.protectUseCaseDataGridViewTextBoxColumn1.Name = "protectUseCaseDataGridViewTextBoxColumn1";
            this.protectUseCaseDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.protectUseCaseDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.protectUseCaseDataGridViewTextBoxColumn1.ValueMember = "Code";
            this.protectUseCaseDataGridViewTextBoxColumn1.Width = 114;
            // 
            // bsProtect_Use_Case2
            // 
            this.bsProtect_Use_Case2.DataMember = "L3DataTable";
            this.bsProtect_Use_Case2.DataSource = this.dsProtect_Use_Case;
            // 
            // proTempUseCaseDataGridViewTextBoxColumn
            // 
            this.proTempUseCaseDataGridViewTextBoxColumn.DataPropertyName = "Pro_Temp_Use_Case";
            this.proTempUseCaseDataGridViewTextBoxColumn.DataSource = this.dsHoldTempMat_Use;
            this.proTempUseCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.proTempUseCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.proTempUseCaseDataGridViewTextBoxColumn.HeaderText = "保温剂使用情况";
            this.proTempUseCaseDataGridViewTextBoxColumn.Name = "proTempUseCaseDataGridViewTextBoxColumn";
            this.proTempUseCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proTempUseCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.proTempUseCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.proTempUseCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsHoldTempMat_Use
            // 
            this.dsHoldTempMat_Use.AutoLoad = true;
            this.dsHoldTempMat_Use.AutoSubscribe = true;
            this.dsHoldTempMat_Use.DataSetName = "L3DataSet";
            this.dsHoldTempMat_Use.DeleteMethod = "";
            this.dsHoldTempMat_Use.InsertMethod = "";
            this.dsHoldTempMat_Use.L3DataAdapter = this.Adapter;
            this.dsHoldTempMat_Use.LoadEvent = "";
            this.dsHoldTempMat_Use.LoadTrigger = null;
            this.dsHoldTempMat_Use.RefreshValve = 1000;
            this.dsHoldTempMat_Use.SourceCommand = null;
            this.dsHoldTempMat_Use.SourceCondition = "Code_Group = \'CCCM_Heat_HoldTempMat_UseInformation\' order by Code";
            this.dsHoldTempMat_Use.SourceMethod = "";
            this.dsHoldTempMat_Use.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHoldTempMat_Use.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHoldTempMat_Use.SubscribeTarget = null;
            this.dsHoldTempMat_Use.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHoldTempMat_Use});
            this.dsHoldTempMat_Use.UpdateEvent = "";
            this.dsHoldTempMat_Use.UpdateMethod = "";
            this.dsHoldTempMat_Use.UpdateTrigger = null;
            // 
            // schemadsHoldTempMat_Use
            // 
            this.schemadsHoldTempMat_Use.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHoldTempMat_UseL3DataTableCode,
            this.coldsHoldTempMat_UseL3DataTableCode_Des});
            this.schemadsHoldTempMat_Use.TableName = "L3DataTable";
            // 
            // coldsHoldTempMat_UseL3DataTableCode
            // 
            this.coldsHoldTempMat_UseL3DataTableCode.Caption = "Code";
            this.coldsHoldTempMat_UseL3DataTableCode.ColumnName = "Code";
            this.coldsHoldTempMat_UseL3DataTableCode.Namespace = "";
            // 
            // coldsHoldTempMat_UseL3DataTableCode_Des
            // 
            this.coldsHoldTempMat_UseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHoldTempMat_UseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHoldTempMat_UseL3DataTableCode_Des.Namespace = "";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "过程异常说明";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.Width = 102;
            // 
            // teamIDDataGridViewTextBoxColumn1
            // 
            this.teamIDDataGridViewTextBoxColumn1.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn1.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn1.Name = "teamIDDataGridViewTextBoxColumn1";
            this.teamIDDataGridViewTextBoxColumn1.Visible = false;
            this.teamIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // shiftIDDataGridViewTextBoxColumn1
            // 
            this.shiftIDDataGridViewTextBoxColumn1.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn1.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn1.Name = "shiftIDDataGridViewTextBoxColumn1";
            this.shiftIDDataGridViewTextBoxColumn1.Visible = false;
            this.shiftIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // operatorDataGridViewTextBoxColumn1
            // 
            this.operatorDataGridViewTextBoxColumn1.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn1.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn1.Name = "operatorDataGridViewTextBoxColumn1";
            this.operatorDataGridViewTextBoxColumn1.Width = 66;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Visible = false;
            this.nameDataGridViewTextBoxColumn2.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsRefraTFF
            // 
            this.bsRefraTFF.DataMember = "L3DataTable";
            this.bsRefraTFF.DataSource = this.dsRefraTFF;
            // 
            // dsRefraTFF
            // 
            this.dsRefraTFF.AutoLoad = true;
            this.dsRefraTFF.AutoSubscribe = false;
            this.dsRefraTFF.DataSetName = "L3DataSet";
            this.dsRefraTFF.DeleteMethod = null;
            this.dsRefraTFF.InsertMethod = null;
            this.dsRefraTFF.L3DataAdapter = null;
            this.dsRefraTFF.LoadEvent = "Click";
            this.dsRefraTFF.LoadTrigger = null;
            this.dsRefraTFF.RefreshValve = 1000;
            this.dsRefraTFF.SourceCommand = null;
            this.dsRefraTFF.SourceCondition = null;
            this.dsRefraTFF.SourceMethod = "";
            this.dsRefraTFF.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraTFF.SourceURI = "XGMESLogic\\TundishMag\\CTundish_TFF_Refra_Use";
            this.dsRefraTFF.SubscribeTarget = null;
            this.dsRefraTFF.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraTFF});
            this.dsRefraTFF.UpdateEvent = "Click";
            this.dsRefraTFF.UpdateMethod = null;
            this.dsRefraTFF.UpdateTrigger = null;
            // 
            // schemadsRefraTFF
            // 
            this.schemadsRefraTFF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraTFFL3DataTableGUID,
            this.coldsRefraTFFL3DataTableName,
            this.coldsRefraTFFL3DataTableInput_Time,
            this.coldsRefraTFFL3DataTableTundishID,
            this.coldsRefraTFFL3DataTableCast_ID,
            this.coldsRefraTFFL3DataTableStop_Cast_Reason,
            this.coldsRefraTFFL3DataTableDaub_Use_Case,
            this.coldsRefraTFFL3DataTableTranq_Case,
            this.coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case,
            this.coldsRefraTFFL3DataTableSec_Tuck_Stick_Case,
            this.coldsRefraTFFL3DataTableThr_Tuck_Stick_Case,
            this.coldsRefraTFFL3DataTableFor_Tuck_Stick_Case,
            this.coldsRefraTFFL3DataTableFrist_Water_Gap_Case,
            this.coldsRefraTFFL3DataTableSec_Water_Gap_Case,
            this.coldsRefraTFFL3DataTableThr_Water_Gap_Case,
            this.coldsRefraTFFL3DataTableFor_Water_Gap_Case,
            this.coldsRefraTFFL3DataTableWard_Dregs_Case,
            this.coldsRefraTFFL3DataTableCover_Use_Case,
            this.coldsRefraTFFL3DataTableProtect_Use_Case,
            this.coldsRefraTFFL3DataTablePro_Temp_Use_Case,
            this.coldsRefraTFFL3DataTableNote,
            this.coldsRefraTFFL3DataTableTeamID,
            this.coldsRefraTFFL3DataTableShiftID,
            this.coldsRefraTFFL3DataTableOperator,
            this.coldsRefraTFFL3DataTableTundishNO});
            this.schemadsRefraTFF.TableName = "L3DataTable";
            // 
            // coldsRefraTFFL3DataTableGUID
            // 
            this.coldsRefraTFFL3DataTableGUID.Caption = "GUID";
            this.coldsRefraTFFL3DataTableGUID.ColumnName = "GUID";
            this.coldsRefraTFFL3DataTableGUID.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableName
            // 
            this.coldsRefraTFFL3DataTableName.Caption = "Name";
            this.coldsRefraTFFL3DataTableName.ColumnName = "Name";
            this.coldsRefraTFFL3DataTableName.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableInput_Time
            // 
            this.coldsRefraTFFL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsRefraTFFL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsRefraTFFL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsRefraTFFL3DataTableInput_Time.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableTundishID
            // 
            this.coldsRefraTFFL3DataTableTundishID.Caption = "TundishID";
            this.coldsRefraTFFL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsRefraTFFL3DataTableTundishID.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableCast_ID
            // 
            this.coldsRefraTFFL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsRefraTFFL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsRefraTFFL3DataTableCast_ID.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableStop_Cast_Reason
            // 
            this.coldsRefraTFFL3DataTableStop_Cast_Reason.Caption = "Stop_Cast_Reason";
            this.coldsRefraTFFL3DataTableStop_Cast_Reason.ColumnName = "Stop_Cast_Reason";
            this.coldsRefraTFFL3DataTableStop_Cast_Reason.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableDaub_Use_Case
            // 
            this.coldsRefraTFFL3DataTableDaub_Use_Case.Caption = "Daub_Use_Case";
            this.coldsRefraTFFL3DataTableDaub_Use_Case.ColumnName = "Daub_Use_Case";
            this.coldsRefraTFFL3DataTableDaub_Use_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableTranq_Case
            // 
            this.coldsRefraTFFL3DataTableTranq_Case.Caption = "Tranq_Case";
            this.coldsRefraTFFL3DataTableTranq_Case.ColumnName = "Tranq_Case";
            this.coldsRefraTFFL3DataTableTranq_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case
            // 
            this.coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case.Caption = "Frist_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case.ColumnName = "Frist_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableSec_Tuck_Stick_Case
            // 
            this.coldsRefraTFFL3DataTableSec_Tuck_Stick_Case.Caption = "Sec_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableSec_Tuck_Stick_Case.ColumnName = "Sec_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableSec_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableThr_Tuck_Stick_Case
            // 
            this.coldsRefraTFFL3DataTableThr_Tuck_Stick_Case.Caption = "Thr_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableThr_Tuck_Stick_Case.ColumnName = "Thr_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableThr_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableFor_Tuck_Stick_Case
            // 
            this.coldsRefraTFFL3DataTableFor_Tuck_Stick_Case.Caption = "For_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableFor_Tuck_Stick_Case.ColumnName = "For_Tuck_Stick_Case";
            this.coldsRefraTFFL3DataTableFor_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableFrist_Water_Gap_Case
            // 
            this.coldsRefraTFFL3DataTableFrist_Water_Gap_Case.Caption = "Frist_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableFrist_Water_Gap_Case.ColumnName = "Frist_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableFrist_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableSec_Water_Gap_Case
            // 
            this.coldsRefraTFFL3DataTableSec_Water_Gap_Case.Caption = "Sec_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableSec_Water_Gap_Case.ColumnName = "Sec_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableSec_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableThr_Water_Gap_Case
            // 
            this.coldsRefraTFFL3DataTableThr_Water_Gap_Case.Caption = "Thr_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableThr_Water_Gap_Case.ColumnName = "Thr_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableThr_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableFor_Water_Gap_Case
            // 
            this.coldsRefraTFFL3DataTableFor_Water_Gap_Case.Caption = "For_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableFor_Water_Gap_Case.ColumnName = "For_Water_Gap_Case";
            this.coldsRefraTFFL3DataTableFor_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableWard_Dregs_Case
            // 
            this.coldsRefraTFFL3DataTableWard_Dregs_Case.Caption = "Ward_Dregs_Case";
            this.coldsRefraTFFL3DataTableWard_Dregs_Case.ColumnName = "Ward_Dregs_Case";
            this.coldsRefraTFFL3DataTableWard_Dregs_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableCover_Use_Case
            // 
            this.coldsRefraTFFL3DataTableCover_Use_Case.Caption = "Cover_Use_Case";
            this.coldsRefraTFFL3DataTableCover_Use_Case.ColumnName = "Cover_Use_Case";
            this.coldsRefraTFFL3DataTableCover_Use_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableProtect_Use_Case
            // 
            this.coldsRefraTFFL3DataTableProtect_Use_Case.Caption = "Protect_Use_Case";
            this.coldsRefraTFFL3DataTableProtect_Use_Case.ColumnName = "Protect_Use_Case";
            this.coldsRefraTFFL3DataTableProtect_Use_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTablePro_Temp_Use_Case
            // 
            this.coldsRefraTFFL3DataTablePro_Temp_Use_Case.Caption = "Pro_Temp_Use_Case";
            this.coldsRefraTFFL3DataTablePro_Temp_Use_Case.ColumnName = "Pro_Temp_Use_Case";
            this.coldsRefraTFFL3DataTablePro_Temp_Use_Case.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableNote
            // 
            this.coldsRefraTFFL3DataTableNote.Caption = "Note";
            this.coldsRefraTFFL3DataTableNote.ColumnName = "Note";
            this.coldsRefraTFFL3DataTableNote.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableTeamID
            // 
            this.coldsRefraTFFL3DataTableTeamID.Caption = "TeamID";
            this.coldsRefraTFFL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsRefraTFFL3DataTableTeamID.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableShiftID
            // 
            this.coldsRefraTFFL3DataTableShiftID.Caption = "ShiftID";
            this.coldsRefraTFFL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsRefraTFFL3DataTableShiftID.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableOperator
            // 
            this.coldsRefraTFFL3DataTableOperator.Caption = "Operator";
            this.coldsRefraTFFL3DataTableOperator.ColumnName = "Operator";
            this.coldsRefraTFFL3DataTableOperator.Namespace = "";
            // 
            // coldsRefraTFFL3DataTableTundishNO
            // 
            this.coldsRefraTFFL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsRefraTFFL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsRefraTFFL3DataTableTundishNO.Namespace = "";
            // 
            // cmdMag
            // 
            this.cmdMag.Adapter = null;
            this.cmdMag.MergeReturnTarget = false;
            this.cmdMag.Method = null;
            this.cmdMag.Object = null;
            this.cmdMag.ReturnTarget = null;
            this.cmdMag.ReturnTargetProperty = null;
            this.cmdMag.Trigger = null;
            this.cmdMag.TriggerEvent = "Click";
            // 
            // richTextBox3
            // 
            this.richTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Note", true));
            this.richTextBox3.EnableNull = true;
            this.richTextBox3.ErropPr = null;
            this.richTextBox3.Location = new System.Drawing.Point(337, 217);
            this.richTextBox3.MaxStrLength = 0;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(591, 21);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            this.richTextBox3.ToolTipValid = null;
            this.richTextBox3.ValidEable = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Location = new System.Drawing.Point(296, 221);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(35, 12);
            this.label55.TabIndex = 174;
            this.label55.Text = "备注:";
            // 
            // pxComboBox7
            // 
            this.pxComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox7.EnableNull = true;
            this.pxComboBox7.ErropPr = null;
            this.pxComboBox7.FormattingEnabled = true;
            this.pxComboBox7.Location = new System.Drawing.Point(337, 166);
            this.pxComboBox7.Name = "pxComboBox7";
            this.pxComboBox7.Size = new System.Drawing.Size(100, 20);
            this.pxComboBox7.TabIndex = 15;
            this.pxComboBox7.ToolTipValid = null;
            this.pxComboBox7.ValidEable = true;
            // 
            // cmbFourthFraID
            // 
            this.cmbFourthFraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFourthFraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFourthFraID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFourthFraID.EnableNull = true;
            this.cmbFourthFraID.ErropPr = null;
            this.cmbFourthFraID.FormattingEnabled = true;
            this.cmbFourthFraID.Location = new System.Drawing.Point(337, 140);
            this.cmbFourthFraID.Name = "cmbFourthFraID";
            this.cmbFourthFraID.Size = new System.Drawing.Size(100, 20);
            this.cmbFourthFraID.TabIndex = 14;
            this.cmbFourthFraID.ToolTipValid = null;
            this.cmbFourthFraID.ValidEable = true;
            // 
            // cmbSecondFraID
            // 
            this.cmbSecondFraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSecondFraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSecondFraID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSecondFraID.EnableNull = true;
            this.cmbSecondFraID.ErropPr = null;
            this.cmbSecondFraID.FormattingEnabled = true;
            this.cmbSecondFraID.Location = new System.Drawing.Point(337, 88);
            this.cmbSecondFraID.Name = "cmbSecondFraID";
            this.cmbSecondFraID.Size = new System.Drawing.Size(100, 20);
            this.cmbSecondFraID.TabIndex = 12;
            this.cmbSecondFraID.ToolTipValid = null;
            this.cmbSecondFraID.ValidEable = true;
            // 
            // pxComboBox8
            // 
            this.pxComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTFFFireInfo, "Cast_ID", true));
            this.pxComboBox8.DisplayMember = "L3DataTable.Code_des";
            this.pxComboBox8.EnableNull = true;
            this.pxComboBox8.ErropPr = null;
            this.pxComboBox8.FormattingEnabled = true;
            this.pxComboBox8.Location = new System.Drawing.Point(337, 36);
            this.pxComboBox8.Name = "pxComboBox8";
            this.pxComboBox8.Size = new System.Drawing.Size(100, 20);
            this.pxComboBox8.TabIndex = 10;
            this.pxComboBox8.ToolTipValid = null;
            this.pxComboBox8.ValidEable = true;
            this.pxComboBox8.ValueMember = "L3DataTable.Code";
            // 
            // pxComboBox9
            // 
            this.pxComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox9.EnableNull = true;
            this.pxComboBox9.ErropPr = null;
            this.pxComboBox9.FormattingEnabled = true;
            this.pxComboBox9.Location = new System.Drawing.Point(337, 192);
            this.pxComboBox9.Name = "pxComboBox9";
            this.pxComboBox9.Size = new System.Drawing.Size(100, 20);
            this.pxComboBox9.TabIndex = 16;
            this.pxComboBox9.ToolTipValid = null;
            this.pxComboBox9.ValidEable = true;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Operator", true));
            this.pxTextBox3.EnableNull = true;
            this.pxTextBox3.ErropPr = null;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(105, 217);
            this.pxTextBox3.Max = 0;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox3.TabIndex = 8;
            this.pxTextBox3.ToolTipValid = null;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Location = new System.Drawing.Point(296, 169);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 12);
            this.label56.TabIndex = 163;
            this.label56.Text = "班次:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Location = new System.Drawing.Point(254, 143);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(77, 12);
            this.label57.TabIndex = 164;
            this.label57.Text = "4流机构编号:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Location = new System.Drawing.Point(254, 91);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(77, 12);
            this.label58.TabIndex = 167;
            this.label58.Text = "2流机构编号:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Location = new System.Drawing.Point(296, 39);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 12);
            this.label59.TabIndex = 166;
            this.label59.Text = "去向:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Location = new System.Drawing.Point(296, 195);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(35, 12);
            this.label60.TabIndex = 165;
            this.label60.Text = "班别:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Location = new System.Drawing.Point(52, 221);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 12);
            this.label61.TabIndex = 162;
            this.label61.Text = "责任人:";
            // 
            // dtBigEnd
            // 
            this.dtBigEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBigEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Big_End_Time", true));
            this.dtBigEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBigEnd.Location = new System.Drawing.Point(105, 191);
            this.dtBigEnd.Name = "dtBigEnd";
            this.dtBigEnd.Size = new System.Drawing.Size(141, 21);
            this.dtBigEnd.TabIndex = 7;
            // 
            // dtMiddleEnd
            // 
            this.dtMiddleEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtMiddleEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Mid_End_Time", true));
            this.dtMiddleEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMiddleEnd.Location = new System.Drawing.Point(105, 139);
            this.dtMiddleEnd.Name = "dtMiddleEnd";
            this.dtMiddleEnd.Size = new System.Drawing.Size(141, 21);
            this.dtMiddleEnd.TabIndex = 5;
            // 
            // dtSmallEnd
            // 
            this.dtSmallEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSmallEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Small_End_Time", true));
            this.dtSmallEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSmallEnd.Location = new System.Drawing.Point(105, 87);
            this.dtSmallEnd.Name = "dtSmallEnd";
            this.dtSmallEnd.Size = new System.Drawing.Size(141, 21);
            this.dtSmallEnd.TabIndex = 3;
            // 
            // dtBigStart
            // 
            this.dtBigStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBigStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Big_Strat_Time", true));
            this.dtBigStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBigStart.Location = new System.Drawing.Point(105, 165);
            this.dtBigStart.Name = "dtBigStart";
            this.dtBigStart.Size = new System.Drawing.Size(141, 21);
            this.dtBigStart.TabIndex = 6;
            // 
            // dtMiddleStart
            // 
            this.dtMiddleStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtMiddleStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Mid_Strat_Time", true));
            this.dtMiddleStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMiddleStart.Location = new System.Drawing.Point(105, 113);
            this.dtMiddleStart.Name = "dtMiddleStart";
            this.dtMiddleStart.Size = new System.Drawing.Size(141, 21);
            this.dtMiddleStart.TabIndex = 4;
            // 
            // dtSmallStart
            // 
            this.dtSmallStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSmallStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Small_Strat_Time", true));
            this.dtSmallStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSmallStart.Location = new System.Drawing.Point(105, 61);
            this.dtSmallStart.Name = "dtSmallStart";
            this.dtSmallStart.Size = new System.Drawing.Size(141, 21);
            this.dtSmallStart.TabIndex = 2;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker7.Enabled = false;
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(105, 35);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker7.TabIndex = 1;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Location = new System.Drawing.Point(16, 195);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(83, 12);
            this.label62.TabIndex = 150;
            this.label62.Text = "大火结束时间:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Location = new System.Drawing.Point(16, 143);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(83, 12);
            this.label63.TabIndex = 149;
            this.label63.Text = "中火结束时间:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Location = new System.Drawing.Point(16, 91);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(83, 12);
            this.label64.TabIndex = 148;
            this.label64.Text = "小火结束时间:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Location = new System.Drawing.Point(16, 169);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(83, 12);
            this.label65.TabIndex = 153;
            this.label65.Text = "大火开始时间:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Location = new System.Drawing.Point(16, 117);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(83, 12);
            this.label66.TabIndex = 152;
            this.label66.Text = "中火开始时间:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Location = new System.Drawing.Point(16, 65);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(83, 12);
            this.label67.TabIndex = 151;
            this.label67.Text = "小火开始时间:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Location = new System.Drawing.Point(4, 39);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(95, 12);
            this.label68.TabIndex = 154;
            this.label68.Text = "工作层修砌日期:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTFFFireInfo, "Input_Time", true));
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(105, 9);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // txtEigGapTemp
            // 
            this.txtEigGapTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Gap_Temp", true));
            this.txtEigGapTemp.EnableNull = true;
            this.txtEigGapTemp.ErropPr = null;
            this.txtEigGapTemp.Length = 0;
            this.txtEigGapTemp.Location = new System.Drawing.Point(837, 190);
            this.txtEigGapTemp.Max = 0;
            this.txtEigGapTemp.MaxStrLength = 0;
            this.txtEigGapTemp.Min = 0;
            this.txtEigGapTemp.MinStrLength = 0;
            this.txtEigGapTemp.Name = "txtEigGapTemp";
            this.txtEigGapTemp.Precision = 0;
            this.txtEigGapTemp.Size = new System.Drawing.Size(91, 21);
            this.txtEigGapTemp.TabIndex = 45;
            this.txtEigGapTemp.ToolTipValid = null;
            this.txtEigGapTemp.ValidEable = true;
            this.txtEigGapTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtEigWallTemp
            // 
            this.txtEigWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Wall_Temp", true));
            this.txtEigWallTemp.EnableNull = true;
            this.txtEigWallTemp.ErropPr = null;
            this.txtEigWallTemp.Length = 0;
            this.txtEigWallTemp.Location = new System.Drawing.Point(740, 190);
            this.txtEigWallTemp.Max = 0;
            this.txtEigWallTemp.MaxStrLength = 0;
            this.txtEigWallTemp.Min = 0;
            this.txtEigWallTemp.MinStrLength = 0;
            this.txtEigWallTemp.Name = "txtEigWallTemp";
            this.txtEigWallTemp.Precision = 0;
            this.txtEigWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtEigWallTemp.TabIndex = 44;
            this.txtEigWallTemp.ToolTipValid = null;
            this.txtEigWallTemp.ValidEable = true;
            this.txtEigWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtEigGasPress
            // 
            this.txtEigGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Gas_Press", true));
            this.txtEigGasPress.EnableNull = true;
            this.txtEigGasPress.ErropPr = null;
            this.txtEigGasPress.Length = 0;
            this.txtEigGasPress.Location = new System.Drawing.Point(644, 190);
            this.txtEigGasPress.Max = 0;
            this.txtEigGasPress.MaxStrLength = 0;
            this.txtEigGasPress.Min = 0;
            this.txtEigGasPress.MinStrLength = 0;
            this.txtEigGasPress.Name = "txtEigGasPress";
            this.txtEigGasPress.Precision = 0;
            this.txtEigGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtEigGasPress.TabIndex = 43;
            this.txtEigGasPress.ToolTipValid = null;
            this.txtEigGasPress.ValidEable = true;
            this.txtEigGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtEigGasFlux
            // 
            this.txtEigGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sev_Gas_Flux", true));
            this.txtEigGasFlux.EnableNull = true;
            this.txtEigGasFlux.ErropPr = null;
            this.txtEigGasFlux.Length = 0;
            this.txtEigGasFlux.Location = new System.Drawing.Point(548, 190);
            this.txtEigGasFlux.Max = 0;
            this.txtEigGasFlux.MaxStrLength = 0;
            this.txtEigGasFlux.Min = 0;
            this.txtEigGasFlux.MinStrLength = 0;
            this.txtEigGasFlux.Name = "txtEigGasFlux";
            this.txtEigGasFlux.Precision = 0;
            this.txtEigGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtEigGasFlux.TabIndex = 42;
            this.txtEigGasFlux.ToolTipValid = null;
            this.txtEigGasFlux.ValidEable = true;
            this.txtEigGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSevGapTemp
            // 
            this.txtSevGapTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Six_Gap_Temp", true));
            this.txtSevGapTemp.EnableNull = true;
            this.txtSevGapTemp.ErropPr = null;
            this.txtSevGapTemp.Length = 0;
            this.txtSevGapTemp.Location = new System.Drawing.Point(837, 164);
            this.txtSevGapTemp.Max = 0;
            this.txtSevGapTemp.MaxStrLength = 0;
            this.txtSevGapTemp.Min = 0;
            this.txtSevGapTemp.MinStrLength = 0;
            this.txtSevGapTemp.Name = "txtSevGapTemp";
            this.txtSevGapTemp.Precision = 0;
            this.txtSevGapTemp.Size = new System.Drawing.Size(91, 21);
            this.txtSevGapTemp.TabIndex = 41;
            this.txtSevGapTemp.ToolTipValid = null;
            this.txtSevGapTemp.ValidEable = true;
            this.txtSevGapTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSevWallTemp
            // 
            this.txtSevWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Six_Wall_Temp", true));
            this.txtSevWallTemp.EnableNull = true;
            this.txtSevWallTemp.ErropPr = null;
            this.txtSevWallTemp.Length = 0;
            this.txtSevWallTemp.Location = new System.Drawing.Point(740, 164);
            this.txtSevWallTemp.Max = 0;
            this.txtSevWallTemp.MaxStrLength = 0;
            this.txtSevWallTemp.Min = 0;
            this.txtSevWallTemp.MinStrLength = 0;
            this.txtSevWallTemp.Name = "txtSevWallTemp";
            this.txtSevWallTemp.Precision = 0;
            this.txtSevWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtSevWallTemp.TabIndex = 40;
            this.txtSevWallTemp.ToolTipValid = null;
            this.txtSevWallTemp.ValidEable = true;
            this.txtSevWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSevGasPress
            // 
            this.txtSevGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Six_Gas_Press", true));
            this.txtSevGasPress.EnableNull = true;
            this.txtSevGasPress.ErropPr = null;
            this.txtSevGasPress.Length = 0;
            this.txtSevGasPress.Location = new System.Drawing.Point(644, 164);
            this.txtSevGasPress.Max = 0;
            this.txtSevGasPress.MaxStrLength = 0;
            this.txtSevGasPress.Min = 0;
            this.txtSevGasPress.MinStrLength = 0;
            this.txtSevGasPress.Name = "txtSevGasPress";
            this.txtSevGasPress.Precision = 0;
            this.txtSevGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtSevGasPress.TabIndex = 39;
            this.txtSevGasPress.ToolTipValid = null;
            this.txtSevGasPress.ValidEable = true;
            this.txtSevGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSevGasFlux
            // 
            this.txtSevGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Six_Gas_Flux", true));
            this.txtSevGasFlux.EnableNull = true;
            this.txtSevGasFlux.ErropPr = null;
            this.txtSevGasFlux.Length = 0;
            this.txtSevGasFlux.Location = new System.Drawing.Point(548, 164);
            this.txtSevGasFlux.Max = 0;
            this.txtSevGasFlux.MaxStrLength = 0;
            this.txtSevGasFlux.Min = 0;
            this.txtSevGasFlux.MinStrLength = 0;
            this.txtSevGasFlux.Name = "txtSevGasFlux";
            this.txtSevGasFlux.Precision = 0;
            this.txtSevGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtSevGasFlux.TabIndex = 38;
            this.txtSevGasFlux.ToolTipValid = null;
            this.txtSevGasFlux.ValidEable = true;
            this.txtSevGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fiv_Gap_Temp", true));
            this.textBox40.EnableNull = true;
            this.textBox40.ErropPr = null;
            this.textBox40.Length = 0;
            this.textBox40.Location = new System.Drawing.Point(837, 138);
            this.textBox40.Max = 0;
            this.textBox40.MaxStrLength = 0;
            this.textBox40.Min = 0;
            this.textBox40.MinStrLength = 0;
            this.textBox40.Name = "textBox40";
            this.textBox40.Precision = 0;
            this.textBox40.Size = new System.Drawing.Size(91, 21);
            this.textBox40.TabIndex = 37;
            this.textBox40.ToolTipValid = null;
            this.textBox40.ValidEable = true;
            this.textBox40.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSixWallTemp
            // 
            this.txtSixWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fiv_Wall_Temp", true));
            this.txtSixWallTemp.EnableNull = true;
            this.txtSixWallTemp.ErropPr = null;
            this.txtSixWallTemp.Length = 0;
            this.txtSixWallTemp.Location = new System.Drawing.Point(740, 138);
            this.txtSixWallTemp.Max = 0;
            this.txtSixWallTemp.MaxStrLength = 0;
            this.txtSixWallTemp.Min = 0;
            this.txtSixWallTemp.MinStrLength = 0;
            this.txtSixWallTemp.Name = "txtSixWallTemp";
            this.txtSixWallTemp.Precision = 0;
            this.txtSixWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtSixWallTemp.TabIndex = 36;
            this.txtSixWallTemp.ToolTipValid = null;
            this.txtSixWallTemp.ValidEable = true;
            this.txtSixWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSixGasPress
            // 
            this.txtSixGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fiv_Gas_Press", true));
            this.txtSixGasPress.EnableNull = true;
            this.txtSixGasPress.ErropPr = null;
            this.txtSixGasPress.Length = 0;
            this.txtSixGasPress.Location = new System.Drawing.Point(644, 138);
            this.txtSixGasPress.Max = 0;
            this.txtSixGasPress.MaxStrLength = 0;
            this.txtSixGasPress.Min = 0;
            this.txtSixGasPress.MinStrLength = 0;
            this.txtSixGasPress.Name = "txtSixGasPress";
            this.txtSixGasPress.Precision = 0;
            this.txtSixGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtSixGasPress.TabIndex = 35;
            this.txtSixGasPress.ToolTipValid = null;
            this.txtSixGasPress.ValidEable = true;
            this.txtSixGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSixGasFlux
            // 
            this.txtSixGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fiv_Gas_Flux", true));
            this.txtSixGasFlux.EnableNull = true;
            this.txtSixGasFlux.ErropPr = null;
            this.txtSixGasFlux.Length = 0;
            this.txtSixGasFlux.Location = new System.Drawing.Point(548, 138);
            this.txtSixGasFlux.Max = 0;
            this.txtSixGasFlux.MaxStrLength = 0;
            this.txtSixGasFlux.Min = 0;
            this.txtSixGasFlux.MinStrLength = 0;
            this.txtSixGasFlux.Name = "txtSixGasFlux";
            this.txtSixGasFlux.Precision = 0;
            this.txtSixGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtSixGasFlux.TabIndex = 34;
            this.txtSixGasFlux.ToolTipValid = null;
            this.txtSixGasFlux.ValidEable = true;
            this.txtSixGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox39
            // 
            this.textBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fou_Gap_Temp", true));
            this.textBox39.EnableNull = true;
            this.textBox39.ErropPr = null;
            this.textBox39.Length = 0;
            this.textBox39.Location = new System.Drawing.Point(837, 112);
            this.textBox39.Max = 0;
            this.textBox39.MaxStrLength = 0;
            this.textBox39.Min = 0;
            this.textBox39.MinStrLength = 0;
            this.textBox39.Name = "textBox39";
            this.textBox39.Precision = 0;
            this.textBox39.Size = new System.Drawing.Size(91, 21);
            this.textBox39.TabIndex = 33;
            this.textBox39.ToolTipValid = null;
            this.textBox39.ValidEable = true;
            this.textBox39.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFouWallTemp
            // 
            this.txtFouWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fou_Wall_Temp", true));
            this.txtFouWallTemp.EnableNull = true;
            this.txtFouWallTemp.ErropPr = null;
            this.txtFouWallTemp.Length = 0;
            this.txtFouWallTemp.Location = new System.Drawing.Point(740, 112);
            this.txtFouWallTemp.Max = 0;
            this.txtFouWallTemp.MaxStrLength = 0;
            this.txtFouWallTemp.Min = 0;
            this.txtFouWallTemp.MinStrLength = 0;
            this.txtFouWallTemp.Name = "txtFouWallTemp";
            this.txtFouWallTemp.Precision = 0;
            this.txtFouWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtFouWallTemp.TabIndex = 32;
            this.txtFouWallTemp.ToolTipValid = null;
            this.txtFouWallTemp.ValidEable = true;
            this.txtFouWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFouGasPress
            // 
            this.txtFouGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fou_Gas_Press", true));
            this.txtFouGasPress.EnableNull = true;
            this.txtFouGasPress.ErropPr = null;
            this.txtFouGasPress.Length = 0;
            this.txtFouGasPress.Location = new System.Drawing.Point(644, 112);
            this.txtFouGasPress.Max = 0;
            this.txtFouGasPress.MaxStrLength = 0;
            this.txtFouGasPress.Min = 0;
            this.txtFouGasPress.MinStrLength = 0;
            this.txtFouGasPress.Name = "txtFouGasPress";
            this.txtFouGasPress.Precision = 0;
            this.txtFouGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtFouGasPress.TabIndex = 31;
            this.txtFouGasPress.ToolTipValid = null;
            this.txtFouGasPress.ValidEable = true;
            this.txtFouGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFouGasFlux
            // 
            this.txtFouGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fou_Gas_Flux", true));
            this.txtFouGasFlux.EnableNull = true;
            this.txtFouGasFlux.ErropPr = null;
            this.txtFouGasFlux.Length = 0;
            this.txtFouGasFlux.Location = new System.Drawing.Point(548, 112);
            this.txtFouGasFlux.Max = 0;
            this.txtFouGasFlux.MaxStrLength = 0;
            this.txtFouGasFlux.Min = 0;
            this.txtFouGasFlux.MinStrLength = 0;
            this.txtFouGasFlux.Name = "txtFouGasFlux";
            this.txtFouGasFlux.Precision = 0;
            this.txtFouGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtFouGasFlux.TabIndex = 30;
            this.txtFouGasFlux.ToolTipValid = null;
            this.txtFouGasFlux.ValidEable = true;
            this.txtFouGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtThiGapTemp
            // 
            this.txtThiGapTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Thi_Gap_Temp", true));
            this.txtThiGapTemp.EnableNull = true;
            this.txtThiGapTemp.ErropPr = null;
            this.txtThiGapTemp.Length = 0;
            this.txtThiGapTemp.Location = new System.Drawing.Point(837, 86);
            this.txtThiGapTemp.Max = 0;
            this.txtThiGapTemp.MaxStrLength = 0;
            this.txtThiGapTemp.Min = 0;
            this.txtThiGapTemp.MinStrLength = 0;
            this.txtThiGapTemp.Name = "txtThiGapTemp";
            this.txtThiGapTemp.Precision = 0;
            this.txtThiGapTemp.Size = new System.Drawing.Size(91, 21);
            this.txtThiGapTemp.TabIndex = 29;
            this.txtThiGapTemp.ToolTipValid = null;
            this.txtThiGapTemp.ValidEable = true;
            this.txtThiGapTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtThiWallTemp
            // 
            this.txtThiWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Thi_Wall_Temp", true));
            this.txtThiWallTemp.EnableNull = true;
            this.txtThiWallTemp.ErropPr = null;
            this.txtThiWallTemp.Length = 0;
            this.txtThiWallTemp.Location = new System.Drawing.Point(740, 86);
            this.txtThiWallTemp.Max = 0;
            this.txtThiWallTemp.MaxStrLength = 0;
            this.txtThiWallTemp.Min = 0;
            this.txtThiWallTemp.MinStrLength = 0;
            this.txtThiWallTemp.Name = "txtThiWallTemp";
            this.txtThiWallTemp.Precision = 0;
            this.txtThiWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtThiWallTemp.TabIndex = 28;
            this.txtThiWallTemp.ToolTipValid = null;
            this.txtThiWallTemp.ValidEable = true;
            this.txtThiWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtThiGasPress
            // 
            this.txtThiGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Thi_Gas_Press", true));
            this.txtThiGasPress.EnableNull = true;
            this.txtThiGasPress.ErropPr = null;
            this.txtThiGasPress.Length = 0;
            this.txtThiGasPress.Location = new System.Drawing.Point(644, 86);
            this.txtThiGasPress.Max = 0;
            this.txtThiGasPress.MaxStrLength = 0;
            this.txtThiGasPress.Min = 0;
            this.txtThiGasPress.MinStrLength = 0;
            this.txtThiGasPress.Name = "txtThiGasPress";
            this.txtThiGasPress.Precision = 0;
            this.txtThiGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtThiGasPress.TabIndex = 27;
            this.txtThiGasPress.ToolTipValid = null;
            this.txtThiGasPress.ValidEable = true;
            this.txtThiGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtThiGasFlux
            // 
            this.txtThiGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Thi_Gas_Flux", true));
            this.txtThiGasFlux.EnableNull = true;
            this.txtThiGasFlux.ErropPr = null;
            this.txtThiGasFlux.Length = 0;
            this.txtThiGasFlux.Location = new System.Drawing.Point(548, 86);
            this.txtThiGasFlux.Max = 0;
            this.txtThiGasFlux.MaxStrLength = 0;
            this.txtThiGasFlux.Min = 0;
            this.txtThiGasFlux.MinStrLength = 0;
            this.txtThiGasFlux.Name = "txtThiGasFlux";
            this.txtThiGasFlux.Precision = 0;
            this.txtThiGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtThiGasFlux.TabIndex = 26;
            this.txtThiGasFlux.ToolTipValid = null;
            this.txtThiGasFlux.ValidEable = true;
            this.txtThiGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSecGapTemp
            // 
            this.txtSecGapTemp.EnableNull = true;
            this.txtSecGapTemp.ErropPr = null;
            this.txtSecGapTemp.Length = 0;
            this.txtSecGapTemp.Location = new System.Drawing.Point(837, 60);
            this.txtSecGapTemp.Max = 0;
            this.txtSecGapTemp.MaxStrLength = 0;
            this.txtSecGapTemp.Min = 0;
            this.txtSecGapTemp.MinStrLength = 0;
            this.txtSecGapTemp.Name = "txtSecGapTemp";
            this.txtSecGapTemp.Precision = 0;
            this.txtSecGapTemp.Size = new System.Drawing.Size(91, 21);
            this.txtSecGapTemp.TabIndex = 25;
            this.txtSecGapTemp.ToolTipValid = null;
            this.txtSecGapTemp.ValidEable = true;
            this.txtSecGapTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSecWallTemp
            // 
            this.txtSecWallTemp.EnableNull = true;
            this.txtSecWallTemp.ErropPr = null;
            this.txtSecWallTemp.Length = 0;
            this.txtSecWallTemp.Location = new System.Drawing.Point(740, 60);
            this.txtSecWallTemp.Max = 0;
            this.txtSecWallTemp.MaxStrLength = 0;
            this.txtSecWallTemp.Min = 0;
            this.txtSecWallTemp.MinStrLength = 0;
            this.txtSecWallTemp.Name = "txtSecWallTemp";
            this.txtSecWallTemp.Precision = 0;
            this.txtSecWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtSecWallTemp.TabIndex = 24;
            this.txtSecWallTemp.ToolTipValid = null;
            this.txtSecWallTemp.ValidEable = true;
            this.txtSecWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSecGasPress
            // 
            this.txtSecGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sec_Gas_Press", true));
            this.txtSecGasPress.EnableNull = true;
            this.txtSecGasPress.ErropPr = null;
            this.txtSecGasPress.Length = 0;
            this.txtSecGasPress.Location = new System.Drawing.Point(644, 60);
            this.txtSecGasPress.Max = 0;
            this.txtSecGasPress.MaxStrLength = 0;
            this.txtSecGasPress.Min = 0;
            this.txtSecGasPress.MinStrLength = 0;
            this.txtSecGasPress.Name = "txtSecGasPress";
            this.txtSecGasPress.Precision = 0;
            this.txtSecGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtSecGasPress.TabIndex = 23;
            this.txtSecGasPress.ToolTipValid = null;
            this.txtSecGasPress.ValidEable = true;
            this.txtSecGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSecGasFlux
            // 
            this.txtSecGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Sec_Gas_Flux", true));
            this.txtSecGasFlux.EnableNull = true;
            this.txtSecGasFlux.ErropPr = null;
            this.txtSecGasFlux.Length = 0;
            this.txtSecGasFlux.Location = new System.Drawing.Point(548, 60);
            this.txtSecGasFlux.Max = 0;
            this.txtSecGasFlux.MaxStrLength = 0;
            this.txtSecGasFlux.Min = 0;
            this.txtSecGasFlux.MinStrLength = 0;
            this.txtSecGasFlux.Name = "txtSecGasFlux";
            this.txtSecGasFlux.Precision = 0;
            this.txtSecGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtSecGasFlux.TabIndex = 22;
            this.txtSecGasFlux.ToolTipValid = null;
            this.txtSecGasFlux.ValidEable = true;
            this.txtSecGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFirGapTemp
            // 
            this.txtFirGapTemp.EnableNull = true;
            this.txtFirGapTemp.ErropPr = null;
            this.txtFirGapTemp.Length = 0;
            this.txtFirGapTemp.Location = new System.Drawing.Point(837, 34);
            this.txtFirGapTemp.Max = 0;
            this.txtFirGapTemp.MaxStrLength = 0;
            this.txtFirGapTemp.Min = 0;
            this.txtFirGapTemp.MinStrLength = 0;
            this.txtFirGapTemp.Name = "txtFirGapTemp";
            this.txtFirGapTemp.Precision = 0;
            this.txtFirGapTemp.Size = new System.Drawing.Size(91, 21);
            this.txtFirGapTemp.TabIndex = 21;
            this.txtFirGapTemp.ToolTipValid = null;
            this.txtFirGapTemp.ValidEable = true;
            this.txtFirGapTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFirWallTemp
            // 
            this.txtFirWallTemp.EnableNull = true;
            this.txtFirWallTemp.ErropPr = null;
            this.txtFirWallTemp.Length = 0;
            this.txtFirWallTemp.Location = new System.Drawing.Point(740, 34);
            this.txtFirWallTemp.Max = 0;
            this.txtFirWallTemp.MaxStrLength = 0;
            this.txtFirWallTemp.Min = 0;
            this.txtFirWallTemp.MinStrLength = 0;
            this.txtFirWallTemp.Name = "txtFirWallTemp";
            this.txtFirWallTemp.Precision = 0;
            this.txtFirWallTemp.Size = new System.Drawing.Size(91, 21);
            this.txtFirWallTemp.TabIndex = 20;
            this.txtFirWallTemp.ToolTipValid = null;
            this.txtFirWallTemp.ValidEable = true;
            this.txtFirWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFirGasPress
            // 
            this.txtFirGasPress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fir_Gas_Press", true));
            this.txtFirGasPress.EnableNull = true;
            this.txtFirGasPress.ErropPr = null;
            this.txtFirGasPress.Length = 0;
            this.txtFirGasPress.Location = new System.Drawing.Point(644, 34);
            this.txtFirGasPress.Max = 0;
            this.txtFirGasPress.MaxStrLength = 0;
            this.txtFirGasPress.Min = 0;
            this.txtFirGasPress.MinStrLength = 0;
            this.txtFirGasPress.Name = "txtFirGasPress";
            this.txtFirGasPress.Precision = 0;
            this.txtFirGasPress.Size = new System.Drawing.Size(91, 21);
            this.txtFirGasPress.TabIndex = 19;
            this.txtFirGasPress.ToolTipValid = null;
            this.txtFirGasPress.ValidEable = true;
            this.txtFirGasPress.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFirGasFlux
            // 
            this.txtFirGasFlux.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTFFFireInfo, "Fir_Gas_Flux", true));
            this.txtFirGasFlux.EnableNull = true;
            this.txtFirGasFlux.ErropPr = null;
            this.txtFirGasFlux.Length = 0;
            this.txtFirGasFlux.Location = new System.Drawing.Point(548, 34);
            this.txtFirGasFlux.Max = 0;
            this.txtFirGasFlux.MaxStrLength = 0;
            this.txtFirGasFlux.Min = 0;
            this.txtFirGasFlux.MinStrLength = 0;
            this.txtFirGasFlux.Name = "txtFirGasFlux";
            this.txtFirGasFlux.Precision = 0;
            this.txtFirGasFlux.Size = new System.Drawing.Size(91, 21);
            this.txtFirGasFlux.TabIndex = 18;
            this.txtFirGasFlux.ToolTipValid = null;
            this.txtFirGasFlux.ValidEable = true;
            this.txtFirGasFlux.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Location = new System.Drawing.Point(40, 13);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(59, 12);
            this.label69.TabIndex = 146;
            this.label69.Text = "录入时间:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Location = new System.Drawing.Point(844, 13);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(77, 12);
            this.label70.TabIndex = 106;
            this.label70.Text = "水口温度[℃]";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Location = new System.Drawing.Point(648, 13);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(83, 12);
            this.label71.TabIndex = 105;
            this.label71.Text = "煤气压力[Kpa]";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Location = new System.Drawing.Point(735, 13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(101, 12);
            this.label72.TabIndex = 108;
            this.label72.Text = "中间包壁温度[℃]";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Location = new System.Drawing.Point(549, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(89, 12);
            this.label73.TabIndex = 107;
            this.label73.Text = "煤气流量[m3/h]";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Location = new System.Drawing.Point(442, 194);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(101, 12);
            this.label74.TabIndex = 104;
            this.label74.Text = "(150～开浇)分钟:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Location = new System.Drawing.Point(448, 168);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(95, 12);
            this.label75.TabIndex = 101;
            this.label75.Text = "(120～150)分钟:";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Location = new System.Drawing.Point(454, 142);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(89, 12);
            this.label76.TabIndex = 100;
            this.label76.Text = "(90～120)分钟:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Location = new System.Drawing.Point(460, 116);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(83, 12);
            this.label77.TabIndex = 103;
            this.label77.Text = "(60～90)分钟:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Location = new System.Drawing.Point(460, 90);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(83, 12);
            this.label78.TabIndex = 102;
            this.label78.Text = "(20～60)分钟:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Location = new System.Drawing.Point(460, 64);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(83, 12);
            this.label79.TabIndex = 114;
            this.label79.Text = "(10～20)分钟:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Location = new System.Drawing.Point(490, 13);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(29, 12);
            this.label80.TabIndex = 112;
            this.label80.Text = "时间";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Location = new System.Drawing.Point(466, 38);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(77, 12);
            this.label81.TabIndex = 113;
            this.label81.Text = "(0～10)分钟:";
            // 
            // cmbThirdFraID
            // 
            this.cmbThirdFraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbThirdFraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbThirdFraID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbThirdFraID.EnableNull = true;
            this.cmbThirdFraID.ErropPr = null;
            this.cmbThirdFraID.FormattingEnabled = true;
            this.cmbThirdFraID.Location = new System.Drawing.Point(337, 114);
            this.cmbThirdFraID.Name = "cmbThirdFraID";
            this.cmbThirdFraID.Size = new System.Drawing.Size(100, 20);
            this.cmbThirdFraID.TabIndex = 13;
            this.cmbThirdFraID.ToolTipValid = null;
            this.cmbThirdFraID.ValidEable = true;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.Color.Transparent;
            this.label82.Location = new System.Drawing.Point(254, 117);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(77, 12);
            this.label82.TabIndex = 109;
            this.label82.Text = "3流机构编号:";
            // 
            // cmbFirstFraID
            // 
            this.cmbFirstFraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFirstFraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFirstFraID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFirstFraID.EnableNull = true;
            this.cmbFirstFraID.ErropPr = null;
            this.cmbFirstFraID.FormattingEnabled = true;
            this.cmbFirstFraID.Location = new System.Drawing.Point(337, 62);
            this.cmbFirstFraID.Name = "cmbFirstFraID";
            this.cmbFirstFraID.Size = new System.Drawing.Size(100, 20);
            this.cmbFirstFraID.TabIndex = 11;
            this.cmbFirstFraID.ToolTipValid = null;
            this.cmbFirstFraID.ValidEable = true;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Location = new System.Drawing.Point(254, 65);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(77, 12);
            this.label83.TabIndex = 110;
            this.label83.Text = "1流机构编号:";
            // 
            // pxComboBox10
            // 
            this.pxComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox10.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTFFFireInfo, "TundishID", true));
            this.pxComboBox10.DisplayMember = "L3DataTable.Code_des";
            this.pxComboBox10.EnableNull = true;
            this.pxComboBox10.ErropPr = null;
            this.pxComboBox10.FormattingEnabled = true;
            this.pxComboBox10.Location = new System.Drawing.Point(337, 10);
            this.pxComboBox10.Name = "pxComboBox10";
            this.pxComboBox10.Size = new System.Drawing.Size(100, 20);
            this.pxComboBox10.TabIndex = 9;
            this.pxComboBox10.ToolTipValid = null;
            this.pxComboBox10.ValidEable = true;
            this.pxComboBox10.ValueMember = "L3DataTable.Code";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Transparent;
            this.label84.Location = new System.Drawing.Point(296, 13);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(35, 12);
            this.label84.TabIndex = 111;
            this.label84.Text = "包号:";
            // 
            // richTextBox6
            // 
            this.richTextBox6.EnableNull = true;
            this.richTextBox6.ErropPr = null;
            this.richTextBox6.Location = new System.Drawing.Point(315, 86);
            this.richTextBox6.MaxStrLength = 0;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(141, 96);
            this.richTextBox6.TabIndex = 10;
            this.richTextBox6.Text = "";
            this.richTextBox6.ToolTipValid = null;
            this.richTextBox6.ValidEable = true;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.BackColor = System.Drawing.Color.Transparent;
            this.label133.Location = new System.Drawing.Point(273, 91);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(35, 12);
            this.label133.TabIndex = 106;
            this.label133.Text = "备注:";
            // 
            // pxComboBox22
            // 
            this.pxComboBox22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox22.EnableNull = true;
            this.pxComboBox22.ErropPr = null;
            this.pxComboBox22.FormattingEnabled = true;
            this.pxComboBox22.Location = new System.Drawing.Point(315, 62);
            this.pxComboBox22.Name = "pxComboBox22";
            this.pxComboBox22.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox22.TabIndex = 9;
            this.pxComboBox22.ToolTipValid = null;
            this.pxComboBox22.ValidEable = true;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.BackColor = System.Drawing.Color.Transparent;
            this.label134.Location = new System.Drawing.Point(273, 65);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(35, 12);
            this.label134.TabIndex = 104;
            this.label134.Text = "班次:";
            // 
            // pxComboBox23
            // 
            this.pxComboBox23.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox23.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox23.EnableNull = true;
            this.pxComboBox23.ErropPr = null;
            this.pxComboBox23.FormattingEnabled = true;
            this.pxComboBox23.Location = new System.Drawing.Point(315, 36);
            this.pxComboBox23.Name = "pxComboBox23";
            this.pxComboBox23.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox23.TabIndex = 8;
            this.pxComboBox23.ToolTipValid = null;
            this.pxComboBox23.ValidEable = true;
            // 
            // txtInstallPer
            // 
            this.txtInstallPer.EnableNull = true;
            this.txtInstallPer.ErropPr = null;
            this.txtInstallPer.Length = 0;
            this.txtInstallPer.Location = new System.Drawing.Point(315, 9);
            this.txtInstallPer.Max = 0;
            this.txtInstallPer.MaxStrLength = 0;
            this.txtInstallPer.Min = 0;
            this.txtInstallPer.MinStrLength = 0;
            this.txtInstallPer.Name = "txtInstallPer";
            this.txtInstallPer.Precision = 0;
            this.txtInstallPer.Size = new System.Drawing.Size(141, 21);
            this.txtInstallPer.TabIndex = 7;
            this.txtInstallPer.ToolTipValid = null;
            this.txtInstallPer.ValidEable = true;
            this.txtInstallPer.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.BackColor = System.Drawing.Color.Transparent;
            this.label135.Location = new System.Drawing.Point(273, 39);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(35, 12);
            this.label135.TabIndex = 101;
            this.label135.Text = "班别:";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.BackColor = System.Drawing.Color.Transparent;
            this.label136.Location = new System.Drawing.Point(261, 13);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(47, 12);
            this.label136.TabIndex = 100;
            this.label136.Text = "安装人:";
            // 
            // cmbGapFac
            // 
            this.cmbGapFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGapFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGapFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGapFac.EnableNull = true;
            this.cmbGapFac.ErropPr = null;
            this.cmbGapFac.FormattingEnabled = true;
            this.cmbGapFac.Location = new System.Drawing.Point(103, 162);
            this.cmbGapFac.Name = "cmbGapFac";
            this.cmbGapFac.Size = new System.Drawing.Size(141, 20);
            this.cmbGapFac.TabIndex = 6;
            this.cmbGapFac.ToolTipValid = null;
            this.cmbGapFac.ValidEable = true;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.BackColor = System.Drawing.Color.Transparent;
            this.label137.Location = new System.Drawing.Point(25, 169);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(71, 12);
            this.label137.TabIndex = 98;
            this.label137.Text = "上水口厂家:";
            // 
            // txtFraCase
            // 
            this.txtFraCase.EnableNull = true;
            this.txtFraCase.ErropPr = null;
            this.txtFraCase.Length = 0;
            this.txtFraCase.Location = new System.Drawing.Point(103, 111);
            this.txtFraCase.Max = 0;
            this.txtFraCase.MaxStrLength = 0;
            this.txtFraCase.Min = 0;
            this.txtFraCase.MinStrLength = 0;
            this.txtFraCase.Name = "txtFraCase";
            this.txtFraCase.Precision = 0;
            this.txtFraCase.Size = new System.Drawing.Size(141, 21);
            this.txtFraCase.TabIndex = 4;
            this.txtFraCase.ToolTipValid = null;
            this.txtFraCase.ValidEable = true;
            this.txtFraCase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbSlipBloFac
            // 
            this.cmbSlipBloFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSlipBloFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSlipBloFac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSlipBloFac.EnableNull = true;
            this.cmbSlipBloFac.ErropPr = null;
            this.cmbSlipBloFac.FormattingEnabled = true;
            this.cmbSlipBloFac.Location = new System.Drawing.Point(103, 137);
            this.cmbSlipBloFac.Name = "cmbSlipBloFac";
            this.cmbSlipBloFac.Size = new System.Drawing.Size(141, 20);
            this.cmbSlipBloFac.TabIndex = 5;
            this.cmbSlipBloFac.ToolTipValid = null;
            this.cmbSlipBloFac.ValidEable = true;
            // 
            // pxComboBox24
            // 
            this.pxComboBox24.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox24.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox24.EnableNull = true;
            this.pxComboBox24.ErropPr = null;
            this.pxComboBox24.FormattingEnabled = true;
            this.pxComboBox24.Location = new System.Drawing.Point(103, 86);
            this.pxComboBox24.Name = "pxComboBox24";
            this.pxComboBox24.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox24.TabIndex = 3;
            this.pxComboBox24.ToolTipValid = null;
            this.pxComboBox24.ValidEable = true;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.BackColor = System.Drawing.Color.Transparent;
            this.label138.Location = new System.Drawing.Point(37, 117);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(59, 12);
            this.label138.TabIndex = 36;
            this.label138.Text = "机构情况:";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.BackColor = System.Drawing.Color.Transparent;
            this.label139.Location = new System.Drawing.Point(37, 143);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(59, 12);
            this.label139.TabIndex = 34;
            this.label139.Text = "滑块厂家:";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.BackColor = System.Drawing.Color.Transparent;
            this.label140.Location = new System.Drawing.Point(37, 91);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(59, 12);
            this.label140.TabIndex = 35;
            this.label140.Text = "涂料厂家:";
            // 
            // dtInstallDate
            // 
            this.dtInstallDate.CustomFormat = "yyyy-MM-dd";
            this.dtInstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInstallDate.Location = new System.Drawing.Point(103, 35);
            this.dtInstallDate.Name = "dtInstallDate";
            this.dtInstallDate.Size = new System.Drawing.Size(141, 21);
            this.dtInstallDate.TabIndex = 1;
            // 
            // dateTimePicker17
            // 
            this.dateTimePicker17.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker17.Enabled = false;
            this.dateTimePicker17.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker17.Location = new System.Drawing.Point(103, 9);
            this.dateTimePicker17.Name = "dateTimePicker17";
            this.dateTimePicker17.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker17.TabIndex = 0;
            this.dateTimePicker17.Value = new System.DateTime(2008, 11, 20, 14, 10, 0, 0);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.BackColor = System.Drawing.Color.Transparent;
            this.label141.Location = new System.Drawing.Point(37, 39);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(59, 12);
            this.label141.TabIndex = 31;
            this.label141.Text = "安装日期:";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.BackColor = System.Drawing.Color.Transparent;
            this.label142.Location = new System.Drawing.Point(37, 13);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(59, 12);
            this.label142.TabIndex = 30;
            this.label142.Text = "录入时间:";
            // 
            // pxComboBox25
            // 
            this.pxComboBox25.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox25.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox25.DisplayMember = "L3DataTable.Code_des";
            this.pxComboBox25.EnableNull = true;
            this.pxComboBox25.ErropPr = null;
            this.pxComboBox25.FormattingEnabled = true;
            this.pxComboBox25.Location = new System.Drawing.Point(103, 61);
            this.pxComboBox25.Name = "pxComboBox25";
            this.pxComboBox25.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox25.TabIndex = 2;
            this.pxComboBox25.ToolTipValid = null;
            this.pxComboBox25.ValidEable = true;
            this.pxComboBox25.ValueMember = "L3DataTable.Code";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.BackColor = System.Drawing.Color.Transparent;
            this.label143.Location = new System.Drawing.Point(61, 65);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(35, 12);
            this.label143.TabIndex = 28;
            this.label143.Text = "包号:";
            // 
            // bsOTInstallTeamID
            // 
            this.bsOTInstallTeamID.DataMember = "L3DataTable";
            this.bsOTInstallTeamID.DataSource = this.dsTeamID;
            // 
            // TundishMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanel);
            this.Controls.Add(this.bnMag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishMag";
            this.TabText = "中包管理";
            this.Text = "　TundishMag";
            this.Load += new System.EventHandler(this.TundishMag_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TundishMag_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bnMag)).EndInit();
            this.bnMag.ResumeLayout(false);
            this.bnMag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerbuildShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuildTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFireShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFireTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOTInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTIstallShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTFFInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTFFInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstallShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFInstallTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTFFFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTFFFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFHotShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTFFHotTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOTFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.hmiRootPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMag)).EndInit();
            this.tabControlMag.ResumeLayout(false);
            this.tabInnerBuild.ResumeLayout(false);
            this.pnlInnerBuild.ResumeLayout(false);
            this.pnlInnerBuild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerRefraFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerRefraFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerRefraName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerRefraName)).EndInit();
            this.tabInnerFire.ResumeLayout(false);
            this.tabInnerFire.PerformLayout();
            this.tabDaub.ResumeLayout(false);
            this.tabDaub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGluemudFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGluemudFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDryMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDryMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWardDregsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWardDregsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBriFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBriFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProject)).EndInit();
            this.tabInstall.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsUpGapFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpGapFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).EndInit();
            this.tabTFFInstall.ResumeLayout(false);
            this.tabTFFInstall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStuStiFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStuStiFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapFac)).EndInit();
            this.tabHotFire.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsOTHotCraneTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustTeam)).EndInit();
            this.tabTFFFire.ResumeLayout(false);
            this.tabTFFFire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTFHotCraneTeamID)).EndInit();
            this.tabRefra.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStopCastingReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopCastingReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopCastingReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoverCaseOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverCaseOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtect_Use_Case1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtect_Use_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtect_Use_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubUseCaseOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubUseCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubUseCaseOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraOT)).EndInit();
            this.tabRefraTFF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvRefraTFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStopCastingReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaubUseCaseTTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuckStickCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuckStickCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTuckStickCase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapCase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWard_Dregs_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWard_Dregs_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoverCaseTFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtect_Use_Case2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat_Use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat_Use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraTFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraTFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraTFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOTInstallTeamID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnMag;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMag;
        private System.Windows.Forms.BindingSource bsMag;
        private AppSvrHMI.L3Command cmdMag;
        private System.Windows.Forms.BindingSource bsInnerBuild;
        private AppSvrHMI.L3DataSet dsInnerBuild;
        private System.Windows.Forms.BindingSource bsInnerFire;
        private AppSvrHMI.L3DataSet dsInnerFire;
        private System.Windows.Forms.BindingSource bsDaub;
        private AppSvrHMI.L3DataSet dsDaub;
        private System.Windows.Forms.BindingSource bsTFFFireInfo;
        private AppSvrHMI.L3DataSet dsTFFFireInfo;
        private PxDataValid.PxRichTextBox richTextBox3;
        private System.Windows.Forms.Label label55;
        private PxDataValid.PxComboBox pxComboBox7;
        private PxDataValid.PxComboBox cmbFourthFraID;
        private PxDataValid.PxComboBox cmbSecondFraID;
        private PxDataValid.PxComboBox pxComboBox8;
        private PxDataValid.PxComboBox pxComboBox9;
        private PxDataValid.PxTextBox pxTextBox3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.DateTimePicker dtBigEnd;
        private System.Windows.Forms.DateTimePicker dtMiddleEnd;
        private System.Windows.Forms.DateTimePicker dtSmallEnd;
        private System.Windows.Forms.DateTimePicker dtBigStart;
        private System.Windows.Forms.DateTimePicker dtMiddleStart;
        private System.Windows.Forms.DateTimePicker dtSmallStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private PxDataValid.PxTextBox txtEigGapTemp;
        private PxDataValid.PxTextBox txtEigWallTemp;
        private PxDataValid.PxTextBox txtEigGasPress;
        private PxDataValid.PxTextBox txtEigGasFlux;
        private PxDataValid.PxTextBox txtSevGapTemp;
        private PxDataValid.PxTextBox txtSevWallTemp;
        private PxDataValid.PxTextBox txtSevGasPress;
        private PxDataValid.PxTextBox txtSevGasFlux;
        private PxDataValid.PxTextBox textBox40;
        private PxDataValid.PxTextBox txtSixWallTemp;
        private PxDataValid.PxTextBox txtSixGasPress;
        private PxDataValid.PxTextBox txtSixGasFlux;
        private PxDataValid.PxTextBox textBox39;
        private PxDataValid.PxTextBox txtFouWallTemp;
        private PxDataValid.PxTextBox txtFouGasPress;
        private PxDataValid.PxTextBox txtFouGasFlux;
        private PxDataValid.PxTextBox txtThiGapTemp;
        private PxDataValid.PxTextBox txtThiWallTemp;
        private PxDataValid.PxTextBox txtThiGasPress;
        private PxDataValid.PxTextBox txtThiGasFlux;
        private PxDataValid.PxTextBox txtSecGapTemp;
        private PxDataValid.PxTextBox txtSecWallTemp;
        private PxDataValid.PxTextBox txtSecGasPress;
        private PxDataValid.PxTextBox txtSecGasFlux;
        private PxDataValid.PxTextBox txtFirGapTemp;
        private PxDataValid.PxTextBox txtFirWallTemp;
        private PxDataValid.PxTextBox txtFirGasPress;
        private PxDataValid.PxTextBox txtFirGasFlux;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private PxDataValid.PxComboBox cmbThirdFraID;
        private System.Windows.Forms.Label label82;
        private PxDataValid.PxComboBox cmbFirstFraID;
        private System.Windows.Forms.Label label83;
        private PxDataValid.PxComboBox pxComboBox10;
        private System.Windows.Forms.Label label84;
        private PxDataValid.PxRichTextBox richTextBox6;
        private System.Windows.Forms.Label label133;
        private PxDataValid.PxComboBox pxComboBox22;
        private System.Windows.Forms.Label label134;
        private PxDataValid.PxComboBox pxComboBox23;
        private PxDataValid.PxTextBox txtInstallPer;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private PxDataValid.PxComboBox cmbGapFac;
        private System.Windows.Forms.Label label137;
        private PxDataValid.PxTextBox txtFraCase;
        private PxDataValid.PxComboBox cmbSlipBloFac;
        private PxDataValid.PxComboBox pxComboBox24;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.DateTimePicker dtInstallDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker17;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private PxDataValid.PxComboBox pxComboBox25;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.BindingSource bsOTFireInfo;
        private AppSvrHMI.L3DataSet dsOTFireInfo;
        private System.Data.DataTable schemadsMag;
        private System.Data.DataColumn coldsMagL3DataTableGUID;
        private System.Data.DataColumn coldsMagL3DataTableName;
        private System.Data.DataColumn coldsMagL3DataTableCreat_Time;
        private System.Data.DataColumn coldsMagL3DataTableTundishID;
        private System.Data.DataColumn coldsMagL3DataTableVehicle_ID;
        private System.Data.DataColumn coldsMagL3DataTableCast_ID;
        private System.Data.DataColumn coldsMagL3DataTableInner_Tie_Start_Time;
        private System.Data.DataColumn coldsMagL3DataTableInner_Tie_End_Time;
        private System.Data.DataColumn coldsMagL3DataTableInner_Small_Fire_Time;
        private System.Data.DataColumn coldsMagL3DataTableInner_Close_Fire_Time;
        private System.Data.DataColumn coldsMagL3DataTableDaub_Start_Time;
        private System.Data.DataColumn coldsMagL3DataTableDaub_End_Time;
        private System.Data.DataColumn coldsMagL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsMagL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsMagL3DataTableHot_Big_End_Time;
        private System.Data.DataColumn coldsMagL3DataTableCast_Start_Time;
        private System.Data.DataColumn coldsMagL3DataTableCast_End_Time;
        private System.Data.DataColumn coldsMagL3DataTableTundishNo;
        private System.Data.DataColumn coldsMagL3DataTableInnerID;
        private System.Data.DataColumn coldsMagL3DataTableWorkID;
        private System.Data.DataColumn coldsMagL3DataTableHot_Small_Start_Time;
        private System.Data.DataTable schemadsInnerBuild;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTundishID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableInnerID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableInner_Use_Count;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTundishNO;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTie_Start_Time;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTie_End_Time;
        private System.Data.DataColumn coldsInnerBuildL3DataTableCheck_Date;
        private System.Data.DataColumn coldsInnerBuildL3DataTableRefra_Fac;
        private System.Data.DataColumn coldsInnerBuildL3DataTableRefra_ID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableWaste;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTeamID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableShiftID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableOperator;
        private System.Data.DataColumn coldsInnerBuildL3DataTableNote;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox tsCmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Data.DataTable schemadsInnerFire;
        private System.Data.DataColumn coldsInnerFireL3DataTableTundishID;
        private System.Data.DataColumn coldsInnerFireL3DataTableInnerID;
        private System.Data.DataColumn coldsInnerFireL3DataTableTundishNO;
        private System.Data.DataColumn coldsInnerFireL3DataTableSmall_Fire_Time;
        private System.Data.DataColumn coldsInnerFireL3DataTableSmall_Fire_Operator;
        private System.Data.DataColumn coldsInnerFireL3DataTableMid_Fire_Time;
        private System.Data.DataColumn coldsInnerFireL3DataTableMid_Fire_Operator;
        private System.Data.DataColumn coldsInnerFireL3DataTableBig_Fire_Time;
        private System.Data.DataColumn coldsInnerFireL3DataTableBig_Fire_Operator;
        private System.Data.DataColumn coldsInnerFireL3DataTableClose_Fire_Time;
        private System.Data.DataColumn coldsInnerFireL3DataTableClose_Fire_Operator;
        private System.Data.DataColumn coldsInnerFireL3DataTableTeamID;
        private System.Data.DataColumn coldsInnerFireL3DataTableShiftID;
        private System.Data.DataColumn coldsInnerFireL3DataTableOperator;
        private System.Data.DataColumn coldsInnerFireL3DataTableNote;
        private System.Data.DataTable schemadsDaub;
        private System.Data.DataColumn coldsDaubL3DataTableTundishID;
        private System.Data.DataColumn coldsDaubL3DataTableWorkID;
        private System.Data.DataColumn coldsDaubL3DataTableInnerID;
        private System.Data.DataColumn coldsDaubL3DataTableInner_Use_Count;
        private System.Data.DataColumn coldsDaubL3DataTableCast_ID;
        private System.Data.DataColumn coldsDaubL3DataTableTundishNo;
        private System.Data.DataColumn coldsDaubL3DataTableProject;
        private System.Data.DataColumn coldsDaubL3DataTableGap_Bri_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableGap_Bri_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableWard_Dregs_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableWard_Dregs_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableTranq_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableTranq_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableDaub_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableDaub_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableDry_Flap_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableDry_Flap_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableGluemud_Fac;
        private System.Data.DataColumn coldsDaubL3DataTableGluemud_Consume;
        private System.Data.DataColumn coldsDaubL3DataTableDaub_Start_Time;
        private System.Data.DataColumn coldsDaubL3DataTableDaub_End_Time;
        private System.Data.DataColumn coldsDaubL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsDaubL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsDaubL3DataTableTeamID;
        private System.Data.DataColumn coldsDaubL3DataTableShiftID;
        private System.Data.DataColumn coldsDaubL3DataTableOperator;
        private System.Data.DataColumn coldsDaubL3DataTableNote;
        private System.Data.DataTable schemadsTFFFireInfo;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableTundishID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableWorkID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableCast_ID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableTundishNO;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFirst_Fra_ID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSecond_Fra_ID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableThird_Fra_ID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFourth_Fra_ID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSmall_Start_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSmall_End_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableMid_Start_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableMid_End_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableBig_Start_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableBig_End_Time;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableNote;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableTeamID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableShiftID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableOperator;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFir_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFir_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSec_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSec_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableThi_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableThi_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableThi_Wall_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableThi_Gap_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFou_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFou_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFou_Wall_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFou_Gap_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFiv_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFiv_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFiv_Wall_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableFiv_Gap_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSix_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSix_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSix_Wall_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSix_Gap_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSev_Gas_Flux;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSev_Gas_Press;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSev_Wall_Temp;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableSev_Gap_Temp;
        private System.Data.DataTable schemadsOTFireInfo;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableTundishID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableWorkID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableTundish_SeqNo;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableCast_ID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableAdjust_Per;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableAdjust_TeamID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableMove_Case;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableNote;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableFirst_Hyd_Pre;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableSecond_Hyd_Pre;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableThird_Hyd_Pre;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableFourth_Hyd_Pre;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableFire_Temp;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableTeamID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableShiftID;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableOperator;
        private System.Windows.Forms.ToolStripButton btnSave;
        private AppSvrHMI.L3DataSet dsOTInstall;
        private AppSvrHMI.L3DataSet dsTFFInstall;
        private System.Data.DataTable schemadsTFFInstall;
        private System.Data.DataColumn coldsTFFInstallL3DataTableTundishID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableWorkID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableDaub_Fac;
        private System.Data.DataColumn coldsTFFInstallL3DataTableRefra_Fac;
        private System.Data.DataColumn coldsTFFInstallL3DataTableFra_Switch_Case;
        private System.Data.DataColumn coldsTFFInstallL3DataTableCon_Per;
        private System.Data.DataColumn coldsTFFInstallL3DataTableGap_Fac;
        private System.Data.DataColumn coldsTFFInstallL3DataTableGap_Pro_Date;
        private System.Data.DataColumn coldsTFFInstallL3DataTableFirst_Gap_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableSecond_Gap_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableThird_Gap_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableFourth_Gap_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableStu_Sti_Fac;
        private System.Data.DataColumn coldsTFFInstallL3DataTableStu_Sti_Pro_Date;
        private System.Data.DataColumn coldsTFFInstallL3DataTableFirst_Stu_Sti_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableSecond_Stu_Sti_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableThird_Stu_Sti_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableFourth_Stu_Sti_ID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableInstall_Per;
        private System.Data.DataColumn coldsTFFInstallL3DataTableInstall_Time;
        private System.Data.DataColumn coldsTFFInstallL3DataTableNote;
        private System.Windows.Forms.BindingSource bsOTInstall;
        private System.Windows.Forms.BindingSource bsTFFInstall;
        private System.Data.DataTable schemadsOTInstall;
        private System.Data.DataColumn coldsOTInstallL3DataTableTundishID;
        private System.Data.DataColumn coldsOTInstallL3DataTableWorkID;
        private System.Data.DataColumn coldsOTInstallL3DataTableVehicleID;
        private System.Data.DataColumn coldsOTInstallL3DataTableTundishNo;
        private System.Data.DataColumn coldsOTInstallL3DataTableDaub_Fac;
        private System.Data.DataColumn coldsOTInstallL3DataTableFra_Case;
        private System.Data.DataColumn coldsOTInstallL3DataTableSlip_Blo_Fac;
        private System.Data.DataColumn coldsOTInstallL3DataTableGap_Fac;
        private System.Data.DataColumn coldsOTInstallL3DataTableInstall_Per;
        private System.Data.DataColumn coldsOTInstallL3DataTableInstall_Time;
        private System.Data.DataColumn coldsOTInstallL3DataTableNote;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_des;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Windows.Forms.BindingSource bsInnerbuildShiftID;
        private System.Windows.Forms.BindingSource bsInnerFireShiftID;
        private System.Windows.Forms.BindingSource bsDaubShiftID;
        private System.Windows.Forms.BindingSource bsOTHotShiftID;
        private System.Windows.Forms.BindingSource bsTFFHotShiftID;
        private System.Windows.Forms.BindingSource bsOTIstallShiftID;
        private System.Windows.Forms.BindingSource bsTFFInstallShiftID;
        private System.Windows.Forms.BindingSource bsInnerBuildTeamID;
        private System.Windows.Forms.BindingSource bsInnerFireTeamID;
        private System.Windows.Forms.BindingSource bsDaubTeamID;
        private System.Windows.Forms.BindingSource bsOTHotTeamID;
        private System.Windows.Forms.BindingSource bsTFFHotTeamID;
        private System.Windows.Forms.BindingSource bsOTInstallTeamID;
        private System.Windows.Forms.BindingSource bsTFFInstallTeamID;
        private System.Windows.Forms.TabControl tabControlMag;
        private System.Windows.Forms.TabPage tabInnerBuild;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label45;
        private PxDataValid.PxTextBox textBox6;
        private PxDataValid.PxTextBox textBox5;
        private PxDataValid.PxTextBox textBox2;
        private PxDataValid.PxTextBox txtWaste;
        private PxDataValid.PxComboBox cmbRefraID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCheckDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label180;
        private PxDataValid.PxComboBox cmbRefraFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTieEndTime;
        private System.Windows.Forms.DateTimePicker dtTieStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabInnerFire;
        private PxDataValid.PxTextBox textBox8;
        private System.Windows.Forms.Label label20;
        private PxDataValid.PxRichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxComboBox pxComboBox1;
        private PxDataValid.PxComboBox pxComboBox2;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtStopFireTime;
        private System.Windows.Forms.DateTimePicker dtLFireTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox textBox7;
        private PxDataValid.PxTextBox txtStopFireOper;
        private PxDataValid.PxTextBox txtLFireOper;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtMFireTime;
        private System.Windows.Forms.DateTimePicker dtSFireTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private PxDataValid.PxTextBox txtMFireOper;
        private PxDataValid.PxTextBox txtSFireOper;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabDaub;
        private PxDataValid.PxRichTextBox richTextBox2;
        private System.Windows.Forms.Label label25;
        private PxDataValid.PxComboBox pxComboBox4;
        private PxDataValid.PxComboBox pxComboBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtFireEnd;
        private System.Windows.Forms.DateTimePicker dtFireStart;
        private System.Windows.Forms.DateTimePicker dtBuildEnd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtBuildStart;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private PxDataValid.PxTextBox txtGluemudWaste;
        private PxDataValid.PxTextBox txtDryFlapWaste;
        private PxDataValid.PxTextBox txtDaubWaste;
        private PxDataValid.PxComboBox cmbGluemudFac;
        private PxDataValid.PxComboBox cmbDryFlapFac;
        private PxDataValid.PxComboBox cmbDaubFac;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private PxDataValid.PxTextBox txtTranqFac;
        private PxDataValid.PxTextBox txtWardDregsWaste;
        private PxDataValid.PxTextBox txtGapBriWaste;
        private PxDataValid.PxComboBox cmbTranqFac;
        private PxDataValid.PxComboBox cmbWardDregsFac;
        private PxDataValid.PxComboBox cmbGapBriFac;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private PxDataValid.PxTextBox pxTextBox2;
        private System.Windows.Forms.Label label48;
        private PxDataValid.PxTextBox txtForeverFloorCount;
        private PxDataValid.PxTextBox textBox9;
        private PxDataValid.PxTextBox textBox13;
        private PxDataValid.PxTextBox txtForeverFloorID;
        private PxDataValid.PxComboBox cmbProject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TabPage tabInstall;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabTFFInstall;
        private PxDataValid.PxRichTextBox richTextBox8;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.DateTimePicker dateTimePicker20;
        private System.Windows.Forms.Label label156;
        private PxDataValid.PxComboBox pxComboBox32;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.DateTimePicker dateTimePicker21;
        private System.Windows.Forms.Label label162;
        private PxDataValid.PxComboBox pxComboBox41;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private PxDataValid.PxTextBox pxTextBox44;
        private PxDataValid.PxTextBox pxTextBox40;
        private PxDataValid.PxTextBox pxTextBox43;
        private PxDataValid.PxTextBox pxTextBox39;
        private PxDataValid.PxTextBox pxTextBox42;
        private PxDataValid.PxTextBox pxTextBox38;
        private PxDataValid.PxTextBox pxTextBox41;
        private PxDataValid.PxTextBox pxTextBox37;
        private PxDataValid.PxTextBox pxTextBox35;
        private PxDataValid.PxTextBox pxTextBox36;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.DateTimePicker dateTimePicker23;
        private System.Windows.Forms.Label label174;
        private PxDataValid.PxTextBox textBox3;
        private PxDataValid.PxTextBox textBox18;
        private PxDataValid.PxTextBox textBox12;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.TabPage tabHotFire;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTFFFire;
        private System.Windows.Forms.Label label170;
        private PxDataValid.PxTextBox textBox16;
        private PxDataValid.PxTextBox textBox15;
        private System.Windows.Forms.Label label49;
        private PxDataValid.PxRichTextBox richTextBox4;
        private System.Windows.Forms.Label label85;
        private PxDataValid.PxComboBox pxComboBox11;
        private PxDataValid.PxComboBox pxComboBox14;
        private PxDataValid.PxComboBox pxComboBox19;
        private PxDataValid.PxComboBox pxComboBox15;
        private PxDataValid.PxTextBox pxTextBox48;
        private PxDataValid.PxTextBox pxTextBox47;
        private PxDataValid.PxTextBox pxTextBox46;
        private PxDataValid.PxTextBox pxTextBox45;
        private PxDataValid.PxTextBox pxTextBox4;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
        private System.Windows.Forms.DateTimePicker dateTimePicker10;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private PxDataValid.PxTextBox pxTextBox5;
        private PxDataValid.PxTextBox pxTextBox6;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TabPage tabRefra;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.DataGridView dvMag;
        private AppSvrHMI.L3DataSet dsRefraOT;
        private System.Data.DataTable schemadsRefraOT;
        private System.Data.DataColumn coldsRefraOTL3DataTableGUID;
        private System.Data.DataColumn coldsRefraOTL3DataTableName;
        private System.Data.DataColumn coldsRefraOTL3DataTableInput_Time;
        private System.Data.DataColumn coldsRefraOTL3DataTableTundishID;
        private System.Data.DataColumn coldsRefraOTL3DataTableCast_ID;
        private System.Data.DataColumn coldsRefraOTL3DataTableStop_Cast_Reason;
        private System.Data.DataColumn coldsRefraOTL3DataTableCover_Use_Case;
        private System.Data.DataColumn coldsRefraOTL3DataTableProtect_Use_Case;
        private System.Data.DataColumn coldsRefraOTL3DataTableDaub_Use_Case;
        private System.Data.DataColumn coldsRefraOTL3DataTableTranq_Case;
        private System.Data.DataColumn coldsRefraOTL3DataTableNote;
        private System.Data.DataColumn coldsRefraOTL3DataTableTeamID;
        private System.Data.DataColumn coldsRefraOTL3DataTableShiftID;
        private System.Data.DataColumn coldsRefraOTL3DataTableOperator;
        private System.Data.DataColumn coldsRefraOTL3DataTableTundishNO;
        private AppSvrHMI.L3DataSet dsRefraTFF;
        private System.Data.DataTable schemadsRefraTFF;
        private System.Data.DataColumn coldsRefraTFFL3DataTableGUID;
        private System.Data.DataColumn coldsRefraTFFL3DataTableName;
        private System.Data.DataColumn coldsRefraTFFL3DataTableInput_Time;
        private System.Data.DataColumn coldsRefraTFFL3DataTableTundishID;
        private System.Data.DataColumn coldsRefraTFFL3DataTableCast_ID;
        private System.Data.DataColumn coldsRefraTFFL3DataTableStop_Cast_Reason;
        private System.Data.DataColumn coldsRefraTFFL3DataTableDaub_Use_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableTranq_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableFrist_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableSec_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableThr_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableFor_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableFrist_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableSec_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableThr_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableFor_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableWard_Dregs_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableCover_Use_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableProtect_Use_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTablePro_Temp_Use_Case;
        private System.Data.DataColumn coldsRefraTFFL3DataTableNote;
        private System.Data.DataColumn coldsRefraTFFL3DataTableTeamID;
        private System.Data.DataColumn coldsRefraTFFL3DataTableShiftID;
        private System.Data.DataColumn coldsRefraTFFL3DataTableOperator;
        private System.Data.DataColumn coldsRefraTFFL3DataTableTundishNO;
        private AppSvrHMI.L3DataSet dsCoverCase;
        private System.Data.DataTable schemadsCoverCaseOT;
        private System.Data.DataColumn coldsCoverCaseOTL3DataTableCode;
        private System.Data.DataColumn coldsCoverCaseOTL3DataTableCode_Des;
        private System.Data.DataColumn coldsCoverCaseOTL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsDaubUseCase;
        private AppSvrHMI.L3DataSet dsTuckStickCase;
        private System.Data.DataTable schemadsDaubUseCaseOT;
        private System.Data.DataColumn coldsDaubUseCaseOTL3DataTableCode;
        private System.Data.DataColumn coldsDaubUseCaseOTL3DataTableCode_Des;
        private System.Data.DataColumn coldsDaubUseCaseOTL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsTuckStickCase;
        private System.Data.DataColumn coldsTuckStickCaseL3DataTableCode;
        private System.Data.DataColumn coldsTuckStickCaseL3DataTableCode_Des;
        private System.Data.DataColumn coldsTuckStickCaseL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingSource bsTuckStickCase1;
        private System.Windows.Forms.BindingSource bsTuckStickCase2;
        private System.Windows.Forms.BindingSource bsTuckStickCase3;
        private System.Windows.Forms.BindingSource bsTuckStickCase4;
        private AppSvrHMI.L3DataSet dsBigGapCase;
        private System.Data.DataTable schemadsBigGapCase;
        private System.Data.DataColumn coldsBigGapCaseL3DataTableCode;
        private System.Data.DataColumn coldsBigGapCaseL3DataTableCode_Des;
        private System.Data.DataColumn coldsBigGapCaseL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingSource bsBigGapCase2;
        private System.Windows.Forms.BindingSource bsBigGapCase1;
        private System.Windows.Forms.BindingSource bsBigGapCase4;
        private System.Windows.Forms.BindingSource bsBigGapCase3;
        private System.Windows.Forms.TabPage tabRefraTFF;
        private System.Windows.Forms.DataGridView dvRefraTFF;
        private System.Data.DataColumn coldsMagL3DataTableInstall_Start_Time;
        private System.Data.DataColumn coldsMagL3DataTableInstall_End_Time;
        private AppSvrHMI.L3DataSet dsDryMatFac;
        private System.Data.DataTable schemadsDryMatFac;
        private System.Data.DataColumn coldsDryMatFacL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsDaubFac;
        private System.Data.DataTable schemadsDaubFac;
        private System.Data.DataColumn coldsDaubFacL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsGluemudFac;
        private AppSvrHMI.L3DataSet dsGapBriFac;
        private System.Data.DataTable schemadsGluemudFac;
        private System.Data.DataColumn coldsGluemudFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsGapBriFac;
        private System.Data.DataColumn coldsGapBriFacL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsTranqFac;
        private System.Data.DataTable schemadsTranqFac;
        private System.Data.DataColumn coldsTranqFacL3DataTableMATFACTORY;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsStuStiFac;
        private System.Data.DataTable schemadsStuStiFac;
        private System.Data.DataColumn coldsStuStiFacL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsWardDregsFac;
        private System.Data.DataTable schemadsWardDregsFac;
        private System.Data.DataColumn coldsWardDregsFacL3DataTableMATFACTORY;
        private System.Windows.Forms.Panel pnlInnerBuild;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsStopCastingReason;
        private System.Data.DataTable schemadsStopCastingReason;
        private System.Data.DataColumn coldsStopCastingReasonL3DataTableCode;
        private System.Data.DataColumn coldsStopCastingReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsStopCastingReason1;
        private System.Windows.Forms.BindingSource bsStopCastingReason2;
        private System.Windows.Forms.ToolStripButton btnDataConfirm;
        private AppSvrHMI.L3DataSet dsProtect_Use_Case;
        private System.Data.DataTable schemadsProtect_Use_Case;
        private System.Data.DataColumn coldsProtect_Use_CaseL3DataTableCode;
        private System.Data.DataColumn coldsProtect_Use_CaseL3DataTableCode_Des;
        private System.Data.DataColumn coldsProtect_Use_CaseL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingSource bsProtect_Use_Case1;
        private System.Windows.Forms.BindingSource bsProtect_Use_Case2;
        private AppSvrHMI.L3DataSet dsWard_Dregs_Case;
        private System.Data.DataTable schemadsWard_Dregs_Case;
        private System.Data.DataColumn coldsWard_Dregs_CaseL3DataTableCode;
        private System.Data.DataColumn coldsWard_Dregs_CaseL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHoldTempMat_Use;
        private System.Data.DataTable schemadsHoldTempMat_Use;
        private System.Data.DataColumn coldsHoldTempMat_UseL3DataTableCode;
        private System.Data.DataColumn coldsHoldTempMat_UseL3DataTableCode_Des;
        private System.Data.DataColumn coldsMagL3DataTableConfirmFlag;
        private System.Windows.Forms.BindingSource bsCoverCaseOT;
        private System.Windows.Forms.BindingSource bsCoverCaseTFF;
        private System.Windows.Forms.BindingSource bsDaubUseCaseOT;
        private System.Windows.Forms.BindingSource bsDaubUseCaseTTF;
        private AppSvrHMI.L3DataSet dsSmoothBlock;
        private System.Data.DataTable schemadsSmoothBlock;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsGapFac;
        private System.Data.DataTable schemadsGapFac;
        private System.Data.DataColumn coldsGapFacL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsUpGapFac;
        private System.Data.DataTable schemadsUpGapFac;
        private System.Data.DataColumn coldsUpGapFacL3DataTableMatFactory;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableCrane_TeamID;
        private System.Windows.Forms.BindingSource bsOTHotCraneTeamID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableCrane_TeamID;
        private System.Windows.Forms.BindingSource bsTTFHotCraneTeamID;
        private PxDataValid.PxComboBox pxComboBox12;
        private System.Data.DataColumn coldsOTFireInfoL3DataTableVehicleID;
        private System.Data.DataColumn coldsTFFFireInfoL3DataTableVehicleID;
        private AppSvrHMI.L3DataSet dsInnerRefraFac;
        private System.Data.DataTable schemadsInnerRefraFac;
        private System.Data.DataColumn coldsInnerRefraFacL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsInnerRefraName;
        private System.Data.DataTable schemadsInnerRefraName;
        private System.Data.DataColumn coldsInnerRefraNameL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsProject;
        private System.Data.DataTable schemadsProject;
        private System.Data.DataColumn coldsProjectL3DataTableCode;
        private System.Data.DataColumn coldsProjectL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTranqCase;
        private System.Data.DataTable schemadsTranqCase;
        private System.Data.DataColumn coldsTranqCaseL3DataTableCode;
        private System.Data.DataColumn coldsTranqCaseL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TundishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerTieStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerTieEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerSmallFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerCloseFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daubStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daubEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fireStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fireEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Install_Start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Install_End_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotSmallStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotBigEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRefraOT;
        private System.Windows.Forms.BindingSource bsRefraTFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishNODataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn castIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn stopCastReasonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn daubUseCaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tranqCaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn fristTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn thrTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn forTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fristWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn thrWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn forWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wardDregsCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn coverUseCaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn protectUseCaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn proTempUseCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsAdjustTeam;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private PxDataValid.PxTextBox pxTextBox7;
        private System.Data.DataColumn coldsTFFInstallL3DataTableChecker;
        private System.Data.DataColumn coldsTFFInstallL3DataTableGUID;
        private System.Data.DataColumn coldsTFFInstallL3DataTableName;
        private System.Data.DataColumn coldsTFFInstallL3DataTableConfirm_Flag;
        private PxDataValid.PxTextBox pxTextBox8;
        private System.Windows.Forms.Label label93;
        private PxDataValid.PxTextBox pxTextBox9;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label101;
        private PxDataValid.PxTextBox pxTextBox10;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label104;
        private PxDataValid.PxTextBox pxTextBox12;
        private System.Windows.Forms.Label label103;
        private PxDataValid.PxTextBox pxTextBox11;
        private System.Data.DataColumn coldsTFFInstallL3DataTableTundish_Bottom_Insulation;
        private System.Data.DataColumn coldsTFFInstallL3DataTableUpper_Core;
        private System.Data.DataColumn coldsTFFInstallL3DataTableLower_Core;
        private System.Data.DataColumn coldsTFFInstallL3DataTableCore_Install_Per;
        private System.Data.DataColumn coldsTFFInstallL3DataTableTundish_Wall_Insulation;
    }
}