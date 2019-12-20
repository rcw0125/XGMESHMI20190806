namespace UnitMag
{
    partial class shoupiBofFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shoupiBofFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsMqhs = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tdtstart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbteam = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cbbof = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.scsjbofBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.炉号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钢种DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁水DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.废钢DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁块DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.压块DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钢水DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收坯DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁耗 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.铁耗钢水 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scsjbofBindingSource)).BeginInit();
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
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel3,
            this.tdtstart,
            this.toolStripLabel4,
            this.cbteam,
            this.toolStripLabel5,
            this.cbbof,
            this.toolStripLabel1,
            this.btnOutput});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = null;
            this.bnM.MoveLastItem = null;
            this.bnM.MoveNextItem = null;
            this.bnM.MovePreviousItem = null;
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            // cbteam
            // 
            this.cbteam.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbteam.Items.AddRange(new object[] {
            "全部",
            "甲班",
            "乙班",
            "丙班",
            "丁班"});
            this.cbteam.Name = "cbteam";
            this.cbteam.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel5.Text = "班组";
            // 
            // cbbof
            // 
            this.cbbof.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbbof.Items.AddRange(new object[] {
            "全部",
            "1#转炉",
            "2#转炉",
            "3#转炉",
            "4#转炉"});
            this.cbbof.Name = "cbbof";
            this.cbbof.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "转炉";
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
            this.钢种DataGridViewTextBoxColumn,
            this.铁水DataGridViewTextBoxColumn,
            this.废钢DataGridViewTextBoxColumn,
            this.铁块DataGridViewTextBoxColumn,
            this.压块DataGridViewTextBoxColumn,
            this.钢水DataGridViewTextBoxColumn,
            this.收坯DataGridViewTextBoxColumn,
            this.铁耗,
            this.铁耗钢水});
            this.dvTel.DataSource = this.scsjbofBindingSource;
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 25);
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.Size = new System.Drawing.Size(895, 569);
            this.dvTel.TabIndex = 34;
            this.dvTel.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTel_DataError);
            // 
            // scsjbofBindingSource
            // 
            this.scsjbofBindingSource.DataSource = typeof(UnitMag.scsjbof);
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
            // 炉号DataGridViewTextBoxColumn
            // 
            this.炉号DataGridViewTextBoxColumn.DataPropertyName = "炉号";
            this.炉号DataGridViewTextBoxColumn.HeaderText = "炉号";
            this.炉号DataGridViewTextBoxColumn.Name = "炉号DataGridViewTextBoxColumn";
            this.炉号DataGridViewTextBoxColumn.ReadOnly = true;
            this.炉号DataGridViewTextBoxColumn.Width = 80;
            // 
            // 钢种DataGridViewTextBoxColumn
            // 
            this.钢种DataGridViewTextBoxColumn.DataPropertyName = "钢种";
            this.钢种DataGridViewTextBoxColumn.HeaderText = "钢种";
            this.钢种DataGridViewTextBoxColumn.Name = "钢种DataGridViewTextBoxColumn";
            this.钢种DataGridViewTextBoxColumn.ReadOnly = true;
            this.钢种DataGridViewTextBoxColumn.Width = 80;
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
            this.铁块DataGridViewTextBoxColumn.Width = 80;
            // 
            // 压块DataGridViewTextBoxColumn
            // 
            this.压块DataGridViewTextBoxColumn.DataPropertyName = "压块";
            this.压块DataGridViewTextBoxColumn.HeaderText = "压块";
            this.压块DataGridViewTextBoxColumn.Name = "压块DataGridViewTextBoxColumn";
            this.压块DataGridViewTextBoxColumn.ReadOnly = true;
            this.压块DataGridViewTextBoxColumn.Width = 80;
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
            this.铁耗.HeaderText = "铁耗(钢坯)";
            this.铁耗.Name = "铁耗";
            this.铁耗.ReadOnly = true;
            // 
            // 铁耗钢水
            // 
            this.铁耗钢水.DataPropertyName = "铁耗钢水";
            this.铁耗钢水.HeaderText = "铁耗(钢水)";
            this.铁耗钢水.Name = "铁耗钢水";
            this.铁耗钢水.ReadOnly = true;
            // 
            // shoupiBofFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.bnM);
            this.Name = "shoupiBofFrm";
            this.TabText = "转炉收坯统计";
            this.Text = "转炉收坯统计";
            this.Load += new System.EventHandler(this.NCTelDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMqhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scsjbofBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private buttonHide.ToolStripToriDateTimePicker tdtstart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.BindingSource bsMqhs;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbteam;
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
        private System.Windows.Forms.BindingSource scsjbofBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cbbof;
        private System.Windows.Forms.DataGridViewTextBoxColumn 炉号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钢种DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁水DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 废钢DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁块DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 压块DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钢水DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收坯DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁耗;
        private System.Windows.Forms.DataGridViewTextBoxColumn 铁耗钢水;
    }
}