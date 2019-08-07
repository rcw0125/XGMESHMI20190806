namespace PlanMag
{
    partial class BloomPlanQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomPlanQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.requestdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instoreweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isinstoreweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insidenoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBloomPlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsBloomPlan = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBloomPlan = new System.Data.DataTable();
            this.coldsBloomPlanL3DataTablerequest_date = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableplanid = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableprotocol = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablesteelgrade = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablelength = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableweight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableinside_note = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablecal_weight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableright_weight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablewaster_weight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablewrong_weight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTablespareweight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableinstoreweight = new System.Data.DataColumn();
            this.coldsBloomPlanL3DataTableisinstoreweight = new System.Data.DataColumn();
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
            this.dtInStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtInStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtPlanOrdID = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBloomPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(915, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestdateDataGridViewTextBoxColumn,
            this.planidDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.steelgradeDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.rightweightDataGridViewTextBoxColumn,
            this.calweightDataGridViewTextBoxColumn,
            this.wasterweightDataGridViewTextBoxColumn,
            this.wrongweightDataGridViewTextBoxColumn,
            this.spareweightDataGridViewTextBoxColumn,
            this.instoreweightDataGridViewTextBoxColumn,
            this.isinstoreweightDataGridViewTextBoxColumn,
            this.insidenoteDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsBloomPlan;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(915, 508);
            this.dvInStore.TabIndex = 29;
            // 
            // requestdateDataGridViewTextBoxColumn
            // 
            this.requestdateDataGridViewTextBoxColumn.DataPropertyName = "request_date";
            this.requestdateDataGridViewTextBoxColumn.HeaderText = "需求日期";
            this.requestdateDataGridViewTextBoxColumn.Name = "requestdateDataGridViewTextBoxColumn";
            this.requestdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestdateDataGridViewTextBoxColumn.Width = 78;
            // 
            // planidDataGridViewTextBoxColumn
            // 
            this.planidDataGridViewTextBoxColumn.DataPropertyName = "planid";
            this.planidDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.planidDataGridViewTextBoxColumn.Name = "planidDataGridViewTextBoxColumn";
            this.planidDataGridViewTextBoxColumn.ReadOnly = true;
            this.planidDataGridViewTextBoxColumn.Width = 90;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "产品标准";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            this.protocolDataGridViewTextBoxColumn.Width = 78;
            // 
            // steelgradeDataGridViewTextBoxColumn
            // 
            this.steelgradeDataGridViewTextBoxColumn.DataPropertyName = "steelgrade";
            this.steelgradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelgradeDataGridViewTextBoxColumn.Name = "steelgradeDataGridViewTextBoxColumn";
            this.steelgradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelgradeDataGridViewTextBoxColumn.Width = 54;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "定尺";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 54;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "计划量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 66;
            // 
            // rightweightDataGridViewTextBoxColumn
            // 
            this.rightweightDataGridViewTextBoxColumn.DataPropertyName = "right_weight";
            this.rightweightDataGridViewTextBoxColumn.HeaderText = "完工数量";
            this.rightweightDataGridViewTextBoxColumn.Name = "rightweightDataGridViewTextBoxColumn";
            this.rightweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.rightweightDataGridViewTextBoxColumn.Width = 78;
            // 
            // calweightDataGridViewTextBoxColumn
            // 
            this.calweightDataGridViewTextBoxColumn.DataPropertyName = "cal_weight";
            this.calweightDataGridViewTextBoxColumn.HeaderText = "理论数量";
            this.calweightDataGridViewTextBoxColumn.Name = "calweightDataGridViewTextBoxColumn";
            this.calweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.calweightDataGridViewTextBoxColumn.Width = 78;
            // 
            // wasterweightDataGridViewTextBoxColumn
            // 
            this.wasterweightDataGridViewTextBoxColumn.DataPropertyName = "waster_weight";
            this.wasterweightDataGridViewTextBoxColumn.HeaderText = "甩废数量";
            this.wasterweightDataGridViewTextBoxColumn.Name = "wasterweightDataGridViewTextBoxColumn";
            this.wasterweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterweightDataGridViewTextBoxColumn.Width = 78;
            // 
            // wrongweightDataGridViewTextBoxColumn
            // 
            this.wrongweightDataGridViewTextBoxColumn.DataPropertyName = "wrong_weight";
            this.wrongweightDataGridViewTextBoxColumn.HeaderText = "不合格数量";
            this.wrongweightDataGridViewTextBoxColumn.Name = "wrongweightDataGridViewTextBoxColumn";
            this.wrongweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongweightDataGridViewTextBoxColumn.Width = 90;
            // 
            // spareweightDataGridViewTextBoxColumn
            // 
            this.spareweightDataGridViewTextBoxColumn.DataPropertyName = "spareweight";
            this.spareweightDataGridViewTextBoxColumn.HeaderText = "订单执行情况";
            this.spareweightDataGridViewTextBoxColumn.Name = "spareweightDataGridViewTextBoxColumn";
            this.spareweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.spareweightDataGridViewTextBoxColumn.Width = 102;
            // 
            // instoreweightDataGridViewTextBoxColumn
            // 
            this.instoreweightDataGridViewTextBoxColumn.DataPropertyName = "instoreweight";
            this.instoreweightDataGridViewTextBoxColumn.HeaderText = "合格入库量";
            this.instoreweightDataGridViewTextBoxColumn.Name = "instoreweightDataGridViewTextBoxColumn";
            this.instoreweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.instoreweightDataGridViewTextBoxColumn.Width = 90;
            // 
            // isinstoreweightDataGridViewTextBoxColumn
            // 
            this.isinstoreweightDataGridViewTextBoxColumn.DataPropertyName = "isinstoreweight";
            this.isinstoreweightDataGridViewTextBoxColumn.HeaderText = "现存量";
            this.isinstoreweightDataGridViewTextBoxColumn.Name = "isinstoreweightDataGridViewTextBoxColumn";
            this.isinstoreweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.isinstoreweightDataGridViewTextBoxColumn.Width = 66;
            // 
            // insidenoteDataGridViewTextBoxColumn
            // 
            this.insidenoteDataGridViewTextBoxColumn.DataPropertyName = "inside_note";
            this.insidenoteDataGridViewTextBoxColumn.HeaderText = "内部备注";
            this.insidenoteDataGridViewTextBoxColumn.Name = "insidenoteDataGridViewTextBoxColumn";
            this.insidenoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.insidenoteDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsBloomPlan
            // 
            this.bsBloomPlan.DataMember = "L3DataTable";
            this.bsBloomPlan.DataSource = this.dsBloomPlan;
            // 
            // dsBloomPlan
            // 
            this.dsBloomPlan.AutoSubscribe = true;
            this.dsBloomPlan.DataSetName = "L3DataSet";
            this.dsBloomPlan.DeleteMethod = "";
            this.dsBloomPlan.InsertMethod = "";
            this.dsBloomPlan.L3DataAdapter = this.Adapter;
            this.dsBloomPlan.LoadEvent = "";
            this.dsBloomPlan.LoadTrigger = null;
            this.dsBloomPlan.RefreshValve = 1000;
            this.dsBloomPlan.SourceCommand = null;
            this.dsBloomPlan.SourceCondition = "";
            this.dsBloomPlan.SourceMethod = "";
            this.dsBloomPlan.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBloomPlan.SourceURI = "";
            this.dsBloomPlan.SubscribeTarget = null;
            this.dsBloomPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBloomPlan});
            this.dsBloomPlan.UpdateEvent = "";
            this.dsBloomPlan.UpdateMethod = "";
            this.dsBloomPlan.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBloomPlan
            // 
            this.schemadsBloomPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomPlanL3DataTablerequest_date,
            this.coldsBloomPlanL3DataTableplanid,
            this.coldsBloomPlanL3DataTableprotocol,
            this.coldsBloomPlanL3DataTablesteelgrade,
            this.coldsBloomPlanL3DataTablelength,
            this.coldsBloomPlanL3DataTableweight,
            this.coldsBloomPlanL3DataTableinside_note,
            this.coldsBloomPlanL3DataTablecal_weight,
            this.coldsBloomPlanL3DataTableright_weight,
            this.coldsBloomPlanL3DataTablewaster_weight,
            this.coldsBloomPlanL3DataTablewrong_weight,
            this.coldsBloomPlanL3DataTablespareweight,
            this.coldsBloomPlanL3DataTableinstoreweight,
            this.coldsBloomPlanL3DataTableisinstoreweight});
            this.schemadsBloomPlan.TableName = "L3DataTable";
            // 
            // coldsBloomPlanL3DataTablerequest_date
            // 
            this.coldsBloomPlanL3DataTablerequest_date.Caption = "request_date";
            this.coldsBloomPlanL3DataTablerequest_date.ColumnName = "request_date";
            this.coldsBloomPlanL3DataTablerequest_date.DataType = typeof(System.DateTime);
            this.coldsBloomPlanL3DataTablerequest_date.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableplanid
            // 
            this.coldsBloomPlanL3DataTableplanid.Caption = "planid";
            this.coldsBloomPlanL3DataTableplanid.ColumnName = "planid";
            this.coldsBloomPlanL3DataTableplanid.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableprotocol
            // 
            this.coldsBloomPlanL3DataTableprotocol.Caption = "protocol";
            this.coldsBloomPlanL3DataTableprotocol.ColumnName = "protocol";
            this.coldsBloomPlanL3DataTableprotocol.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablesteelgrade
            // 
            this.coldsBloomPlanL3DataTablesteelgrade.Caption = "steelgrade";
            this.coldsBloomPlanL3DataTablesteelgrade.ColumnName = "steelgrade";
            this.coldsBloomPlanL3DataTablesteelgrade.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablelength
            // 
            this.coldsBloomPlanL3DataTablelength.Caption = "length";
            this.coldsBloomPlanL3DataTablelength.ColumnName = "length";
            this.coldsBloomPlanL3DataTablelength.DataType = typeof(int);
            this.coldsBloomPlanL3DataTablelength.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableweight
            // 
            this.coldsBloomPlanL3DataTableweight.Caption = "weight";
            this.coldsBloomPlanL3DataTableweight.ColumnName = "weight";
            this.coldsBloomPlanL3DataTableweight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTableweight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableinside_note
            // 
            this.coldsBloomPlanL3DataTableinside_note.Caption = "inside_note";
            this.coldsBloomPlanL3DataTableinside_note.ColumnName = "inside_note";
            this.coldsBloomPlanL3DataTableinside_note.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablecal_weight
            // 
            this.coldsBloomPlanL3DataTablecal_weight.Caption = "cal_weight";
            this.coldsBloomPlanL3DataTablecal_weight.ColumnName = "cal_weight";
            this.coldsBloomPlanL3DataTablecal_weight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTablecal_weight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableright_weight
            // 
            this.coldsBloomPlanL3DataTableright_weight.Caption = "right_weight";
            this.coldsBloomPlanL3DataTableright_weight.ColumnName = "right_weight";
            this.coldsBloomPlanL3DataTableright_weight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTableright_weight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablewaster_weight
            // 
            this.coldsBloomPlanL3DataTablewaster_weight.Caption = "waster_weight";
            this.coldsBloomPlanL3DataTablewaster_weight.ColumnName = "waster_weight";
            this.coldsBloomPlanL3DataTablewaster_weight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTablewaster_weight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablewrong_weight
            // 
            this.coldsBloomPlanL3DataTablewrong_weight.Caption = "wrong_weight";
            this.coldsBloomPlanL3DataTablewrong_weight.ColumnName = "wrong_weight";
            this.coldsBloomPlanL3DataTablewrong_weight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTablewrong_weight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTablespareweight
            // 
            this.coldsBloomPlanL3DataTablespareweight.Caption = "spareweight";
            this.coldsBloomPlanL3DataTablespareweight.ColumnName = "spareweight";
            this.coldsBloomPlanL3DataTablespareweight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTablespareweight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableinstoreweight
            // 
            this.coldsBloomPlanL3DataTableinstoreweight.Caption = "instoreweight";
            this.coldsBloomPlanL3DataTableinstoreweight.ColumnName = "instoreweight";
            this.coldsBloomPlanL3DataTableinstoreweight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTableinstoreweight.Namespace = "";
            // 
            // coldsBloomPlanL3DataTableisinstoreweight
            // 
            this.coldsBloomPlanL3DataTableisinstoreweight.Caption = "isinstoreweight";
            this.coldsBloomPlanL3DataTableisinstoreweight.ColumnName = "isinstoreweight";
            this.coldsBloomPlanL3DataTableisinstoreweight.DataType = typeof(double);
            this.coldsBloomPlanL3DataTableisinstoreweight.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBloomPlan;
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
            this.dtInStoreEndData,
            this.toolStripLabel2,
            this.dtInStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.txtPlanOrdID,
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(915, 25);
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
            // dtInStoreEndData
            // 
            this.dtInStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.Name = "dtInStoreEndData";
            this.dtInStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreEndData.Text = "2009-01-04";
            this.dtInStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtInStoreData
            // 
            this.dtInStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.Name = "dtInStoreData";
            this.dtInStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreData.Text = "2008-11-16";
            this.dtInStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "需求日期:";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel3.Text = "订单号:";
            // 
            // txtPlanOrdID
            // 
            this.txtPlanOrdID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtPlanOrdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanOrdID.Name = "txtPlanOrdID";
            this.txtPlanOrdID.Size = new System.Drawing.Size(120, 25);
            // 
            // BloomPlanQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "BloomPlanQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢坯计划订单执行情况查询";
            this.Text = "钢坯计划订单执行情况查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomPlanQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.BloomPlanQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBloomPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
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
        private buttonHide.ToolStripToriDateTimePicker dtInStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBloomPlan;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsBloomPlan;
        private System.Data.DataTable schemadsBloomPlan;
        private System.Data.DataColumn coldsBloomPlanL3DataTablerequest_date;
        private System.Data.DataColumn coldsBloomPlanL3DataTableplanid;
        private System.Data.DataColumn coldsBloomPlanL3DataTableprotocol;
        private System.Data.DataColumn coldsBloomPlanL3DataTablesteelgrade;
        private System.Data.DataColumn coldsBloomPlanL3DataTablelength;
        private System.Data.DataColumn coldsBloomPlanL3DataTableweight;
        private System.Data.DataColumn coldsBloomPlanL3DataTableinside_note;
        private System.Data.DataColumn coldsBloomPlanL3DataTablecal_weight;
        private System.Data.DataColumn coldsBloomPlanL3DataTableright_weight;
        private System.Data.DataColumn coldsBloomPlanL3DataTablewaster_weight;
        private System.Data.DataColumn coldsBloomPlanL3DataTablewrong_weight;
        private System.Data.DataColumn coldsBloomPlanL3DataTablespareweight;
        private System.Data.DataColumn coldsBloomPlanL3DataTableinstoreweight;
        private System.Data.DataColumn coldsBloomPlanL3DataTableisinstoreweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instoreweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isinstoreweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insidenoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtPlanOrdID;
    }
}