namespace UnitMag.DeSMag
{
    partial class ChangeLanceShowFrm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbLanceNo = new System.Windows.Forms.ComboBox();
            this.dsLanceNo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsLanceNo = new System.Data.DataTable();
            this.coldsLanceNoL3DataTableLanceNo = new System.Data.DataColumn();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeLanceNo1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter11 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeLanceNo2 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter12 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter13 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(394, 134);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.cmbLanceNo);
            this.tabPage2.Controls.Add(this.rbtB);
            this.tabPage2.Controls.Add(this.rbtA);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 109);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "喷枪信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbLanceNo
            // 
            this.cmbLanceNo.DataSource = this.dsLanceNo;
            this.cmbLanceNo.DisplayMember = "L3DataTable.LanceNo";
            this.cmbLanceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanceNo.FormattingEnabled = true;
            this.cmbLanceNo.Location = new System.Drawing.Point(108, 30);
            this.cmbLanceNo.Name = "cmbLanceNo";
            this.cmbLanceNo.Size = new System.Drawing.Size(145, 20);
            this.cmbLanceNo.TabIndex = 4;
            this.cmbLanceNo.ValueMember = "L3DataTable.LanceNo";
            // 
            // dsLanceNo
            // 
            this.dsLanceNo.AutoLoad = true;
            this.dsLanceNo.AutoSubscribe = false;
            this.dsLanceNo.DataSetName = "L3DataSet";
            this.dsLanceNo.DeleteMethod = "";
            this.dsLanceNo.InsertMethod = "";
            this.dsLanceNo.L3DataAdapter = this.Adapter;
            this.dsLanceNo.LoadEvent = "";
            this.dsLanceNo.LoadTrigger = null;
            this.dsLanceNo.RefreshValve = 1000;
            this.dsLanceNo.SourceCommand = null;
            this.dsLanceNo.SourceCondition = "Status < 3 order by LanceNo";
            this.dsLanceNo.SourceMethod = "";
            this.dsLanceNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceNo.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Lance_Data";
            this.dsLanceNo.SubscribeTarget = "";
            this.dsLanceNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceNo});
            this.dsLanceNo.UpdateEvent = "";
            this.dsLanceNo.UpdateMethod = "";
            this.dsLanceNo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsLanceNo
            // 
            this.schemadsLanceNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceNoL3DataTableLanceNo});
            this.schemadsLanceNo.TableName = "L3DataTable";
            // 
            // coldsLanceNoL3DataTableLanceNo
            // 
            this.coldsLanceNoL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsLanceNoL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsLanceNoL3DataTableLanceNo.Namespace = "";
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Location = new System.Drawing.Point(200, 74);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(53, 16);
            this.rbtB.TabIndex = 3;
            this.rbtB.TabStop = true;
            this.rbtB.Text = "B工位";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Location = new System.Drawing.Point(108, 74);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(53, 16);
            this.rbtA.TabIndex = 2;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A工位";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "喷枪号:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(297, 140);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(205, 140);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
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
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
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
            // cmdChangeLanceNo1
            // 
            this.cmdChangeLanceNo1.Adapter = this.Adapter;
            this.cmdChangeLanceNo1.MergeReturnTarget = false;
            this.cmdChangeLanceNo1.Method = "ChangeLanceNo";
            this.cmdChangeLanceNo1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdChangeLanceNo1.Parameters.Add(this.l3CommandParameter10);
            this.cmdChangeLanceNo1.Parameters.Add(this.l3CommandParameter11);
            this.cmdChangeLanceNo1.ReturnTarget = null;
            this.cmdChangeLanceNo1.ReturnTargetProperty = null;
            this.cmdChangeLanceNo1.Trigger = null;
            this.cmdChangeLanceNo1.TriggerEvent = "Click";
            // 
            // l3CommandParameter10
            // 
            this.l3CommandParameter10.AcceptAfterExecuted = false;
            this.l3CommandParameter10.ConstantValue = null;
            this.l3CommandParameter10.MergeTarget = false;
            this.l3CommandParameter10.SourceFilter = null;
            this.l3CommandParameter10.SourceObject = null;
            this.l3CommandParameter10.SourceProperty = null;
            this.l3CommandParameter10.TargetObject = null;
            this.l3CommandParameter10.TargetProperty = null;
            // 
            // l3CommandParameter11
            // 
            this.l3CommandParameter11.AcceptAfterExecuted = false;
            this.l3CommandParameter11.ConstantValue = null;
            this.l3CommandParameter11.MergeTarget = false;
            this.l3CommandParameter11.SourceFilter = null;
            this.l3CommandParameter11.SourceObject = null;
            this.l3CommandParameter11.SourceProperty = null;
            this.l3CommandParameter11.TargetObject = null;
            this.l3CommandParameter11.TargetProperty = null;
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = null;
            this.l3CommandParameter8.SourceObject = null;
            this.l3CommandParameter8.SourceProperty = null;
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = null;
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // cmdChangeLanceNo2
            // 
            this.cmdChangeLanceNo2.Adapter = this.Adapter;
            this.cmdChangeLanceNo2.MergeReturnTarget = false;
            this.cmdChangeLanceNo2.Method = "ChangeLanceNo";
            this.cmdChangeLanceNo2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdChangeLanceNo2.Parameters.Add(this.l3CommandParameter12);
            this.cmdChangeLanceNo2.Parameters.Add(this.l3CommandParameter13);
            this.cmdChangeLanceNo2.ReturnTarget = null;
            this.cmdChangeLanceNo2.ReturnTargetProperty = null;
            this.cmdChangeLanceNo2.Trigger = null;
            this.cmdChangeLanceNo2.TriggerEvent = "Click";
            // 
            // l3CommandParameter12
            // 
            this.l3CommandParameter12.AcceptAfterExecuted = false;
            this.l3CommandParameter12.ConstantValue = null;
            this.l3CommandParameter12.MergeTarget = false;
            this.l3CommandParameter12.SourceFilter = null;
            this.l3CommandParameter12.SourceObject = null;
            this.l3CommandParameter12.SourceProperty = null;
            this.l3CommandParameter12.TargetObject = null;
            this.l3CommandParameter12.TargetProperty = null;
            // 
            // l3CommandParameter13
            // 
            this.l3CommandParameter13.AcceptAfterExecuted = false;
            this.l3CommandParameter13.ConstantValue = null;
            this.l3CommandParameter13.MergeTarget = false;
            this.l3CommandParameter13.SourceFilter = null;
            this.l3CommandParameter13.SourceObject = null;
            this.l3CommandParameter13.SourceProperty = null;
            this.l3CommandParameter13.TargetObject = null;
            this.l3CommandParameter13.TargetProperty = null;
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = null;
            this.l3CommandParameter9.SourceObject = null;
            this.l3CommandParameter9.SourceProperty = null;
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = null;
            this.l3CommandParameter7.SourceObject = null;
            this.l3CommandParameter7.SourceProperty = null;
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'ChangeLanceNo\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // ChangeLanceShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 175);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeLanceShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更换喷枪";
            this.Load += new System.EventHandler(this.ChangeLanceShowFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3Command cmdChangeLanceNo1;
        private AppSvrHMI.L3Command cmdChangeLanceNo2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private System.Windows.Forms.RadioButton rbtB;
        private System.Windows.Forms.RadioButton rbtA;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
        private AppSvrHMI.L3CommandParameter l3CommandParameter11;
        private AppSvrHMI.L3CommandParameter l3CommandParameter12;
        private AppSvrHMI.L3CommandParameter l3CommandParameter13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbLanceNo;
        private AppSvrHMI.L3DataSet dsLanceNo;
        private System.Data.DataTable schemadsLanceNo;
        private System.Data.DataColumn coldsLanceNoL3DataTableLanceNo;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;

    }
}