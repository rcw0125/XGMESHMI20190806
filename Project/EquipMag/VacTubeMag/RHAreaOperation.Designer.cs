namespace EquipMag.VacTubeMag
{
    partial class RHAreaOperation
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
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbAreaB = new System.Windows.Forms.RadioButton();
            this.rbAreaA = new System.Windows.Forms.RadioButton();
            this.cmdOnLine = new AppSvrHMI.L3Command(this.components);
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3cmdpOnLine = new AppSvrHMI.L3CommandParameter();
            this.cmdOffLine = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOffLine = new AppSvrHMI.L3CommandParameter();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.brnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // brnCancel
            // 
            this.brnCancel.Location = new System.Drawing.Point(225, 3);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(75, 23);
            this.brnCancel.TabIndex = 0;
            this.brnCancel.Text = "取消";
            this.brnCancel.UseVisualStyleBackColor = true;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(144, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 173);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDown);
            this.tabPage1.Controls.Add(this.txtUp);
            this.tabPage1.Controls.Add(this.rbAreaB);
            this.tabPage1.Controls.Add(this.rbAreaA);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbAreaB
            // 
            this.rbAreaB.AutoSize = true;
            this.rbAreaB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbAreaB.Location = new System.Drawing.Point(161, 33);
            this.rbAreaB.Name = "rbAreaB";
            this.rbAreaB.Size = new System.Drawing.Size(53, 16);
            this.rbAreaB.TabIndex = 80;
            this.rbAreaB.TabStop = true;
            this.rbAreaB.Text = "B工位";
            this.rbAreaB.UseVisualStyleBackColor = true;
            // 
            // rbAreaA
            // 
            this.rbAreaA.AutoSize = true;
            this.rbAreaA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbAreaA.Location = new System.Drawing.Point(81, 33);
            this.rbAreaA.Name = "rbAreaA";
            this.rbAreaA.Size = new System.Drawing.Size(53, 16);
            this.rbAreaA.TabIndex = 79;
            this.rbAreaA.TabStop = true;
            this.rbAreaA.Text = "A工位";
            this.rbAreaA.UseVisualStyleBackColor = true;
            this.rbAreaA.CheckedChanged += new System.EventHandler(this.rbAreaA_CheckedChanged);
            // 
            // cmdOnLine
            // 
            this.cmdOnLine.Adapter = this.Adapter;
            this.cmdOnLine.MergeReturnTarget = false;
            this.cmdOnLine.Method = "VactubeOnLine";
            this.cmdOnLine.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdOnLine.Parameters.Add(this.l3cmdpOnLine);
            this.cmdOnLine.ReturnTarget = null;
            this.cmdOnLine.ReturnTargetProperty = null;
            this.cmdOnLine.Trigger = null;
            this.cmdOnLine.TriggerEvent = "Click";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // l3cmdpOnLine
            // 
            this.l3cmdpOnLine.AcceptAfterExecuted = false;
            this.l3cmdpOnLine.ConstantValue = null;
            this.l3cmdpOnLine.MergeTarget = false;
            this.l3cmdpOnLine.SourceFilter = null;
            this.l3cmdpOnLine.SourceObject = null;
            this.l3cmdpOnLine.SourceProperty = null;
            this.l3cmdpOnLine.TargetObject = null;
            this.l3cmdpOnLine.TargetProperty = null;
            // 
            // cmdOffLine
            // 
            this.cmdOffLine.Adapter = this.Adapter;
            this.cmdOffLine.MergeReturnTarget = false;
            this.cmdOffLine.Method = "VactubeOffLine";
            this.cmdOffLine.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdOffLine.Parameters.Add(this.l3cmdpOffLine);
            this.cmdOffLine.ReturnTarget = null;
            this.cmdOffLine.ReturnTargetProperty = null;
            this.cmdOffLine.Trigger = null;
            this.cmdOffLine.TriggerEvent = "Click";
            // 
            // l3cmdpOffLine
            // 
            this.l3cmdpOffLine.AcceptAfterExecuted = false;
            this.l3cmdpOffLine.ConstantValue = null;
            this.l3cmdpOffLine.MergeTarget = false;
            this.l3cmdpOffLine.SourceFilter = null;
            this.l3cmdpOffLine.SourceObject = null;
            this.l3cmdpOffLine.SourceProperty = null;
            this.l3cmdpOffLine.TargetObject = null;
            this.l3cmdpOffLine.TargetProperty = null;
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(123, 76);
            this.txtUp.Name = "txtUp";
            this.txtUp.ReadOnly = true;
            this.txtUp.Size = new System.Drawing.Size(100, 21);
            this.txtUp.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 82;
            this.label1.Text = "上部槽号:";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(123, 103);
            this.txtDown.Name = "txtDown";
            this.txtDown.ReadOnly = true;
            this.txtDown.Size = new System.Drawing.Size(100, 21);
            this.txtDown.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "下部槽号:";
            // 
            // RHAreaOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 230);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RHAreaOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH处理";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbAreaB;
        private System.Windows.Forms.RadioButton rbAreaA;
        private AppSvrHMI.L3Command cmdOnLine;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter l3cmdpOnLine;
        private AppSvrHMI.L3Command cmdOffLine;
        private AppSvrHMI.L3CommandParameter l3cmdpOffLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtUp;
    }
}