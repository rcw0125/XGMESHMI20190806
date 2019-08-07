using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class IronGrossFrm : Form
    {
        public IronGrossFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session ,AppSvrHMI.L3DataSet dsSend)
        {
            try
            {
                if (dsSend == null || dsSend.Tables[0].Rows.Count != 1)
                    return DialogResult.None;

                dsMain.Tables[0].Rows.Clear();

                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["MaterialID"] = dsSend.Tables[0].Rows[0]["MaterialID"].ToString();
                newrow["BFID"] = dsSend.Tables[0].Rows[0]["BFID"].ToString();
                newrow["TAP_No"] = dsSend.Tables[0].Rows[0]["TAP_No"].ToString();
                newrow["TPC_No"] = dsSend.Tables[0].Rows[0]["TPC_No"].ToString();
                newrow["Weight"] = 0;
                newrow["WeightMode"] = 1;
                dsMain.Tables[0].Rows.Add(newrow);

                Adapter.Session = session;

                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {  
                bsMain.EndEdit();
                dsMain.AcceptChanges();

                float fGross = float.Parse(txtbTare.Text.Trim());
                if (fGross < 0)
                {
                    MessageBox.Show("ë�ر������0t��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string check = MessageBox.Show("ȷ��ë����", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
                if (check != "OK")
                    return;
              
                int iRet = cmdAcceptWeightData.Execute();
                if (iRet != 0 || !(Convert.ToBoolean(cmdAcceptWeightData.Command.Return)))
                {
                    MessageBox.Show("�趨ë��ʧ�ܣ�");
                    //MessageBox.Show(string.Format("ʧ�ܣ�����:{0:X},{1:X}", cmdAcceptWeightData.Command.ErrorCode, iRet));
                }
                else
                {
                    MessageBox.Show("�趨ë�سɹ���");
                    this.Close();
                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}