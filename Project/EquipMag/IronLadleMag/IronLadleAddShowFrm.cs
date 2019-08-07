using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleAddShowFrm : Form
    {
        public IronLadleAddShowFrm()
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
            //�ж��������Ƿ�Ϊ"T99"��ʽ
            if (IronLadleNo.Length == 3)
            {
                DataRow newrow = dsIronLadle.Tables[0].NewRow();
                newrow["IronLadleID"] = IronLadleNo;
                newrow["Status"] = "10";
                dsIronLadle.Tables[0].Rows.Add(newrow);
                if (dsIronLadle.UpdateData())
                {
                    MessageBox.Show("���������ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("��������ʧ�ܣ�", "��ʾ");
                }
            }
            else
            {
                MessageBox.Show("������������Ų����Ϲ淶�����飡", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}