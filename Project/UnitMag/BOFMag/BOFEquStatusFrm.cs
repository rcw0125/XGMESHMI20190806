using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFEquStatusFrm : Form
    {
        public BOFEquStatusFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.Session = session;

            string id = UnitID.Substring(UnitID.Length - 1, 1);
            lbBOFID.Text = id + @"号转炉";

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (paramStatus.ConstantValue == null || paramStatus.ConstantValue.Length < 1)
            {
                MessageBox.Show("请选择状态！");
                btnConfirm.DialogResult = DialogResult.None;
                return;
            }

            int iRet = cmdChangeStatus.Execute();
            if (iRet != 0 || (short)cmdChangeStatus.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdChangeStatus.Command.ErrorCode));
                MessageBox.Show("修改设备状态失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("修改设备状态成功！", "提示");
            }
        }

        private void OnStatusChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                paramStatus.ConstantValue = btn.Tag.ToString();
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        private void BOFEquStatusFrm_Load(object sender, EventArgs e)
        {
            txtReason.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}