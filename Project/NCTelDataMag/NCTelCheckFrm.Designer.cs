namespace NCTelDataMag
{
    partial class NCTelCheckFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCTelCheckFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTablescddh = new System.Data.DataColumn();
            this.coldsMainL3DataTablezdrid = new System.Data.DataColumn();
            this.coldsMainL3DataTablepch = new System.Data.DataColumn();
            this.coldsMainL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsMainL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsMainL3DataTableylbmid = new System.Data.DataColumn();
            this.coldsMainL3DataTablebljhdh = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue1 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue2 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue3 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue4 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue5 = new System.Data.DataColumn();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsMainL3DataTablezdrq = new System.Data.DataColumn();
            this.dsMaterial = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial = new System.Data.DataTable();
            this.coldsMaterialL3DataTablekgyid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableckckid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableckckbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefjldwid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableljcksl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefljcksl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepch = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegzzxid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegxh = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegcbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccostobject = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableflrq = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_moid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableObjectID = new System.Data.DataColumn();
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsLog = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBillType = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFlag = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableRemark = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCreateTime = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther3 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(895, 25);
            this.bnM.TabIndex = 31;
            this.bnM.Text = "bindingNavigator1";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "发送电文";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 303);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "描述";
            // 
            // txtRemark
            // 
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(3, 17);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(889, 283);
            this.txtRemark.TabIndex = 0;
            this.txtRemark.Text = "";
            // 
            // dvTel
            // 
            this.dvTel.AllowUserToAddRows = false;
            this.dvTel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvTel.ColumnHeadersHeight = 35;
            this.dvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.EnableHeadersVisualStyles = false;
            this.dvTel.Location = new System.Drawing.Point(0, 25);
            this.dvTel.MultiSelect = false;
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvTel.Size = new System.Drawing.Size(895, 266);
            this.dvTel.TabIndex = 34;
            this.dvTel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "炉号";
            this.Column1.HeaderText = "炉号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "错误时间";
            this.Column2.HeaderText = "错误时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "错误原因";
            this.Column3.HeaderText = "错误原因";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 800;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "电文类型：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "投料",
            "订单",
            "入库",
            "完工",
            "质检"});
            this.comboBox1.Location = new System.Drawing.Point(288, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 20);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableHeatID,
            this.coldsMainL3DataTableFlag,
            this.coldsMainL3DataTablescddh,
            this.coldsMainL3DataTablezdrid,
            this.coldsMainL3DataTablepch,
            this.coldsMainL3DataTablewlbmid,
            this.coldsMainL3DataTablejldwid,
            this.coldsMainL3DataTableylbmid,
            this.coldsMainL3DataTablebljhdh,
            this.coldsMainL3DataTablefreeitemvalue1,
            this.coldsMainL3DataTablefreeitemvalue2,
            this.coldsMainL3DataTablefreeitemvalue3,
            this.coldsMainL3DataTablefreeitemvalue4,
            this.coldsMainL3DataTablefreeitemvalue5,
            this.coldsMainL3DataTableObjectID,
            this.coldsMainL3DataTableNC_Confirm_Flag,
            this.coldsMainL3DataTableTreatNo,
            this.coldsMainL3DataTablezdrq});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableHeatID
            // 
            this.coldsMainL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainL3DataTableFlag
            // 
            this.coldsMainL3DataTableFlag.Caption = "Flag";
            this.coldsMainL3DataTableFlag.ColumnName = "Flag";
            this.coldsMainL3DataTableFlag.Namespace = "";
            // 
            // coldsMainL3DataTablescddh
            // 
            this.coldsMainL3DataTablescddh.Caption = "scddh";
            this.coldsMainL3DataTablescddh.ColumnName = "scddh";
            this.coldsMainL3DataTablescddh.Namespace = "";
            // 
            // coldsMainL3DataTablezdrid
            // 
            this.coldsMainL3DataTablezdrid.Caption = "zdrid";
            this.coldsMainL3DataTablezdrid.ColumnName = "zdrid";
            this.coldsMainL3DataTablezdrid.Namespace = "";
            // 
            // coldsMainL3DataTablepch
            // 
            this.coldsMainL3DataTablepch.Caption = "pch";
            this.coldsMainL3DataTablepch.ColumnName = "pch";
            this.coldsMainL3DataTablepch.Namespace = "";
            // 
            // coldsMainL3DataTablewlbmid
            // 
            this.coldsMainL3DataTablewlbmid.Caption = "wlbmid";
            this.coldsMainL3DataTablewlbmid.ColumnName = "wlbmid";
            this.coldsMainL3DataTablewlbmid.Namespace = "";
            // 
            // coldsMainL3DataTablejldwid
            // 
            this.coldsMainL3DataTablejldwid.Caption = "jldwid";
            this.coldsMainL3DataTablejldwid.ColumnName = "jldwid";
            this.coldsMainL3DataTablejldwid.Namespace = "";
            // 
            // coldsMainL3DataTableylbmid
            // 
            this.coldsMainL3DataTableylbmid.Caption = "ylbmid";
            this.coldsMainL3DataTableylbmid.ColumnName = "ylbmid";
            this.coldsMainL3DataTableylbmid.Namespace = "";
            // 
            // coldsMainL3DataTablebljhdh
            // 
            this.coldsMainL3DataTablebljhdh.Caption = "bljhdh";
            this.coldsMainL3DataTablebljhdh.ColumnName = "bljhdh";
            this.coldsMainL3DataTablebljhdh.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue1
            // 
            this.coldsMainL3DataTablefreeitemvalue1.Caption = "freeitemvalue1";
            this.coldsMainL3DataTablefreeitemvalue1.ColumnName = "freeitemvalue1";
            this.coldsMainL3DataTablefreeitemvalue1.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue2
            // 
            this.coldsMainL3DataTablefreeitemvalue2.Caption = "freeitemvalue2";
            this.coldsMainL3DataTablefreeitemvalue2.ColumnName = "freeitemvalue2";
            this.coldsMainL3DataTablefreeitemvalue2.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue3
            // 
            this.coldsMainL3DataTablefreeitemvalue3.Caption = "freeitemvalue3";
            this.coldsMainL3DataTablefreeitemvalue3.ColumnName = "freeitemvalue3";
            this.coldsMainL3DataTablefreeitemvalue3.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue4
            // 
            this.coldsMainL3DataTablefreeitemvalue4.Caption = "freeitemvalue4";
            this.coldsMainL3DataTablefreeitemvalue4.ColumnName = "freeitemvalue4";
            this.coldsMainL3DataTablefreeitemvalue4.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue5
            // 
            this.coldsMainL3DataTablefreeitemvalue5.Caption = "freeitemvalue5";
            this.coldsMainL3DataTablefreeitemvalue5.ColumnName = "freeitemvalue5";
            this.coldsMainL3DataTablefreeitemvalue5.Namespace = "";
            // 
            // coldsMainL3DataTableObjectID
            // 
            this.coldsMainL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMainL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMainL3DataTableObjectID.Namespace = "";
            // 
            // coldsMainL3DataTableNC_Confirm_Flag
            // 
            this.coldsMainL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableTreatNo
            // 
            this.coldsMainL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsMainL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsMainL3DataTableTreatNo.Namespace = "";
            // 
            // coldsMainL3DataTablezdrq
            // 
            this.coldsMainL3DataTablezdrq.Caption = "zdrq";
            this.coldsMainL3DataTablezdrq.ColumnName = "zdrq";
            this.coldsMainL3DataTablezdrq.Namespace = "";
            // 
            // dsMaterial
            // 
            this.dsMaterial.AutoLoad = true;
            this.dsMaterial.AutoSubscribe = false;
            this.dsMaterial.DataSetName = "L3DataSet";
            this.dsMaterial.DeleteMethod = "";
            this.dsMaterial.InsertMethod = "";
            this.dsMaterial.L3DataAdapter = null;
            this.dsMaterial.LoadEvent = "";
            this.dsMaterial.LoadTrigger = null;
            this.dsMaterial.RefreshValve = 1000;
            this.dsMaterial.SourceCommand = null;
            this.dsMaterial.SourceCondition = "";
            this.dsMaterial.SourceMethod = "";
            this.dsMaterial.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMaterial.SourceURI = "";
            this.dsMaterial.SubscribeTarget = null;
            this.dsMaterial.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial});
            this.dsMaterial.UpdateEvent = "";
            this.dsMaterial.UpdateMethod = "";
            this.dsMaterial.UpdateTrigger = null;
            // 
            // schemadsMaterial
            // 
            this.schemadsMaterial.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterialL3DataTablekgyid,
            this.coldsMaterialL3DataTableckckid,
            this.coldsMaterialL3DataTableckckbm,
            this.coldsMaterialL3DataTablewlbmid,
            this.coldsMaterialL3DataTablejldwid,
            this.coldsMaterialL3DataTablefjldwid,
            this.coldsMaterialL3DataTableljcksl,
            this.coldsMaterialL3DataTablefljcksl,
            this.coldsMaterialL3DataTablepch,
            this.coldsMaterialL3DataTablegzzxid,
            this.coldsMaterialL3DataTablegxh,
            this.coldsMaterialL3DataTablezdy1,
            this.coldsMaterialL3DataTablezdy2,
            this.coldsMaterialL3DataTablezdy3,
            this.coldsMaterialL3DataTablezdy4,
            this.coldsMaterialL3DataTablezdy5,
            this.coldsMaterialL3DataTablezyx1,
            this.coldsMaterialL3DataTablezyx2,
            this.coldsMaterialL3DataTablezyx3,
            this.coldsMaterialL3DataTablezyx4,
            this.coldsMaterialL3DataTablezyx5,
            this.coldsMaterialL3DataTablepk_corp,
            this.coldsMaterialL3DataTablegcbm,
            this.coldsMaterialL3DataTableccostobject,
            this.coldsMaterialL3DataTableflrq,
            this.coldsMaterialL3DataTablepk_moid,
            this.coldsMaterialL3DataTableObjectID});
            this.schemadsMaterial.TableName = "L3DataTable";
            // 
            // coldsMaterialL3DataTablekgyid
            // 
            this.coldsMaterialL3DataTablekgyid.Caption = "kgyid";
            this.coldsMaterialL3DataTablekgyid.ColumnName = "kgyid";
            this.coldsMaterialL3DataTablekgyid.Namespace = "";
            // 
            // coldsMaterialL3DataTableckckid
            // 
            this.coldsMaterialL3DataTableckckid.Caption = "ckckid";
            this.coldsMaterialL3DataTableckckid.ColumnName = "ckckid";
            this.coldsMaterialL3DataTableckckid.Namespace = "";
            // 
            // coldsMaterialL3DataTableckckbm
            // 
            this.coldsMaterialL3DataTableckckbm.Caption = "ckckbm";
            this.coldsMaterialL3DataTableckckbm.ColumnName = "ckckbm";
            this.coldsMaterialL3DataTableckckbm.Namespace = "";
            // 
            // coldsMaterialL3DataTablewlbmid
            // 
            this.coldsMaterialL3DataTablewlbmid.Caption = "wlbmid";
            this.coldsMaterialL3DataTablewlbmid.ColumnName = "wlbmid";
            this.coldsMaterialL3DataTablewlbmid.Namespace = "";
            // 
            // coldsMaterialL3DataTablejldwid
            // 
            this.coldsMaterialL3DataTablejldwid.Caption = "jldwid";
            this.coldsMaterialL3DataTablejldwid.ColumnName = "jldwid";
            this.coldsMaterialL3DataTablejldwid.Namespace = "";
            // 
            // coldsMaterialL3DataTablefjldwid
            // 
            this.coldsMaterialL3DataTablefjldwid.Caption = "fjldwid";
            this.coldsMaterialL3DataTablefjldwid.ColumnName = "fjldwid";
            this.coldsMaterialL3DataTablefjldwid.Namespace = "";
            // 
            // coldsMaterialL3DataTableljcksl
            // 
            this.coldsMaterialL3DataTableljcksl.Caption = "ljcksl";
            this.coldsMaterialL3DataTableljcksl.ColumnName = "ljcksl";
            this.coldsMaterialL3DataTableljcksl.Namespace = "";
            // 
            // coldsMaterialL3DataTablefljcksl
            // 
            this.coldsMaterialL3DataTablefljcksl.Caption = "fljcksl";
            this.coldsMaterialL3DataTablefljcksl.ColumnName = "fljcksl";
            this.coldsMaterialL3DataTablefljcksl.Namespace = "";
            // 
            // coldsMaterialL3DataTablepch
            // 
            this.coldsMaterialL3DataTablepch.Caption = "pch";
            this.coldsMaterialL3DataTablepch.ColumnName = "pch";
            this.coldsMaterialL3DataTablepch.Namespace = "";
            // 
            // coldsMaterialL3DataTablegzzxid
            // 
            this.coldsMaterialL3DataTablegzzxid.Caption = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.ColumnName = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.Namespace = "";
            // 
            // coldsMaterialL3DataTablegxh
            // 
            this.coldsMaterialL3DataTablegxh.Caption = "gxh";
            this.coldsMaterialL3DataTablegxh.ColumnName = "gxh";
            this.coldsMaterialL3DataTablegxh.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy1
            // 
            this.coldsMaterialL3DataTablezdy1.Caption = "zdy1";
            this.coldsMaterialL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsMaterialL3DataTablezdy1.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy2
            // 
            this.coldsMaterialL3DataTablezdy2.Caption = "zdy2";
            this.coldsMaterialL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsMaterialL3DataTablezdy2.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy3
            // 
            this.coldsMaterialL3DataTablezdy3.Caption = "zdy3";
            this.coldsMaterialL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsMaterialL3DataTablezdy3.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy4
            // 
            this.coldsMaterialL3DataTablezdy4.Caption = "zdy4";
            this.coldsMaterialL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsMaterialL3DataTablezdy4.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy5
            // 
            this.coldsMaterialL3DataTablezdy5.Caption = "zdy5";
            this.coldsMaterialL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsMaterialL3DataTablezdy5.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx1
            // 
            this.coldsMaterialL3DataTablezyx1.Caption = "zyx1";
            this.coldsMaterialL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsMaterialL3DataTablezyx1.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx2
            // 
            this.coldsMaterialL3DataTablezyx2.Caption = "zyx2";
            this.coldsMaterialL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsMaterialL3DataTablezyx2.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx3
            // 
            this.coldsMaterialL3DataTablezyx3.Caption = "zyx3";
            this.coldsMaterialL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsMaterialL3DataTablezyx3.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx4
            // 
            this.coldsMaterialL3DataTablezyx4.Caption = "zyx4";
            this.coldsMaterialL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsMaterialL3DataTablezyx4.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx5
            // 
            this.coldsMaterialL3DataTablezyx5.Caption = "zyx5";
            this.coldsMaterialL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsMaterialL3DataTablezyx5.Namespace = "";
            // 
            // coldsMaterialL3DataTablepk_corp
            // 
            this.coldsMaterialL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsMaterialL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsMaterialL3DataTablepk_corp.Namespace = "";
            // 
            // coldsMaterialL3DataTablegcbm
            // 
            this.coldsMaterialL3DataTablegcbm.Caption = "gcbm";
            this.coldsMaterialL3DataTablegcbm.ColumnName = "gcbm";
            this.coldsMaterialL3DataTablegcbm.Namespace = "";
            // 
            // coldsMaterialL3DataTableccostobject
            // 
            this.coldsMaterialL3DataTableccostobject.Caption = "ccostobject";
            this.coldsMaterialL3DataTableccostobject.ColumnName = "ccostobject";
            this.coldsMaterialL3DataTableccostobject.Namespace = "";
            // 
            // coldsMaterialL3DataTableflrq
            // 
            this.coldsMaterialL3DataTableflrq.Caption = "flrq";
            this.coldsMaterialL3DataTableflrq.ColumnName = "flrq";
            this.coldsMaterialL3DataTableflrq.Namespace = "";
            // 
            // coldsMaterialL3DataTablepk_moid
            // 
            this.coldsMaterialL3DataTablepk_moid.Caption = "pk_moid";
            this.coldsMaterialL3DataTablepk_moid.ColumnName = "pk_moid";
            this.coldsMaterialL3DataTablepk_moid.Namespace = "";
            // 
            // coldsMaterialL3DataTableObjectID
            // 
            this.coldsMaterialL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.Namespace = "";
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = this.Adapter;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = "SendAddMaterialsInfor";
            this.cmdMain.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdMain.Parameters.Add(this.l3CommandParameter1);
            this.cmdMain.Parameters.Add(this.l3CommandParameter2);
            this.cmdMain.ReturnTarget = this.dsMaterial;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
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
            this.l3CommandParameter2.SourceObject = this.dsMain;
            this.l3CommandParameter2.SourceProperty = "";
            this.l3CommandParameter2.TargetObject = this.dsMain;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsLog
            // 
            this.dsLog.AutoLoad = true;
            this.dsLog.AutoSubscribe = false;
            this.dsLog.DataSetName = "L3DataSet";
            this.dsLog.DeleteMethod = "";
            this.dsLog.InsertMethod = "";
            this.dsLog.L3DataAdapter = null;
            this.dsLog.LoadEvent = "";
            this.dsLog.LoadTrigger = null;
            this.dsLog.RefreshValve = 1000;
            this.dsLog.SourceCommand = null;
            this.dsLog.SourceCondition = "";
            this.dsLog.SourceMethod = "";
            this.dsLog.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsLog.SourceURI = "";
            this.dsLog.SubscribeTarget = "";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsLog.UpdateEvent = "";
            this.dsLog.UpdateMethod = "";
            this.dsLog.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableBillType,
            this.coll3DataSet1L3DataTableFlag,
            this.coll3DataSet1L3DataTableRemark,
            this.coll3DataSet1L3DataTableCreateTime,
            this.coll3DataSet1L3DataTableOther1,
            this.coll3DataSet1L3DataTableOther2,
            this.coll3DataSet1L3DataTableOther3});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableName
            // 
            this.coll3DataSet1L3DataTableName.Caption = "Name";
            this.coll3DataSet1L3DataTableName.ColumnName = "Name";
            this.coll3DataSet1L3DataTableName.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBillType
            // 
            this.coll3DataSet1L3DataTableBillType.Caption = "BillType";
            this.coll3DataSet1L3DataTableBillType.ColumnName = "BillType";
            this.coll3DataSet1L3DataTableBillType.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFlag
            // 
            this.coll3DataSet1L3DataTableFlag.Caption = "Flag";
            this.coll3DataSet1L3DataTableFlag.ColumnName = "Flag";
            this.coll3DataSet1L3DataTableFlag.Namespace = "";
            // 
            // coll3DataSet1L3DataTableRemark
            // 
            this.coll3DataSet1L3DataTableRemark.Caption = "Remark";
            this.coll3DataSet1L3DataTableRemark.ColumnName = "Remark";
            this.coll3DataSet1L3DataTableRemark.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCreateTime
            // 
            this.coll3DataSet1L3DataTableCreateTime.Caption = "CreateTime";
            this.coll3DataSet1L3DataTableCreateTime.ColumnName = "CreateTime";
            this.coll3DataSet1L3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableCreateTime.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther1
            // 
            this.coll3DataSet1L3DataTableOther1.Caption = "Other1";
            this.coll3DataSet1L3DataTableOther1.ColumnName = "Other1";
            this.coll3DataSet1L3DataTableOther1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther2
            // 
            this.coll3DataSet1L3DataTableOther2.Caption = "Other2";
            this.coll3DataSet1L3DataTableOther2.ColumnName = "Other2";
            this.coll3DataSet1L3DataTableOther2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther3
            // 
            this.coll3DataSet1L3DataTableOther3.Caption = "Other3";
            this.coll3DataSet1L3DataTableOther3.ColumnName = "Other3";
            this.coll3DataSet1L3DataTableOther3.Namespace = "";
            // 
            // NCTelCheckFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnM);
            this.Name = "NCTelCheckFrm";
            this.TabText = "NC电文批量补发";
            this.Text = "NC电文批量补发————只可以自动补发投料，订单电文（订单不上传，请重启163NC通讯）";
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsMaterial;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableFlag;
        private System.Data.DataColumn coldsMainL3DataTablescddh;
        private System.Data.DataColumn coldsMainL3DataTablezdrid;
        private System.Data.DataColumn coldsMainL3DataTablepch;
        private System.Data.DataColumn coldsMainL3DataTablewlbmid;
        private System.Data.DataColumn coldsMainL3DataTablejldwid;
        private System.Data.DataColumn coldsMainL3DataTableylbmid;
        private System.Data.DataColumn coldsMainL3DataTablebljhdh;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue1;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue2;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue3;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue4;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue5;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableTreatNo;
        private System.Data.DataColumn coldsMainL3DataTablezdrq;
        private System.Data.DataTable schemadsMaterial;
        private System.Data.DataColumn coldsMaterialL3DataTablekgyid;
        private System.Data.DataColumn coldsMaterialL3DataTableckckid;
        private System.Data.DataColumn coldsMaterialL3DataTableckckbm;
        private System.Data.DataColumn coldsMaterialL3DataTablewlbmid;
        private System.Data.DataColumn coldsMaterialL3DataTablejldwid;
        private System.Data.DataColumn coldsMaterialL3DataTablefjldwid;
        private System.Data.DataColumn coldsMaterialL3DataTableljcksl;
        private System.Data.DataColumn coldsMaterialL3DataTablefljcksl;
        private System.Data.DataColumn coldsMaterialL3DataTablepch;
        private System.Data.DataColumn coldsMaterialL3DataTablegzzxid;
        private System.Data.DataColumn coldsMaterialL3DataTablegxh;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy1;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy2;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy3;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy4;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy5;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx1;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx2;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx3;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx4;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx5;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_corp;
        private System.Data.DataColumn coldsMaterialL3DataTablegcbm;
        private System.Data.DataColumn coldsMaterialL3DataTableccostobject;
        private System.Data.DataColumn coldsMaterialL3DataTableflrq;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_moid;
        private System.Data.DataColumn coldsMaterialL3DataTableObjectID;
        private AppSvrHMI.L3Command cmdMain;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsLog;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableBillType;
        private System.Data.DataColumn coll3DataSet1L3DataTableFlag;
        private System.Data.DataColumn coll3DataSet1L3DataTableRemark;
        private System.Data.DataColumn coll3DataSet1L3DataTableCreateTime;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther1;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther2;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}