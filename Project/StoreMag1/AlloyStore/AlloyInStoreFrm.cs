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

        //上料
        private void btnInStore_Click(object sender, EventArgs e)
        {
            //只选一行数据
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
                MessageBox.Show("只能选一条数据", "提示");
            }
            else
            {
                dsAlloyInStoreSend.Tables[0].Clear();
                dsAlloyInStoreSend.Tables[0].ImportRow(dsAlloyInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                AlloyInStoreComfirmFrm frm = new AlloyInStoreComfirmFrm();
                frm.ShowDialogEx(Adapter.Session, dsAlloyInStoreSend);
            }
        }

        //退出
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

        //合金转散状料
        private void btnAlloyToBulk_Click(object sender, EventArgs e)
        {
            //只选一行数据
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
                MessageBox.Show("只能选一条数据", "提示");
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