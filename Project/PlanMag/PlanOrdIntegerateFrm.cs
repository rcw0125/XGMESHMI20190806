using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace PlanMag
{
    public partial class PlanOrdIntegerateFrm : DockContent, IMESForm
    {
        public PlanOrdIntegerateFrm()
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

        private void PlanOrdIntegerateFrm_Load(object sender, EventArgs e)
        {
            tstdtpCreateDate.Value = DateTime.Now;
        }

        //�ճ�
        private void tsbtIntegerate_Click(object sender, EventArgs e)
        {
            dvIntegernate.EndEdit();
            bsIntegernate.EndEdit();
            string check = MessageBox.Show("Ҫ�ճ���ѡ�ƻ�ô��", "��ʾ",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdIntegernateCfm.Execute();
                dsIntegernate.LoadData();
                String returnFlag = cmdIntegernateCfm.Command.Return.ToString();
                if (returnFlag == "1" )
                {
                    MessageBox.Show("�ճسɹ���", "��ʾ");
                }
                else
                {
                    MessageBox.Show("�ճز��ɹ���", "��ʾ");
                }
            }
            else
            {
                dsIntegernate.LoadData();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanOrdIntegerateFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}