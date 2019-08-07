using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.TundishMag
{
    public partial class TundishAddShowFrm : Form
    {
        public TundishAddShowFrm()
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
            if (txtTundishNo.Text.Length == 4)
            {
                DataRow newrow = dsTundish.Tables[0].NewRow();
                newrow["TundishID"] = txtTundishNo.Text;
                newrow["Status"] = "10";
                if (cmbTundishType.Text == "")
                {
                    MessageBox.Show("��ѡ���а����ͣ�", "��ʾ");
                    return;
                }
                if(cmbTundishType.Text == "1#��2#��")
                {
                    newrow["TundishType"] = 1;
                }
                if(cmbTundishType.Text == "3#��4#��")
                {
                    newrow["TundishType"] = 2;
                }
                if (cmbTundishType.Text == "5#��")
                {
                    newrow["TundishType"] = 3;
                }
                //��ǰ 20110312 ����7#����ӦTundishType=4
                if (cmbTundishType.Text == "7#��")
                {
                    newrow["TundishType"] = 4;
                }
                //add by hyh 2012-06-08
                //��ǰ 20110312 ����7#����ӦTundishType=4
                if (cmbTundishType.Text == "6#��")
                {
                    newrow["TundishType"] = 5;
                }
                //end
                dsTundish.Tables[0].Rows.Add(newrow);
                if (dsTundish.UpdateData())
                {
                    MessageBox.Show("�����а��ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�����а�ʧ�ܣ�", "��ʾ");
                }
            }
            else
            {
                MessageBox.Show("��������а��Ų����Ϲ淶�����飡", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}