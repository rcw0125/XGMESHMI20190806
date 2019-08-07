using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeOnFireFrm : Form
    {
        public VacTubeOnFireFrm()
        {
            InitializeComponent();
        }

        private string strFirePosition = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            dsBase.SourceMethod = "select vactube_code,install_id from cvactube_base where Position = 'aaaaa' and (vactube_name = '1' OR vactube_name = '2')  group by vactube_code,install_id";
            Adapter.Session = session;
            return ShowDialog();
        }

        private void VacTubeOnFireFrm_Load(object sender, EventArgs e)
        {
            rdbtn2.Checked = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (strFirePosition == "")
            {
                MessageBox.Show("请选择烘烤位置！", "提示");
                return;
            }
            Button btn = (Button)sender;
            string strType = btn.Tag.ToString();
            if (strType == "")
                return;

            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("没有真空槽编号！","提示");
                return;
            }

            cmdpPositon.ConstantValue = strFirePosition;
            cmdpType.ConstantValue = strType;
            if (cmdFire.Execute() >= 0)
            {
                if (Convert.ToInt32(cmdFire.Command.Return) > 0)
                {
                    MessageBox.Show("操作成功！", "提示");
                    this.Close();
                }
                else
                    MessageBox.Show("操作失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "RadioButton")
                return;
            RadioButton rdbtn = (RadioButton)sender;
            if (!rdbtn.Checked)
                strFirePosition = "";
            else
                strFirePosition = rdbtn.Tag.ToString();
            dsBase.SourceMethod = "select vactube_code,install_id,Flag from cvactube_base where Position = '"
                + strFirePosition + "' and (vactube_name = '1' OR vactube_name = '2') and status > '01' and status < '06' group by vactube_code,install_id,Flag";
            if (dsBase.Tables[0].Rows.Count < 1)
            {
                btnFireStart.Enabled = false;
                btnFireEnd.Enabled = false;
            }
            else
            {
                string strFlag = dsBase.Tables[0].Rows[0]["Flag"].ToString();
                if (strFlag == "0")
                {
                    btnFireStart.Enabled = false;
                    btnFireEnd.Enabled = true;
                }
                else if(strFlag == "1" )
                {
                    btnFireStart.Enabled = true;
                    btnFireEnd.Enabled = false;
                }

            }

        }

    }
}