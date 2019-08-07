using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class SteelTurnFrm : Form
    {
        public SteelTurnFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            //2008-12-30
            string strCheckFlag = dsData.Tables[0].Rows[0]["Turn_Flag"].ToString();
            if (strCheckFlag == "1")
            {
                MessageBox.Show("��ǰ����\"�Ѿ��������\"��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DialogResult.None;
            }

            Adapter.Session = session;
            dsTurn.Tables[0].Clear();
            dsTurn.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);

            return ShowDialog();
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string rbtnFlag = rbtnAllTurnFlag1.Checked.ToString();
            if (rbtnFlag == "True")
            {
                dsTurn.Tables[0].Rows[0]["All_Turn_Flag"] = 1;
            }
            else
            {
                dsTurn.Tables[0].Rows[0]["All_Turn_Flag"] = 0;
            }
            bsTurn.EndEdit();
            dsTurn.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ��¯ô��", "��ʾ", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTurn.Execute();
                String returnFlag = cmdTurn.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("��¯���ɹ���" + strReasultShow, "��ʾ");
                }
            }
        }

        private void SteelTurnFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}