namespace DispatchMag
{
    partial class SteelExchangeFrm
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
            this.bsExchange = new System.Windows.Forms.BindingSource(this.components);
            this.dsExchange = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsExchange = new System.Data.DataTable();
            this.coldsExchangeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableName = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsExchangeL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableEx_Time = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableEx_Operator = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableEx_Flag = new System.Data.DataColumn();
            this.coldsExchangeL3DataTableEx_SteelGradeIndex = new System.Data.DataColumn();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmdExchange = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSteelGradeIndexPre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSteelGradePre = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbProtocolPre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbExSteelGradeIndex = new System.Windows.Forms.ComboBox();
            this.bsSteelGradeIndex = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.cmdSteelGradeIndex = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpSteelGrade = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpSteelGradeIndx = new AppSvrHMI.L3CommandParameter();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableProtocol = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProtocolChange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStellGradeChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbHeatID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsExchange
            // 
            this.bsExchange.DataMember = "L3DataTable";
            this.bsExchange.DataSource = this.dsExchange;
            // 
            // dsExchange
            // 
            this.dsExchange.DataSetName = "L3DataSet";
            this.dsExchange.DeleteMethod = null;
            this.dsExchange.InsertMethod = null;
            this.dsExchange.L3DataAdapter = this.Adapter;
            this.dsExchange.LoadEvent = "Click";
            this.dsExchange.LoadTrigger = null;
            this.dsExchange.RefreshValve = 1000;
            this.dsExchange.SourceCommand = null;
            this.dsExchange.SourceCondition = "";
            this.dsExchange.SourceMethod = "";
            this.dsExchange.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsExchange.SourceURI = "";
            this.dsExchange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExchange});
            this.dsExchange.UpdateEvent = "Click";
            this.dsExchange.UpdateMethod = null;
            this.dsExchange.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsExchange
            // 
            this.schemadsExchange.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExchangeL3DataTableGUID,
            this.coldsExchangeL3DataTableName,
            this.coldsExchangeL3DataTableObjectID,
            this.coldsExchangeL3DataTablePreHeatID,
            this.coldsExchangeL3DataTableSteelGradeIndex,
            this.coldsExchangeL3DataTableHeatID,
            this.coldsExchangeL3DataTableApp_UnitID,
            this.coldsExchangeL3DataTableApp_Time,
            this.coldsExchangeL3DataTableApp_Steel_Weight,
            this.coldsExchangeL3DataTableApp_Operator,
            this.coldsExchangeL3DataTableApp_Reason,
            this.coldsExchangeL3DataTableEx_Time,
            this.coldsExchangeL3DataTableEx_Operator,
            this.coldsExchangeL3DataTableEx_Flag,
            this.coldsExchangeL3DataTableEx_SteelGradeIndex});
            this.schemadsExchange.TableName = "L3DataTable";
            // 
            // coldsExchangeL3DataTableGUID
            // 
            this.coldsExchangeL3DataTableGUID.Caption = "GUID";
            this.coldsExchangeL3DataTableGUID.ColumnName = "GUID";
            this.coldsExchangeL3DataTableGUID.Namespace = "";
            // 
            // coldsExchangeL3DataTableName
            // 
            this.coldsExchangeL3DataTableName.Caption = "Name";
            this.coldsExchangeL3DataTableName.ColumnName = "Name";
            this.coldsExchangeL3DataTableName.Namespace = "";
            // 
            // coldsExchangeL3DataTableObjectID
            // 
            this.coldsExchangeL3DataTableObjectID.Caption = "ObjectID";
            this.coldsExchangeL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsExchangeL3DataTableObjectID.Namespace = "";
            // 
            // coldsExchangeL3DataTablePreHeatID
            // 
            this.coldsExchangeL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsExchangeL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsExchangeL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsExchangeL3DataTableSteelGradeIndex
            // 
            this.coldsExchangeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsExchangeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsExchangeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsExchangeL3DataTableHeatID
            // 
            this.coldsExchangeL3DataTableHeatID.Caption = "HeatID";
            this.coldsExchangeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsExchangeL3DataTableHeatID.Namespace = "";
            // 
            // coldsExchangeL3DataTableApp_UnitID
            // 
            this.coldsExchangeL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsExchangeL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsExchangeL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsExchangeL3DataTableApp_Time
            // 
            this.coldsExchangeL3DataTableApp_Time.Caption = "App_Time";
            this.coldsExchangeL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsExchangeL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsExchangeL3DataTableApp_Time.Namespace = "";
            // 
            // coldsExchangeL3DataTableApp_Steel_Weight
            // 
            this.coldsExchangeL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsExchangeL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsExchangeL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsExchangeL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsExchangeL3DataTableApp_Operator
            // 
            this.coldsExchangeL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsExchangeL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsExchangeL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsExchangeL3DataTableApp_Reason
            // 
            this.coldsExchangeL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsExchangeL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsExchangeL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsExchangeL3DataTableEx_Time
            // 
            this.coldsExchangeL3DataTableEx_Time.Caption = "Ex_Time";
            this.coldsExchangeL3DataTableEx_Time.ColumnName = "Ex_Time";
            this.coldsExchangeL3DataTableEx_Time.DataType = typeof(System.DateTime);
            this.coldsExchangeL3DataTableEx_Time.Namespace = "";
            // 
            // coldsExchangeL3DataTableEx_Operator
            // 
            this.coldsExchangeL3DataTableEx_Operator.Caption = "Ex_Operator";
            this.coldsExchangeL3DataTableEx_Operator.ColumnName = "Ex_Operator";
            this.coldsExchangeL3DataTableEx_Operator.Namespace = "";
            // 
            // coldsExchangeL3DataTableEx_Flag
            // 
            this.coldsExchangeL3DataTableEx_Flag.Caption = "Ex_Flag";
            this.coldsExchangeL3DataTableEx_Flag.ColumnName = "Ex_Flag";
            this.coldsExchangeL3DataTableEx_Flag.DataType = typeof(int);
            this.coldsExchangeL3DataTableEx_Flag.Namespace = "";
            // 
            // coldsExchangeL3DataTableEx_SteelGradeIndex
            // 
            this.coldsExchangeL3DataTableEx_SteelGradeIndex.Caption = "Ex_SteelGradeIndex";
            this.coldsExchangeL3DataTableEx_SteelGradeIndex.ColumnName = "Ex_SteelGradeIndex";
            this.coldsExchangeL3DataTableEx_SteelGradeIndex.Namespace = "";
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(281, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmdExchange
            // 
            this.cmdExchange.Adapter = this.Adapter;
            this.cmdExchange.MergeReturnTarget = false;
            this.cmdExchange.Method = "SteelExchange";
            this.cmdExchange.Object = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.cmdExchange.Parameters.Add(this.l3CommandParameter1);
            this.cmdExchange.ReturnTarget = null;
            this.cmdExchange.ReturnTargetProperty = null;
            this.cmdExchange.Trigger = null;
            this.cmdExchange.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsExchange;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'SteelExchange\'";
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
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
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
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 233);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 53);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 233);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 176);
            this.tableLayoutPanel1.TabIndex = 154;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSteelGradeIndexPre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbSteelGradePre);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.lbProtocolPre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 170);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前信息";
            // 
            // lbSteelGradeIndexPre
            // 
            this.lbSteelGradeIndexPre.AutoSize = true;
            this.lbSteelGradeIndexPre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExchange, "SteelGradeIndex", true));
            this.lbSteelGradeIndexPre.Location = new System.Drawing.Point(78, 48);
            this.lbSteelGradeIndexPre.Name = "lbSteelGradeIndexPre";
            this.lbSteelGradeIndexPre.Size = new System.Drawing.Size(83, 12);
            this.lbSteelGradeIndexPre.TabIndex = 3;
            this.lbSteelGradeIndexPre.Text = "XXXXXXXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "炼钢记号:";
            // 
            // lbSteelGradePre
            // 
            this.lbSteelGradePre.AutoSize = true;
            this.lbSteelGradePre.Location = new System.Drawing.Point(78, 81);
            this.lbSteelGradePre.Name = "lbSteelGradePre";
            this.lbSteelGradePre.Size = new System.Drawing.Size(83, 12);
            this.lbSteelGradePre.TabIndex = 3;
            this.lbSteelGradePre.Text = "XXXXXXXXXXXXX";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(37, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 130;
            this.label28.Text = "钢种:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(25, 114);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 12);
            this.label31.TabIndex = 133;
            this.label31.Text = "协议号:";
            // 
            // lbProtocolPre
            // 
            this.lbProtocolPre.AutoSize = true;
            this.lbProtocolPre.Location = new System.Drawing.Point(78, 114);
            this.lbProtocolPre.Name = "lbProtocolPre";
            this.lbProtocolPre.Size = new System.Drawing.Size(83, 12);
            this.lbProtocolPre.TabIndex = 134;
            this.lbProtocolPre.Text = "XXXXXXXXXXXXX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbExSteelGradeIndex);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbProtocolChange);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbStellGradeChange);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(215, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 170);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "改判信息";
            // 
            // cmbExSteelGradeIndex
            // 
            this.cmbExSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsExchange, "Ex_SteelGradeIndex", true));
            this.cmbExSteelGradeIndex.DataSource = this.bsSteelGradeIndex;
            this.cmbExSteelGradeIndex.DisplayMember = "Final_SteelGradeIndex";
            this.cmbExSteelGradeIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExSteelGradeIndex.FormattingEnabled = true;
            this.cmbExSteelGradeIndex.Location = new System.Drawing.Point(78, 44);
            this.cmbExSteelGradeIndex.Name = "cmbExSteelGradeIndex";
            this.cmbExSteelGradeIndex.Size = new System.Drawing.Size(110, 20);
            this.cmbExSteelGradeIndex.TabIndex = 5;
            this.cmbExSteelGradeIndex.ValueMember = "Final_SteelGradeIndex";
            this.cmbExSteelGradeIndex.SelectedIndexChanged += new System.EventHandler(this.cmbExSteelGradeIndex_SelectedIndexChanged);
            // 
            // bsSteelGradeIndex
            // 
            this.bsSteelGradeIndex.DataMember = "L3DataTable";
            this.bsSteelGradeIndex.DataSource = this.dsSteelGradeIndex;
            this.bsSteelGradeIndex.Filter = "Final_SteelGradeIndex <> \'YY000000\'";
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = "";
            this.dsSteelGradeIndex.InsertMethod = "";
            this.dsSteelGradeIndex.L3DataAdapter = null;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = this.cmdSteelGradeIndex;
            this.dsSteelGradeIndex.SourceCondition = null;
            this.dsSteelGradeIndex.SourceMethod = "GetJudgedSteelGrade";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQuality_Mag\\Quality_Mag";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = "";
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // cmdSteelGradeIndex
            // 
            this.cmdSteelGradeIndex.Adapter = null;
            this.cmdSteelGradeIndex.MergeReturnTarget = false;
            this.cmdSteelGradeIndex.Method = null;
            this.cmdSteelGradeIndex.Object = null;
            this.cmdSteelGradeIndex.Parameters.Add(this.l3cmdpSteelGrade);
            this.cmdSteelGradeIndex.Parameters.Add(this.l3cmdpSteelGradeIndx);
            this.cmdSteelGradeIndex.ReturnTarget = null;
            this.cmdSteelGradeIndex.ReturnTargetProperty = null;
            this.cmdSteelGradeIndex.Trigger = null;
            this.cmdSteelGradeIndex.TriggerEvent = "Click";
            // 
            // l3cmdpSteelGrade
            // 
            this.l3cmdpSteelGrade.AcceptAfterExecuted = false;
            this.l3cmdpSteelGrade.ConstantValue = null;
            this.l3cmdpSteelGrade.MergeTarget = false;
            this.l3cmdpSteelGrade.SourceFilter = null;
            this.l3cmdpSteelGrade.SourceObject = null;
            this.l3cmdpSteelGrade.SourceProperty = null;
            this.l3cmdpSteelGrade.TargetObject = null;
            this.l3cmdpSteelGrade.TargetProperty = null;
            // 
            // l3cmdpSteelGradeIndx
            // 
            this.l3cmdpSteelGradeIndx.AcceptAfterExecuted = false;
            this.l3cmdpSteelGradeIndx.ConstantValue = null;
            this.l3cmdpSteelGradeIndx.MergeTarget = false;
            this.l3cmdpSteelGradeIndx.SourceFilter = null;
            this.l3cmdpSteelGradeIndx.SourceObject = null;
            this.l3cmdpSteelGradeIndx.SourceProperty = null;
            this.l3cmdpSteelGradeIndx.TargetObject = null;
            this.l3cmdpSteelGradeIndx.TargetProperty = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex,
            this.coldsSteelGradeIndexL3DataTableSteelGrade,
            this.coldsSteelGradeIndexL3DataTableProtocol});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex.Caption = "Final_SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex.ColumnName = "Final_SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex.DefaultValue = "";
            this.coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGrade
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.DefaultValue = "";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableProtocol
            // 
            this.coldsSteelGradeIndexL3DataTableProtocol.Caption = "Protocol";
            this.coldsSteelGradeIndexL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsSteelGradeIndexL3DataTableProtocol.DefaultValue = "";
            this.coldsSteelGradeIndexL3DataTableProtocol.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "炼钢记号:";
            // 
            // lbProtocolChange
            // 
            this.lbProtocolChange.AutoSize = true;
            this.lbProtocolChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSteelGradeIndex, "Protocol", true));
            this.lbProtocolChange.Location = new System.Drawing.Point(78, 114);
            this.lbProtocolChange.Name = "lbProtocolChange";
            this.lbProtocolChange.Size = new System.Drawing.Size(83, 12);
            this.lbProtocolChange.TabIndex = 150;
            this.lbProtocolChange.Text = "XXXXXXXXXXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 147;
            this.label7.Text = "钢种:";
            // 
            // lbStellGradeChange
            // 
            this.lbStellGradeChange.AutoSize = true;
            this.lbStellGradeChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSteelGradeIndex, "SteelGrade", true));
            this.lbStellGradeChange.Location = new System.Drawing.Point(78, 81);
            this.lbStellGradeChange.Name = "lbStellGradeChange";
            this.lbStellGradeChange.Size = new System.Drawing.Size(83, 12);
            this.lbStellGradeChange.TabIndex = 146;
            this.lbStellGradeChange.Text = "XXXXXXXXXXXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 149;
            this.label5.Text = "协议号:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbHeatID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 24);
            this.panel3.TabIndex = 151;
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsExchange, "HeatID", true));
            this.lbHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeatID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHeatID.Location = new System.Drawing.Point(96, 6);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(96, 12);
            this.lbHeatID.TabIndex = 1;
            this.lbHeatID.Text = "XXXXXXXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "炉号:";
            // 
            // SteelExchangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 286);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteelExchangeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "改钢";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelExchangeFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsExchange;
        private AppSvrHMI.L3DataSet dsExchange;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Data.DataTable schemadsExchange;
        private System.Data.DataColumn coldsExchangeL3DataTableGUID;
        private System.Data.DataColumn coldsExchangeL3DataTableName;
        private System.Data.DataColumn coldsExchangeL3DataTableObjectID;
        private System.Data.DataColumn coldsExchangeL3DataTablePreHeatID;
        private System.Data.DataColumn coldsExchangeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsExchangeL3DataTableHeatID;
        private System.Data.DataColumn coldsExchangeL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsExchangeL3DataTableApp_Time;
        private System.Data.DataColumn coldsExchangeL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsExchangeL3DataTableApp_Operator;
        private System.Data.DataColumn coldsExchangeL3DataTableApp_Reason;
        private System.Data.DataColumn coldsExchangeL3DataTableEx_Time;
        private System.Data.DataColumn coldsExchangeL3DataTableEx_Operator;
        private System.Data.DataColumn coldsExchangeL3DataTableEx_Flag;
        private System.Data.DataColumn coldsExchangeL3DataTableEx_SteelGradeIndex;
        private AppSvrHMI.L3Command cmdExchange;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbExSteelGradeIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSteelGradeIndexPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHeatID;
        private System.Windows.Forms.Label lbSteelGradePre;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbProtocolPre;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbProtocolChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStellGradeChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bsSteelGradeIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private AppSvrHMI.L3Command cmdSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableFinal_SteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableProtocol;
        private AppSvrHMI.L3CommandParameter l3cmdpSteelGrade;
        private AppSvrHMI.L3CommandParameter l3cmdpSteelGradeIndx;
    }
}