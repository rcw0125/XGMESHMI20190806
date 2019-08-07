namespace EnergyMag
{
    partial class EnergyStatFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyStatFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsStat = new System.Windows.Forms.BindingSource(this.components);
            this.dsStat = new AppSvrHMI.L3DataSet();
            this.schemadsStat = new System.Data.DataTable();
            this.coldsStatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatL3DataTableName = new System.Data.DataColumn();
            this.coldsStatL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_CFCO = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_BOFCO = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_BOFCO_CallBack = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_N2 = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_N2_SpecialSteel = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_O2 = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsStatL3DataTableOperator = new System.Data.DataColumn();
            this.coldsStatL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_Special_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_Special_M = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvStat = new System.Windows.Forms.DataGridView();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Production_Special_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Production_Special_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowCFCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowBOFCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowBOFCOCallBackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowN2SpecialSteelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFCODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOCallBackDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2DDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2SpecialSteelDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2DDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFCODAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCODAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2DAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2DAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOCallBackMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2MDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2SpecialSteelMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2MDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFCOMAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOMAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2MAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2MAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
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
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvStat)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel,
            this.toolStripSeparator1,
            this.btnOutPut});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1000, 43);
            this.toolStripMain.TabIndex = 15;
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsStat;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.btnQuery,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2,
            this.dtEnd,
            this.toolStripLabel2,
            this.dtStart,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsStat
            // 
            this.bsStat.DataMember = "L3DataTable";
            this.bsStat.DataSource = this.dsStat;
            // 
            // dsStat
            // 
            this.dsStat.AutoLoad = true;
            this.dsStat.AutoSubscribe = false;
            this.dsStat.DataSetName = "L3DataSet";
            this.dsStat.DeleteMethod = "";
            this.dsStat.InsertMethod = "";
            this.dsStat.L3DataAdapter = this.Adapter;
            this.dsStat.LoadEvent = "";
            this.dsStat.LoadTrigger = null;
            this.dsStat.RefreshValve = 1000;
            this.dsStat.SourceCommand = null;
            this.dsStat.SourceCondition = "1=2";
            this.dsStat.SourceMethod = "";
            this.dsStat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStat.SourceURI = "XGMESLogic\\EnergyMag\\CEnergy_Manual_Data";
            this.dsStat.SubscribeTarget = "";
            this.dsStat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStat});
            this.dsStat.UpdateEvent = "";
            this.dsStat.UpdateMethod = "";
            this.dsStat.UpdateTrigger = null;
            // 
            // schemadsStat
            // 
            this.schemadsStat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatL3DataTableGUID,
            this.coldsStatL3DataTableName,
            this.coldsStatL3DataTableProductionDate,
            this.coldsStatL3DataTableFlow_CFCO,
            this.coldsStatL3DataTableFlow_BOFCO,
            this.coldsStatL3DataTableFlow_BOFCO_CallBack,
            this.coldsStatL3DataTableFlow_N2,
            this.coldsStatL3DataTableFlow_N2_SpecialSteel,
            this.coldsStatL3DataTableFlow_O2,
            this.coldsStatL3DataTableCFCO_D,
            this.coldsStatL3DataTableBOFCO_D,
            this.coldsStatL3DataTableBOFCO_CallBack_D,
            this.coldsStatL3DataTableN2_D,
            this.coldsStatL3DataTableN2_SpecialSteel_D,
            this.coldsStatL3DataTableO2_D,
            this.coldsStatL3DataTableCFCO_D_Avg,
            this.coldsStatL3DataTableBOFCO_D_Avg,
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg,
            this.coldsStatL3DataTableN2_D_Avg,
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg,
            this.coldsStatL3DataTableO2_D_Avg,
            this.coldsStatL3DataTableCFCO_M,
            this.coldsStatL3DataTableBOFCO_M,
            this.coldsStatL3DataTableBOFCO_CallBack_M,
            this.coldsStatL3DataTableN2_M,
            this.coldsStatL3DataTableN2_SpecialSteel_M,
            this.coldsStatL3DataTableO2_M,
            this.coldsStatL3DataTableCFCO_M_Avg,
            this.coldsStatL3DataTableBOFCO_M_Avg,
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg,
            this.coldsStatL3DataTableN2_M_Avg,
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg,
            this.coldsStatL3DataTableO2_M_Avg,
            this.coldsStatL3DataTableProduction_D,
            this.coldsStatL3DataTableProduction_M,
            this.coldsStatL3DataTableCreateTime,
            this.coldsStatL3DataTableOperator,
            this.coldsStatL3DataTableStatus,
            this.coldsStatL3DataTableProduction_Special_D,
            this.coldsStatL3DataTableProduction_Special_M});
            this.schemadsStat.TableName = "L3DataTable";
            // 
            // coldsStatL3DataTableGUID
            // 
            this.coldsStatL3DataTableGUID.Caption = "GUID";
            this.coldsStatL3DataTableGUID.ColumnName = "GUID";
            this.coldsStatL3DataTableGUID.Namespace = "";
            // 
            // coldsStatL3DataTableName
            // 
            this.coldsStatL3DataTableName.Caption = "Name";
            this.coldsStatL3DataTableName.ColumnName = "Name";
            this.coldsStatL3DataTableName.Namespace = "";
            // 
            // coldsStatL3DataTableProductionDate
            // 
            this.coldsStatL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsStatL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsStatL3DataTableProductionDate.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_CFCO
            // 
            this.coldsStatL3DataTableFlow_CFCO.Caption = "Flow_CFCO";
            this.coldsStatL3DataTableFlow_CFCO.ColumnName = "Flow_CFCO";
            this.coldsStatL3DataTableFlow_CFCO.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_CFCO.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_BOFCO
            // 
            this.coldsStatL3DataTableFlow_BOFCO.Caption = "Flow_BOFCO";
            this.coldsStatL3DataTableFlow_BOFCO.ColumnName = "Flow_BOFCO";
            this.coldsStatL3DataTableFlow_BOFCO.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_BOFCO.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_BOFCO_CallBack
            // 
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.Caption = "Flow_BOFCO_CallBack";
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.ColumnName = "Flow_BOFCO_CallBack";
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_N2
            // 
            this.coldsStatL3DataTableFlow_N2.Caption = "Flow_N2";
            this.coldsStatL3DataTableFlow_N2.ColumnName = "Flow_N2";
            this.coldsStatL3DataTableFlow_N2.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_N2.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_N2_SpecialSteel
            // 
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.Caption = "Flow_N2_SpecialSteel";
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.ColumnName = "Flow_N2_SpecialSteel";
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_O2
            // 
            this.coldsStatL3DataTableFlow_O2.Caption = "Flow_O2";
            this.coldsStatL3DataTableFlow_O2.ColumnName = "Flow_O2";
            this.coldsStatL3DataTableFlow_O2.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_O2.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_D
            // 
            this.coldsStatL3DataTableCFCO_D.Caption = "CFCO_D";
            this.coldsStatL3DataTableCFCO_D.ColumnName = "CFCO_D";
            this.coldsStatL3DataTableCFCO_D.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_D.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_D
            // 
            this.coldsStatL3DataTableBOFCO_D.Caption = "BOFCO_D";
            this.coldsStatL3DataTableBOFCO_D.ColumnName = "BOFCO_D";
            this.coldsStatL3DataTableBOFCO_D.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_D.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_D
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_D.Caption = "BOFCO_CallBack_D";
            this.coldsStatL3DataTableBOFCO_CallBack_D.ColumnName = "BOFCO_CallBack_D";
            this.coldsStatL3DataTableBOFCO_CallBack_D.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_D.Namespace = "";
            // 
            // coldsStatL3DataTableN2_D
            // 
            this.coldsStatL3DataTableN2_D.Caption = "N2_D";
            this.coldsStatL3DataTableN2_D.ColumnName = "N2_D";
            this.coldsStatL3DataTableN2_D.DataType = typeof(float);
            this.coldsStatL3DataTableN2_D.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_D
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_D.Caption = "N2_SpecialSteel_D";
            this.coldsStatL3DataTableN2_SpecialSteel_D.ColumnName = "N2_SpecialSteel_D";
            this.coldsStatL3DataTableN2_SpecialSteel_D.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_D.Namespace = "";
            // 
            // coldsStatL3DataTableO2_D
            // 
            this.coldsStatL3DataTableO2_D.Caption = "O2_D";
            this.coldsStatL3DataTableO2_D.ColumnName = "O2_D";
            this.coldsStatL3DataTableO2_D.DataType = typeof(float);
            this.coldsStatL3DataTableO2_D.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_D_Avg
            // 
            this.coldsStatL3DataTableCFCO_D_Avg.Caption = "CFCO_D_Avg";
            this.coldsStatL3DataTableCFCO_D_Avg.ColumnName = "CFCO_D_Avg";
            this.coldsStatL3DataTableCFCO_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_D_Avg
            // 
            this.coldsStatL3DataTableBOFCO_D_Avg.Caption = "BOFCO_D_Avg";
            this.coldsStatL3DataTableBOFCO_D_Avg.ColumnName = "BOFCO_D_Avg";
            this.coldsStatL3DataTableBOFCO_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_D_Avg
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.Caption = "BOFCO_CallBack_D_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.ColumnName = "BOFCO_CallBack_D_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_D_Avg
            // 
            this.coldsStatL3DataTableN2_D_Avg.Caption = "N2_D_Avg";
            this.coldsStatL3DataTableN2_D_Avg.ColumnName = "N2_D_Avg";
            this.coldsStatL3DataTableN2_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_D_Avg
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.Caption = "N2_SpecialSteel_D_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.ColumnName = "N2_SpecialSteel_D_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableO2_D_Avg
            // 
            this.coldsStatL3DataTableO2_D_Avg.Caption = "O2_D_Avg";
            this.coldsStatL3DataTableO2_D_Avg.ColumnName = "O2_D_Avg";
            this.coldsStatL3DataTableO2_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableO2_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_M
            // 
            this.coldsStatL3DataTableCFCO_M.Caption = "CFCO_M";
            this.coldsStatL3DataTableCFCO_M.ColumnName = "CFCO_M";
            this.coldsStatL3DataTableCFCO_M.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_M.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_M
            // 
            this.coldsStatL3DataTableBOFCO_M.Caption = "BOFCO_M";
            this.coldsStatL3DataTableBOFCO_M.ColumnName = "BOFCO_M";
            this.coldsStatL3DataTableBOFCO_M.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_M.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_M
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_M.Caption = "BOFCO_CallBack_M";
            this.coldsStatL3DataTableBOFCO_CallBack_M.ColumnName = "BOFCO_CallBack_M";
            this.coldsStatL3DataTableBOFCO_CallBack_M.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_M.Namespace = "";
            // 
            // coldsStatL3DataTableN2_M
            // 
            this.coldsStatL3DataTableN2_M.Caption = "N2_M";
            this.coldsStatL3DataTableN2_M.ColumnName = "N2_M";
            this.coldsStatL3DataTableN2_M.DataType = typeof(float);
            this.coldsStatL3DataTableN2_M.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_M
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_M.Caption = "N2_SpecialSteel_M";
            this.coldsStatL3DataTableN2_SpecialSteel_M.ColumnName = "N2_SpecialSteel_M";
            this.coldsStatL3DataTableN2_SpecialSteel_M.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_M.Namespace = "";
            // 
            // coldsStatL3DataTableO2_M
            // 
            this.coldsStatL3DataTableO2_M.Caption = "O2_M";
            this.coldsStatL3DataTableO2_M.ColumnName = "O2_M";
            this.coldsStatL3DataTableO2_M.DataType = typeof(float);
            this.coldsStatL3DataTableO2_M.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_M_Avg
            // 
            this.coldsStatL3DataTableCFCO_M_Avg.Caption = "CFCO_M_Avg";
            this.coldsStatL3DataTableCFCO_M_Avg.ColumnName = "CFCO_M_Avg";
            this.coldsStatL3DataTableCFCO_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_M_Avg
            // 
            this.coldsStatL3DataTableBOFCO_M_Avg.Caption = "BOFCO_M_Avg";
            this.coldsStatL3DataTableBOFCO_M_Avg.ColumnName = "BOFCO_M_Avg";
            this.coldsStatL3DataTableBOFCO_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_M_Avg
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.Caption = "BOFCO_CallBack_M_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.ColumnName = "BOFCO_CallBack_M_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_M_Avg
            // 
            this.coldsStatL3DataTableN2_M_Avg.Caption = "N2_M_Avg";
            this.coldsStatL3DataTableN2_M_Avg.ColumnName = "N2_M_Avg";
            this.coldsStatL3DataTableN2_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_M_Avg
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.Caption = "N2_SpecialSteel_M_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.ColumnName = "N2_SpecialSteel_M_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableO2_M_Avg
            // 
            this.coldsStatL3DataTableO2_M_Avg.Caption = "O2_M_Avg";
            this.coldsStatL3DataTableO2_M_Avg.ColumnName = "O2_M_Avg";
            this.coldsStatL3DataTableO2_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableO2_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_D
            // 
            this.coldsStatL3DataTableProduction_D.Caption = "Production_D";
            this.coldsStatL3DataTableProduction_D.ColumnName = "Production_D";
            this.coldsStatL3DataTableProduction_D.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_D.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_M
            // 
            this.coldsStatL3DataTableProduction_M.Caption = "Production_M";
            this.coldsStatL3DataTableProduction_M.ColumnName = "Production_M";
            this.coldsStatL3DataTableProduction_M.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_M.Namespace = "";
            // 
            // coldsStatL3DataTableCreateTime
            // 
            this.coldsStatL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsStatL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsStatL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsStatL3DataTableCreateTime.Namespace = "";
            // 
            // coldsStatL3DataTableOperator
            // 
            this.coldsStatL3DataTableOperator.Caption = "Operator";
            this.coldsStatL3DataTableOperator.ColumnName = "Operator";
            this.coldsStatL3DataTableOperator.Namespace = "";
            // 
            // coldsStatL3DataTableStatus
            // 
            this.coldsStatL3DataTableStatus.Caption = "Status";
            this.coldsStatL3DataTableStatus.ColumnName = "Status";
            this.coldsStatL3DataTableStatus.DataType = typeof(int);
            this.coldsStatL3DataTableStatus.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_Special_D
            // 
            this.coldsStatL3DataTableProduction_Special_D.Caption = "Production_Special_D";
            this.coldsStatL3DataTableProduction_Special_D.ColumnName = "Production_Special_D";
            this.coldsStatL3DataTableProduction_Special_D.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_Special_D.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_Special_M
            // 
            this.coldsStatL3DataTableProduction_Special_M.Caption = "Production_Special_M";
            this.coldsStatL3DataTableProduction_Special_M.ColumnName = "Production_Special_M";
            this.coldsStatL3DataTableProduction_Special_M.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_Special_M.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel5.Text = "　";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(120, 22);
            this.dtEnd.Text = "2009-03-28";
            this.dtEnd.Value = new System.DateTime(2009, 3, 28, 18, 37, 23, 903);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "--";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(120, 22);
            this.dtStart.Text = "2009-03-28";
            this.dtStart.Value = new System.DateTime(2009, 3, 28, 18, 38, 0, 355);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "生产日期:";
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
            // dvStat
            // 
            this.dvStat.AllowUserToAddRows = false;
            this.dvStat.AllowUserToDeleteRows = false;
            this.dvStat.AllowUserToResizeRows = false;
            this.dvStat.AutoGenerateColumns = false;
            this.dvStat.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductionDate,
            this.productionDDataGridViewTextBoxColumn,
            this.productionMDataGridViewTextBoxColumn,
            this.Production_Special_D,
            this.Production_Special_M,
            this.flowCFCODataGridViewTextBoxColumn,
            this.flowBOFCODataGridViewTextBoxColumn,
            this.flowBOFCOCallBackDataGridViewTextBoxColumn,
            this.flowN2DataGridViewTextBoxColumn,
            this.flowN2SpecialSteelDataGridViewTextBoxColumn,
            this.flowO2DataGridViewTextBoxColumn,
            this.cFCODDataGridViewTextBoxColumn,
            this.bOFCODDataGridViewTextBoxColumn,
            this.bOFCOCallBackDDataGridViewTextBoxColumn,
            this.n2DDataGridViewTextBoxColumn,
            this.n2SpecialSteelDDataGridViewTextBoxColumn,
            this.o2DDataGridViewTextBoxColumn,
            this.cFCODAvgDataGridViewTextBoxColumn,
            this.bOFCODAvgDataGridViewTextBoxColumn,
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn,
            this.n2DAvgDataGridViewTextBoxColumn,
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn,
            this.o2DAvgDataGridViewTextBoxColumn,
            this.cFCOMDataGridViewTextBoxColumn,
            this.bOFCOMDataGridViewTextBoxColumn,
            this.bOFCOCallBackMDataGridViewTextBoxColumn,
            this.n2MDataGridViewTextBoxColumn,
            this.n2SpecialSteelMDataGridViewTextBoxColumn,
            this.o2MDataGridViewTextBoxColumn,
            this.cFCOMAvgDataGridViewTextBoxColumn,
            this.bOFCOMAvgDataGridViewTextBoxColumn,
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn,
            this.n2MAvgDataGridViewTextBoxColumn,
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn,
            this.o2MAvgDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.GUID});
            this.dvStat.DataSource = this.bsStat;
            this.dvStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStat.Location = new System.Drawing.Point(0, 0);
            this.dvStat.MultiSelect = false;
            this.dvStat.Name = "dvStat";
            this.dvStat.ReadOnly = true;
            this.dvStat.RowTemplate.Height = 23;
            this.dvStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvStat.Size = new System.Drawing.Size(1000, 532);
            this.dvStat.TabIndex = 20;
            this.dvStat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvEnergyData_CellDoubleClick);
            this.dvStat.Sorted += new System.EventHandler(this.dvStat_Sorted);
            this.dvStat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvEnergyData_DataError);
            // 
            // ProductionDate
            // 
            this.ProductionDate.DataPropertyName = "ProductionDate";
            this.ProductionDate.Frozen = true;
            this.ProductionDate.HeaderText = "生产日期";
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.ReadOnly = true;
            // 
            // productionDDataGridViewTextBoxColumn
            // 
            this.productionDDataGridViewTextBoxColumn.DataPropertyName = "Production_D";
            this.productionDDataGridViewTextBoxColumn.Frozen = true;
            this.productionDDataGridViewTextBoxColumn.HeaderText = "日产量";
            this.productionDDataGridViewTextBoxColumn.Name = "productionDDataGridViewTextBoxColumn";
            this.productionDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionMDataGridViewTextBoxColumn
            // 
            this.productionMDataGridViewTextBoxColumn.DataPropertyName = "Production_M";
            this.productionMDataGridViewTextBoxColumn.Frozen = true;
            this.productionMDataGridViewTextBoxColumn.HeaderText = "累计产量";
            this.productionMDataGridViewTextBoxColumn.Name = "productionMDataGridViewTextBoxColumn";
            this.productionMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Production_Special_D
            // 
            this.Production_Special_D.DataPropertyName = "Production_Special_D";
            this.Production_Special_D.Frozen = true;
            this.Production_Special_D.HeaderText = "精品钢日产量";
            this.Production_Special_D.Name = "Production_Special_D";
            this.Production_Special_D.ReadOnly = true;
            // 
            // Production_Special_M
            // 
            this.Production_Special_M.DataPropertyName = "Production_Special_M";
            this.Production_Special_M.Frozen = true;
            this.Production_Special_M.HeaderText = "精品钢累计产量";
            this.Production_Special_M.Name = "Production_Special_M";
            this.Production_Special_M.ReadOnly = true;
            // 
            // flowCFCODataGridViewTextBoxColumn
            // 
            this.flowCFCODataGridViewTextBoxColumn.DataPropertyName = "Flow_CFCO";
            this.flowCFCODataGridViewTextBoxColumn.HeaderText = "焦炉煤气瞬时流量";
            this.flowCFCODataGridViewTextBoxColumn.Name = "flowCFCODataGridViewTextBoxColumn";
            this.flowCFCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowBOFCODataGridViewTextBoxColumn
            // 
            this.flowBOFCODataGridViewTextBoxColumn.DataPropertyName = "Flow_BOFCO";
            this.flowBOFCODataGridViewTextBoxColumn.HeaderText = "转炉煤气瞬时流量";
            this.flowBOFCODataGridViewTextBoxColumn.Name = "flowBOFCODataGridViewTextBoxColumn";
            this.flowBOFCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowBOFCOCallBackDataGridViewTextBoxColumn
            // 
            this.flowBOFCOCallBackDataGridViewTextBoxColumn.DataPropertyName = "Flow_BOFCO_CallBack";
            this.flowBOFCOCallBackDataGridViewTextBoxColumn.HeaderText = "转炉煤气回收瞬时流量";
            this.flowBOFCOCallBackDataGridViewTextBoxColumn.Name = "flowBOFCOCallBackDataGridViewTextBoxColumn";
            this.flowBOFCOCallBackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowN2DataGridViewTextBoxColumn
            // 
            this.flowN2DataGridViewTextBoxColumn.DataPropertyName = "Flow_N2";
            this.flowN2DataGridViewTextBoxColumn.HeaderText = "氮气瞬时流量";
            this.flowN2DataGridViewTextBoxColumn.Name = "flowN2DataGridViewTextBoxColumn";
            this.flowN2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowN2SpecialSteelDataGridViewTextBoxColumn
            // 
            this.flowN2SpecialSteelDataGridViewTextBoxColumn.DataPropertyName = "Flow_N2_SpecialSteel";
            this.flowN2SpecialSteelDataGridViewTextBoxColumn.HeaderText = "精品钢氮气瞬时流量";
            this.flowN2SpecialSteelDataGridViewTextBoxColumn.Name = "flowN2SpecialSteelDataGridViewTextBoxColumn";
            this.flowN2SpecialSteelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowO2DataGridViewTextBoxColumn
            // 
            this.flowO2DataGridViewTextBoxColumn.DataPropertyName = "Flow_O2";
            this.flowO2DataGridViewTextBoxColumn.HeaderText = "氧气瞬时流量";
            this.flowO2DataGridViewTextBoxColumn.Name = "flowO2DataGridViewTextBoxColumn";
            this.flowO2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFCODDataGridViewTextBoxColumn
            // 
            this.cFCODDataGridViewTextBoxColumn.DataPropertyName = "CFCO_D";
            this.cFCODDataGridViewTextBoxColumn.HeaderText = "焦炉煤气日消耗量";
            this.cFCODDataGridViewTextBoxColumn.Name = "cFCODDataGridViewTextBoxColumn";
            this.cFCODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCODDataGridViewTextBoxColumn
            // 
            this.bOFCODDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_D";
            this.bOFCODDataGridViewTextBoxColumn.HeaderText = "转炉煤气日消耗量";
            this.bOFCODDataGridViewTextBoxColumn.Name = "bOFCODDataGridViewTextBoxColumn";
            this.bOFCODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOCallBackDDataGridViewTextBoxColumn
            // 
            this.bOFCOCallBackDDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_CallBack_D";
            this.bOFCOCallBackDDataGridViewTextBoxColumn.HeaderText = "转炉煤气回收日消耗量";
            this.bOFCOCallBackDDataGridViewTextBoxColumn.Name = "bOFCOCallBackDDataGridViewTextBoxColumn";
            this.bOFCOCallBackDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2DDataGridViewTextBoxColumn
            // 
            this.n2DDataGridViewTextBoxColumn.DataPropertyName = "N2_D";
            this.n2DDataGridViewTextBoxColumn.HeaderText = "氮气瞬时流量";
            this.n2DDataGridViewTextBoxColumn.Name = "n2DDataGridViewTextBoxColumn";
            this.n2DDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2SpecialSteelDDataGridViewTextBoxColumn
            // 
            this.n2SpecialSteelDDataGridViewTextBoxColumn.DataPropertyName = "N2_SpecialSteel_D";
            this.n2SpecialSteelDDataGridViewTextBoxColumn.HeaderText = "精品钢氮气日消耗量";
            this.n2SpecialSteelDDataGridViewTextBoxColumn.Name = "n2SpecialSteelDDataGridViewTextBoxColumn";
            this.n2SpecialSteelDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // o2DDataGridViewTextBoxColumn
            // 
            this.o2DDataGridViewTextBoxColumn.DataPropertyName = "O2_D";
            this.o2DDataGridViewTextBoxColumn.HeaderText = "氧气日消耗量";
            this.o2DDataGridViewTextBoxColumn.Name = "o2DDataGridViewTextBoxColumn";
            this.o2DDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFCODAvgDataGridViewTextBoxColumn
            // 
            this.cFCODAvgDataGridViewTextBoxColumn.DataPropertyName = "CFCO_D_Avg";
            this.cFCODAvgDataGridViewTextBoxColumn.HeaderText = "焦炉煤气日单耗";
            this.cFCODAvgDataGridViewTextBoxColumn.Name = "cFCODAvgDataGridViewTextBoxColumn";
            this.cFCODAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCODAvgDataGridViewTextBoxColumn
            // 
            this.bOFCODAvgDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_D_Avg";
            this.bOFCODAvgDataGridViewTextBoxColumn.HeaderText = "转炉煤气日单耗";
            this.bOFCODAvgDataGridViewTextBoxColumn.Name = "bOFCODAvgDataGridViewTextBoxColumn";
            this.bOFCODAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOCallBackDAvgDataGridViewTextBoxColumn
            // 
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_CallBack_D_Avg";
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn.HeaderText = "转炉煤气回收日单耗";
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn.Name = "bOFCOCallBackDAvgDataGridViewTextBoxColumn";
            this.bOFCOCallBackDAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2DAvgDataGridViewTextBoxColumn
            // 
            this.n2DAvgDataGridViewTextBoxColumn.DataPropertyName = "N2_D_Avg";
            this.n2DAvgDataGridViewTextBoxColumn.HeaderText = "氮气日单耗";
            this.n2DAvgDataGridViewTextBoxColumn.Name = "n2DAvgDataGridViewTextBoxColumn";
            this.n2DAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2SpecialSteelDAvgDataGridViewTextBoxColumn
            // 
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn.DataPropertyName = "N2_SpecialSteel_D_Avg";
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn.HeaderText = "精品钢氮气日单耗";
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn.Name = "n2SpecialSteelDAvgDataGridViewTextBoxColumn";
            this.n2SpecialSteelDAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // o2DAvgDataGridViewTextBoxColumn
            // 
            this.o2DAvgDataGridViewTextBoxColumn.DataPropertyName = "O2_D_Avg";
            this.o2DAvgDataGridViewTextBoxColumn.HeaderText = "氧气日单耗";
            this.o2DAvgDataGridViewTextBoxColumn.Name = "o2DAvgDataGridViewTextBoxColumn";
            this.o2DAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFCOMDataGridViewTextBoxColumn
            // 
            this.cFCOMDataGridViewTextBoxColumn.DataPropertyName = "CFCO_M";
            this.cFCOMDataGridViewTextBoxColumn.HeaderText = "焦炉煤气累计消耗";
            this.cFCOMDataGridViewTextBoxColumn.Name = "cFCOMDataGridViewTextBoxColumn";
            this.cFCOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOMDataGridViewTextBoxColumn
            // 
            this.bOFCOMDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_M";
            this.bOFCOMDataGridViewTextBoxColumn.HeaderText = "转炉煤气累计消耗";
            this.bOFCOMDataGridViewTextBoxColumn.Name = "bOFCOMDataGridViewTextBoxColumn";
            this.bOFCOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOCallBackMDataGridViewTextBoxColumn
            // 
            this.bOFCOCallBackMDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_CallBack_M";
            this.bOFCOCallBackMDataGridViewTextBoxColumn.HeaderText = "转炉煤气回收累计消耗";
            this.bOFCOCallBackMDataGridViewTextBoxColumn.Name = "bOFCOCallBackMDataGridViewTextBoxColumn";
            this.bOFCOCallBackMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2MDataGridViewTextBoxColumn
            // 
            this.n2MDataGridViewTextBoxColumn.DataPropertyName = "N2_M";
            this.n2MDataGridViewTextBoxColumn.HeaderText = "氮气累计消耗";
            this.n2MDataGridViewTextBoxColumn.Name = "n2MDataGridViewTextBoxColumn";
            this.n2MDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2SpecialSteelMDataGridViewTextBoxColumn
            // 
            this.n2SpecialSteelMDataGridViewTextBoxColumn.DataPropertyName = "N2_SpecialSteel_M";
            this.n2SpecialSteelMDataGridViewTextBoxColumn.HeaderText = "精品钢氮气累计消耗";
            this.n2SpecialSteelMDataGridViewTextBoxColumn.Name = "n2SpecialSteelMDataGridViewTextBoxColumn";
            this.n2SpecialSteelMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // o2MDataGridViewTextBoxColumn
            // 
            this.o2MDataGridViewTextBoxColumn.DataPropertyName = "O2_M";
            this.o2MDataGridViewTextBoxColumn.HeaderText = "氧气累计消耗";
            this.o2MDataGridViewTextBoxColumn.Name = "o2MDataGridViewTextBoxColumn";
            this.o2MDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFCOMAvgDataGridViewTextBoxColumn
            // 
            this.cFCOMAvgDataGridViewTextBoxColumn.DataPropertyName = "CFCO_M_Avg";
            this.cFCOMAvgDataGridViewTextBoxColumn.HeaderText = "焦炉煤气累计单耗";
            this.cFCOMAvgDataGridViewTextBoxColumn.Name = "cFCOMAvgDataGridViewTextBoxColumn";
            this.cFCOMAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOMAvgDataGridViewTextBoxColumn
            // 
            this.bOFCOMAvgDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_M_Avg";
            this.bOFCOMAvgDataGridViewTextBoxColumn.HeaderText = "转炉煤气累计单耗";
            this.bOFCOMAvgDataGridViewTextBoxColumn.Name = "bOFCOMAvgDataGridViewTextBoxColumn";
            this.bOFCOMAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFCOCallBackMAvgDataGridViewTextBoxColumn
            // 
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn.DataPropertyName = "BOFCO_CallBack_M_Avg";
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn.HeaderText = "转炉煤气回收累计单耗";
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn.Name = "bOFCOCallBackMAvgDataGridViewTextBoxColumn";
            this.bOFCOCallBackMAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2MAvgDataGridViewTextBoxColumn
            // 
            this.n2MAvgDataGridViewTextBoxColumn.DataPropertyName = "N2_M_Avg";
            this.n2MAvgDataGridViewTextBoxColumn.HeaderText = "氮气累计单耗";
            this.n2MAvgDataGridViewTextBoxColumn.Name = "n2MAvgDataGridViewTextBoxColumn";
            this.n2MAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n2SpecialSteelMAvgDataGridViewTextBoxColumn
            // 
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn.DataPropertyName = "N2_SpecialSteel_M_Avg";
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn.HeaderText = "精品钢氮气累计单耗";
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn.Name = "n2SpecialSteelMAvgDataGridViewTextBoxColumn";
            this.n2SpecialSteelMAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // o2MAvgDataGridViewTextBoxColumn
            // 
            this.o2MAvgDataGridViewTextBoxColumn.DataPropertyName = "O2_M_Avg";
            this.o2MAvgDataGridViewTextBoxColumn.HeaderText = "氧气累计单耗";
            this.o2MAvgDataGridViewTextBoxColumn.Name = "o2MAvgDataGridViewTextBoxColumn";
            this.o2MAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "录入时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GUID
            // 
            this.GUID.DataPropertyName = "GUID";
            this.GUID.HeaderText = "GUID";
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.Visible = false;
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvStat);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 532);
            this.hmiRootPanel1.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductionDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "生产日期";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Flow_CFCO";
            this.dataGridViewTextBoxColumn2.HeaderText = "焦炉煤气瞬时流量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Flow_BOFCO";
            this.dataGridViewTextBoxColumn3.HeaderText = "转炉煤气瞬时流量";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Flow_BOFCO_CallBack";
            this.dataGridViewTextBoxColumn4.HeaderText = "转炉煤气回收瞬时流量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Flow_N2";
            this.dataGridViewTextBoxColumn5.HeaderText = "氮气瞬时流量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Flow_N2_SpecialSteel";
            this.dataGridViewTextBoxColumn6.HeaderText = "精品钢氮气瞬时流量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Flow_O2";
            this.dataGridViewTextBoxColumn7.HeaderText = "氧气瞬时流量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CFCO_D";
            this.dataGridViewTextBoxColumn8.HeaderText = "焦炉煤气日消耗量";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BOFCO_D";
            this.dataGridViewTextBoxColumn9.HeaderText = "转炉煤气日消耗量";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BOFCO_CallBack_D";
            this.dataGridViewTextBoxColumn10.HeaderText = "转炉煤气回收日消耗量";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "N2_D";
            this.dataGridViewTextBoxColumn11.HeaderText = "氮气瞬时流量";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "N2_SpecialSteel_D";
            this.dataGridViewTextBoxColumn12.HeaderText = "精品钢氮气日消耗量";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "O2_D";
            this.dataGridViewTextBoxColumn13.HeaderText = "氧气日消耗量";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CFCO_D_Avg";
            this.dataGridViewTextBoxColumn14.HeaderText = "焦炉煤气日单耗";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BOFCO_D_Avg";
            this.dataGridViewTextBoxColumn15.HeaderText = "转炉煤气日单耗";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "BOFCO_CallBack_D_Avg";
            this.dataGridViewTextBoxColumn16.HeaderText = "转炉煤气回收日单耗";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "N2_D_Avg";
            this.dataGridViewTextBoxColumn17.HeaderText = "氮气日单耗";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "N2_SpecialSteel_D_Avg";
            this.dataGridViewTextBoxColumn18.HeaderText = "精品钢氮气日单耗";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "O2_D_Avg";
            this.dataGridViewTextBoxColumn19.HeaderText = "氧气日单耗";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CFCO_M";
            this.dataGridViewTextBoxColumn20.HeaderText = "焦炉煤气累计消耗";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "BOFCO_M";
            this.dataGridViewTextBoxColumn21.HeaderText = "转炉煤气累计消耗";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "BOFCO_CallBack_M";
            this.dataGridViewTextBoxColumn22.HeaderText = "转炉煤气回收累计消耗";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "N2_M";
            this.dataGridViewTextBoxColumn23.HeaderText = "氮气累计消耗";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "N2_SpecialSteel_M";
            this.dataGridViewTextBoxColumn24.HeaderText = "精品钢氮气累计消耗";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "O2_M";
            this.dataGridViewTextBoxColumn25.HeaderText = "氧气累计消耗";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CFCO_M_Avg";
            this.dataGridViewTextBoxColumn26.HeaderText = "焦炉煤气累计单耗";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "BOFCO_M_Avg";
            this.dataGridViewTextBoxColumn27.HeaderText = "转炉煤气累计单耗";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "BOFCO_CallBack_M_Avg";
            this.dataGridViewTextBoxColumn28.HeaderText = "转炉煤气回收累计单耗";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "N2_M_Avg";
            this.dataGridViewTextBoxColumn29.HeaderText = "氮气累计单耗";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "N2_SpecialSteel_M_Avg";
            this.dataGridViewTextBoxColumn30.HeaderText = "精品钢氮气累计单耗";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "O2_M_Avg";
            this.dataGridViewTextBoxColumn31.HeaderText = "氧气累计单耗";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Production_D";
            this.dataGridViewTextBoxColumn32.HeaderText = "日产量";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Production_M";
            this.dataGridViewTextBoxColumn33.HeaderText = "累计产量";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "CreateTime";
            this.dataGridViewTextBoxColumn34.HeaderText = "录入时刻";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn35.HeaderText = "操作员";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // EnergyStatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnergyStatFrm";
            this.TabText = "炼钢厂能源日消耗统计管理";
            this.Text = "炼钢厂能源日消耗统计管理";
            this.Load += new System.EventHandler(this.EnergyStatFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvStat)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dvStat;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.BindingSource bsStat;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3DataSet dsStat;
        private System.Data.DataTable schemadsStat;
        private System.Data.DataColumn coldsStatL3DataTableGUID;
        private System.Data.DataColumn coldsStatL3DataTableName;
        private System.Data.DataColumn coldsStatL3DataTableProductionDate;
        private System.Data.DataColumn coldsStatL3DataTableFlow_CFCO;
        private System.Data.DataColumn coldsStatL3DataTableFlow_BOFCO;
        private System.Data.DataColumn coldsStatL3DataTableFlow_BOFCO_CallBack;
        private System.Data.DataColumn coldsStatL3DataTableFlow_N2;
        private System.Data.DataColumn coldsStatL3DataTableFlow_N2_SpecialSteel;
        private System.Data.DataColumn coldsStatL3DataTableFlow_O2;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_D;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_D;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_D;
        private System.Data.DataColumn coldsStatL3DataTableN2_D;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_D;
        private System.Data.DataColumn coldsStatL3DataTableO2_D;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableO2_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_M;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_M;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_M;
        private System.Data.DataColumn coldsStatL3DataTableN2_M;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_M;
        private System.Data.DataColumn coldsStatL3DataTableO2_M;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableO2_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableProduction_D;
        private System.Data.DataColumn coldsStatL3DataTableProduction_M;
        private System.Data.DataColumn coldsStatL3DataTableCreateTime;
        private System.Data.DataColumn coldsStatL3DataTableOperator;
        private System.Data.DataColumn coldsStatL3DataTableStatus;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Data.DataColumn coldsStatL3DataTableProduction_Special_D;
        private System.Data.DataColumn coldsStatL3DataTableProduction_Special_M;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Production_Special_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Production_Special_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowCFCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowBOFCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowBOFCOCallBackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowN2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowN2SpecialSteelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFCODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOCallBackDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2SpecialSteelDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2DDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFCODAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCODAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOCallBackDAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2SpecialSteelDAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2DAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOCallBackMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2MDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2SpecialSteelMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2MDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFCOMAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOMAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFCOCallBackMAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2MAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2SpecialSteelMAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2MAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOutPut;
    }
}