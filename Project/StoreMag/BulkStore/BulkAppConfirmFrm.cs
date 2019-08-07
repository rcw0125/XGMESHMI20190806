using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.BulkStore
{
    public partial class BulkAppConfirmFrm : DockContent, IMESForm
    {
        public BulkAppConfirmFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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

        private void BulkAppConfirmFrm_Load(object sender, EventArgs e)
        {

        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBulkAppConfirm.EndEdit();
            bsBulkAppConfirm.EndEdit();
            dsyAPPConfirm.AcceptChanges();
            string check = MessageBox.Show("Ҫȷ��������Ϣô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBulkAppConfirm.Execute();
                String returnFlag = cmdBulkAppConfirm.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("ȷ��������Ϣ�ɹ���", "��ʾ");
                    dsyAPPConfirm.LoadData();                    
                }
                else
                {
                    MessageBox.Show("ȷ��������Ϣ���ɹ���" , "��ʾ");
                    ds.LoadData();
                }
            }
        }
        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BulkAppConfirmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}