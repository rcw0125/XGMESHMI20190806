namespace UnitMag.BOFMag
{
    partial class StackMaintenanceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackMaintenanceFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bndsInnerFire = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new AppSvrHMI.L3DataSet();
            this.schemadsData = new System.Data.DataTable();
            this.coldsDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDataL3DataTableName = new System.Data.DataColumn();
            this.coldsDataL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsDataL3DataTableTeam = new System.Data.DataColumn();
            this.coldsDataL3DataTableContent = new System.Data.DataColumn();
            this.coldsDataL3DataTableMateriel = new System.Data.DataColumn();
            this.coldsDataL3DataTableTaphole_Vendor = new System.Data.DataColumn();
            this.coldsDataL3DataTableMateriel_Vendor = new System.Data.DataColumn();
            this.coldsDataL3DataTableWastage = new System.Data.DataColumn();
            this.coldsDataL3DataTableBOFID = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTeamID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvData = new System.Windows.Forms.DataGridView();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsContent = new AppSvrHMI.L3DataSet();
            this.schemadsContent = new System.Data.DataTable();
            this.coldsContentL3DataTableCode = new System.Data.DataColumn();
            this.coldsContentL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsMateriel = new AppSvrHMI.L3DataSet();
            this.schemadsMateriel = new System.Data.DataTable();
            this.coldsMaterielL3DataTableCode = new System.Data.DataColumn();
            this.coldsMaterielL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTaphole_Vendor = new AppSvrHMI.L3DataSet();
            this.schemadsTaphole_Vendor = new System.Data.DataTable();
            this.coldsTaphole_VendorL3DataTableCode = new System.Data.DataColumn();
            this.coldsTaphole_VendorL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsMateriel_Vendor = new AppSvrHMI.L3DataSet();
            this.schemadsMateriel_Vendor = new System.Data.DataTable();
            this.coldsMateriel_VendorL3DataTableCode = new System.Data.DataColumn();
            this.coldsMateriel_VendorL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDataL3DataTableSintering_Time = new System.Data.DataColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tapholeVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materielVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wastageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintering_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).BeginInit();
            this.bndsInnerFire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsData)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaphole_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTaphole_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriel_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMateriel_Vendor)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bndsInnerFire
            // 
            this.bndsInnerFire.AddNewItem = null;
            this.bndsInnerFire.AutoSize = false;
            this.bndsInnerFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bndsInnerFire.BackgroundImage")));
            this.bndsInnerFire.BindingSource = this.bsData;
            this.bndsInnerFire.CountItem = this.bindingNavigatorCountItem;
            this.bndsInnerFire.DeleteItem = null;
            this.bndsInnerFire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel5,
            this.cmbTeamID,
            this.toolStripLabel6,
            this.btnOutput});
            this.bndsInnerFire.Location = new System.Drawing.Point(0, 0);
            this.bndsInnerFire.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndsInnerFire.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndsInnerFire.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndsInnerFire.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndsInnerFire.Name = "bndsInnerFire";
            this.bndsInnerFire.PositionItem = this.bindingNavigatorPositionItem;
            this.bndsInnerFire.Size = new System.Drawing.Size(992, 25);
            this.bndsInnerFire.TabIndex = 28;
            this.bndsInnerFire.Text = "bindingNavigator1";
            // 
            // bsData
            // 
            this.bsData.DataMember = "L3DataTable";
            this.bsData.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.AutoLoad = true;
            this.dsData.AutoSubscribe = false;
            this.dsData.DataSetName = "L3DataSet";
            this.dsData.DeleteMethod = "";
            this.dsData.InsertMethod = "";
            this.dsData.L3DataAdapter = this.Adapter;
            this.dsData.LoadEvent = "";
            this.dsData.LoadTrigger = null;
            this.dsData.RefreshValve = 1000;
            this.dsData.SourceCommand = null;
            this.dsData.SourceCondition = "1=2";
            this.dsData.SourceMethod = "";
            this.dsData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsData.SourceURI = "XGMESLogic\\BOFMag\\CBOF_Stack_Maintenance";
            this.dsData.SubscribeTarget = "";
            this.dsData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsData});
            this.dsData.UpdateEvent = "";
            this.dsData.UpdateMethod = "";
            this.dsData.UpdateTrigger = null;
            // 
            // schemadsData
            // 
            this.schemadsData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDataL3DataTableGUID,
            this.coldsDataL3DataTableName,
            this.coldsDataL3DataTableProductionDate,
            this.coldsDataL3DataTableTeam,
            this.coldsDataL3DataTableContent,
            this.coldsDataL3DataTableMateriel,
            this.coldsDataL3DataTableTaphole_Vendor,
            this.coldsDataL3DataTableMateriel_Vendor,
            this.coldsDataL3DataTableWastage,
            this.coldsDataL3DataTableBOFID,
            this.coldsDataL3DataTableSintering_Time});
            this.schemadsData.TableName = "L3DataTable";
            // 
            // coldsDataL3DataTableGUID
            // 
            this.coldsDataL3DataTableGUID.Caption = "GUID";
            this.coldsDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsDataL3DataTableGUID.Namespace = "";
            // 
            // coldsDataL3DataTableName
            // 
            this.coldsDataL3DataTableName.Caption = "Name";
            this.coldsDataL3DataTableName.ColumnName = "Name";
            this.coldsDataL3DataTableName.Namespace = "";
            // 
            // coldsDataL3DataTableProductionDate
            // 
            this.coldsDataL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsDataL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsDataL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsDataL3DataTableProductionDate.Namespace = "";
            // 
            // coldsDataL3DataTableTeam
            // 
            this.coldsDataL3DataTableTeam.Caption = "Team";
            this.coldsDataL3DataTableTeam.ColumnName = "Team";
            this.coldsDataL3DataTableTeam.Namespace = "";
            // 
            // coldsDataL3DataTableContent
            // 
            this.coldsDataL3DataTableContent.Caption = "Content";
            this.coldsDataL3DataTableContent.ColumnName = "Content";
            this.coldsDataL3DataTableContent.Namespace = "";
            // 
            // coldsDataL3DataTableMateriel
            // 
            this.coldsDataL3DataTableMateriel.Caption = "Materiel";
            this.coldsDataL3DataTableMateriel.ColumnName = "Materiel";
            this.coldsDataL3DataTableMateriel.Namespace = "";
            // 
            // coldsDataL3DataTableTaphole_Vendor
            // 
            this.coldsDataL3DataTableTaphole_Vendor.Caption = "Taphole_Vendor";
            this.coldsDataL3DataTableTaphole_Vendor.ColumnName = "Taphole_Vendor";
            this.coldsDataL3DataTableTaphole_Vendor.Namespace = "";
            // 
            // coldsDataL3DataTableMateriel_Vendor
            // 
            this.coldsDataL3DataTableMateriel_Vendor.Caption = "Materiel_Vendor";
            this.coldsDataL3DataTableMateriel_Vendor.ColumnName = "Materiel_Vendor";
            this.coldsDataL3DataTableMateriel_Vendor.Namespace = "";
            // 
            // coldsDataL3DataTableWastage
            // 
            this.coldsDataL3DataTableWastage.Caption = "Wastage";
            this.coldsDataL3DataTableWastage.ColumnName = "Wastage";
            this.coldsDataL3DataTableWastage.Namespace = "";
            // 
            // coldsDataL3DataTableBOFID
            // 
            this.coldsDataL3DataTableBOFID.Caption = "BOFID";
            this.coldsDataL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsDataL3DataTableBOFID.Namespace = "";
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
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "  ";
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = " ";
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
            this.dtEnd.Text = "2008-11-18";
            this.dtEnd.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 197);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel3.Text = "-";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2008-11-18";
            this.dtStart.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 147);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "日期:";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTeamID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(121, 25);
            this.cmbTeamID.Visible = false;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "班组:";
            this.toolStripLabel6.Visible = false;
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvData);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(992, 451);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvData
            // 
            this.dvData.AllowUserToAddRows = false;
            this.dvData.AutoGenerateColumns = false;
            this.dvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionDateDataGridViewTextBoxColumn,
            this.BOFID,
            this.teamDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.materielDataGridViewTextBoxColumn,
            this.tapholeVendorDataGridViewTextBoxColumn,
            this.materielVendorDataGridViewTextBoxColumn,
            this.wastageDataGridViewTextBoxColumn,
            this.Sintering_Time});
            this.dvData.DataSource = this.bsData;
            this.dvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvData.Location = new System.Drawing.Point(0, 0);
            this.dvData.Name = "dvData";
            this.dvData.ReadOnly = true;
            this.dvData.RowTemplate.Height = 23;
            this.dvData.Size = new System.Drawing.Size(992, 451);
            this.dvData.TabIndex = 0;
            this.dvData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvData_DataError);
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = "";
            this.dsTeamID.InsertMethod = "";
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = "";
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "";
            this.dsTeamID.UpdateMethod = "";
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsContent
            // 
            this.dsContent.AutoLoad = true;
            this.dsContent.AutoSubscribe = false;
            this.dsContent.DataSetName = "L3DataSet";
            this.dsContent.DeleteMethod = "";
            this.dsContent.InsertMethod = "";
            this.dsContent.L3DataAdapter = this.Adapter;
            this.dsContent.LoadEvent = "";
            this.dsContent.LoadTrigger = null;
            this.dsContent.RefreshValve = 1000;
            this.dsContent.SourceCommand = null;
            this.dsContent.SourceCondition = "Code_Group = \'BOF_Stack_Content\'";
            this.dsContent.SourceMethod = "";
            this.dsContent.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsContent.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsContent.SubscribeTarget = "";
            this.dsContent.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsContent});
            this.dsContent.UpdateEvent = "";
            this.dsContent.UpdateMethod = "";
            this.dsContent.UpdateTrigger = null;
            // 
            // schemadsContent
            // 
            this.schemadsContent.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsContentL3DataTableCode,
            this.coldsContentL3DataTableCode_Des});
            this.schemadsContent.TableName = "L3DataTable";
            // 
            // coldsContentL3DataTableCode
            // 
            this.coldsContentL3DataTableCode.Caption = "Code";
            this.coldsContentL3DataTableCode.ColumnName = "Code";
            this.coldsContentL3DataTableCode.Namespace = "";
            // 
            // coldsContentL3DataTableCode_Des
            // 
            this.coldsContentL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsContentL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsContentL3DataTableCode_Des.Namespace = "";
            // 
            // dsMateriel
            // 
            this.dsMateriel.AutoLoad = true;
            this.dsMateriel.AutoSubscribe = false;
            this.dsMateriel.DataSetName = "L3DataSet";
            this.dsMateriel.DeleteMethod = "";
            this.dsMateriel.InsertMethod = "";
            this.dsMateriel.L3DataAdapter = this.Adapter;
            this.dsMateriel.LoadEvent = "";
            this.dsMateriel.LoadTrigger = null;
            this.dsMateriel.RefreshValve = 1000;
            this.dsMateriel.SourceCommand = null;
            this.dsMateriel.SourceCondition = "Code_Group = \'BOF_Stack_Materiel\'";
            this.dsMateriel.SourceMethod = "";
            this.dsMateriel.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMateriel.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMateriel.SubscribeTarget = "";
            this.dsMateriel.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMateriel});
            this.dsMateriel.UpdateEvent = "";
            this.dsMateriel.UpdateMethod = "";
            this.dsMateriel.UpdateTrigger = null;
            // 
            // schemadsMateriel
            // 
            this.schemadsMateriel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterielL3DataTableCode,
            this.coldsMaterielL3DataTableCode_Des});
            this.schemadsMateriel.TableName = "L3DataTable";
            // 
            // coldsMaterielL3DataTableCode
            // 
            this.coldsMaterielL3DataTableCode.Caption = "Code";
            this.coldsMaterielL3DataTableCode.ColumnName = "Code";
            this.coldsMaterielL3DataTableCode.Namespace = "";
            // 
            // coldsMaterielL3DataTableCode_Des
            // 
            this.coldsMaterielL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMaterielL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMaterielL3DataTableCode_Des.Namespace = "";
            // 
            // dsTaphole_Vendor
            // 
            this.dsTaphole_Vendor.AutoLoad = true;
            this.dsTaphole_Vendor.AutoSubscribe = false;
            this.dsTaphole_Vendor.DataSetName = "L3DataSet";
            this.dsTaphole_Vendor.DeleteMethod = "";
            this.dsTaphole_Vendor.InsertMethod = "";
            this.dsTaphole_Vendor.L3DataAdapter = this.Adapter;
            this.dsTaphole_Vendor.LoadEvent = "";
            this.dsTaphole_Vendor.LoadTrigger = null;
            this.dsTaphole_Vendor.RefreshValve = 1000;
            this.dsTaphole_Vendor.SourceCommand = null;
            this.dsTaphole_Vendor.SourceCondition = "Code_Group = \'BOF_Stack_Taphole_Vendor\'";
            this.dsTaphole_Vendor.SourceMethod = "";
            this.dsTaphole_Vendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTaphole_Vendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTaphole_Vendor.SubscribeTarget = "";
            this.dsTaphole_Vendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTaphole_Vendor});
            this.dsTaphole_Vendor.UpdateEvent = "";
            this.dsTaphole_Vendor.UpdateMethod = "";
            this.dsTaphole_Vendor.UpdateTrigger = null;
            // 
            // schemadsTaphole_Vendor
            // 
            this.schemadsTaphole_Vendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTaphole_VendorL3DataTableCode,
            this.coldsTaphole_VendorL3DataTableCode_Des});
            this.schemadsTaphole_Vendor.TableName = "L3DataTable";
            // 
            // coldsTaphole_VendorL3DataTableCode
            // 
            this.coldsTaphole_VendorL3DataTableCode.Caption = "Code";
            this.coldsTaphole_VendorL3DataTableCode.ColumnName = "Code";
            this.coldsTaphole_VendorL3DataTableCode.Namespace = "";
            // 
            // coldsTaphole_VendorL3DataTableCode_Des
            // 
            this.coldsTaphole_VendorL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTaphole_VendorL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTaphole_VendorL3DataTableCode_Des.Namespace = "";
            // 
            // dsMateriel_Vendor
            // 
            this.dsMateriel_Vendor.AutoLoad = true;
            this.dsMateriel_Vendor.AutoSubscribe = false;
            this.dsMateriel_Vendor.DataSetName = "L3DataSet";
            this.dsMateriel_Vendor.DeleteMethod = "";
            this.dsMateriel_Vendor.InsertMethod = "";
            this.dsMateriel_Vendor.L3DataAdapter = this.Adapter;
            this.dsMateriel_Vendor.LoadEvent = "";
            this.dsMateriel_Vendor.LoadTrigger = null;
            this.dsMateriel_Vendor.RefreshValve = 1000;
            this.dsMateriel_Vendor.SourceCommand = null;
            this.dsMateriel_Vendor.SourceCondition = "Code_Group = \'BOF_Stack_Materiel_Vendor\'";
            this.dsMateriel_Vendor.SourceMethod = "";
            this.dsMateriel_Vendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMateriel_Vendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMateriel_Vendor.SubscribeTarget = "";
            this.dsMateriel_Vendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMateriel_Vendor});
            this.dsMateriel_Vendor.UpdateEvent = "";
            this.dsMateriel_Vendor.UpdateMethod = "";
            this.dsMateriel_Vendor.UpdateTrigger = null;
            // 
            // schemadsMateriel_Vendor
            // 
            this.schemadsMateriel_Vendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMateriel_VendorL3DataTableCode,
            this.coldsMateriel_VendorL3DataTableCode_Des});
            this.schemadsMateriel_Vendor.TableName = "L3DataTable";
            // 
            // coldsMateriel_VendorL3DataTableCode
            // 
            this.coldsMateriel_VendorL3DataTableCode.Caption = "Code";
            this.coldsMateriel_VendorL3DataTableCode.ColumnName = "Code";
            this.coldsMateriel_VendorL3DataTableCode.Namespace = "";
            // 
            // coldsMateriel_VendorL3DataTableCode_Des
            // 
            this.coldsMateriel_VendorL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMateriel_VendorL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMateriel_VendorL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDataL3DataTableSintering_Time
            // 
            this.coldsDataL3DataTableSintering_Time.Caption = "Sintering_Time";
            this.coldsDataL3DataTableSintering_Time.ColumnName = "Sintering_Time";
            this.coldsDataL3DataTableSintering_Time.DataType = typeof(int);
            this.coldsDataL3DataTableSintering_Time.Namespace = "";
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.Frozen = true;
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BOFID
            // 
            this.BOFID.DataPropertyName = "BOFID";
            this.BOFID.Frozen = true;
            this.BOFID.HeaderText = "转炉";
            this.BOFID.Name = "BOFID";
            this.BOFID.ReadOnly = true;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.Frozen = true;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班组";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.DataSource = this.dsContent;
            this.contentDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.contentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.contentDataGridViewTextBoxColumn.Frozen = true;
            this.contentDataGridViewTextBoxColumn.HeaderText = "维护内容";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contentDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.contentDataGridViewTextBoxColumn.Width = 120;
            // 
            // materielDataGridViewTextBoxColumn
            // 
            this.materielDataGridViewTextBoxColumn.DataPropertyName = "Materiel";
            this.materielDataGridViewTextBoxColumn.DataSource = this.dsMateriel;
            this.materielDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.materielDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materielDataGridViewTextBoxColumn.Frozen = true;
            this.materielDataGridViewTextBoxColumn.HeaderText = "使用物料";
            this.materielDataGridViewTextBoxColumn.Name = "materielDataGridViewTextBoxColumn";
            this.materielDataGridViewTextBoxColumn.ReadOnly = true;
            this.materielDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materielDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materielDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.materielDataGridViewTextBoxColumn.Width = 120;
            // 
            // tapholeVendorDataGridViewTextBoxColumn
            // 
            this.tapholeVendorDataGridViewTextBoxColumn.DataPropertyName = "Taphole_Vendor";
            this.tapholeVendorDataGridViewTextBoxColumn.DataSource = this.dsTaphole_Vendor;
            this.tapholeVendorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tapholeVendorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tapholeVendorDataGridViewTextBoxColumn.Frozen = true;
            this.tapholeVendorDataGridViewTextBoxColumn.HeaderText = "出钢口厂家";
            this.tapholeVendorDataGridViewTextBoxColumn.Name = "tapholeVendorDataGridViewTextBoxColumn";
            this.tapholeVendorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tapholeVendorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tapholeVendorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tapholeVendorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tapholeVendorDataGridViewTextBoxColumn.Width = 150;
            // 
            // materielVendorDataGridViewTextBoxColumn
            // 
            this.materielVendorDataGridViewTextBoxColumn.DataPropertyName = "Materiel_Vendor";
            this.materielVendorDataGridViewTextBoxColumn.DataSource = this.dsMateriel_Vendor;
            this.materielVendorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.materielVendorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materielVendorDataGridViewTextBoxColumn.Frozen = true;
            this.materielVendorDataGridViewTextBoxColumn.HeaderText = "物料厂家";
            this.materielVendorDataGridViewTextBoxColumn.Name = "materielVendorDataGridViewTextBoxColumn";
            this.materielVendorDataGridViewTextBoxColumn.ReadOnly = true;
            this.materielVendorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materielVendorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materielVendorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.materielVendorDataGridViewTextBoxColumn.Width = 150;
            // 
            // wastageDataGridViewTextBoxColumn
            // 
            this.wastageDataGridViewTextBoxColumn.DataPropertyName = "Wastage";
            this.wastageDataGridViewTextBoxColumn.Frozen = true;
            this.wastageDataGridViewTextBoxColumn.HeaderText = "用料量[Kg]";
            this.wastageDataGridViewTextBoxColumn.Name = "wastageDataGridViewTextBoxColumn";
            this.wastageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sintering_Time
            // 
            this.Sintering_Time.DataPropertyName = "Sintering_Time";
            this.Sintering_Time.Frozen = true;
            this.Sintering_Time.HeaderText = "烧结时间";
            this.Sintering_Time.Name = "Sintering_Time";
            this.Sintering_Time.ReadOnly = true;
            // 
            // StackMaintenanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 476);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bndsInnerFire);
            this.Name = "StackMaintenanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "炉衬维护查询";
            this.Text = "炉衬维护查询";
            this.Load += new System.EventHandler(this.StackMaintenanceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).EndInit();
            this.bndsInnerFire.ResumeLayout(false);
            this.bndsInnerFire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsData)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaphole_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTaphole_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriel_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMateriel_Vendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bndsInnerFire;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvData;
        private System.Windows.Forms.BindingSource bsData;
        private AppSvrHMI.L3DataSet dsData;
        private System.Data.DataTable schemadsData;
        private System.Data.DataColumn coldsDataL3DataTableGUID;
        private System.Data.DataColumn coldsDataL3DataTableName;
        private System.Data.DataColumn coldsDataL3DataTableProductionDate;
        private System.Data.DataColumn coldsDataL3DataTableTeam;
        private System.Data.DataColumn coldsDataL3DataTableContent;
        private System.Data.DataColumn coldsDataL3DataTableMateriel;
        private System.Data.DataColumn coldsDataL3DataTableTaphole_Vendor;
        private System.Data.DataColumn coldsDataL3DataTableMateriel_Vendor;
        private System.Data.DataColumn coldsDataL3DataTableWastage;
        private AppSvrHMI.L3DataSet dsContent;
        private System.Data.DataTable schemadsContent;
        private System.Data.DataColumn coldsContentL3DataTableCode;
        private System.Data.DataColumn coldsContentL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMateriel;
        private System.Data.DataTable schemadsMateriel;
        private System.Data.DataColumn coldsMaterielL3DataTableCode;
        private System.Data.DataColumn coldsMaterielL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripComboBox cmbTeamID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsTaphole_Vendor;
        private System.Data.DataTable schemadsTaphole_Vendor;
        private System.Data.DataColumn coldsTaphole_VendorL3DataTableCode;
        private System.Data.DataColumn coldsTaphole_VendorL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMateriel_Vendor;
        private System.Data.DataTable schemadsMateriel_Vendor;
        private System.Data.DataColumn coldsMateriel_VendorL3DataTableCode;
        private System.Data.DataColumn coldsMateriel_VendorL3DataTableCode_Des;
        private System.Data.DataColumn coldsDataL3DataTableBOFID;
        private System.Data.DataColumn coldsDataL3DataTableSintering_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOFID;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tapholeVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materielVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wastageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintering_Time;
    }
}