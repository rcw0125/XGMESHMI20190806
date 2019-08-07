namespace UnitMag
{
    partial class ModifyLadleGradeFrm
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.txtTreatNo = new System.Windows.Forms.TextBox();
            this.cmbLadleGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeatid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myLine1 = new buttonHide.MyLine();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine2 = new buttonHide.MyLine();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLadleNo = new System.Windows.Forms.TextBox();
            this.cmdModify = new AppSvrHMI.L3Command(this.components);
            this.cmdpTreatNo = new AppSvrHMI.L3CommandParameter();
            this.cmdpLadleGrade = new AppSvrHMI.L3CommandParameter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(97, 13);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(53, 16);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A工位";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(183, 13);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(53, 16);
            this.rbtnB.TabIndex = 0;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B工位";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // txtTreatNo
            // 
            this.txtTreatNo.Location = new System.Drawing.Point(103, 41);
            this.txtTreatNo.Name = "txtTreatNo";
            this.txtTreatNo.ReadOnly = true;
            this.txtTreatNo.Size = new System.Drawing.Size(156, 21);
            this.txtTreatNo.TabIndex = 1;
            // 
            // cmbLadleGrade
            // 
            this.cmbLadleGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleGrade.FormattingEnabled = true;
            this.cmbLadleGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbLadleGrade.Location = new System.Drawing.Point(103, 125);
            this.cmbLadleGrade.Name = "cmbLadleGrade";
            this.cmbLadleGrade.Size = new System.Drawing.Size(156, 20);
            this.cmbLadleGrade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "处理号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "包况:";
            // 
            // txtHeatid
            // 
            this.txtHeatid.Location = new System.Drawing.Point(103, 69);
            this.txtHeatid.Name = "txtHeatid";
            this.txtHeatid.ReadOnly = true;
            this.txtHeatid.Size = new System.Drawing.Size(156, 21);
            this.txtHeatid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "炉号:";
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(50, 33);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(226, 2);
            this.myLine1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 239);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.myLine2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.rbtnA);
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.rbtnB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTreatNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLadleNo);
            this.tabPage1.Controls.Add(this.txtHeatid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbLadleGrade);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "包况信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine2
            // 
            this.myLine2.BackColor = System.Drawing.SystemColors.Control;
            this.myLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myLine2.Location = new System.Drawing.Point(3, 161);
            this.myLine2.Name = "myLine2";
            this.myLine2.Size = new System.Drawing.Size(313, 10);
            this.myLine2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 171);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(313, 38);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(154, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "钢包号:";
            // 
            // txtLadleNo
            // 
            this.txtLadleNo.Location = new System.Drawing.Point(103, 97);
            this.txtLadleNo.Name = "txtLadleNo";
            this.txtLadleNo.ReadOnly = true;
            this.txtLadleNo.Size = new System.Drawing.Size(156, 21);
            this.txtLadleNo.TabIndex = 1;
            // 
            // cmdModify
            // 
            this.cmdModify.Adapter = this.Adapter;
            this.cmdModify.MergeReturnTarget = false;
            this.cmdModify.Method = "ModifyLadleGrade";
            this.cmdModify.Object = "";
            this.cmdModify.Parameters.Add(this.cmdpTreatNo);
            this.cmdModify.Parameters.Add(this.cmdpLadleGrade);
            this.cmdModify.ReturnTarget = null;
            this.cmdModify.ReturnTargetProperty = null;
            this.cmdModify.Trigger = null;
            this.cmdModify.TriggerEvent = "Click";
            // 
            // cmdpTreatNo
            // 
            this.cmdpTreatNo.AcceptAfterExecuted = false;
            this.cmdpTreatNo.ConstantValue = null;
            this.cmdpTreatNo.MergeTarget = false;
            this.cmdpTreatNo.SourceFilter = null;
            this.cmdpTreatNo.SourceObject = null;
            this.cmdpTreatNo.SourceProperty = null;
            this.cmdpTreatNo.TargetObject = null;
            this.cmdpTreatNo.TargetProperty = null;
            // 
            // cmdpLadleGrade
            // 
            this.cmdpLadleGrade.AcceptAfterExecuted = false;
            this.cmdpLadleGrade.ConstantValue = null;
            this.cmdpLadleGrade.MergeTarget = false;
            this.cmdpLadleGrade.SourceFilter = null;
            this.cmdpLadleGrade.SourceObject = null;
            this.cmdpLadleGrade.SourceProperty = null;
            this.cmdpLadleGrade.TargetObject = null;
            this.cmdpLadleGrade.TargetProperty = null;
            // 
            // ModifyLadleGradeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 239);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyLadleGradeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢包包况修正";
            this.Load += new System.EventHandler(this.ModifyLadleGradeFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.TextBox txtTreatNo;
        private System.Windows.Forms.ComboBox cmbLadleGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeatid;
        private System.Windows.Forms.Label label3;
        private buttonHide.MyLine myLine1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3Command cmdModify;
        private AppSvrHMI.L3CommandParameter cmdpTreatNo;
        private AppSvrHMI.L3CommandParameter cmdpLadleGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLadleNo;
        private buttonHide.MyLine myLine2;
    }
}