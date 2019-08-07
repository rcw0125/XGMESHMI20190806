namespace UnitMag.BFMag
{
    partial class IronNetWeightFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronNetWeightFrm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBFID = new System.Windows.Forms.TextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.txtTapNo = new System.Windows.Forms.TextBox();
            this.txtTpcNo = new System.Windows.Forms.TextBox();
            this.txtNetWeghit = new System.Windows.Forms.TextBox();
            this.lbHeatName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.cmdSendIronToCast = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableStatus = new System.Data.DataColumn();
            this.coldsMainL3DataTablePosition = new System.Data.DataColumn();
            this.coldsMainL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsMainL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsMainL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsMainL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSource = new System.Data.DataColumn();
            this.coldsMainL3DataTableDestination = new System.Data.DataColumn();
            this.coldsMainL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeam = new System.Data.DataColumn();
            this.coldsMainL3DataTableResult = new System.Data.DataColumn();
            this.coldsMainL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsMainL3DataTableC = new System.Data.DataColumn();
            this.coldsMainL3DataTableSi = new System.Data.DataColumn();
            this.coldsMainL3DataTableMn = new System.Data.DataColumn();
            this.coldsMainL3DataTableS = new System.Data.DataColumn();
            this.coldsMainL3DataTableP = new System.Data.DataColumn();
            this.coldsMainL3DataTableTi = new System.Data.DataColumn();
            this.coldsMainL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsMainL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFeed_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSend_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSampCode = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronConfirm = new System.Data.DataColumn();
            this.coldsMainL3DataTableC_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableSi_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableMn_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableS_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableP_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableTi_B = new System.Data.DataColumn();
            this.coldsMainL3DataTableGrossFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTareFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableAnalysisFlag = new System.Data.DataColumn();
            this.dsM = new AppSvrHMI.L3DataSet();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableName = new System.Data.DataColumn();
            this.coldsML3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsML3DataTableStatus = new System.Data.DataColumn();
            this.coldsML3DataTablePosition = new System.Data.DataColumn();
            this.coldsML3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsML3DataTableQALevel = new System.Data.DataColumn();
            this.coldsML3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsML3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsML3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsML3DataTableBFID = new System.Data.DataColumn();
            this.coldsML3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsML3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsML3DataTableSource = new System.Data.DataColumn();
            this.coldsML3DataTableDestination = new System.Data.DataColumn();
            this.coldsML3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsML3DataTableShift = new System.Data.DataColumn();
            this.coldsML3DataTableOperator = new System.Data.DataColumn();
            this.coldsML3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsML3DataTableTeam = new System.Data.DataColumn();
            this.coldsML3DataTableResult = new System.Data.DataColumn();
            this.coldsML3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsML3DataTableC = new System.Data.DataColumn();
            this.coldsML3DataTableSi = new System.Data.DataColumn();
            this.coldsML3DataTableMn = new System.Data.DataColumn();
            this.coldsML3DataTableS = new System.Data.DataColumn();
            this.coldsML3DataTableP = new System.Data.DataColumn();
            this.coldsML3DataTableTi = new System.Data.DataColumn();
            this.coldsML3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsML3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsML3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsML3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsML3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsML3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsML3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsML3DataTableFeed_Time = new System.Data.DataColumn();
            this.coldsML3DataTableSend_Time = new System.Data.DataColumn();
            this.coldsML3DataTableSampCode = new System.Data.DataColumn();
            this.coldsML3DataTableIronConfirm = new System.Data.DataColumn();
            this.coldsML3DataTableC_B = new System.Data.DataColumn();
            this.coldsML3DataTableSi_B = new System.Data.DataColumn();
            this.coldsML3DataTableMn_B = new System.Data.DataColumn();
            this.coldsML3DataTableS_B = new System.Data.DataColumn();
            this.coldsML3DataTableP_B = new System.Data.DataColumn();
            this.coldsML3DataTableTi_B = new System.Data.DataColumn();
            this.coldsML3DataTableGrossFlag = new System.Data.DataColumn();
            this.coldsML3DataTableTareFlag = new System.Data.DataColumn();
            this.coldsML3DataTableAnalysisFlag = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(217, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 177);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtBFID);
            this.tabPage1.Controls.Add(this.txtTapNo);
            this.tabPage1.Controls.Add(this.txtTpcNo);
            this.tabPage1.Controls.Add(this.txtNetWeghit);
            this.tabPage1.Controls.Add(this.lbHeatName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铁水信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBFID
            // 
            this.txtBFID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BFID", true));
            this.txtBFID.Location = new System.Drawing.Point(136, 22);
            this.txtBFID.Name = "txtBFID";
            this.txtBFID.ReadOnly = true;
            this.txtBFID.Size = new System.Drawing.Size(169, 21);
            this.txtBFID.TabIndex = 0;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsM;
            // 
            // txtTapNo
            // 
            this.txtTapNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TAP_No", true));
            this.txtTapNo.Location = new System.Drawing.Point(136, 48);
            this.txtTapNo.Name = "txtTapNo";
            this.txtTapNo.ReadOnly = true;
            this.txtTapNo.Size = new System.Drawing.Size(169, 21);
            this.txtTapNo.TabIndex = 1;
            // 
            // txtTpcNo
            // 
            this.txtTpcNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TPC_No", true));
            this.txtTpcNo.Location = new System.Drawing.Point(136, 74);
            this.txtTpcNo.Name = "txtTpcNo";
            this.txtTpcNo.ReadOnly = true;
            this.txtTpcNo.Size = new System.Drawing.Size(169, 21);
            this.txtTpcNo.TabIndex = 2;
            // 
            // txtNetWeghit
            // 
            this.txtNetWeghit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Net_Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.txtNetWeghit.Location = new System.Drawing.Point(136, 100);
            this.txtNetWeghit.Name = "txtNetWeghit";
            this.txtNetWeghit.Size = new System.Drawing.Size(169, 21);
            this.txtNetWeghit.TabIndex = 3;
            // 
            // lbHeatName
            // 
            this.lbHeatName.AutoSize = true;
            this.lbHeatName.Location = new System.Drawing.Point(71, 26);
            this.lbHeatName.Name = "lbHeatName";
            this.lbHeatName.Size = new System.Drawing.Size(59, 12);
            this.lbHeatName.TabIndex = 17;
            this.lbHeatName.Text = "高炉炉号:";
            this.lbHeatName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "罐号:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 15;
            this.label19.Text = "净重[t]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "铁次:";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // cmdSendIronToCast
            // 
            this.cmdSendIronToCast.Adapter = this.Adapter;
            this.cmdSendIronToCast.MergeReturnTarget = false;
            this.cmdSendIronToCast.Method = "SendIronToCast";
            this.cmdSendIronToCast.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.cmdSendIronToCast.Parameters.Add(this.l3CommandParameter1);
            this.cmdSendIronToCast.ReturnTarget = null;
            this.cmdSendIronToCast.ReturnTargetProperty = null;
            this.cmdSendIronToCast.Trigger = null;
            this.cmdSendIronToCast.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsM;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableStatus
            // 
            this.coldsMainL3DataTableStatus.Caption = "Status";
            this.coldsMainL3DataTableStatus.ColumnName = "Status";
            this.coldsMainL3DataTableStatus.DataType = typeof(int);
            this.coldsMainL3DataTableStatus.Namespace = "";
            // 
            // coldsMainL3DataTablePosition
            // 
            this.coldsMainL3DataTablePosition.Caption = "Position";
            this.coldsMainL3DataTablePosition.ColumnName = "Position";
            this.coldsMainL3DataTablePosition.Namespace = "";
            // 
            // coldsMainL3DataTableQAStatus
            // 
            this.coldsMainL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsMainL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsMainL3DataTableQAStatus.DataType = typeof(int);
            this.coldsMainL3DataTableQAStatus.Namespace = "";
            // 
            // coldsMainL3DataTableQALevel
            // 
            this.coldsMainL3DataTableQALevel.Caption = "QALevel";
            this.coldsMainL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsMainL3DataTableQALevel.DataType = typeof(int);
            this.coldsMainL3DataTableQALevel.Namespace = "";
            // 
            // coldsMainL3DataTableOrderContractID
            // 
            this.coldsMainL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsMainL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsMainL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsMainL3DataTableProduceContractID
            // 
            this.coldsMainL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsMainL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsMainL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsMainL3DataTableSalesContractID
            // 
            this.coldsMainL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsMainL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsMainL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsMainL3DataTableSource
            // 
            this.coldsMainL3DataTableSource.Caption = "Source";
            this.coldsMainL3DataTableSource.ColumnName = "Source";
            this.coldsMainL3DataTableSource.DataType = typeof(int);
            this.coldsMainL3DataTableSource.Namespace = "";
            // 
            // coldsMainL3DataTableDestination
            // 
            this.coldsMainL3DataTableDestination.Caption = "Destination";
            this.coldsMainL3DataTableDestination.ColumnName = "Destination";
            this.coldsMainL3DataTableDestination.DataType = typeof(int);
            this.coldsMainL3DataTableDestination.Namespace = "";
            // 
            // coldsMainL3DataTableProduction_Date
            // 
            this.coldsMainL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsMainL3DataTableShift
            // 
            this.coldsMainL3DataTableShift.Caption = "Shift";
            this.coldsMainL3DataTableShift.ColumnName = "Shift";
            this.coldsMainL3DataTableShift.DataType = typeof(int);
            this.coldsMainL3DataTableShift.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableNC_Confirm_Flag
            // 
            this.coldsMainL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.coldsMainL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableTeam
            // 
            this.coldsMainL3DataTableTeam.Caption = "Team";
            this.coldsMainL3DataTableTeam.ColumnName = "Team";
            this.coldsMainL3DataTableTeam.DataType = typeof(int);
            this.coldsMainL3DataTableTeam.Namespace = "";
            // 
            // coldsMainL3DataTableResult
            // 
            this.coldsMainL3DataTableResult.Caption = "Result";
            this.coldsMainL3DataTableResult.ColumnName = "Result";
            this.coldsMainL3DataTableResult.DataType = typeof(int);
            this.coldsMainL3DataTableResult.Namespace = "";
            // 
            // coldsMainL3DataTableSample_Place
            // 
            this.coldsMainL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.Namespace = "";
            // 
            // coldsMainL3DataTableC
            // 
            this.coldsMainL3DataTableC.Caption = "C";
            this.coldsMainL3DataTableC.ColumnName = "C";
            this.coldsMainL3DataTableC.Namespace = "";
            // 
            // coldsMainL3DataTableSi
            // 
            this.coldsMainL3DataTableSi.Caption = "Si";
            this.coldsMainL3DataTableSi.ColumnName = "Si";
            this.coldsMainL3DataTableSi.Namespace = "";
            // 
            // coldsMainL3DataTableMn
            // 
            this.coldsMainL3DataTableMn.Caption = "Mn";
            this.coldsMainL3DataTableMn.ColumnName = "Mn";
            this.coldsMainL3DataTableMn.Namespace = "";
            // 
            // coldsMainL3DataTableS
            // 
            this.coldsMainL3DataTableS.Caption = "S";
            this.coldsMainL3DataTableS.ColumnName = "S";
            this.coldsMainL3DataTableS.Namespace = "";
            // 
            // coldsMainL3DataTableP
            // 
            this.coldsMainL3DataTableP.Caption = "P";
            this.coldsMainL3DataTableP.ColumnName = "P";
            this.coldsMainL3DataTableP.Namespace = "";
            // 
            // coldsMainL3DataTableTi
            // 
            this.coldsMainL3DataTableTi.Caption = "Ti";
            this.coldsMainL3DataTableTi.ColumnName = "Ti";
            this.coldsMainL3DataTableTi.Namespace = "";
            // 
            // coldsMainL3DataTableGross_Weight
            // 
            this.coldsMainL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsMainL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableLast_Tare
            // 
            this.coldsMainL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableCurr_Tare
            // 
            this.coldsMainL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableSpare_Weight
            // 
            this.coldsMainL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsMainL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableIronStatus
            // 
            this.coldsMainL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsMainL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsMainL3DataTableIronStatus.DataType = typeof(int);
            this.coldsMainL3DataTableIronStatus.Namespace = "";
            // 
            // coldsMainL3DataTableArrival_Time
            // 
            this.coldsMainL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsMainL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsMainL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsMainL3DataTableFeed_Time
            // 
            this.coldsMainL3DataTableFeed_Time.Caption = "Feed_Time";
            this.coldsMainL3DataTableFeed_Time.ColumnName = "Feed_Time";
            this.coldsMainL3DataTableFeed_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFeed_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSend_Time
            // 
            this.coldsMainL3DataTableSend_Time.Caption = "Send_Time";
            this.coldsMainL3DataTableSend_Time.ColumnName = "Send_Time";
            this.coldsMainL3DataTableSend_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSend_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSampCode
            // 
            this.coldsMainL3DataTableSampCode.Caption = "SampCode";
            this.coldsMainL3DataTableSampCode.ColumnName = "SampCode";
            this.coldsMainL3DataTableSampCode.Namespace = "";
            // 
            // coldsMainL3DataTableIronConfirm
            // 
            this.coldsMainL3DataTableIronConfirm.Caption = "IronConfirm";
            this.coldsMainL3DataTableIronConfirm.ColumnName = "IronConfirm";
            this.coldsMainL3DataTableIronConfirm.DataType = typeof(int);
            this.coldsMainL3DataTableIronConfirm.Namespace = "";
            // 
            // coldsMainL3DataTableC_B
            // 
            this.coldsMainL3DataTableC_B.Caption = "C_B";
            this.coldsMainL3DataTableC_B.ColumnName = "C_B";
            this.coldsMainL3DataTableC_B.Namespace = "";
            // 
            // coldsMainL3DataTableSi_B
            // 
            this.coldsMainL3DataTableSi_B.Caption = "Si_B";
            this.coldsMainL3DataTableSi_B.ColumnName = "Si_B";
            this.coldsMainL3DataTableSi_B.Namespace = "";
            // 
            // coldsMainL3DataTableMn_B
            // 
            this.coldsMainL3DataTableMn_B.Caption = "Mn_B";
            this.coldsMainL3DataTableMn_B.ColumnName = "Mn_B";
            this.coldsMainL3DataTableMn_B.Namespace = "";
            // 
            // coldsMainL3DataTableS_B
            // 
            this.coldsMainL3DataTableS_B.Caption = "S_B";
            this.coldsMainL3DataTableS_B.ColumnName = "S_B";
            this.coldsMainL3DataTableS_B.Namespace = "";
            // 
            // coldsMainL3DataTableP_B
            // 
            this.coldsMainL3DataTableP_B.Caption = "P_B";
            this.coldsMainL3DataTableP_B.ColumnName = "P_B";
            this.coldsMainL3DataTableP_B.Namespace = "";
            // 
            // coldsMainL3DataTableTi_B
            // 
            this.coldsMainL3DataTableTi_B.Caption = "Ti_B";
            this.coldsMainL3DataTableTi_B.ColumnName = "Ti_B";
            this.coldsMainL3DataTableTi_B.Namespace = "";
            // 
            // coldsMainL3DataTableGrossFlag
            // 
            this.coldsMainL3DataTableGrossFlag.Caption = "GrossFlag";
            this.coldsMainL3DataTableGrossFlag.ColumnName = "GrossFlag";
            this.coldsMainL3DataTableGrossFlag.DataType = typeof(int);
            this.coldsMainL3DataTableGrossFlag.Namespace = "";
            // 
            // coldsMainL3DataTableTareFlag
            // 
            this.coldsMainL3DataTableTareFlag.Caption = "TareFlag";
            this.coldsMainL3DataTableTareFlag.ColumnName = "TareFlag";
            this.coldsMainL3DataTableTareFlag.DataType = typeof(int);
            this.coldsMainL3DataTableTareFlag.Namespace = "";
            // 
            // coldsMainL3DataTableAnalysisFlag
            // 
            this.coldsMainL3DataTableAnalysisFlag.Caption = "AnalysisFlag";
            this.coldsMainL3DataTableAnalysisFlag.ColumnName = "AnalysisFlag";
            this.coldsMainL3DataTableAnalysisFlag.DataType = typeof(int);
            this.coldsMainL3DataTableAnalysisFlag.Namespace = "";
            // 
            // dsM
            // 
            this.dsM.AutoSubscribe = true;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = "";
            this.dsM.InsertMethod = "";
            this.dsM.L3DataAdapter = null;
            this.dsM.LoadEvent = "";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = null;
            this.dsM.SourceCondition = "";
            this.dsM.SourceMethod = "";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsM.SourceURI = "";
            this.dsM.SubscribeTarget = "";
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "";
            this.dsM.UpdateMethod = "";
            this.dsM.UpdateTrigger = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableGUID,
            this.coldsML3DataTableName,
            this.coldsML3DataTableMaterialID,
            this.coldsML3DataTableStatus,
            this.coldsML3DataTablePosition,
            this.coldsML3DataTableQAStatus,
            this.coldsML3DataTableQALevel,
            this.coldsML3DataTableOrderContractID,
            this.coldsML3DataTableProduceContractID,
            this.coldsML3DataTableSalesContractID,
            this.coldsML3DataTableBFID,
            this.coldsML3DataTableTAP_No,
            this.coldsML3DataTableTPC_No,
            this.coldsML3DataTableSource,
            this.coldsML3DataTableDestination,
            this.coldsML3DataTableProduction_Date,
            this.coldsML3DataTableShift,
            this.coldsML3DataTableOperator,
            this.coldsML3DataTableNC_Confirm_Flag,
            this.coldsML3DataTableTeam,
            this.coldsML3DataTableResult,
            this.coldsML3DataTableSample_Place,
            this.coldsML3DataTableC,
            this.coldsML3DataTableSi,
            this.coldsML3DataTableMn,
            this.coldsML3DataTableS,
            this.coldsML3DataTableP,
            this.coldsML3DataTableTi,
            this.coldsML3DataTableGross_Weight,
            this.coldsML3DataTableLast_Tare,
            this.coldsML3DataTableCurr_Tare,
            this.coldsML3DataTableNet_Weight,
            this.coldsML3DataTableSpare_Weight,
            this.coldsML3DataTableIronStatus,
            this.coldsML3DataTableArrival_Time,
            this.coldsML3DataTableFeed_Time,
            this.coldsML3DataTableSend_Time,
            this.coldsML3DataTableSampCode,
            this.coldsML3DataTableIronConfirm,
            this.coldsML3DataTableC_B,
            this.coldsML3DataTableSi_B,
            this.coldsML3DataTableMn_B,
            this.coldsML3DataTableS_B,
            this.coldsML3DataTableP_B,
            this.coldsML3DataTableTi_B,
            this.coldsML3DataTableGrossFlag,
            this.coldsML3DataTableTareFlag,
            this.coldsML3DataTableAnalysisFlag});
            this.schemadsM.TableName = "L3DataTable";
            // 
            // coldsML3DataTableGUID
            // 
            this.coldsML3DataTableGUID.Caption = "GUID";
            this.coldsML3DataTableGUID.ColumnName = "GUID";
            this.coldsML3DataTableGUID.Namespace = "";
            // 
            // coldsML3DataTableName
            // 
            this.coldsML3DataTableName.Caption = "Name";
            this.coldsML3DataTableName.ColumnName = "Name";
            this.coldsML3DataTableName.Namespace = "";
            // 
            // coldsML3DataTableMaterialID
            // 
            this.coldsML3DataTableMaterialID.Caption = "MaterialID";
            this.coldsML3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsML3DataTableMaterialID.Namespace = "";
            // 
            // coldsML3DataTableStatus
            // 
            this.coldsML3DataTableStatus.Caption = "Status";
            this.coldsML3DataTableStatus.ColumnName = "Status";
            this.coldsML3DataTableStatus.DataType = typeof(int);
            this.coldsML3DataTableStatus.Namespace = "";
            // 
            // coldsML3DataTablePosition
            // 
            this.coldsML3DataTablePosition.Caption = "Position";
            this.coldsML3DataTablePosition.ColumnName = "Position";
            this.coldsML3DataTablePosition.Namespace = "";
            // 
            // coldsML3DataTableQAStatus
            // 
            this.coldsML3DataTableQAStatus.Caption = "QAStatus";
            this.coldsML3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsML3DataTableQAStatus.DataType = typeof(int);
            this.coldsML3DataTableQAStatus.Namespace = "";
            // 
            // coldsML3DataTableQALevel
            // 
            this.coldsML3DataTableQALevel.Caption = "QALevel";
            this.coldsML3DataTableQALevel.ColumnName = "QALevel";
            this.coldsML3DataTableQALevel.DataType = typeof(int);
            this.coldsML3DataTableQALevel.Namespace = "";
            // 
            // coldsML3DataTableOrderContractID
            // 
            this.coldsML3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsML3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsML3DataTableOrderContractID.Namespace = "";
            // 
            // coldsML3DataTableProduceContractID
            // 
            this.coldsML3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsML3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsML3DataTableProduceContractID.Namespace = "";
            // 
            // coldsML3DataTableSalesContractID
            // 
            this.coldsML3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsML3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsML3DataTableSalesContractID.Namespace = "";
            // 
            // coldsML3DataTableBFID
            // 
            this.coldsML3DataTableBFID.Caption = "BFID";
            this.coldsML3DataTableBFID.ColumnName = "BFID";
            this.coldsML3DataTableBFID.Namespace = "";
            // 
            // coldsML3DataTableTAP_No
            // 
            this.coldsML3DataTableTAP_No.Caption = "TAP_No";
            this.coldsML3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsML3DataTableTAP_No.Namespace = "";
            // 
            // coldsML3DataTableTPC_No
            // 
            this.coldsML3DataTableTPC_No.Caption = "TPC_No";
            this.coldsML3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsML3DataTableTPC_No.Namespace = "";
            // 
            // coldsML3DataTableSource
            // 
            this.coldsML3DataTableSource.Caption = "Source";
            this.coldsML3DataTableSource.ColumnName = "Source";
            this.coldsML3DataTableSource.DataType = typeof(int);
            this.coldsML3DataTableSource.Namespace = "";
            // 
            // coldsML3DataTableDestination
            // 
            this.coldsML3DataTableDestination.Caption = "Destination";
            this.coldsML3DataTableDestination.ColumnName = "Destination";
            this.coldsML3DataTableDestination.DataType = typeof(int);
            this.coldsML3DataTableDestination.Namespace = "";
            // 
            // coldsML3DataTableProduction_Date
            // 
            this.coldsML3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsML3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsML3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsML3DataTableProduction_Date.Namespace = "";
            // 
            // coldsML3DataTableShift
            // 
            this.coldsML3DataTableShift.Caption = "Shift";
            this.coldsML3DataTableShift.ColumnName = "Shift";
            this.coldsML3DataTableShift.DataType = typeof(int);
            this.coldsML3DataTableShift.Namespace = "";
            // 
            // coldsML3DataTableOperator
            // 
            this.coldsML3DataTableOperator.Caption = "Operator";
            this.coldsML3DataTableOperator.ColumnName = "Operator";
            this.coldsML3DataTableOperator.Namespace = "";
            // 
            // coldsML3DataTableNC_Confirm_Flag
            // 
            this.coldsML3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsML3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsML3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.coldsML3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsML3DataTableTeam
            // 
            this.coldsML3DataTableTeam.Caption = "Team";
            this.coldsML3DataTableTeam.ColumnName = "Team";
            this.coldsML3DataTableTeam.DataType = typeof(int);
            this.coldsML3DataTableTeam.Namespace = "";
            // 
            // coldsML3DataTableResult
            // 
            this.coldsML3DataTableResult.Caption = "Result";
            this.coldsML3DataTableResult.ColumnName = "Result";
            this.coldsML3DataTableResult.DataType = typeof(int);
            this.coldsML3DataTableResult.Namespace = "";
            // 
            // coldsML3DataTableSample_Place
            // 
            this.coldsML3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsML3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsML3DataTableSample_Place.Namespace = "";
            // 
            // coldsML3DataTableC
            // 
            this.coldsML3DataTableC.Caption = "C";
            this.coldsML3DataTableC.ColumnName = "C";
            this.coldsML3DataTableC.Namespace = "";
            // 
            // coldsML3DataTableSi
            // 
            this.coldsML3DataTableSi.Caption = "Si";
            this.coldsML3DataTableSi.ColumnName = "Si";
            this.coldsML3DataTableSi.Namespace = "";
            // 
            // coldsML3DataTableMn
            // 
            this.coldsML3DataTableMn.Caption = "Mn";
            this.coldsML3DataTableMn.ColumnName = "Mn";
            this.coldsML3DataTableMn.Namespace = "";
            // 
            // coldsML3DataTableS
            // 
            this.coldsML3DataTableS.Caption = "S";
            this.coldsML3DataTableS.ColumnName = "S";
            this.coldsML3DataTableS.Namespace = "";
            // 
            // coldsML3DataTableP
            // 
            this.coldsML3DataTableP.Caption = "P";
            this.coldsML3DataTableP.ColumnName = "P";
            this.coldsML3DataTableP.Namespace = "";
            // 
            // coldsML3DataTableTi
            // 
            this.coldsML3DataTableTi.Caption = "Ti";
            this.coldsML3DataTableTi.ColumnName = "Ti";
            this.coldsML3DataTableTi.Namespace = "";
            // 
            // coldsML3DataTableGross_Weight
            // 
            this.coldsML3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsML3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsML3DataTableGross_Weight.DataType = typeof(float);
            this.coldsML3DataTableGross_Weight.Namespace = "";
            // 
            // coldsML3DataTableLast_Tare
            // 
            this.coldsML3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsML3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsML3DataTableLast_Tare.DataType = typeof(float);
            this.coldsML3DataTableLast_Tare.Namespace = "";
            // 
            // coldsML3DataTableCurr_Tare
            // 
            this.coldsML3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsML3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsML3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsML3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsML3DataTableNet_Weight
            // 
            this.coldsML3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsML3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsML3DataTableNet_Weight.DataType = typeof(float);
            this.coldsML3DataTableNet_Weight.Namespace = "";
            // 
            // coldsML3DataTableSpare_Weight
            // 
            this.coldsML3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsML3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsML3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsML3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsML3DataTableIronStatus
            // 
            this.coldsML3DataTableIronStatus.Caption = "IronStatus";
            this.coldsML3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsML3DataTableIronStatus.DataType = typeof(int);
            this.coldsML3DataTableIronStatus.Namespace = "";
            // 
            // coldsML3DataTableArrival_Time
            // 
            this.coldsML3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsML3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsML3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableArrival_Time.Namespace = "";
            // 
            // coldsML3DataTableFeed_Time
            // 
            this.coldsML3DataTableFeed_Time.Caption = "Feed_Time";
            this.coldsML3DataTableFeed_Time.ColumnName = "Feed_Time";
            this.coldsML3DataTableFeed_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableFeed_Time.Namespace = "";
            // 
            // coldsML3DataTableSend_Time
            // 
            this.coldsML3DataTableSend_Time.Caption = "Send_Time";
            this.coldsML3DataTableSend_Time.ColumnName = "Send_Time";
            this.coldsML3DataTableSend_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableSend_Time.Namespace = "";
            // 
            // coldsML3DataTableSampCode
            // 
            this.coldsML3DataTableSampCode.Caption = "SampCode";
            this.coldsML3DataTableSampCode.ColumnName = "SampCode";
            this.coldsML3DataTableSampCode.Namespace = "";
            // 
            // coldsML3DataTableIronConfirm
            // 
            this.coldsML3DataTableIronConfirm.Caption = "IronConfirm";
            this.coldsML3DataTableIronConfirm.ColumnName = "IronConfirm";
            this.coldsML3DataTableIronConfirm.DataType = typeof(int);
            this.coldsML3DataTableIronConfirm.Namespace = "";
            // 
            // coldsML3DataTableC_B
            // 
            this.coldsML3DataTableC_B.Caption = "C_B";
            this.coldsML3DataTableC_B.ColumnName = "C_B";
            this.coldsML3DataTableC_B.Namespace = "";
            // 
            // coldsML3DataTableSi_B
            // 
            this.coldsML3DataTableSi_B.Caption = "Si_B";
            this.coldsML3DataTableSi_B.ColumnName = "Si_B";
            this.coldsML3DataTableSi_B.Namespace = "";
            // 
            // coldsML3DataTableMn_B
            // 
            this.coldsML3DataTableMn_B.Caption = "Mn_B";
            this.coldsML3DataTableMn_B.ColumnName = "Mn_B";
            this.coldsML3DataTableMn_B.Namespace = "";
            // 
            // coldsML3DataTableS_B
            // 
            this.coldsML3DataTableS_B.Caption = "S_B";
            this.coldsML3DataTableS_B.ColumnName = "S_B";
            this.coldsML3DataTableS_B.Namespace = "";
            // 
            // coldsML3DataTableP_B
            // 
            this.coldsML3DataTableP_B.Caption = "P_B";
            this.coldsML3DataTableP_B.ColumnName = "P_B";
            this.coldsML3DataTableP_B.Namespace = "";
            // 
            // coldsML3DataTableTi_B
            // 
            this.coldsML3DataTableTi_B.Caption = "Ti_B";
            this.coldsML3DataTableTi_B.ColumnName = "Ti_B";
            this.coldsML3DataTableTi_B.Namespace = "";
            // 
            // coldsML3DataTableGrossFlag
            // 
            this.coldsML3DataTableGrossFlag.Caption = "GrossFlag";
            this.coldsML3DataTableGrossFlag.ColumnName = "GrossFlag";
            this.coldsML3DataTableGrossFlag.DataType = typeof(int);
            this.coldsML3DataTableGrossFlag.Namespace = "";
            // 
            // coldsML3DataTableTareFlag
            // 
            this.coldsML3DataTableTareFlag.Caption = "TareFlag";
            this.coldsML3DataTableTareFlag.ColumnName = "TareFlag";
            this.coldsML3DataTableTareFlag.DataType = typeof(int);
            this.coldsML3DataTableTareFlag.Namespace = "";
            // 
            // coldsML3DataTableAnalysisFlag
            // 
            this.coldsML3DataTableAnalysisFlag.Caption = "AnalysisFlag";
            this.coldsML3DataTableAnalysisFlag.ColumnName = "AnalysisFlag";
            this.coldsML3DataTableAnalysisFlag.DataType = typeof(int);
            this.coldsML3DataTableAnalysisFlag.Namespace = "";
            // 
            // IronNetWeightFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(385, 222);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "IronNetWeightFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "去铸铁";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Label lbHeatName;
        private System.Windows.Forms.TextBox txtBFID;
        private System.Windows.Forms.TextBox txtTapNo;
        private System.Windows.Forms.TextBox txtTpcNo;
        private System.Windows.Forms.TextBox txtNetWeghit;
        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3Command cmdSendIronToCast;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableStatus;
        private System.Data.DataColumn coldsMainL3DataTablePosition;
        private System.Data.DataColumn coldsMainL3DataTableQAStatus;
        private System.Data.DataColumn coldsMainL3DataTableQALevel;
        private System.Data.DataColumn coldsMainL3DataTableOrderContractID;
        private System.Data.DataColumn coldsMainL3DataTableProduceContractID;
        private System.Data.DataColumn coldsMainL3DataTableSalesContractID;
        private System.Data.DataColumn coldsMainL3DataTableSource;
        private System.Data.DataColumn coldsMainL3DataTableDestination;
        private System.Data.DataColumn coldsMainL3DataTableProduction_Date;
        private System.Data.DataColumn coldsMainL3DataTableShift;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableTeam;
        private System.Data.DataColumn coldsMainL3DataTableResult;
        private System.Data.DataColumn coldsMainL3DataTableSample_Place;
        private System.Data.DataColumn coldsMainL3DataTableC;
        private System.Data.DataColumn coldsMainL3DataTableSi;
        private System.Data.DataColumn coldsMainL3DataTableMn;
        private System.Data.DataColumn coldsMainL3DataTableS;
        private System.Data.DataColumn coldsMainL3DataTableP;
        private System.Data.DataColumn coldsMainL3DataTableTi;
        private System.Data.DataColumn coldsMainL3DataTableGross_Weight;
        private System.Data.DataColumn coldsMainL3DataTableLast_Tare;
        private System.Data.DataColumn coldsMainL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsMainL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsMainL3DataTableIronStatus;
        private System.Data.DataColumn coldsMainL3DataTableArrival_Time;
        private System.Data.DataColumn coldsMainL3DataTableFeed_Time;
        private System.Data.DataColumn coldsMainL3DataTableSend_Time;
        private System.Data.DataColumn coldsMainL3DataTableSampCode;
        private System.Data.DataColumn coldsMainL3DataTableIronConfirm;
        private System.Data.DataColumn coldsMainL3DataTableC_B;
        private System.Data.DataColumn coldsMainL3DataTableSi_B;
        private System.Data.DataColumn coldsMainL3DataTableMn_B;
        private System.Data.DataColumn coldsMainL3DataTableS_B;
        private System.Data.DataColumn coldsMainL3DataTableP_B;
        private System.Data.DataColumn coldsMainL3DataTableTi_B;
        private System.Data.DataColumn coldsMainL3DataTableGrossFlag;
        private System.Data.DataColumn coldsMainL3DataTableTareFlag;
        private System.Data.DataColumn coldsMainL3DataTableAnalysisFlag;
        private AppSvrHMI.L3DataSet dsM;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableName;
        private System.Data.DataColumn coldsML3DataTableMaterialID;
        private System.Data.DataColumn coldsML3DataTableStatus;
        private System.Data.DataColumn coldsML3DataTablePosition;
        private System.Data.DataColumn coldsML3DataTableQAStatus;
        private System.Data.DataColumn coldsML3DataTableQALevel;
        private System.Data.DataColumn coldsML3DataTableOrderContractID;
        private System.Data.DataColumn coldsML3DataTableProduceContractID;
        private System.Data.DataColumn coldsML3DataTableSalesContractID;
        private System.Data.DataColumn coldsML3DataTableBFID;
        private System.Data.DataColumn coldsML3DataTableTAP_No;
        private System.Data.DataColumn coldsML3DataTableTPC_No;
        private System.Data.DataColumn coldsML3DataTableSource;
        private System.Data.DataColumn coldsML3DataTableDestination;
        private System.Data.DataColumn coldsML3DataTableProduction_Date;
        private System.Data.DataColumn coldsML3DataTableShift;
        private System.Data.DataColumn coldsML3DataTableOperator;
        private System.Data.DataColumn coldsML3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsML3DataTableTeam;
        private System.Data.DataColumn coldsML3DataTableResult;
        private System.Data.DataColumn coldsML3DataTableSample_Place;
        private System.Data.DataColumn coldsML3DataTableC;
        private System.Data.DataColumn coldsML3DataTableSi;
        private System.Data.DataColumn coldsML3DataTableMn;
        private System.Data.DataColumn coldsML3DataTableS;
        private System.Data.DataColumn coldsML3DataTableP;
        private System.Data.DataColumn coldsML3DataTableTi;
        private System.Data.DataColumn coldsML3DataTableGross_Weight;
        private System.Data.DataColumn coldsML3DataTableLast_Tare;
        private System.Data.DataColumn coldsML3DataTableCurr_Tare;
        private System.Data.DataColumn coldsML3DataTableNet_Weight;
        private System.Data.DataColumn coldsML3DataTableSpare_Weight;
        private System.Data.DataColumn coldsML3DataTableIronStatus;
        private System.Data.DataColumn coldsML3DataTableArrival_Time;
        private System.Data.DataColumn coldsML3DataTableFeed_Time;
        private System.Data.DataColumn coldsML3DataTableSend_Time;
        private System.Data.DataColumn coldsML3DataTableSampCode;
        private System.Data.DataColumn coldsML3DataTableIronConfirm;
        private System.Data.DataColumn coldsML3DataTableC_B;
        private System.Data.DataColumn coldsML3DataTableSi_B;
        private System.Data.DataColumn coldsML3DataTableMn_B;
        private System.Data.DataColumn coldsML3DataTableS_B;
        private System.Data.DataColumn coldsML3DataTableP_B;
        private System.Data.DataColumn coldsML3DataTableTi_B;
        private System.Data.DataColumn coldsML3DataTableGrossFlag;
        private System.Data.DataColumn coldsML3DataTableTareFlag;
        private System.Data.DataColumn coldsML3DataTableAnalysisFlag;
    }
}