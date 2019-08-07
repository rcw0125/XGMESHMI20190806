using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BloomStore
{
    public partial class BloomInStoreFrm : Form
    {
        public BloomInStoreFrm()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsInStore.Tables[0].Clear();
            for (int i = 0; i < dsData.Tables[0].Rows.Count; i++)
            {
                dsInStore.Tables[0].ImportRow(dsData.Tables[0].Rows[i]);
            }

            return ShowDialog();
        }

        //�˳�
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //���
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            dvInStore.EndEdit();
            bsInStore.EndEdit();

            string check = MessageBox.Show("ȷ��Ҫ���ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdInStore.Execute();
                String returnFlag = cmdInStore.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show("���ɹ���", "��ʾ");
                    dsInStore.LoadData();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("��ⲻ�ɹ����������Ϊ��" + strReasultShow, "��ʾ");
                    dsInStore.LoadData();
                }
            }
        }

        private void dvInStore_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BloomInStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
        
    }
}