using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyToBulkFrm : Form
    {
        public AlloyToBulkFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            dsAlloyToBulk.Tables[0].Clear();
            dsAlloyToBulk.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            txtOldAmount.Text = dsData.Tables[0].Rows[0]["AMOUNT"].ToString();
            Adapter.Session = session;
            this.ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsAlloyToBulk.EndEdit();
            dsAlloyToBulk.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫת��ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (txtAmount.Text.Trim() == "0" && txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("ת����������Ϊ�㣡", "��ʾ");
                    return;
                }

                if (Convert.ToDouble(txtOldAmount.Text.Trim()) < Convert.ToDouble(dsAlloyToBulk.Tables[0].Rows[0]["Amount"].ToString()))
                {
                    MessageBox.Show("ת��ʧ�ܣ�ת��������������������", "��ʾ");
                }
                else
                {
                    cmdAlloyToBulk.Execute();
                    String returnFlag = cmdAlloyToBulk.Command.Return.ToString();
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
                            MessageBox.Show("ת�����ɹ����úϽ�����ת��Ϊɢ״��", "��ʾ");
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
        private void AlloyToBulkFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}