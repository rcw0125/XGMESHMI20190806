using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyInStoreFrm : Form
    {
        public AlloyInStoreFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //����
        private void btnInStore_Click(object sender, EventArgs e)
        {
            //ֻѡһ������
            int checkCount = 0;
            dvAlloyInStore.EndEdit();
            bsAlloyInStore.EndEdit();
            for (int i = 0; i < dsAlloyInStore.Tables[0].Rows.Count; i++)
            {
                if (dvAlloyInStore.Rows[i].Cells[0].Value != null && dvAlloyInStore.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("ֻ��ѡһ������", "��ʾ");
            }
            else
            {
                dsAlloyInStoreSend.Tables[0].Clear();
                dsAlloyInStoreSend.Tables[0].ImportRow(dsAlloyInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                AlloyInStoreComfirmFrm frm = new AlloyInStoreComfirmFrm();
                frm.ShowDialogEx(Adapter.Session, dsAlloyInStoreSend);
            }
        }

        //�˳�
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlloyInStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvAlloyInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //�Ͻ�תɢ״��
        private void btnAlloyToBulk_Click(object sender, EventArgs e)
        {
            //ֻѡһ������
            int checkCount = 0;
            dvAlloyInStore.EndEdit();
            bsAlloyInStore.EndEdit();
            for (int i = 0; i < dsAlloyInStore.Tables[0].Rows.Count; i++)
            {
                if (dvAlloyInStore.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("ֻ��ѡһ������", "��ʾ");
            }
            else
            {
                dsAlloyInStoreSend.Tables[0].Clear();
                dsAlloyInStoreSend.Tables[0].ImportRow(dsAlloyInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                AlloyToBulkFrm frm = new AlloyToBulkFrm();
                frm.ShowDialogEx(Adapter.Session, dsAlloyInStoreSend);
            }
        }

        private void txtAlloyInStore_TextChanged(object sender, EventArgs e)
        {
            dsAlloyInStore.LoadData();
        }

        
       
    }
}