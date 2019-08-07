namespace UnitMag.CCMMag
{
    partial class CCMCureDataFrm
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
            this.panelctr = new System.Windows.Forms.Panel();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.SuspendLayout();
            // 
            // panelctr
            // 
            this.panelctr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelctr.Location = new System.Drawing.Point(0, 0);
            this.panelctr.Margin = new System.Windows.Forms.Padding(0);
            this.panelctr.Name = "panelctr";
            this.panelctr.Size = new System.Drawing.Size(901, 375);
            this.panelctr.TabIndex = 0;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // CCMCureDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 375);
            this.Controls.Add(this.panelctr);
            this.Name = "CCMCureDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "曲线数据";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctr;
        private AppSvrHMI.L3Adapter Adapter;
    }
}