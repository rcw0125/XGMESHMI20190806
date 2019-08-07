namespace EquipMag.MoldMag
{
    partial class MoldBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoldBaseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsMold = new System.Windows.Forms.BindingSource(this.components);
            this.dsMold = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnInstallStrat = new System.Windows.Forms.ToolStripButton();
            this.btnInstallEnd = new System.Windows.Forms.ToolStripButton();
            this.btnOn = new System.Windows.Forms.ToolStripButton();
            this.btnChangeFlowID = new System.Windows.Forms.ToolStripButton();
            this.btnOffToBuild = new System.Windows.Forms.ToolStripButton();
            this.btnOff = new System.Windows.Forms.ToolStripButton();
            this.btnCheckCom = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCold = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.schemadsMold = new System.Data.DataTable();
            this.coldsMoldL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableBreak_Face_Mea = new System.Data.DataColumn();
            this.coldsMoldL3DataTableStatus = new System.Data.DataColumn();
            this.coldsMoldL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableFlowID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsMoldL3DataTableCopper_ID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsMoldL3DataTableInStallID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableUnitID = new System.Data.DataColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.tbLPMold = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvMold = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MoldID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCCM = new AppSvrHMI.L3DataSet();
            this.schemadsCCM = new System.Data.DataTable();
            this.coldsCCML3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCCML3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.Break_Face_Mea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStallID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cast_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FlowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copperFacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copperIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRefraFac = new AppSvrHMI.L3DataSet();
            this.cmdInstallStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpStart = new AppSvrHMI.L3CommandParameter();
            this.cmdInstallEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdOn = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOn = new AppSvrHMI.L3CommandParameter();
            this.cmdOff = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOff = new AppSvrHMI.L3CommandParameter();
            this.cmdBuild = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpBuild = new AppSvrHMI.L3CommandParameter();
            this.cmdCold = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpCold = new AppSvrHMI.L3CommandParameter();
            this.cmdOffToBuild = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOffToBuild = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeFlowID = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpMoldID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpFlowID = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.tbLPMold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMold
            // 
            this.bsMold.DataMember = "L3DataTable";
            this.bsMold.DataSource = this.dsMold;
            // 
            // dsMold
            // 
            this.dsMold.AutoLoad = true;
            this.dsMold.AutoSubscribe = true;
            this.dsMold.DataSetName = "L3DataSet";
            this.dsMold.DeleteMethod = null;
            this.dsMold.InsertMethod = null;
            this.dsMold.L3DataAdapter = this.Adapter;
            this.dsMold.LoadEvent = "Click";
            this.dsMold.LoadTrigger = null;
            this.dsMold.RefreshValve = 1000;
            this.dsMold.SourceCommand = null;
            this.dsMold.SourceCondition = "BREAK_FACE_MEA<>6  order by UnitID";
            this.dsMold.SourceMethod = "";
            this.dsMold.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMold.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMold.SubscribeTarget = null;
            this.dsMold.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMold});
            this.dsMold.UpdateEvent = "Click";
            this.dsMold.UpdateMethod = null;
            this.dsMold.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnInstallStrat
            // 
            this.Adapter.SetAccessRight(this.btnInstallStrat, "MoldbtnInstallStrat");
            this.btnInstallStrat.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallStrat.Image")));
            this.btnInstallStrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstallStrat.Name = "btnInstallStrat";
            this.btnInstallStrat.Size = new System.Drawing.Size(125, 40);
            this.btnInstallStrat.Text = "结晶器装配开始";
            this.btnInstallStrat.Click += new System.EventHandler(this.btnInstallStrat_Click);
            // 
            // btnInstallEnd
            // 
            this.Adapter.SetAccessRight(this.btnInstallEnd, "MoldbtnInstallEnd");
            this.btnInstallEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallEnd.Image")));
            this.btnInstallEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstallEnd.Name = "btnInstallEnd";
            this.btnInstallEnd.Size = new System.Drawing.Size(125, 40);
            this.btnInstallEnd.Text = "结晶器装配结束";
            this.btnInstallEnd.Click += new System.EventHandler(this.btnInstallEnd_Click);
            // 
            // btnOn
            // 
            this.Adapter.SetAccessRight(this.btnOn, "MoldbtnOn");
            this.btnOn.Image = ((System.Drawing.Image)(resources.GetObject("btnOn.Image")));
            this.btnOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(101, 40);
            this.btnOn.Text = "换上结晶器";
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnChangeFlowID
            // 
            this.Adapter.SetAccessRight(this.btnChangeFlowID, "MoldbtnChangeFlowID");
            this.btnChangeFlowID.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeFlowID.Image")));
            this.btnChangeFlowID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeFlowID.Name = "btnChangeFlowID";
            this.btnChangeFlowID.Size = new System.Drawing.Size(77, 40);
            this.btnChangeFlowID.Text = "换流别";
            this.btnChangeFlowID.Click += new System.EventHandler(this.btnChangeFlowID_Click);
            // 
            // btnOffToBuild
            // 
            this.Adapter.SetAccessRight(this.btnOffToBuild, "MoldbtnOffToBuild");
            this.btnOffToBuild.Image = ((System.Drawing.Image)(resources.GetObject("btnOffToBuild.Image")));
            this.btnOffToBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffToBuild.Name = "btnOffToBuild";
            this.btnOffToBuild.Size = new System.Drawing.Size(89, 40);
            this.btnOffToBuild.Text = "下线待装";
            this.btnOffToBuild.Click += new System.EventHandler(this.btnOffToBuild_Click);
            // 
            // btnOff
            // 
            this.Adapter.SetAccessRight(this.btnOff, "MoldbtnOff");
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(125, 40);
            this.btnOff.Text = "结晶器下线检测";
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnCheckCom
            // 
            this.Adapter.SetAccessRight(this.btnCheckCom, "MoldbtnCheckCom");
            this.btnCheckCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCold,
            this.btnBuild});
            this.btnCheckCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckCom.Image")));
            this.btnCheckCom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(134, 40);
            this.btnCheckCom.Text = "结晶器检测完毕";
            // 
            // btnCold
            // 
            this.btnCold.Name = "btnCold";
            this.btnCold.Size = new System.Drawing.Size(118, 22);
            this.btnCold.Text = "判为备用";
            this.btnCold.Click += new System.EventHandler(this.btnCold_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(118, 22);
            this.btnBuild.Text = "判为待装";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnAddMold");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "btnDeleteMold");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // schemadsMold
            // 
            this.schemadsMold.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldL3DataTableMoldID,
            this.coldsMoldL3DataTableBreak_Face_Mea,
            this.coldsMoldL3DataTableStatus,
            this.coldsMoldL3DataTableCast_ID,
            this.coldsMoldL3DataTableFlowID,
            this.coldsMoldL3DataTableCopper_Fac,
            this.coldsMoldL3DataTableCopper_ID,
            this.coldsMoldL3DataTableCheckFlag,
            this.coldsMoldL3DataTableInStallID,
            this.coldsMoldL3DataTableUnitID});
            this.schemadsMold.TableName = "L3DataTable";
            // 
            // coldsMoldL3DataTableMoldID
            // 
            this.coldsMoldL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldL3DataTableMoldID.Namespace = "";
            // 
            // coldsMoldL3DataTableBreak_Face_Mea
            // 
            this.coldsMoldL3DataTableBreak_Face_Mea.Caption = "Break_Face_Mea";
            this.coldsMoldL3DataTableBreak_Face_Mea.ColumnName = "Break_Face_Mea";
            this.coldsMoldL3DataTableBreak_Face_Mea.DataType = typeof(double);
            this.coldsMoldL3DataTableBreak_Face_Mea.Namespace = "";
            // 
            // coldsMoldL3DataTableStatus
            // 
            this.coldsMoldL3DataTableStatus.Caption = "Status";
            this.coldsMoldL3DataTableStatus.ColumnName = "Status";
            this.coldsMoldL3DataTableStatus.Namespace = "";
            // 
            // coldsMoldL3DataTableCast_ID
            // 
            this.coldsMoldL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsMoldL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsMoldL3DataTableCast_ID.Namespace = "";
            // 
            // coldsMoldL3DataTableFlowID
            // 
            this.coldsMoldL3DataTableFlowID.Caption = "FlowID";
            this.coldsMoldL3DataTableFlowID.ColumnName = "FlowID";
            this.coldsMoldL3DataTableFlowID.Namespace = "";
            // 
            // coldsMoldL3DataTableCopper_Fac
            // 
            this.coldsMoldL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsMoldL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsMoldL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsMoldL3DataTableCopper_ID
            // 
            this.coldsMoldL3DataTableCopper_ID.Caption = "Copper_ID";
            this.coldsMoldL3DataTableCopper_ID.ColumnName = "Copper_ID";
            this.coldsMoldL3DataTableCopper_ID.Namespace = "";
            // 
            // coldsMoldL3DataTableCheckFlag
            // 
            this.coldsMoldL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsMoldL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsMoldL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsMoldL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsMoldL3DataTableInStallID
            // 
            this.coldsMoldL3DataTableInStallID.Caption = "InStallID";
            this.coldsMoldL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsMoldL3DataTableInStallID.Namespace = "";
            // 
            // coldsMoldL3DataTableUnitID
            // 
            this.coldsMoldL3DataTableUnitID.Caption = "UnitID";
            this.coldsMoldL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsMoldL3DataTableUnitID.Namespace = "";
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
            this.dsStatus.SourceCondition = "Code_Group = \'MoldStatus\' order by Code";
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
            // tbLPMold
            // 
            this.tbLPMold.ColumnCount = 1;
            this.tbLPMold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPMold.Controls.Add(this.bdN1, 0, 1);
            this.tbLPMold.Controls.Add(this.tSp1, 0, 0);
            this.tbLPMold.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPMold.Location = new System.Drawing.Point(0, 0);
            this.tbLPMold.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPMold.Name = "tbLPMold";
            this.tbLPMold.RowCount = 3;
            this.tbLPMold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPMold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPMold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tbLPMold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPMold.Size = new System.Drawing.Size(1000, 700);
            this.tbLPMold.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsMold;
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
            this.toolStripLabel2});
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(733, 17);
            this.toolStripLabel2.Text = "说 明: 6#机断面8 代表‘150*150*800结晶器’，9 代表\'150*150*900结晶器\',16 代表‘160圆坯结晶器’，18 代表‘180圆坯结晶" +
                "器’";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnInstallStrat,
            this.btnInstallEnd,
            this.btnOn,
            this.btnChangeFlowID,
            this.btnOffToBuild,
            this.btnOff,
            this.btnCheckCom,
            this.toolStripButton1});
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvMold);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvMold
            // 
            this.dvMold.AllowUserToAddRows = false;
            this.dvMold.AutoGenerateColumns = false;
            this.dvMold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMold.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.MoldID,
            this.UnitID,
            this.Break_Face_Mea,
            this.InStallID,
            this.Status,
            this.Cast_ID,
            this.FlowID,
            this.copperFacDataGridViewTextBoxColumn,
            this.copperIDDataGridViewTextBoxColumn});
            this.dvMold.DataSource = this.bsMold;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMold.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMold.Location = new System.Drawing.Point(0, 0);
            this.dvMold.Margin = new System.Windows.Forms.Padding(0);
            this.dvMold.Name = "dvMold";
            this.dvMold.RowTemplate.Height = 23;
            this.dvMold.Size = new System.Drawing.Size(1000, 632);
            this.dvMold.TabIndex = 31;
            this.dvMold.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMold_DataError);
            this.dvMold.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMold_DataBindingComplete);
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
            this.checkFlagDataGridViewTextBoxColumn.Width = 54;
            // 
            // MoldID
            // 
            this.MoldID.DataPropertyName = "MoldID";
            this.MoldID.HeaderText = "结晶器编号";
            this.MoldID.Name = "MoldID";
            this.MoldID.ReadOnly = true;
            this.MoldID.Width = 90;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.DataSource = this.dsCCM;
            this.UnitID.DisplayMember = "L3DataTable.Code_Des";
            this.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnitID.HeaderText = "所属铸机";
            this.UnitID.Name = "UnitID";
            this.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitID.ValueMember = "L3DataTable.Code_Val_Str";
            this.UnitID.Width = 78;
            // 
            // dsCCM
            // 
            this.dsCCM.AutoLoad = true;
            this.dsCCM.AutoSubscribe = true;
            this.dsCCM.DataSetName = "L3DataSet";
            this.dsCCM.DeleteMethod = null;
            this.dsCCM.InsertMethod = null;
            this.dsCCM.L3DataAdapter = this.Adapter;
            this.dsCCM.LoadEvent = "Click";
            this.dsCCM.LoadTrigger = null;
            this.dsCCM.RefreshValve = 1000;
            this.dsCCM.SourceCommand = null;
            this.dsCCM.SourceCondition = "(Code_Group = \'Caster\'  or Code_Group = \'Caster34\')  and Code is not null order b" +
                "y Code";
            this.dsCCM.SourceMethod = "";
            this.dsCCM.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCM.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCCM.SubscribeTarget = null;
            this.dsCCM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCM});
            this.dsCCM.UpdateEvent = "Click";
            this.dsCCM.UpdateMethod = null;
            this.dsCCM.UpdateTrigger = null;
            // 
            // schemadsCCM
            // 
            this.schemadsCCM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCML3DataTableCode_Des,
            this.coldsCCML3DataTableCode_Val_Str});
            this.schemadsCCM.TableName = "L3DataTable";
            // 
            // coldsCCML3DataTableCode_Des
            // 
            this.coldsCCML3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCCML3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCCML3DataTableCode_Des.Namespace = "";
            // 
            // coldsCCML3DataTableCode_Val_Str
            // 
            this.coldsCCML3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsCCML3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsCCML3DataTableCode_Val_Str.Namespace = "";
            // 
            // Break_Face_Mea
            // 
            this.Break_Face_Mea.DataPropertyName = "Break_Face_Mea";
            this.Break_Face_Mea.HeaderText = "断面尺寸";
            this.Break_Face_Mea.Name = "Break_Face_Mea";
            this.Break_Face_Mea.ReadOnly = true;
            this.Break_Face_Mea.Width = 78;
            // 
            // InStallID
            // 
            this.InStallID.DataPropertyName = "InStallID";
            this.InStallID.HeaderText = "结晶器装配编号";
            this.InStallID.Name = "InStallID";
            this.InStallID.Width = 114;
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
            this.Status.Width = 54;
            // 
            // Cast_ID
            // 
            this.Cast_ID.DataPropertyName = "Cast_ID";
            this.Cast_ID.DataSource = this.dsCCM;
            this.Cast_ID.DisplayMember = "L3DataTable.Code_Des";
            this.Cast_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cast_ID.HeaderText = "在线情况";
            this.Cast_ID.Name = "Cast_ID";
            this.Cast_ID.ReadOnly = true;
            this.Cast_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cast_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cast_ID.ValueMember = "L3DataTable.Code_Val_Str";
            this.Cast_ID.Width = 78;
            // 
            // FlowID
            // 
            this.FlowID.DataPropertyName = "FlowID";
            this.FlowID.HeaderText = "流次";
            this.FlowID.Name = "FlowID";
            this.FlowID.ReadOnly = true;
            this.FlowID.Width = 54;
            // 
            // copperFacDataGridViewTextBoxColumn
            // 
            this.copperFacDataGridViewTextBoxColumn.DataPropertyName = "Copper_Fac";
            this.copperFacDataGridViewTextBoxColumn.HeaderText = "铜管(板)厂家";
            this.copperFacDataGridViewTextBoxColumn.Name = "copperFacDataGridViewTextBoxColumn";
            this.copperFacDataGridViewTextBoxColumn.ReadOnly = true;
            this.copperFacDataGridViewTextBoxColumn.Width = 102;
            // 
            // copperIDDataGridViewTextBoxColumn
            // 
            this.copperIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.copperIDDataGridViewTextBoxColumn.DataPropertyName = "Copper_ID";
            this.copperIDDataGridViewTextBoxColumn.HeaderText = "铜管(板)编号";
            this.copperIDDataGridViewTextBoxColumn.Name = "copperIDDataGridViewTextBoxColumn";
            this.copperIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsRefraFac
            // 
            this.dsRefraFac.AutoLoad = true;
            this.dsRefraFac.AutoSubscribe = true;
            this.dsRefraFac.DataSetName = "L3DataSet";
            this.dsRefraFac.DeleteMethod = null;
            this.dsRefraFac.InsertMethod = null;
            this.dsRefraFac.L3DataAdapter = null;
            this.dsRefraFac.LoadEvent = "Click";
            this.dsRefraFac.LoadTrigger = null;
            this.dsRefraFac.RefreshValve = 1000;
            this.dsRefraFac.SourceCommand = null;
            this.dsRefraFac.SourceCondition = null;
            this.dsRefraFac.SourceMethod = null;
            this.dsRefraFac.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsRefraFac.SourceURI = null;
            this.dsRefraFac.SubscribeTarget = null;
            this.dsRefraFac.UpdateEvent = "Click";
            this.dsRefraFac.UpdateMethod = null;
            this.dsRefraFac.UpdateTrigger = null;
            // 
            // cmdInstallStart
            // 
            this.cmdInstallStart.Adapter = this.Adapter;
            this.cmdInstallStart.MergeReturnTarget = false;
            this.cmdInstallStart.Method = "MoldInstallStart";
            this.cmdInstallStart.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdInstallStart.Parameters.Add(this.l3cmdpStart);
            this.cmdInstallStart.ReturnTarget = null;
            this.cmdInstallStart.ReturnTargetProperty = null;
            this.cmdInstallStart.Trigger = null;
            this.cmdInstallStart.TriggerEvent = "Click";
            // 
            // l3cmdpStart
            // 
            this.l3cmdpStart.AcceptAfterExecuted = false;
            this.l3cmdpStart.ConstantValue = null;
            this.l3cmdpStart.MergeTarget = false;
            this.l3cmdpStart.SourceFilter = "";
            this.l3cmdpStart.SourceObject = this.dsMold;
            this.l3cmdpStart.SourceProperty = "L3DataTable";
            this.l3cmdpStart.TargetObject = null;
            this.l3cmdpStart.TargetProperty = null;
            // 
            // cmdInstallEnd
            // 
            this.cmdInstallEnd.Adapter = this.Adapter;
            this.cmdInstallEnd.MergeReturnTarget = false;
            this.cmdInstallEnd.Method = "MoldInstallEnd";
            this.cmdInstallEnd.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdInstallEnd.Parameters.Add(this.l3cmdpEnd);
            this.cmdInstallEnd.ReturnTarget = null;
            this.cmdInstallEnd.ReturnTargetProperty = null;
            this.cmdInstallEnd.Trigger = null;
            this.cmdInstallEnd.TriggerEvent = "Click";
            // 
            // l3cmdpEnd
            // 
            this.l3cmdpEnd.AcceptAfterExecuted = false;
            this.l3cmdpEnd.ConstantValue = null;
            this.l3cmdpEnd.MergeTarget = false;
            this.l3cmdpEnd.SourceFilter = "";
            this.l3cmdpEnd.SourceObject = this.dsMold;
            this.l3cmdpEnd.SourceProperty = "L3DataTable";
            this.l3cmdpEnd.TargetObject = null;
            this.l3cmdpEnd.TargetProperty = null;
            // 
            // cmdOn
            // 
            this.cmdOn.Adapter = this.Adapter;
            this.cmdOn.MergeReturnTarget = false;
            this.cmdOn.Method = "MoldOnLine";
            this.cmdOn.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdOn.Parameters.Add(this.l3cmdpOn);
            this.cmdOn.ReturnTarget = null;
            this.cmdOn.ReturnTargetProperty = null;
            this.cmdOn.Trigger = null;
            this.cmdOn.TriggerEvent = "Click";
            // 
            // l3cmdpOn
            // 
            this.l3cmdpOn.AcceptAfterExecuted = false;
            this.l3cmdpOn.ConstantValue = null;
            this.l3cmdpOn.MergeTarget = false;
            this.l3cmdpOn.SourceFilter = "";
            this.l3cmdpOn.SourceObject = this.dsMold;
            this.l3cmdpOn.SourceProperty = "L3DataTable";
            this.l3cmdpOn.TargetObject = null;
            this.l3cmdpOn.TargetProperty = null;
            // 
            // cmdOff
            // 
            this.cmdOff.Adapter = this.Adapter;
            this.cmdOff.MergeReturnTarget = false;
            this.cmdOff.Method = "MoldOffLine";
            this.cmdOff.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdOff.Parameters.Add(this.l3cmdpOff);
            this.cmdOff.ReturnTarget = null;
            this.cmdOff.ReturnTargetProperty = null;
            this.cmdOff.Trigger = null;
            this.cmdOff.TriggerEvent = "Click";
            // 
            // l3cmdpOff
            // 
            this.l3cmdpOff.AcceptAfterExecuted = false;
            this.l3cmdpOff.ConstantValue = null;
            this.l3cmdpOff.MergeTarget = false;
            this.l3cmdpOff.SourceFilter = "";
            this.l3cmdpOff.SourceObject = this.dsMold;
            this.l3cmdpOff.SourceProperty = "L3DataTable";
            this.l3cmdpOff.TargetObject = null;
            this.l3cmdpOff.TargetProperty = null;
            // 
            // cmdBuild
            // 
            this.cmdBuild.Adapter = this.Adapter;
            this.cmdBuild.MergeReturnTarget = false;
            this.cmdBuild.Method = "MoldCheckBuild";
            this.cmdBuild.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdBuild.Parameters.Add(this.l3cmdpBuild);
            this.cmdBuild.ReturnTarget = null;
            this.cmdBuild.ReturnTargetProperty = null;
            this.cmdBuild.Trigger = null;
            this.cmdBuild.TriggerEvent = "Click";
            // 
            // l3cmdpBuild
            // 
            this.l3cmdpBuild.AcceptAfterExecuted = false;
            this.l3cmdpBuild.ConstantValue = null;
            this.l3cmdpBuild.MergeTarget = false;
            this.l3cmdpBuild.SourceFilter = null;
            this.l3cmdpBuild.SourceObject = this.dsMold;
            this.l3cmdpBuild.SourceProperty = "L3DataTable";
            this.l3cmdpBuild.TargetObject = null;
            this.l3cmdpBuild.TargetProperty = null;
            // 
            // cmdCold
            // 
            this.cmdCold.Adapter = this.Adapter;
            this.cmdCold.MergeReturnTarget = false;
            this.cmdCold.Method = "MoldCheckCold";
            this.cmdCold.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdCold.Parameters.Add(this.l3cmdpCold);
            this.cmdCold.ReturnTarget = null;
            this.cmdCold.ReturnTargetProperty = null;
            this.cmdCold.Trigger = null;
            this.cmdCold.TriggerEvent = "Click";
            // 
            // l3cmdpCold
            // 
            this.l3cmdpCold.AcceptAfterExecuted = false;
            this.l3cmdpCold.ConstantValue = null;
            this.l3cmdpCold.MergeTarget = false;
            this.l3cmdpCold.SourceFilter = null;
            this.l3cmdpCold.SourceObject = this.dsMold;
            this.l3cmdpCold.SourceProperty = "L3DataTable";
            this.l3cmdpCold.TargetObject = null;
            this.l3cmdpCold.TargetProperty = null;
            // 
            // cmdOffToBuild
            // 
            this.cmdOffToBuild.Adapter = this.Adapter;
            this.cmdOffToBuild.MergeReturnTarget = false;
            this.cmdOffToBuild.Method = "MoldCheckBuild";
            this.cmdOffToBuild.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdOffToBuild.Parameters.Add(this.l3cmdpOffToBuild);
            this.cmdOffToBuild.ReturnTarget = null;
            this.cmdOffToBuild.ReturnTargetProperty = null;
            this.cmdOffToBuild.Trigger = null;
            this.cmdOffToBuild.TriggerEvent = "Click";
            // 
            // l3cmdpOffToBuild
            // 
            this.l3cmdpOffToBuild.AcceptAfterExecuted = false;
            this.l3cmdpOffToBuild.ConstantValue = null;
            this.l3cmdpOffToBuild.MergeTarget = false;
            this.l3cmdpOffToBuild.SourceFilter = null;
            this.l3cmdpOffToBuild.SourceObject = this.dsMold;
            this.l3cmdpOffToBuild.SourceProperty = "L3DataTable";
            this.l3cmdpOffToBuild.TargetObject = null;
            this.l3cmdpOffToBuild.TargetProperty = null;
            // 
            // cmdChangeFlowID
            // 
            this.cmdChangeFlowID.Adapter = this.Adapter;
            this.cmdChangeFlowID.MergeReturnTarget = false;
            this.cmdChangeFlowID.Method = "MoldChangeFlowID";
            this.cmdChangeFlowID.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdChangeFlowID.Parameters.Add(this.l3cmdpMoldID);
            this.cmdChangeFlowID.Parameters.Add(this.l3cmdpFlowID);
            this.cmdChangeFlowID.ReturnTarget = null;
            this.cmdChangeFlowID.ReturnTargetProperty = null;
            this.cmdChangeFlowID.Trigger = null;
            this.cmdChangeFlowID.TriggerEvent = "Click";
            // 
            // l3cmdpMoldID
            // 
            this.l3cmdpMoldID.AcceptAfterExecuted = false;
            this.l3cmdpMoldID.ConstantValue = null;
            this.l3cmdpMoldID.MergeTarget = false;
            this.l3cmdpMoldID.SourceFilter = null;
            this.l3cmdpMoldID.SourceObject = null;
            this.l3cmdpMoldID.SourceProperty = null;
            this.l3cmdpMoldID.TargetObject = null;
            this.l3cmdpMoldID.TargetProperty = null;
            // 
            // l3cmdpFlowID
            // 
            this.l3cmdpFlowID.AcceptAfterExecuted = false;
            this.l3cmdpFlowID.ConstantValue = null;
            this.l3cmdpFlowID.MergeTarget = false;
            this.l3cmdpFlowID.SourceFilter = null;
            this.l3cmdpFlowID.SourceObject = null;
            this.l3cmdpFlowID.SourceProperty = null;
            this.l3cmdpFlowID.TargetObject = null;
            this.l3cmdpFlowID.TargetProperty = null;
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
            // MoldBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPMold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoldBaseMagFrm";
            this.TabText = "结晶器基本信息管理";
            this.Text = "结晶器基本信息管理";
            this.Load += new System.EventHandler(this.MoldBaseMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoldBaseMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.tbLPMold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMold;
        private System.Windows.Forms.BindingSource bsMold;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Windows.Forms.TableLayoutPanel tbLPMold;
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
        private AppSvrHMI.L3DataSet dsRefraFac;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripButton btnInstallStrat;
        private System.Windows.Forms.ToolStripButton btnInstallEnd;
        private System.Windows.Forms.ToolStripButton btnOn;
        private System.Windows.Forms.ToolStripButton btnOff;
        private System.Windows.Forms.DataGridView dvMold;
        private System.Data.DataTable schemadsMold;
        private System.Data.DataColumn coldsMoldL3DataTableMoldID;
        private System.Data.DataColumn coldsMoldL3DataTableBreak_Face_Mea;
        private System.Data.DataColumn coldsMoldL3DataTableStatus;
        private System.Data.DataColumn coldsMoldL3DataTableCast_ID;
        private System.Data.DataColumn coldsMoldL3DataTableFlowID;
        private System.Data.DataColumn coldsMoldL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsMoldL3DataTableCopper_ID;
        private System.Data.DataColumn coldsMoldL3DataTableCheckFlag;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdInstallStart;
        private AppSvrHMI.L3CommandParameter l3cmdpStart;
        private AppSvrHMI.L3Command cmdInstallEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpEnd;
        private AppSvrHMI.L3Command cmdOn;
        private AppSvrHMI.L3CommandParameter l3cmdpOn;
        private AppSvrHMI.L3Command cmdOff;
        private AppSvrHMI.L3CommandParameter l3cmdpOff;
        private System.Windows.Forms.ToolStripMenuItem btnCold;
        private System.Windows.Forms.ToolStripMenuItem btnBuild;
        private AppSvrHMI.L3Command cmdBuild;
        private AppSvrHMI.L3Command cmdCold;
        private AppSvrHMI.L3CommandParameter l3cmdpBuild;
        private AppSvrHMI.L3CommandParameter l3cmdpCold;
        private System.Windows.Forms.ToolStripDropDownButton btnCheckCom;
        private System.Windows.Forms.ToolStripButton btnOffToBuild;
        private AppSvrHMI.L3Command cmdOffToBuild;
        private AppSvrHMI.L3CommandParameter l3cmdpOffToBuild;
        private System.Data.DataColumn coldsMoldL3DataTableInStallID;
        private System.Windows.Forms.ToolStripButton btnChangeFlowID;
        private AppSvrHMI.L3Command cmdChangeFlowID;
        private AppSvrHMI.L3CommandParameter l3cmdpMoldID;
        private AppSvrHMI.L3CommandParameter l3cmdpFlowID;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Data.DataColumn coldsMoldL3DataTableUnitID;
        private AppSvrHMI.L3DataSet dsCCM;
        private System.Data.DataTable schemadsCCM;
        private System.Data.DataColumn coldsCCML3DataTableCode_Des;
        private System.Data.DataColumn coldsCCML3DataTableCode_Val_Str;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldID;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Break_Face_Mea;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStallID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cast_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn copperFacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copperIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
    }
}