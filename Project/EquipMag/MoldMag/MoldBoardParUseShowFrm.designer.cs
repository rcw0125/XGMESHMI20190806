namespace EquipMag.MoldMag
{
    partial class MoldBoardParUseShowFrm
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
            this.dsM = new AppSvrHMI.L3DataSet();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableName = new System.Data.DataColumn();
            this.coldsML3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsML3DataTableMoldID = new System.Data.DataColumn();
            this.coldsML3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsML3DataTableLug_Steel_Mea = new System.Data.DataColumn();
            this.coldsML3DataTableCur_Use_Count = new System.Data.DataColumn();
            this.coldsML3DataTableTotal_Use_Count = new System.Data.DataColumn();
            this.coldsML3DataTableCur_Pull_Mea = new System.Data.DataColumn();
            this.coldsML3DataTableTotal_Pull_Mea = new System.Data.DataColumn();
            this.coldsML3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsML3DataTableFlowID = new System.Data.DataColumn();
            this.coldsML3DataTableStop_Reason = new System.Data.DataColumn();
            this.coldsML3DataTableTeamID = new System.Data.DataColumn();
            this.coldsML3DataTableShiftID = new System.Data.DataColumn();
            this.coldsML3DataTableOperator = new System.Data.DataColumn();
            this.coldsML3DataTableNote = new System.Data.DataColumn();
            this.coldsML3DataTableOffLine_Time = new System.Data.DataColumn();
            this.coldsML3DataTableOffLine_Flag = new System.Data.DataColumn();
            this.coldsML3DataTableOnLine_Flag = new System.Data.DataColumn();
            this.coldsML3DataTableOnLine_Time = new System.Data.DataColumn();
            this.coldsML3DataTableInStallID = new System.Data.DataColumn();
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
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsMoldID = new AppSvrHMI.L3DataSet();
            this.schemadsMoldID = new System.Data.DataTable();
            this.coldsMoldIDL3DataTableMoldID = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCopperNorthID = new PxDataValid.PxTextBox();
            this.txtCopperSouthID = new PxDataValid.PxTextBox();
            this.txtCopperInnerID = new PxDataValid.PxTextBox();
            this.txtCopperOuterID = new PxDataValid.PxTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.dtOffLine = new System.Windows.Forms.DateTimePicker();
            this.dtOnLine = new System.Windows.Forms.DateTimePicker();
            this.cmbCopperFac = new PxDataValid.PxComboBox();
            this.dsCopperFac = new AppSvrHMI.L3DataSet();
            this.schemadsCopperFac = new System.Data.DataTable();
            this.coldsCopperFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.pxComboBox11 = new PxDataValid.PxComboBox();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbStopReason = new PxDataValid.PxComboBox();
            this.dsMoldStopReason = new AppSvrHMI.L3DataSet();
            this.schemadsMoldStopReason = new System.Data.DataTable();
            this.coldsMoldStopReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsMoldStopReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbFlowID = new PxDataValid.PxComboBox();
            this.cmbCastID = new PxDataValid.PxComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLugSteelMea = new PxDataValid.PxTextBox();
            this.txtTotalPullMea = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMoldID = new PxDataValid.PxComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.coldsMainL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableLug_Steel_Mea = new System.Data.DataColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pxRichTextBox1 = new PxDataValid.PxRichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.pxComboBox3 = new PxDataValid.PxComboBox();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pxComboBox4 = new PxDataValid.PxComboBox();
            this.pxComboBox5 = new PxDataValid.PxComboBox();
            this.pxComboBox6 = new PxDataValid.PxComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pxComboBox7 = new PxDataValid.PxComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.coldsML3DataTableInner_ID = new System.Data.DataColumn();
            this.coldsML3DataTableOuter_ID = new System.Data.DataColumn();
            this.coldsML3DataTableSouth_ID = new System.Data.DataColumn();
            this.coldsML3DataTableNorth_ID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsM;
            // 
            // dsM
            // 
            this.dsM.AutoLoad = true;
            this.dsM.AutoSubscribe = false;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = null;
            this.dsM.InsertMethod = null;
            this.dsM.L3DataAdapter = null;
            this.dsM.LoadEvent = "Click";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = null;
            this.dsM.SourceCondition = "";
            this.dsM.SourceMethod = "";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsM.SourceURI = "";
            this.dsM.SubscribeTarget = "";
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "Click";
            this.dsM.UpdateMethod = null;
            this.dsM.UpdateTrigger = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableGUID,
            this.coldsML3DataTableName,
            this.coldsML3DataTableInput_Time,
            this.coldsML3DataTableMoldID,
            this.coldsML3DataTableCopper_Fac,
            this.coldsML3DataTableLug_Steel_Mea,
            this.coldsML3DataTableCur_Use_Count,
            this.coldsML3DataTableTotal_Use_Count,
            this.coldsML3DataTableCur_Pull_Mea,
            this.coldsML3DataTableTotal_Pull_Mea,
            this.coldsML3DataTableCast_ID,
            this.coldsML3DataTableFlowID,
            this.coldsML3DataTableStop_Reason,
            this.coldsML3DataTableTeamID,
            this.coldsML3DataTableShiftID,
            this.coldsML3DataTableOperator,
            this.coldsML3DataTableNote,
            this.coldsML3DataTableOffLine_Time,
            this.coldsML3DataTableOffLine_Flag,
            this.coldsML3DataTableOnLine_Flag,
            this.coldsML3DataTableOnLine_Time,
            this.coldsML3DataTableInStallID});
            this.schemadsM.TableName = "L3DataTable";
            // 
            // coldsML3DataTableGUID
            // 
            this.coldsML3DataTableGUID.Caption = "GUID";
            this.coldsML3DataTableGUID.ColumnName = "GUID";
            this.coldsML3DataTableGUID.Namespace = "";
            // 
            // coldsML3DataTableName
            // 
            this.coldsML3DataTableName.Caption = "Name";
            this.coldsML3DataTableName.ColumnName = "Name";
            this.coldsML3DataTableName.Namespace = "";
            // 
            // coldsML3DataTableInput_Time
            // 
            this.coldsML3DataTableInput_Time.Caption = "Input_Time";
            this.coldsML3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsML3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableInput_Time.Namespace = "";
            // 
            // coldsML3DataTableMoldID
            // 
            this.coldsML3DataTableMoldID.Caption = "MoldID";
            this.coldsML3DataTableMoldID.ColumnName = "MoldID";
            this.coldsML3DataTableMoldID.Namespace = "";
            // 
            // coldsML3DataTableCopper_Fac
            // 
            this.coldsML3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsML3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsML3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsML3DataTableLug_Steel_Mea
            // 
            this.coldsML3DataTableLug_Steel_Mea.Caption = "Lug_Steel_Mea";
            this.coldsML3DataTableLug_Steel_Mea.ColumnName = "Lug_Steel_Mea";
            this.coldsML3DataTableLug_Steel_Mea.DataType = typeof(double);
            this.coldsML3DataTableLug_Steel_Mea.Namespace = "";
            // 
            // coldsML3DataTableCur_Use_Count
            // 
            this.coldsML3DataTableCur_Use_Count.Caption = "Cur_Use_Count";
            this.coldsML3DataTableCur_Use_Count.ColumnName = "Cur_Use_Count";
            this.coldsML3DataTableCur_Use_Count.DataType = typeof(int);
            this.coldsML3DataTableCur_Use_Count.Namespace = "";
            // 
            // coldsML3DataTableTotal_Use_Count
            // 
            this.coldsML3DataTableTotal_Use_Count.Caption = "Total_Use_Count";
            this.coldsML3DataTableTotal_Use_Count.ColumnName = "Total_Use_Count";
            this.coldsML3DataTableTotal_Use_Count.DataType = typeof(int);
            this.coldsML3DataTableTotal_Use_Count.Namespace = "";
            // 
            // coldsML3DataTableCur_Pull_Mea
            // 
            this.coldsML3DataTableCur_Pull_Mea.Caption = "Cur_Pull_Mea";
            this.coldsML3DataTableCur_Pull_Mea.ColumnName = "Cur_Pull_Mea";
            this.coldsML3DataTableCur_Pull_Mea.DataType = typeof(double);
            this.coldsML3DataTableCur_Pull_Mea.Namespace = "";
            // 
            // coldsML3DataTableTotal_Pull_Mea
            // 
            this.coldsML3DataTableTotal_Pull_Mea.Caption = "Total_Pull_Mea";
            this.coldsML3DataTableTotal_Pull_Mea.ColumnName = "Total_Pull_Mea";
            this.coldsML3DataTableTotal_Pull_Mea.DataType = typeof(double);
            this.coldsML3DataTableTotal_Pull_Mea.Namespace = "";
            // 
            // coldsML3DataTableCast_ID
            // 
            this.coldsML3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsML3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsML3DataTableCast_ID.Namespace = "";
            // 
            // coldsML3DataTableFlowID
            // 
            this.coldsML3DataTableFlowID.Caption = "FlowID";
            this.coldsML3DataTableFlowID.ColumnName = "FlowID";
            this.coldsML3DataTableFlowID.Namespace = "";
            // 
            // coldsML3DataTableStop_Reason
            // 
            this.coldsML3DataTableStop_Reason.Caption = "Stop_Reason";
            this.coldsML3DataTableStop_Reason.ColumnName = "Stop_Reason";
            this.coldsML3DataTableStop_Reason.Namespace = "";
            // 
            // coldsML3DataTableTeamID
            // 
            this.coldsML3DataTableTeamID.Caption = "TeamID";
            this.coldsML3DataTableTeamID.ColumnName = "TeamID";
            this.coldsML3DataTableTeamID.Namespace = "";
            // 
            // coldsML3DataTableShiftID
            // 
            this.coldsML3DataTableShiftID.Caption = "ShiftID";
            this.coldsML3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsML3DataTableShiftID.Namespace = "";
            // 
            // coldsML3DataTableOperator
            // 
            this.coldsML3DataTableOperator.Caption = "Operator";
            this.coldsML3DataTableOperator.ColumnName = "Operator";
            this.coldsML3DataTableOperator.Namespace = "";
            // 
            // coldsML3DataTableNote
            // 
            this.coldsML3DataTableNote.Caption = "Note";
            this.coldsML3DataTableNote.ColumnName = "Note";
            this.coldsML3DataTableNote.Namespace = "";
            // 
            // coldsML3DataTableOffLine_Time
            // 
            this.coldsML3DataTableOffLine_Time.Caption = "OffLine_Time";
            this.coldsML3DataTableOffLine_Time.ColumnName = "OffLine_Time";
            this.coldsML3DataTableOffLine_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableOffLine_Time.Namespace = "";
            // 
            // coldsML3DataTableOffLine_Flag
            // 
            this.coldsML3DataTableOffLine_Flag.Caption = "OffLine_Flag";
            this.coldsML3DataTableOffLine_Flag.ColumnName = "OffLine_Flag";
            this.coldsML3DataTableOffLine_Flag.DataType = typeof(int);
            this.coldsML3DataTableOffLine_Flag.Namespace = "";
            // 
            // coldsML3DataTableOnLine_Flag
            // 
            this.coldsML3DataTableOnLine_Flag.Caption = "OnLine_Flag";
            this.coldsML3DataTableOnLine_Flag.ColumnName = "OnLine_Flag";
            this.coldsML3DataTableOnLine_Flag.DataType = typeof(int);
            this.coldsML3DataTableOnLine_Flag.Namespace = "";
            // 
            // coldsML3DataTableOnLine_Time
            // 
            this.coldsML3DataTableOnLine_Time.Caption = "OnLine_Time";
            this.coldsML3DataTableOnLine_Time.ColumnName = "OnLine_Time";
            this.coldsML3DataTableOnLine_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableOnLine_Time.Namespace = "";
            // 
            // coldsML3DataTableInStallID
            // 
            this.coldsML3DataTableInStallID.Caption = "InStallID";
            this.coldsML3DataTableInStallID.ColumnName = "InStallID";
            this.coldsML3DataTableInStallID.Namespace = "";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(472, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(391, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 78;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
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
            this.dsTeamID.AutoLoad = true;
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
            // dsCasterID
            // 
            this.dsCasterID.AutoLoad = true;
            this.dsCasterID.AutoSubscribe = false;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' and code = \'S65\' order by Code";
            this.dsCasterID.SourceMethod = "";
            this.dsCasterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterID.SubscribeTarget = null;
            this.dsCasterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterID});
            this.dsCasterID.UpdateEvent = "Click";
            this.dsCasterID.UpdateMethod = null;
            this.dsCasterID.UpdateTrigger = null;
            // 
            // schemadsCasterID
            // 
            this.schemadsCasterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterIDL3DataTableCode,
            this.coldsCasterIDL3DataTableCode_Des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_Des
            // 
            this.coldsCasterIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsMoldID
            // 
            this.dsMoldID.AutoLoad = true;
            this.dsMoldID.AutoSubscribe = false;
            this.dsMoldID.DataSetName = "L3DataSet";
            this.dsMoldID.DeleteMethod = null;
            this.dsMoldID.InsertMethod = null;
            this.dsMoldID.L3DataAdapter = this.Adapter;
            this.dsMoldID.LoadEvent = "Click";
            this.dsMoldID.LoadTrigger = null;
            this.dsMoldID.RefreshValve = 1000;
            this.dsMoldID.SourceCommand = null;
            this.dsMoldID.SourceCondition = "MoldID Like \'J12%\'";
            this.dsMoldID.SourceMethod = "";
            this.dsMoldID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldID.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMoldID.SubscribeTarget = null;
            this.dsMoldID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldID});
            this.dsMoldID.UpdateEvent = "Click";
            this.dsMoldID.UpdateMethod = null;
            this.dsMoldID.UpdateTrigger = null;
            // 
            // schemadsMoldID
            // 
            this.schemadsMoldID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldIDL3DataTableMoldID});
            this.schemadsMoldID.TableName = "L3DataTable";
            // 
            // coldsMoldIDL3DataTableMoldID
            // 
            this.coldsMoldIDL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.Namespace = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 67);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 331);
            this.tabControl1.TabIndex = 81;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtCopperNorthID);
            this.tabPage1.Controls.Add(this.txtCopperSouthID);
            this.tabPage1.Controls.Add(this.txtCopperInnerID);
            this.tabPage1.Controls.Add(this.txtCopperOuterID);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.dtOffLine);
            this.tabPage1.Controls.Add(this.dtOnLine);
            this.tabPage1.Controls.Add(this.cmbCopperFac);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.pxComboBox11);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbStopReason);
            this.tabPage1.Controls.Add(this.cmbFlowID);
            this.tabPage1.Controls.Add(this.cmbCastID);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLugSteelMea);
            this.tabPage1.Controls.Add(this.txtTotalPullMea);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbMoldID);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(542, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铜板使用信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCopperNorthID
            // 
            this.txtCopperNorthID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "North_ID", true));
            this.txtCopperNorthID.EnableNull = true;
            this.txtCopperNorthID.ErropPr = null;
            this.txtCopperNorthID.Length = 0;
            this.txtCopperNorthID.Location = new System.Drawing.Point(108, 211);
            this.txtCopperNorthID.Max = 0;
            this.txtCopperNorthID.MaxStrLength = 0;
            this.txtCopperNorthID.Min = 0;
            this.txtCopperNorthID.MinStrLength = 0;
            this.txtCopperNorthID.Name = "txtCopperNorthID";
            this.txtCopperNorthID.Precision = 0;
            this.txtCopperNorthID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperNorthID.TabIndex = 101;
            this.txtCopperNorthID.ToolTipValid = null;
            this.txtCopperNorthID.ValidEable = true;
            this.txtCopperNorthID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCopperSouthID
            // 
            this.txtCopperSouthID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "South_ID", true));
            this.txtCopperSouthID.EnableNull = true;
            this.txtCopperSouthID.ErropPr = null;
            this.txtCopperSouthID.Length = 0;
            this.txtCopperSouthID.Location = new System.Drawing.Point(108, 186);
            this.txtCopperSouthID.Max = 0;
            this.txtCopperSouthID.MaxStrLength = 0;
            this.txtCopperSouthID.Min = 0;
            this.txtCopperSouthID.MinStrLength = 0;
            this.txtCopperSouthID.Name = "txtCopperSouthID";
            this.txtCopperSouthID.Precision = 0;
            this.txtCopperSouthID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperSouthID.TabIndex = 100;
            this.txtCopperSouthID.ToolTipValid = null;
            this.txtCopperSouthID.ValidEable = true;
            this.txtCopperSouthID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCopperInnerID
            // 
            this.txtCopperInnerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Inner_ID", true));
            this.txtCopperInnerID.EnableNull = true;
            this.txtCopperInnerID.ErropPr = null;
            this.txtCopperInnerID.Length = 0;
            this.txtCopperInnerID.Location = new System.Drawing.Point(108, 136);
            this.txtCopperInnerID.Max = 0;
            this.txtCopperInnerID.MaxStrLength = 0;
            this.txtCopperInnerID.Min = 0;
            this.txtCopperInnerID.MinStrLength = 0;
            this.txtCopperInnerID.Name = "txtCopperInnerID";
            this.txtCopperInnerID.Precision = 0;
            this.txtCopperInnerID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperInnerID.TabIndex = 98;
            this.txtCopperInnerID.ToolTipValid = null;
            this.txtCopperInnerID.ValidEable = true;
            this.txtCopperInnerID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCopperOuterID
            // 
            this.txtCopperOuterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Outer_ID", true));
            this.txtCopperOuterID.EnableNull = true;
            this.txtCopperOuterID.ErropPr = null;
            this.txtCopperOuterID.Length = 0;
            this.txtCopperOuterID.Location = new System.Drawing.Point(108, 161);
            this.txtCopperOuterID.Max = 0;
            this.txtCopperOuterID.MaxStrLength = 0;
            this.txtCopperOuterID.Min = 0;
            this.txtCopperOuterID.MinStrLength = 0;
            this.txtCopperOuterID.Name = "txtCopperOuterID";
            this.txtCopperOuterID.Precision = 0;
            this.txtCopperOuterID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperOuterID.TabIndex = 99;
            this.txtCopperOuterID.ToolTipValid = null;
            this.txtCopperOuterID.ValidEable = true;
            this.txtCopperOuterID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(19, 214);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(83, 12);
            this.label37.TabIndex = 105;
            this.label37.Text = "铜板北侧编号:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(19, 189);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(83, 12);
            this.label38.TabIndex = 104;
            this.label38.Text = "铜板南侧编号:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(19, 165);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(83, 12);
            this.label39.TabIndex = 103;
            this.label39.Text = "铜板外弧编号:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(19, 141);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 12);
            this.label40.TabIndex = 102;
            this.label40.Text = "铜板内弧编号:";
            // 
            // dtOffLine
            // 
            this.dtOffLine.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOffLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OffLine_Time", true));
            this.dtOffLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffLine.Location = new System.Drawing.Point(381, 113);
            this.dtOffLine.Name = "dtOffLine";
            this.dtOffLine.Size = new System.Drawing.Size(141, 21);
            this.dtOffLine.TabIndex = 94;
            // 
            // dtOnLine
            // 
            this.dtOnLine.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOnLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OnLine_Time", true));
            this.dtOnLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOnLine.Location = new System.Drawing.Point(381, 88);
            this.dtOnLine.Name = "dtOnLine";
            this.dtOnLine.Size = new System.Drawing.Size(141, 21);
            this.dtOnLine.TabIndex = 95;
            // 
            // cmbCopperFac
            // 
            this.cmbCopperFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCopperFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCopperFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Copper_Fac", true));
            this.cmbCopperFac.DataSource = this.dsCopperFac;
            this.cmbCopperFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbCopperFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopperFac.EnableNull = false;
            this.cmbCopperFac.ErropPr = this.errorProvider1;
            this.cmbCopperFac.FormattingEnabled = true;
            this.cmbCopperFac.Location = new System.Drawing.Point(108, 112);
            this.cmbCopperFac.Name = "cmbCopperFac";
            this.cmbCopperFac.Size = new System.Drawing.Size(141, 20);
            this.cmbCopperFac.TabIndex = 92;
            this.cmbCopperFac.ToolTipValid = this.toolTip1;
            this.cmbCopperFac.ValidEable = true;
            this.cmbCopperFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsCopperFac
            // 
            this.dsCopperFac.AutoLoad = true;
            this.dsCopperFac.AutoSubscribe = false;
            this.dsCopperFac.DataSetName = "L3DataSet";
            this.dsCopperFac.DeleteMethod = null;
            this.dsCopperFac.InsertMethod = null;
            this.dsCopperFac.L3DataAdapter = this.Adapter;
            this.dsCopperFac.LoadEvent = "Click";
            this.dsCopperFac.LoadTrigger = null;
            this.dsCopperFac.RefreshValve = 1000;
            this.dsCopperFac.SourceCommand = null;
            this.dsCopperFac.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜板\'";
            this.dsCopperFac.SourceMethod = "";
            this.dsCopperFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCopperFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCopperFac.SubscribeTarget = null;
            this.dsCopperFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCopperFac});
            this.dsCopperFac.UpdateEvent = "Click";
            this.dsCopperFac.UpdateMethod = null;
            this.dsCopperFac.UpdateTrigger = null;
            // 
            // schemadsCopperFac
            // 
            this.schemadsCopperFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCopperFacL3DataTableMatFactory});
            this.schemadsCopperFac.TableName = "L3DataTable";
            // 
            // coldsCopperFacL3DataTableMatFactory
            // 
            this.coldsCopperFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(43, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 93;
            this.label19.Text = "铜板厂家:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(108, 238);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(414, 55);
            this.rtxtNote.TabIndex = 91;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(64, 238);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 90;
            this.label46.Text = "备注:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "SHIFTID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(381, 186);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 88;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // pxComboBox11
            // 
            this.pxComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox11.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TEAMID", true));
            this.pxComboBox11.DataSource = this.dsTeamID;
            this.pxComboBox11.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox11.EnableNull = true;
            this.pxComboBox11.ErropPr = null;
            this.pxComboBox11.FormattingEnabled = true;
            this.pxComboBox11.Location = new System.Drawing.Point(381, 162);
            this.pxComboBox11.Name = "pxComboBox11";
            this.pxComboBox11.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox11.TabIndex = 89;
            this.pxComboBox11.ToolTipValid = null;
            this.pxComboBox11.ValidEable = true;
            this.pxComboBox11.ValueMember = "L3DataTable.Code";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "OPERATOR", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(108, 63);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 87;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(340, 186);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 85;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(340, 162);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 86;
            this.label45.Text = "班别:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(55, 67);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 84;
            this.label47.Text = "责任人:";
            // 
            // cmbStopReason
            // 
            this.cmbStopReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStopReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStopReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "STOP_REASON", true));
            this.cmbStopReason.DataSource = this.dsMoldStopReason;
            this.cmbStopReason.DisplayMember = "L3DataTable.Code_Des";
            this.cmbStopReason.EnableNull = true;
            this.cmbStopReason.ErropPr = this.errorProvider1;
            this.cmbStopReason.FormattingEnabled = true;
            this.cmbStopReason.Location = new System.Drawing.Point(381, 138);
            this.cmbStopReason.Name = "cmbStopReason";
            this.cmbStopReason.Size = new System.Drawing.Size(141, 20);
            this.cmbStopReason.TabIndex = 81;
            this.cmbStopReason.ToolTipValid = this.toolTip1;
            this.cmbStopReason.ValidEable = false;
            this.cmbStopReason.ValueMember = "L3DataTable.Code";
            // 
            // dsMoldStopReason
            // 
            this.dsMoldStopReason.AutoLoad = true;
            this.dsMoldStopReason.AutoSubscribe = false;
            this.dsMoldStopReason.DataSetName = "L3DataSet";
            this.dsMoldStopReason.DeleteMethod = null;
            this.dsMoldStopReason.InsertMethod = null;
            this.dsMoldStopReason.L3DataAdapter = this.Adapter;
            this.dsMoldStopReason.LoadEvent = "Click";
            this.dsMoldStopReason.LoadTrigger = null;
            this.dsMoldStopReason.RefreshValve = 1000;
            this.dsMoldStopReason.SourceCommand = null;
            this.dsMoldStopReason.SourceCondition = "CODE_GROUP = \'MoldStopReason\'";
            this.dsMoldStopReason.SourceMethod = "";
            this.dsMoldStopReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldStopReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMoldStopReason.SubscribeTarget = null;
            this.dsMoldStopReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldStopReason});
            this.dsMoldStopReason.UpdateEvent = "Click";
            this.dsMoldStopReason.UpdateMethod = null;
            this.dsMoldStopReason.UpdateTrigger = null;
            // 
            // schemadsMoldStopReason
            // 
            this.schemadsMoldStopReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldStopReasonL3DataTableCode,
            this.coldsMoldStopReasonL3DataTableCode_Des});
            this.schemadsMoldStopReason.TableName = "L3DataTable";
            // 
            // coldsMoldStopReasonL3DataTableCode
            // 
            this.coldsMoldStopReasonL3DataTableCode.Caption = "Code";
            this.coldsMoldStopReasonL3DataTableCode.ColumnName = "Code";
            this.coldsMoldStopReasonL3DataTableCode.Namespace = "";
            // 
            // coldsMoldStopReasonL3DataTableCode_Des
            // 
            this.coldsMoldStopReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMoldStopReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMoldStopReasonL3DataTableCode_Des.Namespace = "";
            // 
            // cmbFlowID
            // 
            this.cmbFlowID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFlowID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlowID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "FLOWID", true));
            this.cmbFlowID.EnableNull = false;
            this.cmbFlowID.ErropPr = this.errorProvider1;
            this.cmbFlowID.FormattingEnabled = true;
            this.cmbFlowID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbFlowID.Location = new System.Drawing.Point(108, 88);
            this.cmbFlowID.Name = "cmbFlowID";
            this.cmbFlowID.Size = new System.Drawing.Size(141, 20);
            this.cmbFlowID.TabIndex = 82;
            this.cmbFlowID.ToolTipValid = this.toolTip1;
            this.cmbFlowID.ValidEable = false;
            // 
            // cmbCastID
            // 
            this.cmbCastID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCastID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCastID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "CAST_ID", true));
            this.cmbCastID.DataSource = this.dsCasterID;
            this.cmbCastID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCastID.EnableNull = false;
            this.cmbCastID.ErropPr = this.errorProvider1;
            this.cmbCastID.FormattingEnabled = true;
            this.cmbCastID.Location = new System.Drawing.Point(108, 39);
            this.cmbCastID.Name = "cmbCastID";
            this.cmbCastID.Size = new System.Drawing.Size(141, 20);
            this.cmbCastID.TabIndex = 83;
            this.cmbCastID.ToolTipValid = this.toolTip1;
            this.cmbCastID.ValidEable = true;
            this.cmbCastID.ValueMember = "L3DataTable.Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(316, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "下线原因:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 78;
            this.label1.Text = "流号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 80;
            this.label2.Text = "铸机号:";
            // 
            // txtLugSteelMea
            // 
            this.txtLugSteelMea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Lug_Steel_Mea", true));
            this.txtLugSteelMea.EnableNull = false;
            this.txtLugSteelMea.ErropPr = this.errorProvider1;
            this.txtLugSteelMea.Length = 0;
            this.txtLugSteelMea.Location = new System.Drawing.Point(381, 14);
            this.txtLugSteelMea.Max = 99999;
            this.txtLugSteelMea.MaxStrLength = 0;
            this.txtLugSteelMea.Min = 0;
            this.txtLugSteelMea.MinStrLength = 0;
            this.txtLugSteelMea.Name = "txtLugSteelMea";
            this.txtLugSteelMea.Precision = 2;
            this.txtLugSteelMea.Size = new System.Drawing.Size(141, 21);
            this.txtLugSteelMea.TabIndex = 75;
            this.txtLugSteelMea.ToolTipValid = this.toolTip1;
            this.txtLugSteelMea.ValidEable = true;
            this.txtLugSteelMea.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTotalPullMea
            // 
            this.txtTotalPullMea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TOTAL_PULL_MEA", true));
            this.txtTotalPullMea.EnableNull = false;
            this.txtTotalPullMea.ErropPr = this.errorProvider1;
            this.txtTotalPullMea.Length = 0;
            this.txtTotalPullMea.Location = new System.Drawing.Point(381, 63);
            this.txtTotalPullMea.Max = 99999;
            this.txtTotalPullMea.MaxStrLength = 0;
            this.txtTotalPullMea.Min = 0;
            this.txtTotalPullMea.MinStrLength = 0;
            this.txtTotalPullMea.Name = "txtTotalPullMea";
            this.txtTotalPullMea.Precision = 0;
            this.txtTotalPullMea.Size = new System.Drawing.Size(141, 21);
            this.txtTotalPullMea.TabIndex = 75;
            this.txtTotalPullMea.ToolTipValid = this.toolTip1;
            this.txtTotalPullMea.ValidEable = true;
            this.txtTotalPullMea.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(304, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 71;
            this.label21.Text = "铜板拉钢量:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(316, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 71;
            this.label7.Text = "下线时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(316, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 71;
            this.label3.Text = "上线时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(304, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "拉钢量累计:";
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "MOLDID", true));
            this.cmbMoldID.DataSource = this.dsMoldID;
            this.cmbMoldID.DisplayMember = "L3DataTable.MoldID";
            this.cmbMoldID.EnableNull = false;
            this.cmbMoldID.ErropPr = this.errorProvider1;
            this.cmbMoldID.FormattingEnabled = true;
            this.cmbMoldID.Location = new System.Drawing.Point(381, 39);
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.Size = new System.Drawing.Size(141, 20);
            this.cmbMoldID.TabIndex = 69;
            this.cmbMoldID.ToolTipValid = this.toolTip1;
            this.cmbMoldID.ValidEable = true;
            this.cmbMoldID.ValueMember = "L3DataTable.MoldID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(304, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 68;
            this.label8.Text = "结晶器编号:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "INPUT_TIME", true));
            this.dtInputTime.Enabled = false;
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(108, 14);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(43, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 66;
            this.label9.Text = "录入时间:";
            // 
            // coldsMainL3DataTableCopper_Fac
            // 
            this.coldsMainL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsMainL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsMainL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableLug_Steel_Mea
            // 
            this.coldsMainL3DataTableLug_Steel_Mea.Caption = "Lug_Steel_Mea";
            this.coldsMainL3DataTableLug_Steel_Mea.ColumnName = "Lug_Steel_Mea";
            this.coldsMainL3DataTableLug_Steel_Mea.DataType = typeof(double);
            this.coldsMainL3DataTableLug_Steel_Mea.Namespace = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "OffLine_Flag", true));
            this.checkBox1.Location = new System.Drawing.Point(287, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 96;
            this.checkBox1.Text = "下线时间:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "OnLine_Flag", true));
            this.checkBox2.Location = new System.Drawing.Point(287, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 16);
            this.checkBox2.TabIndex = 97;
            this.checkBox2.Text = "上线时间:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OffLine_Time", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker1.TabIndex = 94;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OnLine_Time", true));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker2.TabIndex = 95;
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Copper_Fac", true));
            this.pxComboBox1.DataSource = this.dsCopperFac;
            this.pxComboBox1.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox1.EnableNull = false;
            this.pxComboBox1.ErropPr = this.errorProvider1;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Location = new System.Drawing.Point(97, 112);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox1.TabIndex = 92;
            this.pxComboBox1.ToolTipValid = this.toolTip1;
            this.pxComboBox1.ValidEable = true;
            this.pxComboBox1.ValueMember = "L3DataTable.MatFactory";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(32, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 93;
            this.label22.Text = "铜板厂家:";
            // 
            // pxRichTextBox1
            // 
            this.pxRichTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.pxRichTextBox1.EnableNull = true;
            this.pxRichTextBox1.ErropPr = this.errorProvider1;
            this.pxRichTextBox1.Location = new System.Drawing.Point(97, 214);
            this.pxRichTextBox1.MaxStrLength = 125;
            this.pxRichTextBox1.Name = "pxRichTextBox1";
            this.pxRichTextBox1.Size = new System.Drawing.Size(415, 55);
            this.pxRichTextBox1.TabIndex = 91;
            this.pxRichTextBox1.Text = "";
            this.pxRichTextBox1.ToolTipValid = this.toolTip1;
            this.pxRichTextBox1.ValidEable = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(53, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 90;
            this.label23.Text = "备注:";
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "SHIFTID", true));
            this.pxComboBox2.DataSource = this.dsShiftID;
            this.pxComboBox2.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Location = new System.Drawing.Point(371, 184);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox2.TabIndex = 88;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            this.pxComboBox2.ValueMember = "L3DataTable.Code";
            // 
            // pxComboBox3
            // 
            this.pxComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TEAMID", true));
            this.pxComboBox3.DataSource = this.dsTeamID;
            this.pxComboBox3.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox3.EnableNull = true;
            this.pxComboBox3.ErropPr = null;
            this.pxComboBox3.FormattingEnabled = true;
            this.pxComboBox3.Location = new System.Drawing.Point(97, 188);
            this.pxComboBox3.Name = "pxComboBox3";
            this.pxComboBox3.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox3.TabIndex = 89;
            this.pxComboBox3.ToolTipValid = null;
            this.pxComboBox3.ValidEable = true;
            this.pxComboBox3.ValueMember = "L3DataTable.Code";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "OPERATOR", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(97, 61);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox1.TabIndex = 87;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(330, 190);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 85;
            this.label24.Text = "班次:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(56, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 86;
            this.label25.Text = "班别:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(44, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 84;
            this.label26.Text = "责任人:";
            // 
            // pxComboBox4
            // 
            this.pxComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "STOP_REASON", true));
            this.pxComboBox4.DataSource = this.dsMoldStopReason;
            this.pxComboBox4.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox4.Enabled = false;
            this.pxComboBox4.EnableNull = true;
            this.pxComboBox4.ErropPr = this.errorProvider1;
            this.pxComboBox4.FormattingEnabled = true;
            this.pxComboBox4.Location = new System.Drawing.Point(371, 160);
            this.pxComboBox4.Name = "pxComboBox4";
            this.pxComboBox4.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox4.TabIndex = 81;
            this.pxComboBox4.ToolTipValid = this.toolTip1;
            this.pxComboBox4.ValidEable = false;
            this.pxComboBox4.ValueMember = "L3DataTable.Code";
            // 
            // pxComboBox5
            // 
            this.pxComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "FLOWID", true));
            this.pxComboBox5.EnableNull = false;
            this.pxComboBox5.ErropPr = this.errorProvider1;
            this.pxComboBox5.FormattingEnabled = true;
            this.pxComboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.pxComboBox5.Location = new System.Drawing.Point(97, 87);
            this.pxComboBox5.Name = "pxComboBox5";
            this.pxComboBox5.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox5.TabIndex = 82;
            this.pxComboBox5.ToolTipValid = this.toolTip1;
            this.pxComboBox5.ValidEable = false;
            // 
            // pxComboBox6
            // 
            this.pxComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "CAST_ID", true));
            this.pxComboBox6.DataSource = this.dsCasterID;
            this.pxComboBox6.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox6.EnableNull = false;
            this.pxComboBox6.ErropPr = this.errorProvider1;
            this.pxComboBox6.FormattingEnabled = true;
            this.pxComboBox6.Location = new System.Drawing.Point(97, 36);
            this.pxComboBox6.Name = "pxComboBox6";
            this.pxComboBox6.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox6.TabIndex = 83;
            this.pxComboBox6.ToolTipValid = this.toolTip1;
            this.pxComboBox6.ValidEable = true;
            this.pxComboBox6.ValueMember = "L3DataTable.Code";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(306, 166);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 79;
            this.label27.Text = "下线原因:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(56, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 78;
            this.label28.Text = "流号:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(44, 39);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 80;
            this.label29.Text = "铸机号:";
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Lug_Steel_Mea", true));
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(97, 137);
            this.pxTextBox2.Max = 99999;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 2;
            this.pxTextBox2.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox2.TabIndex = 75;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TOTAL_PULL_MEA", true));
            this.pxTextBox3.EnableNull = false;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(371, 85);
            this.pxTextBox3.Max = 99999;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox3.TabIndex = 75;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TOTAL_USE_COUNT", true));
            this.pxTextBox4.EnableNull = false;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(371, 35);
            this.pxTextBox4.Max = 99999;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox4.TabIndex = 74;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CUR_PULL_MEA", true));
            this.pxTextBox5.EnableNull = false;
            this.pxTextBox5.ErropPr = this.errorProvider1;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(371, 60);
            this.pxTextBox5.Max = 99999;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox5.TabIndex = 77;
            this.pxTextBox5.ToolTipValid = this.toolTip1;
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(20, 139);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 12);
            this.label30.TabIndex = 71;
            this.label30.Text = "铜板拉钢量:";
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CUR_USE_COUNT", true));
            this.pxTextBox6.EnableNull = false;
            this.pxTextBox6.ErropPr = this.errorProvider1;
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(371, 10);
            this.pxTextBox6.Max = 99999;
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0;
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            this.pxTextBox6.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox6.TabIndex = 76;
            this.pxTextBox6.ToolTipValid = this.toolTip1;
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(294, 86);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 12);
            this.label31.TabIndex = 71;
            this.label31.Text = "拉钢量累计:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(282, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 12);
            this.label32.TabIndex = 70;
            this.label32.Text = "使用次数累计:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(294, 62);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 12);
            this.label33.TabIndex = 73;
            this.label33.Text = "当班拉钢量:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(282, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 12);
            this.label34.TabIndex = 72;
            this.label34.Text = "当班使用次数:";
            // 
            // pxComboBox7
            // 
            this.pxComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "MOLDID", true));
            this.pxComboBox7.DataSource = this.dsMoldID;
            this.pxComboBox7.DisplayMember = "L3DataTable.MoldID";
            this.pxComboBox7.EnableNull = false;
            this.pxComboBox7.ErropPr = this.errorProvider1;
            this.pxComboBox7.FormattingEnabled = true;
            this.pxComboBox7.Location = new System.Drawing.Point(97, 163);
            this.pxComboBox7.Name = "pxComboBox7";
            this.pxComboBox7.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox7.TabIndex = 69;
            this.pxComboBox7.ToolTipValid = this.toolTip1;
            this.pxComboBox7.ValidEable = true;
            this.pxComboBox7.ValueMember = "L3DataTable.MoldID";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(20, 164);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 12);
            this.label35.TabIndex = 68;
            this.label35.Text = "结晶器编号:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "INPUT_TIME", true));
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(97, 10);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker3.TabIndex = 67;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(32, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 12);
            this.label36.TabIndex = 66;
            this.label36.Text = "录入时间:";
            // 
            // coldsML3DataTableInner_ID
            // 
            this.coldsML3DataTableInner_ID.Caption = "Inner_ID";
            this.coldsML3DataTableInner_ID.ColumnName = "Inner_ID";
            this.coldsML3DataTableInner_ID.Namespace = "";
            // 
            // coldsML3DataTableOuter_ID
            // 
            this.coldsML3DataTableOuter_ID.Caption = "Outer_ID";
            this.coldsML3DataTableOuter_ID.ColumnName = "Outer_ID";
            this.coldsML3DataTableOuter_ID.Namespace = "";
            // 
            // coldsML3DataTableSouth_ID
            // 
            this.coldsML3DataTableSouth_ID.Caption = "South_ID";
            this.coldsML3DataTableSouth_ID.ColumnName = "South_ID";
            this.coldsML3DataTableSouth_ID.Namespace = "";
            // 
            // coldsML3DataTableNorth_ID
            // 
            this.coldsML3DataTableNorth_ID.Caption = "North_ID";
            this.coldsML3DataTableNorth_ID.ColumnName = "North_ID";
            this.coldsML3DataTableNorth_ID.Namespace = "";
            // 
            // MoldBoardParUseShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 398);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MoldBoardParUseShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结晶器铜板使用信息";
            this.Load += new System.EventHandler(this.MoldBoardParUseShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMoldID;
        private System.Data.DataTable schemadsMoldID;
        private System.Data.DataColumn coldsMoldIDL3DataTableMoldID;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbCopperFac;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox pxComboBox11;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbStopReason;
        private PxDataValid.PxComboBox cmbFlowID;
        private PxDataValid.PxComboBox cmbCastID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtLugSteelMea;
        private PxDataValid.PxTextBox txtTotalPullMea;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxComboBox cmbMoldID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label9;
        private AppSvrHMI.L3DataSet dsMoldStopReason;
        private System.Data.DataTable schemadsMoldStopReason;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCopperFac;
        private System.Data.DataTable schemadsCopperFac;
        private System.Data.DataColumn coldsCopperFacL3DataTableMatFactory;
        private System.Data.DataColumn coldsMainL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsMainL3DataTableLug_Steel_Mea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsM;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableName;
        private System.Data.DataColumn coldsML3DataTableInput_Time;
        private System.Data.DataColumn coldsML3DataTableMoldID;
        private System.Data.DataColumn coldsML3DataTableCopper_Fac;
        private System.Data.DataColumn coldsML3DataTableLug_Steel_Mea;
        private System.Data.DataColumn coldsML3DataTableCur_Use_Count;
        private System.Data.DataColumn coldsML3DataTableTotal_Use_Count;
        private System.Data.DataColumn coldsML3DataTableCur_Pull_Mea;
        private System.Data.DataColumn coldsML3DataTableTotal_Pull_Mea;
        private System.Data.DataColumn coldsML3DataTableCast_ID;
        private System.Data.DataColumn coldsML3DataTableFlowID;
        private System.Data.DataColumn coldsML3DataTableStop_Reason;
        private System.Data.DataColumn coldsML3DataTableTeamID;
        private System.Data.DataColumn coldsML3DataTableShiftID;
        private System.Data.DataColumn coldsML3DataTableOperator;
        private System.Data.DataColumn coldsML3DataTableNote;
        private System.Data.DataColumn coldsML3DataTableOffLine_Time;
        private System.Data.DataColumn coldsML3DataTableOffLine_Flag;
        private System.Data.DataColumn coldsML3DataTableOnLine_Flag;
        private System.Data.DataColumn coldsML3DataTableOnLine_Time;
        private System.Windows.Forms.DateTimePicker dtOffLine;
        private System.Windows.Forms.DateTimePicker dtOnLine;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private PxDataValid.PxComboBox pxComboBox1;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxRichTextBox pxRichTextBox1;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxComboBox pxComboBox2;
        private PxDataValid.PxComboBox pxComboBox3;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxComboBox pxComboBox4;
        private PxDataValid.PxComboBox pxComboBox5;
        private PxDataValid.PxComboBox pxComboBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private PxDataValid.PxTextBox pxTextBox2;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox5;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox pxTextBox6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private PxDataValid.PxComboBox pxComboBox7;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label36;
        private PxDataValid.PxTextBox txtCopperNorthID;
        private PxDataValid.PxTextBox txtCopperSouthID;
        private PxDataValid.PxTextBox txtCopperInnerID;
        private PxDataValid.PxTextBox txtCopperOuterID;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Data.DataColumn coldsML3DataTableInner_ID;
        private System.Data.DataColumn coldsML3DataTableOuter_ID;
        private System.Data.DataColumn coldsML3DataTableSouth_ID;
        private System.Data.DataColumn coldsML3DataTableNorth_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn coldsML3DataTableInStallID;
    }
}