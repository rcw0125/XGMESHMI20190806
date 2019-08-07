namespace StoreMag.AlloyStore
{
    partial class AlloyInformationInputFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlloyInformationInputFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnAlloyInforEXL = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bsAlloyInfor = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloyInfor = new AppSvrHMI.L3DataSet();
            this.schemadsAllyInfor = new System.Data.DataTable();
            this.coldsAlloyInforL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableName = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablecinventoryid = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableInvname = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTableDbilldate = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablecoutwarehouseid = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablecinwarehouseid = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablennum = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablenassistnum = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablevproductbatchcode = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsAlloyInforL3DataTablepk_corp = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdAlloyInfor = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvElement = new System.Windows.Forms.DataGridView();
            this.recTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vproductbatchcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcheckbillcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcompcheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistchecknumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstoreorganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpraycorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckbillidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbaseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsamplecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsElement = new System.Windows.Forms.BindingSource(this.components);
            this.dsElement = new AppSvrHMI.L3DataSet();
            this.schemadsElement = new System.Data.DataTable();
            this.coldsElementL3DataTableGUID = new System.Data.DataColumn();
            this.coldsElementL3DataTableName = new System.Data.DataColumn();
            this.coldsElementL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsElementL3DataTablevproductbatchcode = new System.Data.DataColumn();
            this.coldsElementL3DataTablevcheckbillcode = new System.Data.DataColumn();
            this.coldsElementL3DataTablebcompcheck = new System.Data.DataColumn();
            this.coldsElementL3DataTablenassistchecknum = new System.Data.DataColumn();
            this.coldsElementL3DataTablecstoreorganization = new System.Data.DataColumn();
            this.coldsElementL3DataTablecpraycorp = new System.Data.DataColumn();
            this.coldsElementL3DataTableccheckbillid = new System.Data.DataColumn();
            this.coldsElementL3DataTablecbaseid = new System.Data.DataColumn();
            this.coldsElementL3DataTablevsamplecode = new System.Data.DataColumn();
            this.coldsElementL3DataTablennum = new System.Data.DataColumn();
            this.coldsElementL3DataTableC = new System.Data.DataColumn();
            this.coldsElementL3DataTableSi = new System.Data.DataColumn();
            this.coldsElementL3DataTableMn = new System.Data.DataColumn();
            this.coldsElementL3DataTableP = new System.Data.DataColumn();
            this.coldsElementL3DataTableS = new System.Data.DataColumn();
            this.coldsElementL3DataTableCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableNi = new System.Data.DataColumn();
            this.coldsElementL3DataTableCr = new System.Data.DataColumn();
            this.coldsElementL3DataTableMo = new System.Data.DataColumn();
            this.coldsElementL3DataTableV = new System.Data.DataColumn();
            this.coldsElementL3DataTableNb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAl = new System.Data.DataColumn();
            this.coldsElementL3DataTableAlS = new System.Data.DataColumn();
            this.coldsElementL3DataTableTi = new System.Data.DataColumn();
            this.coldsElementL3DataTableB = new System.Data.DataColumn();
            this.coldsElementL3DataTableSb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAs = new System.Data.DataColumn();
            this.coldsElementL3DataTableSn = new System.Data.DataColumn();
            this.coldsElementL3DataTableZn = new System.Data.DataColumn();
            this.coldsElementL3DataTableCa = new System.Data.DataColumn();
            this.coldsElementL3DataTableW = new System.Data.DataColumn();
            this.coldsElementL3DataTablePb = new System.Data.DataColumn();
            this.coldsElementL3DataTableRe = new System.Data.DataColumn();
            this.coldsElementL3DataTableCeq = new System.Data.DataColumn();
            this.coldsElementL3DataTableN = new System.Data.DataColumn();
            this.coldsElementL3DataTableH = new System.Data.DataColumn();
            this.coldsElementL3DataTableO = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther2 = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnElementEXL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnElementAdd = new System.Windows.Forms.ToolStripButton();
            this.btnElementDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnElementConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnElementCancel = new System.Windows.Forms.ToolStripButton();
            this.dvAlloyInfor = new System.Windows.Forms.DataGridView();
            this.recTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinventoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsAlloyCode1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.invnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbilldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vproductbatchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdElement = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.bsAlloyCode2 = new System.Windows.Forms.BindingSource(this.components);
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElement)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloyInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode2)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlloyInforEXL,
            this.btnExit,
            this.toolStripSeparator3,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator4,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(990, 43);
            this.tSp1.TabIndex = 28;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnAlloyInforEXL
            // 
            this.btnAlloyInforEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnAlloyInforEXL.Image")));
            this.btnAlloyInforEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlloyInforEXL.Name = "btnAlloyInforEXL";
            this.btnAlloyInforEXL.Size = new System.Drawing.Size(119, 40);
            this.btnAlloyInforEXL.Text = "合金从EXL导入";
            this.btnAlloyInforEXL.Click += new System.EventHandler(this.btnAlloyInforEXL_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bsAlloyInfor
            // 
            this.bsAlloyInfor.DataMember = "L3DataTable";
            this.bsAlloyInfor.DataSource = this.dsAlloyInfor;
            // 
            // dsAlloyInfor
            // 
            this.dsAlloyInfor.AutoSubscribe = true;
            this.dsAlloyInfor.DataSetName = "L3DataSet";
            this.dsAlloyInfor.DeleteMethod = null;
            this.dsAlloyInfor.InsertMethod = null;
            this.dsAlloyInfor.L3DataAdapter = null;
            this.dsAlloyInfor.LoadEvent = "Click";
            this.dsAlloyInfor.LoadTrigger = null;
            this.dsAlloyInfor.RefreshValve = 1000;
            this.dsAlloyInfor.SourceCommand = null;
            this.dsAlloyInfor.SourceCondition = "";
            this.dsAlloyInfor.SourceMethod = "";
            this.dsAlloyInfor.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsAlloyInfor.SourceURI = "";
            this.dsAlloyInfor.SubscribeTarget = "Version";
            this.dsAlloyInfor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAllyInfor});
            this.dsAlloyInfor.UpdateEvent = "Click";
            this.dsAlloyInfor.UpdateMethod = null;
            this.dsAlloyInfor.UpdateTrigger = null;
            // 
            // schemadsAllyInfor
            // 
            this.schemadsAllyInfor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyInforL3DataTableRec_Time,
            this.coldsAlloyInforL3DataTableGUID,
            this.coldsAlloyInforL3DataTableName,
            this.coldsAlloyInforL3DataTablecinventoryid,
            this.coldsAlloyInforL3DataTableInvcode,
            this.coldsAlloyInforL3DataTableInvname,
            this.coldsAlloyInforL3DataTableInvspec,
            this.coldsAlloyInforL3DataTableInvtype,
            this.coldsAlloyInforL3DataTableDbilldate,
            this.coldsAlloyInforL3DataTablecoutwarehouseid,
            this.coldsAlloyInforL3DataTablecinwarehouseid,
            this.coldsAlloyInforL3DataTablennum,
            this.coldsAlloyInforL3DataTablenassistnum,
            this.coldsAlloyInforL3DataTablevproductbatchcode,
            this.coldsAlloyInforL3DataTablezdy1,
            this.coldsAlloyInforL3DataTablezdy2,
            this.coldsAlloyInforL3DataTablezdy3,
            this.coldsAlloyInforL3DataTablezdy4,
            this.coldsAlloyInforL3DataTablezdy5,
            this.coldsAlloyInforL3DataTablezyx1,
            this.coldsAlloyInforL3DataTablezyx2,
            this.coldsAlloyInforL3DataTablezyx3,
            this.coldsAlloyInforL3DataTablezyx4,
            this.coldsAlloyInforL3DataTablezyx5,
            this.coldsAlloyInforL3DataTablepk_corp});
            this.schemadsAllyInfor.TableName = "L3DataTable";
            // 
            // coldsAlloyInforL3DataTableRec_Time
            // 
            this.coldsAlloyInforL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsAlloyInforL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsAlloyInforL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsAlloyInforL3DataTableRec_Time.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableGUID
            // 
            this.coldsAlloyInforL3DataTableGUID.Caption = "GUID";
            this.coldsAlloyInforL3DataTableGUID.ColumnName = "GUID";
            this.coldsAlloyInforL3DataTableGUID.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableName
            // 
            this.coldsAlloyInforL3DataTableName.Caption = "Name";
            this.coldsAlloyInforL3DataTableName.ColumnName = "Name";
            this.coldsAlloyInforL3DataTableName.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablecinventoryid
            // 
            this.coldsAlloyInforL3DataTablecinventoryid.Caption = "cinventoryid";
            this.coldsAlloyInforL3DataTablecinventoryid.ColumnName = "cinventoryid";
            this.coldsAlloyInforL3DataTablecinventoryid.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableInvcode
            // 
            this.coldsAlloyInforL3DataTableInvcode.Caption = "Invcode";
            this.coldsAlloyInforL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsAlloyInforL3DataTableInvcode.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableInvname
            // 
            this.coldsAlloyInforL3DataTableInvname.Caption = "Invname";
            this.coldsAlloyInforL3DataTableInvname.ColumnName = "Invname";
            this.coldsAlloyInforL3DataTableInvname.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableInvspec
            // 
            this.coldsAlloyInforL3DataTableInvspec.Caption = "Invspec";
            this.coldsAlloyInforL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsAlloyInforL3DataTableInvspec.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableInvtype
            // 
            this.coldsAlloyInforL3DataTableInvtype.Caption = "Invtype";
            this.coldsAlloyInforL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsAlloyInforL3DataTableInvtype.Namespace = "";
            // 
            // coldsAlloyInforL3DataTableDbilldate
            // 
            this.coldsAlloyInforL3DataTableDbilldate.Caption = "Dbilldate";
            this.coldsAlloyInforL3DataTableDbilldate.ColumnName = "Dbilldate";
            this.coldsAlloyInforL3DataTableDbilldate.DataType = typeof(System.DateTime);
            this.coldsAlloyInforL3DataTableDbilldate.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablecoutwarehouseid
            // 
            this.coldsAlloyInforL3DataTablecoutwarehouseid.Caption = "coutwarehouseid";
            this.coldsAlloyInforL3DataTablecoutwarehouseid.ColumnName = "coutwarehouseid";
            this.coldsAlloyInforL3DataTablecoutwarehouseid.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablecinwarehouseid
            // 
            this.coldsAlloyInforL3DataTablecinwarehouseid.Caption = "cinwarehouseid";
            this.coldsAlloyInforL3DataTablecinwarehouseid.ColumnName = "cinwarehouseid";
            this.coldsAlloyInforL3DataTablecinwarehouseid.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablennum
            // 
            this.coldsAlloyInforL3DataTablennum.Caption = "nnum";
            this.coldsAlloyInforL3DataTablennum.ColumnName = "nnum";
            this.coldsAlloyInforL3DataTablennum.DataType = typeof(double);
            this.coldsAlloyInforL3DataTablennum.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablenassistnum
            // 
            this.coldsAlloyInforL3DataTablenassistnum.Caption = "nassistnum";
            this.coldsAlloyInforL3DataTablenassistnum.ColumnName = "nassistnum";
            this.coldsAlloyInforL3DataTablenassistnum.DataType = typeof(int);
            this.coldsAlloyInforL3DataTablenassistnum.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablevproductbatchcode
            // 
            this.coldsAlloyInforL3DataTablevproductbatchcode.Caption = "vproductbatchcode";
            this.coldsAlloyInforL3DataTablevproductbatchcode.ColumnName = "vproductbatchcode";
            this.coldsAlloyInforL3DataTablevproductbatchcode.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezdy1
            // 
            this.coldsAlloyInforL3DataTablezdy1.Caption = "zdy1";
            this.coldsAlloyInforL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsAlloyInforL3DataTablezdy1.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezdy2
            // 
            this.coldsAlloyInforL3DataTablezdy2.Caption = "zdy2";
            this.coldsAlloyInforL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsAlloyInforL3DataTablezdy2.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezdy3
            // 
            this.coldsAlloyInforL3DataTablezdy3.Caption = "zdy3";
            this.coldsAlloyInforL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsAlloyInforL3DataTablezdy3.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezdy4
            // 
            this.coldsAlloyInforL3DataTablezdy4.Caption = "zdy4";
            this.coldsAlloyInforL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsAlloyInforL3DataTablezdy4.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezdy5
            // 
            this.coldsAlloyInforL3DataTablezdy5.Caption = "zdy5";
            this.coldsAlloyInforL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsAlloyInforL3DataTablezdy5.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezyx1
            // 
            this.coldsAlloyInforL3DataTablezyx1.Caption = "zyx1";
            this.coldsAlloyInforL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsAlloyInforL3DataTablezyx1.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezyx2
            // 
            this.coldsAlloyInforL3DataTablezyx2.Caption = "zyx2";
            this.coldsAlloyInforL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsAlloyInforL3DataTablezyx2.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezyx3
            // 
            this.coldsAlloyInforL3DataTablezyx3.Caption = "zyx3";
            this.coldsAlloyInforL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsAlloyInforL3DataTablezyx3.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezyx4
            // 
            this.coldsAlloyInforL3DataTablezyx4.Caption = "zyx4";
            this.coldsAlloyInforL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsAlloyInforL3DataTablezyx4.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablezyx5
            // 
            this.coldsAlloyInforL3DataTablezyx5.Caption = "zyx5";
            this.coldsAlloyInforL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsAlloyInforL3DataTablezyx5.Namespace = "";
            // 
            // coldsAlloyInforL3DataTablepk_corp
            // 
            this.coldsAlloyInforL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsAlloyInforL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsAlloyInforL3DataTablepk_corp.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdAlloyInfor
            // 
            this.cmdAlloyInfor.Adapter = this.Adapter;
            this.cmdAlloyInfor.MergeReturnTarget = false;
            this.cmdAlloyInfor.Method = "AlloyDataAccept";
            this.cmdAlloyInfor.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdAlloyInfor.Parameters.Add(this.l3CommandParameter1);
            this.cmdAlloyInfor.ReturnTarget = null;
            this.cmdAlloyInfor.ReturnTargetProperty = null;
            this.cmdAlloyInfor.Trigger = null;
            this.cmdAlloyInfor.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsAlloyInfor;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvElement);
            this.hmiRootPanel1.Controls.Add(this.toolStrip1);
            this.hmiRootPanel1.Controls.Add(this.dvAlloyInfor);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(990, 466);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvElement
            // 
            this.dvElement.AllowUserToAddRows = false;
            this.dvElement.AutoGenerateColumns = false;
            this.dvElement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recTimeDataGridViewTextBoxColumn1,
            this.vproductbatchcodeDataGridViewTextBoxColumn1,
            this.vcheckbillcodeDataGridViewTextBoxColumn,
            this.bcompcheckDataGridViewTextBoxColumn,
            this.nassistchecknumDataGridViewTextBoxColumn,
            this.cstoreorganizationDataGridViewTextBoxColumn,
            this.cpraycorpDataGridViewTextBoxColumn,
            this.ccheckbillidDataGridViewTextBoxColumn,
            this.cbaseidDataGridViewTextBoxColumn,
            this.vsamplecodeDataGridViewTextBoxColumn,
            this.nnumDataGridViewTextBoxColumn1,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.Cu,
            this.Ni,
            this.Cr,
            this.Mo,
            this.V,
            this.Nb,
            this.Al,
            this.AlS,
            this.Ti,
            this.B,
            this.Sb,
            this.As,
            this.Sn,
            this.Zn,
            this.Ca,
            this.Column2,
            this.Pb,
            this.Re,
            this.Ceq,
            this.N,
            this.H,
            this.O,
            this.Column1,
            this.Other2,
            this.nameDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1});
            this.dvElement.DataSource = this.bsElement;
            this.dvElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvElement.Location = new System.Drawing.Point(0, 242);
            this.dvElement.Name = "dvElement";
            this.dvElement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvElement.RowTemplate.Height = 23;
            this.dvElement.Size = new System.Drawing.Size(990, 223);
            this.dvElement.TabIndex = 32;
            this.dvElement.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAlloyInfor_DataError);
            // 
            // recTimeDataGridViewTextBoxColumn1
            // 
            this.recTimeDataGridViewTextBoxColumn1.DataPropertyName = "Rec_Time";
            this.recTimeDataGridViewTextBoxColumn1.HeaderText = "接收时间";
            this.recTimeDataGridViewTextBoxColumn1.Name = "recTimeDataGridViewTextBoxColumn1";
            this.recTimeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // vproductbatchcodeDataGridViewTextBoxColumn1
            // 
            this.vproductbatchcodeDataGridViewTextBoxColumn1.DataPropertyName = "vproductbatchcode";
            this.vproductbatchcodeDataGridViewTextBoxColumn1.HeaderText = "合金批次";
            this.vproductbatchcodeDataGridViewTextBoxColumn1.Name = "vproductbatchcodeDataGridViewTextBoxColumn1";
            // 
            // vcheckbillcodeDataGridViewTextBoxColumn
            // 
            this.vcheckbillcodeDataGridViewTextBoxColumn.DataPropertyName = "vcheckbillcode";
            this.vcheckbillcodeDataGridViewTextBoxColumn.HeaderText = "检验单号";
            this.vcheckbillcodeDataGridViewTextBoxColumn.Name = "vcheckbillcodeDataGridViewTextBoxColumn";
            // 
            // bcompcheckDataGridViewTextBoxColumn
            // 
            this.bcompcheckDataGridViewTextBoxColumn.DataPropertyName = "bcompcheck";
            this.bcompcheckDataGridViewTextBoxColumn.HeaderText = "是否成分检验";
            this.bcompcheckDataGridViewTextBoxColumn.Name = "bcompcheckDataGridViewTextBoxColumn";
            // 
            // nassistchecknumDataGridViewTextBoxColumn
            // 
            this.nassistchecknumDataGridViewTextBoxColumn.DataPropertyName = "nassistchecknum";
            this.nassistchecknumDataGridViewTextBoxColumn.HeaderText = "报检辅数量";
            this.nassistchecknumDataGridViewTextBoxColumn.Name = "nassistchecknumDataGridViewTextBoxColumn";
            // 
            // cstoreorganizationDataGridViewTextBoxColumn
            // 
            this.cstoreorganizationDataGridViewTextBoxColumn.DataPropertyName = "cstoreorganization";
            this.cstoreorganizationDataGridViewTextBoxColumn.HeaderText = "库存组织";
            this.cstoreorganizationDataGridViewTextBoxColumn.Name = "cstoreorganizationDataGridViewTextBoxColumn";
            // 
            // cpraycorpDataGridViewTextBoxColumn
            // 
            this.cpraycorpDataGridViewTextBoxColumn.DataPropertyName = "cpraycorp";
            this.cpraycorpDataGridViewTextBoxColumn.HeaderText = "报检公司";
            this.cpraycorpDataGridViewTextBoxColumn.Name = "cpraycorpDataGridViewTextBoxColumn";
            // 
            // ccheckbillidDataGridViewTextBoxColumn
            // 
            this.ccheckbillidDataGridViewTextBoxColumn.DataPropertyName = "ccheckbillid";
            this.ccheckbillidDataGridViewTextBoxColumn.HeaderText = "质量检验单主键";
            this.ccheckbillidDataGridViewTextBoxColumn.Name = "ccheckbillidDataGridViewTextBoxColumn";
            // 
            // cbaseidDataGridViewTextBoxColumn
            // 
            this.cbaseidDataGridViewTextBoxColumn.DataPropertyName = "cbaseid";
            this.cbaseidDataGridViewTextBoxColumn.HeaderText = "检验产品";
            this.cbaseidDataGridViewTextBoxColumn.Name = "cbaseidDataGridViewTextBoxColumn";
            // 
            // vsamplecodeDataGridViewTextBoxColumn
            // 
            this.vsamplecodeDataGridViewTextBoxColumn.DataPropertyName = "vsamplecode";
            this.vsamplecodeDataGridViewTextBoxColumn.HeaderText = "样本号";
            this.vsamplecodeDataGridViewTextBoxColumn.Name = "vsamplecodeDataGridViewTextBoxColumn";
            // 
            // nnumDataGridViewTextBoxColumn1
            // 
            this.nnumDataGridViewTextBoxColumn1.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn1.HeaderText = "检验数量";
            this.nnumDataGridViewTextBoxColumn1.Name = "nnumDataGridViewTextBoxColumn1";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            // 
            // Cu
            // 
            this.Cu.DataPropertyName = "Cu";
            this.Cu.HeaderText = "Cu";
            this.Cu.Name = "Cu";
            // 
            // Ni
            // 
            this.Ni.DataPropertyName = "Ni";
            this.Ni.HeaderText = "Ni";
            this.Ni.Name = "Ni";
            // 
            // Cr
            // 
            this.Cr.DataPropertyName = "Cr";
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            // 
            // Mo
            // 
            this.Mo.DataPropertyName = "Mo";
            this.Mo.HeaderText = "Mo";
            this.Mo.Name = "Mo";
            // 
            // V
            // 
            this.V.DataPropertyName = "V";
            this.V.HeaderText = "V";
            this.V.Name = "V";
            // 
            // Nb
            // 
            this.Nb.DataPropertyName = "Nb";
            this.Nb.HeaderText = "Nb";
            this.Nb.Name = "Nb";
            // 
            // Al
            // 
            this.Al.DataPropertyName = "Al";
            this.Al.HeaderText = "Al";
            this.Al.Name = "Al";
            // 
            // AlS
            // 
            this.AlS.DataPropertyName = "AlS";
            this.AlS.HeaderText = "AlS";
            this.AlS.Name = "AlS";
            // 
            // Ti
            // 
            this.Ti.DataPropertyName = "Ti";
            this.Ti.HeaderText = "Ti";
            this.Ti.Name = "Ti";
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            this.As.HeaderText = "As";
            this.As.Name = "As";
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            // 
            // Zn
            // 
            this.Zn.DataPropertyName = "Zn";
            this.Zn.HeaderText = "Zn";
            this.Zn.Name = "Zn";
            // 
            // Ca
            // 
            this.Ca.DataPropertyName = "Ca";
            this.Ca.HeaderText = "Ca";
            this.Ca.Name = "Ca";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "W";
            this.Column2.HeaderText = "W";
            this.Column2.Name = "Column2";
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            // 
            // Re
            // 
            this.Re.DataPropertyName = "Re";
            this.Re.HeaderText = "Re";
            this.Re.Name = "Re";
            // 
            // Ceq
            // 
            this.Ceq.DataPropertyName = "Ceq";
            this.Ceq.HeaderText = "Ceq";
            this.Ceq.Name = "Ceq";
            // 
            // N
            // 
            this.N.DataPropertyName = "N";
            this.N.HeaderText = "N";
            this.N.Name = "N";
            // 
            // H
            // 
            this.H.DataPropertyName = "H";
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // O
            // 
            this.O.DataPropertyName = "O";
            this.O.HeaderText = "O";
            this.O.Name = "O";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Other1";
            this.Column1.HeaderText = "Other1";
            this.Column1.Name = "Column1";
            // 
            // Other2
            // 
            this.Other2.DataPropertyName = "Other2";
            this.Other2.HeaderText = "Other2";
            this.Other2.Name = "Other2";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            this.nameDataGridViewTextBoxColumn1.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsElement
            // 
            this.bsElement.DataMember = "L3DataTable";
            this.bsElement.DataSource = this.dsElement;
            // 
            // dsElement
            // 
            this.dsElement.AutoSubscribe = true;
            this.dsElement.DataSetName = "L3DataSet";
            this.dsElement.DeleteMethod = null;
            this.dsElement.InsertMethod = null;
            this.dsElement.L3DataAdapter = null;
            this.dsElement.LoadEvent = "Click";
            this.dsElement.LoadTrigger = null;
            this.dsElement.RefreshValve = 1000;
            this.dsElement.SourceCommand = null;
            this.dsElement.SourceCondition = null;
            this.dsElement.SourceMethod = "";
            this.dsElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsElement.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Element_Tel_Data";
            this.dsElement.SubscribeTarget = null;
            this.dsElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsElement});
            this.dsElement.UpdateEvent = "Click";
            this.dsElement.UpdateMethod = null;
            this.dsElement.UpdateTrigger = null;
            // 
            // schemadsElement
            // 
            this.schemadsElement.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsElementL3DataTableGUID,
            this.coldsElementL3DataTableName,
            this.coldsElementL3DataTableRec_Time,
            this.coldsElementL3DataTablevproductbatchcode,
            this.coldsElementL3DataTablevcheckbillcode,
            this.coldsElementL3DataTablebcompcheck,
            this.coldsElementL3DataTablenassistchecknum,
            this.coldsElementL3DataTablecstoreorganization,
            this.coldsElementL3DataTablecpraycorp,
            this.coldsElementL3DataTableccheckbillid,
            this.coldsElementL3DataTablecbaseid,
            this.coldsElementL3DataTablevsamplecode,
            this.coldsElementL3DataTablennum,
            this.coldsElementL3DataTableC,
            this.coldsElementL3DataTableSi,
            this.coldsElementL3DataTableMn,
            this.coldsElementL3DataTableP,
            this.coldsElementL3DataTableS,
            this.coldsElementL3DataTableCu,
            this.coldsElementL3DataTableNi,
            this.coldsElementL3DataTableCr,
            this.coldsElementL3DataTableMo,
            this.coldsElementL3DataTableV,
            this.coldsElementL3DataTableNb,
            this.coldsElementL3DataTableAl,
            this.coldsElementL3DataTableAlS,
            this.coldsElementL3DataTableTi,
            this.coldsElementL3DataTableB,
            this.coldsElementL3DataTableSb,
            this.coldsElementL3DataTableAs,
            this.coldsElementL3DataTableSn,
            this.coldsElementL3DataTableZn,
            this.coldsElementL3DataTableCa,
            this.coldsElementL3DataTableW,
            this.coldsElementL3DataTablePb,
            this.coldsElementL3DataTableRe,
            this.coldsElementL3DataTableCeq,
            this.coldsElementL3DataTableN,
            this.coldsElementL3DataTableH,
            this.coldsElementL3DataTableO,
            this.coldsElementL3DataTableOther1,
            this.coldsElementL3DataTableOther2});
            this.schemadsElement.TableName = "L3DataTable";
            // 
            // coldsElementL3DataTableGUID
            // 
            this.coldsElementL3DataTableGUID.Caption = "GUID";
            this.coldsElementL3DataTableGUID.ColumnName = "GUID";
            this.coldsElementL3DataTableGUID.Namespace = "";
            // 
            // coldsElementL3DataTableName
            // 
            this.coldsElementL3DataTableName.Caption = "Name";
            this.coldsElementL3DataTableName.ColumnName = "Name";
            this.coldsElementL3DataTableName.Namespace = "";
            // 
            // coldsElementL3DataTableRec_Time
            // 
            this.coldsElementL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsElementL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsElementL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsElementL3DataTableRec_Time.Namespace = "";
            // 
            // coldsElementL3DataTablevproductbatchcode
            // 
            this.coldsElementL3DataTablevproductbatchcode.Caption = "vproductbatchcode";
            this.coldsElementL3DataTablevproductbatchcode.ColumnName = "vproductbatchcode";
            this.coldsElementL3DataTablevproductbatchcode.Namespace = "";
            // 
            // coldsElementL3DataTablevcheckbillcode
            // 
            this.coldsElementL3DataTablevcheckbillcode.Caption = "vcheckbillcode";
            this.coldsElementL3DataTablevcheckbillcode.ColumnName = "vcheckbillcode";
            this.coldsElementL3DataTablevcheckbillcode.Namespace = "";
            // 
            // coldsElementL3DataTablebcompcheck
            // 
            this.coldsElementL3DataTablebcompcheck.Caption = "bcompcheck";
            this.coldsElementL3DataTablebcompcheck.ColumnName = "bcompcheck";
            this.coldsElementL3DataTablebcompcheck.Namespace = "";
            // 
            // coldsElementL3DataTablenassistchecknum
            // 
            this.coldsElementL3DataTablenassistchecknum.Caption = "nassistchecknum";
            this.coldsElementL3DataTablenassistchecknum.ColumnName = "nassistchecknum";
            this.coldsElementL3DataTablenassistchecknum.DataType = typeof(int);
            this.coldsElementL3DataTablenassistchecknum.Namespace = "";
            // 
            // coldsElementL3DataTablecstoreorganization
            // 
            this.coldsElementL3DataTablecstoreorganization.Caption = "cstoreorganization";
            this.coldsElementL3DataTablecstoreorganization.ColumnName = "cstoreorganization";
            this.coldsElementL3DataTablecstoreorganization.Namespace = "";
            // 
            // coldsElementL3DataTablecpraycorp
            // 
            this.coldsElementL3DataTablecpraycorp.Caption = "cpraycorp";
            this.coldsElementL3DataTablecpraycorp.ColumnName = "cpraycorp";
            this.coldsElementL3DataTablecpraycorp.Namespace = "";
            // 
            // coldsElementL3DataTableccheckbillid
            // 
            this.coldsElementL3DataTableccheckbillid.Caption = "ccheckbillid";
            this.coldsElementL3DataTableccheckbillid.ColumnName = "ccheckbillid";
            this.coldsElementL3DataTableccheckbillid.Namespace = "";
            // 
            // coldsElementL3DataTablecbaseid
            // 
            this.coldsElementL3DataTablecbaseid.Caption = "cbaseid";
            this.coldsElementL3DataTablecbaseid.ColumnName = "cbaseid";
            this.coldsElementL3DataTablecbaseid.Namespace = "";
            // 
            // coldsElementL3DataTablevsamplecode
            // 
            this.coldsElementL3DataTablevsamplecode.Caption = "vsamplecode";
            this.coldsElementL3DataTablevsamplecode.ColumnName = "vsamplecode";
            this.coldsElementL3DataTablevsamplecode.Namespace = "";
            // 
            // coldsElementL3DataTablennum
            // 
            this.coldsElementL3DataTablennum.Caption = "nnum";
            this.coldsElementL3DataTablennum.ColumnName = "nnum";
            this.coldsElementL3DataTablennum.Namespace = "";
            // 
            // coldsElementL3DataTableC
            // 
            this.coldsElementL3DataTableC.Caption = "C";
            this.coldsElementL3DataTableC.ColumnName = "C";
            this.coldsElementL3DataTableC.DataType = typeof(double);
            this.coldsElementL3DataTableC.Namespace = "";
            // 
            // coldsElementL3DataTableSi
            // 
            this.coldsElementL3DataTableSi.Caption = "Si";
            this.coldsElementL3DataTableSi.ColumnName = "Si";
            this.coldsElementL3DataTableSi.DataType = typeof(double);
            this.coldsElementL3DataTableSi.Namespace = "";
            // 
            // coldsElementL3DataTableMn
            // 
            this.coldsElementL3DataTableMn.Caption = "Mn";
            this.coldsElementL3DataTableMn.ColumnName = "Mn";
            this.coldsElementL3DataTableMn.DataType = typeof(double);
            this.coldsElementL3DataTableMn.Namespace = "";
            // 
            // coldsElementL3DataTableP
            // 
            this.coldsElementL3DataTableP.Caption = "P";
            this.coldsElementL3DataTableP.ColumnName = "P";
            this.coldsElementL3DataTableP.DataType = typeof(double);
            this.coldsElementL3DataTableP.Namespace = "";
            // 
            // coldsElementL3DataTableS
            // 
            this.coldsElementL3DataTableS.Caption = "S";
            this.coldsElementL3DataTableS.ColumnName = "S";
            this.coldsElementL3DataTableS.DataType = typeof(double);
            this.coldsElementL3DataTableS.Namespace = "";
            // 
            // coldsElementL3DataTableCu
            // 
            this.coldsElementL3DataTableCu.Caption = "Cu";
            this.coldsElementL3DataTableCu.ColumnName = "Cu";
            this.coldsElementL3DataTableCu.DataType = typeof(double);
            this.coldsElementL3DataTableCu.Namespace = "";
            // 
            // coldsElementL3DataTableNi
            // 
            this.coldsElementL3DataTableNi.Caption = "Ni";
            this.coldsElementL3DataTableNi.ColumnName = "Ni";
            this.coldsElementL3DataTableNi.DataType = typeof(double);
            this.coldsElementL3DataTableNi.Namespace = "";
            // 
            // coldsElementL3DataTableCr
            // 
            this.coldsElementL3DataTableCr.Caption = "Cr";
            this.coldsElementL3DataTableCr.ColumnName = "Cr";
            this.coldsElementL3DataTableCr.DataType = typeof(double);
            this.coldsElementL3DataTableCr.Namespace = "";
            // 
            // coldsElementL3DataTableMo
            // 
            this.coldsElementL3DataTableMo.Caption = "Mo";
            this.coldsElementL3DataTableMo.ColumnName = "Mo";
            this.coldsElementL3DataTableMo.DataType = typeof(double);
            this.coldsElementL3DataTableMo.Namespace = "";
            // 
            // coldsElementL3DataTableV
            // 
            this.coldsElementL3DataTableV.Caption = "V";
            this.coldsElementL3DataTableV.ColumnName = "V";
            this.coldsElementL3DataTableV.DataType = typeof(double);
            this.coldsElementL3DataTableV.Namespace = "";
            // 
            // coldsElementL3DataTableNb
            // 
            this.coldsElementL3DataTableNb.Caption = "Nb";
            this.coldsElementL3DataTableNb.ColumnName = "Nb";
            this.coldsElementL3DataTableNb.DataType = typeof(double);
            this.coldsElementL3DataTableNb.Namespace = "";
            // 
            // coldsElementL3DataTableAl
            // 
            this.coldsElementL3DataTableAl.Caption = "Al";
            this.coldsElementL3DataTableAl.ColumnName = "Al";
            this.coldsElementL3DataTableAl.DataType = typeof(double);
            this.coldsElementL3DataTableAl.Namespace = "";
            // 
            // coldsElementL3DataTableAlS
            // 
            this.coldsElementL3DataTableAlS.Caption = "AlS";
            this.coldsElementL3DataTableAlS.ColumnName = "AlS";
            this.coldsElementL3DataTableAlS.DataType = typeof(double);
            this.coldsElementL3DataTableAlS.Namespace = "";
            // 
            // coldsElementL3DataTableTi
            // 
            this.coldsElementL3DataTableTi.Caption = "Ti";
            this.coldsElementL3DataTableTi.ColumnName = "Ti";
            this.coldsElementL3DataTableTi.DataType = typeof(double);
            this.coldsElementL3DataTableTi.Namespace = "";
            // 
            // coldsElementL3DataTableB
            // 
            this.coldsElementL3DataTableB.Caption = "B";
            this.coldsElementL3DataTableB.ColumnName = "B";
            this.coldsElementL3DataTableB.DataType = typeof(double);
            this.coldsElementL3DataTableB.Namespace = "";
            // 
            // coldsElementL3DataTableSb
            // 
            this.coldsElementL3DataTableSb.Caption = "Sb";
            this.coldsElementL3DataTableSb.ColumnName = "Sb";
            this.coldsElementL3DataTableSb.DataType = typeof(double);
            this.coldsElementL3DataTableSb.Namespace = "";
            // 
            // coldsElementL3DataTableAs
            // 
            this.coldsElementL3DataTableAs.Caption = "As";
            this.coldsElementL3DataTableAs.ColumnName = "As";
            this.coldsElementL3DataTableAs.DataType = typeof(double);
            this.coldsElementL3DataTableAs.Namespace = "";
            // 
            // coldsElementL3DataTableSn
            // 
            this.coldsElementL3DataTableSn.Caption = "Sn";
            this.coldsElementL3DataTableSn.ColumnName = "Sn";
            this.coldsElementL3DataTableSn.DataType = typeof(double);
            this.coldsElementL3DataTableSn.Namespace = "";
            // 
            // coldsElementL3DataTableZn
            // 
            this.coldsElementL3DataTableZn.Caption = "Zn";
            this.coldsElementL3DataTableZn.ColumnName = "Zn";
            this.coldsElementL3DataTableZn.DataType = typeof(double);
            this.coldsElementL3DataTableZn.Namespace = "";
            // 
            // coldsElementL3DataTableCa
            // 
            this.coldsElementL3DataTableCa.Caption = "Ca";
            this.coldsElementL3DataTableCa.ColumnName = "Ca";
            this.coldsElementL3DataTableCa.DataType = typeof(double);
            this.coldsElementL3DataTableCa.Namespace = "";
            // 
            // coldsElementL3DataTableW
            // 
            this.coldsElementL3DataTableW.Caption = "W";
            this.coldsElementL3DataTableW.ColumnName = "W";
            this.coldsElementL3DataTableW.DataType = typeof(double);
            this.coldsElementL3DataTableW.Namespace = "";
            // 
            // coldsElementL3DataTablePb
            // 
            this.coldsElementL3DataTablePb.Caption = "Pb";
            this.coldsElementL3DataTablePb.ColumnName = "Pb";
            this.coldsElementL3DataTablePb.DataType = typeof(double);
            this.coldsElementL3DataTablePb.Namespace = "";
            // 
            // coldsElementL3DataTableRe
            // 
            this.coldsElementL3DataTableRe.Caption = "Re";
            this.coldsElementL3DataTableRe.ColumnName = "Re";
            this.coldsElementL3DataTableRe.DataType = typeof(double);
            this.coldsElementL3DataTableRe.Namespace = "";
            // 
            // coldsElementL3DataTableCeq
            // 
            this.coldsElementL3DataTableCeq.Caption = "Ceq";
            this.coldsElementL3DataTableCeq.ColumnName = "Ceq";
            this.coldsElementL3DataTableCeq.DataType = typeof(double);
            this.coldsElementL3DataTableCeq.Namespace = "";
            // 
            // coldsElementL3DataTableN
            // 
            this.coldsElementL3DataTableN.Caption = "N";
            this.coldsElementL3DataTableN.ColumnName = "N";
            this.coldsElementL3DataTableN.DataType = typeof(double);
            this.coldsElementL3DataTableN.Namespace = "";
            // 
            // coldsElementL3DataTableH
            // 
            this.coldsElementL3DataTableH.Caption = "H";
            this.coldsElementL3DataTableH.ColumnName = "H";
            this.coldsElementL3DataTableH.DataType = typeof(double);
            this.coldsElementL3DataTableH.Namespace = "";
            // 
            // coldsElementL3DataTableO
            // 
            this.coldsElementL3DataTableO.Caption = "O";
            this.coldsElementL3DataTableO.ColumnName = "O";
            this.coldsElementL3DataTableO.DataType = typeof(double);
            this.coldsElementL3DataTableO.Namespace = "";
            // 
            // coldsElementL3DataTableOther1
            // 
            this.coldsElementL3DataTableOther1.Caption = "Other1";
            this.coldsElementL3DataTableOther1.ColumnName = "Other1";
            this.coldsElementL3DataTableOther1.DataType = typeof(double);
            this.coldsElementL3DataTableOther1.Namespace = "";
            // 
            // coldsElementL3DataTableOther2
            // 
            this.coldsElementL3DataTableOther2.Caption = "Other2";
            this.coldsElementL3DataTableOther2.ColumnName = "Other2";
            this.coldsElementL3DataTableOther2.DataType = typeof(double);
            this.coldsElementL3DataTableOther2.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnElementEXL,
            this.toolStripSeparator5,
            this.btnElementAdd,
            this.btnElementDel,
            this.toolStripSeparator6,
            this.btnElementConfirm,
            this.btnElementCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 199);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(990, 43);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnElementEXL
            // 
            this.btnElementEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnElementEXL.Image")));
            this.btnElementEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElementEXL.Name = "btnElementEXL";
            this.btnElementEXL.Size = new System.Drawing.Size(119, 40);
            this.btnElementEXL.Text = "成分从EXL导入";
            this.btnElementEXL.Click += new System.EventHandler(this.btnElementEXL_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnElementAdd
            // 
            this.btnElementAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnElementAdd.Image")));
            this.btnElementAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElementAdd.Name = "btnElementAdd";
            this.btnElementAdd.Size = new System.Drawing.Size(65, 40);
            this.btnElementAdd.Text = "新增";
            this.btnElementAdd.Click += new System.EventHandler(this.btnElementAdd_Click);
            // 
            // btnElementDel
            // 
            this.btnElementDel.Image = ((System.Drawing.Image)(resources.GetObject("btnElementDel.Image")));
            this.btnElementDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElementDel.Name = "btnElementDel";
            this.btnElementDel.Size = new System.Drawing.Size(65, 40);
            this.btnElementDel.Text = "删除";
            this.btnElementDel.Click += new System.EventHandler(this.btnElementDel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // btnElementConfirm
            // 
            this.btnElementConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnElementConfirm.Image")));
            this.btnElementConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElementConfirm.Name = "btnElementConfirm";
            this.btnElementConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnElementConfirm.Text = "确定";
            this.btnElementConfirm.Click += new System.EventHandler(this.btnElementConfirm_Click);
            // 
            // btnElementCancel
            // 
            this.btnElementCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnElementCancel.Image")));
            this.btnElementCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElementCancel.Name = "btnElementCancel";
            this.btnElementCancel.Size = new System.Drawing.Size(65, 40);
            this.btnElementCancel.Text = "取消";
            this.btnElementCancel.Click += new System.EventHandler(this.btnElementCancel_Click);
            // 
            // dvAlloyInfor
            // 
            this.dvAlloyInfor.AllowUserToAddRows = false;
            this.dvAlloyInfor.AutoGenerateColumns = false;
            this.dvAlloyInfor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAlloyInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAlloyInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recTimeDataGridViewTextBoxColumn,
            this.cinventoryidDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.invnameDataGridViewTextBoxColumn,
            this.nnumDataGridViewTextBoxColumn,
            this.invspecDataGridViewTextBoxColumn,
            this.invtypeDataGridViewTextBoxColumn,
            this.dbilldateDataGridViewTextBoxColumn,
            this.coutwarehouseidDataGridViewTextBoxColumn,
            this.cinwarehouseidDataGridViewTextBoxColumn,
            this.nassistnumDataGridViewTextBoxColumn,
            this.vproductbatchcodeDataGridViewTextBoxColumn,
            this.zdy1DataGridViewTextBoxColumn,
            this.zdy2DataGridViewTextBoxColumn,
            this.zdy3DataGridViewTextBoxColumn,
            this.zdy4DataGridViewTextBoxColumn,
            this.zdy5DataGridViewTextBoxColumn,
            this.zyx1DataGridViewTextBoxColumn,
            this.zyx2DataGridViewTextBoxColumn,
            this.zyx3DataGridViewTextBoxColumn,
            this.zyx4DataGridViewTextBoxColumn,
            this.zyx5DataGridViewTextBoxColumn,
            this.pkcorpDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvAlloyInfor.DataSource = this.bsAlloyInfor;
            this.dvAlloyInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvAlloyInfor.Location = new System.Drawing.Point(0, 0);
            this.dvAlloyInfor.Name = "dvAlloyInfor";
            this.dvAlloyInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvAlloyInfor.RowTemplate.Height = 23;
            this.dvAlloyInfor.Size = new System.Drawing.Size(990, 199);
            this.dvAlloyInfor.TabIndex = 30;
            this.dvAlloyInfor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAlloyInfor_DataError);
            // 
            // recTimeDataGridViewTextBoxColumn
            // 
            this.recTimeDataGridViewTextBoxColumn.DataPropertyName = "Rec_Time";
            this.recTimeDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.recTimeDataGridViewTextBoxColumn.Name = "recTimeDataGridViewTextBoxColumn";
            this.recTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinventoryidDataGridViewTextBoxColumn
            // 
            this.cinventoryidDataGridViewTextBoxColumn.DataPropertyName = "cinventoryid";
            this.cinventoryidDataGridViewTextBoxColumn.HeaderText = "物料ID";
            this.cinventoryidDataGridViewTextBoxColumn.Name = "cinventoryidDataGridViewTextBoxColumn";
            this.cinventoryidDataGridViewTextBoxColumn.Visible = false;
            // 
            // invcodeDataGridViewTextBoxColumn
            // 
            this.invcodeDataGridViewTextBoxColumn.DataPropertyName = "Invcode";
            this.invcodeDataGridViewTextBoxColumn.DataSource = this.bsAlloyCode1;
            this.invcodeDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.invcodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invcodeDataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // bsAlloyCode1
            // 
            this.bsAlloyCode1.DataMember = "L3DataTable";
            this.bsAlloyCode1.DataSource = this.dsAlloyCode;
            // 
            // dsAlloyCode
            // 
            this.dsAlloyCode.AutoSubscribe = true;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = null;
            this.dsAlloyCode.InsertMethod = null;
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\'";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = null;
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = null;
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode,
            this.coldsAlloyCodeL3DataTableCode_Des});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode
            // 
            this.coldsAlloyCodeL3DataTableCode.Caption = "Code";
            this.coldsAlloyCodeL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyCodeL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // invnameDataGridViewTextBoxColumn
            // 
            this.invnameDataGridViewTextBoxColumn.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn.Name = "invnameDataGridViewTextBoxColumn";
            // 
            // nnumDataGridViewTextBoxColumn
            // 
            this.nnumDataGridViewTextBoxColumn.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn.HeaderText = "检验数量";
            this.nnumDataGridViewTextBoxColumn.Name = "nnumDataGridViewTextBoxColumn";
            // 
            // invspecDataGridViewTextBoxColumn
            // 
            this.invspecDataGridViewTextBoxColumn.DataPropertyName = "Invspec";
            this.invspecDataGridViewTextBoxColumn.HeaderText = "物料规格";
            this.invspecDataGridViewTextBoxColumn.Name = "invspecDataGridViewTextBoxColumn";
            // 
            // invtypeDataGridViewTextBoxColumn
            // 
            this.invtypeDataGridViewTextBoxColumn.DataPropertyName = "Invtype";
            this.invtypeDataGridViewTextBoxColumn.HeaderText = "物料型号";
            this.invtypeDataGridViewTextBoxColumn.Name = "invtypeDataGridViewTextBoxColumn";
            // 
            // dbilldateDataGridViewTextBoxColumn
            // 
            this.dbilldateDataGridViewTextBoxColumn.DataPropertyName = "Dbilldate";
            this.dbilldateDataGridViewTextBoxColumn.HeaderText = "单据日期";
            this.dbilldateDataGridViewTextBoxColumn.Name = "dbilldateDataGridViewTextBoxColumn";
            // 
            // coutwarehouseidDataGridViewTextBoxColumn
            // 
            this.coutwarehouseidDataGridViewTextBoxColumn.DataPropertyName = "coutwarehouseid";
            this.coutwarehouseidDataGridViewTextBoxColumn.HeaderText = "出库仓库";
            this.coutwarehouseidDataGridViewTextBoxColumn.Name = "coutwarehouseidDataGridViewTextBoxColumn";
            // 
            // cinwarehouseidDataGridViewTextBoxColumn
            // 
            this.cinwarehouseidDataGridViewTextBoxColumn.DataPropertyName = "cinwarehouseid";
            this.cinwarehouseidDataGridViewTextBoxColumn.HeaderText = "入库仓库";
            this.cinwarehouseidDataGridViewTextBoxColumn.Name = "cinwarehouseidDataGridViewTextBoxColumn";
            // 
            // nassistnumDataGridViewTextBoxColumn
            // 
            this.nassistnumDataGridViewTextBoxColumn.DataPropertyName = "nassistnum";
            this.nassistnumDataGridViewTextBoxColumn.HeaderText = "转库辅数量";
            this.nassistnumDataGridViewTextBoxColumn.Name = "nassistnumDataGridViewTextBoxColumn";
            // 
            // vproductbatchcodeDataGridViewTextBoxColumn
            // 
            this.vproductbatchcodeDataGridViewTextBoxColumn.DataPropertyName = "vproductbatchcode";
            this.vproductbatchcodeDataGridViewTextBoxColumn.HeaderText = "合金批次";
            this.vproductbatchcodeDataGridViewTextBoxColumn.Name = "vproductbatchcodeDataGridViewTextBoxColumn";
            // 
            // zdy1DataGridViewTextBoxColumn
            // 
            this.zdy1DataGridViewTextBoxColumn.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn.HeaderText = "自定义1";
            this.zdy1DataGridViewTextBoxColumn.Name = "zdy1DataGridViewTextBoxColumn";
            // 
            // zdy2DataGridViewTextBoxColumn
            // 
            this.zdy2DataGridViewTextBoxColumn.DataPropertyName = "zdy2";
            this.zdy2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.zdy2DataGridViewTextBoxColumn.Name = "zdy2DataGridViewTextBoxColumn";
            // 
            // zdy3DataGridViewTextBoxColumn
            // 
            this.zdy3DataGridViewTextBoxColumn.DataPropertyName = "zdy3";
            this.zdy3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.zdy3DataGridViewTextBoxColumn.Name = "zdy3DataGridViewTextBoxColumn";
            // 
            // zdy4DataGridViewTextBoxColumn
            // 
            this.zdy4DataGridViewTextBoxColumn.DataPropertyName = "zdy4";
            this.zdy4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.zdy4DataGridViewTextBoxColumn.Name = "zdy4DataGridViewTextBoxColumn";
            // 
            // zdy5DataGridViewTextBoxColumn
            // 
            this.zdy5DataGridViewTextBoxColumn.DataPropertyName = "zdy5";
            this.zdy5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.zdy5DataGridViewTextBoxColumn.Name = "zdy5DataGridViewTextBoxColumn";
            // 
            // zyx1DataGridViewTextBoxColumn
            // 
            this.zyx1DataGridViewTextBoxColumn.DataPropertyName = "zyx1";
            this.zyx1DataGridViewTextBoxColumn.HeaderText = "自由项1";
            this.zyx1DataGridViewTextBoxColumn.Name = "zyx1DataGridViewTextBoxColumn";
            // 
            // zyx2DataGridViewTextBoxColumn
            // 
            this.zyx2DataGridViewTextBoxColumn.DataPropertyName = "zyx2";
            this.zyx2DataGridViewTextBoxColumn.HeaderText = "自由项2";
            this.zyx2DataGridViewTextBoxColumn.Name = "zyx2DataGridViewTextBoxColumn";
            // 
            // zyx3DataGridViewTextBoxColumn
            // 
            this.zyx3DataGridViewTextBoxColumn.DataPropertyName = "zyx3";
            this.zyx3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.zyx3DataGridViewTextBoxColumn.Name = "zyx3DataGridViewTextBoxColumn";
            // 
            // zyx4DataGridViewTextBoxColumn
            // 
            this.zyx4DataGridViewTextBoxColumn.DataPropertyName = "zyx4";
            this.zyx4DataGridViewTextBoxColumn.HeaderText = "自由项4";
            this.zyx4DataGridViewTextBoxColumn.Name = "zyx4DataGridViewTextBoxColumn";
            // 
            // zyx5DataGridViewTextBoxColumn
            // 
            this.zyx5DataGridViewTextBoxColumn.DataPropertyName = "zyx5";
            this.zyx5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.zyx5DataGridViewTextBoxColumn.Name = "zyx5DataGridViewTextBoxColumn";
            // 
            // pkcorpDataGridViewTextBoxColumn
            // 
            this.pkcorpDataGridViewTextBoxColumn.DataPropertyName = "pk_corp";
            this.pkcorpDataGridViewTextBoxColumn.HeaderText = "公司";
            this.pkcorpDataGridViewTextBoxColumn.Name = "pkcorpDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmdElement
            // 
            this.cmdElement.Adapter = this.Adapter;
            this.cmdElement.MergeReturnTarget = false;
            this.cmdElement.Method = "AlloyElementDataAccept";
            this.cmdElement.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdElement.Parameters.Add(this.l3CommandParameter2);
            this.cmdElement.ReturnTarget = null;
            this.cmdElement.ReturnTargetProperty = null;
            this.cmdElement.Trigger = null;
            this.cmdElement.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsElement;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'AlloyDataAccept\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // bsAlloyCode2
            // 
            this.bsAlloyCode2.DataMember = "L3DataTable";
            this.bsAlloyCode2.DataSource = this.dsAlloyCode;
            // 
            // AlloyInformationInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 509);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.MinimizeBox = false;
            this.Name = "AlloyInformationInputFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合金信息导入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyInformationInputFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElement)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloyInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAlloyInforEXL;
        private AppSvrHMI.L3DataSet dsAlloyInfor;
        private System.Windows.Forms.BindingSource bsAlloyInfor;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsAllyInfor;
        private AppSvrHMI.L3Command cmdAlloyInfor;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvAlloyInfor;
        private System.Data.DataColumn coldsAlloyInforL3DataTableRec_Time;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private System.Windows.Forms.DataGridView dvElement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnElementEXL;
        private System.Data.DataColumn coldsAlloyInforL3DataTableGUID;
        private System.Data.DataColumn coldsAlloyInforL3DataTableName;
        private System.Data.DataColumn coldsAlloyInforL3DataTablecinventoryid;
        private System.Data.DataColumn coldsAlloyInforL3DataTableInvcode;
        private System.Data.DataColumn coldsAlloyInforL3DataTableInvname;
        private System.Data.DataColumn coldsAlloyInforL3DataTableInvspec;
        private System.Data.DataColumn coldsAlloyInforL3DataTableInvtype;
        private System.Data.DataColumn coldsAlloyInforL3DataTableDbilldate;
        private System.Data.DataColumn coldsAlloyInforL3DataTablecoutwarehouseid;
        private System.Data.DataColumn coldsAlloyInforL3DataTablecinwarehouseid;
        private System.Data.DataColumn coldsAlloyInforL3DataTablennum;
        private System.Data.DataColumn coldsAlloyInforL3DataTablenassistnum;
        private System.Data.DataColumn coldsAlloyInforL3DataTablevproductbatchcode;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezdy1;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezdy2;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezdy3;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezdy4;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezdy5;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezyx1;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezyx2;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezyx3;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezyx4;
        private System.Data.DataColumn coldsAlloyInforL3DataTablezyx5;
        private System.Data.DataColumn coldsAlloyInforL3DataTablepk_corp;
        private AppSvrHMI.L3DataSet dsElement;
        private System.Data.DataTable schemadsElement;
        private System.Data.DataColumn coldsElementL3DataTableGUID;
        private System.Data.DataColumn coldsElementL3DataTableName;
        private System.Data.DataColumn coldsElementL3DataTableRec_Time;
        private System.Data.DataColumn coldsElementL3DataTablevproductbatchcode;
        private System.Data.DataColumn coldsElementL3DataTablevcheckbillcode;
        private System.Data.DataColumn coldsElementL3DataTablebcompcheck;
        private System.Data.DataColumn coldsElementL3DataTablenassistchecknum;
        private System.Data.DataColumn coldsElementL3DataTablecstoreorganization;
        private System.Data.DataColumn coldsElementL3DataTablecpraycorp;
        private System.Data.DataColumn coldsElementL3DataTableccheckbillid;
        private System.Data.DataColumn coldsElementL3DataTablecbaseid;
        private System.Data.DataColumn coldsElementL3DataTablevsamplecode;
        private System.Data.DataColumn coldsElementL3DataTablennum;
        private System.Data.DataColumn coldsElementL3DataTableC;
        private System.Data.DataColumn coldsElementL3DataTableSi;
        private System.Data.DataColumn coldsElementL3DataTableMn;
        private System.Data.DataColumn coldsElementL3DataTableP;
        private System.Data.DataColumn coldsElementL3DataTableS;
        private System.Windows.Forms.BindingSource bsElement;
        private AppSvrHMI.L3Command cmdElement;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataColumn coldsElementL3DataTableCu;
        private System.Data.DataColumn coldsElementL3DataTableNi;
        private System.Data.DataColumn coldsElementL3DataTableCr;
        private System.Data.DataColumn coldsElementL3DataTableMo;
        private System.Data.DataColumn coldsElementL3DataTableV;
        private System.Data.DataColumn coldsElementL3DataTableNb;
        private System.Data.DataColumn coldsElementL3DataTableAl;
        private System.Data.DataColumn coldsElementL3DataTableAlS;
        private System.Data.DataColumn coldsElementL3DataTableTi;
        private System.Data.DataColumn coldsElementL3DataTableB;
        private System.Data.DataColumn coldsElementL3DataTableSb;
        private System.Data.DataColumn coldsElementL3DataTableAs;
        private System.Data.DataColumn coldsElementL3DataTableSn;
        private System.Data.DataColumn coldsElementL3DataTableZn;
        private System.Data.DataColumn coldsElementL3DataTableCa;
        private System.Data.DataColumn coldsElementL3DataTableW;
        private System.Data.DataColumn coldsElementL3DataTablePb;
        private System.Data.DataColumn coldsElementL3DataTableRe;
        private System.Data.DataColumn coldsElementL3DataTableCeq;
        private System.Data.DataColumn coldsElementL3DataTableN;
        private System.Data.DataColumn coldsElementL3DataTableH;
        private System.Data.DataColumn coldsElementL3DataTableO;
        private System.Data.DataColumn coldsElementL3DataTableOther1;
        private System.Data.DataColumn coldsElementL3DataTableOther2;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnElementAdd;
        private System.Windows.Forms.ToolStripButton btnElementDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnElementConfirm;
        private System.Windows.Forms.ToolStripButton btnElementCancel;
        private System.Windows.Forms.BindingSource bsAlloyCode1;
        private System.Windows.Forms.BindingSource bsAlloyCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn recTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinventoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbilldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vproductbatchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vproductbatchcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcheckbillcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcompcheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistchecknumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstoreorganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpraycorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckbillidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbaseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsamplecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ceq;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn O;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
    }
}