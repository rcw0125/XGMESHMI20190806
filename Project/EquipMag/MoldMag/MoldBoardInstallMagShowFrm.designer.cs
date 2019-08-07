namespace EquipMag.MoldMag
{
    partial class MoldBoardInstallMagShowFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsInstall = new AppSvrHMI.L3DataSet();
            this.schemadsInstall = new System.Data.DataTable();
            this.coldsInstallL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableName = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInstall_Date = new System.Data.DataColumn();
            this.coldsInstallL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableHit_Press_Flag = new System.Data.DataColumn();
            this.coldsInstallL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINNERID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableOuter_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableSouth_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNorth_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRep_Count = new System.Data.DataColumn();
            this.coldsInstallL3DataTableLug_Steel_Mea = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_Start_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_End_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInstall_Per = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Two_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Two_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Two_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Three_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Three_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Up_Three_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Down_Eight_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Down_Eight_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWide_Down_Eight_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Two_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Two_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Two_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Three_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Three_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Up_Three_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Down_Eight_Fir = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Down_Eight_Sec = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNar_Down_Eight_Thi = new System.Data.DataColumn();
            this.coldsInstallL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNote = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_Fac = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInStallID = new System.Data.DataColumn();
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
            this.dsMoldID = new AppSvrHMI.L3DataSet();
            this.schemadsMoldID = new System.Data.DataTable();
            this.coldsMoldIDL3DataTableMoldID = new System.Data.DataColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbFlag = new PxDataValid.PxComboBox();
            this.dsFlag = new AppSvrHMI.L3DataSet();
            this.schemadsFlag = new System.Data.DataTable();
            this.coldsFlagL3DataTableCode = new System.Data.DataColumn();
            this.coldsFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.label46 = new System.Windows.Forms.Label();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.myLine1 = new buttonHide.MyLine();
            this.txtCopperNorthID = new PxDataValid.PxTextBox();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.txtNarDownEightFir = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtNarDownEightThi = new PxDataValid.PxTextBox();
            this.txtWideDownEightThi = new PxDataValid.PxTextBox();
            this.txtWideDownEightSec = new PxDataValid.PxTextBox();
            this.txtNarUpThreeFir = new PxDataValid.PxTextBox();
            this.txtNarUpThreeThi = new PxDataValid.PxTextBox();
            this.txtCopperSouthID = new PxDataValid.PxTextBox();
            this.txtInstalPer = new PxDataValid.PxTextBox();
            this.txtWideUpThreeThi = new PxDataValid.PxTextBox();
            this.txtCopperInnerID = new PxDataValid.PxTextBox();
            this.txtCopperLugSteelMea = new PxDataValid.PxTextBox();
            this.txtCopperOuterID = new PxDataValid.PxTextBox();
            this.txtWideUpThreeSec = new PxDataValid.PxTextBox();
            this.txtCopperRepCount = new PxDataValid.PxTextBox();
            this.txtNarUpTwoFir = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNarUpTwoThi = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWideUpTwoThi = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWideUpTwoSec = new PxDataValid.PxTextBox();
            this.txtWideDownEightFir = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNarDownEightSec = new PxDataValid.PxTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtWideUpThreeFir = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNarUpThreeSec = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtWideUpTwoFir = new PxDataValid.PxTextBox();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtNarUpTwoSec = new PxDataValid.PxTextBox();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label38 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtRepairStopTime = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.dtInstallDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.dtRepairStartTime = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRepairFac = new PxDataValid.PxComboBox();
            this.dsRepairFac = new AppSvrHMI.L3DataSet();
            this.schemadsRepairFac = new System.Data.DataTable();
            this.coldsRepairFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.cmbCopperFac = new PxDataValid.PxComboBox();
            this.dsCopperFac = new AppSvrHMI.L3DataSet();
            this.schemadsCopperFac = new System.Data.DataTable();
            this.coldsCopperFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbMoldID = new PxDataValid.PxComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepairFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRepairFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInstall
            // 
            this.bsInstall.DataMember = "L3DataTable";
            this.bsInstall.DataSource = this.dsInstall;
            // 
            // dsInstall
            // 
            this.dsInstall.AutoLoad = true;
            this.dsInstall.AutoSubscribe = false;
            this.dsInstall.DataSetName = "L3DataSet";
            this.dsInstall.DeleteMethod = null;
            this.dsInstall.InsertMethod = null;
            this.dsInstall.L3DataAdapter = null;
            this.dsInstall.LoadEvent = "Click";
            this.dsInstall.LoadTrigger = null;
            this.dsInstall.RefreshValve = 1000;
            this.dsInstall.SourceCommand = null;
            this.dsInstall.SourceCondition = "";
            this.dsInstall.SourceMethod = "";
            this.dsInstall.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInstall.SourceURI = "XGMESLogic\\MoldMag\\CMold_Board_Install";
            this.dsInstall.SubscribeTarget = null;
            this.dsInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInstall});
            this.dsInstall.UpdateEvent = "Click";
            this.dsInstall.UpdateMethod = null;
            this.dsInstall.UpdateTrigger = null;
            // 
            // schemadsInstall
            // 
            this.schemadsInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInstallL3DataTableGUID,
            this.coldsInstallL3DataTableName,
            this.coldsInstallL3DataTableInput_Time,
            this.coldsInstallL3DataTableInstall_Date,
            this.coldsInstallL3DataTableMoldID,
            this.coldsInstallL3DataTableHit_Press_Flag,
            this.coldsInstallL3DataTableCopper_Fac,
            this.coldsInstallL3DataTableINNERID,
            this.coldsInstallL3DataTableOuter_ID,
            this.coldsInstallL3DataTableSouth_ID,
            this.coldsInstallL3DataTableNorth_ID,
            this.coldsInstallL3DataTableRep_Count,
            this.coldsInstallL3DataTableLug_Steel_Mea,
            this.coldsInstallL3DataTableRepair_Start_Time,
            this.coldsInstallL3DataTableRepair_End_Time,
            this.coldsInstallL3DataTableInstall_Per,
            this.coldsInstallL3DataTableWide_Up_Two_Fir,
            this.coldsInstallL3DataTableWide_Up_Two_Sec,
            this.coldsInstallL3DataTableWide_Up_Two_Thi,
            this.coldsInstallL3DataTableWide_Up_Three_Fir,
            this.coldsInstallL3DataTableWide_Up_Three_Sec,
            this.coldsInstallL3DataTableWide_Up_Three_Thi,
            this.coldsInstallL3DataTableWide_Down_Eight_Fir,
            this.coldsInstallL3DataTableWide_Down_Eight_Sec,
            this.coldsInstallL3DataTableWide_Down_Eight_Thi,
            this.coldsInstallL3DataTableNar_Up_Two_Fir,
            this.coldsInstallL3DataTableNar_Up_Two_Sec,
            this.coldsInstallL3DataTableNar_Up_Two_Thi,
            this.coldsInstallL3DataTableNar_Up_Three_Fir,
            this.coldsInstallL3DataTableNar_Up_Three_Sec,
            this.coldsInstallL3DataTableNar_Up_Three_Thi,
            this.coldsInstallL3DataTableNar_Down_Eight_Fir,
            this.coldsInstallL3DataTableNar_Down_Eight_Sec,
            this.coldsInstallL3DataTableNar_Down_Eight_Thi,
            this.coldsInstallL3DataTableTeamID,
            this.coldsInstallL3DataTableShiftID,
            this.coldsInstallL3DataTableOperator,
            this.coldsInstallL3DataTableNote,
            this.coldsInstallL3DataTableRepair_Fac,
            this.coldsInstallL3DataTableInStallID});
            this.schemadsInstall.TableName = "L3DataTable";
            // 
            // coldsInstallL3DataTableGUID
            // 
            this.coldsInstallL3DataTableGUID.Caption = "GUID";
            this.coldsInstallL3DataTableGUID.ColumnName = "GUID";
            this.coldsInstallL3DataTableGUID.Namespace = "";
            // 
            // coldsInstallL3DataTableName
            // 
            this.coldsInstallL3DataTableName.Caption = "Name";
            this.coldsInstallL3DataTableName.ColumnName = "Name";
            this.coldsInstallL3DataTableName.Namespace = "";
            // 
            // coldsInstallL3DataTableInput_Time
            // 
            this.coldsInstallL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsInstallL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsInstallL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableInput_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableInstall_Date
            // 
            this.coldsInstallL3DataTableInstall_Date.Caption = "Install_Date";
            this.coldsInstallL3DataTableInstall_Date.ColumnName = "Install_Date";
            this.coldsInstallL3DataTableInstall_Date.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableInstall_Date.Namespace = "";
            // 
            // coldsInstallL3DataTableMoldID
            // 
            this.coldsInstallL3DataTableMoldID.Caption = "MoldID";
            this.coldsInstallL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsInstallL3DataTableMoldID.Namespace = "";
            // 
            // coldsInstallL3DataTableHit_Press_Flag
            // 
            this.coldsInstallL3DataTableHit_Press_Flag.Caption = "Hit_Press_Flag";
            this.coldsInstallL3DataTableHit_Press_Flag.ColumnName = "Hit_Press_Flag";
            this.coldsInstallL3DataTableHit_Press_Flag.DataType = typeof(int);
            this.coldsInstallL3DataTableHit_Press_Flag.Namespace = "";
            // 
            // coldsInstallL3DataTableCopper_Fac
            // 
            this.coldsInstallL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsInstallL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsInstallL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsInstallL3DataTableINNERID
            // 
            this.coldsInstallL3DataTableINNERID.Caption = "Inner_ID";
            this.coldsInstallL3DataTableINNERID.ColumnName = "Inner_ID";
            this.coldsInstallL3DataTableINNERID.Namespace = "";
            // 
            // coldsInstallL3DataTableOuter_ID
            // 
            this.coldsInstallL3DataTableOuter_ID.Caption = "Outer_ID";
            this.coldsInstallL3DataTableOuter_ID.ColumnName = "Outer_ID";
            this.coldsInstallL3DataTableOuter_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableSouth_ID
            // 
            this.coldsInstallL3DataTableSouth_ID.Caption = "South_ID";
            this.coldsInstallL3DataTableSouth_ID.ColumnName = "South_ID";
            this.coldsInstallL3DataTableSouth_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableNorth_ID
            // 
            this.coldsInstallL3DataTableNorth_ID.Caption = "North_ID";
            this.coldsInstallL3DataTableNorth_ID.ColumnName = "North_ID";
            this.coldsInstallL3DataTableNorth_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableRep_Count
            // 
            this.coldsInstallL3DataTableRep_Count.Caption = "Rep_Count";
            this.coldsInstallL3DataTableRep_Count.ColumnName = "Rep_Count";
            this.coldsInstallL3DataTableRep_Count.DataType = typeof(int);
            this.coldsInstallL3DataTableRep_Count.Namespace = "";
            // 
            // coldsInstallL3DataTableLug_Steel_Mea
            // 
            this.coldsInstallL3DataTableLug_Steel_Mea.Caption = "Lug_Steel_Mea";
            this.coldsInstallL3DataTableLug_Steel_Mea.ColumnName = "Lug_Steel_Mea";
            this.coldsInstallL3DataTableLug_Steel_Mea.DataType = typeof(double);
            this.coldsInstallL3DataTableLug_Steel_Mea.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_Start_Time
            // 
            this.coldsInstallL3DataTableRepair_Start_Time.Caption = "Repair_Start_Time";
            this.coldsInstallL3DataTableRepair_Start_Time.ColumnName = "Repair_Start_Time";
            this.coldsInstallL3DataTableRepair_Start_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableRepair_Start_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_End_Time
            // 
            this.coldsInstallL3DataTableRepair_End_Time.Caption = "Repair_End_Time";
            this.coldsInstallL3DataTableRepair_End_Time.ColumnName = "Repair_End_Time";
            this.coldsInstallL3DataTableRepair_End_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableRepair_End_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableInstall_Per
            // 
            this.coldsInstallL3DataTableInstall_Per.Caption = "Install_Per";
            this.coldsInstallL3DataTableInstall_Per.ColumnName = "Install_Per";
            this.coldsInstallL3DataTableInstall_Per.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Two_Fir
            // 
            this.coldsInstallL3DataTableWide_Up_Two_Fir.Caption = "Wide_Up_Two_Fir";
            this.coldsInstallL3DataTableWide_Up_Two_Fir.ColumnName = "Wide_Up_Two_Fir";
            this.coldsInstallL3DataTableWide_Up_Two_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Two_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Two_Sec
            // 
            this.coldsInstallL3DataTableWide_Up_Two_Sec.Caption = "Wide_Up_Two_Sec";
            this.coldsInstallL3DataTableWide_Up_Two_Sec.ColumnName = "Wide_Up_Two_Sec";
            this.coldsInstallL3DataTableWide_Up_Two_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Two_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Two_Thi
            // 
            this.coldsInstallL3DataTableWide_Up_Two_Thi.Caption = "Wide_Up_Two_Thi";
            this.coldsInstallL3DataTableWide_Up_Two_Thi.ColumnName = "Wide_Up_Two_Thi";
            this.coldsInstallL3DataTableWide_Up_Two_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Two_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Three_Fir
            // 
            this.coldsInstallL3DataTableWide_Up_Three_Fir.Caption = "Wide_Up_Three_Fir";
            this.coldsInstallL3DataTableWide_Up_Three_Fir.ColumnName = "Wide_Up_Three_Fir";
            this.coldsInstallL3DataTableWide_Up_Three_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Three_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Three_Sec
            // 
            this.coldsInstallL3DataTableWide_Up_Three_Sec.Caption = "Wide_Up_Three_Sec";
            this.coldsInstallL3DataTableWide_Up_Three_Sec.ColumnName = "Wide_Up_Three_Sec";
            this.coldsInstallL3DataTableWide_Up_Three_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Three_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Up_Three_Thi
            // 
            this.coldsInstallL3DataTableWide_Up_Three_Thi.Caption = "Wide_Up_Three_Thi";
            this.coldsInstallL3DataTableWide_Up_Three_Thi.ColumnName = "Wide_Up_Three_Thi";
            this.coldsInstallL3DataTableWide_Up_Three_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Up_Three_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Down_Eight_Fir
            // 
            this.coldsInstallL3DataTableWide_Down_Eight_Fir.Caption = "Wide_Down_Eight_Fir";
            this.coldsInstallL3DataTableWide_Down_Eight_Fir.ColumnName = "Wide_Down_Eight_Fir";
            this.coldsInstallL3DataTableWide_Down_Eight_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Down_Eight_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Down_Eight_Sec
            // 
            this.coldsInstallL3DataTableWide_Down_Eight_Sec.Caption = "Wide_Down_Eight_Sec";
            this.coldsInstallL3DataTableWide_Down_Eight_Sec.ColumnName = "Wide_Down_Eight_Sec";
            this.coldsInstallL3DataTableWide_Down_Eight_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Down_Eight_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableWide_Down_Eight_Thi
            // 
            this.coldsInstallL3DataTableWide_Down_Eight_Thi.Caption = "Wide_Down_Eight_Thi";
            this.coldsInstallL3DataTableWide_Down_Eight_Thi.ColumnName = "Wide_Down_Eight_Thi";
            this.coldsInstallL3DataTableWide_Down_Eight_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableWide_Down_Eight_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Two_Fir
            // 
            this.coldsInstallL3DataTableNar_Up_Two_Fir.Caption = "Nar_Up_Two_Fir";
            this.coldsInstallL3DataTableNar_Up_Two_Fir.ColumnName = "Nar_Up_Two_Fir";
            this.coldsInstallL3DataTableNar_Up_Two_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Two_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Two_Sec
            // 
            this.coldsInstallL3DataTableNar_Up_Two_Sec.Caption = "Nar_Up_Two_Sec";
            this.coldsInstallL3DataTableNar_Up_Two_Sec.ColumnName = "Nar_Up_Two_Sec";
            this.coldsInstallL3DataTableNar_Up_Two_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Two_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Two_Thi
            // 
            this.coldsInstallL3DataTableNar_Up_Two_Thi.Caption = "Nar_Up_Two_Thi";
            this.coldsInstallL3DataTableNar_Up_Two_Thi.ColumnName = "Nar_Up_Two_Thi";
            this.coldsInstallL3DataTableNar_Up_Two_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Two_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Three_Fir
            // 
            this.coldsInstallL3DataTableNar_Up_Three_Fir.Caption = "Nar_Up_Three_Fir";
            this.coldsInstallL3DataTableNar_Up_Three_Fir.ColumnName = "Nar_Up_Three_Fir";
            this.coldsInstallL3DataTableNar_Up_Three_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Three_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Three_Sec
            // 
            this.coldsInstallL3DataTableNar_Up_Three_Sec.Caption = "Nar_Up_Three_Sec";
            this.coldsInstallL3DataTableNar_Up_Three_Sec.ColumnName = "Nar_Up_Three_Sec";
            this.coldsInstallL3DataTableNar_Up_Three_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Three_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Up_Three_Thi
            // 
            this.coldsInstallL3DataTableNar_Up_Three_Thi.Caption = "Nar_Up_Three_Thi";
            this.coldsInstallL3DataTableNar_Up_Three_Thi.ColumnName = "Nar_Up_Three_Thi";
            this.coldsInstallL3DataTableNar_Up_Three_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Up_Three_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Down_Eight_Fir
            // 
            this.coldsInstallL3DataTableNar_Down_Eight_Fir.Caption = "Nar_Down_Eight_Fir";
            this.coldsInstallL3DataTableNar_Down_Eight_Fir.ColumnName = "Nar_Down_Eight_Fir";
            this.coldsInstallL3DataTableNar_Down_Eight_Fir.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Down_Eight_Fir.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Down_Eight_Sec
            // 
            this.coldsInstallL3DataTableNar_Down_Eight_Sec.Caption = "Nar_Down_Eight_Sec";
            this.coldsInstallL3DataTableNar_Down_Eight_Sec.ColumnName = "Nar_Down_Eight_Sec";
            this.coldsInstallL3DataTableNar_Down_Eight_Sec.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Down_Eight_Sec.Namespace = "";
            // 
            // coldsInstallL3DataTableNar_Down_Eight_Thi
            // 
            this.coldsInstallL3DataTableNar_Down_Eight_Thi.Caption = "Nar_Down_Eight_Thi";
            this.coldsInstallL3DataTableNar_Down_Eight_Thi.ColumnName = "Nar_Down_Eight_Thi";
            this.coldsInstallL3DataTableNar_Down_Eight_Thi.DataType = typeof(double);
            this.coldsInstallL3DataTableNar_Down_Eight_Thi.Namespace = "";
            // 
            // coldsInstallL3DataTableTeamID
            // 
            this.coldsInstallL3DataTableTeamID.Caption = "TeamID";
            this.coldsInstallL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsInstallL3DataTableTeamID.Namespace = "";
            // 
            // coldsInstallL3DataTableShiftID
            // 
            this.coldsInstallL3DataTableShiftID.Caption = "ShiftID";
            this.coldsInstallL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsInstallL3DataTableShiftID.Namespace = "";
            // 
            // coldsInstallL3DataTableOperator
            // 
            this.coldsInstallL3DataTableOperator.Caption = "Operator";
            this.coldsInstallL3DataTableOperator.ColumnName = "Operator";
            this.coldsInstallL3DataTableOperator.Namespace = "";
            // 
            // coldsInstallL3DataTableNote
            // 
            this.coldsInstallL3DataTableNote.Caption = "Note";
            this.coldsInstallL3DataTableNote.ColumnName = "Note";
            this.coldsInstallL3DataTableNote.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_Fac
            // 
            this.coldsInstallL3DataTableRepair_Fac.Caption = "Repair_Fac";
            this.coldsInstallL3DataTableRepair_Fac.ColumnName = "Repair_Fac";
            this.coldsInstallL3DataTableRepair_Fac.Namespace = "";
            // 
            // coldsInstallL3DataTableInStallID
            // 
            this.coldsInstallL3DataTableInStallID.Caption = "InStallID";
            this.coldsInstallL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsInstallL3DataTableInStallID.Namespace = "";
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
            this.dsMoldID.SourceCondition = "MoldID like \'J12%\'";
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(741, 3);
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
            this.btnConfirm.Location = new System.Drawing.Point(660, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 313);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(819, 77);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbFlag);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.txtCopperNorthID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.txtNarDownEightFir);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.txtNarDownEightThi);
            this.tabPage1.Controls.Add(this.txtWideDownEightThi);
            this.tabPage1.Controls.Add(this.txtWideDownEightSec);
            this.tabPage1.Controls.Add(this.txtNarUpThreeFir);
            this.tabPage1.Controls.Add(this.txtNarUpThreeThi);
            this.tabPage1.Controls.Add(this.txtCopperSouthID);
            this.tabPage1.Controls.Add(this.txtInstalPer);
            this.tabPage1.Controls.Add(this.txtWideUpThreeThi);
            this.tabPage1.Controls.Add(this.txtCopperInnerID);
            this.tabPage1.Controls.Add(this.txtCopperLugSteelMea);
            this.tabPage1.Controls.Add(this.txtCopperOuterID);
            this.tabPage1.Controls.Add(this.txtWideUpThreeSec);
            this.tabPage1.Controls.Add(this.txtCopperRepCount);
            this.tabPage1.Controls.Add(this.txtNarUpTwoFir);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtNarUpTwoThi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtWideUpTwoThi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtWideUpTwoSec);
            this.tabPage1.Controls.Add(this.txtWideDownEightFir);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txtNarDownEightSec);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txtWideUpThreeFir);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.txtNarUpThreeSec);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.txtWideUpTwoFir);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.txtNarUpTwoSec);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.dtRepairStopTime);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.dtInstallDate);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.dtRepairStartTime);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbRepairFac);
            this.tabPage1.Controls.Add(this.cmbCopperFac);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.cmbMoldID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结晶器铜板装配实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbFlag
            // 
            this.cmbFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "Hit_Press_Flag", true));
            this.cmbFlag.DataSource = this.dsFlag;
            this.cmbFlag.DisplayMember = "L3DataTable.Code_Des";
            this.cmbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlag.EnableNull = false;
            this.cmbFlag.ErropPr = null;
            this.cmbFlag.FormattingEnabled = true;
            this.cmbFlag.Location = new System.Drawing.Point(100, 136);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.Size = new System.Drawing.Size(141, 20);
            this.cmbFlag.TabIndex = 65;
            this.cmbFlag.ToolTipValid = null;
            this.cmbFlag.ValidEable = false;
            this.cmbFlag.ValueMember = "L3DataTable.Code";
            // 
            // dsFlag
            // 
            this.dsFlag.AutoLoad = true;
            this.dsFlag.AutoSubscribe = false;
            this.dsFlag.DataSetName = "L3DataSet";
            this.dsFlag.DeleteMethod = "";
            this.dsFlag.InsertMethod = "";
            this.dsFlag.L3DataAdapter = this.Adapter;
            this.dsFlag.LoadEvent = "";
            this.dsFlag.LoadTrigger = null;
            this.dsFlag.RefreshValve = 1000;
            this.dsFlag.SourceCommand = null;
            this.dsFlag.SourceCondition = "Code_Group = \'COMMON_YESNO\' order by Code desc";
            this.dsFlag.SourceMethod = "";
            this.dsFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFlag.SubscribeTarget = null;
            this.dsFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFlag});
            this.dsFlag.UpdateEvent = "";
            this.dsFlag.UpdateMethod = "";
            this.dsFlag.UpdateTrigger = null;
            // 
            // schemadsFlag
            // 
            this.schemadsFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFlagL3DataTableCode,
            this.coldsFlagL3DataTableCode_Des});
            this.schemadsFlag.TableName = "L3DataTable";
            // 
            // coldsFlagL3DataTableCode
            // 
            this.coldsFlagL3DataTableCode.Caption = "Code";
            this.coldsFlagL3DataTableCode.ColumnName = "Code";
            this.coldsFlagL3DataTableCode.Namespace = "";
            // 
            // coldsFlagL3DataTableCode_Des
            // 
            this.coldsFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFlagL3DataTableCode_Des.Namespace = "";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(58, 242);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 53;
            this.label46.Text = "备注:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(99, 238);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(698, 41);
            this.rtxtNote.TabIndex = 35;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(461, 192);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(336, 10);
            this.myLine1.TabIndex = 64;
            // 
            // txtCopperNorthID
            // 
            this.txtCopperNorthID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "North_ID", true));
            this.txtCopperNorthID.EnableNull = true;
            this.txtCopperNorthID.ErropPr = null;
            this.txtCopperNorthID.Length = 0;
            this.txtCopperNorthID.Location = new System.Drawing.Point(347, 86);
            this.txtCopperNorthID.Max = 0;
            this.txtCopperNorthID.MaxStrLength = 0;
            this.txtCopperNorthID.Min = 0;
            this.txtCopperNorthID.MinStrLength = 0;
            this.txtCopperNorthID.Name = "txtCopperNorthID";
            this.txtCopperNorthID.Precision = 0;
            this.txtCopperNorthID.Size = new System.Drawing.Size(100, 21);
            this.txtCopperNorthID.TabIndex = 11;
            this.txtCopperNorthID.ToolTipValid = null;
            this.txtCopperNorthID.ValidEable = false;
            this.txtCopperNorthID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperNorthID.TextChanged += new System.EventHandler(this.txtCopperID_TextChanged);
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(347, 187);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(100, 21);
            this.txtOperator.TabIndex = 15;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtNarDownEightFir
            // 
            this.txtNarDownEightFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Down_Eight_Fir", true));
            this.txtNarDownEightFir.EnableNull = false;
            this.txtNarDownEightFir.ErropPr = null;
            this.txtNarDownEightFir.Length = 0;
            this.txtNarDownEightFir.Location = new System.Drawing.Point(566, 160);
            this.txtNarDownEightFir.Max = 0;
            this.txtNarDownEightFir.MaxStrLength = 0;
            this.txtNarDownEightFir.Min = 9999;
            this.txtNarDownEightFir.MinStrLength = 0;
            this.txtNarDownEightFir.Name = "txtNarDownEightFir";
            this.txtNarDownEightFir.Precision = 0;
            this.txtNarDownEightFir.Size = new System.Drawing.Size(73, 21);
            this.txtNarDownEightFir.TabIndex = 32;
            this.txtNarDownEightFir.ToolTipValid = this.toolTip1;
            this.txtNarDownEightFir.ValidEable = true;
            this.txtNarDownEightFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarDownEightFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(294, 191);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 52;
            this.label47.Text = "责任人:";
            // 
            // txtNarDownEightThi
            // 
            this.txtNarDownEightThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Down_Eight_Thi", true));
            this.txtNarDownEightThi.EnableNull = false;
            this.txtNarDownEightThi.ErropPr = this.errorProvider1;
            this.txtNarDownEightThi.Length = 0;
            this.txtNarDownEightThi.Location = new System.Drawing.Point(724, 161);
            this.txtNarDownEightThi.Max = 9999;
            this.txtNarDownEightThi.MaxStrLength = 0;
            this.txtNarDownEightThi.Min = -0.99;
            this.txtNarDownEightThi.MinStrLength = 0;
            this.txtNarDownEightThi.Name = "txtNarDownEightThi";
            this.txtNarDownEightThi.Precision = 0;
            this.txtNarDownEightThi.Size = new System.Drawing.Size(73, 21);
            this.txtNarDownEightThi.TabIndex = 34;
            this.txtNarDownEightThi.ToolTipValid = this.toolTip1;
            this.txtNarDownEightThi.ValidEable = true;
            this.txtNarDownEightThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarDownEightThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWideDownEightThi
            // 
            this.txtWideDownEightThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Down_Eight_Thi", true));
            this.txtWideDownEightThi.EnableNull = false;
            this.txtWideDownEightThi.ErropPr = this.errorProvider1;
            this.txtWideDownEightThi.Length = 0;
            this.txtWideDownEightThi.Location = new System.Drawing.Point(724, 87);
            this.txtWideDownEightThi.Max = 9999;
            this.txtWideDownEightThi.MaxStrLength = 0;
            this.txtWideDownEightThi.Min = -0.99;
            this.txtWideDownEightThi.MinStrLength = 0;
            this.txtWideDownEightThi.Name = "txtWideDownEightThi";
            this.txtWideDownEightThi.Precision = 0;
            this.txtWideDownEightThi.Size = new System.Drawing.Size(73, 21);
            this.txtWideDownEightThi.TabIndex = 25;
            this.txtWideDownEightThi.ToolTipValid = this.toolTip1;
            this.txtWideDownEightThi.ValidEable = false;
            this.txtWideDownEightThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideDownEightThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWideDownEightSec
            // 
            this.txtWideDownEightSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Down_Eight_Sec", true));
            this.txtWideDownEightSec.EnableNull = false;
            this.txtWideDownEightSec.ErropPr = this.errorProvider1;
            this.txtWideDownEightSec.Length = 0;
            this.txtWideDownEightSec.Location = new System.Drawing.Point(645, 87);
            this.txtWideDownEightSec.Max = 9999;
            this.txtWideDownEightSec.MaxStrLength = 0;
            this.txtWideDownEightSec.Min = -0.99;
            this.txtWideDownEightSec.MinStrLength = 0;
            this.txtWideDownEightSec.Name = "txtWideDownEightSec";
            this.txtWideDownEightSec.Precision = 0;
            this.txtWideDownEightSec.Size = new System.Drawing.Size(73, 21);
            this.txtWideDownEightSec.TabIndex = 24;
            this.txtWideDownEightSec.ToolTipValid = this.toolTip1;
            this.txtWideDownEightSec.ValidEable = false;
            this.txtWideDownEightSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideDownEightSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtNarUpThreeFir
            // 
            this.txtNarUpThreeFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Three_Fir", true));
            this.txtNarUpThreeFir.EnableNull = false;
            this.txtNarUpThreeFir.ErropPr = null;
            this.txtNarUpThreeFir.Length = 0;
            this.txtNarUpThreeFir.Location = new System.Drawing.Point(566, 135);
            this.txtNarUpThreeFir.Max = 0;
            this.txtNarUpThreeFir.MaxStrLength = 0;
            this.txtNarUpThreeFir.Min = 9999;
            this.txtNarUpThreeFir.MinStrLength = 0;
            this.txtNarUpThreeFir.Name = "txtNarUpThreeFir";
            this.txtNarUpThreeFir.Precision = 0;
            this.txtNarUpThreeFir.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpThreeFir.TabIndex = 29;
            this.txtNarUpThreeFir.ToolTipValid = this.toolTip1;
            this.txtNarUpThreeFir.ValidEable = true;
            this.txtNarUpThreeFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpThreeFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtNarUpThreeThi
            // 
            this.txtNarUpThreeThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Three_Thi", true));
            this.txtNarUpThreeThi.EnableNull = false;
            this.txtNarUpThreeThi.ErropPr = this.errorProvider1;
            this.txtNarUpThreeThi.Length = 0;
            this.txtNarUpThreeThi.Location = new System.Drawing.Point(724, 136);
            this.txtNarUpThreeThi.Max = 9999;
            this.txtNarUpThreeThi.MaxStrLength = 0;
            this.txtNarUpThreeThi.Min = -0.99;
            this.txtNarUpThreeThi.MinStrLength = 0;
            this.txtNarUpThreeThi.Name = "txtNarUpThreeThi";
            this.txtNarUpThreeThi.Precision = 0;
            this.txtNarUpThreeThi.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpThreeThi.TabIndex = 31;
            this.txtNarUpThreeThi.ToolTipValid = this.toolTip1;
            this.txtNarUpThreeThi.ValidEable = true;
            this.txtNarUpThreeThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpThreeThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtCopperSouthID
            // 
            this.txtCopperSouthID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "South_ID", true));
            this.txtCopperSouthID.EnableNull = true;
            this.txtCopperSouthID.ErropPr = null;
            this.txtCopperSouthID.Length = 0;
            this.txtCopperSouthID.Location = new System.Drawing.Point(347, 61);
            this.txtCopperSouthID.Max = 0;
            this.txtCopperSouthID.MaxStrLength = 0;
            this.txtCopperSouthID.Min = 0;
            this.txtCopperSouthID.MinStrLength = 0;
            this.txtCopperSouthID.Name = "txtCopperSouthID";
            this.txtCopperSouthID.Precision = 0;
            this.txtCopperSouthID.Size = new System.Drawing.Size(100, 21);
            this.txtCopperSouthID.TabIndex = 10;
            this.txtCopperSouthID.ToolTipValid = null;
            this.txtCopperSouthID.ValidEable = false;
            this.txtCopperSouthID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperSouthID.TextChanged += new System.EventHandler(this.txtCopperID_TextChanged);
            // 
            // txtInstalPer
            // 
            this.txtInstalPer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Install_Per", true));
            this.txtInstalPer.EnableNull = true;
            this.txtInstalPer.ErropPr = null;
            this.txtInstalPer.Length = 0;
            this.txtInstalPer.Location = new System.Drawing.Point(347, 211);
            this.txtInstalPer.Max = 0;
            this.txtInstalPer.MaxStrLength = 0;
            this.txtInstalPer.Min = 0;
            this.txtInstalPer.MinStrLength = 0;
            this.txtInstalPer.Name = "txtInstalPer";
            this.txtInstalPer.Precision = 0;
            this.txtInstalPer.Size = new System.Drawing.Size(450, 21);
            this.txtInstalPer.TabIndex = 16;
            this.txtInstalPer.ToolTipValid = null;
            this.txtInstalPer.ValidEable = true;
            this.txtInstalPer.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWideUpThreeThi
            // 
            this.txtWideUpThreeThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Three_Thi", true));
            this.txtWideUpThreeThi.EnableNull = false;
            this.txtWideUpThreeThi.ErropPr = this.errorProvider1;
            this.txtWideUpThreeThi.Length = 0;
            this.txtWideUpThreeThi.Location = new System.Drawing.Point(724, 62);
            this.txtWideUpThreeThi.Max = 9999;
            this.txtWideUpThreeThi.MaxStrLength = 0;
            this.txtWideUpThreeThi.Min = -0.99;
            this.txtWideUpThreeThi.MinStrLength = 0;
            this.txtWideUpThreeThi.Name = "txtWideUpThreeThi";
            this.txtWideUpThreeThi.Precision = 0;
            this.txtWideUpThreeThi.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpThreeThi.TabIndex = 22;
            this.txtWideUpThreeThi.ToolTipValid = this.toolTip1;
            this.txtWideUpThreeThi.ValidEable = false;
            this.txtWideUpThreeThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpThreeThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtCopperInnerID
            // 
            this.txtCopperInnerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Inner_ID", true));
            this.txtCopperInnerID.EnableNull = true;
            this.txtCopperInnerID.ErropPr = null;
            this.txtCopperInnerID.Length = 0;
            this.txtCopperInnerID.Location = new System.Drawing.Point(347, 11);
            this.txtCopperInnerID.Max = 0;
            this.txtCopperInnerID.MaxStrLength = 0;
            this.txtCopperInnerID.Min = 0;
            this.txtCopperInnerID.MinStrLength = 0;
            this.txtCopperInnerID.Name = "txtCopperInnerID";
            this.txtCopperInnerID.Precision = 0;
            this.txtCopperInnerID.Size = new System.Drawing.Size(100, 21);
            this.txtCopperInnerID.TabIndex = 8;
            this.txtCopperInnerID.ToolTipValid = null;
            this.txtCopperInnerID.ValidEable = false;
            this.txtCopperInnerID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperInnerID.TextChanged += new System.EventHandler(this.txtCopperID_TextChanged);
            // 
            // txtCopperLugSteelMea
            // 
            this.txtCopperLugSteelMea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Lug_Steel_Mea", true));
            this.txtCopperLugSteelMea.EnableNull = false;
            this.txtCopperLugSteelMea.ErropPr = this.errorProvider1;
            this.txtCopperLugSteelMea.Length = 0;
            this.txtCopperLugSteelMea.Location = new System.Drawing.Point(347, 111);
            this.txtCopperLugSteelMea.Max = 9999;
            this.txtCopperLugSteelMea.MaxStrLength = 0;
            this.txtCopperLugSteelMea.Min = 0;
            this.txtCopperLugSteelMea.MinStrLength = 0;
            this.txtCopperLugSteelMea.Name = "txtCopperLugSteelMea";
            this.txtCopperLugSteelMea.Precision = 0;
            this.txtCopperLugSteelMea.Size = new System.Drawing.Size(100, 21);
            this.txtCopperLugSteelMea.TabIndex = 12;
            this.txtCopperLugSteelMea.ToolTipValid = this.toolTip1;
            this.txtCopperLugSteelMea.ValidEable = true;
            this.txtCopperLugSteelMea.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtCopperLugSteelMea.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtCopperOuterID
            // 
            this.txtCopperOuterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Outer_ID", true));
            this.txtCopperOuterID.EnableNull = true;
            this.txtCopperOuterID.ErropPr = null;
            this.txtCopperOuterID.Length = 0;
            this.txtCopperOuterID.Location = new System.Drawing.Point(347, 36);
            this.txtCopperOuterID.Max = 0;
            this.txtCopperOuterID.MaxStrLength = 0;
            this.txtCopperOuterID.Min = 0;
            this.txtCopperOuterID.MinStrLength = 0;
            this.txtCopperOuterID.Name = "txtCopperOuterID";
            this.txtCopperOuterID.Precision = 0;
            this.txtCopperOuterID.Size = new System.Drawing.Size(100, 21);
            this.txtCopperOuterID.TabIndex = 9;
            this.txtCopperOuterID.ToolTipValid = null;
            this.txtCopperOuterID.ValidEable = false;
            this.txtCopperOuterID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperOuterID.TextChanged += new System.EventHandler(this.txtCopperID_TextChanged);
            // 
            // txtWideUpThreeSec
            // 
            this.txtWideUpThreeSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Three_Sec", true));
            this.txtWideUpThreeSec.EnableNull = false;
            this.txtWideUpThreeSec.ErropPr = this.errorProvider1;
            this.txtWideUpThreeSec.Length = 0;
            this.txtWideUpThreeSec.Location = new System.Drawing.Point(645, 62);
            this.txtWideUpThreeSec.Max = 9999;
            this.txtWideUpThreeSec.MaxStrLength = 0;
            this.txtWideUpThreeSec.Min = -0.99;
            this.txtWideUpThreeSec.MinStrLength = 0;
            this.txtWideUpThreeSec.Name = "txtWideUpThreeSec";
            this.txtWideUpThreeSec.Precision = 0;
            this.txtWideUpThreeSec.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpThreeSec.TabIndex = 21;
            this.txtWideUpThreeSec.ToolTipValid = this.toolTip1;
            this.txtWideUpThreeSec.ValidEable = false;
            this.txtWideUpThreeSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpThreeSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtCopperRepCount
            // 
            this.txtCopperRepCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Rep_Count", true));
            this.txtCopperRepCount.EnableNull = true;
            this.txtCopperRepCount.ErropPr = null;
            this.txtCopperRepCount.Length = 0;
            this.txtCopperRepCount.Location = new System.Drawing.Point(99, 211);
            this.txtCopperRepCount.Max = 0;
            this.txtCopperRepCount.MaxStrLength = 0;
            this.txtCopperRepCount.Min = 0;
            this.txtCopperRepCount.MinStrLength = 0;
            this.txtCopperRepCount.Name = "txtCopperRepCount";
            this.txtCopperRepCount.Precision = 0;
            this.txtCopperRepCount.Size = new System.Drawing.Size(141, 21);
            this.txtCopperRepCount.TabIndex = 7;
            this.txtCopperRepCount.ToolTipValid = null;
            this.txtCopperRepCount.ValidEable = true;
            this.txtCopperRepCount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperRepCount.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtNarUpTwoFir
            // 
            this.txtNarUpTwoFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Two_Fir", true));
            this.txtNarUpTwoFir.EnableNull = false;
            this.txtNarUpTwoFir.ErropPr = null;
            this.txtNarUpTwoFir.Length = 0;
            this.txtNarUpTwoFir.Location = new System.Drawing.Point(566, 111);
            this.txtNarUpTwoFir.Max = 0;
            this.txtNarUpTwoFir.MaxStrLength = 0;
            this.txtNarUpTwoFir.Min = 9999;
            this.txtNarUpTwoFir.MinStrLength = 0;
            this.txtNarUpTwoFir.Name = "txtNarUpTwoFir";
            this.txtNarUpTwoFir.Precision = 0;
            this.txtNarUpTwoFir.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpTwoFir.TabIndex = 26;
            this.txtNarUpTwoFir.ToolTipValid = this.toolTip1;
            this.txtNarUpTwoFir.ValidEable = true;
            this.txtNarUpTwoFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpTwoFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(294, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "装配人:";
            // 
            // txtNarUpTwoThi
            // 
            this.txtNarUpTwoThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Two_Thi", true));
            this.txtNarUpTwoThi.EnableNull = false;
            this.txtNarUpTwoThi.ErropPr = this.errorProvider1;
            this.txtNarUpTwoThi.Length = 0;
            this.txtNarUpTwoThi.Location = new System.Drawing.Point(724, 112);
            this.txtNarUpTwoThi.Max = 9999;
            this.txtNarUpTwoThi.MaxStrLength = 0;
            this.txtNarUpTwoThi.Min = -0.99;
            this.txtNarUpTwoThi.MinStrLength = 0;
            this.txtNarUpTwoThi.Name = "txtNarUpTwoThi";
            this.txtNarUpTwoThi.Precision = 0;
            this.txtNarUpTwoThi.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpTwoThi.TabIndex = 28;
            this.txtNarUpTwoThi.ToolTipValid = this.toolTip1;
            this.txtNarUpTwoThi.ValidEable = true;
            this.txtNarUpTwoThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpTwoThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(270, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "铜板拉钢量:";
            // 
            // txtWideUpTwoThi
            // 
            this.txtWideUpTwoThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Two_Thi", true));
            this.txtWideUpTwoThi.EnableNull = false;
            this.txtWideUpTwoThi.ErropPr = this.errorProvider1;
            this.txtWideUpTwoThi.Length = 0;
            this.txtWideUpTwoThi.Location = new System.Drawing.Point(724, 37);
            this.txtWideUpTwoThi.Max = 9999;
            this.txtWideUpTwoThi.MaxStrLength = 0;
            this.txtWideUpTwoThi.Min = -0.99;
            this.txtWideUpTwoThi.MinStrLength = 0;
            this.txtWideUpTwoThi.Name = "txtWideUpTwoThi";
            this.txtWideUpTwoThi.Precision = 0;
            this.txtWideUpTwoThi.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpTwoThi.TabIndex = 19;
            this.txtWideUpTwoThi.ToolTipValid = this.toolTip1;
            this.txtWideUpTwoThi.ValidEable = false;
            this.txtWideUpTwoThi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpTwoThi.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 50;
            this.label8.Text = "铜板修复次数:";
            // 
            // txtWideUpTwoSec
            // 
            this.txtWideUpTwoSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Two_Sec", true));
            this.txtWideUpTwoSec.EnableNull = false;
            this.txtWideUpTwoSec.ErropPr = this.errorProvider1;
            this.txtWideUpTwoSec.Length = 0;
            this.txtWideUpTwoSec.Location = new System.Drawing.Point(645, 37);
            this.txtWideUpTwoSec.Max = 9999;
            this.txtWideUpTwoSec.MaxStrLength = 0;
            this.txtWideUpTwoSec.Min = -0.99;
            this.txtWideUpTwoSec.MinStrLength = 0;
            this.txtWideUpTwoSec.Name = "txtWideUpTwoSec";
            this.txtWideUpTwoSec.Precision = 0;
            this.txtWideUpTwoSec.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpTwoSec.TabIndex = 18;
            this.txtWideUpTwoSec.ToolTipValid = this.toolTip1;
            this.txtWideUpTwoSec.ValidEable = false;
            this.txtWideUpTwoSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpTwoSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWideDownEightFir
            // 
            this.txtWideDownEightFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Down_Eight_Fir", true));
            this.txtWideDownEightFir.EnableNull = false;
            this.txtWideDownEightFir.ErropPr = null;
            this.txtWideDownEightFir.Length = 0;
            this.txtWideDownEightFir.Location = new System.Drawing.Point(566, 86);
            this.txtWideDownEightFir.Max = 0;
            this.txtWideDownEightFir.MaxStrLength = 0;
            this.txtWideDownEightFir.Min = 9999;
            this.txtWideDownEightFir.MinStrLength = 0;
            this.txtWideDownEightFir.Name = "txtWideDownEightFir";
            this.txtWideDownEightFir.Precision = 0;
            this.txtWideDownEightFir.Size = new System.Drawing.Size(73, 21);
            this.txtWideDownEightFir.TabIndex = 23;
            this.txtWideDownEightFir.ToolTipValid = this.toolTip1;
            this.txtWideDownEightFir.ValidEable = false;
            this.txtWideDownEightFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideDownEightFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(258, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "铜板北侧编号:";
            // 
            // txtNarDownEightSec
            // 
            this.txtNarDownEightSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Down_Eight_Sec", true));
            this.txtNarDownEightSec.EnableNull = false;
            this.txtNarDownEightSec.ErropPr = this.errorProvider1;
            this.txtNarDownEightSec.Length = 0;
            this.txtNarDownEightSec.Location = new System.Drawing.Point(645, 161);
            this.txtNarDownEightSec.Max = 9999;
            this.txtNarDownEightSec.MaxStrLength = 0;
            this.txtNarDownEightSec.Min = -0.99;
            this.txtNarDownEightSec.MinStrLength = 0;
            this.txtNarDownEightSec.Name = "txtNarDownEightSec";
            this.txtNarDownEightSec.Precision = 0;
            this.txtNarDownEightSec.Size = new System.Drawing.Size(73, 21);
            this.txtNarDownEightSec.TabIndex = 33;
            this.txtNarDownEightSec.ToolTipValid = this.toolTip1;
            this.txtNarDownEightSec.ValidEable = true;
            this.txtNarDownEightSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarDownEightSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(258, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 12);
            this.label22.TabIndex = 47;
            this.label22.Text = "铜板南侧编号:";
            // 
            // txtWideUpThreeFir
            // 
            this.txtWideUpThreeFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Three_Fir", true));
            this.txtWideUpThreeFir.EnableNull = false;
            this.txtWideUpThreeFir.ErropPr = this.errorProvider1;
            this.txtWideUpThreeFir.Length = 0;
            this.txtWideUpThreeFir.Location = new System.Drawing.Point(566, 61);
            this.txtWideUpThreeFir.Max = 9999;
            this.txtWideUpThreeFir.MaxStrLength = 0;
            this.txtWideUpThreeFir.Min = -0.99;
            this.txtWideUpThreeFir.MinStrLength = 0;
            this.txtWideUpThreeFir.Name = "txtWideUpThreeFir";
            this.txtWideUpThreeFir.Precision = 0;
            this.txtWideUpThreeFir.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpThreeFir.TabIndex = 20;
            this.txtWideUpThreeFir.ToolTipValid = this.toolTip1;
            this.txtWideUpThreeFir.ValidEable = false;
            this.txtWideUpThreeFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpThreeFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(258, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 12);
            this.label23.TabIndex = 46;
            this.label23.Text = "铜板外弧编号:";
            // 
            // txtNarUpThreeSec
            // 
            this.txtNarUpThreeSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Three_Sec", true));
            this.txtNarUpThreeSec.EnableNull = false;
            this.txtNarUpThreeSec.ErropPr = this.errorProvider1;
            this.txtNarUpThreeSec.Length = 0;
            this.txtNarUpThreeSec.Location = new System.Drawing.Point(645, 136);
            this.txtNarUpThreeSec.Max = 9999;
            this.txtNarUpThreeSec.MaxStrLength = 0;
            this.txtNarUpThreeSec.Min = -0.99;
            this.txtNarUpThreeSec.MinStrLength = 0;
            this.txtNarUpThreeSec.Name = "txtNarUpThreeSec";
            this.txtNarUpThreeSec.Precision = 0;
            this.txtNarUpThreeSec.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpThreeSec.TabIndex = 30;
            this.txtNarUpThreeSec.ToolTipValid = this.toolTip1;
            this.txtNarUpThreeSec.ValidEable = true;
            this.txtNarUpThreeSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpThreeSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(258, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 45;
            this.label24.Text = "铜板内弧编号:";
            // 
            // txtWideUpTwoFir
            // 
            this.txtWideUpTwoFir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Wide_Up_Two_Fir", true));
            this.txtWideUpTwoFir.EnableNull = false;
            this.txtWideUpTwoFir.ErropPr = this.errorProvider1;
            this.txtWideUpTwoFir.Length = 0;
            this.txtWideUpTwoFir.Location = new System.Drawing.Point(566, 36);
            this.txtWideUpTwoFir.Max = 9999;
            this.txtWideUpTwoFir.MaxStrLength = 0;
            this.txtWideUpTwoFir.Min = 0;
            this.txtWideUpTwoFir.MinStrLength = 0;
            this.txtWideUpTwoFir.Name = "txtWideUpTwoFir";
            this.txtWideUpTwoFir.Precision = 0;
            this.txtWideUpTwoFir.Size = new System.Drawing.Size(73, 21);
            this.txtWideUpTwoFir.TabIndex = 17;
            this.txtWideUpTwoFir.ToolTipValid = this.toolTip1;
            this.txtWideUpTwoFir.ValidEable = false;
            this.txtWideUpTwoFir.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWideUpTwoFir.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(347, 163);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(100, 20);
            this.cmbShiftID.TabIndex = 14;
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
            // txtNarUpTwoSec
            // 
            this.txtNarUpTwoSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Nar_Up_Two_Sec", true));
            this.txtNarUpTwoSec.EnableNull = false;
            this.txtNarUpTwoSec.ErropPr = this.errorProvider1;
            this.txtNarUpTwoSec.Length = 0;
            this.txtNarUpTwoSec.Location = new System.Drawing.Point(645, 112);
            this.txtNarUpTwoSec.Max = 9999;
            this.txtNarUpTwoSec.MaxStrLength = 0;
            this.txtNarUpTwoSec.Min = -0.99;
            this.txtNarUpTwoSec.MinStrLength = 0;
            this.txtNarUpTwoSec.Name = "txtNarUpTwoSec";
            this.txtNarUpTwoSec.Precision = 0;
            this.txtNarUpTwoSec.Size = new System.Drawing.Size(73, 21);
            this.txtNarUpTwoSec.TabIndex = 27;
            this.txtNarUpTwoSec.ToolTipValid = this.toolTip1;
            this.txtNarUpTwoSec.ValidEable = true;
            this.txtNarUpTwoSec.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtNarUpTwoSec.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(347, 136);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(100, 20);
            this.cmbTeamID.TabIndex = 13;
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
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(459, 65);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(101, 12);
            this.label38.TabIndex = 59;
            this.label38.Text = "宽面距上口300mm:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(306, 167);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 44;
            this.label44.Text = "班次:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(465, 164);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 12);
            this.label25.TabIndex = 63;
            this.label25.Text = "窄面距下口80mm:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(306, 140);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 43;
            this.label45.Text = "班别:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(459, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 12);
            this.label26.TabIndex = 62;
            this.label26.Text = "窄面距上口300mm:";
            // 
            // dtRepairStopTime
            // 
            this.dtRepairStopTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRepairStopTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Repair_End_Time", true));
            this.dtRepairStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRepairStopTime.Location = new System.Drawing.Point(100, 86);
            this.dtRepairStopTime.Name = "dtRepairStopTime";
            this.dtRepairStopTime.Size = new System.Drawing.Size(141, 21);
            this.dtRepairStopTime.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(459, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 61;
            this.label27.Text = "窄面距上口200mm:";
            // 
            // dtInstallDate
            // 
            this.dtInstallDate.CustomFormat = "yyyy-MM-dd";
            this.dtInstallDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Install_Date", true));
            this.dtInstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInstallDate.Location = new System.Drawing.Point(100, 36);
            this.dtInstallDate.Name = "dtInstallDate";
            this.dtInstallDate.Size = new System.Drawing.Size(141, 21);
            this.dtInstallDate.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(459, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 12);
            this.label28.TabIndex = 58;
            this.label28.Text = "宽面距上口200mm:";
            // 
            // dtRepairStartTime
            // 
            this.dtRepairStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRepairStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Repair_Start_Time", true));
            this.dtRepairStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRepairStartTime.Location = new System.Drawing.Point(100, 61);
            this.dtRepairStartTime.Name = "dtRepairStartTime";
            this.dtRepairStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtRepairStartTime.TabIndex = 2;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(737, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 57;
            this.label29.Text = "点3[mm]";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(100, 11);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(658, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 56;
            this.label30.Text = "点2[mm]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "维修结束时间:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(579, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 12);
            this.label31.TabIndex = 55;
            this.label31.Text = "点1[mm]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(35, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "安装日期:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(498, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 54;
            this.label32.Text = "项目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "维修开始时间:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(465, 90);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 12);
            this.label39.TabIndex = 60;
            this.label39.Text = "宽面距下口80mm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "录入时间:";
            // 
            // cmbRepairFac
            // 
            this.cmbRepairFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRepairFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRepairFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Repair_Fac", true));
            this.cmbRepairFac.DataSource = this.dsRepairFac;
            this.cmbRepairFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbRepairFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepairFac.EnableNull = true;
            this.cmbRepairFac.ErropPr = null;
            this.cmbRepairFac.FormattingEnabled = true;
            this.cmbRepairFac.Location = new System.Drawing.Point(99, 187);
            this.cmbRepairFac.Name = "cmbRepairFac";
            this.cmbRepairFac.Size = new System.Drawing.Size(141, 20);
            this.cmbRepairFac.TabIndex = 6;
            this.cmbRepairFac.ToolTipValid = null;
            this.cmbRepairFac.ValidEable = false;
            this.cmbRepairFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsRepairFac
            // 
            this.dsRepairFac.AutoLoad = true;
            this.dsRepairFac.AutoSubscribe = false;
            this.dsRepairFac.DataSetName = "L3DataSet";
            this.dsRepairFac.DeleteMethod = null;
            this.dsRepairFac.InsertMethod = null;
            this.dsRepairFac.L3DataAdapter = this.Adapter;
            this.dsRepairFac.LoadEvent = "Click";
            this.dsRepairFac.LoadTrigger = null;
            this.dsRepairFac.RefreshValve = 1000;
            this.dsRepairFac.SourceCommand = null;
            this.dsRepairFac.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜板修复\'";
            this.dsRepairFac.SourceMethod = "";
            this.dsRepairFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRepairFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsRepairFac.SubscribeTarget = null;
            this.dsRepairFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRepairFac});
            this.dsRepairFac.UpdateEvent = "Click";
            this.dsRepairFac.UpdateMethod = null;
            this.dsRepairFac.UpdateTrigger = null;
            // 
            // schemadsRepairFac
            // 
            this.schemadsRepairFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRepairFacL3DataTableMatFactory});
            this.schemadsRepairFac.TableName = "L3DataTable";
            // 
            // coldsRepairFacL3DataTableMatFactory
            // 
            this.coldsRepairFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsRepairFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsRepairFacL3DataTableMatFactory.Namespace = "";
            // 
            // cmbCopperFac
            // 
            this.cmbCopperFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCopperFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCopperFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Copper_Fac", true));
            this.cmbCopperFac.DataSource = this.dsCopperFac;
            this.cmbCopperFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbCopperFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopperFac.EnableNull = true;
            this.cmbCopperFac.ErropPr = null;
            this.cmbCopperFac.FormattingEnabled = true;
            this.cmbCopperFac.Location = new System.Drawing.Point(100, 160);
            this.cmbCopperFac.Name = "cmbCopperFac";
            this.cmbCopperFac.Size = new System.Drawing.Size(141, 20);
            this.cmbCopperFac.TabIndex = 5;
            this.cmbCopperFac.ToolTipValid = null;
            this.cmbCopperFac.ValidEable = false;
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
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(11, 191);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 12);
            this.label33.TabIndex = 42;
            this.label33.Text = "铜板修复厂家:";
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "MoldID", true));
            this.cmbMoldID.DataSource = this.dsMoldID;
            this.cmbMoldID.DisplayMember = "L3DataTable.MoldID";
            this.cmbMoldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoldID.EnableNull = false;
            this.cmbMoldID.ErropPr = this.errorProvider1;
            this.cmbMoldID.FormattingEnabled = true;
            this.cmbMoldID.Location = new System.Drawing.Point(100, 111);
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.Size = new System.Drawing.Size(141, 20);
            this.cmbMoldID.TabIndex = 4;
            this.cmbMoldID.ToolTipValid = this.toolTip1;
            this.cmbMoldID.ValidEable = true;
            this.cmbMoldID.ValueMember = "L3DataTable.MoldID";
            this.cmbMoldID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(35, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "铜板厂家:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "打压是否合格:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "结晶器编号:";
            // 
            // MoldBoardInstallMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 390);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MoldBoardInstallMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结晶器铜板装配实绩信息维护";
            this.Load += new System.EventHandler(this.MoldBoardInstallMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepairFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRepairFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInstall;
        private AppSvrHMI.L3DataSet dsInstall;
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
        private System.Data.DataTable schemadsInstall;
        private System.Data.DataColumn coldsInstallL3DataTableGUID;
        private System.Data.DataColumn coldsInstallL3DataTableName;
        private System.Data.DataColumn coldsInstallL3DataTableInput_Time;
        private System.Data.DataColumn coldsInstallL3DataTableInstall_Date;
        private System.Data.DataColumn coldsInstallL3DataTableMoldID;
        private System.Data.DataColumn coldsInstallL3DataTableHit_Press_Flag;
        private System.Data.DataColumn coldsInstallL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsInstallL3DataTableINNERID;
        private System.Data.DataColumn coldsInstallL3DataTableOuter_ID;
        private System.Data.DataColumn coldsInstallL3DataTableSouth_ID;
        private System.Data.DataColumn coldsInstallL3DataTableNorth_ID;
        private System.Data.DataColumn coldsInstallL3DataTableRep_Count;
        private System.Data.DataColumn coldsInstallL3DataTableLug_Steel_Mea;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_Start_Time;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_End_Time;
        private System.Data.DataColumn coldsInstallL3DataTableInstall_Per;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Two_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Two_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Two_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Three_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Three_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Up_Three_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Down_Eight_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Down_Eight_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableWide_Down_Eight_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Two_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Two_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Two_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Three_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Three_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Up_Three_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Down_Eight_Fir;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Down_Eight_Sec;
        private System.Data.DataColumn coldsInstallL3DataTableNar_Down_Eight_Thi;
        private System.Data.DataColumn coldsInstallL3DataTableTeamID;
        private System.Data.DataColumn coldsInstallL3DataTableShiftID;
        private System.Data.DataColumn coldsInstallL3DataTableOperator;
        private System.Data.DataColumn coldsInstallL3DataTableNote;
        private AppSvrHMI.L3DataSet dsMoldID;
        private System.Data.DataTable schemadsMoldID;
        private System.Data.DataColumn coldsMoldIDL3DataTableMoldID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label46;
        private buttonHide.MyLine myLine1;
        private PxDataValid.PxTextBox txtCopperNorthID;
        private PxDataValid.PxTextBox txtOperator;
        private PxDataValid.PxTextBox txtNarDownEightFir;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxTextBox txtNarDownEightThi;
        private PxDataValid.PxTextBox txtWideDownEightThi;
        private PxDataValid.PxTextBox txtWideDownEightSec;
        private PxDataValid.PxTextBox txtNarUpThreeFir;
        private PxDataValid.PxTextBox txtNarUpThreeThi;
        private PxDataValid.PxTextBox txtCopperSouthID;
        private PxDataValid.PxTextBox txtInstalPer;
        private PxDataValid.PxTextBox txtWideUpThreeThi;
        private PxDataValid.PxTextBox txtCopperInnerID;
        private PxDataValid.PxTextBox txtCopperLugSteelMea;
        private PxDataValid.PxTextBox txtCopperOuterID;
        private PxDataValid.PxTextBox txtWideUpThreeSec;
        private PxDataValid.PxTextBox txtCopperRepCount;
        private PxDataValid.PxTextBox txtNarUpTwoFir;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox txtNarUpTwoThi;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox txtWideUpTwoThi;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox txtWideUpTwoSec;
        private PxDataValid.PxTextBox txtWideDownEightFir;
        private System.Windows.Forms.Label label21;
        private PxDataValid.PxTextBox txtNarDownEightSec;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxTextBox txtWideUpThreeFir;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxTextBox txtNarUpThreeSec;
        private System.Windows.Forms.Label label24;
        private PxDataValid.PxTextBox txtWideUpTwoFir;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxTextBox txtNarUpTwoSec;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtRepairStopTime;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtInstallDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtRepairStartTime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbCopperFac;
        private PxDataValid.PxComboBox cmbMoldID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbRepairFac;
        private System.Windows.Forms.Label label33;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_Fac;
        private AppSvrHMI.L3DataSet dsCopperFac;
        private AppSvrHMI.L3DataSet dsRepairFac;
        private System.Data.DataTable schemadsCopperFac;
        private System.Data.DataColumn coldsCopperFacL3DataTableMatFactory;
        private System.Data.DataTable schemadsRepairFac;
        private System.Data.DataColumn coldsRepairFacL3DataTableMatFactory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsInstallL3DataTableInStallID;
        private AppSvrHMI.L3DataSet dsFlag;
        private System.Data.DataTable schemadsFlag;
        private System.Data.DataColumn coldsFlagL3DataTableCode;
        private System.Data.DataColumn coldsFlagL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbFlag;
    }
}