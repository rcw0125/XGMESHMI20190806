namespace XGMESMain
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.PRODUCT_NAME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PRODUCT_VERSION = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COPYRIGHT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.USER_INFO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MANUFACTURE = new System.Windows.Forms.Label();
            this.MANUFACTURER_PHONE = new System.Windows.Forms.Label();
            this.MANUFACTURER_WEB = new System.Windows.Forms.LinkLabel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(420, 234);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "关闭(&X)";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PRODUCT_NAME, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PRODUCT_VERSION, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.COPYRIGHT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.USER_INFO, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(187, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 199);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "产品名称：";
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.AutoSize = true;
            this.PRODUCT_NAME.Location = new System.Drawing.Point(77, 0);
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Size = new System.Drawing.Size(77, 12);
            this.PRODUCT_NAME.TabIndex = 0;
            this.PRODUCT_NAME.Text = "制造执行系统";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "版本号：";
            // 
            // PRODUCT_VERSION
            // 
            this.PRODUCT_VERSION.AutoSize = true;
            this.PRODUCT_VERSION.Location = new System.Drawing.Point(77, 20);
            this.PRODUCT_VERSION.Name = "PRODUCT_VERSION";
            this.PRODUCT_VERSION.Size = new System.Drawing.Size(77, 12);
            this.PRODUCT_VERSION.TabIndex = 0;
            this.PRODUCT_VERSION.Text = "2.0.080523.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "版权申明：";
            // 
            // COPYRIGHT
            // 
            this.COPYRIGHT.AutoSize = true;
            this.COPYRIGHT.Location = new System.Drawing.Point(77, 42);
            this.COPYRIGHT.Name = "COPYRIGHT";
            this.COPYRIGHT.Size = new System.Drawing.Size(221, 24);
            this.COPYRIGHT.TabIndex = 0;
            this.COPYRIGHT.Text = "CopyRight (C) 2008-2009 攀钢信息工程技术有限公司 保留所有权力！";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "本软件的使用权授予：";
            // 
            // USER_INFO
            // 
            this.USER_INFO.AutoSize = true;
            this.USER_INFO.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.USER_INFO.Location = new System.Drawing.Point(77, 159);
            this.USER_INFO.Name = "USER_INFO";
            this.USER_INFO.Size = new System.Drawing.Size(125, 12);
            this.USER_INFO.TabIndex = 0;
            this.USER_INFO.Text = "邢台钢铁有限责任公司";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "如需技术支持，请洽：";
            // 
            // MANUFACTURE
            // 
            this.MANUFACTURE.AutoSize = true;
            this.MANUFACTURE.Location = new System.Drawing.Point(185, 234);
            this.MANUFACTURE.Name = "MANUFACTURE";
            this.MANUFACTURE.Size = new System.Drawing.Size(215, 12);
            this.MANUFACTURE.TabIndex = 3;
            this.MANUFACTURE.Text = "攀钢信息工程技术有限公司 软件分公司";
            // 
            // MANUFACTURER_PHONE
            // 
            this.MANUFACTURER_PHONE.AutoSize = true;
            this.MANUFACTURER_PHONE.Location = new System.Drawing.Point(185, 253);
            this.MANUFACTURER_PHONE.Name = "MANUFACTURER_PHONE";
            this.MANUFACTURER_PHONE.Size = new System.Drawing.Size(77, 12);
            this.MANUFACTURER_PHONE.TabIndex = 3;
            this.MANUFACTURER_PHONE.Text = "0812-3397115";
            // 
            // MANUFACTURER_WEB
            // 
            this.MANUFACTURER_WEB.AutoSize = true;
            this.MANUFACTURER_WEB.Location = new System.Drawing.Point(21, 253);
            this.MANUFACTURER_WEB.Name = "MANUFACTURER_WEB";
            this.MANUFACTURER_WEB.Size = new System.Drawing.Size(119, 12);
            this.MANUFACTURER_WEB.TabIndex = 4;
            this.MANUFACTURER_WEB.TabStop = true;
            this.MANUFACTURER_WEB.Text = "www.pzhsteel.com.cn";
            this.MANUFACTURER_WEB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MANUFACTURER_WEB_LinkClicked);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(8, 21);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(164, 199);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(515, 277);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.MANUFACTURER_WEB);
            this.Controls.Add(this.MANUFACTURER_PHONE);
            this.Controls.Add(this.MANUFACTURE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MANUFACTURE;
        private System.Windows.Forms.Label MANUFACTURER_PHONE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel MANUFACTURER_WEB;
        private System.Windows.Forms.Label PRODUCT_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PRODUCT_VERSION;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label COPYRIGHT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label USER_INFO;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}