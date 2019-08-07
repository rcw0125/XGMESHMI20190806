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
    /// ����������
    /// </summary>
    public enum CheckOverType : int
    {
       /// <summary>
        /// ��Ϊ�䱸1
       /// </summary>
        ToCold = 1,
        /// <summary>
        /// ��ΪС��2
        /// </summary>
        ToRepair = 2,
        /// <summary>
        /// ��������3
        /// </summary>
        ToBuild = 3,
    }

    public partial class VacTubeOffLineFrm : Form
    {
        public VacTubeOffLineFrm()
        {
            InitializeComponent();
        }

        public CheckOverType checkovertype = CheckOverType.ToBuild;

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            string strSQL = "";
            switch (checkovertype)
            {
                case CheckOverType.ToCold:
                    btnConfrim.Text = "��Ϊ�䱸";
                    cmdpCheckType.ConstantValue = "1";
                    strSQL = "  SELECT   vactube_code                                              ";
                    strSQL += "    FROM (SELECT   vactube_code                                      ";
                    strSQL += "              FROM cvactube_base                                     ";
                    strSQL += "             WHERE status = '07'                                     ";
                    strSQL += "               AND (vactube_name = '1' OR vactube_name = '2')        ";
                    strSQL += "          GROUP BY vactube_code                                      ";
                    strSQL += "          UNION ALL                                                  ";
                    strSQL += "          SELECT   vactube_id AS vactube_code                        ";
                    strSQL += "              FROM cvactube_base                                     ";
                    strSQL += "             WHERE status = '07' AND vactube_name = '3'              ";
                    strSQL += "          GROUP BY vactube_id)                                       ";
                    strSQL += "GROUP BY vactube_code                                                ";
                    strSQL += "ORDER BY vactube_code                                                ";
                    break;
                case CheckOverType.ToRepair:
                    btnConfrim.Text = "��ΪС��";
                    cmdpCheckType.ConstantValue = "2";
                    strSQL = "   SELECT   vactube_id AS vactube_code                ";
                    strSQL += "    FROM cvactube_base                               ";
                    strSQL += "   WHERE status = '07'                               ";
                    strSQL += "ORDER BY vactube_code                                ";
                    break;
                case CheckOverType.ToBuild:
                    btnConfrim.Text = "��Ϊ���ߴ���";
                    cmdpCheckType.ConstantValue = "3"; ;
                    strSQL = "   SELECT   vactube_id AS vactube_code                ";
                    strSQL += "    FROM cvactube_base                               ";
                    strSQL += "   WHERE status = '07'                               ";
                    strSQL += "ORDER BY vactube_code                                ";
                    break;
                default:
                    break;
            }
            dsBase.SourceMethod = strSQL;
            Adapter.Session = session;
            return ShowDialog();
        }

        private void VacTubeOffLineFrm_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbVacTubeCode.Text.Trim() == "")
            {
                MessageBox.Show("û�в۹ܱ�ţ�", "��ʾ");
                return;
            }
            cmdpCode.ConstantValue = cmbVacTubeCode.Text.Trim();

            if (cmdVacTubeCheckOver.Execute() >= 0)
            {
                if (Convert.ToInt32(cmdVacTubeCheckOver.Command.Return) > 0)
                {
                    MessageBox.Show(btnConfrim.Text + "�ɹ���", "��ʾ");
                    this.Close();
                }
                else
                    MessageBox.Show(btnConfrim.Text + "ʧ�ܣ�", "��ʾ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}