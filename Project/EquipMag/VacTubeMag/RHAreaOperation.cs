using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class RHAreaOperation : Form
    {
        public RHAreaOperation()
        {
            InitializeComponent();
        }

        private DataSet dsCur = new DataSet();
        private int iStart = 0;//0为处理开始，1为处理结束
        public DialogResult ShowDialogEx(AppSvrIF.Session session,DataSet ds,int i)
        {
            Adapter.Session = session;
            iStart = i;//
            if (iStart == 0)
                btnConfirm.Text = "处理开始";
            else
                btnConfirm.Text = "处理结束";
          
            dsCur = ds.Clone();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dsCur.Tables[0].ImportRow(dr);
            }
            dsCur.AcceptChanges();
            rbAreaA.Checked = true;

            return ShowDialog();
        }

        private void rbAreaA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAreaA.Checked)
                {
                    txtUp.Text = dsCur.Tables[0].Select("Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "' and VacTube_Name = '1'")[0]["Vactube_ID"].ToString();
                    txtDown.Text = dsCur.Tables[0].Select("Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "' and VacTube_Name = '2'")[0]["Vactube_ID"].ToString();
                }
                else
                {
                    txtUp.Text = dsCur.Tables[0].Select("Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "' and VacTube_Name = '1'")[0]["Vactube_ID"].ToString();
                    txtDown.Text = dsCur.Tables[0].Select("Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "' and VacTube_Name = '2'")[0]["Vactube_ID"].ToString();
                }
            }
            catch 
            {
                txtUp.Text = "";
                txtDown.Text = "";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (iStart == 0)
            {
                if (rbAreaA.Checked)
                    l3cmdpOnLine.ConstantValue = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A;
                else
                    l3cmdpOnLine.ConstantValue = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B;
                if (txtUp.Text == "" || txtDown.Text == "")
                {
                    MessageBox.Show("当前所选工位没有真空槽！", "提示");
                    return;
                }

                if (cmdOnLine.Execute() >= 0)
                {
                    if (Convert.ToInt16(cmdOnLine.Command.Return) > 0)
                    {
                        MessageBox.Show("处理开始成功！", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                        MessageBox.Show("处理开始失败！", "提示", MessageBoxButtons.OK);
                }

                else
                    MessageBox.Show("处理开始失败！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (rbAreaA.Checked)
                    l3cmdpOffLine.ConstantValue = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A;
                else
                    l3cmdpOffLine.ConstantValue = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B;

                if (txtUp.Text == "" || txtDown.Text == "")
                {
                    MessageBox.Show("当前所选工位没有真空槽！", "提示");
                    return;
                }
                if (cmdOffLine.Execute() >= 0)
                {
                    if (Convert.ToInt16(cmdOffLine.Command.Return) > 0)
                    {
                        MessageBox.Show("处理结束成功！", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                        MessageBox.Show("处理结束失败！", "提示", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("处理结束失败！", "提示", MessageBoxButtons.OK);
            }

        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}