using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace EquipMag.LadleMag
{
    public partial class LadleAddShowFrm : Form
    {
        public LadleAddShowFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string IronLadleNo = txtIronLadleNo.Text.Trim();
            DataRow newrow = dsLadle.Tables[0].NewRow();
            newrow["LadleID"] = IronLadleNo;
            newrow["Status"] = "10";
            if (cmbLadleType.Text.Trim() == "")
            {
                MessageBox.Show("��ѡ��ְ����ͣ�", "��ʾ");
                return;
            }
            newrow["LadleType"] = cmbLadleType.SelectedValue;
            if (cmbLadleType.SelectedValue.ToString() == "3")
            {
                newrow["New_BOF_Flag"] = "1";
            }
            dsLadle.Tables[0].Rows.Add(newrow);
            if (dsLadle.UpdateData())
            {
                MessageBox.Show("�����ְ��ɹ���", "��ʾ");
                this.Close();
            }
            else
            {
                MessageBox.Show("�����ְ�ʧ�ܣ�", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}