namespace DispatchMag
{
    partial class SteelTurnFrm
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
            this.bsTurn = new System.Windows.Forms.BindingSource(this.components);
            this.dsTurn = new AppSvrHMI.L3DataSet();
            this.schemadsTurn = new System.Data.DataTable();
            this.coldsTurnL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTurnL3DataTableName = new System.Data.DataColumn();
            this.coldsTurnL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsTurnL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsTurnL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsTurnL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTurnL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsTurnL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsTurnL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsTurnL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsTurnL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsTurnL3DataTableTurn_Time = new System.Data.DataColumn();
            this.coldsTurnL3DataTableTurn_Operator = new System.Data.DataColumn();
            this.coldsTurnL3DataTableTurn_Flag = new System.Data.DataColumn();
            this.coldsTurnL3DataTableAll_Turn_Flag = new System.Data.DataColumn();
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
            this.lbAppSteelWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHeatID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtnAllTurnFlag1 = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmdTurn = new AppSvrHMI.L3Command(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTurn
            // 
            this.bsTurn.DataMember = "L3DataTable";
            this.bsTurn.DataSource = this.dsTurn;
            // 
            // dsTurn
            // 
            this.dsTurn.DataSetName = "L3DataSet";
            this.dsTurn.DeleteMethod = null;
            this.dsTurn.InsertMethod = null;
            this.dsTurn.L3DataAdapter = null;
            this.dsTurn.LoadEvent = "Click";
            this.dsTurn.LoadTrigger = null;
            this.dsTurn.RefreshValve = 1000;
            this.dsTurn.SourceCommand = null;
            this.dsTurn.SourceCondition = "";
            this.dsTurn.SourceMethod = "";
            this.dsTurn.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTurn.SourceURI = "";
            this.dsTurn.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTurn});
            this.dsTurn.UpdateEvent = "Click";
            this.dsTurn.UpdateMethod = null;
            this.dsTurn.UpdateTrigger = null;
            // 
            // schemadsTurn
            // 
            this.schemadsTurn.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTurnL3DataTableGUID,
            this.coldsTurnL3DataTableName,
            this.coldsTurnL3DataTableObjectID,
            this.coldsTurnL3DataTablePreHeatID,
            this.coldsTurnL3DataTableSteelGradeIndex,
            this.coldsTurnL3DataTableHeatID,
            this.coldsTurnL3DataTableApp_Time,
            this.coldsTurnL3DataTableApp_UnitID,
            this.coldsTurnL3DataTableApp_Steel_Weight,
            this.coldsTurnL3DataTableApp_Operator,
            this.coldsTurnL3DataTableApp_Reason,
            this.coldsTurnL3DataTableTurn_Time,
            this.coldsTurnL3DataTableTurn_Operator,
            this.coldsTurnL3DataTableTurn_Flag,
            this.coldsTurnL3DataTableAll_Turn_Flag});
            this.schemadsTurn.TableName = "L3DataTable";
            // 
            // coldsTurnL3DataTableGUID
            // 
            this.coldsTurnL3DataTableGUID.Caption = "GUID";
            this.coldsTurnL3DataTableGUID.ColumnName = "GUID";
            this.coldsTurnL3DataTableGUID.Namespace = "";
            // 
            // coldsTurnL3DataTableName
            // 
            this.coldsTurnL3DataTableName.Caption = "Name";
            this.coldsTurnL3DataTableName.ColumnName = "Name";
            this.coldsTurnL3DataTableName.Namespace = "";
            // 
            // coldsTurnL3DataTableObjectID
            // 
            this.coldsTurnL3DataTableObjectID.Caption = "ObjectID";
            this.coldsTurnL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsTurnL3DataTableObjectID.Namespace = "";
            // 
            // coldsTurnL3DataTablePreHeatID
            // 
            this.coldsTurnL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsTurnL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsTurnL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsTurnL3DataTableSteelGradeIndex
            // 
            this.coldsTurnL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsTurnL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsTurnL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsTurnL3DataTableHeatID
            // 
            this.coldsTurnL3DataTableHeatID.Caption = "HeatID";
            this.coldsTurnL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTurnL3DataTableHeatID.Namespace = "";
            // 
            // coldsTurnL3DataTableApp_Time
            // 
            this.coldsTurnL3DataTableApp_Time.Caption = "App_Time";
            this.coldsTurnL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsTurnL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsTurnL3DataTableApp_Time.Namespace = "";
            // 
            // coldsTurnL3DataTableApp_UnitID
            // 
            this.coldsTurnL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsTurnL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsTurnL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsTurnL3DataTableApp_Steel_Weight
            // 
            this.coldsTurnL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsTurnL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsTurnL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsTurnL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsTurnL3DataTableApp_Operator
            // 
            this.coldsTurnL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsTurnL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsTurnL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsTurnL3DataTableApp_Reason
            // 
            this.coldsTurnL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsTurnL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsTurnL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsTurnL3DataTableTurn_Time
            // 
            this.coldsTurnL3DataTableTurn_Time.Caption = "Turn_Time";
            this.coldsTurnL3DataTableTurn_Time.ColumnName = "Turn_Time";
            this.coldsTurnL3DataTableTurn_Time.DataType = typeof(System.DateTime);
            this.coldsTurnL3DataTableTurn_Time.Namespace = "";
            // 
            // coldsTurnL3DataTableTurn_Operator
            // 
            this.coldsTurnL3DataTableTurn_Operator.Caption = "Turn_Operator";
            this.coldsTurnL3DataTableTurn_Operator.ColumnName = "Turn_Operator";
            this.coldsTurnL3DataTableTurn_Operator.Namespace = "";
            // 
            // coldsTurnL3DataTableTurn_Flag
            // 
            this.coldsTurnL3DataTableTurn_Flag.Caption = "Turn_Flag";
            this.coldsTurnL3DataTableTurn_Flag.ColumnName = "Turn_Flag";
            this.coldsTurnL3DataTableTurn_Flag.DataType = typeof(int);
            this.coldsTurnL3DataTableTurn_Flag.Namespace = "";
            // 
            // coldsTurnL3DataTableAll_Turn_Flag
            // 
            this.coldsTurnL3DataTableAll_Turn_Flag.Caption = "All_Turn_Flag";
            this.coldsTurnL3DataTableAll_Turn_Flag.ColumnName = "All_Turn_Flag";
            this.coldsTurnL3DataTableAll_Turn_Flag.DataType = typeof(int);
            this.coldsTurnL3DataTableAll_Turn_Flag.Namespace = "";
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
            // lbAppSteelWeight
            // 
            this.lbAppSteelWeight.AutoSize = true;
            this.lbAppSteelWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTurn, "App_Steel_Weight", true));
            this.lbAppSteelWeight.Location = new System.Drawing.Point(160, 52);
            this.lbAppSteelWeight.Name = "lbAppSteelWeight";
            this.lbAppSteelWeight.Size = new System.Drawing.Size(83, 12);
            this.lbAppSteelWeight.TabIndex = 3;
            this.lbAppSteelWeight.Text = "XXXXXXXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "炉号:";
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTurn, "HeatID", true));
            this.lbHeatID.Location = new System.Drawing.Point(160, 19);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(35, 12);
            this.lbHeatID.TabIndex = 1;
            this.lbHeatID.Text = "XXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "回炉钢水量:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 146);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rbtnAllTurnFlag1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbAppSteelWeight);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lbHeatID);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtnAllTurnFlag1
            // 
            this.rbtnAllTurnFlag1.AutoSize = true;
            this.rbtnAllTurnFlag1.Checked = true;
            this.rbtnAllTurnFlag1.Location = new System.Drawing.Point(118, 86);
            this.rbtnAllTurnFlag1.Name = "rbtnAllTurnFlag1";
            this.rbtnAllTurnFlag1.Size = new System.Drawing.Size(59, 16);
            this.rbtnAllTurnFlag1.TabIndex = 5;
            this.rbtnAllTurnFlag1.TabStop = true;
            this.rbtnAllTurnFlag1.Text = "全回炉";
            this.rbtnAllTurnFlag1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(139, 152);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmdTurn
            // 
            this.cmdTurn.Adapter = this.Adapter;
            this.cmdTurn.MergeReturnTarget = false;
            this.cmdTurn.Method = "SteelTurn";
            this.cmdTurn.Object = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.cmdTurn.Parameters.Add(this.l3CommandParameter1);
            this.cmdTurn.ReturnTarget = null;
            this.cmdTurn.ReturnTargetProperty = null;
            this.cmdTurn.Trigger = null;
            this.cmdTurn.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsTurn;
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
            this.dsError.SourceCondition = "OWNER = \'SteelTurn\'";
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
            // SteelTurnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteelTurnFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢水回炉";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelTurnFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTurn;
        private AppSvrHMI.L3DataSet dsTurn;
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
        private System.Windows.Forms.Label lbAppSteelWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHeatID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtnAllTurnFlag1;
        private System.Data.DataTable schemadsTurn;
        private System.Data.DataColumn coldsTurnL3DataTableGUID;
        private System.Data.DataColumn coldsTurnL3DataTableName;
        private System.Data.DataColumn coldsTurnL3DataTableObjectID;
        private System.Data.DataColumn coldsTurnL3DataTablePreHeatID;
        private System.Data.DataColumn coldsTurnL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsTurnL3DataTableHeatID;
        private System.Data.DataColumn coldsTurnL3DataTableApp_Time;
        private System.Data.DataColumn coldsTurnL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsTurnL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsTurnL3DataTableApp_Operator;
        private System.Data.DataColumn coldsTurnL3DataTableApp_Reason;
        private System.Data.DataColumn coldsTurnL3DataTableTurn_Time;
        private System.Data.DataColumn coldsTurnL3DataTableTurn_Operator;
        private System.Data.DataColumn coldsTurnL3DataTableTurn_Flag;
        private System.Data.DataColumn coldsTurnL3DataTableAll_Turn_Flag;
        private AppSvrHMI.L3Command cmdTurn;
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
    }
}