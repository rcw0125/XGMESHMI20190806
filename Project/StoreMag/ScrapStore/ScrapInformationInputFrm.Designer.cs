namespace StoreMag.ScrapStore
{
    partial class ScrapInformationInputFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapInformationInputFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPurchaseEXL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bsScrapInfor = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapInfor = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsAllyInfor = new System.Data.DataTable();
            this.coldsBulkInforL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableGUID = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableName = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablevbillcode = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablecwarehouseid = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablecinventoryid = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableInvname = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableDbilldate = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTableninnum = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablenassistinnum = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsScrapInforL3DataTablepk_corp = new System.Data.DataColumn();
            this.cmdScrapInfor = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvScrapInfor = new System.Windows.Forms.DataGridView();
            this.vbillcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinventoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsScrap1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapCode = new AppSvrHMI.L3DataSet();
            this.schemadsScrapCode = new System.Data.DataTable();
            this.coldsScrapCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.ninnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbilldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistinnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTransEXL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransAdd = new System.Windows.Forms.ToolStripButton();
            this.btnTransDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnTransCancel = new System.Windows.Forms.ToolStripButton();
            this.dsTrans = new AppSvrHMI.L3DataSet();
            this.schemadsTrans = new System.Data.DataTable();
            this.coldsTransL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTransL3DataTableName = new System.Data.DataColumn();
            this.coldsTransL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsTransL3DataTablecinventoryid = new System.Data.DataColumn();
            this.coldsTransL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsTransL3DataTableInvname = new System.Data.DataColumn();
            this.coldsTransL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsTransL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsTransL3DataTableDbilldate = new System.Data.DataColumn();
            this.coldsTransL3DataTablecoutwarehouseid = new System.Data.DataColumn();
            this.coldsTransL3DataTablecinwarehouseid = new System.Data.DataColumn();
            this.coldsTransL3DataTablennum = new System.Data.DataColumn();
            this.coldsTransL3DataTablenassistnum = new System.Data.DataColumn();
            this.coldsTransL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsTransL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsTransL3DataTablepk_corp = new System.Data.DataColumn();
            this.bsTrans = new System.Windows.Forms.BindingSource(this.components);
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvTrans = new System.Windows.Forms.DataGridView();
            this.cinventoryidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsScrap2 = new System.Windows.Forms.BindingSource(this.components);
            this.invnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invspecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbilldateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdTrans = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).BeginInit();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap2)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnPurchaseEXL,
            this.toolStripSeparator4,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(852, 43);
            this.tSp1.TabIndex = 28;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnPurchaseEXL
            // 
            this.btnPurchaseEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseEXL.Image")));
            this.btnPurchaseEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPurchaseEXL.Name = "btnPurchaseEXL";
            this.btnPurchaseEXL.Size = new System.Drawing.Size(167, 40);
            this.btnPurchaseEXL.Text = "采购入库信息从EXL导入";
            this.btnPurchaseEXL.Click += new System.EventHandler(this.btnPurchaseEXL_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
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
            // bsScrapInfor
            // 
            this.bsScrapInfor.DataMember = "L3DataTable";
            this.bsScrapInfor.DataSource = this.dsScrapInfor;
            // 
            // dsScrapInfor
            // 
            this.dsScrapInfor.DataSetName = "L3DataSet";
            this.dsScrapInfor.DeleteMethod = null;
            this.dsScrapInfor.InsertMethod = null;
            this.dsScrapInfor.L3DataAdapter = this.Adapter;
            this.dsScrapInfor.LoadEvent = "Click";
            this.dsScrapInfor.LoadTrigger = null;
            this.dsScrapInfor.RefreshValve = 1000;
            this.dsScrapInfor.SourceCommand = null;
            this.dsScrapInfor.SourceCondition = "";
            this.dsScrapInfor.SourceMethod = "";
            this.dsScrapInfor.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsScrapInfor.SourceURI = "";
            this.dsScrapInfor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAllyInfor});
            this.dsScrapInfor.UpdateEvent = "Click";
            this.dsScrapInfor.UpdateMethod = null;
            this.dsScrapInfor.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsAllyInfor
            // 
            this.schemadsAllyInfor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInforL3DataTableRec_Time,
            this.coldsScrapInforL3DataTableGUID,
            this.coldsScrapInforL3DataTableName,
            this.coldsScrapInforL3DataTablevbillcode,
            this.coldsScrapInforL3DataTablecwarehouseid,
            this.coldsScrapInforL3DataTablecinventoryid,
            this.coldsScrapInforL3DataTableInvcode,
            this.coldsScrapInforL3DataTableInvname,
            this.coldsScrapInforL3DataTableInvspec,
            this.coldsScrapInforL3DataTableInvtype,
            this.coldsScrapInforL3DataTableDbilldate,
            this.coldsScrapInforL3DataTableninnum,
            this.coldsScrapInforL3DataTablenassistinnum,
            this.coldsScrapInforL3DataTablezdy1,
            this.coldsScrapInforL3DataTablezdy2,
            this.coldsScrapInforL3DataTablezdy3,
            this.coldsScrapInforL3DataTablezdy4,
            this.coldsScrapInforL3DataTablezdy5,
            this.coldsScrapInforL3DataTablezyx1,
            this.coldsScrapInforL3DataTablezyx2,
            this.coldsScrapInforL3DataTablezyx3,
            this.coldsScrapInforL3DataTablezyx4,
            this.coldsScrapInforL3DataTablezyx5,
            this.coldsScrapInforL3DataTablepk_corp});
            this.schemadsAllyInfor.TableName = "L3DataTable";
            // 
            // coldsBulkInforL3DataTableRec_Time
            // 
            this.coldsBulkInforL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsBulkInforL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsBulkInforL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsBulkInforL3DataTableRec_Time.Namespace = "";
            // 
            // coldsScrapInforL3DataTableGUID
            // 
            this.coldsScrapInforL3DataTableGUID.Caption = "GUID";
            this.coldsScrapInforL3DataTableGUID.ColumnName = "GUID";
            this.coldsScrapInforL3DataTableGUID.Namespace = "";
            // 
            // coldsScrapInforL3DataTableName
            // 
            this.coldsScrapInforL3DataTableName.Caption = "Name";
            this.coldsScrapInforL3DataTableName.ColumnName = "Name";
            this.coldsScrapInforL3DataTableName.Namespace = "";
            // 
            // coldsScrapInforL3DataTablevbillcode
            // 
            this.coldsScrapInforL3DataTablevbillcode.Caption = "vbillcode";
            this.coldsScrapInforL3DataTablevbillcode.ColumnName = "vbillcode";
            this.coldsScrapInforL3DataTablevbillcode.Namespace = "";
            // 
            // coldsScrapInforL3DataTablecwarehouseid
            // 
            this.coldsScrapInforL3DataTablecwarehouseid.Caption = "cwarehouseid";
            this.coldsScrapInforL3DataTablecwarehouseid.ColumnName = "cwarehouseid";
            this.coldsScrapInforL3DataTablecwarehouseid.Namespace = "";
            // 
            // coldsScrapInforL3DataTablecinventoryid
            // 
            this.coldsScrapInforL3DataTablecinventoryid.Caption = "cinventoryid";
            this.coldsScrapInforL3DataTablecinventoryid.ColumnName = "cinventoryid";
            this.coldsScrapInforL3DataTablecinventoryid.Namespace = "";
            // 
            // coldsScrapInforL3DataTableInvcode
            // 
            this.coldsScrapInforL3DataTableInvcode.Caption = "Invcode";
            this.coldsScrapInforL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsScrapInforL3DataTableInvcode.Namespace = "";
            // 
            // coldsScrapInforL3DataTableInvname
            // 
            this.coldsScrapInforL3DataTableInvname.Caption = "Invname";
            this.coldsScrapInforL3DataTableInvname.ColumnName = "Invname";
            this.coldsScrapInforL3DataTableInvname.Namespace = "";
            // 
            // coldsScrapInforL3DataTableInvspec
            // 
            this.coldsScrapInforL3DataTableInvspec.Caption = "Invspec";
            this.coldsScrapInforL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsScrapInforL3DataTableInvspec.Namespace = "";
            // 
            // coldsScrapInforL3DataTableInvtype
            // 
            this.coldsScrapInforL3DataTableInvtype.Caption = "Invtype";
            this.coldsScrapInforL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsScrapInforL3DataTableInvtype.Namespace = "";
            // 
            // coldsScrapInforL3DataTableDbilldate
            // 
            this.coldsScrapInforL3DataTableDbilldate.Caption = "Dbilldate";
            this.coldsScrapInforL3DataTableDbilldate.ColumnName = "Dbilldate";
            this.coldsScrapInforL3DataTableDbilldate.DataType = typeof(System.DateTime);
            this.coldsScrapInforL3DataTableDbilldate.Namespace = "";
            // 
            // coldsScrapInforL3DataTableninnum
            // 
            this.coldsScrapInforL3DataTableninnum.Caption = "ninnum";
            this.coldsScrapInforL3DataTableninnum.ColumnName = "ninnum";
            this.coldsScrapInforL3DataTableninnum.DataType = typeof(double);
            this.coldsScrapInforL3DataTableninnum.Namespace = "";
            // 
            // coldsScrapInforL3DataTablenassistinnum
            // 
            this.coldsScrapInforL3DataTablenassistinnum.Caption = "nassistinnum";
            this.coldsScrapInforL3DataTablenassistinnum.ColumnName = "nassistinnum";
            this.coldsScrapInforL3DataTablenassistinnum.DataType = typeof(int);
            this.coldsScrapInforL3DataTablenassistinnum.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezdy1
            // 
            this.coldsScrapInforL3DataTablezdy1.Caption = "zdy1";
            this.coldsScrapInforL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsScrapInforL3DataTablezdy1.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezdy2
            // 
            this.coldsScrapInforL3DataTablezdy2.Caption = "zdy2";
            this.coldsScrapInforL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsScrapInforL3DataTablezdy2.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezdy3
            // 
            this.coldsScrapInforL3DataTablezdy3.Caption = "zdy3";
            this.coldsScrapInforL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsScrapInforL3DataTablezdy3.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezdy4
            // 
            this.coldsScrapInforL3DataTablezdy4.Caption = "zdy4";
            this.coldsScrapInforL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsScrapInforL3DataTablezdy4.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezdy5
            // 
            this.coldsScrapInforL3DataTablezdy5.Caption = "zdy5";
            this.coldsScrapInforL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsScrapInforL3DataTablezdy5.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezyx1
            // 
            this.coldsScrapInforL3DataTablezyx1.Caption = "zyx1";
            this.coldsScrapInforL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsScrapInforL3DataTablezyx1.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezyx2
            // 
            this.coldsScrapInforL3DataTablezyx2.Caption = "zyx2";
            this.coldsScrapInforL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsScrapInforL3DataTablezyx2.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezyx3
            // 
            this.coldsScrapInforL3DataTablezyx3.Caption = "zyx3";
            this.coldsScrapInforL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsScrapInforL3DataTablezyx3.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezyx4
            // 
            this.coldsScrapInforL3DataTablezyx4.Caption = "zyx4";
            this.coldsScrapInforL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsScrapInforL3DataTablezyx4.Namespace = "";
            // 
            // coldsScrapInforL3DataTablezyx5
            // 
            this.coldsScrapInforL3DataTablezyx5.Caption = "zyx5";
            this.coldsScrapInforL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsScrapInforL3DataTablezyx5.Namespace = "";
            // 
            // coldsScrapInforL3DataTablepk_corp
            // 
            this.coldsScrapInforL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsScrapInforL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsScrapInforL3DataTablepk_corp.Namespace = "";
            // 
            // cmdScrapInfor
            // 
            this.cmdScrapInfor.Adapter = this.Adapter;
            this.cmdScrapInfor.MergeReturnTarget = false;
            this.cmdScrapInfor.Method = "ScrapDataAccept";
            this.cmdScrapInfor.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdScrapInfor.Parameters.Add(this.l3CommandParameter3);
            this.cmdScrapInfor.ReturnTarget = null;
            this.cmdScrapInfor.ReturnTargetProperty = null;
            this.cmdScrapInfor.Trigger = null;
            this.cmdScrapInfor.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter3.SourceObject = this.dsScrapInfor;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsScrapInfor;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsScrapInfor;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvScrapInfor);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(852, 234);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvScrapInfor
            // 
            this.dvScrapInfor.AllowUserToAddRows = false;
            this.dvScrapInfor.AutoGenerateColumns = false;
            this.dvScrapInfor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvScrapInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvScrapInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vbillcodeDataGridViewTextBoxColumn,
            this.cwarehouseidDataGridViewTextBoxColumn,
            this.cinventoryidDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.ninnumDataGridViewTextBoxColumn,
            this.invnameDataGridViewTextBoxColumn,
            this.invspecDataGridViewTextBoxColumn,
            this.invtypeDataGridViewTextBoxColumn,
            this.dbilldateDataGridViewTextBoxColumn,
            this.nassistinnumDataGridViewTextBoxColumn,
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
            this.pkcorpDataGridViewTextBoxColumn});
            this.dvScrapInfor.DataSource = this.bsScrapInfor;
            this.dvScrapInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvScrapInfor.Location = new System.Drawing.Point(0, 0);
            this.dvScrapInfor.Name = "dvScrapInfor";
            this.dvScrapInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvScrapInfor.RowTemplate.Height = 23;
            this.dvScrapInfor.Size = new System.Drawing.Size(852, 234);
            this.dvScrapInfor.TabIndex = 30;
            this.dvScrapInfor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvScrapInfor_DataError);
            // 
            // vbillcodeDataGridViewTextBoxColumn
            // 
            this.vbillcodeDataGridViewTextBoxColumn.DataPropertyName = "vbillcode";
            this.vbillcodeDataGridViewTextBoxColumn.HeaderText = "入库单号";
            this.vbillcodeDataGridViewTextBoxColumn.Name = "vbillcodeDataGridViewTextBoxColumn";
            // 
            // cwarehouseidDataGridViewTextBoxColumn
            // 
            this.cwarehouseidDataGridViewTextBoxColumn.DataPropertyName = "cwarehouseid";
            this.cwarehouseidDataGridViewTextBoxColumn.HeaderText = "入库仓库";
            this.cwarehouseidDataGridViewTextBoxColumn.Name = "cwarehouseidDataGridViewTextBoxColumn";
            // 
            // cinventoryidDataGridViewTextBoxColumn
            // 
            this.cinventoryidDataGridViewTextBoxColumn.DataPropertyName = "cinventoryid";
            this.cinventoryidDataGridViewTextBoxColumn.HeaderText = "入库物料";
            this.cinventoryidDataGridViewTextBoxColumn.Name = "cinventoryidDataGridViewTextBoxColumn";
            // 
            // invcodeDataGridViewTextBoxColumn
            // 
            this.invcodeDataGridViewTextBoxColumn.DataPropertyName = "Invcode";
            this.invcodeDataGridViewTextBoxColumn.DataSource = this.bsScrap1;
            this.invcodeDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.invcodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invcodeDataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // bsScrap1
            // 
            this.bsScrap1.DataMember = "L3DataTable";
            this.bsScrap1.DataSource = this.dsScrapCode;
            // 
            // dsScrapCode
            // 
            this.dsScrapCode.DataSetName = "L3DataSet";
            this.dsScrapCode.DeleteMethod = null;
            this.dsScrapCode.InsertMethod = null;
            this.dsScrapCode.L3DataAdapter = this.Adapter;
            this.dsScrapCode.LoadEvent = "Click";
            this.dsScrapCode.LoadTrigger = null;
            this.dsScrapCode.RefreshValve = 1000;
            this.dsScrapCode.SourceCommand = null;
            this.dsScrapCode.SourceCondition = "Code_Group = \'SCRAP_CODE\'";
            this.dsScrapCode.SourceMethod = "";
            this.dsScrapCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapCode.SubscribeTarget = null;
            this.dsScrapCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapCode});
            this.dsScrapCode.UpdateEvent = "Click";
            this.dsScrapCode.UpdateMethod = null;
            this.dsScrapCode.UpdateTrigger = null;
            // 
            // schemadsScrapCode
            // 
            this.schemadsScrapCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapCodeL3DataTableCode,
            this.coldsScrapCodeL3DataTableCode_Des});
            this.schemadsScrapCode.TableName = "L3DataTable";
            // 
            // coldsScrapCodeL3DataTableCode
            // 
            this.coldsScrapCodeL3DataTableCode.Caption = "Code";
            this.coldsScrapCodeL3DataTableCode.ColumnName = "Code";
            this.coldsScrapCodeL3DataTableCode.Namespace = "";
            // 
            // coldsScrapCodeL3DataTableCode_Des
            // 
            this.coldsScrapCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.Namespace = "";
            // 
            // ninnumDataGridViewTextBoxColumn
            // 
            this.ninnumDataGridViewTextBoxColumn.DataPropertyName = "ninnum";
            this.ninnumDataGridViewTextBoxColumn.HeaderText = "入库数量";
            this.ninnumDataGridViewTextBoxColumn.Name = "ninnumDataGridViewTextBoxColumn";
            // 
            // invnameDataGridViewTextBoxColumn
            // 
            this.invnameDataGridViewTextBoxColumn.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn.Name = "invnameDataGridViewTextBoxColumn";
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
            this.dbilldateDataGridViewTextBoxColumn.HeaderText = "入库日期";
            this.dbilldateDataGridViewTextBoxColumn.Name = "dbilldateDataGridViewTextBoxColumn";
            // 
            // nassistinnumDataGridViewTextBoxColumn
            // 
            this.nassistinnumDataGridViewTextBoxColumn.DataPropertyName = "nassistinnum";
            this.nassistinnumDataGridViewTextBoxColumn.HeaderText = "入库辅数量";
            this.nassistinnumDataGridViewTextBoxColumn.Name = "nassistinnumDataGridViewTextBoxColumn";
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransEXL,
            this.toolStripSeparator5,
            this.btnTransAdd,
            this.btnTransDel,
            this.toolStripSeparator3,
            this.btnTransConfirm,
            this.btnTransCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 277);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(852, 43);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTransEXL
            // 
            this.btnTransEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnTransEXL.Image")));
            this.btnTransEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransEXL.Name = "btnTransEXL";
            this.btnTransEXL.Size = new System.Drawing.Size(143, 40);
            this.btnTransEXL.Text = "转库信息从EXL导入";
            this.btnTransEXL.Click += new System.EventHandler(this.btnTransEXL_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnTransAdd
            // 
            this.btnTransAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTransAdd.Image")));
            this.btnTransAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransAdd.Name = "btnTransAdd";
            this.btnTransAdd.Size = new System.Drawing.Size(65, 40);
            this.btnTransAdd.Text = "新增";
            this.btnTransAdd.Click += new System.EventHandler(this.btnTransAdd_Click);
            // 
            // btnTransDel
            // 
            this.btnTransDel.Image = ((System.Drawing.Image)(resources.GetObject("btnTransDel.Image")));
            this.btnTransDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransDel.Name = "btnTransDel";
            this.btnTransDel.Size = new System.Drawing.Size(65, 40);
            this.btnTransDel.Text = "删除";
            this.btnTransDel.Click += new System.EventHandler(this.btnTransDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnTransConfirm
            // 
            this.btnTransConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnTransConfirm.Image")));
            this.btnTransConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransConfirm.Name = "btnTransConfirm";
            this.btnTransConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnTransConfirm.Text = "确定";
            this.btnTransConfirm.Click += new System.EventHandler(this.btnTransConfirm_Click);
            // 
            // btnTransCancel
            // 
            this.btnTransCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnTransCancel.Image")));
            this.btnTransCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransCancel.Name = "btnTransCancel";
            this.btnTransCancel.Size = new System.Drawing.Size(65, 40);
            this.btnTransCancel.Text = "取消";
            this.btnTransCancel.Click += new System.EventHandler(this.btnTransCancel_Click);
            // 
            // dsTrans
            // 
            this.dsTrans.DataSetName = "L3DataSet";
            this.dsTrans.DeleteMethod = null;
            this.dsTrans.InsertMethod = null;
            this.dsTrans.L3DataAdapter = null;
            this.dsTrans.LoadEvent = "Click";
            this.dsTrans.LoadTrigger = null;
            this.dsTrans.RefreshValve = 1000;
            this.dsTrans.SourceCommand = null;
            this.dsTrans.SourceCondition = null;
            this.dsTrans.SourceMethod = "";
            this.dsTrans.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTrans.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Trans_Tel_Data";
            this.dsTrans.SubscribeTarget = null;
            this.dsTrans.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTrans});
            this.dsTrans.UpdateEvent = "Click";
            this.dsTrans.UpdateMethod = null;
            this.dsTrans.UpdateTrigger = null;
            // 
            // schemadsTrans
            // 
            this.schemadsTrans.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTransL3DataTableGUID,
            this.coldsTransL3DataTableName,
            this.coldsTransL3DataTableRec_Time,
            this.coldsTransL3DataTablecinventoryid,
            this.coldsTransL3DataTableInvcode,
            this.coldsTransL3DataTableInvname,
            this.coldsTransL3DataTableInvspec,
            this.coldsTransL3DataTableInvtype,
            this.coldsTransL3DataTableDbilldate,
            this.coldsTransL3DataTablecoutwarehouseid,
            this.coldsTransL3DataTablecinwarehouseid,
            this.coldsTransL3DataTablennum,
            this.coldsTransL3DataTablenassistnum,
            this.coldsTransL3DataTablezdy1,
            this.coldsTransL3DataTablezdy2,
            this.coldsTransL3DataTablezdy3,
            this.coldsTransL3DataTablezdy4,
            this.coldsTransL3DataTablezdy5,
            this.coldsTransL3DataTablezyx1,
            this.coldsTransL3DataTablezyx2,
            this.coldsTransL3DataTablezyx3,
            this.coldsTransL3DataTablezyx4,
            this.coldsTransL3DataTablezyx5,
            this.coldsTransL3DataTablepk_corp});
            this.schemadsTrans.TableName = "L3DataTable";
            // 
            // coldsTransL3DataTableGUID
            // 
            this.coldsTransL3DataTableGUID.Caption = "GUID";
            this.coldsTransL3DataTableGUID.ColumnName = "GUID";
            this.coldsTransL3DataTableGUID.Namespace = "";
            // 
            // coldsTransL3DataTableName
            // 
            this.coldsTransL3DataTableName.Caption = "Name";
            this.coldsTransL3DataTableName.ColumnName = "Name";
            this.coldsTransL3DataTableName.Namespace = "";
            // 
            // coldsTransL3DataTableRec_Time
            // 
            this.coldsTransL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsTransL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsTransL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsTransL3DataTableRec_Time.Namespace = "";
            // 
            // coldsTransL3DataTablecinventoryid
            // 
            this.coldsTransL3DataTablecinventoryid.Caption = "cinventoryid";
            this.coldsTransL3DataTablecinventoryid.ColumnName = "cinventoryid";
            this.coldsTransL3DataTablecinventoryid.Namespace = "";
            // 
            // coldsTransL3DataTableInvcode
            // 
            this.coldsTransL3DataTableInvcode.Caption = "Invcode";
            this.coldsTransL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsTransL3DataTableInvcode.Namespace = "";
            // 
            // coldsTransL3DataTableInvname
            // 
            this.coldsTransL3DataTableInvname.Caption = "Invname";
            this.coldsTransL3DataTableInvname.ColumnName = "Invname";
            this.coldsTransL3DataTableInvname.Namespace = "";
            // 
            // coldsTransL3DataTableInvspec
            // 
            this.coldsTransL3DataTableInvspec.Caption = "Invspec";
            this.coldsTransL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsTransL3DataTableInvspec.Namespace = "";
            // 
            // coldsTransL3DataTableInvtype
            // 
            this.coldsTransL3DataTableInvtype.Caption = "Invtype";
            this.coldsTransL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsTransL3DataTableInvtype.Namespace = "";
            // 
            // coldsTransL3DataTableDbilldate
            // 
            this.coldsTransL3DataTableDbilldate.Caption = "Dbilldate";
            this.coldsTransL3DataTableDbilldate.ColumnName = "Dbilldate";
            this.coldsTransL3DataTableDbilldate.DataType = typeof(System.DateTime);
            this.coldsTransL3DataTableDbilldate.Namespace = "";
            // 
            // coldsTransL3DataTablecoutwarehouseid
            // 
            this.coldsTransL3DataTablecoutwarehouseid.Caption = "coutwarehouseid";
            this.coldsTransL3DataTablecoutwarehouseid.ColumnName = "coutwarehouseid";
            this.coldsTransL3DataTablecoutwarehouseid.Namespace = "";
            // 
            // coldsTransL3DataTablecinwarehouseid
            // 
            this.coldsTransL3DataTablecinwarehouseid.Caption = "cinwarehouseid";
            this.coldsTransL3DataTablecinwarehouseid.ColumnName = "cinwarehouseid";
            this.coldsTransL3DataTablecinwarehouseid.Namespace = "";
            // 
            // coldsTransL3DataTablennum
            // 
            this.coldsTransL3DataTablennum.Caption = "nnum";
            this.coldsTransL3DataTablennum.ColumnName = "nnum";
            this.coldsTransL3DataTablennum.DataType = typeof(double);
            this.coldsTransL3DataTablennum.Namespace = "";
            // 
            // coldsTransL3DataTablenassistnum
            // 
            this.coldsTransL3DataTablenassistnum.Caption = "nassistnum";
            this.coldsTransL3DataTablenassistnum.ColumnName = "nassistnum";
            this.coldsTransL3DataTablenassistnum.DataType = typeof(int);
            this.coldsTransL3DataTablenassistnum.Namespace = "";
            // 
            // coldsTransL3DataTablezdy1
            // 
            this.coldsTransL3DataTablezdy1.Caption = "zdy1";
            this.coldsTransL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsTransL3DataTablezdy1.Namespace = "";
            // 
            // coldsTransL3DataTablezdy2
            // 
            this.coldsTransL3DataTablezdy2.Caption = "zdy2";
            this.coldsTransL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsTransL3DataTablezdy2.Namespace = "";
            // 
            // coldsTransL3DataTablezdy3
            // 
            this.coldsTransL3DataTablezdy3.Caption = "zdy3";
            this.coldsTransL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsTransL3DataTablezdy3.Namespace = "";
            // 
            // coldsTransL3DataTablezdy4
            // 
            this.coldsTransL3DataTablezdy4.Caption = "zdy4";
            this.coldsTransL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsTransL3DataTablezdy4.Namespace = "";
            // 
            // coldsTransL3DataTablezdy5
            // 
            this.coldsTransL3DataTablezdy5.Caption = "zdy5";
            this.coldsTransL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsTransL3DataTablezdy5.Namespace = "";
            // 
            // coldsTransL3DataTablezyx1
            // 
            this.coldsTransL3DataTablezyx1.Caption = "zyx1";
            this.coldsTransL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsTransL3DataTablezyx1.Namespace = "";
            // 
            // coldsTransL3DataTablezyx2
            // 
            this.coldsTransL3DataTablezyx2.Caption = "zyx2";
            this.coldsTransL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsTransL3DataTablezyx2.Namespace = "";
            // 
            // coldsTransL3DataTablezyx3
            // 
            this.coldsTransL3DataTablezyx3.Caption = "zyx3";
            this.coldsTransL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsTransL3DataTablezyx3.Namespace = "";
            // 
            // coldsTransL3DataTablezyx4
            // 
            this.coldsTransL3DataTablezyx4.Caption = "zyx4";
            this.coldsTransL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsTransL3DataTablezyx4.Namespace = "";
            // 
            // coldsTransL3DataTablezyx5
            // 
            this.coldsTransL3DataTablezyx5.Caption = "zyx5";
            this.coldsTransL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsTransL3DataTablezyx5.Namespace = "";
            // 
            // coldsTransL3DataTablepk_corp
            // 
            this.coldsTransL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsTransL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsTransL3DataTablepk_corp.Namespace = "";
            // 
            // bsTrans
            // 
            this.bsTrans.DataMember = "L3DataTable";
            this.bsTrans.DataSource = this.dsTrans;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.Controls.Add(this.dvTrans);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(0, 320);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(852, 208);
            this.hmiRootPanel2.TabIndex = 31;
            // 
            // dvTrans
            // 
            this.dvTrans.AllowUserToAddRows = false;
            this.dvTrans.AutoGenerateColumns = false;
            this.dvTrans.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinventoryidDataGridViewTextBoxColumn1,
            this.invcodeDataGridViewTextBoxColumn1,
            this.invnameDataGridViewTextBoxColumn1,
            this.nnumDataGridViewTextBoxColumn,
            this.invspecDataGridViewTextBoxColumn1,
            this.invtypeDataGridViewTextBoxColumn1,
            this.dbilldateDataGridViewTextBoxColumn1,
            this.coutwarehouseidDataGridViewTextBoxColumn,
            this.cinwarehouseidDataGridViewTextBoxColumn,
            this.nassistnumDataGridViewTextBoxColumn,
            this.zdy1DataGridViewTextBoxColumn1,
            this.zdy2DataGridViewTextBoxColumn1,
            this.zdy3DataGridViewTextBoxColumn1,
            this.zdy4DataGridViewTextBoxColumn1,
            this.zdy5DataGridViewTextBoxColumn1,
            this.zyx1DataGridViewTextBoxColumn1,
            this.zyx2DataGridViewTextBoxColumn1,
            this.zyx3DataGridViewTextBoxColumn1,
            this.zyx4DataGridViewTextBoxColumn1,
            this.zyx5DataGridViewTextBoxColumn1,
            this.pkcorpDataGridViewTextBoxColumn1});
            this.dvTrans.DataSource = this.bsTrans;
            this.dvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTrans.Location = new System.Drawing.Point(0, 0);
            this.dvTrans.Name = "dvTrans";
            this.dvTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvTrans.RowTemplate.Height = 23;
            this.dvTrans.Size = new System.Drawing.Size(852, 208);
            this.dvTrans.TabIndex = 30;
            this.dvTrans.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvScrapInfor_DataError);
            // 
            // cinventoryidDataGridViewTextBoxColumn1
            // 
            this.cinventoryidDataGridViewTextBoxColumn1.DataPropertyName = "cinventoryid";
            this.cinventoryidDataGridViewTextBoxColumn1.HeaderText = "物料ID";
            this.cinventoryidDataGridViewTextBoxColumn1.Name = "cinventoryidDataGridViewTextBoxColumn1";
            // 
            // invcodeDataGridViewTextBoxColumn1
            // 
            this.invcodeDataGridViewTextBoxColumn1.DataPropertyName = "Invcode";
            this.invcodeDataGridViewTextBoxColumn1.DataSource = this.bsScrap2;
            this.invcodeDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.invcodeDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.invcodeDataGridViewTextBoxColumn1.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn1.Name = "invcodeDataGridViewTextBoxColumn1";
            this.invcodeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invcodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invcodeDataGridViewTextBoxColumn1.ValueMember = "Code";
            // 
            // bsScrap2
            // 
            this.bsScrap2.DataMember = "L3DataTable";
            this.bsScrap2.DataSource = this.dsScrapCode;
            // 
            // invnameDataGridViewTextBoxColumn1
            // 
            this.invnameDataGridViewTextBoxColumn1.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn1.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn1.Name = "invnameDataGridViewTextBoxColumn1";
            // 
            // nnumDataGridViewTextBoxColumn
            // 
            this.nnumDataGridViewTextBoxColumn.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn.HeaderText = "转库数量";
            this.nnumDataGridViewTextBoxColumn.Name = "nnumDataGridViewTextBoxColumn";
            // 
            // invspecDataGridViewTextBoxColumn1
            // 
            this.invspecDataGridViewTextBoxColumn1.DataPropertyName = "Invspec";
            this.invspecDataGridViewTextBoxColumn1.HeaderText = "物料规格";
            this.invspecDataGridViewTextBoxColumn1.Name = "invspecDataGridViewTextBoxColumn1";
            // 
            // invtypeDataGridViewTextBoxColumn1
            // 
            this.invtypeDataGridViewTextBoxColumn1.DataPropertyName = "Invtype";
            this.invtypeDataGridViewTextBoxColumn1.HeaderText = "物料型号";
            this.invtypeDataGridViewTextBoxColumn1.Name = "invtypeDataGridViewTextBoxColumn1";
            // 
            // dbilldateDataGridViewTextBoxColumn1
            // 
            this.dbilldateDataGridViewTextBoxColumn1.DataPropertyName = "Dbilldate";
            this.dbilldateDataGridViewTextBoxColumn1.HeaderText = "单据日期";
            this.dbilldateDataGridViewTextBoxColumn1.Name = "dbilldateDataGridViewTextBoxColumn1";
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
            // zdy1DataGridViewTextBoxColumn1
            // 
            this.zdy1DataGridViewTextBoxColumn1.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn1.HeaderText = "自定义1";
            this.zdy1DataGridViewTextBoxColumn1.Name = "zdy1DataGridViewTextBoxColumn1";
            // 
            // zdy2DataGridViewTextBoxColumn1
            // 
            this.zdy2DataGridViewTextBoxColumn1.DataPropertyName = "zdy2";
            this.zdy2DataGridViewTextBoxColumn1.HeaderText = "自定义2";
            this.zdy2DataGridViewTextBoxColumn1.Name = "zdy2DataGridViewTextBoxColumn1";
            // 
            // zdy3DataGridViewTextBoxColumn1
            // 
            this.zdy3DataGridViewTextBoxColumn1.DataPropertyName = "zdy3";
            this.zdy3DataGridViewTextBoxColumn1.HeaderText = "自定义3";
            this.zdy3DataGridViewTextBoxColumn1.Name = "zdy3DataGridViewTextBoxColumn1";
            // 
            // zdy4DataGridViewTextBoxColumn1
            // 
            this.zdy4DataGridViewTextBoxColumn1.DataPropertyName = "zdy4";
            this.zdy4DataGridViewTextBoxColumn1.HeaderText = "自定义4";
            this.zdy4DataGridViewTextBoxColumn1.Name = "zdy4DataGridViewTextBoxColumn1";
            // 
            // zdy5DataGridViewTextBoxColumn1
            // 
            this.zdy5DataGridViewTextBoxColumn1.DataPropertyName = "zdy5";
            this.zdy5DataGridViewTextBoxColumn1.HeaderText = "自定义5";
            this.zdy5DataGridViewTextBoxColumn1.Name = "zdy5DataGridViewTextBoxColumn1";
            // 
            // zyx1DataGridViewTextBoxColumn1
            // 
            this.zyx1DataGridViewTextBoxColumn1.DataPropertyName = "zyx1";
            this.zyx1DataGridViewTextBoxColumn1.HeaderText = "自由项1";
            this.zyx1DataGridViewTextBoxColumn1.Name = "zyx1DataGridViewTextBoxColumn1";
            // 
            // zyx2DataGridViewTextBoxColumn1
            // 
            this.zyx2DataGridViewTextBoxColumn1.DataPropertyName = "zyx2";
            this.zyx2DataGridViewTextBoxColumn1.HeaderText = "自由项2";
            this.zyx2DataGridViewTextBoxColumn1.Name = "zyx2DataGridViewTextBoxColumn1";
            // 
            // zyx3DataGridViewTextBoxColumn1
            // 
            this.zyx3DataGridViewTextBoxColumn1.DataPropertyName = "zyx3";
            this.zyx3DataGridViewTextBoxColumn1.HeaderText = "自由项3";
            this.zyx3DataGridViewTextBoxColumn1.Name = "zyx3DataGridViewTextBoxColumn1";
            // 
            // zyx4DataGridViewTextBoxColumn1
            // 
            this.zyx4DataGridViewTextBoxColumn1.DataPropertyName = "zyx4";
            this.zyx4DataGridViewTextBoxColumn1.HeaderText = "自由项4";
            this.zyx4DataGridViewTextBoxColumn1.Name = "zyx4DataGridViewTextBoxColumn1";
            // 
            // zyx5DataGridViewTextBoxColumn1
            // 
            this.zyx5DataGridViewTextBoxColumn1.DataPropertyName = "zyx5";
            this.zyx5DataGridViewTextBoxColumn1.HeaderText = "自由项5";
            this.zyx5DataGridViewTextBoxColumn1.Name = "zyx5DataGridViewTextBoxColumn1";
            // 
            // pkcorpDataGridViewTextBoxColumn1
            // 
            this.pkcorpDataGridViewTextBoxColumn1.DataPropertyName = "pk_corp";
            this.pkcorpDataGridViewTextBoxColumn1.HeaderText = "公司";
            this.pkcorpDataGridViewTextBoxColumn1.Name = "pkcorpDataGridViewTextBoxColumn1";
            // 
            // cmdTrans
            // 
            this.cmdTrans.Adapter = this.Adapter;
            this.cmdTrans.MergeReturnTarget = false;
            this.cmdTrans.Method = "ScrapDataAccept";
            this.cmdTrans.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdTrans.Parameters.Add(this.l3CommandParameter4);
            this.cmdTrans.ReturnTarget = null;
            this.cmdTrans.ReturnTargetProperty = null;
            this.cmdTrans.Trigger = null;
            this.cmdTrans.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.dsTrans;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // ScrapInformationInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.hmiRootPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.Name = "ScrapInformationInputFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "废钢信息导入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapInformationInputFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).EndInit();
            this.hmiRootPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPurchaseEXL;
        private AppSvrHMI.L3DataSet dsScrapInfor;
        private System.Windows.Forms.BindingSource bsScrapInfor;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsAllyInfor;
        private AppSvrHMI.L3Command cmdScrapInfor;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBulkInforL3DataTableRec_Time;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvScrapInfor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTransEXL;
        private System.Data.DataColumn coldsScrapInforL3DataTableGUID;
        private System.Data.DataColumn coldsScrapInforL3DataTableName;
        private System.Data.DataColumn coldsScrapInforL3DataTablevbillcode;
        private System.Data.DataColumn coldsScrapInforL3DataTablecwarehouseid;
        private System.Data.DataColumn coldsScrapInforL3DataTablecinventoryid;
        private System.Data.DataColumn coldsScrapInforL3DataTableInvcode;
        private System.Data.DataColumn coldsScrapInforL3DataTableInvname;
        private System.Data.DataColumn coldsScrapInforL3DataTableInvspec;
        private System.Data.DataColumn coldsScrapInforL3DataTableInvtype;
        private System.Data.DataColumn coldsScrapInforL3DataTableDbilldate;
        private System.Data.DataColumn coldsScrapInforL3DataTableninnum;
        private System.Data.DataColumn coldsScrapInforL3DataTablenassistinnum;
        private System.Data.DataColumn coldsScrapInforL3DataTablezdy1;
        private System.Data.DataColumn coldsScrapInforL3DataTablezdy2;
        private System.Data.DataColumn coldsScrapInforL3DataTablezdy3;
        private System.Data.DataColumn coldsScrapInforL3DataTablezdy4;
        private System.Data.DataColumn coldsScrapInforL3DataTablezdy5;
        private System.Data.DataColumn coldsScrapInforL3DataTablezyx1;
        private System.Data.DataColumn coldsScrapInforL3DataTablezyx2;
        private System.Data.DataColumn coldsScrapInforL3DataTablezyx3;
        private System.Data.DataColumn coldsScrapInforL3DataTablezyx4;
        private System.Data.DataColumn coldsScrapInforL3DataTablezyx5;
        private System.Data.DataColumn coldsScrapInforL3DataTablepk_corp;
        private AppSvrHMI.L3DataSet dsTrans;
        private System.Data.DataTable schemadsTrans;
        private System.Data.DataColumn coldsTransL3DataTableGUID;
        private System.Data.DataColumn coldsTransL3DataTableName;
        private System.Data.DataColumn coldsTransL3DataTableRec_Time;
        private System.Data.DataColumn coldsTransL3DataTablecinventoryid;
        private System.Data.DataColumn coldsTransL3DataTableInvcode;
        private System.Data.DataColumn coldsTransL3DataTableInvname;
        private System.Data.DataColumn coldsTransL3DataTableInvspec;
        private System.Data.DataColumn coldsTransL3DataTableInvtype;
        private System.Data.DataColumn coldsTransL3DataTableDbilldate;
        private System.Data.DataColumn coldsTransL3DataTablecoutwarehouseid;
        private System.Data.DataColumn coldsTransL3DataTablecinwarehouseid;
        private System.Data.DataColumn coldsTransL3DataTablennum;
        private System.Data.DataColumn coldsTransL3DataTablenassistnum;
        private System.Data.DataColumn coldsTransL3DataTablezdy1;
        private System.Data.DataColumn coldsTransL3DataTablezdy2;
        private System.Data.DataColumn coldsTransL3DataTablezdy3;
        private System.Data.DataColumn coldsTransL3DataTablezdy4;
        private System.Data.DataColumn coldsTransL3DataTablezdy5;
        private System.Data.DataColumn coldsTransL3DataTablezyx1;
        private System.Data.DataColumn coldsTransL3DataTablezyx2;
        private System.Data.DataColumn coldsTransL3DataTablezyx3;
        private System.Data.DataColumn coldsTransL3DataTablezyx4;
        private System.Data.DataColumn coldsTransL3DataTablezyx5;
        private System.Data.DataColumn coldsTransL3DataTablepk_corp;
        private System.Windows.Forms.BindingSource bsTrans;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.DataGridView dvTrans;
        private AppSvrHMI.L3Command cmdTrans;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnTransAdd;
        private System.Windows.Forms.ToolStripButton btnTransDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTransConfirm;
        private System.Windows.Forms.ToolStripButton btnTransCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private AppSvrHMI.L3DataSet dsScrapCode;
        private System.Data.DataTable schemadsScrapCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsScrap1;
        private System.Windows.Forms.BindingSource bsScrap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbillcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinventoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbilldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistinnumDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cinventoryidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn invcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invspecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbilldateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn1;
    }
}