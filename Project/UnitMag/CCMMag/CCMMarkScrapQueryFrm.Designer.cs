namespace UnitMag.CCMMag
{
    partial class CCMMarkScrapQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCMMarkScrapQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.wasterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloomCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.wasterCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Waster_Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWaster = new System.Windows.Forms.BindingSource(this.components);
            this.dsWaster = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsOutStoreL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableLength = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWidth = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableThickness = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsWasterL3DataTableProduce_Date = new System.Data.DataColumn();
            this.coldsWasterL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsWasterL3DataTableCut_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Operator = new System.Data.DataColumn();
            this.coldsWasterL3DataTableWaster_Date = new System.Data.DataColumn();
            this.coldsWasterL3DataTableShitID = new System.Data.DataColumn();
            this.coldsWasterL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsWasterL3DataTableCasterID = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtOutStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtOutStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dsBloomArea = new AppSvrHMI.L3DataSet();
            this.schemadsBloomArea = new System.Data.DataTable();
            this.coldsBloomAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBloomAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(940, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wasterDateDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.cutSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.calWeightDataGridViewTextBoxColumn,
            this.wasterWeightDataGridViewTextBoxColumn,
            this.bloomCountDataGridViewTextBoxColumn,
            this.wasterCountDataGridViewTextBoxColumn,
            this.produceDateDataGridViewTextBoxColumn,
            this.wasterCount1DataGridViewTextBoxColumn,
            this.wasterWeight1DataGridViewTextBoxColumn,
            this.wasterReason1DataGridViewTextBoxColumn,
            this.wasterCount2DataGridViewTextBoxColumn,
            this.wasterWeight2DataGridViewTextBoxColumn,
            this.wasterReason2DataGridViewTextBoxColumn,
            this.wasterCount3DataGridViewTextBoxColumn,
            this.wasterWeight3DataGridViewTextBoxColumn,
            this.wasterReason3DataGridViewTextBoxColumn,
            this.Waster_Operator,
            this.shitIDDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsWaster;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(940, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // wasterDateDataGridViewTextBoxColumn
            // 
            this.wasterDateDataGridViewTextBoxColumn.DataPropertyName = "Waster_Date";
            this.wasterDateDataGridViewTextBoxColumn.Frozen = true;
            this.wasterDateDataGridViewTextBoxColumn.HeaderText = "甩废日期";
            this.wasterDateDataGridViewTextBoxColumn.Name = "wasterDateDataGridViewTextBoxColumn";
            this.wasterDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cutSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Cut_SteelGradeIndex";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Name = "cutSteelGradeIndexDataGridViewTextBoxColumn";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度[mm]";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度[mm]";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度[mm]";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calWeightDataGridViewTextBoxColumn
            // 
            this.calWeightDataGridViewTextBoxColumn.DataPropertyName = "Cal_Weight";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.calWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.calWeightDataGridViewTextBoxColumn.HeaderText = "理论重量[t]";
            this.calWeightDataGridViewTextBoxColumn.Name = "calWeightDataGridViewTextBoxColumn";
            this.calWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeightDataGridViewTextBoxColumn
            // 
            this.wasterWeightDataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.wasterWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.wasterWeightDataGridViewTextBoxColumn.HeaderText = "甩废总重量[t]";
            this.wasterWeightDataGridViewTextBoxColumn.Name = "wasterWeightDataGridViewTextBoxColumn";
            this.wasterWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloomCountDataGridViewTextBoxColumn
            // 
            this.bloomCountDataGridViewTextBoxColumn.DataPropertyName = "Bloom_Count";
            this.bloomCountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bloomCountDataGridViewTextBoxColumn.Name = "bloomCountDataGridViewTextBoxColumn";
            this.bloomCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterCountDataGridViewTextBoxColumn
            // 
            this.wasterCountDataGridViewTextBoxColumn.DataPropertyName = "Waster_Count";
            this.wasterCountDataGridViewTextBoxColumn.HeaderText = "甩废长度[m]";
            this.wasterCountDataGridViewTextBoxColumn.Name = "wasterCountDataGridViewTextBoxColumn";
            this.wasterCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produceDateDataGridViewTextBoxColumn
            // 
            this.produceDateDataGridViewTextBoxColumn.DataPropertyName = "Produce_Date";
            this.produceDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.produceDateDataGridViewTextBoxColumn.Name = "produceDateDataGridViewTextBoxColumn";
            this.produceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterCount1DataGridViewTextBoxColumn
            // 
            this.wasterCount1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count1";
            this.wasterCount1DataGridViewTextBoxColumn.HeaderText = "甩废长度1[m]";
            this.wasterCount1DataGridViewTextBoxColumn.Name = "wasterCount1DataGridViewTextBoxColumn";
            this.wasterCount1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight1DataGridViewTextBoxColumn
            // 
            this.wasterWeight1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight1";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.wasterWeight1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.wasterWeight1DataGridViewTextBoxColumn.HeaderText = "甩废重量1[t]";
            this.wasterWeight1DataGridViewTextBoxColumn.Name = "wasterWeight1DataGridViewTextBoxColumn";
            this.wasterWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterReason1DataGridViewTextBoxColumn
            // 
            this.wasterReason1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason1";
            this.wasterReason1DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wasterReason1DataGridViewTextBoxColumn.Name = "wasterReason1DataGridViewTextBoxColumn";
            this.wasterReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = "";
            this.dsWasterReason.InsertMethod = "";
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "";
            this.dsWasterReason.UpdateMethod = "";
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // wasterCount2DataGridViewTextBoxColumn
            // 
            this.wasterCount2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count2";
            this.wasterCount2DataGridViewTextBoxColumn.HeaderText = "甩废长度2[m]";
            this.wasterCount2DataGridViewTextBoxColumn.Name = "wasterCount2DataGridViewTextBoxColumn";
            this.wasterCount2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight2DataGridViewTextBoxColumn
            // 
            this.wasterWeight2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight2";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.wasterWeight2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.wasterWeight2DataGridViewTextBoxColumn.HeaderText = "甩废重量2[t]";
            this.wasterWeight2DataGridViewTextBoxColumn.Name = "wasterWeight2DataGridViewTextBoxColumn";
            this.wasterWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterReason2DataGridViewTextBoxColumn
            // 
            this.wasterReason2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason2";
            this.wasterReason2DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wasterReason2DataGridViewTextBoxColumn.Name = "wasterReason2DataGridViewTextBoxColumn";
            this.wasterReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wasterCount3DataGridViewTextBoxColumn
            // 
            this.wasterCount3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count3";
            this.wasterCount3DataGridViewTextBoxColumn.HeaderText = "甩废长度3[m]";
            this.wasterCount3DataGridViewTextBoxColumn.Name = "wasterCount3DataGridViewTextBoxColumn";
            this.wasterCount3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterWeight3DataGridViewTextBoxColumn
            // 
            this.wasterWeight3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight3";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.wasterWeight3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.wasterWeight3DataGridViewTextBoxColumn.HeaderText = "甩废重量3[t]";
            this.wasterWeight3DataGridViewTextBoxColumn.Name = "wasterWeight3DataGridViewTextBoxColumn";
            this.wasterWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasterReason3DataGridViewTextBoxColumn
            // 
            this.wasterReason3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason3";
            this.wasterReason3DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wasterReason3DataGridViewTextBoxColumn.Name = "wasterReason3DataGridViewTextBoxColumn";
            this.wasterReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // Waster_Operator
            // 
            this.Waster_Operator.DataPropertyName = "Waster_Operator";
            this.Waster_Operator.HeaderText = "甩废人";
            this.Waster_Operator.Name = "Waster_Operator";
            this.Waster_Operator.ReadOnly = true;
            // 
            // shitIDDataGridViewTextBoxColumn
            // 
            this.shitIDDataGridViewTextBoxColumn.DataPropertyName = "ShitID";
            this.shitIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shitIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shitIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shitIDDataGridViewTextBoxColumn.Name = "shitIDDataGridViewTextBoxColumn";
            this.shitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shitIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
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
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
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
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
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
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsWaster
            // 
            this.bsWaster.DataMember = "L3DataTable";
            this.bsWaster.DataSource = this.dsWaster;
            // 
            // dsWaster
            // 
            this.dsWaster.AutoLoad = true;
            this.dsWaster.AutoSubscribe = false;
            this.dsWaster.DataSetName = "L3DataSet";
            this.dsWaster.DeleteMethod = null;
            this.dsWaster.InsertMethod = null;
            this.dsWaster.L3DataAdapter = this.Adapter;
            this.dsWaster.LoadEvent = "Click";
            this.dsWaster.LoadTrigger = null;
            this.dsWaster.RefreshValve = 1000;
            this.dsWaster.SourceCommand = null;
            this.dsWaster.SourceCondition = "1=2";
            this.dsWaster.SourceMethod = "";
            this.dsWaster.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWaster.SourceURI = "XGMESLogic\\QualityMag\\CQA_Bloom_Waster_Data";
            this.dsWaster.SubscribeTarget = null;
            this.dsWaster.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsWaster.UpdateEvent = "Click";
            this.dsWaster.UpdateMethod = null;
            this.dsWaster.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOutStoreL3DataTableSteelGradeIndex,
            this.coldsOutStoreL3DataTableLength,
            this.coldsOutStoreL3DataTableWidth,
            this.coldsOutStoreL3DataTableThickness,
            this.coldsOutStoreL3DataTableCal_Weight,
            this.coldsOutStoreL3DataTableWaster_Weight,
            this.coldsOutStoreL3DataTableBloom_Count,
            this.coldsOutStoreL3DataTableWaster_Count,
            this.coldsWasterL3DataTableProduce_Date,
            this.coldsWasterL3DataTableHeatID,
            this.coldsWasterL3DataTableCut_SteelGradeIndex,
            this.coldsWasterL3DataTableWaster_Count1,
            this.coldsWasterL3DataTableWaster_Weight1,
            this.coldsWasterL3DataTableWaster_Reason1,
            this.coldsWasterL3DataTableWaster_Count2,
            this.coldsWasterL3DataTableWaster_Weight2,
            this.coldsWasterL3DataTableWaster_Reason2,
            this.coldsWasterL3DataTableWaster_Count3,
            this.coldsWasterL3DataTableWaster_Weight3,
            this.coldsWasterL3DataTableWaster_Reason3,
            this.coldsWasterL3DataTableWaster_Operator,
            this.coldsWasterL3DataTableWaster_Date,
            this.coldsWasterL3DataTableShitID,
            this.coldsWasterL3DataTableTeamID,
            this.coldsWasterL3DataTableCasterID});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsOutStoreL3DataTableSteelGradeIndex
            // 
            this.coldsOutStoreL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsOutStoreL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsOutStoreL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsOutStoreL3DataTableLength
            // 
            this.coldsOutStoreL3DataTableLength.Caption = "Length";
            this.coldsOutStoreL3DataTableLength.ColumnName = "Length";
            this.coldsOutStoreL3DataTableLength.DataType = typeof(int);
            this.coldsOutStoreL3DataTableLength.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWidth
            // 
            this.coldsOutStoreL3DataTableWidth.Caption = "Width";
            this.coldsOutStoreL3DataTableWidth.ColumnName = "Width";
            this.coldsOutStoreL3DataTableWidth.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWidth.Namespace = "";
            // 
            // coldsOutStoreL3DataTableThickness
            // 
            this.coldsOutStoreL3DataTableThickness.Caption = "Thickness";
            this.coldsOutStoreL3DataTableThickness.ColumnName = "Thickness";
            this.coldsOutStoreL3DataTableThickness.DataType = typeof(int);
            this.coldsOutStoreL3DataTableThickness.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCal_Weight
            // 
            this.coldsOutStoreL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsOutStoreL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsOutStoreL3DataTableCal_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWaster_Weight
            // 
            this.coldsOutStoreL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsOutStoreL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsOutStoreL3DataTableWaster_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableBloom_Count
            // 
            this.coldsOutStoreL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsOutStoreL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsOutStoreL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWaster_Count
            // 
            this.coldsOutStoreL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsOutStoreL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsOutStoreL3DataTableWaster_Count.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsWasterL3DataTableProduce_Date
            // 
            this.coldsWasterL3DataTableProduce_Date.Caption = "Produce_Date";
            this.coldsWasterL3DataTableProduce_Date.ColumnName = "Produce_Date";
            this.coldsWasterL3DataTableProduce_Date.DataType = typeof(System.DateTime);
            this.coldsWasterL3DataTableProduce_Date.Namespace = "";
            // 
            // coldsWasterL3DataTableHeatID
            // 
            this.coldsWasterL3DataTableHeatID.Caption = "HeatID";
            this.coldsWasterL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsWasterL3DataTableHeatID.Namespace = "";
            // 
            // coldsWasterL3DataTableCut_SteelGradeIndex
            // 
            this.coldsWasterL3DataTableCut_SteelGradeIndex.Caption = "Cut_SteelGradeIndex";
            this.coldsWasterL3DataTableCut_SteelGradeIndex.ColumnName = "Cut_SteelGradeIndex";
            this.coldsWasterL3DataTableCut_SteelGradeIndex.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Count1
            // 
            this.coldsWasterL3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coldsWasterL3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coldsWasterL3DataTableWaster_Count1.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Count1.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Weight1
            // 
            this.coldsWasterL3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coldsWasterL3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coldsWasterL3DataTableWaster_Weight1.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Weight1.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Reason1
            // 
            this.coldsWasterL3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coldsWasterL3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coldsWasterL3DataTableWaster_Reason1.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Count2
            // 
            this.coldsWasterL3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coldsWasterL3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coldsWasterL3DataTableWaster_Count2.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Count2.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Weight2
            // 
            this.coldsWasterL3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coldsWasterL3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coldsWasterL3DataTableWaster_Weight2.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Weight2.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Reason2
            // 
            this.coldsWasterL3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coldsWasterL3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coldsWasterL3DataTableWaster_Reason2.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Count3
            // 
            this.coldsWasterL3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coldsWasterL3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coldsWasterL3DataTableWaster_Count3.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Count3.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Weight3
            // 
            this.coldsWasterL3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coldsWasterL3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coldsWasterL3DataTableWaster_Weight3.DataType = typeof(double);
            this.coldsWasterL3DataTableWaster_Weight3.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Reason3
            // 
            this.coldsWasterL3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coldsWasterL3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coldsWasterL3DataTableWaster_Reason3.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Operator
            // 
            this.coldsWasterL3DataTableWaster_Operator.Caption = "Waster_Operator";
            this.coldsWasterL3DataTableWaster_Operator.ColumnName = "Waster_Operator";
            this.coldsWasterL3DataTableWaster_Operator.Namespace = "";
            // 
            // coldsWasterL3DataTableWaster_Date
            // 
            this.coldsWasterL3DataTableWaster_Date.Caption = "Waster_Date";
            this.coldsWasterL3DataTableWaster_Date.ColumnName = "Waster_Date";
            this.coldsWasterL3DataTableWaster_Date.DataType = typeof(System.DateTime);
            this.coldsWasterL3DataTableWaster_Date.Namespace = "";
            // 
            // coldsWasterL3DataTableShitID
            // 
            this.coldsWasterL3DataTableShitID.Caption = "ShitID";
            this.coldsWasterL3DataTableShitID.ColumnName = "ShitID";
            this.coldsWasterL3DataTableShitID.Namespace = "";
            // 
            // coldsWasterL3DataTableTeamID
            // 
            this.coldsWasterL3DataTableTeamID.Caption = "TeamID";
            this.coldsWasterL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsWasterL3DataTableTeamID.Namespace = "";
            // 
            // coldsWasterL3DataTableCasterID
            // 
            this.coldsWasterL3DataTableCasterID.Caption = "CasterID";
            this.coldsWasterL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsWasterL3DataTableCasterID.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsWaster;
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
            this.toolStripLabel1,
            this.btnQuery,
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.cmbCasterID,
            this.toolStripLabel4,
            this.txtHeatID,
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(940, 25);
            this.bdN1.TabIndex = 28;
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
            // dtOutStoreEndData
            // 
            this.dtOutStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.Name = "dtOutStoreEndData";
            this.dtOutStoreEndData.Size = new System.Drawing.Size(85, 22);
            this.dtOutStoreEndData.Text = "2009-01-04";
            this.dtOutStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtOutStoreData
            // 
            this.dtOutStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.Name = "dtOutStoreData";
            this.dtOutStoreData.Size = new System.Drawing.Size(85, 22);
            this.dtOutStoreData.Text = "2008-11-16";
            this.dtOutStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "甩废日期:";
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
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "炉号:";
            // 
            // dsBloomArea
            // 
            this.dsBloomArea.AutoLoad = true;
            this.dsBloomArea.AutoSubscribe = false;
            this.dsBloomArea.DataSetName = "L3DataSet";
            this.dsBloomArea.DeleteMethod = null;
            this.dsBloomArea.InsertMethod = null;
            this.dsBloomArea.L3DataAdapter = this.Adapter;
            this.dsBloomArea.LoadEvent = "Click";
            this.dsBloomArea.LoadTrigger = null;
            this.dsBloomArea.RefreshValve = 1000;
            this.dsBloomArea.SourceCommand = null;
            this.dsBloomArea.SourceCondition = "CODE_GROUP = \'BloomArea\'";
            this.dsBloomArea.SourceMethod = "";
            this.dsBloomArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBloomArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBloomArea.SubscribeTarget = null;
            this.dsBloomArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBloomArea});
            this.dsBloomArea.UpdateEvent = "Click";
            this.dsBloomArea.UpdateMethod = null;
            this.dsBloomArea.UpdateTrigger = null;
            // 
            // schemadsBloomArea
            // 
            this.schemadsBloomArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomAreaL3DataTableCode,
            this.coldsBloomAreaL3DataTableCode_Des});
            this.schemadsBloomArea.TableName = "L3DataTable";
            // 
            // coldsBloomAreaL3DataTableCode
            // 
            this.coldsBloomAreaL3DataTableCode.Caption = "Code";
            this.coldsBloomAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBloomAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBloomAreaL3DataTableCode_Des
            // 
            this.coldsBloomAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBloomAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBloomAreaL3DataTableCode_Des.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "铸机:";
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCasterID.Items.AddRange(new object[] {
            "",
            "S61",
            "S62",
            "S63",
            "S64",
            "S65"});
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(80, 25);
            // 
            // CCMMarkScrapQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "CCMMarkScrapQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "出库查询";
            this.Text = "出坯实绩查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CCMMarkScrapQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.CCMMarkScrapQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsWaster;
        private System.Data.DataTable schemadsInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsWaster;
        private System.Data.DataColumn coldsOutStoreL3DataTableSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsBloomArea;
        private System.Data.DataTable schemadsBloomArea;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Data.DataColumn coldsOutStoreL3DataTableLength;
        private System.Data.DataColumn coldsOutStoreL3DataTableWidth;
        private System.Data.DataColumn coldsOutStoreL3DataTableThickness;
        private System.Data.DataColumn coldsOutStoreL3DataTableCal_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableBloom_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableWaster_Count;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Data.DataColumn coldsWasterL3DataTableProduce_Date;
        private System.Data.DataColumn coldsWasterL3DataTableHeatID;
        private System.Data.DataColumn coldsWasterL3DataTableCut_SteelGradeIndex;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Count1;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Weight1;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Reason1;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Count2;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Weight2;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Reason2;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Count3;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Weight3;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Reason3;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Operator;
        private System.Data.DataColumn coldsWasterL3DataTableWaster_Date;
        private System.Data.DataColumn coldsWasterL3DataTableShitID;
        private System.Data.DataColumn coldsWasterL3DataTableTeamID;
        private System.Data.DataColumn coldsWasterL3DataTableCasterID;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridView dvInStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloomCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waster_Operator;
        private System.Windows.Forms.DataGridViewComboBoxColumn shitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripComboBox cmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}