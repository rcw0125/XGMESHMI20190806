namespace EquipMag.LadleMag
{
    partial class LadleBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadleBaseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.menuMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableRefra_Facturer = new System.Data.DataColumn();
            this.coldsMainL3DataTableStatus = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Grade = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTare_WT = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleType = new System.Data.DataColumn();
            this.coldsMainL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsMainL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsMainL3DataTableComFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableOnFireID = new System.Data.DataColumn();
            this.coldsMainL3DataTableWorkFireID = new System.Data.DataColumn();
            this.coldsMainL3DataTableMeasure_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableInnerFireID = new System.Data.DataColumn();
            this.coldsMainL3DataTableCheckFlag = new System.Data.DataColumn();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOffLineException = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnInnerBuildStart = new System.Windows.Forms.ToolStripButton();
            this.btnInnerBuildEnd = new System.Windows.Forms.ToolStripButton();
            this.btnHKBegin = new System.Windows.Forms.ToolStripButton();
            this.btnHKEnd = new System.Windows.Forms.ToolStripButton();
            this.btnWorkBuildStart = new System.Windows.Forms.ToolStripButton();
            this.btnWorkBuildEnd = new System.Windows.Forms.ToolStripButton();
            this.btnWorkFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnWorkFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnOnFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnOnFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnBOFTaping = new System.Windows.Forms.ToolStripButton();
            this.btnCastingEnd = new System.Windows.Forms.ToolStripButton();
            this.btnOffLineToCold = new System.Windows.Forms.ToolStripButton();
            this.btnOffLineThrow = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LadleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLadleType = new AppSvrHMI.L3DataSet();
            this.schemadsLadleType = new System.Data.DataTable();
            this.coldsLadleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLadleTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tareWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measure_Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBOFFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkFireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnFireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InnerFireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmdSetStatus = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.cmdInnerBuildStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpInnerBuildStart = new AppSvrHMI.L3CommandParameter();
            this.cmdInnerBuildEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpInnerBuildEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkBuildStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkBuildStart = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkBuildEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkBuildEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkFireEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdHotFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHotFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdHotFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHotFireEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdMeasureDesignate = new AppSvrHMI.L3Command(this.components);
            this.cmdOffLineException = new AppSvrHMI.L3Command(this.components);
            this.cmdpOffLineException = new AppSvrHMI.L3CommandParameter();
            this.cmdHKBegin = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.cmdHKEnd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdpMeasure = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleType)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            this.bsMain.Sort = "";
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = true;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // menuMeasure
            // 
            this.Adapter.SetAccessRight(this.menuMeasure, "btnLaldeMeasure");
            this.menuMeasure.Name = "menuMeasure";
            this.menuMeasure.Size = new System.Drawing.Size(118, 22);
            this.menuMeasure.Text = "指定称重";
            this.menuMeasure.Click += new System.EventHandler(this.menuMeasure_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnLaldeMeasure");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 22);
            this.btnCancel.Text = "取消指定";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableHeatID,
            this.coldsMainL3DataTableRefra_Facturer,
            this.coldsMainL3DataTableStatus,
            this.coldsMainL3DataTableLadle_Grade,
            this.coldsMainL3DataTableLadle_Age,
            this.coldsMainL3DataTableNew_BOF_Flag,
            this.coldsMainL3DataTableTare_WT,
            this.coldsMainL3DataTableLadleType,
            this.coldsMainL3DataTableInnerID,
            this.coldsMainL3DataTableWorkID,
            this.coldsMainL3DataTableComFlag,
            this.coldsMainL3DataTableOnFireID,
            this.coldsMainL3DataTableWorkFireID,
            this.coldsMainL3DataTableMeasure_Flag,
            this.coldsMainL3DataTableInnerFireID,
            this.coldsMainL3DataTableCheckFlag});
            this.schemadsMain.TableName = "L3DataTable";
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
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableHeatID
            // 
            this.coldsMainL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainL3DataTableRefra_Facturer
            // 
            this.coldsMainL3DataTableRefra_Facturer.Caption = "Refra_Facturer";
            this.coldsMainL3DataTableRefra_Facturer.ColumnName = "Refra_Facturer";
            this.coldsMainL3DataTableRefra_Facturer.Namespace = "";
            // 
            // coldsMainL3DataTableStatus
            // 
            this.coldsMainL3DataTableStatus.Caption = "Status";
            this.coldsMainL3DataTableStatus.ColumnName = "Status";
            this.coldsMainL3DataTableStatus.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Grade
            // 
            this.coldsMainL3DataTableLadle_Grade.Caption = "Ladle_Grade";
            this.coldsMainL3DataTableLadle_Grade.ColumnName = "Ladle_Grade";
            this.coldsMainL3DataTableLadle_Grade.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Age
            // 
            this.coldsMainL3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coldsMainL3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coldsMainL3DataTableLadle_Age.DataType = typeof(int);
            this.coldsMainL3DataTableLadle_Age.Namespace = "";
            // 
            // coldsMainL3DataTableNew_BOF_Flag
            // 
            this.coldsMainL3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsMainL3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsMainL3DataTableNew_BOF_Flag.DataType = typeof(int);
            this.coldsMainL3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableTare_WT
            // 
            this.coldsMainL3DataTableTare_WT.Caption = "Tare_WT";
            this.coldsMainL3DataTableTare_WT.ColumnName = "Tare_WT";
            this.coldsMainL3DataTableTare_WT.DataType = typeof(double);
            this.coldsMainL3DataTableTare_WT.Namespace = "";
            // 
            // coldsMainL3DataTableLadleType
            // 
            this.coldsMainL3DataTableLadleType.Caption = "LadleType";
            this.coldsMainL3DataTableLadleType.ColumnName = "LadleType";
            this.coldsMainL3DataTableLadleType.DataType = typeof(int);
            this.coldsMainL3DataTableLadleType.Namespace = "";
            // 
            // coldsMainL3DataTableInnerID
            // 
            this.coldsMainL3DataTableInnerID.Caption = "InnerID";
            this.coldsMainL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsMainL3DataTableInnerID.Namespace = "";
            // 
            // coldsMainL3DataTableWorkID
            // 
            this.coldsMainL3DataTableWorkID.Caption = "WorkID";
            this.coldsMainL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsMainL3DataTableWorkID.Namespace = "";
            // 
            // coldsMainL3DataTableComFlag
            // 
            this.coldsMainL3DataTableComFlag.Caption = "ComFlag";
            this.coldsMainL3DataTableComFlag.ColumnName = "ComFlag";
            this.coldsMainL3DataTableComFlag.DataType = typeof(int);
            this.coldsMainL3DataTableComFlag.Namespace = "";
            // 
            // coldsMainL3DataTableOnFireID
            // 
            this.coldsMainL3DataTableOnFireID.Caption = "OnFireID";
            this.coldsMainL3DataTableOnFireID.ColumnName = "OnFireID";
            this.coldsMainL3DataTableOnFireID.DataType = typeof(int);
            this.coldsMainL3DataTableOnFireID.Namespace = "";
            // 
            // coldsMainL3DataTableWorkFireID
            // 
            this.coldsMainL3DataTableWorkFireID.Caption = "WorkFireID";
            this.coldsMainL3DataTableWorkFireID.ColumnName = "WorkFireID";
            this.coldsMainL3DataTableWorkFireID.DataType = typeof(int);
            this.coldsMainL3DataTableWorkFireID.Namespace = "";
            // 
            // coldsMainL3DataTableMeasure_Flag
            // 
            this.coldsMainL3DataTableMeasure_Flag.Caption = "Measure_Flag";
            this.coldsMainL3DataTableMeasure_Flag.ColumnName = "Measure_Flag";
            this.coldsMainL3DataTableMeasure_Flag.DataType = typeof(int);
            this.coldsMainL3DataTableMeasure_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableInnerFireID
            // 
            this.coldsMainL3DataTableInnerFireID.Caption = "InnerFireID";
            this.coldsMainL3DataTableInnerFireID.ColumnName = "InnerFireID";
            this.coldsMainL3DataTableInnerFireID.DataType = typeof(int);
            this.coldsMainL3DataTableInnerFireID.Namespace = "";
            // 
            // coldsMainL3DataTableCheckFlag
            // 
            this.coldsMainL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsMainL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsMainL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsMainL3DataTableCheckFlag.Namespace = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "Code_Group = \'LadleStatus\'";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableCode,
            this.coldsStatusL3DataTableCode_Des});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableCode
            // 
            this.coldsStatusL3DataTableCode.Caption = "Code";
            this.coldsStatusL3DataTableCode.ColumnName = "Code";
            this.coldsStatusL3DataTableCode.Namespace = "";
            // 
            // coldsStatusL3DataTableCode_Des
            // 
            this.coldsStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1253, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsMain;
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
            this.btnAdd,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnOffLineException});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1253, 25);
            this.bdN1.TabIndex = 27;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOffLineException
            // 
            this.btnOffLineException.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffLineException.Image = ((System.Drawing.Image)(resources.GetObject("btnOffLineException.Image")));
            this.btnOffLineException.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffLineException.Name = "btnOffLineException";
            this.btnOffLineException.Size = new System.Drawing.Size(57, 22);
            this.btnOffLineException.Text = "异常下线";
            this.btnOffLineException.ToolTipText = "只对状态在\"使用\"以前的钢包有效";
            this.btnOffLineException.Click += new System.EventHandler(this.btnOffLineException_Click);
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInnerBuildStart,
            this.btnInnerBuildEnd,
            this.btnHKBegin,
            this.btnHKEnd,
            this.btnWorkBuildStart,
            this.btnWorkBuildEnd,
            this.btnWorkFireStart,
            this.btnWorkFireEnd,
            this.btnOnFireStart,
            this.btnOnFireEnd,
            this.btnBOFTaping,
            this.btnCastingEnd,
            this.btnOffLineToCold,
            this.btnOffLineThrow});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1253, 43);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnInnerBuildStart
            // 
            this.btnInnerBuildStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerBuildStart.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerBuildStart.Image")));
            this.btnInnerBuildStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerBuildStart.Name = "btnInnerBuildStart";
            this.btnInnerBuildStart.Size = new System.Drawing.Size(93, 40);
            this.btnInnerBuildStart.Text = "永久层砌筑开始";
            this.btnInnerBuildStart.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnInnerBuildEnd
            // 
            this.btnInnerBuildEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerBuildEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerBuildEnd.Image")));
            this.btnInnerBuildEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerBuildEnd.Name = "btnInnerBuildEnd";
            this.btnInnerBuildEnd.Size = new System.Drawing.Size(93, 40);
            this.btnInnerBuildEnd.Text = "永久层砌筑结束";
            this.btnInnerBuildEnd.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnHKBegin
            // 
            this.btnHKBegin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHKBegin.Image = ((System.Drawing.Image)(resources.GetObject("btnHKBegin.Image")));
            this.btnHKBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHKBegin.Name = "btnHKBegin";
            this.btnHKBegin.Size = new System.Drawing.Size(117, 40);
            this.btnHKBegin.Text = "钢包永久层烘烤开始";
            this.btnHKBegin.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnHKEnd
            // 
            this.btnHKEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHKEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnHKEnd.Image")));
            this.btnHKEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHKEnd.Name = "btnHKEnd";
            this.btnHKEnd.Size = new System.Drawing.Size(117, 40);
            this.btnHKEnd.Text = "钢包永久层烘烤结束";
            this.btnHKEnd.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnWorkBuildStart
            // 
            this.btnWorkBuildStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkBuildStart.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkBuildStart.Image")));
            this.btnWorkBuildStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkBuildStart.Name = "btnWorkBuildStart";
            this.btnWorkBuildStart.Size = new System.Drawing.Size(93, 40);
            this.btnWorkBuildStart.Text = "工作层修砌开始";
            this.btnWorkBuildStart.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnWorkBuildEnd
            // 
            this.btnWorkBuildEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkBuildEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkBuildEnd.Image")));
            this.btnWorkBuildEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkBuildEnd.Name = "btnWorkBuildEnd";
            this.btnWorkBuildEnd.Size = new System.Drawing.Size(93, 40);
            this.btnWorkBuildEnd.Text = "工作层修砌结束";
            this.btnWorkBuildEnd.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnWorkFireStart
            // 
            this.btnWorkFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkFireStart.Image")));
            this.btnWorkFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkFireStart.Name = "btnWorkFireStart";
            this.btnWorkFireStart.Size = new System.Drawing.Size(93, 40);
            this.btnWorkFireStart.Text = "工作层烘烤开始";
            this.btnWorkFireStart.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnWorkFireEnd
            // 
            this.btnWorkFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkFireEnd.Image")));
            this.btnWorkFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkFireEnd.Name = "btnWorkFireEnd";
            this.btnWorkFireEnd.Size = new System.Drawing.Size(93, 40);
            this.btnWorkFireEnd.Text = "工作层烘烤结束";
            this.btnWorkFireEnd.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnOnFireStart
            // 
            this.btnOnFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOnFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnOnFireStart.Image")));
            this.btnOnFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnFireStart.Name = "btnOnFireStart";
            this.btnOnFireStart.Size = new System.Drawing.Size(81, 40);
            this.btnOnFireStart.Text = "在线烘烤开始";
            this.btnOnFireStart.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnOnFireEnd
            // 
            this.btnOnFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOnFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnOnFireEnd.Image")));
            this.btnOnFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnFireEnd.Name = "btnOnFireEnd";
            this.btnOnFireEnd.Size = new System.Drawing.Size(81, 40);
            this.btnOnFireEnd.Text = "在线烘烤结束";
            this.btnOnFireEnd.Click += new System.EventHandler(this.SetStatus);
            // 
            // btnBOFTaping
            // 
            this.btnBOFTaping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBOFTaping.Image = ((System.Drawing.Image)(resources.GetObject("btnBOFTaping.Image")));
            this.btnBOFTaping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBOFTaping.Name = "btnBOFTaping";
            this.btnBOFTaping.Size = new System.Drawing.Size(81, 40);
            this.btnBOFTaping.Text = "转炉出钢开始";
            this.btnBOFTaping.ToolTipText = "当转炉出钢时,而上件未及时,及时补录转炉出钢开始信号";
            this.btnBOFTaping.Click += new System.EventHandler(this.btnBOFTaping_Click);
            // 
            // btnCastingEnd
            // 
            this.btnCastingEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCastingEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnCastingEnd.Image")));
            this.btnCastingEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCastingEnd.Name = "btnCastingEnd";
            this.btnCastingEnd.Size = new System.Drawing.Size(81, 40);
            this.btnCastingEnd.Text = "连铸浇注结束";
            this.btnCastingEnd.ToolTipText = "当未接收到连铸浇注结束信号而钢包实体已经浇注结束,补录连铸浇注结束信号";
            this.btnCastingEnd.Click += new System.EventHandler(this.btnCastingEnd_Click);
            // 
            // btnOffLineToCold
            // 
            this.btnOffLineToCold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffLineToCold.Image = ((System.Drawing.Image)(resources.GetObject("btnOffLineToCold.Image")));
            this.btnOffLineToCold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffLineToCold.Name = "btnOffLineToCold";
            this.btnOffLineToCold.Size = new System.Drawing.Size(57, 40);
            this.btnOffLineToCold.Text = "下线维护";
            this.btnOffLineToCold.Click += new System.EventHandler(this.btnOffLineToCold_Click);
            // 
            // btnOffLineThrow
            // 
            this.btnOffLineThrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffLineThrow.Image = ((System.Drawing.Image)(resources.GetObject("btnOffLineThrow.Image")));
            this.btnOffLineThrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffLineThrow.Name = "btnOffLineThrow";
            this.btnOffLineThrow.Size = new System.Drawing.Size(33, 40);
            this.btnOffLineThrow.Text = "甩包";
            this.btnOffLineThrow.Click += new System.EventHandler(this.btnOffLineThrow_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1253, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvMain.ColumnHeadersHeight = 32;
            this.dvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.LadleID,
            this.ladleAgeDataGridViewTextBoxColumn,
            this.ladleTypeDataGridViewTextBoxColumn,
            this.tareWTDataGridViewTextBoxColumn,
            this.Measure_Flag,
            this.Status,
            this.comFlagDataGridViewTextBoxColumn,
            this.ladleGradeDataGridViewTextBoxColumn,
            this.newBOFFlagDataGridViewTextBoxColumn,
            this.innerIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.WorkFireID,
            this.OnFireID,
            this.InnerFireID});
            this.dvMain.ContextMenuStrip = this.contextMenuStrip1;
            this.dvMain.DataSource = this.bsMain;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(0, 0);
            this.dvMain.Margin = new System.Windows.Forms.Padding(0);
            this.dvMain.Name = "dvMain";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvMain.Size = new System.Drawing.Size(1249, 628);
            this.dvMain.TabIndex = 31;
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            this.dvMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvMain_RowPostPaint);
            this.dvMain.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dvMain_RowContextMenuStripNeeded);
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn.Width = 51;
            // 
            // LadleID
            // 
            this.LadleID.DataPropertyName = "LadleID";
            this.LadleID.HeaderText = "钢包号";
            this.LadleID.Name = "LadleID";
            this.LadleID.ReadOnly = true;
            this.LadleID.Width = 61;
            // 
            // ladleAgeDataGridViewTextBoxColumn
            // 
            this.ladleAgeDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Age";
            this.ladleAgeDataGridViewTextBoxColumn.HeaderText = "包龄";
            this.ladleAgeDataGridViewTextBoxColumn.Name = "ladleAgeDataGridViewTextBoxColumn";
            this.ladleAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleAgeDataGridViewTextBoxColumn.Width = 51;
            // 
            // ladleTypeDataGridViewTextBoxColumn
            // 
            this.ladleTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ladleTypeDataGridViewTextBoxColumn.DataPropertyName = "LadleType";
            this.ladleTypeDataGridViewTextBoxColumn.DataSource = this.dsLadleType;
            this.ladleTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.ladleTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ladleTypeDataGridViewTextBoxColumn.HeaderText = "钢包类型";
            this.ladleTypeDataGridViewTextBoxColumn.Name = "ladleTypeDataGridViewTextBoxColumn";
            this.ladleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ladleTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ladleTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsLadleType
            // 
            this.dsLadleType.AutoLoad = true;
            this.dsLadleType.AutoSubscribe = false;
            this.dsLadleType.DataSetName = "L3DataSet";
            this.dsLadleType.DeleteMethod = null;
            this.dsLadleType.InsertMethod = null;
            this.dsLadleType.L3DataAdapter = this.Adapter;
            this.dsLadleType.LoadEvent = "Click";
            this.dsLadleType.LoadTrigger = null;
            this.dsLadleType.RefreshValve = 1000;
            this.dsLadleType.SourceCommand = null;
            this.dsLadleType.SourceCondition = "Code_Group = \'LadleType\'";
            this.dsLadleType.SourceMethod = "";
            this.dsLadleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleType.SubscribeTarget = null;
            this.dsLadleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleType});
            this.dsLadleType.UpdateEvent = "Click";
            this.dsLadleType.UpdateMethod = null;
            this.dsLadleType.UpdateTrigger = null;
            // 
            // schemadsLadleType
            // 
            this.schemadsLadleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleTypeL3DataTableCode,
            this.coldsLadleTypeL3DataTableCode_Des,
            this.coldsLadleTypeL3DataTableCode_Val_Long});
            this.schemadsLadleType.TableName = "L3DataTable";
            // 
            // coldsLadleTypeL3DataTableCode
            // 
            this.coldsLadleTypeL3DataTableCode.Caption = "Code";
            this.coldsLadleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsLadleTypeL3DataTableCode_Des
            // 
            this.coldsLadleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLadleTypeL3DataTableCode_Val_Long
            // 
            this.coldsLadleTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsLadleTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsLadleTypeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsLadleTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // tareWTDataGridViewTextBoxColumn
            // 
            this.tareWTDataGridViewTextBoxColumn.DataPropertyName = "Tare_WT";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.tareWTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tareWTDataGridViewTextBoxColumn.HeaderText = "钢包皮重";
            this.tareWTDataGridViewTextBoxColumn.Name = "tareWTDataGridViewTextBoxColumn";
            this.tareWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tareWTDataGridViewTextBoxColumn.Width = 61;
            // 
            // Measure_Flag
            // 
            this.Measure_Flag.DataPropertyName = "Measure_Flag";
            this.Measure_Flag.HeaderText = "称重指定标志";
            this.Measure_Flag.Name = "Measure_Flag";
            this.Measure_Flag.Width = 72;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.DataSource = this.dsStatus;
            this.Status.DisplayMember = "L3DataTable.Code_Des";
            this.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.ValueMember = "L3DataTable.Code";
            this.Status.Width = 51;
            // 
            // comFlagDataGridViewTextBoxColumn
            // 
            this.comFlagDataGridViewTextBoxColumn.DataPropertyName = "ComFlag";
            this.comFlagDataGridViewTextBoxColumn.HeaderText = "完成标志";
            this.comFlagDataGridViewTextBoxColumn.Name = "comFlagDataGridViewTextBoxColumn";
            this.comFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.comFlagDataGridViewTextBoxColumn.Width = 61;
            // 
            // ladleGradeDataGridViewTextBoxColumn
            // 
            this.ladleGradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ladleGradeDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Grade";
            this.ladleGradeDataGridViewTextBoxColumn.HeaderText = "包况";
            this.ladleGradeDataGridViewTextBoxColumn.Name = "ladleGradeDataGridViewTextBoxColumn";
            this.ladleGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladleGradeDataGridViewTextBoxColumn.Visible = false;
            // 
            // newBOFFlagDataGridViewTextBoxColumn
            // 
            this.newBOFFlagDataGridViewTextBoxColumn.DataPropertyName = "New_BOF_Flag";
            this.newBOFFlagDataGridViewTextBoxColumn.HeaderText = "转炉标志";
            this.newBOFFlagDataGridViewTextBoxColumn.Name = "newBOFFlagDataGridViewTextBoxColumn";
            this.newBOFFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.newBOFFlagDataGridViewTextBoxColumn.Visible = false;
            this.newBOFFlagDataGridViewTextBoxColumn.Width = 61;
            // 
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WorkFireID
            // 
            this.WorkFireID.DataPropertyName = "WorkFireID";
            this.WorkFireID.HeaderText = "工作层烘烤次数";
            this.WorkFireID.Name = "WorkFireID";
            this.WorkFireID.Width = 83;
            // 
            // OnFireID
            // 
            this.OnFireID.DataPropertyName = "OnFireID";
            this.OnFireID.HeaderText = "在线烘烤次数";
            this.OnFireID.Name = "OnFireID";
            this.OnFireID.ReadOnly = true;
            this.OnFireID.Width = 72;
            // 
            // InnerFireID
            // 
            this.InnerFireID.DataPropertyName = "InnerFireID";
            this.InnerFireID.HeaderText = "永久层烘烤次数";
            this.InnerFireID.Name = "InnerFireID";
            this.InnerFireID.ReadOnly = true;
            this.InnerFireID.Width = 83;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMeasure,
            this.btnCancel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // CmdSetStatus
            // 
            this.CmdSetStatus.Adapter = this.Adapter;
            this.CmdSetStatus.MergeReturnTarget = false;
            this.CmdSetStatus.Method = "SetLadleStatus";
            this.CmdSetStatus.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.CmdSetStatus.Parameters.Add(this.l3CommandParameter1);
            this.CmdSetStatus.Parameters.Add(this.l3CommandParameter2);
            this.CmdSetStatus.ReturnTarget = null;
            this.CmdSetStatus.ReturnTargetProperty = null;
            this.CmdSetStatus.Trigger = null;
            this.CmdSetStatus.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
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
            // cmdInnerBuildStart
            // 
            this.cmdInnerBuildStart.Adapter = this.Adapter;
            this.cmdInnerBuildStart.MergeReturnTarget = false;
            this.cmdInnerBuildStart.Method = "LadleInnerBuildStart";
            this.cmdInnerBuildStart.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdInnerBuildStart.Parameters.Add(this.l3cmdpInnerBuildStart);
            this.cmdInnerBuildStart.ReturnTarget = null;
            this.cmdInnerBuildStart.ReturnTargetProperty = null;
            this.cmdInnerBuildStart.Trigger = null;
            this.cmdInnerBuildStart.TriggerEvent = "Click";
            // 
            // l3cmdpInnerBuildStart
            // 
            this.l3cmdpInnerBuildStart.AcceptAfterExecuted = false;
            this.l3cmdpInnerBuildStart.ConstantValue = null;
            this.l3cmdpInnerBuildStart.MergeTarget = false;
            this.l3cmdpInnerBuildStart.SourceFilter = null;
            this.l3cmdpInnerBuildStart.SourceObject = this.dsMain;
            this.l3cmdpInnerBuildStart.SourceProperty = "L3DataTable";
            this.l3cmdpInnerBuildStart.TargetObject = null;
            this.l3cmdpInnerBuildStart.TargetProperty = null;
            // 
            // cmdInnerBuildEnd
            // 
            this.cmdInnerBuildEnd.Adapter = this.Adapter;
            this.cmdInnerBuildEnd.MergeReturnTarget = false;
            this.cmdInnerBuildEnd.Method = "LadleInnerBuildEnd";
            this.cmdInnerBuildEnd.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdInnerBuildEnd.Parameters.Add(this.l3cmdpInnerBuildEnd);
            this.cmdInnerBuildEnd.ReturnTarget = null;
            this.cmdInnerBuildEnd.ReturnTargetProperty = null;
            this.cmdInnerBuildEnd.Trigger = null;
            this.cmdInnerBuildEnd.TriggerEvent = "Click";
            // 
            // l3cmdpInnerBuildEnd
            // 
            this.l3cmdpInnerBuildEnd.AcceptAfterExecuted = false;
            this.l3cmdpInnerBuildEnd.ConstantValue = null;
            this.l3cmdpInnerBuildEnd.MergeTarget = false;
            this.l3cmdpInnerBuildEnd.SourceFilter = null;
            this.l3cmdpInnerBuildEnd.SourceObject = this.dsMain;
            this.l3cmdpInnerBuildEnd.SourceProperty = "L3DataTable";
            this.l3cmdpInnerBuildEnd.TargetObject = null;
            this.l3cmdpInnerBuildEnd.TargetProperty = null;
            // 
            // cmdWorkBuildStart
            // 
            this.cmdWorkBuildStart.Adapter = this.Adapter;
            this.cmdWorkBuildStart.MergeReturnTarget = false;
            this.cmdWorkBuildStart.Method = "LadleWorkBuildStart";
            this.cmdWorkBuildStart.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdWorkBuildStart.Parameters.Add(this.l3cmdpWorkBuildStart);
            this.cmdWorkBuildStart.ReturnTarget = null;
            this.cmdWorkBuildStart.ReturnTargetProperty = null;
            this.cmdWorkBuildStart.Trigger = null;
            this.cmdWorkBuildStart.TriggerEvent = "Click";
            // 
            // l3cmdpWorkBuildStart
            // 
            this.l3cmdpWorkBuildStart.AcceptAfterExecuted = false;
            this.l3cmdpWorkBuildStart.ConstantValue = null;
            this.l3cmdpWorkBuildStart.MergeTarget = false;
            this.l3cmdpWorkBuildStart.SourceFilter = null;
            this.l3cmdpWorkBuildStart.SourceObject = this.dsMain;
            this.l3cmdpWorkBuildStart.SourceProperty = "L3DataTable";
            this.l3cmdpWorkBuildStart.TargetObject = null;
            this.l3cmdpWorkBuildStart.TargetProperty = null;
            // 
            // cmdWorkBuildEnd
            // 
            this.cmdWorkBuildEnd.Adapter = this.Adapter;
            this.cmdWorkBuildEnd.MergeReturnTarget = false;
            this.cmdWorkBuildEnd.Method = "LadleWorkBuildEnd";
            this.cmdWorkBuildEnd.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdWorkBuildEnd.Parameters.Add(this.l3cmdpWorkBuildEnd);
            this.cmdWorkBuildEnd.ReturnTarget = null;
            this.cmdWorkBuildEnd.ReturnTargetProperty = null;
            this.cmdWorkBuildEnd.Trigger = null;
            this.cmdWorkBuildEnd.TriggerEvent = "Click";
            // 
            // l3cmdpWorkBuildEnd
            // 
            this.l3cmdpWorkBuildEnd.AcceptAfterExecuted = false;
            this.l3cmdpWorkBuildEnd.ConstantValue = null;
            this.l3cmdpWorkBuildEnd.MergeTarget = false;
            this.l3cmdpWorkBuildEnd.SourceFilter = null;
            this.l3cmdpWorkBuildEnd.SourceObject = this.dsMain;
            this.l3cmdpWorkBuildEnd.SourceProperty = "L3DataTable";
            this.l3cmdpWorkBuildEnd.TargetObject = null;
            this.l3cmdpWorkBuildEnd.TargetProperty = null;
            // 
            // cmdWorkFireStart
            // 
            this.cmdWorkFireStart.Adapter = this.Adapter;
            this.cmdWorkFireStart.MergeReturnTarget = false;
            this.cmdWorkFireStart.Method = "LadleWorkFireStart";
            this.cmdWorkFireStart.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdWorkFireStart.Parameters.Add(this.l3cmdpWorkFireStart);
            this.cmdWorkFireStart.ReturnTarget = null;
            this.cmdWorkFireStart.ReturnTargetProperty = null;
            this.cmdWorkFireStart.Trigger = null;
            this.cmdWorkFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpWorkFireStart
            // 
            this.l3cmdpWorkFireStart.AcceptAfterExecuted = false;
            this.l3cmdpWorkFireStart.ConstantValue = null;
            this.l3cmdpWorkFireStart.MergeTarget = false;
            this.l3cmdpWorkFireStart.SourceFilter = null;
            this.l3cmdpWorkFireStart.SourceObject = this.dsMain;
            this.l3cmdpWorkFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpWorkFireStart.TargetObject = null;
            this.l3cmdpWorkFireStart.TargetProperty = null;
            // 
            // cmdWorkFireEnd
            // 
            this.cmdWorkFireEnd.Adapter = this.Adapter;
            this.cmdWorkFireEnd.MergeReturnTarget = false;
            this.cmdWorkFireEnd.Method = "LadleWorkFireEnd";
            this.cmdWorkFireEnd.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdWorkFireEnd.Parameters.Add(this.l3cmdpWorkFireEnd);
            this.cmdWorkFireEnd.ReturnTarget = null;
            this.cmdWorkFireEnd.ReturnTargetProperty = null;
            this.cmdWorkFireEnd.Trigger = null;
            this.cmdWorkFireEnd.TriggerEvent = "Click";
            // 
            // l3cmdpWorkFireEnd
            // 
            this.l3cmdpWorkFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpWorkFireEnd.ConstantValue = null;
            this.l3cmdpWorkFireEnd.MergeTarget = false;
            this.l3cmdpWorkFireEnd.SourceFilter = null;
            this.l3cmdpWorkFireEnd.SourceObject = this.dsMain;
            this.l3cmdpWorkFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpWorkFireEnd.TargetObject = null;
            this.l3cmdpWorkFireEnd.TargetProperty = null;
            // 
            // cmdHotFireStart
            // 
            this.cmdHotFireStart.Adapter = this.Adapter;
            this.cmdHotFireStart.MergeReturnTarget = false;
            this.cmdHotFireStart.Method = "LadleHotFireStart";
            this.cmdHotFireStart.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdHotFireStart.Parameters.Add(this.l3cmdpHotFireStart);
            this.cmdHotFireStart.ReturnTarget = null;
            this.cmdHotFireStart.ReturnTargetProperty = null;
            this.cmdHotFireStart.Trigger = null;
            this.cmdHotFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpHotFireStart
            // 
            this.l3cmdpHotFireStart.AcceptAfterExecuted = false;
            this.l3cmdpHotFireStart.ConstantValue = null;
            this.l3cmdpHotFireStart.MergeTarget = false;
            this.l3cmdpHotFireStart.SourceFilter = null;
            this.l3cmdpHotFireStart.SourceObject = this.dsMain;
            this.l3cmdpHotFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpHotFireStart.TargetObject = null;
            this.l3cmdpHotFireStart.TargetProperty = null;
            // 
            // cmdHotFireEnd
            // 
            this.cmdHotFireEnd.Adapter = this.Adapter;
            this.cmdHotFireEnd.MergeReturnTarget = false;
            this.cmdHotFireEnd.Method = "LadleHotFireEnd";
            this.cmdHotFireEnd.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdHotFireEnd.Parameters.Add(this.l3cmdpHotFireEnd);
            this.cmdHotFireEnd.ReturnTarget = null;
            this.cmdHotFireEnd.ReturnTargetProperty = null;
            this.cmdHotFireEnd.Trigger = null;
            this.cmdHotFireEnd.TriggerEvent = "Click";
            // 
            // l3cmdpHotFireEnd
            // 
            this.l3cmdpHotFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpHotFireEnd.ConstantValue = null;
            this.l3cmdpHotFireEnd.MergeTarget = false;
            this.l3cmdpHotFireEnd.SourceFilter = null;
            this.l3cmdpHotFireEnd.SourceObject = this.dsMain;
            this.l3cmdpHotFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpHotFireEnd.TargetObject = null;
            this.l3cmdpHotFireEnd.TargetProperty = null;
            // 
            // cmdMeasureDesignate
            // 
            this.cmdMeasureDesignate.Adapter = this.Adapter;
            this.cmdMeasureDesignate.MergeReturnTarget = false;
            this.cmdMeasureDesignate.Method = "MeasureDesignate";
            this.cmdMeasureDesignate.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdMeasureDesignate.Parameters.Add(this.cmdpMeasure);
            this.cmdMeasureDesignate.ReturnTarget = null;
            this.cmdMeasureDesignate.ReturnTargetProperty = null;
            this.cmdMeasureDesignate.Trigger = null;
            this.cmdMeasureDesignate.TriggerEvent = "Click";
            // 
            // cmdOffLineException
            // 
            this.cmdOffLineException.Adapter = this.Adapter;
            this.cmdOffLineException.MergeReturnTarget = false;
            this.cmdOffLineException.Method = "LadleOffLineException";
            this.cmdOffLineException.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdOffLineException.Parameters.Add(this.cmdpOffLineException);
            this.cmdOffLineException.ReturnTarget = null;
            this.cmdOffLineException.ReturnTargetProperty = null;
            this.cmdOffLineException.Trigger = null;
            this.cmdOffLineException.TriggerEvent = "Click";
            // 
            // cmdpOffLineException
            // 
            this.cmdpOffLineException.AcceptAfterExecuted = false;
            this.cmdpOffLineException.ConstantValue = null;
            this.cmdpOffLineException.MergeTarget = false;
            this.cmdpOffLineException.SourceFilter = null;
            this.cmdpOffLineException.SourceObject = this.dsMain;
            this.cmdpOffLineException.SourceProperty = "L3DataTable";
            this.cmdpOffLineException.TargetObject = null;
            this.cmdpOffLineException.TargetProperty = null;
            // 
            // cmdHKBegin
            // 
            this.cmdHKBegin.Adapter = this.Adapter;
            this.cmdHKBegin.MergeReturnTarget = false;
            this.cmdHKBegin.Method = "LadleInnerFireStart";
            this.cmdHKBegin.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdHKBegin.Parameters.Add(this.l3CommandParameter4);
            this.cmdHKBegin.ReturnTarget = null;
            this.cmdHKBegin.ReturnTargetProperty = null;
            this.cmdHKBegin.Trigger = null;
            this.cmdHKBegin.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.dsMain;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // cmdHKEnd
            // 
            this.cmdHKEnd.Adapter = this.Adapter;
            this.cmdHKEnd.MergeReturnTarget = false;
            this.cmdHKEnd.Method = "LadleInnerFireEnd";
            this.cmdHKEnd.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdHKEnd.Parameters.Add(this.l3CommandParameter5);
            this.cmdHKEnd.ReturnTarget = null;
            this.cmdHKEnd.ReturnTargetProperty = null;
            this.cmdHKEnd.Trigger = null;
            this.cmdHKEnd.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = this.dsMain;
            this.l3CommandParameter5.SourceProperty = "L3DataTable";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
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
            // cmdpMeasure
            // 
            this.cmdpMeasure.AcceptAfterExecuted = false;
            this.cmdpMeasure.ConstantValue = null;
            this.cmdpMeasure.MergeTarget = false;
            this.cmdpMeasure.SourceFilter = null;
            this.cmdpMeasure.SourceObject = null;
            this.cmdpMeasure.SourceProperty = null;
            this.cmdpMeasure.TargetObject = null;
            this.cmdpMeasure.TargetProperty = null;
            // 
            // LadleBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LadleBaseMagFrm";
            this.TabText = "钢包基本信息管理";
            this.Text = "钢包基本信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadleBaseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LadleBaseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleType)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3Command CmdSetStatus;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableRefra_Facturer;
        private System.Data.DataColumn coldsMainL3DataTableStatus;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Grade;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Age;
        private System.Data.DataColumn coldsMainL3DataTableNew_BOF_Flag;
        private System.Data.DataColumn coldsMainL3DataTableTare_WT;
        private System.Data.DataColumn coldsMainL3DataTableLadleType;
        private System.Data.DataColumn coldsMainL3DataTableInnerID;
        private System.Data.DataColumn coldsMainL3DataTableWorkID;
        private System.Data.DataColumn coldsMainL3DataTableComFlag;
        private AppSvrHMI.L3Command cmdInnerBuildStart;
        private AppSvrHMI.L3CommandParameter l3cmdpInnerBuildStart;
        private AppSvrHMI.L3Command cmdInnerBuildEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpInnerBuildEnd;
        private AppSvrHMI.L3Command cmdWorkBuildStart;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkBuildStart;
        private AppSvrHMI.L3Command cmdWorkBuildEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkBuildEnd;
        private AppSvrHMI.L3Command cmdWorkFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkFireStart;
        private AppSvrHMI.L3Command cmdWorkFireEnd;
        private AppSvrHMI.L3Command cmdHotFireStart;
        private AppSvrHMI.L3Command cmdHotFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpHotFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpHotFireEnd;
        private System.Windows.Forms.ToolStripButton btnInnerBuildStart;
        private System.Windows.Forms.ToolStripButton btnInnerBuildEnd;
        private System.Windows.Forms.ToolStripButton btnWorkBuildStart;
        private System.Windows.Forms.ToolStripButton btnWorkBuildEnd;
        private System.Windows.Forms.ToolStripButton btnWorkFireStart;
        private System.Windows.Forms.ToolStripButton btnWorkFireEnd;
        private System.Windows.Forms.ToolStripButton btnOnFireStart;
        private System.Windows.Forms.ToolStripButton btnOnFireEnd;
        private AppSvrHMI.L3DataSet dsLadleType;
        private System.Data.DataTable schemadsLadleType;
        private System.Data.DataColumn coldsLadleTypeL3DataTableCode;
        private System.Data.DataColumn coldsLadleTypeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnBOFTaping;
        private System.Windows.Forms.ToolStripButton btnOffLineToCold;
        private System.Windows.Forms.ToolStripButton btnCastingEnd;
        private System.Windows.Forms.ToolStripButton btnOffLineThrow;
        private System.Data.DataColumn coldsLadleTypeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsMainL3DataTableOnFireID;
        private System.Data.DataColumn coldsMainL3DataTableWorkFireID;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private AppSvrHMI.L3Command cmdMeasureDesignate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMeasure;
        private System.Data.DataColumn coldsMainL3DataTableMeasure_Flag;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOffLineException;
        private AppSvrHMI.L3Command cmdOffLineException;
        private AppSvrHMI.L3CommandParameter cmdpOffLineException;
        private System.Windows.Forms.ToolStripButton btnHKBegin;
        private System.Windows.Forms.ToolStripButton btnHKEnd;
        private System.Data.DataColumn coldsMainL3DataTableInnerFireID;
        private AppSvrHMI.L3Command cmdHKBegin;
        private AppSvrHMI.L3Command cmdHKEnd;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private System.Data.DataColumn coldsMainL3DataTableCheckFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ladleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measure_Flag;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn comFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newBOFFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkFireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnFireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InnerFireID;
        private AppSvrHMI.L3CommandParameter cmdpMeasure;
    }
}