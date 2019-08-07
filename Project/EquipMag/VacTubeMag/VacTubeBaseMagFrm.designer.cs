namespace EquipMag.VacTubeMag
{
    partial class VacTubeBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacTubeBaseMagFrm));
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnBuildStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuildEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFire = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHotOn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHotOff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnPosition = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOnBuildPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnFirePositionA = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnFirePositionB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnWorkPositionA = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnWorkPositionB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProcessStart = new System.Windows.Forms.ToolStripButton();
            this.btnProcessEnd = new System.Windows.Forms.ToolStripButton();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.btnCheckOver = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCold = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSmallRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWaitRapair = new System.Windows.Forms.ToolStripMenuItem();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableVacTube_Name = new System.Data.DataColumn();
            this.coldsBaseL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePosition = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsBaseL3DataTableBuild_ID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableInstall_ID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableVacTube_Age = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableVacTube_Code = new System.Data.DataColumn();
            this.coldsBaseL3DataTableFlag = new System.Data.DataColumn();
            this.coldsBaseL3DataTableFire_Count = new System.Data.DataColumn();
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
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBase = new System.Windows.Forms.DataGridView();
            this.dsName = new AppSvrHMI.L3DataSet();
            this.schemadsName = new System.Data.DataTable();
            this.coldsNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdBuildStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpBuildStart = new AppSvrHMI.L3CommandParameter();
            this.cmdBuildEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpBuildEnd = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpPreFireStart = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpPreFireEnd = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpBigFireStart = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpBigFireEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdHotOn = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHotOn = new AppSvrHMI.L3CommandParameter();
            this.cmdHotOff = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHotOff = new AppSvrHMI.L3CommandParameter();
            this.cmdOnPosition = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOnPosition = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpStopUse = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpWaitRepair = new AppSvrHMI.L3CommandParameter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VacTube_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacTube_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Install_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VacTube_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Build_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            this.bsBase.Sort = "";
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = true;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "VacTube_ID is not null order by VacTube_Name,VacTube_ID";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "VactubeBasebtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "VactubeBasebtnDelete");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuildStart
            // 
            this.Adapter.SetAccessRight(this.btnBuildStart, "VactubeBasebtnBuildStart");
            this.btnBuildStart.Name = "btnBuildStart";
            this.btnBuildStart.Size = new System.Drawing.Size(166, 22);
            this.btnBuildStart.Text = "真空槽管砌筑开始";
            this.btnBuildStart.Click += new System.EventHandler(this.btnBuildStart_Click);
            // 
            // btnBuildEnd
            // 
            this.Adapter.SetAccessRight(this.btnBuildEnd, "VactubeBasebtnBuildEnd");
            this.btnBuildEnd.Name = "btnBuildEnd";
            this.btnBuildEnd.Size = new System.Drawing.Size(166, 22);
            this.btnBuildEnd.Text = "真空槽砌管筑结束";
            this.btnBuildEnd.Click += new System.EventHandler(this.btnBuildEnd_Click);
            // 
            // btnInstall
            // 
            this.Adapter.SetAccessRight(this.btnInstall, "VactubeBasebtnInstall");
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(166, 22);
            this.btnInstall.Text = "真空槽组装";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnFire
            // 
            this.Adapter.SetAccessRight(this.btnFire, "VactubeBasebtnFire");
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(166, 22);
            this.btnFire.Text = "真空槽烘烤";
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnHotOn
            // 
            this.Adapter.SetAccessRight(this.btnHotOn, "VactubeBasebtnHotOn");
            this.btnHotOn.Name = "btnHotOn";
            this.btnHotOn.Size = new System.Drawing.Size(130, 22);
            this.btnHotOn.Text = "换上热弯管";
            this.btnHotOn.Click += new System.EventHandler(this.btnHotOn_Click);
            // 
            // btnHotOff
            // 
            this.Adapter.SetAccessRight(this.btnHotOff, "VactubeBasebtnHotOff");
            this.btnHotOff.Name = "btnHotOff";
            this.btnHotOff.Size = new System.Drawing.Size(130, 22);
            this.btnHotOff.Text = "换下热弯管";
            this.btnHotOff.Click += new System.EventHandler(this.btnHotOff_Click);
            // 
            // btnOnPosition
            // 
            this.Adapter.SetAccessRight(this.btnOnPosition, "VactubeBasebtnOnPosition");
            this.btnOnPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOnBuildPosition,
            this.btnOnFirePositionA,
            this.btnOnFirePositionB,
            this.btnOnWorkPositionA,
            this.btnOnWorkPositionB});
            this.btnOnPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnOnPosition.Image")));
            this.btnOnPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnPosition.Name = "btnOnPosition";
            this.btnOnPosition.Size = new System.Drawing.Size(122, 40);
            this.btnOnPosition.Text = "真空槽管上位";
            // 
            // btnOnBuildPosition
            // 
            this.btnOnBuildPosition.Name = "btnOnBuildPosition";
            this.btnOnBuildPosition.Size = new System.Drawing.Size(124, 22);
            this.btnOnBuildPosition.Text = "上砌筑位";
            this.btnOnBuildPosition.Click += new System.EventHandler(this.btnOnPosition_Click);
            // 
            // btnOnFirePositionA
            // 
            this.btnOnFirePositionA.Name = "btnOnFirePositionA";
            this.btnOnFirePositionA.Size = new System.Drawing.Size(124, 22);
            this.btnOnFirePositionA.Text = "上A烘烤位";
            this.btnOnFirePositionA.Click += new System.EventHandler(this.btnOnPosition_Click);
            // 
            // btnOnFirePositionB
            // 
            this.btnOnFirePositionB.Name = "btnOnFirePositionB";
            this.btnOnFirePositionB.Size = new System.Drawing.Size(124, 22);
            this.btnOnFirePositionB.Text = "上B烘烤位";
            this.btnOnFirePositionB.Click += new System.EventHandler(this.btnOnPosition_Click);
            // 
            // btnOnWorkPositionA
            // 
            this.btnOnWorkPositionA.Name = "btnOnWorkPositionA";
            this.btnOnWorkPositionA.Size = new System.Drawing.Size(124, 22);
            this.btnOnWorkPositionA.Text = "上A工位";
            this.btnOnWorkPositionA.Click += new System.EventHandler(this.btnOnPosition_Click);
            // 
            // btnOnWorkPositionB
            // 
            this.btnOnWorkPositionB.Name = "btnOnWorkPositionB";
            this.btnOnWorkPositionB.Size = new System.Drawing.Size(124, 22);
            this.btnOnWorkPositionB.Text = "上B工位";
            this.btnOnWorkPositionB.Click += new System.EventHandler(this.btnOnPosition_Click);
            // 
            // btnProcessStart
            // 
            this.Adapter.SetAccessRight(this.btnProcessStart, "VactubeBasebtnProcessStart");
            this.btnProcessStart.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessStart.Image")));
            this.btnProcessStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcessStart.Name = "btnProcessStart";
            this.btnProcessStart.Size = new System.Drawing.Size(89, 40);
            this.btnProcessStart.Text = "处理开始";
            this.btnProcessStart.Click += new System.EventHandler(this.btnProcessStart_Click);
            // 
            // btnProcessEnd
            // 
            this.Adapter.SetAccessRight(this.btnProcessEnd, "VactubeBasebtnProcessEnd");
            this.btnProcessEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessEnd.Image")));
            this.btnProcessEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcessEnd.Name = "btnProcessEnd";
            this.btnProcessEnd.Size = new System.Drawing.Size(89, 40);
            this.btnProcessEnd.Text = "处理结束";
            this.btnProcessEnd.Click += new System.EventHandler(this.btnProcessEnd_Click);
            // 
            // btnCheck
            // 
            this.Adapter.SetAccessRight(this.btnCheck, "VactubeBasebtnCheck");
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(89, 40);
            this.btnCheck.Text = "下线检查";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCheckOver
            // 
            this.Adapter.SetAccessRight(this.btnCheckOver, "VactubeBasebtnCheckOver");
            this.btnCheckOver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCold,
            this.btnSmallRepair,
            this.btnWaitRapair});
            this.btnCheckOver.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOver.Image")));
            this.btnCheckOver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckOver.Name = "btnCheckOver";
            this.btnCheckOver.Size = new System.Drawing.Size(98, 40);
            this.btnCheckOver.Text = "检查完毕";
            // 
            // btnCold
            // 
            this.btnCold.Name = "btnCold";
            this.btnCold.Size = new System.Drawing.Size(118, 22);
            this.btnCold.Tag = "1";
            this.btnCold.Text = "判为备用";
            this.btnCold.Click += new System.EventHandler(this.btnCheckOver_Click);
            // 
            // btnSmallRepair
            // 
            this.btnSmallRepair.Name = "btnSmallRepair";
            this.btnSmallRepair.Size = new System.Drawing.Size(118, 22);
            this.btnSmallRepair.Tag = "2";
            this.btnSmallRepair.Text = "离线小修";
            this.btnSmallRepair.Click += new System.EventHandler(this.btnCheckOver_Click);
            // 
            // btnWaitRapair
            // 
            this.btnWaitRapair.Name = "btnWaitRapair";
            this.btnWaitRapair.Size = new System.Drawing.Size(118, 22);
            this.btnWaitRapair.Tag = "3";
            this.btnWaitRapair.Text = "离线待修";
            this.btnWaitRapair.Click += new System.EventHandler(this.btnCheckOver_Click);
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableVacTube_Name,
            this.coldsBaseL3DataTableVacTube_ID,
            this.coldsBaseL3DataTableStatus,
            this.coldsBaseL3DataTablePosition,
            this.coldsBaseL3DataTableCheckFlag,
            this.coldsBaseL3DataTableBuild_ID,
            this.coldsBaseL3DataTableInstall_ID,
            this.coldsBaseL3DataTableVacTube_Age,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTableVacTube_Code,
            this.coldsBaseL3DataTableFlag,
            this.coldsBaseL3DataTableFire_Count});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableVacTube_Name
            // 
            this.coldsBaseL3DataTableVacTube_Name.Caption = "VacTube_Name";
            this.coldsBaseL3DataTableVacTube_Name.ColumnName = "VacTube_Name";
            this.coldsBaseL3DataTableVacTube_Name.Namespace = "";
            // 
            // coldsBaseL3DataTableVacTube_ID
            // 
            this.coldsBaseL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsBaseL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsBaseL3DataTableVacTube_ID.Namespace = "";
            // 
            // coldsBaseL3DataTableStatus
            // 
            this.coldsBaseL3DataTableStatus.Caption = "Status";
            this.coldsBaseL3DataTableStatus.ColumnName = "Status";
            this.coldsBaseL3DataTableStatus.Namespace = "";
            // 
            // coldsBaseL3DataTablePosition
            // 
            this.coldsBaseL3DataTablePosition.Caption = "Position";
            this.coldsBaseL3DataTablePosition.ColumnName = "Position";
            this.coldsBaseL3DataTablePosition.Namespace = "";
            // 
            // coldsBaseL3DataTableCheckFlag
            // 
            this.coldsBaseL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsBaseL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsBaseL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsBaseL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsBaseL3DataTableBuild_ID
            // 
            this.coldsBaseL3DataTableBuild_ID.Caption = "Build_ID";
            this.coldsBaseL3DataTableBuild_ID.ColumnName = "Build_ID";
            this.coldsBaseL3DataTableBuild_ID.Namespace = "";
            // 
            // coldsBaseL3DataTableInstall_ID
            // 
            this.coldsBaseL3DataTableInstall_ID.Caption = "Install_ID";
            this.coldsBaseL3DataTableInstall_ID.ColumnName = "Install_ID";
            this.coldsBaseL3DataTableInstall_ID.Namespace = "";
            // 
            // coldsBaseL3DataTableVacTube_Age
            // 
            this.coldsBaseL3DataTableVacTube_Age.Caption = "VacTube_Age";
            this.coldsBaseL3DataTableVacTube_Age.ColumnName = "VacTube_Age";
            this.coldsBaseL3DataTableVacTube_Age.DataType = typeof(int);
            this.coldsBaseL3DataTableVacTube_Age.Namespace = "";
            // 
            // coldsBaseL3DataTableHeatID
            // 
            this.coldsBaseL3DataTableHeatID.Caption = "HeatID";
            this.coldsBaseL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBaseL3DataTableHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTableVacTube_Code
            // 
            this.coldsBaseL3DataTableVacTube_Code.Caption = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.ColumnName = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.Namespace = "";
            // 
            // coldsBaseL3DataTableFlag
            // 
            this.coldsBaseL3DataTableFlag.Caption = "Flag";
            this.coldsBaseL3DataTableFlag.ColumnName = "Flag";
            this.coldsBaseL3DataTableFlag.DataType = typeof(int);
            this.coldsBaseL3DataTableFlag.Namespace = "";
            // 
            // coldsBaseL3DataTableFire_Count
            // 
            this.coldsBaseL3DataTableFire_Count.Caption = "Fire_Count";
            this.coldsBaseL3DataTableFire_Count.ColumnName = "Fire_Count";
            this.coldsBaseL3DataTableFire_Count.DataType = typeof(int);
            this.coldsBaseL3DataTableFire_Count.Namespace = "";
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBase;
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
            this.btnDelete});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.btnOnPosition,
            this.btnProcessStart,
            this.btnProcessEnd,
            this.btnCheck,
            this.btnCheckOver});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
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
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuildStart,
            this.btnBuildEnd,
            this.btnInstall,
            this.btnFire});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(86, 40);
            this.toolStripDropDownButton2.Text = "真空槽";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHotOn,
            this.btnHotOff});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(86, 40);
            this.toolStripDropDownButton3.Text = "热弯管";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBase);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvBase
            // 
            this.dvBase.AllowUserToAddRows = false;
            this.dvBase.AutoGenerateColumns = false;
            this.dvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.VacTube_ID,
            this.VacTube_Name,
            this.Install_ID,
            this.positionDataGridViewTextBoxColumn,
            this.Status,
            this.VacTube_Age,
            this.HeatID,
            this.Flag,
            this.Build_ID,
            this.dataGridViewTextBoxColumn1});
            this.dvBase.DataSource = this.bsBase;
            this.dvBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBase.Location = new System.Drawing.Point(0, 0);
            this.dvBase.Margin = new System.Windows.Forms.Padding(0);
            this.dvBase.Name = "dvBase";
            this.dvBase.RowTemplate.Height = 23;
            this.dvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvBase.Size = new System.Drawing.Size(1000, 632);
            this.dvBase.TabIndex = 31;
            this.dvBase.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBase_DataBindingComplete);
            this.dvBase.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // dsName
            // 
            this.dsName.AutoLoad = true;
            this.dsName.AutoSubscribe = true;
            this.dsName.DataSetName = "L3DataSet";
            this.dsName.DeleteMethod = null;
            this.dsName.InsertMethod = null;
            this.dsName.L3DataAdapter = this.Adapter;
            this.dsName.LoadEvent = "Click";
            this.dsName.LoadTrigger = null;
            this.dsName.RefreshValve = 1000;
            this.dsName.SourceCommand = null;
            this.dsName.SourceCondition = "Code_Group = \'VacTubeName\' order by Code";
            this.dsName.SourceMethod = "";
            this.dsName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsName.SubscribeTarget = null;
            this.dsName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsName});
            this.dsName.UpdateEvent = "Click";
            this.dsName.UpdateMethod = null;
            this.dsName.UpdateTrigger = null;
            // 
            // schemadsName
            // 
            this.schemadsName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNameL3DataTableCode,
            this.coldsNameL3DataTableCode_Des});
            this.schemadsName.TableName = "L3DataTable";
            // 
            // coldsNameL3DataTableCode
            // 
            this.coldsNameL3DataTableCode.Caption = "Code";
            this.coldsNameL3DataTableCode.ColumnName = "Code";
            this.coldsNameL3DataTableCode.Namespace = "";
            // 
            // coldsNameL3DataTableCode_Des
            // 
            this.coldsNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNameL3DataTableCode_Des.Namespace = "";
            // 
            // dsPosition
            // 
            this.dsPosition.AutoLoad = true;
            this.dsPosition.AutoSubscribe = true;
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = null;
            this.dsPosition.InsertMethod = null;
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "Click";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 1000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "Code_Group = \'VacTube_Position\' order by Code";
            this.dsPosition.SourceMethod = "";
            this.dsPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPosition.SubscribeTarget = null;
            this.dsPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPosition});
            this.dsPosition.UpdateEvent = "Click";
            this.dsPosition.UpdateMethod = null;
            this.dsPosition.UpdateTrigger = null;
            // 
            // schemadsPosition
            // 
            this.schemadsPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPositionL3DataTableCode,
            this.coldsPositionL3DataTableCode_Des});
            this.schemadsPosition.TableName = "L3DataTable";
            // 
            // coldsPositionL3DataTableCode
            // 
            this.coldsPositionL3DataTableCode.Caption = "Code";
            this.coldsPositionL3DataTableCode.ColumnName = "Code";
            this.coldsPositionL3DataTableCode.Namespace = "";
            // 
            // coldsPositionL3DataTableCode_Des
            // 
            this.coldsPositionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.Namespace = "";
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = true;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "Code_Group = \'VacTubeStatus\'";
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
            // cmdBuildStart
            // 
            this.cmdBuildStart.Adapter = this.Adapter;
            this.cmdBuildStart.MergeReturnTarget = false;
            this.cmdBuildStart.Method = "VacTubeBuildStart";
            this.cmdBuildStart.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdBuildStart.Parameters.Add(this.l3cmdpBuildStart);
            this.cmdBuildStart.ReturnTarget = null;
            this.cmdBuildStart.ReturnTargetProperty = null;
            this.cmdBuildStart.Trigger = null;
            this.cmdBuildStart.TriggerEvent = "Click";
            // 
            // l3cmdpBuildStart
            // 
            this.l3cmdpBuildStart.AcceptAfterExecuted = false;
            this.l3cmdpBuildStart.ConstantValue = null;
            this.l3cmdpBuildStart.MergeTarget = false;
            this.l3cmdpBuildStart.SourceFilter = null;
            this.l3cmdpBuildStart.SourceObject = this.dsBase;
            this.l3cmdpBuildStart.SourceProperty = "L3DataTable";
            this.l3cmdpBuildStart.TargetObject = null;
            this.l3cmdpBuildStart.TargetProperty = null;
            // 
            // cmdBuildEnd
            // 
            this.cmdBuildEnd.Adapter = this.Adapter;
            this.cmdBuildEnd.MergeReturnTarget = false;
            this.cmdBuildEnd.Method = "VacTubeBuildEnd";
            this.cmdBuildEnd.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdBuildEnd.Parameters.Add(this.l3cmdpBuildEnd);
            this.cmdBuildEnd.ReturnTarget = null;
            this.cmdBuildEnd.ReturnTargetProperty = null;
            this.cmdBuildEnd.Trigger = null;
            this.cmdBuildEnd.TriggerEvent = "Click";
            // 
            // l3cmdpBuildEnd
            // 
            this.l3cmdpBuildEnd.AcceptAfterExecuted = false;
            this.l3cmdpBuildEnd.ConstantValue = null;
            this.l3cmdpBuildEnd.MergeTarget = false;
            this.l3cmdpBuildEnd.SourceFilter = null;
            this.l3cmdpBuildEnd.SourceObject = this.dsBase;
            this.l3cmdpBuildEnd.SourceProperty = "L3DataTable";
            this.l3cmdpBuildEnd.TargetObject = null;
            this.l3cmdpBuildEnd.TargetProperty = null;
            // 
            // l3cmdpPreFireStart
            // 
            this.l3cmdpPreFireStart.AcceptAfterExecuted = false;
            this.l3cmdpPreFireStart.ConstantValue = null;
            this.l3cmdpPreFireStart.MergeTarget = false;
            this.l3cmdpPreFireStart.SourceFilter = null;
            this.l3cmdpPreFireStart.SourceObject = this.dsBase;
            this.l3cmdpPreFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpPreFireStart.TargetObject = null;
            this.l3cmdpPreFireStart.TargetProperty = null;
            // 
            // l3cmdpPreFireEnd
            // 
            this.l3cmdpPreFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpPreFireEnd.ConstantValue = null;
            this.l3cmdpPreFireEnd.MergeTarget = false;
            this.l3cmdpPreFireEnd.SourceFilter = null;
            this.l3cmdpPreFireEnd.SourceObject = this.dsBase;
            this.l3cmdpPreFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpPreFireEnd.TargetObject = null;
            this.l3cmdpPreFireEnd.TargetProperty = null;
            // 
            // l3cmdpBigFireStart
            // 
            this.l3cmdpBigFireStart.AcceptAfterExecuted = false;
            this.l3cmdpBigFireStart.ConstantValue = null;
            this.l3cmdpBigFireStart.MergeTarget = false;
            this.l3cmdpBigFireStart.SourceFilter = null;
            this.l3cmdpBigFireStart.SourceObject = this.dsBase;
            this.l3cmdpBigFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpBigFireStart.TargetObject = null;
            this.l3cmdpBigFireStart.TargetProperty = null;
            // 
            // l3cmdpBigFireEnd
            // 
            this.l3cmdpBigFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpBigFireEnd.ConstantValue = null;
            this.l3cmdpBigFireEnd.MergeTarget = false;
            this.l3cmdpBigFireEnd.SourceFilter = null;
            this.l3cmdpBigFireEnd.SourceObject = this.dsBase;
            this.l3cmdpBigFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpBigFireEnd.TargetObject = null;
            this.l3cmdpBigFireEnd.TargetProperty = null;
            // 
            // cmdHotOn
            // 
            this.cmdHotOn.Adapter = this.Adapter;
            this.cmdHotOn.MergeReturnTarget = false;
            this.cmdHotOn.Method = "HotOn";
            this.cmdHotOn.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdHotOn.Parameters.Add(this.l3cmdpHotOn);
            this.cmdHotOn.ReturnTarget = null;
            this.cmdHotOn.ReturnTargetProperty = null;
            this.cmdHotOn.Trigger = null;
            this.cmdHotOn.TriggerEvent = "Click";
            // 
            // l3cmdpHotOn
            // 
            this.l3cmdpHotOn.AcceptAfterExecuted = false;
            this.l3cmdpHotOn.ConstantValue = null;
            this.l3cmdpHotOn.MergeTarget = false;
            this.l3cmdpHotOn.SourceFilter = null;
            this.l3cmdpHotOn.SourceObject = this.dsBase;
            this.l3cmdpHotOn.SourceProperty = "L3DataTable";
            this.l3cmdpHotOn.TargetObject = null;
            this.l3cmdpHotOn.TargetProperty = null;
            // 
            // cmdHotOff
            // 
            this.cmdHotOff.Adapter = this.Adapter;
            this.cmdHotOff.MergeReturnTarget = false;
            this.cmdHotOff.Method = "HotOff";
            this.cmdHotOff.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdHotOff.Parameters.Add(this.l3cmdpHotOff);
            this.cmdHotOff.ReturnTarget = null;
            this.cmdHotOff.ReturnTargetProperty = null;
            this.cmdHotOff.Trigger = null;
            this.cmdHotOff.TriggerEvent = "Click";
            // 
            // l3cmdpHotOff
            // 
            this.l3cmdpHotOff.AcceptAfterExecuted = false;
            this.l3cmdpHotOff.ConstantValue = null;
            this.l3cmdpHotOff.MergeTarget = false;
            this.l3cmdpHotOff.SourceFilter = null;
            this.l3cmdpHotOff.SourceObject = this.dsBase;
            this.l3cmdpHotOff.SourceProperty = "L3DataTable";
            this.l3cmdpHotOff.TargetObject = null;
            this.l3cmdpHotOff.TargetProperty = null;
            // 
            // cmdOnPosition
            // 
            this.cmdOnPosition.Adapter = this.Adapter;
            this.cmdOnPosition.MergeReturnTarget = false;
            this.cmdOnPosition.Method = "VacTubeOnPosition";
            this.cmdOnPosition.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdOnPosition.Parameters.Add(this.l3cmdpOnPosition);
            this.cmdOnPosition.ReturnTarget = null;
            this.cmdOnPosition.ReturnTargetProperty = null;
            this.cmdOnPosition.Trigger = null;
            this.cmdOnPosition.TriggerEvent = "Click";
            // 
            // l3cmdpOnPosition
            // 
            this.l3cmdpOnPosition.AcceptAfterExecuted = false;
            this.l3cmdpOnPosition.ConstantValue = null;
            this.l3cmdpOnPosition.MergeTarget = false;
            this.l3cmdpOnPosition.SourceFilter = "";
            this.l3cmdpOnPosition.SourceObject = null;
            this.l3cmdpOnPosition.SourceProperty = "";
            this.l3cmdpOnPosition.TargetObject = null;
            this.l3cmdpOnPosition.TargetProperty = null;
            // 
            // l3cmdpStopUse
            // 
            this.l3cmdpStopUse.AcceptAfterExecuted = false;
            this.l3cmdpStopUse.ConstantValue = null;
            this.l3cmdpStopUse.MergeTarget = false;
            this.l3cmdpStopUse.SourceFilter = null;
            this.l3cmdpStopUse.SourceObject = this.dsBase;
            this.l3cmdpStopUse.SourceProperty = "L3DataTable";
            this.l3cmdpStopUse.TargetObject = null;
            this.l3cmdpStopUse.TargetProperty = null;
            // 
            // l3cmdpWaitRepair
            // 
            this.l3cmdpWaitRepair.AcceptAfterExecuted = false;
            this.l3cmdpWaitRepair.ConstantValue = null;
            this.l3cmdpWaitRepair.MergeTarget = false;
            this.l3cmdpWaitRepair.SourceFilter = null;
            this.l3cmdpWaitRepair.SourceObject = this.dsBase;
            this.l3cmdpWaitRepair.SourceProperty = "L3DataTable";
            this.l3cmdpWaitRepair.TargetObject = null;
            this.l3cmdpWaitRepair.TargetProperty = null;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VacTube_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "槽管编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VacTube_Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "槽管寿命";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Build_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "砌筑编号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Install_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "组装编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Build_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "砌筑编号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 87;
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
            // 
            // VacTube_ID
            // 
            this.VacTube_ID.DataPropertyName = "VacTube_ID";
            this.VacTube_ID.HeaderText = "槽管编号";
            this.VacTube_ID.Name = "VacTube_ID";
            this.VacTube_ID.ReadOnly = true;
            // 
            // VacTube_Name
            // 
            this.VacTube_Name.DataPropertyName = "VacTube_Name";
            this.VacTube_Name.DataSource = this.dsName;
            this.VacTube_Name.DisplayMember = "L3DataTable.Code_Des";
            this.VacTube_Name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VacTube_Name.HeaderText = "槽管名称";
            this.VacTube_Name.Name = "VacTube_Name";
            this.VacTube_Name.ReadOnly = true;
            this.VacTube_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VacTube_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VacTube_Name.ValueMember = "L3DataTable.Code";
            // 
            // Install_ID
            // 
            this.Install_ID.DataPropertyName = "VacTube_Code";
            this.Install_ID.HeaderText = "真空槽编号";
            this.Install_ID.Name = "Install_ID";
            this.Install_ID.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.DataSource = this.dsPosition;
            this.positionDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.positionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.positionDataGridViewTextBoxColumn.HeaderText = "位置";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            // 
            // VacTube_Age
            // 
            this.VacTube_Age.DataPropertyName = "VacTube_Age";
            this.VacTube_Age.HeaderText = "槽管寿命";
            this.VacTube_Age.Name = "VacTube_Age";
            this.VacTube_Age.ReadOnly = true;
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            this.HeatID.ReadOnly = true;
            // 
            // Flag
            // 
            this.Flag.DataPropertyName = "Flag";
            this.Flag.HeaderText = "完成标志";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            // 
            // Build_ID
            // 
            this.Build_ID.DataPropertyName = "Build_ID";
            this.Build_ID.HeaderText = "砌筑编号";
            this.Build_ID.Name = "Build_ID";
            this.Build_ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Install_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "组装编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // VacTubeBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VacTubeBaseMagFrm";
            this.TabText = "RH炉槽管基本信息管理";
            this.Text = "RH炉槽管基本信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VacTubeBaseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.VacTubeBaseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBase;
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
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBase;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripDropDownButton btnOnPosition;
        private System.Windows.Forms.ToolStripMenuItem btnOnBuildPosition;
        private System.Windows.Forms.ToolStripMenuItem btnOnFirePositionA;
        private System.Windows.Forms.ToolStripMenuItem btnOnFirePositionB;
        private System.Windows.Forms.ToolStripMenuItem btnOnWorkPositionA;
        private System.Windows.Forms.ToolStripMenuItem btnOnWorkPositionB;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnBuildStart;
        private System.Windows.Forms.ToolStripMenuItem btnBuildEnd;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnHotOn;
        private System.Windows.Forms.ToolStripMenuItem btnHotOff;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Name;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_ID;
        private System.Data.DataColumn coldsBaseL3DataTableStatus;
        private System.Data.DataColumn coldsBaseL3DataTablePosition;
        private System.Data.DataColumn coldsBaseL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsName;
        private System.Data.DataTable schemadsName;
        private System.Data.DataColumn coldsNameL3DataTableCode;
        private System.Data.DataColumn coldsNameL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdBuildStart;
        private AppSvrHMI.L3CommandParameter l3cmdpBuildStart;
        private AppSvrHMI.L3Command cmdBuildEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpBuildEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpPreFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpPreFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpBigFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpBigFireEnd;
        private AppSvrHMI.L3Command cmdHotOn;
        private AppSvrHMI.L3Command cmdHotOff;
        private AppSvrHMI.L3CommandParameter l3cmdpHotOn;
        private AppSvrHMI.L3CommandParameter l3cmdpHotOff;
        private AppSvrHMI.L3Command cmdOnPosition;
        private AppSvrHMI.L3CommandParameter l3cmdpOnPosition;
        private System.Windows.Forms.ToolStripButton btnProcessStart;
        private System.Windows.Forms.ToolStripButton btnProcessEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpStopUse;
        private AppSvrHMI.L3CommandParameter l3cmdpWaitRepair;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Data.DataColumn coldsBaseL3DataTableBuild_ID;
        private System.Data.DataColumn coldsBaseL3DataTableInstall_ID;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Age;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Code;
        private System.Data.DataColumn coldsBaseL3DataTableFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripMenuItem btnInstall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripMenuItem btnFire;
        private System.Data.DataColumn coldsBaseL3DataTableFire_Count;
        private System.Windows.Forms.ToolStripDropDownButton btnCheckOver;
        private System.Windows.Forms.ToolStripMenuItem btnCold;
        private System.Windows.Forms.ToolStripMenuItem btnSmallRepair;
        private System.Windows.Forms.ToolStripMenuItem btnWaitRapair;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacTube_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn VacTube_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Install_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacTube_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Build_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}