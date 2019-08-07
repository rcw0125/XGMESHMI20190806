namespace XGMESMain
{
    partial class PassWordMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassWordMagFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassWordOld = new PxDataValid.PxTextBox();
            this.txtPassWordNewConfirm = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccount = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassWordNew = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdUpdRecord = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 52);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(100, 3);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定(&O)";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPassWordOld);
            this.panel1.Controls.Add(this.txtPassWordNewConfirm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPassWordNew);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 135);
            this.panel1.TabIndex = 0;
            // 
            // txtPassWordOld
            // 
            //
            this.txtPassWordOld.EnableNull = true;
            this.txtPassWordOld.ErropPr = null;
            //
            this.txtPassWordOld.Length = 0;
            this.txtPassWordOld.Location = new System.Drawing.Point(92, 47);
            this.txtPassWordOld.Max = 0;
            //
            //
            this.txtPassWordOld.MaxStrLength = 0;
            this.txtPassWordOld.Min = 0;
            //
            //
            this.txtPassWordOld.MinStrLength = 0;
            this.txtPassWordOld.Name = "txtPassWordOld";
            this.txtPassWordOld.PasswordChar = '*';
            this.txtPassWordOld.Precision = 0;
            //
            this.txtPassWordOld.Size = new System.Drawing.Size(204, 21);
            this.txtPassWordOld.TabIndex = 1;
            this.txtPassWordOld.ToolTipValid = null;
          //
            this.txtPassWordOld.ValidEable = true;
            this.txtPassWordOld.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtPassWordNewConfirm
            // 
            //
            this.txtPassWordNewConfirm.EnableNull = true;
            this.txtPassWordNewConfirm.ErropPr = null;
            //
            this.txtPassWordNewConfirm.Length = 0;
            this.txtPassWordNewConfirm.Location = new System.Drawing.Point(92, 101);
            this.txtPassWordNewConfirm.Max = 0;
            //
            //
            this.txtPassWordNewConfirm.MaxStrLength = 0;
            this.txtPassWordNewConfirm.Min = 0;
            //
            //
            this.txtPassWordNewConfirm.MinStrLength = 0;
            this.txtPassWordNewConfirm.Name = "txtPassWordNewConfirm";
            this.txtPassWordNewConfirm.PasswordChar = '*';
            this.txtPassWordNewConfirm.Precision = 0;
            //
            this.txtPassWordNewConfirm.Size = new System.Drawing.Size(204, 21);
            this.txtPassWordNewConfirm.TabIndex = 3;
            this.txtPassWordNewConfirm.ToolTipValid = null;
          //
            this.txtPassWordNewConfirm.ValidEable = true;
            this.txtPassWordNewConfirm.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "账    号:";
            // 
            // txtAccount
            // 
            //
            this.txtAccount.EnableNull = true;
            this.txtAccount.ErropPr = null;
            //
            this.txtAccount.Length = 0;
            this.txtAccount.Location = new System.Drawing.Point(92, 20);
            this.txtAccount.Max = 0;
            //
            //
            this.txtAccount.MaxStrLength = 0;
            this.txtAccount.Min = 0;
            //
            //
            this.txtAccount.MinStrLength = 0;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Precision = 0;
            this.txtAccount.ReadOnly = true;
            //
            this.txtAccount.Size = new System.Drawing.Size(204, 21);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.ToolTipValid = null;
          //
            this.txtAccount.ValidEable = true;
            this.txtAccount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "旧 密 码:";
            // 
            // txtPassWordNew
            // 
            //
            this.txtPassWordNew.EnableNull = true;
            this.txtPassWordNew.ErropPr = null;
            //
            this.txtPassWordNew.Length = 0;
            this.txtPassWordNew.Location = new System.Drawing.Point(92, 74);
            this.txtPassWordNew.Max = 0;
            //
            //
            this.txtPassWordNew.MaxStrLength = 0;
            this.txtPassWordNew.Min = 0;
            //
            //
            this.txtPassWordNew.MinStrLength = 0;
            this.txtPassWordNew.Name = "txtPassWordNew";
            this.txtPassWordNew.PasswordChar = '*';
            this.txtPassWordNew.Precision = 0;
            //
            this.txtPassWordNew.Size = new System.Drawing.Size(204, 21);
            this.txtPassWordNew.TabIndex = 2;
            this.txtPassWordNew.ToolTipValid = null;
          //
            this.txtPassWordNew.ValidEable = true;
            this.txtPassWordNew.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "新 密 码:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "密码确认:";
            // 
            // cmdUpdRecord
            // 
            this.cmdUpdRecord.Adapter = null;
            this.cmdUpdRecord.MergeReturnTarget = false;
            this.cmdUpdRecord.Method = "UpdPassWord";
            this.cmdUpdRecord.Object = "XGMESLogic\\BaseDataMag\\CBase_UserPwd_Lock_Mag\\MagID";
            this.cmdUpdRecord.Parameters.Add(this.l3CommandParameter1);
            this.cmdUpdRecord.Parameters.Add(this.l3CommandParameter2);
            this.cmdUpdRecord.ReturnTarget = null;
            this.cmdUpdRecord.ReturnTargetProperty = null;
            this.cmdUpdRecord.Trigger = null;
            this.cmdUpdRecord.TriggerEvent = "Click";
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
            // PassWordMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PassWordMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            this.Load += new System.EventHandler(this.PassWordMagFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private PxDataValid.PxTextBox txtPassWordOld;
        private PxDataValid.PxTextBox txtPassWordNewConfirm;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxTextBox txtAccount;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox txtPassWordNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private AppSvrHMI.L3Command cmdUpdRecord;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
    }
}