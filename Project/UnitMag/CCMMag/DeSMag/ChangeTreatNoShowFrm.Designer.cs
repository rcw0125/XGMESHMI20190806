namespace UnitMag.DeSMag
{
    partial class ChangeTreatNoShowFrm
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
            this.txtTreatNo = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeTreatNo1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeTreatNo2 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(382, 108);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.txtTreatNo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 83);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "喷吹号信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTreatNo
            // 
            this.txtTreatNo.EnableNull = true;
            this.txtTreatNo.ErropPr = this.errorProvider1;
            this.txtTreatNo.Length = 0;
            this.txtTreatNo.Location = new System.Drawing.Point(108, 30);
            this.txtTreatNo.Max = 0;
            this.txtTreatNo.MaxStrLength = 0;
            this.txtTreatNo.Min = 0;
            this.txtTreatNo.MinStrLength = 0;
            this.txtTreatNo.Name = "txtTreatNo";
            this.txtTreatNo.Precision = 0;
            this.txtTreatNo.Size = new System.Drawing.Size(209, 21);
            this.txtTreatNo.TabIndex = 1;
            this.txtTreatNo.ToolTipValid = this.toolTip1;
            this.txtTreatNo.ValidEable = true;
            this.txtTreatNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTreatNo.TextChanged += new System.EventHandler(this.txtTreatNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "喷吹号:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(298, 114);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(206, 114);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // cmdChangeTreatNo1
            // 
            this.cmdChangeTreatNo1.Adapter = this.Adapter;
            this.cmdChangeTreatNo1.MergeReturnTarget = false;
            this.cmdChangeTreatNo1.Method = "ChangeTreatNo";
            this.cmdChangeTreatNo1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdChangeTreatNo1.Parameters.Add(this.l3CommandParameter6);
            this.cmdChangeTreatNo1.ReturnTarget = null;
            this.cmdChangeTreatNo1.ReturnTargetProperty = null;
            this.cmdChangeTreatNo1.Trigger = null;
            this.cmdChangeTreatNo1.TriggerEvent = "Click";
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
            // cmdChangeTreatNo2
            // 
            this.cmdChangeTreatNo2.Adapter = this.Adapter;
            this.cmdChangeTreatNo2.MergeReturnTarget = false;
            this.cmdChangeTreatNo2.Method = "ChangeTreatNo";
            this.cmdChangeTreatNo2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdChangeTreatNo2.Parameters.Add(this.l3CommandParameter7);
            this.cmdChangeTreatNo2.ReturnTarget = null;
            this.cmdChangeTreatNo2.ReturnTargetProperty = null;
            this.cmdChangeTreatNo2.Trigger = null;
            this.cmdChangeTreatNo2.TriggerEvent = "Click";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangeTreatNoShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 154);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeTreatNoShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "喷吹号修改";
            this.Load += new System.EventHandler(this.ChangeTreatNoShowFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private PxDataValid.PxTextBox txtTreatNo;
        private AppSvrHMI.L3Command cmdChangeTreatNo1;
        private AppSvrHMI.L3Command cmdChangeTreatNo2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}