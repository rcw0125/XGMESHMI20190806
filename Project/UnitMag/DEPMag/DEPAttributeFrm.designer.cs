namespace UnitMag.DEPMag
{
    partial class DEPAttributeFrm
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
            this.txtDepFlag = new AppSvrHMI.L3DataBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l3DataBox1 = new AppSvrHMI.L3DataBox();
            this.txtCampaign = new AppSvrHMI.L3DataBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLanceAge = new AppSvrHMI.L3DataBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFurnaceAge = new AppSvrHMI.L3DataBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurface = new AppSvrHMI.L3DataBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHead = new AppSvrHMI.L3DataBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel3.Location = new System.Drawing.Point(0, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 41);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 6);
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
            this.btnConfirm.Location = new System.Drawing.Point(191, 6);
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
            this.tabControl1.Size = new System.Drawing.Size(360, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtHead);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSurface);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDepFlag);
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
            this.tabPage1.Size = new System.Drawing.Size(352, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "脱磷站信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDepFlag
            // 
            this.txtDepFlag.DataFormat = null;
            this.txtDepFlag.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtDepFlag.DataProperty = "Dep_Flag";
            this.txtDepFlag.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtDepFlag.L3DataAdapter = this.Adapter;
            this.txtDepFlag.Location = new System.Drawing.Point(110, 270);
            this.txtDepFlag.Name = "txtDepFlag";
            this.txtDepFlag.Size = new System.Drawing.Size(145, 21);
            this.txtDepFlag.TabIndex = 86;
            this.txtDepFlag.Value = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 87;
            this.label2.Text = "脱硅标志:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "设置下一炉炉号:";
            // 
            // l3DataBox1
            // 
            this.l3DataBox1.DataFormat = null;
            this.l3DataBox1.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.l3DataBox1.DataProperty = "NextHeatID";
            this.l3DataBox1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox1.L3DataAdapter = this.Adapter;
            this.l3DataBox1.Location = new System.Drawing.Point(110, 23);
            this.l3DataBox1.Name = "l3DataBox1";
            this.l3DataBox1.Size = new System.Drawing.Size(145, 21);
            this.l3DataBox1.TabIndex = 84;
            this.l3DataBox1.Value = null;
            // 
            // txtCampaign
            // 
            this.txtCampaign.DataFormat = null;
            this.txtCampaign.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtCampaign.DataProperty = "LanceNo";
            this.txtCampaign.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtCampaign.L3DataAdapter = this.Adapter;
            this.txtCampaign.Location = new System.Drawing.Point(110, 139);
            this.txtCampaign.Name = "txtCampaign";
            this.txtCampaign.Size = new System.Drawing.Size(145, 21);
            this.txtCampaign.TabIndex = 0;
            this.txtCampaign.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 83;
            this.label7.Text = "喷粉枪号:";
            // 
            // txtLanceAge
            // 
            this.txtLanceAge.DataFormat = null;
            this.txtLanceAge.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtLanceAge.DataProperty = "LanceAge";
            this.txtLanceAge.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtLanceAge.L3DataAdapter = this.Adapter;
            this.txtLanceAge.Location = new System.Drawing.Point(110, 177);
            this.txtLanceAge.Name = "txtLanceAge";
            this.txtLanceAge.Size = new System.Drawing.Size(145, 21);
            this.txtLanceAge.TabIndex = 2;
            this.txtLanceAge.Value = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 81;
            this.label6.Text = "喷粉枪龄:";
            // 
            // txtFurnaceAge
            // 
            this.txtFurnaceAge.DataFormat = null;
            this.txtFurnaceAge.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtFurnaceAge.DataProperty = "FurnaceAge";
            this.txtFurnaceAge.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtFurnaceAge.L3DataAdapter = this.Adapter;
            this.txtFurnaceAge.Location = new System.Drawing.Point(110, 61);
            this.txtFurnaceAge.Name = "txtFurnaceAge";
            this.txtFurnaceAge.Size = new System.Drawing.Size(145, 21);
            this.txtFurnaceAge.TabIndex = 1;
            this.txtFurnaceAge.Value = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "氧枪枪龄:";
            // 
            // txtSurface
            // 
            this.txtSurface.DataFormat = null;
            this.txtSurface.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtSurface.DataProperty = "Furnace_Surface";
            this.txtSurface.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtSurface.L3DataAdapter = this.Adapter;
            this.txtSurface.Location = new System.Drawing.Point(110, 101);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(145, 21);
            this.txtSurface.TabIndex = 88;
            this.txtSurface.Value = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "铁水液面:";
            // 
            // txtHead
            // 
            this.txtHead.DataFormat = null;
            this.txtHead.DataObject = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.txtHead.DataProperty = "Slag_Head";
            this.txtHead.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtHead.L3DataAdapter = this.Adapter;
            this.txtHead.Location = new System.Drawing.Point(110, 219);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(145, 21);
            this.txtHead.TabIndex = 90;
            this.txtHead.Value = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "耙头使用寿命:";
            // 
            // DEPAttributeFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(360, 433);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DEPAttributeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "脱磷站属性维护";
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
        private AppSvrHMI.L3DataBox txtDepFlag;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataBox txtSurface;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3DataBox txtHead;
        private System.Windows.Forms.Label label5;
    }
}