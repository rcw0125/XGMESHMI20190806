using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class IronNetWeightFrm : Form
    {
        public IronNetWeightFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,AppSvrHMI.L3DataSet dsSend)
        {
            try
            {
                if (dsSend == null || dsSend.Tables[0].Rows.Count != 1)
                    return DialogResult.None;

                dsM.Tables[0].Rows.Clear();

                dsM.Tables[0].ImportRow(dsSend.Tables[0].Rows[0]);
                //DataRow newrow = dsM.Tables[0].NewRow();
                //newrow["MaterialID"] = dsSend.Tables[0].Rows[0]["MaterialID"].ToString();
                //newrow["BFID"] = dsSend.Tables[0].Rows[0]["BFID"].ToString();
                //newrow["TAP_No"] = dsSend.Tables[0].Rows[0]["TAP_No"].ToString();
                //newrow["TPC_No"] = dsSend.Tables[0].Rows[0]["TPC_No"].ToString();
                //newrow["Net_Weight"] = 0;
                //dsM.Tables[0].Rows.Add(newrow);
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
                dsM.AcceptChanges();
              
                float fNetWT = float.Parse(txtNetWeghit.Text.Trim());
                if (fNetWT < 0)
                {
                    MessageBox.Show("净重不能小于0t！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string check = MessageBox.Show("确认去铸铁吗？", "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
                if (check != "Yes") return;

                int iRet = cmdSendIronToCast.Execute();
                if (iRet != 0 || !(Convert.ToBoolean(cmdSendIronToCast.Command.Return)))
                {
                    MessageBox.Show("去铸铁失败！");
                    //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdAcceptWeightData.Command.ErrorCode, iRet));
                }
                else
                {
                    MessageBox.Show("成功去铸铁！");
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