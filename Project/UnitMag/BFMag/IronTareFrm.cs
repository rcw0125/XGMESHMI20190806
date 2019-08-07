using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class IronTareFrm : Form
    {
        public IronTareFrm()
        {
            InitializeComponent();
        }

        private float fGross = 0;//缓存毛重
        public DialogResult ShowDialogEx(AppSvrIF.Session session,AppSvrHMI.L3DataSet dsSend)
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
                newrow["Weight"] = dsSend.Tables[0].Rows[0]["Net_Weight"].ToString();
                newrow["WeightMode"] = 2;
                dsMain.Tables[0].Rows.Add(newrow);
                try
                {
                    fGross = float.Parse(dsSend.Tables[0].Rows[0]["Gross_Weight"].ToString());
                }
                catch { fGross = 0; }

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
              
                //float fTare = float.Parse(txtNet.Text.Trim());
                //float fNetWeight = fGross - fTare;
                float fNetWeight = float.Parse(txtNet.Text.Trim());
                float fTare = fGross - fNetWeight;
                if (fTare < 0)
                {
                    MessageBox.Show("皮重不能小于0t！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (fNetWeight < 0)
                {
                    MessageBox.Show("当前净重小于0t！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string check = MessageBox.Show("确认净重吗？", "提示",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
                if (check != "OK") return;

                int iRet = cmdAcceptWeightData.Execute();
                if (iRet != 0 || !(Convert.ToBoolean(cmdAcceptWeightData.Command.Return)))
                {
                    MessageBox.Show("设定净重失败！");
                    //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdAcceptWeightData.Command.ErrorCode, iRet));
                }
                else
                {
                    MessageBox.Show("设定净重成功！");
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