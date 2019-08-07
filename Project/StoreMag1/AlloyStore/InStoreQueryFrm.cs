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
    public partial class InStoreQueryFrm : DockContent, IMESForm
    {
        public InStoreQueryFrm()
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

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtInStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtInStoreEndData.Text.Trim() + " 23:59:59");
            string strAlloyCode = CommDataMag.CommonMethed.GetStrCodeByDesc(dsAlloyCode, cmbAlloyCode.Text.ToString());
            dsInStore.SourceCondition = "1=2";
            if (cmbAlloyCode.Text != "")
            {
                dsInStore.SourceCondition = "LOGDATE between '" + dtS + "' and '" + dtE + "' and Alloy_Code = '" + strAlloyCode + "' order by LOGDATE desc";
            }
            else
            {
                dsInStore.SourceCondition = "LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
            }
        }

        //控件加载
        private void InStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
            //2009-08-31 sun
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
            CommDataMag.CommonMethed.PutIntoExcel("合金入库信息", dvInStore);
        }

        private void InStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsInStore.Position < 0)
                    return;

                dvInStore.CurrentRow.Cells["Name1"].Value = "1";

                dvInStore.EndEdit();
                bsInStore.EndEdit();

                bool bbb = dsInStore.UpdateData();
                dsInStore.LoadData();
            }
            catch { }
        }

        private void dvInStore_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dsInStore.Tables[0].Rows.Count; i++)
            {
                if (dvInStore.Rows[i].Cells["Name1"].Value.ToString() == "1")
                {
                    dvInStore.Rows[i].Cells["LogDate"].ReadOnly = true;
                    dvInStore.Rows[i].Cells["Alloy_Code"].Style.BackColor = Color.Green;
                    dvInStore.Rows[i].Cells["Alloy_Code"].Style.SelectionBackColor = Color.Yellow;
                    dvInStore.Rows[i].Cells["Alloy_Code"].Style.SelectionForeColor = Color.Black;
                }
            }
        }
    }
}