namespace UnitMag
{
    partial class mqhsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mqhsFrm));
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tdtend = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tdtstart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dvTel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
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
            this.toolStripLabel2,
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 25);
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.Size = new System.Drawing.Size(895, 569);
            this.dvTel.TabIndex = 34;
            this.dvTel.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTel_DataError);
            // 
            // mqhsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.bnM);
            this.Name = "mqhsFrm";
            this.TabText = "煤气回收统计";
            this.Text = "煤气回收统计";
            this.Load += new System.EventHandler(this.NCTelDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private buttonHide.ToolStripToriDateTimePicker tdtstart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker tdtend;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.BindingSource bsMqhs;
        private System.Windows.Forms.ToolStripButton btnOutput;
    }
}