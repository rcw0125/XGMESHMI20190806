namespace EquipMag.VacTubeMag
{
    partial class VacTubeInstallFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUpID = new System.Windows.Forms.ComboBox();
            this.cmbDownID = new System.Windows.Forms.ComboBox();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsUpID = new AppSvrHMI.L3DataSet();
            this.dsDownID = new AppSvrHMI.L3DataSet();
            this.cmdInstall = new AppSvrHMI.L3Command(this.components);
            this.cmdpUpID = new AppSvrHMI.L3CommandParameter();
            this.cmdpDownID = new AppSvrHMI.L3CommandParameter();
            this.schemadsUpID = new System.Data.DataTable();
            this.coldsUpIDL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.schemadsDownID = new System.Data.DataTable();
            this.coldsDownIDL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 166);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbDownID);
            this.tabPage1.Controls.Add(this.cmbUpID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "真空槽信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(133, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上部槽:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "下部槽:";
            // 
            // cmbUpID
            // 
            this.cmbUpID.DataSource = this.dsUpID;
            this.cmbUpID.DisplayMember = "L3DataTable.VacTube_ID";
            this.cmbUpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpID.FormattingEnabled = true;
            this.cmbUpID.Location = new System.Drawing.Point(105, 37);
            this.cmbUpID.Name = "cmbUpID";
            this.cmbUpID.Size = new System.Drawing.Size(121, 20);
            this.cmbUpID.TabIndex = 1;
            this.cmbUpID.ValueMember = "L3DataTable.VacTube_ID";
            // 
            // cmbDownID
            // 
            this.cmbDownID.DataSource = this.dsDownID;
            this.cmbDownID.DisplayMember = "L3DataTable.VacTube_ID";
            this.cmbDownID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownID.FormattingEnabled = true;
            this.cmbDownID.Location = new System.Drawing.Point(105, 72);
            this.cmbDownID.Name = "cmbDownID";
            this.cmbDownID.Size = new System.Drawing.Size(121, 20);
            this.cmbDownID.TabIndex = 1;
            this.cmbDownID.ValueMember = "L3DataTable.VacTube_ID";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsUpID
            // 
            this.dsUpID.AutoSubscribe = false;
            this.dsUpID.DataSetName = "L3DataSet";
            this.dsUpID.DeleteMethod = "";
            this.dsUpID.InsertMethod = "";
            this.dsUpID.L3DataAdapter = this.Adapter;
            this.dsUpID.LoadEvent = "";
            this.dsUpID.LoadTrigger = null;
            this.dsUpID.RefreshValve = 1000;
            this.dsUpID.SourceCommand = null;
            this.dsUpID.SourceCondition = "VacTube_Name = \'1\' and Status = \'01\' and flag = \'1\' order by  VacTube_ID";
            this.dsUpID.SourceMethod = "";
            this.dsUpID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUpID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsUpID.SubscribeTarget = "";
            this.dsUpID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUpID});
            this.dsUpID.UpdateEvent = "";
            this.dsUpID.UpdateMethod = "";
            this.dsUpID.UpdateTrigger = null;
            // 
            // dsDownID
            // 
            this.dsDownID.AutoSubscribe = false;
            this.dsDownID.DataSetName = "L3DataSet";
            this.dsDownID.DeleteMethod = "";
            this.dsDownID.InsertMethod = "";
            this.dsDownID.L3DataAdapter = this.Adapter;
            this.dsDownID.LoadEvent = "";
            this.dsDownID.LoadTrigger = null;
            this.dsDownID.RefreshValve = 1000;
            this.dsDownID.SourceCommand = null;
            this.dsDownID.SourceCondition = "VacTube_Name = \'2\' and Status = \'01\' and flag = \'1\' order by  VacTube_ID";
            this.dsDownID.SourceMethod = "";
            this.dsDownID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDownID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsDownID.SubscribeTarget = "";
            this.dsDownID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDownID});
            this.dsDownID.UpdateEvent = "";
            this.dsDownID.UpdateMethod = "";
            this.dsDownID.UpdateTrigger = null;
            // 
            // cmdInstall
            // 
            this.cmdInstall.Adapter = this.Adapter;
            this.cmdInstall.MergeReturnTarget = false;
            this.cmdInstall.Method = "Vactube_Install";
            this.cmdInstall.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdInstall.Parameters.Add(this.cmdpUpID);
            this.cmdInstall.Parameters.Add(this.cmdpDownID);
            this.cmdInstall.ReturnTarget = null;
            this.cmdInstall.ReturnTargetProperty = null;
            this.cmdInstall.Trigger = null;
            this.cmdInstall.TriggerEvent = "Click";
            // 
            // cmdpUpID
            // 
            this.cmdpUpID.AcceptAfterExecuted = false;
            this.cmdpUpID.ConstantValue = null;
            this.cmdpUpID.MergeTarget = false;
            this.cmdpUpID.SourceFilter = null;
            this.cmdpUpID.SourceObject = null;
            this.cmdpUpID.SourceProperty = null;
            this.cmdpUpID.TargetObject = null;
            this.cmdpUpID.TargetProperty = null;
            // 
            // cmdpDownID
            // 
            this.cmdpDownID.AcceptAfterExecuted = false;
            this.cmdpDownID.ConstantValue = null;
            this.cmdpDownID.MergeTarget = false;
            this.cmdpDownID.SourceFilter = null;
            this.cmdpDownID.SourceObject = null;
            this.cmdpDownID.SourceProperty = null;
            this.cmdpDownID.TargetObject = null;
            this.cmdpDownID.TargetProperty = null;
            // 
            // schemadsUpID
            // 
            this.schemadsUpID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUpIDL3DataTableVacTube_ID});
            this.schemadsUpID.TableName = "L3DataTable";
            // 
            // coldsUpIDL3DataTableVacTube_ID
            // 
            this.coldsUpIDL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsUpIDL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsUpIDL3DataTableVacTube_ID.Namespace = "";
            // 
            // schemadsDownID
            // 
            this.schemadsDownID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDownIDL3DataTableVacTube_ID});
            this.schemadsDownID.TableName = "L3DataTable";
            // 
            // coldsDownIDL3DataTableVacTube_ID
            // 
            this.coldsDownIDL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsDownIDL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsDownIDL3DataTableVacTube_ID.Namespace = "";
            // 
            // VacTubeInstallFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeInstallFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "真空槽组装";
            this.Load += new System.EventHandler(this.VacTubeInstallFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDownID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbDownID;
        private System.Windows.Forms.ComboBox cmbUpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsUpID;
        private System.Data.DataTable schemadsUpID;
        private System.Data.DataColumn coldsUpIDL3DataTableVacTube_ID;
        private AppSvrHMI.L3DataSet dsDownID;
        private System.Data.DataTable schemadsDownID;
        private System.Data.DataColumn coldsDownIDL3DataTableVacTube_ID;
        private AppSvrHMI.L3Command cmdInstall;
        private AppSvrHMI.L3CommandParameter cmdpUpID;
        private AppSvrHMI.L3CommandParameter cmdpDownID;
    }
}