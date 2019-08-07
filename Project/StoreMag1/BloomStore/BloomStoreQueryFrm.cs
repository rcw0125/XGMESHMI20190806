using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.BloomStore
{
    public partial class BloomStoreQueryFrm : DockContent, IMESForm
    {
        public BloomStoreQueryFrm()
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
            dsQuery.L3DataAdapter = Adapter;
            dsQuery.LoadData();

        }

        private void BloomStoreQueryFrm_Load(object sender, EventArgs e)
        {
            cmbStoreID.Items.Clear();
            for (int i = 0; i < dsStoreAreaID.Tables[0].Rows.Count; i++)
            {
                cmbStoreID.Items.Add(dsStoreAreaID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void cmbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStoreAreaID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsStoreAreaID, cmbStoreID.SelectedItem.ToString());
            
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvQuery_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BloomStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnOutEXL_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢坯库存信息", dvQuery);
        }

    }
}