namespace XGMESMain
{
    partial class frmConfigConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.ERR = new System.Windows.Forms.ErrorProvider(this.components);
            this.L3Session = new AppSvrIF.Session(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ERR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口号：";
            // 
            // tbAddress
            // 
            this.ERR.SetIconAlignment(this.tbAddress, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbAddress.Location = new System.Drawing.Point(103, 51);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(195, 21);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Validated += new System.EventHandler(this.tbAddress_Validated);
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // tbPort
            // 
            this.ERR.SetIconAlignment(this.tbPort, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbPort.Location = new System.Drawing.Point(103, 78);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(195, 21);
            this.tbPort.TabIndex = 2;
            this.tbPort.Validated += new System.EventHandler(this.tbPort_Validated);
            this.tbPort.Validating += new System.ComponentModel.CancelEventHandler(this.tbPort_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称：";
            // 
            // cmbNames
            // 
            this.cmbNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNames.FormattingEnabled = true;
            this.ERR.SetIconAlignment(this.cmbNames, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.cmbNames.Location = new System.Drawing.Point(104, 23);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(193, 20);
            this.cmbNames.TabIndex = 0;
            this.cmbNames.Validating += new System.ComponentModel.CancelEventHandler(this.cmbNames_Validating);
            this.cmbNames.Validated += new System.EventHandler(this.cmbNames_Validated);
            this.cmbNames.SelectionChangeCommitted += new System.EventHandler(this.cmbNames_SelectionChangeCommitted);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(307, 24);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(21, 18);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "×";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(156, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(230, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(44, 124);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(68, 24);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "测试(&T)";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ERR
            // 
            this.ERR.ContainerControl = this;
            // 
            // L3Session
            // 
            this.L3Session.ConnectionStr = null;
            this.L3Session.Password = null;
            this.L3Session.TimeOut = ((uint)(4294967295u));
            this.L3Session.User = null;
            // 
            // frmConfigConnection
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 164);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConfigConnection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置MES服务器连接";
            this.Load += new System.EventHandler(this.frmConfigConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ErrorProvider ERR;
        private AppSvrIF.Session L3Session;
    }
}