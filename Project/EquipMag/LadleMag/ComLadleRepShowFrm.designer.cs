namespace EquipMag.LadleMag
{
    partial class ComLadleRepShowFrm
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
            this.coldsMainL3DataTableRepID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableRep_Ladle_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableRep_Date = new System.Data.DataColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pxComboBox10 = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.pxComboBox11 = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.txtRepID = new PxDataValid.PxTextBox();
            this.pxTextBox18 = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.pxComboBox4 = new PxDataValid.PxComboBox();
            this.dsCastMat = new AppSvrHMI.L3DataSet();
            this.schemadsCastMat = new System.Data.DataTable();
            this.coldsCastMatL3DataTableMatFactory = new System.Data.DataColumn();
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.dsBreBri = new AppSvrHMI.L3DataSet();
            this.schemadsBreBri = new System.Data.DataTable();
            this.coldsBreBriL3DataTableMatFactory = new System.Data.DataColumn();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.dsGapBri = new AppSvrHMI.L3DataSet();
            this.schemadsGapBri = new System.Data.DataTable();
            this.coldsGapBriL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsGapBriL3DataTableMatName = new System.Data.DataColumn();
            this.coldsGapBriL3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pxTextBox13 = new PxDataValid.PxTextBox();
            this.txtCastWast = new PxDataValid.PxTextBox();
            this.txtBreatheBriWast = new PxDataValid.PxTextBox();
            this.txtWaterGapBriWast = new PxDataValid.PxTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).BeginInit();
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
            this.coldsMainL3DataTableRepID,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableWater_gap_Bri_Fac,
            this.coldsMainL3DataTableWater_gap_Bri_Wast,
            this.coldsMainL3DataTableBreathe_Bri_Fac,
            this.coldsMainL3DataTableBreathe_Bri_Wast,
            this.coldsMainL3DataTableCast_Fac,
            this.coldsMainL3DataTableCast_Wast,
            this.coldsMainL3DataTableFire_Start_Time,
            this.coldsMainL3DataTableFire_End_Time,
            this.coldsMainL3DataTableRep_Ladle_Operator,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableRep_Date});
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
            // coldsMainL3DataTableRepID
            // 
            this.coldsMainL3DataTableRepID.Caption = "RepID";
            this.coldsMainL3DataTableRepID.ColumnName = "RepID";
            this.coldsMainL3DataTableRepID.DataType = typeof(int);
            this.coldsMainL3DataTableRepID.Namespace = "";
            // 
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableWater_gap_Bri_Fac
            // 
            this.coldsMainL3DataTableWater_gap_Bri_Fac.Caption = "Water_gap_Bri_Fac";
            this.coldsMainL3DataTableWater_gap_Bri_Fac.ColumnName = "Water_gap_Bri_Fac";
            this.coldsMainL3DataTableWater_gap_Bri_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableWater_gap_Bri_Wast
            // 
            this.coldsMainL3DataTableWater_gap_Bri_Wast.Caption = "Water_gap_Bri_Wast";
            this.coldsMainL3DataTableWater_gap_Bri_Wast.ColumnName = "Water_gap_Bri_Wast";
            this.coldsMainL3DataTableWater_gap_Bri_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableWater_gap_Bri_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBreathe_Bri_Fac
            // 
            this.coldsMainL3DataTableBreathe_Bri_Fac.Caption = "Breathe_Bri_Fac";
            this.coldsMainL3DataTableBreathe_Bri_Fac.ColumnName = "Breathe_Bri_Fac";
            this.coldsMainL3DataTableBreathe_Bri_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableBreathe_Bri_Wast
            // 
            this.coldsMainL3DataTableBreathe_Bri_Wast.Caption = "Breathe_Bri_Wast";
            this.coldsMainL3DataTableBreathe_Bri_Wast.ColumnName = "Breathe_Bri_Wast";
            this.coldsMainL3DataTableBreathe_Bri_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableBreathe_Bri_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableCast_Fac
            // 
            this.coldsMainL3DataTableCast_Fac.Caption = "Cast_Fac";
            this.coldsMainL3DataTableCast_Fac.ColumnName = "Cast_Fac";
            this.coldsMainL3DataTableCast_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableCast_Wast
            // 
            this.coldsMainL3DataTableCast_Wast.Caption = "Cast_Wast";
            this.coldsMainL3DataTableCast_Wast.ColumnName = "Cast_Wast";
            this.coldsMainL3DataTableCast_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableCast_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableFire_Start_Time
            // 
            this.coldsMainL3DataTableFire_Start_Time.Caption = "Fire_Start_Time";
            this.coldsMainL3DataTableFire_Start_Time.ColumnName = "Fire_Start_Time";
            this.coldsMainL3DataTableFire_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFire_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableFire_End_Time
            // 
            this.coldsMainL3DataTableFire_End_Time.Caption = "Fire_End_Time";
            this.coldsMainL3DataTableFire_End_Time.ColumnName = "Fire_End_Time";
            this.coldsMainL3DataTableFire_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFire_End_Time.Namespace = "";
            // 
            // coldsMainL3DataTableRep_Ladle_Operator
            // 
            this.coldsMainL3DataTableRep_Ladle_Operator.Caption = "Rep_Ladle_Operator";
            this.coldsMainL3DataTableRep_Ladle_Operator.ColumnName = "Rep_Ladle_Operator";
            this.coldsMainL3DataTableRep_Ladle_Operator.Namespace = "";
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
            // coldsMainL3DataTableRep_Date
            // 
            this.coldsMainL3DataTableRep_Date.Caption = "Rep_Date";
            this.coldsMainL3DataTableRep_Date.ColumnName = "Rep_Date";
            this.coldsMainL3DataTableRep_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableRep_Date.Namespace = "";
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 274);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.pxComboBox10);
            this.tabPage1.Controls.Add(this.pxComboBox11);
            this.tabPage1.Controls.Add(this.pxTextBox1);
            this.tabPage1.Controls.Add(this.txtRepID);
            this.tabPage1.Controls.Add(this.pxTextBox18);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.pxComboBox4);
            this.tabPage1.Controls.Add(this.pxComboBox2);
            this.tabPage1.Controls.Add(this.pxComboBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker5);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker4);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pxTextBox13);
            this.tabPage1.Controls.Add(this.txtCastWast);
            this.tabPage1.Controls.Add(this.txtBreatheBriWast);
            this.tabPage1.Controls.Add(this.txtWaterGapBriWast);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修补实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(95, 199);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(405, 42);
            this.rtxtNote.TabIndex = 87;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pxComboBox10
            // 
            this.pxComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox10.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.pxComboBox10.DataSource = this.dsShiftID;
            this.pxComboBox10.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox10.EnableNull = true;
            this.pxComboBox10.ErropPr = null;
            this.pxComboBox10.FormattingEnabled = true;
            this.pxComboBox10.Location = new System.Drawing.Point(95, 174);
            this.pxComboBox10.Name = "pxComboBox10";
            this.pxComboBox10.Size = new System.Drawing.Size(139, 20);
            this.pxComboBox10.TabIndex = 7;
            this.pxComboBox10.ToolTipValid = null;
            this.pxComboBox10.ValidEable = true;
            this.pxComboBox10.ValueMember = "L3DataTable.Code";
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
            // pxComboBox11
            // 
            this.pxComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox11.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TeamID", true));
            this.pxComboBox11.DataSource = this.dsTeamID;
            this.pxComboBox11.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox11.EnableNull = true;
            this.pxComboBox11.ErropPr = null;
            this.pxComboBox11.FormattingEnabled = true;
            this.pxComboBox11.Location = new System.Drawing.Point(95, 151);
            this.pxComboBox11.Name = "pxComboBox11";
            this.pxComboBox11.Size = new System.Drawing.Size(139, 20);
            this.pxComboBox11.TabIndex = 6;
            this.pxComboBox11.ToolTipValid = null;
            this.pxComboBox11.ValidEable = true;
            this.pxComboBox11.ValueMember = "L3DataTable.Code";
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
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LadleID", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(95, 35);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 4;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 4;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.ReadOnly = true;
            this.pxTextBox1.Size = new System.Drawing.Size(139, 21);
            this.pxTextBox1.TabIndex = 2;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = false;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtRepID
            // 
            this.txtRepID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "RepID", true));
            this.txtRepID.EnableNull = false;
            this.txtRepID.ErropPr = this.errorProvider1;
            this.txtRepID.Length = 0;
            this.txtRepID.Location = new System.Drawing.Point(95, 58);
            this.txtRepID.Max = 0;
            this.txtRepID.MaxStrLength = 0;
            this.txtRepID.Min = 0;
            this.txtRepID.MinStrLength = 0;
            this.txtRepID.Name = "txtRepID";
            this.txtRepID.Precision = 0;
            this.txtRepID.ReadOnly = true;
            this.txtRepID.Size = new System.Drawing.Size(139, 21);
            this.txtRepID.TabIndex = 2;
            this.txtRepID.ToolTipValid = this.toolTip1;
            this.txtRepID.ValidEable = true;
            this.txtRepID.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox18
            // 
            this.pxTextBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.pxTextBox18.EnableNull = true;
            this.pxTextBox18.ErropPr = null;
            this.pxTextBox18.Length = 0;
            this.pxTextBox18.Location = new System.Drawing.Point(361, 172);
            this.pxTextBox18.Max = 0;
            this.pxTextBox18.MaxStrLength = 0;
            this.pxTextBox18.Min = 0;
            this.pxTextBox18.MinStrLength = 0;
            this.pxTextBox18.Name = "pxTextBox18";
            this.pxTextBox18.Precision = 0;
            this.pxTextBox18.Size = new System.Drawing.Size(139, 21);
            this.pxTextBox18.TabIndex = 15;
            this.pxTextBox18.ToolTipValid = null;
            this.pxTextBox18.ValidEable = true;
            this.pxTextBox18.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(54, 177);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 85;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(54, 150);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 86;
            this.label45.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "序号:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(54, 202);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 83;
            this.label46.Text = "备注:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(308, 177);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 84;
            this.label47.Text = "责任人:";
            // 
            // pxComboBox4
            // 
            this.pxComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox4.DataSource = this.dsCastMat;
            this.pxComboBox4.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox4.EnableNull = true;
            this.pxComboBox4.ErropPr = null;
            this.pxComboBox4.FormattingEnabled = true;
            this.pxComboBox4.Location = new System.Drawing.Point(95, 128);
            this.pxComboBox4.Name = "pxComboBox4";
            this.pxComboBox4.Size = new System.Drawing.Size(139, 20);
            this.pxComboBox4.TabIndex = 5;
            this.pxComboBox4.ToolTipValid = null;
            this.pxComboBox4.ValidEable = true;
            this.pxComboBox4.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsCastMat
            // 
            this.dsCastMat.AutoSubscribe = false;
            this.dsCastMat.DataSetName = "L3DataSet";
            this.dsCastMat.DeleteMethod = null;
            this.dsCastMat.InsertMethod = null;
            this.dsCastMat.L3DataAdapter = this.Adapter;
            this.dsCastMat.LoadEvent = "Click";
            this.dsCastMat.LoadTrigger = null;
            this.dsCastMat.RefreshValve = 1000;
            this.dsCastMat.SourceCommand = null;
            this.dsCastMat.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'尖晶石浇铸料\'";
            this.dsCastMat.SourceMethod = "";
            this.dsCastMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCastMat.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCastMat.SubscribeTarget = null;
            this.dsCastMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCastMat});
            this.dsCastMat.UpdateEvent = "Click";
            this.dsCastMat.UpdateMethod = null;
            this.dsCastMat.UpdateTrigger = null;
            // 
            // schemadsCastMat
            // 
            this.schemadsCastMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCastMatL3DataTableMatFactory});
            this.schemadsCastMat.TableName = "L3DataTable";
            // 
            // coldsCastMatL3DataTableMatFactory
            // 
            this.coldsCastMatL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCastMatL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCastMatL3DataTableMatFactory.Namespace = "";
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Fac", true));
            this.pxComboBox2.DataSource = this.dsBreBri;
            this.pxComboBox2.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Location = new System.Drawing.Point(95, 105);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(139, 20);
            this.pxComboBox2.TabIndex = 4;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            this.pxComboBox2.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsBreBri
            // 
            this.dsBreBri.AutoSubscribe = false;
            this.dsBreBri.DataSetName = "L3DataSet";
            this.dsBreBri.DeleteMethod = null;
            this.dsBreBri.InsertMethod = null;
            this.dsBreBri.L3DataAdapter = this.Adapter;
            this.dsBreBri.LoadEvent = "Click";
            this.dsBreBri.LoadTrigger = null;
            this.dsBreBri.RefreshValve = 1000;
            this.dsBreBri.SourceCommand = null;
            this.dsBreBri.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'透气座砖\'";
            this.dsBreBri.SourceMethod = "";
            this.dsBreBri.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBreBri.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsBreBri.SubscribeTarget = null;
            this.dsBreBri.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBreBri});
            this.dsBreBri.UpdateEvent = "Click";
            this.dsBreBri.UpdateMethod = null;
            this.dsBreBri.UpdateTrigger = null;
            // 
            // schemadsBreBri
            // 
            this.schemadsBreBri.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBreBriL3DataTableMatFactory});
            this.schemadsBreBri.TableName = "L3DataTable";
            // 
            // coldsBreBriL3DataTableMatFactory
            // 
            this.coldsBreBriL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsBreBriL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsBreBriL3DataTableMatFactory.Namespace = "";
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_gap_Bri_Fac", true));
            this.pxComboBox1.DataSource = this.dsGapBri;
            this.pxComboBox1.DisplayMember = "L3DataTable.MatFactory";
            this.pxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox1.EnableNull = true;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Location = new System.Drawing.Point(95, 82);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(139, 20);
            this.pxComboBox1.TabIndex = 3;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            this.pxComboBox1.ValueMember = "L3DataTable.MatName";
            // 
            // dsGapBri
            // 
            this.dsGapBri.AutoSubscribe = false;
            this.dsGapBri.DataSetName = "L3DataSet";
            this.dsGapBri.DeleteMethod = null;
            this.dsGapBri.InsertMethod = null;
            this.dsGapBri.L3DataAdapter = this.Adapter;
            this.dsGapBri.LoadEvent = "Click";
            this.dsGapBri.LoadTrigger = null;
            this.dsGapBri.RefreshValve = 1000;
            this.dsGapBri.SourceCommand = null;
            this.dsGapBri.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'水口座砖\'";
            this.dsGapBri.SourceMethod = "";
            this.dsGapBri.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGapBri.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsGapBri.SubscribeTarget = null;
            this.dsGapBri.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGapBri});
            this.dsGapBri.UpdateEvent = "Click";
            this.dsGapBri.UpdateMethod = null;
            this.dsGapBri.UpdateTrigger = null;
            // 
            // schemadsGapBri
            // 
            this.schemadsGapBri.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGapBriL3DataTableMatFactory,
            this.coldsGapBriL3DataTableMatName,
            this.coldsGapBriL3DataTableMatGroup_Code});
            this.schemadsGapBri.TableName = "L3DataTable";
            // 
            // coldsGapBriL3DataTableMatFactory
            // 
            this.coldsGapBriL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsGapBriL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsGapBriL3DataTableMatFactory.Namespace = "";
            // 
            // coldsGapBriL3DataTableMatName
            // 
            this.coldsGapBriL3DataTableMatName.Caption = "MatName";
            this.coldsGapBriL3DataTableMatName.ColumnName = "MatName";
            this.coldsGapBriL3DataTableMatName.Namespace = "";
            // 
            // coldsGapBriL3DataTableMatGroup_Code
            // 
            this.coldsGapBriL3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsGapBriL3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsGapBriL3DataTableMatGroup_Code.Namespace = "";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_End_Time", true));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(361, 57);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker5.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Date", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(361, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_Start_Time", true));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(361, 34);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(272, 61);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 75;
            this.label42.Text = "烘烤结束时间:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(296, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 72;
            this.label2.Text = "修补日期:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(272, 38);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 12);
            this.label41.TabIndex = 73;
            this.label41.Text = "烘烤开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "录入时间:";
            // 
            // pxTextBox13
            // 
            this.pxTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Ladle_Operator", true));
            this.pxTextBox13.EnableNull = true;
            this.pxTextBox13.ErropPr = null;
            this.pxTextBox13.Length = 0;
            this.pxTextBox13.Location = new System.Drawing.Point(361, 149);
            this.pxTextBox13.Max = 0;
            this.pxTextBox13.MaxStrLength = 0;
            this.pxTextBox13.Min = 0;
            this.pxTextBox13.MinStrLength = 0;
            this.pxTextBox13.Name = "pxTextBox13";
            this.pxTextBox13.Precision = 0;
            this.pxTextBox13.Size = new System.Drawing.Size(139, 21);
            this.pxTextBox13.TabIndex = 14;
            this.pxTextBox13.ToolTipValid = null;
            this.pxTextBox13.ValidEable = true;
            this.pxTextBox13.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCastWast
            // 
            this.txtCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cast_Wast", true));
            this.txtCastWast.EnableNull = false;
            this.txtCastWast.ErropPr = this.errorProvider1;
            this.txtCastWast.Length = 0;
            this.txtCastWast.Location = new System.Drawing.Point(361, 126);
            this.txtCastWast.Max = 0;
            this.txtCastWast.MaxStrLength = 0;
            this.txtCastWast.Min = 0;
            this.txtCastWast.MinStrLength = 0;
            this.txtCastWast.Name = "txtCastWast";
            this.txtCastWast.Precision = 2;
            this.txtCastWast.Size = new System.Drawing.Size(139, 21);
            this.txtCastWast.TabIndex = 13;
            this.txtCastWast.ToolTipValid = this.toolTip1;
            this.txtCastWast.ValidEable = true;
            this.txtCastWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtBreatheBriWast
            // 
            this.txtBreatheBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Wast", true));
            this.txtBreatheBriWast.EnableNull = false;
            this.txtBreatheBriWast.ErropPr = this.errorProvider1;
            this.txtBreatheBriWast.Length = 0;
            this.txtBreatheBriWast.Location = new System.Drawing.Point(361, 103);
            this.txtBreatheBriWast.Max = 0;
            this.txtBreatheBriWast.MaxStrLength = 0;
            this.txtBreatheBriWast.Min = 0;
            this.txtBreatheBriWast.MinStrLength = 0;
            this.txtBreatheBriWast.Name = "txtBreatheBriWast";
            this.txtBreatheBriWast.Precision = 2;
            this.txtBreatheBriWast.Size = new System.Drawing.Size(139, 21);
            this.txtBreatheBriWast.TabIndex = 12;
            this.txtBreatheBriWast.ToolTipValid = this.toolTip1;
            this.txtBreatheBriWast.ValidEable = true;
            this.txtBreatheBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtWaterGapBriWast
            // 
            this.txtWaterGapBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_gap_Bri_Wast", true));
            this.txtWaterGapBriWast.EnableNull = false;
            this.txtWaterGapBriWast.ErropPr = this.errorProvider1;
            this.txtWaterGapBriWast.Length = 0;
            this.txtWaterGapBriWast.Location = new System.Drawing.Point(361, 80);
            this.txtWaterGapBriWast.Max = 0;
            this.txtWaterGapBriWast.MaxStrLength = 0;
            this.txtWaterGapBriWast.Min = 0;
            this.txtWaterGapBriWast.MinStrLength = 0;
            this.txtWaterGapBriWast.Name = "txtWaterGapBriWast";
            this.txtWaterGapBriWast.Precision = 2;
            this.txtWaterGapBriWast.Size = new System.Drawing.Size(139, 21);
            this.txtWaterGapBriWast.TabIndex = 11;
            this.txtWaterGapBriWast.ToolTipValid = this.toolTip1;
            this.txtWaterGapBriWast.ValidEable = true;
            this.txtWaterGapBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(308, 150);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 12);
            this.label36.TabIndex = 61;
            this.label36.Text = "修包人:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(254, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 62;
            this.label19.Text = "浇注料消耗量[t]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(242, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 59;
            this.label7.Text = "透气座砖消耗量[t]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "浇铸料厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 65;
            this.label6.Text = "透气座砖厂家:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(242, 84);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 12);
            this.label33.TabIndex = 66;
            this.label33.Text = "水口座砖消耗量[t]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(6, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 63;
            this.label21.Text = "水口座砖厂家:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(42, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "钢包号:";
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
            this.dsLadleID.SourceCondition = "LadleType = \'1\'";
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(457, 289);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(382, 289);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 26);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ComLadleRepShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 336);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComLadleRepShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "普通钢包工作层修补实绩维护界面";
            this.Load += new System.EventHandler(this.ComLadleRepShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox pxComboBox10;
        private PxDataValid.PxComboBox pxComboBox11;
        private PxDataValid.PxTextBox pxTextBox18;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox pxComboBox4;
        private PxDataValid.PxComboBox pxComboBox2;
        private PxDataValid.PxComboBox pxComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox pxTextBox13;
        private PxDataValid.PxTextBox txtCastWast;
        private PxDataValid.PxTextBox txtBreatheBriWast;
        private PxDataValid.PxTextBox txtWaterGapBriWast;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableRepID;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableCast_Fac;
        private System.Data.DataColumn coldsMainL3DataTableCast_Wast;
        private System.Data.DataColumn coldsMainL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableRep_Ladle_Operator;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsMainL3DataTableRep_Date;
        private PxDataValid.PxTextBox txtRepID;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private PxDataValid.PxTextBox pxTextBox1;
        private AppSvrHMI.L3DataSet dsGapBri;
        private System.Data.DataTable schemadsGapBri;
        private System.Data.DataColumn coldsGapBriL3DataTableMatFactory;
        private System.Data.DataColumn coldsGapBriL3DataTableMatName;
        private System.Data.DataColumn coldsGapBriL3DataTableMatGroup_Code;
        private AppSvrHMI.L3DataSet dsBreBri;
        private System.Data.DataTable schemadsBreBri;
        private System.Data.DataColumn coldsBreBriL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsCastMat;
        private System.Data.DataTable schemadsCastMat;
        private System.Data.DataColumn coldsCastMatL3DataTableMatFactory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
    }
}