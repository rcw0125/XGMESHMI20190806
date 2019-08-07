namespace QualityMag.LabMag
{
    partial class ChemicalInfoFrm
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
            PxDataValid.PxTextBox ptbCeq;
            PxDataValid.PxTextBox ptbCa;
            this.bsChemical = new System.Windows.Forms.BindingSource(this.components);
            this.dsChemical = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsChemical = new System.Data.DataTable();
            this.coldsChemicalL3DataTableGUID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableName = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAppID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableC = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableP = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCr = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMo = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableV = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAl = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAlS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableTi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableB = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAs = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableZn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCa = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableW = new System.Data.DataColumn();
            this.coldsChemicalL3DataTablePb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableRe = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCeq = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableN = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableH = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableO = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableDataLogMode = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbFinalFlag = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFormAppID = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpElement = new System.Windows.Forms.TabPage();
            this.cmbSampleType = new PxDataValid.PxComboBox();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbAddr = new PxDataValid.PxComboBox();
            this.dsAddr = new AppSvrHMI.L3DataSet();
            this.schemadsAddr = new System.Data.DataTable();
            this.coldsAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.ptbOther2 = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSampleCode = new PxDataValid.PxTextBox();
            this.ptbOther1 = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.ptbO = new PxDataValid.PxTextBox();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.ptbH = new PxDataValid.PxTextBox();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.ptbN = new PxDataValid.PxTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ptbRe = new PxDataValid.PxTextBox();
            this.ptbPb = new PxDataValid.PxTextBox();
            this.ptbW = new PxDataValid.PxTextBox();
            this.ptbZn = new PxDataValid.PxTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ptbSn = new PxDataValid.PxTextBox();
            this.ptbAs = new PxDataValid.PxTextBox();
            this.ptbSb = new PxDataValid.PxTextBox();
            this.ptbB = new PxDataValid.PxTextBox();
            this.ptbTi = new PxDataValid.PxTextBox();
            this.ptbAls = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ptbAl = new PxDataValid.PxTextBox();
            this.ptbNb = new PxDataValid.PxTextBox();
            this.ptbV = new PxDataValid.PxTextBox();
            this.ptbMo = new PxDataValid.PxTextBox();
            this.ptbCr = new PxDataValid.PxTextBox();
            this.ptbNi = new PxDataValid.PxTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ptbCu = new PxDataValid.PxTextBox();
            this.ptbS = new PxDataValid.PxTextBox();
            this.ptbP = new PxDataValid.PxTextBox();
            this.ptbMn = new PxDataValid.PxTextBox();
            this.ptbSi = new PxDataValid.PxTextBox();
            this.ptbC = new PxDataValid.PxTextBox();
            this.txtApplyID = new PxDataValid.PxTextBox();
            this.txtSampleCount = new PxDataValid.PxTextBox();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdNewLabSheet = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpSampleType = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpAddr = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpFinalFlag = new AppSvrHMI.L3CommandParameter();
            ptbCeq = new PxDataValid.PxTextBox();
            ptbCa = new PxDataValid.PxTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAddr)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCeq
            // 
            ptbCeq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Ceq", true));
            ptbCeq.EnableNull = true;
            ptbCeq.ErropPr = this.errorProvider1;
            ptbCeq.Length = 0;
            ptbCeq.Location = new System.Drawing.Point(548, 150);
            ptbCeq.Max = 0;
            ptbCeq.MaxStrLength = 0;
            ptbCeq.Min = 0;
            ptbCeq.MinStrLength = 0;
            ptbCeq.Name = "ptbCeq";
            ptbCeq.Precision = 0;
            ptbCeq.Size = new System.Drawing.Size(46, 21);
            ptbCeq.TabIndex = 29;
            ptbCeq.ToolTipValid = this.toolTip1;
            ptbCeq.ValidEable = true;
            ptbCeq.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            ptbCeq.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            ptbCeq.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // bsChemical
            // 
            this.bsChemical.DataMember = "L3DataTable";
            this.bsChemical.DataSource = this.dsChemical;
            // 
            // dsChemical
            // 
            this.dsChemical.DataSetName = "L3DataSet";
            this.dsChemical.DeleteMethod = null;
            this.dsChemical.InsertMethod = null;
            this.dsChemical.L3DataAdapter = this.Adapter;
            this.dsChemical.LoadEvent = "Click";
            this.dsChemical.LoadTrigger = null;
            this.dsChemical.RefreshValve = 1000;
            this.dsChemical.SourceCommand = null;
            this.dsChemical.SourceCondition = "";
            this.dsChemical.SourceMethod = "";
            this.dsChemical.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsChemical.SourceURI = "";
            this.dsChemical.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChemical});
            this.dsChemical.UpdateEvent = "Click";
            this.dsChemical.UpdateMethod = null;
            this.dsChemical.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsChemical
            // 
            this.schemadsChemical.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChemicalL3DataTableGUID,
            this.coldsChemicalL3DataTableName,
            this.coldsChemicalL3DataTableAppID,
            this.coldsChemicalL3DataTableSample_Code,
            this.coldsChemicalL3DataTableArrive_Date,
            this.coldsChemicalL3DataTableReport_Date,
            this.coldsChemicalL3DataTableHeatID,
            this.coldsChemicalL3DataTableUnitTypeID,
            this.coldsChemicalL3DataTableUnitID,
            this.coldsChemicalL3DataTableSample_Address,
            this.coldsChemicalL3DataTableSample_Type,
            this.coldsChemicalL3DataTableSample_Count,
            this.coldsChemicalL3DataTableC,
            this.coldsChemicalL3DataTableSi,
            this.coldsChemicalL3DataTableMn,
            this.coldsChemicalL3DataTableP,
            this.coldsChemicalL3DataTableS,
            this.coldsChemicalL3DataTableCu,
            this.coldsChemicalL3DataTableNi,
            this.coldsChemicalL3DataTableCr,
            this.coldsChemicalL3DataTableMo,
            this.coldsChemicalL3DataTableV,
            this.coldsChemicalL3DataTableNb,
            this.coldsChemicalL3DataTableAl,
            this.coldsChemicalL3DataTableAlS,
            this.coldsChemicalL3DataTableTi,
            this.coldsChemicalL3DataTableB,
            this.coldsChemicalL3DataTableSb,
            this.coldsChemicalL3DataTableAs,
            this.coldsChemicalL3DataTableSn,
            this.coldsChemicalL3DataTableZn,
            this.coldsChemicalL3DataTableCa,
            this.coldsChemicalL3DataTableW,
            this.coldsChemicalL3DataTablePb,
            this.coldsChemicalL3DataTableRe,
            this.coldsChemicalL3DataTableCeq,
            this.coldsChemicalL3DataTableN,
            this.coldsChemicalL3DataTableH,
            this.coldsChemicalL3DataTableO,
            this.coldsChemicalL3DataTableCrNi,
            this.coldsChemicalL3DataTableCrCu,
            this.coldsChemicalL3DataTableCrNiCu,
            this.coldsChemicalL3DataTableOther1,
            this.coldsChemicalL3DataTableOther2,
            this.coldsChemicalL3DataTableOther3,
            this.coldsChemicalL3DataTableLogTime,
            this.coldsChemicalL3DataTableDataLogMode});
            this.schemadsChemical.TableName = "L3DataTable";
            // 
            // coldsChemicalL3DataTableGUID
            // 
            this.coldsChemicalL3DataTableGUID.Caption = "GUID";
            this.coldsChemicalL3DataTableGUID.ColumnName = "GUID";
            this.coldsChemicalL3DataTableGUID.Namespace = "";
            // 
            // coldsChemicalL3DataTableName
            // 
            this.coldsChemicalL3DataTableName.Caption = "Name";
            this.coldsChemicalL3DataTableName.ColumnName = "Name";
            this.coldsChemicalL3DataTableName.Namespace = "";
            // 
            // coldsChemicalL3DataTableAppID
            // 
            this.coldsChemicalL3DataTableAppID.Caption = "AppID";
            this.coldsChemicalL3DataTableAppID.ColumnName = "AppID";
            this.coldsChemicalL3DataTableAppID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Code
            // 
            this.coldsChemicalL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.Namespace = "";
            // 
            // coldsChemicalL3DataTableArrive_Date
            // 
            this.coldsChemicalL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableReport_Date
            // 
            this.coldsChemicalL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableReport_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableHeatID
            // 
            this.coldsChemicalL3DataTableHeatID.Caption = "HeatID";
            this.coldsChemicalL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsChemicalL3DataTableHeatID.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitTypeID
            // 
            this.coldsChemicalL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitID
            // 
            this.coldsChemicalL3DataTableUnitID.Caption = "UnitID";
            this.coldsChemicalL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsChemicalL3DataTableUnitID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Address
            // 
            this.coldsChemicalL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Type
            // 
            this.coldsChemicalL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Count
            // 
            this.coldsChemicalL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.Namespace = "";
            // 
            // coldsChemicalL3DataTableC
            // 
            this.coldsChemicalL3DataTableC.Caption = "C";
            this.coldsChemicalL3DataTableC.ColumnName = "C";
            this.coldsChemicalL3DataTableC.DataType = typeof(double);
            this.coldsChemicalL3DataTableC.Namespace = "";
            // 
            // coldsChemicalL3DataTableSi
            // 
            this.coldsChemicalL3DataTableSi.Caption = "Si";
            this.coldsChemicalL3DataTableSi.ColumnName = "Si";
            this.coldsChemicalL3DataTableSi.DataType = typeof(double);
            this.coldsChemicalL3DataTableSi.Namespace = "";
            // 
            // coldsChemicalL3DataTableMn
            // 
            this.coldsChemicalL3DataTableMn.Caption = "Mn";
            this.coldsChemicalL3DataTableMn.ColumnName = "Mn";
            this.coldsChemicalL3DataTableMn.DataType = typeof(double);
            this.coldsChemicalL3DataTableMn.Namespace = "";
            // 
            // coldsChemicalL3DataTableP
            // 
            this.coldsChemicalL3DataTableP.Caption = "P";
            this.coldsChemicalL3DataTableP.ColumnName = "P";
            this.coldsChemicalL3DataTableP.DataType = typeof(double);
            this.coldsChemicalL3DataTableP.Namespace = "";
            // 
            // coldsChemicalL3DataTableS
            // 
            this.coldsChemicalL3DataTableS.Caption = "S";
            this.coldsChemicalL3DataTableS.ColumnName = "S";
            this.coldsChemicalL3DataTableS.Namespace = "";
            // 
            // coldsChemicalL3DataTableCu
            // 
            this.coldsChemicalL3DataTableCu.Caption = "Cu";
            this.coldsChemicalL3DataTableCu.ColumnName = "Cu";
            this.coldsChemicalL3DataTableCu.DataType = typeof(double);
            this.coldsChemicalL3DataTableCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableNi
            // 
            this.coldsChemicalL3DataTableNi.Caption = "Ni";
            this.coldsChemicalL3DataTableNi.ColumnName = "Ni";
            this.coldsChemicalL3DataTableNi.DataType = typeof(double);
            this.coldsChemicalL3DataTableNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCr
            // 
            this.coldsChemicalL3DataTableCr.Caption = "Cr";
            this.coldsChemicalL3DataTableCr.ColumnName = "Cr";
            this.coldsChemicalL3DataTableCr.DataType = typeof(double);
            this.coldsChemicalL3DataTableCr.Namespace = "";
            // 
            // coldsChemicalL3DataTableMo
            // 
            this.coldsChemicalL3DataTableMo.Caption = "Mo";
            this.coldsChemicalL3DataTableMo.ColumnName = "Mo";
            this.coldsChemicalL3DataTableMo.DataType = typeof(double);
            this.coldsChemicalL3DataTableMo.Namespace = "";
            // 
            // coldsChemicalL3DataTableV
            // 
            this.coldsChemicalL3DataTableV.Caption = "V";
            this.coldsChemicalL3DataTableV.ColumnName = "V";
            this.coldsChemicalL3DataTableV.DataType = typeof(double);
            this.coldsChemicalL3DataTableV.Namespace = "";
            // 
            // coldsChemicalL3DataTableNb
            // 
            this.coldsChemicalL3DataTableNb.Caption = "Nb";
            this.coldsChemicalL3DataTableNb.ColumnName = "Nb";
            this.coldsChemicalL3DataTableNb.DataType = typeof(double);
            this.coldsChemicalL3DataTableNb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAl
            // 
            this.coldsChemicalL3DataTableAl.Caption = "Al";
            this.coldsChemicalL3DataTableAl.ColumnName = "Al";
            this.coldsChemicalL3DataTableAl.DataType = typeof(double);
            this.coldsChemicalL3DataTableAl.Namespace = "";
            // 
            // coldsChemicalL3DataTableAlS
            // 
            this.coldsChemicalL3DataTableAlS.Caption = "AlS";
            this.coldsChemicalL3DataTableAlS.ColumnName = "AlS";
            this.coldsChemicalL3DataTableAlS.DataType = typeof(double);
            this.coldsChemicalL3DataTableAlS.Namespace = "";
            // 
            // coldsChemicalL3DataTableTi
            // 
            this.coldsChemicalL3DataTableTi.Caption = "Ti";
            this.coldsChemicalL3DataTableTi.ColumnName = "Ti";
            this.coldsChemicalL3DataTableTi.DataType = typeof(double);
            this.coldsChemicalL3DataTableTi.Namespace = "";
            // 
            // coldsChemicalL3DataTableB
            // 
            this.coldsChemicalL3DataTableB.Caption = "B";
            this.coldsChemicalL3DataTableB.ColumnName = "B";
            this.coldsChemicalL3DataTableB.DataType = typeof(double);
            this.coldsChemicalL3DataTableB.Namespace = "";
            // 
            // coldsChemicalL3DataTableSb
            // 
            this.coldsChemicalL3DataTableSb.Caption = "Sb";
            this.coldsChemicalL3DataTableSb.ColumnName = "Sb";
            this.coldsChemicalL3DataTableSb.DataType = typeof(double);
            this.coldsChemicalL3DataTableSb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAs
            // 
            this.coldsChemicalL3DataTableAs.Caption = "As";
            this.coldsChemicalL3DataTableAs.ColumnName = "As";
            this.coldsChemicalL3DataTableAs.DataType = typeof(double);
            this.coldsChemicalL3DataTableAs.Namespace = "";
            // 
            // coldsChemicalL3DataTableSn
            // 
            this.coldsChemicalL3DataTableSn.Caption = "Sn";
            this.coldsChemicalL3DataTableSn.ColumnName = "Sn";
            this.coldsChemicalL3DataTableSn.DataType = typeof(double);
            this.coldsChemicalL3DataTableSn.Namespace = "";
            // 
            // coldsChemicalL3DataTableZn
            // 
            this.coldsChemicalL3DataTableZn.Caption = "Zn";
            this.coldsChemicalL3DataTableZn.ColumnName = "Zn";
            this.coldsChemicalL3DataTableZn.DataType = typeof(double);
            this.coldsChemicalL3DataTableZn.Namespace = "";
            // 
            // coldsChemicalL3DataTableCa
            // 
            this.coldsChemicalL3DataTableCa.Caption = "Ca";
            this.coldsChemicalL3DataTableCa.ColumnName = "Ca";
            this.coldsChemicalL3DataTableCa.DataType = typeof(double);
            this.coldsChemicalL3DataTableCa.Namespace = "";
            // 
            // coldsChemicalL3DataTableW
            // 
            this.coldsChemicalL3DataTableW.Caption = "W";
            this.coldsChemicalL3DataTableW.ColumnName = "W";
            this.coldsChemicalL3DataTableW.DataType = typeof(double);
            this.coldsChemicalL3DataTableW.Namespace = "";
            // 
            // coldsChemicalL3DataTablePb
            // 
            this.coldsChemicalL3DataTablePb.Caption = "Pb";
            this.coldsChemicalL3DataTablePb.ColumnName = "Pb";
            this.coldsChemicalL3DataTablePb.DataType = typeof(double);
            this.coldsChemicalL3DataTablePb.Namespace = "";
            // 
            // coldsChemicalL3DataTableRe
            // 
            this.coldsChemicalL3DataTableRe.Caption = "Re";
            this.coldsChemicalL3DataTableRe.ColumnName = "Re";
            this.coldsChemicalL3DataTableRe.DataType = typeof(double);
            this.coldsChemicalL3DataTableRe.Namespace = "";
            // 
            // coldsChemicalL3DataTableCeq
            // 
            this.coldsChemicalL3DataTableCeq.Caption = "Ceq";
            this.coldsChemicalL3DataTableCeq.ColumnName = "Ceq";
            this.coldsChemicalL3DataTableCeq.DataType = typeof(double);
            this.coldsChemicalL3DataTableCeq.Namespace = "";
            // 
            // coldsChemicalL3DataTableN
            // 
            this.coldsChemicalL3DataTableN.Caption = "N";
            this.coldsChemicalL3DataTableN.ColumnName = "N";
            this.coldsChemicalL3DataTableN.DataType = typeof(double);
            this.coldsChemicalL3DataTableN.Namespace = "";
            // 
            // coldsChemicalL3DataTableH
            // 
            this.coldsChemicalL3DataTableH.Caption = "H";
            this.coldsChemicalL3DataTableH.ColumnName = "H";
            this.coldsChemicalL3DataTableH.DataType = typeof(double);
            this.coldsChemicalL3DataTableH.Namespace = "";
            // 
            // coldsChemicalL3DataTableO
            // 
            this.coldsChemicalL3DataTableO.Caption = "O";
            this.coldsChemicalL3DataTableO.ColumnName = "O";
            this.coldsChemicalL3DataTableO.DataType = typeof(double);
            this.coldsChemicalL3DataTableO.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrNi
            // 
            this.coldsChemicalL3DataTableCrNi.Caption = "CrNi";
            this.coldsChemicalL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsChemicalL3DataTableCrNi.DataType = typeof(double);
            this.coldsChemicalL3DataTableCrNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrCu
            // 
            this.coldsChemicalL3DataTableCrCu.Caption = "CrCu";
            this.coldsChemicalL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsChemicalL3DataTableCrCu.DataType = typeof(double);
            this.coldsChemicalL3DataTableCrCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrNiCu
            // 
            this.coldsChemicalL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.DataType = typeof(double);
            this.coldsChemicalL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther1
            // 
            this.coldsChemicalL3DataTableOther1.Caption = "Other1";
            this.coldsChemicalL3DataTableOther1.ColumnName = "Other1";
            this.coldsChemicalL3DataTableOther1.DataType = typeof(double);
            this.coldsChemicalL3DataTableOther1.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther2
            // 
            this.coldsChemicalL3DataTableOther2.Caption = "Other2";
            this.coldsChemicalL3DataTableOther2.ColumnName = "Other2";
            this.coldsChemicalL3DataTableOther2.DataType = typeof(double);
            this.coldsChemicalL3DataTableOther2.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther3
            // 
            this.coldsChemicalL3DataTableOther3.Caption = "Other3";
            this.coldsChemicalL3DataTableOther3.ColumnName = "Other3";
            this.coldsChemicalL3DataTableOther3.DataType = typeof(double);
            this.coldsChemicalL3DataTableOther3.Namespace = "";
            // 
            // coldsChemicalL3DataTableLogTime
            // 
            this.coldsChemicalL3DataTableLogTime.Caption = "LogTime";
            this.coldsChemicalL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsChemicalL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableLogTime.Namespace = "";
            // 
            // coldsChemicalL3DataTableDataLogMode
            // 
            this.coldsChemicalL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsChemicalL3DataTableDataLogMode.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ptbCa
            // 
            ptbCa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Ca", true));
            ptbCa.EnableNull = true;
            ptbCa.ErropPr = this.errorProvider1;
            ptbCa.Length = 0;
            ptbCa.Location = new System.Drawing.Point(548, 38);
            ptbCa.Max = 0;
            ptbCa.MaxStrLength = 0;
            ptbCa.Min = 0;
            ptbCa.MinStrLength = 0;
            ptbCa.Name = "ptbCa";
            ptbCa.Precision = 0;
            ptbCa.Size = new System.Drawing.Size(46, 21);
            ptbCa.TabIndex = 25;
            ptbCa.ToolTipValid = this.toolTip1;
            ptbCa.ValidEable = true;
            ptbCa.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            ptbCa.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            ptbCa.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbFinalFlag);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnFormAppID);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 45);
            this.panel3.TabIndex = 1;
            // 
            // ckbFinalFlag
            // 
            this.ckbFinalFlag.AutoSize = true;
            this.ckbFinalFlag.Location = new System.Drawing.Point(59, 10);
            this.ckbFinalFlag.Name = "ckbFinalFlag";
            this.ckbFinalFlag.Size = new System.Drawing.Size(84, 16);
            this.ckbFinalFlag.TabIndex = 70;
            this.ckbFinalFlag.Text = "成品样标志";
            this.ckbFinalFlag.UseVisualStyleBackColor = true;
            this.ckbFinalFlag.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(746, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFormAppID
            // 
            this.btnFormAppID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormAppID.Location = new System.Drawing.Point(559, 10);
            this.btnFormAppID.Name = "btnFormAppID";
            this.btnFormAppID.Size = new System.Drawing.Size(75, 23);
            this.btnFormAppID.TabIndex = 0;
            this.btnFormAppID.Text = "生成委托单";
            this.btnFormAppID.UseVisualStyleBackColor = true;
            this.btnFormAppID.Click += new System.EventHandler(this.btnFormAppID_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(665, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确认(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpElement);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tpElement
            // 
            this.tpElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpElement.Controls.Add(this.cmbSampleType);
            this.tpElement.Controls.Add(this.cmbAddr);
            this.tpElement.Controls.Add(this.pxTextBox4);
            this.tpElement.Controls.Add(this.ptbOther2);
            this.tpElement.Controls.Add(this.label2);
            this.tpElement.Controls.Add(this.label1);
            this.tpElement.Controls.Add(this.txtSampleCode);
            this.tpElement.Controls.Add(this.ptbOther1);
            this.tpElement.Controls.Add(this.pxTextBox3);
            this.tpElement.Controls.Add(this.ptbO);
            this.tpElement.Controls.Add(this.pxTextBox2);
            this.tpElement.Controls.Add(this.ptbH);
            this.tpElement.Controls.Add(this.pxTextBox1);
            this.tpElement.Controls.Add(this.ptbN);
            this.tpElement.Controls.Add(this.label38);
            this.tpElement.Controls.Add(this.label31);
            this.tpElement.Controls.Add(this.label32);
            this.tpElement.Controls.Add(this.label39);
            this.tpElement.Controls.Add(this.label37);
            this.tpElement.Controls.Add(this.label33);
            this.tpElement.Controls.Add(this.label34);
            this.tpElement.Controls.Add(this.label35);
            this.tpElement.Controls.Add(this.label36);
            this.tpElement.Controls.Add(ptbCeq);
            this.tpElement.Controls.Add(this.ptbRe);
            this.tpElement.Controls.Add(this.ptbPb);
            this.tpElement.Controls.Add(this.ptbW);
            this.tpElement.Controls.Add(ptbCa);
            this.tpElement.Controls.Add(this.ptbZn);
            this.tpElement.Controls.Add(this.label25);
            this.tpElement.Controls.Add(this.label26);
            this.tpElement.Controls.Add(this.label27);
            this.tpElement.Controls.Add(this.label28);
            this.tpElement.Controls.Add(this.label29);
            this.tpElement.Controls.Add(this.label30);
            this.tpElement.Controls.Add(this.ptbSn);
            this.tpElement.Controls.Add(this.ptbAs);
            this.tpElement.Controls.Add(this.ptbSb);
            this.tpElement.Controls.Add(this.ptbB);
            this.tpElement.Controls.Add(this.ptbTi);
            this.tpElement.Controls.Add(this.ptbAls);
            this.tpElement.Controls.Add(this.label16);
            this.tpElement.Controls.Add(this.label17);
            this.tpElement.Controls.Add(this.label18);
            this.tpElement.Controls.Add(this.label20);
            this.tpElement.Controls.Add(this.label23);
            this.tpElement.Controls.Add(this.label24);
            this.tpElement.Controls.Add(this.ptbAl);
            this.tpElement.Controls.Add(this.ptbNb);
            this.tpElement.Controls.Add(this.ptbV);
            this.tpElement.Controls.Add(this.ptbMo);
            this.tpElement.Controls.Add(this.ptbCr);
            this.tpElement.Controls.Add(this.ptbNi);
            this.tpElement.Controls.Add(this.label10);
            this.tpElement.Controls.Add(this.label11);
            this.tpElement.Controls.Add(this.label12);
            this.tpElement.Controls.Add(this.label13);
            this.tpElement.Controls.Add(this.label14);
            this.tpElement.Controls.Add(this.label15);
            this.tpElement.Controls.Add(this.ptbCu);
            this.tpElement.Controls.Add(this.ptbS);
            this.tpElement.Controls.Add(this.ptbP);
            this.tpElement.Controls.Add(this.ptbMn);
            this.tpElement.Controls.Add(this.ptbSi);
            this.tpElement.Controls.Add(this.ptbC);
            this.tpElement.Controls.Add(this.txtApplyID);
            this.tpElement.Controls.Add(this.txtSampleCount);
            this.tpElement.Controls.Add(this.txtHeatID);
            this.tpElement.Controls.Add(this.label3);
            this.tpElement.Controls.Add(this.label22);
            this.tpElement.Controls.Add(this.label21);
            this.tpElement.Controls.Add(this.label19);
            this.tpElement.Controls.Add(this.label9);
            this.tpElement.Controls.Add(this.label8);
            this.tpElement.Controls.Add(this.label7);
            this.tpElement.Controls.Add(this.label4);
            this.tpElement.Controls.Add(this.label6);
            this.tpElement.Controls.Add(this.label5);
            this.tpElement.Location = new System.Drawing.Point(4, 21);
            this.tpElement.Name = "tpElement";
            this.tpElement.Padding = new System.Windows.Forms.Padding(3);
            this.tpElement.Size = new System.Drawing.Size(825, 188);
            this.tpElement.TabIndex = 0;
            this.tpElement.Text = "成分信息";
            this.tpElement.UseVisualStyleBackColor = true;
            // 
            // cmbSampleType
            // 
            this.cmbSampleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSampleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSampleType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsChemical, "Sample_Type", true));
            this.cmbSampleType.DataSource = this.dsSampleType;
            this.cmbSampleType.DisplayMember = "L3DataTable.Code_Des";
            this.cmbSampleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampleType.EnableNull = false;
            this.cmbSampleType.ErropPr = this.errorProvider1;
            this.cmbSampleType.FormattingEnabled = true;
            this.cmbSampleType.Location = new System.Drawing.Point(84, 67);
            this.cmbSampleType.Name = "cmbSampleType";
            this.cmbSampleType.Size = new System.Drawing.Size(99, 20);
            this.cmbSampleType.TabIndex = 2;
            this.cmbSampleType.ToolTipValid = this.toolTip1;
            this.cmbSampleType.ValidEable = true;
            this.cmbSampleType.ValueMember = "L3DataTable.Code";
            this.cmbSampleType.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.cmbSampleType.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsSampleType
            // 
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "Code_Group =  \'QA_Sample_Type\'";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleType});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleType
            // 
            this.schemadsSampleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleTypeL3DataTableCode,
            this.coldsSampleTypeL3DataTableCode_Des});
            this.schemadsSampleType.TableName = "L3DataTable";
            // 
            // coldsSampleTypeL3DataTableCode
            // 
            this.coldsSampleTypeL3DataTableCode.Caption = "Code";
            this.coldsSampleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsSampleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsSampleTypeL3DataTableCode_Des
            // 
            this.coldsSampleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // cmbAddr
            // 
            this.cmbAddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAddr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsChemical, "Sample_Address", true));
            this.cmbAddr.DataSource = this.dsAddr;
            this.cmbAddr.DisplayMember = "L3DataTable.Code_Des";
            this.cmbAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddr.EnableNull = false;
            this.cmbAddr.ErropPr = this.errorProvider1;
            this.cmbAddr.FormattingEnabled = true;
            this.cmbAddr.Location = new System.Drawing.Point(84, 10);
            this.cmbAddr.Name = "cmbAddr";
            this.cmbAddr.Size = new System.Drawing.Size(99, 20);
            this.cmbAddr.TabIndex = 0;
            this.cmbAddr.ToolTipValid = this.toolTip1;
            this.cmbAddr.ValidEable = true;
            this.cmbAddr.ValueMember = "L3DataTable.Code";
            this.cmbAddr.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.cmbAddr.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsAddr
            // 
            this.dsAddr.DataSetName = "L3DataSet";
            this.dsAddr.DeleteMethod = null;
            this.dsAddr.InsertMethod = null;
            this.dsAddr.L3DataAdapter = this.Adapter;
            this.dsAddr.LoadEvent = "Click";
            this.dsAddr.LoadTrigger = null;
            this.dsAddr.RefreshValve = 1000;
            this.dsAddr.SourceCommand = null;
            this.dsAddr.SourceCondition = "code_group = \'QA_Sample_Addr\' and substr(Code,1,1) <> \'H\' order by Code_Val_Long";
            this.dsAddr.SourceMethod = "";
            this.dsAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAddr.SubscribeTarget = null;
            this.dsAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAddr});
            this.dsAddr.UpdateEvent = "Click";
            this.dsAddr.UpdateMethod = null;
            this.dsAddr.UpdateTrigger = null;
            // 
            // schemadsAddr
            // 
            this.schemadsAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAddrL3DataTableCode,
            this.coldsAddrL3DataTableCode_Des});
            this.schemadsAddr.TableName = "L3DataTable";
            // 
            // coldsAddrL3DataTableCode
            // 
            this.coldsAddrL3DataTableCode.Caption = "Code";
            this.coldsAddrL3DataTableCode.ColumnName = "Code";
            this.coldsAddrL3DataTableCode.Namespace = "";
            // 
            // coldsAddrL3DataTableCode_Des
            // 
            this.coldsAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAddrL3DataTableCode_Des.Namespace = "";
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Other3", true));
            this.pxTextBox4.EnableNull = true;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(764, 67);
            this.pxTextBox4.Max = 0;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.Size = new System.Drawing.Size(46, 21);
            this.pxTextBox4.TabIndex = 34;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.pxTextBox4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.pxTextBox4.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbOther2
            // 
            this.ptbOther2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Other2", true));
            this.ptbOther2.EnableNull = true;
            this.ptbOther2.ErropPr = this.errorProvider1;
            this.ptbOther2.Length = 0;
            this.ptbOther2.Location = new System.Drawing.Point(764, 38);
            this.ptbOther2.Max = 0;
            this.ptbOther2.MaxStrLength = 0;
            this.ptbOther2.Min = 0;
            this.ptbOther2.MinStrLength = 0;
            this.ptbOther2.Name = "ptbOther2";
            this.ptbOther2.Precision = 0;
            this.ptbOther2.Size = new System.Drawing.Size(46, 21);
            this.ptbOther2.TabIndex = 34;
            this.ptbOther2.ToolTipValid = this.toolTip1;
            this.ptbOther2.ValidEable = true;
            this.ptbOther2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbOther2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbOther2.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "试样编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "委托单号:";
            // 
            // txtSampleCode
            // 
            this.txtSampleCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Sample_Code", true));
            this.txtSampleCode.EnableNull = true;
            this.txtSampleCode.ErropPr = this.errorProvider1;
            this.txtSampleCode.Length = 0;
            this.txtSampleCode.Location = new System.Drawing.Point(84, 150);
            this.txtSampleCode.Max = 0;
            this.txtSampleCode.MaxStrLength = 0;
            this.txtSampleCode.Min = 0;
            this.txtSampleCode.MinStrLength = 0;
            this.txtSampleCode.Name = "txtSampleCode";
            this.txtSampleCode.Precision = 0;
            this.txtSampleCode.ReadOnly = true;
            this.txtSampleCode.Size = new System.Drawing.Size(99, 21);
            this.txtSampleCode.TabIndex = 5;
            this.txtSampleCode.ToolTipValid = this.toolTip1;
            this.txtSampleCode.ValidEable = true;
            this.txtSampleCode.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtSampleCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            // 
            // ptbOther1
            // 
            this.ptbOther1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Other1", true));
            this.ptbOther1.EnableNull = true;
            this.ptbOther1.ErropPr = this.errorProvider1;
            this.ptbOther1.Length = 0;
            this.ptbOther1.Location = new System.Drawing.Point(764, 10);
            this.ptbOther1.Max = 0;
            this.ptbOther1.MaxStrLength = 0;
            this.ptbOther1.Min = 0;
            this.ptbOther1.MinStrLength = 0;
            this.ptbOther1.Name = "ptbOther1";
            this.ptbOther1.Precision = 0;
            this.ptbOther1.Size = new System.Drawing.Size(46, 21);
            this.ptbOther1.TabIndex = 33;
            this.ptbOther1.ToolTipValid = this.toolTip1;
            this.ptbOther1.ValidEable = true;
            this.ptbOther1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbOther1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbOther1.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "CrNiCu", true));
            this.pxTextBox3.EnableNull = true;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(660, 151);
            this.pxTextBox3.Max = 0;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.Size = new System.Drawing.Size(46, 21);
            this.pxTextBox3.TabIndex = 32;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.pxTextBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.pxTextBox3.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbO
            // 
            this.ptbO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "O", true));
            this.ptbO.EnableNull = true;
            this.ptbO.ErropPr = this.errorProvider1;
            this.ptbO.Length = 0;
            this.ptbO.Location = new System.Drawing.Point(660, 66);
            this.ptbO.Max = 0;
            this.ptbO.MaxStrLength = 0;
            this.ptbO.Min = 0;
            this.ptbO.MinStrLength = 0;
            this.ptbO.Name = "ptbO";
            this.ptbO.Precision = 0;
            this.ptbO.Size = new System.Drawing.Size(46, 21);
            this.ptbO.TabIndex = 32;
            this.ptbO.ToolTipValid = this.toolTip1;
            this.ptbO.ValidEable = true;
            this.ptbO.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbO.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "CrCu", true));
            this.pxTextBox2.EnableNull = true;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(660, 123);
            this.pxTextBox2.Max = 0;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.Size = new System.Drawing.Size(46, 21);
            this.pxTextBox2.TabIndex = 31;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.pxTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.pxTextBox2.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbH
            // 
            this.ptbH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "H", true));
            this.ptbH.EnableNull = true;
            this.ptbH.ErropPr = this.errorProvider1;
            this.ptbH.Length = 0;
            this.ptbH.Location = new System.Drawing.Point(660, 38);
            this.ptbH.Max = 0;
            this.ptbH.MaxStrLength = 0;
            this.ptbH.Min = 0;
            this.ptbH.MinStrLength = 0;
            this.ptbH.Name = "ptbH";
            this.ptbH.Precision = 0;
            this.ptbH.Size = new System.Drawing.Size(46, 21);
            this.ptbH.TabIndex = 31;
            this.ptbH.ToolTipValid = this.toolTip1;
            this.ptbH.ValidEable = true;
            this.ptbH.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbH.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbH.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "CrNi", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = this.errorProvider1;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(660, 95);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(46, 21);
            this.pxTextBox1.TabIndex = 30;
            this.pxTextBox1.ToolTipValid = this.toolTip1;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.pxTextBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.pxTextBox1.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbN
            // 
            this.ptbN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "N", true));
            this.ptbN.EnableNull = true;
            this.ptbN.ErropPr = this.errorProvider1;
            this.ptbN.Length = 0;
            this.ptbN.Location = new System.Drawing.Point(660, 10);
            this.ptbN.Max = 0;
            this.ptbN.MaxStrLength = 0;
            this.ptbN.Min = 0;
            this.ptbN.MinStrLength = 0;
            this.ptbN.Name = "ptbN";
            this.ptbN.Precision = 0;
            this.ptbN.Size = new System.Drawing.Size(46, 21);
            this.ptbN.TabIndex = 30;
            this.ptbN.ToolTipValid = this.toolTip1;
            this.ptbN.ValidEable = true;
            this.ptbN.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbN.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(613, 154);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 12);
            this.label38.TabIndex = 67;
            this.label38.Text = "CrNiCu:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(723, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 68;
            this.label31.Text = "其他1:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(643, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 12);
            this.label32.TabIndex = 67;
            this.label32.Text = "O:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(723, 71);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 12);
            this.label39.TabIndex = 69;
            this.label39.Text = "其他3:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(625, 126);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 12);
            this.label37.TabIndex = 66;
            this.label37.Text = "CrCu:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(723, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 12);
            this.label33.TabIndex = 69;
            this.label33.Text = "其他2:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(625, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 12);
            this.label34.TabIndex = 65;
            this.label34.Text = "CrNi:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(643, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 12);
            this.label35.TabIndex = 66;
            this.label35.Text = "H:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(643, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 12);
            this.label36.TabIndex = 65;
            this.label36.Text = "N:";
            // 
            // ptbRe
            // 
            this.ptbRe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Re", true));
            this.ptbRe.EnableNull = true;
            this.ptbRe.ErropPr = this.errorProvider1;
            this.ptbRe.Length = 0;
            this.ptbRe.Location = new System.Drawing.Point(548, 122);
            this.ptbRe.Max = 0;
            this.ptbRe.MaxStrLength = 0;
            this.ptbRe.Min = 0;
            this.ptbRe.MinStrLength = 0;
            this.ptbRe.Name = "ptbRe";
            this.ptbRe.Precision = 0;
            this.ptbRe.Size = new System.Drawing.Size(46, 21);
            this.ptbRe.TabIndex = 28;
            this.ptbRe.ToolTipValid = this.toolTip1;
            this.ptbRe.ValidEable = true;
            this.ptbRe.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbRe.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbRe.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbPb
            // 
            this.ptbPb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Pb", true));
            this.ptbPb.EnableNull = true;
            this.ptbPb.ErropPr = this.errorProvider1;
            this.ptbPb.Length = 0;
            this.ptbPb.Location = new System.Drawing.Point(548, 94);
            this.ptbPb.Max = 0;
            this.ptbPb.MaxStrLength = 0;
            this.ptbPb.Min = 0;
            this.ptbPb.MinStrLength = 0;
            this.ptbPb.Name = "ptbPb";
            this.ptbPb.Precision = 0;
            this.ptbPb.Size = new System.Drawing.Size(46, 21);
            this.ptbPb.TabIndex = 27;
            this.ptbPb.ToolTipValid = this.toolTip1;
            this.ptbPb.ValidEable = true;
            this.ptbPb.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbPb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbPb.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbW
            // 
            this.ptbW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "W", true));
            this.ptbW.EnableNull = true;
            this.ptbW.ErropPr = this.errorProvider1;
            this.ptbW.Length = 0;
            this.ptbW.Location = new System.Drawing.Point(548, 66);
            this.ptbW.Max = 0;
            this.ptbW.MaxStrLength = 0;
            this.ptbW.Min = 0;
            this.ptbW.MinStrLength = 0;
            this.ptbW.Name = "ptbW";
            this.ptbW.Precision = 0;
            this.ptbW.Size = new System.Drawing.Size(46, 21);
            this.ptbW.TabIndex = 26;
            this.ptbW.ToolTipValid = this.toolTip1;
            this.ptbW.ValidEable = true;
            this.ptbW.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbW.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbW.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbZn
            // 
            this.ptbZn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Zn", true));
            this.ptbZn.EnableNull = true;
            this.ptbZn.ErropPr = this.errorProvider1;
            this.ptbZn.Length = 0;
            this.ptbZn.Location = new System.Drawing.Point(548, 10);
            this.ptbZn.Max = 0;
            this.ptbZn.MaxStrLength = 0;
            this.ptbZn.Min = 0;
            this.ptbZn.MinStrLength = 0;
            this.ptbZn.Name = "ptbZn";
            this.ptbZn.Precision = 0;
            this.ptbZn.Size = new System.Drawing.Size(46, 21);
            this.ptbZn.TabIndex = 24;
            this.ptbZn.ToolTipValid = this.toolTip1;
            this.ptbZn.ValidEable = true;
            this.ptbZn.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbZn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbZn.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(525, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 12);
            this.label25.TabIndex = 62;
            this.label25.Text = "Pb:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(531, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 12);
            this.label26.TabIndex = 61;
            this.label26.Text = "W:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(525, 126);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 63;
            this.label27.Text = "Re:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(519, 154);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 64;
            this.label28.Text = "Ceq:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(525, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 12);
            this.label29.TabIndex = 60;
            this.label29.Text = "Ca:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(525, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 12);
            this.label30.TabIndex = 59;
            this.label30.Text = "Zn:";
            // 
            // ptbSn
            // 
            this.ptbSn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Sn", true));
            this.ptbSn.EnableNull = true;
            this.ptbSn.ErropPr = this.errorProvider1;
            this.ptbSn.Length = 0;
            this.ptbSn.Location = new System.Drawing.Point(452, 150);
            this.ptbSn.Max = 0;
            this.ptbSn.MaxStrLength = 0;
            this.ptbSn.Min = 0;
            this.ptbSn.MinStrLength = 0;
            this.ptbSn.Name = "ptbSn";
            this.ptbSn.Precision = 0;
            this.ptbSn.Size = new System.Drawing.Size(46, 21);
            this.ptbSn.TabIndex = 23;
            this.ptbSn.ToolTipValid = this.toolTip1;
            this.ptbSn.ValidEable = true;
            this.ptbSn.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbSn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbSn.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbAs
            // 
            this.ptbAs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "As", true));
            this.ptbAs.EnableNull = true;
            this.ptbAs.ErropPr = this.errorProvider1;
            this.ptbAs.Length = 0;
            this.ptbAs.Location = new System.Drawing.Point(452, 122);
            this.ptbAs.Max = 0;
            this.ptbAs.MaxStrLength = 0;
            this.ptbAs.Min = 0;
            this.ptbAs.MinStrLength = 0;
            this.ptbAs.Name = "ptbAs";
            this.ptbAs.Precision = 0;
            this.ptbAs.Size = new System.Drawing.Size(46, 21);
            this.ptbAs.TabIndex = 22;
            this.ptbAs.ToolTipValid = this.toolTip1;
            this.ptbAs.ValidEable = true;
            this.ptbAs.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbAs.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbAs.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbSb
            // 
            this.ptbSb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Sb", true));
            this.ptbSb.EnableNull = true;
            this.ptbSb.ErropPr = this.errorProvider1;
            this.ptbSb.Length = 0;
            this.ptbSb.Location = new System.Drawing.Point(452, 94);
            this.ptbSb.Max = 0;
            this.ptbSb.MaxStrLength = 0;
            this.ptbSb.Min = 0;
            this.ptbSb.MinStrLength = 0;
            this.ptbSb.Name = "ptbSb";
            this.ptbSb.Precision = 0;
            this.ptbSb.Size = new System.Drawing.Size(46, 21);
            this.ptbSb.TabIndex = 21;
            this.ptbSb.ToolTipValid = this.toolTip1;
            this.ptbSb.ValidEable = true;
            this.ptbSb.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbSb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbSb.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbB
            // 
            this.ptbB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "B", true));
            this.ptbB.EnableNull = true;
            this.ptbB.ErropPr = this.errorProvider1;
            this.ptbB.Length = 0;
            this.ptbB.Location = new System.Drawing.Point(452, 66);
            this.ptbB.Max = 0;
            this.ptbB.MaxStrLength = 0;
            this.ptbB.Min = 0;
            this.ptbB.MinStrLength = 0;
            this.ptbB.Name = "ptbB";
            this.ptbB.Precision = 0;
            this.ptbB.Size = new System.Drawing.Size(46, 21);
            this.ptbB.TabIndex = 20;
            this.ptbB.ToolTipValid = this.toolTip1;
            this.ptbB.ValidEable = true;
            this.ptbB.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbB.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbTi
            // 
            this.ptbTi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Ti", true));
            this.ptbTi.EnableNull = true;
            this.ptbTi.ErropPr = this.errorProvider1;
            this.ptbTi.Length = 0;
            this.ptbTi.Location = new System.Drawing.Point(452, 38);
            this.ptbTi.Max = 0;
            this.ptbTi.MaxStrLength = 0;
            this.ptbTi.Min = 0;
            this.ptbTi.MinStrLength = 0;
            this.ptbTi.Name = "ptbTi";
            this.ptbTi.Precision = 0;
            this.ptbTi.Size = new System.Drawing.Size(46, 21);
            this.ptbTi.TabIndex = 19;
            this.ptbTi.ToolTipValid = this.toolTip1;
            this.ptbTi.ValidEable = true;
            this.ptbTi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbTi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbTi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbAls
            // 
            this.ptbAls.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "AlS", true));
            this.ptbAls.EnableNull = true;
            this.ptbAls.ErropPr = this.errorProvider1;
            this.ptbAls.Length = 0;
            this.ptbAls.Location = new System.Drawing.Point(452, 10);
            this.ptbAls.Max = 0;
            this.ptbAls.MaxStrLength = 0;
            this.ptbAls.Min = 0;
            this.ptbAls.MinStrLength = 0;
            this.ptbAls.Name = "ptbAls";
            this.ptbAls.Precision = 0;
            this.ptbAls.Size = new System.Drawing.Size(46, 21);
            this.ptbAls.TabIndex = 18;
            this.ptbAls.ToolTipValid = this.toolTip1;
            this.ptbAls.ValidEable = true;
            this.ptbAls.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbAls.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbAls.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(429, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 56;
            this.label16.Text = "Sb:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 55;
            this.label17.Text = "B:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(429, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 57;
            this.label18.Text = "As:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(429, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 58;
            this.label20.Text = "Sn:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(429, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 12);
            this.label23.TabIndex = 54;
            this.label23.Text = "Ti:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(423, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 53;
            this.label24.Text = "AlS:";
            // 
            // ptbAl
            // 
            this.ptbAl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Al", true));
            this.ptbAl.EnableNull = true;
            this.ptbAl.ErropPr = this.errorProvider1;
            this.ptbAl.Length = 0;
            this.ptbAl.Location = new System.Drawing.Point(348, 150);
            this.ptbAl.Max = 0;
            this.ptbAl.MaxStrLength = 0;
            this.ptbAl.Min = 0;
            this.ptbAl.MinStrLength = 0;
            this.ptbAl.Name = "ptbAl";
            this.ptbAl.Precision = 0;
            this.ptbAl.Size = new System.Drawing.Size(46, 21);
            this.ptbAl.TabIndex = 17;
            this.ptbAl.ToolTipValid = this.toolTip1;
            this.ptbAl.ValidEable = true;
            this.ptbAl.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbAl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbAl.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbNb
            // 
            this.ptbNb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Nb", true));
            this.ptbNb.EnableNull = true;
            this.ptbNb.ErropPr = this.errorProvider1;
            this.ptbNb.Length = 0;
            this.ptbNb.Location = new System.Drawing.Point(348, 122);
            this.ptbNb.Max = 0;
            this.ptbNb.MaxStrLength = 0;
            this.ptbNb.Min = 0;
            this.ptbNb.MinStrLength = 0;
            this.ptbNb.Name = "ptbNb";
            this.ptbNb.Precision = 0;
            this.ptbNb.Size = new System.Drawing.Size(46, 21);
            this.ptbNb.TabIndex = 16;
            this.ptbNb.ToolTipValid = this.toolTip1;
            this.ptbNb.ValidEable = true;
            this.ptbNb.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbNb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbNb.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbV
            // 
            this.ptbV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "V", true));
            this.ptbV.EnableNull = true;
            this.ptbV.ErropPr = this.errorProvider1;
            this.ptbV.Length = 0;
            this.ptbV.Location = new System.Drawing.Point(348, 94);
            this.ptbV.Max = 0;
            this.ptbV.MaxStrLength = 0;
            this.ptbV.Min = 0;
            this.ptbV.MinStrLength = 0;
            this.ptbV.Name = "ptbV";
            this.ptbV.Precision = 0;
            this.ptbV.Size = new System.Drawing.Size(46, 21);
            this.ptbV.TabIndex = 15;
            this.ptbV.ToolTipValid = this.toolTip1;
            this.ptbV.ValidEable = true;
            this.ptbV.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbV.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbV.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbMo
            // 
            this.ptbMo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Mo", true));
            this.ptbMo.EnableNull = true;
            this.ptbMo.ErropPr = this.errorProvider1;
            this.ptbMo.Length = 0;
            this.ptbMo.Location = new System.Drawing.Point(348, 66);
            this.ptbMo.Max = 0;
            this.ptbMo.MaxStrLength = 0;
            this.ptbMo.Min = 0;
            this.ptbMo.MinStrLength = 0;
            this.ptbMo.Name = "ptbMo";
            this.ptbMo.Precision = 0;
            this.ptbMo.Size = new System.Drawing.Size(46, 21);
            this.ptbMo.TabIndex = 14;
            this.ptbMo.ToolTipValid = this.toolTip1;
            this.ptbMo.ValidEable = true;
            this.ptbMo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbMo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbMo.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbCr
            // 
            this.ptbCr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Cr", true));
            this.ptbCr.EnableNull = true;
            this.ptbCr.ErropPr = this.errorProvider1;
            this.ptbCr.Length = 0;
            this.ptbCr.Location = new System.Drawing.Point(348, 38);
            this.ptbCr.Max = 0;
            this.ptbCr.MaxStrLength = 0;
            this.ptbCr.Min = 0;
            this.ptbCr.MinStrLength = 0;
            this.ptbCr.Name = "ptbCr";
            this.ptbCr.Precision = 0;
            this.ptbCr.Size = new System.Drawing.Size(46, 21);
            this.ptbCr.TabIndex = 13;
            this.ptbCr.ToolTipValid = this.toolTip1;
            this.ptbCr.ValidEable = true;
            this.ptbCr.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbCr.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbCr.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbNi
            // 
            this.ptbNi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Ni", true));
            this.ptbNi.EnableNull = true;
            this.ptbNi.ErropPr = this.errorProvider1;
            this.ptbNi.Length = 0;
            this.ptbNi.Location = new System.Drawing.Point(348, 10);
            this.ptbNi.Max = 0;
            this.ptbNi.MaxStrLength = 0;
            this.ptbNi.Min = 0;
            this.ptbNi.MinStrLength = 0;
            this.ptbNi.Name = "ptbNi";
            this.ptbNi.Precision = 0;
            this.ptbNi.Size = new System.Drawing.Size(46, 21);
            this.ptbNi.TabIndex = 12;
            this.ptbNi.ToolTipValid = this.toolTip1;
            this.ptbNi.ValidEable = true;
            this.ptbNi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbNi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbNi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 50;
            this.label10.Text = "V:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 51;
            this.label12.Text = "Nb:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 52;
            this.label13.Text = "Al:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 48;
            this.label14.Text = "Cr:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(325, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 47;
            this.label15.Text = "Ni:";
            // 
            // ptbCu
            // 
            this.ptbCu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Cu", true));
            this.ptbCu.EnableNull = true;
            this.ptbCu.ErropPr = this.errorProvider1;
            this.ptbCu.Length = 0;
            this.ptbCu.Location = new System.Drawing.Point(241, 150);
            this.ptbCu.Max = 0;
            this.ptbCu.MaxStrLength = 0;
            this.ptbCu.Min = 0;
            this.ptbCu.MinStrLength = 0;
            this.ptbCu.Name = "ptbCu";
            this.ptbCu.Precision = 0;
            this.ptbCu.Size = new System.Drawing.Size(46, 21);
            this.ptbCu.TabIndex = 11;
            this.ptbCu.ToolTipValid = this.toolTip1;
            this.ptbCu.ValidEable = true;
            this.ptbCu.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbCu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbCu.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbS
            // 
            this.ptbS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "S", true));
            this.ptbS.EnableNull = true;
            this.ptbS.ErropPr = this.errorProvider1;
            this.ptbS.Length = 0;
            this.ptbS.Location = new System.Drawing.Point(241, 122);
            this.ptbS.Max = 0;
            this.ptbS.MaxStrLength = 0;
            this.ptbS.Min = 0;
            this.ptbS.MinStrLength = 0;
            this.ptbS.Name = "ptbS";
            this.ptbS.Precision = 0;
            this.ptbS.Size = new System.Drawing.Size(46, 21);
            this.ptbS.TabIndex = 10;
            this.ptbS.ToolTipValid = this.toolTip1;
            this.ptbS.ValidEable = true;
            this.ptbS.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbS.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbS.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbP
            // 
            this.ptbP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "P", true));
            this.ptbP.EnableNull = true;
            this.ptbP.ErropPr = this.errorProvider1;
            this.ptbP.Length = 0;
            this.ptbP.Location = new System.Drawing.Point(241, 94);
            this.ptbP.Max = 0;
            this.ptbP.MaxStrLength = 0;
            this.ptbP.Min = 0;
            this.ptbP.MinStrLength = 0;
            this.ptbP.Name = "ptbP";
            this.ptbP.Precision = 0;
            this.ptbP.Size = new System.Drawing.Size(46, 21);
            this.ptbP.TabIndex = 9;
            this.ptbP.ToolTipValid = this.toolTip1;
            this.ptbP.ValidEable = true;
            this.ptbP.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbP.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbMn
            // 
            this.ptbMn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Mn", true));
            this.ptbMn.EnableNull = true;
            this.ptbMn.ErropPr = this.errorProvider1;
            this.ptbMn.Length = 0;
            this.ptbMn.Location = new System.Drawing.Point(241, 66);
            this.ptbMn.Max = 0;
            this.ptbMn.MaxStrLength = 0;
            this.ptbMn.Min = 0;
            this.ptbMn.MinStrLength = 0;
            this.ptbMn.Name = "ptbMn";
            this.ptbMn.Precision = 0;
            this.ptbMn.Size = new System.Drawing.Size(46, 21);
            this.ptbMn.TabIndex = 8;
            this.ptbMn.ToolTipValid = this.toolTip1;
            this.ptbMn.ValidEable = true;
            this.ptbMn.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbMn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbMn.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbSi
            // 
            this.ptbSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Si", true));
            this.ptbSi.EnableNull = true;
            this.ptbSi.ErropPr = this.errorProvider1;
            this.ptbSi.Length = 0;
            this.ptbSi.Location = new System.Drawing.Point(241, 38);
            this.ptbSi.Max = 0;
            this.ptbSi.MaxStrLength = 0;
            this.ptbSi.Min = 0;
            this.ptbSi.MinStrLength = 0;
            this.ptbSi.Name = "ptbSi";
            this.ptbSi.Precision = 0;
            this.ptbSi.Size = new System.Drawing.Size(46, 21);
            this.ptbSi.TabIndex = 7;
            this.ptbSi.ToolTipValid = this.toolTip1;
            this.ptbSi.ValidEable = true;
            this.ptbSi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbSi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbSi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // ptbC
            // 
            this.ptbC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "C", true));
            this.ptbC.EnableNull = true;
            this.ptbC.ErropPr = this.errorProvider1;
            this.ptbC.Length = 0;
            this.ptbC.Location = new System.Drawing.Point(241, 10);
            this.ptbC.Max = 0;
            this.ptbC.MaxStrLength = 0;
            this.ptbC.Min = 0;
            this.ptbC.MinStrLength = 0;
            this.ptbC.Name = "ptbC";
            this.ptbC.Precision = 0;
            this.ptbC.Size = new System.Drawing.Size(46, 21);
            this.ptbC.TabIndex = 6;
            this.ptbC.ToolTipValid = this.toolTip1;
            this.ptbC.ValidEable = true;
            this.ptbC.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.ptbC.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.ptbC.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtApplyID
            // 
            this.txtApplyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "AppID", true));
            this.txtApplyID.EnableNull = true;
            this.txtApplyID.ErropPr = null;
            this.txtApplyID.Length = 0;
            this.txtApplyID.Location = new System.Drawing.Point(84, 124);
            this.txtApplyID.Max = 0;
            this.txtApplyID.MaxStrLength = 0;
            this.txtApplyID.Min = 0;
            this.txtApplyID.MinStrLength = 0;
            this.txtApplyID.Name = "txtApplyID";
            this.txtApplyID.Precision = 0;
            this.txtApplyID.ReadOnly = true;
            this.txtApplyID.Size = new System.Drawing.Size(99, 21);
            this.txtApplyID.TabIndex = 4;
            this.txtApplyID.ToolTipValid = null;
            this.txtApplyID.ValidEable = true;
            this.txtApplyID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtApplyID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            // 
            // txtSampleCount
            // 
            this.txtSampleCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "Sample_Count", true));
            this.txtSampleCount.EnableNull = true;
            this.txtSampleCount.ErropPr = this.errorProvider1;
            this.txtSampleCount.Length = 0;
            this.txtSampleCount.Location = new System.Drawing.Point(84, 95);
            this.txtSampleCount.Max = 0;
            this.txtSampleCount.MaxStrLength = 0;
            this.txtSampleCount.Min = 0;
            this.txtSampleCount.MinStrLength = 0;
            this.txtSampleCount.Name = "txtSampleCount";
            this.txtSampleCount.Precision = 0;
            this.txtSampleCount.ReadOnly = true;
            this.txtSampleCount.Size = new System.Drawing.Size(99, 21);
            this.txtSampleCount.TabIndex = 3;
            this.txtSampleCount.ToolTipValid = this.toolTip1;
            this.txtSampleCount.ValidEable = true;
            this.txtSampleCount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtSampleCount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChemical, "HeatID", true));
            this.txtHeatID.EnableNull = true;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 9;
            this.txtHeatID.Location = new System.Drawing.Point(84, 38);
            this.txtHeatID.Max = 0;
            this.txtHeatID.MaxStrLength = 0;
            this.txtHeatID.Min = 0;
            this.txtHeatID.MinStrLength = 0;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Precision = 0;
            this.txtHeatID.Size = new System.Drawing.Size(99, 21);
            this.txtHeatID.TabIndex = 1;
            this.txtHeatID.ToolTipValid = this.toolTip1;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtHeatID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.txtHeatID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "炉号:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 40;
            this.label22.Text = "试样次数:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 39;
            this.label21.Text = "取样类别:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 35;
            this.label19.Text = "取样地点:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "P:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "Mn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "Si:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "C:";
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
            // cmdNewLabSheet
            // 
            this.cmdNewLabSheet.Adapter = this.Adapter;
            this.cmdNewLabSheet.MergeReturnTarget = false;
            this.cmdNewLabSheet.Method = "GenLabSheet";
            this.cmdNewLabSheet.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdNewLabSheet.Parameters.Add(this.l3cmdpSampleType);
            this.cmdNewLabSheet.Parameters.Add(this.l3cmdpAddr);
            this.cmdNewLabSheet.Parameters.Add(this.l3cmdpHeatID);
            this.cmdNewLabSheet.Parameters.Add(this.l3cmdpFinalFlag);
            this.cmdNewLabSheet.ReturnTarget = null;
            this.cmdNewLabSheet.ReturnTargetProperty = null;
            this.cmdNewLabSheet.Trigger = null;
            this.cmdNewLabSheet.TriggerEvent = "Click";
            // 
            // l3cmdpSampleType
            // 
            this.l3cmdpSampleType.AcceptAfterExecuted = false;
            this.l3cmdpSampleType.ConstantValue = null;
            this.l3cmdpSampleType.MergeTarget = false;
            this.l3cmdpSampleType.SourceFilter = null;
            this.l3cmdpSampleType.SourceObject = null;
            this.l3cmdpSampleType.SourceProperty = null;
            this.l3cmdpSampleType.TargetObject = null;
            this.l3cmdpSampleType.TargetProperty = null;
            // 
            // l3cmdpAddr
            // 
            this.l3cmdpAddr.AcceptAfterExecuted = false;
            this.l3cmdpAddr.ConstantValue = null;
            this.l3cmdpAddr.MergeTarget = false;
            this.l3cmdpAddr.SourceFilter = null;
            this.l3cmdpAddr.SourceObject = null;
            this.l3cmdpAddr.SourceProperty = null;
            this.l3cmdpAddr.TargetObject = null;
            this.l3cmdpAddr.TargetProperty = null;
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
            // l3cmdpFinalFlag
            // 
            this.l3cmdpFinalFlag.AcceptAfterExecuted = false;
            this.l3cmdpFinalFlag.ConstantValue = null;
            this.l3cmdpFinalFlag.MergeTarget = false;
            this.l3cmdpFinalFlag.SourceFilter = null;
            this.l3cmdpFinalFlag.SourceObject = null;
            this.l3cmdpFinalFlag.SourceProperty = null;
            this.l3cmdpFinalFlag.TargetObject = null;
            this.l3cmdpFinalFlag.TargetProperty = null;
            // 
            // ChemicalInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 258);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChemicalInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "成分收集";
            this.Load += new System.EventHandler(this.ChemicalInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpElement.ResumeLayout(false);
            this.tpElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAddr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpElement;
        private PxDataValid.PxTextBox ptbCu;
        private PxDataValid.PxTextBox ptbS;
        private PxDataValid.PxTextBox ptbP;
        private PxDataValid.PxTextBox ptbMn;
        private PxDataValid.PxTextBox ptbSi;
        private PxDataValid.PxTextBox ptbC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtSampleCode;
        private PxDataValid.PxTextBox ptbOther2;
        private PxDataValid.PxTextBox ptbOther1;
        private PxDataValid.PxTextBox ptbO;
        private PxDataValid.PxTextBox ptbH;
        private PxDataValid.PxTextBox ptbN;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private PxDataValid.PxTextBox ptbRe;
        private PxDataValid.PxTextBox ptbPb;
        private PxDataValid.PxTextBox ptbW;
        private PxDataValid.PxTextBox ptbZn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox ptbSn;
        private PxDataValid.PxTextBox ptbAs;
        private PxDataValid.PxTextBox ptbSb;
        private PxDataValid.PxTextBox ptbB;
        private PxDataValid.PxTextBox ptbTi;
        private PxDataValid.PxTextBox ptbAls;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private PxDataValid.PxTextBox ptbAl;
        private PxDataValid.PxTextBox ptbNb;
        private PxDataValid.PxTextBox ptbV;
        private PxDataValid.PxTextBox ptbMo;
        private PxDataValid.PxTextBox ptbCr;
        private PxDataValid.PxTextBox ptbNi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsChemical;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Data.DataTable schemadsChemical;
        private System.Data.DataColumn coldsChemicalL3DataTableGUID;
        private System.Data.DataColumn coldsChemicalL3DataTableName;
        private System.Data.DataColumn coldsChemicalL3DataTableAppID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Code;
        private System.Data.DataColumn coldsChemicalL3DataTableArrive_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableReport_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableHeatID;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Address;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Type;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Count;
        private System.Data.DataColumn coldsChemicalL3DataTableC;
        private System.Data.DataColumn coldsChemicalL3DataTableSi;
        private System.Data.DataColumn coldsChemicalL3DataTableMn;
        private System.Data.DataColumn coldsChemicalL3DataTableP;
        private System.Data.DataColumn coldsChemicalL3DataTableS;
        private System.Data.DataColumn coldsChemicalL3DataTableCu;
        private System.Data.DataColumn coldsChemicalL3DataTableNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCr;
        private System.Data.DataColumn coldsChemicalL3DataTableMo;
        private System.Data.DataColumn coldsChemicalL3DataTableV;
        private System.Data.DataColumn coldsChemicalL3DataTableNb;
        private System.Data.DataColumn coldsChemicalL3DataTableAl;
        private System.Data.DataColumn coldsChemicalL3DataTableAlS;
        private System.Data.DataColumn coldsChemicalL3DataTableTi;
        private System.Data.DataColumn coldsChemicalL3DataTableB;
        private System.Data.DataColumn coldsChemicalL3DataTableSb;
        private System.Data.DataColumn coldsChemicalL3DataTableAs;
        private System.Data.DataColumn coldsChemicalL3DataTableSn;
        private System.Data.DataColumn coldsChemicalL3DataTableZn;
        private System.Data.DataColumn coldsChemicalL3DataTableCa;
        private System.Data.DataColumn coldsChemicalL3DataTableW;
        private System.Data.DataColumn coldsChemicalL3DataTablePb;
        private System.Data.DataColumn coldsChemicalL3DataTableRe;
        private System.Data.DataColumn coldsChemicalL3DataTableCeq;
        private System.Data.DataColumn coldsChemicalL3DataTableN;
        private System.Data.DataColumn coldsChemicalL3DataTableH;
        private System.Data.DataColumn coldsChemicalL3DataTableO;
        private System.Data.DataColumn coldsChemicalL3DataTableOther1;
        private System.Data.DataColumn coldsChemicalL3DataTableOther2;
        private System.Data.DataColumn coldsChemicalL3DataTableLogTime;
        private System.Data.DataColumn coldsChemicalL3DataTableDataLogMode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PxDataValid.PxComboBox cmbAddr;
        private PxDataValid.PxTextBox txtHeatID;
        private AppSvrHMI.L3DataSet dsAddr;
        private System.Data.DataTable schemadsAddr;
        private System.Data.DataColumn coldsAddrL3DataTableCode;
        private System.Data.DataColumn coldsAddrL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxComboBox cmbSampleType;
        private PxDataValid.PxTextBox txtApplyID;
        private PxDataValid.PxTextBox txtSampleCount;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Windows.Forms.Button btnFormAppID;
        private AppSvrHMI.L3Command cmdNewLabSheet;
        private AppSvrHMI.L3CommandParameter l3cmdpSampleType;
        private AppSvrHMI.L3CommandParameter l3cmdpAddr;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpFinalFlag;
        private System.Windows.Forms.CheckBox ckbFinalFlag;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsChemicalL3DataTableOther3;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox pxTextBox2;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label34;
    }
}