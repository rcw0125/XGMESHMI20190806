using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class DeSIronSheetFrm : Form
    {
        public DeSIronSheetFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {   
            Adapter.Session = session;
            return ShowDialog();
        }

        private void DeSIronSheetFrm_Load(object sender, EventArgs e)
        {
            string strSQL = "Select BFID,Tap_No,Tpc_No from CBFIron where IronStatus < 2 and Source = 1 ";//[2009-04-09]
            dsMain.SourceMethod = strSQL;
            //dsMain.LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbTpcNo.Text.Trim() == "")
            {
                MessageBox.Show("û����ˮ�޺�,�������ɹ���", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            dsSend.Tables[0].Rows.Clear();
            DataRow newrow = dsSend.Tables[0].NewRow();
            newrow["TAP_No"] = cmbTapNo.Text.Trim();
            newrow["TPC_No"] = cmbTpcNo.Text.Trim();
            if(radioButton1.Checked)
                newrow["Mode"] = 1;
            else
                newrow["Mode"] = 2;
            dsSend.Tables[0].Rows.Add(newrow);
            dsSend.AcceptChanges();
            cmdSend.Parameters[0].SourceObject = dsSend;
            if (cmdSend.Execute() >= 0)
            {
                int iRet = (int)cmdSend.Command.Return;
                if (iRet > 0)
                {
                    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
                    this.Close();
                }
                else { MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK); }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        //ѡ���¯��:��ȡ���κ�
        private void cmbBFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //��������κ�����Դ
                dsTapNo.Tables[0].Rows.Clear();

                DataRow[] drArray = dsMain.Tables[0].Select("BFID = '" + cmbBFID.Text.Trim() + "'", "TAP_No");// Group by TAP_No
                string strCurTapNo = "";
                foreach (DataRow dr in drArray)
                {
                    if (strCurTapNo != dr["TAP_No"].ToString())
                    {
                        DataRow newrow = dsTapNo.Tables[0].NewRow();
                        newrow[0] = dr["TAP_No"].ToString();
                        dsTapNo.Tables[0].Rows.Add(newrow);
                    }
                    strCurTapNo = dr["TAP_No"].ToString();
                }
                cmbTapNo_SelectedIndexChanged(sender, e);
            }
            catch { }
        }

        private void cmbTapNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //��������κ�����Դ
                dsTpcNo.Tables[0].Rows.Clear();

                DataRow[] drArray = dsMain.Tables[0].Select("TAP_No = '" + cmbTapNo.Text.Trim() + "'", "TPC_No");// Group by TAP_No
                string strCurTpcNo = "";
                foreach (DataRow dr in drArray)
                {
                    if (strCurTpcNo != dr["TPC_No"].ToString())
                    {
                        DataRow newrow = dsTpcNo.Tables[0].NewRow();
                        newrow[0] = dr["TPC_No"].ToString();
                        dsTpcNo.Tables[0].Rows.Add(newrow);
                    }
                    strCurTpcNo = dr["TPC_No"].ToString();
                }
            }
            catch { }
        }

        private void cmbTpcNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}