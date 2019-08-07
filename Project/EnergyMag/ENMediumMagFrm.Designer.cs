namespace EnergyMag
{
    partial class ENMediumMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ENMediumMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
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
            this.bdn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableTagName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTagCode = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTagDesc = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePressure = new System.Data.DataColumn();
            this.coldsBaseL3DataTableFlow = new System.Data.DataColumn();
            this.coldsBaseL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsBaseL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsBaseL3DataTableP_High = new System.Data.DataColumn();
            this.coldsBaseL3DataTableP_Low = new System.Data.DataColumn();
            this.coldsBaseL3DataTableF_Max = new System.Data.DataColumn();
            this.coldsBaseL3DataTableF_Min = new System.Data.DataColumn();
            this.coldsBaseL3DataTableF_High = new System.Data.DataColumn();
            this.coldsBaseL3DataTableF_Low = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCatch_Time = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBase = new System.Windows.Forms.DataGridView();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLowDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).BeginInit();
            this.bdn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "ENMediumMagBtnMod");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(49, 22);
            this.btnConfirm.Text = "保存";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // bdn1
            // 
            this.bdn1.AddNewItem = null;
            this.bdn1.BindingSource = this.bsBase;
            this.bdn1.CountItem = this.bindingNavigatorCountItem;
            this.bdn1.DeleteItem = null;
            this.bdn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator1,
            this.btnConfirm,
            this.btnCancel});
            this.bdn1.Location = new System.Drawing.Point(0, 0);
            this.bdn1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn1.Name = "bdn1";
            this.bdn1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn1.Size = new System.Drawing.Size(832, 25);
            this.bdn1.TabIndex = 0;
            this.bdn1.Text = "bindingNavigator1";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = "";
            this.dsBase.InsertMethod = "";
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "";
            this.dsBase.UpdateMethod = "";
            this.dsBase.UpdateTrigger = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableTagName,
            this.coldsBaseL3DataTableTagCode,
            this.coldsBaseL3DataTableTagDesc,
            this.coldsBaseL3DataTablePressure,
            this.coldsBaseL3DataTableFlow,
            this.coldsBaseL3DataTableP_Max,
            this.coldsBaseL3DataTableP_Min,
            this.coldsBaseL3DataTableP_High,
            this.coldsBaseL3DataTableP_Low,
            this.coldsBaseL3DataTableF_Max,
            this.coldsBaseL3DataTableF_Min,
            this.coldsBaseL3DataTableF_High,
            this.coldsBaseL3DataTableF_Low,
            this.coldsBaseL3DataTableCatch_Time});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableTagName
            // 
            this.coldsBaseL3DataTableTagName.Caption = "TagName";
            this.coldsBaseL3DataTableTagName.ColumnName = "TagName";
            this.coldsBaseL3DataTableTagName.Namespace = "";
            // 
            // coldsBaseL3DataTableTagCode
            // 
            this.coldsBaseL3DataTableTagCode.Caption = "TagCode";
            this.coldsBaseL3DataTableTagCode.ColumnName = "TagCode";
            this.coldsBaseL3DataTableTagCode.Namespace = "";
            // 
            // coldsBaseL3DataTableTagDesc
            // 
            this.coldsBaseL3DataTableTagDesc.Caption = "TagDesc";
            this.coldsBaseL3DataTableTagDesc.ColumnName = "TagDesc";
            this.coldsBaseL3DataTableTagDesc.Namespace = "";
            // 
            // coldsBaseL3DataTablePressure
            // 
            this.coldsBaseL3DataTablePressure.Caption = "Pressure";
            this.coldsBaseL3DataTablePressure.ColumnName = "Pressure";
            this.coldsBaseL3DataTablePressure.DataType = typeof(double);
            this.coldsBaseL3DataTablePressure.Namespace = "";
            // 
            // coldsBaseL3DataTableFlow
            // 
            this.coldsBaseL3DataTableFlow.Caption = "Flow";
            this.coldsBaseL3DataTableFlow.ColumnName = "Flow";
            this.coldsBaseL3DataTableFlow.DataType = typeof(double);
            this.coldsBaseL3DataTableFlow.Namespace = "";
            // 
            // coldsBaseL3DataTableP_Max
            // 
            this.coldsBaseL3DataTableP_Max.Caption = "P_Max";
            this.coldsBaseL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsBaseL3DataTableP_Max.DataType = typeof(double);
            this.coldsBaseL3DataTableP_Max.Namespace = "";
            // 
            // coldsBaseL3DataTableP_Min
            // 
            this.coldsBaseL3DataTableP_Min.Caption = "P_Min";
            this.coldsBaseL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsBaseL3DataTableP_Min.DataType = typeof(double);
            this.coldsBaseL3DataTableP_Min.Namespace = "";
            // 
            // coldsBaseL3DataTableP_High
            // 
            this.coldsBaseL3DataTableP_High.Caption = "P_High";
            this.coldsBaseL3DataTableP_High.ColumnName = "P_High";
            this.coldsBaseL3DataTableP_High.DataType = typeof(double);
            this.coldsBaseL3DataTableP_High.Namespace = "";
            // 
            // coldsBaseL3DataTableP_Low
            // 
            this.coldsBaseL3DataTableP_Low.Caption = "P_Low";
            this.coldsBaseL3DataTableP_Low.ColumnName = "P_Low";
            this.coldsBaseL3DataTableP_Low.DataType = typeof(double);
            this.coldsBaseL3DataTableP_Low.Namespace = "";
            // 
            // coldsBaseL3DataTableF_Max
            // 
            this.coldsBaseL3DataTableF_Max.Caption = "F_Max";
            this.coldsBaseL3DataTableF_Max.ColumnName = "F_Max";
            this.coldsBaseL3DataTableF_Max.DataType = typeof(double);
            this.coldsBaseL3DataTableF_Max.Namespace = "";
            // 
            // coldsBaseL3DataTableF_Min
            // 
            this.coldsBaseL3DataTableF_Min.Caption = "F_Min";
            this.coldsBaseL3DataTableF_Min.ColumnName = "F_Min";
            this.coldsBaseL3DataTableF_Min.DataType = typeof(double);
            this.coldsBaseL3DataTableF_Min.Namespace = "";
            // 
            // coldsBaseL3DataTableF_High
            // 
            this.coldsBaseL3DataTableF_High.Caption = "F_High";
            this.coldsBaseL3DataTableF_High.ColumnName = "F_High";
            this.coldsBaseL3DataTableF_High.DataType = typeof(double);
            this.coldsBaseL3DataTableF_High.Namespace = "";
            // 
            // coldsBaseL3DataTableF_Low
            // 
            this.coldsBaseL3DataTableF_Low.Caption = "F_Low";
            this.coldsBaseL3DataTableF_Low.ColumnName = "F_Low";
            this.coldsBaseL3DataTableF_Low.DataType = typeof(double);
            this.coldsBaseL3DataTableF_Low.Namespace = "";
            // 
            // coldsBaseL3DataTableCatch_Time
            // 
            this.coldsBaseL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsBaseL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsBaseL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableCatch_Time.Namespace = "";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "新添";
            this.btnAdd.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Name = "btnDel";
            this.btnDel.RightToLeftAutoMirrorImage = true;
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "删除";
            this.btnDel.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBase);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(832, 530);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvBase
            // 
            this.dvBase.AllowUserToAddRows = false;
            this.dvBase.AutoGenerateColumns = false;
            this.dvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagNameDataGridViewTextBoxColumn,
            this.tagDescDataGridViewTextBoxColumn,
            this.pMaxDataGridViewTextBoxColumn,
            this.pMinDataGridViewTextBoxColumn,
            this.pHighDataGridViewTextBoxColumn,
            this.pLowDataGridViewTextBoxColumn,
            this.fMaxDataGridViewTextBoxColumn,
            this.fMinDataGridViewTextBoxColumn,
            this.fHighDataGridViewTextBoxColumn,
            this.fLowDataGridViewTextBoxColumn1});
            this.dvBase.DataSource = this.bsBase;
            this.dvBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBase.Location = new System.Drawing.Point(0, 0);
            this.dvBase.Name = "dvBase";
            this.dvBase.RowTemplate.Height = 23;
            this.dvBase.Size = new System.Drawing.Size(832, 530);
            this.dvBase.TabIndex = 0;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.tagNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "介质代码";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDescDataGridViewTextBoxColumn
            // 
            this.tagDescDataGridViewTextBoxColumn.DataPropertyName = "TagDesc";
            this.tagDescDataGridViewTextBoxColumn.HeaderText = "介质名称";
            this.tagDescDataGridViewTextBoxColumn.Name = "tagDescDataGridViewTextBoxColumn";
            this.tagDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagDescDataGridViewTextBoxColumn.Width = 200;
            // 
            // pMaxDataGridViewTextBoxColumn
            // 
            this.pMaxDataGridViewTextBoxColumn.DataPropertyName = "P_Max";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.pMaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pMaxDataGridViewTextBoxColumn.HeaderText = "压力上限值";
            this.pMaxDataGridViewTextBoxColumn.Name = "pMaxDataGridViewTextBoxColumn";
            // 
            // pMinDataGridViewTextBoxColumn
            // 
            this.pMinDataGridViewTextBoxColumn.DataPropertyName = "P_Min";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.pMinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pMinDataGridViewTextBoxColumn.HeaderText = "压力下限值";
            this.pMinDataGridViewTextBoxColumn.Name = "pMinDataGridViewTextBoxColumn";
            // 
            // pHighDataGridViewTextBoxColumn
            // 
            this.pHighDataGridViewTextBoxColumn.DataPropertyName = "P_High";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.pHighDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pHighDataGridViewTextBoxColumn.HeaderText = "压力高限值";
            this.pHighDataGridViewTextBoxColumn.Name = "pHighDataGridViewTextBoxColumn";
            // 
            // pLowDataGridViewTextBoxColumn
            // 
            this.pLowDataGridViewTextBoxColumn.DataPropertyName = "P_Low";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.pLowDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pLowDataGridViewTextBoxColumn.HeaderText = "压力低限值";
            this.pLowDataGridViewTextBoxColumn.Name = "pLowDataGridViewTextBoxColumn";
            // 
            // fMaxDataGridViewTextBoxColumn
            // 
            this.fMaxDataGridViewTextBoxColumn.DataPropertyName = "F_Max";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.fMaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.fMaxDataGridViewTextBoxColumn.HeaderText = "流量上限值";
            this.fMaxDataGridViewTextBoxColumn.Name = "fMaxDataGridViewTextBoxColumn";
            // 
            // fMinDataGridViewTextBoxColumn
            // 
            this.fMinDataGridViewTextBoxColumn.DataPropertyName = "F_Min";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.fMinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.fMinDataGridViewTextBoxColumn.HeaderText = "流量下限值";
            this.fMinDataGridViewTextBoxColumn.Name = "fMinDataGridViewTextBoxColumn";
            // 
            // fHighDataGridViewTextBoxColumn
            // 
            this.fHighDataGridViewTextBoxColumn.DataPropertyName = "F_High";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.fHighDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.fHighDataGridViewTextBoxColumn.HeaderText = "流量高限值";
            this.fHighDataGridViewTextBoxColumn.Name = "fHighDataGridViewTextBoxColumn";
            // 
            // fLowDataGridViewTextBoxColumn1
            // 
            this.fLowDataGridViewTextBoxColumn1.DataPropertyName = "F_Low";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.fLowDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.fLowDataGridViewTextBoxColumn1.HeaderText = "流量低限值";
            this.fLowDataGridViewTextBoxColumn1.Name = "fLowDataGridViewTextBoxColumn1";
            // 
            // ENMediumMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 555);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ENMediumMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "能源介质属性管理";
            this.Text = "能源介质属性管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).EndInit();
            this.bdn1.ResumeLayout(false);
            this.bdn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingNavigator bdn1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBase;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableTagName;
        private System.Data.DataColumn coldsBaseL3DataTableTagCode;
        private System.Data.DataColumn coldsBaseL3DataTableTagDesc;
        private System.Data.DataColumn coldsBaseL3DataTablePressure;
        private System.Data.DataColumn coldsBaseL3DataTableFlow;
        private System.Data.DataColumn coldsBaseL3DataTableP_Max;
        private System.Data.DataColumn coldsBaseL3DataTableP_Min;
        private System.Data.DataColumn coldsBaseL3DataTableP_High;
        private System.Data.DataColumn coldsBaseL3DataTableP_Low;
        private System.Data.DataColumn coldsBaseL3DataTableF_Max;
        private System.Data.DataColumn coldsBaseL3DataTableF_Min;
        private System.Data.DataColumn coldsBaseL3DataTableF_High;
        private System.Data.DataColumn coldsBaseL3DataTableF_Low;
        private System.Data.DataColumn coldsBaseL3DataTableCatch_Time;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLowDataGridViewTextBoxColumn1;
    }
}