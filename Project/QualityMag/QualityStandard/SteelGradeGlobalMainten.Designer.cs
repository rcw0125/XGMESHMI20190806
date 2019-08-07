namespace QualityMag.QualityStandard
{
    partial class SteelGradeGlobalMainten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelGradeGlobalMainten));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.bsSteelGradeIndexRelation = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelGradeIndexRelation = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndexRelation = new System.Data.DataTable();
            this.coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableProtocol = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1 = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2 = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note = new System.Data.DataColumn();
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
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
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeGroupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NC_ZYX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NC_ZYX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOF_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUse_Flag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableFirst_Flag = new System.Data.DataColumn();
            this.dsFlag = new AppSvrHMI.L3DataSet();
            this.cmdCopy = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
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
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnSteeGradeIndexMap");
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.Text = "取消 　";
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
            this.btnOutput.Font = new System.Drawing.Font("宋体", 10F);
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(176, 40);
            this.btnOutput.Text = "导出炼钢信息到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnCopy,
            this.toolStripSeparator5,
            this.btnCancel,
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
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(127, 40);
            this.btnCopy.Text = "复制炼钢记号";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
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
            this.dsSteelGradeIndexRelation.SourceCondition = "1=1 order by STEELGRADE";
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
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag,
            this.coldsSteelGradeIndexRelationL3DataTableProtocol,
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX1,
            this.coldsSteelGradeIndexRelationL3DataTableNC_ZYX2,
            this.coldsSteelGradeIndexRelationL3DataTableBOF_Note,
            this.coldsSteelGradeIndexRelationL3DataTableUse_Flag});
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
            // coldsSteelGradeIndexRelationL3DataTableFirst_Flag
            // 
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag.Caption = "First_Flag";
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag.ColumnName = "First_Flag";
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag.DataType = typeof(int);
            this.coldsSteelGradeIndexRelationL3DataTableFirst_Flag.Namespace = "";
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
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(61, 22);
            this.btnQuery.Text = "查询  ";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
            this.toolStripLabel6.Click += new System.EventHandler(this.toolStripLabel6_Click);
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
            this.dvSteelGradeIndexRelation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.gradeGroupCodeDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.NC_ZYX1,
            this.NC_ZYX2,
            this.BOF_Note,
            this.cmbUse_Flag});
            this.dvSteelGradeIndexRelation.DataSource = this.bsSteelGradeIndexRelation;
            this.dvSteelGradeIndexRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelGradeIndexRelation.Location = new System.Drawing.Point(0, 0);
            this.dvSteelGradeIndexRelation.MultiSelect = false;
            this.dvSteelGradeIndexRelation.Name = "dvSteelGradeIndexRelation";
            this.dvSteelGradeIndexRelation.ReadOnly = true;
            this.dvSteelGradeIndexRelation.RowTemplate.Height = 23;
            this.dvSteelGradeIndexRelation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSteelGradeIndexRelation.Size = new System.Drawing.Size(1016, 608);
            this.dvSteelGradeIndexRelation.TabIndex = 0;
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.ReadOnly = true;
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
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 70;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeDataGridViewTextBoxColumn.Width = 80;
            // 
            // gradeGroupCodeDataGridViewTextBoxColumn
            // 
            this.gradeGroupCodeDataGridViewTextBoxColumn.DataPropertyName = "Grade_Group_Code";
            this.gradeGroupCodeDataGridViewTextBoxColumn.HeaderText = "钢组";
            this.gradeGroupCodeDataGridViewTextBoxColumn.Name = "gradeGroupCodeDataGridViewTextBoxColumn";
            this.gradeGroupCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeGroupCodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "Protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "制造标准/协议";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NC_ZYX1
            // 
            this.NC_ZYX1.DataPropertyName = "NC_ZYX1";
            this.NC_ZYX1.HeaderText = "NC_ZYX1";
            this.NC_ZYX1.Name = "NC_ZYX1";
            this.NC_ZYX1.ReadOnly = true;
            // 
            // NC_ZYX2
            // 
            this.NC_ZYX2.DataPropertyName = "NC_ZYX2";
            this.NC_ZYX2.HeaderText = "NC_ZYX2";
            this.NC_ZYX2.Name = "NC_ZYX2";
            this.NC_ZYX2.ReadOnly = true;
            // 
            // BOF_Note
            // 
            this.BOF_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOF_Note.DataPropertyName = "BOF_Note";
            this.BOF_Note.HeaderText = "转炉冶炼要求";
            this.BOF_Note.Name = "BOF_Note";
            this.BOF_Note.ReadOnly = true;
            // 
            // cmbUse_Flag
            // 
            this.cmbUse_Flag.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cmbUse_Flag.HeaderText = "使用标志";
            this.cmbUse_Flag.Name = "cmbUse_Flag";
            this.cmbUse_Flag.ReadOnly = true;
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
            // cmdCopy
            // 
            this.cmdCopy.Adapter = this.Adapter;
            this.cmdCopy.MergeReturnTarget = false;
            this.cmdCopy.Method = "SteelGradeIndexCopy";
            this.cmdCopy.Object = "XGMESLogic\\QualityMag\\CQuality_Mag\\Quality_Mag";
            this.cmdCopy.Parameters.Add(this.l3CommandParameter1);
            this.cmdCopy.Parameters.Add(this.l3CommandParameter2);
            this.cmdCopy.ReturnTarget = null;
            this.cmdCopy.ReturnTargetProperty = null;
            this.cmdCopy.Trigger = null;
            this.cmdCopy.TriggerEvent = "Click";
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
            // SteelGradeGlobalMainten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProcTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelGradeGlobalMainten";
            this.TabText = "质量管理制造标准全局维护";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.SteelGradeGlobalMainten_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsSteelGradeIndexRelation;
        private AppSvrHMI.L3DataSet dsSteelGradeIndexRelation;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Data.DataTable schemadsSteelGradeIndexRelation;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableGrade_Group_Code;
        private System.Data.DataColumn coldsSteelGradeIndexRelationL3DataTableFirst_Flag;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeGroupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC_ZYX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC_ZYX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOF_Note;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbUse_Flag;
        private AppSvrHMI.L3Command cmdCopy;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
    }
}