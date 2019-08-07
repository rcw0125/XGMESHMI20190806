using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.ScrapStore
{
    public partial class RollbackOutStoreFrm : DockContent, IMESForm
    {
        public RollbackOutStoreFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return this.ShowDialog();
        }

        //刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsOutStore.LoadData();
        }

        

        private void RollbackOutStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnCancelOutStore_Click(object sender, EventArgs e)
        {
            dvInStore.EndEdit();
            bsOutStore.EndEdit();
            cmdCancelOutStore.Execute();
            dsOutStore.LoadData();
            String returnFlag = cmdCancelOutStore.Command.Return.ToString();
            if (returnFlag == "1" && dsOutStore.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("取消出库成功！", "提示");
            }
            else
            {
                MessageBox.Show("取消出库不成功！", "提示");
            }
        }

    }
}