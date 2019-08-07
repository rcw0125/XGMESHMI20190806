namespace StoreMag.BulkStore
{
    partial class BulkInformationInputFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkInformationInputFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBulkInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bsBulkInfor = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkInfor = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsAllyInfor = new System.Data.DataTable();
            this.coldsBulkInforL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableName = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablevbillcode = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablecwarehouseid = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablecinventoryid = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableInvname = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableDbilldate = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableninnum = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablenassistinnum = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTablevproductbatchcode = new System.Data.DataColumn();
            this.cmdBulkInfor = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvBulkTrans = new System.Windows.Forms.DataGridView();
            this.cinventoryidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBulkCode2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.invnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invspecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbilldateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBulkTrans = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkTrans = new AppSvrHMI.L3DataSet();
            this.schemadsBulkTrans = new System.Data.DataTable();
            this.coldsBulkTransL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableName = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableRec_Time = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablecinventoryid = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableInvname = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableDbilldate = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablecoutwarehouseid = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablecinwarehouseid = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablennum = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablenassistnum = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTablevproductbatchcode = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTrans = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransAdd = new System.Windows.Forms.ToolStripButton();
            this.btnTransDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnTransCancel = new System.Windows.Forms.ToolStripButton();
            this.dvBulkInfor = new System.Windows.Forms.DataGridView();
            this.vbillcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinventoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBulkCode1 = new System.Windows.Forms.BindingSource(this.components);
            this.invnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.vproductbatchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdBulkTrans = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.coldsBulkInforL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsBulkTransL3DataTableBatch_ID = new System.Data.DataColumn();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkTrans)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnBulkInfo,
            this.toolStripSeparator3,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator4,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(929, 43);
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
            // btnBulkInfo
            // 
            this.btnBulkInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnBulkInfo.Image")));
            this.btnBulkInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBulkInfo.Name = "btnBulkInfo";
            this.btnBulkInfo.Size = new System.Drawing.Size(167, 40);
            this.btnBulkInfo.Text = "采购入库信息从EXL导入";
            this.btnBulkInfo.Click += new System.EventHandler(this.btnBulkInfo_Click);
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
            // bsBulkInfor
            // 
            this.bsBulkInfor.DataMember = "L3DataTable";
            this.bsBulkInfor.DataSource = this.dsBulkInfor;
            // 
            // dsBulkInfor
            // 
            this.dsBulkInfor.AutoSubscribe = true;
            this.dsBulkInfor.DataSetName = "L3DataSet";
            this.dsBulkInfor.DeleteMethod = null;
            this.dsBulkInfor.InsertMethod = null;
            this.dsBulkInfor.L3DataAdapter = this.Adapter;
            this.dsBulkInfor.LoadEvent = "Click";
            this.dsBulkInfor.LoadTrigger = null;
            this.dsBulkInfor.RefreshValve = 1000;
            this.dsBulkInfor.SourceCommand = null;
            this.dsBulkInfor.SourceCondition = "";
            this.dsBulkInfor.SourceMethod = "";
            this.dsBulkInfor.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBulkInfor.SourceURI = "";
            this.dsBulkInfor.SubscribeTarget = "Version";
            this.dsBulkInfor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAllyInfor});
            this.dsBulkInfor.UpdateEvent = "Click";
            this.dsBulkInfor.UpdateMethod = null;
            this.dsBulkInfor.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsAllyInfor
            // 
            this.schemadsAllyInfor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInforL3DataTableRec_Time,
            this.coldsBulkInforL3DataTableGUID,
            this.coldsBulkInforL3DataTableName,
            this.coldsBulkInforL3DataTablevbillcode,
            this.coldsBulkInforL3DataTablecwarehouseid,
            this.coldsBulkInforL3DataTablecinventoryid,
            this.coldsBulkInforL3DataTableInvcode,
            this.coldsBulkInforL3DataTableInvname,
            this.coldsBulkInforL3DataTableInvspec,
            this.coldsBulkInforL3DataTableInvtype,
            this.coldsBulkInforL3DataTableDbilldate,
            this.coldsBulkInforL3DataTableninnum,
            this.coldsBulkInforL3DataTablenassistinnum,
            this.coldsBulkInforL3DataTablezdy1,
            this.coldsBulkInforL3DataTablezdy2,
            this.coldsBulkInforL3DataTablezdy3,
            this.coldsBulkInforL3DataTablezdy4,
            this.coldsBulkInforL3DataTablezdy5,
            this.coldsBulkInforL3DataTablezyx1,
            this.coldsBulkInforL3DataTablezyx2,
            this.coldsBulkInforL3DataTablezyx3,
            this.coldsBulkInforL3DataTablezyx4,
            this.coldsBulkInforL3DataTablezyx5,
            this.coldsBulkInforL3DataTablepk_corp,
            this.coldsBulkInforL3DataTablevproductbatchcode,
            this.coldsBulkInforL3DataTableBatch_ID});
            this.schemadsAllyInfor.TableName = "L3DataTable";
            // 
            // coldsBulkInforL3DataTableRec_Time
            // 
            this.coldsBulkInforL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsBulkInforL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsBulkInforL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsBulkInforL3DataTableRec_Time.Namespace = "";
            // 
            // coldsBulkInforL3DataTableGUID
            // 
            this.coldsBulkInforL3DataTableGUID.Caption = "GUID";
            this.coldsBulkInforL3DataTableGUID.ColumnName = "GUID";
            this.coldsBulkInforL3DataTableGUID.Namespace = "";
            // 
            // coldsBulkInforL3DataTableName
            // 
            this.coldsBulkInforL3DataTableName.Caption = "Name";
            this.coldsBulkInforL3DataTableName.ColumnName = "Name";
            this.coldsBulkInforL3DataTableName.Namespace = "";
            // 
            // coldsBulkInforL3DataTablevbillcode
            // 
            this.coldsBulkInforL3DataTablevbillcode.Caption = "vbillcode";
            this.coldsBulkInforL3DataTablevbillcode.ColumnName = "vbillcode";
            this.coldsBulkInforL3DataTablevbillcode.Namespace = "";
            // 
            // coldsBulkInforL3DataTablecwarehouseid
            // 
            this.coldsBulkInforL3DataTablecwarehouseid.Caption = "cwarehouseid";
            this.coldsBulkInforL3DataTablecwarehouseid.ColumnName = "cwarehouseid";
            this.coldsBulkInforL3DataTablecwarehouseid.Namespace = "";
            // 
            // coldsBulkInforL3DataTablecinventoryid
            // 
            this.coldsBulkInforL3DataTablecinventoryid.Caption = "cinventoryid";
            this.coldsBulkInforL3DataTablecinventoryid.ColumnName = "cinventoryid";
            this.coldsBulkInforL3DataTablecinventoryid.Namespace = "";
            // 
            // coldsBulkInforL3DataTableInvcode
            // 
            this.coldsBulkInforL3DataTableInvcode.Caption = "Invcode";
            this.coldsBulkInforL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsBulkInforL3DataTableInvcode.Namespace = "";
            // 
            // coldsBulkInforL3DataTableInvname
            // 
            this.coldsBulkInforL3DataTableInvname.Caption = "Invname";
            this.coldsBulkInforL3DataTableInvname.ColumnName = "Invname";
            this.coldsBulkInforL3DataTableInvname.Namespace = "";
            // 
            // coldsBulkInforL3DataTableInvspec
            // 
            this.coldsBulkInforL3DataTableInvspec.Caption = "Invspec";
            this.coldsBulkInforL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsBulkInforL3DataTableInvspec.Namespace = "";
            // 
            // coldsBulkInforL3DataTableInvtype
            // 
            this.coldsBulkInforL3DataTableInvtype.Caption = "Invtype";
            this.coldsBulkInforL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsBulkInforL3DataTableInvtype.Namespace = "";
            // 
            // coldsBulkInforL3DataTableDbilldate
            // 
            this.coldsBulkInforL3DataTableDbilldate.Caption = "Dbilldate";
            this.coldsBulkInforL3DataTableDbilldate.ColumnName = "Dbilldate";
            this.coldsBulkInforL3DataTableDbilldate.DataType = typeof(System.DateTime);
            this.coldsBulkInforL3DataTableDbilldate.Namespace = "";
            // 
            // coldsBulkInforL3DataTableninnum
            // 
            this.coldsBulkInforL3DataTableninnum.Caption = "ninnum";
            this.coldsBulkInforL3DataTableninnum.ColumnName = "ninnum";
            this.coldsBulkInforL3DataTableninnum.DataType = typeof(double);
            this.coldsBulkInforL3DataTableninnum.Namespace = "";
            // 
            // coldsBulkInforL3DataTablenassistinnum
            // 
            this.coldsBulkInforL3DataTablenassistinnum.Caption = "nassistinnum";
            this.coldsBulkInforL3DataTablenassistinnum.ColumnName = "nassistinnum";
            this.coldsBulkInforL3DataTablenassistinnum.DataType = typeof(int);
            this.coldsBulkInforL3DataTablenassistinnum.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezdy1
            // 
            this.coldsBulkInforL3DataTablezdy1.Caption = "zdy1";
            this.coldsBulkInforL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsBulkInforL3DataTablezdy1.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezdy2
            // 
            this.coldsBulkInforL3DataTablezdy2.Caption = "zdy2";
            this.coldsBulkInforL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsBulkInforL3DataTablezdy2.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezdy3
            // 
            this.coldsBulkInforL3DataTablezdy3.Caption = "zdy3";
            this.coldsBulkInforL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsBulkInforL3DataTablezdy3.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezdy4
            // 
            this.coldsBulkInforL3DataTablezdy4.Caption = "zdy4";
            this.coldsBulkInforL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsBulkInforL3DataTablezdy4.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezdy5
            // 
            this.coldsBulkInforL3DataTablezdy5.Caption = "zdy5";
            this.coldsBulkInforL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsBulkInforL3DataTablezdy5.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezyx1
            // 
            this.coldsBulkInforL3DataTablezyx1.Caption = "zyx1";
            this.coldsBulkInforL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsBulkInforL3DataTablezyx1.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezyx2
            // 
            this.coldsBulkInforL3DataTablezyx2.Caption = "zyx2";
            this.coldsBulkInforL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsBulkInforL3DataTablezyx2.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezyx3
            // 
            this.coldsBulkInforL3DataTablezyx3.Caption = "zyx3";
            this.coldsBulkInforL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsBulkInforL3DataTablezyx3.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezyx4
            // 
            this.coldsBulkInforL3DataTablezyx4.Caption = "zyx4";
            this.coldsBulkInforL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsBulkInforL3DataTablezyx4.Namespace = "";
            // 
            // coldsBulkInforL3DataTablezyx5
            // 
            this.coldsBulkInforL3DataTablezyx5.Caption = "zyx5";
            this.coldsBulkInforL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsBulkInforL3DataTablezyx5.Namespace = "";
            // 
            // coldsBulkInforL3DataTablepk_corp
            // 
            this.coldsBulkInforL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsBulkInforL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsBulkInforL3DataTablepk_corp.Namespace = "";
            // 
            // coldsBulkInforL3DataTablevproductbatchcode
            // 
            this.coldsBulkInforL3DataTablevproductbatchcode.Caption = "vproductbatchcode";
            this.coldsBulkInforL3DataTablevproductbatchcode.ColumnName = "vproductbatchcode";
            this.coldsBulkInforL3DataTablevproductbatchcode.Namespace = "";
            // 
            // cmdBulkInfor
            // 
            this.cmdBulkInfor.Adapter = this.Adapter;
            this.cmdBulkInfor.MergeReturnTarget = false;
            this.cmdBulkInfor.Method = "BulkDataAccept";
            this.cmdBulkInfor.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkInfor.Parameters.Add(this.l3CommandParameter2);
            this.cmdBulkInfor.ReturnTarget = null;
            this.cmdBulkInfor.ReturnTargetProperty = null;
            this.cmdBulkInfor.Trigger = null;
            this.cmdBulkInfor.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsBulkInfor;
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
            this.l3CommandParameter1.SourceObject = this.dsBulkInfor;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.hmiRootPanel2);
            this.hmiRootPanel1.Controls.Add(this.toolStrip1);
            this.hmiRootPanel1.Controls.Add(this.dvBulkInfor);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(929, 509);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.Controls.Add(this.dvBulkTrans);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(0, 289);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(929, 220);
            this.hmiRootPanel2.TabIndex = 32;
            // 
            // dvBulkTrans
            // 
            this.dvBulkTrans.AllowUserToAddRows = false;
            this.dvBulkTrans.AutoGenerateColumns = false;
            this.dvBulkTrans.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBulkTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBulkTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinventoryidDataGridViewTextBoxColumn1,
            this.invcodeDataGridViewTextBoxColumn1,
            this.invnameDataGridViewTextBoxColumn1,
            this.invspecDataGridViewTextBoxColumn1,
            this.invtypeDataGridViewTextBoxColumn1,
            this.dbilldateDataGridViewTextBoxColumn1,
            this.coutwarehouseidDataGridViewTextBoxColumn,
            this.cinwarehouseidDataGridViewTextBoxColumn,
            this.nnumDataGridViewTextBoxColumn,
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
            this.pkcorpDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dvBulkTrans.DataSource = this.bsBulkTrans;
            this.dvBulkTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBulkTrans.Location = new System.Drawing.Point(0, 0);
            this.dvBulkTrans.Name = "dvBulkTrans";
            this.dvBulkTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBulkTrans.RowTemplate.Height = 23;
            this.dvBulkTrans.Size = new System.Drawing.Size(929, 220);
            this.dvBulkTrans.TabIndex = 30;
            this.dvBulkTrans.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulkInfor_DataError);
            // 
            // cinventoryidDataGridViewTextBoxColumn1
            // 
            this.cinventoryidDataGridViewTextBoxColumn1.DataPropertyName = "cinventoryid";
            this.cinventoryidDataGridViewTextBoxColumn1.HeaderText = "入库物料";
            this.cinventoryidDataGridViewTextBoxColumn1.Name = "cinventoryidDataGridViewTextBoxColumn1";
            // 
            // invcodeDataGridViewTextBoxColumn1
            // 
            this.invcodeDataGridViewTextBoxColumn1.DataPropertyName = "Invcode";
            this.invcodeDataGridViewTextBoxColumn1.DataSource = this.bsBulkCode2;
            this.invcodeDataGridViewTextBoxColumn1.DisplayMember = "Code_Des";
            this.invcodeDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.invcodeDataGridViewTextBoxColumn1.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn1.Name = "invcodeDataGridViewTextBoxColumn1";
            this.invcodeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invcodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invcodeDataGridViewTextBoxColumn1.ValueMember = "Code";
            // 
            // bsBulkCode2
            // 
            this.bsBulkCode2.DataMember = "L3DataTable";
            this.bsBulkCode2.DataSource = this.dsBulkCode;
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoSubscribe = true;
            this.dsBulkCode.DataSetName = "L3DataSet";
            this.dsBulkCode.DeleteMethod = null;
            this.dsBulkCode.InsertMethod = null;
            this.dsBulkCode.L3DataAdapter = this.Adapter;
            this.dsBulkCode.LoadEvent = "Click";
            this.dsBulkCode.LoadTrigger = null;
            this.dsBulkCode.RefreshValve = 1000;
            this.dsBulkCode.SourceCommand = null;
            this.dsBulkCode.SourceCondition = "Code_Group = \'BULK_CODE\'";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkCode});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
            // 
            // schemadsBulkCode
            // 
            this.schemadsBulkCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkCodeL3DataTableCode,
            this.coldsBulkCodeL3DataTableCode_Des});
            this.schemadsBulkCode.TableName = "L3DataTable";
            // 
            // coldsBulkCodeL3DataTableCode
            // 
            this.coldsBulkCodeL3DataTableCode.Caption = "Code";
            this.coldsBulkCodeL3DataTableCode.ColumnName = "Code";
            this.coldsBulkCodeL3DataTableCode.Namespace = "";
            // 
            // coldsBulkCodeL3DataTableCode_Des
            // 
            this.coldsBulkCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.Namespace = "";
            // 
            // invnameDataGridViewTextBoxColumn1
            // 
            this.invnameDataGridViewTextBoxColumn1.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn1.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn1.Name = "invnameDataGridViewTextBoxColumn1";
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
            this.dbilldateDataGridViewTextBoxColumn1.HeaderText = "入库日期";
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
            // nnumDataGridViewTextBoxColumn
            // 
            this.nnumDataGridViewTextBoxColumn.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn.HeaderText = "转库数量";
            this.nnumDataGridViewTextBoxColumn.Name = "nnumDataGridViewTextBoxColumn";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vproductbatchcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // bsBulkTrans
            // 
            this.bsBulkTrans.DataMember = "L3DataTable";
            this.bsBulkTrans.DataSource = this.dsBulkTrans;
            // 
            // dsBulkTrans
            // 
            this.dsBulkTrans.AutoSubscribe = true;
            this.dsBulkTrans.DataSetName = "L3DataSet";
            this.dsBulkTrans.DeleteMethod = null;
            this.dsBulkTrans.InsertMethod = null;
            this.dsBulkTrans.L3DataAdapter = this.Adapter;
            this.dsBulkTrans.LoadEvent = "Click";
            this.dsBulkTrans.LoadTrigger = null;
            this.dsBulkTrans.RefreshValve = 1000;
            this.dsBulkTrans.SourceCommand = null;
            this.dsBulkTrans.SourceCondition = "";
            this.dsBulkTrans.SourceMethod = "";
            this.dsBulkTrans.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBulkTrans.SourceURI = "";
            this.dsBulkTrans.SubscribeTarget = "Version";
            this.dsBulkTrans.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkTrans});
            this.dsBulkTrans.UpdateEvent = "Click";
            this.dsBulkTrans.UpdateMethod = null;
            this.dsBulkTrans.UpdateTrigger = null;
            // 
            // schemadsBulkTrans
            // 
            this.schemadsBulkTrans.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkTransL3DataTableGUID,
            this.coldsBulkTransL3DataTableName,
            this.coldsBulkTransL3DataTableRec_Time,
            this.coldsBulkTransL3DataTablecinventoryid,
            this.coldsBulkTransL3DataTableInvcode,
            this.coldsBulkTransL3DataTableInvname,
            this.coldsBulkTransL3DataTableInvspec,
            this.coldsBulkTransL3DataTableInvtype,
            this.coldsBulkTransL3DataTableDbilldate,
            this.coldsBulkTransL3DataTablecoutwarehouseid,
            this.coldsBulkTransL3DataTablecinwarehouseid,
            this.coldsBulkTransL3DataTablennum,
            this.coldsBulkTransL3DataTablenassistnum,
            this.coldsBulkTransL3DataTablezdy1,
            this.coldsBulkTransL3DataTablezdy2,
            this.coldsBulkTransL3DataTablezdy3,
            this.coldsBulkTransL3DataTablezdy4,
            this.coldsBulkTransL3DataTablezdy5,
            this.coldsBulkTransL3DataTablezyx1,
            this.coldsBulkTransL3DataTablezyx2,
            this.coldsBulkTransL3DataTablezyx3,
            this.coldsBulkTransL3DataTablezyx4,
            this.coldsBulkTransL3DataTablezyx5,
            this.coldsBulkTransL3DataTablepk_corp,
            this.coldsBulkTransL3DataTablevproductbatchcode});
            this.schemadsBulkTrans.TableName = "L3DataTable";
            // 
            // coldsBulkTransL3DataTableGUID
            // 
            this.coldsBulkTransL3DataTableGUID.Caption = "GUID";
            this.coldsBulkTransL3DataTableGUID.ColumnName = "GUID";
            this.coldsBulkTransL3DataTableGUID.Namespace = "";
            // 
            // coldsBulkTransL3DataTableName
            // 
            this.coldsBulkTransL3DataTableName.Caption = "Name";
            this.coldsBulkTransL3DataTableName.ColumnName = "Name";
            this.coldsBulkTransL3DataTableName.Namespace = "";
            // 
            // coldsBulkTransL3DataTableRec_Time
            // 
            this.coldsBulkTransL3DataTableRec_Time.Caption = "Rec_Time";
            this.coldsBulkTransL3DataTableRec_Time.ColumnName = "Rec_Time";
            this.coldsBulkTransL3DataTableRec_Time.DataType = typeof(System.DateTime);
            this.coldsBulkTransL3DataTableRec_Time.Namespace = "";
            // 
            // coldsBulkTransL3DataTablecinventoryid
            // 
            this.coldsBulkTransL3DataTablecinventoryid.Caption = "cinventoryid";
            this.coldsBulkTransL3DataTablecinventoryid.ColumnName = "cinventoryid";
            this.coldsBulkTransL3DataTablecinventoryid.Namespace = "";
            // 
            // coldsBulkTransL3DataTableInvcode
            // 
            this.coldsBulkTransL3DataTableInvcode.Caption = "Invcode";
            this.coldsBulkTransL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsBulkTransL3DataTableInvcode.Namespace = "";
            // 
            // coldsBulkTransL3DataTableInvname
            // 
            this.coldsBulkTransL3DataTableInvname.Caption = "Invname";
            this.coldsBulkTransL3DataTableInvname.ColumnName = "Invname";
            this.coldsBulkTransL3DataTableInvname.Namespace = "";
            // 
            // coldsBulkTransL3DataTableInvspec
            // 
            this.coldsBulkTransL3DataTableInvspec.Caption = "Invspec";
            this.coldsBulkTransL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsBulkTransL3DataTableInvspec.Namespace = "";
            // 
            // coldsBulkTransL3DataTableInvtype
            // 
            this.coldsBulkTransL3DataTableInvtype.Caption = "Invtype";
            this.coldsBulkTransL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsBulkTransL3DataTableInvtype.Namespace = "";
            // 
            // coldsBulkTransL3DataTableDbilldate
            // 
            this.coldsBulkTransL3DataTableDbilldate.Caption = "Dbilldate";
            this.coldsBulkTransL3DataTableDbilldate.ColumnName = "Dbilldate";
            this.coldsBulkTransL3DataTableDbilldate.DataType = typeof(System.DateTime);
            this.coldsBulkTransL3DataTableDbilldate.Namespace = "";
            // 
            // coldsBulkTransL3DataTablecoutwarehouseid
            // 
            this.coldsBulkTransL3DataTablecoutwarehouseid.Caption = "coutwarehouseid";
            this.coldsBulkTransL3DataTablecoutwarehouseid.ColumnName = "coutwarehouseid";
            this.coldsBulkTransL3DataTablecoutwarehouseid.Namespace = "";
            // 
            // coldsBulkTransL3DataTablecinwarehouseid
            // 
            this.coldsBulkTransL3DataTablecinwarehouseid.Caption = "cinwarehouseid";
            this.coldsBulkTransL3DataTablecinwarehouseid.ColumnName = "cinwarehouseid";
            this.coldsBulkTransL3DataTablecinwarehouseid.Namespace = "";
            // 
            // coldsBulkTransL3DataTablennum
            // 
            this.coldsBulkTransL3DataTablennum.Caption = "nnum";
            this.coldsBulkTransL3DataTablennum.ColumnName = "nnum";
            this.coldsBulkTransL3DataTablennum.DataType = typeof(double);
            this.coldsBulkTransL3DataTablennum.Namespace = "";
            // 
            // coldsBulkTransL3DataTablenassistnum
            // 
            this.coldsBulkTransL3DataTablenassistnum.Caption = "nassistnum";
            this.coldsBulkTransL3DataTablenassistnum.ColumnName = "nassistnum";
            this.coldsBulkTransL3DataTablenassistnum.DataType = typeof(int);
            this.coldsBulkTransL3DataTablenassistnum.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezdy1
            // 
            this.coldsBulkTransL3DataTablezdy1.Caption = "zdy1";
            this.coldsBulkTransL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsBulkTransL3DataTablezdy1.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezdy2
            // 
            this.coldsBulkTransL3DataTablezdy2.Caption = "zdy2";
            this.coldsBulkTransL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsBulkTransL3DataTablezdy2.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezdy3
            // 
            this.coldsBulkTransL3DataTablezdy3.Caption = "zdy3";
            this.coldsBulkTransL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsBulkTransL3DataTablezdy3.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezdy4
            // 
            this.coldsBulkTransL3DataTablezdy4.Caption = "zdy4";
            this.coldsBulkTransL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsBulkTransL3DataTablezdy4.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezdy5
            // 
            this.coldsBulkTransL3DataTablezdy5.Caption = "zdy5";
            this.coldsBulkTransL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsBulkTransL3DataTablezdy5.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezyx1
            // 
            this.coldsBulkTransL3DataTablezyx1.Caption = "zyx1";
            this.coldsBulkTransL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsBulkTransL3DataTablezyx1.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezyx2
            // 
            this.coldsBulkTransL3DataTablezyx2.Caption = "zyx2";
            this.coldsBulkTransL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsBulkTransL3DataTablezyx2.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezyx3
            // 
            this.coldsBulkTransL3DataTablezyx3.Caption = "zyx3";
            this.coldsBulkTransL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsBulkTransL3DataTablezyx3.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezyx4
            // 
            this.coldsBulkTransL3DataTablezyx4.Caption = "zyx4";
            this.coldsBulkTransL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsBulkTransL3DataTablezyx4.Namespace = "";
            // 
            // coldsBulkTransL3DataTablezyx5
            // 
            this.coldsBulkTransL3DataTablezyx5.Caption = "zyx5";
            this.coldsBulkTransL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsBulkTransL3DataTablezyx5.Namespace = "";
            // 
            // coldsBulkTransL3DataTablepk_corp
            // 
            this.coldsBulkTransL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsBulkTransL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsBulkTransL3DataTablepk_corp.Namespace = "";
            // 
            // coldsBulkTransL3DataTablevproductbatchcode
            // 
            this.coldsBulkTransL3DataTablevproductbatchcode.Caption = "vproductbatchcode";
            this.coldsBulkTransL3DataTablevproductbatchcode.ColumnName = "vproductbatchcode";
            this.coldsBulkTransL3DataTablevproductbatchcode.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnTrans,
            this.toolStripSeparator5,
            this.btnTransAdd,
            this.btnTransDel,
            this.toolStripSeparator6,
            this.btnTransConfirm,
            this.btnTransCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 246);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(929, 43);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnTrans
            // 
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(143, 40);
            this.btnTrans.Text = "转库信息从EXL导入";
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
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
            // dvBulkInfor
            // 
            this.dvBulkInfor.AllowUserToAddRows = false;
            this.dvBulkInfor.AutoGenerateColumns = false;
            this.dvBulkInfor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBulkInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBulkInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vbillcodeDataGridViewTextBoxColumn,
            this.cwarehouseidDataGridViewTextBoxColumn,
            this.cinventoryidDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.invnameDataGridViewTextBoxColumn,
            this.ninnumDataGridViewTextBoxColumn,
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
            this.pkcorpDataGridViewTextBoxColumn,
            this.vproductbatchcode});
            this.dvBulkInfor.DataSource = this.bsBulkInfor;
            this.dvBulkInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvBulkInfor.Location = new System.Drawing.Point(0, 0);
            this.dvBulkInfor.Name = "dvBulkInfor";
            this.dvBulkInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBulkInfor.RowTemplate.Height = 23;
            this.dvBulkInfor.Size = new System.Drawing.Size(929, 246);
            this.dvBulkInfor.TabIndex = 30;
            this.dvBulkInfor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulkInfor_DataError);
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
            this.invcodeDataGridViewTextBoxColumn.DataSource = this.bsBulkCode1;
            this.invcodeDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.invcodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.invcodeDataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // bsBulkCode1
            // 
            this.bsBulkCode1.DataMember = "L3DataTable";
            this.bsBulkCode1.DataSource = this.dsBulkCode;
            // 
            // invnameDataGridViewTextBoxColumn
            // 
            this.invnameDataGridViewTextBoxColumn.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn.Name = "invnameDataGridViewTextBoxColumn";
            // 
            // ninnumDataGridViewTextBoxColumn
            // 
            this.ninnumDataGridViewTextBoxColumn.DataPropertyName = "ninnum";
            this.ninnumDataGridViewTextBoxColumn.HeaderText = "入库数量";
            this.ninnumDataGridViewTextBoxColumn.Name = "ninnumDataGridViewTextBoxColumn";
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
            // vproductbatchcode
            // 
            this.vproductbatchcode.DataPropertyName = "vproductbatchcode";
            this.vproductbatchcode.HeaderText = "批次号";
            this.vproductbatchcode.Name = "vproductbatchcode";
            // 
            // cmdBulkTrans
            // 
            this.cmdBulkTrans.Adapter = this.Adapter;
            this.cmdBulkTrans.MergeReturnTarget = false;
            this.cmdBulkTrans.Method = "BulkDataAccept";
            this.cmdBulkTrans.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkTrans.Parameters.Add(this.l3CommandParameter3);
            this.cmdBulkTrans.ReturnTarget = null;
            this.cmdBulkTrans.ReturnTargetProperty = null;
            this.cmdBulkTrans.Trigger = null;
            this.cmdBulkTrans.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsBulkTrans;
            this.l3CommandParameter3.SourceProperty = "L3DataTable";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
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
            this.dsError.SourceCondition = "OWNER = \'BulkChangeStore\'";
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
            this.coldsErrorL3DataTableERROR_CODE,
            this.coldsErrorL3DataTableERROR_DES});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableERROR_CODE
            // 
            this.coldsErrorL3DataTableERROR_CODE.Caption = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.ColumnName = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.Namespace = "";
            // 
            // coldsErrorL3DataTableERROR_DES
            // 
            this.coldsErrorL3DataTableERROR_DES.Caption = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.ColumnName = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.Namespace = "";
            // 
            // coldsBulkInforL3DataTableBatch_ID
            // 
            this.coldsBulkInforL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsBulkInforL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsBulkInforL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsBulkTransL3DataTableBatch_ID
            // 
            this.coldsBulkTransL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsBulkTransL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsBulkTransL3DataTableBatch_ID.Namespace = "";
            // 
            // BulkInformationInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 552);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.Name = "BulkInformationInputFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "散状料信息导入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkInformationInputFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAllyInfor)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkTrans)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBulkInfo;
        private AppSvrHMI.L3DataSet dsBulkInfor;
        private System.Windows.Forms.BindingSource bsBulkInfor;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsAllyInfor;
        private AppSvrHMI.L3Command cmdBulkInfor;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBulkInforL3DataTableRec_Time;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBulkInfor;
        private System.Data.DataColumn coldsBulkInforL3DataTableGUID;
        private System.Data.DataColumn coldsBulkInforL3DataTableName;
        private System.Data.DataColumn coldsBulkInforL3DataTablevbillcode;
        private System.Data.DataColumn coldsBulkInforL3DataTablecwarehouseid;
        private System.Data.DataColumn coldsBulkInforL3DataTablecinventoryid;
        private System.Data.DataColumn coldsBulkInforL3DataTableInvcode;
        private System.Data.DataColumn coldsBulkInforL3DataTableInvname;
        private System.Data.DataColumn coldsBulkInforL3DataTableInvspec;
        private System.Data.DataColumn coldsBulkInforL3DataTableInvtype;
        private System.Data.DataColumn coldsBulkInforL3DataTableDbilldate;
        private System.Data.DataColumn coldsBulkInforL3DataTableninnum;
        private System.Data.DataColumn coldsBulkInforL3DataTablenassistinnum;
        private System.Data.DataColumn coldsBulkInforL3DataTablezdy1;
        private System.Data.DataColumn coldsBulkInforL3DataTablezdy2;
        private System.Data.DataColumn coldsBulkInforL3DataTablezdy3;
        private System.Data.DataColumn coldsBulkInforL3DataTablezdy4;
        private System.Data.DataColumn coldsBulkInforL3DataTablezdy5;
        private System.Data.DataColumn coldsBulkInforL3DataTablezyx1;
        private System.Data.DataColumn coldsBulkInforL3DataTablezyx2;
        private System.Data.DataColumn coldsBulkInforL3DataTablezyx3;
        private System.Data.DataColumn coldsBulkInforL3DataTablezyx4;
        private System.Data.DataColumn coldsBulkInforL3DataTablezyx5;
        private System.Data.DataColumn coldsBulkInforL3DataTablepk_corp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTrans;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.DataGridView dvBulkTrans;
        private System.Windows.Forms.BindingSource bsBulkTrans;
        private AppSvrHMI.L3DataSet dsBulkTrans;
        private System.Data.DataTable schemadsBulkTrans;
        private System.Data.DataColumn coldsBulkTransL3DataTableGUID;
        private System.Data.DataColumn coldsBulkTransL3DataTableName;
        private System.Data.DataColumn coldsBulkTransL3DataTableRec_Time;
        private System.Data.DataColumn coldsBulkTransL3DataTablecinventoryid;
        private System.Data.DataColumn coldsBulkTransL3DataTableInvcode;
        private System.Data.DataColumn coldsBulkTransL3DataTableInvname;
        private System.Data.DataColumn coldsBulkTransL3DataTableInvspec;
        private System.Data.DataColumn coldsBulkTransL3DataTableInvtype;
        private System.Data.DataColumn coldsBulkTransL3DataTableDbilldate;
        private System.Data.DataColumn coldsBulkTransL3DataTablecoutwarehouseid;
        private System.Data.DataColumn coldsBulkTransL3DataTablecinwarehouseid;
        private System.Data.DataColumn coldsBulkTransL3DataTablennum;
        private System.Data.DataColumn coldsBulkTransL3DataTablenassistnum;
        private System.Data.DataColumn coldsBulkTransL3DataTablezdy1;
        private System.Data.DataColumn coldsBulkTransL3DataTablezdy2;
        private System.Data.DataColumn coldsBulkTransL3DataTablezdy3;
        private System.Data.DataColumn coldsBulkTransL3DataTablezdy4;
        private System.Data.DataColumn coldsBulkTransL3DataTablezdy5;
        private System.Data.DataColumn coldsBulkTransL3DataTablezyx1;
        private System.Data.DataColumn coldsBulkTransL3DataTablezyx2;
        private System.Data.DataColumn coldsBulkTransL3DataTablezyx3;
        private System.Data.DataColumn coldsBulkTransL3DataTablezyx4;
        private System.Data.DataColumn coldsBulkTransL3DataTablezyx5;
        private System.Data.DataColumn coldsBulkTransL3DataTablepk_corp;
        private AppSvrHMI.L3Command cmdBulkTrans;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnTransAdd;
        private System.Windows.Forms.ToolStripButton btnTransDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnTransConfirm;
        private System.Windows.Forms.ToolStripButton btnTransCancel;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsBulkCode1;
        private System.Windows.Forms.BindingSource bsBulkCode2;
        private System.Data.DataColumn coldsBulkInforL3DataTablevproductbatchcode;
        private System.Data.DataColumn coldsBulkTransL3DataTablevproductbatchcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinventoryidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn invcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invspecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbilldateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbillcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinventoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninnumDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn vproductbatchcode;
        private System.Data.DataColumn coldsBulkInforL3DataTableBatch_ID;
        private System.Data.DataColumn coldsBulkTransL3DataTableBatch_ID;
    }
}