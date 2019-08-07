namespace UnitMag.BFMag
{
    partial class reSendApply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reSendApply));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsTapno = new AppSvrHMI.L3DataSet();
            this.schemadsTapno = new System.Data.DataTable();
            this.coldsTapnoL3DataTableTap_No = new System.Data.DataColumn();
            this.coldsTapnoL3DataTableflag = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dsSendNo = new AppSvrHMI.L3DataSet();
            this.schemadsSendNo = new System.Data.DataTable();
            this.coldsSendNoL3DataTableTAP_No = new System.Data.DataColumn();
            this.cmdToLab = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(608, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "flag";
            this.Column1.FalseValue = "0";
            this.Column1.HeaderText = "选择";
            this.Column1.IndeterminateValue = "0";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tap_No";
            this.Column2.HeaderText = "铁次号";
            this.Column2.Name = "Column2";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(608, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsTapno
            // 
            this.dsTapno.AutoLoad = true;
            this.dsTapno.AutoSubscribe = true;
            this.dsTapno.DataSetName = "L3DataSet";
            this.dsTapno.DeleteMethod = "";
            this.dsTapno.InsertMethod = "";
            this.dsTapno.L3DataAdapter = this.Adapter;
            this.dsTapno.LoadEvent = "";
            this.dsTapno.LoadTrigger = null;
            this.dsTapno.RefreshValve = 1000;
            this.dsTapno.SourceCommand = null;
            this.dsTapno.SourceCondition = "";
            this.dsTapno.SourceMethod = "";
            this.dsTapno.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsTapno.SourceURI = "";
            this.dsTapno.SubscribeTarget = "";
            this.dsTapno.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapno});
            this.dsTapno.UpdateEvent = "";
            this.dsTapno.UpdateMethod = "";
            this.dsTapno.UpdateTrigger = null;
            // 
            // schemadsTapno
            // 
            this.schemadsTapno.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapnoL3DataTableTap_No,
            this.coldsTapnoL3DataTableflag});
            this.schemadsTapno.TableName = "L3DataTable";
            // 
            // coldsTapnoL3DataTableTap_No
            // 
            this.coldsTapnoL3DataTableTap_No.Caption = "Tap_No";
            this.coldsTapnoL3DataTableTap_No.ColumnName = "Tap_No";
            this.coldsTapnoL3DataTableTap_No.Namespace = "";
            // 
            // coldsTapnoL3DataTableflag
            // 
            this.coldsTapnoL3DataTableflag.Caption = "flag";
            this.coldsTapnoL3DataTableflag.ColumnName = "flag";
            this.coldsTapnoL3DataTableflag.Namespace = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送委托单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsSendNo
            // 
            this.dsSendNo.AutoLoad = true;
            this.dsSendNo.AutoSubscribe = true;
            this.dsSendNo.DataSetName = "L3DataSet";
            this.dsSendNo.DeleteMethod = "";
            this.dsSendNo.InsertMethod = "";
            this.dsSendNo.L3DataAdapter = null;
            this.dsSendNo.LoadEvent = "";
            this.dsSendNo.LoadTrigger = null;
            this.dsSendNo.RefreshValve = 1000;
            this.dsSendNo.SourceCommand = null;
            this.dsSendNo.SourceCondition = "";
            this.dsSendNo.SourceMethod = "";
            this.dsSendNo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSendNo.SourceURI = "";
            this.dsSendNo.SubscribeTarget = "";
            this.dsSendNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSendNo});
            this.dsSendNo.UpdateEvent = "";
            this.dsSendNo.UpdateMethod = "";
            this.dsSendNo.UpdateTrigger = null;
            // 
            // schemadsSendNo
            // 
            this.schemadsSendNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSendNoL3DataTableTAP_No});
            this.schemadsSendNo.TableName = "L3DataTable";
            // 
            // coldsSendNoL3DataTableTAP_No
            // 
            this.coldsSendNoL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsSendNoL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsSendNoL3DataTableTAP_No.Namespace = "";
            // 
            // cmdToLab
            // 
            this.cmdToLab.Adapter = this.Adapter;
            this.cmdToLab.MergeReturnTarget = false;
            this.cmdToLab.Method = "NewBFIronSheet";
            this.cmdToLab.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdToLab.Parameters.Add(this.l3CommandParameter1);
            this.cmdToLab.ReturnTarget = null;
            this.cmdToLab.ReturnTargetProperty = null;
            this.cmdToLab.Trigger = null;
            this.cmdToLab.TriggerEvent = "Click";
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
            // reSendApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "reSendApply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重新发送铁钩样委托单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsTapno;
        private System.Data.DataTable schemadsTapno;
        private System.Data.DataColumn coldsTapnoL3DataTableTap_No;
        private System.Windows.Forms.Button button1;
        private System.Data.DataColumn coldsTapnoL3DataTableflag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private AppSvrHMI.L3DataSet dsSendNo;
        private System.Data.DataTable schemadsSendNo;
        private System.Data.DataColumn coldsSendNoL3DataTableTAP_No;
        private AppSvrHMI.L3Command cmdToLab;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
    }
}