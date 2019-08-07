using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeAddShowFrm : Form
    {
        public VacTubeAddShowFrm()
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
            if (cmbType.Text == "�ϲ���" || cmbType.Text == "�²���")
            {
                if (txtVacTubeNo.Text.Length == 4)
                {
                    DataRow newrow = dsVacTube.Tables[0].NewRow();
                    newrow["VacTube_ID"] = txtVacTubeNo.Text.Trim();
                    newrow["Status"] = CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE;
                    newrow["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_BUILD;
                    if (cmbType.Text == "�ϲ���")
                    {
                        newrow["VacTube_Name"] = "1";
                    }
                    if (cmbType.Text == "�²���")
                    {
                        newrow["VacTube_Name"] = "2";
                    }
                    dsVacTube.Tables[0].Rows.Add(newrow);
                    if (dsVacTube.UpdateData())
                    {
                        MessageBox.Show("�����ɹ���", "��ʾ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                    }
                }
                else
                {
                    MessageBox.Show("������ı�Ų����Ϲ淶�����飡", "��ʾ");
                }
            }

            if (cmbType.Text == "�����")
            {
                if (txtVacTubeNo.Text.Length == 3)
                {
                    DataRow newrow = dsVacTube.Tables[0].NewRow();
                    newrow["VacTube_ID"] = txtVacTubeNo.Text.Trim();
                    newrow["Status"] = CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE;
                    newrow["VacTube_Name"] = "3";
                    newrow["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_BUILD;
                    dsVacTube.Tables[0].Rows.Add(newrow);
                    if (dsVacTube.UpdateData())
                    {
                        MessageBox.Show("�����ɹ���", "��ʾ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                    }
                }
                else
                {
                    MessageBox.Show("������ı�Ų����Ϲ淶�����飡", "��ʾ");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "�ϲ���")
            {
                txtVacTubeNo.Mask = @"ZS99";
            }
            if (cmbType.Text == "�²���")
            {
                txtVacTubeNo.Mask = @"ZX99";
            }
            if (cmbType.Text == "�����")
            {
                txtVacTubeNo.Mask = @"R99";
            }
        }
    }
}