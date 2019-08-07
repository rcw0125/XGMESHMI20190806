using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class BOFTapStartFrm : Form
    {
        public BOFTapStartFrm()
        {
            InitializeComponent();
        }

        //[20081229Liao]
        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strLadleID)
        {
            Adapter.Session = session;

            txtLadleID.Text = strLadleID;

            return ShowDialog();
        }

        private void BOFTapStartFrm_Load(object sender, EventArgs e)
        {
            dtTapTime.Value = DateTime.Now;

            cmbBOFID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbBOFID.Text.Trim() == "" || txtHeatID.Text.Trim().Length != 9)
            {
                MessageBox.Show("输入数据有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("确认\"补录转炉出钢开始信号\"！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                l3cmdpUnitID.ConstantValue = cmbBOFID.Text.Trim();
                l3cmdpTapTime.SourceObject = dtTapTime;
                l3cmdpTapTime.SourceProperty = "Value";
                l3cmdpHeatID.ConstantValue = txtHeatID.Text.Trim();

                if (cmdBOFTapStart.Execute() >= 0)
                {
                    if (Convert.ToBoolean(cmdBOFTapStart.Command.Return))
                    {
                        MessageBox.Show("补录成功！", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("补录失败！", "提示", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("补录失败！", "提示", MessageBoxButtons.OK);
                }
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}