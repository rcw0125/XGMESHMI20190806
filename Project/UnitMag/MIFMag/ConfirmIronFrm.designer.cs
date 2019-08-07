namespace UnitMag.MIFMag
{
    partial class ConfirmIronFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmIronFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsIron = new System.Windows.Forms.BindingSource(this.components);
            this.dsgIron = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.l3cmdIron = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsGrid1 = new System.Data.DataTable();
            this.coldsGrid1L3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableBFID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSource = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableC = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSi = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableMn = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableS = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableP = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTi = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsgIronL3DataTableStatus = new System.Data.DataColumn();
            this.coldsgIronL3DataTableDestination = new System.Data.DataColumn();
            this.coldsgIronL3DataTableShift = new System.Data.DataColumn();
            this.coldsgIronL3DataTableOperator = new System.Data.DataColumn();
            this.coldsgIronL3DataTableSendFlag = new System.Data.DataColumn();
            this.coldsgIronL3DataTableTeam = new System.Data.DataColumn();
            this.coldsgIronL3DataTableResult = new System.Data.DataColumn();
            this.coldsgIronL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsgIronL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsgIronL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsgIronL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsgIronL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsgIronL3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsgIronL3DataTableSELECTED = new System.Data.DataColumn();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.dsIronSource = new AppSvrHMI.L3DataSet();
            this.schemadsIronSource = new System.Data.DataTable();
            this.coldsIronSourceL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronSourceL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.l3cmdConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3cmdparamConfirm = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.SELECTED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsgIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsIron
            // 
            this.bsIron.DataMember = "L3DataTable";
            this.bsIron.DataSource = this.dsgIron;
            // 
            // dsgIron
            // 
            this.dsgIron.DataSetName = "L3DataSet";
            this.dsgIron.DeleteMethod = "";
            this.dsgIron.InsertMethod = "";
            this.dsgIron.L3DataAdapter = this.Adapter;
            this.dsgIron.LoadEvent = "Click";
            this.dsgIron.LoadTrigger = this.btnRefresh;
            this.dsgIron.RefreshValve = 1000;
            this.dsgIron.SourceCommand = this.l3cmdIron;
            this.dsgIron.SourceCondition = null;
            this.dsgIron.SourceMethod = "GetUnArrivedIrons";
            this.dsgIron.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsgIron.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.dsgIron.SubscribeTarget = "XGMESLogic\\BaseDataMag\\XGStoreArea\\S01.MaterialChanged";
            this.dsgIron.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGrid1});
            this.dsgIron.UpdateEvent = "Click";
            this.dsgIron.UpdateMethod = "";
            this.dsgIron.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 40);
            this.btnRefresh.Text = "刷新";
            // 
            // l3cmdIron
            // 
            this.l3cmdIron.Adapter = null;
            this.l3cmdIron.MergeReturnTarget = false;
            this.l3cmdIron.Method = null;
            this.l3cmdIron.Object = null;
            this.l3cmdIron.Parameters.Add(this.l3CommandParameter1);
            this.l3cmdIron.ReturnTarget = null;
            this.l3cmdIron.ReturnTargetProperty = null;
            this.l3cmdIron.Trigger = null;
            this.l3cmdIron.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = "1";
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // schemadsGrid1
            // 
            this.schemadsGrid1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGrid1L3DataTableMaterialID,
            this.coldsGrid1L3DataTableBFID,
            this.coldsGrid1L3DataTableTAP_No,
            this.coldsGrid1L3DataTableTPC_No,
            this.coldsGrid1L3DataTableSource,
            this.coldsGrid1L3DataTableProduction_Date,
            this.coldsGrid1L3DataTableC,
            this.coldsGrid1L3DataTableSi,
            this.coldsGrid1L3DataTableMn,
            this.coldsGrid1L3DataTableS,
            this.coldsGrid1L3DataTableP,
            this.coldsGrid1L3DataTableTi,
            this.coldsGrid1L3DataTableNet_Weight,
            this.coldsgIronL3DataTableStatus,
            this.coldsgIronL3DataTableDestination,
            this.coldsgIronL3DataTableShift,
            this.coldsgIronL3DataTableOperator,
            this.coldsgIronL3DataTableSendFlag,
            this.coldsgIronL3DataTableTeam,
            this.coldsgIronL3DataTableResult,
            this.coldsgIronL3DataTableSample_Place,
            this.coldsgIronL3DataTableGross_Weight,
            this.coldsgIronL3DataTableLast_Tare,
            this.coldsgIronL3DataTableCurr_Tare,
            this.coldsgIronL3DataTableSpare_Weight,
            this.coldsgIronL3DataTableIronStatus,
            this.coldsgIronL3DataTableSELECTED});
            this.schemadsGrid1.TableName = "L3DataTable";
            // 
            // coldsGrid1L3DataTableMaterialID
            // 
            this.coldsGrid1L3DataTableMaterialID.Caption = "MaterialID";
            this.coldsGrid1L3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsGrid1L3DataTableMaterialID.DefaultValue = "";
            this.coldsGrid1L3DataTableMaterialID.Namespace = "";
            // 
            // coldsGrid1L3DataTableBFID
            // 
            this.coldsGrid1L3DataTableBFID.Caption = "BFID";
            this.coldsGrid1L3DataTableBFID.ColumnName = "BFID";
            this.coldsGrid1L3DataTableBFID.DefaultValue = "";
            this.coldsGrid1L3DataTableBFID.Namespace = "";
            // 
            // coldsGrid1L3DataTableTAP_No
            // 
            this.coldsGrid1L3DataTableTAP_No.Caption = "TAP_No";
            this.coldsGrid1L3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsGrid1L3DataTableTAP_No.DefaultValue = "";
            this.coldsGrid1L3DataTableTAP_No.Namespace = "";
            // 
            // coldsGrid1L3DataTableTPC_No
            // 
            this.coldsGrid1L3DataTableTPC_No.Caption = "TPC_No";
            this.coldsGrid1L3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsGrid1L3DataTableTPC_No.DefaultValue = "";
            this.coldsGrid1L3DataTableTPC_No.Namespace = "";
            // 
            // coldsGrid1L3DataTableSource
            // 
            this.coldsGrid1L3DataTableSource.Caption = "Source";
            this.coldsGrid1L3DataTableSource.ColumnName = "Source";
            this.coldsGrid1L3DataTableSource.DataType = typeof(int);
            this.coldsGrid1L3DataTableSource.DefaultValue = 0;
            this.coldsGrid1L3DataTableSource.Namespace = "";
            // 
            // coldsGrid1L3DataTableProduction_Date
            // 
            this.coldsGrid1L3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsGrid1L3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsGrid1L3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableProduction_Date.Namespace = "";
            // 
            // coldsGrid1L3DataTableC
            // 
            this.coldsGrid1L3DataTableC.Caption = "C";
            this.coldsGrid1L3DataTableC.ColumnName = "C";
            this.coldsGrid1L3DataTableC.DataType = typeof(float);
            this.coldsGrid1L3DataTableC.DefaultValue = 0F;
            this.coldsGrid1L3DataTableC.Namespace = "";
            // 
            // coldsGrid1L3DataTableSi
            // 
            this.coldsGrid1L3DataTableSi.Caption = "Si";
            this.coldsGrid1L3DataTableSi.ColumnName = "Si";
            this.coldsGrid1L3DataTableSi.DataType = typeof(float);
            this.coldsGrid1L3DataTableSi.DefaultValue = 0F;
            this.coldsGrid1L3DataTableSi.Namespace = "";
            // 
            // coldsGrid1L3DataTableMn
            // 
            this.coldsGrid1L3DataTableMn.Caption = "Mn";
            this.coldsGrid1L3DataTableMn.ColumnName = "Mn";
            this.coldsGrid1L3DataTableMn.DataType = typeof(float);
            this.coldsGrid1L3DataTableMn.DefaultValue = 0F;
            this.coldsGrid1L3DataTableMn.Namespace = "";
            // 
            // coldsGrid1L3DataTableS
            // 
            this.coldsGrid1L3DataTableS.Caption = "S";
            this.coldsGrid1L3DataTableS.ColumnName = "S";
            this.coldsGrid1L3DataTableS.DataType = typeof(float);
            this.coldsGrid1L3DataTableS.DefaultValue = 0F;
            this.coldsGrid1L3DataTableS.Namespace = "";
            // 
            // coldsGrid1L3DataTableP
            // 
            this.coldsGrid1L3DataTableP.Caption = "P";
            this.coldsGrid1L3DataTableP.ColumnName = "P";
            this.coldsGrid1L3DataTableP.DataType = typeof(float);
            this.coldsGrid1L3DataTableP.DefaultValue = 0F;
            this.coldsGrid1L3DataTableP.Namespace = "";
            // 
            // coldsGrid1L3DataTableTi
            // 
            this.coldsGrid1L3DataTableTi.Caption = "Ti";
            this.coldsGrid1L3DataTableTi.ColumnName = "Ti";
            this.coldsGrid1L3DataTableTi.DataType = typeof(float);
            this.coldsGrid1L3DataTableTi.DefaultValue = 0F;
            this.coldsGrid1L3DataTableTi.Namespace = "";
            // 
            // coldsGrid1L3DataTableNet_Weight
            // 
            this.coldsGrid1L3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsGrid1L3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsGrid1L3DataTableNet_Weight.DataType = typeof(float);
            this.coldsGrid1L3DataTableNet_Weight.DefaultValue = 0F;
            this.coldsGrid1L3DataTableNet_Weight.Namespace = "";
            // 
            // coldsgIronL3DataTableStatus
            // 
            this.coldsgIronL3DataTableStatus.Caption = "Status";
            this.coldsgIronL3DataTableStatus.ColumnName = "Status";
            this.coldsgIronL3DataTableStatus.DataType = typeof(int);
            this.coldsgIronL3DataTableStatus.DefaultValue = 0;
            this.coldsgIronL3DataTableStatus.Namespace = "";
            // 
            // coldsgIronL3DataTableDestination
            // 
            this.coldsgIronL3DataTableDestination.Caption = "Destination";
            this.coldsgIronL3DataTableDestination.ColumnName = "Destination";
            this.coldsgIronL3DataTableDestination.DataType = typeof(int);
            this.coldsgIronL3DataTableDestination.DefaultValue = 0;
            this.coldsgIronL3DataTableDestination.Namespace = "";
            // 
            // coldsgIronL3DataTableShift
            // 
            this.coldsgIronL3DataTableShift.Caption = "Shift";
            this.coldsgIronL3DataTableShift.ColumnName = "Shift";
            this.coldsgIronL3DataTableShift.DataType = typeof(int);
            this.coldsgIronL3DataTableShift.DefaultValue = 0;
            this.coldsgIronL3DataTableShift.Namespace = "";
            // 
            // coldsgIronL3DataTableOperator
            // 
            this.coldsgIronL3DataTableOperator.Caption = "Operator";
            this.coldsgIronL3DataTableOperator.ColumnName = "Operator";
            this.coldsgIronL3DataTableOperator.DefaultValue = "";
            this.coldsgIronL3DataTableOperator.Namespace = "";
            // 
            // coldsgIronL3DataTableSendFlag
            // 
            this.coldsgIronL3DataTableSendFlag.Caption = "SendFlag";
            this.coldsgIronL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsgIronL3DataTableSendFlag.DataType = typeof(int);
            this.coldsgIronL3DataTableSendFlag.DefaultValue = 0;
            this.coldsgIronL3DataTableSendFlag.Namespace = "";
            // 
            // coldsgIronL3DataTableTeam
            // 
            this.coldsgIronL3DataTableTeam.Caption = "Team";
            this.coldsgIronL3DataTableTeam.ColumnName = "Team";
            this.coldsgIronL3DataTableTeam.DataType = typeof(int);
            this.coldsgIronL3DataTableTeam.DefaultValue = 0;
            this.coldsgIronL3DataTableTeam.Namespace = "";
            // 
            // coldsgIronL3DataTableResult
            // 
            this.coldsgIronL3DataTableResult.Caption = "Result";
            this.coldsgIronL3DataTableResult.ColumnName = "Result";
            this.coldsgIronL3DataTableResult.DataType = typeof(int);
            this.coldsgIronL3DataTableResult.DefaultValue = 0;
            this.coldsgIronL3DataTableResult.Namespace = "";
            // 
            // coldsgIronL3DataTableSample_Place
            // 
            this.coldsgIronL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsgIronL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsgIronL3DataTableSample_Place.DefaultValue = "";
            this.coldsgIronL3DataTableSample_Place.Namespace = "";
            // 
            // coldsgIronL3DataTableGross_Weight
            // 
            this.coldsgIronL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsgIronL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsgIronL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsgIronL3DataTableGross_Weight.DefaultValue = 0F;
            this.coldsgIronL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsgIronL3DataTableLast_Tare
            // 
            this.coldsgIronL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsgIronL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsgIronL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsgIronL3DataTableLast_Tare.DefaultValue = 0F;
            this.coldsgIronL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsgIronL3DataTableCurr_Tare
            // 
            this.coldsgIronL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsgIronL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsgIronL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsgIronL3DataTableCurr_Tare.DefaultValue = 0F;
            this.coldsgIronL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsgIronL3DataTableSpare_Weight
            // 
            this.coldsgIronL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsgIronL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsgIronL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsgIronL3DataTableSpare_Weight.DefaultValue = 0;
            this.coldsgIronL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsgIronL3DataTableIronStatus
            // 
            this.coldsgIronL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsgIronL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsgIronL3DataTableIronStatus.DataType = typeof(int);
            this.coldsgIronL3DataTableIronStatus.DefaultValue = 0;
            this.coldsgIronL3DataTableIronStatus.Namespace = "";
            // 
            // coldsgIronL3DataTableSELECTED
            // 
            this.coldsgIronL3DataTableSELECTED.Caption = "SELECTED";
            this.coldsgIronL3DataTableSELECTED.ColumnName = "SELECTED";
            this.coldsgIronL3DataTableSELECTED.DataType = typeof(bool);
            this.coldsgIronL3DataTableSELECTED.Namespace = "";
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnConfirm,
            this.btnRefresh});
            this.tSp1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Size = new System.Drawing.Size(568, 43);
            this.tSp1.TabIndex = 14;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
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
            this.bdN1.Size = new System.Drawing.Size(568, 25);
            this.bdN1.TabIndex = 22;
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(568, 353);
            this.hmiRootPanel1.TabIndex = 23;
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
            this.SELECTED,
            this.bFIDDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsIron;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Name = "dvM";
            this.dvM.RowHeadersVisible = false;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(564, 349);
            this.dvM.TabIndex = 25;
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // dsIronSource
            // 
            this.dsIronSource.DataSetName = "L3DataSet";
            this.dsIronSource.DeleteMethod = null;
            this.dsIronSource.InsertMethod = null;
            this.dsIronSource.L3DataAdapter = this.Adapter;
            this.dsIronSource.LoadEvent = "Click";
            this.dsIronSource.LoadTrigger = null;
            this.dsIronSource.RefreshValve = 1000;
            this.dsIronSource.SourceCommand = null;
            this.dsIronSource.SourceCondition = "CODE_GROUP = \'Iron_Source\'";
            this.dsIronSource.SourceMethod = "";
            this.dsIronSource.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronSource.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronSource.SubscribeTarget = null;
            this.dsIronSource.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronSource});
            this.dsIronSource.UpdateEvent = "Click";
            this.dsIronSource.UpdateMethod = null;
            this.dsIronSource.UpdateTrigger = null;
            // 
            // schemadsIronSource
            // 
            this.schemadsIronSource.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronSourceL3DataTableCode_Des,
            this.coldsIronSourceL3DataTableCode_Val_Long});
            this.schemadsIronSource.TableName = "L3DataTable";
            // 
            // coldsIronSourceL3DataTableCode_Des
            // 
            this.coldsIronSourceL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronSourceL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronSourceL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronSourceL3DataTableCode_Val_Long
            // 
            this.coldsIronSourceL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronSourceL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronSourceL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronSourceL3DataTableCode_Val_Long.Namespace = "";
            // 
            // l3cmdConfirm
            // 
            this.l3cmdConfirm.Adapter = this.Adapter;
            this.l3cmdConfirm.MergeReturnTarget = false;
            this.l3cmdConfirm.Method = "ConfirmIronArrive";
            this.l3cmdConfirm.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.l3cmdConfirm.Parameters.Add(this.l3cmdparamConfirm);
            this.l3cmdConfirm.ReturnTarget = null;
            this.l3cmdConfirm.ReturnTargetProperty = null;
            this.l3cmdConfirm.Trigger = null;
            this.l3cmdConfirm.TriggerEvent = "Click";
            // 
            // l3cmdparamConfirm
            // 
            this.l3cmdparamConfirm.AcceptAfterExecuted = false;
            this.l3cmdparamConfirm.ConstantValue = null;
            this.l3cmdparamConfirm.MergeTarget = false;
            this.l3cmdparamConfirm.SourceFilter = null;
            this.l3cmdparamConfirm.SourceObject = null;
            this.l3cmdparamConfirm.SourceProperty = null;
            this.l3cmdparamConfirm.TargetObject = null;
            this.l3cmdparamConfirm.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'UnitMag\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableERROR_CODE,
            this.coldsErrorL3DataTableERROR_DES});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableERROR_CODE
            // 
            this.coldsErrorL3DataTableERROR_CODE.Caption = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.ColumnName = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.Namespace = "";
            // 
            // coldsErrorL3DataTableERROR_DES
            // 
            this.coldsErrorL3DataTableERROR_DES.Caption = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.ColumnName = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.Namespace = "";
            // 
            // SELECTED
            // 
            this.SELECTED.DataPropertyName = "SELECTED";
            this.SELECTED.HeaderText = "选择";
            this.SELECTED.Name = "SELECTED";
            this.SELECTED.Width = 35;
            // 
            // bFIDDataGridViewTextBoxColumn
            // 
            this.bFIDDataGridViewTextBoxColumn.DataPropertyName = "BFID";
            this.bFIDDataGridViewTextBoxColumn.HeaderText = "高炉炉号";
            this.bFIDDataGridViewTextBoxColumn.Name = "bFIDDataGridViewTextBoxColumn";
            this.bFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bFIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // tAPNoDataGridViewTextBoxColumn
            // 
            this.tAPNoDataGridViewTextBoxColumn.DataPropertyName = "TAP_No";
            this.tAPNoDataGridViewTextBoxColumn.HeaderText = "铁次号";
            this.tAPNoDataGridViewTextBoxColumn.Name = "tAPNoDataGridViewTextBoxColumn";
            this.tAPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAPNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            this.tPCNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.DataSource = this.dsIronSource;
            this.sourceDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sourceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceDataGridViewTextBoxColumn.HeaderText = "铁水来源";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sourceDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sourceDataGridViewTextBoxColumn.Width = 78;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期(进机时刻)";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 138;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C成份";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 60;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si成份";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn成份";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 66;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S成份";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 60;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P成份";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 60;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti成份";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 66;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "净重";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Visible = false;
            this.materialIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // ConfirmIronFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 421);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.Name = "ConfirmIronFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁水到达确认";
            ((System.ComponentModel.ISupportInitialize)(this.bsIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsgIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsIron;
        private AppSvrHMI.L3DataSet dsgIron;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Data.DataTable schemadsGrid1;
        private System.Data.DataColumn coldsGrid1L3DataTableMaterialID;
        private System.Data.DataColumn coldsGrid1L3DataTableBFID;
        private System.Data.DataColumn coldsGrid1L3DataTableTAP_No;
        private System.Data.DataColumn coldsGrid1L3DataTableTPC_No;
        private System.Data.DataColumn coldsGrid1L3DataTableSource;
        private System.Data.DataColumn coldsGrid1L3DataTableProduction_Date;
        private System.Data.DataColumn coldsGrid1L3DataTableC;
        private System.Data.DataColumn coldsGrid1L3DataTableSi;
        private System.Data.DataColumn coldsGrid1L3DataTableMn;
        private System.Data.DataColumn coldsGrid1L3DataTableS;
        private System.Data.DataColumn coldsGrid1L3DataTableP;
        private System.Data.DataColumn coldsGrid1L3DataTableTi;
        private System.Data.DataColumn coldsGrid1L3DataTableNet_Weight;
        private AppSvrHMI.L3Command l3cmdIron;
        private System.Data.DataColumn coldsgIronL3DataTableStatus;
        private System.Data.DataColumn coldsgIronL3DataTableDestination;
        private System.Data.DataColumn coldsgIronL3DataTableShift;
        private System.Data.DataColumn coldsgIronL3DataTableOperator;
        private System.Data.DataColumn coldsgIronL3DataTableSendFlag;
        private System.Data.DataColumn coldsgIronL3DataTableTeam;
        private System.Data.DataColumn coldsgIronL3DataTableResult;
        private System.Data.DataColumn coldsgIronL3DataTableSample_Place;
        private System.Data.DataColumn coldsgIronL3DataTableGross_Weight;
        private System.Data.DataColumn coldsgIronL3DataTableLast_Tare;
        private System.Data.DataColumn coldsgIronL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsgIronL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsgIronL3DataTableIronStatus;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3Command l3cmdConfirm;
        private AppSvrHMI.L3CommandParameter l3cmdparamConfirm;
        private System.Data.DataColumn coldsgIronL3DataTableSELECTED;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
        private AppSvrHMI.L3DataSet dsIronSource;
        private System.Data.DataTable schemadsIronSource;
        private System.Data.DataColumn coldsIronSourceL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronSourceL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTED;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
    }
}