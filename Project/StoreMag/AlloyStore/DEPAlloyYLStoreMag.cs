//����4#LF�Ͻ�ԭ�Ͽ������� add by hyh 2012-06-06
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
    public partial class DEPAlloyYLStoreMag : DockContent, IMESForm
    {
        public DEPAlloyYLStoreMag()
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
        private AlloyBalanceFrm AlloyBalance = new AlloyBalanceFrm();
        private AlloyChangeFrm AlloyChange = new AlloyChangeFrm();
        private InStoreQueryFrm InStoreQuery = new InStoreQueryFrm();
        private OutStoreQueryFrm OutStoreQuery = new OutStoreQueryFrm();
        private AlloyOutStoreFrm OutStore = new AlloyOutStoreFrm();
        private AlloyRollBackFrm RollBack = new AlloyRollBackFrm();

        private void LF4AlloyYLStoreMag_Load(object sender, EventArgs e)
        {
            //��������
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvLFPublic);

        }
    
        //�Ͻ�ά��
        private void btnDefend_Click(object sender, EventArgs e)
        {
            AlloyAndAreaMapFrm frm = new AlloyAndAreaMapFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //�Ͻ�����
        private void btnApp_Click(object sender, EventArgs e)
        {
            AlloyAppFrm frm = new AlloyAppFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //�Ͻ�����
        private void btnInStore_Click(object sender, EventArgs e)
        {
            AlloyInStoreFrm frm = new AlloyInStoreFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ToolTipText
       

        //����ɼ��Ըı�
        private void AlloyStoreRHMag_VisibleChanged(object sender, EventArgs e)
        {

        }

        //�رմ���
        private void AlloyStoreRHMag_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //�Ͻ���Ϣ����
        private void btnAlloyInput_Click(object sender, EventArgs e)
        {
            AlloyInformationInputFrm frm = new AlloyInformationInputFrm();
            frm.ShowDialogEx(Adapter.Session);

        }


        //�̿�
        private void tsbtnLFPublicBanlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLFPublicChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
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

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //ԤԼ������¼�,ˢ�½������ݼ�dsStore[20090105Liao]
        private void l3dbxGetStore_TextChanged(object sender, EventArgs e)
        {
            dsStore.LoadData();
        }

        private void AlloyStoreRHMag_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void tsbtnLFPublicClear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("�˲�������ո��ϲ����������ݣ��Ƿ���գ�", "��ʾ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("�����ɹ���", "��ʾ");
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("�������ɹ�!", "��ʾ");
                    }
                }
            }
        }


 





      


      
    }
}