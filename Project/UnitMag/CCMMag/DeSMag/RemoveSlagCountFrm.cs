using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class RemoveSlagCountFrm : Form
    {
        public RemoveSlagCountFrm()
        {
            InitializeComponent();
        }

        private string IorII = "";
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData,string UnitID)
        {
            Adapter.Session = session;
            txtTAPNo.Text = dsData.Tables[0].Rows[0]["TAP_No"].ToString();
            txtTPCNo.Text = dsData.Tables[0].Rows[0]["TPC_No"].ToString();
            dsIronsInfo.SourceCondition = "MaterialID = '" + dsData.Tables[0].Rows[0]["MaterialID"].ToString()  + "'";
            IorII = UnitID;
            this.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsIronsIfo.EndEdit();
            if (dsIronsInfo.UpdateData())
            {
                MessageBox.Show("�޸ĳɹ���", "��ʾ");
                this.Close();
            }
            else
            {
                MessageBox.Show("�޸�ʧ�ܣ�", "��ʾ");
            }
        }

        private void RemoveSlagCountFrm_Load(object sender, EventArgs e)
        {
            txtRemoveSlagCount.TextChanged += new EventHandler(txtRemoveSlagCount_TextChanged);
            if (dsIronsInfo.Tables[0].Rows.Count > 1)
            {
                MessageBox.Show("���ݿ���������ͬ��ˮ���ݣ������޸ģ�" , "��ʾ");
                this.Close();
            }
            //if (dsIronsInfo.Tables[0].Rows[0]["Des_UnitID"].ToString() != IorII)
            //{
            //    MessageBox.Show("����λ�������޸Ĵ���ˮ���ݣ��������λ������", "��ʾ");
            //    this.Close();
            //}

        }

        private void txtRemoveSlagCount_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}