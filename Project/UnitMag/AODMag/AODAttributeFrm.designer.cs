namespace UnitMag.AODMag
{
    partial class AODAttributeFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.l3DataBox1 = new AppSvrHMI.L3DataBox();
            this.txtCampaign = new AppSvrHMI.L3DataBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLanceAge = new AppSvrHMI.L3DataBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFurnaceAge = new AppSvrHMI.L3DataBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFurnaceNo = new AppSvrHMI.L3DataBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 41);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(220, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(142, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
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
            this.tabControl1.Size = new System.Drawing.Size(311, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtFurnaceNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.l3DataBox1);
            this.tabPage1.Controls.Add(this.txtCampaign);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLanceAge);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtFurnaceAge);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(303, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AOD炉信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "设置还原步数:";
            // 
            // l3DataBox1
            // 
            this.l3DataBox1.DataFormat = null;
            this.l3DataBox1.DataObject = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.l3DataBox1.DataProperty = "Return_Flag";
            this.l3DataBox1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox1.L3DataAdapter = this.Adapter;
            this.l3DataBox1.Location = new System.Drawing.Point(144, 23);
            this.l3DataBox1.Name = "l3DataBox1";
            this.l3DataBox1.Size = new System.Drawing.Size(111, 21);
            this.l3DataBox1.TabIndex = 84;
            this.l3DataBox1.Value = null;
            // 
            // txtCampaign
            // 
            this.txtCampaign.DataFormat = null;
            this.txtCampaign.DataObject = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.txtCampaign.DataProperty = "LanceNo";
            this.txtCampaign.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtCampaign.L3DataAdapter = this.Adapter;
            this.txtCampaign.Location = new System.Drawing.Point(84, 64);
            this.txtCampaign.Name = "txtCampaign";
            this.txtCampaign.Size = new System.Drawing.Size(171, 21);
            this.txtCampaign.TabIndex = 0;
            this.txtCampaign.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 83;
            this.label7.Text = "枪号:";
            // 
            // txtLanceAge
            // 
            this.txtLanceAge.DataFormat = null;
            this.txtLanceAge.DataObject = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.txtLanceAge.DataProperty = "LanceAge";
            this.txtLanceAge.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtLanceAge.L3DataAdapter = this.Adapter;
            this.txtLanceAge.Location = new System.Drawing.Point(84, 102);
            this.txtLanceAge.Name = "txtLanceAge";
            this.txtLanceAge.Size = new System.Drawing.Size(171, 21);
            this.txtLanceAge.TabIndex = 2;
            this.txtLanceAge.Value = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 81;
            this.label6.Text = "枪龄:";
            // 
            // txtFurnaceAge
            // 
            this.txtFurnaceAge.DataFormat = null;
            this.txtFurnaceAge.DataObject = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.txtFurnaceAge.DataProperty = "FurnaceAge";
            this.txtFurnaceAge.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtFurnaceAge.L3DataAdapter = this.Adapter;
            this.txtFurnaceAge.Location = new System.Drawing.Point(84, 173);
            this.txtFurnaceAge.Name = "txtFurnaceAge";
            this.txtFurnaceAge.Size = new System.Drawing.Size(171, 21);
            this.txtFurnaceAge.TabIndex = 1;
            this.txtFurnaceAge.Value = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "炉龄:";
            // 
            // txtFurnaceNo
            // 
            this.txtFurnaceNo.DataFormat = null;
            this.txtFurnaceNo.DataObject = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.txtFurnaceNo.DataProperty = "FurnaceNo";
            this.txtFurnaceNo.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtFurnaceNo.L3DataAdapter = this.Adapter;
            this.txtFurnaceNo.Location = new System.Drawing.Point(84, 137);
            this.txtFurnaceNo.Name = "txtFurnaceNo";
            this.txtFurnaceNo.Size = new System.Drawing.Size(171, 21);
            this.txtFurnaceNo.TabIndex = 86;
            this.txtFurnaceNo.Value = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 87;
            this.label2.Text = "炉壳号:";
            // 
            // AODAttributeFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(311, 319);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AODAttributeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AOD炉属性维护";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AppSvrHMI.L3DataBox txtFurnaceAge;
        private System.Windows.Forms.Label label4;
        private AppSvrHMI.L3DataBox txtLanceAge;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3DataBox txtCampaign;
        private System.Windows.Forms.Label label7;
        private AppSvrHMI.L3DataBox l3DataBox1;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataBox txtFurnaceNo;
        private System.Windows.Forms.Label label2;
    }
}