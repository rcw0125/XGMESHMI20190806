namespace EquipMag.LadleMag
{
    partial class ComLadleTieShowFrm
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
            this.coldsMainL3DataTableWORKID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTie_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTie_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableSqu_Lead_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableSqu_Lead_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableHalf_Boa_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableHalf_Boa_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableCrust_Checker = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Inner_Checker = new System.Data.DataColumn();
            this.coldsMainL3DataTableSeat_Bri_Installer = new System.Data.DataColumn();
            this.coldsMainL3DataTableBre_Bri_Installer = new System.Data.DataColumn();
            this.coldsMainL3DataTableSepa_Dose_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableWhip_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Bot_Quiver = new System.Data.DataColumn();
            this.coldsMainL3DataTableSeat_Tyre_Operator = new System.Data.DataColumn();
            this.coldsMainL3DataTableFace_A__Quiver = new System.Data.DataColumn();
            this.coldsMainL3DataTableFace_B__Quiver = new System.Data.DataColumn();
            this.coldsMainL3DataTableDoff_Mod_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableRep_Ladle_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableThr_Ladle_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Inner_Use_Count = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
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
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbHalfBoaFac = new PxDataValid.PxComboBox();
            this.dsHalfBoaFac = new AppSvrHMI.L3DataSet();
            this.schemadsHalfBoaFac = new System.Data.DataTable();
            this.coldsHalfBoaFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbSquLeadFac = new PxDataValid.PxComboBox();
            this.dsSquLeadFac = new AppSvrHMI.L3DataSet();
            this.schemadsSquLeadFac = new System.Data.DataTable();
            this.coldsSquLeadFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbCastFac = new PxDataValid.PxComboBox();
            this.dsCastMat = new AppSvrHMI.L3DataSet();
            this.schemadsCastMat = new System.Data.DataTable();
            this.coldsCastMatL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbBreatheBriFac = new PxDataValid.PxComboBox();
            this.dsBreBri = new AppSvrHMI.L3DataSet();
            this.schemadsBreBri = new System.Data.DataTable();
            this.coldsBreBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbWatergapBriFac = new PxDataValid.PxComboBox();
            this.dsGapBri = new AppSvrHMI.L3DataSet();
            this.schemadsGapBri = new System.Data.DataTable();
            this.coldsGapBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.dtThrLadleTime = new System.Windows.Forms.DateTimePicker();
            this.dtDoffModTime = new System.Windows.Forms.DateTimePicker();
            this.dtFireEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtTieEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtFireStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtTieStartTime = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrustChecker = new PxDataValid.PxTextBox();
            this.txtRepLadleBuilder = new PxDataValid.PxTextBox();
            this.txtFaceBQuiver = new PxDataValid.PxTextBox();
            this.txtSeatTyreOperator = new PxDataValid.PxTextBox();
            this.txtFaceAQuiver = new PxDataValid.PxTextBox();
            this.txtLadleBotQuiver = new PxDataValid.PxTextBox();
            this.txtWhipOperator = new PxDataValid.PxTextBox();
            this.txtSepaDoseOperator = new PxDataValid.PxTextBox();
            this.txtBreBriInstaller = new PxDataValid.PxTextBox();
            this.txtSeatBriInstaller = new PxDataValid.PxTextBox();
            this.txtLadleInnerUseCount = new PxDataValid.PxTextBox();
            this.txtLadleInnerChecker = new PxDataValid.PxTextBox();
            this.txtHalfBoaWast = new PxDataValid.PxTextBox();
            this.txtSquLeadWast = new PxDataValid.PxTextBox();
            this.txtCastWast = new PxDataValid.PxTextBox();
            this.txtBreatheBriWast = new PxDataValid.PxTextBox();
            this.txtWaterGapBriWast = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHalfBoaFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHalfBoaFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSquLeadFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSquLeadFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).BeginInit();
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
            this.coldsMainL3DataTableWORKID,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableTie_Start_Time,
            this.coldsMainL3DataTableTie_End_Time,
            this.coldsMainL3DataTableWater_gap_Bri_Fac,
            this.coldsMainL3DataTableWater_gap_Bri_Wast,
            this.coldsMainL3DataTableBreathe_Bri_Fac,
            this.coldsMainL3DataTableBreathe_Bri_Wast,
            this.coldsMainL3DataTableCast_Fac,
            this.coldsMainL3DataTableCast_Wast,
            this.coldsMainL3DataTableSqu_Lead_Fac,
            this.coldsMainL3DataTableSqu_Lead_Wast,
            this.coldsMainL3DataTableHalf_Boa_Fac,
            this.coldsMainL3DataTableHalf_Boa_Wast,
            this.coldsMainL3DataTableCrust_Checker,
            this.coldsMainL3DataTableLadle_Inner_Checker,
            this.coldsMainL3DataTableSeat_Bri_Installer,
            this.coldsMainL3DataTableBre_Bri_Installer,
            this.coldsMainL3DataTableSepa_Dose_Operator,
            this.coldsMainL3DataTableWhip_Operator,
            this.coldsMainL3DataTableLadle_Bot_Quiver,
            this.coldsMainL3DataTableSeat_Tyre_Operator,
            this.coldsMainL3DataTableFace_A__Quiver,
            this.coldsMainL3DataTableFace_B__Quiver,
            this.coldsMainL3DataTableDoff_Mod_Time,
            this.coldsMainL3DataTableRep_Ladle_Builder,
            this.coldsMainL3DataTableFire_Start_Time,
            this.coldsMainL3DataTableFire_End_Time,
            this.coldsMainL3DataTableThr_Ladle_Time,
            this.coldsMainL3DataTableLadle_Inner_Use_Count,
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
            // coldsMainL3DataTableWORKID
            // 
            this.coldsMainL3DataTableWORKID.Caption = "WORKID";
            this.coldsMainL3DataTableWORKID.ColumnName = "WORKID";
            this.coldsMainL3DataTableWORKID.Namespace = "";
            // 
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableTie_Start_Time
            // 
            this.coldsMainL3DataTableTie_Start_Time.Caption = "Tie_Start_Time";
            this.coldsMainL3DataTableTie_Start_Time.ColumnName = "Tie_Start_Time";
            this.coldsMainL3DataTableTie_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableTie_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableTie_End_Time
            // 
            this.coldsMainL3DataTableTie_End_Time.Caption = "Tie_End_Time";
            this.coldsMainL3DataTableTie_End_Time.ColumnName = "Tie_End_Time";
            this.coldsMainL3DataTableTie_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableTie_End_Time.Namespace = "";
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
            // coldsMainL3DataTableSqu_Lead_Fac
            // 
            this.coldsMainL3DataTableSqu_Lead_Fac.Caption = "Squ_Lead_Fac";
            this.coldsMainL3DataTableSqu_Lead_Fac.ColumnName = "Squ_Lead_Fac";
            this.coldsMainL3DataTableSqu_Lead_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableSqu_Lead_Wast
            // 
            this.coldsMainL3DataTableSqu_Lead_Wast.Caption = "Squ_Lead_Wast";
            this.coldsMainL3DataTableSqu_Lead_Wast.ColumnName = "Squ_Lead_Wast";
            this.coldsMainL3DataTableSqu_Lead_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableSqu_Lead_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableHalf_Boa_Fac
            // 
            this.coldsMainL3DataTableHalf_Boa_Fac.Caption = "Half_Boa_Fac";
            this.coldsMainL3DataTableHalf_Boa_Fac.ColumnName = "Half_Boa_Fac";
            this.coldsMainL3DataTableHalf_Boa_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableHalf_Boa_Wast
            // 
            this.coldsMainL3DataTableHalf_Boa_Wast.Caption = "Half_Boa_Wast";
            this.coldsMainL3DataTableHalf_Boa_Wast.ColumnName = "Half_Boa_Wast";
            this.coldsMainL3DataTableHalf_Boa_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableHalf_Boa_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableCrust_Checker
            // 
            this.coldsMainL3DataTableCrust_Checker.Caption = "Crust_Checker";
            this.coldsMainL3DataTableCrust_Checker.ColumnName = "Crust_Checker";
            this.coldsMainL3DataTableCrust_Checker.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Inner_Checker
            // 
            this.coldsMainL3DataTableLadle_Inner_Checker.Caption = "Ladle_Inner_Checker";
            this.coldsMainL3DataTableLadle_Inner_Checker.ColumnName = "Ladle_Inner_Checker";
            this.coldsMainL3DataTableLadle_Inner_Checker.Namespace = "";
            // 
            // coldsMainL3DataTableSeat_Bri_Installer
            // 
            this.coldsMainL3DataTableSeat_Bri_Installer.Caption = "Seat_Bri_Installer";
            this.coldsMainL3DataTableSeat_Bri_Installer.ColumnName = "Seat_Bri_Installer";
            this.coldsMainL3DataTableSeat_Bri_Installer.Namespace = "";
            // 
            // coldsMainL3DataTableBre_Bri_Installer
            // 
            this.coldsMainL3DataTableBre_Bri_Installer.Caption = "Bre_Bri_Installer";
            this.coldsMainL3DataTableBre_Bri_Installer.ColumnName = "Bre_Bri_Installer";
            this.coldsMainL3DataTableBre_Bri_Installer.Namespace = "";
            // 
            // coldsMainL3DataTableSepa_Dose_Operator
            // 
            this.coldsMainL3DataTableSepa_Dose_Operator.Caption = "Sepa_Dose_Operator";
            this.coldsMainL3DataTableSepa_Dose_Operator.ColumnName = "Sepa_Dose_Operator";
            this.coldsMainL3DataTableSepa_Dose_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableWhip_Operator
            // 
            this.coldsMainL3DataTableWhip_Operator.Caption = "Whip_Operator";
            this.coldsMainL3DataTableWhip_Operator.ColumnName = "Whip_Operator";
            this.coldsMainL3DataTableWhip_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Bot_Quiver
            // 
            this.coldsMainL3DataTableLadle_Bot_Quiver.Caption = "Ladle_Bot_Quiver";
            this.coldsMainL3DataTableLadle_Bot_Quiver.ColumnName = "Ladle_Bot_Quiver";
            this.coldsMainL3DataTableLadle_Bot_Quiver.Namespace = "";
            // 
            // coldsMainL3DataTableSeat_Tyre_Operator
            // 
            this.coldsMainL3DataTableSeat_Tyre_Operator.Caption = "Seat_Tyre_Operator";
            this.coldsMainL3DataTableSeat_Tyre_Operator.ColumnName = "Seat_Tyre_Operator";
            this.coldsMainL3DataTableSeat_Tyre_Operator.Namespace = "";
            // 
            // coldsMainL3DataTableFace_A__Quiver
            // 
            this.coldsMainL3DataTableFace_A__Quiver.Caption = "Face_A__Quiver";
            this.coldsMainL3DataTableFace_A__Quiver.ColumnName = "Face_A__Quiver";
            this.coldsMainL3DataTableFace_A__Quiver.Namespace = "";
            // 
            // coldsMainL3DataTableFace_B__Quiver
            // 
            this.coldsMainL3DataTableFace_B__Quiver.Caption = "Face_B__Quiver";
            this.coldsMainL3DataTableFace_B__Quiver.ColumnName = "Face_B__Quiver";
            this.coldsMainL3DataTableFace_B__Quiver.Namespace = "";
            // 
            // coldsMainL3DataTableDoff_Mod_Time
            // 
            this.coldsMainL3DataTableDoff_Mod_Time.Caption = "Doff_Mod_Time";
            this.coldsMainL3DataTableDoff_Mod_Time.ColumnName = "Doff_Mod_Time";
            this.coldsMainL3DataTableDoff_Mod_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableDoff_Mod_Time.Namespace = "";
            // 
            // coldsMainL3DataTableRep_Ladle_Builder
            // 
            this.coldsMainL3DataTableRep_Ladle_Builder.Caption = "Rep_Ladle_Builder";
            this.coldsMainL3DataTableRep_Ladle_Builder.ColumnName = "Rep_Ladle_Builder";
            this.coldsMainL3DataTableRep_Ladle_Builder.Namespace = "";
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
            // coldsMainL3DataTableThr_Ladle_Time
            // 
            this.coldsMainL3DataTableThr_Ladle_Time.Caption = "Thr_Ladle_Time";
            this.coldsMainL3DataTableThr_Ladle_Time.ColumnName = "Thr_Ladle_Time";
            this.coldsMainL3DataTableThr_Ladle_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableThr_Ladle_Time.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Inner_Use_Count
            // 
            this.coldsMainL3DataTableLadle_Inner_Use_Count.Caption = "Ladle_Inner_Use_Count";
            this.coldsMainL3DataTableLadle_Inner_Use_Count.ColumnName = "Ladle_Inner_Use_Count";
            this.coldsMainL3DataTableLadle_Inner_Use_Count.DataType = typeof(int);
            this.coldsMainL3DataTableLadle_Inner_Use_Count.Namespace = "";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbLadleID);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbHalfBoaFac);
            this.tabPage1.Controls.Add(this.cmbSquLeadFac);
            this.tabPage1.Controls.Add(this.cmbCastFac);
            this.tabPage1.Controls.Add(this.cmbBreatheBriFac);
            this.tabPage1.Controls.Add(this.cmbWatergapBriFac);
            this.tabPage1.Controls.Add(this.dtThrLadleTime);
            this.tabPage1.Controls.Add(this.dtDoffModTime);
            this.tabPage1.Controls.Add(this.dtFireEndTime);
            this.tabPage1.Controls.Add(this.dtTieEndTime);
            this.tabPage1.Controls.Add(this.dtFireStartTime);
            this.tabPage1.Controls.Add(this.dtTieStartTime);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCrustChecker);
            this.tabPage1.Controls.Add(this.txtRepLadleBuilder);
            this.tabPage1.Controls.Add(this.txtFaceBQuiver);
            this.tabPage1.Controls.Add(this.txtSeatTyreOperator);
            this.tabPage1.Controls.Add(this.txtFaceAQuiver);
            this.tabPage1.Controls.Add(this.txtLadleBotQuiver);
            this.tabPage1.Controls.Add(this.txtWhipOperator);
            this.tabPage1.Controls.Add(this.txtSepaDoseOperator);
            this.tabPage1.Controls.Add(this.txtBreBriInstaller);
            this.tabPage1.Controls.Add(this.txtSeatBriInstaller);
            this.tabPage1.Controls.Add(this.txtLadleInnerUseCount);
            this.tabPage1.Controls.Add(this.txtLadleInnerChecker);
            this.tabPage1.Controls.Add(this.txtHalfBoaWast);
            this.tabPage1.Controls.Add(this.txtSquLeadWast);
            this.tabPage1.Controls.Add(this.txtCastWast);
            this.tabPage1.Controls.Add(this.txtBreatheBriWast);
            this.tabPage1.Controls.Add(this.txtWaterGapBriWast);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "打结实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(114, 285);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(700, 61);
            this.rtxtNote.TabIndex = 72;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.cmbLadleID.Location = new System.Drawing.Point(114, 35);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleID.TabIndex = 1;
            this.cmbLadleID.ToolTipValid = this.toolTip1;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.LadleID";
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
            this.cmbShiftID.Location = new System.Drawing.Point(674, 233);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 31;
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
            this.cmbTeamID.Location = new System.Drawing.Point(674, 209);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 30;
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
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(674, 257);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(140, 21);
            this.txtOperator.TabIndex = 32;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(633, 237);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 59;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(633, 213);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 58;
            this.label45.Text = "班别:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(73, 288);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 71;
            this.label46.Text = "备注:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(621, 261);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 70;
            this.label47.Text = "责任人:";
            // 
            // cmbHalfBoaFac
            // 
            this.cmbHalfBoaFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHalfBoaFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHalfBoaFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Half_Boa_Fac", true));
            this.cmbHalfBoaFac.DataSource = this.dsHalfBoaFac;
            this.cmbHalfBoaFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbHalfBoaFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHalfBoaFac.EnableNull = true;
            this.cmbHalfBoaFac.ErropPr = null;
            this.cmbHalfBoaFac.FormattingEnabled = true;
            this.cmbHalfBoaFac.Location = new System.Drawing.Point(377, 109);
            this.cmbHalfBoaFac.Name = "cmbHalfBoaFac";
            this.cmbHalfBoaFac.Size = new System.Drawing.Size(141, 20);
            this.cmbHalfBoaFac.TabIndex = 16;
            this.cmbHalfBoaFac.ToolTipValid = null;
            this.cmbHalfBoaFac.ValidEable = true;
            this.cmbHalfBoaFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsHalfBoaFac
            // 
            this.dsHalfBoaFac.AutoSubscribe = false;
            this.dsHalfBoaFac.DataSetName = "L3DataSet";
            this.dsHalfBoaFac.DeleteMethod = null;
            this.dsHalfBoaFac.InsertMethod = null;
            this.dsHalfBoaFac.L3DataAdapter = this.Adapter;
            this.dsHalfBoaFac.LoadEvent = "Click";
            this.dsHalfBoaFac.LoadTrigger = null;
            this.dsHalfBoaFac.RefreshValve = 1000;
            this.dsHalfBoaFac.SourceCommand = null;
            this.dsHalfBoaFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'半板片\'";
            this.dsHalfBoaFac.SourceMethod = "";
            this.dsHalfBoaFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHalfBoaFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsHalfBoaFac.SubscribeTarget = null;
            this.dsHalfBoaFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHalfBoaFac});
            this.dsHalfBoaFac.UpdateEvent = "Click";
            this.dsHalfBoaFac.UpdateMethod = null;
            this.dsHalfBoaFac.UpdateTrigger = null;
            // 
            // schemadsHalfBoaFac
            // 
            this.schemadsHalfBoaFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHalfBoaFacL3DataTableMATFACTORY});
            this.schemadsHalfBoaFac.TableName = "L3DataTable";
            // 
            // coldsHalfBoaFacL3DataTableMATFACTORY
            // 
            this.coldsHalfBoaFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsHalfBoaFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsHalfBoaFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbSquLeadFac
            // 
            this.cmbSquLeadFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSquLeadFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSquLeadFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Squ_Lead_Fac", true));
            this.cmbSquLeadFac.DataSource = this.dsSquLeadFac;
            this.cmbSquLeadFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbSquLeadFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSquLeadFac.EnableNull = true;
            this.cmbSquLeadFac.ErropPr = null;
            this.cmbSquLeadFac.FormattingEnabled = true;
            this.cmbSquLeadFac.Location = new System.Drawing.Point(377, 85);
            this.cmbSquLeadFac.Name = "cmbSquLeadFac";
            this.cmbSquLeadFac.Size = new System.Drawing.Size(141, 20);
            this.cmbSquLeadFac.TabIndex = 14;
            this.cmbSquLeadFac.ToolTipValid = null;
            this.cmbSquLeadFac.ValidEable = true;
            this.cmbSquLeadFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsSquLeadFac
            // 
            this.dsSquLeadFac.AutoSubscribe = false;
            this.dsSquLeadFac.DataSetName = "L3DataSet";
            this.dsSquLeadFac.DeleteMethod = null;
            this.dsSquLeadFac.InsertMethod = null;
            this.dsSquLeadFac.L3DataAdapter = this.Adapter;
            this.dsSquLeadFac.LoadEvent = "Click";
            this.dsSquLeadFac.LoadTrigger = null;
            this.dsSquLeadFac.RefreshValve = 1000;
            this.dsSquLeadFac.SourceCommand = null;
            this.dsSquLeadFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'鳞片状石墨粉\'";
            this.dsSquLeadFac.SourceMethod = "";
            this.dsSquLeadFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSquLeadFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsSquLeadFac.SubscribeTarget = null;
            this.dsSquLeadFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSquLeadFac});
            this.dsSquLeadFac.UpdateEvent = "Click";
            this.dsSquLeadFac.UpdateMethod = null;
            this.dsSquLeadFac.UpdateTrigger = null;
            // 
            // schemadsSquLeadFac
            // 
            this.schemadsSquLeadFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSquLeadFacL3DataTableMATFACTORY});
            this.schemadsSquLeadFac.TableName = "L3DataTable";
            // 
            // coldsSquLeadFacL3DataTableMATFACTORY
            // 
            this.coldsSquLeadFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsSquLeadFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsSquLeadFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbCastFac
            // 
            this.cmbCastFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCastFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCastFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cast_Fac", true));
            this.cmbCastFac.DataSource = this.dsCastMat;
            this.cmbCastFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbCastFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastFac.EnableNull = true;
            this.cmbCastFac.ErropPr = null;
            this.cmbCastFac.FormattingEnabled = true;
            this.cmbCastFac.Location = new System.Drawing.Point(377, 60);
            this.cmbCastFac.Name = "cmbCastFac";
            this.cmbCastFac.Size = new System.Drawing.Size(141, 20);
            this.cmbCastFac.TabIndex = 12;
            this.cmbCastFac.ToolTipValid = null;
            this.cmbCastFac.ValidEable = true;
            this.cmbCastFac.ValueMember = "L3DataTable.MATFACTORY";
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
            this.coldsCastMatL3DataTableMATFACTORY});
            this.schemadsCastMat.TableName = "L3DataTable";
            // 
            // coldsCastMatL3DataTableMATFACTORY
            // 
            this.coldsCastMatL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbBreatheBriFac
            // 
            this.cmbBreatheBriFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBreatheBriFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBreatheBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Fac", true));
            this.cmbBreatheBriFac.DataSource = this.dsBreBri;
            this.cmbBreatheBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbBreatheBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreatheBriFac.EnableNull = true;
            this.cmbBreatheBriFac.ErropPr = null;
            this.cmbBreatheBriFac.FormattingEnabled = true;
            this.cmbBreatheBriFac.Location = new System.Drawing.Point(377, 35);
            this.cmbBreatheBriFac.Name = "cmbBreatheBriFac";
            this.cmbBreatheBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBreatheBriFac.TabIndex = 10;
            this.cmbBreatheBriFac.ToolTipValid = null;
            this.cmbBreatheBriFac.ValidEable = true;
            this.cmbBreatheBriFac.ValueMember = "L3DataTable.MATFACTORY";
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
            this.coldsBreBriL3DataTableMATFACTORY});
            this.schemadsBreBri.TableName = "L3DataTable";
            // 
            // coldsBreBriL3DataTableMATFACTORY
            // 
            this.coldsBreBriL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsBreBriL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsBreBriL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbWatergapBriFac
            // 
            this.cmbWatergapBriFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWatergapBriFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWatergapBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_gap_Bri_Fac", true));
            this.cmbWatergapBriFac.DataSource = this.dsGapBri;
            this.cmbWatergapBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbWatergapBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWatergapBriFac.EnableNull = true;
            this.cmbWatergapBriFac.ErropPr = null;
            this.cmbWatergapBriFac.FormattingEnabled = true;
            this.cmbWatergapBriFac.Location = new System.Drawing.Point(377, 10);
            this.cmbWatergapBriFac.Name = "cmbWatergapBriFac";
            this.cmbWatergapBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbWatergapBriFac.TabIndex = 8;
            this.cmbWatergapBriFac.ToolTipValid = null;
            this.cmbWatergapBriFac.ValidEable = true;
            this.cmbWatergapBriFac.ValueMember = "L3DataTable.MATFACTORY";
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
            this.coldsGapBriL3DataTableMATFACTORY});
            this.schemadsGapBri.TableName = "L3DataTable";
            // 
            // coldsGapBriL3DataTableMATFACTORY
            // 
            this.coldsGapBriL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsGapBriL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsGapBriL3DataTableMATFACTORY.Namespace = "";
            // 
            // dtThrLadleTime
            // 
            this.dtThrLadleTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtThrLadleTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Thr_Ladle_Time", true));
            this.dtThrLadleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThrLadleTime.Location = new System.Drawing.Point(114, 158);
            this.dtThrLadleTime.Name = "dtThrLadleTime";
            this.dtThrLadleTime.Size = new System.Drawing.Size(141, 21);
            this.dtThrLadleTime.TabIndex = 6;
            // 
            // dtDoffModTime
            // 
            this.dtDoffModTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtDoffModTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Doff_Mod_Time", true));
            this.dtDoffModTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDoffModTime.Location = new System.Drawing.Point(114, 183);
            this.dtDoffModTime.Name = "dtDoffModTime";
            this.dtDoffModTime.Size = new System.Drawing.Size(140, 21);
            this.dtDoffModTime.TabIndex = 7;
            // 
            // dtFireEndTime
            // 
            this.dtFireEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_End_Time", true));
            this.dtFireEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireEndTime.Location = new System.Drawing.Point(114, 133);
            this.dtFireEndTime.Name = "dtFireEndTime";
            this.dtFireEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireEndTime.TabIndex = 5;
            // 
            // dtTieEndTime
            // 
            this.dtTieEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Tie_End_Time", true));
            this.dtTieEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieEndTime.Location = new System.Drawing.Point(114, 85);
            this.dtTieEndTime.Name = "dtTieEndTime";
            this.dtTieEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtTieEndTime.TabIndex = 3;
            // 
            // dtFireStartTime
            // 
            this.dtFireStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_Start_Time", true));
            this.dtFireStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireStartTime.Location = new System.Drawing.Point(114, 109);
            this.dtFireStartTime.Name = "dtFireStartTime";
            this.dtFireStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireStartTime.TabIndex = 4;
            // 
            // dtTieStartTime
            // 
            this.dtTieStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Tie_Start_Time", true));
            this.dtTieStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieStartTime.Location = new System.Drawing.Point(114, 60);
            this.dtTieStartTime.Name = "dtTieStartTime";
            this.dtTieStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtTieStartTime.TabIndex = 2;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(49, 162);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 12);
            this.label43.TabIndex = 42;
            this.label43.Text = "甩包时间:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(49, 187);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 69;
            this.label29.Text = "脱模时间:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(25, 137);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 41;
            this.label42.Text = "烘烤结束时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(114, 10);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(25, 113);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 12);
            this.label41.TabIndex = 40;
            this.label41.Text = "烘烤开始时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "打结结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "打结开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "录入时间:";
            // 
            // txtCrustChecker
            // 
            this.txtCrustChecker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Crust_Checker", true));
            this.txtCrustChecker.EnableNull = true;
            this.txtCrustChecker.ErropPr = null;
            this.txtCrustChecker.Length = 0;
            this.txtCrustChecker.Location = new System.Drawing.Point(376, 183);
            this.txtCrustChecker.Max = 0;
            this.txtCrustChecker.MaxStrLength = 0;
            this.txtCrustChecker.Min = 0;
            this.txtCrustChecker.MinStrLength = 0;
            this.txtCrustChecker.Name = "txtCrustChecker";
            this.txtCrustChecker.Precision = 0;
            this.txtCrustChecker.Size = new System.Drawing.Size(141, 21);
            this.txtCrustChecker.TabIndex = 20;
            this.txtCrustChecker.ToolTipValid = null;
            this.txtCrustChecker.ValidEable = true;
            this.txtCrustChecker.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtRepLadleBuilder
            // 
            this.txtRepLadleBuilder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Ladle_Builder", true));
            this.txtRepLadleBuilder.EnableNull = true;
            this.txtRepLadleBuilder.ErropPr = null;
            this.txtRepLadleBuilder.Length = 0;
            this.txtRepLadleBuilder.Location = new System.Drawing.Point(376, 257);
            this.txtRepLadleBuilder.Max = 0;
            this.txtRepLadleBuilder.MaxStrLength = 0;
            this.txtRepLadleBuilder.Min = 0;
            this.txtRepLadleBuilder.MinStrLength = 0;
            this.txtRepLadleBuilder.Name = "txtRepLadleBuilder";
            this.txtRepLadleBuilder.Precision = 0;
            this.txtRepLadleBuilder.Size = new System.Drawing.Size(141, 21);
            this.txtRepLadleBuilder.TabIndex = 29;
            this.txtRepLadleBuilder.ToolTipValid = null;
            this.txtRepLadleBuilder.ValidEable = true;
            this.txtRepLadleBuilder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFaceBQuiver
            // 
            this.txtFaceBQuiver.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Face_B__Quiver", true));
            this.txtFaceBQuiver.EnableNull = true;
            this.txtFaceBQuiver.ErropPr = null;
            this.txtFaceBQuiver.Length = 0;
            this.txtFaceBQuiver.Location = new System.Drawing.Point(376, 233);
            this.txtFaceBQuiver.Max = 0;
            this.txtFaceBQuiver.MaxStrLength = 0;
            this.txtFaceBQuiver.Min = 0;
            this.txtFaceBQuiver.MinStrLength = 0;
            this.txtFaceBQuiver.Name = "txtFaceBQuiver";
            this.txtFaceBQuiver.Precision = 0;
            this.txtFaceBQuiver.Size = new System.Drawing.Size(141, 21);
            this.txtFaceBQuiver.TabIndex = 28;
            this.txtFaceBQuiver.ToolTipValid = null;
            this.txtFaceBQuiver.ValidEable = true;
            this.txtFaceBQuiver.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSeatTyreOperator
            // 
            this.txtSeatTyreOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Seat_Tyre_Operator", true));
            this.txtSeatTyreOperator.EnableNull = true;
            this.txtSeatTyreOperator.ErropPr = null;
            this.txtSeatTyreOperator.Length = 0;
            this.txtSeatTyreOperator.Location = new System.Drawing.Point(114, 257);
            this.txtSeatTyreOperator.Max = 0;
            this.txtSeatTyreOperator.MaxStrLength = 0;
            this.txtSeatTyreOperator.Min = 0;
            this.txtSeatTyreOperator.MinStrLength = 0;
            this.txtSeatTyreOperator.Name = "txtSeatTyreOperator";
            this.txtSeatTyreOperator.Precision = 0;
            this.txtSeatTyreOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSeatTyreOperator.TabIndex = 26;
            this.txtSeatTyreOperator.ToolTipValid = null;
            this.txtSeatTyreOperator.ValidEable = true;
            this.txtSeatTyreOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFaceAQuiver
            // 
            this.txtFaceAQuiver.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Face_A__Quiver", true));
            this.txtFaceAQuiver.EnableNull = true;
            this.txtFaceAQuiver.ErropPr = null;
            this.txtFaceAQuiver.Length = 0;
            this.txtFaceAQuiver.Location = new System.Drawing.Point(377, 209);
            this.txtFaceAQuiver.Max = 0;
            this.txtFaceAQuiver.MaxStrLength = 0;
            this.txtFaceAQuiver.Min = 0;
            this.txtFaceAQuiver.MinStrLength = 0;
            this.txtFaceAQuiver.Name = "txtFaceAQuiver";
            this.txtFaceAQuiver.Precision = 0;
            this.txtFaceAQuiver.Size = new System.Drawing.Size(141, 21);
            this.txtFaceAQuiver.TabIndex = 27;
            this.txtFaceAQuiver.ToolTipValid = null;
            this.txtFaceAQuiver.ValidEable = true;
            this.txtFaceAQuiver.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLadleBotQuiver
            // 
            this.txtLadleBotQuiver.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Bot_Quiver", true));
            this.txtLadleBotQuiver.EnableNull = true;
            this.txtLadleBotQuiver.ErropPr = null;
            this.txtLadleBotQuiver.Length = 0;
            this.txtLadleBotQuiver.Location = new System.Drawing.Point(114, 233);
            this.txtLadleBotQuiver.Max = 0;
            this.txtLadleBotQuiver.MaxStrLength = 0;
            this.txtLadleBotQuiver.Min = 0;
            this.txtLadleBotQuiver.MinStrLength = 0;
            this.txtLadleBotQuiver.Name = "txtLadleBotQuiver";
            this.txtLadleBotQuiver.Precision = 0;
            this.txtLadleBotQuiver.Size = new System.Drawing.Size(140, 21);
            this.txtLadleBotQuiver.TabIndex = 25;
            this.txtLadleBotQuiver.ToolTipValid = null;
            this.txtLadleBotQuiver.ValidEable = true;
            this.txtLadleBotQuiver.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWhipOperator
            // 
            this.txtWhipOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Whip_Operator", true));
            this.txtWhipOperator.EnableNull = true;
            this.txtWhipOperator.ErropPr = null;
            this.txtWhipOperator.Length = 0;
            this.txtWhipOperator.Location = new System.Drawing.Point(114, 209);
            this.txtWhipOperator.Max = 0;
            this.txtWhipOperator.MaxStrLength = 0;
            this.txtWhipOperator.Min = 0;
            this.txtWhipOperator.MinStrLength = 0;
            this.txtWhipOperator.Name = "txtWhipOperator";
            this.txtWhipOperator.Precision = 0;
            this.txtWhipOperator.Size = new System.Drawing.Size(141, 21);
            this.txtWhipOperator.TabIndex = 24;
            this.txtWhipOperator.ToolTipValid = null;
            this.txtWhipOperator.ValidEable = true;
            this.txtWhipOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSepaDoseOperator
            // 
            this.txtSepaDoseOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Sepa_Dose_Operator", true));
            this.txtSepaDoseOperator.EnableNull = true;
            this.txtSepaDoseOperator.ErropPr = null;
            this.txtSepaDoseOperator.Length = 0;
            this.txtSepaDoseOperator.Location = new System.Drawing.Point(674, 183);
            this.txtSepaDoseOperator.Max = 0;
            this.txtSepaDoseOperator.MaxStrLength = 0;
            this.txtSepaDoseOperator.Min = 0;
            this.txtSepaDoseOperator.MinStrLength = 0;
            this.txtSepaDoseOperator.Name = "txtSepaDoseOperator";
            this.txtSepaDoseOperator.Precision = 0;
            this.txtSepaDoseOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSepaDoseOperator.TabIndex = 23;
            this.txtSepaDoseOperator.ToolTipValid = null;
            this.txtSepaDoseOperator.ValidEable = true;
            this.txtSepaDoseOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtBreBriInstaller
            // 
            this.txtBreBriInstaller.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bre_Bri_Installer", true));
            this.txtBreBriInstaller.EnableNull = true;
            this.txtBreBriInstaller.ErropPr = null;
            this.txtBreBriInstaller.Length = 0;
            this.txtBreBriInstaller.Location = new System.Drawing.Point(674, 158);
            this.txtBreBriInstaller.Max = 0;
            this.txtBreBriInstaller.MaxStrLength = 0;
            this.txtBreBriInstaller.Min = 0;
            this.txtBreBriInstaller.MinStrLength = 0;
            this.txtBreBriInstaller.Name = "txtBreBriInstaller";
            this.txtBreBriInstaller.Precision = 0;
            this.txtBreBriInstaller.Size = new System.Drawing.Size(141, 21);
            this.txtBreBriInstaller.TabIndex = 22;
            this.txtBreBriInstaller.ToolTipValid = null;
            this.txtBreBriInstaller.ValidEable = true;
            this.txtBreBriInstaller.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSeatBriInstaller
            // 
            this.txtSeatBriInstaller.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Seat_Bri_Installer", true));
            this.txtSeatBriInstaller.EnableNull = true;
            this.txtSeatBriInstaller.ErropPr = null;
            this.txtSeatBriInstaller.Length = 0;
            this.txtSeatBriInstaller.Location = new System.Drawing.Point(674, 133);
            this.txtSeatBriInstaller.Max = 0;
            this.txtSeatBriInstaller.MaxStrLength = 0;
            this.txtSeatBriInstaller.Min = 0;
            this.txtSeatBriInstaller.MinStrLength = 0;
            this.txtSeatBriInstaller.Name = "txtSeatBriInstaller";
            this.txtSeatBriInstaller.Precision = 0;
            this.txtSeatBriInstaller.Size = new System.Drawing.Size(140, 21);
            this.txtSeatBriInstaller.TabIndex = 21;
            this.txtSeatBriInstaller.ToolTipValid = null;
            this.txtSeatBriInstaller.ValidEable = true;
            this.txtSeatBriInstaller.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLadleInnerUseCount
            // 
            this.txtLadleInnerUseCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Inner_Use_Count", true));
            this.txtLadleInnerUseCount.EnableNull = false;
            this.txtLadleInnerUseCount.ErropPr = this.errorProvider1;
            this.txtLadleInnerUseCount.Length = 0;
            this.txtLadleInnerUseCount.Location = new System.Drawing.Point(377, 158);
            this.txtLadleInnerUseCount.Max = 0;
            this.txtLadleInnerUseCount.MaxStrLength = 0;
            this.txtLadleInnerUseCount.Min = -0.99;
            this.txtLadleInnerUseCount.MinStrLength = 0;
            this.txtLadleInnerUseCount.Name = "txtLadleInnerUseCount";
            this.txtLadleInnerUseCount.Precision = 0;
            this.txtLadleInnerUseCount.Size = new System.Drawing.Size(140, 21);
            this.txtLadleInnerUseCount.TabIndex = 19;
            this.txtLadleInnerUseCount.ToolTipValid = this.toolTip1;
            this.txtLadleInnerUseCount.ValidEable = true;
            this.txtLadleInnerUseCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLadleInnerChecker
            // 
            this.txtLadleInnerChecker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Inner_Checker", true));
            this.txtLadleInnerChecker.EnableNull = true;
            this.txtLadleInnerChecker.ErropPr = null;
            this.txtLadleInnerChecker.Length = 0;
            this.txtLadleInnerChecker.Location = new System.Drawing.Point(377, 133);
            this.txtLadleInnerChecker.Max = 0;
            this.txtLadleInnerChecker.MaxStrLength = 0;
            this.txtLadleInnerChecker.Min = 0;
            this.txtLadleInnerChecker.MinStrLength = 0;
            this.txtLadleInnerChecker.Name = "txtLadleInnerChecker";
            this.txtLadleInnerChecker.Precision = 0;
            this.txtLadleInnerChecker.Size = new System.Drawing.Size(141, 21);
            this.txtLadleInnerChecker.TabIndex = 18;
            this.txtLadleInnerChecker.ToolTipValid = null;
            this.txtLadleInnerChecker.ValidEable = true;
            this.txtLadleInnerChecker.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtHalfBoaWast
            // 
            this.txtHalfBoaWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Half_Boa_Wast", true));
            this.txtHalfBoaWast.EnableNull = false;
            this.txtHalfBoaWast.ErropPr = this.errorProvider1;
            this.txtHalfBoaWast.Length = 0;
            this.txtHalfBoaWast.Location = new System.Drawing.Point(674, 109);
            this.txtHalfBoaWast.Max = 0;
            this.txtHalfBoaWast.MaxStrLength = 0;
            this.txtHalfBoaWast.Min = 0;
            this.txtHalfBoaWast.MinStrLength = 0;
            this.txtHalfBoaWast.Name = "txtHalfBoaWast";
            this.txtHalfBoaWast.Precision = 3;
            this.txtHalfBoaWast.Size = new System.Drawing.Size(140, 21);
            this.txtHalfBoaWast.TabIndex = 17;
            this.txtHalfBoaWast.ToolTipValid = this.toolTip1;
            this.txtHalfBoaWast.ValidEable = true;
            this.txtHalfBoaWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtSquLeadWast
            // 
            this.txtSquLeadWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Squ_Lead_Wast", true));
            this.txtSquLeadWast.EnableNull = false;
            this.txtSquLeadWast.ErropPr = this.errorProvider1;
            this.txtSquLeadWast.Length = 0;
            this.txtSquLeadWast.Location = new System.Drawing.Point(674, 85);
            this.txtSquLeadWast.Max = 0;
            this.txtSquLeadWast.MaxStrLength = 0;
            this.txtSquLeadWast.Min = 0;
            this.txtSquLeadWast.MinStrLength = 0;
            this.txtSquLeadWast.Name = "txtSquLeadWast";
            this.txtSquLeadWast.Precision = 3;
            this.txtSquLeadWast.Size = new System.Drawing.Size(140, 21);
            this.txtSquLeadWast.TabIndex = 15;
            this.txtSquLeadWast.ToolTipValid = this.toolTip1;
            this.txtSquLeadWast.ValidEable = true;
            this.txtSquLeadWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCastWast
            // 
            this.txtCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cast_Wast", true));
            this.txtCastWast.EnableNull = false;
            this.txtCastWast.ErropPr = this.errorProvider1;
            this.txtCastWast.Length = 0;
            this.txtCastWast.Location = new System.Drawing.Point(674, 60);
            this.txtCastWast.Max = 0;
            this.txtCastWast.MaxStrLength = 0;
            this.txtCastWast.Min = 0;
            this.txtCastWast.MinStrLength = 0;
            this.txtCastWast.Name = "txtCastWast";
            this.txtCastWast.Precision = 3;
            this.txtCastWast.Size = new System.Drawing.Size(140, 21);
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
            this.txtBreatheBriWast.Location = new System.Drawing.Point(674, 35);
            this.txtBreatheBriWast.Max = 0;
            this.txtBreatheBriWast.MaxStrLength = 0;
            this.txtBreatheBriWast.Min = 0;
            this.txtBreatheBriWast.MinStrLength = 0;
            this.txtBreatheBriWast.Name = "txtBreatheBriWast";
            this.txtBreatheBriWast.Precision = 3;
            this.txtBreatheBriWast.Size = new System.Drawing.Size(140, 21);
            this.txtBreatheBriWast.TabIndex = 11;
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
            this.txtWaterGapBriWast.Location = new System.Drawing.Point(674, 10);
            this.txtWaterGapBriWast.Max = 0;
            this.txtWaterGapBriWast.MaxStrLength = 0;
            this.txtWaterGapBriWast.Min = 0;
            this.txtWaterGapBriWast.MinStrLength = 0;
            this.txtWaterGapBriWast.Name = "txtWaterGapBriWast";
            this.txtWaterGapBriWast.Precision = 3;
            this.txtWaterGapBriWast.Size = new System.Drawing.Size(140, 21);
            this.txtWaterGapBriWast.TabIndex = 9;
            this.txtWaterGapBriWast.ToolTipValid = this.toolTip1;
            this.txtWaterGapBriWast.ValidEable = true;
            this.txtWaterGapBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(312, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "外壳检查:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(324, 261);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 47;
            this.label30.Text = "补包底:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(318, 237);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 57;
            this.label27.Text = "B面振动:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(37, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "座包胎操作:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(318, 213);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 56;
            this.label26.Text = "A面振动:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(49, 237);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 12);
            this.label39.TabIndex = 67;
            this.label39.Text = "包底振动:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(49, 213);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(59, 12);
            this.label38.TabIndex = 45;
            this.label38.Text = "搅拌操作:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(597, 187);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 12);
            this.label37.TabIndex = 44;
            this.label37.Text = "隔离剂操作:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(597, 162);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 12);
            this.label36.TabIndex = 43;
            this.label36.Text = "透气砖安装:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(609, 137);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 66;
            this.label35.Text = "座砖安装:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(276, 162);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 12);
            this.label34.TabIndex = 65;
            this.label34.Text = "永久层使用次数:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(300, 137);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 12);
            this.label32.TabIndex = 53;
            this.label32.Text = "永久层检查:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(567, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 12);
            this.label25.TabIndex = 64;
            this.label25.Text = "半板片消耗量[t]:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(525, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 12);
            this.label23.TabIndex = 63;
            this.label23.Text = "鳞片状石墨粉消耗量[Kg]:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(567, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 62;
            this.label19.Text = "浇注料消耗量[t]:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(300, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "半板片厂家:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(555, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "透气座砖消耗量[t]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(264, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 12);
            this.label22.TabIndex = 51;
            this.label22.Text = "鳞片状石墨粉厂家:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(300, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 50;
            this.label9.Text = "浇铸料厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(288, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "透气座砖厂家:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(555, 14);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 12);
            this.label33.TabIndex = 60;
            this.label33.Text = "水口座砖消耗量[t]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(288, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "水口座砖厂家:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(61, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "钢包号:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(717, 406);
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
            this.btnConfirm.Location = new System.Drawing.Point(636, 406);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ComLadleTieShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 469);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComLadleTieShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "普通钢包工作层打结实绩维护界面";
            this.Load += new System.EventHandler(this.ComLadleTieShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHalfBoaFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHalfBoaFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSquLeadFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSquLeadFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).EndInit();
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
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbHalfBoaFac;
        private PxDataValid.PxComboBox cmbSquLeadFac;
        private PxDataValid.PxComboBox cmbCastFac;
        private PxDataValid.PxComboBox cmbBreatheBriFac;
        private PxDataValid.PxComboBox cmbWatergapBriFac;
        private System.Windows.Forms.DateTimePicker dtThrLadleTime;
        private System.Windows.Forms.DateTimePicker dtDoffModTime;
        private System.Windows.Forms.DateTimePicker dtFireEndTime;
        private System.Windows.Forms.DateTimePicker dtTieEndTime;
        private System.Windows.Forms.DateTimePicker dtFireStartTime;
        private System.Windows.Forms.DateTimePicker dtTieStartTime;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtCrustChecker;
        private PxDataValid.PxTextBox txtRepLadleBuilder;
        private PxDataValid.PxTextBox txtFaceBQuiver;
        private PxDataValid.PxTextBox txtSeatTyreOperator;
        private PxDataValid.PxTextBox txtFaceAQuiver;
        private PxDataValid.PxTextBox txtLadleBotQuiver;
        private PxDataValid.PxTextBox txtWhipOperator;
        private PxDataValid.PxTextBox txtSepaDoseOperator;
        private PxDataValid.PxTextBox txtBreBriInstaller;
        private PxDataValid.PxTextBox txtSeatBriInstaller;
        private PxDataValid.PxTextBox txtLadleInnerUseCount;
        private PxDataValid.PxTextBox txtLadleInnerChecker;
        private PxDataValid.PxTextBox txtHalfBoaWast;
        private PxDataValid.PxTextBox txtSquLeadWast;
        private PxDataValid.PxTextBox txtCastWast;
        private PxDataValid.PxTextBox txtBreatheBriWast;
        private PxDataValid.PxTextBox txtWaterGapBriWast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxComboBox cmbLadleID;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableWORKID;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableTie_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableTie_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableCast_Fac;
        private System.Data.DataColumn coldsMainL3DataTableCast_Wast;
        private System.Data.DataColumn coldsMainL3DataTableSqu_Lead_Fac;
        private System.Data.DataColumn coldsMainL3DataTableSqu_Lead_Wast;
        private System.Data.DataColumn coldsMainL3DataTableHalf_Boa_Fac;
        private System.Data.DataColumn coldsMainL3DataTableHalf_Boa_Wast;
        private System.Data.DataColumn coldsMainL3DataTableCrust_Checker;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Inner_Checker;
        private System.Data.DataColumn coldsMainL3DataTableSeat_Bri_Installer;
        private System.Data.DataColumn coldsMainL3DataTableBre_Bri_Installer;
        private System.Data.DataColumn coldsMainL3DataTableSepa_Dose_Operator;
        private System.Data.DataColumn coldsMainL3DataTableWhip_Operator;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Bot_Quiver;
        private System.Data.DataColumn coldsMainL3DataTableSeat_Tyre_Operator;
        private System.Data.DataColumn coldsMainL3DataTableFace_A__Quiver;
        private System.Data.DataColumn coldsMainL3DataTableFace_B__Quiver;
        private System.Data.DataColumn coldsMainL3DataTableDoff_Mod_Time;
        private System.Data.DataColumn coldsMainL3DataTableRep_Ladle_Builder;
        private System.Data.DataColumn coldsMainL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableThr_Ladle_Time;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Inner_Use_Count;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsGapBri;
        private AppSvrHMI.L3DataSet dsBreBri;
        private AppSvrHMI.L3DataSet dsCastMat;
        private System.Data.DataTable schemadsGapBri;
        private System.Data.DataColumn coldsGapBriL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsBreBri;
        private System.Data.DataColumn coldsBreBriL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsCastMat;
        private System.Data.DataColumn coldsCastMatL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsSquLeadFac;
        private System.Data.DataTable schemadsSquLeadFac;
        private System.Data.DataColumn coldsSquLeadFacL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsHalfBoaFac;
        private System.Data.DataTable schemadsHalfBoaFac;
        private System.Data.DataColumn coldsHalfBoaFacL3DataTableMATFACTORY;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
    }
}