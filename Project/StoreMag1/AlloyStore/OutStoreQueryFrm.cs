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
    public partial class OutStoreQueryFrm : DockContent, IMESForm
    {
        public OutStoreQueryFrm()
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
            DateTime dtS = Convert.ToDateTime(dtOutStore.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            int iType = CommDataMag.CommonMethed.GetIntCodeByDesc(OutType,cmbType.Text.Trim());
            string strAlloyCode = CommDataMag.CommonMethed.GetStrCodeByDesc(dsAlloyCode, cmbAlloyCode.Text.ToString());
            dsOutStore.SourceCondition = "1=2";
            if (txtHeatID.Text.Trim() == "")
            {
                if (cmbAlloyCode.Text == "")
                {
                    if (txtUnitID.Text.Trim() == "")
                    {
                        if (cmbType.Text == "")
                                dsOutStore.SourceCondition = "LOGDATE  between  '" + dtS + "' and  '" + dtE + "' order by LOGDATE desc";
                        else
                            dsOutStore.SourceCondition = "LOGDATE  between  '" + dtS + "' and '" + dtE + "'  and Type = '" + iType + "' order by LOGDATE desc";
                    }
                    else
                    {
                        if (cmbType.Text == "")
                            dsOutStore.SourceCondition = "UnitID = '" + txtUnitID.Text.Trim() + "' and LOGDATE  between  '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
                        else
                            dsOutStore.SourceCondition = "UnitID = '" + txtUnitID.Text.Trim() + "' and LOGDATE  between  '" + dtS + "'and '" + dtE + "' and Type = '" + iType + "' order by LOGDATE desc";
                    }
                }
                else
                {
                    if (txtUnitID.Text.Trim() == "")
                    {
                        if (cmbType.Text == "")
                            dsOutStore.SourceCondition = "LOGDATE  between  '" + dtS + "' and  '" + dtE + "' and Alloy_Code = '"+strAlloyCode+"' order by LOGDATE desc";
                        else
                            dsOutStore.SourceCondition = "LOGDATE  between  '" + dtS + "' and '" + dtE + "'  and Type = '" + iType + "' and Alloy_Code = '"+strAlloyCode+"' order by LOGDATE desc";
                    }
                    else
                    {
                        if (cmbType.Text == "")
                            dsOutStore.SourceCondition = "UnitID = '" + txtUnitID.Text.Trim() + "' and Alloy_Code = '"+strAlloyCode+"' and LOGDATE  between  '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
                        else
                            dsOutStore.SourceCondition = "UnitID = '" + txtUnitID.Text.Trim() + "'and Alloy_Code = '"+strAlloyCode+"' and LOGDATE  between  '" + dtS + "'and '" + dtE + "' and Type = '" + iType + "' order by LOGDATE desc";
                    }
                }
            }
            else
                dsOutStore.SourceCondition = "Target like '%" + txtHeatID.Text.Trim() + "%' order by LOGDATE desc";
        }

        //控件加载
        private void OutStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStore.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
            for (int i = 0; i < dsUnitID.Tables[0].Rows.Count; i++)
            {
                cmbUnitID.Items.Add(dsUnitID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
            cmbUnitID.Items.Add("");
            for (int i = 0; i < OutType.Tables[0].Rows.Count; i++)
            {
                cmbType.Items.Add(OutType.Tables[0].Rows[i]["Code_Des"].ToString());
            }
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
            CommDataMag.CommonMethed.PutIntoExcel("合金出库信息", dvInStore);
        }

        private void OutStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsOutStore.Position < 0)
                    return;

                dvInStore.CurrentRow.Cells["Name1"].Value = "1";

                dvInStore.EndEdit();
                bsOutStore.EndEdit();

                bool bbb = dsOutStore.UpdateData();
                dsOutStore.LoadData();
            }
            catch { }
        }

        private void dvInStore_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
                {
                    if (dvInStore.Rows[i].Cells["Name1"].Value.ToString() == "1")
                    {
                        dvInStore.Rows[i].Cells["LogDate"].ReadOnly = true;
                        dvInStore.Rows[i].Cells["alloyCodeDataGridViewTextBoxColumn"].Style.BackColor = Color.Green;
                        dvInStore.Rows[i].Cells["alloyCodeDataGridViewTextBoxColumn"].Style.SelectionBackColor = Color.Yellow;
                        dvInStore.Rows[i].Cells["alloyCodeDataGridViewTextBoxColumn"].Style.SelectionForeColor = Color.Black;
                    }
                }
            }
            catch { }
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsUnitID, cmbUnitID.SelectedItem.ToString());
        }
    }
}