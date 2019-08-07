namespace UnitMag.DeSMag
{
    partial class PreRemoveSlagUnitIDFrm
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
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.txtTAPNo = new PxDataValid.PxTextBox();
            this.txtTPCNo = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmdPreRemoveSlag1 = new AppSvrHMI.L3Command(this.components);
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.cmdPreRemoveSlag2 = new AppSvrHMI.L3Command(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl2.Size = new System.Drawing.Size(377, 141);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.rbtnB);
            this.tabPage2.Controls.Add(this.rbtnA);
            this.tabPage2.Controls.Add(this.txtTAPNo);
            this.tabPage2.Controls.Add(this.txtTPCNo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 116);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "铁水信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(227, 77);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(53, 16);
            this.rbtnB.TabIndex = 6;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B工位";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(113, 77);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(53, 16);
            this.rbtnA.TabIndex = 5;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A工位";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // txtTAPNo
            // 
            this.txtTAPNo.Enabled = false;
            this.txtTAPNo.EnableNull = false;
            this.txtTAPNo.ErropPr = null;
            this.txtTAPNo.Length = 0;
            this.txtTAPNo.Location = new System.Drawing.Point(113, 22);
            this.txtTAPNo.Max = 0;
            this.txtTAPNo.MaxStrLength = 0;
            this.txtTAPNo.Min = -0.99;
            this.txtTAPNo.MinStrLength = 0;
            this.txtTAPNo.Name = "txtTAPNo";
            this.txtTAPNo.Precision = 0;
            this.txtTAPNo.Size = new System.Drawing.Size(209, 21);
            this.txtTAPNo.TabIndex = 4;
            this.txtTAPNo.ToolTipValid = null;
            this.txtTAPNo.ValidEable = true;
            this.txtTAPNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTPCNo
            // 
            this.txtTPCNo.Enabled = false;
            this.txtTPCNo.EnableNull = false;
            this.txtTPCNo.ErropPr = null;
            this.txtTPCNo.Length = 0;
            this.txtTPCNo.Location = new System.Drawing.Point(113, 48);
            this.txtTPCNo.Max = 0;
            this.txtTPCNo.MaxStrLength = 0;
            this.txtTPCNo.Min = -0.99;
            this.txtTPCNo.MinStrLength = 0;
            this.txtTPCNo.Name = "txtTPCNo";
            this.txtTPCNo.Precision = 0;
            this.txtTPCNo.Size = new System.Drawing.Size(209, 21);
            this.txtTPCNo.TabIndex = 1;
            this.txtTPCNo.ToolTipValid = null;
            this.txtTPCNo.ValidEable = true;
            this.txtTPCNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "工位:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "罐号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "铁次号:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(288, 147);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(196, 147);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdPreRemoveSlag1
            // 
            this.cmdPreRemoveSlag1.Adapter = this.Adapter;
            this.cmdPreRemoveSlag1.MergeReturnTarget = false;
            this.cmdPreRemoveSlag1.Method = "ChangeStatus";
            this.cmdPreRemoveSlag1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdPreRemoveSlag1.Parameters.Add(this.l3CommandParameter6);
            this.cmdPreRemoveSlag1.Parameters.Add(this.l3CommandParameter7);
            this.cmdPreRemoveSlag1.Parameters.Add(this.l3CommandParameter8);
            this.cmdPreRemoveSlag1.ReturnTarget = null;
            this.cmdPreRemoveSlag1.ReturnTargetProperty = null;
            this.cmdPreRemoveSlag1.Trigger = null;
            this.cmdPreRemoveSlag1.TriggerEvent = "Click";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.dsError.SourceCondition = "OWNER = \'ChangeStatus\'";
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
            // cmdPreRemoveSlag2
            // 
            this.cmdPreRemoveSlag2.Adapter = this.Adapter;
            this.cmdPreRemoveSlag2.MergeReturnTarget = false;
            this.cmdPreRemoveSlag2.Method = "ChangeStatus";
            this.cmdPreRemoveSlag2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdPreRemoveSlag2.Parameters.Add(this.l3CommandParameter6);
            this.cmdPreRemoveSlag2.Parameters.Add(this.l3CommandParameter7);
            this.cmdPreRemoveSlag2.Parameters.Add(this.l3CommandParameter8);
            this.cmdPreRemoveSlag2.ReturnTarget = null;
            this.cmdPreRemoveSlag2.ReturnTargetProperty = null;
            this.cmdPreRemoveSlag2.Trigger = null;
            this.cmdPreRemoveSlag2.TriggerEvent = "Click";
            // 
            // PreRemoveSlagUnitIDFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 181);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PreRemoveSlagUnitIDFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "预捞渣开始";
            this.Load += new System.EventHandler(this.PreRemoveSlagUnitIDFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private PxDataValid.PxTextBox txtTAPNo;
        private PxDataValid.PxTextBox txtTPCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3Command cmdPreRemoveSlag1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3Command cmdPreRemoveSlag2;

    }
}