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
    public partial class TransQueryFrm : DockContent, IMESForm
    {
        public TransQueryFrm()
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
            DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            string strAlloyCode = CommDataMag.CommonMethed.GetStrCodeByDesc(dsAlloyCode, cmbAlloyCode.Text.ToString());
            if (cmbAlloyCode.Text == "")
            {
                dsTrans.SourceCondition = "Trans_Date between '" + dtS + "' and '" + dtE + "' order by Trans_Date desc";
            }
            else
            {
                dsTrans.SourceCondition = "Alloy_Code = '" + strAlloyCode + "' and Trans_Date between '" + dtS + "' and '" + dtE + "' order by Trans_Date desc";
            }
            dsTrans.L3DataAdapter = Adapter;
            dsTrans.L3DataAdapter = null;
        }

        //�ؼ�����
        private void TransQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
            for (int i = 0; i < dsAlloyCode.Tables[0].Rows.Count; i++)
            {
                cmbAlloyCode.Items.Add(dsAlloyCode.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�Ͻ�ת����Ϣ", dvInStore);
        }

        private void TransQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}