using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.TundishMag
{
    public partial class TundishOnLineFrm : Form
    {
        public TundishOnLineFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,DataSet dsSend)
        {
            if (dsSend.Tables[0].Rows.Count < 1)
                return DialogResult.None;
            dsBase.Tables[0].ImportRow(dsSend.Tables[0].Rows[0]);

            string strType = dsBase.Tables[0].Rows[0]["TundishType"].ToString();
            Adapter.Session = session;
            
            cmbCastID.Items.Clear();
            if (strType == "1")
            {
                cmbCastID.Items.Add("S61");
                cmbCastID.Items.Add("S62");
            }
            else if (strType == "2")
            {
                cmbCastID.Items.Add("S63");
                cmbCastID.Items.Add("S64");
            }
            else if (strType == "3")
            {
                cmbCastID.Items.Add("S65");
            }
            else if (strType == "4")
            {
                cmbCastID.Items.Add("S67");
            }
            //add by hyh 2012-06-08
            else if (strType == "5")
            {
                cmbCastID.Items.Add("S66");
            }
            //end
         
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            string strShow = "";
            if (cmdOnFire.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdOnFire.Command.Return);
                if (iRet <= 0)
                {
                    switch (iRet)
                    {
                        case -1:
                            strShow = "工作层编号为空，或铸机为空，或车号为空！";
                            break;
                        case -2:
                            strShow = "当前铸机对应车号上存在中包！";
                            break;
                        case -3:
                            strShow = "设置东西中包号失败！";
                            break;
                        case -4:
                            strShow = "获取中包履历信息失败！";
                            break;
                        case -5:
                            strShow = "修改中包履历信息失败！";
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show(strShow, "提示");
                }
                else
                {
                    MessageBox.Show("操作成功！", "提示");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}