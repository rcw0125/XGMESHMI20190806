namespace DispatchMag
{
    partial class DisExcepitonalItemsShowFrm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pxRichTextBox1 = new PxDataValid.PxRichTextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableIDObject = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableItems = new System.Data.DataColumn();
            this.coldsMainL3DataTableBeginTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableEndTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableTimeSpan = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.dsItems = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsItems = new System.Data.DataTable();
            this.coldsItemsL3DataTablepk_exception = new System.Data.DataColumn();
            this.coldsItemsL3DataTableexception_code = new System.Data.DataColumn();
            this.coldsItemsL3DataTableexception_name = new System.Data.DataColumn();
            this.dtCreatTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsUnitID = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTablePK_CENTER = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCENTER_NAME = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCENTER_CODE = new System.Data.DataColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 247);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(228, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
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
            this.tabControl1.Size = new System.Drawing.Size(397, 247);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pxRichTextBox1);
            this.tabPage1.Controls.Add(this.cmbItems);
            this.tabPage1.Controls.Add(this.dtCreatTime);
            this.tabPage1.Controls.Add(this.dtEndTime);
            this.tabPage1.Controls.Add(this.dtStartTime);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "详细信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pxRichTextBox1
            // 
            this.pxRichTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.pxRichTextBox1.EnableNull = true;
            this.pxRichTextBox1.ErropPr = this.errorProvider1;
            this.pxRichTextBox1.Location = new System.Drawing.Point(139, 129);
            this.pxRichTextBox1.MaxStrLength = 125;
            this.pxRichTextBox1.Name = "pxRichTextBox1";
            this.pxRichTextBox1.Size = new System.Drawing.Size(173, 72);
            this.pxRichTextBox1.TabIndex = 4;
            this.pxRichTextBox1.Text = "";
            this.pxRichTextBox1.ToolTipValid = this.toolTip1;
            this.pxRichTextBox1.ValidEable = true;
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
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
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
            this.coldsMainL3DataTableIDObject,
            this.coldsMainL3DataTableCreateTime,
            this.coldsMainL3DataTableItems,
            this.coldsMainL3DataTableBeginTime,
            this.coldsMainL3DataTableEndTime,
            this.coldsMainL3DataTableTimeSpan,
            this.coldsMainL3DataTableNote});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableIDObject
            // 
            this.coldsMainL3DataTableIDObject.Caption = "IDObject";
            this.coldsMainL3DataTableIDObject.ColumnName = "IDObject";
            this.coldsMainL3DataTableIDObject.Namespace = "";
            // 
            // coldsMainL3DataTableCreateTime
            // 
            this.coldsMainL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsMainL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsMainL3DataTableCreateTime.Namespace = "";
            // 
            // coldsMainL3DataTableItems
            // 
            this.coldsMainL3DataTableItems.Caption = "Items";
            this.coldsMainL3DataTableItems.ColumnName = "Items";
            this.coldsMainL3DataTableItems.Namespace = "";
            // 
            // coldsMainL3DataTableBeginTime
            // 
            this.coldsMainL3DataTableBeginTime.Caption = "BeginTime";
            this.coldsMainL3DataTableBeginTime.ColumnName = "BeginTime";
            this.coldsMainL3DataTableBeginTime.Namespace = "";
            // 
            // coldsMainL3DataTableEndTime
            // 
            this.coldsMainL3DataTableEndTime.Caption = "EndTime";
            this.coldsMainL3DataTableEndTime.ColumnName = "EndTime";
            this.coldsMainL3DataTableEndTime.Namespace = "";
            // 
            // coldsMainL3DataTableTimeSpan
            // 
            this.coldsMainL3DataTableTimeSpan.Caption = "TimeSpan";
            this.coldsMainL3DataTableTimeSpan.ColumnName = "TimeSpan";
            this.coldsMainL3DataTableTimeSpan.DataType = typeof(int);
            this.coldsMainL3DataTableTimeSpan.Namespace = "";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbItems
            // 
            this.cmbItems.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Items", true));
            this.cmbItems.DataSource = this.bsItems;
            this.cmbItems.DisplayMember = "exception_name";
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(139, 103);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(173, 20);
            this.cmbItems.TabIndex = 3;
            this.cmbItems.ValueMember = "pk_exception";
            // 
            // bsItems
            // 
            this.bsItems.DataMember = "L3DataTable";
            this.bsItems.DataSource = this.dsItems;
            // 
            // dsItems
            // 
            this.dsItems.AutoSubscribe = false;
            this.dsItems.DataSetName = "L3DataSet";
            this.dsItems.DeleteMethod = "";
            this.dsItems.InsertMethod = "";
            this.dsItems.L3DataAdapter = this.Adapter;
            this.dsItems.LoadEvent = "";
            this.dsItems.LoadTrigger = null;
            this.dsItems.RefreshValve = 1000;
            this.dsItems.SourceCommand = null;
            this.dsItems.SourceCondition = "";
            this.dsItems.SourceMethod = "";
            this.dsItems.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsItems.SourceURI = "";
            this.dsItems.SubscribeTarget = "";
            this.dsItems.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsItems});
            this.dsItems.UpdateEvent = "";
            this.dsItems.UpdateMethod = "";
            this.dsItems.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsItems
            // 
            this.schemadsItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsItemsL3DataTablepk_exception,
            this.coldsItemsL3DataTableexception_code,
            this.coldsItemsL3DataTableexception_name});
            this.schemadsItems.TableName = "L3DataTable";
            // 
            // coldsItemsL3DataTablepk_exception
            // 
            this.coldsItemsL3DataTablepk_exception.Caption = "pk_exception";
            this.coldsItemsL3DataTablepk_exception.ColumnName = "pk_exception";
            this.coldsItemsL3DataTablepk_exception.Namespace = "";
            // 
            // coldsItemsL3DataTableexception_code
            // 
            this.coldsItemsL3DataTableexception_code.Caption = "exception_code";
            this.coldsItemsL3DataTableexception_code.ColumnName = "exception_code";
            this.coldsItemsL3DataTableexception_code.Namespace = "";
            // 
            // coldsItemsL3DataTableexception_name
            // 
            this.coldsItemsL3DataTableexception_name.Caption = "exception_name";
            this.coldsItemsL3DataTableexception_name.ColumnName = "exception_name";
            this.coldsItemsL3DataTableexception_name.Namespace = "";
            // 
            // dtCreatTime
            // 
            this.dtCreatTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtCreatTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CreateTime", true));
            this.dtCreatTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatTime.Location = new System.Drawing.Point(139, 22);
            this.dtCreatTime.Name = "dtCreatTime";
            this.dtCreatTime.Size = new System.Drawing.Size(173, 21);
            this.dtCreatTime.TabIndex = 1;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "HH:mm:ss";
            this.dtEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "EndTime", true));
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(139, 76);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.ShowUpDown = true;
            this.dtEndTime.Size = new System.Drawing.Size(173, 21);
            this.dtEndTime.TabIndex = 1;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "HH:mm:ss";
            this.dtStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BeginTime", true));
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(139, 49);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(173, 21);
            this.dtStartTime.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "创建时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "备　　注:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "异常项目:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "结束时刻:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时刻:";
            // 
            // bsUnitID
            // 
            this.bsUnitID.DataMember = "L3DataTable";
            this.bsUnitID.DataSource = this.dsUnitID;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsUnitID.SourceURI = "";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTablePK_CENTER,
            this.coldsUnitIDL3DataTableCENTER_NAME,
            this.coldsUnitIDL3DataTableCENTER_CODE});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTablePK_CENTER
            // 
            this.coldsUnitIDL3DataTablePK_CENTER.Caption = "PK_CENTER";
            this.coldsUnitIDL3DataTablePK_CENTER.ColumnName = "PK_CENTER";
            this.coldsUnitIDL3DataTablePK_CENTER.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCENTER_NAME
            // 
            this.coldsUnitIDL3DataTableCENTER_NAME.Caption = "CENTER_NAME";
            this.coldsUnitIDL3DataTableCENTER_NAME.ColumnName = "CENTER_NAME";
            this.coldsUnitIDL3DataTableCENTER_NAME.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCENTER_CODE
            // 
            this.coldsUnitIDL3DataTableCENTER_CODE.Caption = "CENTER_CODE";
            this.coldsUnitIDL3DataTableCENTER_CODE.ColumnName = "CENTER_CODE";
            this.coldsUnitIDL3DataTableCENTER_CODE.Namespace = "";
            // 
            // DisExcepitonalItemsShowFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(397, 303);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DisExcepitonalItemsShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备异常详细信息";
            this.Load += new System.EventHandler(this.DisExcepitonalItemsShowFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.DateTimePicker dtCreatTime;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTablePK_CENTER;
        private System.Data.DataColumn coldsUnitIDL3DataTableCENTER_NAME;
        private System.Data.DataColumn coldsUnitIDL3DataTableCENTER_CODE;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableIDObject;
        private System.Data.DataColumn coldsMainL3DataTableCreateTime;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsUnitID;
        private System.Data.DataColumn coldsMainL3DataTableItems;
        private System.Data.DataColumn coldsMainL3DataTableBeginTime;
        private System.Data.DataColumn coldsMainL3DataTableEndTime;
        private System.Data.DataColumn coldsMainL3DataTableTimeSpan;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label label7;
        private AppSvrHMI.L3DataSet dsItems;
        private System.Data.DataTable schemadsItems;
        private System.Data.DataColumn coldsItemsL3DataTablepk_exception;
        private System.Data.DataColumn coldsItemsL3DataTableexception_code;
        private System.Data.DataColumn coldsItemsL3DataTableexception_name;
        private System.Windows.Forms.BindingSource bsItems;
        private PxDataValid.PxRichTextBox pxRichTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}