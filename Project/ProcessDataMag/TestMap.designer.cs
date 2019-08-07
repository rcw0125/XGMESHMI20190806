namespace ProcessDataMag
{
    partial class TestMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMap));
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.cmbElement = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGrade = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBOFID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtPage = new System.Windows.Forms.ToolStripTextBox();
            this.txtRowNum = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.pbxMap = new System.Windows.Forms.PictureBox();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsElement = new AppSvrHMI.L3DataSet();
            this.schemadsTest = new System.Data.DataTable();
            this.coldsTestL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTestL3DataTableElement = new System.Data.DataColumn();
            this.coldsTestL3DataTableEle_Max = new System.Data.DataColumn();
            this.coldsTestL3DataTableEle_Min = new System.Data.DataColumn();
            this.coldsTestL3DataTableRowNum = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTest)).BeginInit();
            this.SuspendLayout();
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.CountItem = null;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnQuery,
            this.dtStart,
            this.toolStripLabel7,
            this.cmbElement,
            this.toolStripLabel3,
            this.cmbSteelGrade,
            this.toolStripLabel2,
            this.cmbBOFID,
            this.toolStripLabel4,
            this.txtPage,
            this.txtRowNum});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = null;
            this.bnM.MoveLastItem = null;
            this.bnM.MoveNextItem = null;
            this.bnM.MovePreviousItem = null;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = null;
            this.bnM.Size = new System.Drawing.Size(1020, 25);
            this.bnM.TabIndex = 0;
            this.bnM.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "　";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查看";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2009-03";
            this.dtStart.Value = new System.DateTime(2009, 3, 9, 15, 33, 49, 390);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel7.Text = "日期:";
            // 
            // cmbElement
            // 
            this.cmbElement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbElement.Items.AddRange(new object[] {
            "C",
            "Si",
            "Mn",
            "P",
            "S"});
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "温度类型:";
            // 
            // cmbSteelGrade
            // 
            this.cmbSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSteelGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSteelGrade.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbSteelGrade.Name = "cmbSteelGrade";
            this.cmbSteelGrade.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "钢种:";
            // 
            // cmbBOFID
            // 
            this.cmbBOFID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOFID.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbBOFID.Items.AddRange(new object[] {
            "S21",
            "S22",
            "S23",
            "S24"});
            this.cmbBOFID.Name = "cmbBOFID";
            this.cmbBOFID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "转炉:";
            // 
            // txtPage
            // 
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 25);
            // 
            // txtRowNum
            // 
            this.txtRowNum.Name = "txtRowNum";
            this.txtRowNum.Size = new System.Drawing.Size(100, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.pbxMap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 655);
            this.panel1.TabIndex = 1;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(182, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(41, 27);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(140, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 27);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(98, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(41, 27);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(56, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(41, 27);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // pbxMap
            // 
            this.pbxMap.BackColor = System.Drawing.Color.White;
            this.pbxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMap.Location = new System.Drawing.Point(0, 0);
            this.pbxMap.Name = "pbxMap";
            this.pbxMap.Size = new System.Drawing.Size(1020, 655);
            this.pbxMap.TabIndex = 0;
            this.pbxMap.TabStop = false;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsElement
            // 
            this.dsElement.AutoLoad = true;
            this.dsElement.AutoSubscribe = false;
            this.dsElement.DataSetName = "L3DataSet";
            this.dsElement.DeleteMethod = "";
            this.dsElement.InsertMethod = "";
            this.dsElement.L3DataAdapter = this.Adapter;
            this.dsElement.LoadEvent = "";
            this.dsElement.LoadTrigger = null;
            this.dsElement.RefreshValve = 1000;
            this.dsElement.SourceCommand = null;
            this.dsElement.SourceCondition = "";
            this.dsElement.SourceMethod = "";
            this.dsElement.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsElement.SourceURI = "";
            this.dsElement.SubscribeTarget = null;
            this.dsElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTest});
            this.dsElement.UpdateEvent = "";
            this.dsElement.UpdateMethod = "";
            this.dsElement.UpdateTrigger = null;
            // 
            // schemadsTest
            // 
            this.schemadsTest.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTestL3DataTableHeatID,
            this.coldsTestL3DataTableElement,
            this.coldsTestL3DataTableEle_Max,
            this.coldsTestL3DataTableEle_Min,
            this.coldsTestL3DataTableRowNum});
            this.schemadsTest.TableName = "L3DataTable";
            // 
            // coldsTestL3DataTableHeatID
            // 
            this.coldsTestL3DataTableHeatID.Caption = "HeatID";
            this.coldsTestL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTestL3DataTableHeatID.Namespace = "";
            // 
            // coldsTestL3DataTableElement
            // 
            this.coldsTestL3DataTableElement.Caption = "Element";
            this.coldsTestL3DataTableElement.ColumnName = "Element";
            this.coldsTestL3DataTableElement.Namespace = "";
            // 
            // coldsTestL3DataTableEle_Max
            // 
            this.coldsTestL3DataTableEle_Max.Caption = "Ele_Max";
            this.coldsTestL3DataTableEle_Max.ColumnName = "Ele_Max";
            this.coldsTestL3DataTableEle_Max.Namespace = "";
            // 
            // coldsTestL3DataTableEle_Min
            // 
            this.coldsTestL3DataTableEle_Min.Caption = "Ele_Min";
            this.coldsTestL3DataTableEle_Min.ColumnName = "Ele_Min";
            this.coldsTestL3DataTableEle_Min.Namespace = "";
            // 
            // coldsTestL3DataTableRowNum
            // 
            this.coldsTestL3DataTableRowNum.Caption = "RowNum";
            this.coldsTestL3DataTableRowNum.ColumnName = "RowNum";
            this.coldsTestL3DataTableRowNum.DataType = typeof(long);
            this.coldsTestL3DataTableRowNum.Namespace = "";
            // 
            // TestMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestMap";
            this.TabText = "调度图表";
            this.Text = "调度图表";
            this.SizeChanged += new System.EventHandler(this.TestMap_SizeChanged);
            this.Load += new System.EventHandler(this.TestMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxMap;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3DataSet dsElement;
        private System.Data.DataTable schemadsTest;
        private System.Data.DataColumn coldsTestL3DataTableHeatID;
        private System.Data.DataColumn coldsTestL3DataTableElement;
        private System.Data.DataColumn coldsTestL3DataTableEle_Max;
        private System.Data.DataColumn coldsTestL3DataTableEle_Min;
        private System.Data.DataColumn coldsTestL3DataTableRowNum;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cmbElement;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGrade;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbBOFID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtPage;
        private System.Windows.Forms.ToolStripTextBox txtRowNum;
    }
}