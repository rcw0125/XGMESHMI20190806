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
    public partial class InStoreQueryFrm : DockContent, IMESForm
    {
        public InStoreQueryFrm()
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
            DateTime dtS = Convert.ToDateTime(dtInStoreData.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtInStoreEndData.Text.Trim() + " 23:59:59");

            if (txtHeatID.Text.Length != 9)
            {
                double dDateLength = Math.Round((dtInStoreEndData.Value.ToOADate() - dtInStoreData.Value.ToOADate() + 1), 0);
                if (dDateLength > 7)
                {
                    MessageBox.Show("���ѯʱ������һ�����ڵ����ݣ�", "��ʾ");
                    return;
                }
                if (txtHeatID.Text == "")
                {
                    if (cmbCasterID.Text == "")
                        dsInStore.SourceMethod = "select * from VIEW_BLOOM_INPUT_LOG where LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
                    else
                        dsInStore.SourceMethod = "select * from VIEW_BLOOM_INPUT_LOG where LOGDATE between '" + dtS + "' and '" + dtE + "' and CasterID = '" + cmbCasterID.Text + "' order by LOGDATE desc";
                }
                else
                    dsInStore.SourceMethod = "select * from VIEW_BLOOM_INPUT_LOG where MaterialID like '%" + txtHeatID.Text.Trim() + "%' and  LOGDATE between '" + dtS + "' and '" + dtE + "' order by LOGDATE desc";
            }
            else
                dsInStore.SourceMethod = "select * from VIEW_BLOOM_INPUT_LOG where MaterialID = '" + txtHeatID.Text.Trim() + "'";

            dsInStore.LoadData();
        }

        //�ؼ�����
        private void InStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtInStoreData.Value = DateTime.Now;
            dtInStoreEndData.Value = DateTime.Now;
        }

        private void dvInStore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        //������Excel
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("���������Ϣ", dvInStore);
        }

        private void InStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvInStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}