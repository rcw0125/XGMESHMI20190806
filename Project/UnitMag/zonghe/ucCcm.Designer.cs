namespace UnitMag.zonghe
{
    partial class ucCcm
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCCM = new System.Windows.Forms.PictureBox();
            this.lbCcmName = new System.Windows.Forms.Label();
            this.lbLadleWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCCM)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCCM
            // 
            this.pbCCM.Location = new System.Drawing.Point(0, 3);
            this.pbCCM.Name = "pbCCM";
            this.pbCCM.Size = new System.Drawing.Size(82, 78);
            this.pbCCM.TabIndex = 0;
            this.pbCCM.TabStop = false;
            // 
            // lbCcmName
            // 
            this.lbCcmName.AutoSize = true;
            this.lbCcmName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbCcmName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbCcmName.Location = new System.Drawing.Point(29, 9);
            this.lbCcmName.Name = "lbCcmName";
            this.lbCcmName.Size = new System.Drawing.Size(43, 16);
            this.lbCcmName.TabIndex = 1;
            this.lbCcmName.Text = "3#机";
            // 
            // lbLadleWeight
            // 
            this.lbLadleWeight.AutoSize = true;
            this.lbLadleWeight.Font = new System.Drawing.Font("宋体", 11F);
            this.lbLadleWeight.Location = new System.Drawing.Point(17, 88);
            this.lbLadleWeight.Name = "lbLadleWeight";
            this.lbLadleWeight.Size = new System.Drawing.Size(39, 15);
            this.lbLadleWeight.TabIndex = 2;
            this.lbLadleWeight.Text = "20.1";
            // 
            // ucCcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLadleWeight);
            this.Controls.Add(this.lbCcmName);
            this.Controls.Add(this.pbCCM);
            this.Name = "ucCcm";
            this.Size = new System.Drawing.Size(82, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pbCCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCCM;
        private System.Windows.Forms.Label lbCcmName;
        private System.Windows.Forms.Label lbLadleWeight;
    }
}
