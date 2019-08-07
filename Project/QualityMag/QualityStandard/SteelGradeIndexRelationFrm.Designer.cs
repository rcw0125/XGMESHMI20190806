namespace QualityMag.QualityStandard
{
    partial class SteelGradeIndexRelationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelGradeIndexRelationFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnRe = new System.Windows.Forms.ToolStripButton();
            this.bsSteelGradeIndexRelation = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelGradeIndexRelation = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndexRelation = new System.Data.DataTable();
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableProtocol = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1 = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2 = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
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
            this.dvSteelGradeIndexRelation = new System.Windows.Forms.DataGridView();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableFirst_Flag = new System.Data.DataColumn();
            this.dsFlag = new AppSvrHMI.L3DataSet();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type = new System.Data.DataColumn();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeGroupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCZYX1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCZYX2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUse_Flag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.steelGradeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProcTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnSteeGradeIndexMap");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnSteeGradeIndexMap");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnSteeGradeIndexMap");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnSteeGradeIndexMap");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnSteeGradeIndexMap");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "btnSteeGradeIndexMap");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutput
            // 
            this.Adapter.SetAccessRight(this.btnOutput, "btnSteeGradeIndexMap");
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(107, 40);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
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
            this.btnRe,
            this.toolStripSeparator5,
            this.btnOutput});
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
            // btnRe
            // 
            this.btnRe.Image = ((System.Drawing.Image)(resources.GetObject("btnRe.Image")));
            this.btnRe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(65, 40);
            this.btnRe.Text = "代表";
            this.btnRe.Visible = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // bsSteelGradeIndexRelation
            // 
            this.bsSteelGradeIndexRelation.DataMember = "L3DataTable";
            this.bsSteelGradeIndexRelation.DataSource = this.dsSteelGradeIndexRelation;
            // 
            // dsSteelGradeIndexRelation
            // 
            this.dsSteelGradeIndexRelation.AutoLoad = true;
            this.dsSteelGradeIndexRelation.AutoSubscribe = false;
            this.dsSteelGradeIndexRelation.DataSetName = "L3DataSet";
            this.dsSteelGradeIndexRelation.DeleteMethod = null;
            this.dsSteelGradeIndexRelation.InsertMethod = null;
            this.dsSteelGradeIndexRelation.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndexRelation.LoadEvent = "Click";
            this.dsSteelGradeIndexRelation.LoadTrigger = null;
            this.dsSteelGradeIndexRelation.RefreshValve = 1000;
            this.dsSteelGradeIndexRelation.SourceCommand = null;
            this.dsSteelGradeIndexRelation.SourceCondition = "1=2";
            this.dsSteelGradeIndexRelation.SourceMethod = "";
            this.dsSteelGradeIndexRelation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndexRelation.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndexRelation.SubscribeTarget = null;
            this.dsSteelGradeIndexRelation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndexRelation});
            this.dsSteelGradeIndexRelation.UpdateEvent = "Click";
            this.dsSteelGradeIndexRelation.UpdateMethod = null;
            this.dsSteelGradeIndexRelation.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndexRelation
            // 
            this.schemadsSteelGradeIndexRelation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex,
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade,
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code,
            this.coldsSteelGradeIndexRelationL3DataTableProtocol,
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1,
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2,
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note,
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag,
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type});
            this.schemadsSteelGradeIndexRelation.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableSteelGrade
            // 
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code
            // 
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code.Caption = "Grade_Group_Code";
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code.ColumnName = "Grade_Group_Code";
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableProtocol
            // 
            this.coldsSteelGradeIndexRelationL3DataTableProtocol.Caption = "Protocol";
            this.coldsSteelGradeIndexRelationL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsSteelGradeIndexRelationL3DataTableProtocol.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableNC_ZYX1
            // 
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1.Caption = "NC_ZYX1";
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1.ColumnName = "NC_ZYX1";
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableNC_ZYX2
            // 
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2.Caption = "NC_ZYX2";
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2.ColumnName = "NC_ZYX2";
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableBOF_Note
            // 
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note.Caption = "BOF_Note";
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note.ColumnName = "BOF_Note";
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableUse_Flag
            // 
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag.Caption = "Use_Flag";
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag.ColumnName = "Use_Flag";
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsSteelGradeIndexRelation;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.toolStripLabel6,
            this.txtSteelGrade,
            this.toolStripLabel2,
            this.cmbSteelGradeIndex,
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
            // txtSteelGrade
            // 
            this.txtSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "钢种:";
            // 
            // cmbSteelGradeIndex
            // 
            this.cmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSteelGradeIndex.Name = "cmbSteelGradeIndex";
            this.cmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "炼钢记号:";
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
            this.hmiRootPanelProcTime.Controls.Add(this.dvSteelGradeIndexRelation);
            this.hmiRootPanelProcTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProcTime.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProcTime.Name = "hmiRootPanelProcTime";
            this.hmiRootPanelProcTime.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProcTime.TabIndex = 18;
            // 
            // dvSteelGradeIndexRelation
            // 
            this.dvSteelGradeIndexRelation.AllowUserToAddRows = false;
            this.dvSteelGradeIndexRelation.AllowUserToDeleteRows = false;
            this.dvSteelGradeIndexRelation.AutoGenerateColumns = false;
            this.dvSteelGradeIndexRelation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteelGradeIndexRelation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.gradeGroupCodeDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.nCZYX1DataGridViewTextBoxColumn,
            this.nCZYX2DataGridViewTextBoxColumn,
            this.bOFNoteDataGridViewTextBoxColumn,
            this.cmbUse_Flag,
            this.steelGradeTypeDataGridViewTextBoxColumn});
            this.dvSteelGradeIndexRelation.DataSource = this.bsSteelGradeIndexRelation;
            this.dvSteelGradeIndexRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelGradeIndexRelation.Location = new System.Drawing.Point(0, 0);
            this.dvSteelGradeIndexRelation.MultiSelect = false;
            this.dvSteelGradeIndexRelation.Name = "dvSteelGradeIndexRelation";
            this.dvSteelGradeIndexRelation.RowTemplate.Height = 23;
            this.dvSteelGradeIndexRelation.Size = new System.Drawing.Size(1016, 608);
            this.dvSteelGradeIndexRelation.TabIndex = 0;
            this.dvSteelGradeIndexRelation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvSteelGradeIndexRelation_DataError);
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoLoad = true;
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = "steelgradeindex is not null order by SteelGradeIndex";
            this.dsSteelGradeIndex.SourceMethod = "";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = null;
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableGUID,
            this.coldsSteelGradeIndexL3DataTableName,
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex,
            this.coldsSteelGradeIndexL3DataTableSteelGrade,
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code,
            this.coldsSteelGradeIndexL3DataTableFirst_Flag});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableGUID
            // 
            this.coldsSteelGradeIndexL3DataTableGUID.Caption = "GUID";
            this.coldsSteelGradeIndexL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelGradeIndexL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableName
            // 
            this.coldsSteelGradeIndexL3DataTableName.Caption = "Name";
            this.coldsSteelGradeIndexL3DataTableName.ColumnName = "Name";
            this.coldsSteelGradeIndexL3DataTableName.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGrade
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableGrade_Group_Code
            // 
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.Caption = "Grade_Group_Code";
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.ColumnName = "Grade_Group_Code";
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableFirst_Flag
            // 
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.Caption = "First_Flag";
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.ColumnName = "First_Flag";
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.DataType = typeof(int);
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.Namespace = "";
            // 
            // dsFlag
            // 
            this.dsFlag.AutoLoad = true;
            this.dsFlag.AutoSubscribe = false;
            this.dsFlag.DataSetName = "L3DataSet";
            this.dsFlag.DeleteMethod = null;
            this.dsFlag.InsertMethod = null;
            this.dsFlag.L3DataAdapter = this.Adapter;
            this.dsFlag.LoadEvent = "Click";
            this.dsFlag.LoadTrigger = null;
            this.dsFlag.RefreshValve = 1000;
            this.dsFlag.SourceCommand = null;
            this.dsFlag.SourceCondition = "";
            this.dsFlag.SourceMethod = "";
            this.dsFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFlag.SourceURI = "";
            this.dsFlag.SubscribeTarget = null;
            this.dsFlag.UpdateEvent = "Click";
            this.dsFlag.UpdateMethod = null;
            this.dsFlag.UpdateTrigger = null;
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = null;
            this.dsSteelGrade.InsertMethod = null;
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "Click";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "code_group=\'steelgrade_type\'";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGrade.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "Click";
            this.dsSteelGrade.UpdateMethod = null;
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableCode,
            this.coldsSteelGradeL3DataTableCode_Des});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableCode
            // 
            this.coldsSteelGradeL3DataTableCode.Caption = "Code";
            this.coldsSteelGradeL3DataTableCode.ColumnName = "Code";
            this.coldsSteelGradeL3DataTableCode.Namespace = "";
            // 
            // coldsSteelGradeL3DataTableCode_Des
            // 
            this.coldsSteelGradeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelGradeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelGradeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type
            // 
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type.Caption = "SteelGrade_Type";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type.ColumnName = "SteelGrade_Type";
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type.Namespace = "";
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
            this.CheckFlag.Width = 20;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            // 
            // gradeGroupCodeDataGridViewTextBoxColumn
            // 
            this.gradeGroupCodeDataGridViewTextBoxColumn.DataPropertyName = "Grade_Group_Code";
            this.gradeGroupCodeDataGridViewTextBoxColumn.HeaderText = "钢组";
            this.gradeGroupCodeDataGridViewTextBoxColumn.Name = "gradeGroupCodeDataGridViewTextBoxColumn";
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "Protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "制造标准/协议";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            // 
            // nCZYX1DataGridViewTextBoxColumn
            // 
            this.nCZYX1DataGridViewTextBoxColumn.DataPropertyName = "NC_ZYX1";
            this.nCZYX1DataGridViewTextBoxColumn.HeaderText = "NC_ZYX1";
            this.nCZYX1DataGridViewTextBoxColumn.Name = "nCZYX1DataGridViewTextBoxColumn";
            // 
            // nCZYX2DataGridViewTextBoxColumn
            // 
            this.nCZYX2DataGridViewTextBoxColumn.DataPropertyName = "NC_ZYX2";
            this.nCZYX2DataGridViewTextBoxColumn.HeaderText = "NC_ZYX2";
            this.nCZYX2DataGridViewTextBoxColumn.Name = "nCZYX2DataGridViewTextBoxColumn";
            // 
            // bOFNoteDataGridViewTextBoxColumn
            // 
            this.bOFNoteDataGridViewTextBoxColumn.DataPropertyName = "BOF_Note";
            this.bOFNoteDataGridViewTextBoxColumn.HeaderText = "转炉冶炼要求";
            this.bOFNoteDataGridViewTextBoxColumn.Name = "bOFNoteDataGridViewTextBoxColumn";
            // 
            // cmbUse_Flag
            // 
            this.cmbUse_Flag.DataPropertyName = "Use_Flag";
            this.cmbUse_Flag.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cmbUse_Flag.HeaderText = "使用标志";
            this.cmbUse_Flag.Name = "cmbUse_Flag";
            this.cmbUse_Flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbUse_Flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // steelGradeTypeDataGridViewTextBoxColumn
            // 
            this.steelGradeTypeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade_Type";
            this.steelGradeTypeDataGridViewTextBoxColumn.DataSource = this.dsSteelGrade;
            this.steelGradeTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.steelGradeTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.steelGradeTypeDataGridViewTextBoxColumn.HeaderText = "钢种分类";
            this.steelGradeTypeDataGridViewTextBoxColumn.Name = "steelGradeTypeDataGridViewTextBoxColumn";
            this.steelGradeTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.steelGradeTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.steelGradeTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // SteelGradeIndexRelationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProcTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelGradeIndexRelationFrm";
            this.TabText = "炼钢记号钢种对照关系维护";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.SteelGradeIndexRelationFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelGradeIndexRelationFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProcTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
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
        private System.Windows.Forms.BindingSource bsSteelGradeIndexRelation;
        private AppSvrHMI.L3DataSet dsSteelGradeIndexRelation;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelProcTime;
        private System.Windows.Forms.DataGridView dvSteelGradeIndexRelation;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnRe;
        private System.Data.DataTable schemadsSteelGradeIndexRelation;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableGUID;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableName;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableGrade_Group_Code;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableFirst_Flag;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableProtocol;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableNC_ZYX1;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableNC_ZYX2;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableBOF_Note;
        private AppSvrHMI.L3DataSet dsFlag;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableUse_Flag;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableCode;
        private System.Data.DataColumn coldsSteelGradeL3DataTableCode_Des;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableSteelGrade_Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeGroupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCZYX1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCZYX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbUse_Flag;
        private System.Windows.Forms.DataGridViewComboBoxColumn steelGradeTypeDataGridViewTextBoxColumn;
    }
}