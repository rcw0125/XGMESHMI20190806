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
            if (cmbType.Text == "上部槽" || cmbType.Text == "下部槽")
            {
                if (txtVacTubeNo.Text.Length == 4)
                {
                    DataRow newrow = dsVacTube.Tables[0].NewRow();
                    newrow["VacTube_ID"] = txtVacTubeNo.Text.Trim();
                    newrow["Status"] = CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE;
                    newrow["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_BUILD;
                    if (cmbType.Text == "上部槽")
                    {
                        newrow["VacTube_Name"] = "1";
                    }
                    if (cmbType.Text == "下部槽")
                    {
                        newrow["VacTube_Name"] = "2";
                    }
                    dsVacTube.Tables[0].Rows.Add(newrow);
                    if (dsVacTube.UpdateData())
                    {
                        MessageBox.Show("新增成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("新增失败！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的编号不符合规范，请检查！", "提示");
                }
            }

            if (cmbType.Text == "热弯管")
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
                        MessageBox.Show("新增成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("新增失败！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的编号不符合规范，请检查！", "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "上部槽")
            {
                txtVacTubeNo.Mask = @"ZS99";
            }
            if (cmbType.Text == "下部槽")
            {
                txtVacTubeNo.Mask = @"ZX99";
            }
            if (cmbType.Text == "热弯管")
            {
                txtVacTubeNo.Mask = @"R99";
            }
        }
    }
}