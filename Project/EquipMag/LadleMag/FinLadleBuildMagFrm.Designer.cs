namespace EquipMag.LadleMag
{
    partial class FinLadleBuildMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinLadleBuildMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableWORKID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_START_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_END_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableBREATHE_BRI_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableBREATHE_BRI_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableBRICKLAYING_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableWALL_REFR_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableWALL_REFR_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableSPI_CAST_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableSPI_CAST_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLE_INNER_CHECKER = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT = new System.Data.DataColumn();
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUTTOM_BUILDER = new System.Data.DataColumn();
            this.coldsMainL3DataTableWALL_BUILDER = new System.Data.DataColumn();
            this.coldsMainL3DataTableLINE_REFE_BUILDER = new System.Data.DataColumn();
            this.coldsMainL3DataTableREP_LADLE_BOT = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableTHR_LADLE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.cmdDetail = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCHAID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBREATHE_BRI_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBREATHE_BRI_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSPI_CAST_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSPI_CAST_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBUTTOM_BUILDER = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWALL_BUILDER = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREP_LADLE_BOT = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTHR_LADLE_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCha_Dre_Lin_Per = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast = new System.Data.DataColumn();
            this.coldsDetailL3DataTableObject_ID = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIFACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPICASTFACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPICASTWASTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cha_Dre_Lin_Per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cha_Dre_Lin_Wast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHRLADLETIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdNP = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmDetail = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDetail = new System.Windows.Forms.ToolStripButton();
            this.btnQueryDetail = new System.Windows.Forms.ToolStripButton();
            this.tSpM = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddMain = new System.Windows.Forms.ToolStripButton();
            this.btnDelMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmMain = new System.Windows.Forms.ToolStripButton();
            this.btnCancelMain = new System.Windows.Forms.ToolStripButton();
            this.btnExlMain = new System.Windows.Forms.ToolStripButton();
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
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
            this.cmbLadleID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataConfirm = new System.Windows.Forms.ToolStripButton();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRICKLAYINGFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTPROREFRWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wALLREFRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wALLREFRWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPICASTFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPICASTWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUTTOMBUILDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wALLBUILDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINEREFEBUILDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPLADLEBOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHRLADLETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).BeginInit();
            this.bdNP.SuspendLayout();
            this.tSpM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
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
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            this.bsMain.CurrentChanged += new System.EventHandler(this.bsMain_CurrentChanged);
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteFinBuildInfos";
            this.dsMain.InsertMethod = "InsertFinBuildInfos";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "GetFinBuildInfos";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = "UpdateFinBuildInfos";
            this.dsMain.UpdateTrigger = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.l3CommandParameter1);
            this.cmdMain.ReturnTarget = null;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
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
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableWORKID,
            this.coldsMainL3DataTableLADLEID,
            this.coldsMainL3DataTableBUILD_START_TIME,
            this.coldsMainL3DataTableBUILD_END_TIME,
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC,
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST,
            this.coldsMainL3DataTableBREATHE_BRI_FAC,
            this.coldsMainL3DataTableBREATHE_BRI_WAST,
            this.coldsMainL3DataTableBRICKLAYING_FAC,
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME,
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST,
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME,
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST,
            this.coldsMainL3DataTableWALL_REFR_NAME,
            this.coldsMainL3DataTableWALL_REFR_WAST,
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME,
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST,
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC,
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST,
            this.coldsMainL3DataTableSPI_CAST_FAC,
            this.coldsMainL3DataTableSPI_CAST_WAST,
            this.coldsMainL3DataTableLADLE_INNER_CHECKER,
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT,
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER,
            this.coldsMainL3DataTableBUTTOM_BUILDER,
            this.coldsMainL3DataTableWALL_BUILDER,
            this.coldsMainL3DataTableLINE_REFE_BUILDER,
            this.coldsMainL3DataTableREP_LADLE_BOT,
            this.coldsMainL3DataTableFIRE_START_TIME,
            this.coldsMainL3DataTableFIRE_END_TIME,
            this.coldsMainL3DataTableTHR_LADLE_TIME,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
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
            // coldsMainL3DataTableWORKID
            // 
            this.coldsMainL3DataTableWORKID.Caption = "WORKID";
            this.coldsMainL3DataTableWORKID.ColumnName = "WORKID";
            this.coldsMainL3DataTableWORKID.DefaultValue = "";
            this.coldsMainL3DataTableWORKID.Namespace = "";
            // 
            // coldsMainL3DataTableLADLEID
            // 
            this.coldsMainL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsMainL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsMainL3DataTableLADLEID.DefaultValue = "";
            this.coldsMainL3DataTableLADLEID.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_START_TIME
            // 
            this.coldsMainL3DataTableBUILD_START_TIME.Caption = "BUILD_START_TIME";
            this.coldsMainL3DataTableBUILD_START_TIME.ColumnName = "BUILD_START_TIME";
            this.coldsMainL3DataTableBUILD_START_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBUILD_START_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_END_TIME
            // 
            this.coldsMainL3DataTableBUILD_END_TIME.Caption = "BUILD_END_TIME";
            this.coldsMainL3DataTableBUILD_END_TIME.ColumnName = "BUILD_END_TIME";
            this.coldsMainL3DataTableBUILD_END_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBUILD_END_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableWATER_GAP_BRI_FAC
            // 
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC.Caption = "WATER_GAP_BRI_FAC";
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC.ColumnName = "WATER_GAP_BRI_FAC";
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC.DefaultValue = "";
            this.coldsMainL3DataTableWATER_GAP_BRI_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableWATER_GAP_BRI_WAST
            // 
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST.Caption = "WATER_GAP_BRI_WAST";
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST.ColumnName = "WATER_GAP_BRI_WAST";
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableWATER_GAP_BRI_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableBREATHE_BRI_FAC
            // 
            this.coldsMainL3DataTableBREATHE_BRI_FAC.Caption = "BREATHE_BRI_FAC";
            this.coldsMainL3DataTableBREATHE_BRI_FAC.ColumnName = "BREATHE_BRI_FAC";
            this.coldsMainL3DataTableBREATHE_BRI_FAC.DefaultValue = "";
            this.coldsMainL3DataTableBREATHE_BRI_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableBREATHE_BRI_WAST
            // 
            this.coldsMainL3DataTableBREATHE_BRI_WAST.Caption = "BREATHE_BRI_WAST";
            this.coldsMainL3DataTableBREATHE_BRI_WAST.ColumnName = "BREATHE_BRI_WAST";
            this.coldsMainL3DataTableBREATHE_BRI_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableBREATHE_BRI_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableBREATHE_BRI_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableBRICKLAYING_FAC
            // 
            this.coldsMainL3DataTableBRICKLAYING_FAC.Caption = "BRICKLAYING_FAC";
            this.coldsMainL3DataTableBRICKLAYING_FAC.ColumnName = "BRICKLAYING_FAC";
            this.coldsMainL3DataTableBRICKLAYING_FAC.DefaultValue = "";
            this.coldsMainL3DataTableBRICKLAYING_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_PRO_REFR_NAME
            // 
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME.Caption = "BOT_PRO_REFR_NAME";
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME.ColumnName = "BOT_PRO_REFR_NAME";
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME.DefaultValue = "";
            this.coldsMainL3DataTableBOT_PRO_REFR_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_PRO_REFR_WAST
            // 
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST.Caption = "BOT_PRO_REFR_WAST";
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST.ColumnName = "BOT_PRO_REFR_WAST";
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableBOT_PRO_REFR_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_WOKE_REFR_NAME
            // 
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME.Caption = "BOT_WOKE_REFR_NAME";
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME.ColumnName = "BOT_WOKE_REFR_NAME";
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME.DefaultValue = "";
            this.coldsMainL3DataTableBOT_WOKE_REFR_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_WOKE_REFR_WAST
            // 
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST.Caption = "BOT_WOKE_REFR_WAST";
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST.ColumnName = "BOT_WOKE_REFR_WAST";
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableBOT_WOKE_REFR_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableWALL_REFR_NAME
            // 
            this.coldsMainL3DataTableWALL_REFR_NAME.Caption = "WALL_REFR_NAME";
            this.coldsMainL3DataTableWALL_REFR_NAME.ColumnName = "WALL_REFR_NAME";
            this.coldsMainL3DataTableWALL_REFR_NAME.DefaultValue = "";
            this.coldsMainL3DataTableWALL_REFR_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableWALL_REFR_WAST
            // 
            this.coldsMainL3DataTableWALL_REFR_WAST.Caption = "WALL_REFR_WAST";
            this.coldsMainL3DataTableWALL_REFR_WAST.ColumnName = "WALL_REFR_WAST";
            this.coldsMainL3DataTableWALL_REFR_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableWALL_REFR_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableWALL_REFR_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableSLAG_LINE_REFE_NAME
            // 
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME.Caption = "SLAG_LINE_REFE_NAME";
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME.ColumnName = "SLAG_LINE_REFE_NAME";
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME.DefaultValue = "";
            this.coldsMainL3DataTableSLAG_LINE_REFE_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableSLAG_LINE_REFE_WAST
            // 
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST.Caption = "SLAG_LINE_REFE_WAST";
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST.ColumnName = "SLAG_LINE_REFE_WAST";
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableSLAG_LINE_REFE_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_WALL_REP_MAT_FAC
            // 
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC.Caption = "BOT_WALL_REP_MAT_FAC";
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC.ColumnName = "BOT_WALL_REP_MAT_FAC";
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC.DefaultValue = "";
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_WALL_REP_MAT_WAST
            // 
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST.Caption = "BOT_WALL_REP_MAT_WAST";
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST.ColumnName = "BOT_WALL_REP_MAT_WAST";
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableBOT_WALL_REP_MAT_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableSPI_CAST_FAC
            // 
            this.coldsMainL3DataTableSPI_CAST_FAC.Caption = "SPI_CAST_FAC";
            this.coldsMainL3DataTableSPI_CAST_FAC.ColumnName = "SPI_CAST_FAC";
            this.coldsMainL3DataTableSPI_CAST_FAC.DefaultValue = "";
            this.coldsMainL3DataTableSPI_CAST_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableSPI_CAST_WAST
            // 
            this.coldsMainL3DataTableSPI_CAST_WAST.Caption = "SPI_CAST_WAST";
            this.coldsMainL3DataTableSPI_CAST_WAST.ColumnName = "SPI_CAST_WAST";
            this.coldsMainL3DataTableSPI_CAST_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableSPI_CAST_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableSPI_CAST_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableLADLE_INNER_CHECKER
            // 
            this.coldsMainL3DataTableLADLE_INNER_CHECKER.Caption = "LADLE_INNER_CHECKER";
            this.coldsMainL3DataTableLADLE_INNER_CHECKER.ColumnName = "LADLE_INNER_CHECKER";
            this.coldsMainL3DataTableLADLE_INNER_CHECKER.DefaultValue = "";
            this.coldsMainL3DataTableLADLE_INNER_CHECKER.Namespace = "";
            // 
            // coldsMainL3DataTableLADLE_INNER_USE_COUNT
            // 
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT.Caption = "LADLE_INNER_USE_COUNT";
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT.ColumnName = "LADLE_INNER_USE_COUNT";
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT.DataType = typeof(int);
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT.DefaultValue = 0;
            this.coldsMainL3DataTableLADLE_INNER_USE_COUNT.Namespace = "";
            // 
            // coldsMainL3DataTableSEAT_BRI_INSTALLER
            // 
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER.Caption = "SEAT_BRI_INSTALLER";
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER.ColumnName = "SEAT_BRI_INSTALLER";
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER.DefaultValue = "";
            this.coldsMainL3DataTableSEAT_BRI_INSTALLER.Namespace = "";
            // 
            // coldsMainL3DataTableBUTTOM_BUILDER
            // 
            this.coldsMainL3DataTableBUTTOM_BUILDER.Caption = "BUTTOM_BUILDER";
            this.coldsMainL3DataTableBUTTOM_BUILDER.ColumnName = "BUTTOM_BUILDER";
            this.coldsMainL3DataTableBUTTOM_BUILDER.DefaultValue = "";
            this.coldsMainL3DataTableBUTTOM_BUILDER.Namespace = "";
            // 
            // coldsMainL3DataTableWALL_BUILDER
            // 
            this.coldsMainL3DataTableWALL_BUILDER.Caption = "WALL_BUILDER";
            this.coldsMainL3DataTableWALL_BUILDER.ColumnName = "WALL_BUILDER";
            this.coldsMainL3DataTableWALL_BUILDER.DefaultValue = "";
            this.coldsMainL3DataTableWALL_BUILDER.Namespace = "";
            // 
            // coldsMainL3DataTableLINE_REFE_BUILDER
            // 
            this.coldsMainL3DataTableLINE_REFE_BUILDER.Caption = "LINE_REFE_BUILDER";
            this.coldsMainL3DataTableLINE_REFE_BUILDER.ColumnName = "LINE_REFE_BUILDER";
            this.coldsMainL3DataTableLINE_REFE_BUILDER.DefaultValue = "";
            this.coldsMainL3DataTableLINE_REFE_BUILDER.Namespace = "";
            // 
            // coldsMainL3DataTableREP_LADLE_BOT
            // 
            this.coldsMainL3DataTableREP_LADLE_BOT.Caption = "REP_LADLE_BOT";
            this.coldsMainL3DataTableREP_LADLE_BOT.ColumnName = "REP_LADLE_BOT";
            this.coldsMainL3DataTableREP_LADLE_BOT.DefaultValue = "";
            this.coldsMainL3DataTableREP_LADLE_BOT.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_START_TIME
            // 
            this.coldsMainL3DataTableFIRE_START_TIME.Caption = "FIRE_START_TIME";
            this.coldsMainL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsMainL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_END_TIME
            // 
            this.coldsMainL3DataTableFIRE_END_TIME.Caption = "FIRE_END_TIME";
            this.coldsMainL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsMainL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableTHR_LADLE_TIME
            // 
            this.coldsMainL3DataTableTHR_LADLE_TIME.Caption = "THR_LADLE_TIME";
            this.coldsMainL3DataTableTHR_LADLE_TIME.ColumnName = "THR_LADLE_TIME";
            this.coldsMainL3DataTableTHR_LADLE_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableTHR_LADLE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.DefaultValue = "";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "L3DataTable";
            this.bsDetail.DataSource = this.dsDetail;
            // 
            // dsDetail
            // 
            this.dsDetail.AutoLoad = true;
            this.dsDetail.AutoSubscribe = false;
            this.dsDetail.DataSetName = "L3DataSet";
            this.dsDetail.DeleteMethod = "DeleteChaDreLinInfos";
            this.dsDetail.InsertMethod = "InsertChaDreLinInfos";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "Click";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 1000;
            this.dsDetail.SourceCommand = this.cmdDetail;
            this.dsDetail.SourceCondition = null;
            this.dsDetail.SourceMethod = "GetChaDreLinInfos";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDetail.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsDetail.SubscribeTarget = null;
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "Click";
            this.dsDetail.UpdateMethod = "UpdateChaDreLinInfos";
            this.dsDetail.UpdateTrigger = null;
            // 
            // cmdDetail
            // 
            this.cmdDetail.Adapter = null;
            this.cmdDetail.MergeReturnTarget = false;
            this.cmdDetail.Method = null;
            this.cmdDetail.Object = null;
            this.cmdDetail.Parameters.Add(this.l3CommandParameter2);
            this.cmdDetail.ReturnTarget = null;
            this.cmdDetail.ReturnTargetProperty = null;
            this.cmdDetail.Trigger = null;
            this.cmdDetail.TriggerEvent = "Click";
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
            // schemadsDetail
            // 
            this.schemadsDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDetailL3DataTableGUID,
            this.coldsDetailL3DataTableNAME,
            this.coldsDetailL3DataTableINPUT_TIME,
            this.coldsDetailL3DataTableCHAID,
            this.coldsDetailL3DataTableLADLEID,
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME,
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC,
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST,
            this.coldsDetailL3DataTableBREATHE_BRI_FAC,
            this.coldsDetailL3DataTableBREATHE_BRI_WAST,
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC,
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST,
            this.coldsDetailL3DataTableSPI_CAST_FAC,
            this.coldsDetailL3DataTableSPI_CAST_WAST,
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER,
            this.coldsDetailL3DataTableBUTTOM_BUILDER,
            this.coldsDetailL3DataTableWALL_BUILDER,
            this.coldsDetailL3DataTableREP_LADLE_BOT,
            this.coldsDetailL3DataTableFIRE_START_TIME,
            this.coldsDetailL3DataTableFIRE_END_TIME,
            this.coldsDetailL3DataTableTHR_LADLE_TIME,
            this.coldsDetailL3DataTableTEAMID,
            this.coldsDetailL3DataTableSHIFTID,
            this.coldsDetailL3DataTableOPERATOR,
            this.coldsDetailL3DataTableNOTE,
            this.coldsDetailL3DataTableWorkID,
            this.coldsDetailL3DataTableCha_Dre_Lin_Per,
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast,
            this.coldsDetailL3DataTableObject_ID});
            this.schemadsDetail.TableName = "L3DataTable";
            // 
            // coldsDetailL3DataTableGUID
            // 
            this.coldsDetailL3DataTableGUID.Caption = "GUID";
            this.coldsDetailL3DataTableGUID.ColumnName = "GUID";
            this.coldsDetailL3DataTableGUID.DefaultValue = "";
            this.coldsDetailL3DataTableGUID.Namespace = "";
            // 
            // coldsDetailL3DataTableNAME
            // 
            this.coldsDetailL3DataTableNAME.Caption = "NAME";
            this.coldsDetailL3DataTableNAME.ColumnName = "NAME";
            this.coldsDetailL3DataTableNAME.DefaultValue = "";
            this.coldsDetailL3DataTableNAME.Namespace = "";
            // 
            // coldsDetailL3DataTableINPUT_TIME
            // 
            this.coldsDetailL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableCHAID
            // 
            this.coldsDetailL3DataTableCHAID.Caption = "CHAID";
            this.coldsDetailL3DataTableCHAID.ColumnName = "CHAID";
            this.coldsDetailL3DataTableCHAID.DataType = typeof(int);
            this.coldsDetailL3DataTableCHAID.DefaultValue = 0;
            this.coldsDetailL3DataTableCHAID.Namespace = "";
            // 
            // coldsDetailL3DataTableLADLEID
            // 
            this.coldsDetailL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsDetailL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsDetailL3DataTableLADLEID.DefaultValue = "";
            this.coldsDetailL3DataTableLADLEID.Namespace = "";
            // 
            // coldsDetailL3DataTableCHA_SLAG_LINE_TIME
            // 
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME.Caption = "CHA_SLAG_LINE_TIME";
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME.ColumnName = "CHA_SLAG_LINE_TIME";
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableCHA_SLAG_LINE_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableWATER_GAP_BRI_FAC
            // 
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.Caption = "WATER_GAP_BRI_FAC";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.ColumnName = "WATER_GAP_BRI_FAC";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableWATER_GAP_BRI_WAST
            // 
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.Caption = "WATER_GAP_BRI_WAST";
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.ColumnName = "WATER_GAP_BRI_WAST";
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableBREATHE_BRI_FAC
            // 
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.Caption = "BREATHE_BRI_FAC";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.ColumnName = "BREATHE_BRI_FAC";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableBREATHE_BRI_WAST
            // 
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.Caption = "BREATHE_BRI_WAST";
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.ColumnName = "BREATHE_BRI_WAST";
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC
            // 
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC.Caption = "BOT_WALL_REP_MAT_FAC";
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC.ColumnName = "BOT_WALL_REP_MAT_FAC";
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST
            // 
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST.Caption = "BOT_WALL_REP_MAT_WAST";
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST.ColumnName = "BOT_WALL_REP_MAT_WAST";
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableSPI_CAST_FAC
            // 
            this.coldsDetailL3DataTableSPI_CAST_FAC.Caption = "SPI_CAST_FAC";
            this.coldsDetailL3DataTableSPI_CAST_FAC.ColumnName = "SPI_CAST_FAC";
            this.coldsDetailL3DataTableSPI_CAST_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableSPI_CAST_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableSPI_CAST_WAST
            // 
            this.coldsDetailL3DataTableSPI_CAST_WAST.Caption = "SPI_CAST_WAST";
            this.coldsDetailL3DataTableSPI_CAST_WAST.ColumnName = "SPI_CAST_WAST";
            this.coldsDetailL3DataTableSPI_CAST_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableSPI_CAST_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableSPI_CAST_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableSEAT_BRI_INSTALLER
            // 
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER.Caption = "SEAT_BRI_INSTALLER";
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER.ColumnName = "SEAT_BRI_INSTALLER";
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER.DefaultValue = "";
            this.coldsDetailL3DataTableSEAT_BRI_INSTALLER.Namespace = "";
            // 
            // coldsDetailL3DataTableBUTTOM_BUILDER
            // 
            this.coldsDetailL3DataTableBUTTOM_BUILDER.Caption = "BUTTOM_BUILDER";
            this.coldsDetailL3DataTableBUTTOM_BUILDER.ColumnName = "BUTTOM_BUILDER";
            this.coldsDetailL3DataTableBUTTOM_BUILDER.DefaultValue = "";
            this.coldsDetailL3DataTableBUTTOM_BUILDER.Namespace = "";
            // 
            // coldsDetailL3DataTableWALL_BUILDER
            // 
            this.coldsDetailL3DataTableWALL_BUILDER.Caption = "WALL_BUILDER";
            this.coldsDetailL3DataTableWALL_BUILDER.ColumnName = "WALL_BUILDER";
            this.coldsDetailL3DataTableWALL_BUILDER.DefaultValue = "";
            this.coldsDetailL3DataTableWALL_BUILDER.Namespace = "";
            // 
            // coldsDetailL3DataTableREP_LADLE_BOT
            // 
            this.coldsDetailL3DataTableREP_LADLE_BOT.Caption = "REP_LADLE_BOT";
            this.coldsDetailL3DataTableREP_LADLE_BOT.ColumnName = "REP_LADLE_BOT";
            this.coldsDetailL3DataTableREP_LADLE_BOT.DefaultValue = "";
            this.coldsDetailL3DataTableREP_LADLE_BOT.Namespace = "";
            // 
            // coldsDetailL3DataTableFIRE_START_TIME
            // 
            this.coldsDetailL3DataTableFIRE_START_TIME.Caption = "FIRE_START_TIME";
            this.coldsDetailL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsDetailL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableFIRE_END_TIME
            // 
            this.coldsDetailL3DataTableFIRE_END_TIME.Caption = "FIRE_END_TIME";
            this.coldsDetailL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsDetailL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableTHR_LADLE_TIME
            // 
            this.coldsDetailL3DataTableTHR_LADLE_TIME.Caption = "THR_LADLE_TIME";
            this.coldsDetailL3DataTableTHR_LADLE_TIME.ColumnName = "THR_LADLE_TIME";
            this.coldsDetailL3DataTableTHR_LADLE_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableTHR_LADLE_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableTEAMID
            // 
            this.coldsDetailL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.DefaultValue = "";
            this.coldsDetailL3DataTableTEAMID.Namespace = "";
            // 
            // coldsDetailL3DataTableSHIFTID
            // 
            this.coldsDetailL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.DefaultValue = "";
            this.coldsDetailL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsDetailL3DataTableOPERATOR
            // 
            this.coldsDetailL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsDetailL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsDetailL3DataTableOPERATOR.DefaultValue = "";
            this.coldsDetailL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsDetailL3DataTableNOTE
            // 
            this.coldsDetailL3DataTableNOTE.Caption = "NOTE";
            this.coldsDetailL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsDetailL3DataTableNOTE.DefaultValue = "";
            this.coldsDetailL3DataTableNOTE.Namespace = "";
            // 
            // coldsDetailL3DataTableWorkID
            // 
            this.coldsDetailL3DataTableWorkID.Caption = "WorkID";
            this.coldsDetailL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsDetailL3DataTableWorkID.Namespace = "";
            // 
            // coldsDetailL3DataTableCha_Dre_Lin_Per
            // 
            this.coldsDetailL3DataTableCha_Dre_Lin_Per.Caption = "Cha_Dre_Lin_Per";
            this.coldsDetailL3DataTableCha_Dre_Lin_Per.ColumnName = "Cha_Dre_Lin_Per";
            this.coldsDetailL3DataTableCha_Dre_Lin_Per.Namespace = "";
            // 
            // coldsDetailL3DataTableCha_Dre_Lin_Wast
            // 
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast.Caption = "Cha_Dre_Lin_Wast";
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast.ColumnName = "Cha_Dre_Lin_Wast";
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast.DataType = typeof(double);
            this.coldsDetailL3DataTableCha_Dre_Lin_Wast.Namespace = "";
            // 
            // coldsDetailL3DataTableObject_ID
            // 
            this.coldsDetailL3DataTableObject_ID.Caption = "Object_ID";
            this.coldsDetailL3DataTableObject_ID.ColumnName = "Object_ID";
            this.coldsDetailL3DataTableObject_ID.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 700);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dvMain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tSpM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bnMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 700);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.wORKIDDataGridViewTextBoxColumn,
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn,
            this.bUILDENDTIMEDataGridViewTextBoxColumn,
            this.wATERGAPBRIFACDataGridViewTextBoxColumn,
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn,
            this.bREATHEBRIFACDataGridViewTextBoxColumn,
            this.bREATHEBRIWASTDataGridViewTextBoxColumn,
            this.bRICKLAYINGFACDataGridViewTextBoxColumn,
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn,
            this.bOTPROREFRWASTDataGridViewTextBoxColumn,
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn,
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn,
            this.wALLREFRNAMEDataGridViewTextBoxColumn,
            this.wALLREFRWASTDataGridViewTextBoxColumn,
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn,
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn,
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn,
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn,
            this.sPICASTFACDataGridViewTextBoxColumn,
            this.sPICASTWASTDataGridViewTextBoxColumn,
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn,
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn,
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn,
            this.bUTTOMBUILDERDataGridViewTextBoxColumn,
            this.wALLBUILDERDataGridViewTextBoxColumn,
            this.lINEREFEBUILDERDataGridViewTextBoxColumn,
            this.rEPLADLEBOTDataGridViewTextBoxColumn,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn,
            this.fIREENDTIMEDataGridViewTextBoxColumn,
            this.tHRLADLETIMEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 71);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMain.Size = new System.Drawing.Size(994, 347);
            this.dvMain.TabIndex = 28;
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            this.dvMain.Sorted += new System.EventHandler(this.dvMain_Sorted);
            this.dvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvMain_CellMouseDoubleClick);
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 421);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 279);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvDetail);
            this.tabPage1.Controls.Add(this.bdNP);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(992, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "换渣线实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn1,
            this.lADLEIDDataGridViewTextBoxColumn1,
            this.cHAIDDataGridViewTextBoxColumn,
            this.WorkID,
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn,
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1,
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1,
            this.bREATHEBRIFACDataGridViewTextBoxColumn1,
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1,
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1,
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1,
            this.sPICASTFACDataGridViewTextBoxColumn1,
            this.sPICASTWASTDataGridViewTextBoxColumn1,
            this.Cha_Dre_Lin_Per,
            this.Cha_Dre_Lin_Wast,
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1,
            this.fIREENDTIMEDataGridViewTextBoxColumn1,
            this.tHRLADLETIMEDataGridViewTextBoxColumn1,
            this.tEAMIDDataGridViewTextBoxColumn1,
            this.sHIFTIDDataGridViewTextBoxColumn1,
            this.oPERATORDataGridViewTextBoxColumn1,
            this.nOTEDataGridViewTextBoxColumn1});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 25);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(992, 229);
            this.dvDetail.TabIndex = 24;
            this.dvDetail.Sorted += new System.EventHandler(this.dvDetail_Sorted);
            this.dvDetail.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvDetail_CellMouseDoubleClick);
            this.dvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDetail_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn1
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "INPUT_TIME";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Name = "iNPUTTIMEDataGridViewTextBoxColumn1";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // lADLEIDDataGridViewTextBoxColumn1
            // 
            this.lADLEIDDataGridViewTextBoxColumn1.DataPropertyName = "LADLEID";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.lADLEIDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.lADLEIDDataGridViewTextBoxColumn1.Frozen = true;
            this.lADLEIDDataGridViewTextBoxColumn1.HeaderText = "包号";
            this.lADLEIDDataGridViewTextBoxColumn1.Name = "lADLEIDDataGridViewTextBoxColumn1";
            this.lADLEIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // cHAIDDataGridViewTextBoxColumn
            // 
            this.cHAIDDataGridViewTextBoxColumn.DataPropertyName = "CHAID";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.cHAIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cHAIDDataGridViewTextBoxColumn.Frozen = true;
            this.cHAIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.cHAIDDataGridViewTextBoxColumn.Name = "cHAIDDataGridViewTextBoxColumn";
            this.cHAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHAIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // WorkID
            // 
            this.WorkID.DataPropertyName = "WorkID";
            this.WorkID.HeaderText = "工作层编号";
            this.WorkID.Name = "WorkID";
            this.WorkID.ReadOnly = true;
            this.WorkID.Width = 90;
            // 
            // cHASLAGLINETIMEDataGridViewTextBoxColumn
            // 
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn.DataPropertyName = "CHA_SLAG_LINE_TIME";
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn.HeaderText = "换渣线时间";
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn.Name = "cHASLAGLINETIMEDataGridViewTextBoxColumn";
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHASLAGLINETIMEDataGridViewTextBoxColumn.Width = 90;
            // 
            // wATERGAPBRIFACDataGridViewTextBoxColumn1
            // 
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1.DataPropertyName = "WATER_GAP_BRI_FAC";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1.HeaderText = "水口座砖厂家";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1.Name = "wATERGAPBRIFACDataGridViewTextBoxColumn1";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wATERGAPBRIFACDataGridViewTextBoxColumn1.Width = 102;
            // 
            // wATERGAPBRIWASTDataGridViewTextBoxColumn1
            // 
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1.DataPropertyName = "WATER_GAP_BRI_WAST";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1.HeaderText = "水口座砖消耗量[t]";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1.Name = "wATERGAPBRIWASTDataGridViewTextBoxColumn1";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn1.Width = 132;
            // 
            // bREATHEBRIFACDataGridViewTextBoxColumn1
            // 
            this.bREATHEBRIFACDataGridViewTextBoxColumn1.DataPropertyName = "BREATHE_BRI_FAC";
            this.bREATHEBRIFACDataGridViewTextBoxColumn1.HeaderText = "透气座砖厂家";
            this.bREATHEBRIFACDataGridViewTextBoxColumn1.Name = "bREATHEBRIFACDataGridViewTextBoxColumn1";
            this.bREATHEBRIFACDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bREATHEBRIFACDataGridViewTextBoxColumn1.Width = 102;
            // 
            // bREATHEBRIWASTDataGridViewTextBoxColumn1
            // 
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1.DataPropertyName = "BREATHE_BRI_WAST";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1.HeaderText = "透气座砖消耗量[t]";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1.Name = "bREATHEBRIWASTDataGridViewTextBoxColumn1";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bREATHEBRIWASTDataGridViewTextBoxColumn1.Width = 132;
            // 
            // bOTWALLREPMATFACDataGridViewTextBoxColumn1
            // 
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1.DataPropertyName = "BOT_WALL_REP_MAT_FAC";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1.HeaderText = "包底壁修补料厂家";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1.Name = "bOTWALLREPMATFACDataGridViewTextBoxColumn1";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn1.Width = 126;
            // 
            // bOTWALLREPMATWASTDataGridViewTextBoxColumn1
            // 
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1.DataPropertyName = "BOT_WALL_REP_MAT_WAST";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1.HeaderText = "包底修补料消耗量[t]";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1.Name = "bOTWALLREPMATWASTDataGridViewTextBoxColumn1";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn1.Width = 144;
            // 
            // sPICASTFACDataGridViewTextBoxColumn1
            // 
            this.sPICASTFACDataGridViewTextBoxColumn1.DataPropertyName = "SPI_CAST_FAC";
            this.sPICASTFACDataGridViewTextBoxColumn1.HeaderText = "尖晶石浇铸料厂家";
            this.sPICASTFACDataGridViewTextBoxColumn1.Name = "sPICASTFACDataGridViewTextBoxColumn1";
            this.sPICASTFACDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sPICASTFACDataGridViewTextBoxColumn1.Width = 126;
            // 
            // sPICASTWASTDataGridViewTextBoxColumn1
            // 
            this.sPICASTWASTDataGridViewTextBoxColumn1.DataPropertyName = "SPI_CAST_WAST";
            this.sPICASTWASTDataGridViewTextBoxColumn1.HeaderText = "尖晶石浇铸料消耗量[t]";
            this.sPICASTWASTDataGridViewTextBoxColumn1.Name = "sPICASTWASTDataGridViewTextBoxColumn1";
            this.sPICASTWASTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sPICASTWASTDataGridViewTextBoxColumn1.Width = 156;
            // 
            // Cha_Dre_Lin_Per
            // 
            this.Cha_Dre_Lin_Per.DataPropertyName = "Cha_Dre_Lin_Per";
            this.Cha_Dre_Lin_Per.HeaderText = "渣线砌筑";
            this.Cha_Dre_Lin_Per.Name = "Cha_Dre_Lin_Per";
            this.Cha_Dre_Lin_Per.ReadOnly = true;
            this.Cha_Dre_Lin_Per.Width = 78;
            // 
            // Cha_Dre_Lin_Wast
            // 
            this.Cha_Dre_Lin_Wast.DataPropertyName = "Cha_Dre_Lin_Wast";
            this.Cha_Dre_Lin_Wast.HeaderText = "渣线消耗[t]";
            this.Cha_Dre_Lin_Wast.Name = "Cha_Dre_Lin_Wast";
            this.Cha_Dre_Lin_Wast.ReadOnly = true;
            this.Cha_Dre_Lin_Wast.Width = 96;
            // 
            // sEATBRIINSTALLERDataGridViewTextBoxColumn1
            // 
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1.DataPropertyName = "SEAT_BRI_INSTALLER";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1.HeaderText = "座砖安装";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1.Name = "sEATBRIINSTALLERDataGridViewTextBoxColumn1";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn1.Width = 78;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn1
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1.HeaderText = "烘烤开始时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn1";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn1
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn1.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn1.HeaderText = "烘烤结束时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn1.Name = "fIREENDTIMEDataGridViewTextBoxColumn1";
            this.fIREENDTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // tHRLADLETIMEDataGridViewTextBoxColumn1
            // 
            this.tHRLADLETIMEDataGridViewTextBoxColumn1.DataPropertyName = "THR_LADLE_TIME";
            this.tHRLADLETIMEDataGridViewTextBoxColumn1.HeaderText = "甩包时间";
            this.tHRLADLETIMEDataGridViewTextBoxColumn1.Name = "tHRLADLETIMEDataGridViewTextBoxColumn1";
            this.tHRLADLETIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tHRLADLETIMEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // tEAMIDDataGridViewTextBoxColumn1
            // 
            this.tEAMIDDataGridViewTextBoxColumn1.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn1.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn1.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn1.Name = "tEAMIDDataGridViewTextBoxColumn1";
            this.tEAMIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn1
            // 
            this.sHIFTIDDataGridViewTextBoxColumn1.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn1.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn1.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn1.Name = "sHIFTIDDataGridViewTextBoxColumn1";
            this.sHIFTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // oPERATORDataGridViewTextBoxColumn1
            // 
            this.oPERATORDataGridViewTextBoxColumn1.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn1.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn1.Name = "oPERATORDataGridViewTextBoxColumn1";
            this.oPERATORDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn1.Width = 66;
            // 
            // nOTEDataGridViewTextBoxColumn1
            // 
            this.nOTEDataGridViewTextBoxColumn1.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn1.Name = "nOTEDataGridViewTextBoxColumn1";
            this.nOTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bdNP
            // 
            this.bdNP.AddNewItem = null;
            this.bdNP.AutoSize = false;
            this.bdNP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdNP.BackgroundImage")));
            this.bdNP.BindingSource = this.bsDetail;
            this.bdNP.CountItem = null;
            this.bdNP.DeleteItem = null;
            this.bdNP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDetail,
            this.btnDelDetail,
            this.toolStripSeparator5,
            this.btnConfirmDetail,
            this.btnCancelDetail,
            this.btnQueryDetail});
            this.bdNP.Location = new System.Drawing.Point(0, 0);
            this.bdNP.MoveFirstItem = null;
            this.bdNP.MoveLastItem = null;
            this.bdNP.MoveNextItem = null;
            this.bdNP.MovePreviousItem = null;
            this.bdNP.Name = "bdNP";
            this.bdNP.Padding = new System.Windows.Forms.Padding(0);
            this.bdNP.PositionItem = null;
            this.bdNP.Size = new System.Drawing.Size(992, 25);
            this.bdNP.TabIndex = 22;
            this.bdNP.Text = "bindingNavigator2";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(49, 22);
            this.btnAddDetail.Text = "新增";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDelDetail.Image")));
            this.btnDelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnDelDetail.Text = "删除";
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmDetail
            // 
            this.btnConfirmDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmDetail.Image")));
            this.btnConfirmDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmDetail.Name = "btnConfirmDetail";
            this.btnConfirmDetail.Size = new System.Drawing.Size(55, 22);
            this.btnConfirmDetail.Text = "确定 ";
            this.btnConfirmDetail.Click += new System.EventHandler(this.btnConfirmDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.btnCancelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDetail.Image")));
            this.btnCancelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnCancelDetail.Text = "取消";
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // btnQueryDetail
            // 
            this.btnQueryDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryDetail.Image")));
            this.btnQueryDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryDetail.Name = "btnQueryDetail";
            this.btnQueryDetail.Size = new System.Drawing.Size(73, 22);
            this.btnQueryDetail.Text = "实绩查询";
            this.btnQueryDetail.Click += new System.EventHandler(this.btnQueryDetail_Click);
            // 
            // tSpM
            // 
            this.tSpM.AutoSize = false;
            this.tSpM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSpM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSpM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAddMain,
            this.btnDelMain,
            this.toolStripSeparator10,
            this.btnConfirmMain,
            this.btnCancelMain,
            this.btnExlMain});
            this.tSpM.Location = new System.Drawing.Point(0, 0);
            this.tSpM.Name = "tSpM";
            this.tSpM.Size = new System.Drawing.Size(1000, 43);
            this.tSpM.TabIndex = 15;
            this.tSpM.Text = "toolStrip1";
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
            // btnAddMain
            // 
            this.btnAddMain.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMain.Image")));
            this.btnAddMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(65, 40);
            this.btnAddMain.Text = "新增";
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // btnDelMain
            // 
            this.btnDelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnDelMain.Image")));
            this.btnDelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelMain.Name = "btnDelMain";
            this.btnDelMain.Size = new System.Drawing.Size(65, 40);
            this.btnDelMain.Text = "删除";
            this.btnDelMain.Click += new System.EventHandler(this.btnDelMain_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirmMain
            // 
            this.btnConfirmMain.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmMain.Image")));
            this.btnConfirmMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmMain.Name = "btnConfirmMain";
            this.btnConfirmMain.Size = new System.Drawing.Size(65, 40);
            this.btnConfirmMain.Text = "确定";
            this.btnConfirmMain.Click += new System.EventHandler(this.btnConfirmMain_Click);
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMain.Image")));
            this.btnCancelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(65, 40);
            this.btnCancelMain.Text = "取消";
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
            // 
            // btnExlMain
            // 
            this.btnExlMain.Image = ((System.Drawing.Image)(resources.GetObject("btnExlMain.Image")));
            this.btnExlMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExlMain.Name = "btnExlMain";
            this.btnExlMain.Size = new System.Drawing.Size(107, 40);
            this.btnExlMain.Text = "导出到Excel";
            this.btnExlMain.Click += new System.EventHandler(this.btnExlMain_Click);
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = null;
            this.bnMain.AutoSize = false;
            this.bnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnMain.BackgroundImage")));
            this.bnMain.BindingSource = this.bsMain;
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = null;
            this.bnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
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
            this.cmbLadleID,
            this.toolStripLabel7,
            this.dtEnd,
            this.toolStripLabel8,
            this.dtStart,
            this.toolStripLabel9,
            this.btnDataConfirm});
            this.bnMain.Location = new System.Drawing.Point(0, 43);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(1000, 25);
            this.bnMain.TabIndex = 22;
            this.bnMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel3.Text = "砌筑实绩";
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(121, 25);
            this.cmbLadleID.DropDownClosed += new System.EventHandler(this.cmbLadleID_DropDownClosed);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel7.Text = "钢包号:";
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
            // toolStripLabel8
            // 
            this.toolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel8.Text = "-";
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
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel9.Text = "录入日期:";
            // 
            // btnDataConfirm
            // 
            this.btnDataConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnDataConfirm.Image")));
            this.btnDataConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataConfirm.Name = "btnDataConfirm";
            this.btnDataConfirm.Size = new System.Drawing.Size(73, 22);
            this.btnDataConfirm.Text = "数据确认";
            this.btnDataConfirm.Visible = false;
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "LadleType <> \'1\' order by LadleID";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadleID.SubscribeTarget = null;
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.iNPUTTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.lADLEIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.lADLEIDDataGridViewTextBoxColumn.Frozen = true;
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // wORKIDDataGridViewTextBoxColumn
            // 
            this.wORKIDDataGridViewTextBoxColumn.DataPropertyName = "WORKID";
            this.wORKIDDataGridViewTextBoxColumn.Frozen = true;
            this.wORKIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.wORKIDDataGridViewTextBoxColumn.Name = "wORKIDDataGridViewTextBoxColumn";
            this.wORKIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wORKIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // bUILDSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_START_TIME";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "砌筑开始时间";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Name = "bUILDSTARTTIMEDataGridViewTextBoxColumn";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // bUILDENDTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_END_TIME";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.HeaderText = "砌筑结束时间";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Name = "bUILDENDTIMEDataGridViewTextBoxColumn";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // wATERGAPBRIFACDataGridViewTextBoxColumn
            // 
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.DataPropertyName = "WATER_GAP_BRI_FAC";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.HeaderText = "水口座砖厂家";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.Name = "wATERGAPBRIFACDataGridViewTextBoxColumn";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // wATERGAPBRIWASTDataGridViewTextBoxColumn
            // 
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.DataPropertyName = "WATER_GAP_BRI_WAST";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.HeaderText = "水口座砖消耗量[t]";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.Name = "wATERGAPBRIWASTDataGridViewTextBoxColumn";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.Width = 132;
            // 
            // bREATHEBRIFACDataGridViewTextBoxColumn
            // 
            this.bREATHEBRIFACDataGridViewTextBoxColumn.DataPropertyName = "BREATHE_BRI_FAC";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.HeaderText = "透气座砖厂家";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.Name = "bREATHEBRIFACDataGridViewTextBoxColumn";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.bREATHEBRIFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // bREATHEBRIWASTDataGridViewTextBoxColumn
            // 
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.DataPropertyName = "BREATHE_BRI_WAST";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.HeaderText = "透气座砖消耗量[t]";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.Name = "bREATHEBRIWASTDataGridViewTextBoxColumn";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.Width = 132;
            // 
            // bRICKLAYINGFACDataGridViewTextBoxColumn
            // 
            this.bRICKLAYINGFACDataGridViewTextBoxColumn.DataPropertyName = "BRICKLAYING_FAC";
            this.bRICKLAYINGFACDataGridViewTextBoxColumn.HeaderText = "砌砖厂家";
            this.bRICKLAYINGFACDataGridViewTextBoxColumn.Name = "bRICKLAYINGFACDataGridViewTextBoxColumn";
            this.bRICKLAYINGFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.bRICKLAYINGFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // bOTPROREFRNAMEDataGridViewTextBoxColumn
            // 
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOT_PRO_REFR_NAME";
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.HeaderText = "砌筑包底保护层耐材名称";
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.Name = "bOTPROREFRNAMEDataGridViewTextBoxColumn";
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.Visible = false;
            this.bOTPROREFRNAMEDataGridViewTextBoxColumn.Width = 162;
            // 
            // bOTPROREFRWASTDataGridViewTextBoxColumn
            // 
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.DataPropertyName = "BOT_PRO_REFR_WAST";
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.HeaderText = "砌筑包底保护层耐材消耗量[t]";
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.Name = "bOTPROREFRWASTDataGridViewTextBoxColumn";
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.Visible = false;
            this.bOTPROREFRWASTDataGridViewTextBoxColumn.Width = 192;
            // 
            // bOTWOKEREFRNAMEDataGridViewTextBoxColumn
            // 
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOT_WOKE_REFR_NAME";
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn.HeaderText = "砌筑包底工作层耐材名称";
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn.Name = "bOTWOKEREFRNAMEDataGridViewTextBoxColumn";
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTWOKEREFRNAMEDataGridViewTextBoxColumn.Width = 162;
            // 
            // bOTWOKEREFRWASTDataGridViewTextBoxColumn
            // 
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn.DataPropertyName = "BOT_WOKE_REFR_WAST";
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn.HeaderText = "砌筑包底工作层耐材消耗量[t]";
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn.Name = "bOTWOKEREFRWASTDataGridViewTextBoxColumn";
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTWOKEREFRWASTDataGridViewTextBoxColumn.Width = 192;
            // 
            // wALLREFRNAMEDataGridViewTextBoxColumn
            // 
            this.wALLREFRNAMEDataGridViewTextBoxColumn.DataPropertyName = "WALL_REFR_NAME";
            this.wALLREFRNAMEDataGridViewTextBoxColumn.HeaderText = "砌筑包壁耐材名称";
            this.wALLREFRNAMEDataGridViewTextBoxColumn.Name = "wALLREFRNAMEDataGridViewTextBoxColumn";
            this.wALLREFRNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.wALLREFRNAMEDataGridViewTextBoxColumn.Width = 126;
            // 
            // wALLREFRWASTDataGridViewTextBoxColumn
            // 
            this.wALLREFRWASTDataGridViewTextBoxColumn.DataPropertyName = "WALL_REFR_WAST";
            this.wALLREFRWASTDataGridViewTextBoxColumn.HeaderText = "砌筑包壁耐材消耗量[t]";
            this.wALLREFRWASTDataGridViewTextBoxColumn.Name = "wALLREFRWASTDataGridViewTextBoxColumn";
            this.wALLREFRWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wALLREFRWASTDataGridViewTextBoxColumn.Width = 156;
            // 
            // sLAGLINEREFENAMEDataGridViewTextBoxColumn
            // 
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn.DataPropertyName = "SLAG_LINE_REFE_NAME";
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn.HeaderText = "砌筑渣线耐材名称";
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn.Name = "sLAGLINEREFENAMEDataGridViewTextBoxColumn";
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sLAGLINEREFENAMEDataGridViewTextBoxColumn.Width = 126;
            // 
            // sLAGLINEREFEWASTDataGridViewTextBoxColumn
            // 
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn.DataPropertyName = "SLAG_LINE_REFE_WAST";
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn.HeaderText = "砌筑渣线耐材消耗量[t]";
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn.Name = "sLAGLINEREFEWASTDataGridViewTextBoxColumn";
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sLAGLINEREFEWASTDataGridViewTextBoxColumn.Width = 156;
            // 
            // bOTWALLREPMATFACDataGridViewTextBoxColumn
            // 
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn.DataPropertyName = "BOT_WALL_REP_MAT_FAC";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn.HeaderText = "包底壁修补料厂家";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn.Name = "bOTWALLREPMATFACDataGridViewTextBoxColumn";
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTWALLREPMATFACDataGridViewTextBoxColumn.Width = 126;
            // 
            // bOTWALLREPMATWASTDataGridViewTextBoxColumn
            // 
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn.DataPropertyName = "BOT_WALL_REP_MAT_WAST";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn.HeaderText = "包底修补料消耗量[t]";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn.Name = "bOTWALLREPMATWASTDataGridViewTextBoxColumn";
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTWALLREPMATWASTDataGridViewTextBoxColumn.Width = 144;
            // 
            // sPICASTFACDataGridViewTextBoxColumn
            // 
            this.sPICASTFACDataGridViewTextBoxColumn.DataPropertyName = "SPI_CAST_FAC";
            this.sPICASTFACDataGridViewTextBoxColumn.HeaderText = "尖晶石浇铸料厂家";
            this.sPICASTFACDataGridViewTextBoxColumn.Name = "sPICASTFACDataGridViewTextBoxColumn";
            this.sPICASTFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPICASTFACDataGridViewTextBoxColumn.Width = 126;
            // 
            // sPICASTWASTDataGridViewTextBoxColumn
            // 
            this.sPICASTWASTDataGridViewTextBoxColumn.DataPropertyName = "SPI_CAST_WAST";
            this.sPICASTWASTDataGridViewTextBoxColumn.HeaderText = "尖晶石浇铸料消耗量[t]";
            this.sPICASTWASTDataGridViewTextBoxColumn.Name = "sPICASTWASTDataGridViewTextBoxColumn";
            this.sPICASTWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPICASTWASTDataGridViewTextBoxColumn.Width = 156;
            // 
            // lADLEINNERCHECKERDataGridViewTextBoxColumn
            // 
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn.DataPropertyName = "LADLE_INNER_CHECKER";
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn.HeaderText = "永久层检查";
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn.Name = "lADLEINNERCHECKERDataGridViewTextBoxColumn";
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEINNERCHECKERDataGridViewTextBoxColumn.Width = 90;
            // 
            // lADLEINNERUSECOUNTDataGridViewTextBoxColumn
            // 
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.DataPropertyName = "LADLE_INNER_USE_COUNT";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.HeaderText = "永久层使用次数";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.Name = "lADLEINNERUSECOUNTDataGridViewTextBoxColumn";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.Width = 114;
            // 
            // sEATBRIINSTALLERDataGridViewTextBoxColumn
            // 
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn.DataPropertyName = "SEAT_BRI_INSTALLER";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn.HeaderText = "座砖安装";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn.Name = "sEATBRIINSTALLERDataGridViewTextBoxColumn";
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEATBRIINSTALLERDataGridViewTextBoxColumn.Width = 78;
            // 
            // bUTTOMBUILDERDataGridViewTextBoxColumn
            // 
            this.bUTTOMBUILDERDataGridViewTextBoxColumn.DataPropertyName = "BUTTOM_BUILDER";
            this.bUTTOMBUILDERDataGridViewTextBoxColumn.HeaderText = "包底砌筑";
            this.bUTTOMBUILDERDataGridViewTextBoxColumn.Name = "bUTTOMBUILDERDataGridViewTextBoxColumn";
            this.bUTTOMBUILDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUTTOMBUILDERDataGridViewTextBoxColumn.Width = 78;
            // 
            // wALLBUILDERDataGridViewTextBoxColumn
            // 
            this.wALLBUILDERDataGridViewTextBoxColumn.DataPropertyName = "WALL_BUILDER";
            this.wALLBUILDERDataGridViewTextBoxColumn.HeaderText = "包壁砌筑";
            this.wALLBUILDERDataGridViewTextBoxColumn.Name = "wALLBUILDERDataGridViewTextBoxColumn";
            this.wALLBUILDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.wALLBUILDERDataGridViewTextBoxColumn.Width = 78;
            // 
            // lINEREFEBUILDERDataGridViewTextBoxColumn
            // 
            this.lINEREFEBUILDERDataGridViewTextBoxColumn.DataPropertyName = "LINE_REFE_BUILDER";
            this.lINEREFEBUILDERDataGridViewTextBoxColumn.HeaderText = "渣线砌筑";
            this.lINEREFEBUILDERDataGridViewTextBoxColumn.Name = "lINEREFEBUILDERDataGridViewTextBoxColumn";
            this.lINEREFEBUILDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.lINEREFEBUILDERDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEPLADLEBOTDataGridViewTextBoxColumn
            // 
            this.rEPLADLEBOTDataGridViewTextBoxColumn.DataPropertyName = "REP_LADLE_BOT";
            this.rEPLADLEBOTDataGridViewTextBoxColumn.HeaderText = "补包底";
            this.rEPLADLEBOTDataGridViewTextBoxColumn.Name = "rEPLADLEBOTDataGridViewTextBoxColumn";
            this.rEPLADLEBOTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPLADLEBOTDataGridViewTextBoxColumn.Width = 66;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤开始时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤结束时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn.Name = "fIREENDTIMEDataGridViewTextBoxColumn";
            this.fIREENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // tHRLADLETIMEDataGridViewTextBoxColumn
            // 
            this.tHRLADLETIMEDataGridViewTextBoxColumn.DataPropertyName = "THR_LADLE_TIME";
            this.tHRLADLETIMEDataGridViewTextBoxColumn.HeaderText = "甩包时间";
            this.tHRLADLETIMEDataGridViewTextBoxColumn.Name = "tHRLADLETIMEDataGridViewTextBoxColumn";
            this.tHRLADLETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHRLADLETIMEDataGridViewTextBoxColumn.Width = 78;
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
            // FinLadleBuildMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinLadleBuildMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "精炼钢包砌筑实绩管理";
            this.Text = "精炼钢包砌筑实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinLadleBuildMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.FinLadleBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).EndInit();
            this.bdNP.ResumeLayout(false);
            this.bdNP.PerformLayout();
            this.tSpM.ResumeLayout(false);
            this.tSpM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
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
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsDetail;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsDetail;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvDetail;
        private System.Windows.Forms.BindingNavigator bdNP;
        private System.Windows.Forms.ToolStripButton btnAddDetail;
        private System.Windows.Forms.ToolStripButton btnDelDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirmDetail;
        private System.Windows.Forms.ToolStripButton btnCancelDetail;
        private System.Windows.Forms.ToolStrip tSpM;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddMain;
        private System.Windows.Forms.ToolStripButton btnDelMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnConfirmMain;
        private System.Windows.Forms.ToolStripButton btnCancelMain;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
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
        private System.Windows.Forms.ToolStripComboBox cmbLadleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableWORKID;
        private System.Data.DataColumn coldsMainL3DataTableLADLEID;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_START_TIME;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_END_TIME;
        private System.Data.DataColumn coldsMainL3DataTableWATER_GAP_BRI_FAC;
        private System.Data.DataColumn coldsMainL3DataTableWATER_GAP_BRI_WAST;
        private System.Data.DataColumn coldsMainL3DataTableBREATHE_BRI_FAC;
        private System.Data.DataColumn coldsMainL3DataTableBREATHE_BRI_WAST;
        private System.Data.DataColumn coldsMainL3DataTableBRICKLAYING_FAC;
        private System.Data.DataColumn coldsMainL3DataTableBOT_PRO_REFR_NAME;
        private System.Data.DataColumn coldsMainL3DataTableBOT_PRO_REFR_WAST;
        private System.Data.DataColumn coldsMainL3DataTableBOT_WOKE_REFR_NAME;
        private System.Data.DataColumn coldsMainL3DataTableBOT_WOKE_REFR_WAST;
        private System.Data.DataColumn coldsMainL3DataTableWALL_REFR_NAME;
        private System.Data.DataColumn coldsMainL3DataTableWALL_REFR_WAST;
        private System.Data.DataColumn coldsMainL3DataTableSLAG_LINE_REFE_NAME;
        private System.Data.DataColumn coldsMainL3DataTableSLAG_LINE_REFE_WAST;
        private System.Data.DataColumn coldsMainL3DataTableBOT_WALL_REP_MAT_FAC;
        private System.Data.DataColumn coldsMainL3DataTableBOT_WALL_REP_MAT_WAST;
        private System.Data.DataColumn coldsMainL3DataTableSPI_CAST_FAC;
        private System.Data.DataColumn coldsMainL3DataTableSPI_CAST_WAST;
        private System.Data.DataColumn coldsMainL3DataTableLADLE_INNER_CHECKER;
        private System.Data.DataColumn coldsMainL3DataTableLADLE_INNER_USE_COUNT;
        private System.Data.DataColumn coldsMainL3DataTableSEAT_BRI_INSTALLER;
        private System.Data.DataColumn coldsMainL3DataTableBUTTOM_BUILDER;
        private System.Data.DataColumn coldsMainL3DataTableWALL_BUILDER;
        private System.Data.DataColumn coldsMainL3DataTableLINE_REFE_BUILDER;
        private System.Data.DataColumn coldsMainL3DataTableREP_LADLE_BOT;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsMainL3DataTableTHR_LADLE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3Command cmdDetail;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableNAME;
        private System.Data.DataColumn coldsDetailL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableCHAID;
        private System.Data.DataColumn coldsDetailL3DataTableLADLEID;
        private System.Data.DataColumn coldsDetailL3DataTableCHA_SLAG_LINE_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableWATER_GAP_BRI_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableWATER_GAP_BRI_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableBREATHE_BRI_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableBREATHE_BRI_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableBOT_WALL_REP_MAT_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableBOT_WALL_REP_MAT_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableSPI_CAST_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableSPI_CAST_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableSEAT_BRI_INSTALLER;
        private System.Data.DataColumn coldsDetailL3DataTableBUTTOM_BUILDER;
        private System.Data.DataColumn coldsDetailL3DataTableWALL_BUILDER;
        private System.Data.DataColumn coldsDetailL3DataTableREP_LADLE_BOT;
        private System.Data.DataColumn coldsDetailL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableTHR_LADLE_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableTEAMID;
        private System.Data.DataColumn coldsDetailL3DataTableSHIFTID;
        private System.Data.DataColumn coldsDetailL3DataTableOPERATOR;
        private System.Data.DataColumn coldsDetailL3DataTableNOTE;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private System.Data.DataColumn coldsDetailL3DataTableWorkID;
        private System.Data.DataColumn coldsDetailL3DataTableCha_Dre_Lin_Per;
        private System.Data.DataColumn coldsDetailL3DataTableCha_Dre_Lin_Wast;
        private System.Windows.Forms.ToolStripButton btnDataConfirm;
        private System.Data.DataColumn coldsDetailL3DataTableObject_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHASLAGLINETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIFACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIWASTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIFACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIWASTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWALLREPMATFACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWALLREPMATWASTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPICASTFACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPICASTWASTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cha_Dre_Lin_Per;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cha_Dre_Lin_Wast;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATBRIINSTALLERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHRLADLETIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton btnExlMain;
        private System.Windows.Forms.ToolStripButton btnQueryDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRICKLAYINGFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTPROREFRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTPROREFRWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWOKEREFRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWOKEREFRWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wALLREFRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wALLREFRWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLAGLINEREFENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLAGLINEREFEWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWALLREPMATFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTWALLREPMATWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPICASTFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPICASTWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEINNERCHECKERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEINNERUSECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATBRIINSTALLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUTTOMBUILDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wALLBUILDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINEREFEBUILDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPLADLEBOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHRLADLETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}