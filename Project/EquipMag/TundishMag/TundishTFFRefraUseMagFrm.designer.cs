namespace EquipMag.TundishMag
{
    partial class TundishTFFRefraUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishTFFRefraUseMagFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bsRefraUse = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefraUse = new AppSvrHMI.L3DataSet();
            this.schemadsRefraUse = new System.Data.DataTable();
            this.coldsRefraUseL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableStop_Cast_Reason = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableDaub_Use_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableTranq_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableFrist_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableSec_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableThr_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableFor_Tuck_Stick_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableFrist_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableSec_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableThr_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableFor_Water_Gap_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableWard_Dregs_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableCover_Use_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableProtect_Use_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTablePro_Temp_Use_Case = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableNote = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableOperator = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsRefraUseL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.inputTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopCastReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStopCastingReason = new AppSvrHMI.L3DataSet();
            this.schemadsStopCastingReason = new System.Data.DataTable();
            this.coldsStopCastingReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsStopCastingReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.daubUseCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDaubUseCase = new AppSvrHMI.L3DataSet();
            this.schemadsDaubUseCase = new System.Data.DataTable();
            this.coldsDaubUseCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsDaubUseCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.tranqCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTranqCase = new AppSvrHMI.L3DataSet();
            this.schemadsTranqCase = new System.Data.DataTable();
            this.coldsTranqCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsTranqCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.fristTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTuckStickCase = new AppSvrHMI.L3DataSet();
            this.schemadsTuckStickCase = new System.Data.DataTable();
            this.coldsTuckStickCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsTuckStickCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.secTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.thrTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.forTuckStickCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fristWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBigGapCase = new AppSvrHMI.L3DataSet();
            this.schemadsBigGapCase = new System.Data.DataTable();
            this.coldsBigGapCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsBigGapCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.secWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.thrWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.forWaterGapCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wardDregsCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWard_Dregs_Case = new AppSvrHMI.L3DataSet();
            this.schemadsWard_Dregs_Case = new System.Data.DataTable();
            this.coldsWard_Dregs_CaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsWard_Dregs_CaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coverUseCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCoverCase = new AppSvrHMI.L3DataSet();
            this.schemadsCoverCase = new System.Data.DataTable();
            this.coldsCoverCaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsCoverCaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.protectUseCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsProtect_Use_Case = new AppSvrHMI.L3DataSet();
            this.schemadsProtect_Use_Case = new System.Data.DataTable();
            this.coldsProtect_Use_CaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsProtect_Use_CaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.proTempUseCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHoldTempMat_Use = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTempMat_Use = new System.Data.DataTable();
            this.coldsHoldTempMat_UseL3DataTableCode = new System.Data.DataColumn();
            this.coldsHoldTempMat_UseL3DataTableCode_Des = new System.Data.DataColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnRefraUse = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraUse)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopCastingReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopCastingReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubUseCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubUseCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuckStickCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuckStickCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWard_Dregs_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWard_Dregs_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtect_Use_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtect_Use_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat_Use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat_Use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRefraUse)).BeginInit();
            this.bnRefraUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "/ 0";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel4.Text = " ****信息 ";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到第一条记录";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到上一条记录";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Enabled = false;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到下一条记录";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Enabled = false;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到最后一条记录";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "  ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton1.Text = "退出";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(71, 40);
            this.toolStripButton3.Text = "功能1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton4.Text = "确认";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton5.Text = "取消";
            // 
            // bsRefraUse
            // 
            this.bsRefraUse.DataMember = "L3DataTable";
            this.bsRefraUse.DataSource = this.dsRefraUse;
            // 
            // dsRefraUse
            // 
            this.dsRefraUse.AutoLoad = true;
            this.dsRefraUse.AutoSubscribe = false;
            this.dsRefraUse.DataSetName = "L3DataSet";
            this.dsRefraUse.DeleteMethod = "";
            this.dsRefraUse.InsertMethod = "";
            this.dsRefraUse.L3DataAdapter = this.Adapter;
            this.dsRefraUse.LoadEvent = "";
            this.dsRefraUse.LoadTrigger = null;
            this.dsRefraUse.RefreshValve = 1000;
            this.dsRefraUse.SourceCommand = null;
            this.dsRefraUse.SourceCondition = "1=2";
            this.dsRefraUse.SourceMethod = "";
            this.dsRefraUse.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraUse.SourceURI = "XGMESLogic\\TundishMag\\CTundish_TFF_Refra_Use";
            this.dsRefraUse.SubscribeTarget = null;
            this.dsRefraUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraUse});
            this.dsRefraUse.UpdateEvent = "";
            this.dsRefraUse.UpdateMethod = "";
            this.dsRefraUse.UpdateTrigger = null;
            // 
            // schemadsRefraUse
            // 
            this.schemadsRefraUse.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraUseL3DataTableInput_Time,
            this.coldsRefraUseL3DataTableTundishID,
            this.coldsRefraUseL3DataTableCast_ID,
            this.coldsRefraUseL3DataTableStop_Cast_Reason,
            this.coldsRefraUseL3DataTableDaub_Use_Case,
            this.coldsRefraUseL3DataTableTranq_Case,
            this.coldsRefraUseL3DataTableFrist_Tuck_Stick_Case,
            this.coldsRefraUseL3DataTableSec_Tuck_Stick_Case,
            this.coldsRefraUseL3DataTableThr_Tuck_Stick_Case,
            this.coldsRefraUseL3DataTableFor_Tuck_Stick_Case,
            this.coldsRefraUseL3DataTableFrist_Water_Gap_Case,
            this.coldsRefraUseL3DataTableSec_Water_Gap_Case,
            this.coldsRefraUseL3DataTableThr_Water_Gap_Case,
            this.coldsRefraUseL3DataTableFor_Water_Gap_Case,
            this.coldsRefraUseL3DataTableWard_Dregs_Case,
            this.coldsRefraUseL3DataTableCover_Use_Case,
            this.coldsRefraUseL3DataTableProtect_Use_Case,
            this.coldsRefraUseL3DataTablePro_Temp_Use_Case,
            this.coldsRefraUseL3DataTableNote,
            this.coldsRefraUseL3DataTableTeamID,
            this.coldsRefraUseL3DataTableShiftID,
            this.coldsRefraUseL3DataTableOperator,
            this.coldsRefraUseL3DataTableTundishNO,
            this.coldsRefraUseL3DataTableConfirm_Flag});
            this.schemadsRefraUse.TableName = "L3DataTable";
            // 
            // coldsRefraUseL3DataTableInput_Time
            // 
            this.coldsRefraUseL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsRefraUseL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsRefraUseL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsRefraUseL3DataTableInput_Time.Namespace = "";
            // 
            // coldsRefraUseL3DataTableTundishID
            // 
            this.coldsRefraUseL3DataTableTundishID.Caption = "TundishID";
            this.coldsRefraUseL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsRefraUseL3DataTableTundishID.Namespace = "";
            // 
            // coldsRefraUseL3DataTableCast_ID
            // 
            this.coldsRefraUseL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsRefraUseL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsRefraUseL3DataTableCast_ID.Namespace = "";
            // 
            // coldsRefraUseL3DataTableStop_Cast_Reason
            // 
            this.coldsRefraUseL3DataTableStop_Cast_Reason.Caption = "Stop_Cast_Reason";
            this.coldsRefraUseL3DataTableStop_Cast_Reason.ColumnName = "Stop_Cast_Reason";
            this.coldsRefraUseL3DataTableStop_Cast_Reason.Namespace = "";
            // 
            // coldsRefraUseL3DataTableDaub_Use_Case
            // 
            this.coldsRefraUseL3DataTableDaub_Use_Case.Caption = "Daub_Use_Case";
            this.coldsRefraUseL3DataTableDaub_Use_Case.ColumnName = "Daub_Use_Case";
            this.coldsRefraUseL3DataTableDaub_Use_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableTranq_Case
            // 
            this.coldsRefraUseL3DataTableTranq_Case.Caption = "Tranq_Case";
            this.coldsRefraUseL3DataTableTranq_Case.ColumnName = "Tranq_Case";
            this.coldsRefraUseL3DataTableTranq_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableFrist_Tuck_Stick_Case
            // 
            this.coldsRefraUseL3DataTableFrist_Tuck_Stick_Case.Caption = "Frist_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableFrist_Tuck_Stick_Case.ColumnName = "Frist_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableFrist_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableSec_Tuck_Stick_Case
            // 
            this.coldsRefraUseL3DataTableSec_Tuck_Stick_Case.Caption = "Sec_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableSec_Tuck_Stick_Case.ColumnName = "Sec_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableSec_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableThr_Tuck_Stick_Case
            // 
            this.coldsRefraUseL3DataTableThr_Tuck_Stick_Case.Caption = "Thr_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableThr_Tuck_Stick_Case.ColumnName = "Thr_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableThr_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableFor_Tuck_Stick_Case
            // 
            this.coldsRefraUseL3DataTableFor_Tuck_Stick_Case.Caption = "For_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableFor_Tuck_Stick_Case.ColumnName = "For_Tuck_Stick_Case";
            this.coldsRefraUseL3DataTableFor_Tuck_Stick_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableFrist_Water_Gap_Case
            // 
            this.coldsRefraUseL3DataTableFrist_Water_Gap_Case.Caption = "Frist_Water_Gap_Case";
            this.coldsRefraUseL3DataTableFrist_Water_Gap_Case.ColumnName = "Frist_Water_Gap_Case";
            this.coldsRefraUseL3DataTableFrist_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableSec_Water_Gap_Case
            // 
            this.coldsRefraUseL3DataTableSec_Water_Gap_Case.Caption = "Sec_Water_Gap_Case";
            this.coldsRefraUseL3DataTableSec_Water_Gap_Case.ColumnName = "Sec_Water_Gap_Case";
            this.coldsRefraUseL3DataTableSec_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableThr_Water_Gap_Case
            // 
            this.coldsRefraUseL3DataTableThr_Water_Gap_Case.Caption = "Thr_Water_Gap_Case";
            this.coldsRefraUseL3DataTableThr_Water_Gap_Case.ColumnName = "Thr_Water_Gap_Case";
            this.coldsRefraUseL3DataTableThr_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableFor_Water_Gap_Case
            // 
            this.coldsRefraUseL3DataTableFor_Water_Gap_Case.Caption = "For_Water_Gap_Case";
            this.coldsRefraUseL3DataTableFor_Water_Gap_Case.ColumnName = "For_Water_Gap_Case";
            this.coldsRefraUseL3DataTableFor_Water_Gap_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableWard_Dregs_Case
            // 
            this.coldsRefraUseL3DataTableWard_Dregs_Case.Caption = "Ward_Dregs_Case";
            this.coldsRefraUseL3DataTableWard_Dregs_Case.ColumnName = "Ward_Dregs_Case";
            this.coldsRefraUseL3DataTableWard_Dregs_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableCover_Use_Case
            // 
            this.coldsRefraUseL3DataTableCover_Use_Case.Caption = "Cover_Use_Case";
            this.coldsRefraUseL3DataTableCover_Use_Case.ColumnName = "Cover_Use_Case";
            this.coldsRefraUseL3DataTableCover_Use_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableProtect_Use_Case
            // 
            this.coldsRefraUseL3DataTableProtect_Use_Case.Caption = "Protect_Use_Case";
            this.coldsRefraUseL3DataTableProtect_Use_Case.ColumnName = "Protect_Use_Case";
            this.coldsRefraUseL3DataTableProtect_Use_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTablePro_Temp_Use_Case
            // 
            this.coldsRefraUseL3DataTablePro_Temp_Use_Case.Caption = "Pro_Temp_Use_Case";
            this.coldsRefraUseL3DataTablePro_Temp_Use_Case.ColumnName = "Pro_Temp_Use_Case";
            this.coldsRefraUseL3DataTablePro_Temp_Use_Case.Namespace = "";
            // 
            // coldsRefraUseL3DataTableNote
            // 
            this.coldsRefraUseL3DataTableNote.Caption = "Note";
            this.coldsRefraUseL3DataTableNote.ColumnName = "Note";
            this.coldsRefraUseL3DataTableNote.Namespace = "";
            // 
            // coldsRefraUseL3DataTableTeamID
            // 
            this.coldsRefraUseL3DataTableTeamID.Caption = "TeamID";
            this.coldsRefraUseL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsRefraUseL3DataTableTeamID.Namespace = "";
            // 
            // coldsRefraUseL3DataTableShiftID
            // 
            this.coldsRefraUseL3DataTableShiftID.Caption = "ShiftID";
            this.coldsRefraUseL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsRefraUseL3DataTableShiftID.Namespace = "";
            // 
            // coldsRefraUseL3DataTableOperator
            // 
            this.coldsRefraUseL3DataTableOperator.Caption = "Operator";
            this.coldsRefraUseL3DataTableOperator.ColumnName = "Operator";
            this.coldsRefraUseL3DataTableOperator.Namespace = "";
            // 
            // coldsRefraUseL3DataTableTundishNO
            // 
            this.coldsRefraUseL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsRefraUseL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsRefraUseL3DataTableTundishNO.Namespace = "";
            // 
            // coldsRefraUseL3DataTableConfirm_Flag
            // 
            this.coldsRefraUseL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsRefraUseL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsRefraUseL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsRefraUseL3DataTableConfirm_Flag.Namespace = "";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Controls.Add(this.bnRefraUse);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 700);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inputTimeDataGridViewTextBoxColumn,
            this.tundishIDDataGridViewTextBoxColumn,
            this.castIDDataGridViewTextBoxColumn,
            this.tundishNODataGridViewTextBoxColumn,
            this.stopCastReasonDataGridViewTextBoxColumn,
            this.daubUseCaseDataGridViewTextBoxColumn,
            this.tranqCaseDataGridViewTextBoxColumn,
            this.fristTuckStickCaseDataGridViewTextBoxColumn,
            this.secTuckStickCaseDataGridViewTextBoxColumn,
            this.thrTuckStickCaseDataGridViewTextBoxColumn,
            this.forTuckStickCaseDataGridViewTextBoxColumn,
            this.fristWaterGapCaseDataGridViewTextBoxColumn,
            this.secWaterGapCaseDataGridViewTextBoxColumn,
            this.thrWaterGapCaseDataGridViewTextBoxColumn,
            this.forWaterGapCaseDataGridViewTextBoxColumn,
            this.wardDregsCaseDataGridViewTextBoxColumn,
            this.coverUseCaseDataGridViewTextBoxColumn,
            this.protectUseCaseDataGridViewTextBoxColumn,
            this.proTempUseCaseDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsRefraUse;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 25);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 675);
            this.dvM.TabIndex = 32;
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // inputTimeDataGridViewTextBoxColumn
            // 
            this.inputTimeDataGridViewTextBoxColumn.DataPropertyName = "Input_Time";
            this.inputTimeDataGridViewTextBoxColumn.Frozen = true;
            this.inputTimeDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.inputTimeDataGridViewTextBoxColumn.Name = "inputTimeDataGridViewTextBoxColumn";
            this.inputTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.inputTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // tundishIDDataGridViewTextBoxColumn
            // 
            this.tundishIDDataGridViewTextBoxColumn.DataPropertyName = "TundishID";
            this.tundishIDDataGridViewTextBoxColumn.Frozen = true;
            this.tundishIDDataGridViewTextBoxColumn.HeaderText = "中包号";
            this.tundishIDDataGridViewTextBoxColumn.Name = "tundishIDDataGridViewTextBoxColumn";
            this.tundishIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // castIDDataGridViewTextBoxColumn
            // 
            this.castIDDataGridViewTextBoxColumn.DataPropertyName = "Cast_ID";
            this.castIDDataGridViewTextBoxColumn.Frozen = true;
            this.castIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.castIDDataGridViewTextBoxColumn.Name = "castIDDataGridViewTextBoxColumn";
            this.castIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.castIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // tundishNODataGridViewTextBoxColumn
            // 
            this.tundishNODataGridViewTextBoxColumn.DataPropertyName = "TundishNO";
            this.tundishNODataGridViewTextBoxColumn.Frozen = true;
            this.tundishNODataGridViewTextBoxColumn.HeaderText = "包次号";
            this.tundishNODataGridViewTextBoxColumn.Name = "tundishNODataGridViewTextBoxColumn";
            this.tundishNODataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishNODataGridViewTextBoxColumn.Width = 66;
            // 
            // stopCastReasonDataGridViewTextBoxColumn
            // 
            this.stopCastReasonDataGridViewTextBoxColumn.DataPropertyName = "Stop_Cast_Reason";
            this.stopCastReasonDataGridViewTextBoxColumn.DataSource = this.dsStopCastingReason;
            this.stopCastReasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.stopCastReasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stopCastReasonDataGridViewTextBoxColumn.HeaderText = "停浇原因";
            this.stopCastReasonDataGridViewTextBoxColumn.Name = "stopCastReasonDataGridViewTextBoxColumn";
            this.stopCastReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.stopCastReasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stopCastReasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stopCastReasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.stopCastReasonDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsStopCastingReason
            // 
            this.dsStopCastingReason.AutoLoad = true;
            this.dsStopCastingReason.AutoSubscribe = false;
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
            // daubUseCaseDataGridViewTextBoxColumn
            // 
            this.daubUseCaseDataGridViewTextBoxColumn.DataPropertyName = "Daub_Use_Case";
            this.daubUseCaseDataGridViewTextBoxColumn.DataSource = this.dsDaubUseCase;
            this.daubUseCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.daubUseCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.daubUseCaseDataGridViewTextBoxColumn.HeaderText = "涂抹(干振)料使用情况";
            this.daubUseCaseDataGridViewTextBoxColumn.Name = "daubUseCaseDataGridViewTextBoxColumn";
            this.daubUseCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.daubUseCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.daubUseCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.daubUseCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.daubUseCaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // dsDaubUseCase
            // 
            this.dsDaubUseCase.AutoLoad = true;
            this.dsDaubUseCase.AutoSubscribe = false;
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
            this.schemadsDaubUseCase});
            this.dsDaubUseCase.UpdateEvent = "Click";
            this.dsDaubUseCase.UpdateMethod = null;
            this.dsDaubUseCase.UpdateTrigger = null;
            // 
            // schemadsDaubUseCase
            // 
            this.schemadsDaubUseCase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDaubUseCaseL3DataTableCode,
            this.coldsDaubUseCaseL3DataTableCode_Des});
            this.schemadsDaubUseCase.TableName = "L3DataTable";
            // 
            // coldsDaubUseCaseL3DataTableCode
            // 
            this.coldsDaubUseCaseL3DataTableCode.Caption = "Code";
            this.coldsDaubUseCaseL3DataTableCode.ColumnName = "Code";
            this.coldsDaubUseCaseL3DataTableCode.Namespace = "";
            // 
            // coldsDaubUseCaseL3DataTableCode_Des
            // 
            this.coldsDaubUseCaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDaubUseCaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDaubUseCaseL3DataTableCode_Des.Namespace = "";
            // 
            // tranqCaseDataGridViewTextBoxColumn
            // 
            this.tranqCaseDataGridViewTextBoxColumn.DataPropertyName = "Tranq_Case";
            this.tranqCaseDataGridViewTextBoxColumn.DataSource = this.dsTranqCase;
            this.tranqCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tranqCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tranqCaseDataGridViewTextBoxColumn.HeaderText = "紊流器使用情况";
            this.tranqCaseDataGridViewTextBoxColumn.Name = "tranqCaseDataGridViewTextBoxColumn";
            this.tranqCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.tranqCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tranqCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tranqCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tranqCaseDataGridViewTextBoxColumn.Width = 114;
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
            // fristTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Frist_Tuck_Stick_Case";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.dsTuckStickCase;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "1流塞棒使用情况";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Name = "fristTuckStickCaseDataGridViewTextBoxColumn";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fristTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.fristTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // dsTuckStickCase
            // 
            this.dsTuckStickCase.AutoLoad = true;
            this.dsTuckStickCase.AutoSubscribe = false;
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
            this.coldsTuckStickCaseL3DataTableCode_Des});
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
            // secTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.secTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Sec_Tuck_Stick_Case";
            this.secTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.dsTuckStickCase;
            this.secTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.secTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.secTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "2流塞棒使用情况";
            this.secTuckStickCaseDataGridViewTextBoxColumn.Name = "secTuckStickCaseDataGridViewTextBoxColumn";
            this.secTuckStickCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.secTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.secTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // thrTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "Thr_Tuck_Stick_Case";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.dsTuckStickCase;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "3流塞棒使用情况";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Name = "thrTuckStickCaseDataGridViewTextBoxColumn";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thrTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.thrTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // forTuckStickCaseDataGridViewTextBoxColumn
            // 
            this.forTuckStickCaseDataGridViewTextBoxColumn.DataPropertyName = "For_Tuck_Stick_Case";
            this.forTuckStickCaseDataGridViewTextBoxColumn.DataSource = this.dsTuckStickCase;
            this.forTuckStickCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.forTuckStickCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.forTuckStickCaseDataGridViewTextBoxColumn.HeaderText = "4流塞棒使用情况";
            this.forTuckStickCaseDataGridViewTextBoxColumn.Name = "forTuckStickCaseDataGridViewTextBoxColumn";
            this.forTuckStickCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.forTuckStickCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.forTuckStickCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.forTuckStickCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.forTuckStickCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // fristWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Frist_Water_Gap_Case";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.dsBigGapCase;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "1流水口使用情况";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Name = "fristWaterGapCaseDataGridViewTextBoxColumn";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fristWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.fristWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // dsBigGapCase
            // 
            this.dsBigGapCase.AutoLoad = true;
            this.dsBigGapCase.AutoSubscribe = false;
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
            this.coldsBigGapCaseL3DataTableCode_Des});
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
            // secWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.secWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Sec_Water_Gap_Case";
            this.secWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.dsBigGapCase;
            this.secWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.secWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.secWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "2流水口使用情况";
            this.secWaterGapCaseDataGridViewTextBoxColumn.Name = "secWaterGapCaseDataGridViewTextBoxColumn";
            this.secWaterGapCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.secWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.secWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.secWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.secWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // thrWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "Thr_Water_Gap_Case";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.dsBigGapCase;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "3流水口使用情况";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Name = "thrWaterGapCaseDataGridViewTextBoxColumn";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thrWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.thrWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // forWaterGapCaseDataGridViewTextBoxColumn
            // 
            this.forWaterGapCaseDataGridViewTextBoxColumn.DataPropertyName = "For_Water_Gap_Case";
            this.forWaterGapCaseDataGridViewTextBoxColumn.DataSource = this.dsBigGapCase;
            this.forWaterGapCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.forWaterGapCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.forWaterGapCaseDataGridViewTextBoxColumn.HeaderText = "4流水口使用情况";
            this.forWaterGapCaseDataGridViewTextBoxColumn.Name = "forWaterGapCaseDataGridViewTextBoxColumn";
            this.forWaterGapCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.forWaterGapCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.forWaterGapCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.forWaterGapCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.forWaterGapCaseDataGridViewTextBoxColumn.Width = 120;
            // 
            // wardDregsCaseDataGridViewTextBoxColumn
            // 
            this.wardDregsCaseDataGridViewTextBoxColumn.DataPropertyName = "Ward_Dregs_Case";
            this.wardDregsCaseDataGridViewTextBoxColumn.DataSource = this.dsWard_Dregs_Case;
            this.wardDregsCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wardDregsCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wardDregsCaseDataGridViewTextBoxColumn.HeaderText = "挡渣墙使用情况";
            this.wardDregsCaseDataGridViewTextBoxColumn.Name = "wardDregsCaseDataGridViewTextBoxColumn";
            this.wardDregsCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.wardDregsCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wardDregsCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wardDregsCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.wardDregsCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsWard_Dregs_Case
            // 
            this.dsWard_Dregs_Case.AutoLoad = true;
            this.dsWard_Dregs_Case.AutoSubscribe = false;
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
            // coverUseCaseDataGridViewTextBoxColumn
            // 
            this.coverUseCaseDataGridViewTextBoxColumn.DataPropertyName = "Cover_Use_Case";
            this.coverUseCaseDataGridViewTextBoxColumn.DataSource = this.dsCoverCase;
            this.coverUseCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.coverUseCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.coverUseCaseDataGridViewTextBoxColumn.HeaderText = "覆盖剂使用情况";
            this.coverUseCaseDataGridViewTextBoxColumn.Name = "coverUseCaseDataGridViewTextBoxColumn";
            this.coverUseCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.coverUseCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coverUseCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coverUseCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.coverUseCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsCoverCase
            // 
            this.dsCoverCase.AutoLoad = true;
            this.dsCoverCase.AutoSubscribe = false;
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
            this.schemadsCoverCase});
            this.dsCoverCase.UpdateEvent = "Click";
            this.dsCoverCase.UpdateMethod = null;
            this.dsCoverCase.UpdateTrigger = null;
            // 
            // schemadsCoverCase
            // 
            this.schemadsCoverCase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCoverCaseL3DataTableCode,
            this.coldsCoverCaseL3DataTableCode_Des});
            this.schemadsCoverCase.TableName = "L3DataTable";
            // 
            // coldsCoverCaseL3DataTableCode
            // 
            this.coldsCoverCaseL3DataTableCode.Caption = "Code";
            this.coldsCoverCaseL3DataTableCode.ColumnName = "Code";
            this.coldsCoverCaseL3DataTableCode.Namespace = "";
            // 
            // coldsCoverCaseL3DataTableCode_Des
            // 
            this.coldsCoverCaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCoverCaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCoverCaseL3DataTableCode_Des.Namespace = "";
            // 
            // protectUseCaseDataGridViewTextBoxColumn
            // 
            this.protectUseCaseDataGridViewTextBoxColumn.DataPropertyName = "Protect_Use_Case";
            this.protectUseCaseDataGridViewTextBoxColumn.DataSource = this.dsProtect_Use_Case;
            this.protectUseCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.protectUseCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.protectUseCaseDataGridViewTextBoxColumn.HeaderText = "保护渣使用情况";
            this.protectUseCaseDataGridViewTextBoxColumn.Name = "protectUseCaseDataGridViewTextBoxColumn";
            this.protectUseCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.protectUseCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.protectUseCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.protectUseCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.protectUseCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsProtect_Use_Case
            // 
            this.dsProtect_Use_Case.AutoLoad = true;
            this.dsProtect_Use_Case.AutoSubscribe = false;
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
            this.coldsProtect_Use_CaseL3DataTableCode_Des});
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
            // proTempUseCaseDataGridViewTextBoxColumn
            // 
            this.proTempUseCaseDataGridViewTextBoxColumn.DataPropertyName = "Pro_Temp_Use_Case";
            this.proTempUseCaseDataGridViewTextBoxColumn.DataSource = this.dsHoldTempMat_Use;
            this.proTempUseCaseDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.proTempUseCaseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.proTempUseCaseDataGridViewTextBoxColumn.HeaderText = "保温剂使用情况";
            this.proTempUseCaseDataGridViewTextBoxColumn.Name = "proTempUseCaseDataGridViewTextBoxColumn";
            this.proTempUseCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.proTempUseCaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proTempUseCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.proTempUseCaseDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.proTempUseCaseDataGridViewTextBoxColumn.Width = 114;
            // 
            // dsHoldTempMat_Use
            // 
            this.dsHoldTempMat_Use.AutoLoad = true;
            this.dsHoldTempMat_Use.AutoSubscribe = false;
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
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
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
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
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
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "过程异常说明";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 102;
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
            // bnRefraUse
            // 
            this.bnRefraUse.AddNewItem = null;
            this.bnRefraUse.AutoSize = false;
            this.bnRefraUse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnRefraUse.BackgroundImage")));
            this.bnRefraUse.BindingSource = this.bsRefraUse;
            this.bnRefraUse.CountItem = this.bindingNavigatorCountItem;
            this.bnRefraUse.DeleteItem = null;
            this.bnRefraUse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel6,
            this.dtEnd,
            this.toolStripLabel7,
            this.dtStart,
            this.toolStripLabel8,
            this.cmbTundishID,
            this.toolStripLabel9,
            this.btnOutput});
            this.bnRefraUse.Location = new System.Drawing.Point(0, 0);
            this.bnRefraUse.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnRefraUse.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnRefraUse.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnRefraUse.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnRefraUse.Name = "bnRefraUse";
            this.bnRefraUse.PositionItem = this.bindingNavigatorPositionItem;
            this.bnRefraUse.Size = new System.Drawing.Size(1000, 25);
            this.bnRefraUse.TabIndex = 31;
            this.bnRefraUse.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel6.Text = " ";
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
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel7.Text = "-";
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
            // toolStripLabel8
            // 
            this.toolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel8.Text = "录入日期:";
            // 
            // cmbTundishID
            // 
            this.cmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTundishID.Name = "cmbTundishID";
            this.cmbTundishID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel9.Text = "中包号:";
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
            // dsTundishID
            // 
            this.dsTundishID.AutoLoad = true;
            this.dsTundishID.AutoSubscribe = false;
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
            // TundishTFFRefraUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishTFFRefraUseMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "3/4/5/7#铸机中包耐材使用实绩管理";
            this.Text = "耐材使用实绩管理";
            this.Load += new System.EventHandler(this.TundishTFFRefraUseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRefraUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraUse)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopCastingReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopCastingReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaubUseCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaubUseCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTranqCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTranqCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuckStickCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuckStickCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWard_Dregs_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWard_Dregs_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtect_Use_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtect_Use_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat_Use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat_Use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRefraUse)).EndInit();
            this.bnRefraUse.ResumeLayout(false);
            this.bnRefraUse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource bsRefraUse;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.BindingNavigator bnRefraUse;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsRefraUse;
        private System.Data.DataTable schemadsRefraUse;
        private System.Data.DataColumn coldsRefraUseL3DataTableInput_Time;
        private System.Data.DataColumn coldsRefraUseL3DataTableTundishID;
        private System.Data.DataColumn coldsRefraUseL3DataTableCast_ID;
        private System.Data.DataColumn coldsRefraUseL3DataTableStop_Cast_Reason;
        private System.Data.DataColumn coldsRefraUseL3DataTableDaub_Use_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableTranq_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableFrist_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableSec_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableThr_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableFor_Tuck_Stick_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableFrist_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableSec_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableThr_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableFor_Water_Gap_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableWard_Dregs_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableCover_Use_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableProtect_Use_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTablePro_Temp_Use_Case;
        private System.Data.DataColumn coldsRefraUseL3DataTableNote;
        private System.Data.DataColumn coldsRefraUseL3DataTableTeamID;
        private System.Data.DataColumn coldsRefraUseL3DataTableShiftID;
        private System.Data.DataColumn coldsRefraUseL3DataTableOperator;
        private System.Data.DataColumn coldsRefraUseL3DataTableTundishNO;
        private System.Data.DataColumn coldsRefraUseL3DataTableConfirm_Flag;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private AppSvrHMI.L3DataSet dsStopCastingReason;
        private System.Data.DataTable schemadsStopCastingReason;
        private System.Data.DataColumn coldsStopCastingReasonL3DataTableCode;
        private System.Data.DataColumn coldsStopCastingReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsProtect_Use_Case;
        private AppSvrHMI.L3DataSet dsDaubUseCase;
        private AppSvrHMI.L3DataSet dsCoverCase;
        private AppSvrHMI.L3DataSet dsTuckStickCase;
        private AppSvrHMI.L3DataSet dsBigGapCase;
        private AppSvrHMI.L3DataSet dsWard_Dregs_Case;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsProtect_Use_Case;
        private System.Data.DataColumn coldsProtect_Use_CaseL3DataTableCode;
        private System.Data.DataColumn coldsProtect_Use_CaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsDaubUseCase;
        private System.Data.DataColumn coldsDaubUseCaseL3DataTableCode;
        private System.Data.DataColumn coldsDaubUseCaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsCoverCase;
        private System.Data.DataColumn coldsCoverCaseL3DataTableCode;
        private System.Data.DataColumn coldsCoverCaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsTuckStickCase;
        private System.Data.DataColumn coldsTuckStickCaseL3DataTableCode;
        private System.Data.DataColumn coldsTuckStickCaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsBigGapCase;
        private System.Data.DataColumn coldsBigGapCaseL3DataTableCode;
        private System.Data.DataColumn coldsBigGapCaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsWard_Dregs_Case;
        private System.Data.DataColumn coldsWard_Dregs_CaseL3DataTableCode;
        private System.Data.DataColumn coldsWard_Dregs_CaseL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private AppSvrHMI.L3DataSet dsTranqCase;
        private System.Data.DataTable schemadsTranqCase;
        private System.Data.DataColumn coldsTranqCaseL3DataTableCode;
        private System.Data.DataColumn coldsTranqCaseL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHoldTempMat_Use;
        private System.Data.DataTable schemadsHoldTempMat_Use;
        private System.Data.DataColumn coldsHoldTempMat_UseL3DataTableCode;
        private System.Data.DataColumn coldsHoldTempMat_UseL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stopCastReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn daubUseCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tranqCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fristTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn thrTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn forTuckStickCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fristWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn secWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn thrWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn forWaterGapCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wardDregsCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn coverUseCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn protectUseCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn proTempUseCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}