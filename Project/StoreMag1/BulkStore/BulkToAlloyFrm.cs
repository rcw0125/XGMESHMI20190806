using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BulkStore
{
    public partial class BulkToAlloyFrm : Form
    {
        public BulkToAlloyFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            dsBulkToAlloy.Tables[0].Clear();
            dsBulkToAlloy.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            txtOldAmount.Text = dsData.Tables[0].Rows[0]["AMOUNT"].ToString();
            Adapter.Session = session;
            this.ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBulkToAlloy.EndEdit();
            dsBulkToAlloy.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫת��ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (txtAmount.Text.Trim() == "0" && txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("ת����������Ϊ�㣡", "��ʾ");
                    return;
                }

                if (Convert.ToDouble(txtOldAmount.Text.Trim()) < Convert.ToDouble(dsBulkToAlloy.Tables[0].Rows[0]["Amount"].ToString()))
                {
                    MessageBox.Show("ת��ʧ�ܣ�ת��������������������", "��ʾ");
                }
                else
                {
                    cmdBulkToAlloy.Execute();
                    String returnFlag = cmdBulkToAlloy.Command.Return.ToString();
                    //string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        MessageBox.Show("ת���ɹ���", "��ʾ");
                        this.Close();
                    }
                    else
                    {
                        if (returnFlag == "-3")
                        {
                            MessageBox.Show("ת�����ɹ�����ɢ״�ϲ�����ת��Ϊ�Ͻ�", "��ʾ");
                        }
                        else
                        {
                            MessageBox.Show("ת�����ɹ���" + returnFlag, "��ʾ");
                        }
                    }
                }
            }
        }

        //ȡ��
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BulkToAlloyFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}