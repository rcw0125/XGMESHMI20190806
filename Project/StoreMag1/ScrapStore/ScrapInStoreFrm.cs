using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.ScrapStore
{
    public partial class ScrapInStoreFrm : Form
    {
        public ScrapInStoreFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //���
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            //ֻѡһ������
            int checkCount = 0;
            dvInStore.EndEdit();
            bsInStore.EndEdit();
            for (int i = 0; i < dsInStore.Tables[0].Rows.Count; i++)
            {
                if (dvInStore.Rows[i].Cells[0].Value.ToString() == "1")
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
                dsScrapInStoreSend.Tables[0].Clear();
                dsScrapInStoreSend.Tables[0].ImportRow(dsInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                ScrapInStoreComfirmFrm frm = new ScrapInStoreComfirmFrm();
                frm.ShowDialogEx(Adapter.Session, dsScrapInStoreSend);
                dsInStore.LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScrapInStoreFrm_Load(object sender, EventArgs e)
        {

        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void ScrapInStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}