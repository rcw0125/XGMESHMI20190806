using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.ScrapStore
{
    public partial class ScrapInStoreComfirmFrm : Form
    {
        public ScrapInStoreComfirmFrm()
        {
            InitializeComponent();
        }

        private string strMaterialType = "";
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsScrapInStoreConfirm.Tables[0].Clear();
            dsScrapInStoreConfirm.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            strMaterialType = dsData.Tables[0].Rows[0]["MATERIALID"].ToString();
            if (strMaterialType == "PigIron")
            {
                lbStoreArea.Text = "��������";
            } 
            else
            {
                lbStoreArea.Text = "�ϸֿ���";
            }
            this.ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsScrapInStoreComfirmFrm.EndEdit();
            if (strMaterialType == "PigIron")
            {
                dsScrapInStoreConfirm.Tables[0].Rows[0]["StoreAreaID"] = "S82A02";
            } 
            else
            {
                dsScrapInStoreConfirm.Tables[0].Rows[0]["StoreAreaID"] = "S82A01";
            }
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdScrapInStoreConfirm.Execute();
                String returnFlag = cmdScrapInStoreConfirm.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("���ϳɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���ϲ��ɹ���", "��ʾ");
                }
            }
        }

        //ȡ��
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsScrapInStoreComfirmFrm_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ScrapInStoreComfirmFrm_Load(object sender, EventArgs e)
        {
            txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void ScrapInStoreComfirmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}