namespace UnitMag.BOFMag
{
    partial class NewDesignateMaterialFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvIronInfo = new System.Windows.Forms.DataGridView();
            this.SELECTID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shiftDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironLadleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronMode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsIronMode = new System.Data.DataTable();
            this.coldsIronModeL3DataTableName = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableNC_Code = new System.Data.DataColumn();
            this.returnSteelWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapTimeDataGridViewTextBoxColumn = new DataGridValid.DataGridViewValidateCellColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIronInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronInfo = new AppSvrHMI.L3DataSet();
            this.schemadsIronInfo = new System.Data.DataTable();
            this.coldsIronInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePosition = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableC = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableP = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableS = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronTemp = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSource = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableShift = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTeam = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTare = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTap_Time = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronLadleNo = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject1 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight1 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject2 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight2 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject3 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight3 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIsDes = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableAs = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSELECTID = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHeatID = new AppSvrHMI.L3DataBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvScrapSteel = new System.Windows.Forms.DataGridView();
            this.bsScrapSteel = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapSteel = new AppSvrHMI.L3DataSet();
            this.schemadsScrapSteel = new System.Data.DataTable();
            this.coldsScrapSteelL3DataTableAmount = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableScrapWT = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTablePigIronWT = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableHEATID = new System.Data.DataColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsST = new System.Windows.Forms.BindingSource(this.components);
            this.dsST = new AppSvrHMI.L3DataSet();
            this.schemadsST = new System.Data.DataTable();
            this.coldsSTL3DataTableSCRAP_SLOT_ID = new System.Data.DataColumn();
            this.AAcoldsSTL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsSTL3DataTableCode_Des = new System.Data.DataColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.bsFGST = new System.Windows.Forms.BindingSource(this.components);
            this.dsFGST = new AppSvrHMI.L3DataSet();
            this.schemadsFGST = new System.Data.DataTable();
            this.coldsFGSTL3DataTableCode = new System.Data.DataColumn();
            this.AAcoldsFGSTL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsFG = new System.Windows.Forms.BindingSource(this.components);
            this.dsFG = new AppSvrHMI.L3DataSet();
            this.schemadsFG = new System.Data.DataTable();
            this.coldsFGL3DataTableSCRAP_SLOT_ID = new System.Data.DataColumn();
            this.coldsFGL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.coldsFGL3DataTableAMOUNT = new System.Data.DataColumn();
            this.dsReturnSteel = new AppSvrHMI.L3DataSet();
            this.schemadsReturnSteel = new System.Data.DataTable();
            this.coldsReturnSteelL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsReturnSteelL3DataTableReturn_SteelGrade = new System.Data.DataColumn();
            this.cmdDesignateMainMat = new AppSvrHMI.L3Command(this.components);
            this.cmdPar1 = new AppSvrHMI.L3CommandParameter();
            this.cmdPar2 = new AppSvrHMI.L3CommandParameter();
            this.cmdPar3 = new AppSvrHMI.L3CommandParameter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.coldsFGSTL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsSTL3DataTableMATERIAL = new System.Data.DataColumn();
            this.coldsSTL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.coldsSTL3DataTableAMOUNT = new System.Data.DataColumn();
            this.AcoldsFGSTL3DataTableCode_Des = new System.Data.DataColumn();
            this.AcoldsSTL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.AcoldsSTL3DataTableAMOUNT = new System.Data.DataColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coldsFGL3DataTableCode_Des = new System.Data.DataColumn();
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkFlagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.scrapSlotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PigIronWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSteel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsST)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturnSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.29981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.90323F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvIronInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "铁水信息";
            // 
            // dvIronInfo
            // 
            this.dvIronInfo.AllowUserToAddRows = false;
            this.dvIronInfo.AutoGenerateColumns = false;
            this.dvIronInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvIronInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvIronInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvIronInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTID,
            this.shiftDataGridViewCheckBoxColumn,
            this.teamDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.ironLadleNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewCheckBoxColumn,
            this.returnSteelWeightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.qAStatusDataGridViewTextBoxColumn,
            this.qALevelDataGridViewTextBoxColumn,
            this.orderContractIDDataGridViewTextBoxColumn,
            this.produceContractIDDataGridViewTextBoxColumn,
            this.salesContractIDDataGridViewTextBoxColumn,
            this.tapTimeDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.Sn,
            this.Sb,
            this.As,
            this.Pb,
            this.ironTempDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.tareDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.object1DataGridViewTextBoxColumn,
            this.weight1DataGridViewTextBoxColumn,
            this.object2DataGridViewTextBoxColumn,
            this.weight2DataGridViewTextBoxColumn,
            this.object3DataGridViewTextBoxColumn,
            this.weight3DataGridViewTextBoxColumn,
            this.isDesDataGridViewTextBoxColumn});
            this.dvIronInfo.DataSource = this.bsIronInfo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvIronInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvIronInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronInfo.Location = new System.Drawing.Point(3, 17);
            this.dvIronInfo.Name = "dvIronInfo";
            this.dvIronInfo.RowHeadersVisible = false;
            this.dvIronInfo.RowTemplate.Height = 23;
            this.dvIronInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvIronInfo.Size = new System.Drawing.Size(977, 189);
            this.dvIronInfo.TabIndex = 0;
            // 
            // SELECTID
            // 
            this.SELECTID.DataPropertyName = "SELECTID";
            this.SELECTID.FalseValue = "0";
            this.SELECTID.Frozen = true;
            this.SELECTID.HeaderText = "选择";
            this.SELECTID.IndeterminateValue = "0";
            this.SELECTID.Name = "SELECTID";
            this.SELECTID.TrueValue = "1";
            this.SELECTID.Width = 35;
            // 
            // shiftDataGridViewCheckBoxColumn
            // 
            this.shiftDataGridViewCheckBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewCheckBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewCheckBoxColumn.Name = "shiftDataGridViewCheckBoxColumn";
            this.shiftDataGridViewCheckBoxColumn.Visible = false;
            this.shiftDataGridViewCheckBoxColumn.Width = 41;
            // 
            // teamDataGridViewCheckBoxColumn
            // 
            this.teamDataGridViewCheckBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewCheckBoxColumn.HeaderText = "Team";
            this.teamDataGridViewCheckBoxColumn.Name = "teamDataGridViewCheckBoxColumn";
            this.teamDataGridViewCheckBoxColumn.Visible = false;
            this.teamDataGridViewCheckBoxColumn.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Frozen = true;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // ironLadleNoDataGridViewTextBoxColumn
            // 
            this.ironLadleNoDataGridViewTextBoxColumn.DataPropertyName = "IronLadleNo";
            this.ironLadleNoDataGridViewTextBoxColumn.Frozen = true;
            this.ironLadleNoDataGridViewTextBoxColumn.HeaderText = "铁包号";
            this.ironLadleNoDataGridViewTextBoxColumn.Name = "ironLadleNoDataGridViewTextBoxColumn";
            this.ironLadleNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // sourceDataGridViewCheckBoxColumn
            // 
            this.sourceDataGridViewCheckBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewCheckBoxColumn.DataSource = this.dsIronMode;
            this.sourceDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sourceDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceDataGridViewCheckBoxColumn.Frozen = true;
            this.sourceDataGridViewCheckBoxColumn.HeaderText = "出铁方式";
            this.sourceDataGridViewCheckBoxColumn.Name = "sourceDataGridViewCheckBoxColumn";
            this.sourceDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sourceDataGridViewCheckBoxColumn.Width = 59;
            // 
            // dsIronMode
            // 
            this.dsIronMode.AutoLoad = true;
            this.dsIronMode.AutoSubscribe = false;
            this.dsIronMode.DataSetName = "L3DataSet";
            this.dsIronMode.DeleteMethod = null;
            this.dsIronMode.InsertMethod = null;
            this.dsIronMode.L3DataAdapter = this.Adapter;
            this.dsIronMode.LoadEvent = "Click";
            this.dsIronMode.LoadTrigger = null;
            this.dsIronMode.RefreshValve = 1000;
            this.dsIronMode.SourceCommand = null;
            this.dsIronMode.SourceCondition = "CODE_GROUP = \'Iron_Mode\'";
            this.dsIronMode.SourceMethod = "";
            this.dsIronMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronMode.SubscribeTarget = null;
            this.dsIronMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronMode});
            this.dsIronMode.UpdateEvent = "Click";
            this.dsIronMode.UpdateMethod = null;
            this.dsIronMode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsIronMode
            // 
            this.schemadsIronMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronModeL3DataTableName,
            this.coldsIronModeL3DataTableCode,
            this.coldsIronModeL3DataTableCode_Des,
            this.coldsIronModeL3DataTableCode_Group,
            this.coldsIronModeL3DataTableCode_Group_Des,
            this.coldsIronModeL3DataTableCode_Val_Str,
            this.coldsIronModeL3DataTableCode_Val_Long,
            this.coldsIronModeL3DataTableCode_Val_Double,
            this.coldsIronModeL3DataTableCode_Function_Group,
            this.coldsIronModeL3DataTableNC_Code});
            this.schemadsIronMode.TableName = "L3DataTable";
            // 
            // coldsIronModeL3DataTableName
            // 
            this.coldsIronModeL3DataTableName.Caption = "Name";
            this.coldsIronModeL3DataTableName.ColumnName = "Name";
            this.coldsIronModeL3DataTableName.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode
            // 
            this.coldsIronModeL3DataTableCode.Caption = "Code";
            this.coldsIronModeL3DataTableCode.ColumnName = "Code";
            this.coldsIronModeL3DataTableCode.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Des
            // 
            this.coldsIronModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Group
            // 
            this.coldsIronModeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsIronModeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsIronModeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Group_Des
            // 
            this.coldsIronModeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsIronModeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsIronModeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Str
            // 
            this.coldsIronModeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsIronModeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsIronModeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Long
            // 
            this.coldsIronModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Double
            // 
            this.coldsIronModeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsIronModeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsIronModeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsIronModeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Function_Group
            // 
            this.coldsIronModeL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsIronModeL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsIronModeL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsIronModeL3DataTableNC_Code
            // 
            this.coldsIronModeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsIronModeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsIronModeL3DataTableNC_Code.Namespace = "";
            // 
            // returnSteelWeightDataGridViewTextBoxColumn
            // 
            this.returnSteelWeightDataGridViewTextBoxColumn.DataPropertyName = "Return_Steel_Weight";
            this.returnSteelWeightDataGridViewTextBoxColumn.HeaderText = "回炉钢水量";
            this.returnSteelWeightDataGridViewTextBoxColumn.Name = "returnSteelWeightDataGridViewTextBoxColumn";
            this.returnSteelWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "铁水重量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 66;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Visible = false;
            this.positionDataGridViewTextBoxColumn.Width = 78;
            // 
            // qAStatusDataGridViewTextBoxColumn
            // 
            this.qAStatusDataGridViewTextBoxColumn.DataPropertyName = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.HeaderText = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.Name = "qAStatusDataGridViewTextBoxColumn";
            this.qAStatusDataGridViewTextBoxColumn.Visible = false;
            this.qAStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // qALevelDataGridViewTextBoxColumn
            // 
            this.qALevelDataGridViewTextBoxColumn.DataPropertyName = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.HeaderText = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.Name = "qALevelDataGridViewTextBoxColumn";
            this.qALevelDataGridViewTextBoxColumn.Visible = false;
            this.qALevelDataGridViewTextBoxColumn.Width = 72;
            // 
            // orderContractIDDataGridViewTextBoxColumn
            // 
            this.orderContractIDDataGridViewTextBoxColumn.DataPropertyName = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.HeaderText = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.Name = "orderContractIDDataGridViewTextBoxColumn";
            this.orderContractIDDataGridViewTextBoxColumn.Visible = false;
            this.orderContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // produceContractIDDataGridViewTextBoxColumn
            // 
            this.produceContractIDDataGridViewTextBoxColumn.DataPropertyName = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.HeaderText = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.Name = "produceContractIDDataGridViewTextBoxColumn";
            this.produceContractIDDataGridViewTextBoxColumn.Visible = false;
            this.produceContractIDDataGridViewTextBoxColumn.Width = 132;
            // 
            // salesContractIDDataGridViewTextBoxColumn
            // 
            this.salesContractIDDataGridViewTextBoxColumn.DataPropertyName = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.HeaderText = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.Name = "salesContractIDDataGridViewTextBoxColumn";
            this.salesContractIDDataGridViewTextBoxColumn.Visible = false;
            this.salesContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // tapTimeDataGridViewTextBoxColumn
            // 
            this.tapTimeDataGridViewTextBoxColumn.DataPropertyName = "Tap_Time";
            this.tapTimeDataGridViewTextBoxColumn.DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewColumnHeaderCell);
            this.tapTimeDataGridViewTextBoxColumn.EnableNull = true;
            this.tapTimeDataGridViewTextBoxColumn.HeaderText = "出铁时间";
            this.tapTimeDataGridViewTextBoxColumn.Length = 0;
            this.tapTimeDataGridViewTextBoxColumn.Max = 0;
            this.tapTimeDataGridViewTextBoxColumn.MaxInputLength = 32767;
            this.tapTimeDataGridViewTextBoxColumn.MaxLength = 0;
            this.tapTimeDataGridViewTextBoxColumn.Min = 0;
            this.tapTimeDataGridViewTextBoxColumn.MinLength = 0;
            this.tapTimeDataGridViewTextBoxColumn.Name = "tapTimeDataGridViewTextBoxColumn";
            this.tapTimeDataGridViewTextBoxColumn.Precision = 0;
            this.tapTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tapTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tapTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tapTimeDataGridViewTextBoxColumn.ValidEable = true;
            this.tapTimeDataGridViewTextBoxColumn.ValidType = DataGridValid.DataGridViewValidateCellColumn.TypeEnum.Integer;
            this.tapTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.Width = 42;
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            this.Sb.Width = 42;
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            this.As.HeaderText = "As";
            this.As.Name = "As";
            this.As.Width = 42;
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            this.Pb.Width = 42;
            // 
            // ironTempDataGridViewTextBoxColumn
            // 
            this.ironTempDataGridViewTextBoxColumn.DataPropertyName = "IronTemp";
            this.ironTempDataGridViewTextBoxColumn.HeaderText = "铁水温度";
            this.ironTempDataGridViewTextBoxColumn.Name = "ironTempDataGridViewTextBoxColumn";
            this.ironTempDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Visible = false;
            this.operatorDataGridViewTextBoxColumn.Width = 78;
            // 
            // tareDataGridViewTextBoxColumn
            // 
            this.tareDataGridViewTextBoxColumn.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn.HeaderText = "皮重";
            this.tareDataGridViewTextBoxColumn.Name = "tareDataGridViewTextBoxColumn";
            this.tareDataGridViewTextBoxColumn.Width = 54;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // object1DataGridViewTextBoxColumn
            // 
            this.object1DataGridViewTextBoxColumn.DataPropertyName = "Object1";
            this.object1DataGridViewTextBoxColumn.HeaderText = "Object1";
            this.object1DataGridViewTextBoxColumn.Name = "object1DataGridViewTextBoxColumn";
            this.object1DataGridViewTextBoxColumn.Visible = false;
            this.object1DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight1DataGridViewTextBoxColumn
            // 
            this.weight1DataGridViewTextBoxColumn.DataPropertyName = "Weight1";
            this.weight1DataGridViewTextBoxColumn.HeaderText = "Weight1";
            this.weight1DataGridViewTextBoxColumn.Name = "weight1DataGridViewTextBoxColumn";
            this.weight1DataGridViewTextBoxColumn.Visible = false;
            this.weight1DataGridViewTextBoxColumn.Width = 72;
            // 
            // object2DataGridViewTextBoxColumn
            // 
            this.object2DataGridViewTextBoxColumn.DataPropertyName = "Object2";
            this.object2DataGridViewTextBoxColumn.HeaderText = "Object2";
            this.object2DataGridViewTextBoxColumn.Name = "object2DataGridViewTextBoxColumn";
            this.object2DataGridViewTextBoxColumn.Visible = false;
            this.object2DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight2DataGridViewTextBoxColumn
            // 
            this.weight2DataGridViewTextBoxColumn.DataPropertyName = "Weight2";
            this.weight2DataGridViewTextBoxColumn.HeaderText = "Weight2";
            this.weight2DataGridViewTextBoxColumn.Name = "weight2DataGridViewTextBoxColumn";
            this.weight2DataGridViewTextBoxColumn.Visible = false;
            this.weight2DataGridViewTextBoxColumn.Width = 72;
            // 
            // object3DataGridViewTextBoxColumn
            // 
            this.object3DataGridViewTextBoxColumn.DataPropertyName = "Object3";
            this.object3DataGridViewTextBoxColumn.HeaderText = "Object3";
            this.object3DataGridViewTextBoxColumn.Name = "object3DataGridViewTextBoxColumn";
            this.object3DataGridViewTextBoxColumn.Visible = false;
            this.object3DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight3DataGridViewTextBoxColumn
            // 
            this.weight3DataGridViewTextBoxColumn.DataPropertyName = "Weight3";
            this.weight3DataGridViewTextBoxColumn.HeaderText = "Weight3";
            this.weight3DataGridViewTextBoxColumn.Name = "weight3DataGridViewTextBoxColumn";
            this.weight3DataGridViewTextBoxColumn.Visible = false;
            this.weight3DataGridViewTextBoxColumn.Width = 72;
            // 
            // isDesDataGridViewTextBoxColumn
            // 
            this.isDesDataGridViewTextBoxColumn.DataPropertyName = "IsDes";
            this.isDesDataGridViewTextBoxColumn.HeaderText = "IsDes";
            this.isDesDataGridViewTextBoxColumn.Name = "isDesDataGridViewTextBoxColumn";
            this.isDesDataGridViewTextBoxColumn.Visible = false;
            this.isDesDataGridViewTextBoxColumn.Width = 60;
            // 
            // bsIronInfo
            // 
            this.bsIronInfo.DataMember = "L3DataTable";
            this.bsIronInfo.DataSource = this.dsIronInfo;
            // 
            // dsIronInfo
            // 
            this.dsIronInfo.AutoLoad = true;
            this.dsIronInfo.AutoSubscribe = false;
            this.dsIronInfo.DataSetName = "L3DataSet";
            this.dsIronInfo.DeleteMethod = "";
            this.dsIronInfo.InsertMethod = "";
            this.dsIronInfo.L3DataAdapter = this.Adapter;
            this.dsIronInfo.LoadEvent = "";
            this.dsIronInfo.LoadTrigger = null;
            this.dsIronInfo.RefreshValve = 1000;
            this.dsIronInfo.SourceCommand = null;
            this.dsIronInfo.SourceCondition = "";
            this.dsIronInfo.SourceMethod = "GetIronsForDesignate";
            this.dsIronInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsIronInfo.SourceURI = "XGMESLogic\\\\BOFMag\\\\CBOF_Unit_Mag\\\\{BOFID}";
            this.dsIronInfo.SubscribeTarget = "";
            this.dsIronInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronInfo});
            this.dsIronInfo.UpdateEvent = "";
            this.dsIronInfo.UpdateMethod = "";
            this.dsIronInfo.UpdateTrigger = null;
            // 
            // schemadsIronInfo
            // 
            this.schemadsIronInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronInfoL3DataTableName,
            this.coldsIronInfoL3DataTableMaterialID,
            this.coldsIronInfoL3DataTableStatus,
            this.coldsIronInfoL3DataTablePosition,
            this.coldsIronInfoL3DataTableQAStatus,
            this.coldsIronInfoL3DataTableQALevel,
            this.coldsIronInfoL3DataTableOrderContractID,
            this.coldsIronInfoL3DataTableProduceContractID,
            this.coldsIronInfoL3DataTableSalesContractID,
            this.coldsIronInfoL3DataTableWeight,
            this.coldsIronInfoL3DataTableC,
            this.coldsIronInfoL3DataTableSi,
            this.coldsIronInfoL3DataTableMn,
            this.coldsIronInfoL3DataTableP,
            this.coldsIronInfoL3DataTableS,
            this.coldsIronInfoL3DataTableTi,
            this.coldsIronInfoL3DataTableIronTemp,
            this.coldsIronInfoL3DataTableHeatID,
            this.coldsIronInfoL3DataTableSource,
            this.coldsIronInfoL3DataTableShift,
            this.coldsIronInfoL3DataTableTeam,
            this.coldsIronInfoL3DataTableOperator,
            this.coldsIronInfoL3DataTableTare,
            this.coldsIronInfoL3DataTableGross_Weight,
            this.coldsIronInfoL3DataTableTap_Time,
            this.coldsIronInfoL3DataTableIronLadleNo,
            this.coldsIronInfoL3DataTableObject1,
            this.coldsIronInfoL3DataTableWeight1,
            this.coldsIronInfoL3DataTableObject2,
            this.coldsIronInfoL3DataTableWeight2,
            this.coldsIronInfoL3DataTableObject3,
            this.coldsIronInfoL3DataTableWeight3,
            this.coldsIronInfoL3DataTableReturn_Steel_Weight,
            this.coldsIronInfoL3DataTableIsDes,
            this.coldsIronInfoL3DataTableSn,
            this.coldsIronInfoL3DataTableSb,
            this.coldsIronInfoL3DataTableAs,
            this.coldsIronInfoL3DataTablePb,
            this.coldsIronInfoL3DataTableSELECTID});
            this.schemadsIronInfo.TableName = "L3DataTable";
            // 
            // coldsIronInfoL3DataTableName
            // 
            this.coldsIronInfoL3DataTableName.Caption = "Name";
            this.coldsIronInfoL3DataTableName.ColumnName = "Name";
            this.coldsIronInfoL3DataTableName.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMaterialID
            // 
            this.coldsIronInfoL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableStatus
            // 
            this.coldsIronInfoL3DataTableStatus.Caption = "Status";
            this.coldsIronInfoL3DataTableStatus.ColumnName = "Status";
            this.coldsIronInfoL3DataTableStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePosition
            // 
            this.coldsIronInfoL3DataTablePosition.Caption = "Position";
            this.coldsIronInfoL3DataTablePosition.ColumnName = "Position";
            this.coldsIronInfoL3DataTablePosition.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQAStatus
            // 
            this.coldsIronInfoL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQAStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQALevel
            // 
            this.coldsIronInfoL3DataTableQALevel.Caption = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQALevel.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOrderContractID
            // 
            this.coldsIronInfoL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableProduceContractID
            // 
            this.coldsIronInfoL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSalesContractID
            // 
            this.coldsIronInfoL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight
            // 
            this.coldsIronInfoL3DataTableWeight.Caption = "Weight";
            this.coldsIronInfoL3DataTableWeight.ColumnName = "Weight";
            this.coldsIronInfoL3DataTableWeight.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableC
            // 
            this.coldsIronInfoL3DataTableC.Caption = "C";
            this.coldsIronInfoL3DataTableC.ColumnName = "C";
            this.coldsIronInfoL3DataTableC.DataType = typeof(float);
            this.coldsIronInfoL3DataTableC.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSi
            // 
            this.coldsIronInfoL3DataTableSi.Caption = "Si";
            this.coldsIronInfoL3DataTableSi.ColumnName = "Si";
            this.coldsIronInfoL3DataTableSi.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMn
            // 
            this.coldsIronInfoL3DataTableMn.Caption = "Mn";
            this.coldsIronInfoL3DataTableMn.ColumnName = "Mn";
            this.coldsIronInfoL3DataTableMn.DataType = typeof(float);
            this.coldsIronInfoL3DataTableMn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableP
            // 
            this.coldsIronInfoL3DataTableP.Caption = "P";
            this.coldsIronInfoL3DataTableP.ColumnName = "P";
            this.coldsIronInfoL3DataTableP.DataType = typeof(float);
            this.coldsIronInfoL3DataTableP.Namespace = "";
            // 
            // coldsIronInfoL3DataTableS
            // 
            this.coldsIronInfoL3DataTableS.Caption = "S";
            this.coldsIronInfoL3DataTableS.ColumnName = "S";
            this.coldsIronInfoL3DataTableS.DataType = typeof(float);
            this.coldsIronInfoL3DataTableS.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTi
            // 
            this.coldsIronInfoL3DataTableTi.Caption = "Ti";
            this.coldsIronInfoL3DataTableTi.ColumnName = "Ti";
            this.coldsIronInfoL3DataTableTi.DataType = typeof(float);
            this.coldsIronInfoL3DataTableTi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronTemp
            // 
            this.coldsIronInfoL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsIronInfoL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsIronInfoL3DataTableIronTemp.DataType = typeof(int);
            this.coldsIronInfoL3DataTableIronTemp.Namespace = "";
            // 
            // coldsIronInfoL3DataTableHeatID
            // 
            this.coldsIronInfoL3DataTableHeatID.Caption = "HeatID";
            this.coldsIronInfoL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsIronInfoL3DataTableHeatID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSource
            // 
            this.coldsIronInfoL3DataTableSource.Caption = "Source";
            this.coldsIronInfoL3DataTableSource.ColumnName = "Source";
            this.coldsIronInfoL3DataTableSource.DataType = typeof(int);
            this.coldsIronInfoL3DataTableSource.Namespace = "";
            // 
            // coldsIronInfoL3DataTableShift
            // 
            this.coldsIronInfoL3DataTableShift.Caption = "Shift";
            this.coldsIronInfoL3DataTableShift.ColumnName = "Shift";
            this.coldsIronInfoL3DataTableShift.DataType = typeof(bool);
            this.coldsIronInfoL3DataTableShift.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTeam
            // 
            this.coldsIronInfoL3DataTableTeam.Caption = "Team";
            this.coldsIronInfoL3DataTableTeam.ColumnName = "Team";
            this.coldsIronInfoL3DataTableTeam.DataType = typeof(bool);
            this.coldsIronInfoL3DataTableTeam.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOperator
            // 
            this.coldsIronInfoL3DataTableOperator.Caption = "Operator";
            this.coldsIronInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsIronInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTare
            // 
            this.coldsIronInfoL3DataTableTare.Caption = "Tare";
            this.coldsIronInfoL3DataTableTare.ColumnName = "Tare";
            this.coldsIronInfoL3DataTableTare.DataType = typeof(double);
            this.coldsIronInfoL3DataTableTare.Namespace = "";
            // 
            // coldsIronInfoL3DataTableGross_Weight
            // 
            this.coldsIronInfoL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsIronInfoL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTap_Time
            // 
            this.coldsIronInfoL3DataTableTap_Time.Caption = "Tap_Time";
            this.coldsIronInfoL3DataTableTap_Time.ColumnName = "Tap_Time";
            this.coldsIronInfoL3DataTableTap_Time.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableTap_Time.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronLadleNo
            // 
            this.coldsIronInfoL3DataTableIronLadleNo.Caption = "IronLadleNo";
            this.coldsIronInfoL3DataTableIronLadleNo.ColumnName = "IronLadleNo";
            this.coldsIronInfoL3DataTableIronLadleNo.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject1
            // 
            this.coldsIronInfoL3DataTableObject1.Caption = "Object1";
            this.coldsIronInfoL3DataTableObject1.ColumnName = "Object1";
            this.coldsIronInfoL3DataTableObject1.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight1
            // 
            this.coldsIronInfoL3DataTableWeight1.Caption = "Weight1";
            this.coldsIronInfoL3DataTableWeight1.ColumnName = "Weight1";
            this.coldsIronInfoL3DataTableWeight1.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight1.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject2
            // 
            this.coldsIronInfoL3DataTableObject2.Caption = "Object2";
            this.coldsIronInfoL3DataTableObject2.ColumnName = "Object2";
            this.coldsIronInfoL3DataTableObject2.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight2
            // 
            this.coldsIronInfoL3DataTableWeight2.Caption = "Weight2";
            this.coldsIronInfoL3DataTableWeight2.ColumnName = "Weight2";
            this.coldsIronInfoL3DataTableWeight2.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight2.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject3
            // 
            this.coldsIronInfoL3DataTableObject3.Caption = "Object3";
            this.coldsIronInfoL3DataTableObject3.ColumnName = "Object3";
            this.coldsIronInfoL3DataTableObject3.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight3
            // 
            this.coldsIronInfoL3DataTableWeight3.Caption = "Weight3";
            this.coldsIronInfoL3DataTableWeight3.ColumnName = "Weight3";
            this.coldsIronInfoL3DataTableWeight3.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight3.Namespace = "";
            // 
            // coldsIronInfoL3DataTableReturn_Steel_Weight
            // 
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.DataType = typeof(float);
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIsDes
            // 
            this.coldsIronInfoL3DataTableIsDes.Caption = "IsDes";
            this.coldsIronInfoL3DataTableIsDes.ColumnName = "IsDes";
            this.coldsIronInfoL3DataTableIsDes.DataType = typeof(float);
            this.coldsIronInfoL3DataTableIsDes.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSn
            // 
            this.coldsIronInfoL3DataTableSn.Caption = "Sn";
            this.coldsIronInfoL3DataTableSn.ColumnName = "Sn";
            this.coldsIronInfoL3DataTableSn.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSb
            // 
            this.coldsIronInfoL3DataTableSb.Caption = "Sb";
            this.coldsIronInfoL3DataTableSb.ColumnName = "Sb";
            this.coldsIronInfoL3DataTableSb.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableAs
            // 
            this.coldsIronInfoL3DataTableAs.Caption = "As";
            this.coldsIronInfoL3DataTableAs.ColumnName = "As";
            this.coldsIronInfoL3DataTableAs.DataType = typeof(float);
            this.coldsIronInfoL3DataTableAs.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePb
            // 
            this.coldsIronInfoL3DataTablePb.Caption = "Pb";
            this.coldsIronInfoL3DataTablePb.ColumnName = "Pb";
            this.coldsIronInfoL3DataTablePb.DataType = typeof(float);
            this.coldsIronInfoL3DataTablePb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSELECTID
            // 
            this.coldsIronInfoL3DataTableSELECTID.Caption = "SELECTID";
            this.coldsIronInfoL3DataTableSELECTID.ColumnName = "SELECTID";
            this.coldsIronInfoL3DataTableSELECTID.DataType = typeof(short);
            this.coldsIronInfoL3DataTableSELECTID.Namespace = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHeatID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 40);
            this.panel1.TabIndex = 2;
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataFormat = null;
            this.txtHeatID.DataObject = "XGMESLogic\\\\BOFMag\\\\CBOF_Unit_Mag\\\\{BOFID}";
            this.txtHeatID.DataProperty = "HeatID";
            this.txtHeatID.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeatID.L3DataAdapter = this.Adapter;
            this.txtHeatID.Location = new System.Drawing.Point(61, 9);
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.ReadOnly = true;
            this.txtHeatID.Size = new System.Drawing.Size(136, 21);
            this.txtHeatID.TabIndex = 1;
            this.txtHeatID.Value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 264);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(983, 237);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvScrapSteel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 237);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "废钢信息";
            // 
            // dvScrapSteel
            // 
            this.dvScrapSteel.AllowUserToAddRows = false;
            this.dvScrapSteel.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvScrapSteel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvScrapSteel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvScrapSteel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn1,
            this.scrapSlotIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.ScrapWT,
            this.PigIronWT});
            this.dvScrapSteel.DataSource = this.bsScrapSteel;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvScrapSteel.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvScrapSteel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvScrapSteel.Location = new System.Drawing.Point(3, 17);
            this.dvScrapSteel.Name = "dvScrapSteel";
            this.dvScrapSteel.RowHeadersVisible = false;
            this.dvScrapSteel.RowTemplate.Height = 23;
            this.dvScrapSteel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvScrapSteel.Size = new System.Drawing.Size(495, 217);
            this.dvScrapSteel.TabIndex = 0;
            this.dvScrapSteel.CurrentCellChanged += new System.EventHandler(this.dvScrapSteel_CurrentCellChanged);
            this.dvScrapSteel.Click += new System.EventHandler(this.dvScrapSteel_Click);
            // 
            // bsScrapSteel
            // 
            this.bsScrapSteel.DataMember = "L3DataTable";
            this.bsScrapSteel.DataSource = this.dsScrapSteel;
            // 
            // dsScrapSteel
            // 
            this.dsScrapSteel.AutoLoad = true;
            this.dsScrapSteel.AutoSubscribe = false;
            this.dsScrapSteel.DataSetName = "L3DataSet";
            this.dsScrapSteel.DeleteMethod = "";
            this.dsScrapSteel.InsertMethod = "";
            this.dsScrapSteel.L3DataAdapter = this.Adapter;
            this.dsScrapSteel.LoadEvent = "";
            this.dsScrapSteel.LoadTrigger = null;
            this.dsScrapSteel.RefreshValve = 1000;
            this.dsScrapSteel.SourceCommand = null;
            this.dsScrapSteel.SourceCondition = "";
            this.dsScrapSteel.SourceMethod = "GetScrapesForDesignate";
            this.dsScrapSteel.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsScrapSteel.SourceURI = "XGMESLogic\\\\BOFMag\\\\CBOF_Unit_Mag\\\\{BOFID}";
            this.dsScrapSteel.SubscribeTarget = "";
            this.dsScrapSteel.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapSteel});
            this.dsScrapSteel.UpdateEvent = "";
            this.dsScrapSteel.UpdateMethod = "";
            this.dsScrapSteel.UpdateTrigger = null;
            // 
            // schemadsScrapSteel
            // 
            this.schemadsScrapSteel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapSteelL3DataTableAmount,
            this.coldsScrapSteelL3DataTableScrap_Slot_ID,
            this.coldsScrapSteelL3DataTableCheckFlag,
            this.coldsScrapSteelL3DataTableScrapWT,
            this.coldsScrapSteelL3DataTablePigIronWT,
            this.coldsScrapSteelL3DataTableHEATID});
            this.schemadsScrapSteel.TableName = "L3DataTable";
            // 
            // coldsScrapSteelL3DataTableAmount
            // 
            this.coldsScrapSteelL3DataTableAmount.Caption = "Amount";
            this.coldsScrapSteelL3DataTableAmount.ColumnName = "Amount";
            this.coldsScrapSteelL3DataTableAmount.DataType = typeof(double);
            this.coldsScrapSteelL3DataTableAmount.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableScrap_Slot_ID
            // 
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.Caption = "Scrap_Slot_ID";
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableCheckFlag
            // 
            this.coldsScrapSteelL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsScrapSteelL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsScrapSteelL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsScrapSteelL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableScrapWT
            // 
            this.coldsScrapSteelL3DataTableScrapWT.Caption = "ScrapWT";
            this.coldsScrapSteelL3DataTableScrapWT.ColumnName = "ScrapWT";
            this.coldsScrapSteelL3DataTableScrapWT.DataType = typeof(double);
            this.coldsScrapSteelL3DataTableScrapWT.Namespace = "";
            // 
            // coldsScrapSteelL3DataTablePigIronWT
            // 
            this.coldsScrapSteelL3DataTablePigIronWT.Caption = "PigIronWT";
            this.coldsScrapSteelL3DataTablePigIronWT.ColumnName = "PigIronWT";
            this.coldsScrapSteelL3DataTablePigIronWT.DataType = typeof(double);
            this.coldsScrapSteelL3DataTablePigIronWT.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableHEATID
            // 
            this.coldsScrapSteelL3DataTableHEATID.Caption = "HEATID";
            this.coldsScrapSteelL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsScrapSteelL3DataTableHEATID.Namespace = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(3, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 78);
            this.groupBox4.TabIndex = 85;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "生铁";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1,
            this.Code_Des,
            this.aMOUNTDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bsST;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(425, 44);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsST
            // 
            this.bsST.DataMember = "L3DataTable";
            this.bsST.DataSource = this.dsST;
            // 
            // dsST
            // 
            this.dsST.AutoLoad = true;
            this.dsST.AutoSubscribe = true;
            this.dsST.DataSetName = "L3DataSet";
            this.dsST.DeleteMethod = null;
            this.dsST.InsertMethod = null;
            this.dsST.L3DataAdapter = this.Adapter;
            this.dsST.LoadEvent = "Click";
            this.dsST.LoadTrigger = null;
            this.dsST.RefreshValve = 1000;
            this.dsST.SourceCommand = null;
            this.dsST.SourceCondition = "";
            this.dsST.SourceMethod = "";
            this.dsST.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsST.SourceURI = "";
            this.dsST.SubscribeTarget = null;
            this.dsST.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsST});
            this.dsST.UpdateEvent = "Click";
            this.dsST.UpdateMethod = null;
            this.dsST.UpdateTrigger = null;
            // 
            // schemadsST
            // 
            this.schemadsST.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSTL3DataTableSCRAP_SLOT_ID,
            this.AAcoldsSTL3DataTableAMOUNT,
            this.coldsSTL3DataTableCode_Des});
            this.schemadsST.TableName = "L3DataTable";
            // 
            // coldsSTL3DataTableSCRAP_SLOT_ID
            // 
            this.coldsSTL3DataTableSCRAP_SLOT_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsSTL3DataTableSCRAP_SLOT_ID.ColumnName = "SCRAP_SLOT_ID";
            this.coldsSTL3DataTableSCRAP_SLOT_ID.Namespace = "";
            // 
            // AAcoldsSTL3DataTableAMOUNT
            // 
            this.AAcoldsSTL3DataTableAMOUNT.Caption = "AMOUNT";
            this.AAcoldsSTL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.AAcoldsSTL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsSTL3DataTableCode_Des
            // 
            this.coldsSTL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSTL3DataTableCode_Des.Namespace = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(3, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 78);
            this.groupBox5.TabIndex = 84;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "废钢";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 237);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "不经过混铁炉回炉钢信息";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "回炉钢水量[t]:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAssign);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 63);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(839, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(747, 27);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "指定";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // bsFGST
            // 
            this.bsFGST.DataMember = "L3DataTable";
            this.bsFGST.DataSource = this.dsFGST;
            // 
            // dsFGST
            // 
            this.dsFGST.AutoLoad = true;
            this.dsFGST.AutoSubscribe = false;
            this.dsFGST.DataSetName = "L3DataSet";
            this.dsFGST.DeleteMethod = null;
            this.dsFGST.InsertMethod = null;
            this.dsFGST.L3DataAdapter = this.Adapter;
            this.dsFGST.LoadEvent = "Click";
            this.dsFGST.LoadTrigger = null;
            this.dsFGST.RefreshValve = 1000;
            this.dsFGST.SourceCommand = null;
            this.dsFGST.SourceCondition = "";
            this.dsFGST.SourceMethod = "";
            this.dsFGST.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFGST.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFGST.SubscribeTarget = null;
            this.dsFGST.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFGST});
            this.dsFGST.UpdateEvent = "Click";
            this.dsFGST.UpdateMethod = null;
            this.dsFGST.UpdateTrigger = null;
            // 
            // schemadsFGST
            // 
            this.schemadsFGST.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFGSTL3DataTableCode,
            this.AAcoldsFGSTL3DataTableCode_Des});
            this.schemadsFGST.TableName = "L3DataTable";
            // 
            // coldsFGSTL3DataTableCode
            // 
            this.coldsFGSTL3DataTableCode.Caption = "Code";
            this.coldsFGSTL3DataTableCode.ColumnName = "Code";
            this.coldsFGSTL3DataTableCode.Namespace = "";
            // 
            // AAcoldsFGSTL3DataTableCode_Des
            // 
            this.AAcoldsFGSTL3DataTableCode_Des.Caption = "Code_Des";
            this.AAcoldsFGSTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.AAcoldsFGSTL3DataTableCode_Des.Namespace = "";
            // 
            // bsFG
            // 
            this.bsFG.DataMember = "L3DataTable";
            this.bsFG.DataSource = this.dsFG;
            // 
            // dsFG
            // 
            this.dsFG.AutoLoad = true;
            this.dsFG.AutoSubscribe = true;
            this.dsFG.DataSetName = "L3DataSet";
            this.dsFG.DeleteMethod = null;
            this.dsFG.InsertMethod = null;
            this.dsFG.L3DataAdapter = this.Adapter;
            this.dsFG.LoadEvent = "Click";
            this.dsFG.LoadTrigger = null;
            this.dsFG.RefreshValve = 1000;
            this.dsFG.SourceCommand = null;
            this.dsFG.SourceCondition = "";
            this.dsFG.SourceMethod = "";
            this.dsFG.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFG.SourceURI = "";
            this.dsFG.SubscribeTarget = null;
            this.dsFG.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFG});
            this.dsFG.UpdateEvent = "Click";
            this.dsFG.UpdateMethod = null;
            this.dsFG.UpdateTrigger = null;
            // 
            // schemadsFG
            // 
            this.schemadsFG.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFGL3DataTableSCRAP_SLOT_ID,
            this.coldsFGL3DataTableMATERIAL_CODE,
            this.coldsFGL3DataTableAMOUNT,
            this.coldsFGL3DataTableCode_Des});
            this.schemadsFG.TableName = "L3DataTable";
            // 
            // coldsFGL3DataTableSCRAP_SLOT_ID
            // 
            this.coldsFGL3DataTableSCRAP_SLOT_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsFGL3DataTableSCRAP_SLOT_ID.ColumnName = "SCRAP_SLOT_ID";
            this.coldsFGL3DataTableSCRAP_SLOT_ID.Namespace = "";
            // 
            // coldsFGL3DataTableMATERIAL_CODE
            // 
            this.coldsFGL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.coldsFGL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.coldsFGL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // coldsFGL3DataTableAMOUNT
            // 
            this.coldsFGL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsFGL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsFGL3DataTableAMOUNT.Namespace = "";
            // 
            // dsReturnSteel
            // 
            this.dsReturnSteel.AutoLoad = true;
            this.dsReturnSteel.AutoSubscribe = false;
            this.dsReturnSteel.DataSetName = "L3DataSet";
            this.dsReturnSteel.DeleteMethod = "";
            this.dsReturnSteel.InsertMethod = "";
            this.dsReturnSteel.L3DataAdapter = null;
            this.dsReturnSteel.LoadEvent = "";
            this.dsReturnSteel.LoadTrigger = null;
            this.dsReturnSteel.RefreshValve = 1000;
            this.dsReturnSteel.SourceCommand = null;
            this.dsReturnSteel.SourceCondition = "";
            this.dsReturnSteel.SourceMethod = "";
            this.dsReturnSteel.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsReturnSteel.SourceURI = "XGMESLogic\\\\BOFMag\\\\CBOF_Unit_Mag\\\\{BOFID}";
            this.dsReturnSteel.SubscribeTarget = "";
            this.dsReturnSteel.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReturnSteel});
            this.dsReturnSteel.UpdateEvent = "";
            this.dsReturnSteel.UpdateMethod = "";
            this.dsReturnSteel.UpdateTrigger = null;
            // 
            // schemadsReturnSteel
            // 
            this.schemadsReturnSteel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReturnSteelL3DataTableHeatID,
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight,
            this.coldsReturnSteelL3DataTableReturn_SteelGrade});
            this.schemadsReturnSteel.TableName = "L3DataTable";
            // 
            // coldsReturnSteelL3DataTableHeatID
            // 
            this.coldsReturnSteelL3DataTableHeatID.Caption = "HeatID";
            this.coldsReturnSteelL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsReturnSteelL3DataTableHeatID.Namespace = "";
            // 
            // coldsReturnSteelL3DataTableReturn_Steel_Weight
            // 
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.DataType = typeof(double);
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsReturnSteelL3DataTableReturn_SteelGrade
            // 
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.Caption = "Return_SteelGrade";
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.ColumnName = "Return_SteelGrade";
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.Namespace = "";
            // 
            // cmdDesignateMainMat
            // 
            this.cmdDesignateMainMat.Adapter = this.Adapter;
            this.cmdDesignateMainMat.MergeReturnTarget = false;
            this.cmdDesignateMainMat.Method = "DesignateMainMaterial";
            this.cmdDesignateMainMat.Object = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.cmdDesignateMainMat.Parameters.Add(this.cmdPar1);
            this.cmdDesignateMainMat.Parameters.Add(this.cmdPar2);
            this.cmdDesignateMainMat.Parameters.Add(this.cmdPar3);
            this.cmdDesignateMainMat.ReturnTarget = null;
            this.cmdDesignateMainMat.ReturnTargetProperty = null;
            this.cmdDesignateMainMat.Trigger = null;
            this.cmdDesignateMainMat.TriggerEvent = "Click";
            // 
            // cmdPar1
            // 
            this.cmdPar1.AcceptAfterExecuted = false;
            this.cmdPar1.ConstantValue = null;
            this.cmdPar1.MergeTarget = false;
            this.cmdPar1.SourceFilter = "SELECTID=true";
            this.cmdPar1.SourceObject = this.dsIronInfo;
            this.cmdPar1.SourceProperty = "L3DataTable";
            this.cmdPar1.TargetObject = null;
            this.cmdPar1.TargetProperty = null;
            // 
            // cmdPar2
            // 
            this.cmdPar2.AcceptAfterExecuted = false;
            this.cmdPar2.ConstantValue = null;
            this.cmdPar2.MergeTarget = false;
            this.cmdPar2.SourceFilter = null;
            this.cmdPar2.SourceObject = this.dsReturnSteel;
            this.cmdPar2.SourceProperty = "L3DataTable";
            this.cmdPar2.TargetObject = null;
            this.cmdPar2.TargetProperty = null;
            // 
            // cmdPar3
            // 
            this.cmdPar3.AcceptAfterExecuted = false;
            this.cmdPar3.ConstantValue = null;
            this.cmdPar3.MergeTarget = false;
            this.cmdPar3.SourceFilter = "CheckFlag=true";
            this.cmdPar3.SourceObject = this.dsScrapSteel;
            this.cmdPar3.SourceProperty = "L3DataTable";
            this.cmdPar3.TargetObject = null;
            this.cmdPar3.TargetProperty = null;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaterialID";
            this.dataGridViewTextBoxColumn2.HeaderText = "材料号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IronLadleNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "铁包号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Return_Steel_Weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "回炉钢水量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn5.HeaderText = "铁水重量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QAStatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "QAStatus";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QALevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "QALevel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 72;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OrderContractID";
            this.dataGridViewTextBoxColumn10.HeaderText = "OrderContractID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProduceContractID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ProduceContractID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 132;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SalesContractID";
            this.dataGridViewTextBoxColumn12.HeaderText = "SalesContractID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn13.HeaderText = "C";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 36;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn14.HeaderText = "Si";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 42;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn15.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 42;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn16.HeaderText = "P";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 36;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn17.HeaderText = "S";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 36;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 42;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn19.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 42;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn20.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 42;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn21.HeaderText = "As";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 42;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn22.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 42;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "IronTemp";
            this.dataGridViewTextBoxColumn23.HeaderText = "铁水温度";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 78;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn24.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 54;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn25.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            this.dataGridViewTextBoxColumn25.Width = 78;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Tare";
            this.dataGridViewTextBoxColumn26.HeaderText = "皮重";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 54;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Gross_Weight";
            this.dataGridViewTextBoxColumn27.HeaderText = "毛重";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 54;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Object1";
            this.dataGridViewTextBoxColumn28.HeaderText = "Object1";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Visible = false;
            this.dataGridViewTextBoxColumn28.Width = 72;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Weight1";
            this.dataGridViewTextBoxColumn29.HeaderText = "Weight1";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Visible = false;
            this.dataGridViewTextBoxColumn29.Width = 72;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Object2";
            this.dataGridViewTextBoxColumn30.HeaderText = "Object2";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Visible = false;
            this.dataGridViewTextBoxColumn30.Width = 72;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Weight2";
            this.dataGridViewTextBoxColumn31.HeaderText = "Weight2";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Visible = false;
            this.dataGridViewTextBoxColumn31.Width = 72;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Object3";
            this.dataGridViewTextBoxColumn32.HeaderText = "Object3";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Visible = false;
            this.dataGridViewTextBoxColumn32.Width = 72;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Weight3";
            this.dataGridViewTextBoxColumn33.HeaderText = "Weight3";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Visible = false;
            this.dataGridViewTextBoxColumn33.Width = 72;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "IsDes";
            this.dataGridViewTextBoxColumn34.HeaderText = "IsDes";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 60;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Scrap_Slot_ID";
            this.dataGridViewTextBoxColumn35.HeaderText = "废钢斗号";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn36.HeaderText = "重量[T]";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ScrapWT";
            this.dataGridViewTextBoxColumn37.HeaderText = "废钢[T]";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "PigIronWT";
            this.dataGridViewTextBoxColumn38.HeaderText = "生铁[T]";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // coldsFGSTL3DataTableCode_Des
            // 
            this.coldsFGSTL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFGSTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFGSTL3DataTableCode_Des.Namespace = "";
            // 
            // coldsSTL3DataTableMATERIAL
            // 
            this.coldsSTL3DataTableMATERIAL.Caption = "MATERIAL";
            this.coldsSTL3DataTableMATERIAL.ColumnName = "MATERIAL";
            this.coldsSTL3DataTableMATERIAL.Namespace = "";
            // 
            // coldsSTL3DataTableMATERIAL_CODE
            // 
            this.coldsSTL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.coldsSTL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.coldsSTL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // coldsSTL3DataTableAMOUNT
            // 
            this.coldsSTL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsSTL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsSTL3DataTableAMOUNT.Namespace = "";
            // 
            // AcoldsFGSTL3DataTableCode_Des
            // 
            this.AcoldsFGSTL3DataTableCode_Des.Caption = "Code_Des";
            this.AcoldsFGSTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.AcoldsFGSTL3DataTableCode_Des.Namespace = "";
            // 
            // AcoldsSTL3DataTableMATERIAL_CODE
            // 
            this.AcoldsSTL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.AcoldsSTL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.AcoldsSTL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // AcoldsSTL3DataTableAMOUNT
            // 
            this.AcoldsSTL3DataTableAMOUNT.Caption = "AMOUNT";
            this.AcoldsSTL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.AcoldsSTL3DataTableAMOUNT.Namespace = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41});
            this.dataGridView2.DataSource = this.bsFG;
            this.dataGridView2.Location = new System.Drawing.Point(6, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(425, 43);
            this.dataGridView2.TabIndex = 1;
            // 
            // coldsFGL3DataTableCode_Des
            // 
            this.coldsFGL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFGL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFGL3DataTableCode_Des.Namespace = "";
            // 
            // sCRAPSLOTIDDataGridViewTextBoxColumn1
            // 
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.DataPropertyName = "SCRAP_SLOT_ID";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.HeaderText = "废钢斗号";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.Name = "sCRAPSLOTIDDataGridViewTextBoxColumn1";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.Width = 130;
            // 
            // Code_Des
            // 
            this.Code_Des.DataPropertyName = "Code_Des";
            this.Code_Des.HeaderText = "生铁名称";
            this.Code_Des.Name = "Code_Des";
            this.Code_Des.ReadOnly = true;
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn1.HeaderText = "生铁重量";
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            this.aMOUNTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "SCRAP_SLOT_ID";
            this.dataGridViewTextBoxColumn39.HeaderText = "废钢斗号";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 130;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Code_Des";
            this.dataGridViewTextBoxColumn40.HeaderText = "废钢名称";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "AMOUNT";
            this.dataGridViewTextBoxColumn41.HeaderText = "生铁重量";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // checkFlagDataGridViewTextBoxColumn1
            // 
            this.checkFlagDataGridViewTextBoxColumn1.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn1.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn1.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn1.IndeterminateValue = "0";
            this.checkFlagDataGridViewTextBoxColumn1.Name = "checkFlagDataGridViewTextBoxColumn1";
            this.checkFlagDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn1.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn1.Width = 50;
            // 
            // scrapSlotIDDataGridViewTextBoxColumn
            // 
            this.scrapSlotIDDataGridViewTextBoxColumn.DataPropertyName = "Scrap_Slot_ID";
            this.scrapSlotIDDataGridViewTextBoxColumn.HeaderText = "废钢斗号";
            this.scrapSlotIDDataGridViewTextBoxColumn.Name = "scrapSlotIDDataGridViewTextBoxColumn";
            this.scrapSlotIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "重量[T]";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // ScrapWT
            // 
            this.ScrapWT.DataPropertyName = "ScrapWT";
            this.ScrapWT.HeaderText = "废钢[T]";
            this.ScrapWT.Name = "ScrapWT";
            // 
            // PigIronWT
            // 
            this.PigIronWT.DataPropertyName = "PigIronWT";
            this.PigIronWT.HeaderText = "生铁[T]";
            this.PigIronWT.Name = "PigIronWT";
            // 
            // NewDesignateMaterialFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "NewDesignateMaterialFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "指定主原料";
            this.Load += new System.EventHandler(this.NewDesignateMaterialFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSteel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsST)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturnSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvIronInfo;
        private AppSvrHMI.L3DataBox txtHeatID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvScrapSteel;
        private System.Windows.Forms.GroupBox groupBox3;
        private AppSvrHMI.L3DataSet dsIronInfo;
        private AppSvrHMI.L3DataSet dsScrapSteel;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsReturnSteel;
        private System.Data.DataTable schemadsIronInfo;
        private System.Data.DataColumn coldsIronInfoL3DataTableName;
        private System.Data.DataColumn coldsIronInfoL3DataTableMaterialID;
        private System.Data.DataColumn coldsIronInfoL3DataTableStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTablePosition;
        private System.Data.DataColumn coldsIronInfoL3DataTableQAStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTableQALevel;
        private System.Data.DataColumn coldsIronInfoL3DataTableOrderContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableProduceContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableSalesContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight;
        private System.Data.DataColumn coldsIronInfoL3DataTableC;
        private System.Data.DataColumn coldsIronInfoL3DataTableSi;
        private System.Data.DataColumn coldsIronInfoL3DataTableMn;
        private System.Data.DataColumn coldsIronInfoL3DataTableP;
        private System.Data.DataColumn coldsIronInfoL3DataTableS;
        private System.Data.DataColumn coldsIronInfoL3DataTableTi;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronTemp;
        private System.Data.DataColumn coldsIronInfoL3DataTableHeatID;
        private System.Data.DataColumn coldsIronInfoL3DataTableSource;
        private System.Data.DataColumn coldsIronInfoL3DataTableShift;
        private System.Data.DataColumn coldsIronInfoL3DataTableTeam;
        private System.Data.DataColumn coldsIronInfoL3DataTableOperator;
        private System.Data.DataColumn coldsIronInfoL3DataTableTare;
        private System.Data.DataColumn coldsIronInfoL3DataTableGross_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableTap_Time;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronLadleNo;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject1;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight1;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject2;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight2;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject3;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight3;
        private System.Data.DataColumn coldsIronInfoL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableIsDes;
        private System.Data.DataTable schemadsScrapSteel;
        private System.Data.DataColumn coldsScrapSteelL3DataTableAmount;
        private System.Data.DataColumn coldsScrapSteelL3DataTableScrap_Slot_ID;
        private System.Data.DataColumn coldsScrapSteelL3DataTableCheckFlag;
        private System.Data.DataTable schemadsReturnSteel;
        private System.Data.DataColumn coldsReturnSteelL3DataTableHeatID;
        private System.Data.DataColumn coldsReturnSteelL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsReturnSteelL3DataTableReturn_SteelGrade;
        private System.Windows.Forms.BindingSource bsIronInfo;
        private System.Windows.Forms.BindingSource bsScrapSteel;
        private System.Windows.Forms.Label label2;
       // private PxDataValid.PxTextBox pxTextBox1;
        private System.Data.DataColumn coldsIronInfoL3DataTableSn;
        private System.Data.DataColumn coldsIronInfoL3DataTableSb;
        private System.Data.DataColumn coldsIronInfoL3DataTableAs;
        private System.Data.DataColumn coldsIronInfoL3DataTablePb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAssign;
        private AppSvrHMI.L3Command cmdDesignateMainMat;
        private AppSvrHMI.L3CommandParameter cmdPar1;
        private AppSvrHMI.L3CommandParameter cmdPar2;
        private AppSvrHMI.L3CommandParameter cmdPar3;
        private System.Data.DataColumn coldsScrapSteelL3DataTableScrapWT;
        private System.Data.DataColumn coldsScrapSteelL3DataTablePigIronWT;
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
        //private PxDataValid.PxTextBox txtRetAmount;
        private System.Data.DataColumn coldsScrapSteelL3DataTableHEATID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataColumn coldsIronInfoL3DataTableSELECTID;
        private AppSvrHMI.L3DataSet dsIronMode;
        private System.Data.DataTable schemadsIronMode;
        private System.Data.DataColumn coldsIronModeL3DataTableName;
        private System.Data.DataColumn coldsIronModeL3DataTableCode;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Group;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Function_Group;
        private System.Data.DataColumn coldsIronModeL3DataTableNC_Code;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn shiftDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironLadleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnSteelWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesContractIDDataGridViewTextBoxColumn;
        private DataGridValid.DataGridViewValidateCellColumn tapTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private AppSvrHMI.L3DataSet dsFGST;
        private System.Windows.Forms.BindingSource bsFG;
        private AppSvrHMI.L3DataSet dsFG;
        private System.Windows.Forms.BindingSource bsST;
        private System.Data.DataTable schemadsFGST;
        private System.Data.DataColumn coldsFGSTL3DataTableCode;
        private System.Data.DataColumn coldsFGSTL3DataTableCode_Des;
        private System.Data.DataTable schemadsFG;
        private System.Data.DataColumn coldsFGL3DataTableSCRAP_SLOT_ID;
        private System.Data.DataColumn coldsFGL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn coldsFGL3DataTableAMOUNT;
        private System.Data.DataColumn coldsSTL3DataTableMATERIAL;
        private System.Data.DataColumn coldsSTL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn coldsSTL3DataTableAMOUNT;
        private System.Data.DataColumn AcoldsFGSTL3DataTableCode_Des;
        private System.Data.DataColumn AAcoldsFGSTL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsFGST;
        private System.Data.DataColumn AcoldsSTL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn AcoldsSTL3DataTableAMOUNT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppSvrHMI.L3DataSet dsST;
        private System.Data.DataTable schemadsST;
        private System.Data.DataColumn coldsSTL3DataTableSCRAP_SLOT_ID;
        private System.Data.DataColumn AAcoldsSTL3DataTableAMOUNT;
        private System.Data.DataColumn coldsSTL3DataTableCode_Des;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.DataColumn coldsFGL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapSlotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PigIronWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRAPSLOTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
    }
}