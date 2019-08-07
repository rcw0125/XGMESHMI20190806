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
    public partial class SteelExchangeQueryFrm : DockContent, IMESForm
    {
        public SteelExchangeQueryFrm()
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

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "";
            DateTime dtS = Convert.ToDateTime(dtNoteData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtNoteEndData.Text.Trim() + " 23:59:59");

            strSourceCondition = "App_Time between '" + dtS + "' and '" + dtE + "' and Ex_Flag = 1 order by App_Time asc";
            dsSteelExchange.SourceCondition = strSourceCondition;
        }

        //�ؼ�����
        private void SteelExchangeQueryFrm_Load(object sender, EventArgs e)
        {
            dtNoteData.Value = DateTime.Now;
            dtNoteEndData.Value = DateTime.Now;
        }


        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ĸ�������Ϣ", dvInStore);
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void SteelExchangeQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}