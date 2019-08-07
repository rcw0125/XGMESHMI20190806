using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BloomStore
{
    public partial class BloomOnStoreMagFrm : Form
    {
        public BloomOnStoreMagFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloomOnStoreMagFrm_Load(object sender, EventArgs e)
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

        //���
        private void btnQualityCheck_Click(object sender, EventArgs e)
        {
            dvQualityCheck.EndEdit();
            bsQualityCheck.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫ���ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBloomFinish.Execute();
                String returnFlag = cmdBloomFinish.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("���ɹ���", "��ʾ");
                }
                else
                {
                    MessageBox.Show("��鲻�ɹ����������Ϊ��" + returnFlag, "��ʾ");
                }
            }
        }

        BloomSpileChangeFrm frmSpileChange = new BloomSpileChangeFrm();
        
        //��λ���
        private void btnSpileChange_Click(object sender, EventArgs e)
        {
            dvQualityCheck.EndEdit();
            bsQualityCheck.EndEdit();
            dsSpileChangeSend.Clear();
            for (int i = 0; i < dsQualityCheck.Tables[0].Rows.Count; i++)
            {
                if (dsQualityCheck.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsSpileChangeSend.Tables[0].ImportRow(dsQualityCheck.Tables[0].Rows[i]);
                }
            }
            frmSpileChange.ShowDialogEx(Adapter.Session, dsSpileChangeSend);
        }
        BloomOutStoreFrm frmOutStore = new BloomOutStoreFrm();
        
        //����
        private void btnOutStore_Click(object sender, EventArgs e)
        {
            dvQualityCheck.EndEdit();
            bsQualityCheck.EndEdit();
            dsOutStoreSend.Clear();
            for (int i = 0; i < dsQualityCheck.Tables[0].Rows.Count; i++)
            {
                if (dsQualityCheck.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsOutStoreSend.Tables[0].ImportRow(dsQualityCheck.Tables[0].Rows[i]);
                }
            }
            frmOutStore.ShowDialogEx(Adapter.Session, dsOutStoreSend);
        
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsQualityCheck.L3DataAdapter = Adapter;
            dsQualityCheck.LoadData();
        }

        private void dvQualityCheck_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //[20090105]
        private void l3dbxGetStore_TextChanged(object sender, EventArgs e)
        {
            dsQualityCheck.L3DataAdapter = Adapter;
            dsQualityCheck.LoadData();
        }

        private void BloomOnStoreMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}