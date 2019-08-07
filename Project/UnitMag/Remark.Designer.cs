namespace spc
{
    partial class Remark
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeatid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlarmtype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYuanyin = new System.Windows.Forms.TextBox();
            this.tbGaijin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号：";
            // 
            // tbHeatid
            // 
            this.tbHeatid.Location = new System.Drawing.Point(154, 9);
            this.tbHeatid.Name = "tbHeatid";
            this.tbHeatid.Size = new System.Drawing.Size(99, 21);
            this.tbHeatid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "报警类型：";
            // 
            // tbAlarmtype
            // 
            this.tbAlarmtype.Location = new System.Drawing.Point(154, 43);
            this.tbAlarmtype.Multiline = true;
            this.tbAlarmtype.Name = "tbAlarmtype";
            this.tbAlarmtype.Size = new System.Drawing.Size(230, 50);
            this.tbAlarmtype.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "原因分析：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "改进措施：";
            // 
            // tbYuanyin
            // 
            this.tbYuanyin.Location = new System.Drawing.Point(154, 136);
            this.tbYuanyin.Multiline = true;
            this.tbYuanyin.Name = "tbYuanyin";
            this.tbYuanyin.Size = new System.Drawing.Size(230, 50);
            this.tbYuanyin.TabIndex = 3;
            // 
            // tbGaijin
            // 
            this.tbGaijin.Location = new System.Drawing.Point(154, 218);
            this.tbGaijin.Multiline = true;
            this.tbGaijin.Name = "tbGaijin";
            this.tbGaijin.Size = new System.Drawing.Size(230, 50);
            this.tbGaijin.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(277, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Remark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 370);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGaijin);
            this.Controls.Add(this.tbYuanyin);
            this.Controls.Add(this.tbAlarmtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHeatid);
            this.Controls.Add(this.label1);
            this.Name = "Remark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报警记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeatid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlarmtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYuanyin;
        private System.Windows.Forms.TextBox tbGaijin;
        private System.Windows.Forms.Button btnSave;
    }
}