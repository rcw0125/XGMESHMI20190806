namespace UnitMag.TAPMag
{
    partial class TAPHeatFinalDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAPHeatFinalDataFrm));
            this.bsHeatData = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatData = new AppSvrHMI.L3DataSet();
            this.schemadsHeatData = new System.Data.DataTable();
            this.coldsHeatDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableName = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableShift = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableTeam = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableLocked = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
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
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvHeatData = new System.Windows.Forms.DataGridView();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.Locked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTapID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatData)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsHeatData
            // 
            this.bsHeatData.DataMember = "L3DataTable";
            this.bsHeatData.DataSource = this.dsHeatData;
            // 
            // dsHeatData
            // 
            this.dsHeatData.AutoSubscribe = true;
            this.dsHeatData.DataSetName = "L3DataSet";
            this.dsHeatData.DeleteMethod = null;
            this.dsHeatData.InsertMethod = null;
            this.dsHeatData.L3DataAdapter = null;
            this.dsHeatData.LoadEvent = "Click";
            this.dsHeatData.LoadTrigger = null;
            this.dsHeatData.RefreshValve = 1000;
            this.dsHeatData.SourceCommand = null;
            this.dsHeatData.SourceCondition = null;
            this.dsHeatData.SourceMethod = "";
            this.dsHeatData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatData.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Base_Data";
            this.dsHeatData.SubscribeTarget = null;
            this.dsHeatData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatData});
            this.dsHeatData.UpdateEvent = "Click";
            this.dsHeatData.UpdateMethod = null;
            this.dsHeatData.UpdateTrigger = null;
            // 
            // schemadsHeatData
            // 
            this.schemadsHeatData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatDataL3DataTableGUID,
            this.coldsHeatDataL3DataTableName,
            this.coldsHeatDataL3DataTableHeatID,
            this.coldsHeatDataL3DataTableSteelGradeIndex,
            this.coldsHeatDataL3DataTableSteelGrade,
            this.coldsHeatDataL3DataTableLadleNo,
            this.coldsHeatDataL3DataTablePreHeatID,
            this.coldsHeatDataL3DataTableProductionDate,
            this.coldsHeatDataL3DataTableShift,
            this.coldsHeatDataL3DataTableTeam,
            this.coldsHeatDataL3DataTableLocked});
            this.schemadsHeatData.TableName = "L3DataTable";
            // 
            // coldsHeatDataL3DataTableGUID
            // 
            this.coldsHeatDataL3DataTableGUID.Caption = "GUID";
            this.coldsHeatDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsHeatDataL3DataTableGUID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableName
            // 
            this.coldsHeatDataL3DataTableName.Caption = "Name";
            this.coldsHeatDataL3DataTableName.ColumnName = "Name";
            this.coldsHeatDataL3DataTableName.Namespace = "";
            // 
            // coldsHeatDataL3DataTableHeatID
            // 
            this.coldsHeatDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatDataL3DataTableHeatID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableSteelGradeIndex
            // 
            this.coldsHeatDataL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsHeatDataL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsHeatDataL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsHeatDataL3DataTableSteelGrade
            // 
            this.coldsHeatDataL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsHeatDataL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsHeatDataL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsHeatDataL3DataTableLadleNo
            // 
            this.coldsHeatDataL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsHeatDataL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsHeatDataL3DataTableLadleNo.Namespace = "";
            // 
            // coldsHeatDataL3DataTablePreHeatID
            // 
            this.coldsHeatDataL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsHeatDataL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsHeatDataL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableProductionDate
            // 
            this.coldsHeatDataL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsHeatDataL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsHeatDataL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsHeatDataL3DataTableProductionDate.Namespace = "";
            // 
            // coldsHeatDataL3DataTableShift
            // 
            this.coldsHeatDataL3DataTableShift.Caption = "Shift";
            this.coldsHeatDataL3DataTableShift.ColumnName = "Shift";
            this.coldsHeatDataL3DataTableShift.Namespace = "";
            // 
            // coldsHeatDataL3DataTableTeam
            // 
            this.coldsHeatDataL3DataTableTeam.Caption = "Team";
            this.coldsHeatDataL3DataTableTeam.ColumnName = "Team";
            this.coldsHeatDataL3DataTableTeam.Namespace = "";
            // 
            // coldsHeatDataL3DataTableLocked
            // 
            this.coldsHeatDataL3DataTableLocked.Caption = "Locked";
            this.coldsHeatDataL3DataTableLocked.ColumnName = "Locked";
            this.coldsHeatDataL3DataTableLocked.DataType = typeof(short);
            this.coldsHeatDataL3DataTableLocked.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cbxUpdate
            // 
            this.Adapter.SetAccessRight(this.cbxUpdate, "SideCheck");
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Location = new System.Drawing.Point(201, 5);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(72, 16);
            this.cbxUpdate.TabIndex = 26;
            this.cbxUpdate.Text = "数据修正";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BOFbtnConfirm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(73, 22);
            this.btnConfirm.Text = "实绩确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvHeatData);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1047, 531);
            this.hmiRootPanel1.TabIndex = 25;
            // 
            // dvHeatData
            // 
            this.dvHeatData.AllowUserToAddRows = false;
            this.dvHeatData.AutoGenerateColumns = false;
            this.dvHeatData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeatID,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.ladleNoDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.Locked,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvHeatData.DataSource = this.bsHeatData;
            this.dvHeatData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatData.Location = new System.Drawing.Point(0, 0);
            this.dvHeatData.Name = "dvHeatData";
            this.dvHeatData.ReadOnly = true;
            this.dvHeatData.RowTemplate.Height = 23;
            this.dvHeatData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvHeatData.Size = new System.Drawing.Size(1047, 531);
            this.dvHeatData.TabIndex = 0;
            this.dvHeatData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvHeatData_DataBindingComplete);
            this.dvHeatData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvHeatData_CellMouseDoubleClick);
            this.dvHeatData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvHeatData_DataError);
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            this.HeatID.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ladleNoDataGridViewTextBoxColumn
            // 
            this.ladleNoDataGridViewTextBoxColumn.DataPropertyName = "LadleNo";
            this.ladleNoDataGridViewTextBoxColumn.HeaderText = "钢包号";
            this.ladleNoDataGridViewTextBoxColumn.Name = "ladleNoDataGridViewTextBoxColumn";
            this.ladleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShift;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsShift
            // 
            this.dsShift.AutoSubscribe = true;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = null;
            this.dsShift.InsertMethod = null;
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "Click";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = null;
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "Click";
            this.dsShift.UpdateMethod = null;
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTableCode,
            this.coldsShiftL3DataTableCode_Des});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTableCode
            // 
            this.coldsShiftL3DataTableCode.Caption = "Code";
            this.coldsShiftL3DataTableCode.ColumnName = "Code";
            this.coldsShiftL3DataTableCode.Namespace = "";
            // 
            // coldsShiftL3DataTableCode_Des
            // 
            this.coldsShiftL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsTeam
            // 
            this.dsTeam.AutoSubscribe = true;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = null;
            this.dsTeam.InsertMethod = null;
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "Click";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "Click";
            this.dsTeam.UpdateMethod = null;
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTableCode
            // 
            this.coldsTeamL3DataTableCode.Caption = "Code";
            this.coldsTeamL3DataTableCode.ColumnName = "Code";
            this.coldsTeamL3DataTableCode.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Des
            // 
            this.coldsTeamL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.Namespace = "";
            // 
            // Locked
            // 
            this.Locked.DataPropertyName = "Locked";
            this.Locked.HeaderText = "封存标志";
            this.Locked.Name = "Locked";
            this.Locked.ReadOnly = true;
            this.Locked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Locked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsHeatData;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel4,
            this.toolStripLabel1,
            this.btnQuery,
            this.dtData,
            this.toolStripLabel3,
            this.cmbTapID,
            this.toolStripLabel2,
            this.btnConfirm,
            this.txtHeatID,
            this.toolStripLabel5});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1047, 25);
            this.bdN1.TabIndex = 24;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "       ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtData
            // 
            this.dtData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtData.CustomFormat = "yyyy-MM-dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(100, 22);
            this.dtData.Text = "2008-11-10";
            this.dtData.Value = new System.DateTime(2008, 11, 10, 11, 16, 8, 907);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "日期:";
            // 
            // cmbTapID
            // 
            this.cmbTapID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTapID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTapID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTapID.Name = "cmbTapID";
            this.cmbTapID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "炉座号:";
            // 
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "炉号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = true;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = null;
            this.dsUnitID.InsertMethod = null;
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "Click";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "CODE_GROUP = \'Side\' order by code";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = null;
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "Click";
            this.dsUnitID.UpdateMethod = null;
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // TAPHeatFinalDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 556);
            this.Controls.Add(this.cbxUpdate);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TAPHeatFinalDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "炉后实绩数据管理";
            this.Text = "炉后实绩数据管理";
            this.Load += new System.EventHandler(this.TAPHeatFinalDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatData)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsHeatData;
        private AppSvrHMI.L3DataSet dsHeatData;
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
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbTapID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvHeatData;
        private System.Data.DataTable schemadsHeatData;
        private System.Data.DataColumn coldsHeatDataL3DataTableGUID;
        private System.Data.DataColumn coldsHeatDataL3DataTableName;
        private System.Data.DataColumn coldsHeatDataL3DataTableHeatID;
        private System.Data.DataColumn coldsHeatDataL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsHeatDataL3DataTableSteelGrade;
        private System.Data.DataColumn coldsHeatDataL3DataTableLadleNo;
        private System.Data.DataColumn coldsHeatDataL3DataTablePreHeatID;
        private System.Data.DataColumn coldsHeatDataL3DataTableProductionDate;
        private System.Data.DataColumn coldsHeatDataL3DataTableShift;
        private System.Data.DataColumn coldsHeatDataL3DataTableTeam;
        private System.Data.DataColumn coldsHeatDataL3DataTableLocked;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCode;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locked;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}