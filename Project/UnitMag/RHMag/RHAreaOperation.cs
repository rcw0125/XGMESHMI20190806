using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHAreaOperation : Form
    {
        public RHAreaOperation()
        {
            InitializeComponent();
        }
        public enum Operation
        {
            StartProcess,
            StopProcess,
            StartBlow,
            StopBlow,
            SteelLeave,
        }

        private Operation m_CurOpr;

        public bool StartProcess(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("RHID",UnitID);
            Adapter.Session = session;
            m_CurOpr = Operation.StartProcess;
            btnOK.Text = "开始处理";
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号RH炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool StopProcess(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("RHID", UnitID);
            Adapter.Session = session;
            m_CurOpr = Operation.StopProcess;
            btnOK.Text = "结束处理";
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号RH炉";
            return ShowDialog() == DialogResult.OK;
        }

        /***********20090218*************/
        public bool StartBlow(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("RHID", UnitID);
            Adapter.Session = session;
            m_CurOpr = Operation.StartBlow;
            btnOK.Text = "软吹开始";
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号RH炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool StopBlow(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("RHID", UnitID);
            Adapter.Session = session;
            m_CurOpr = Operation.StopBlow;
            btnOK.Text = "软吹结束";
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号RH炉";
            return ShowDialog() == DialogResult.OK;
        }
        /***********20090218*************/

        public bool SteelLeave(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("RHID", UnitID);
            Adapter.Session = session;
            m_CurOpr = Operation.SteelLeave;
            btnOK.Text = "钢水离站";
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号RH炉";
            return ShowDialog() == DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3Command cmd = null;
                string strArea = rbAreaA.Checked ? "A" : (rbAreaB.Checked ? "B" : "");

                switch (m_CurOpr)
                {
                    case Operation.StartProcess:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdStartProc;
                            paramStartArea.ConstantValue = strArea;
                        }
                        break;
                    case Operation.StopProcess:
                        {
                            cmd = cmdStopProc;
                        }
                        break;
                    /**************************/
                    case Operation.StartBlow:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdStartBlow;
                            l3cmdpStartBlow.ConstantValue = strArea;
                        }
                        break;

                    case Operation.StopBlow:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdStopBlow;
                            l3cmdpEndBlow.ConstantValue = strArea;
                        }
                        break;
                    /**********************************/
                    case Operation.SteelLeave:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdSteelLeave;
                            paramLeaveArea.ConstantValue = strArea;
                        }
                        break;
                }

                btnOK.DialogResult = DialogResult.OK;

                int iRet = cmd.Execute();
                if (iRet != 0 || Convert.ToBoolean(cmd.Command.Return) == false)
                {
                    //  [12/28/2008 sun]
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmd.Command.ErrorCode));
                    MessageBox.Show("操作失败！" + strReasultShow);
                    btnOK.DialogResult = DialogResult.Cancel;
                }
                //  [12/27/2008 sun]
                else
                {
                    MessageBox.Show("操作成功！", "提示");
                }
            }
            catch { }
        }       
    }
}