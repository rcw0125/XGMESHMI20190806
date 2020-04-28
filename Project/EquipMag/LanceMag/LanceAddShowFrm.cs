using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.LanceMag
{
    public partial class LanceAddShowFrm : Form
    {
        public LanceAddShowFrm()
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
            if (cmbBOFID.Text == "")
            {
                MessageBox.Show("��ѡ��ʹ��ת¯��", "��ʾ");
                return;
            }
            if (txtLanceNoA.Text.Length != 4)
            {
                MessageBox.Show("���������ǹ�Ų����Ϲ淶�����飡", "��ʾ");
                return;
            }

            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceID"] = txtLanceNoA.Text;
            newrow["Status"] = "05";
            newrow["Lance_Head_Type"] = txtLanceHeadType.Text;
            dsLance.Tables[0].Rows.Add(newrow);
            if (dsLance.UpdateData())
            {
                MessageBox.Show("������ǹ�ɹ���", "��ʾ");
                this.Close();
            }
            else
            {
                MessageBox.Show("������ǹʧ�ܣ������Ƿ����ǹ�Ѵ���", "��ʾ");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBOFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbBOFID.Text == "1#ת¯")
            //{
            //    txtLanceNoA.Mask = "YB99";
            //    txtLanceHeadType.Text = "��180";
            //}
            //if (cmbBOFID.Text == "2#ת¯" || cmbBOFID.Text == "3#ת¯")
            //{
            //    txtLanceNoA.Mask = @"Y\A99";
            //    txtLanceHeadType.Text = "��168";
            //}
            //if (cmbBOFID.Text == "4#ת¯")
            //{
            //    txtLanceNoA.Mask = @"Y\C99";
            //    txtLanceHeadType.Text = "��219";
            //}


            //if (cmbBOFID.Text == "1#ת¯")
            //{
            //    txtLanceNoA.Mask = "YB99";
            //    txtLanceHeadType.Text = "��180";
            //}
            if (cmbBOFID.Text == "1#ת¯"||cmbBOFID.Text == "2#ת¯" || cmbBOFID.Text == "3#ת¯")
            {
                txtLanceNoA.Mask = @"Y\A99";
                txtLanceHeadType.Text = "��180";
            }
            if (cmbBOFID.Text == "4#ת¯")
            {
                txtLanceNoA.Mask = @"Y\B99";
                txtLanceHeadType.Text = "��219";
            }
            if (cmbBOFID.Text == "AOD¯")
            {
                txtLanceNoA.Mask = @"Y\C99";
                txtLanceHeadType.Text = "��AOD";
            }
        }
    }
}