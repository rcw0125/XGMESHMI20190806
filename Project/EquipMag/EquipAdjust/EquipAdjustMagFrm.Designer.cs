namespace EquipMag.EquipAdjust
{
    partial class EquipAdjustMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipAdjustMagFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmDetail = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDetail = new System.Windows.Forms.ToolStripButton();
            this.btnAddMain = new System.Windows.Forms.ToolStripButton();
            this.btnDelMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmMain = new System.Windows.Forms.ToolStripButton();
            this.btnExlMain = new System.Windows.Forms.ToolStripButton();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
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
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableLogID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLocation = new System.Data.DataColumn();
            this.coldsMainL3DataTableLocation_Des = new System.Data.DataColumn();
            this.coldsMainL3DataTableMeter = new System.Data.DataColumn();
            this.coldsMainL3DataTableMeter_Size = new System.Data.DataColumn();
            this.coldsMainL3DataTableRange = new System.Data.DataColumn();
            this.coldsMainL3DataTablePrecision = new System.Data.DataColumn();
            this.coldsMainL3DataTableFactory = new System.Data.DataColumn();
            this.coldsMainL3DataTableMeasure_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableStandard_Equ = new System.Data.DataColumn();
            this.coldsMainL3DataTableScale_Min = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreate_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableAuditing_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableAssessor = new System.Data.DataColumn();
            this.coldsMainL3DataTableResult = new System.Data.DataColumn();
            this.coldsMainL3DataTableStatus = new System.Data.DataColumn();
            this.coldsMainL3DataTableCheck_Date = new System.Data.DataColumn();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.cmdDetail = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLogID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCreate_Time = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_B_Std = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_B_Act = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_B_Dif = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_B_Std = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_B_Act = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_B_Dif = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_A_Std = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_A_Act = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLoad_A_Dif = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_A_Std = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_A_Act = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUnLoad_A_Dif = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.loadBStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadBActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadBDifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadBStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadBActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadBDifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadAStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadAActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadADifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadAStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadAActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoadADifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdNP = new System.Windows.Forms.BindingNavigator(this.components);
            this.tSpM = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancelMain = new System.Windows.Forms.ToolStripButton();
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
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLocation = new AppSvrHMI.L3DataSet();
            this.schemadsLocation = new System.Data.DataTable();
            this.coldsLocationL3DataTableCode = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.locationDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLocation_Des = new AppSvrHMI.L3DataSet();
            this.schemadsLocation_Des = new System.Data.DataTable();
            this.coldsLocation_DesL3DataTableCode = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardEquDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaleMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCheck = new AppSvrHMI.L3DataSet();
            this.schemadsCheck = new System.Data.DataTable();
            this.coldsCheckL3DataTableID = new System.Data.DataColumn();
            this.coldsCheckL3DataTableDesc = new System.Data.DataColumn();
            this.auditingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).BeginInit();
            this.bdNP.SuspendLayout();
            this.tSpM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation_Des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAddDetail
            // 
            this.Adapter.SetAccessRight(this.btnAddDetail, "btnEquipAdjustMag");
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(49, 22);
            this.btnAddDetail.Text = "新增";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.Adapter.SetAccessRight(this.btnDelDetail, "btnEquipAdjustMag");
            this.btnDelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDelDetail.Image")));
            this.btnDelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnDelDetail.Text = "删除";
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "btnEquipAdjustMag");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmDetail
            // 
            this.Adapter.SetAccessRight(this.btnConfirmDetail, "btnEquipAdjustMag");
            this.btnConfirmDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmDetail.Image")));
            this.btnConfirmDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmDetail.Name = "btnConfirmDetail";
            this.btnConfirmDetail.Size = new System.Drawing.Size(55, 22);
            this.btnConfirmDetail.Text = "确定 ";
            this.btnConfirmDetail.Click += new System.EventHandler(this.btnConfirmDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.Adapter.SetAccessRight(this.btnCancelDetail, "btnEquipAdjustMag");
            this.btnCancelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDetail.Image")));
            this.btnCancelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnCancelDetail.Text = "取消";
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // btnAddMain
            // 
            this.Adapter.SetAccessRight(this.btnAddMain, "btnEquipAdjustMag");
            this.btnAddMain.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMain.Image")));
            this.btnAddMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(65, 40);
            this.btnAddMain.Text = "新增";
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // btnDelMain
            // 
            this.Adapter.SetAccessRight(this.btnDelMain, "btnEquipAdjustMag");
            this.btnDelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnDelMain.Image")));
            this.btnDelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelMain.Name = "btnDelMain";
            this.btnDelMain.Size = new System.Drawing.Size(65, 40);
            this.btnDelMain.Text = "删除";
            this.btnDelMain.Click += new System.EventHandler(this.btnDelMain_Click);
            // 
            // toolStripSeparator10
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator10, "btnEquipAdjustMag");
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirmMain
            // 
            this.Adapter.SetAccessRight(this.btnConfirmMain, "btnEquipAdjustMag");
            this.btnConfirmMain.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmMain.Image")));
            this.btnConfirmMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmMain.Name = "btnConfirmMain";
            this.btnConfirmMain.Size = new System.Drawing.Size(65, 40);
            this.btnConfirmMain.Text = "确定";
            this.btnConfirmMain.Click += new System.EventHandler(this.btnConfirmMain_Click);
            // 
            // btnExlMain
            // 
            this.Adapter.SetAccessRight(this.btnExlMain, "btnEquipAdjustMag");
            this.btnExlMain.Image = ((System.Drawing.Image)(resources.GetObject("btnExlMain.Image")));
            this.btnExlMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExlMain.Name = "btnExlMain";
            this.btnExlMain.Size = new System.Drawing.Size(107, 40);
            this.btnExlMain.Text = "导出到Excel";
            this.btnExlMain.Click += new System.EventHandler(this.btnExlMain_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(55, 22);
            this.btnCheck.Text = "审 核";
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteCalibration";
            this.dsMain.InsertMethod = "NewCalibration";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = "Location is not null order by Location";
            this.dsMain.SourceMethod = "QueryCalibration";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Unit_Mag\\EquipMag";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = "ModifyCalibration";
            this.dsMain.UpdateTrigger = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.l3CommandParameter1);
            this.cmdMain.Parameters.Add(this.l3CommandParameter3);
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
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableLogID,
            this.coldsMainL3DataTableLocation,
            this.coldsMainL3DataTableLocation_Des,
            this.coldsMainL3DataTableMeter,
            this.coldsMainL3DataTableMeter_Size,
            this.coldsMainL3DataTableRange,
            this.coldsMainL3DataTablePrecision,
            this.coldsMainL3DataTableFactory,
            this.coldsMainL3DataTableMeasure_ID,
            this.coldsMainL3DataTableStandard_Equ,
            this.coldsMainL3DataTableScale_Min,
            this.coldsMainL3DataTableCreate_Time,
            this.coldsMainL3DataTableAuditing_Time,
            this.coldsMainL3DataTableAssessor,
            this.coldsMainL3DataTableResult,
            this.coldsMainL3DataTableStatus,
            this.coldsMainL3DataTableCheck_Date});
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
            this.coldsMainL3DataTableNAME.Caption = "Name";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "Operator";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableLogID
            // 
            this.coldsMainL3DataTableLogID.Caption = "LogID";
            this.coldsMainL3DataTableLogID.ColumnName = "LogID";
            this.coldsMainL3DataTableLogID.DefaultValue = "";
            this.coldsMainL3DataTableLogID.Namespace = "";
            // 
            // coldsMainL3DataTableLocation
            // 
            this.coldsMainL3DataTableLocation.Caption = "Location";
            this.coldsMainL3DataTableLocation.ColumnName = "Location";
            this.coldsMainL3DataTableLocation.DefaultValue = "";
            this.coldsMainL3DataTableLocation.Namespace = "";
            // 
            // coldsMainL3DataTableLocation_Des
            // 
            this.coldsMainL3DataTableLocation_Des.Caption = "Location_Des";
            this.coldsMainL3DataTableLocation_Des.ColumnName = "Location_Des";
            this.coldsMainL3DataTableLocation_Des.DefaultValue = "";
            this.coldsMainL3DataTableLocation_Des.Namespace = "";
            // 
            // coldsMainL3DataTableMeter
            // 
            this.coldsMainL3DataTableMeter.Caption = "Meter";
            this.coldsMainL3DataTableMeter.ColumnName = "Meter";
            this.coldsMainL3DataTableMeter.DefaultValue = "";
            this.coldsMainL3DataTableMeter.Namespace = "";
            // 
            // coldsMainL3DataTableMeter_Size
            // 
            this.coldsMainL3DataTableMeter_Size.Caption = "Meter_Size";
            this.coldsMainL3DataTableMeter_Size.ColumnName = "Meter_Size";
            this.coldsMainL3DataTableMeter_Size.DefaultValue = "";
            this.coldsMainL3DataTableMeter_Size.Namespace = "";
            // 
            // coldsMainL3DataTableRange
            // 
            this.coldsMainL3DataTableRange.Caption = "Range";
            this.coldsMainL3DataTableRange.ColumnName = "Range";
            this.coldsMainL3DataTableRange.DefaultValue = "";
            this.coldsMainL3DataTableRange.Namespace = "";
            // 
            // coldsMainL3DataTablePrecision
            // 
            this.coldsMainL3DataTablePrecision.Caption = "Precision";
            this.coldsMainL3DataTablePrecision.ColumnName = "Precision";
            this.coldsMainL3DataTablePrecision.DefaultValue = "";
            this.coldsMainL3DataTablePrecision.Namespace = "";
            // 
            // coldsMainL3DataTableFactory
            // 
            this.coldsMainL3DataTableFactory.Caption = "Factory";
            this.coldsMainL3DataTableFactory.ColumnName = "Factory";
            this.coldsMainL3DataTableFactory.DefaultValue = "";
            this.coldsMainL3DataTableFactory.Namespace = "";
            // 
            // coldsMainL3DataTableMeasure_ID
            // 
            this.coldsMainL3DataTableMeasure_ID.Caption = "Measure_ID";
            this.coldsMainL3DataTableMeasure_ID.ColumnName = "Measure_ID";
            this.coldsMainL3DataTableMeasure_ID.DefaultValue = "";
            this.coldsMainL3DataTableMeasure_ID.Namespace = "";
            // 
            // coldsMainL3DataTableStandard_Equ
            // 
            this.coldsMainL3DataTableStandard_Equ.Caption = "Standard_Equ";
            this.coldsMainL3DataTableStandard_Equ.ColumnName = "Standard_Equ";
            this.coldsMainL3DataTableStandard_Equ.DefaultValue = "";
            this.coldsMainL3DataTableStandard_Equ.Namespace = "";
            // 
            // coldsMainL3DataTableScale_Min
            // 
            this.coldsMainL3DataTableScale_Min.Caption = "Scale_Min";
            this.coldsMainL3DataTableScale_Min.ColumnName = "Scale_Min";
            this.coldsMainL3DataTableScale_Min.DefaultValue = "";
            this.coldsMainL3DataTableScale_Min.Namespace = "";
            // 
            // coldsMainL3DataTableCreate_Time
            // 
            this.coldsMainL3DataTableCreate_Time.Caption = "Create_Time";
            this.coldsMainL3DataTableCreate_Time.ColumnName = "Create_Time";
            this.coldsMainL3DataTableCreate_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCreate_Time.Namespace = "";
            // 
            // coldsMainL3DataTableAuditing_Time
            // 
            this.coldsMainL3DataTableAuditing_Time.Caption = "Auditing_Time";
            this.coldsMainL3DataTableAuditing_Time.ColumnName = "Auditing_Time";
            this.coldsMainL3DataTableAuditing_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableAuditing_Time.Namespace = "";
            // 
            // coldsMainL3DataTableAssessor
            // 
            this.coldsMainL3DataTableAssessor.Caption = "Assessor";
            this.coldsMainL3DataTableAssessor.ColumnName = "Assessor";
            this.coldsMainL3DataTableAssessor.DefaultValue = "";
            this.coldsMainL3DataTableAssessor.Namespace = "";
            // 
            // coldsMainL3DataTableResult
            // 
            this.coldsMainL3DataTableResult.Caption = "Result";
            this.coldsMainL3DataTableResult.ColumnName = "Result";
            this.coldsMainL3DataTableResult.DefaultValue = "";
            this.coldsMainL3DataTableResult.Namespace = "";
            // 
            // coldsMainL3DataTableStatus
            // 
            this.coldsMainL3DataTableStatus.Caption = "Status";
            this.coldsMainL3DataTableStatus.ColumnName = "Status";
            this.coldsMainL3DataTableStatus.DataType = typeof(int);
            this.coldsMainL3DataTableStatus.DefaultValue = 0;
            this.coldsMainL3DataTableStatus.Namespace = "";
            // 
            // coldsMainL3DataTableCheck_Date
            // 
            this.coldsMainL3DataTableCheck_Date.Caption = "Check_Date";
            this.coldsMainL3DataTableCheck_Date.ColumnName = "Check_Date";
            this.coldsMainL3DataTableCheck_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCheck_Date.Namespace = "";
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "L3DataTable";
            this.bsDetail.DataSource = this.dsDetail;
            // 
            // dsDetail
            // 
            this.dsDetail.AutoSubscribe = false;
            this.dsDetail.DataSetName = "L3DataSet";
            this.dsDetail.DeleteMethod = "DeleteCalibrationDetail";
            this.dsDetail.InsertMethod = "NewCalibrationDetail";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "Click";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 1000;
            this.dsDetail.SourceCommand = this.cmdDetail;
            this.dsDetail.SourceCondition = null;
            this.dsDetail.SourceMethod = "QueryCalibrationDetail";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDetail.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Unit_Mag\\EquipMag";
            this.dsDetail.SubscribeTarget = "";
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "Click";
            this.dsDetail.UpdateMethod = "ModifyCalibrationDetail";
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
            this.coldsDetailL3DataTableLogID,
            this.coldsDetailL3DataTableCreate_Time,
            this.coldsDetailL3DataTableLoad_B_Std,
            this.coldsDetailL3DataTableLoad_B_Act,
            this.coldsDetailL3DataTableLoad_B_Dif,
            this.coldsDetailL3DataTableUnLoad_B_Std,
            this.coldsDetailL3DataTableUnLoad_B_Act,
            this.coldsDetailL3DataTableUnLoad_B_Dif,
            this.coldsDetailL3DataTableLoad_A_Std,
            this.coldsDetailL3DataTableLoad_A_Act,
            this.coldsDetailL3DataTableLoad_A_Dif,
            this.coldsDetailL3DataTableUnLoad_A_Std,
            this.coldsDetailL3DataTableUnLoad_A_Act,
            this.coldsDetailL3DataTableUnLoad_A_Dif});
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
            this.coldsDetailL3DataTableNAME.Caption = "Name";
            this.coldsDetailL3DataTableNAME.ColumnName = "NAME";
            this.coldsDetailL3DataTableNAME.DefaultValue = "";
            this.coldsDetailL3DataTableNAME.Namespace = "";
            // 
            // coldsDetailL3DataTableLogID
            // 
            this.coldsDetailL3DataTableLogID.Caption = "LogID";
            this.coldsDetailL3DataTableLogID.ColumnName = "LogID";
            this.coldsDetailL3DataTableLogID.DefaultValue = "";
            this.coldsDetailL3DataTableLogID.Namespace = "";
            // 
            // coldsDetailL3DataTableCreate_Time
            // 
            this.coldsDetailL3DataTableCreate_Time.Caption = "Create_Time";
            this.coldsDetailL3DataTableCreate_Time.ColumnName = "Create_Time";
            this.coldsDetailL3DataTableCreate_Time.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableCreate_Time.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_B_Std
            // 
            this.coldsDetailL3DataTableLoad_B_Std.Caption = "Load_B_Std";
            this.coldsDetailL3DataTableLoad_B_Std.ColumnName = "Load_B_Std";
            this.coldsDetailL3DataTableLoad_B_Std.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_B_Std.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_B_Act
            // 
            this.coldsDetailL3DataTableLoad_B_Act.Caption = "Load_B_Act";
            this.coldsDetailL3DataTableLoad_B_Act.ColumnName = "Load_B_Act";
            this.coldsDetailL3DataTableLoad_B_Act.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_B_Act.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_B_Dif
            // 
            this.coldsDetailL3DataTableLoad_B_Dif.Caption = "Load_B_Dif";
            this.coldsDetailL3DataTableLoad_B_Dif.ColumnName = "Load_B_Dif";
            this.coldsDetailL3DataTableLoad_B_Dif.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_B_Dif.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_B_Std
            // 
            this.coldsDetailL3DataTableUnLoad_B_Std.Caption = "UnLoad_B_Std";
            this.coldsDetailL3DataTableUnLoad_B_Std.ColumnName = "UnLoad_B_Std";
            this.coldsDetailL3DataTableUnLoad_B_Std.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_B_Std.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_B_Act
            // 
            this.coldsDetailL3DataTableUnLoad_B_Act.Caption = "UnLoad_B_Act";
            this.coldsDetailL3DataTableUnLoad_B_Act.ColumnName = "UnLoad_B_Act";
            this.coldsDetailL3DataTableUnLoad_B_Act.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_B_Act.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_B_Dif
            // 
            this.coldsDetailL3DataTableUnLoad_B_Dif.Caption = "UnLoad_B_Dif";
            this.coldsDetailL3DataTableUnLoad_B_Dif.ColumnName = "UnLoad_B_Dif";
            this.coldsDetailL3DataTableUnLoad_B_Dif.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_B_Dif.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_A_Std
            // 
            this.coldsDetailL3DataTableLoad_A_Std.Caption = "Load_A_Std";
            this.coldsDetailL3DataTableLoad_A_Std.ColumnName = "Load_A_Std";
            this.coldsDetailL3DataTableLoad_A_Std.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_A_Std.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_A_Act
            // 
            this.coldsDetailL3DataTableLoad_A_Act.Caption = "Load_A_Act";
            this.coldsDetailL3DataTableLoad_A_Act.ColumnName = "Load_A_Act";
            this.coldsDetailL3DataTableLoad_A_Act.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_A_Act.Namespace = "";
            // 
            // coldsDetailL3DataTableLoad_A_Dif
            // 
            this.coldsDetailL3DataTableLoad_A_Dif.Caption = "Load_A_Dif";
            this.coldsDetailL3DataTableLoad_A_Dif.ColumnName = "Load_A_Dif";
            this.coldsDetailL3DataTableLoad_A_Dif.DefaultValue = "";
            this.coldsDetailL3DataTableLoad_A_Dif.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_A_Std
            // 
            this.coldsDetailL3DataTableUnLoad_A_Std.Caption = "UnLoad_A_Std";
            this.coldsDetailL3DataTableUnLoad_A_Std.ColumnName = "UnLoad_A_Std";
            this.coldsDetailL3DataTableUnLoad_A_Std.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_A_Std.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_A_Act
            // 
            this.coldsDetailL3DataTableUnLoad_A_Act.Caption = "UnLoad_A_Act";
            this.coldsDetailL3DataTableUnLoad_A_Act.ColumnName = "UnLoad_A_Act";
            this.coldsDetailL3DataTableUnLoad_A_Act.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_A_Act.Namespace = "";
            // 
            // coldsDetailL3DataTableUnLoad_A_Dif
            // 
            this.coldsDetailL3DataTableUnLoad_A_Dif.Caption = "UnLoad_A_Dif";
            this.coldsDetailL3DataTableUnLoad_A_Dif.ColumnName = "UnLoad_A_Dif";
            this.coldsDetailL3DataTableUnLoad_A_Dif.DefaultValue = "";
            this.coldsDetailL3DataTableUnLoad_A_Dif.Namespace = "";
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
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tSpM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bnMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dvMain, 0, 2);
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
            this.tabPage1.Text = "设备校准实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AllowUserToDeleteRows = false;
            this.dvDetail.AllowUserToResizeRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loadBStdDataGridViewTextBoxColumn,
            this.loadBActDataGridViewTextBoxColumn,
            this.loadBDifDataGridViewTextBoxColumn,
            this.unLoadBStdDataGridViewTextBoxColumn,
            this.unLoadBActDataGridViewTextBoxColumn,
            this.unLoadBDifDataGridViewTextBoxColumn,
            this.loadAStdDataGridViewTextBoxColumn,
            this.loadAActDataGridViewTextBoxColumn,
            this.loadADifDataGridViewTextBoxColumn,
            this.unLoadAStdDataGridViewTextBoxColumn,
            this.unLoadAActDataGridViewTextBoxColumn,
            this.unLoadADifDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1,
            this.logIDDataGridViewTextBoxColumn1});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 25);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.MultiSelect = false;
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(992, 229);
            this.dvDetail.TabIndex = 24;
            this.dvDetail.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvDetail_CellMouseDoubleClick);
            this.dvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDetail_DataError);
            // 
            // loadBStdDataGridViewTextBoxColumn
            // 
            this.loadBStdDataGridViewTextBoxColumn.DataPropertyName = "Load_B_Std";
            this.loadBStdDataGridViewTextBoxColumn.HeaderText = "调整前加载标值";
            this.loadBStdDataGridViewTextBoxColumn.Name = "loadBStdDataGridViewTextBoxColumn";
            this.loadBStdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadBStdDataGridViewTextBoxColumn.Width = 114;
            // 
            // loadBActDataGridViewTextBoxColumn
            // 
            this.loadBActDataGridViewTextBoxColumn.DataPropertyName = "Load_B_Act";
            this.loadBActDataGridViewTextBoxColumn.HeaderText = "调整前加载示值";
            this.loadBActDataGridViewTextBoxColumn.Name = "loadBActDataGridViewTextBoxColumn";
            this.loadBActDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadBActDataGridViewTextBoxColumn.Width = 114;
            // 
            // loadBDifDataGridViewTextBoxColumn
            // 
            this.loadBDifDataGridViewTextBoxColumn.DataPropertyName = "Load_B_Dif";
            this.loadBDifDataGridViewTextBoxColumn.HeaderText = "调整前加载差值";
            this.loadBDifDataGridViewTextBoxColumn.Name = "loadBDifDataGridViewTextBoxColumn";
            this.loadBDifDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadBDifDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadBStdDataGridViewTextBoxColumn
            // 
            this.unLoadBStdDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_B_Std";
            this.unLoadBStdDataGridViewTextBoxColumn.HeaderText = "调整前卸载标值";
            this.unLoadBStdDataGridViewTextBoxColumn.Name = "unLoadBStdDataGridViewTextBoxColumn";
            this.unLoadBStdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadBStdDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadBActDataGridViewTextBoxColumn
            // 
            this.unLoadBActDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_B_Act";
            this.unLoadBActDataGridViewTextBoxColumn.HeaderText = "调整前卸载示值";
            this.unLoadBActDataGridViewTextBoxColumn.Name = "unLoadBActDataGridViewTextBoxColumn";
            this.unLoadBActDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadBActDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadBDifDataGridViewTextBoxColumn
            // 
            this.unLoadBDifDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_B_Dif";
            this.unLoadBDifDataGridViewTextBoxColumn.HeaderText = "调整前卸载差值";
            this.unLoadBDifDataGridViewTextBoxColumn.Name = "unLoadBDifDataGridViewTextBoxColumn";
            this.unLoadBDifDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadBDifDataGridViewTextBoxColumn.Width = 114;
            // 
            // loadAStdDataGridViewTextBoxColumn
            // 
            this.loadAStdDataGridViewTextBoxColumn.DataPropertyName = "Load_A_Std";
            this.loadAStdDataGridViewTextBoxColumn.HeaderText = "调整后加载标值";
            this.loadAStdDataGridViewTextBoxColumn.Name = "loadAStdDataGridViewTextBoxColumn";
            this.loadAStdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadAStdDataGridViewTextBoxColumn.Width = 114;
            // 
            // loadAActDataGridViewTextBoxColumn
            // 
            this.loadAActDataGridViewTextBoxColumn.DataPropertyName = "Load_A_Act";
            this.loadAActDataGridViewTextBoxColumn.HeaderText = "调整后加载示值";
            this.loadAActDataGridViewTextBoxColumn.Name = "loadAActDataGridViewTextBoxColumn";
            this.loadAActDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadAActDataGridViewTextBoxColumn.Width = 114;
            // 
            // loadADifDataGridViewTextBoxColumn
            // 
            this.loadADifDataGridViewTextBoxColumn.DataPropertyName = "Load_A_Dif";
            this.loadADifDataGridViewTextBoxColumn.HeaderText = "调整后加载差值";
            this.loadADifDataGridViewTextBoxColumn.Name = "loadADifDataGridViewTextBoxColumn";
            this.loadADifDataGridViewTextBoxColumn.ReadOnly = true;
            this.loadADifDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadAStdDataGridViewTextBoxColumn
            // 
            this.unLoadAStdDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_A_Std";
            this.unLoadAStdDataGridViewTextBoxColumn.HeaderText = "调整后卸载标值";
            this.unLoadAStdDataGridViewTextBoxColumn.Name = "unLoadAStdDataGridViewTextBoxColumn";
            this.unLoadAStdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadAStdDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadAActDataGridViewTextBoxColumn
            // 
            this.unLoadAActDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_A_Act";
            this.unLoadAActDataGridViewTextBoxColumn.HeaderText = "调整后卸载示值";
            this.unLoadAActDataGridViewTextBoxColumn.Name = "unLoadAActDataGridViewTextBoxColumn";
            this.unLoadAActDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadAActDataGridViewTextBoxColumn.Width = 114;
            // 
            // unLoadADifDataGridViewTextBoxColumn
            // 
            this.unLoadADifDataGridViewTextBoxColumn.DataPropertyName = "UnLoad_A_Dif";
            this.unLoadADifDataGridViewTextBoxColumn.HeaderText = "调整后卸载差值";
            this.unLoadADifDataGridViewTextBoxColumn.Name = "unLoadADifDataGridViewTextBoxColumn";
            this.unLoadADifDataGridViewTextBoxColumn.ReadOnly = true;
            this.unLoadADifDataGridViewTextBoxColumn.Width = 114;
            // 
            // createTimeDataGridViewTextBoxColumn1
            // 
            this.createTimeDataGridViewTextBoxColumn1.DataPropertyName = "Create_Time";
            this.createTimeDataGridViewTextBoxColumn1.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn1.Name = "createTimeDataGridViewTextBoxColumn1";
            this.createTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 52;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn1.Visible = false;
            this.nAMEDataGridViewTextBoxColumn1.Width = 52;
            // 
            // logIDDataGridViewTextBoxColumn1
            // 
            this.logIDDataGridViewTextBoxColumn1.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn1.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn1.Name = "logIDDataGridViewTextBoxColumn1";
            this.logIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.logIDDataGridViewTextBoxColumn1.Visible = false;
            this.logIDDataGridViewTextBoxColumn1.Width = 58;
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
            this.btnCancelDetail});
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
            // tSpM
            // 
            this.tSpM.AutoSize = false;
            this.tSpM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSpM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSpM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
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
            // btnCancelMain
            // 
            this.btnCancelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMain.Image")));
            this.btnCancelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(65, 40);
            this.btnCancelMain.Text = "取消";
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
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
            this.dtEnd,
            this.toolStripLabel8,
            this.dtStart,
            this.toolStripLabel9,
            this.btnCheck});
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
            this.toolStripLabel3.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel3.Text = "设备校准管理";
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
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AllowUserToDeleteRows = false;
            this.dvMain.AllowUserToResizeRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.locationDesDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.meterSizeDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.precisionDataGridViewTextBoxColumn,
            this.factoryDataGridViewTextBoxColumn,
            this.measureIDDataGridViewTextBoxColumn,
            this.standardEquDataGridViewTextBoxColumn,
            this.scaleMinDataGridViewTextBoxColumn,
            this.checkDateDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditingTimeDataGridViewTextBoxColumn,
            this.assessorDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.logIDDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 71);
            this.dvMain.MultiSelect = false;
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMain.Size = new System.Drawing.Size(994, 347);
            this.dvMain.TabIndex = 28;
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            this.dvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvMain_CellMouseDoubleClick);
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            this.dvMain.CurrentCellChanged += new System.EventHandler(this.dvMain_CurrentCellChanged);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.DataSource = this.dsLocation;
            this.locationDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.locationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.locationDataGridViewTextBoxColumn.HeaderText = "处所";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.locationDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsLocation
            // 
            this.dsLocation.AutoSubscribe = false;
            this.dsLocation.DataSetName = "L3DataSet";
            this.dsLocation.DeleteMethod = "";
            this.dsLocation.InsertMethod = "";
            this.dsLocation.L3DataAdapter = this.Adapter;
            this.dsLocation.LoadEvent = "Click";
            this.dsLocation.LoadTrigger = null;
            this.dsLocation.RefreshValve = 1000;
            this.dsLocation.SourceCommand = null;
            this.dsLocation.SourceCondition = "Code_Group = \'Location\' order by Code";
            this.dsLocation.SourceMethod = "";
            this.dsLocation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation.SubscribeTarget = "";
            this.dsLocation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLocation});
            this.dsLocation.UpdateEvent = "Click";
            this.dsLocation.UpdateMethod = "";
            this.dsLocation.UpdateTrigger = null;
            // 
            // schemadsLocation
            // 
            this.schemadsLocation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLocationL3DataTableCode,
            this.coldsLocationL3DataTableCode_Des,
            this.coldsLocationL3DataTableCode_Group,
            this.coldsLocationL3DataTableCode_Group_Des});
            this.schemadsLocation.TableName = "L3DataTable";
            // 
            // coldsLocationL3DataTableCode
            // 
            this.coldsLocationL3DataTableCode.Caption = "Code";
            this.coldsLocationL3DataTableCode.ColumnName = "Code";
            this.coldsLocationL3DataTableCode.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Des
            // 
            this.coldsLocationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group
            // 
            this.coldsLocationL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group_Des
            // 
            this.coldsLocationL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.Namespace = "";
            // 
            // locationDesDataGridViewTextBoxColumn
            // 
            this.locationDesDataGridViewTextBoxColumn.DataPropertyName = "Location_Des";
            this.locationDesDataGridViewTextBoxColumn.DataSource = this.dsLocation_Des;
            this.locationDesDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.locationDesDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.locationDesDataGridViewTextBoxColumn.HeaderText = "处所描述";
            this.locationDesDataGridViewTextBoxColumn.Name = "locationDesDataGridViewTextBoxColumn";
            this.locationDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationDesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationDesDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.locationDesDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsLocation_Des
            // 
            this.dsLocation_Des.AutoSubscribe = false;
            this.dsLocation_Des.DataSetName = "L3DataSet";
            this.dsLocation_Des.DeleteMethod = "";
            this.dsLocation_Des.InsertMethod = "";
            this.dsLocation_Des.L3DataAdapter = this.Adapter;
            this.dsLocation_Des.LoadEvent = "Click";
            this.dsLocation_Des.LoadTrigger = null;
            this.dsLocation_Des.RefreshValve = 1000;
            this.dsLocation_Des.SourceCommand = null;
            this.dsLocation_Des.SourceCondition = "Code_Group = \'Location_Des\' order by Code";
            this.dsLocation_Des.SourceMethod = "";
            this.dsLocation_Des.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation_Des.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation_Des.SubscribeTarget = "";
            this.dsLocation_Des.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLocation_Des});
            this.dsLocation_Des.UpdateEvent = "Click";
            this.dsLocation_Des.UpdateMethod = "";
            this.dsLocation_Des.UpdateTrigger = null;
            // 
            // schemadsLocation_Des
            // 
            this.schemadsLocation_Des.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLocation_DesL3DataTableCode,
            this.coldsLocation_DesL3DataTableCode_Des,
            this.coldsLocation_DesL3DataTableCode_Group,
            this.coldsLocation_DesL3DataTableCode_Group_Des});
            this.schemadsLocation_Des.TableName = "L3DataTable";
            // 
            // coldsLocation_DesL3DataTableCode
            // 
            this.coldsLocation_DesL3DataTableCode.Caption = "Code";
            this.coldsLocation_DesL3DataTableCode.ColumnName = "Code";
            this.coldsLocation_DesL3DataTableCode.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Des
            // 
            this.coldsLocation_DesL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLocation_DesL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLocation_DesL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Group
            // 
            this.coldsLocation_DesL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsLocation_DesL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsLocation_DesL3DataTableCode_Group.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Group_Des
            // 
            this.coldsLocation_DesL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsLocation_DesL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsLocation_DesL3DataTableCode_Group_Des.Namespace = "";
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "仪表名称";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterDataGridViewTextBoxColumn.Width = 78;
            // 
            // meterSizeDataGridViewTextBoxColumn
            // 
            this.meterSizeDataGridViewTextBoxColumn.DataPropertyName = "Meter_Size";
            this.meterSizeDataGridViewTextBoxColumn.HeaderText = "仪表型号";
            this.meterSizeDataGridViewTextBoxColumn.Name = "meterSizeDataGridViewTextBoxColumn";
            this.meterSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterSizeDataGridViewTextBoxColumn.Width = 78;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "测量范围";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rangeDataGridViewTextBoxColumn.Width = 78;
            // 
            // precisionDataGridViewTextBoxColumn
            // 
            this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
            this.precisionDataGridViewTextBoxColumn.HeaderText = "准确度";
            this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
            this.precisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.precisionDataGridViewTextBoxColumn.Width = 66;
            // 
            // factoryDataGridViewTextBoxColumn
            // 
            this.factoryDataGridViewTextBoxColumn.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn.HeaderText = "厂家";
            this.factoryDataGridViewTextBoxColumn.Name = "factoryDataGridViewTextBoxColumn";
            this.factoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.factoryDataGridViewTextBoxColumn.Width = 54;
            // 
            // measureIDDataGridViewTextBoxColumn
            // 
            this.measureIDDataGridViewTextBoxColumn.DataPropertyName = "Measure_ID";
            this.measureIDDataGridViewTextBoxColumn.HeaderText = "计量编号";
            this.measureIDDataGridViewTextBoxColumn.Name = "measureIDDataGridViewTextBoxColumn";
            this.measureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.measureIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // standardEquDataGridViewTextBoxColumn
            // 
            this.standardEquDataGridViewTextBoxColumn.DataPropertyName = "Standard_Equ";
            this.standardEquDataGridViewTextBoxColumn.HeaderText = "标准器";
            this.standardEquDataGridViewTextBoxColumn.Name = "standardEquDataGridViewTextBoxColumn";
            this.standardEquDataGridViewTextBoxColumn.ReadOnly = true;
            this.standardEquDataGridViewTextBoxColumn.Width = 66;
            // 
            // scaleMinDataGridViewTextBoxColumn
            // 
            this.scaleMinDataGridViewTextBoxColumn.DataPropertyName = "Scale_Min";
            this.scaleMinDataGridViewTextBoxColumn.HeaderText = "最小分度值";
            this.scaleMinDataGridViewTextBoxColumn.Name = "scaleMinDataGridViewTextBoxColumn";
            this.scaleMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.scaleMinDataGridViewTextBoxColumn.Width = 90;
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "Check_Date";
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "校准日期";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            this.checkDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 66;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "检验结论";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsCheck;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Desc";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.ID";
            this.statusDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsCheck
            // 
            this.dsCheck.AutoSubscribe = false;
            this.dsCheck.DataSetName = "L3DataSet";
            this.dsCheck.DeleteMethod = "";
            this.dsCheck.InsertMethod = "";
            this.dsCheck.L3DataAdapter = null;
            this.dsCheck.LoadEvent = "Click";
            this.dsCheck.LoadTrigger = null;
            this.dsCheck.RefreshValve = 1000;
            this.dsCheck.SourceCommand = null;
            this.dsCheck.SourceCondition = "";
            this.dsCheck.SourceMethod = "";
            this.dsCheck.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsCheck.SourceURI = "";
            this.dsCheck.SubscribeTarget = "";
            this.dsCheck.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCheck});
            this.dsCheck.UpdateEvent = "Click";
            this.dsCheck.UpdateMethod = "";
            this.dsCheck.UpdateTrigger = null;
            // 
            // schemadsCheck
            // 
            this.schemadsCheck.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCheckL3DataTableID,
            this.coldsCheckL3DataTableDesc});
            this.schemadsCheck.TableName = "L3DataTable";
            // 
            // coldsCheckL3DataTableID
            // 
            this.coldsCheckL3DataTableID.Caption = "ID";
            this.coldsCheckL3DataTableID.ColumnName = "ID";
            this.coldsCheckL3DataTableID.DataType = typeof(int);
            this.coldsCheckL3DataTableID.Namespace = "";
            // 
            // coldsCheckL3DataTableDesc
            // 
            this.coldsCheckL3DataTableDesc.Caption = "Desc";
            this.coldsCheckL3DataTableDesc.ColumnName = "Desc";
            this.coldsCheckL3DataTableDesc.Namespace = "";
            // 
            // auditingTimeDataGridViewTextBoxColumn
            // 
            this.auditingTimeDataGridViewTextBoxColumn.DataPropertyName = "Auditing_Time";
            this.auditingTimeDataGridViewTextBoxColumn.HeaderText = "审核时刻";
            this.auditingTimeDataGridViewTextBoxColumn.Name = "auditingTimeDataGridViewTextBoxColumn";
            this.auditingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditingTimeDataGridViewTextBoxColumn.Visible = false;
            this.auditingTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // assessorDataGridViewTextBoxColumn
            // 
            this.assessorDataGridViewTextBoxColumn.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn.HeaderText = "审核人";
            this.assessorDataGridViewTextBoxColumn.Name = "assessorDataGridViewTextBoxColumn";
            this.assessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.assessorDataGridViewTextBoxColumn.Visible = false;
            this.assessorDataGridViewTextBoxColumn.Width = 66;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "Create_Time";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 78;
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
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            this.logIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.logIDDataGridViewTextBoxColumn.Visible = false;
            this.logIDDataGridViewTextBoxColumn.Width = 60;
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
            // EquipAdjustMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipAdjustMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "称重设备校准管理";
            this.Text = "称重设备校准管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EquipAdjustMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.FinLadleBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation_Des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCheck)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnAddMain;
        private System.Windows.Forms.ToolStripButton btnDelMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnConfirmMain;
        private System.Windows.Forms.ToolStripButton btnCancelMain;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3Command cmdDetail;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableNAME;
        private System.Windows.Forms.ToolStripButton btnExlMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsMainL3DataTableLogID;
        private System.Data.DataColumn coldsMainL3DataTableLocation;
        private System.Data.DataColumn coldsMainL3DataTableLocation_Des;
        private System.Data.DataColumn coldsMainL3DataTableMeter;
        private System.Data.DataColumn coldsMainL3DataTableMeter_Size;
        private System.Data.DataColumn coldsMainL3DataTableRange;
        private System.Data.DataColumn coldsMainL3DataTablePrecision;
        private System.Data.DataColumn coldsMainL3DataTableFactory;
        private System.Data.DataColumn coldsMainL3DataTableMeasure_ID;
        private System.Data.DataColumn coldsMainL3DataTableStandard_Equ;
        private System.Data.DataColumn coldsMainL3DataTableScale_Min;
        private System.Data.DataColumn coldsMainL3DataTableCreate_Time;
        private System.Data.DataColumn coldsMainL3DataTableAuditing_Time;
        private System.Data.DataColumn coldsMainL3DataTableAssessor;
        private System.Data.DataColumn coldsMainL3DataTableResult;
        private System.Data.DataColumn coldsMainL3DataTableStatus;
        private System.Data.DataColumn coldsDetailL3DataTableLogID;
        private System.Data.DataColumn coldsDetailL3DataTableCreate_Time;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_B_Std;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_B_Act;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_B_Dif;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_B_Std;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_B_Act;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_B_Dif;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_A_Std;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_A_Act;
        private System.Data.DataColumn coldsDetailL3DataTableLoad_A_Dif;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_A_Std;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_A_Act;
        private System.Data.DataColumn coldsDetailL3DataTableUnLoad_A_Dif;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadBStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadBActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadBDifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadBStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadBActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadBDifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadAStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadAActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadADifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadAStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadAActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoadADifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn1;
        private System.Data.DataColumn coldsMainL3DataTableCheck_Date;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private AppSvrHMI.L3DataSet dsCheck;
        private System.Data.DataTable schemadsCheck;
        private System.Data.DataColumn coldsCheckL3DataTableID;
        private System.Data.DataColumn coldsCheckL3DataTableDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsLocation;
        private System.Data.DataTable schemadsLocation;
        private System.Data.DataColumn coldsLocationL3DataTableCode;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Des;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationDesDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsLocation_Des;
        private System.Data.DataTable schemadsLocation_Des;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Des;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Group;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardEquDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scaleMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
    }
}