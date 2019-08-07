namespace DispatchMag
{
    partial class SteelDivFrm
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
            this.bsDiv = new System.Windows.Forms.BindingSource(this.components);
            this.dsDiv = new AppSvrHMI.L3DataSet();
            this.schemadsDiv = new System.Data.DataTable();
            this.coldsDivL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDivL3DataTableName = new System.Data.DataColumn();
            this.coldsDivL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsDivL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsDivL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsDivL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsDivL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsDivL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsDivL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsDivL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsDivL3DataTableDiv_UnitID = new System.Data.DataColumn();
            this.coldsDivL3DataTableDiv_Time = new System.Data.DataColumn();
            this.coldsDivL3DataTableDiv_Operator = new System.Data.DataColumn();
            this.coldsDivL3DataTableDiv_Flag = new System.Data.DataColumn();
            this.coldsDivL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsDivL3DataTableBack_UnitID_Type = new System.Data.DataColumn();
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
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsAppUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsAppUnitID = new System.Data.DataTable();
            this.coldsAppUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAppUnitIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmdDiv = new AppSvrHMI.L3Command(this.components);
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
            this.cmbProcessID = new System.Windows.Forms.ComboBox();
            this.cmbCCMID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHeatID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAppUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsDiv
            // 
            this.bsDiv.DataMember = "L3DataTable";
            this.bsDiv.DataSource = this.dsDiv;
            // 
            // dsDiv
            // 
            this.dsDiv.DataSetName = "L3DataSet";
            this.dsDiv.DeleteMethod = null;
            this.dsDiv.InsertMethod = null;
            this.dsDiv.L3DataAdapter = null;
            this.dsDiv.LoadEvent = "Click";
            this.dsDiv.LoadTrigger = null;
            this.dsDiv.RefreshValve = 1000;
            this.dsDiv.SourceCommand = null;
            this.dsDiv.SourceCondition = "";
            this.dsDiv.SourceMethod = "";
            this.dsDiv.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsDiv.SourceURI = "";
            this.dsDiv.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDiv});
            this.dsDiv.UpdateEvent = "Click";
            this.dsDiv.UpdateMethod = null;
            this.dsDiv.UpdateTrigger = null;
            // 
            // schemadsDiv
            // 
            this.schemadsDiv.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDivL3DataTableGUID,
            this.coldsDivL3DataTableName,
            this.coldsDivL3DataTableObjectID,
            this.coldsDivL3DataTablePreHeatID,
            this.coldsDivL3DataTableSteelGradeIndex,
            this.coldsDivL3DataTableHeatID,
            this.coldsDivL3DataTableApp_Time,
            this.coldsDivL3DataTableApp_Steel_Weight,
            this.coldsDivL3DataTableApp_Operator,
            this.coldsDivL3DataTableApp_UnitID,
            this.coldsDivL3DataTableDiv_UnitID,
            this.coldsDivL3DataTableDiv_Time,
            this.coldsDivL3DataTableDiv_Operator,
            this.coldsDivL3DataTableDiv_Flag,
            this.coldsDivL3DataTableApp_Reason,
            this.coldsDivL3DataTableBack_UnitID_Type});
            this.schemadsDiv.TableName = "L3DataTable";
            // 
            // coldsDivL3DataTableGUID
            // 
            this.coldsDivL3DataTableGUID.Caption = "GUID";
            this.coldsDivL3DataTableGUID.ColumnName = "GUID";
            this.coldsDivL3DataTableGUID.Namespace = "";
            // 
            // coldsDivL3DataTableName
            // 
            this.coldsDivL3DataTableName.Caption = "Name";
            this.coldsDivL3DataTableName.ColumnName = "Name";
            this.coldsDivL3DataTableName.Namespace = "";
            // 
            // coldsDivL3DataTableObjectID
            // 
            this.coldsDivL3DataTableObjectID.Caption = "ObjectID";
            this.coldsDivL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsDivL3DataTableObjectID.Namespace = "";
            // 
            // coldsDivL3DataTablePreHeatID
            // 
            this.coldsDivL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsDivL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsDivL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsDivL3DataTableSteelGradeIndex
            // 
            this.coldsDivL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsDivL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsDivL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsDivL3DataTableHeatID
            // 
            this.coldsDivL3DataTableHeatID.Caption = "HeatID";
            this.coldsDivL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsDivL3DataTableHeatID.Namespace = "";
            // 
            // coldsDivL3DataTableApp_Time
            // 
            this.coldsDivL3DataTableApp_Time.Caption = "App_Time";
            this.coldsDivL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsDivL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsDivL3DataTableApp_Time.Namespace = "";
            // 
            // coldsDivL3DataTableApp_Steel_Weight
            // 
            this.coldsDivL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsDivL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsDivL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsDivL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsDivL3DataTableApp_Operator
            // 
            this.coldsDivL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsDivL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsDivL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsDivL3DataTableApp_UnitID
            // 
            this.coldsDivL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsDivL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsDivL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsDivL3DataTableDiv_UnitID
            // 
            this.coldsDivL3DataTableDiv_UnitID.Caption = "Div_UnitID";
            this.coldsDivL3DataTableDiv_UnitID.ColumnName = "Div_UnitID";
            this.coldsDivL3DataTableDiv_UnitID.Namespace = "";
            // 
            // coldsDivL3DataTableDiv_Time
            // 
            this.coldsDivL3DataTableDiv_Time.Caption = "Div_Time";
            this.coldsDivL3DataTableDiv_Time.ColumnName = "Div_Time";
            this.coldsDivL3DataTableDiv_Time.DataType = typeof(System.DateTime);
            this.coldsDivL3DataTableDiv_Time.Namespace = "";
            // 
            // coldsDivL3DataTableDiv_Operator
            // 
            this.coldsDivL3DataTableDiv_Operator.Caption = "Div_Operator";
            this.coldsDivL3DataTableDiv_Operator.ColumnName = "Div_Operator";
            this.coldsDivL3DataTableDiv_Operator.Namespace = "";
            // 
            // coldsDivL3DataTableDiv_Flag
            // 
            this.coldsDivL3DataTableDiv_Flag.Caption = "Div_Flag";
            this.coldsDivL3DataTableDiv_Flag.ColumnName = "Div_Flag";
            this.coldsDivL3DataTableDiv_Flag.DataType = typeof(int);
            this.coldsDivL3DataTableDiv_Flag.Namespace = "";
            // 
            // coldsDivL3DataTableApp_Reason
            // 
            this.coldsDivL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsDivL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsDivL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsDivL3DataTableBack_UnitID_Type
            // 
            this.coldsDivL3DataTableBack_UnitID_Type.Caption = "Back_UnitID_Type";
            this.coldsDivL3DataTableBack_UnitID_Type.ColumnName = "Back_UnitID_Type";
            this.coldsDivL3DataTableBack_UnitID_Type.DataType = typeof(short);
            this.coldsDivL3DataTableBack_UnitID_Type.Namespace = "";
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
            // dsUnitType
            // 
            this.dsUnitType.DataSetName = "L3DataSet";
            this.dsUnitType.DeleteMethod = null;
            this.dsUnitType.InsertMethod = null;
            this.dsUnitType.L3DataAdapter = this.Adapter;
            this.dsUnitType.LoadEvent = "Click";
            this.dsUnitType.LoadTrigger = null;
            this.dsUnitType.RefreshValve = 1000;
            this.dsUnitType.SourceCommand = null;
            this.dsUnitType.SourceCondition = "CODE_GROUP = \'UnitType\' and CODE_VAL_LONG>2 and CODE_VAL_LONG<6";
            this.dsUnitType.SourceMethod = "";
            this.dsUnitType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitType.SubscribeTarget = null;
            this.dsUnitType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsUnitType.UpdateEvent = "Click";
            this.dsUnitType.UpdateMethod = null;
            this.dsUnitType.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode_Des,
            this.coll3DataSet1L3DataTableCode_Val_Long});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Val_Long
            // 
            this.coll3DataSet1L3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coll3DataSet1L3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coll3DataSet1L3DataTableCode_Val_Long.DataType = typeof(int);
            this.coll3DataSet1L3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsAppUnitID
            // 
            this.dsAppUnitID.DataSetName = "L3DataSet";
            this.dsAppUnitID.DeleteMethod = null;
            this.dsAppUnitID.InsertMethod = null;
            this.dsAppUnitID.L3DataAdapter = this.Adapter;
            this.dsAppUnitID.LoadEvent = "Click";
            this.dsAppUnitID.LoadTrigger = null;
            this.dsAppUnitID.RefreshValve = 1000;
            this.dsAppUnitID.SourceCommand = null;
            this.dsAppUnitID.SourceCondition = "CODE_GROUP = \'UnitType\'";
            this.dsAppUnitID.SourceMethod = "";
            this.dsAppUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAppUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAppUnitID.SubscribeTarget = null;
            this.dsAppUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAppUnitID});
            this.dsAppUnitID.UpdateEvent = "Click";
            this.dsAppUnitID.UpdateMethod = null;
            this.dsAppUnitID.UpdateTrigger = null;
            // 
            // schemadsAppUnitID
            // 
            this.schemadsAppUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAppUnitIDL3DataTableCode_Des,
            this.coldsAppUnitIDL3DataTableCode_Val_Long});
            this.schemadsAppUnitID.TableName = "L3DataTable";
            // 
            // coldsAppUnitIDL3DataTableCode_Des
            // 
            this.coldsAppUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAppUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAppUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAppUnitIDL3DataTableCode_Val_Long
            // 
            this.coldsAppUnitIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsAppUnitIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsAppUnitIDL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsAppUnitIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(167, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Adapter = this.Adapter;
            this.cmdDiv.MergeReturnTarget = false;
            this.cmdDiv.Method = "SteelDiv";
            this.cmdDiv.Object = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.cmdDiv.Parameters.Add(this.l3CommandParameter1);
            this.cmdDiv.ReturnTarget = null;
            this.cmdDiv.ReturnTargetProperty = null;
            this.cmdDiv.Trigger = null;
            this.cmdDiv.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsDiv;
            this.l3CommandParameter1.SourceProperty = null;
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
            this.dsError.SourceCondition = "OWNER = \'SteelDiv\'";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 57);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 159);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbProcessID);
            this.tabPage1.Controls.Add(this.cmbCCMID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lbHeatID);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbProcessID
            // 
            this.cmbProcessID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDiv, "Back_UnitID_Type", true));
            this.cmbProcessID.DataSource = this.dsUnitType;
            this.cmbProcessID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbProcessID.FormattingEnabled = true;
            this.cmbProcessID.Location = new System.Drawing.Point(123, 74);
            this.cmbProcessID.Name = "cmbProcessID";
            this.cmbProcessID.Size = new System.Drawing.Size(117, 20);
            this.cmbProcessID.TabIndex = 5;
            this.cmbProcessID.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // cmbCCMID
            // 
            this.cmbCCMID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDiv, "App_UnitID", true));
            this.cmbCCMID.DataSource = this.dsAppUnitID;
            this.cmbCCMID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCCMID.Enabled = false;
            this.cmbCCMID.FormattingEnabled = true;
            this.cmbCCMID.Location = new System.Drawing.Point(123, 44);
            this.cmbCCMID.Name = "cmbCCMID";
            this.cmbCCMID.Size = new System.Drawing.Size(117, 20);
            this.cmbCCMID.TabIndex = 5;
            this.cmbCCMID.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "炉号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "铸机:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "工序:";
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDiv, "HeatID", true));
            this.lbHeatID.Location = new System.Drawing.Point(123, 21);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(35, 12);
            this.lbHeatID.TabIndex = 1;
            this.lbHeatID.Text = "XXXXX";
            // 
            // SteelDivFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 216);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteelDivFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉次分割";
            ((System.ComponentModel.ISupportInitialize)(this.bsDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAppUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDiv;
        private AppSvrHMI.L3DataSet dsDiv;
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
        private System.Data.DataTable schemadsDiv;
        private System.Data.DataColumn coldsDivL3DataTableGUID;
        private System.Data.DataColumn coldsDivL3DataTableName;
        private System.Data.DataColumn coldsDivL3DataTableObjectID;
        private System.Data.DataColumn coldsDivL3DataTablePreHeatID;
        private System.Data.DataColumn coldsDivL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsDivL3DataTableHeatID;
        private System.Data.DataColumn coldsDivL3DataTableApp_Time;
        private System.Data.DataColumn coldsDivL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsDivL3DataTableApp_Operator;
        private System.Data.DataColumn coldsDivL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsDivL3DataTableDiv_UnitID;
        private System.Data.DataColumn coldsDivL3DataTableDiv_Time;
        private System.Data.DataColumn coldsDivL3DataTableDiv_Operator;
        private System.Data.DataColumn coldsDivL3DataTableDiv_Flag;
        private System.Data.DataColumn coldsDivL3DataTableApp_Reason;
        private AppSvrHMI.L3DataSet dsAppUnitID;
        private AppSvrHMI.L3DataSet dsUnitType;
        private System.Data.DataTable schemadsAppUnitID;
        private System.Data.DataColumn coldsAppUnitIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsAppUnitIDL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsDivL3DataTableBack_UnitID_Type;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Val_Long;
        private AppSvrHMI.L3Command cmdDiv;
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
        private System.Windows.Forms.ComboBox cmbProcessID;
        private System.Windows.Forms.ComboBox cmbCCMID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHeatID;
    }
}