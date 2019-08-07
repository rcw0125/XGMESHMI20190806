using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class ProcessTimeFrm : DockContent, IMESForm
    {
        public ProcessTimeFrm()
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


        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "";
            DateTime dtS = Convert.ToDateTime(dtNoteData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtNoteEndData.Text.Trim() + " 23:59:59");
            strSourceCondition = "ProductDate between '" + dtS + "' and '" + dtE + "' order by ProductDate desc";
            dsProcessTime.SourceCondition = strSourceCondition;
        }

        //�ؼ�����
        private void ProcessTimeFrm_Load(object sender, EventArgs e)
        {
            dtNoteData.Value = DateTime.Now;
            dtNoteEndData.Value = DateTime.Now;
        }

        
                
        private void ProcessTimeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsProcessTime.Tables[0].NewRow();
            newrow["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd");
            newrow["ProductDate"] = DateTime.Now;
            dsProcessTime.Tables[0].Rows.Add(newrow);
        }

        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsProcessTime.RemoveCurrent();
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsProcessTime.LoadData();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvProcessTime.EndEdit();
            bsProcessTime.EndEdit();
            bool returnflag = dsProcessTime.UpdateData();
           if (returnflag)
           {
               MessageBox.Show("����ɹ���", "��ʾ", MessageBoxButtons.OK);
           }
           else
           {
               MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
           }
           dsProcessTime.LoadData();
        }

        private void dvDispAccount_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}