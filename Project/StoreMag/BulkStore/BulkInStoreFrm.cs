using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BulkStore
{
    public partial class BulkInStoreFrm : Form
    {
        public BulkInStoreFrm()
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
            dvBulkInStore.EndEdit();
            bsBulkInStore.EndEdit();
            for (int i = 0; i < dsBulkInStore.Tables[0].Rows.Count; i++)
            {
                if (dvBulkInStore.Rows[i].Cells[0].Value.ToString() == "1")
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
                dsBulkInStoreSend.Tables[0].Clear();
                dsBulkInStoreSend.Tables[0].ImportRow(dsBulkInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                BulkInStoreComfirmFrm frm = new BulkInStoreComfirmFrm();
                frm.ShowDialogEx(Adapter.Session, dsBulkInStoreSend);
                dsBulkInStore.LoadData();
            }
        }

        //退出
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BulkInStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvBulkInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnBulkToAlloy_Click(object sender, EventArgs e)
        {
            //只选一行数据
            int checkCount = 0;
            dvBulkInStore.EndEdit();
            bsBulkInStore.EndEdit();
            for (int i = 0; i < dsBulkInStore.Tables[0].Rows.Count; i++)
            {
                if (dvBulkInStore.Rows[i].Cells[0].Value.ToString() == "1")
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
                dsBulkInStoreSend.Tables[0].Clear();
                dsBulkInStoreSend.Tables[0].ImportRow(dsBulkInStore.Tables[0].Select("CheckFlag = '1'")[0]);
                BulkToAlloyFrm frm = new BulkToAlloyFrm();
                frm.ShowDialogEx(Adapter.Session, dsBulkInStoreSend);
                dsBulkInStore.LoadData();
            }
        }

        private void txtBulkInStore_TextChanged(object sender, EventArgs e)
        {
            dsBulkInStore.LoadData();
        }
       
    }
}