using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    /// <summary>
    /// 真空槽处理操作类型
    /// </summary>
    public enum OperateType : int
    {
        /// <summary>
        /// 处理开始1
        /// </summary>
        OperateStart = 1,
        /// <summary>
        /// 处理结束2
        /// </summary>
        OperateEnd = 2,
        /// <summary>
        /// 下线检查3
        /// </summary>
        OperateCheck = 3,
    }

    public partial class VacTubeOnLineFrm : Form
    {
        public VacTubeOnLineFrm()
        {
            InitializeComponent();
        }

        public OperateType operatetype = OperateType.OperateStart;
        private string strConditonSql = "";
        private string strPosition = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            switch (operatetype)
            {
                case OperateType.OperateStart:
                    strConditonSql = " Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_HOT + "'";
                    btnConfrim.Text = "处理开始";
                    break;
                case OperateType.OperateEnd:
                    strConditonSql = " Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_USE + "'";
                    btnConfrim.Text = "处理结束";
                    break;
                case OperateType.OperateCheck:
                    strConditonSql = " Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_HOT + "'";
                    btnConfrim.Text = "下线检查";
                    break;
                default:
                    break;
            }
            dsBase.SourceMethod = "select vactube_code,install_id from cvactube_base where Position = 'aaaaa' and (vactube_name = '1' OR vactube_name = '2')  group by vactube_code,install_id";
          
            Adapter.Session = session;
            return ShowDialog();
        }

        private void VacTubeOnLineFrm_Load(object sender, EventArgs e)
        {
            rdbtnA.Checked = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (strPosition == "")
            {
                MessageBox.Show("请选择烘烤位置！", "提示");
                return;
            }

            if (txtVacTubeCode.Text.Trim() == "")
            {
                MessageBox.Show("没有真空槽编号！", "提示");
                return;
            }

            cmdpPositon.ConstantValue = strPosition;
            switch (operatetype)
            {
                case OperateType.OperateStart:
                    cmdOnLine.Parameters.Clear();
                    cmdOnLine.Parameters.Add(cmdpPositon);
                    if (cmdOnLine.Execute() >= 0)
                    {
                        if (Convert.ToInt32(cmdOnLine.Command.Return) > 0)
                        {
                            MessageBox.Show(btnConfrim.Text + "成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show(btnConfrim.Text + "失败！", "提示");
                    }
                    break;
                case OperateType.OperateEnd:
                    cmdOffLine.Parameters.Clear();
                    cmdOffLine.Parameters.Add(cmdpPositon);
                    if (cmdOffLine.Execute() >= 0)
                    {
                        if (Convert.ToInt32(cmdOffLine.Command.Return) > 0)
                        {
                            MessageBox.Show(btnConfrim.Text + "成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show(btnConfrim.Text + "失败！", "提示");
                    }
                    break;
                case OperateType.OperateCheck:
                    cmdCheck.Parameters.Clear();
                    cmdCheck.Parameters.Add(cmdpPositon);
                    if (cmdCheck.Execute() >= 0)
                    {
                        if (Convert.ToInt32(cmdCheck.Command.Return) > 0)
                        {
                            MessageBox.Show(btnConfrim.Text + "成功！", "提示");
                            this.Close();
                        }
                        else
                            MessageBox.Show(btnConfrim.Text + "失败！", "提示");
                    }
                    break;
                default:
                    break;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "RadioButton")
                return;
            RadioButton rdbtn = (RadioButton)sender;
            if (!rdbtn.Checked)
                strPosition = "";
            else
                strPosition = rdbtn.Tag.ToString();
            dsBase.SourceMethod = "select vactube_code,install_id from cvactube_base where Position = '"
                + strPosition + "' and  " + strConditonSql
                + " and (vactube_name = '1' OR vactube_name = '2') and status > '04' and status < '07' group by vactube_code,install_id";
            if (dsBase.Tables[0].Rows.Count < 1)
                btnConfrim.Enabled = false;
            else
                btnConfrim.Enabled = true;
        }
    }
}