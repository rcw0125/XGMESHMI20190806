namespace BaseDataMag
{
    partial class SteelGradeStdMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelGradeStdMagFrm));
            this.dsSteelGradeStd = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteelGradeStd = new System.Data.DataTable();
            this.coldsSteelGradeStdL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableC_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableC_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSi_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSi_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableMn_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableMn_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableTi_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableTi_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSn_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSn_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSb_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSb_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableAs_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableAs_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTablePb_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTablePb_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableName = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSteelGradeStd = new System.Windows.Forms.DataGridView();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelGradeStd = new System.Windows.Forms.BindingSource(this.components);
            this.bnCostStandardRate = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeStd)).BeginInit();
            this.panel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGradeStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCostStandardRate)).BeginInit();
            this.bnCostStandardRate.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSteelGradeStd
            // 
            this.dsSteelGradeStd.AutoLoad = true;
            this.dsSteelGradeStd.AutoSubscribe = true;
            this.dsSteelGradeStd.DataSetName = "L3DataSet";
            this.dsSteelGradeStd.DeleteMethod = null;
            this.dsSteelGradeStd.InsertMethod = null;
            this.dsSteelGradeStd.L3DataAdapter = this.Adapter;
            this.dsSteelGradeStd.LoadEvent = "Click";
            this.dsSteelGradeStd.LoadTrigger = null;
            this.dsSteelGradeStd.RefreshValve = 1000;
            this.dsSteelGradeStd.SourceCommand = null;
            this.dsSteelGradeStd.SourceCondition = null;
            this.dsSteelGradeStd.SourceMethod = "";
            this.dsSteelGradeStd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeStd.SourceURI = "XGMESLogic\\QualityMag\\CQA_Element_Std";
            this.dsSteelGradeStd.SubscribeTarget = null;
            this.dsSteelGradeStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeStd});
            this.dsSteelGradeStd.UpdateEvent = "Click";
            this.dsSteelGradeStd.UpdateMethod = null;
            this.dsSteelGradeStd.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteelGradeStd
            // 
            this.schemadsSteelGradeStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeStdL3DataTableSteelGrade,
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex,
            this.coldsSteelGradeStdL3DataTableC_Max,
            this.coldsSteelGradeStdL3DataTableC_Min,
            this.coldsSteelGradeStdL3DataTableSi_Max,
            this.coldsSteelGradeStdL3DataTableSi_Min,
            this.coldsSteelGradeStdL3DataTableMn_Max,
            this.coldsSteelGradeStdL3DataTableMn_Min,
            this.coldsSteelGradeStdL3DataTableP_Max,
            this.coldsSteelGradeStdL3DataTableP_Min,
            this.coldsSteelGradeStdL3DataTableS_Max,
            this.coldsSteelGradeStdL3DataTableS_Min,
            this.coldsSteelGradeStdL3DataTableTi_Max,
            this.coldsSteelGradeStdL3DataTableTi_Min,
            this.coldsSteelGradeStdL3DataTableSn_Max,
            this.coldsSteelGradeStdL3DataTableSn_Min,
            this.coldsSteelGradeStdL3DataTableSb_Max,
            this.coldsSteelGradeStdL3DataTableSb_Min,
            this.coldsSteelGradeStdL3DataTableAs_Max,
            this.coldsSteelGradeStdL3DataTableAs_Min,
            this.coldsSteelGradeStdL3DataTablePb_Max,
            this.coldsSteelGradeStdL3DataTablePb_Min,
            this.coldsSteelGradeStdL3DataTableGUID,
            this.coldsSteelGradeStdL3DataTableName});
            this.schemadsSteelGradeStd.TableName = "L3DataTable";
            // 
            // coldsSteelGradeStdL3DataTableSteelGrade
            // 
            this.coldsSteelGradeStdL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeStdL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeStdL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableC_Max
            // 
            this.coldsSteelGradeStdL3DataTableC_Max.Caption = "C_Max";
            this.coldsSteelGradeStdL3DataTableC_Max.ColumnName = "C_Max";
            this.coldsSteelGradeStdL3DataTableC_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableC_Min
            // 
            this.coldsSteelGradeStdL3DataTableC_Min.Caption = "C_Min";
            this.coldsSteelGradeStdL3DataTableC_Min.ColumnName = "C_Min";
            this.coldsSteelGradeStdL3DataTableC_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSi_Max
            // 
            this.coldsSteelGradeStdL3DataTableSi_Max.Caption = "Si_Max";
            this.coldsSteelGradeStdL3DataTableSi_Max.ColumnName = "Si_Max";
            this.coldsSteelGradeStdL3DataTableSi_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSi_Min
            // 
            this.coldsSteelGradeStdL3DataTableSi_Min.Caption = "Si_Min";
            this.coldsSteelGradeStdL3DataTableSi_Min.ColumnName = "Si_Min";
            this.coldsSteelGradeStdL3DataTableSi_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableMn_Max
            // 
            this.coldsSteelGradeStdL3DataTableMn_Max.Caption = "Mn_Max";
            this.coldsSteelGradeStdL3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coldsSteelGradeStdL3DataTableMn_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableMn_Min
            // 
            this.coldsSteelGradeStdL3DataTableMn_Min.Caption = "Mn_Min";
            this.coldsSteelGradeStdL3DataTableMn_Min.ColumnName = "Mn_Min";
            this.coldsSteelGradeStdL3DataTableMn_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableP_Max
            // 
            this.coldsSteelGradeStdL3DataTableP_Max.Caption = "P_Max";
            this.coldsSteelGradeStdL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsSteelGradeStdL3DataTableP_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableP_Min
            // 
            this.coldsSteelGradeStdL3DataTableP_Min.Caption = "P_Min";
            this.coldsSteelGradeStdL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsSteelGradeStdL3DataTableP_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableS_Max
            // 
            this.coldsSteelGradeStdL3DataTableS_Max.Caption = "S_Max";
            this.coldsSteelGradeStdL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsSteelGradeStdL3DataTableS_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableS_Min
            // 
            this.coldsSteelGradeStdL3DataTableS_Min.Caption = "S_Min";
            this.coldsSteelGradeStdL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsSteelGradeStdL3DataTableS_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableTi_Max
            // 
            this.coldsSteelGradeStdL3DataTableTi_Max.Caption = "Ti_Max";
            this.coldsSteelGradeStdL3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coldsSteelGradeStdL3DataTableTi_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableTi_Min
            // 
            this.coldsSteelGradeStdL3DataTableTi_Min.Caption = "Ti_Min";
            this.coldsSteelGradeStdL3DataTableTi_Min.ColumnName = "Ti_Min";
            this.coldsSteelGradeStdL3DataTableTi_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSn_Max
            // 
            this.coldsSteelGradeStdL3DataTableSn_Max.Caption = "Sn_Max";
            this.coldsSteelGradeStdL3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coldsSteelGradeStdL3DataTableSn_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSn_Min
            // 
            this.coldsSteelGradeStdL3DataTableSn_Min.Caption = "Sn_Min";
            this.coldsSteelGradeStdL3DataTableSn_Min.ColumnName = "Sn_Min";
            this.coldsSteelGradeStdL3DataTableSn_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSb_Max
            // 
            this.coldsSteelGradeStdL3DataTableSb_Max.Caption = "Sb_Max";
            this.coldsSteelGradeStdL3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coldsSteelGradeStdL3DataTableSb_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSb_Min
            // 
            this.coldsSteelGradeStdL3DataTableSb_Min.Caption = "Sb_Min";
            this.coldsSteelGradeStdL3DataTableSb_Min.ColumnName = "Sb_Min";
            this.coldsSteelGradeStdL3DataTableSb_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableAs_Max
            // 
            this.coldsSteelGradeStdL3DataTableAs_Max.Caption = "As_Max";
            this.coldsSteelGradeStdL3DataTableAs_Max.ColumnName = "As_Max";
            this.coldsSteelGradeStdL3DataTableAs_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableAs_Min
            // 
            this.coldsSteelGradeStdL3DataTableAs_Min.Caption = "As_Min";
            this.coldsSteelGradeStdL3DataTableAs_Min.ColumnName = "As_Min";
            this.coldsSteelGradeStdL3DataTableAs_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTablePb_Max
            // 
            this.coldsSteelGradeStdL3DataTablePb_Max.Caption = "Pb_Max";
            this.coldsSteelGradeStdL3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coldsSteelGradeStdL3DataTablePb_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTablePb_Min
            // 
            this.coldsSteelGradeStdL3DataTablePb_Min.Caption = "Pb_Min";
            this.coldsSteelGradeStdL3DataTablePb_Min.ColumnName = "Pb_Min";
            this.coldsSteelGradeStdL3DataTablePb_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableGUID
            // 
            this.coldsSteelGradeStdL3DataTableGUID.Caption = "GUID";
            this.coldsSteelGradeStdL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelGradeStdL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableName
            // 
            this.coldsSteelGradeStdL3DataTableName.Caption = "Name";
            this.coldsSteelGradeStdL3DataTableName.ColumnName = "Name";
            this.coldsSteelGradeStdL3DataTableName.Namespace = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hmiRootPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 350);
            this.panel1.TabIndex = 1;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvSteelGradeStd);
            this.hmiRootPanel1.Controls.Add(this.bnCostStandardRate);
            this.hmiRootPanel1.Controls.Add(this.toolStrip1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(792, 350);
            this.hmiRootPanel1.TabIndex = 2;
            // 
            // dvSteelGradeStd
            // 
            this.dvSteelGradeStd.AllowUserToAddRows = false;
            this.dvSteelGradeStd.AutoGenerateColumns = false;
            this.dvSteelGradeStd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSteelGradeStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSteelGradeStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.cMaxDataGridViewTextBoxColumn,
            this.cMinDataGridViewTextBoxColumn,
            this.siMaxDataGridViewTextBoxColumn,
            this.siMinDataGridViewTextBoxColumn,
            this.mnMaxDataGridViewTextBoxColumn,
            this.mnMinDataGridViewTextBoxColumn,
            this.pMaxDataGridViewTextBoxColumn,
            this.pMinDataGridViewTextBoxColumn,
            this.sMaxDataGridViewTextBoxColumn,
            this.sMinDataGridViewTextBoxColumn,
            this.tiMaxDataGridViewTextBoxColumn,
            this.tiMinDataGridViewTextBoxColumn,
            this.snMaxDataGridViewTextBoxColumn,
            this.snMinDataGridViewTextBoxColumn,
            this.sbMaxDataGridViewTextBoxColumn,
            this.sbMinDataGridViewTextBoxColumn,
            this.asMaxDataGridViewTextBoxColumn,
            this.asMinDataGridViewTextBoxColumn,
            this.pbMaxDataGridViewTextBoxColumn,
            this.pbMinDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvSteelGradeStd.DataSource = this.bsSteelGradeStd;
            this.dvSteelGradeStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelGradeStd.Location = new System.Drawing.Point(0, 68);
            this.dvSteelGradeStd.Name = "dvSteelGradeStd";
            this.dvSteelGradeStd.RowTemplate.Height = 23;
            this.dvSteelGradeStd.Size = new System.Drawing.Size(792, 282);
            this.dvSteelGradeStd.TabIndex = 27;
            this.dvSteelGradeStd.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvSteelGradeStd_RowPostPaint);
            this.dvSteelGradeStd.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvSteelGradeStd_DataError);
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.Width = 54;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            dataGridViewCellStyle1.NullValue = "001";
            this.steelGradeIndexDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // cMaxDataGridViewTextBoxColumn
            // 
            this.cMaxDataGridViewTextBoxColumn.DataPropertyName = "C_Max";
            this.cMaxDataGridViewTextBoxColumn.HeaderText = "C最大";
            this.cMaxDataGridViewTextBoxColumn.Name = "cMaxDataGridViewTextBoxColumn";
            this.cMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // cMinDataGridViewTextBoxColumn
            // 
            this.cMinDataGridViewTextBoxColumn.DataPropertyName = "C_Min";
            this.cMinDataGridViewTextBoxColumn.HeaderText = "C最小";
            this.cMinDataGridViewTextBoxColumn.Name = "cMinDataGridViewTextBoxColumn";
            this.cMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // siMaxDataGridViewTextBoxColumn
            // 
            this.siMaxDataGridViewTextBoxColumn.DataPropertyName = "Si_Max";
            this.siMaxDataGridViewTextBoxColumn.HeaderText = "Si最大";
            this.siMaxDataGridViewTextBoxColumn.Name = "siMaxDataGridViewTextBoxColumn";
            this.siMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // siMinDataGridViewTextBoxColumn
            // 
            this.siMinDataGridViewTextBoxColumn.DataPropertyName = "Si_Min";
            this.siMinDataGridViewTextBoxColumn.HeaderText = "Si最小";
            this.siMinDataGridViewTextBoxColumn.Name = "siMinDataGridViewTextBoxColumn";
            this.siMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMaxDataGridViewTextBoxColumn
            // 
            this.mnMaxDataGridViewTextBoxColumn.DataPropertyName = "Mn_Max";
            this.mnMaxDataGridViewTextBoxColumn.HeaderText = "Mn最大";
            this.mnMaxDataGridViewTextBoxColumn.Name = "mnMaxDataGridViewTextBoxColumn";
            this.mnMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMinDataGridViewTextBoxColumn
            // 
            this.mnMinDataGridViewTextBoxColumn.DataPropertyName = "Mn_Min";
            this.mnMinDataGridViewTextBoxColumn.HeaderText = "Mn最小";
            this.mnMinDataGridViewTextBoxColumn.Name = "mnMinDataGridViewTextBoxColumn";
            this.mnMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // pMaxDataGridViewTextBoxColumn
            // 
            this.pMaxDataGridViewTextBoxColumn.DataPropertyName = "P_Max";
            this.pMaxDataGridViewTextBoxColumn.HeaderText = "P最大";
            this.pMaxDataGridViewTextBoxColumn.Name = "pMaxDataGridViewTextBoxColumn";
            this.pMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // pMinDataGridViewTextBoxColumn
            // 
            this.pMinDataGridViewTextBoxColumn.DataPropertyName = "P_Min";
            this.pMinDataGridViewTextBoxColumn.HeaderText = "P最小";
            this.pMinDataGridViewTextBoxColumn.Name = "pMinDataGridViewTextBoxColumn";
            this.pMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMaxDataGridViewTextBoxColumn
            // 
            this.sMaxDataGridViewTextBoxColumn.DataPropertyName = "S_Max";
            this.sMaxDataGridViewTextBoxColumn.HeaderText = "S最大";
            this.sMaxDataGridViewTextBoxColumn.Name = "sMaxDataGridViewTextBoxColumn";
            this.sMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMinDataGridViewTextBoxColumn
            // 
            this.sMinDataGridViewTextBoxColumn.DataPropertyName = "S_Min";
            this.sMinDataGridViewTextBoxColumn.HeaderText = "S最小";
            this.sMinDataGridViewTextBoxColumn.Name = "sMinDataGridViewTextBoxColumn";
            this.sMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // tiMaxDataGridViewTextBoxColumn
            // 
            this.tiMaxDataGridViewTextBoxColumn.DataPropertyName = "Ti_Max";
            this.tiMaxDataGridViewTextBoxColumn.HeaderText = "Ti最大";
            this.tiMaxDataGridViewTextBoxColumn.Name = "tiMaxDataGridViewTextBoxColumn";
            this.tiMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // tiMinDataGridViewTextBoxColumn
            // 
            this.tiMinDataGridViewTextBoxColumn.DataPropertyName = "Ti_Min";
            this.tiMinDataGridViewTextBoxColumn.HeaderText = "Ti最小";
            this.tiMinDataGridViewTextBoxColumn.Name = "tiMinDataGridViewTextBoxColumn";
            this.tiMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMaxDataGridViewTextBoxColumn
            // 
            this.snMaxDataGridViewTextBoxColumn.DataPropertyName = "Sn_Max";
            this.snMaxDataGridViewTextBoxColumn.HeaderText = "Sn最大";
            this.snMaxDataGridViewTextBoxColumn.Name = "snMaxDataGridViewTextBoxColumn";
            this.snMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMinDataGridViewTextBoxColumn
            // 
            this.snMinDataGridViewTextBoxColumn.DataPropertyName = "Sn_Min";
            this.snMinDataGridViewTextBoxColumn.HeaderText = "Sn最小";
            this.snMinDataGridViewTextBoxColumn.Name = "snMinDataGridViewTextBoxColumn";
            this.snMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbMaxDataGridViewTextBoxColumn
            // 
            this.sbMaxDataGridViewTextBoxColumn.DataPropertyName = "Sb_Max";
            this.sbMaxDataGridViewTextBoxColumn.HeaderText = "Sb最大";
            this.sbMaxDataGridViewTextBoxColumn.Name = "sbMaxDataGridViewTextBoxColumn";
            this.sbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbMinDataGridViewTextBoxColumn
            // 
            this.sbMinDataGridViewTextBoxColumn.DataPropertyName = "Sb_Min";
            this.sbMinDataGridViewTextBoxColumn.HeaderText = "Sb最小";
            this.sbMinDataGridViewTextBoxColumn.Name = "sbMinDataGridViewTextBoxColumn";
            this.sbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMaxDataGridViewTextBoxColumn
            // 
            this.asMaxDataGridViewTextBoxColumn.DataPropertyName = "As_Max";
            this.asMaxDataGridViewTextBoxColumn.HeaderText = "As最大";
            this.asMaxDataGridViewTextBoxColumn.Name = "asMaxDataGridViewTextBoxColumn";
            this.asMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMinDataGridViewTextBoxColumn
            // 
            this.asMinDataGridViewTextBoxColumn.DataPropertyName = "As_Min";
            this.asMinDataGridViewTextBoxColumn.HeaderText = "As最小";
            this.asMinDataGridViewTextBoxColumn.Name = "asMinDataGridViewTextBoxColumn";
            this.asMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbMaxDataGridViewTextBoxColumn
            // 
            this.pbMaxDataGridViewTextBoxColumn.DataPropertyName = "Pb_Max";
            this.pbMaxDataGridViewTextBoxColumn.HeaderText = "Pb最大";
            this.pbMaxDataGridViewTextBoxColumn.Name = "pbMaxDataGridViewTextBoxColumn";
            this.pbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbMinDataGridViewTextBoxColumn
            // 
            this.pbMinDataGridViewTextBoxColumn.DataPropertyName = "Pb_Min";
            this.pbMinDataGridViewTextBoxColumn.HeaderText = "Pb最小";
            this.pbMinDataGridViewTextBoxColumn.Name = "pbMinDataGridViewTextBoxColumn";
            this.pbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsSteelGradeStd
            // 
            this.bsSteelGradeStd.DataMember = "L3DataTable";
            this.bsSteelGradeStd.DataSource = this.dsSteelGradeStd;
            // 
            // bnCostStandardRate
            // 
            this.bnCostStandardRate.AddNewItem = null;
            this.bnCostStandardRate.AutoSize = false;
            this.bnCostStandardRate.BindingSource = this.bsSteelGradeStd;
            this.bnCostStandardRate.CountItem = this.bindingNavigatorCountItem;
            this.bnCostStandardRate.DeleteItem = null;
            this.bnCostStandardRate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bnCostStandardRate.Location = new System.Drawing.Point(0, 43);
            this.bnCostStandardRate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCostStandardRate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCostStandardRate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCostStandardRate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCostStandardRate.Name = "bnCostStandardRate";
            this.bnCostStandardRate.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCostStandardRate.Size = new System.Drawing.Size(792, 25);
            this.bnCostStandardRate.TabIndex = 26;
            this.bnCostStandardRate.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 43);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(68, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(109, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // SteelGradeStdMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelGradeStdMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢种标准维护";
            this.Text = "钢种标准维护";
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeStd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGradeStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCostStandardRate)).EndInit();
            this.bnCostStandardRate.ResumeLayout(false);
            this.bnCostStandardRate.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3DataSet dsSteelGradeStd;
        private AppSvrHMI.L3Adapter Adapter;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.BindingNavigator bnCostStandardRate;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dvSteelGradeStd;
        private System.Data.DataTable schemadsSteelGradeStd;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableC_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableC_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSi_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSi_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableMn_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableMn_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableP_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableP_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableS_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableS_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableTi_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableTi_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSn_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSn_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSb_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSb_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableAs_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableAs_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTablePb_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTablePb_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableGUID;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableName;
        private System.Windows.Forms.BindingSource bsSteelGradeStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}