namespace UnitMag
{
    partial class shoupiFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shoupiFrm));
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
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tdtstart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scsjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.炉号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.炉座 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开吹时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钢种DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铸机DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.包次DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开浇时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁水DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.废钢DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁块DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.压块DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钢水DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收坯DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁耗 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scsjBindingSource)).BeginInit();
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
            this.toolStripLabel3,
            this.tdtstart,
            this.toolStripLabel4,
            this.toolStripComboBox1,
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "日期";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "全部",
            "3#连铸机",
            "4#连铸机",
            "5#连铸机",
            "6#连铸机",
            "7#连铸机"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "铸机";
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
            this.dvTel.AutoGenerateColumns = false;
            this.dvTel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTel.ColumnHeadersHeight = 35;
            this.dvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.炉号DataGridViewTextBoxColumn,
            this.炉座,
            this.开吹时间,
            this.钢种DataGridViewTextBoxColumn,
            this.铸机DataGridViewTextBoxColumn,
            this.包次DataGridViewTextBoxColumn,
            this.开浇时间DataGridViewTextBoxColumn,
            this.铁水DataGridViewTextBoxColumn,
            this.废钢DataGridViewTextBoxColumn,
            this.铁块DataGridViewTextBoxColumn,
            this.压块DataGridViewTextBoxColumn,
            this.钢水DataGridViewTextBoxColumn,
            this.收坯DataGridViewTextBoxColumn,
            this.铁耗});
            this.dvTel.DataSource = this.scsjBindingSource;
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 25);
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.Size = new System.Drawing.Size(895, 569);
            this.dvTel.TabIndex = 34;
            this.dvTel.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTel_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "铸机";
            this.dataGridViewTextBoxColumn1.HeaderText = "铸机";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "炉号";
            this.dataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "钢种";
            this.dataGridViewTextBoxColumn3.HeaderText = "钢种";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "包次";
            this.dataGridViewTextBoxColumn4.HeaderText = "包次";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "开浇时间";
            this.dataGridViewTextBoxColumn5.HeaderText = "开浇时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "铁水";
            this.dataGridViewTextBoxColumn6.HeaderText = "铁水";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "废钢";
            this.dataGridViewTextBoxColumn7.HeaderText = "废钢";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "铁块";
            this.dataGridViewTextBoxColumn8.HeaderText = "铁块";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "压块";
            this.dataGridViewTextBoxColumn9.HeaderText = "压块";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "钢水";
            this.dataGridViewTextBoxColumn10.HeaderText = "钢水";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "收坯";
            this.dataGridViewTextBoxColumn11.HeaderText = "收坯";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "铁耗";
            this.dataGridViewTextBoxColumn12.HeaderText = "铁耗";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // scsjBindingSource
            // 
            this.scsjBindingSource.DataSource = typeof(UnitMag.scsj);
            // 
            // 炉号DataGridViewTextBoxColumn
            // 
            this.炉号DataGridViewTextBoxColumn.DataPropertyName = "炉号";
            this.炉号DataGridViewTextBoxColumn.HeaderText = "炉号";
            this.炉号DataGridViewTextBoxColumn.Name = "炉号DataGridViewTextBoxColumn";
            this.炉号DataGridViewTextBoxColumn.ReadOnly = true;
            this.炉号DataGridViewTextBoxColumn.Width = 80;
            // 
            // 炉座
            // 
            this.炉座.DataPropertyName = "炉座";
            this.炉座.HeaderText = "炉座";
            this.炉座.Name = "炉座";
            this.炉座.ReadOnly = true;
            this.炉座.Width = 70;
            // 
            // 开吹时间
            // 
            this.开吹时间.DataPropertyName = "开吹时间";
            this.开吹时间.HeaderText = "开吹时间";
            this.开吹时间.Name = "开吹时间";
            this.开吹时间.ReadOnly = true;
            this.开吹时间.Width = 80;
            // 
            // 钢种DataGridViewTextBoxColumn
            // 
            this.钢种DataGridViewTextBoxColumn.DataPropertyName = "钢种";
            this.钢种DataGridViewTextBoxColumn.HeaderText = "钢种";
            this.钢种DataGridViewTextBoxColumn.Name = "钢种DataGridViewTextBoxColumn";
            this.钢种DataGridViewTextBoxColumn.ReadOnly = true;
            this.钢种DataGridViewTextBoxColumn.Width = 80;
            // 
            // 铸机DataGridViewTextBoxColumn
            // 
            this.铸机DataGridViewTextBoxColumn.DataPropertyName = "铸机";
            this.铸机DataGridViewTextBoxColumn.HeaderText = "铸机";
            this.铸机DataGridViewTextBoxColumn.Name = "铸机DataGridViewTextBoxColumn";
            this.铸机DataGridViewTextBoxColumn.ReadOnly = true;
            this.铸机DataGridViewTextBoxColumn.Width = 70;
            // 
            // 包次DataGridViewTextBoxColumn
            // 
            this.包次DataGridViewTextBoxColumn.DataPropertyName = "包次";
            this.包次DataGridViewTextBoxColumn.HeaderText = "包次";
            this.包次DataGridViewTextBoxColumn.Name = "包次DataGridViewTextBoxColumn";
            this.包次DataGridViewTextBoxColumn.ReadOnly = true;
            this.包次DataGridViewTextBoxColumn.Width = 60;
            // 
            // 开浇时间DataGridViewTextBoxColumn
            // 
            this.开浇时间DataGridViewTextBoxColumn.DataPropertyName = "开浇时间";
            this.开浇时间DataGridViewTextBoxColumn.HeaderText = "开浇时间";
            this.开浇时间DataGridViewTextBoxColumn.Name = "开浇时间DataGridViewTextBoxColumn";
            this.开浇时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.开浇时间DataGridViewTextBoxColumn.Width = 80;
            // 
            // 铁水DataGridViewTextBoxColumn
            // 
            this.铁水DataGridViewTextBoxColumn.DataPropertyName = "铁水";
            this.铁水DataGridViewTextBoxColumn.HeaderText = "铁水";
            this.铁水DataGridViewTextBoxColumn.Name = "铁水DataGridViewTextBoxColumn";
            this.铁水DataGridViewTextBoxColumn.ReadOnly = true;
            this.铁水DataGridViewTextBoxColumn.Width = 80;
            // 
            // 废钢DataGridViewTextBoxColumn
            // 
            this.废钢DataGridViewTextBoxColumn.DataPropertyName = "废钢";
            this.废钢DataGridViewTextBoxColumn.HeaderText = "废钢";
            this.废钢DataGridViewTextBoxColumn.Name = "废钢DataGridViewTextBoxColumn";
            this.废钢DataGridViewTextBoxColumn.ReadOnly = true;
            this.废钢DataGridViewTextBoxColumn.Width = 80;
            // 
            // 铁块DataGridViewTextBoxColumn
            // 
            this.铁块DataGridViewTextBoxColumn.DataPropertyName = "铁块";
            this.铁块DataGridViewTextBoxColumn.HeaderText = "铁块";
            this.铁块DataGridViewTextBoxColumn.Name = "铁块DataGridViewTextBoxColumn";
            this.铁块DataGridViewTextBoxColumn.ReadOnly = true;
            this.铁块DataGridViewTextBoxColumn.Width = 60;
            // 
            // 压块DataGridViewTextBoxColumn
            // 
            this.压块DataGridViewTextBoxColumn.DataPropertyName = "压块";
            this.压块DataGridViewTextBoxColumn.HeaderText = "压块";
            this.压块DataGridViewTextBoxColumn.Name = "压块DataGridViewTextBoxColumn";
            this.压块DataGridViewTextBoxColumn.ReadOnly = true;
            this.压块DataGridViewTextBoxColumn.Width = 60;
            // 
            // 钢水DataGridViewTextBoxColumn
            // 
            this.钢水DataGridViewTextBoxColumn.DataPropertyName = "钢水";
            this.钢水DataGridViewTextBoxColumn.HeaderText = "钢水";
            this.钢水DataGridViewTextBoxColumn.Name = "钢水DataGridViewTextBoxColumn";
            this.钢水DataGridViewTextBoxColumn.ReadOnly = true;
            this.钢水DataGridViewTextBoxColumn.Width = 80;
            // 
            // 收坯DataGridViewTextBoxColumn
            // 
            this.收坯DataGridViewTextBoxColumn.DataPropertyName = "收坯";
            this.收坯DataGridViewTextBoxColumn.HeaderText = "收坯";
            this.收坯DataGridViewTextBoxColumn.Name = "收坯DataGridViewTextBoxColumn";
            this.收坯DataGridViewTextBoxColumn.ReadOnly = true;
            this.收坯DataGridViewTextBoxColumn.Width = 80;
            // 
            // 铁耗
            // 
            this.铁耗.DataPropertyName = "铁耗";
            this.铁耗.HeaderText = "铁耗";
            this.铁耗.Name = "铁耗";
            this.铁耗.ReadOnly = true;
            // 
            // shoupiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.bnM);
            this.Name = "shoupiFrm";
            this.TabText = "收坯统计";
            this.Text = "收坯统计";
            this.Load += new System.EventHandler(this.NCTelDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scsjBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.BindingSource bsMqhs;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource scsjBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn 炉号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 炉座;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开吹时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钢种DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铸机DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包次DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开浇时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁水DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 废钢DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁块DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 压块DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钢水DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收坯DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁耗;
    }
}