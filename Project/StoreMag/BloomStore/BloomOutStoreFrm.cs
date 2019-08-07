using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BloomStore
{
    public partial class BloomOutStoreFrm : Form
    {
        public BloomOutStoreFrm()
        {
            InitializeComponent();
        }
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsOutStore.Tables[0].Clear();
            for (int i = 0; i < dsData.Tables[0].Rows.Count; i++)
            {
                dsOutStore.Tables[0].ImportRow(dsData.Tables[0].Rows[i]);
            }

            this.ShowDialog();
        }

        //出库
        private void btnOutStore_Click(object sender, EventArgs e)
        {
            dvOutStore.EndEdit();
            bsOutStore.EndEdit();
            for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
            {
                dsOutStore.Tables[0].Rows[i]["StoreAreaID"] = "S71N01";
            }
            for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
            {
                if (dsOutStore.Tables[0].Rows[i]["Target"].ToString() == "")
                {
                    MessageBox.Show("请选择去向！", "提示");
                    return;
                }
            }

            string check = MessageBox.Show("确认要出库么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdOutStore.Execute();
                String returnFlag = cmdOutStore.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("出库成功！", "提示");
                    dsOutStore.LoadData();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("出库不成功！错误代码为：" + returnFlag, "提示");
                    dsOutStore.LoadData();
                }
            }

        }
        //退出
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dvOutStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvOutStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BloomOutStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}