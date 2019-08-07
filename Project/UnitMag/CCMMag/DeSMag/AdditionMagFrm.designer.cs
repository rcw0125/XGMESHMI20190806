namespace UnitMag.DeSMag
{
    partial class AdditionMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.bsAddition = new System.Windows.Forms.BindingSource(this.components);
            this.dsAddition = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsGrid1 = new System.Data.DataTable();
            this.coldsGrid1L3DataTableGUID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableName = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableUnitID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTeam = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableMat_Code = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableMat_Vendor = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableWeight = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableShift = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableOperator = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableTime_Discharge = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableTime_Begin_Discharge = new System.Data.DataColumn();
            this.coldsAdditionL3DataTableTime_Stop_Discharge = new System.Data.DataColumn();
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
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvAddition = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.matCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMatCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.matVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMatVonder = new AppSvrHMI.L3DataSet();
            this.schemadsMatVonder = new System.Data.DataTable();
            this.coldsMatVonderL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatVonderL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsMatVonderL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCODE = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCODE_DES = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Begin_Discharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Stop_Discharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Discharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataModify = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtMatCode1 = new AppSvrHMI.L3DataBox();
            this.txtMatVendor1 = new AppSvrHMI.L3DataBox();
            this.txtMatCode2 = new AppSvrHMI.L3DataBox();
            this.txtMatVender2 = new AppSvrHMI.L3DataBox();
            this.dsAdditionSend = new AppSvrHMI.L3DataSet();
            this.schemadsAdditionSend = new System.Data.DataTable();
            this.coldsAdditionSendL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableWeight = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableName = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableMat_Code = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableMat_Vendor = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableTime_Discharge = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableShift = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableTeam = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableOperator = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge = new System.Data.DataColumn();
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.btnIntoEXL = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionSend)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.btnAdd,
            this.tsbtnConfirm,
            this.tsbtnCancel,
            this.btnIntoEXL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 43);
            this.toolStrip1.TabIndex = 61;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(65, 40);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnDeSAdditionAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbtnConfirm
            // 
            this.Adapter.SetAccessRight(this.tsbtnConfirm, "btnDeSAdditionConfirm");
            this.tsbtnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConfirm.Image")));
            this.tsbtnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConfirm.Name = "tsbtnConfirm";
            this.tsbtnConfirm.Size = new System.Drawing.Size(65, 40);
            this.tsbtnConfirm.Text = "确定";
            this.tsbtnConfirm.Click += new System.EventHandler(this.tsbtnConfirm_Click);
            // 
            // tsbtnCancel
            // 
            this.Adapter.SetAccessRight(this.tsbtnCancel, "btnDeSAdditionCancel");
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(65, 40);
            this.tsbtnCancel.Text = "取消";
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // bsAddition
            // 
            this.bsAddition.DataMember = "L3DataTable";
            this.bsAddition.DataSource = this.dsAddition;
            // 
            // dsAddition
            // 
            this.dsAddition.AutoLoad = true;
            this.dsAddition.AutoSubscribe = false;
            this.dsAddition.DataSetName = "L3DataSet";
            this.dsAddition.DeleteMethod = null;
            this.dsAddition.InsertMethod = null;
            this.dsAddition.L3DataAdapter = this.Adapter;
            this.dsAddition.LoadEvent = "Click";
            this.dsAddition.LoadTrigger = null;
            this.dsAddition.RefreshValve = 1000;
            this.dsAddition.SourceCommand = null;
            this.dsAddition.SourceCondition = "1=2";
            this.dsAddition.SourceMethod = "";
            this.dsAddition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAddition.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Addition_Data";
            this.dsAddition.SubscribeTarget = null;
            this.dsAddition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGrid1});
            this.dsAddition.UpdateEvent = "Click";
            this.dsAddition.UpdateMethod = null;
            this.dsAddition.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsGrid1
            // 
            this.schemadsGrid1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGrid1L3DataTableGUID,
            this.coldsGrid1L3DataTableName,
            this.coldsGrid1L3DataTableUnitID,
            this.coldsGrid1L3DataTableTeam,
            this.coldsAdditionL3DataTableMat_Code,
            this.coldsAdditionL3DataTableMat_Vendor,
            this.coldsAdditionL3DataTableWeight,
            this.coldsAdditionL3DataTableShift,
            this.coldsAdditionL3DataTableOperator,
            this.coldsAdditionL3DataTableTime_Discharge,
            this.coldsAdditionL3DataTableTime_Begin_Discharge,
            this.coldsAdditionL3DataTableTime_Stop_Discharge});
            this.schemadsGrid1.TableName = "L3DataTable";
            // 
            // coldsGrid1L3DataTableGUID
            // 
            this.coldsGrid1L3DataTableGUID.Caption = "GUID";
            this.coldsGrid1L3DataTableGUID.ColumnName = "GUID";
            this.coldsGrid1L3DataTableGUID.Namespace = "";
            // 
            // coldsGrid1L3DataTableName
            // 
            this.coldsGrid1L3DataTableName.Caption = "Name";
            this.coldsGrid1L3DataTableName.ColumnName = "Name";
            this.coldsGrid1L3DataTableName.Namespace = "";
            // 
            // coldsGrid1L3DataTableUnitID
            // 
            this.coldsGrid1L3DataTableUnitID.Caption = "UnitID";
            this.coldsGrid1L3DataTableUnitID.ColumnName = "UnitID";
            this.coldsGrid1L3DataTableUnitID.Namespace = "";
            // 
            // coldsGrid1L3DataTableTeam
            // 
            this.coldsGrid1L3DataTableTeam.Caption = "Team";
            this.coldsGrid1L3DataTableTeam.ColumnName = "Team";
            this.coldsGrid1L3DataTableTeam.Namespace = "";
            // 
            // coldsAdditionL3DataTableMat_Code
            // 
            this.coldsAdditionL3DataTableMat_Code.Caption = "Mat_Code";
            this.coldsAdditionL3DataTableMat_Code.ColumnName = "Mat_Code";
            this.coldsAdditionL3DataTableMat_Code.Namespace = "";
            // 
            // coldsAdditionL3DataTableMat_Vendor
            // 
            this.coldsAdditionL3DataTableMat_Vendor.Caption = "Mat_Vendor";
            this.coldsAdditionL3DataTableMat_Vendor.ColumnName = "Mat_Vendor";
            this.coldsAdditionL3DataTableMat_Vendor.Namespace = "";
            // 
            // coldsAdditionL3DataTableWeight
            // 
            this.coldsAdditionL3DataTableWeight.Caption = "Weight";
            this.coldsAdditionL3DataTableWeight.ColumnName = "Weight";
            this.coldsAdditionL3DataTableWeight.DataType = typeof(float);
            this.coldsAdditionL3DataTableWeight.Namespace = "";
            // 
            // coldsAdditionL3DataTableShift
            // 
            this.coldsAdditionL3DataTableShift.Caption = "Shift";
            this.coldsAdditionL3DataTableShift.ColumnName = "Shift";
            this.coldsAdditionL3DataTableShift.Namespace = "";
            // 
            // coldsAdditionL3DataTableOperator
            // 
            this.coldsAdditionL3DataTableOperator.Caption = "Operator";
            this.coldsAdditionL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdditionL3DataTableOperator.Namespace = "";
            // 
            // coldsAdditionL3DataTableTime_Discharge
            // 
            this.coldsAdditionL3DataTableTime_Discharge.Caption = "Time_Discharge";
            this.coldsAdditionL3DataTableTime_Discharge.ColumnName = "Time_Discharge";
            this.coldsAdditionL3DataTableTime_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionL3DataTableTime_Discharge.Namespace = "";
            // 
            // coldsAdditionL3DataTableTime_Begin_Discharge
            // 
            this.coldsAdditionL3DataTableTime_Begin_Discharge.Caption = "Time_Begin_Discharge";
            this.coldsAdditionL3DataTableTime_Begin_Discharge.ColumnName = "Time_Begin_Discharge";
            this.coldsAdditionL3DataTableTime_Begin_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionL3DataTableTime_Begin_Discharge.Namespace = "";
            // 
            // coldsAdditionL3DataTableTime_Stop_Discharge
            // 
            this.coldsAdditionL3DataTableTime_Stop_Discharge.Caption = "Time_Stop_Discharge";
            this.coldsAdditionL3DataTableTime_Stop_Discharge.ColumnName = "Time_Stop_Discharge";
            this.coldsAdditionL3DataTableTime_Stop_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionL3DataTableTime_Stop_Discharge.Namespace = "";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvAddition);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(806, 326);
            this.hmiRootPanel1.TabIndex = 81;
            // 
            // dvAddition
            // 
            this.dvAddition.AllowUserToAddRows = false;
            this.dvAddition.AutoGenerateColumns = false;
            this.dvAddition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvAddition.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAddition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAddition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.matCodeDataGridViewTextBoxColumn,
            this.matVendorDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.Time_Begin_Discharge,
            this.Time_Stop_Discharge,
            this.Time_Discharge});
            this.dvAddition.DataSource = this.bsAddition;
            this.dvAddition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAddition.Location = new System.Drawing.Point(0, 25);
            this.dvAddition.Name = "dvAddition";
            this.dvAddition.RowTemplate.Height = 23;
            this.dvAddition.Size = new System.Drawing.Size(802, 297);
            this.dvAddition.TabIndex = 25;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.dsUnitID;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.unitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.unitIDDataGridViewTextBoxColumn.Width = 51;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoLoad = true;
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "code_group = \'DeS\'";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // matCodeDataGridViewTextBoxColumn
            // 
            this.matCodeDataGridViewTextBoxColumn.DataPropertyName = "Mat_Code";
            this.matCodeDataGridViewTextBoxColumn.DataSource = this.dsMatCode;
            this.matCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.matCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.matCodeDataGridViewTextBoxColumn.HeaderText = "脱硫剂代码";
            this.matCodeDataGridViewTextBoxColumn.Name = "matCodeDataGridViewTextBoxColumn";
            this.matCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.matCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.matCodeDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsMatCode
            // 
            this.dsMatCode.AutoLoad = true;
            this.dsMatCode.AutoSubscribe = false;
            this.dsMatCode.DataSetName = "L3DataSet";
            this.dsMatCode.DeleteMethod = "";
            this.dsMatCode.InsertMethod = "";
            this.dsMatCode.L3DataAdapter = this.Adapter;
            this.dsMatCode.LoadEvent = "";
            this.dsMatCode.LoadTrigger = null;
            this.dsMatCode.RefreshValve = 1000;
            this.dsMatCode.SourceCommand = null;
            this.dsMatCode.SourceCondition = "code_group = \'DeS_Mat_Code\'";
            this.dsMatCode.SourceMethod = "";
            this.dsMatCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatCode.SubscribeTarget = "";
            this.dsMatCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsMatCode.UpdateEvent = "";
            this.dsMatCode.UpdateMethod = "";
            this.dsMatCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTableCode,
            this.coldsMatCodeL3DataTableCode_Des});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTableCode
            // 
            this.coldsMatCodeL3DataTableCode.Caption = "Code";
            this.coldsMatCodeL3DataTableCode.ColumnName = "Code";
            this.coldsMatCodeL3DataTableCode.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Des
            // 
            this.coldsMatCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.Namespace = "";
            // 
            // matVendorDataGridViewTextBoxColumn
            // 
            this.matVendorDataGridViewTextBoxColumn.DataPropertyName = "Mat_Vendor";
            this.matVendorDataGridViewTextBoxColumn.DataSource = this.dsMatVonder;
            this.matVendorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.matVendorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.matVendorDataGridViewTextBoxColumn.HeaderText = "脱硫剂厂家";
            this.matVendorDataGridViewTextBoxColumn.Name = "matVendorDataGridViewTextBoxColumn";
            this.matVendorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matVendorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.matVendorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Des";
            this.matVendorDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsMatVonder
            // 
            this.dsMatVonder.AutoLoad = true;
            this.dsMatVonder.AutoSubscribe = false;
            this.dsMatVonder.DataSetName = "L3DataSet";
            this.dsMatVonder.DeleteMethod = "";
            this.dsMatVonder.InsertMethod = "";
            this.dsMatVonder.L3DataAdapter = this.Adapter;
            this.dsMatVonder.LoadEvent = "";
            this.dsMatVonder.LoadTrigger = null;
            this.dsMatVonder.RefreshValve = 1000;
            this.dsMatVonder.SourceCommand = null;
            this.dsMatVonder.SourceCondition = "code_group = \'DeS_Mat_Vendor\'";
            this.dsMatVonder.SourceMethod = "";
            this.dsMatVonder.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatVonder.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatVonder.SubscribeTarget = "";
            this.dsMatVonder.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatVonder});
            this.dsMatVonder.UpdateEvent = "";
            this.dsMatVonder.UpdateMethod = "";
            this.dsMatVonder.UpdateTrigger = null;
            // 
            // schemadsMatVonder
            // 
            this.schemadsMatVonder.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatVonderL3DataTableCode,
            this.coldsMatVonderL3DataTableCode_Des,
            this.coldsMatVonderL3DataTableCode_Val_Str});
            this.schemadsMatVonder.TableName = "L3DataTable";
            // 
            // coldsMatVonderL3DataTableCode
            // 
            this.coldsMatVonderL3DataTableCode.Caption = "Code";
            this.coldsMatVonderL3DataTableCode.ColumnName = "Code";
            this.coldsMatVonderL3DataTableCode.Namespace = "";
            // 
            // coldsMatVonderL3DataTableCode_Des
            // 
            this.coldsMatVonderL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatVonderL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatVonderL3DataTableCode_Des.Namespace = "";
            // 
            // coldsMatVonderL3DataTableCode_Val_Str
            // 
            this.coldsMatVonderL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsMatVonderL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsMatVonderL3DataTableCode_Val_Str.Namespace = "";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.weightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.weightDataGridViewTextBoxColumn.HeaderText = "加料量[Kg]";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 83;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班次";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamDataGridViewTextBoxColumn.Width = 51;
            // 
            // dsTeam
            // 
            this.dsTeam.AutoLoad = true;
            this.dsTeam.AutoSubscribe = true;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = null;
            this.dsTeam.InsertMethod = null;
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "Click";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "Click";
            this.dsTeam.UpdateMethod = null;
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTableCode
            // 
            this.coldsTeamL3DataTableCode.Caption = "Code";
            this.coldsTeamL3DataTableCode.ColumnName = "Code";
            this.coldsTeamL3DataTableCode.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Des
            // 
            this.coldsTeamL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.Namespace = "";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShift;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.CODE_DES";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班别";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.CODE";
            this.shiftDataGridViewTextBoxColumn.Width = 51;
            // 
            // dsShift
            // 
            this.dsShift.AutoLoad = true;
            this.dsShift.AutoSubscribe = true;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = null;
            this.dsShift.InsertMethod = null;
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "Click";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = null;
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "Click";
            this.dsShift.UpdateMethod = null;
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTableCODE,
            this.coldsShiftL3DataTableCODE_DES});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTableCODE
            // 
            this.coldsShiftL3DataTableCODE.Caption = "CODE";
            this.coldsShiftL3DataTableCODE.ColumnName = "CODE";
            this.coldsShiftL3DataTableCODE.Namespace = "";
            // 
            // coldsShiftL3DataTableCODE_DES
            // 
            this.coldsShiftL3DataTableCODE_DES.Caption = "CODE_DES";
            this.coldsShiftL3DataTableCODE_DES.ColumnName = "CODE_DES";
            this.coldsShiftL3DataTableCODE_DES.Namespace = "";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Width = 61;
            // 
            // Time_Begin_Discharge
            // 
            this.Time_Begin_Discharge.DataPropertyName = "Time_Begin_Discharge";
            this.Time_Begin_Discharge.HeaderText = "加料开始时间";
            this.Time_Begin_Discharge.Name = "Time_Begin_Discharge";
            this.Time_Begin_Discharge.Width = 72;
            // 
            // Time_Stop_Discharge
            // 
            this.Time_Stop_Discharge.DataPropertyName = "Time_Stop_Discharge";
            this.Time_Stop_Discharge.HeaderText = "加料结束时间";
            this.Time_Stop_Discharge.Name = "Time_Stop_Discharge";
            this.Time_Stop_Discharge.Width = 72;
            // 
            // Time_Discharge
            // 
            this.Time_Discharge.DataPropertyName = "Time_Discharge";
            this.Time_Discharge.HeaderText = "记录时间";
            this.Time_Discharge.Name = "Time_Discharge";
            this.Time_Discharge.Width = 61;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsAddition;
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
            this.btnDataModify,
            this.btnQuery,
            this.dtEnd,
            this.toolStripLabel5,
            this.dtStart,
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(802, 25);
            this.bdN1.TabIndex = 24;
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
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "       ";
            // 
            // btnDataModify
            // 
            this.btnDataModify.Name = "btnDataModify";
            this.btnDataModify.Size = new System.Drawing.Size(0, 22);
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
            this.dtEnd.Text = "2009-01-04";
            this.dtEnd.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "－";
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
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "日期:";
            // 
            // txtMatCode1
            // 
            this.txtMatCode1.DataFormat = null;
            this.txtMatCode1.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.txtMatCode1.DataProperty = "Mat_Code";
            this.txtMatCode1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtMatCode1.L3DataAdapter = this.Adapter;
            this.txtMatCode1.Location = new System.Drawing.Point(480, 12);
            this.txtMatCode1.Name = "txtMatCode1";
            this.txtMatCode1.Size = new System.Drawing.Size(21, 21);
            this.txtMatCode1.TabIndex = 82;
            this.txtMatCode1.Value = null;
            this.txtMatCode1.Visible = false;
            // 
            // txtMatVendor1
            // 
            this.txtMatVendor1.DataFormat = null;
            this.txtMatVendor1.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.txtMatVendor1.DataProperty = "Mat_Vendor";
            this.txtMatVendor1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtMatVendor1.L3DataAdapter = this.Adapter;
            this.txtMatVendor1.Location = new System.Drawing.Point(507, 12);
            this.txtMatVendor1.Name = "txtMatVendor1";
            this.txtMatVendor1.Size = new System.Drawing.Size(21, 21);
            this.txtMatVendor1.TabIndex = 82;
            this.txtMatVendor1.Value = null;
            this.txtMatVendor1.Visible = false;
            // 
            // txtMatCode2
            // 
            this.txtMatCode2.DataFormat = null;
            this.txtMatCode2.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.txtMatCode2.DataProperty = "Mat_Code";
            this.txtMatCode2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtMatCode2.L3DataAdapter = this.Adapter;
            this.txtMatCode2.Location = new System.Drawing.Point(534, 12);
            this.txtMatCode2.Name = "txtMatCode2";
            this.txtMatCode2.Size = new System.Drawing.Size(21, 21);
            this.txtMatCode2.TabIndex = 82;
            this.txtMatCode2.Value = null;
            this.txtMatCode2.Visible = false;
            // 
            // txtMatVender2
            // 
            this.txtMatVender2.DataFormat = null;
            this.txtMatVender2.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.txtMatVender2.DataProperty = "Mat_Vendor";
            this.txtMatVender2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtMatVender2.L3DataAdapter = this.Adapter;
            this.txtMatVender2.Location = new System.Drawing.Point(561, 12);
            this.txtMatVender2.Name = "txtMatVender2";
            this.txtMatVender2.Size = new System.Drawing.Size(21, 21);
            this.txtMatVender2.TabIndex = 82;
            this.txtMatVender2.Value = null;
            this.txtMatVender2.Visible = false;
            // 
            // dsAdditionSend
            // 
            this.dsAdditionSend.AutoLoad = false;
            this.dsAdditionSend.AutoSubscribe = false;
            this.dsAdditionSend.DataSetName = "L3DataSet";
            this.dsAdditionSend.DeleteMethod = "";
            this.dsAdditionSend.InsertMethod = "";
            this.dsAdditionSend.L3DataAdapter = null;
            this.dsAdditionSend.LoadEvent = "";
            this.dsAdditionSend.LoadTrigger = null;
            this.dsAdditionSend.RefreshValve = 1000;
            this.dsAdditionSend.SourceCommand = null;
            this.dsAdditionSend.SourceCondition = "";
            this.dsAdditionSend.SourceMethod = "";
            this.dsAdditionSend.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdditionSend.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Addition_Data";
            this.dsAdditionSend.SubscribeTarget = "";
            this.dsAdditionSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdditionSend});
            this.dsAdditionSend.UpdateEvent = "";
            this.dsAdditionSend.UpdateMethod = "";
            this.dsAdditionSend.UpdateTrigger = null;
            // 
            // schemadsAdditionSend
            // 
            this.schemadsAdditionSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdditionSendL3DataTableUnitID,
            this.coldsAdditionSendL3DataTableWeight,
            this.coldsAdditionSendL3DataTableGUID,
            this.coldsAdditionSendL3DataTableName,
            this.coldsAdditionSendL3DataTableMat_Code,
            this.coldsAdditionSendL3DataTableMat_Vendor,
            this.coldsAdditionSendL3DataTableTime_Discharge,
            this.coldsAdditionSendL3DataTableShift,
            this.coldsAdditionSendL3DataTableTeam,
            this.coldsAdditionSendL3DataTableOperator,
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge,
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge});
            this.schemadsAdditionSend.TableName = "L3DataTable";
            // 
            // coldsAdditionSendL3DataTableUnitID
            // 
            this.coldsAdditionSendL3DataTableUnitID.Caption = "UnitID";
            this.coldsAdditionSendL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsAdditionSendL3DataTableUnitID.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableWeight
            // 
            this.coldsAdditionSendL3DataTableWeight.Caption = "Weight";
            this.coldsAdditionSendL3DataTableWeight.ColumnName = "Weight";
            this.coldsAdditionSendL3DataTableWeight.DataType = typeof(float);
            this.coldsAdditionSendL3DataTableWeight.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableGUID
            // 
            this.coldsAdditionSendL3DataTableGUID.Caption = "GUID";
            this.coldsAdditionSendL3DataTableGUID.ColumnName = "GUID";
            this.coldsAdditionSendL3DataTableGUID.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableName
            // 
            this.coldsAdditionSendL3DataTableName.Caption = "Name";
            this.coldsAdditionSendL3DataTableName.ColumnName = "Name";
            this.coldsAdditionSendL3DataTableName.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableMat_Code
            // 
            this.coldsAdditionSendL3DataTableMat_Code.Caption = "Mat_Code";
            this.coldsAdditionSendL3DataTableMat_Code.ColumnName = "Mat_Code";
            this.coldsAdditionSendL3DataTableMat_Code.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableMat_Vendor
            // 
            this.coldsAdditionSendL3DataTableMat_Vendor.Caption = "Mat_Vendor";
            this.coldsAdditionSendL3DataTableMat_Vendor.ColumnName = "Mat_Vendor";
            this.coldsAdditionSendL3DataTableMat_Vendor.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableTime_Discharge
            // 
            this.coldsAdditionSendL3DataTableTime_Discharge.Caption = "Time_Discharge";
            this.coldsAdditionSendL3DataTableTime_Discharge.ColumnName = "Time_Discharge";
            this.coldsAdditionSendL3DataTableTime_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionSendL3DataTableTime_Discharge.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableShift
            // 
            this.coldsAdditionSendL3DataTableShift.Caption = "Shift";
            this.coldsAdditionSendL3DataTableShift.ColumnName = "Shift";
            this.coldsAdditionSendL3DataTableShift.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableTeam
            // 
            this.coldsAdditionSendL3DataTableTeam.Caption = "Team";
            this.coldsAdditionSendL3DataTableTeam.ColumnName = "Team";
            this.coldsAdditionSendL3DataTableTeam.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableOperator
            // 
            this.coldsAdditionSendL3DataTableOperator.Caption = "Operator";
            this.coldsAdditionSendL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdditionSendL3DataTableOperator.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableTime_Begin_Discharge
            // 
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge.Caption = "Time_Begin_Discharge";
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge.ColumnName = "Time_Begin_Discharge";
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionSendL3DataTableTime_Begin_Discharge.Namespace = "";
            // 
            // coldsAdditionSendL3DataTableTime_Stop_Discharge
            // 
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge.Caption = "Time_Stop_Discharge";
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge.ColumnName = "Time_Stop_Discharge";
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditionSendL3DataTableTime_Stop_Discharge.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsAddition;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // btnIntoEXL
            // 
            this.btnIntoEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnIntoEXL.Image")));
            this.btnIntoEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIntoEXL.Name = "btnIntoEXL";
            this.btnIntoEXL.Size = new System.Drawing.Size(95, 40);
            this.btnIntoEXL.Text = "导出到EXL";
            this.btnIntoEXL.Click += new System.EventHandler(this.btnIntoEXL_Click);
            // 
            // AdditionMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 369);
            this.Controls.Add(this.txtMatVender2);
            this.Controls.Add(this.txtMatCode2);
            this.Controls.Add(this.txtMatVendor1);
            this.Controls.Add(this.txtMatCode1);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdditionMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "加料维护";
            this.Text = "加料维护";
            this.Load += new System.EventHandler(this.AdditionMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingSource bsAddition;
        private AppSvrHMI.L3DataSet dsAddition;
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
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnConfirm;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Data.DataTable schemadsGrid1;
        private System.Data.DataColumn coldsGrid1L3DataTableGUID;
        private System.Data.DataColumn coldsGrid1L3DataTableName;
        private System.Data.DataColumn coldsGrid1L3DataTableUnitID;
        private System.Data.DataColumn coldsGrid1L3DataTableTeam;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdditionL3DataTableMat_Code;
        private System.Data.DataColumn coldsAdditionL3DataTableMat_Vendor;
        private System.Data.DataColumn coldsAdditionL3DataTableWeight;
        private System.Data.DataColumn coldsAdditionL3DataTableShift;
        private System.Data.DataColumn coldsAdditionL3DataTableOperator;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCODE;
        private System.Data.DataColumn coldsShiftL3DataTableCODE_DES;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private AppSvrHMI.L3DataBox txtMatCode1;
        private AppSvrHMI.L3DataBox txtMatVendor1;
        private AppSvrHMI.L3DataBox txtMatCode2;
        private AppSvrHMI.L3DataBox txtMatVender2;
        private AppSvrHMI.L3DataSet dsAdditionSend;
        private System.Data.DataTable schemadsAdditionSend;
        private System.Data.DataColumn coldsAdditionSendL3DataTableUnitID;
        private System.Data.DataColumn coldsAdditionSendL3DataTableWeight;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMatCode;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Des;
        private System.Windows.Forms.DataGridView dvAddition;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel btnDataModify;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3DataSet dsMatVonder;
        private System.Data.DataTable schemadsMatVonder;
        private System.Data.DataColumn coldsMatVonderL3DataTableCode;
        private System.Data.DataColumn coldsMatVonderL3DataTableCode_Des;
        private System.Data.DataColumn coldsMatVonderL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsAdditionL3DataTableTime_Discharge;
        private System.Data.DataColumn coldsAdditionL3DataTableTime_Begin_Discharge;
        private System.Data.DataColumn coldsAdditionL3DataTableTime_Stop_Discharge;
        private System.Data.DataColumn coldsAdditionSendL3DataTableGUID;
        private System.Data.DataColumn coldsAdditionSendL3DataTableName;
        private System.Data.DataColumn coldsAdditionSendL3DataTableMat_Code;
        private System.Data.DataColumn coldsAdditionSendL3DataTableMat_Vendor;
        private System.Data.DataColumn coldsAdditionSendL3DataTableTime_Discharge;
        private System.Data.DataColumn coldsAdditionSendL3DataTableShift;
        private System.Data.DataColumn coldsAdditionSendL3DataTableTeam;
        private System.Data.DataColumn coldsAdditionSendL3DataTableOperator;
        private System.Data.DataColumn coldsAdditionSendL3DataTableTime_Begin_Discharge;
        private System.Data.DataColumn coldsAdditionSendL3DataTableTime_Stop_Discharge;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn matCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn matVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Begin_Discharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Stop_Discharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Discharge;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnIntoEXL;
    }
}