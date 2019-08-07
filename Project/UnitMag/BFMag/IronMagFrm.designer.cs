namespace UnitMag.BFMag
{
    partial class IronMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBFSample = new System.Windows.Forms.ToolStripButton();
            this.btnDisSSample = new System.Windows.Forms.ToolStripButton();
            this.menuSouresHF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSoureS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGross = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToIron = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToNC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToSteelAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnIronSlagSample = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.BFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPC_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIromSource = new AppSvrHMI.L3DataSet();
            this.schemadsIromSource = new System.Data.DataTable();
            this.coldsIromSourceL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIromSourceL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.Destination = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronDestination = new AppSvrHMI.L3DataSet();
            this.schemadsIronDestination = new System.Data.DataTable();
            this.coldsIronDestinationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronDestinationL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curr_Tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NC_Confirm_Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samplePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IronStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IronConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenuStripModifyWT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bsBFIron = new System.Windows.Forms.BindingSource(this.components);
            this.dsBFIron = new AppSvrHMI.L3DataSet();
            this.schemadsBFIron = new System.Data.DataTable();
            this.coldsBFIronL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBFIronL3DataTablePosition = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableBFID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSource = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableDestination = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableShift = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableOperator = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableResult = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableC = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSi = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableMn = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableS = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableP = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTi = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableFeed_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSend_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSampCode = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableIronConfirm = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableC_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSi_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableMn_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableS_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableP_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTi_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableGrossFlag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTareFlag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableAnalysisFlag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSn = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSb = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableAs = new System.Data.DataColumn();
            this.coldsBFIronL3DataTablePb = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSn_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSb_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableAs_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTablePb_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableOperator_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableDeSFlag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableDeSType = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNi = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableMo = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCu = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCr = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableB = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableV = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableAl = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNb = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableZn = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableW = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNi_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableMo_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCu_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCr_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableB_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableV_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableAl_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNb_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableZn_B = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableW_B = new System.Data.DataColumn();
            this.dsSendFlag = new AppSvrHMI.L3DataSet();
            this.schemadsSendFlag = new System.Data.DataTable();
            this.coldsSendFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsSendFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsIronResult = new AppSvrHMI.L3DataSet();
            this.schemadsIronResult = new System.Data.DataTable();
            this.coldsIronResultL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronResultL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsIronStatus = new AppSvrHMI.L3DataSet();
            this.schemadsIronStatus = new System.Data.DataTable();
            this.coldsIronStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.session1 = new AppSvrIF.Session(this.components);
            this.cmdDesignatePath = new AppSvrHMI.L3Command(this.components);
            this.cmdpPath = new AppSvrHMI.L3CommandParameter();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmdSendIronDataToNC = new AppSvrHMI.L3Command(this.components);
            this.cmdpTapNo = new AppSvrHMI.L3CommandParameter();
            this.cmdModifySource = new AppSvrHMI.L3Command(this.components);
            this.cmdSource = new AppSvrHMI.L3CommandParameter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIromSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIromSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).BeginInit();
            this.ctxtMenuStripModifyWT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnDelBFIron");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnDelBFIron");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnDelBFIron");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnDelBFIron");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator3, "btnDelBFIron");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnBFSample
            // 
            this.Adapter.SetAccessRight(this.btnBFSample, "btnBFSample");
            this.btnBFSample.Image = ((System.Drawing.Image)(resources.GetObject("btnBFSample.Image")));
            this.btnBFSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBFSample.Name = "btnBFSample";
            this.btnBFSample.Size = new System.Drawing.Size(113, 40);
            this.btnBFSample.Text = "铁沟样委托单";
            this.btnBFSample.Click += new System.EventHandler(this.btnBFSample_Click);
            // 
            // btnDisSSample
            // 
            this.Adapter.SetAccessRight(this.btnDisSSample, "btnDisSSample");
            this.btnDisSSample.Image = ((System.Drawing.Image)(resources.GetObject("btnDisSSample.Image")));
            this.btnDisSSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisSSample.Name = "btnDisSSample";
            this.btnDisSSample.Size = new System.Drawing.Size(101, 40);
            this.btnDisSSample.Text = "脱硫委托单";
            this.btnDisSSample.Visible = false;
            this.btnDisSSample.Click += new System.EventHandler(this.btnDisSSample_Click);
            // 
            // menuSouresHF
            // 
            this.Adapter.SetAccessRight(this.menuSouresHF, "menuSouresHF");
            this.menuSouresHF.Name = "menuSouresHF";
            this.menuSouresHF.Size = new System.Drawing.Size(166, 22);
            this.menuSouresHF.Text = "高炉铁水(&H)...";
            this.menuSouresHF.Click += new System.EventHandler(this.menuSouresHF_Click);
            // 
            // menuSoureS
            // 
            this.Adapter.SetAccessRight(this.menuSoureS, "menuSoureS");
            this.menuSoureS.Enabled = false;
            this.menuSoureS.Name = "menuSoureS";
            this.menuSoureS.Size = new System.Drawing.Size(166, 22);
            this.menuSoureS.Text = "脱硫站铁水(&S)...";
            this.menuSoureS.Click += new System.EventHandler(this.menuSoureS_Click);
            // 
            // menuGross
            // 
            this.Adapter.SetAccessRight(this.menuGross, "menuGross");
            this.menuGross.Name = "menuGross";
            this.menuGross.Size = new System.Drawing.Size(166, 22);
            this.menuGross.Text = "设定毛重(&G)...";
            this.menuGross.Click += new System.EventHandler(this.menuGross_Click);
            // 
            // menuTare
            // 
            this.Adapter.SetAccessRight(this.menuTare, "menuTare");
            this.menuTare.Name = "menuTare";
            this.menuTare.Size = new System.Drawing.Size(166, 22);
            this.menuTare.Text = "设定净重(&T)...";
            this.menuTare.Click += new System.EventHandler(this.menuTare_Click);
            // 
            // menuToIron
            // 
            this.Adapter.SetAccessRight(this.menuToIron, "menuToIron");
            this.menuToIron.Name = "menuToIron";
            this.menuToIron.Size = new System.Drawing.Size(166, 22);
            this.menuToIron.Text = "去铸铁(&I)...";
            this.menuToIron.Click += new System.EventHandler(this.menuToIron_Click);
            // 
            // menuToNC
            // 
            this.Adapter.SetAccessRight(this.menuToNC, "menuToNC");
            this.menuToNC.Name = "menuToNC";
            this.menuToNC.Size = new System.Drawing.Size(166, 22);
            this.menuToNC.Text = "上传NC(&N)...";
            this.menuToNC.Click += new System.EventHandler(this.menuToNC_Click);
            // 
            // menuToSteelAgain
            // 
            this.Adapter.SetAccessRight(this.menuToSteelAgain, "menuGross");
            this.menuToSteelAgain.Name = "menuToSteelAgain";
            this.menuToSteelAgain.Size = new System.Drawing.Size(166, 22);
            this.menuToSteelAgain.Text = "重去炼钢(&L)...";
            this.menuToSteelAgain.Click += new System.EventHandler(this.menuToSteelAgain_Click);
            // 
            // toolStripSeparator7
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator7, "menuGross");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "menuGross");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripSeparator6
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator6, "menuToNC");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
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
            this.btnBFSample,
            this.btnDisSSample,
            this.btnIronSlagSample,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.toolStripButton1});
            this.tSp1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 13;
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
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnIronSlagSample
            // 
            this.btnIronSlagSample.Image = ((System.Drawing.Image)(resources.GetObject("btnIronSlagSample.Image")));
            this.btnIronSlagSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIronSlagSample.Name = "btnIronSlagSample";
            this.btnIronSlagSample.Size = new System.Drawing.Size(113, 40);
            this.btnIronSlagSample.Text = "铁渣样委托单";
            this.btnIronSlagSample.Click += new System.EventHandler(this.btnIronSlagSample_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 40);
            this.btnRefresh.Text = "刷新";
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
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\' and code is not null";
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
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode_Val_Long});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Val_Long
            // 
            this.coldsShiftIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsShiftIDL3DataTableCode_Val_Long.Namespace = "";
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
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\' and code is not null";
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
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode_Val_Long});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Val_Long
            // 
            this.coldsTeamIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsTeamIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 182);
            this.hmiRootPanel1.TabIndex = 22;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvM.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BFID,
            this.TAP_No,
            this.TPC_No,
            this.Name_GroupNo,
            this.Source,
            this.Destination,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.Sn,
            this.Sb,
            this.As,
            this.Pb,
            this.Ni,
            this.Mo,
            this.Cu,
            this.Cr,
            this.B,
            this.V,
            this.Al,
            this.Nb,
            this.Zn,
            this.W,
            this.Gross_Weight,
            this.Curr_Tare,
            this.Net_Weight,
            this.teamDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.MaterialID,
            this.statusDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.qAStatusDataGridViewTextBoxColumn,
            this.qALevelDataGridViewTextBoxColumn,
            this.orderContractIDDataGridViewTextBoxColumn,
            this.produceContractIDDataGridViewTextBoxColumn,
            this.salesContractIDDataGridViewTextBoxColumn,
            this.NC_Confirm_Flag,
            this.Result,
            this.samplePlaceDataGridViewTextBoxColumn,
            this.lastTareDataGridViewTextBoxColumn,
            this.spareWeightDataGridViewTextBoxColumn,
            this.IronStatus,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.feedTimeDataGridViewTextBoxColumn,
            this.sendTimeDataGridViewTextBoxColumn,
            this.sampCodeDataGridViewTextBoxColumn,
            this.IronConfirm,
            this.GrossFlag,
            this.TareFlag,
            this.AnalysisFlag});
            this.dvM.ContextMenuStrip = this.ctxtMenuStripModifyWT;
            this.dvM.DataSource = this.bsBFIron;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvM.DefaultCellStyle = dataGridViewCellStyle25;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.MultiSelect = false;
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(996, 178);
            this.dvM.TabIndex = 25;
            this.dvM.Sorted += new System.EventHandler(this.dvM_Sorted);
            this.dvM.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvM_RowPostPaint);
            this.dvM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvM.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dvM_RowContextMenuStripNeeded);
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            this.dvM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvM_DataBindingComplete);
            // 
            // BFID
            // 
            this.BFID.DataPropertyName = "BFID";
            this.BFID.Frozen = true;
            this.BFID.HeaderText = "高炉炉号";
            this.BFID.Name = "BFID";
            this.BFID.ReadOnly = true;
            this.BFID.Width = 78;
            // 
            // TAP_No
            // 
            this.TAP_No.DataPropertyName = "TAP_No";
            this.TAP_No.Frozen = true;
            this.TAP_No.HeaderText = "铁次号";
            this.TAP_No.Name = "TAP_No";
            this.TAP_No.ReadOnly = true;
            this.TAP_No.Width = 66;
            // 
            // TPC_No
            // 
            this.TPC_No.DataPropertyName = "TPC_No";
            this.TPC_No.Frozen = true;
            this.TPC_No.HeaderText = "罐号";
            this.TPC_No.Name = "TPC_No";
            this.TPC_No.ReadOnly = true;
            this.TPC_No.Width = 54;
            // 
            // Name_GroupNo
            // 
            this.Name_GroupNo.DataPropertyName = "Name";
            this.Name_GroupNo.Frozen = true;
            this.Name_GroupNo.HeaderText = "组号";
            this.Name_GroupNo.Name = "Name_GroupNo";
            this.Name_GroupNo.ReadOnly = true;
            this.Name_GroupNo.Width = 54;
            // 
            // Source
            // 
            this.Source.DataPropertyName = "Source";
            this.Source.DataSource = this.dsIromSource;
            this.Source.DisplayMember = "L3DataTable.Code_Des";
            this.Source.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Source.HeaderText = "铁水来源\r\n";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Source.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Source.ValueMember = "L3DataTable.Code_Val_Long";
            this.Source.Width = 78;
            // 
            // dsIromSource
            // 
            this.dsIromSource.AutoLoad = true;
            this.dsIromSource.AutoSubscribe = false;
            this.dsIromSource.DataSetName = "L3DataSet";
            this.dsIromSource.DeleteMethod = null;
            this.dsIromSource.InsertMethod = null;
            this.dsIromSource.L3DataAdapter = this.Adapter;
            this.dsIromSource.LoadEvent = "Click";
            this.dsIromSource.LoadTrigger = null;
            this.dsIromSource.RefreshValve = 1000;
            this.dsIromSource.SourceCommand = null;
            this.dsIromSource.SourceCondition = "CODE_GROUP = \'Iron_Source\' and Code_Des is not null";
            this.dsIromSource.SourceMethod = "";
            this.dsIromSource.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIromSource.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIromSource.SubscribeTarget = null;
            this.dsIromSource.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIromSource});
            this.dsIromSource.UpdateEvent = "Click";
            this.dsIromSource.UpdateMethod = null;
            this.dsIromSource.UpdateTrigger = null;
            // 
            // schemadsIromSource
            // 
            this.schemadsIromSource.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIromSourceL3DataTableCode_Des,
            this.coldsIromSourceL3DataTableCode_Val_Long});
            this.schemadsIromSource.TableName = "L3DataTable";
            // 
            // coldsIromSourceL3DataTableCode_Des
            // 
            this.coldsIromSourceL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIromSourceL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIromSourceL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIromSourceL3DataTableCode_Val_Long
            // 
            this.coldsIromSourceL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIromSourceL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIromSourceL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIromSourceL3DataTableCode_Val_Long.Namespace = "";
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.DataSource = this.dsIronDestination;
            this.Destination.DisplayMember = "L3DataTable.Code_Des";
            this.Destination.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Destination.HeaderText = "去向\r\n";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Destination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Destination.ValueMember = "L3DataTable.Code_Val_Long";
            this.Destination.Width = 54;
            // 
            // dsIronDestination
            // 
            this.dsIronDestination.AutoLoad = true;
            this.dsIronDestination.AutoSubscribe = false;
            this.dsIronDestination.DataSetName = "L3DataSet";
            this.dsIronDestination.DeleteMethod = null;
            this.dsIronDestination.InsertMethod = null;
            this.dsIronDestination.L3DataAdapter = this.Adapter;
            this.dsIronDestination.LoadEvent = "Click";
            this.dsIronDestination.LoadTrigger = null;
            this.dsIronDestination.RefreshValve = 1000;
            this.dsIronDestination.SourceCommand = null;
            this.dsIronDestination.SourceCondition = "CODE_GROUP = \'Iron_Destination\'";
            this.dsIronDestination.SourceMethod = "";
            this.dsIronDestination.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronDestination.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronDestination.SubscribeTarget = null;
            this.dsIronDestination.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronDestination});
            this.dsIronDestination.UpdateEvent = "Click";
            this.dsIronDestination.UpdateMethod = null;
            this.dsIronDestination.UpdateTrigger = null;
            // 
            // schemadsIronDestination
            // 
            this.schemadsIronDestination.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronDestinationL3DataTableCode_Des,
            this.coldsIronDestinationL3DataTableCode_Val_Long});
            this.schemadsIronDestination.TableName = "L3DataTable";
            // 
            // coldsIronDestinationL3DataTableCode_Des
            // 
            this.coldsIronDestinationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronDestinationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronDestinationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronDestinationL3DataTableCode_Val_Long
            // 
            this.coldsIronDestinationL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronDestinationL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronDestinationL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronDestinationL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.cDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.siDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.mnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            this.sDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = "0";
            this.pDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = "0";
            this.tiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = "0";
            this.Sn.DefaultCellStyle = dataGridViewCellStyle8;
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.ReadOnly = true;
            this.Sn.Width = 42;
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = "0";
            this.Sb.DefaultCellStyle = dataGridViewCellStyle9;
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            this.Sb.ReadOnly = true;
            this.Sb.Width = 42;
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = "0";
            this.As.DefaultCellStyle = dataGridViewCellStyle10;
            this.As.HeaderText = "As";
            this.As.Name = "As";
            this.As.ReadOnly = true;
            this.As.Width = 42;
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = "0";
            this.Pb.DefaultCellStyle = dataGridViewCellStyle11;
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            this.Pb.ReadOnly = true;
            this.Pb.Width = 42;
            // 
            // Ni
            // 
            this.Ni.DataPropertyName = "Ni";
            dataGridViewCellStyle12.Format = "N3";
            dataGridViewCellStyle12.NullValue = "0";
            this.Ni.DefaultCellStyle = dataGridViewCellStyle12;
            this.Ni.HeaderText = "Ni";
            this.Ni.Name = "Ni";
            this.Ni.ReadOnly = true;
            this.Ni.Width = 42;
            // 
            // Mo
            // 
            this.Mo.DataPropertyName = "Mo";
            dataGridViewCellStyle13.Format = "N3";
            dataGridViewCellStyle13.NullValue = "0";
            this.Mo.DefaultCellStyle = dataGridViewCellStyle13;
            this.Mo.HeaderText = "Mo";
            this.Mo.Name = "Mo";
            this.Mo.ReadOnly = true;
            this.Mo.Width = 42;
            // 
            // Cu
            // 
            this.Cu.DataPropertyName = "Cu";
            dataGridViewCellStyle14.Format = "N3";
            dataGridViewCellStyle14.NullValue = "0";
            this.Cu.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cu.HeaderText = "Cu";
            this.Cu.Name = "Cu";
            this.Cu.ReadOnly = true;
            this.Cu.Width = 42;
            // 
            // Cr
            // 
            this.Cr.DataPropertyName = "Cr";
            dataGridViewCellStyle15.Format = "N3";
            dataGridViewCellStyle15.NullValue = "0";
            this.Cr.DefaultCellStyle = dataGridViewCellStyle15;
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            this.Cr.ReadOnly = true;
            this.Cr.Width = 42;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            dataGridViewCellStyle16.Format = "N3";
            dataGridViewCellStyle16.NullValue = "0";
            this.B.DefaultCellStyle = dataGridViewCellStyle16;
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 36;
            // 
            // V
            // 
            this.V.DataPropertyName = "V";
            dataGridViewCellStyle17.Format = "N3";
            dataGridViewCellStyle17.NullValue = "0";
            this.V.DefaultCellStyle = dataGridViewCellStyle17;
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 36;
            // 
            // Al
            // 
            this.Al.DataPropertyName = "Al";
            dataGridViewCellStyle18.Format = "N3";
            dataGridViewCellStyle18.NullValue = "0";
            this.Al.DefaultCellStyle = dataGridViewCellStyle18;
            this.Al.HeaderText = "Al";
            this.Al.Name = "Al";
            this.Al.ReadOnly = true;
            this.Al.Width = 42;
            // 
            // Nb
            // 
            this.Nb.DataPropertyName = "Nb";
            dataGridViewCellStyle19.Format = "N3";
            dataGridViewCellStyle19.NullValue = "0";
            this.Nb.DefaultCellStyle = dataGridViewCellStyle19;
            this.Nb.HeaderText = "Nb";
            this.Nb.Name = "Nb";
            this.Nb.ReadOnly = true;
            this.Nb.Width = 42;
            // 
            // Zn
            // 
            this.Zn.DataPropertyName = "Zn";
            dataGridViewCellStyle20.Format = "N3";
            dataGridViewCellStyle20.NullValue = "0";
            this.Zn.DefaultCellStyle = dataGridViewCellStyle20;
            this.Zn.HeaderText = "Zn";
            this.Zn.Name = "Zn";
            this.Zn.ReadOnly = true;
            this.Zn.Width = 42;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            dataGridViewCellStyle21.Format = "N3";
            dataGridViewCellStyle21.NullValue = "0";
            this.W.DefaultCellStyle = dataGridViewCellStyle21;
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 36;
            // 
            // Gross_Weight
            // 
            this.Gross_Weight.DataPropertyName = "Gross_Weight";
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = "0";
            this.Gross_Weight.DefaultCellStyle = dataGridViewCellStyle22;
            this.Gross_Weight.HeaderText = "毛重[t]";
            this.Gross_Weight.Name = "Gross_Weight";
            this.Gross_Weight.ReadOnly = true;
            this.Gross_Weight.Width = 72;
            // 
            // Curr_Tare
            // 
            this.Curr_Tare.DataPropertyName = "Curr_Tare";
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = "0";
            this.Curr_Tare.DefaultCellStyle = dataGridViewCellStyle23;
            this.Curr_Tare.HeaderText = "皮重[t]";
            this.Curr_Tare.Name = "Curr_Tare";
            this.Curr_Tare.ReadOnly = true;
            this.Curr_Tare.Visible = false;
            this.Curr_Tare.Width = 72;
            // 
            // Net_Weight
            // 
            this.Net_Weight.DataPropertyName = "Net_Weight";
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = "0";
            this.Net_Weight.DefaultCellStyle = dataGridViewCellStyle24;
            this.Net_Weight.HeaderText = "净重[t]";
            this.Net_Weight.Name = "Net_Weight";
            this.Net_Weight.ReadOnly = true;
            this.Net_Weight.Visible = false;
            this.Net_Weight.Width = 72;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.Visible = false;
            this.MaterialID.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 66;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Visible = false;
            this.positionDataGridViewTextBoxColumn.Width = 78;
            // 
            // qAStatusDataGridViewTextBoxColumn
            // 
            this.qAStatusDataGridViewTextBoxColumn.DataPropertyName = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.HeaderText = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.Name = "qAStatusDataGridViewTextBoxColumn";
            this.qAStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.qAStatusDataGridViewTextBoxColumn.Visible = false;
            this.qAStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // qALevelDataGridViewTextBoxColumn
            // 
            this.qALevelDataGridViewTextBoxColumn.DataPropertyName = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.HeaderText = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.Name = "qALevelDataGridViewTextBoxColumn";
            this.qALevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.qALevelDataGridViewTextBoxColumn.Visible = false;
            this.qALevelDataGridViewTextBoxColumn.Width = 72;
            // 
            // orderContractIDDataGridViewTextBoxColumn
            // 
            this.orderContractIDDataGridViewTextBoxColumn.DataPropertyName = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.HeaderText = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.Name = "orderContractIDDataGridViewTextBoxColumn";
            this.orderContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderContractIDDataGridViewTextBoxColumn.Visible = false;
            this.orderContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // produceContractIDDataGridViewTextBoxColumn
            // 
            this.produceContractIDDataGridViewTextBoxColumn.DataPropertyName = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.HeaderText = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.Name = "produceContractIDDataGridViewTextBoxColumn";
            this.produceContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.produceContractIDDataGridViewTextBoxColumn.Visible = false;
            this.produceContractIDDataGridViewTextBoxColumn.Width = 132;
            // 
            // salesContractIDDataGridViewTextBoxColumn
            // 
            this.salesContractIDDataGridViewTextBoxColumn.DataPropertyName = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.HeaderText = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.Name = "salesContractIDDataGridViewTextBoxColumn";
            this.salesContractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesContractIDDataGridViewTextBoxColumn.Visible = false;
            this.salesContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // NC_Confirm_Flag
            // 
            this.NC_Confirm_Flag.DataPropertyName = "NC_Confirm_Flag";
            this.NC_Confirm_Flag.HeaderText = "已发电文标志";
            this.NC_Confirm_Flag.Name = "NC_Confirm_Flag";
            this.NC_Confirm_Flag.ReadOnly = true;
            this.NC_Confirm_Flag.Visible = false;
            this.NC_Confirm_Flag.Width = 102;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "成分判定结果\r\n(1:合格\r\n2:不合格\r\n0: 未判定)";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Visible = false;
            this.Result.Width = 102;
            // 
            // samplePlaceDataGridViewTextBoxColumn
            // 
            this.samplePlaceDataGridViewTextBoxColumn.DataPropertyName = "Sample_Place";
            this.samplePlaceDataGridViewTextBoxColumn.HeaderText = "采样地点";
            this.samplePlaceDataGridViewTextBoxColumn.Name = "samplePlaceDataGridViewTextBoxColumn";
            this.samplePlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.samplePlaceDataGridViewTextBoxColumn.Visible = false;
            this.samplePlaceDataGridViewTextBoxColumn.Width = 78;
            // 
            // lastTareDataGridViewTextBoxColumn
            // 
            this.lastTareDataGridViewTextBoxColumn.DataPropertyName = "Last_Tare";
            this.lastTareDataGridViewTextBoxColumn.HeaderText = "上次皮重";
            this.lastTareDataGridViewTextBoxColumn.Name = "lastTareDataGridViewTextBoxColumn";
            this.lastTareDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastTareDataGridViewTextBoxColumn.Visible = false;
            this.lastTareDataGridViewTextBoxColumn.Width = 78;
            // 
            // spareWeightDataGridViewTextBoxColumn
            // 
            this.spareWeightDataGridViewTextBoxColumn.DataPropertyName = "Spare_Weight";
            this.spareWeightDataGridViewTextBoxColumn.HeaderText = "剩余重量";
            this.spareWeightDataGridViewTextBoxColumn.Name = "spareWeightDataGridViewTextBoxColumn";
            this.spareWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.spareWeightDataGridViewTextBoxColumn.Visible = false;
            this.spareWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // IronStatus
            // 
            this.IronStatus.DataPropertyName = "IronStatus";
            this.IronStatus.HeaderText = "状态\r\n";
            this.IronStatus.Name = "IronStatus";
            this.IronStatus.ReadOnly = true;
            this.IronStatus.Visible = false;
            this.IronStatus.Width = 54;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Arrival_Time";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "到达时刻";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalTimeDataGridViewTextBoxColumn.Visible = false;
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // feedTimeDataGridViewTextBoxColumn
            // 
            this.feedTimeDataGridViewTextBoxColumn.DataPropertyName = "Feed_Time";
            this.feedTimeDataGridViewTextBoxColumn.HeaderText = "兑入时刻";
            this.feedTimeDataGridViewTextBoxColumn.Name = "feedTimeDataGridViewTextBoxColumn";
            this.feedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedTimeDataGridViewTextBoxColumn.Visible = false;
            this.feedTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // sendTimeDataGridViewTextBoxColumn
            // 
            this.sendTimeDataGridViewTextBoxColumn.DataPropertyName = "Send_Time";
            this.sendTimeDataGridViewTextBoxColumn.HeaderText = "送NC时刻";
            this.sendTimeDataGridViewTextBoxColumn.Name = "sendTimeDataGridViewTextBoxColumn";
            this.sendTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sendTimeDataGridViewTextBoxColumn.Visible = false;
            this.sendTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampCodeDataGridViewTextBoxColumn
            // 
            this.sampCodeDataGridViewTextBoxColumn.DataPropertyName = "SampCode";
            this.sampCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampCodeDataGridViewTextBoxColumn.Name = "sampCodeDataGridViewTextBoxColumn";
            this.sampCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampCodeDataGridViewTextBoxColumn.Visible = false;
            this.sampCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // IronConfirm
            // 
            this.IronConfirm.DataPropertyName = "IronConfirm";
            this.IronConfirm.HeaderText = "已发电文标志";
            this.IronConfirm.Name = "IronConfirm";
            this.IronConfirm.ReadOnly = true;
            this.IronConfirm.Visible = false;
            this.IronConfirm.Width = 102;
            // 
            // GrossFlag
            // 
            this.GrossFlag.DataPropertyName = "GrossFlag";
            this.GrossFlag.HeaderText = "毛重标志";
            this.GrossFlag.Name = "GrossFlag";
            this.GrossFlag.ReadOnly = true;
            this.GrossFlag.Visible = false;
            this.GrossFlag.Width = 78;
            // 
            // TareFlag
            // 
            this.TareFlag.DataPropertyName = "TareFlag";
            this.TareFlag.HeaderText = "皮重标志";
            this.TareFlag.Name = "TareFlag";
            this.TareFlag.ReadOnly = true;
            this.TareFlag.Visible = false;
            this.TareFlag.Width = 78;
            // 
            // AnalysisFlag
            // 
            this.AnalysisFlag.DataPropertyName = "AnalysisFlag";
            this.AnalysisFlag.HeaderText = "分析标志";
            this.AnalysisFlag.Name = "AnalysisFlag";
            this.AnalysisFlag.ReadOnly = true;
            this.AnalysisFlag.Visible = false;
            this.AnalysisFlag.Width = 78;
            // 
            // ctxtMenuStripModifyWT
            // 
            this.ctxtMenuStripModifyWT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSouresHF,
            this.menuSoureS,
            this.toolStripSeparator7,
            this.menuGross,
            this.menuTare,
            this.toolStripSeparator5,
            this.menuToSteelAgain,
            this.menuToIron,
            this.toolStripSeparator6,
            this.menuToNC});
            this.ctxtMenuStripModifyWT.Name = "ctxtMenuStripModifyWT";
            this.ctxtMenuStripModifyWT.Size = new System.Drawing.Size(167, 176);
            // 
            // bsBFIron
            // 
            this.bsBFIron.DataMember = "L3DataTable";
            this.bsBFIron.DataSource = this.dsBFIron;
            // 
            // dsBFIron
            // 
            this.dsBFIron.AutoLoad = true;
            this.dsBFIron.AutoSubscribe = true;
            this.dsBFIron.DataSetName = "L3DataSet";
            this.dsBFIron.DeleteMethod = "DeleteIronData";
            this.dsBFIron.InsertMethod = "NewIronData";
            this.dsBFIron.L3DataAdapter = this.Adapter;
            this.dsBFIron.LoadEvent = "Click";
            this.dsBFIron.LoadTrigger = this.btnRefresh;
            this.dsBFIron.RefreshValve = 1000;
            this.dsBFIron.SourceCommand = null;
            this.dsBFIron.SourceCondition = "";
            this.dsBFIron.SourceMethod = "GetUnprocessedIrons";
            this.dsBFIron.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsBFIron.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.dsBFIron.SubscribeTarget = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag.EventIronChanged";
            this.dsBFIron.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBFIron});
            this.dsBFIron.UpdateEvent = "Click";
            this.dsBFIron.UpdateMethod = "ModifyIronData";
            this.dsBFIron.UpdateTrigger = null;
            // 
            // schemadsBFIron
            // 
            this.schemadsBFIron.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBFIronL3DataTableMaterialID,
            this.coldsBFIronL3DataTableStatus,
            this.coldsBFIronL3DataTablePosition,
            this.coldsBFIronL3DataTableQAStatus,
            this.coldsBFIronL3DataTableQALevel,
            this.coldsBFIronL3DataTableOrderContractID,
            this.coldsBFIronL3DataTableProduceContractID,
            this.coldsBFIronL3DataTableSalesContractID,
            this.coldsBFIronL3DataTableBFID,
            this.coldsBFIronL3DataTableTAP_No,
            this.coldsBFIronL3DataTableTPC_No,
            this.coldsBFIronL3DataTableSource,
            this.coldsBFIronL3DataTableDestination,
            this.coldsBFIronL3DataTableProduction_Date,
            this.coldsBFIronL3DataTableShift,
            this.coldsBFIronL3DataTableOperator,
            this.coldsBFIronL3DataTableNC_Confirm_Flag,
            this.coldsBFIronL3DataTableTeam,
            this.coldsBFIronL3DataTableResult,
            this.coldsBFIronL3DataTableSample_Place,
            this.coldsBFIronL3DataTableC,
            this.coldsBFIronL3DataTableSi,
            this.coldsBFIronL3DataTableMn,
            this.coldsBFIronL3DataTableS,
            this.coldsBFIronL3DataTableP,
            this.coldsBFIronL3DataTableTi,
            this.coldsBFIronL3DataTableGross_Weight,
            this.coldsBFIronL3DataTableLast_Tare,
            this.coldsBFIronL3DataTableCurr_Tare,
            this.coldsBFIronL3DataTableNet_Weight,
            this.coldsBFIronL3DataTableSpare_Weight,
            this.coldsBFIronL3DataTableIronStatus,
            this.coldsBFIronL3DataTableArrival_Time,
            this.coldsBFIronL3DataTableFeed_Time,
            this.coldsBFIronL3DataTableSend_Time,
            this.coldsBFIronL3DataTableSampCode,
            this.coldsBFIronL3DataTableIronConfirm,
            this.coldsBFIronL3DataTableC_B,
            this.coldsBFIronL3DataTableSi_B,
            this.coldsBFIronL3DataTableMn_B,
            this.coldsBFIronL3DataTableS_B,
            this.coldsBFIronL3DataTableP_B,
            this.coldsBFIronL3DataTableTi_B,
            this.coldsBFIronL3DataTableGrossFlag,
            this.coldsBFIronL3DataTableTareFlag,
            this.coldsBFIronL3DataTableAnalysisFlag,
            this.coldsBFIronL3DataTableSn,
            this.coldsBFIronL3DataTableSb,
            this.coldsBFIronL3DataTableAs,
            this.coldsBFIronL3DataTablePb,
            this.coldsBFIronL3DataTableSn_B,
            this.coldsBFIronL3DataTableSb_B,
            this.coldsBFIronL3DataTableAs_B,
            this.coldsBFIronL3DataTablePb_B,
            this.coldsBFIronL3DataTableOperator_B,
            this.coldsBFIronL3DataTableDeSFlag,
            this.coldsBFIronL3DataTableDeSType,
            this.coldsBFIronL3DataTableNi,
            this.coldsBFIronL3DataTableMo,
            this.coldsBFIronL3DataTableCu,
            this.coldsBFIronL3DataTableCr,
            this.coldsBFIronL3DataTableB,
            this.coldsBFIronL3DataTableV,
            this.coldsBFIronL3DataTableAl,
            this.coldsBFIronL3DataTableNb,
            this.coldsBFIronL3DataTableZn,
            this.coldsBFIronL3DataTableW,
            this.coldsBFIronL3DataTableNi_B,
            this.coldsBFIronL3DataTableMo_B,
            this.coldsBFIronL3DataTableCu_B,
            this.coldsBFIronL3DataTableCr_B,
            this.coldsBFIronL3DataTableB_B,
            this.coldsBFIronL3DataTableV_B,
            this.coldsBFIronL3DataTableAl_B,
            this.coldsBFIronL3DataTableNb_B,
            this.coldsBFIronL3DataTableZn_B,
            this.coldsBFIronL3DataTableW_B});
            this.schemadsBFIron.TableName = "L3DataTable";
            // 
            // coldsBFIronL3DataTableMaterialID
            // 
            this.coldsBFIronL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsBFIronL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsBFIronL3DataTableMaterialID.Namespace = "";
            // 
            // coldsBFIronL3DataTableStatus
            // 
            this.coldsBFIronL3DataTableStatus.Caption = "Status";
            this.coldsBFIronL3DataTableStatus.ColumnName = "Status";
            this.coldsBFIronL3DataTableStatus.DataType = typeof(int);
            this.coldsBFIronL3DataTableStatus.Namespace = "";
            // 
            // coldsBFIronL3DataTablePosition
            // 
            this.coldsBFIronL3DataTablePosition.Caption = "Position";
            this.coldsBFIronL3DataTablePosition.ColumnName = "Position";
            this.coldsBFIronL3DataTablePosition.Namespace = "";
            // 
            // coldsBFIronL3DataTableQAStatus
            // 
            this.coldsBFIronL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsBFIronL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsBFIronL3DataTableQAStatus.DataType = typeof(int);
            this.coldsBFIronL3DataTableQAStatus.Namespace = "";
            // 
            // coldsBFIronL3DataTableQALevel
            // 
            this.coldsBFIronL3DataTableQALevel.Caption = "QALevel";
            this.coldsBFIronL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsBFIronL3DataTableQALevel.DataType = typeof(int);
            this.coldsBFIronL3DataTableQALevel.Namespace = "";
            // 
            // coldsBFIronL3DataTableOrderContractID
            // 
            this.coldsBFIronL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsBFIronL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsBFIronL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsBFIronL3DataTableProduceContractID
            // 
            this.coldsBFIronL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsBFIronL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsBFIronL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsBFIronL3DataTableSalesContractID
            // 
            this.coldsBFIronL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsBFIronL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsBFIronL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsBFIronL3DataTableBFID
            // 
            this.coldsBFIronL3DataTableBFID.Caption = "BFID";
            this.coldsBFIronL3DataTableBFID.ColumnName = "BFID";
            this.coldsBFIronL3DataTableBFID.Namespace = "";
            // 
            // coldsBFIronL3DataTableTAP_No
            // 
            this.coldsBFIronL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsBFIronL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsBFIronL3DataTableTAP_No.Namespace = "";
            // 
            // coldsBFIronL3DataTableTPC_No
            // 
            this.coldsBFIronL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsBFIronL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsBFIronL3DataTableTPC_No.Namespace = "";
            // 
            // coldsBFIronL3DataTableSource
            // 
            this.coldsBFIronL3DataTableSource.Caption = "Source";
            this.coldsBFIronL3DataTableSource.ColumnName = "Source";
            this.coldsBFIronL3DataTableSource.DataType = typeof(int);
            this.coldsBFIronL3DataTableSource.Namespace = "";
            // 
            // coldsBFIronL3DataTableDestination
            // 
            this.coldsBFIronL3DataTableDestination.Caption = "Destination";
            this.coldsBFIronL3DataTableDestination.ColumnName = "Destination";
            this.coldsBFIronL3DataTableDestination.DataType = typeof(int);
            this.coldsBFIronL3DataTableDestination.Namespace = "";
            // 
            // coldsBFIronL3DataTableProduction_Date
            // 
            this.coldsBFIronL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsBFIronL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsBFIronL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsBFIronL3DataTableShift
            // 
            this.coldsBFIronL3DataTableShift.Caption = "Shift";
            this.coldsBFIronL3DataTableShift.ColumnName = "Shift";
            this.coldsBFIronL3DataTableShift.DataType = typeof(int);
            this.coldsBFIronL3DataTableShift.Namespace = "";
            // 
            // coldsBFIronL3DataTableOperator
            // 
            this.coldsBFIronL3DataTableOperator.Caption = "Operator";
            this.coldsBFIronL3DataTableOperator.ColumnName = "Operator";
            this.coldsBFIronL3DataTableOperator.Namespace = "";
            // 
            // coldsBFIronL3DataTableNC_Confirm_Flag
            // 
            this.coldsBFIronL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsBFIronL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsBFIronL3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.coldsBFIronL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsBFIronL3DataTableTeam
            // 
            this.coldsBFIronL3DataTableTeam.Caption = "Team";
            this.coldsBFIronL3DataTableTeam.ColumnName = "Team";
            this.coldsBFIronL3DataTableTeam.DataType = typeof(int);
            this.coldsBFIronL3DataTableTeam.Namespace = "";
            // 
            // coldsBFIronL3DataTableResult
            // 
            this.coldsBFIronL3DataTableResult.Caption = "Result";
            this.coldsBFIronL3DataTableResult.ColumnName = "Result";
            this.coldsBFIronL3DataTableResult.DataType = typeof(int);
            this.coldsBFIronL3DataTableResult.Namespace = "";
            // 
            // coldsBFIronL3DataTableSample_Place
            // 
            this.coldsBFIronL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsBFIronL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsBFIronL3DataTableSample_Place.Namespace = "";
            // 
            // coldsBFIronL3DataTableC
            // 
            this.coldsBFIronL3DataTableC.Caption = "C";
            this.coldsBFIronL3DataTableC.ColumnName = "C";
            this.coldsBFIronL3DataTableC.Namespace = "";
            // 
            // coldsBFIronL3DataTableSi
            // 
            this.coldsBFIronL3DataTableSi.Caption = "Si";
            this.coldsBFIronL3DataTableSi.ColumnName = "Si";
            this.coldsBFIronL3DataTableSi.Namespace = "";
            // 
            // coldsBFIronL3DataTableMn
            // 
            this.coldsBFIronL3DataTableMn.Caption = "Mn";
            this.coldsBFIronL3DataTableMn.ColumnName = "Mn";
            this.coldsBFIronL3DataTableMn.Namespace = "";
            // 
            // coldsBFIronL3DataTableS
            // 
            this.coldsBFIronL3DataTableS.Caption = "S";
            this.coldsBFIronL3DataTableS.ColumnName = "S";
            this.coldsBFIronL3DataTableS.Namespace = "";
            // 
            // coldsBFIronL3DataTableP
            // 
            this.coldsBFIronL3DataTableP.Caption = "P";
            this.coldsBFIronL3DataTableP.ColumnName = "P";
            this.coldsBFIronL3DataTableP.Namespace = "";
            // 
            // coldsBFIronL3DataTableTi
            // 
            this.coldsBFIronL3DataTableTi.Caption = "Ti";
            this.coldsBFIronL3DataTableTi.ColumnName = "Ti";
            this.coldsBFIronL3DataTableTi.Namespace = "";
            // 
            // coldsBFIronL3DataTableGross_Weight
            // 
            this.coldsBFIronL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsBFIronL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsBFIronL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsBFIronL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableLast_Tare
            // 
            this.coldsBFIronL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsBFIronL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsBFIronL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsBFIronL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsBFIronL3DataTableCurr_Tare
            // 
            this.coldsBFIronL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsBFIronL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsBFIronL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsBFIronL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsBFIronL3DataTableNet_Weight
            // 
            this.coldsBFIronL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsBFIronL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsBFIronL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsBFIronL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableSpare_Weight
            // 
            this.coldsBFIronL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsBFIronL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsBFIronL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsBFIronL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableIronStatus
            // 
            this.coldsBFIronL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsBFIronL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsBFIronL3DataTableIronStatus.DataType = typeof(int);
            this.coldsBFIronL3DataTableIronStatus.Namespace = "";
            // 
            // coldsBFIronL3DataTableArrival_Time
            // 
            this.coldsBFIronL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsBFIronL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsBFIronL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableFeed_Time
            // 
            this.coldsBFIronL3DataTableFeed_Time.Caption = "Feed_Time";
            this.coldsBFIronL3DataTableFeed_Time.ColumnName = "Feed_Time";
            this.coldsBFIronL3DataTableFeed_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableFeed_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableSend_Time
            // 
            this.coldsBFIronL3DataTableSend_Time.Caption = "Send_Time";
            this.coldsBFIronL3DataTableSend_Time.ColumnName = "Send_Time";
            this.coldsBFIronL3DataTableSend_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableSend_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableSampCode
            // 
            this.coldsBFIronL3DataTableSampCode.Caption = "SampCode";
            this.coldsBFIronL3DataTableSampCode.ColumnName = "SampCode";
            this.coldsBFIronL3DataTableSampCode.Namespace = "";
            // 
            // coldsBFIronL3DataTableIronConfirm
            // 
            this.coldsBFIronL3DataTableIronConfirm.Caption = "IronConfirm";
            this.coldsBFIronL3DataTableIronConfirm.ColumnName = "IronConfirm";
            this.coldsBFIronL3DataTableIronConfirm.DataType = typeof(int);
            this.coldsBFIronL3DataTableIronConfirm.Namespace = "";
            // 
            // coldsBFIronL3DataTableC_B
            // 
            this.coldsBFIronL3DataTableC_B.Caption = "C_B";
            this.coldsBFIronL3DataTableC_B.ColumnName = "C_B";
            this.coldsBFIronL3DataTableC_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableSi_B
            // 
            this.coldsBFIronL3DataTableSi_B.Caption = "Si_B";
            this.coldsBFIronL3DataTableSi_B.ColumnName = "Si_B";
            this.coldsBFIronL3DataTableSi_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableMn_B
            // 
            this.coldsBFIronL3DataTableMn_B.Caption = "Mn_B";
            this.coldsBFIronL3DataTableMn_B.ColumnName = "Mn_B";
            this.coldsBFIronL3DataTableMn_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableS_B
            // 
            this.coldsBFIronL3DataTableS_B.Caption = "S_B";
            this.coldsBFIronL3DataTableS_B.ColumnName = "S_B";
            this.coldsBFIronL3DataTableS_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableP_B
            // 
            this.coldsBFIronL3DataTableP_B.Caption = "P_B";
            this.coldsBFIronL3DataTableP_B.ColumnName = "P_B";
            this.coldsBFIronL3DataTableP_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableTi_B
            // 
            this.coldsBFIronL3DataTableTi_B.Caption = "Ti_B";
            this.coldsBFIronL3DataTableTi_B.ColumnName = "Ti_B";
            this.coldsBFIronL3DataTableTi_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableGrossFlag
            // 
            this.coldsBFIronL3DataTableGrossFlag.Caption = "GrossFlag";
            this.coldsBFIronL3DataTableGrossFlag.ColumnName = "GrossFlag";
            this.coldsBFIronL3DataTableGrossFlag.DataType = typeof(int);
            this.coldsBFIronL3DataTableGrossFlag.Namespace = "";
            // 
            // coldsBFIronL3DataTableTareFlag
            // 
            this.coldsBFIronL3DataTableTareFlag.Caption = "TareFlag";
            this.coldsBFIronL3DataTableTareFlag.ColumnName = "TareFlag";
            this.coldsBFIronL3DataTableTareFlag.DataType = typeof(int);
            this.coldsBFIronL3DataTableTareFlag.Namespace = "";
            // 
            // coldsBFIronL3DataTableAnalysisFlag
            // 
            this.coldsBFIronL3DataTableAnalysisFlag.Caption = "AnalysisFlag";
            this.coldsBFIronL3DataTableAnalysisFlag.ColumnName = "AnalysisFlag";
            this.coldsBFIronL3DataTableAnalysisFlag.DataType = typeof(int);
            this.coldsBFIronL3DataTableAnalysisFlag.Namespace = "";
            // 
            // coldsBFIronL3DataTableSn
            // 
            this.coldsBFIronL3DataTableSn.Caption = "Sn";
            this.coldsBFIronL3DataTableSn.ColumnName = "Sn";
            this.coldsBFIronL3DataTableSn.Namespace = "";
            // 
            // coldsBFIronL3DataTableSb
            // 
            this.coldsBFIronL3DataTableSb.Caption = "Sb";
            this.coldsBFIronL3DataTableSb.ColumnName = "Sb";
            this.coldsBFIronL3DataTableSb.Namespace = "";
            // 
            // coldsBFIronL3DataTableAs
            // 
            this.coldsBFIronL3DataTableAs.Caption = "As";
            this.coldsBFIronL3DataTableAs.ColumnName = "As";
            this.coldsBFIronL3DataTableAs.Namespace = "";
            // 
            // coldsBFIronL3DataTablePb
            // 
            this.coldsBFIronL3DataTablePb.Caption = "Pb";
            this.coldsBFIronL3DataTablePb.ColumnName = "Pb";
            this.coldsBFIronL3DataTablePb.Namespace = "";
            // 
            // coldsBFIronL3DataTableSn_B
            // 
            this.coldsBFIronL3DataTableSn_B.Caption = "Sn_B";
            this.coldsBFIronL3DataTableSn_B.ColumnName = "Sn_B";
            this.coldsBFIronL3DataTableSn_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableSb_B
            // 
            this.coldsBFIronL3DataTableSb_B.Caption = "Sb_B";
            this.coldsBFIronL3DataTableSb_B.ColumnName = "Sb_B";
            this.coldsBFIronL3DataTableSb_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableAs_B
            // 
            this.coldsBFIronL3DataTableAs_B.Caption = "As_B";
            this.coldsBFIronL3DataTableAs_B.ColumnName = "As_B";
            this.coldsBFIronL3DataTableAs_B.Namespace = "";
            // 
            // coldsBFIronL3DataTablePb_B
            // 
            this.coldsBFIronL3DataTablePb_B.Caption = "Pb_B";
            this.coldsBFIronL3DataTablePb_B.ColumnName = "Pb_B";
            this.coldsBFIronL3DataTablePb_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableOperator_B
            // 
            this.coldsBFIronL3DataTableOperator_B.Caption = "Operator_B";
            this.coldsBFIronL3DataTableOperator_B.ColumnName = "Operator_B";
            this.coldsBFIronL3DataTableOperator_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableDeSFlag
            // 
            this.coldsBFIronL3DataTableDeSFlag.Caption = "DeSFlag";
            this.coldsBFIronL3DataTableDeSFlag.ColumnName = "DeSFlag";
            this.coldsBFIronL3DataTableDeSFlag.DataType = typeof(int);
            this.coldsBFIronL3DataTableDeSFlag.Namespace = "";
            // 
            // coldsBFIronL3DataTableDeSType
            // 
            this.coldsBFIronL3DataTableDeSType.Caption = "DeSType";
            this.coldsBFIronL3DataTableDeSType.ColumnName = "DeSType";
            this.coldsBFIronL3DataTableDeSType.DataType = typeof(int);
            this.coldsBFIronL3DataTableDeSType.Namespace = "";
            // 
            // coldsBFIronL3DataTableNi
            // 
            this.coldsBFIronL3DataTableNi.Caption = "Ni";
            this.coldsBFIronL3DataTableNi.ColumnName = "Ni";
            this.coldsBFIronL3DataTableNi.Namespace = "";
            // 
            // coldsBFIronL3DataTableMo
            // 
            this.coldsBFIronL3DataTableMo.Caption = "Mo";
            this.coldsBFIronL3DataTableMo.ColumnName = "Mo";
            this.coldsBFIronL3DataTableMo.Namespace = "";
            // 
            // coldsBFIronL3DataTableCu
            // 
            this.coldsBFIronL3DataTableCu.Caption = "Cu";
            this.coldsBFIronL3DataTableCu.ColumnName = "Cu";
            this.coldsBFIronL3DataTableCu.Namespace = "";
            // 
            // coldsBFIronL3DataTableCr
            // 
            this.coldsBFIronL3DataTableCr.Caption = "Cr";
            this.coldsBFIronL3DataTableCr.ColumnName = "Cr";
            this.coldsBFIronL3DataTableCr.Namespace = "";
            // 
            // coldsBFIronL3DataTableB
            // 
            this.coldsBFIronL3DataTableB.Caption = "B";
            this.coldsBFIronL3DataTableB.ColumnName = "B";
            this.coldsBFIronL3DataTableB.Namespace = "";
            // 
            // coldsBFIronL3DataTableV
            // 
            this.coldsBFIronL3DataTableV.Caption = "V";
            this.coldsBFIronL3DataTableV.ColumnName = "V";
            this.coldsBFIronL3DataTableV.Namespace = "";
            // 
            // coldsBFIronL3DataTableAl
            // 
            this.coldsBFIronL3DataTableAl.Caption = "Al";
            this.coldsBFIronL3DataTableAl.ColumnName = "Al";
            this.coldsBFIronL3DataTableAl.Namespace = "";
            // 
            // coldsBFIronL3DataTableNb
            // 
            this.coldsBFIronL3DataTableNb.Caption = "Nb";
            this.coldsBFIronL3DataTableNb.ColumnName = "Nb";
            this.coldsBFIronL3DataTableNb.Namespace = "";
            // 
            // coldsBFIronL3DataTableZn
            // 
            this.coldsBFIronL3DataTableZn.Caption = "Zn";
            this.coldsBFIronL3DataTableZn.ColumnName = "Zn";
            this.coldsBFIronL3DataTableZn.Namespace = "";
            // 
            // coldsBFIronL3DataTableW
            // 
            this.coldsBFIronL3DataTableW.Caption = "W";
            this.coldsBFIronL3DataTableW.ColumnName = "W";
            this.coldsBFIronL3DataTableW.Namespace = "";
            // 
            // coldsBFIronL3DataTableNi_B
            // 
            this.coldsBFIronL3DataTableNi_B.Caption = "Ni_B";
            this.coldsBFIronL3DataTableNi_B.ColumnName = "Ni_B";
            this.coldsBFIronL3DataTableNi_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableMo_B
            // 
            this.coldsBFIronL3DataTableMo_B.Caption = "Mo_B";
            this.coldsBFIronL3DataTableMo_B.ColumnName = "Mo_B";
            this.coldsBFIronL3DataTableMo_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableCu_B
            // 
            this.coldsBFIronL3DataTableCu_B.Caption = "Cu_B";
            this.coldsBFIronL3DataTableCu_B.ColumnName = "Cu_B";
            this.coldsBFIronL3DataTableCu_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableCr_B
            // 
            this.coldsBFIronL3DataTableCr_B.Caption = "Cr_B";
            this.coldsBFIronL3DataTableCr_B.ColumnName = "Cr_B";
            this.coldsBFIronL3DataTableCr_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableB_B
            // 
            this.coldsBFIronL3DataTableB_B.Caption = "B_B";
            this.coldsBFIronL3DataTableB_B.ColumnName = "B_B";
            this.coldsBFIronL3DataTableB_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableV_B
            // 
            this.coldsBFIronL3DataTableV_B.Caption = "V_B";
            this.coldsBFIronL3DataTableV_B.ColumnName = "V_B";
            this.coldsBFIronL3DataTableV_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableAl_B
            // 
            this.coldsBFIronL3DataTableAl_B.Caption = "Al_B";
            this.coldsBFIronL3DataTableAl_B.ColumnName = "Al_B";
            this.coldsBFIronL3DataTableAl_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableNb_B
            // 
            this.coldsBFIronL3DataTableNb_B.Caption = "Nb_B";
            this.coldsBFIronL3DataTableNb_B.ColumnName = "Nb_B";
            this.coldsBFIronL3DataTableNb_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableZn_B
            // 
            this.coldsBFIronL3DataTableZn_B.Caption = "Zn_B";
            this.coldsBFIronL3DataTableZn_B.ColumnName = "Zn_B";
            this.coldsBFIronL3DataTableZn_B.Namespace = "";
            // 
            // coldsBFIronL3DataTableW_B
            // 
            this.coldsBFIronL3DataTableW_B.Caption = "W_B";
            this.coldsBFIronL3DataTableW_B.ColumnName = "W_B";
            this.coldsBFIronL3DataTableW_B.Namespace = "";
            // 
            // dsSendFlag
            // 
            this.dsSendFlag.AutoLoad = true;
            this.dsSendFlag.AutoSubscribe = true;
            this.dsSendFlag.DataSetName = "L3DataSet";
            this.dsSendFlag.DeleteMethod = null;
            this.dsSendFlag.InsertMethod = null;
            this.dsSendFlag.L3DataAdapter = this.Adapter;
            this.dsSendFlag.LoadEvent = "Click";
            this.dsSendFlag.LoadTrigger = null;
            this.dsSendFlag.RefreshValve = 1000;
            this.dsSendFlag.SourceCommand = null;
            this.dsSendFlag.SourceCondition = "CODE_GROUP = \'SendFlag\'";
            this.dsSendFlag.SourceMethod = "";
            this.dsSendFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSendFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSendFlag.SubscribeTarget = null;
            this.dsSendFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSendFlag});
            this.dsSendFlag.UpdateEvent = "Click";
            this.dsSendFlag.UpdateMethod = null;
            this.dsSendFlag.UpdateTrigger = null;
            // 
            // schemadsSendFlag
            // 
            this.schemadsSendFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSendFlagL3DataTableCode_Des,
            this.coldsSendFlagL3DataTableCode_Val_Long});
            this.schemadsSendFlag.TableName = "L3DataTable";
            // 
            // coldsSendFlagL3DataTableCode_Des
            // 
            this.coldsSendFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSendFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSendFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsSendFlagL3DataTableCode_Val_Long
            // 
            this.coldsSendFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsSendFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsSendFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsSendFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsIronResult
            // 
            this.dsIronResult.AutoLoad = true;
            this.dsIronResult.AutoSubscribe = true;
            this.dsIronResult.DataSetName = "L3DataSet";
            this.dsIronResult.DeleteMethod = null;
            this.dsIronResult.InsertMethod = null;
            this.dsIronResult.L3DataAdapter = this.Adapter;
            this.dsIronResult.LoadEvent = "Click";
            this.dsIronResult.LoadTrigger = null;
            this.dsIronResult.RefreshValve = 1000;
            this.dsIronResult.SourceCommand = null;
            this.dsIronResult.SourceCondition = "CODE_GROUP = \'Iron_Result\'";
            this.dsIronResult.SourceMethod = "";
            this.dsIronResult.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronResult.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronResult.SubscribeTarget = null;
            this.dsIronResult.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronResult});
            this.dsIronResult.UpdateEvent = "Click";
            this.dsIronResult.UpdateMethod = null;
            this.dsIronResult.UpdateTrigger = null;
            // 
            // schemadsIronResult
            // 
            this.schemadsIronResult.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronResultL3DataTableCode_Des,
            this.coldsIronResultL3DataTableCode_Val_Long});
            this.schemadsIronResult.TableName = "L3DataTable";
            // 
            // coldsIronResultL3DataTableCode_Des
            // 
            this.coldsIronResultL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronResultL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronResultL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronResultL3DataTableCode_Val_Long
            // 
            this.coldsIronResultL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronResultL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronResultL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronResultL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = true;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "Code_Group = \'QA_Sample_Addr\'";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // dsIronStatus
            // 
            this.dsIronStatus.AutoLoad = true;
            this.dsIronStatus.AutoSubscribe = true;
            this.dsIronStatus.DataSetName = "L3DataSet";
            this.dsIronStatus.DeleteMethod = null;
            this.dsIronStatus.InsertMethod = null;
            this.dsIronStatus.L3DataAdapter = this.Adapter;
            this.dsIronStatus.LoadEvent = "Click";
            this.dsIronStatus.LoadTrigger = null;
            this.dsIronStatus.RefreshValve = 1000;
            this.dsIronStatus.SourceCommand = null;
            this.dsIronStatus.SourceCondition = "CODE_GROUP = \'Iron_Status\'";
            this.dsIronStatus.SourceMethod = "";
            this.dsIronStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronStatus.SubscribeTarget = null;
            this.dsIronStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronStatus});
            this.dsIronStatus.UpdateEvent = "Click";
            this.dsIronStatus.UpdateMethod = null;
            this.dsIronStatus.UpdateTrigger = null;
            // 
            // schemadsIronStatus
            // 
            this.schemadsIronStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronStatusL3DataTableCode_Des,
            this.coldsIronStatusL3DataTableCode_Val_Long});
            this.schemadsIronStatus.TableName = "L3DataTable";
            // 
            // coldsIronStatusL3DataTableCode_Des
            // 
            this.coldsIronStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronStatusL3DataTableCode_Val_Long
            // 
            this.coldsIronStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // session1
            // 
            this.session1.ConnectionStr = null;
            this.session1.Password = null;
            this.session1.TimeOut = ((uint)(4294967295u));
            this.session1.User = null;
            // 
            // cmdDesignatePath
            // 
            this.cmdDesignatePath.Adapter = this.Adapter;
            this.cmdDesignatePath.MergeReturnTarget = false;
            this.cmdDesignatePath.Method = "DesignatePath";
            this.cmdDesignatePath.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.cmdDesignatePath.Parameters.Add(this.cmdpPath);
            this.cmdDesignatePath.ReturnTarget = null;
            this.cmdDesignatePath.ReturnTargetProperty = null;
            this.cmdDesignatePath.Trigger = null;
            this.cmdDesignatePath.TriggerEvent = "Click";
            // 
            // cmdpPath
            // 
            this.cmdpPath.AcceptAfterExecuted = false;
            this.cmdpPath.ConstantValue = null;
            this.cmdpPath.MergeTarget = false;
            this.cmdpPath.SourceFilter = null;
            this.cmdpPath.SourceObject = null;
            this.cmdpPath.SourceProperty = null;
            this.cmdpPath.TargetObject = null;
            this.cmdpPath.TargetProperty = null;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBFIron;
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
            this.toolStripLabel1});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 21;
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // cmdSendIronDataToNC
            // 
            this.cmdSendIronDataToNC.Adapter = this.Adapter;
            this.cmdSendIronDataToNC.MergeReturnTarget = false;
            this.cmdSendIronDataToNC.Method = "SendIronDataToNC";
            this.cmdSendIronDataToNC.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.cmdSendIronDataToNC.Parameters.Add(this.cmdpTapNo);
            this.cmdSendIronDataToNC.ReturnTarget = null;
            this.cmdSendIronDataToNC.ReturnTargetProperty = null;
            this.cmdSendIronDataToNC.Trigger = null;
            this.cmdSendIronDataToNC.TriggerEvent = "Click";
            // 
            // cmdpTapNo
            // 
            this.cmdpTapNo.AcceptAfterExecuted = false;
            this.cmdpTapNo.ConstantValue = null;
            this.cmdpTapNo.MergeTarget = false;
            this.cmdpTapNo.SourceFilter = null;
            this.cmdpTapNo.SourceObject = null;
            this.cmdpTapNo.SourceProperty = null;
            this.cmdpTapNo.TargetObject = null;
            this.cmdpTapNo.TargetProperty = null;
            // 
            // cmdModifySource
            // 
            this.cmdModifySource.Adapter = this.Adapter;
            this.cmdModifySource.MergeReturnTarget = false;
            this.cmdModifySource.Method = "MarkIronSource";
            this.cmdModifySource.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.cmdModifySource.Parameters.Add(this.cmdSource);
            this.cmdModifySource.ReturnTarget = null;
            this.cmdModifySource.ReturnTargetProperty = null;
            this.cmdModifySource.Trigger = null;
            this.cmdModifySource.TriggerEvent = "Click";
            // 
            // cmdSource
            // 
            this.cmdSource.AcceptAfterExecuted = false;
            this.cmdSource.ConstantValue = null;
            this.cmdSource.MergeTarget = false;
            this.cmdSource.SourceFilter = null;
            this.cmdSource.SourceObject = null;
            this.cmdSource.SourceProperty = null;
            this.cmdSource.TargetObject = null;
            this.cmdSource.TargetProperty = null;
            // 
            // toolStripButton1
            // 
            this.Adapter.SetAccessRight(this.toolStripButton1, "btnBFSample");
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 40);
            this.toolStripButton1.Text = "重新发送委托单";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // IronMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 250);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronMagFrm";
            this.TabText = "铁水信息收集管理";
            this.Text = "铁水信息收集管理";
            this.Load += new System.EventHandler(this.IronMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronMagFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIromSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIromSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).EndInit();
            this.ctxtMenuStripModifyWT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private AppSvrIF.Session session1;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIromSource;
        private System.Data.DataTable schemadsIromSource;
        private System.Data.DataColumn coldsIromSourceL3DataTableCode_Des;
        private System.Data.DataColumn coldsIromSourceL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIronDestination;
        private System.Data.DataTable schemadsIronDestination;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSendFlag;
        private System.Data.DataTable schemadsSendFlag;
        private System.Data.DataColumn coldsSendFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsSendFlagL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIronResult;
        private System.Data.DataTable schemadsIronResult;
        private System.Data.DataColumn coldsIronResultL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronResultL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsIronStatus;
        private System.Data.DataTable schemadsIronStatus;
        private System.Data.DataColumn coldsIronStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronStatusL3DataTableCode_Val_Long;
        private System.Windows.Forms.ToolStripButton btnBFSample;
        private System.Windows.Forms.ToolStripButton btnDisSSample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private AppSvrHMI.L3Command cmdDesignatePath;
        private AppSvrHMI.L3CommandParameter cmdpPath;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuStripModifyWT;
        private System.Windows.Forms.ToolStripMenuItem menuGross;
        private System.Windows.Forms.ToolStripMenuItem menuTare;
        private System.Windows.Forms.ToolStripMenuItem menuToIron;
        private System.Windows.Forms.ToolStripMenuItem menuToNC;
        private AppSvrHMI.L3DataSet dsBFIron;
        private System.Data.DataTable schemadsBFIron;
        private System.Data.DataColumn coldsBFIronL3DataTableMaterialID;
        private System.Data.DataColumn coldsBFIronL3DataTableStatus;
        private System.Data.DataColumn coldsBFIronL3DataTablePosition;
        private System.Data.DataColumn coldsBFIronL3DataTableQAStatus;
        private System.Data.DataColumn coldsBFIronL3DataTableQALevel;
        private System.Data.DataColumn coldsBFIronL3DataTableOrderContractID;
        private System.Data.DataColumn coldsBFIronL3DataTableProduceContractID;
        private System.Data.DataColumn coldsBFIronL3DataTableSalesContractID;
        private System.Data.DataColumn coldsBFIronL3DataTableBFID;
        private System.Data.DataColumn coldsBFIronL3DataTableTAP_No;
        private System.Data.DataColumn coldsBFIronL3DataTableTPC_No;
        private System.Data.DataColumn coldsBFIronL3DataTableSource;
        private System.Data.DataColumn coldsBFIronL3DataTableDestination;
        private System.Data.DataColumn coldsBFIronL3DataTableProduction_Date;
        private System.Data.DataColumn coldsBFIronL3DataTableShift;
        private System.Data.DataColumn coldsBFIronL3DataTableOperator;
        private System.Data.DataColumn coldsBFIronL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsBFIronL3DataTableTeam;
        private System.Data.DataColumn coldsBFIronL3DataTableResult;
        private System.Data.DataColumn coldsBFIronL3DataTableSample_Place;
        private System.Data.DataColumn coldsBFIronL3DataTableC;
        private System.Data.DataColumn coldsBFIronL3DataTableSi;
        private System.Data.DataColumn coldsBFIronL3DataTableMn;
        private System.Data.DataColumn coldsBFIronL3DataTableS;
        private System.Data.DataColumn coldsBFIronL3DataTableP;
        private System.Data.DataColumn coldsBFIronL3DataTableTi;
        private System.Data.DataColumn coldsBFIronL3DataTableGross_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableLast_Tare;
        private System.Data.DataColumn coldsBFIronL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsBFIronL3DataTableNet_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableIronStatus;
        private System.Data.DataColumn coldsBFIronL3DataTableArrival_Time;
        private System.Data.DataColumn coldsBFIronL3DataTableFeed_Time;
        private System.Data.DataColumn coldsBFIronL3DataTableSend_Time;
        private System.Data.DataColumn coldsBFIronL3DataTableSampCode;
        private System.Data.DataColumn coldsBFIronL3DataTableIronConfirm;
        private System.Data.DataColumn coldsBFIronL3DataTableC_B;
        private System.Data.DataColumn coldsBFIronL3DataTableSi_B;
        private System.Data.DataColumn coldsBFIronL3DataTableMn_B;
        private System.Data.DataColumn coldsBFIronL3DataTableS_B;
        private System.Data.DataColumn coldsBFIronL3DataTableP_B;
        private System.Data.DataColumn coldsBFIronL3DataTableTi_B;
        private System.Data.DataColumn coldsBFIronL3DataTableGrossFlag;
        private System.Data.DataColumn coldsBFIronL3DataTableTareFlag;
        private System.Data.DataColumn coldsBFIronL3DataTableAnalysisFlag;
        private System.Windows.Forms.BindingSource bsBFIron;
        private AppSvrHMI.L3Command cmdSendIronDataToNC;
        private AppSvrHMI.L3CommandParameter cmdpTapNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuSoureS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuSouresHF;
        private AppSvrHMI.L3Command cmdModifySource;
        private AppSvrHMI.L3CommandParameter cmdSource;
        private System.Windows.Forms.ToolStripMenuItem menuToSteelAgain;
        private System.Windows.Forms.ToolStripButton btnIronSlagSample;
        private System.Data.DataColumn coldsBFIronL3DataTableSn;
        private System.Data.DataColumn coldsBFIronL3DataTableSb;
        private System.Data.DataColumn coldsBFIronL3DataTableAs;
        private System.Data.DataColumn coldsBFIronL3DataTablePb;
        private System.Data.DataColumn coldsBFIronL3DataTableSn_B;
        private System.Data.DataColumn coldsBFIronL3DataTableSb_B;
        private System.Data.DataColumn coldsBFIronL3DataTableAs_B;
        private System.Data.DataColumn coldsBFIronL3DataTablePb_B;
        private System.Data.DataColumn coldsBFIronL3DataTableOperator_B;
        private System.Data.DataColumn coldsBFIronL3DataTableDeSFlag;
        private System.Data.DataColumn coldsBFIronL3DataTableDeSType;
        private System.Data.DataColumn coldsBFIronL3DataTableNi;
        private System.Data.DataColumn coldsBFIronL3DataTableMo;
        private System.Data.DataColumn coldsBFIronL3DataTableCu;
        private System.Data.DataColumn coldsBFIronL3DataTableCr;
        private System.Data.DataColumn coldsBFIronL3DataTableB;
        private System.Data.DataColumn coldsBFIronL3DataTableV;
        private System.Data.DataColumn coldsBFIronL3DataTableAl;
        private System.Data.DataColumn coldsBFIronL3DataTableNb;
        private System.Data.DataColumn coldsBFIronL3DataTableZn;
        private System.Data.DataColumn coldsBFIronL3DataTableW;
        private System.Data.DataColumn coldsBFIronL3DataTableNi_B;
        private System.Data.DataColumn coldsBFIronL3DataTableMo_B;
        private System.Data.DataColumn coldsBFIronL3DataTableCu_B;
        private System.Data.DataColumn coldsBFIronL3DataTableCr_B;
        private System.Data.DataColumn coldsBFIronL3DataTableB_B;
        private System.Data.DataColumn coldsBFIronL3DataTableV_B;
        private System.Data.DataColumn coldsBFIronL3DataTableAl_B;
        private System.Data.DataColumn coldsBFIronL3DataTableNb_B;
        private System.Data.DataColumn coldsBFIronL3DataTableZn_B;
        private System.Data.DataColumn coldsBFIronL3DataTableW_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPC_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_GroupNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Source;
        private System.Windows.Forms.DataGridViewComboBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zn;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curr_Tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net_Weight;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC_Confirm_Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn samplePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IronStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IronConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisFlag;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}