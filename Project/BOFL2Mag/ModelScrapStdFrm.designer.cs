namespace BOFL2Mag
{
    partial class ModelScrapStdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelScrapStdFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsMaterial_CodeRelation = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial_CodeRelation = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial_CodeRelation = new System.Data.DataTable();
            this.coldsMaterial_CodeRelationL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableName = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Code = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableC = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableSi = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableMn = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableP = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableS = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableTi = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableFe = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableFeO = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop = new System.Data.DataColumn();
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbMaterial_Code = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanelProcTime = new HMIBase.HMIRootPanel();
            this.dvMaterial_CodeRelation = new System.Windows.Forms.DataGridView();
            this.dsMaterial_Code = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial_Code = new System.Data.DataTable();
            this.coldsMaterial_CodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMaterial_CodeL3DataTableMaterial_Code = new System.Data.DataColumn();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdTempDropDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial_CodeRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial_CodeRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial_CodeRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProcTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial_CodeRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial_Code)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnBOFStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnBOFStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnBOFStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnBOFStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnBOFStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "btnBOFStd");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
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
            this.toolStripSeparator5});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 14;
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
            // bsMaterial_CodeRelation
            // 
            this.bsMaterial_CodeRelation.DataMember = "L3DataTable";
            this.bsMaterial_CodeRelation.DataSource = this.dsMaterial_CodeRelation;
            // 
            // dsMaterial_CodeRelation
            // 
            this.dsMaterial_CodeRelation.AutoLoad = true;
            this.dsMaterial_CodeRelation.AutoSubscribe = false;
            this.dsMaterial_CodeRelation.DataSetName = "L3DataSet";
            this.dsMaterial_CodeRelation.DeleteMethod = null;
            this.dsMaterial_CodeRelation.InsertMethod = null;
            this.dsMaterial_CodeRelation.L3DataAdapter = this.Adapter;
            this.dsMaterial_CodeRelation.LoadEvent = "Click";
            this.dsMaterial_CodeRelation.LoadTrigger = null;
            this.dsMaterial_CodeRelation.RefreshValve = 1000;
            this.dsMaterial_CodeRelation.SourceCommand = null;
            this.dsMaterial_CodeRelation.SourceCondition = "1=2";
            this.dsMaterial_CodeRelation.SourceMethod = "";
            this.dsMaterial_CodeRelation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterial_CodeRelation.SourceURI = "XGMESLogic\\BOFL2Mag\\BOFL2_Model_Scrap";
            this.dsMaterial_CodeRelation.SubscribeTarget = null;
            this.dsMaterial_CodeRelation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial_CodeRelation});
            this.dsMaterial_CodeRelation.UpdateEvent = "Click";
            this.dsMaterial_CodeRelation.UpdateMethod = null;
            this.dsMaterial_CodeRelation.UpdateTrigger = null;
            // 
            // schemadsMaterial_CodeRelation
            // 
            this.schemadsMaterial_CodeRelation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterial_CodeRelationL3DataTableGUID,
            this.coldsMaterial_CodeRelationL3DataTableName,
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Code,
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Name,
            this.coldsMaterial_CodeRelationL3DataTableC,
            this.coldsMaterial_CodeRelationL3DataTableSi,
            this.coldsMaterial_CodeRelationL3DataTableMn,
            this.coldsMaterial_CodeRelationL3DataTableP,
            this.coldsMaterial_CodeRelationL3DataTableS,
            this.coldsMaterial_CodeRelationL3DataTableTi,
            this.coldsMaterial_CodeRelationL3DataTableFe,
            this.coldsMaterial_CodeRelationL3DataTableFeO,
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop,
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop});
            this.schemadsMaterial_CodeRelation.TableName = "L3DataTable";
            // 
            // coldsMaterial_CodeRelationL3DataTableGUID
            // 
            this.coldsMaterial_CodeRelationL3DataTableGUID.Caption = "GUID";
            this.coldsMaterial_CodeRelationL3DataTableGUID.ColumnName = "GUID";
            this.coldsMaterial_CodeRelationL3DataTableGUID.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableName
            // 
            this.coldsMaterial_CodeRelationL3DataTableName.Caption = "Name";
            this.coldsMaterial_CodeRelationL3DataTableName.ColumnName = "Name";
            this.coldsMaterial_CodeRelationL3DataTableName.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableMaterial_Code
            // 
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Code.Caption = "Material_Code";
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Code.ColumnName = "Material_Code";
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Code.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableMaterial_Name
            // 
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Name.Caption = "Material_Name";
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Name.ColumnName = "Material_Name";
            this.coldsMaterial_CodeRelationL3DataTableMaterial_Name.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableC
            // 
            this.coldsMaterial_CodeRelationL3DataTableC.Caption = "C";
            this.coldsMaterial_CodeRelationL3DataTableC.ColumnName = "C";
            this.coldsMaterial_CodeRelationL3DataTableC.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableC.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableSi
            // 
            this.coldsMaterial_CodeRelationL3DataTableSi.Caption = "Si";
            this.coldsMaterial_CodeRelationL3DataTableSi.ColumnName = "Si";
            this.coldsMaterial_CodeRelationL3DataTableSi.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableSi.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableMn
            // 
            this.coldsMaterial_CodeRelationL3DataTableMn.Caption = "Mn";
            this.coldsMaterial_CodeRelationL3DataTableMn.ColumnName = "Mn";
            this.coldsMaterial_CodeRelationL3DataTableMn.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableMn.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableP
            // 
            this.coldsMaterial_CodeRelationL3DataTableP.Caption = "P";
            this.coldsMaterial_CodeRelationL3DataTableP.ColumnName = "P";
            this.coldsMaterial_CodeRelationL3DataTableP.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableP.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableS
            // 
            this.coldsMaterial_CodeRelationL3DataTableS.Caption = "S";
            this.coldsMaterial_CodeRelationL3DataTableS.ColumnName = "S";
            this.coldsMaterial_CodeRelationL3DataTableS.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableS.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableTi
            // 
            this.coldsMaterial_CodeRelationL3DataTableTi.Caption = "Ti";
            this.coldsMaterial_CodeRelationL3DataTableTi.ColumnName = "Ti";
            this.coldsMaterial_CodeRelationL3DataTableTi.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableTi.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableFe
            // 
            this.coldsMaterial_CodeRelationL3DataTableFe.Caption = "Fe";
            this.coldsMaterial_CodeRelationL3DataTableFe.ColumnName = "Fe";
            this.coldsMaterial_CodeRelationL3DataTableFe.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableFe.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableFeO
            // 
            this.coldsMaterial_CodeRelationL3DataTableFeO.Caption = "FeO";
            this.coldsMaterial_CodeRelationL3DataTableFeO.ColumnName = "FeO";
            this.coldsMaterial_CodeRelationL3DataTableFeO.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableFeO.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop
            // 
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop.Caption = "Std_Temp_Drop";
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop.ColumnName = "Std_Temp_Drop";
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop.Namespace = "";
            // 
            // coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop
            // 
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop.Caption = "Season_Temp_Drop";
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop.ColumnName = "Season_Temp_Drop";
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop.DataType = typeof(double);
            this.coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsMaterial_CodeRelation;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.toolStripLabel6,
            this.cmbMaterial_Code,
            this.toolStripLabel7,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
            // 
            // cmbMaterial_Code
            // 
            this.cmbMaterial_Code.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbMaterial_Code.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMaterial_Code.Name = "cmbMaterial_Code";
            this.cmbMaterial_Code.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "废钢代码:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hmiRootPanelProcTime
            // 
            this.hmiRootPanelProcTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelProcTime.Controls.Add(this.dvMaterial_CodeRelation);
            this.hmiRootPanelProcTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProcTime.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProcTime.Name = "hmiRootPanelProcTime";
            this.hmiRootPanelProcTime.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProcTime.TabIndex = 18;
            // 
            // dvMaterial_CodeRelation
            // 
            this.dvMaterial_CodeRelation.AllowUserToAddRows = false;
            this.dvMaterial_CodeRelation.AllowUserToDeleteRows = false;
            this.dvMaterial_CodeRelation.AutoGenerateColumns = false;
            this.dvMaterial_CodeRelation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMaterial_CodeRelation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.feDataGridViewTextBoxColumn,
            this.feODataGridViewTextBoxColumn,
            this.stdTempDropDataGridViewTextBoxColumn});
            this.dvMaterial_CodeRelation.DataSource = this.bsMaterial_CodeRelation;
            this.dvMaterial_CodeRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial_CodeRelation.Location = new System.Drawing.Point(0, 0);
            this.dvMaterial_CodeRelation.MultiSelect = false;
            this.dvMaterial_CodeRelation.Name = "dvMaterial_CodeRelation";
            this.dvMaterial_CodeRelation.RowTemplate.Height = 23;
            this.dvMaterial_CodeRelation.Size = new System.Drawing.Size(1016, 608);
            this.dvMaterial_CodeRelation.TabIndex = 0;
            this.dvMaterial_CodeRelation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMaterial_CodeRelation_DataError);
            // 
            // dsMaterial_Code
            // 
            this.dsMaterial_Code.AutoLoad = true;
            this.dsMaterial_Code.AutoSubscribe = false;
            this.dsMaterial_Code.DataSetName = "L3DataSet";
            this.dsMaterial_Code.DeleteMethod = null;
            this.dsMaterial_Code.InsertMethod = null;
            this.dsMaterial_Code.L3DataAdapter = this.Adapter;
            this.dsMaterial_Code.LoadEvent = "Click";
            this.dsMaterial_Code.LoadTrigger = null;
            this.dsMaterial_Code.RefreshValve = 1000;
            this.dsMaterial_Code.SourceCommand = null;
            this.dsMaterial_Code.SourceCondition = "Material_Code is not null order by Material_Code";
            this.dsMaterial_Code.SourceMethod = "";
            this.dsMaterial_Code.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterial_Code.SourceURI = "XGMESLogic\\BOFL2Mag\\BOFL2_Model_Scrap";
            this.dsMaterial_Code.SubscribeTarget = null;
            this.dsMaterial_Code.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial_Code});
            this.dsMaterial_Code.UpdateEvent = "Click";
            this.dsMaterial_Code.UpdateMethod = null;
            this.dsMaterial_Code.UpdateTrigger = null;
            // 
            // schemadsMaterial_Code
            // 
            this.schemadsMaterial_Code.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterial_CodeL3DataTableGUID,
            this.coldsMaterial_CodeL3DataTableMaterial_Code});
            this.schemadsMaterial_Code.TableName = "L3DataTable";
            // 
            // coldsMaterial_CodeL3DataTableGUID
            // 
            this.coldsMaterial_CodeL3DataTableGUID.Caption = "GUID";
            this.coldsMaterial_CodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsMaterial_CodeL3DataTableGUID.Namespace = "";
            // 
            // coldsMaterial_CodeL3DataTableMaterial_Code
            // 
            this.coldsMaterial_CodeL3DataTableMaterial_Code.Caption = "Material_Code";
            this.coldsMaterial_CodeL3DataTableMaterial_Code.ColumnName = "Material_Code";
            this.coldsMaterial_CodeL3DataTableMaterial_Code.Namespace = "";
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Visible = false;
            this.CheckFlag.Width = 50;
            // 
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "Material_Code";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "代码";
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.Width = 40;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 50;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 50;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 50;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 50;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 50;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.Width = 50;
            // 
            // feDataGridViewTextBoxColumn
            // 
            this.feDataGridViewTextBoxColumn.DataPropertyName = "Fe";
            this.feDataGridViewTextBoxColumn.HeaderText = "Fe";
            this.feDataGridViewTextBoxColumn.Name = "feDataGridViewTextBoxColumn";
            this.feDataGridViewTextBoxColumn.Width = 50;
            // 
            // feODataGridViewTextBoxColumn
            // 
            this.feODataGridViewTextBoxColumn.DataPropertyName = "FeO";
            this.feODataGridViewTextBoxColumn.HeaderText = "FeO";
            this.feODataGridViewTextBoxColumn.Name = "feODataGridViewTextBoxColumn";
            this.feODataGridViewTextBoxColumn.Width = 50;
            // 
            // stdTempDropDataGridViewTextBoxColumn
            // 
            this.stdTempDropDataGridViewTextBoxColumn.DataPropertyName = "Std_Temp_Drop";
            this.stdTempDropDataGridViewTextBoxColumn.HeaderText = "标准温降";
            this.stdTempDropDataGridViewTextBoxColumn.Name = "stdTempDropDataGridViewTextBoxColumn";
            this.stdTempDropDataGridViewTextBoxColumn.Width = 80;
            // 
            // ModelScrapStdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProcTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModelScrapStdFrm";
            this.TabText = "废钢标准维护";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.ModelScrapStdFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelScrapStdFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial_CodeRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial_CodeRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial_CodeRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProcTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial_CodeRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial_Code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsMaterial_CodeRelation;
        private AppSvrHMI.L3DataSet dsMaterial_CodeRelation;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbMaterial_Code;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelProcTime;
        private System.Windows.Forms.DataGridView dvMaterial_CodeRelation;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Data.DataTable schemadsMaterial_CodeRelation;
        private AppSvrHMI.L3DataSet dsMaterial_Code;
        private System.Data.DataTable schemadsMaterial_Code;
        private System.Data.DataColumn coldsMaterial_CodeL3DataTableGUID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableGUID;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableName;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableMaterial_Code;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableMaterial_Name;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableC;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableSi;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableMn;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableP;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableS;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableTi;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableFe;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableFeO;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableStd_Temp_Drop;
        private System.Data.DataColumn coldsMaterial_CodeRelationL3DataTableSeason_Temp_Drop;
        private System.Data.DataColumn coldsMaterial_CodeL3DataTableMaterial_Code;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdTempDropDataGridViewTextBoxColumn;
    }
}