using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMAttributeFrm : Form
    {
        public CCMAttributeFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            /******MODIFY BY HUYUNHAI 2011-3-15******/
            if (UnitID.Equals("S67"))
            {
                groupBox4.Visible = false;
                checkBox4.Visible = false;
                checkBox4.Enabled = false;
                on4.Visible = false;
                on4.Enabled = false;
                off4.Visible = false;
                off4.Enabled = false;
            }
            /*******MODIFY END*******/
            Adapter.Session = session;
            dsCCMPropTruth.SourceCondition = "name = '" + UnitID + "'";
            cmdCCMProp.Object = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\" + UnitID;
            cmdCCMProp.Method = "ModifyStrandStatusData";
            return ShowDialog();
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataRow newrow1 = dsCCMProp.Tables[0].NewRow();
            DataRow newrow2 = dsCCMProp.Tables[0].NewRow();
            DataRow newrow3 = dsCCMProp.Tables[0].NewRow();
            DataRow newrow4 = dsCCMProp.Tables[0].NewRow();
            if (checkBox1.Checked)
            {
                newrow1["StrandNo"] = 1;
                if (on1.Checked)
                {
                    newrow1["OnOff"] = 1;
                }
                else
                {
                    newrow1["OnOff"] = 0;
                }
                dsCCMProp.Tables[0].Rows.Add(newrow1);
            }

            if (checkBox2.Checked)
            {
                newrow2["StrandNo"] = 2;
                if (on2.Checked)
                {
                    newrow2["OnOff"] = 1;
                }
                else
                {
                    newrow2["OnOff"] = 0;
                }
                dsCCMProp.Tables[0].Rows.Add(newrow2);
            }

            if (checkBox3.Checked)
            {
                newrow3["StrandNo"] = 3;
                if (on3.Checked)
                {
                    newrow3["OnOff"] = 1;
                }
                else
                {
                    newrow3["OnOff"] = 0;
                }
                dsCCMProp.Tables[0].Rows.Add(newrow3);
            }

            if (checkBox4.Checked)
            {
                newrow4["StrandNo"] = 4;
                if (on4.Checked)
                {
                    newrow4["OnOff"] = 1;
                }
                else
                {
                    newrow4["OnOff"] = 0;
                }
                dsCCMProp.Tables[0].Rows.Add(newrow4);
            }
            cmdCCMProp.Execute();
            string returnFlag = cmdCCMProp.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("属性修改成功！", "提示");
            } 
            else
            {
                MessageBox.Show("属性修改不成功！" + returnFlag, "提示");
            }
        }

        private void CCMAttributeFrm_Load(object sender, EventArgs e)
        {
            string strOnOffFlag1 = dsCCMPropTruth.Tables[0].Rows[0]["OnOff1st"].ToString();
            string strOnOffFlag2 = dsCCMPropTruth.Tables[0].Rows[0]["OnOff2st"].ToString();
            string strOnOffFlag3 = dsCCMPropTruth.Tables[0].Rows[0]["OnOff3st"].ToString();
            string strOnOffFlag4 = dsCCMPropTruth.Tables[0].Rows[0]["OnOff4st"].ToString();
            if (strOnOffFlag1 == "1")
            {
                on1.Checked = true;
            }
            else
            {
                off1.Checked = true;
            }
            if (strOnOffFlag2 == "1")
            {
                on2.Checked = true;
            }
            else
            {
                off2.Checked = true;
            }
            if (strOnOffFlag3 == "1")
            {
                on3.Checked = true;
            }
            else
            {
                off3.Checked = true;
            }
            if (strOnOffFlag4 == "1")
            {
                on4.Checked = true;
            }
            else
            {
                off4.Checked = true;
            }
        }

       // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}