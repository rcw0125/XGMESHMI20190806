namespace EquipMag.LanceMag
{
    partial class LanceUseMagShowFrm
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
            this.coldsMainL3DataTableLanceID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLance_Head_Type = new System.Data.DataColumn();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift_Date = new System.Data.DataColumn();
            this.coldsMainL3DataTableCool_Water_Flow = new System.Data.DataColumn();
            this.coldsMainL3DataTableCool_Water_Temp = new System.Data.DataColumn();
            this.coldsMainL3DataTableOxygen_Pressure = new System.Data.DataColumn();
            this.coldsMainL3DataTableOxygen_Flow = new System.Data.DataColumn();
            this.coldsMainL3DataTableFurnace_Count = new System.Data.DataColumn();
            this.coldsMainL3DataTableChange_Lance_Reason = new System.Data.DataColumn();
            this.coldsMainL3DataTableTotal_Lance_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableAmelt_Confirm_Pepole = new System.Data.DataColumn();
            this.coldsMainL3DataTableMaintain_Confirm_Pepole = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbChangeLanceReason = new PxDataValid.PxComboBox();
            this.dsChangeReason = new AppSvrHMI.L3DataSet();
            this.schemadsChangeReason = new System.Data.DataTable();
            this.coldsChangeReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsChangeReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtAmeltConfirmPepole = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.txtOxygenFlow = new PxDataValid.PxTextBox();
            this.txtMaintainConfirmPepole = new PxDataValid.PxTextBox();
            this.txtTotalLanceAge = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtFurnaceCount = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOxygenPressure = new PxDataValid.PxTextBox();
            this.txtCoolWaterTemp = new PxDataValid.PxTextBox();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.txtCoolWaterFlow = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtInputDate = new System.Windows.Forms.DateTimePicker();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanceID = new PxDataValid.PxComboBox();
            this.dsLanceID = new AppSvrHMI.L3DataSet();
            this.schemadsLanceID = new System.Data.DataTable();
            this.coldsLanceIDL3DataTableLanceID = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dsMakeID = new AppSvrHMI.L3DataSet();
            this.schemadsMakeID = new System.Data.DataTable();
            this.coldsMakeIDL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableName = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLanceID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableStatus = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableNozzle_Factury = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLance_Head_Type = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLance_Age = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMakeID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMake_Start_Time = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMake_End_Time = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
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
            this.coldsMainL3DataTableLanceID,
            this.coldsMainL3DataTableLance_Head_Type,
            this.coldsMainL3DataTableHeatID,
            this.coldsMainL3DataTableShift_Date,
            this.coldsMainL3DataTableCool_Water_Flow,
            this.coldsMainL3DataTableCool_Water_Temp,
            this.coldsMainL3DataTableOxygen_Pressure,
            this.coldsMainL3DataTableOxygen_Flow,
            this.coldsMainL3DataTableFurnace_Count,
            this.coldsMainL3DataTableChange_Lance_Reason,
            this.coldsMainL3DataTableTotal_Lance_Age,
            this.coldsMainL3DataTableAmelt_Confirm_Pepole,
            this.coldsMainL3DataTableMaintain_Confirm_Pepole,
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
            // coldsMainL3DataTableLanceID
            // 
            this.coldsMainL3DataTableLanceID.Caption = "LanceID";
            this.coldsMainL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsMainL3DataTableLanceID.Namespace = "";
            // 
            // coldsMainL3DataTableLance_Head_Type
            // 
            this.coldsMainL3DataTableLance_Head_Type.Caption = "Lance_Head_Type";
            this.coldsMainL3DataTableLance_Head_Type.ColumnName = "Lance_Head_Type";
            this.coldsMainL3DataTableLance_Head_Type.Namespace = "";
            // 
            // coldsMainL3DataTableHeatID
            // 
            this.coldsMainL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainL3DataTableShift_Date
            // 
            this.coldsMainL3DataTableShift_Date.Caption = "Shift_Date";
            this.coldsMainL3DataTableShift_Date.ColumnName = "Shift_Date";
            this.coldsMainL3DataTableShift_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableShift_Date.Namespace = "";
            // 
            // coldsMainL3DataTableCool_Water_Flow
            // 
            this.coldsMainL3DataTableCool_Water_Flow.Caption = "Cool_Water_Flow";
            this.coldsMainL3DataTableCool_Water_Flow.ColumnName = "Cool_Water_Flow";
            this.coldsMainL3DataTableCool_Water_Flow.DataType = typeof(double);
            this.coldsMainL3DataTableCool_Water_Flow.Namespace = "";
            // 
            // coldsMainL3DataTableCool_Water_Temp
            // 
            this.coldsMainL3DataTableCool_Water_Temp.Caption = "Cool_Water_Temp";
            this.coldsMainL3DataTableCool_Water_Temp.ColumnName = "Cool_Water_Temp";
            this.coldsMainL3DataTableCool_Water_Temp.DataType = typeof(double);
            this.coldsMainL3DataTableCool_Water_Temp.Namespace = "";
            // 
            // coldsMainL3DataTableOxygen_Pressure
            // 
            this.coldsMainL3DataTableOxygen_Pressure.Caption = "Oxygen_Pressure";
            this.coldsMainL3DataTableOxygen_Pressure.ColumnName = "Oxygen_Pressure";
            this.coldsMainL3DataTableOxygen_Pressure.DataType = typeof(double);
            this.coldsMainL3DataTableOxygen_Pressure.Namespace = "";
            // 
            // coldsMainL3DataTableOxygen_Flow
            // 
            this.coldsMainL3DataTableOxygen_Flow.Caption = "Oxygen_Flow";
            this.coldsMainL3DataTableOxygen_Flow.ColumnName = "Oxygen_Flow";
            this.coldsMainL3DataTableOxygen_Flow.DataType = typeof(double);
            this.coldsMainL3DataTableOxygen_Flow.Namespace = "";
            // 
            // coldsMainL3DataTableFurnace_Count
            // 
            this.coldsMainL3DataTableFurnace_Count.Caption = "Furnace_Count";
            this.coldsMainL3DataTableFurnace_Count.ColumnName = "Furnace_Count";
            this.coldsMainL3DataTableFurnace_Count.DataType = typeof(int);
            this.coldsMainL3DataTableFurnace_Count.Namespace = "";
            // 
            // coldsMainL3DataTableChange_Lance_Reason
            // 
            this.coldsMainL3DataTableChange_Lance_Reason.Caption = "Change_Lance_Reason";
            this.coldsMainL3DataTableChange_Lance_Reason.ColumnName = "Change_Lance_Reason";
            this.coldsMainL3DataTableChange_Lance_Reason.Namespace = "";
            // 
            // coldsMainL3DataTableTotal_Lance_Age
            // 
            this.coldsMainL3DataTableTotal_Lance_Age.Caption = "Total_Lance_Age";
            this.coldsMainL3DataTableTotal_Lance_Age.ColumnName = "Total_Lance_Age";
            this.coldsMainL3DataTableTotal_Lance_Age.DataType = typeof(int);
            this.coldsMainL3DataTableTotal_Lance_Age.Namespace = "";
            // 
            // coldsMainL3DataTableAmelt_Confirm_Pepole
            // 
            this.coldsMainL3DataTableAmelt_Confirm_Pepole.Caption = "Amelt_Confirm_Pepole";
            this.coldsMainL3DataTableAmelt_Confirm_Pepole.ColumnName = "Amelt_Confirm_Pepole";
            this.coldsMainL3DataTableAmelt_Confirm_Pepole.Namespace = "";
            // 
            // coldsMainL3DataTableMaintain_Confirm_Pepole
            // 
            this.coldsMainL3DataTableMaintain_Confirm_Pepole.Caption = "Maintain_Confirm_Pepole";
            this.coldsMainL3DataTableMaintain_Confirm_Pepole.ColumnName = "Maintain_Confirm_Pepole";
            this.coldsMainL3DataTableMaintain_Confirm_Pepole.Namespace = "";
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(476, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(395, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 337);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 60);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 337);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.cmbChangeLanceReason);
            this.tabPage1.Controls.Add(this.txtAmeltConfirmPepole);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.txtOxygenFlow);
            this.tabPage1.Controls.Add(this.txtMaintainConfirmPepole);
            this.tabPage1.Controls.Add(this.txtTotalLanceAge);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.txtFurnaceCount);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txtOxygenPressure);
            this.tabPage1.Controls.Add(this.txtCoolWaterTemp);
            this.tabPage1.Controls.Add(this.txtHeatID);
            this.tabPage1.Controls.Add(this.txtCoolWaterFlow);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtInputDate);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbLanceID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "氧枪使用实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(115, 221);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(404, 83);
            this.rtxtNote.TabIndex = 88;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.cmbShiftID.Location = new System.Drawing.Point(375, 167);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(144, 20);
            this.cmbShiftID.TabIndex = 81;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
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
            this.cmbTeamID.Location = new System.Drawing.Point(375, 142);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(144, 20);
            this.cmbTeamID.TabIndex = 80;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(334, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "班次:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(334, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 87;
            this.label25.Text = "班别:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(74, 220);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 12);
            this.label27.TabIndex = 84;
            this.label27.Text = "备注:";
            // 
            // cmbChangeLanceReason
            // 
            this.cmbChangeLanceReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbChangeLanceReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbChangeLanceReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Change_Lance_Reason", true));
            this.cmbChangeLanceReason.DataSource = this.dsChangeReason;
            this.cmbChangeLanceReason.DisplayMember = "L3DataTable.Code_Des";
            this.cmbChangeLanceReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChangeLanceReason.EnableNull = true;
            this.cmbChangeLanceReason.ErropPr = null;
            this.cmbChangeLanceReason.FormattingEnabled = true;
            this.cmbChangeLanceReason.Location = new System.Drawing.Point(375, 117);
            this.cmbChangeLanceReason.Name = "cmbChangeLanceReason";
            this.cmbChangeLanceReason.Size = new System.Drawing.Size(144, 20);
            this.cmbChangeLanceReason.TabIndex = 15;
            this.cmbChangeLanceReason.ToolTipValid = null;
            this.cmbChangeLanceReason.ValidEable = true;
            this.cmbChangeLanceReason.ValueMember = "L3DataTable.Code";
            // 
            // dsChangeReason
            // 
            this.dsChangeReason.AutoLoad = true;
            this.dsChangeReason.AutoSubscribe = false;
            this.dsChangeReason.DataSetName = "L3DataSet";
            this.dsChangeReason.DeleteMethod = null;
            this.dsChangeReason.InsertMethod = null;
            this.dsChangeReason.L3DataAdapter = this.Adapter;
            this.dsChangeReason.LoadEvent = "Click";
            this.dsChangeReason.LoadTrigger = null;
            this.dsChangeReason.RefreshValve = 1000;
            this.dsChangeReason.SourceCommand = null;
            this.dsChangeReason.SourceCondition = "Code_Group = \'LanceChangeReason\' order by Code";
            this.dsChangeReason.SourceMethod = "";
            this.dsChangeReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsChangeReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsChangeReason.SubscribeTarget = null;
            this.dsChangeReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChangeReason});
            this.dsChangeReason.UpdateEvent = "Click";
            this.dsChangeReason.UpdateMethod = null;
            this.dsChangeReason.UpdateTrigger = null;
            // 
            // schemadsChangeReason
            // 
            this.schemadsChangeReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChangeReasonL3DataTableCode,
            this.coldsChangeReasonL3DataTableCode_Des});
            this.schemadsChangeReason.TableName = "L3DataTable";
            // 
            // coldsChangeReasonL3DataTableCode
            // 
            this.coldsChangeReasonL3DataTableCode.Caption = "Code";
            this.coldsChangeReasonL3DataTableCode.ColumnName = "Code";
            this.coldsChangeReasonL3DataTableCode.Namespace = "";
            // 
            // coldsChangeReasonL3DataTableCode_Des
            // 
            this.coldsChangeReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsChangeReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsChangeReasonL3DataTableCode_Des.Namespace = "";
            // 
            // txtAmeltConfirmPepole
            // 
            this.txtAmeltConfirmPepole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Amelt_Confirm_Pepole", true));
            this.txtAmeltConfirmPepole.EnableNull = true;
            this.txtAmeltConfirmPepole.ErropPr = null;
            this.txtAmeltConfirmPepole.Length = 0;
            this.txtAmeltConfirmPepole.Location = new System.Drawing.Point(375, 91);
            this.txtAmeltConfirmPepole.Max = 0;
            this.txtAmeltConfirmPepole.MaxStrLength = 0;
            this.txtAmeltConfirmPepole.Min = 0;
            this.txtAmeltConfirmPepole.MinStrLength = 0;
            this.txtAmeltConfirmPepole.Name = "txtAmeltConfirmPepole";
            this.txtAmeltConfirmPepole.Precision = 0;
            this.txtAmeltConfirmPepole.Size = new System.Drawing.Size(144, 21);
            this.txtAmeltConfirmPepole.TabIndex = 13;
            this.txtAmeltConfirmPepole.ToolTipValid = null;
            this.txtAmeltConfirmPepole.ValidEable = true;
            this.txtAmeltConfirmPepole.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(310, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 62;
            this.label23.Text = "换枪原因:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(298, 94);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 12);
            this.label26.TabIndex = 63;
            this.label26.Text = "冶炼确认人:";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(375, 193);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(144, 21);
            this.txtOperator.TabIndex = 8;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtOxygenFlow
            // 
            this.txtOxygenFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Oxygen_Flow", true));
            this.txtOxygenFlow.EnableNull = false;
            this.txtOxygenFlow.ErropPr = this.errorProvider1;
            this.txtOxygenFlow.Length = 0;
            this.txtOxygenFlow.Location = new System.Drawing.Point(115, 194);
            this.txtOxygenFlow.Max = 99999;
            this.txtOxygenFlow.MaxStrLength = 0;
            this.txtOxygenFlow.Min = 0;
            this.txtOxygenFlow.MinStrLength = 0;
            this.txtOxygenFlow.Name = "txtOxygenFlow";
            this.txtOxygenFlow.Precision = 2;
            this.txtOxygenFlow.Size = new System.Drawing.Size(144, 21);
            this.txtOxygenFlow.TabIndex = 8;
            this.txtOxygenFlow.ToolTipValid = this.toolTip1;
            this.txtOxygenFlow.ValidEable = true;
            this.txtOxygenFlow.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMaintainConfirmPepole
            // 
            this.txtMaintainConfirmPepole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Maintain_Confirm_Pepole", true));
            this.txtMaintainConfirmPepole.EnableNull = true;
            this.txtMaintainConfirmPepole.ErropPr = null;
            this.txtMaintainConfirmPepole.Length = 0;
            this.txtMaintainConfirmPepole.Location = new System.Drawing.Point(375, 65);
            this.txtMaintainConfirmPepole.Max = 0;
            this.txtMaintainConfirmPepole.MaxStrLength = 0;
            this.txtMaintainConfirmPepole.Min = 0;
            this.txtMaintainConfirmPepole.MinStrLength = 0;
            this.txtMaintainConfirmPepole.Name = "txtMaintainConfirmPepole";
            this.txtMaintainConfirmPepole.Precision = 0;
            this.txtMaintainConfirmPepole.Size = new System.Drawing.Size(144, 21);
            this.txtMaintainConfirmPepole.TabIndex = 11;
            this.txtMaintainConfirmPepole.ToolTipValid = null;
            this.txtMaintainConfirmPepole.ValidEable = true;
            this.txtMaintainConfirmPepole.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTotalLanceAge
            // 
            this.txtTotalLanceAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Total_Lance_Age", true));
            this.txtTotalLanceAge.EnableNull = false;
            this.txtTotalLanceAge.ErropPr = this.errorProvider1;
            this.txtTotalLanceAge.Length = 0;
            this.txtTotalLanceAge.Location = new System.Drawing.Point(375, 39);
            this.txtTotalLanceAge.Max = 9999;
            this.txtTotalLanceAge.MaxStrLength = 0;
            this.txtTotalLanceAge.Min = 0;
            this.txtTotalLanceAge.MinStrLength = 0;
            this.txtTotalLanceAge.Name = "txtTotalLanceAge";
            this.txtTotalLanceAge.Precision = 0;
            this.txtTotalLanceAge.Size = new System.Drawing.Size(144, 21);
            this.txtTotalLanceAge.TabIndex = 10;
            this.txtTotalLanceAge.ToolTipValid = this.toolTip1;
            this.txtTotalLanceAge.ValidEable = true;
            this.txtTotalLanceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(322, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 12);
            this.label24.TabIndex = 54;
            this.label24.Text = "责任人:";
            // 
            // txtFurnaceCount
            // 
            this.txtFurnaceCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Furnace_Count", true));
            this.txtFurnaceCount.EnableNull = false;
            this.txtFurnaceCount.ErropPr = this.errorProvider1;
            this.txtFurnaceCount.Length = 0;
            this.txtFurnaceCount.Location = new System.Drawing.Point(375, 13);
            this.txtFurnaceCount.Max = 99;
            this.txtFurnaceCount.MaxStrLength = 0;
            this.txtFurnaceCount.Min = 0;
            this.txtFurnaceCount.MinStrLength = 0;
            this.txtFurnaceCount.Name = "txtFurnaceCount";
            this.txtFurnaceCount.Precision = 0;
            this.txtFurnaceCount.Size = new System.Drawing.Size(144, 21);
            this.txtFurnaceCount.TabIndex = 9;
            this.txtFurnaceCount.ToolTipValid = this.toolTip1;
            this.txtFurnaceCount.ValidEable = true;
            this.txtFurnaceCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(14, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "氧气(工作)流量:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(298, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 53;
            this.label19.Text = "维修确认人:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(310, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 56;
            this.label21.Text = "累计枪龄:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(286, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 12);
            this.label22.TabIndex = 55;
            this.label22.Text = "当班使用炉数:";
            // 
            // txtOxygenPressure
            // 
            this.txtOxygenPressure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Oxygen_Pressure", true));
            this.txtOxygenPressure.EnableNull = false;
            this.txtOxygenPressure.ErropPr = this.errorProvider1;
            this.txtOxygenPressure.Length = 0;
            this.txtOxygenPressure.Location = new System.Drawing.Point(115, 168);
            this.txtOxygenPressure.Max = 9999;
            this.txtOxygenPressure.MaxStrLength = 0;
            this.txtOxygenPressure.Min = 0;
            this.txtOxygenPressure.MinStrLength = 0;
            this.txtOxygenPressure.Name = "txtOxygenPressure";
            this.txtOxygenPressure.Precision = 2;
            this.txtOxygenPressure.Size = new System.Drawing.Size(144, 21);
            this.txtOxygenPressure.TabIndex = 7;
            this.txtOxygenPressure.ToolTipValid = this.toolTip1;
            this.txtOxygenPressure.ValidEable = true;
            this.txtOxygenPressure.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCoolWaterTemp
            // 
            this.txtCoolWaterTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cool_Water_Temp", true));
            this.txtCoolWaterTemp.EnableNull = false;
            this.txtCoolWaterTemp.ErropPr = this.errorProvider1;
            this.txtCoolWaterTemp.Length = 0;
            this.txtCoolWaterTemp.Location = new System.Drawing.Point(115, 142);
            this.txtCoolWaterTemp.Max = 9999;
            this.txtCoolWaterTemp.MaxStrLength = 0;
            this.txtCoolWaterTemp.Min = 0;
            this.txtCoolWaterTemp.MinStrLength = 0;
            this.txtCoolWaterTemp.Name = "txtCoolWaterTemp";
            this.txtCoolWaterTemp.Precision = 2;
            this.txtCoolWaterTemp.Size = new System.Drawing.Size(144, 21);
            this.txtCoolWaterTemp.TabIndex = 6;
            this.txtCoolWaterTemp.ToolTipValid = this.toolTip1;
            this.txtCoolWaterTemp.ValidEable = true;
            this.txtCoolWaterTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "HeatID", true));
            this.txtHeatID.EnableNull = true;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 0;
            this.txtHeatID.Location = new System.Drawing.Point(115, 90);
            this.txtHeatID.Max = 0;
            this.txtHeatID.MaxLength = 9;
            this.txtHeatID.MaxStrLength = 9;
            this.txtHeatID.Min = 0;
            this.txtHeatID.MinStrLength = 9;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Precision = 0;
            this.txtHeatID.Size = new System.Drawing.Size(144, 21);
            this.txtHeatID.TabIndex = 5;
            this.txtHeatID.ToolTipValid = this.toolTip1;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCoolWaterFlow
            // 
            this.txtCoolWaterFlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cool_Water_Flow", true));
            this.txtCoolWaterFlow.EnableNull = false;
            this.txtCoolWaterFlow.ErropPr = this.errorProvider1;
            this.txtCoolWaterFlow.Length = 0;
            this.txtCoolWaterFlow.Location = new System.Drawing.Point(115, 116);
            this.txtCoolWaterFlow.Max = 9999;
            this.txtCoolWaterFlow.MaxStrLength = 0;
            this.txtCoolWaterFlow.Min = 0;
            this.txtCoolWaterFlow.MinStrLength = 0;
            this.txtCoolWaterFlow.Name = "txtCoolWaterFlow";
            this.txtCoolWaterFlow.Precision = 2;
            this.txtCoolWaterFlow.Size = new System.Drawing.Size(144, 21);
            this.txtCoolWaterFlow.TabIndex = 5;
            this.txtCoolWaterFlow.ToolTipValid = this.toolTip1;
            this.txtCoolWaterFlow.ValidEable = true;
            this.txtCoolWaterFlow.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "氧气(工作)压力:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(38, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 48;
            this.label7.Text = "冷却水温差:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(38, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "冷却水流量:";
            // 
            // dtInputDate
            // 
            this.dtInputDate.CustomFormat = "yyyy-MM-dd";
            this.dtInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Shift_Date", true));
            this.dtInputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputDate.Location = new System.Drawing.Point(115, 39);
            this.dtInputDate.Name = "dtInputDate";
            this.dtInputDate.Size = new System.Drawing.Size(144, 21);
            this.dtInputDate.TabIndex = 1;
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(115, 13);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(144, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "当班日期:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "录入时间:";
            // 
            // cmbLanceID
            // 
            this.cmbLanceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLanceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLanceID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "LanceID", true));
            this.cmbLanceID.DataSource = this.dsLanceID;
            this.cmbLanceID.DisplayMember = "L3DataTable.LanceID";
            this.cmbLanceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanceID.EnableNull = false;
            this.cmbLanceID.ErropPr = this.errorProvider1;
            this.cmbLanceID.FormattingEnabled = true;
            this.cmbLanceID.Location = new System.Drawing.Point(115, 65);
            this.cmbLanceID.Name = "cmbLanceID";
            this.cmbLanceID.Size = new System.Drawing.Size(144, 20);
            this.cmbLanceID.TabIndex = 2;
            this.cmbLanceID.ToolTipValid = this.toolTip1;
            this.cmbLanceID.ValidEable = true;
            this.cmbLanceID.ValueMember = "L3DataTable.LanceID";
            this.cmbLanceID.SelectedValueChanged += new System.EventHandler(this.cmbLanceID_SelectedValueChanged);
            // 
            // dsLanceID
            // 
            this.dsLanceID.AutoLoad = true;
            this.dsLanceID.AutoSubscribe = false;
            this.dsLanceID.DataSetName = "L3DataSet";
            this.dsLanceID.DeleteMethod = null;
            this.dsLanceID.InsertMethod = null;
            this.dsLanceID.L3DataAdapter = this.Adapter;
            this.dsLanceID.LoadEvent = "Click";
            this.dsLanceID.LoadTrigger = null;
            this.dsLanceID.RefreshValve = 1000;
            this.dsLanceID.SourceCommand = null;
            this.dsLanceID.SourceCondition = null;
            this.dsLanceID.SourceMethod = "";
            this.dsLanceID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsLanceID.SubscribeTarget = null;
            this.dsLanceID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceID});
            this.dsLanceID.UpdateEvent = "Click";
            this.dsLanceID.UpdateMethod = null;
            this.dsLanceID.UpdateTrigger = null;
            // 
            // schemadsLanceID
            // 
            this.schemadsLanceID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceIDL3DataTableLanceID});
            this.schemadsLanceID.TableName = "L3DataTable";
            // 
            // coldsLanceIDL3DataTableLanceID
            // 
            this.coldsLanceIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.Namespace = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(74, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "炉号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(50, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "氧枪编号:";
            // 
            // dsMakeID
            // 
            this.dsMakeID.AutoLoad = true;
            this.dsMakeID.AutoSubscribe = false;
            this.dsMakeID.DataSetName = "L3DataSet";
            this.dsMakeID.DeleteMethod = null;
            this.dsMakeID.InsertMethod = null;
            this.dsMakeID.L3DataAdapter = null;
            this.dsMakeID.LoadEvent = "Click";
            this.dsMakeID.LoadTrigger = null;
            this.dsMakeID.RefreshValve = 1000;
            this.dsMakeID.SourceCommand = null;
            this.dsMakeID.SourceCondition = null;
            this.dsMakeID.SourceMethod = "";
            this.dsMakeID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMakeID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsMakeID.SubscribeTarget = null;
            this.dsMakeID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMakeID});
            this.dsMakeID.UpdateEvent = "Click";
            this.dsMakeID.UpdateMethod = null;
            this.dsMakeID.UpdateTrigger = null;
            // 
            // schemadsMakeID
            // 
            this.schemadsMakeID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMakeIDL3DataTableGUID,
            this.coldsMakeIDL3DataTableName,
            this.coldsMakeIDL3DataTableLanceID,
            this.coldsMakeIDL3DataTableBOFID,
            this.coldsMakeIDL3DataTableStatus,
            this.coldsMakeIDL3DataTableNozzle_Factury,
            this.coldsMakeIDL3DataTableLance_Head_Type,
            this.coldsMakeIDL3DataTableLance_Age,
            this.coldsMakeIDL3DataTableMakeID,
            this.coldsMakeIDL3DataTableMake_Start_Time,
            this.coldsMakeIDL3DataTableMake_End_Time});
            this.schemadsMakeID.TableName = "L3DataTable";
            // 
            // coldsMakeIDL3DataTableGUID
            // 
            this.coldsMakeIDL3DataTableGUID.Caption = "GUID";
            this.coldsMakeIDL3DataTableGUID.ColumnName = "GUID";
            this.coldsMakeIDL3DataTableGUID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableName
            // 
            this.coldsMakeIDL3DataTableName.Caption = "Name";
            this.coldsMakeIDL3DataTableName.ColumnName = "Name";
            this.coldsMakeIDL3DataTableName.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLanceID
            // 
            this.coldsMakeIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableBOFID
            // 
            this.coldsMakeIDL3DataTableBOFID.Caption = "BOFID";
            this.coldsMakeIDL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsMakeIDL3DataTableBOFID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableStatus
            // 
            this.coldsMakeIDL3DataTableStatus.Caption = "Status";
            this.coldsMakeIDL3DataTableStatus.ColumnName = "Status";
            this.coldsMakeIDL3DataTableStatus.Namespace = "";
            // 
            // coldsMakeIDL3DataTableNozzle_Factury
            // 
            this.coldsMakeIDL3DataTableNozzle_Factury.Caption = "Nozzle_Factury";
            this.coldsMakeIDL3DataTableNozzle_Factury.ColumnName = "Nozzle_Factury";
            this.coldsMakeIDL3DataTableNozzle_Factury.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLance_Head_Type
            // 
            this.coldsMakeIDL3DataTableLance_Head_Type.Caption = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.ColumnName = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLance_Age
            // 
            this.coldsMakeIDL3DataTableLance_Age.Caption = "Lance_Age";
            this.coldsMakeIDL3DataTableLance_Age.ColumnName = "Lance_Age";
            this.coldsMakeIDL3DataTableLance_Age.DataType = typeof(int);
            this.coldsMakeIDL3DataTableLance_Age.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMakeID
            // 
            this.coldsMakeIDL3DataTableMakeID.Caption = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMake_Start_Time
            // 
            this.coldsMakeIDL3DataTableMake_Start_Time.Caption = "Make_Start_Time";
            this.coldsMakeIDL3DataTableMake_Start_Time.ColumnName = "Make_Start_Time";
            this.coldsMakeIDL3DataTableMake_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMakeIDL3DataTableMake_Start_Time.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMake_End_Time
            // 
            this.coldsMakeIDL3DataTableMake_End_Time.Caption = "Make_End_Time";
            this.coldsMakeIDL3DataTableMake_End_Time.ColumnName = "Make_End_Time";
            this.coldsMakeIDL3DataTableMake_End_Time.DataType = typeof(System.DateTime);
            this.coldsMakeIDL3DataTableMake_End_Time.Namespace = "";
            // 
            // LanceUseMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 397);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LanceUseMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "氧枪使用实绩维护";
            this.Load += new System.EventHandler(this.LanceUseMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsMain;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbChangeLanceReason;
        private PxDataValid.PxTextBox txtAmeltConfirmPepole;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxTextBox txtOxygenFlow;
        private PxDataValid.PxTextBox txtMaintainConfirmPepole;
        private PxDataValid.PxTextBox txtTotalLanceAge;
        private PxDataValid.PxTextBox txtFurnaceCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxTextBox txtOxygenPressure;
        private PxDataValid.PxTextBox txtCoolWaterTemp;
        private PxDataValid.PxTextBox txtHeatID;
        private PxDataValid.PxTextBox txtCoolWaterFlow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtInputDate;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox cmbLanceID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableLanceID;
        private System.Data.DataColumn coldsMainL3DataTableLance_Head_Type;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableShift_Date;
        private System.Data.DataColumn coldsMainL3DataTableCool_Water_Flow;
        private System.Data.DataColumn coldsMainL3DataTableCool_Water_Temp;
        private System.Data.DataColumn coldsMainL3DataTableOxygen_Pressure;
        private System.Data.DataColumn coldsMainL3DataTableOxygen_Flow;
        private System.Data.DataColumn coldsMainL3DataTableFurnace_Count;
        private System.Data.DataColumn coldsMainL3DataTableChange_Lance_Reason;
        private System.Data.DataColumn coldsMainL3DataTableTotal_Lance_Age;
        private System.Data.DataColumn coldsMainL3DataTableAmelt_Confirm_Pepole;
        private System.Data.DataColumn coldsMainL3DataTableMaintain_Confirm_Pepole;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private AppSvrHMI.L3DataSet dsLanceID;
        private System.Data.DataTable schemadsLanceID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private AppSvrHMI.L3DataSet dsChangeReason;
        private System.Data.DataTable schemadsChangeReason;
        private System.Data.DataColumn coldsChangeReasonL3DataTableCode;
        private System.Data.DataColumn coldsChangeReasonL3DataTableCode_Des;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private AppSvrHMI.L3DataSet dsMakeID;
        private System.Data.DataTable schemadsMakeID;
        private System.Data.DataColumn coldsMakeIDL3DataTableGUID;
        private System.Data.DataColumn coldsMakeIDL3DataTableName;
        private System.Data.DataColumn coldsMakeIDL3DataTableLanceID;
        private System.Data.DataColumn coldsMakeIDL3DataTableBOFID;
        private System.Data.DataColumn coldsMakeIDL3DataTableStatus;
        private System.Data.DataColumn coldsMakeIDL3DataTableNozzle_Factury;
        private System.Data.DataColumn coldsMakeIDL3DataTableLance_Head_Type;
        private System.Data.DataColumn coldsMakeIDL3DataTableLance_Age;
        private System.Data.DataColumn coldsMakeIDL3DataTableMakeID;
        private System.Data.DataColumn coldsMakeIDL3DataTableMake_Start_Time;
        private System.Data.DataColumn coldsMakeIDL3DataTableMake_End_Time;
    }
}