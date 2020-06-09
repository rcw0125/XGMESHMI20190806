namespace UnitMag
{
    partial class NewLadleWeightFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLadleWeightFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsMqhs = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tdtend = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tdtstart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsMqhs;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnQuery,
            this.tdtend,
            this.toolStripLabel3,
            this.tdtstart,
            this.toolStripLabel1,
            this.btnOutput});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(895, 25);
            this.bnM.TabIndex = 31;
            this.bnM.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tdtend
            // 
            this.tdtend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tdtend.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tdtend.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tdtend.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tdtend.CustomFormat = "yyyy-MM-dd";
            this.tdtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdtend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tdtend.MaximumSize = new System.Drawing.Size(0, 0);
            this.tdtend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tdtend.MinimumSize = new System.Drawing.Size(0, 0);
            this.tdtend.Name = "tdtend";
            this.tdtend.Size = new System.Drawing.Size(93, 22);
            this.tdtend.Text = "2009-03-26";
            this.tdtend.Value = new System.DateTime(2009, 3, 26, 12, 18, 41, 239);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel3.Text = "-";
            // 
            // tdtstart
            // 
            this.tdtstart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tdtstart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tdtstart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tdtstart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tdtstart.CustomFormat = "yyyy-MM-dd";
            this.tdtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdtstart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tdtstart.MaximumSize = new System.Drawing.Size(0, 0);
            this.tdtstart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tdtstart.MinimumSize = new System.Drawing.Size(0, 0);
            this.tdtstart.Name = "tdtstart";
            this.tdtstart.Size = new System.Drawing.Size(93, 22);
            this.tdtstart.Text = "2009-03-26";
            this.tdtstart.Value = new System.DateTime(2009, 3, 26, 12, 17, 30, 417);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "日期";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // dvTel
            // 
            this.dvTel.AllowUserToAddRows = false;
            this.dvTel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTel.ColumnHeadersHeight = 35;
            this.dvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column13});
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 87);
            this.dvTel.MultiSelect = false;
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTel.Size = new System.Drawing.Size(895, 507);
            this.dvTel.TabIndex = 34;
            this.dvTel.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvTel_CellPainting);
            this.dvTel.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTel_DataError);
            this.dvTel.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvTel_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "炉号";
            this.Column1.HeaderText = "炉号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "钢包";
            this.Column2.HeaderText = "钢包";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 55;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "净重";
            this.Column3.HeaderText = "净重";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LF毛重";
            this.Column4.HeaderText = "毛重";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "皮重";
            this.Column5.HeaderText = "皮重";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 55;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "扣除";
            this.Column6.HeaderText = "扣除";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 55;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "大包臂";
            this.Column7.HeaderText = "大包臂";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "大包毛重";
            this.Column8.HeaderText = "大包毛重";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "浇完皮重";
            this.Column9.HeaderText = "浇完皮重";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 55;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "浇注钢水量";
            this.Column10.HeaderText = "浇注钢水量";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 55;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "毛重差";
            this.Column11.HeaderText = "毛重差";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 55;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "剩钢";
            this.Column12.HeaderText = "剩钢";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 55;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "开浇时间";
            this.Column14.HeaderText = "开浇时间";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "浇注周期";
            this.Column15.HeaderText = "浇注周期";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 55;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "理论重量";
            this.Column16.HeaderText = "理论重量";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 55;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "中包重量";
            this.Column17.HeaderText = "中包重量";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 55;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "铸坯重量";
            this.Column18.HeaderText = "铸坯重量";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 55;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "铸坯长度";
            this.Column19.HeaderText = "铸坯长度";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 55;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "单重";
            this.Column20.HeaderText = "单重";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 55;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "备注";
            this.Column13.HeaderText = "备注";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 62);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "中包重量：停浇时重量减去开浇时中包重量； 铸坯重量：本炉铸坯跟踪值增量*单重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "理论重量：中包重量加上铸坯重量";
            // 
            // NewLadleWeightFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnM);
            this.Name = "NewLadleWeightFrm";
            this.TabText = "5#机大包称重分析(新版本)";
            this.Text = "5#机大包称重分析(新版本)";
            this.Load += new System.EventHandler(this.NCTelDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private buttonHide.ToolStripToriDateTimePicker tdtstart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker tdtend;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.BindingSource bsMqhs;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}