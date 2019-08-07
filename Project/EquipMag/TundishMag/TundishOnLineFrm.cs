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
                            strShow = "��������Ϊ�գ�������Ϊ�գ��򳵺�Ϊ�գ�";
                            break;
                        case -2:
                            strShow = "��ǰ������Ӧ�����ϴ����а���";
                            break;
                        case -3:
                            strShow = "���ö����а���ʧ�ܣ�";
                            break;
                        case -4:
                            strShow = "��ȡ�а�������Ϣʧ�ܣ�";
                            break;
                        case -5:
                            strShow = "�޸��а�������Ϣʧ�ܣ�";
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show(strShow, "��ʾ");
                }
                else
                {
                    MessageBox.Show("�����ɹ���", "��ʾ");
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