using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.AlloyStore
{
    public partial class AlloyAppConfirmFrm : DockContent, IMESForm
    {
        public AlloyAppConfirmFrm()
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

        private void AlloyAppConfirmFrm_Load(object sender, EventArgs e)
        {

        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvAlloyAppConfirm.EndEdit();
            bsAlloyAppConfirm.EndEdit();
            dsyAPPConfirm.AcceptChanges();
            string check = MessageBox.Show("要确认申请信息么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdAlloyAppConfirm.Execute();
                String returnFlag = cmdAlloyAppConfirm.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("确认申请信息成功！", "提示");
                    ds.LoadData();
                    
                }
                else
                {
                    MessageBox.Show("确认申请信息不成功！错误代码为：" + returnFlag, "提示");
                    ds.LoadData();
                }
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlloyAppConfirmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}