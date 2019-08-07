namespace StoreMag.BloomStore
{
    partial class BloomStoreMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomStoreMagFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnInStore = new System.Windows.Forms.ToolStripButton();
            this.btnQualityCheck = new System.Windows.Forms.ToolStripButton();
            this.bsCaster05 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBloom = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemal3DataSet23 = new System.Data.DataTable();
            this.coll3DataSet23L3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableAMOUNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableMATERIALID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCASTERID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableSTOREAREAID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableSTD = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coll3DataSet23L3DataTableREASON = new System.Data.DataColumn();
            this.coldsBloomL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bsCaster04 = new System.Windows.Forms.BindingSource(this.components);
            this.bsCaster03 = new System.Windows.Forms.BindingSource(this.components);
            this.bsCaster02 = new System.Windows.Forms.BindingSource(this.components);
            this.bsCaster01 = new System.Windows.Forms.BindingSource(this.components);
            this.coldsBloomL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsBloomL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsBloomL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsBloomSendL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsBloomSendL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsBloomSendL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dvCaster07 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCaster07 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dvCaster05 = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOffLineReason = new System.Windows.Forms.ComboBox();
            this.bsInfo = new System.Windows.Forms.BindingSource(this.components);
            this.bsOffLineReason = new System.Windows.Forms.BindingSource(this.components);
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTablecode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTablecode_des = new System.Data.DataColumn();
            this.cmbWrongReason3 = new System.Windows.Forms.ComboBox();
            this.bsWrongReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWrongReason = new AppSvrHMI.L3DataSet();
            this.schemadsWrongReason = new System.Data.DataTable();
            this.coldsWrongReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWrongReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.dbxBloomOffLineEvent = new AppSvrHMI.L3DataBox();
            this.cmbWrongReason2 = new System.Windows.Forms.ComboBox();
            this.bsWrongReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.myLine2 = new buttonHide.MyLine();
            this.myLine1 = new buttonHide.MyLine();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lbWrongReason3 = new System.Windows.Forms.Label();
            this.lbWrongReason2 = new System.Windows.Forms.Label();
            this.lbWrongReason1 = new System.Windows.Forms.Label();
            this.lbWasterReason3 = new System.Windows.Forms.Label();
            this.lbWasterReason2 = new System.Windows.Forms.Label();
            this.lbWasterReason1 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.lbOffLineReason = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWrongReason1 = new System.Windows.Forms.ComboBox();
            this.bsWrongReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cmbWasterReason3 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsReason = new System.Data.DataTable();
            this.coldsReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmbWasterReason2 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbWasterReason1 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dvCaster04 = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvCaster03 = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvCaster02 = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvCaster06 = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemadsBloom = new System.Data.DataTable();
            this.coldsBloomL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBloomL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBloomL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBloomL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsBloomL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsBloomL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsBloomL3DataTableSTOREAREAID = new System.Data.DataColumn();
            this.coldsBloomL3DataTableSTD = new System.Data.DataColumn();
            this.coldsBloomL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.dsBloomSend = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet110 = new System.Data.DataTable();
            this.coll3DataSet110L3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableAMOUNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableMATERIALID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCASTERID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableSTOREAREAID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableSTD = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coll3DataSet110L3DataTableREASON = new System.Data.DataColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCaster06 = new System.Windows.Forms.BindingSource(this.components);
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster01)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster04)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster03)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster02)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster06)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnInStore,
            this.btnQualityCheck});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1178, 43);
            this.tSp1.TabIndex = 28;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInStore
            // 
            this.Adapter.SetAccessRight(this.btnInStore, "BloomStorebtnInStore");
            this.btnInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnInStore.Image")));
            this.btnInStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(68, 40);
            this.btnInStore.Text = "入库";
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // btnQualityCheck
            // 
            this.btnQualityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnQualityCheck.Image")));
            this.btnQualityCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQualityCheck.Name = "btnQualityCheck";
            this.btnQualityCheck.Size = new System.Drawing.Size(116, 40);
            this.btnQualityCheck.Text = "在库钢坯管理";
            this.btnQualityCheck.Click += new System.EventHandler(this.btnQualityCheck_Click);
            // 
            // bsCaster05
            // 
            this.bsCaster05.DataMember = "L3DataTable";
            this.bsCaster05.DataSource = this.dsBloom;
            this.bsCaster05.Filter = "CASTERID = \'S65\'";
            // 
            // dsBloom
            // 
            this.dsBloom.AutoLoad = true;
            this.dsBloom.AutoSubscribe = true;
            this.dsBloom.DataSetName = "L3DataSet";
            this.dsBloom.DeleteMethod = "";
            this.dsBloom.InsertMethod = "";
            this.dsBloom.L3DataAdapter = this.Adapter;
            this.dsBloom.LoadEvent = "Click";
            this.dsBloom.LoadTrigger = null;
            this.dsBloom.RefreshValve = 1000;
            this.dsBloom.SourceCommand = null;
            this.dsBloom.SourceCondition = null;
            this.dsBloom.SourceMethod = "GetMaterialOnInputCache";
            this.dsBloom.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsBloom.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.dsBloom.SubscribeTarget = null;
            this.dsBloom.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet23});
            this.dsBloom.UpdateEvent = "Click";
            this.dsBloom.UpdateMethod = "";
            this.dsBloom.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemal3DataSet23
            // 
            this.schemal3DataSet23.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet23L3DataTableMATERIALTYPE,
            this.coll3DataSet23L3DataTableAMOUNT,
            this.coll3DataSet23L3DataTableMATERIALID,
            this.coll3DataSet23L3DataTableCUR_PILE_ID,
            this.coll3DataSet23L3DataTableCUR_LAYER_ID,
            this.coll3DataSet23L3DataTableCASTERID,
            this.coll3DataSet23L3DataTableSTOREAREAID,
            this.coll3DataSet23L3DataTableSTD,
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX,
            this.coll3DataSet23L3DataTableWASTER_COUNT,
            this.coll3DataSet23L3DataTableWRONG_COUNT,
            this.coll3DataSet23L3DataTableRIGHT_COUNT,
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX,
            this.coll3DataSet23L3DataTableCASTING_NO,
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT,
            this.coll3DataSet23L3DataTablePROCESS_TYPE,
            this.coll3DataSet23L3DataTablePLAN_ORD_ID,
            this.coll3DataSet23L3DataTableBLOOM_COUNT,
            this.coll3DataSet23L3DataTableCAL_WEIGHT,
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT,
            this.coll3DataSet23L3DataTableWASTER_WEIGHT,
            this.coll3DataSet23L3DataTableWASTER_COUNT1,
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1,
            this.coll3DataSet23L3DataTableWASTER_REASON1,
            this.coll3DataSet23L3DataTableWASTER_COUNT2,
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2,
            this.coll3DataSet23L3DataTableWASTER_REASON2,
            this.coll3DataSet23L3DataTableWASTER_COUNT3,
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3,
            this.coll3DataSet23L3DataTableWASTER_REASON3,
            this.coll3DataSet23L3DataTableWRONG_WEIGHT,
            this.coll3DataSet23L3DataTableWRONG_COUNT1,
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1,
            this.coll3DataSet23L3DataTableWRONG_REASON1,
            this.coll3DataSet23L3DataTableWRONG_COUNT2,
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2,
            this.coll3DataSet23L3DataTableWRONG_REASON2,
            this.coll3DataSet23L3DataTableWRONG_COUNT3,
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3,
            this.coll3DataSet23L3DataTableWRONG_REASON3,
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES,
            this.coll3DataSet23L3DataTableREASON,
            this.coldsBloomL3DataTableCheckFlag});
            this.schemal3DataSet23.TableName = "L3DataTable";
            // 
            // coll3DataSet23L3DataTableMATERIALTYPE
            // 
            this.coll3DataSet23L3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coll3DataSet23L3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coll3DataSet23L3DataTableMATERIALTYPE.DefaultValue = "";
            this.coll3DataSet23L3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coll3DataSet23L3DataTableAMOUNT
            // 
            this.coll3DataSet23L3DataTableAMOUNT.Caption = "AMOUNT";
            this.coll3DataSet23L3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coll3DataSet23L3DataTableAMOUNT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableAMOUNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableMATERIALID
            // 
            this.coll3DataSet23L3DataTableMATERIALID.Caption = "MATERIALID";
            this.coll3DataSet23L3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coll3DataSet23L3DataTableMATERIALID.DefaultValue = "";
            this.coll3DataSet23L3DataTableMATERIALID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCUR_PILE_ID
            // 
            this.coll3DataSet23L3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coll3DataSet23L3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coll3DataSet23L3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coll3DataSet23L3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCUR_LAYER_ID
            // 
            this.coll3DataSet23L3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coll3DataSet23L3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coll3DataSet23L3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCASTERID
            // 
            this.coll3DataSet23L3DataTableCASTERID.Caption = "CASTERID";
            this.coll3DataSet23L3DataTableCASTERID.ColumnName = "CASTERID";
            this.coll3DataSet23L3DataTableCASTERID.DefaultValue = "";
            this.coll3DataSet23L3DataTableCASTERID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableSTOREAREAID
            // 
            this.coll3DataSet23L3DataTableSTOREAREAID.Caption = "STOREAREAID";
            this.coll3DataSet23L3DataTableSTOREAREAID.ColumnName = "STOREAREAID";
            this.coll3DataSet23L3DataTableSTOREAREAID.DefaultValue = "";
            this.coll3DataSet23L3DataTableSTOREAREAID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableSTD
            // 
            this.coll3DataSet23L3DataTableSTD.Caption = "STD";
            this.coll3DataSet23L3DataTableSTD.ColumnName = "STD";
            this.coll3DataSet23L3DataTableSTD.DefaultValue = "";
            this.coll3DataSet23L3DataTableSTD.Namespace = "";
            // 
            // coll3DataSet23L3DataTableSTEELGRADEINDEX
            // 
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coll3DataSet23L3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_COUNT
            // 
            this.coll3DataSet23L3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coll3DataSet23L3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coll3DataSet23L3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_COUNT
            // 
            this.coll3DataSet23L3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coll3DataSet23L3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coll3DataSet23L3DataTableWRONG_COUNT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableRIGHT_COUNT
            // 
            this.coll3DataSet23L3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coll3DataSet23L3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coll3DataSet23L3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coll3DataSet23L3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coll3DataSet23L3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTablePRE_STEELGRADEINDEX
            // 
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coll3DataSet23L3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCASTING_NO
            // 
            this.coll3DataSet23L3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coll3DataSet23L3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coll3DataSet23L3DataTableCASTING_NO.DefaultValue = "";
            this.coll3DataSet23L3DataTableCASTING_NO.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCASTING_HEAT_CNT
            // 
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coll3DataSet23L3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTablePROCESS_TYPE
            // 
            this.coll3DataSet23L3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coll3DataSet23L3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coll3DataSet23L3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coll3DataSet23L3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coll3DataSet23L3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coll3DataSet23L3DataTablePLAN_ORD_ID
            // 
            this.coll3DataSet23L3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coll3DataSet23L3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coll3DataSet23L3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coll3DataSet23L3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coll3DataSet23L3DataTableBLOOM_COUNT
            // 
            this.coll3DataSet23L3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coll3DataSet23L3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coll3DataSet23L3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coll3DataSet23L3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coll3DataSet23L3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableCAL_WEIGHT
            // 
            this.coll3DataSet23L3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coll3DataSet23L3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coll3DataSet23L3DataTableCAL_WEIGHT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableRIGHT_WEIGHT
            // 
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_WEIGHT
            // 
            this.coll3DataSet23L3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_COUNT1
            // 
            this.coll3DataSet23L3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coll3DataSet23L3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coll3DataSet23L3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_WEIGHT1
            // 
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_REASON1
            // 
            this.coll3DataSet23L3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coll3DataSet23L3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coll3DataSet23L3DataTableWASTER_REASON1.DefaultValue = "";
            this.coll3DataSet23L3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_COUNT2
            // 
            this.coll3DataSet23L3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coll3DataSet23L3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coll3DataSet23L3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_WEIGHT2
            // 
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_REASON2
            // 
            this.coll3DataSet23L3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coll3DataSet23L3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coll3DataSet23L3DataTableWASTER_REASON2.DefaultValue = "";
            this.coll3DataSet23L3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_COUNT3
            // 
            this.coll3DataSet23L3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coll3DataSet23L3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coll3DataSet23L3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_WEIGHT3
            // 
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWASTER_REASON3
            // 
            this.coll3DataSet23L3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coll3DataSet23L3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coll3DataSet23L3DataTableWASTER_REASON3.DefaultValue = "";
            this.coll3DataSet23L3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_WEIGHT
            // 
            this.coll3DataSet23L3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_COUNT1
            // 
            this.coll3DataSet23L3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coll3DataSet23L3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coll3DataSet23L3DataTableWRONG_COUNT1.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_WEIGHT1
            // 
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_REASON1
            // 
            this.coll3DataSet23L3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coll3DataSet23L3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coll3DataSet23L3DataTableWRONG_REASON1.DefaultValue = "";
            this.coll3DataSet23L3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_COUNT2
            // 
            this.coll3DataSet23L3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coll3DataSet23L3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coll3DataSet23L3DataTableWRONG_COUNT2.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_WEIGHT2
            // 
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_REASON2
            // 
            this.coll3DataSet23L3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coll3DataSet23L3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coll3DataSet23L3DataTableWRONG_REASON2.DefaultValue = "";
            this.coll3DataSet23L3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_COUNT3
            // 
            this.coll3DataSet23L3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coll3DataSet23L3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coll3DataSet23L3DataTableWRONG_COUNT3.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_WEIGHT3
            // 
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3.DefaultValue = "0";
            this.coll3DataSet23L3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableWRONG_REASON3
            // 
            this.coll3DataSet23L3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coll3DataSet23L3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coll3DataSet23L3DataTableWRONG_REASON3.DefaultValue = "";
            this.coll3DataSet23L3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coll3DataSet23L3DataTableSUFACEDEFACTDES
            // 
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coll3DataSet23L3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coll3DataSet23L3DataTableREASON
            // 
            this.coll3DataSet23L3DataTableREASON.Caption = "REASON";
            this.coll3DataSet23L3DataTableREASON.ColumnName = "REASON";
            this.coll3DataSet23L3DataTableREASON.DefaultValue = "";
            this.coll3DataSet23L3DataTableREASON.Namespace = "";
            // 
            // coldsBloomL3DataTableCheckFlag
            // 
            this.coldsBloomL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsBloomL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsBloomL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsBloomL3DataTableCheckFlag.Namespace = "";
            // 
            // bsCaster04
            // 
            this.bsCaster04.DataMember = "L3DataTable";
            this.bsCaster04.DataSource = this.dsBloom;
            this.bsCaster04.Filter = "CASTERID = \'S64\'";
            // 
            // bsCaster03
            // 
            this.bsCaster03.DataMember = "L3DataTable";
            this.bsCaster03.DataSource = this.dsBloom;
            this.bsCaster03.Filter = "CASTERID = \'S63\'";
            // 
            // bsCaster02
            // 
            this.bsCaster02.DataMember = "L3DataTable";
            this.bsCaster02.DataSource = this.dsBloom;
            this.bsCaster02.Filter = "CASTERID = \'S62\'";
            // 
            // bsCaster01
            // 
            this.bsCaster01.DataMember = "L3DataTable";
            this.bsCaster01.DataSource = this.dsBloom;
            this.bsCaster01.Filter = "CASTERID = \'S61\'";
            // 
            // coldsBloomL3DataTableWaster_Count
            // 
            this.coldsBloomL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsBloomL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsBloomL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsBloomL3DataTableWrong_Count
            // 
            this.coldsBloomL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsBloomL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsBloomL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsBloomL3DataTableRight_Count
            // 
            this.coldsBloomL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsBloomL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsBloomL3DataTableRight_Count.Namespace = "";
            // 
            // coldsBloomSendL3DataTableWASTER_COUNT
            // 
            this.coldsBloomSendL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsBloomSendL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsBloomSendL3DataTableWASTER_COUNT.DefaultValue = "0";
            this.coldsBloomSendL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsBloomSendL3DataTableWRONG_COUNT
            // 
            this.coldsBloomSendL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsBloomSendL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsBloomSendL3DataTableWRONG_COUNT.DefaultValue = "0";
            this.coldsBloomSendL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsBloomSendL3DataTableRIGHT_COUNT
            // 
            this.coldsBloomSendL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsBloomSendL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsBloomSendL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsBloomSendL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsBloomSendL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.panel1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1178, 745);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.cmbOffLineReason);
            this.panel1.Controls.Add(this.cmbWrongReason3);
            this.panel1.Controls.Add(this.dbxBloomOffLineEvent);
            this.panel1.Controls.Add(this.cmbWrongReason2);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.cmbWrongReason1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.cmbWasterReason3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.cmbWasterReason2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.cmbWasterReason1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 745);
            this.panel1.TabIndex = 30;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dvCaster07);
            this.groupBox7.Location = new System.Drawing.Point(653, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(381, 141);
            this.groupBox7.TabIndex = 103;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "7#铸机";
            // 
            // dvCaster07
            // 
            this.dvCaster07.AllowUserToAddRows = false;
            this.dvCaster07.AutoGenerateColumns = false;
            this.dvCaster07.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster07.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster07.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dvCaster07.DataSource = this.bsCaster07;
            this.dvCaster07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster07.Location = new System.Drawing.Point(3, 17);
            this.dvCaster07.Name = "dvCaster07";
            this.dvCaster07.RowHeadersVisible = false;
            this.dvCaster07.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster07.RowTemplate.Height = 23;
            this.dvCaster07.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster07.Size = new System.Drawing.Size(375, 121);
            this.dvCaster07.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CheckFlag";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "选择";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MATERIALID";
            this.dataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STD";
            this.dataGridViewTextBoxColumn2.HeaderText = "规格";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STEELGRADEINDEX";
            this.dataGridViewTextBoxColumn3.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bsCaster07
            // 
            this.bsCaster07.DataMember = "L3DataTable";
            this.bsCaster07.DataSource = this.dsBloom;
            this.bsCaster07.Filter = "CASTERID = \'S67\'";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(528, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(119, 147);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 102;
            this.pictureBox7.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dvCaster05);
            this.groupBox5.Location = new System.Drawing.Point(135, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 149);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5#铸机";
            // 
            // dvCaster05
            // 
            this.dvCaster05.AllowUserToAddRows = false;
            this.dvCaster05.AutoGenerateColumns = false;
            this.dvCaster05.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster05.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster05.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn3,
            this.mATERIALIDDataGridViewTextBoxColumn4,
            this.sTDDataGridViewTextBoxColumn4,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn4});
            this.dvCaster05.DataSource = this.bsCaster05;
            this.dvCaster05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster05.Location = new System.Drawing.Point(3, 17);
            this.dvCaster05.Name = "dvCaster05";
            this.dvCaster05.RowHeadersVisible = false;
            this.dvCaster05.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster05.RowTemplate.Height = 23;
            this.dvCaster05.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster05.Size = new System.Drawing.Size(378, 129);
            this.dvCaster05.TabIndex = 0;
            this.dvCaster05.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCaster_CellClick);
            // 
            // checkFlagDataGridViewTextBoxColumn3
            // 
            this.checkFlagDataGridViewTextBoxColumn3.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn3.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn3.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn3.Name = "checkFlagDataGridViewTextBoxColumn3";
            this.checkFlagDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn3.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn3.Width = 60;
            // 
            // mATERIALIDDataGridViewTextBoxColumn4
            // 
            this.mATERIALIDDataGridViewTextBoxColumn4.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn4.Name = "mATERIALIDDataGridViewTextBoxColumn4";
            // 
            // sTDDataGridViewTextBoxColumn4
            // 
            this.sTDDataGridViewTextBoxColumn4.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn4.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn4.Name = "sTDDataGridViewTextBoxColumn4";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn4
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn4.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn4.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn4.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn4";
            // 
            // cmbOffLineReason
            // 
            this.cmbOffLineReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "REASON", true));
            this.cmbOffLineReason.DataSource = this.bsOffLineReason;
            this.cmbOffLineReason.DisplayMember = "Code_Des";
            this.cmbOffLineReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbOffLineReason.Enabled = false;
            this.cmbOffLineReason.FormattingEnabled = true;
            this.cmbOffLineReason.Location = new System.Drawing.Point(1113, 139);
            this.cmbOffLineReason.Name = "cmbOffLineReason";
            this.cmbOffLineReason.Size = new System.Drawing.Size(22, 20);
            this.cmbOffLineReason.TabIndex = 100;
            this.cmbOffLineReason.ValueMember = "Code";
            this.cmbOffLineReason.Visible = false;
            this.cmbOffLineReason.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsInfo
            // 
            this.bsInfo.DataMember = "L3DataTable";
            this.bsInfo.DataSource = this.dsBloom;
            this.bsInfo.Filter = "";
            // 
            // bsOffLineReason
            // 
            this.bsOffLineReason.DataMember = "L3DataTable";
            this.bsOffLineReason.DataSource = this.dsOffLineReason;
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoLoad = true;
            this.dsOffLineReason.AutoSubscribe = true;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = null;
            this.dsOffLineReason.InsertMethod = null;
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "Click";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "CODE_GROUP = \'OFFLINE_REASON_CODE\'";
            this.dsOffLineReason.SourceMethod = "";
            this.dsOffLineReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOffLineReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOffLineReason.SubscribeTarget = null;
            this.dsOffLineReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOffLineReason});
            this.dsOffLineReason.UpdateEvent = "Click";
            this.dsOffLineReason.UpdateMethod = null;
            this.dsOffLineReason.UpdateTrigger = null;
            // 
            // schemadsOffLineReason
            // 
            this.schemadsOffLineReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOffLineReasonL3DataTablecode,
            this.coldsOffLineReasonL3DataTablecode_des});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTablecode
            // 
            this.coldsOffLineReasonL3DataTablecode.Caption = "code";
            this.coldsOffLineReasonL3DataTablecode.ColumnName = "code";
            this.coldsOffLineReasonL3DataTablecode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTablecode_des
            // 
            this.coldsOffLineReasonL3DataTablecode_des.Caption = "code_des";
            this.coldsOffLineReasonL3DataTablecode_des.ColumnName = "code_des";
            this.coldsOffLineReasonL3DataTablecode_des.Namespace = "";
            // 
            // cmbWrongReason3
            // 
            this.cmbWrongReason3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WRONG_REASON3", true));
            this.cmbWrongReason3.DataSource = this.bsWrongReason3;
            this.cmbWrongReason3.DisplayMember = "Code_Des";
            this.cmbWrongReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason3.Enabled = false;
            this.cmbWrongReason3.FormattingEnabled = true;
            this.cmbWrongReason3.Location = new System.Drawing.Point(1141, 139);
            this.cmbWrongReason3.Name = "cmbWrongReason3";
            this.cmbWrongReason3.Size = new System.Drawing.Size(22, 20);
            this.cmbWrongReason3.TabIndex = 99;
            this.cmbWrongReason3.ValueMember = "Code";
            this.cmbWrongReason3.Visible = false;
            this.cmbWrongReason3.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWrongReason3
            // 
            this.bsWrongReason3.DataMember = "L3DataTable";
            this.bsWrongReason3.DataSource = this.dsWrongReason;
            // 
            // dsWrongReason
            // 
            this.dsWrongReason.AutoLoad = true;
            this.dsWrongReason.AutoSubscribe = true;
            this.dsWrongReason.DataSetName = "L3DataSet";
            this.dsWrongReason.DeleteMethod = null;
            this.dsWrongReason.InsertMethod = null;
            this.dsWrongReason.L3DataAdapter = this.Adapter;
            this.dsWrongReason.LoadEvent = "Click";
            this.dsWrongReason.LoadTrigger = null;
            this.dsWrongReason.RefreshValve = 1000;
            this.dsWrongReason.SourceCommand = null;
            this.dsWrongReason.SourceCondition = "CODE_GROUP = \'WRONG_REASON_CODE\'";
            this.dsWrongReason.SourceMethod = "";
            this.dsWrongReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWrongReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWrongReason.SubscribeTarget = null;
            this.dsWrongReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWrongReason});
            this.dsWrongReason.UpdateEvent = "Click";
            this.dsWrongReason.UpdateMethod = null;
            this.dsWrongReason.UpdateTrigger = null;
            // 
            // schemadsWrongReason
            // 
            this.schemadsWrongReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWrongReasonL3DataTableCode,
            this.coldsWrongReasonL3DataTableCode_Des});
            this.schemadsWrongReason.TableName = "L3DataTable";
            // 
            // coldsWrongReasonL3DataTableCode
            // 
            this.coldsWrongReasonL3DataTableCode.Caption = "Code";
            this.coldsWrongReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWrongReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWrongReasonL3DataTableCode_Des
            // 
            this.coldsWrongReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.Namespace = "";
            // 
            // dbxBloomOffLineEvent
            // 
            this.dbxBloomOffLineEvent.DataFormat = null;
            this.dbxBloomOffLineEvent.DataObject = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.dbxBloomOffLineEvent.DataProperty = "BloomOffLineEvent";
            this.dbxBloomOffLineEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxBloomOffLineEvent.L3DataAdapter = this.Adapter;
            this.dbxBloomOffLineEvent.Location = new System.Drawing.Point(1066, 188);
            this.dbxBloomOffLineEvent.Name = "dbxBloomOffLineEvent";
            this.dbxBloomOffLineEvent.Size = new System.Drawing.Size(100, 21);
            this.dbxBloomOffLineEvent.TabIndex = 98;
            this.dbxBloomOffLineEvent.Value = null;
            this.dbxBloomOffLineEvent.Visible = false;
            this.dbxBloomOffLineEvent.TextChanged += new System.EventHandler(this.dbxBloomOffLineEvent_TextChanged);
            // 
            // cmbWrongReason2
            // 
            this.cmbWrongReason2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WRONG_REASON2", true));
            this.cmbWrongReason2.DataSource = this.bsWrongReason2;
            this.cmbWrongReason2.DisplayMember = "Code_Des";
            this.cmbWrongReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason2.Enabled = false;
            this.cmbWrongReason2.FormattingEnabled = true;
            this.cmbWrongReason2.Location = new System.Drawing.Point(1141, 116);
            this.cmbWrongReason2.Name = "cmbWrongReason2";
            this.cmbWrongReason2.Size = new System.Drawing.Size(22, 20);
            this.cmbWrongReason2.TabIndex = 99;
            this.cmbWrongReason2.ValueMember = "Code";
            this.cmbWrongReason2.Visible = false;
            this.cmbWrongReason2.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWrongReason2
            // 
            this.bsWrongReason2.DataMember = "L3DataTable";
            this.bsWrongReason2.DataSource = this.dsWrongReason;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.myLine2);
            this.groupBox6.Controls.Add(this.myLine1);
            this.groupBox6.Controls.Add(this.label58);
            this.groupBox6.Controls.Add(this.label55);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.lbWrongReason3);
            this.groupBox6.Controls.Add(this.lbWrongReason2);
            this.groupBox6.Controls.Add(this.lbWrongReason1);
            this.groupBox6.Controls.Add(this.lbWasterReason3);
            this.groupBox6.Controls.Add(this.lbWasterReason2);
            this.groupBox6.Controls.Add(this.lbWasterReason1);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label60);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.label61);
            this.groupBox6.Controls.Add(this.label63);
            this.groupBox6.Controls.Add(this.label62);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.lbOffLineReason);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(538, 338);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(495, 298);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "钢坯详细信息";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // myLine2
            // 
            this.myLine2.BackColor = System.Drawing.SystemColors.Control;
            this.myLine2.Location = new System.Drawing.Point(12, 149);
            this.myLine2.Name = "myLine2";
            this.myLine2.Size = new System.Drawing.Size(389, 3);
            this.myLine2.TabIndex = 101;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(15, 57);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(389, 3);
            this.myLine1.TabIndex = 100;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "SUFACEDEFACTDES", true));
            this.label58.Location = new System.Drawing.Point(86, 40);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(47, 12);
            this.label58.TabIndex = 6;
            this.label58.Text = "label36";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_WEIGHT3", true));
            this.label55.Location = new System.Drawing.Point(242, 270);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(47, 12);
            this.label55.TabIndex = 6;
            this.label55.Text = "label36";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_WEIGHT2", true));
            this.label52.Location = new System.Drawing.Point(242, 247);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(47, 12);
            this.label52.TabIndex = 6;
            this.label52.Text = "label36";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_WEIGHT1", true));
            this.label49.Location = new System.Drawing.Point(242, 224);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(47, 12);
            this.label49.TabIndex = 6;
            this.label49.Text = "label36";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_WEIGHT3", true));
            this.label46.Location = new System.Drawing.Point(242, 201);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(47, 12);
            this.label46.TabIndex = 6;
            this.label46.Text = "label36";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_WEIGHT2", true));
            this.label43.Location = new System.Drawing.Point(242, 178);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 12);
            this.label43.TabIndex = 6;
            this.label43.Text = "label36";
            // 
            // lbWrongReason3
            // 
            this.lbWrongReason3.AutoSize = true;
            this.lbWrongReason3.Location = new System.Drawing.Point(398, 270);
            this.lbWrongReason3.Name = "lbWrongReason3";
            this.lbWrongReason3.Size = new System.Drawing.Size(47, 12);
            this.lbWrongReason3.TabIndex = 6;
            this.lbWrongReason3.Text = "label36";
            // 
            // lbWrongReason2
            // 
            this.lbWrongReason2.AutoSize = true;
            this.lbWrongReason2.Location = new System.Drawing.Point(398, 247);
            this.lbWrongReason2.Name = "lbWrongReason2";
            this.lbWrongReason2.Size = new System.Drawing.Size(47, 12);
            this.lbWrongReason2.TabIndex = 6;
            this.lbWrongReason2.Text = "label36";
            // 
            // lbWrongReason1
            // 
            this.lbWrongReason1.AutoSize = true;
            this.lbWrongReason1.Location = new System.Drawing.Point(398, 224);
            this.lbWrongReason1.Name = "lbWrongReason1";
            this.lbWrongReason1.Size = new System.Drawing.Size(47, 12);
            this.lbWrongReason1.TabIndex = 6;
            this.lbWrongReason1.Text = "label36";
            // 
            // lbWasterReason3
            // 
            this.lbWasterReason3.AutoSize = true;
            this.lbWasterReason3.Location = new System.Drawing.Point(398, 201);
            this.lbWasterReason3.Name = "lbWasterReason3";
            this.lbWasterReason3.Size = new System.Drawing.Size(0, 12);
            this.lbWasterReason3.TabIndex = 6;
            // 
            // lbWasterReason2
            // 
            this.lbWasterReason2.AutoSize = true;
            this.lbWasterReason2.Location = new System.Drawing.Point(398, 178);
            this.lbWasterReason2.Name = "lbWasterReason2";
            this.lbWasterReason2.Size = new System.Drawing.Size(0, 12);
            this.lbWasterReason2.TabIndex = 6;
            // 
            // lbWasterReason1
            // 
            this.lbWasterReason1.AutoSize = true;
            this.lbWasterReason1.Location = new System.Drawing.Point(398, 155);
            this.lbWasterReason1.Name = "lbWasterReason1";
            this.lbWasterReason1.Size = new System.Drawing.Size(0, 12);
            this.lbWasterReason1.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_WEIGHT1", true));
            this.label40.Location = new System.Drawing.Point(242, 155);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 12);
            this.label40.TabIndex = 6;
            this.label40.Text = "label36";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "CASTING_NO", true));
            this.label59.Location = new System.Drawing.Point(247, 40);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 12);
            this.label59.TabIndex = 6;
            this.label59.Text = "label36";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_COUNT", true));
            this.label35.Location = new System.Drawing.Point(145, 85);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 5;
            this.label35.Text = "label35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "甩废总长度:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "CASTING_HEAT_CNT", true));
            this.label60.Location = new System.Drawing.Point(392, 40);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 12);
            this.label60.TabIndex = 6;
            this.label60.Text = "label36";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "甩废总重量:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_WEIGHT", true));
            this.label36.Location = new System.Drawing.Point(332, 85);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 12);
            this.label36.TabIndex = 6;
            this.label36.Text = "label36";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "MATERIALID", true));
            this.label64.Location = new System.Drawing.Point(86, 17);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 12);
            this.label64.TabIndex = 5;
            this.label64.Text = "label35";
            this.label64.Click += new System.EventHandler(this.label39_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(167, 17);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(83, 12);
            this.label61.TabIndex = 0;
            this.label61.Text = "预定炼钢记号:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(54, 17);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 12);
            this.label63.TabIndex = 0;
            this.label63.Text = "炉号:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "PRE_STEELGRADEINDEX", true));
            this.label62.Location = new System.Drawing.Point(247, 17);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 12);
            this.label62.TabIndex = 5;
            this.label62.Text = "label35";
            this.label62.Click += new System.EventHandler(this.label39_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_WEIGHT", true));
            this.label38.Location = new System.Drawing.Point(332, 132);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 12);
            this.label38.TabIndex = 6;
            this.label38.Text = "label36";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_COUNT3", true));
            this.label54.Location = new System.Drawing.Point(89, 270);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(47, 12);
            this.label54.TabIndex = 5;
            this.label54.Text = "label35";
            this.label54.Click += new System.EventHandler(this.label39_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_COUNT2", true));
            this.label51.Location = new System.Drawing.Point(89, 247);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(47, 12);
            this.label51.TabIndex = 5;
            this.label51.Text = "label35";
            this.label51.Click += new System.EventHandler(this.label39_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_COUNT1", true));
            this.label48.Location = new System.Drawing.Point(89, 224);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(47, 12);
            this.label48.TabIndex = 5;
            this.label48.Text = "label35";
            this.label48.Click += new System.EventHandler(this.label39_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_COUNT3", true));
            this.label45.Location = new System.Drawing.Point(89, 201);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 12);
            this.label45.TabIndex = 5;
            this.label45.Text = "label35";
            this.label45.Click += new System.EventHandler(this.label39_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(320, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "浇次内炉数:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_COUNT2", true));
            this.label42.Location = new System.Drawing.Point(89, 178);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 12);
            this.label42.TabIndex = 5;
            this.label42.Text = "label35";
            this.label42.Click += new System.EventHandler(this.label39_Click);
            // 
            // lbOffLineReason
            // 
            this.lbOffLineReason.AutoSize = true;
            this.lbOffLineReason.Location = new System.Drawing.Point(392, 17);
            this.lbOffLineReason.Name = "lbOffLineReason";
            this.lbOffLineReason.Size = new System.Drawing.Size(47, 12);
            this.lbOffLineReason.TabIndex = 5;
            this.lbOffLineReason.Text = "label35";
            this.lbOffLineReason.Click += new System.EventHandler(this.label39_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WASTER_COUNT1", true));
            this.label39.Location = new System.Drawing.Point(89, 155);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 12);
            this.label39.TabIndex = 5;
            this.label39.Text = "label35";
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(332, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "下线原因:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "WRONG_COUNT", true));
            this.label37.Location = new System.Drawing.Point(145, 132);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 12);
            this.label37.TabIndex = 5;
            this.label37.Text = "label35";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "表面缺陷描述:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(203, 40);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "浇次号:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "RIGHT_WEIGHT", true));
            this.label34.Location = new System.Drawing.Point(332, 107);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 12);
            this.label34.TabIndex = 4;
            this.label34.Text = "label34";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "RIGHT_COUNT", true));
            this.label33.Location = new System.Drawing.Point(145, 107);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 12);
            this.label33.TabIndex = 3;
            this.label33.Text = "label33";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "CAL_WEIGHT", true));
            this.label32.Location = new System.Drawing.Point(332, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInfo, "BLOOM_COUNT", true));
            this.label31.Location = new System.Drawing.Point(145, 63);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 12);
            this.label31.TabIndex = 1;
            this.label31.Text = "label31";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(315, 270);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "不合格原因3:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(315, 247);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "不合格原因2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "甩废原因3:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(168, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "不合格重量3:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "甩废原因2:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(315, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "不合格原因1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "甩废重量3:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(168, 247);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "不合格重量2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "甩废原因1:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "不合格支数3:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "甩废重量2:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(168, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "不合格重量1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "甩废长度3:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 247);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "不合格支数2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "甩废重量1:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "不合格支数1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "甩废长度2:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(242, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "不合格总重量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "甩废长度1:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "不合格总支数:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "合格钢坯重量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "合格支数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "钢坯重量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出坯钢坯支数:";
            // 
            // cmbWrongReason1
            // 
            this.cmbWrongReason1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WRONG_REASON1", true));
            this.cmbWrongReason1.DataSource = this.bsWrongReason1;
            this.cmbWrongReason1.DisplayMember = "Code_Des";
            this.cmbWrongReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWrongReason1.Enabled = false;
            this.cmbWrongReason1.FormattingEnabled = true;
            this.cmbWrongReason1.Location = new System.Drawing.Point(1141, 93);
            this.cmbWrongReason1.Name = "cmbWrongReason1";
            this.cmbWrongReason1.Size = new System.Drawing.Size(22, 20);
            this.cmbWrongReason1.TabIndex = 99;
            this.cmbWrongReason1.ValueMember = "Code";
            this.cmbWrongReason1.Visible = false;
            this.cmbWrongReason1.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWrongReason1
            // 
            this.bsWrongReason1.DataMember = "L3DataTable";
            this.bsWrongReason1.DataSource = this.dsWrongReason;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 318);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 149);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // cmbWasterReason3
            // 
            this.cmbWasterReason3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WASTER_REASON3", true));
            this.cmbWasterReason3.DataSource = this.bsWasterReason3;
            this.cmbWasterReason3.DisplayMember = "Code_Des";
            this.cmbWasterReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason3.Enabled = false;
            this.cmbWasterReason3.FormattingEnabled = true;
            this.cmbWasterReason3.Location = new System.Drawing.Point(1141, 70);
            this.cmbWasterReason3.Name = "cmbWasterReason3";
            this.cmbWasterReason3.Size = new System.Drawing.Size(22, 20);
            this.cmbWasterReason3.TabIndex = 99;
            this.cmbWasterReason3.ValueMember = "Code";
            this.cmbWasterReason3.Visible = false;
            this.cmbWasterReason3.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWasterReason3
            // 
            this.bsWasterReason3.DataMember = "L3DataTable";
            this.bsWasterReason3.DataSource = this.dsWasterReason;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = true;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsReason
            // 
            this.schemadsReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReasonL3DataTableCode,
            this.coldsReasonL3DataTableCode_Des});
            this.schemadsReason.TableName = "L3DataTable";
            // 
            // coldsReasonL3DataTableCode
            // 
            this.coldsReasonL3DataTableCode.Caption = "Code";
            this.coldsReasonL3DataTableCode.ColumnName = "Code";
            this.coldsReasonL3DataTableCode.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Des
            // 
            this.coldsReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.Namespace = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 137);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // cmbWasterReason2
            // 
            this.cmbWasterReason2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WASTER_REASON2", true));
            this.cmbWasterReason2.DataSource = this.bsWasterReason2;
            this.cmbWasterReason2.DisplayMember = "Code_Des";
            this.cmbWasterReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason2.Enabled = false;
            this.cmbWasterReason2.FormattingEnabled = true;
            this.cmbWasterReason2.Location = new System.Drawing.Point(1141, 47);
            this.cmbWasterReason2.Name = "cmbWasterReason2";
            this.cmbWasterReason2.Size = new System.Drawing.Size(22, 20);
            this.cmbWasterReason2.TabIndex = 99;
            this.cmbWasterReason2.ValueMember = "Code";
            this.cmbWasterReason2.Visible = false;
            this.cmbWasterReason2.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWasterReason2
            // 
            this.bsWasterReason2.DataMember = "L3DataTable";
            this.bsWasterReason2.DataSource = this.dsWasterReason;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // cmbWasterReason1
            // 
            this.cmbWasterReason1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInfo, "WASTER_REASON1", true));
            this.cmbWasterReason1.DataSource = this.bsWasterReason1;
            this.cmbWasterReason1.DisplayMember = "Code_Des";
            this.cmbWasterReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason1.Enabled = false;
            this.cmbWasterReason1.FormattingEnabled = true;
            this.cmbWasterReason1.Location = new System.Drawing.Point(1141, 24);
            this.cmbWasterReason1.Name = "cmbWasterReason1";
            this.cmbWasterReason1.Size = new System.Drawing.Size(22, 20);
            this.cmbWasterReason1.TabIndex = 99;
            this.cmbWasterReason1.ValueMember = "Code";
            this.cmbWasterReason1.Visible = false;
            this.cmbWasterReason1.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // bsWasterReason1
            // 
            this.bsWasterReason1.DataMember = "L3DataTable";
            this.bsWasterReason1.DataSource = this.dsWasterReason;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dvCaster04);
            this.groupBox4.Location = new System.Drawing.Point(139, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 150);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4#铸机";
            // 
            // dvCaster04
            // 
            this.dvCaster04.AllowUserToAddRows = false;
            this.dvCaster04.AutoGenerateColumns = false;
            this.dvCaster04.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster04.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster04.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn2,
            this.mATERIALIDDataGridViewTextBoxColumn3,
            this.sTDDataGridViewTextBoxColumn3,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3});
            this.dvCaster04.DataSource = this.bsCaster04;
            this.dvCaster04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster04.Location = new System.Drawing.Point(3, 17);
            this.dvCaster04.Name = "dvCaster04";
            this.dvCaster04.RowHeadersVisible = false;
            this.dvCaster04.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster04.RowTemplate.Height = 23;
            this.dvCaster04.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster04.Size = new System.Drawing.Size(374, 130);
            this.dvCaster04.TabIndex = 0;
            this.dvCaster04.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCaster_CellClick);
            // 
            // checkFlagDataGridViewTextBoxColumn2
            // 
            this.checkFlagDataGridViewTextBoxColumn2.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn2.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn2.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn2.Name = "checkFlagDataGridViewTextBoxColumn2";
            this.checkFlagDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn2.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn2.Width = 60;
            // 
            // mATERIALIDDataGridViewTextBoxColumn3
            // 
            this.mATERIALIDDataGridViewTextBoxColumn3.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn3.Name = "mATERIALIDDataGridViewTextBoxColumn3";
            // 
            // sTDDataGridViewTextBoxColumn3
            // 
            this.sTDDataGridViewTextBoxColumn3.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn3.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn3.Name = "sTDDataGridViewTextBoxColumn3";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn3
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn3.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvCaster03);
            this.groupBox3.Location = new System.Drawing.Point(139, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 145);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3#铸机";
            // 
            // dvCaster03
            // 
            this.dvCaster03.AllowUserToAddRows = false;
            this.dvCaster03.AutoGenerateColumns = false;
            this.dvCaster03.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster03.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster03.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn1,
            this.mATERIALIDDataGridViewTextBoxColumn2,
            this.sTDDataGridViewTextBoxColumn2,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2});
            this.dvCaster03.DataSource = this.bsCaster03;
            this.dvCaster03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster03.Location = new System.Drawing.Point(3, 17);
            this.dvCaster03.Name = "dvCaster03";
            this.dvCaster03.RowHeadersVisible = false;
            this.dvCaster03.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster03.RowTemplate.Height = 23;
            this.dvCaster03.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster03.Size = new System.Drawing.Size(377, 125);
            this.dvCaster03.TabIndex = 0;
            this.dvCaster03.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCaster_CellClick);
            // 
            // checkFlagDataGridViewTextBoxColumn1
            // 
            this.checkFlagDataGridViewTextBoxColumn1.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn1.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn1.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn1.Name = "checkFlagDataGridViewTextBoxColumn1";
            this.checkFlagDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn1.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn1.Width = 60;
            // 
            // mATERIALIDDataGridViewTextBoxColumn2
            // 
            this.mATERIALIDDataGridViewTextBoxColumn2.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn2.Name = "mATERIALIDDataGridViewTextBoxColumn2";
            // 
            // sTDDataGridViewTextBoxColumn2
            // 
            this.sTDDataGridViewTextBoxColumn2.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn2.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn2.Name = "sTDDataGridViewTextBoxColumn2";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn2
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn2.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvCaster02);
            this.groupBox2.Location = new System.Drawing.Point(352, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 66);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2#铸机";
            this.groupBox2.Visible = false;
            // 
            // dvCaster02
            // 
            this.dvCaster02.AllowUserToAddRows = false;
            this.dvCaster02.AutoGenerateColumns = false;
            this.dvCaster02.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster02.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn1,
            this.sTDDataGridViewTextBoxColumn1,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1});
            this.dvCaster02.DataSource = this.bsCaster02;
            this.dvCaster02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster02.Location = new System.Drawing.Point(3, 17);
            this.dvCaster02.Name = "dvCaster02";
            this.dvCaster02.RowHeadersVisible = false;
            this.dvCaster02.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster02.RowTemplate.Height = 23;
            this.dvCaster02.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster02.Size = new System.Drawing.Size(79, 46);
            this.dvCaster02.TabIndex = 0;
            this.dvCaster02.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCaster_CellClick);
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
            this.checkFlagDataGridViewTextBoxColumn.Width = 60;
            // 
            // mATERIALIDDataGridViewTextBoxColumn1
            // 
            this.mATERIALIDDataGridViewTextBoxColumn1.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn1.Name = "mATERIALIDDataGridViewTextBoxColumn1";
            // 
            // sTDDataGridViewTextBoxColumn1
            // 
            this.sTDDataGridViewTextBoxColumn1.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn1.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn1.Name = "sTDDataGridViewTextBoxColumn1";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn1
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn1.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvCaster06);
            this.groupBox1.Location = new System.Drawing.Point(656, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "6#铸机";
            // 
            // dvCaster06
            // 
            this.dvCaster06.AllowUserToAddRows = false;
            this.dvCaster06.AutoGenerateColumns = false;
            this.dvCaster06.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCaster06.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCaster06.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.sTDDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn});
            this.dvCaster06.DataSource = this.bsCaster06;
            this.dvCaster06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCaster06.Location = new System.Drawing.Point(3, 17);
            this.dvCaster06.Name = "dvCaster06";
            this.dvCaster06.RowHeadersVisible = false;
            this.dvCaster06.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvCaster06.RowTemplate.Height = 23;
            this.dvCaster06.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCaster06.Size = new System.Drawing.Size(372, 113);
            this.dvCaster06.TabIndex = 0;
            this.dvCaster06.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCaster_CellClick);
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
            this.CheckFlag.Width = 60;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            // 
            // sTDDataGridViewTextBoxColumn
            // 
            this.sTDDataGridViewTextBoxColumn.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn.Name = "sTDDataGridViewTextBoxColumn";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // schemadsBloom
            // 
            this.schemadsBloom.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomL3DataTableMATERIALTYPE,
            this.coldsBloomL3DataTableAMOUNT,
            this.coldsBloomL3DataTableMATERIALID,
            this.coldsBloomL3DataTableCUR_PILE_ID,
            this.coldsBloomL3DataTableCUR_LAYER_ID,
            this.coldsBloomL3DataTableCASTERID,
            this.coldsBloomL3DataTableSTOREAREAID,
            this.coldsBloomL3DataTableSTD,
            this.coldsBloomL3DataTableSTEELGRADEINDEX});
            this.schemadsBloom.TableName = "L3DataTable";
            // 
            // coldsBloomL3DataTableMATERIALTYPE
            // 
            this.coldsBloomL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBloomL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBloomL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBloomL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBloomL3DataTableAMOUNT
            // 
            this.coldsBloomL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBloomL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBloomL3DataTableAMOUNT.DefaultValue = "0";
            this.coldsBloomL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBloomL3DataTableMATERIALID
            // 
            this.coldsBloomL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBloomL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBloomL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBloomL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBloomL3DataTableCUR_PILE_ID
            // 
            this.coldsBloomL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsBloomL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsBloomL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsBloomL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsBloomL3DataTableCUR_LAYER_ID
            // 
            this.coldsBloomL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsBloomL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsBloomL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsBloomL3DataTableCASTERID
            // 
            this.coldsBloomL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsBloomL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsBloomL3DataTableCASTERID.DefaultValue = "";
            this.coldsBloomL3DataTableCASTERID.Namespace = "";
            // 
            // coldsBloomL3DataTableSTOREAREAID
            // 
            this.coldsBloomL3DataTableSTOREAREAID.Caption = "STOREAREAID";
            this.coldsBloomL3DataTableSTOREAREAID.ColumnName = "STOREAREAID";
            this.coldsBloomL3DataTableSTOREAREAID.DefaultValue = "";
            this.coldsBloomL3DataTableSTOREAREAID.Namespace = "";
            // 
            // coldsBloomL3DataTableSTD
            // 
            this.coldsBloomL3DataTableSTD.Caption = "STD";
            this.coldsBloomL3DataTableSTD.ColumnName = "STD";
            this.coldsBloomL3DataTableSTD.DefaultValue = "";
            this.coldsBloomL3DataTableSTD.Namespace = "";
            // 
            // coldsBloomL3DataTableSTEELGRADEINDEX
            // 
            this.coldsBloomL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsBloomL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsBloomL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsBloomL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // dsBloomSend
            // 
            this.dsBloomSend.AutoLoad = true;
            this.dsBloomSend.AutoSubscribe = true;
            this.dsBloomSend.DataSetName = "L3DataSet";
            this.dsBloomSend.DeleteMethod = "";
            this.dsBloomSend.InsertMethod = "";
            this.dsBloomSend.L3DataAdapter = null;
            this.dsBloomSend.LoadEvent = "Click";
            this.dsBloomSend.LoadTrigger = null;
            this.dsBloomSend.RefreshValve = 1000;
            this.dsBloomSend.SourceCommand = null;
            this.dsBloomSend.SourceCondition = "";
            this.dsBloomSend.SourceMethod = "";
            this.dsBloomSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBloomSend.SourceURI = "";
            this.dsBloomSend.SubscribeTarget = "Version";
            this.dsBloomSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet110});
            this.dsBloomSend.UpdateEvent = "Click";
            this.dsBloomSend.UpdateMethod = "";
            this.dsBloomSend.UpdateTrigger = null;
            // 
            // schemal3DataSet110
            // 
            this.schemal3DataSet110.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet110L3DataTableMATERIALTYPE,
            this.coll3DataSet110L3DataTableAMOUNT,
            this.coll3DataSet110L3DataTableMATERIALID,
            this.coll3DataSet110L3DataTableCUR_PILE_ID,
            this.coll3DataSet110L3DataTableCUR_LAYER_ID,
            this.coll3DataSet110L3DataTableCASTERID,
            this.coll3DataSet110L3DataTableSTOREAREAID,
            this.coll3DataSet110L3DataTableSTD,
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX,
            this.coll3DataSet110L3DataTableWASTER_COUNT,
            this.coll3DataSet110L3DataTableWRONG_COUNT,
            this.coll3DataSet110L3DataTableRIGHT_COUNT,
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX,
            this.coll3DataSet110L3DataTableCASTING_NO,
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT,
            this.coll3DataSet110L3DataTablePROCESS_TYPE,
            this.coll3DataSet110L3DataTablePLAN_ORD_ID,
            this.coll3DataSet110L3DataTableBLOOM_COUNT,
            this.coll3DataSet110L3DataTableCAL_WEIGHT,
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT,
            this.coll3DataSet110L3DataTableWASTER_WEIGHT,
            this.coll3DataSet110L3DataTableWASTER_COUNT1,
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1,
            this.coll3DataSet110L3DataTableWASTER_REASON1,
            this.coll3DataSet110L3DataTableWASTER_COUNT2,
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2,
            this.coll3DataSet110L3DataTableWASTER_REASON2,
            this.coll3DataSet110L3DataTableWASTER_COUNT3,
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3,
            this.coll3DataSet110L3DataTableWASTER_REASON3,
            this.coll3DataSet110L3DataTableWRONG_WEIGHT,
            this.coll3DataSet110L3DataTableWRONG_COUNT1,
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1,
            this.coll3DataSet110L3DataTableWRONG_REASON1,
            this.coll3DataSet110L3DataTableWRONG_COUNT2,
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2,
            this.coll3DataSet110L3DataTableWRONG_REASON2,
            this.coll3DataSet110L3DataTableWRONG_COUNT3,
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3,
            this.coll3DataSet110L3DataTableWRONG_REASON3,
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES,
            this.coll3DataSet110L3DataTableREASON});
            this.schemal3DataSet110.TableName = "L3DataTable";
            // 
            // coll3DataSet110L3DataTableMATERIALTYPE
            // 
            this.coll3DataSet110L3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coll3DataSet110L3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coll3DataSet110L3DataTableMATERIALTYPE.DefaultValue = "";
            this.coll3DataSet110L3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coll3DataSet110L3DataTableAMOUNT
            // 
            this.coll3DataSet110L3DataTableAMOUNT.Caption = "AMOUNT";
            this.coll3DataSet110L3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coll3DataSet110L3DataTableAMOUNT.DefaultValue = "0";
            this.coll3DataSet110L3DataTableAMOUNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableMATERIALID
            // 
            this.coll3DataSet110L3DataTableMATERIALID.Caption = "MATERIALID";
            this.coll3DataSet110L3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coll3DataSet110L3DataTableMATERIALID.DefaultValue = "";
            this.coll3DataSet110L3DataTableMATERIALID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCUR_PILE_ID
            // 
            this.coll3DataSet110L3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coll3DataSet110L3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coll3DataSet110L3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coll3DataSet110L3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCUR_LAYER_ID
            // 
            this.coll3DataSet110L3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coll3DataSet110L3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coll3DataSet110L3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCASTERID
            // 
            this.coll3DataSet110L3DataTableCASTERID.Caption = "CASTERID";
            this.coll3DataSet110L3DataTableCASTERID.ColumnName = "CASTERID";
            this.coll3DataSet110L3DataTableCASTERID.DefaultValue = "";
            this.coll3DataSet110L3DataTableCASTERID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableSTOREAREAID
            // 
            this.coll3DataSet110L3DataTableSTOREAREAID.Caption = "STOREAREAID";
            this.coll3DataSet110L3DataTableSTOREAREAID.ColumnName = "STOREAREAID";
            this.coll3DataSet110L3DataTableSTOREAREAID.DefaultValue = "";
            this.coll3DataSet110L3DataTableSTOREAREAID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableSTD
            // 
            this.coll3DataSet110L3DataTableSTD.Caption = "STD";
            this.coll3DataSet110L3DataTableSTD.ColumnName = "STD";
            this.coll3DataSet110L3DataTableSTD.DefaultValue = "";
            this.coll3DataSet110L3DataTableSTD.Namespace = "";
            // 
            // coll3DataSet110L3DataTableSTEELGRADEINDEX
            // 
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coll3DataSet110L3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_COUNT
            // 
            this.coll3DataSet110L3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coll3DataSet110L3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coll3DataSet110L3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_COUNT
            // 
            this.coll3DataSet110L3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coll3DataSet110L3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coll3DataSet110L3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coll3DataSet110L3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coll3DataSet110L3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableRIGHT_COUNT
            // 
            this.coll3DataSet110L3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coll3DataSet110L3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coll3DataSet110L3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coll3DataSet110L3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coll3DataSet110L3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTablePRE_STEELGRADEINDEX
            // 
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coll3DataSet110L3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCASTING_NO
            // 
            this.coll3DataSet110L3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coll3DataSet110L3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coll3DataSet110L3DataTableCASTING_NO.DefaultValue = "";
            this.coll3DataSet110L3DataTableCASTING_NO.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCASTING_HEAT_CNT
            // 
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coll3DataSet110L3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTablePROCESS_TYPE
            // 
            this.coll3DataSet110L3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coll3DataSet110L3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coll3DataSet110L3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coll3DataSet110L3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coll3DataSet110L3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coll3DataSet110L3DataTablePLAN_ORD_ID
            // 
            this.coll3DataSet110L3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coll3DataSet110L3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coll3DataSet110L3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coll3DataSet110L3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coll3DataSet110L3DataTableBLOOM_COUNT
            // 
            this.coll3DataSet110L3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coll3DataSet110L3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coll3DataSet110L3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coll3DataSet110L3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coll3DataSet110L3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableCAL_WEIGHT
            // 
            this.coll3DataSet110L3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coll3DataSet110L3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coll3DataSet110L3DataTableCAL_WEIGHT.DefaultValue = "0";
            this.coll3DataSet110L3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableRIGHT_WEIGHT
            // 
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT.DefaultValue = "0";
            this.coll3DataSet110L3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_WEIGHT
            // 
            this.coll3DataSet110L3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_COUNT1
            // 
            this.coll3DataSet110L3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coll3DataSet110L3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coll3DataSet110L3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_WEIGHT1
            // 
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_REASON1
            // 
            this.coll3DataSet110L3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coll3DataSet110L3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coll3DataSet110L3DataTableWASTER_REASON1.DefaultValue = "";
            this.coll3DataSet110L3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_COUNT2
            // 
            this.coll3DataSet110L3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coll3DataSet110L3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coll3DataSet110L3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_WEIGHT2
            // 
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_REASON2
            // 
            this.coll3DataSet110L3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coll3DataSet110L3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coll3DataSet110L3DataTableWASTER_REASON2.DefaultValue = "";
            this.coll3DataSet110L3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_COUNT3
            // 
            this.coll3DataSet110L3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coll3DataSet110L3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coll3DataSet110L3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_WEIGHT3
            // 
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWASTER_REASON3
            // 
            this.coll3DataSet110L3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coll3DataSet110L3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coll3DataSet110L3DataTableWASTER_REASON3.DefaultValue = "";
            this.coll3DataSet110L3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_WEIGHT
            // 
            this.coll3DataSet110L3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_COUNT1
            // 
            this.coll3DataSet110L3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coll3DataSet110L3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coll3DataSet110L3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coll3DataSet110L3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coll3DataSet110L3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_WEIGHT1
            // 
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_REASON1
            // 
            this.coll3DataSet110L3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coll3DataSet110L3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coll3DataSet110L3DataTableWRONG_REASON1.DefaultValue = "";
            this.coll3DataSet110L3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_COUNT2
            // 
            this.coll3DataSet110L3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coll3DataSet110L3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coll3DataSet110L3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coll3DataSet110L3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coll3DataSet110L3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_WEIGHT2
            // 
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_REASON2
            // 
            this.coll3DataSet110L3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coll3DataSet110L3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coll3DataSet110L3DataTableWRONG_REASON2.DefaultValue = "";
            this.coll3DataSet110L3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_COUNT3
            // 
            this.coll3DataSet110L3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coll3DataSet110L3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coll3DataSet110L3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coll3DataSet110L3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coll3DataSet110L3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_WEIGHT3
            // 
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3.DefaultValue = "0";
            this.coll3DataSet110L3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableWRONG_REASON3
            // 
            this.coll3DataSet110L3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coll3DataSet110L3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coll3DataSet110L3DataTableWRONG_REASON3.DefaultValue = "";
            this.coll3DataSet110L3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coll3DataSet110L3DataTableSUFACEDEFACTDES
            // 
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coll3DataSet110L3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coll3DataSet110L3DataTableREASON
            // 
            this.coll3DataSet110L3DataTableREASON.Caption = "REASON";
            this.coll3DataSet110L3DataTableREASON.ColumnName = "REASON";
            this.coll3DataSet110L3DataTableREASON.DefaultValue = "";
            this.coll3DataSet110L3DataTableREASON.Namespace = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(69, 502);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 61);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 104;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(160, 506);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(58, 57);
            this.groupBox8.TabIndex = 105;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "1#铸机";
            this.groupBox8.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.bsCaster01;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(52, 37);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "CheckFlag";
            this.dataGridViewCheckBoxColumn2.FalseValue = "0";
            this.dataGridViewCheckBoxColumn2.HeaderText = "选择";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "1";
            this.dataGridViewCheckBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MATERIALID";
            this.dataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "STD";
            this.dataGridViewTextBoxColumn5.HeaderText = "规格";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STEELGRADEINDEX";
            this.dataGridViewTextBoxColumn6.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bsCaster06
            // 
            this.bsCaster06.DataMember = "L3DataTable";
            this.bsCaster06.DataSource = this.dsBloom;
            this.bsCaster06.Filter = "CASTERID = \'S66\'";
            // 
            // BloomStoreMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 788);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloomStoreMagFrm";
            this.TabText = "钢坯库管理";
            this.Text = "钢坯库管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomStoreMagFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster01)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster04)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster03)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster02)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCaster06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaster06)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnQualityCheck;
        private System.Windows.Forms.ToolStripButton btnInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsCaster01;
        private System.Windows.Forms.BindingSource bsCaster02;
        private System.Windows.Forms.BindingSource bsCaster03;
        private System.Windows.Forms.BindingSource bsCaster04;
        private System.Windows.Forms.BindingSource bsCaster05;
        private System.Data.DataColumn coldsBloomL3DataTableWaster_Count;
        private System.Data.DataColumn coldsBloomL3DataTableWrong_Count;
        private System.Data.DataColumn coldsBloomL3DataTableRight_Count;
        private System.Data.DataColumn coldsBloomSendL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsBloomSendL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsBloomSendL3DataTableRIGHT_COUNT;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dvCaster05;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dvCaster04;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvCaster03;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvCaster02;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvCaster06;
        private AppSvrHMI.L3DataBox dbxBloomOffLineEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label lbOffLineReason;
        private System.Data.DataTable schemadsBloom;
        private System.Data.DataColumn coldsBloomL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBloomL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBloomL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBloomL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsBloomL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsBloomL3DataTableCASTERID;
        private System.Data.DataColumn coldsBloomL3DataTableSTOREAREAID;
        private System.Data.DataColumn coldsBloomL3DataTableSTD;
        private System.Data.DataColumn coldsBloomL3DataTableSTEELGRADEINDEX;
        private AppSvrHMI.L3DataSet dsBloom;
        private System.Data.DataTable schemal3DataSet23;
        private System.Data.DataColumn coll3DataSet23L3DataTableMATERIALTYPE;
        private System.Data.DataColumn coll3DataSet23L3DataTableAMOUNT;
        private System.Data.DataColumn coll3DataSet23L3DataTableMATERIALID;
        private System.Data.DataColumn coll3DataSet23L3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coll3DataSet23L3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coll3DataSet23L3DataTableCASTERID;
        private System.Data.DataColumn coll3DataSet23L3DataTableSTOREAREAID;
        private System.Data.DataColumn coll3DataSet23L3DataTableSTD;
        private System.Data.DataColumn coll3DataSet23L3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_COUNT;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_COUNT;
        private System.Data.DataColumn coll3DataSet23L3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coll3DataSet23L3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coll3DataSet23L3DataTableCASTING_NO;
        private System.Data.DataColumn coll3DataSet23L3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coll3DataSet23L3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coll3DataSet23L3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coll3DataSet23L3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coll3DataSet23L3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coll3DataSet23L3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_REASON1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_REASON2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coll3DataSet23L3DataTableWASTER_REASON3;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_REASON1;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_REASON2;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coll3DataSet23L3DataTableWRONG_REASON3;
        private System.Data.DataColumn coll3DataSet23L3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coll3DataSet23L3DataTableREASON;
        private System.Data.DataColumn coldsBloomL3DataTableCheckFlag;
        private System.Windows.Forms.BindingSource bsInfo;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private buttonHide.MyLine myLine2;
        private buttonHide.MyLine myLine1;
        private AppSvrHMI.L3DataSet dsBloomSend;
        private System.Data.DataTable schemal3DataSet110;
        private System.Data.DataColumn coll3DataSet110L3DataTableMATERIALTYPE;
        private System.Data.DataColumn coll3DataSet110L3DataTableAMOUNT;
        private System.Data.DataColumn coll3DataSet110L3DataTableMATERIALID;
        private System.Data.DataColumn coll3DataSet110L3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coll3DataSet110L3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coll3DataSet110L3DataTableCASTERID;
        private System.Data.DataColumn coll3DataSet110L3DataTableSTOREAREAID;
        private System.Data.DataColumn coll3DataSet110L3DataTableSTD;
        private System.Data.DataColumn coll3DataSet110L3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_COUNT;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_COUNT;
        private System.Data.DataColumn coll3DataSet110L3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coll3DataSet110L3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coll3DataSet110L3DataTableCASTING_NO;
        private System.Data.DataColumn coll3DataSet110L3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coll3DataSet110L3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coll3DataSet110L3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coll3DataSet110L3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coll3DataSet110L3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coll3DataSet110L3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_REASON1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_REASON2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coll3DataSet110L3DataTableWASTER_REASON3;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_REASON1;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_REASON2;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coll3DataSet110L3DataTableWRONG_REASON3;
        private System.Data.DataColumn coll3DataSet110L3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coll3DataSet110L3DataTableREASON;
        private System.Windows.Forms.ComboBox cmbWasterReason1;
        private System.Windows.Forms.ComboBox cmbWasterReason3;
        private System.Windows.Forms.ComboBox cmbWasterReason2;
        private System.Windows.Forms.ComboBox cmbWrongReason3;
        private System.Windows.Forms.ComboBox cmbWrongReason2;
        private System.Windows.Forms.ComboBox cmbWrongReason1;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsReason;
        private System.Data.DataColumn coldsReasonL3DataTableCode;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWasterReason1;
        private System.Windows.Forms.BindingSource bsWasterReason2;
        private System.Windows.Forms.BindingSource bsWasterReason3;
        private System.Windows.Forms.BindingSource bsWrongReason3;
        private System.Windows.Forms.BindingSource bsWrongReason2;
        private System.Windows.Forms.BindingSource bsWrongReason1;
        private System.Windows.Forms.Label lbWrongReason3;
        private System.Windows.Forms.Label lbWrongReason2;
        private System.Windows.Forms.Label lbWrongReason1;
        private System.Windows.Forms.Label lbWasterReason3;
        private System.Windows.Forms.Label lbWasterReason2;
        private System.Windows.Forms.Label lbWasterReason1;
        private System.Windows.Forms.ComboBox cmbOffLineReason;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTablecode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTablecode_des;
        private System.Windows.Forms.BindingSource bsOffLineReason;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dvCaster07;
        private System.Windows.Forms.BindingSource bsCaster07;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.BindingSource bsCaster06;
    }
}