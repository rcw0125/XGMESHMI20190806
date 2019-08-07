namespace EquipMag.LadleMag
{
    partial class LadleFireShowFrm
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Type = new System.Data.DataColumn();
            this.coldsMainL3DataTableRoaster_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableStart_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_One_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_One_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Two_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Two_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Three_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Three_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Four_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSet_Four_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableEnd_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSuspend_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSuspend_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbNoteType = new PxDataValid.PxComboBox();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbFireType = new PxDataValid.PxComboBox();
            this.dsLadleFireType = new AppSvrHMI.L3DataSet();
            this.schemadsLadleFireType = new System.Data.DataTable();
            this.coldsLadleFireTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleFireTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbRoasterID = new PxDataValid.PxComboBox();
            this.dsLadleFireEqu = new AppSvrHMI.L3DataSet();
            this.schemadsLadleFireEqu = new System.Data.DataTable();
            this.coldsLadleFireEquL3DataTableCode = new System.Data.DataColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dtSuspendTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtSetFourTime = new System.Windows.Forms.DateTimePicker();
            this.txtSuspendOperator = new PxDataValid.PxTextBox();
            this.txtEndOperator = new PxDataValid.PxTextBox();
            this.txtSetFourOperator = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dtSetTwoTime = new System.Windows.Forms.DateTimePicker();
            this.dtSetThreeTime = new System.Windows.Forms.DateTimePicker();
            this.dtSetOneTime = new System.Windows.Forms.DateTimePicker();
            this.txtSetTwoOperator = new PxDataValid.PxTextBox();
            this.txtSetThreeOperator = new PxDataValid.PxTextBox();
            this.txtSetOneOperator = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.txtStartOperator = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coldsMainL3DataTableFireNote = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireEqu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireEqu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            this.SuspendLayout();
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableInput_Time,
            this.coldsMainL3DataTableFire_Type,
            this.coldsMainL3DataTableRoaster_ID,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableStart_Time,
            this.coldsMainL3DataTableStart_Operator,
            this.coldsMainL3DataTableSet_One_Time,
            this.coldsMainL3DataTableSet_One_Operator,
            this.coldsMainL3DataTableSet_Two_Time,
            this.coldsMainL3DataTableSet_Two_Operator,
            this.coldsMainL3DataTableSet_Three_Time,
            this.coldsMainL3DataTableSet_Three_Operator,
            this.coldsMainL3DataTableSet_Four_Time,
            this.coldsMainL3DataTableSet_Four_Operator,
            this.coldsMainL3DataTableEnd_Time,
            this.coldsMainL3DataTableEnd_Operator,
            this.coldsMainL3DataTableSuspend_Time,
            this.coldsMainL3DataTableSuspend_Operator,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableInput_Time
            // 
            this.coldsMainL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsMainL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsMainL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableInput_Time.Namespace = "";
            // 
            // coldsMainL3DataTableFire_Type
            // 
            this.coldsMainL3DataTableFire_Type.Caption = "Fire_Type";
            this.coldsMainL3DataTableFire_Type.ColumnName = "Fire_Type";
            this.coldsMainL3DataTableFire_Type.Namespace = "";
            // 
            // coldsMainL3DataTableRoaster_ID
            // 
            this.coldsMainL3DataTableRoaster_ID.Caption = "Roaster_ID";
            this.coldsMainL3DataTableRoaster_ID.ColumnName = "Roaster_ID";
            this.coldsMainL3DataTableRoaster_ID.Namespace = "";
            // 
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableStart_Time
            // 
            this.coldsMainL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsMainL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsMainL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableStart_Time.Namespace = "";
            // 
            // coldsMainL3DataTableStart_Operator
            // 
            this.coldsMainL3DataTableStart_Operator.Caption = "Start_Operator";
            this.coldsMainL3DataTableStart_Operator.ColumnName = "Start_Operator";
            this.coldsMainL3DataTableStart_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableSet_One_Time
            // 
            this.coldsMainL3DataTableSet_One_Time.Caption = "Set_One_Time";
            this.coldsMainL3DataTableSet_One_Time.ColumnName = "Set_One_Time";
            this.coldsMainL3DataTableSet_One_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSet_One_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSet_One_Operator
            // 
            this.coldsMainL3DataTableSet_One_Operator.Caption = "Set_One_Operator";
            this.coldsMainL3DataTableSet_One_Operator.ColumnName = "Set_One_Operator";
            this.coldsMainL3DataTableSet_One_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Two_Time
            // 
            this.coldsMainL3DataTableSet_Two_Time.Caption = "Set_Two_Time";
            this.coldsMainL3DataTableSet_Two_Time.ColumnName = "Set_Two_Time";
            this.coldsMainL3DataTableSet_Two_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSet_Two_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Two_Operator
            // 
            this.coldsMainL3DataTableSet_Two_Operator.Caption = "Set_Two_Operator";
            this.coldsMainL3DataTableSet_Two_Operator.ColumnName = "Set_Two_Operator";
            this.coldsMainL3DataTableSet_Two_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Three_Time
            // 
            this.coldsMainL3DataTableSet_Three_Time.Caption = "Set_Three_Time";
            this.coldsMainL3DataTableSet_Three_Time.ColumnName = "Set_Three_Time";
            this.coldsMainL3DataTableSet_Three_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSet_Three_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Three_Operator
            // 
            this.coldsMainL3DataTableSet_Three_Operator.Caption = "Set_Three_Operator";
            this.coldsMainL3DataTableSet_Three_Operator.ColumnName = "Set_Three_Operator";
            this.coldsMainL3DataTableSet_Three_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Four_Time
            // 
            this.coldsMainL3DataTableSet_Four_Time.Caption = "Set_Four_Time";
            this.coldsMainL3DataTableSet_Four_Time.ColumnName = "Set_Four_Time";
            this.coldsMainL3DataTableSet_Four_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSet_Four_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSet_Four_Operator
            // 
            this.coldsMainL3DataTableSet_Four_Operator.Caption = "Set_Four_Operator";
            this.coldsMainL3DataTableSet_Four_Operator.ColumnName = "Set_Four_Operator";
            this.coldsMainL3DataTableSet_Four_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableEnd_Time
            // 
            this.coldsMainL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsMainL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsMainL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsMainL3DataTableEnd_Operator
            // 
            this.coldsMainL3DataTableEnd_Operator.Caption = "End_Operator";
            this.coldsMainL3DataTableEnd_Operator.ColumnName = "End_Operator";
            this.coldsMainL3DataTableEnd_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableSuspend_Time
            // 
            this.coldsMainL3DataTableSuspend_Time.Caption = "Suspend_Time";
            this.coldsMainL3DataTableSuspend_Time.ColumnName = "Suspend_Time";
            this.coldsMainL3DataTableSuspend_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSuspend_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSuspend_Operator
            // 
            this.coldsMainL3DataTableSuspend_Operator.Caption = "Suspend_Operator";
            this.coldsMainL3DataTableSuspend_Operator.ColumnName = "Suspend_Operator";
            this.coldsMainL3DataTableSuspend_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableTeamID
            // 
            this.coldsMainL3DataTableTeamID.Caption = "TeamID";
            this.coldsMainL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsMainL3DataTableTeamID.Namespace = "";
            // 
            // coldsMainL3DataTableShiftID
            // 
            this.coldsMainL3DataTableShiftID.Caption = "ShiftID";
            this.coldsMainL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsMainL3DataTableShiftID.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(620, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(539, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbNoteType);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbFireType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.cmbRoasterID);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.dtSuspendTime);
            this.tabPage1.Controls.Add(this.dtEndTime);
            this.tabPage1.Controls.Add(this.dtSetFourTime);
            this.tabPage1.Controls.Add(this.txtSuspendOperator);
            this.tabPage1.Controls.Add(this.txtEndOperator);
            this.tabPage1.Controls.Add(this.txtSetFourOperator);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.dtSetTwoTime);
            this.tabPage1.Controls.Add(this.dtSetThreeTime);
            this.tabPage1.Controls.Add(this.dtSetOneTime);
            this.tabPage1.Controls.Add(this.txtSetTwoOperator);
            this.tabPage1.Controls.Add(this.txtSetThreeOperator);
            this.tabPage1.Controls.Add(this.txtSetOneOperator);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.dtStartTime);
            this.tabPage1.Controls.Add(this.cmbLadleID);
            this.tabPage1.Controls.Add(this.txtStartOperator);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "烘烤实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(84, 209);
            this.rtxtNote.MaxStrLength = 0;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(596, 49);
            this.rtxtNote.TabIndex = 21;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbNoteType
            // 
            this.cmbNoteType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNoteType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNoteType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "FireNote", true));
            this.cmbNoteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoteType.EnableNull = true;
            this.cmbNoteType.ErropPr = null;
            this.cmbNoteType.FormattingEnabled = true;
            this.cmbNoteType.Items.AddRange(new object[] {
            "",
            "大修",
            "中修",
            "小修",
            "补包底",
            "普通钢包烘烤",
            "回烤包",
            "备用包"});
            this.cmbNoteType.Location = new System.Drawing.Point(84, 81);
            this.cmbNoteType.Name = "cmbNoteType";
            this.cmbNoteType.Size = new System.Drawing.Size(141, 20);
            this.cmbNoteType.TabIndex = 5;
            this.cmbNoteType.ToolTipValid = null;
            this.cmbNoteType.ValidEable = true;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(84, 156);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 5;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // cmbFireType
            // 
            this.cmbFireType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFireType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFireType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Fire_Type", true));
            this.cmbFireType.DataSource = this.dsLadleFireType;
            this.cmbFireType.DisplayMember = "L3DataTable.Code_Des";
            this.cmbFireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFireType.EnableNull = false;
            this.cmbFireType.ErropPr = this.errorProvider1;
            this.cmbFireType.FormattingEnabled = true;
            this.cmbFireType.Location = new System.Drawing.Point(84, 57);
            this.cmbFireType.Name = "cmbFireType";
            this.cmbFireType.Size = new System.Drawing.Size(141, 20);
            this.cmbFireType.TabIndex = 2;
            this.cmbFireType.ToolTipValid = this.toolTip1;
            this.cmbFireType.ValidEable = true;
            this.cmbFireType.ValueMember = "L3DataTable.Code";
            this.cmbFireType.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsLadleFireType
            // 
            this.dsLadleFireType.AutoSubscribe = false;
            this.dsLadleFireType.DataSetName = "L3DataSet";
            this.dsLadleFireType.DeleteMethod = null;
            this.dsLadleFireType.InsertMethod = null;
            this.dsLadleFireType.L3DataAdapter = this.Adapter;
            this.dsLadleFireType.LoadEvent = "Click";
            this.dsLadleFireType.LoadTrigger = null;
            this.dsLadleFireType.RefreshValve = 1000;
            this.dsLadleFireType.SourceCommand = null;
            this.dsLadleFireType.SourceCondition = "CODE_GROUP = \'LadleFireType\' order by CODE";
            this.dsLadleFireType.SourceMethod = "";
            this.dsLadleFireType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleFireType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleFireType.SubscribeTarget = null;
            this.dsLadleFireType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleFireType});
            this.dsLadleFireType.UpdateEvent = "Click";
            this.dsLadleFireType.UpdateMethod = null;
            this.dsLadleFireType.UpdateTrigger = null;
            // 
            // schemadsLadleFireType
            // 
            this.schemadsLadleFireType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleFireTypeL3DataTableCode,
            this.coldsLadleFireTypeL3DataTableCode_Des});
            this.schemadsLadleFireType.TableName = "L3DataTable";
            // 
            // coldsLadleFireTypeL3DataTableCode
            // 
            this.coldsLadleFireTypeL3DataTableCode.Caption = "Code";
            this.coldsLadleFireTypeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleFireTypeL3DataTableCode.Namespace = "";
            // 
            // coldsLadleFireTypeL3DataTableCode_Des
            // 
            this.coldsLadleFireTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleFireTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleFireTypeL3DataTableCode_Des.Namespace = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "烘烤类别:";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(84, 131);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 4;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(7, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "烘烤器台号:";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(84, 181);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 6;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(19, 84);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 60;
            this.label33.Text = "备注类型:";
            // 
            // cmbRoasterID
            // 
            this.cmbRoasterID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRoasterID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoasterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Roaster_ID", true));
            this.cmbRoasterID.DataSource = this.dsLadleFireEqu;
            this.cmbRoasterID.DisplayMember = "L3DataTable.Code";
            this.cmbRoasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoasterID.EnableNull = true;
            this.cmbRoasterID.ErropPr = null;
            this.cmbRoasterID.FormattingEnabled = true;
            this.cmbRoasterID.Location = new System.Drawing.Point(84, 106);
            this.cmbRoasterID.Name = "cmbRoasterID";
            this.cmbRoasterID.Size = new System.Drawing.Size(141, 20);
            this.cmbRoasterID.TabIndex = 3;
            this.cmbRoasterID.ToolTipValid = null;
            this.cmbRoasterID.ValidEable = true;
            this.cmbRoasterID.ValueMember = "L3DataTable.Code";
            // 
            // dsLadleFireEqu
            // 
            this.dsLadleFireEqu.AutoSubscribe = false;
            this.dsLadleFireEqu.DataSetName = "L3DataSet";
            this.dsLadleFireEqu.DeleteMethod = null;
            this.dsLadleFireEqu.InsertMethod = null;
            this.dsLadleFireEqu.L3DataAdapter = this.Adapter;
            this.dsLadleFireEqu.LoadEvent = "Click";
            this.dsLadleFireEqu.LoadTrigger = null;
            this.dsLadleFireEqu.RefreshValve = 1000;
            this.dsLadleFireEqu.SourceCommand = null;
            this.dsLadleFireEqu.SourceCondition = "CODE_GROUP = \'LadleFireEqu\' order by CODE_Val_Str";
            this.dsLadleFireEqu.SourceMethod = "";
            this.dsLadleFireEqu.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleFireEqu.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleFireEqu.SubscribeTarget = null;
            this.dsLadleFireEqu.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleFireEqu});
            this.dsLadleFireEqu.UpdateEvent = "Click";
            this.dsLadleFireEqu.UpdateMethod = null;
            this.dsLadleFireEqu.UpdateTrigger = null;
            // 
            // schemadsLadleFireEqu
            // 
            this.schemadsLadleFireEqu.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleFireEquL3DataTableCode});
            this.schemadsLadleFireEqu.TableName = "L3DataTable";
            // 
            // coldsLadleFireEquL3DataTableCode
            // 
            this.coldsLadleFireEquL3DataTableCode.Caption = "Code";
            this.coldsLadleFireEquL3DataTableCode.ColumnName = "Code";
            this.coldsLadleFireEquL3DataTableCode.Namespace = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(43, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 60;
            this.label23.Text = "班次:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(43, 134);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 61;
            this.label30.Text = "班别:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(43, 212);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 12);
            this.label31.TabIndex = 58;
            this.label31.Text = "备注:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(31, 184);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 12);
            this.label32.TabIndex = 59;
            this.label32.Text = "责任人:";
            // 
            // dtSuspendTime
            // 
            this.dtSuspendTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSuspendTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Suspend_Time", true));
            this.dtSuspendTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSuspendTime.Location = new System.Drawing.Point(303, 156);
            this.dtSuspendTime.Name = "dtSuspendTime";
            this.dtSuspendTime.Size = new System.Drawing.Size(141, 21);
            this.dtSuspendTime.TabIndex = 13;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "End_Time", true));
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(303, 131);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtEndTime.TabIndex = 12;
            // 
            // dtSetFourTime
            // 
            this.dtSetFourTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSetFourTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Set_Four_Time", true));
            this.dtSetFourTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetFourTime.Location = new System.Drawing.Point(303, 106);
            this.dtSetFourTime.Name = "dtSetFourTime";
            this.dtSetFourTime.Size = new System.Drawing.Size(141, 21);
            this.dtSetFourTime.TabIndex = 11;
            // 
            // txtSuspendOperator
            // 
            this.txtSuspendOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Suspend_Operator", true));
            this.txtSuspendOperator.EnableNull = true;
            this.txtSuspendOperator.ErropPr = null;
            this.txtSuspendOperator.Length = 0;
            this.txtSuspendOperator.Location = new System.Drawing.Point(539, 156);
            this.txtSuspendOperator.Max = 0;
            this.txtSuspendOperator.MaxStrLength = 0;
            this.txtSuspendOperator.Min = 0;
            this.txtSuspendOperator.MinStrLength = 0;
            this.txtSuspendOperator.Name = "txtSuspendOperator";
            this.txtSuspendOperator.Precision = 0;
            this.txtSuspendOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSuspendOperator.TabIndex = 20;
            this.txtSuspendOperator.ToolTipValid = null;
            this.txtSuspendOperator.ValidEable = true;
            this.txtSuspendOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtEndOperator
            // 
            this.txtEndOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "End_Operator", true));
            this.txtEndOperator.EnableNull = true;
            this.txtEndOperator.ErropPr = null;
            this.txtEndOperator.Length = 0;
            this.txtEndOperator.Location = new System.Drawing.Point(539, 131);
            this.txtEndOperator.Max = 0;
            this.txtEndOperator.MaxStrLength = 0;
            this.txtEndOperator.Min = 0;
            this.txtEndOperator.MinStrLength = 0;
            this.txtEndOperator.Name = "txtEndOperator";
            this.txtEndOperator.Precision = 0;
            this.txtEndOperator.Size = new System.Drawing.Size(141, 21);
            this.txtEndOperator.TabIndex = 19;
            this.txtEndOperator.ToolTipValid = null;
            this.txtEndOperator.ValidEable = true;
            this.txtEndOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSetFourOperator
            // 
            this.txtSetFourOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Set_Four_Operator", true));
            this.txtSetFourOperator.EnableNull = true;
            this.txtSetFourOperator.ErropPr = null;
            this.txtSetFourOperator.Length = 0;
            this.txtSetFourOperator.Location = new System.Drawing.Point(539, 106);
            this.txtSetFourOperator.Max = 0;
            this.txtSetFourOperator.MaxStrLength = 0;
            this.txtSetFourOperator.Min = 0;
            this.txtSetFourOperator.MinStrLength = 0;
            this.txtSetFourOperator.Name = "txtSetFourOperator";
            this.txtSetFourOperator.Precision = 0;
            this.txtSetFourOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSetFourOperator.TabIndex = 18;
            this.txtSetFourOperator.ToolTipValid = null;
            this.txtSetFourOperator.ValidEable = true;
            this.txtSetFourOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(238, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 49;
            this.label21.Text = "吊包时间:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(238, 135);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 50;
            this.label29.Text = "结束时间:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(238, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 51;
            this.label27.Text = "调四时间:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(462, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 12);
            this.label22.TabIndex = 46;
            this.label22.Text = "吊包操作员:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(462, 135);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 12);
            this.label28.TabIndex = 47;
            this.label28.Text = "结束操作员:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(462, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 12);
            this.label25.TabIndex = 48;
            this.label25.Text = "调四操作员:";
            // 
            // dtSetTwoTime
            // 
            this.dtSetTwoTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSetTwoTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Set_Two_Time", true));
            this.dtSetTwoTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetTwoTime.Location = new System.Drawing.Point(303, 56);
            this.dtSetTwoTime.Name = "dtSetTwoTime";
            this.dtSetTwoTime.Size = new System.Drawing.Size(141, 21);
            this.dtSetTwoTime.TabIndex = 9;
            // 
            // dtSetThreeTime
            // 
            this.dtSetThreeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSetThreeTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Set_Three_Time", true));
            this.dtSetThreeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetThreeTime.Location = new System.Drawing.Point(303, 81);
            this.dtSetThreeTime.Name = "dtSetThreeTime";
            this.dtSetThreeTime.Size = new System.Drawing.Size(141, 21);
            this.dtSetThreeTime.TabIndex = 10;
            // 
            // dtSetOneTime
            // 
            this.dtSetOneTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSetOneTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Set_One_Time", true));
            this.dtSetOneTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetOneTime.Location = new System.Drawing.Point(303, 31);
            this.dtSetOneTime.Name = "dtSetOneTime";
            this.dtSetOneTime.Size = new System.Drawing.Size(141, 21);
            this.dtSetOneTime.TabIndex = 8;
            // 
            // txtSetTwoOperator
            // 
            this.txtSetTwoOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Set_Two_Operator", true));
            this.txtSetTwoOperator.EnableNull = true;
            this.txtSetTwoOperator.ErropPr = null;
            this.txtSetTwoOperator.Length = 0;
            this.txtSetTwoOperator.Location = new System.Drawing.Point(539, 56);
            this.txtSetTwoOperator.Max = 0;
            this.txtSetTwoOperator.MaxStrLength = 0;
            this.txtSetTwoOperator.Min = 0;
            this.txtSetTwoOperator.MinStrLength = 0;
            this.txtSetTwoOperator.Name = "txtSetTwoOperator";
            this.txtSetTwoOperator.Precision = 0;
            this.txtSetTwoOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSetTwoOperator.TabIndex = 16;
            this.txtSetTwoOperator.ToolTipValid = null;
            this.txtSetTwoOperator.ValidEable = true;
            this.txtSetTwoOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSetThreeOperator
            // 
            this.txtSetThreeOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Set_Three_Operator", true));
            this.txtSetThreeOperator.EnableNull = true;
            this.txtSetThreeOperator.ErropPr = null;
            this.txtSetThreeOperator.Length = 0;
            this.txtSetThreeOperator.Location = new System.Drawing.Point(539, 81);
            this.txtSetThreeOperator.Max = 0;
            this.txtSetThreeOperator.MaxStrLength = 0;
            this.txtSetThreeOperator.Min = 0;
            this.txtSetThreeOperator.MinStrLength = 0;
            this.txtSetThreeOperator.Name = "txtSetThreeOperator";
            this.txtSetThreeOperator.Precision = 0;
            this.txtSetThreeOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSetThreeOperator.TabIndex = 17;
            this.txtSetThreeOperator.ToolTipValid = null;
            this.txtSetThreeOperator.ValidEable = true;
            this.txtSetThreeOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSetOneOperator
            // 
            this.txtSetOneOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Set_One_Operator", true));
            this.txtSetOneOperator.EnableNull = true;
            this.txtSetOneOperator.ErropPr = null;
            this.txtSetOneOperator.Length = 0;
            this.txtSetOneOperator.Location = new System.Drawing.Point(539, 31);
            this.txtSetOneOperator.Max = 0;
            this.txtSetOneOperator.MaxStrLength = 0;
            this.txtSetOneOperator.Min = 0;
            this.txtSetOneOperator.MinStrLength = 0;
            this.txtSetOneOperator.Name = "txtSetOneOperator";
            this.txtSetOneOperator.Precision = 0;
            this.txtSetOneOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSetOneOperator.TabIndex = 15;
            this.txtSetOneOperator.ToolTipValid = null;
            this.txtSetOneOperator.ValidEable = true;
            this.txtSetOneOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(238, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "调二时间:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(238, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 12);
            this.label26.TabIndex = 38;
            this.label26.Text = "调三时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(238, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "调一时间:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(462, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "调三操作员:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(462, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "调二操作员:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(462, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 36;
            this.label19.Text = "调一操作员:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(84, 6);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Start_Time", true));
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(303, 6);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtStartTime.TabIndex = 7;
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "LadleID", true));
            this.cmbLadleID.DataSource = this.dsLadleID;
            this.cmbLadleID.DisplayMember = "L3DataTable.LadleID";
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.EnableNull = false;
            this.cmbLadleID.ErropPr = this.errorProvider1;
            this.cmbLadleID.FormattingEnabled = true;
            this.cmbLadleID.Location = new System.Drawing.Point(84, 32);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleID.TabIndex = 1;
            this.cmbLadleID.ToolTipValid = this.toolTip1;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.LadleID";
            this.cmbLadleID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadleID.SubscribeTarget = null;
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // txtStartOperator
            // 
            this.txtStartOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Start_Operator", true));
            this.txtStartOperator.EnableNull = true;
            this.txtStartOperator.ErropPr = null;
            this.txtStartOperator.Length = 0;
            this.txtStartOperator.Location = new System.Drawing.Point(539, 6);
            this.txtStartOperator.Max = 0;
            this.txtStartOperator.MaxStrLength = 0;
            this.txtStartOperator.Min = 0;
            this.txtStartOperator.MinStrLength = 0;
            this.txtStartOperator.Name = "txtStartOperator";
            this.txtStartOperator.Precision = 0;
            this.txtStartOperator.Size = new System.Drawing.Size(141, 21);
            this.txtStartOperator.TabIndex = 14;
            this.txtStartOperator.ToolTipValid = null;
            this.txtStartOperator.ValidEable = true;
            this.txtStartOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(238, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "开始时间:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "录入时间:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(462, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 22;
            this.label24.Text = "开始操作员:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "钢包号:";
            // 
            // coldsMainL3DataTableFireNote
            // 
            this.coldsMainL3DataTableFireNote.Caption = "FireNote";
            this.coldsMainL3DataTableFireNote.ColumnName = "FireNote";
            this.coldsMainL3DataTableFireNote.Namespace = "";
            // 
            // LadleFireShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 337);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LadleFireShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢包烘烤实绩维护界面";
            this.Load += new System.EventHandler(this.LadleFireShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireEqu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireEqu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dtSuspendTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtSetFourTime;
        private PxDataValid.PxTextBox txtSuspendOperator;
        private PxDataValid.PxTextBox txtEndOperator;
        private PxDataValid.PxTextBox txtSetFourOperator;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtSetTwoTime;
        private System.Windows.Forms.DateTimePicker dtSetThreeTime;
        private System.Windows.Forms.DateTimePicker dtSetOneTime;
        private PxDataValid.PxTextBox txtSetTwoOperator;
        private PxDataValid.PxTextBox txtSetThreeOperator;
        private PxDataValid.PxTextBox txtSetOneOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private PxDataValid.PxComboBox cmbLadleID;
        private PxDataValid.PxComboBox cmbRoasterID;
        private PxDataValid.PxComboBox cmbFireType;
        private PxDataValid.PxTextBox txtStartOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableFire_Type;
        private System.Data.DataColumn coldsMainL3DataTableRoaster_ID;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableStart_Time;
        private System.Data.DataColumn coldsMainL3DataTableStart_Operator;
        private System.Data.DataColumn coldsMainL3DataTableSet_One_Time;
        private System.Data.DataColumn coldsMainL3DataTableSet_One_Operator;
        private System.Data.DataColumn coldsMainL3DataTableSet_Two_Time;
        private System.Data.DataColumn coldsMainL3DataTableSet_Two_Operator;
        private System.Data.DataColumn coldsMainL3DataTableSet_Three_Time;
        private System.Data.DataColumn coldsMainL3DataTableSet_Three_Operator;
        private System.Data.DataColumn coldsMainL3DataTableSet_Four_Time;
        private System.Data.DataColumn coldsMainL3DataTableSet_Four_Operator;
        private System.Data.DataColumn coldsMainL3DataTableEnd_Time;
        private System.Data.DataColumn coldsMainL3DataTableEnd_Operator;
        private System.Data.DataColumn coldsMainL3DataTableSuspend_Time;
        private System.Data.DataColumn coldsMainL3DataTableSuspend_Operator;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsLadleFireEqu;
        private System.Data.DataTable schemadsLadleFireEqu;
        private System.Data.DataColumn coldsLadleFireEquL3DataTableCode;
        private AppSvrHMI.L3DataSet dsLadleFireType;
        private System.Data.DataTable schemadsLadleFireType;
        private System.Data.DataColumn coldsLadleFireTypeL3DataTableCode;
        private System.Data.DataColumn coldsLadleFireTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbNoteType;
        private System.Windows.Forms.Label label33;
        private System.Data.DataColumn coldsMainL3DataTableFireNote;
    }
}