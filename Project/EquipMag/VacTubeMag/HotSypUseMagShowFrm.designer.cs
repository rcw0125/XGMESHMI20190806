namespace EquipMag.VacTubeMag
{
    partial class HotSypUseMagShowFrm
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableHot_Syp_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableRefra_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableOn_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTablePosition = new System.Data.DataColumn();
            this.coldsMainL3DataTableOn_TeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOn_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableCur_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableTotal_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableOffLine_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableOff_TeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOff_Reason = new System.Data.DataColumn();
            this.coldsMainL3DataTableOnLine_Len = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableOn_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableOn_ShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOff_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableOff_ShiftID = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine1 = new buttonHide.MyLine();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtTotalAge = new System.Windows.Forms.TextBox();
            this.txtCurAge = new System.Windows.Forms.TextBox();
            this.txtOnAge = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.pxComboBox3 = new PxDataValid.PxComboBox();
            this.bsOnShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.pxComboBox4 = new PxDataValid.PxComboBox();
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_des = new System.Data.DataColumn();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.bsOffShiftID = new System.Windows.Forms.BindingSource(this.components);
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.bsOnTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.bsOffTeamID = new System.Windows.Forms.BindingSource(this.components);
            this.label33 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtOffTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOnTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.cmbVacTubeID = new PxDataValid.PxComboBox();
            this.dsNo = new AppSvrHMI.L3DataSet();
            this.schemadsNo = new System.Data.DataTable();
            this.coldsNoL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.cmbRefraFac = new PxDataValid.PxComboBox();
            this.dsFac = new AppSvrHMI.L3DataSet();
            this.schemadsFac = new System.Data.DataTable();
            this.coldsFacL3DataTableMatFactory = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Hot_Syp_Use";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableInput_Time,
            this.coldsMainL3DataTableBuild_ID,
            this.coldsMainL3DataTableHot_Syp_ID,
            this.coldsMainL3DataTableRefra_Fac,
            this.coldsMainL3DataTableOn_Time,
            this.coldsMainL3DataTablePosition,
            this.coldsMainL3DataTableOn_TeamID,
            this.coldsMainL3DataTableOn_Age,
            this.coldsMainL3DataTableCur_Age,
            this.coldsMainL3DataTableTotal_Age,
            this.coldsMainL3DataTableOffLine_Time,
            this.coldsMainL3DataTableOff_TeamID,
            this.coldsMainL3DataTableOff_Reason,
            this.coldsMainL3DataTableOnLine_Len,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableOn_Operator,
            this.coldsMainL3DataTableOn_ShiftID,
            this.coldsMainL3DataTableOff_Operator,
            this.coldsMainL3DataTableOff_ShiftID});
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
            // coldsMainL3DataTableBuild_ID
            // 
            this.coldsMainL3DataTableBuild_ID.Caption = "Build_ID";
            this.coldsMainL3DataTableBuild_ID.ColumnName = "Build_ID";
            this.coldsMainL3DataTableBuild_ID.Namespace = "";
            // 
            // coldsMainL3DataTableHot_Syp_ID
            // 
            this.coldsMainL3DataTableHot_Syp_ID.Caption = "Hot_Syp_ID";
            this.coldsMainL3DataTableHot_Syp_ID.ColumnName = "Hot_Syp_ID";
            this.coldsMainL3DataTableHot_Syp_ID.Namespace = "";
            // 
            // coldsMainL3DataTableRefra_Fac
            // 
            this.coldsMainL3DataTableRefra_Fac.Caption = "Refra_Fac";
            this.coldsMainL3DataTableRefra_Fac.ColumnName = "Refra_Fac";
            this.coldsMainL3DataTableRefra_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableOn_Time
            // 
            this.coldsMainL3DataTableOn_Time.Caption = "On_Time";
            this.coldsMainL3DataTableOn_Time.ColumnName = "On_Time";
            this.coldsMainL3DataTableOn_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableOn_Time.Namespace = "";
            // 
            // coldsMainL3DataTablePosition
            // 
            this.coldsMainL3DataTablePosition.Caption = "Position";
            this.coldsMainL3DataTablePosition.ColumnName = "Position";
            this.coldsMainL3DataTablePosition.Namespace = "";
            // 
            // coldsMainL3DataTableOn_TeamID
            // 
            this.coldsMainL3DataTableOn_TeamID.Caption = "On_TeamID";
            this.coldsMainL3DataTableOn_TeamID.ColumnName = "On_TeamID";
            this.coldsMainL3DataTableOn_TeamID.Namespace = "";
            // 
            // coldsMainL3DataTableOn_Age
            // 
            this.coldsMainL3DataTableOn_Age.Caption = "On_Age";
            this.coldsMainL3DataTableOn_Age.ColumnName = "On_Age";
            this.coldsMainL3DataTableOn_Age.DataType = typeof(int);
            this.coldsMainL3DataTableOn_Age.Namespace = "";
            // 
            // coldsMainL3DataTableCur_Age
            // 
            this.coldsMainL3DataTableCur_Age.Caption = "Cur_Age";
            this.coldsMainL3DataTableCur_Age.ColumnName = "Cur_Age";
            this.coldsMainL3DataTableCur_Age.DataType = typeof(int);
            this.coldsMainL3DataTableCur_Age.Namespace = "";
            // 
            // coldsMainL3DataTableTotal_Age
            // 
            this.coldsMainL3DataTableTotal_Age.Caption = "Total_Age";
            this.coldsMainL3DataTableTotal_Age.ColumnName = "Total_Age";
            this.coldsMainL3DataTableTotal_Age.DataType = typeof(int);
            this.coldsMainL3DataTableTotal_Age.Namespace = "";
            // 
            // coldsMainL3DataTableOffLine_Time
            // 
            this.coldsMainL3DataTableOffLine_Time.Caption = "OffLine_Time";
            this.coldsMainL3DataTableOffLine_Time.ColumnName = "OffLine_Time";
            this.coldsMainL3DataTableOffLine_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableOffLine_Time.Namespace = "";
            // 
            // coldsMainL3DataTableOff_TeamID
            // 
            this.coldsMainL3DataTableOff_TeamID.Caption = "Off_TeamID";
            this.coldsMainL3DataTableOff_TeamID.ColumnName = "Off_TeamID";
            this.coldsMainL3DataTableOff_TeamID.Namespace = "";
            // 
            // coldsMainL3DataTableOff_Reason
            // 
            this.coldsMainL3DataTableOff_Reason.Caption = "Off_Reason";
            this.coldsMainL3DataTableOff_Reason.ColumnName = "Off_Reason";
            this.coldsMainL3DataTableOff_Reason.Namespace = "";
            // 
            // coldsMainL3DataTableOnLine_Len
            // 
            this.coldsMainL3DataTableOnLine_Len.Caption = "OnLine_Len";
            this.coldsMainL3DataTableOnLine_Len.ColumnName = "OnLine_Len";
            this.coldsMainL3DataTableOnLine_Len.DataType = typeof(double);
            this.coldsMainL3DataTableOnLine_Len.Namespace = "";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // coldsMainL3DataTableOn_Operator
            // 
            this.coldsMainL3DataTableOn_Operator.Caption = "On_Operator";
            this.coldsMainL3DataTableOn_Operator.ColumnName = "On_Operator";
            this.coldsMainL3DataTableOn_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableOn_ShiftID
            // 
            this.coldsMainL3DataTableOn_ShiftID.Caption = "On_ShiftID";
            this.coldsMainL3DataTableOn_ShiftID.ColumnName = "On_ShiftID";
            this.coldsMainL3DataTableOn_ShiftID.Namespace = "";
            // 
            // coldsMainL3DataTableOff_Operator
            // 
            this.coldsMainL3DataTableOff_Operator.Caption = "Off_Operator";
            this.coldsMainL3DataTableOff_Operator.ColumnName = "Off_Operator";
            this.coldsMainL3DataTableOff_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableOff_ShiftID
            // 
            this.coldsMainL3DataTableOff_ShiftID.Caption = "Off_ShiftID";
            this.coldsMainL3DataTableOff_ShiftID.ColumnName = "Off_ShiftID";
            this.coldsMainL3DataTableOff_ShiftID.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(458, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
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
            this.btnConfirm.Location = new System.Drawing.Point(377, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(543, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.txtLength);
            this.tabPage1.Controls.Add(this.txtTotalAge);
            this.tabPage1.Controls.Add(this.txtCurAge);
            this.tabPage1.Controls.Add(this.txtOnAge);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.pxComboBox3);
            this.tabPage1.Controls.Add(this.pxComboBox4);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.pxComboBox2);
            this.tabPage1.Controls.Add(this.pxTextBox1);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.dtOffTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtOnTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.cmbVacTubeID);
            this.tabPage1.Controls.Add(this.pxComboBox1);
            this.tabPage1.Controls.Add(this.cmbRefraFac);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "砌筑信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(34, 144);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(478, 1);
            this.myLine1.TabIndex = 89;
            // 
            // txtLength
            // 
            this.txtLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "OnLine_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N1"));
            this.txtLength.Location = new System.Drawing.Point(370, 92);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(142, 21);
            this.txtLength.TabIndex = 8;
            // 
            // txtTotalAge
            // 
            this.txtTotalAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.txtTotalAge.Location = new System.Drawing.Point(370, 64);
            this.txtTotalAge.Name = "txtTotalAge";
            this.txtTotalAge.ReadOnly = true;
            this.txtTotalAge.Size = new System.Drawing.Size(142, 21);
            this.txtTotalAge.TabIndex = 7;
            // 
            // txtCurAge
            // 
            this.txtCurAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cur_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.txtCurAge.Location = new System.Drawing.Point(370, 36);
            this.txtCurAge.Name = "txtCurAge";
            this.txtCurAge.Size = new System.Drawing.Size(142, 21);
            this.txtCurAge.TabIndex = 6;
            this.txtCurAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtOnAge
            // 
            this.txtOnAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "On_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.txtOnAge.Location = new System.Drawing.Point(370, 8);
            this.txtOnAge.Name = "txtOnAge";
            this.txtOnAge.Size = new System.Drawing.Size(142, 21);
            this.txtOnAge.TabIndex = 5;
            this.txtOnAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Build_ID", true));
            this.textBox16.Location = new System.Drawing.Point(108, 36);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(142, 21);
            this.textBox16.TabIndex = 1;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = null;
            this.rtxtNote.Location = new System.Drawing.Point(108, 258);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(404, 69);
            this.rtxtNote.TabIndex = 18;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = null;
            this.rtxtNote.ValidEable = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(67, 258);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 88;
            this.label46.Text = "备注:";
            // 
            // pxComboBox3
            // 
            this.pxComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "On_ShiftID", true));
            this.pxComboBox3.DataSource = this.bsOnShiftID;
            this.pxComboBox3.DisplayMember = "Code_Des";
            this.pxComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox3.EnableNull = true;
            this.pxComboBox3.ErropPr = null;
            this.pxComboBox3.FormattingEnabled = true;
            this.pxComboBox3.Location = new System.Drawing.Point(108, 203);
            this.pxComboBox3.Name = "pxComboBox3";
            this.pxComboBox3.Size = new System.Drawing.Size(142, 20);
            this.pxComboBox3.TabIndex = 12;
            this.pxComboBox3.ToolTipValid = null;
            this.pxComboBox3.ValidEable = true;
            this.pxComboBox3.ValueMember = "Code";
            // 
            // bsOnShiftID
            // 
            this.bsOnShiftID.DataMember = "L3DataTable";
            this.bsOnShiftID.DataSource = this.dsShiftID;
            // 
            // pxComboBox4
            // 
            this.pxComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Off_Reason", true));
            this.pxComboBox4.DataSource = this.dsOffLineReason;
            this.pxComboBox4.DisplayMember = "L3DataTable.Code_des";
            this.pxComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox4.EnableNull = true;
            this.pxComboBox4.ErropPr = null;
            this.pxComboBox4.FormattingEnabled = true;
            this.pxComboBox4.Location = new System.Drawing.Point(370, 120);
            this.pxComboBox4.Name = "pxComboBox4";
            this.pxComboBox4.Size = new System.Drawing.Size(142, 20);
            this.pxComboBox4.TabIndex = 9;
            this.pxComboBox4.ToolTipValid = null;
            this.pxComboBox4.ValidEable = true;
            this.pxComboBox4.ValueMember = "L3DataTable.Code";
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoSubscribe = false;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = null;
            this.dsOffLineReason.InsertMethod = null;
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "Click";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "CODE_GROUP = \'CVACTUBE_OFF_REASON\'";
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
            this.coldsOffLineReasonL3DataTableCode,
            this.coldsOffLineReasonL3DataTableCode_des});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTableCode
            // 
            this.coldsOffLineReasonL3DataTableCode.Caption = "Code";
            this.coldsOffLineReasonL3DataTableCode.ColumnName = "Code";
            this.coldsOffLineReasonL3DataTableCode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_des
            // 
            this.coldsOffLineReasonL3DataTableCode_des.Caption = "Code_des";
            this.coldsOffLineReasonL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsOffLineReasonL3DataTableCode_des.Namespace = "";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Off_ShiftID", true));
            this.cmbShiftID.DataSource = this.bsOffShiftID;
            this.cmbShiftID.DisplayMember = "Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(370, 203);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(142, 20);
            this.cmbShiftID.TabIndex = 16;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "Code";
            // 
            // bsOffShiftID
            // 
            this.bsOffShiftID.DataMember = "L3DataTable";
            this.bsOffShiftID.DataSource = this.dsShiftID;
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "On_TeamID", true));
            this.pxComboBox2.DataSource = this.bsOnTeamID;
            this.pxComboBox2.DisplayMember = "Code_Des";
            this.pxComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Location = new System.Drawing.Point(108, 177);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(142, 20);
            this.pxComboBox2.TabIndex = 11;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            this.pxComboBox2.ValueMember = "Code";
            // 
            // bsOnTeamID
            // 
            this.bsOnTeamID.DataMember = "L3DataTable";
            this.bsOnTeamID.DataSource = this.dsTeamID;
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "On_Operator", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(108, 229);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(142, 21);
            this.pxTextBox1.TabIndex = 13;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Off_TeamID", true));
            this.cmbTeamID.DataSource = this.bsOffTeamID;
            this.cmbTeamID.DisplayMember = "Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(370, 177);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(142, 20);
            this.cmbTeamID.TabIndex = 15;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "Code";
            // 
            // bsOffTeamID
            // 
            this.bsOffTeamID.DataMember = "L3DataTable";
            this.bsOffTeamID.DataSource = this.dsTeamID;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(43, 207);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 83;
            this.label33.Text = "上线班次:";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Off_Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(370, 229);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(142, 21);
            this.txtOperator.TabIndex = 17;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(308, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 83;
            this.label6.Text = "下线原因:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(43, 181);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 84;
            this.label29.Text = "上线班组:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(308, 207);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(59, 12);
            this.label44.TabIndex = 83;
            this.label44.Text = "下线班次:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(31, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 82;
            this.label8.Text = "上线责任人:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(308, 181);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 12);
            this.label45.TabIndex = 84;
            this.label45.Text = "下线班组:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(296, 233);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 12);
            this.label28.TabIndex = 82;
            this.label28.Text = "下线责任人:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(43, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 58;
            this.label22.Text = "砌筑编号:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(284, 96);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 12);
            this.label36.TabIndex = 57;
            this.label36.Text = "在线时长[天]:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(308, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 61;
            this.label35.Text = "累计寿命:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(308, 40);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 61;
            this.label34.Text = "在线寿命:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(308, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 61;
            this.label19.Text = "上线寿命:";
            // 
            // dtOffTime
            // 
            this.dtOffTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOffTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OffLine_Time", true));
            this.dtOffTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffTime.Location = new System.Drawing.Point(370, 151);
            this.dtOffTime.MinDate = new System.DateTime(1899, 12, 31, 0, 0, 0, 0);
            this.dtOffTime.Name = "dtOffTime";
            this.dtOffTime.Size = new System.Drawing.Size(142, 21);
            this.dtOffTime.TabIndex = 14;
            this.dtOffTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "录入时间:";
            // 
            // dtOnTime
            // 
            this.dtOnTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOnTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "On_Time", true));
            this.dtOnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOnTime.Location = new System.Drawing.Point(108, 151);
            this.dtOnTime.MinDate = new System.DateTime(1899, 12, 31, 0, 0, 0, 0);
            this.dtOnTime.Name = "dtOnTime";
            this.dtOnTime.Size = new System.Drawing.Size(142, 21);
            this.dtOnTime.TabIndex = 10;
            this.dtOnTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(308, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "下线时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "耐材厂家:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "上线工位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "上线时间:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(31, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "热弯管编号:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(108, 8);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(142, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // cmbVacTubeID
            // 
            this.cmbVacTubeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVacTubeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Hot_Syp_ID", true));
            this.cmbVacTubeID.DataSource = this.dsNo;
            this.cmbVacTubeID.DisplayMember = "L3DataTable.VacTube_ID";
            this.cmbVacTubeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeID.EnableNull = true;
            this.cmbVacTubeID.ErropPr = null;
            this.cmbVacTubeID.FormattingEnabled = true;
            this.cmbVacTubeID.Location = new System.Drawing.Point(108, 64);
            this.cmbVacTubeID.Name = "cmbVacTubeID";
            this.cmbVacTubeID.Size = new System.Drawing.Size(142, 20);
            this.cmbVacTubeID.TabIndex = 2;
            this.cmbVacTubeID.ToolTipValid = null;
            this.cmbVacTubeID.ValidEable = true;
            this.cmbVacTubeID.ValueMember = "L3DataTable.VacTube_ID";
            // 
            // dsNo
            // 
            this.dsNo.AutoSubscribe = false;
            this.dsNo.DataSetName = "L3DataSet";
            this.dsNo.DeleteMethod = null;
            this.dsNo.InsertMethod = null;
            this.dsNo.L3DataAdapter = this.Adapter;
            this.dsNo.LoadEvent = "Click";
            this.dsNo.LoadTrigger = null;
            this.dsNo.RefreshValve = 1000;
            this.dsNo.SourceCommand = null;
            this.dsNo.SourceCondition = "VacTube_Name = \'3\' order by VacTube_ID";
            this.dsNo.SourceMethod = "";
            this.dsNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNo.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsNo.SubscribeTarget = null;
            this.dsNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNo});
            this.dsNo.UpdateEvent = "Click";
            this.dsNo.UpdateMethod = null;
            this.dsNo.UpdateTrigger = null;
            // 
            // schemadsNo
            // 
            this.schemadsNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNoL3DataTableVacTube_ID});
            this.schemadsNo.TableName = "L3DataTable";
            // 
            // coldsNoL3DataTableVacTube_ID
            // 
            this.coldsNoL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsNoL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsNoL3DataTableVacTube_ID.Namespace = "";
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Position", true));
            this.pxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox1.EnableNull = true;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.pxComboBox1.Location = new System.Drawing.Point(108, 92);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(142, 20);
            this.pxComboBox1.TabIndex = 3;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            // 
            // cmbRefraFac
            // 
            this.cmbRefraFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Refra_Fac", true));
            this.cmbRefraFac.DataSource = this.dsFac;
            this.cmbRefraFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbRefraFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefraFac.EnableNull = true;
            this.cmbRefraFac.ErropPr = null;
            this.cmbRefraFac.FormattingEnabled = true;
            this.cmbRefraFac.Location = new System.Drawing.Point(108, 120);
            this.cmbRefraFac.Name = "cmbRefraFac";
            this.cmbRefraFac.Size = new System.Drawing.Size(142, 20);
            this.cmbRefraFac.TabIndex = 4;
            this.cmbRefraFac.ToolTipValid = null;
            this.cmbRefraFac.ValidEable = true;
            this.cmbRefraFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsFac
            // 
            this.dsFac.AutoSubscribe = false;
            this.dsFac.DataSetName = "L3DataSet";
            this.dsFac.DeleteMethod = null;
            this.dsFac.InsertMethod = null;
            this.dsFac.L3DataAdapter = this.Adapter;
            this.dsFac.LoadEvent = "Click";
            this.dsFac.LoadTrigger = null;
            this.dsFac.RefreshValve = 1000;
            this.dsFac.SourceCommand = null;
            this.dsFac.SourceCondition = "MatGroup_Code = \'VacTubeFac\' and MatName = \'耐材\'";
            this.dsFac.SourceMethod = "";
            this.dsFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsFac.SubscribeTarget = null;
            this.dsFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFac});
            this.dsFac.UpdateEvent = "Click";
            this.dsFac.UpdateMethod = null;
            this.dsFac.UpdateTrigger = null;
            // 
            // schemadsFac
            // 
            this.schemadsFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFacL3DataTableMatFactory});
            this.schemadsFac.TableName = "L3DataTable";
            // 
            // coldsFacL3DataTableMatFactory
            // 
            this.coldsFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsFacL3DataTableMatFactory.Namespace = "";
            // 
            // HotSypUseMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HotSypUseMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "热弯管使用信息维护";
            this.Load += new System.EventHandler(this.HotSypUseMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3Adapter Adapter;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtOffTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOnTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private PxDataValid.PxComboBox cmbVacTubeID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsNo;
        private System.Data.DataTable schemadsNo;
        private System.Data.DataColumn coldsNoL3DataTableVacTube_ID;
        private AppSvrHMI.L3DataSet dsFac;
        private System.Data.DataTable schemadsFac;
        private System.Data.DataColumn coldsFacL3DataTableMatFactory;
        private PxDataValid.PxComboBox cmbRefraFac;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.TextBox txtOnAge;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtTotalAge;
        private System.Windows.Forms.TextBox txtCurAge;
        private PxDataValid.PxComboBox pxComboBox3;
        private PxDataValid.PxComboBox pxComboBox4;
        private PxDataValid.PxComboBox pxComboBox2;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxComboBox pxComboBox1;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableBuild_ID;
        private System.Data.DataColumn coldsMainL3DataTableHot_Syp_ID;
        private System.Data.DataColumn coldsMainL3DataTableRefra_Fac;
        private System.Data.DataColumn coldsMainL3DataTableOn_Time;
        private System.Data.DataColumn coldsMainL3DataTablePosition;
        private System.Data.DataColumn coldsMainL3DataTableOn_TeamID;
        private System.Data.DataColumn coldsMainL3DataTableOn_Age;
        private System.Data.DataColumn coldsMainL3DataTableCur_Age;
        private System.Data.DataColumn coldsMainL3DataTableTotal_Age;
        private System.Data.DataColumn coldsMainL3DataTableOffLine_Time;
        private System.Data.DataColumn coldsMainL3DataTableOff_TeamID;
        private System.Data.DataColumn coldsMainL3DataTableOff_Reason;
        private System.Data.DataColumn coldsMainL3DataTableOnLine_Len;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Data.DataColumn coldsMainL3DataTableOn_Operator;
        private System.Data.DataColumn coldsMainL3DataTableOn_ShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOff_Operator;
        private System.Data.DataColumn coldsMainL3DataTableOff_ShiftID;
        private System.Windows.Forms.BindingSource bsOnShiftID;
        private System.Windows.Forms.BindingSource bsOffShiftID;
        private System.Windows.Forms.BindingSource bsOnTeamID;
        private System.Windows.Forms.BindingSource bsOffTeamID;
        private buttonHide.MyLine myLine1;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_des;
    }
}