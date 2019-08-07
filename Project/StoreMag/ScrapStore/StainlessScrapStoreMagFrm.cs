using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using StoreMag.ScrapStore;

namespace StoreMag.ScrapStore
{
    public partial class StainlessScrapStoreMagFrm : DockContent, IMESForm
    {
        public StainlessScrapStoreMagFrm()
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

        private InStoreQueryFrm InStoreQuery = new InStoreQueryFrm();
        private OutStoreQueryFrm OutStoreQuery = new OutStoreQueryFrm();

        private void StainlessScrapStoreMagFrm_Load(object sender, EventArgs e)
        {
            l3cmdpScrap.ConstantValue = "";
        }

        //���
        private void btnInStore_Click(object sender, EventArgs e)
        {
            ScrapInStoreFrm frm = new ScrapInStoreFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //����
        private void btnOutStore_Click(object sender, EventArgs e)
        {
            //ScrapOutStoreShowFrm frm = new ScrapOutStoreShowFrm();
            StainlessScrapOutStoreShowFrm frm = new   StainlessScrapOutStoreShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //�̿�
        private void btnBalanceStore_Click(object sender, EventArgs e)
        {
            //ֻѡһ������
            int checkCount = 0;
            dvM.EndEdit();
            bsScrap.EndEdit();
            for (int i = 0; i < dsScrap.Tables[0].Rows.Count; i++)
            {
                if (dvM.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("ֻ��ѡһ������", "��ʾ");
            }
            else
            {
                dsScrapSend.Tables[0].Clear();
                dsScrapSend.Tables[0].ImportRow(dsScrap.Tables[0].Select("CheckFlag = '1'")[0]);
                ScrapBalanceFrm frm = new ScrapBalanceFrm();
                frm.ShowDialogEx(Adapter.Session, dsScrapSend);
            }
        }

        private void cmbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        //EXCEL����
        private void btnScarpInformationInput_Click(object sender, EventArgs e)
        {
             ScrapInformationInputFrm frm = new ScrapInformationInputFrm();
             frm.ShowDialogEx(Adapter.Session);
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //����ѯ
        private void btnInStoreQuery_Click(object sender, EventArgs e)
        {
            InStoreQuery.ShowDialogEx(Adapter.Session);
        }

        //�����ѯ
        private void btnOutStoreQuery_Click(object sender, EventArgs e)
        {
            OutStoreQuery.ShowDialogEx(Adapter.Session);
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void l3dbxGetStore_TextChanged(object sender, EventArgs e)
        {
            dsScrap.L3DataAdapter = Adapter;
            dsScrap.LoadData();
        }

        private void StainlessScrapStoreMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnCancelOutStore_Click(object sender, EventArgs e)
        {
            RollbackStainlessOutStoreFrm frm = new RollbackStainlessOutStoreFrm();
            frm.ShowDialogEx(Adapter.Session);
        }
    }
}