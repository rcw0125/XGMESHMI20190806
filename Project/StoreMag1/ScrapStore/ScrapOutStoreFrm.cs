using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.ScrapStore
{
    public partial class ScrapOutStoreFrm: Form
    {
        public ScrapOutStoreFrm()
        {
            InitializeComponent();
        }

        ScrapOutStoreShowFrm Frm = new ScrapOutStoreShowFrm();

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            this.ShowDialog();
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsScrapOutStore.Tables[0].NewRow();
            newrow["MaterialType"] = "CScrap_Data";
            dsScrapOutStore.Tables[0].Rows.Add(newrow);
            bsScrapOutStore.MoveLast();
            Frm.ShowDialogEx(Adapter.Session);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsScrapOutStore.RejectChanges();
            dsScrapOutStore.LoadData();
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsScrapOutStore.EndEdit();
            dsScrapOutStore.AcceptChanges();
            cmdScrapOutStore.Execute();
            dsScrapOutStore.LoadData();
            String returnFlag = cmdScrapOutStore.Command.Return.ToString();
            if (returnFlag == "1" )
            {
                MessageBox.Show("出库成功！", "提示");
            }
            else
            {
                MessageBox.Show("出库不成功！"  , "提示");
            }
            
        }

        private void ScrapOutStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}