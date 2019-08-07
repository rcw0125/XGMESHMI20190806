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

        private void AlloyAppConfirmFrm_Load(object sender, EventArgs e)
        {

        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvAlloyAppConfirm.EndEdit();
            bsAlloyAppConfirm.EndEdit();
            dsyAPPConfirm.AcceptChanges();
            string check = MessageBox.Show("Ҫȷ��������Ϣô��", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdAlloyAppConfirm.Execute();
                String returnFlag = cmdAlloyAppConfirm.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("ȷ��������Ϣ�ɹ���", "��ʾ");
                    ds.LoadData();
                    
                }
                else
                {
                    MessageBox.Show("ȷ��������Ϣ���ɹ����������Ϊ��" + returnFlag, "��ʾ");
                    ds.LoadData();
                }
            }
        }

        //�˳�
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