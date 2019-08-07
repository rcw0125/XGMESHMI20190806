namespace EquipMag.TundishMag
{
    partial class TundishONorOFFLine
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTundishNO = new PxDataValid.PxTextBox();
            this.txtCCMID = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTundishID = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdOnLine = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTundishID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpTundishNO = new AppSvrHMI.L3CommandParameter();
            this.cmdOFFLine = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTundishIDOff = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpTundishNOOff = new AppSvrHMI.L3CommandParameter();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.l3cmdpOnTime = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpOffTime = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(196, 3);
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
            this.tabControl1.Size = new System.Drawing.Size(355, 162);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dtTime);
            this.tabPage1.Controls.Add(this.txtTundishNO);
            this.tabPage1.Controls.Add(this.txtCCMID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtTundishID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "包次信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTundishNO
            // 
            this.txtTundishNO.EnableNull = true;
            this.txtTundishNO.ErropPr = null;
            this.txtTundishNO.Length = 0;
            this.txtTundishNO.Location = new System.Drawing.Point(122, 70);
            this.txtTundishNO.Max = 0;
            this.txtTundishNO.MaxStrLength = 0;
            this.txtTundishNO.Min = 0;
            this.txtTundishNO.MinStrLength = 0;
            this.txtTundishNO.Name = "txtTundishNO";
            this.txtTundishNO.Precision = 0;
            this.txtTundishNO.Size = new System.Drawing.Size(153, 21);
            this.txtTundishNO.TabIndex = 2;
            this.txtTundishNO.ToolTipValid = null;
            this.txtTundishNO.ValidEable = true;
            this.txtTundishNO.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCCMID
            // 
            this.txtCCMID.EnableNull = true;
            this.txtCCMID.ErropPr = null;
            this.txtCCMID.Length = 0;
            this.txtCCMID.Location = new System.Drawing.Point(122, 45);
            this.txtCCMID.Max = 0;
            this.txtCCMID.MaxStrLength = 0;
            this.txtCCMID.Min = 0;
            this.txtCCMID.MinStrLength = 0;
            this.txtCCMID.Name = "txtCCMID";
            this.txtCCMID.Precision = 0;
            this.txtCCMID.ReadOnly = true;
            this.txtCCMID.Size = new System.Drawing.Size(153, 21);
            this.txtCCMID.TabIndex = 2;
            this.txtCCMID.ToolTipValid = null;
            this.txtCCMID.ValidEable = true;
            this.txtCCMID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "包次号:";
            // 
            // txtTundishID
            // 
            this.txtTundishID.EnableNull = true;
            this.txtTundishID.ErropPr = null;
            this.txtTundishID.Length = 0;
            this.txtTundishID.Location = new System.Drawing.Point(122, 20);
            this.txtTundishID.Max = 0;
            this.txtTundishID.MaxStrLength = 0;
            this.txtTundishID.Min = 0;
            this.txtTundishID.MinStrLength = 0;
            this.txtTundishID.Name = "txtTundishID";
            this.txtTundishID.Precision = 0;
            this.txtTundishID.ReadOnly = true;
            this.txtTundishID.Size = new System.Drawing.Size(153, 21);
            this.txtTundishID.TabIndex = 2;
            this.txtTundishID.ToolTipValid = null;
            this.txtTundishID.ValidEable = true;
            this.txtTundishID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "铸机号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "中包号:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdOnLine
            // 
            this.cmdOnLine.Adapter = this.Adapter;
            this.cmdOnLine.MergeReturnTarget = false;
            this.cmdOnLine.Method = "TundishOnLine";
            this.cmdOnLine.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdOnLine.Parameters.Add(this.l3cmdpTundishID);
            this.cmdOnLine.Parameters.Add(this.l3cmdpTundishNO);
            this.cmdOnLine.Parameters.Add(this.l3cmdpOnTime);
            this.cmdOnLine.ReturnTarget = null;
            this.cmdOnLine.ReturnTargetProperty = null;
            this.cmdOnLine.Trigger = null;
            this.cmdOnLine.TriggerEvent = "Click";
            // 
            // l3cmdpTundishID
            // 
            this.l3cmdpTundishID.AcceptAfterExecuted = false;
            this.l3cmdpTundishID.ConstantValue = null;
            this.l3cmdpTundishID.MergeTarget = false;
            this.l3cmdpTundishID.SourceFilter = null;
            this.l3cmdpTundishID.SourceObject = null;
            this.l3cmdpTundishID.SourceProperty = null;
            this.l3cmdpTundishID.TargetObject = null;
            this.l3cmdpTundishID.TargetProperty = null;
            // 
            // l3cmdpTundishNO
            // 
            this.l3cmdpTundishNO.AcceptAfterExecuted = false;
            this.l3cmdpTundishNO.ConstantValue = null;
            this.l3cmdpTundishNO.MergeTarget = false;
            this.l3cmdpTundishNO.SourceFilter = null;
            this.l3cmdpTundishNO.SourceObject = null;
            this.l3cmdpTundishNO.SourceProperty = null;
            this.l3cmdpTundishNO.TargetObject = null;
            this.l3cmdpTundishNO.TargetProperty = null;
            // 
            // cmdOFFLine
            // 
            this.cmdOFFLine.Adapter = this.Adapter;
            this.cmdOFFLine.MergeReturnTarget = false;
            this.cmdOFFLine.Method = "TundishOffLine";
            this.cmdOFFLine.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdOFFLine.Parameters.Add(this.l3cmdpTundishIDOff);
            this.cmdOFFLine.Parameters.Add(this.l3cmdpTundishNOOff);
            this.cmdOFFLine.Parameters.Add(this.l3cmdpOffTime);
            this.cmdOFFLine.ReturnTarget = null;
            this.cmdOFFLine.ReturnTargetProperty = null;
            this.cmdOFFLine.Trigger = null;
            this.cmdOFFLine.TriggerEvent = "Click";
            // 
            // l3cmdpTundishIDOff
            // 
            this.l3cmdpTundishIDOff.AcceptAfterExecuted = false;
            this.l3cmdpTundishIDOff.ConstantValue = null;
            this.l3cmdpTundishIDOff.MergeTarget = false;
            this.l3cmdpTundishIDOff.SourceFilter = null;
            this.l3cmdpTundishIDOff.SourceObject = null;
            this.l3cmdpTundishIDOff.SourceProperty = null;
            this.l3cmdpTundishIDOff.TargetObject = null;
            this.l3cmdpTundishIDOff.TargetProperty = null;
            // 
            // l3cmdpTundishNOOff
            // 
            this.l3cmdpTundishNOOff.AcceptAfterExecuted = false;
            this.l3cmdpTundishNOOff.ConstantValue = null;
            this.l3cmdpTundishNOOff.MergeTarget = false;
            this.l3cmdpTundishNOOff.SourceFilter = null;
            this.l3cmdpTundishNOOff.SourceObject = null;
            this.l3cmdpTundishNOOff.SourceProperty = null;
            this.l3cmdpTundishNOOff.TargetObject = null;
            this.l3cmdpTundishNOOff.TargetProperty = null;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(122, 95);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(153, 21);
            this.dtTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "时间:";
            // 
            // l3cmdpOnTime
            // 
            this.l3cmdpOnTime.AcceptAfterExecuted = false;
            this.l3cmdpOnTime.ConstantValue = null;
            this.l3cmdpOnTime.MergeTarget = false;
            this.l3cmdpOnTime.SourceFilter = null;
            this.l3cmdpOnTime.SourceObject = this.dtTime;
            this.l3cmdpOnTime.SourceProperty = "Value";
            this.l3cmdpOnTime.TargetObject = null;
            this.l3cmdpOnTime.TargetProperty = null;
            // 
            // l3cmdpOffTime
            // 
            this.l3cmdpOffTime.AcceptAfterExecuted = false;
            this.l3cmdpOffTime.ConstantValue = null;
            this.l3cmdpOffTime.MergeTarget = false;
            this.l3cmdpOffTime.SourceFilter = null;
            this.l3cmdpOffTime.SourceObject = this.dtTime;
            this.l3cmdpOffTime.SourceProperty = "Value";
            this.l3cmdpOffTime.TargetObject = null;
            this.l3cmdpOffTime.TargetProperty = null;
            // 
            // TundishONorOFFLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 212);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TundishONorOFFLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "中包上线";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtTundishNO;
        private PxDataValid.PxTextBox txtCCMID;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox txtTundishID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3Command cmdOnLine;
        private AppSvrHMI.L3CommandParameter l3cmdpTundishID;
        private AppSvrHMI.L3CommandParameter l3cmdpTundishNO;
        private AppSvrHMI.L3Command cmdOFFLine;
        private AppSvrHMI.L3CommandParameter l3cmdpTundishIDOff;
        private AppSvrHMI.L3CommandParameter l3cmdpTundishNOOff;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label label4;
        private AppSvrHMI.L3CommandParameter l3cmdpOnTime;
        private AppSvrHMI.L3CommandParameter l3cmdpOffTime;
    }
}