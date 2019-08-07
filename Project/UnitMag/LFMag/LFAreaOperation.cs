using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFAreaOperation : Form
    {
        public LFAreaOperation()
        {
            InitializeComponent();
        }
        public enum Operation
        {
            StartProcess,
            StopProcess,
            StartSoft,
            StopSoft,
            SteelLeave,
        }

        private void ChooseArea(string UnitID)
        {
            object obj = null;
            Adapter.Session.Get(CommDataMag.CommonData.LF_CLASS_URI + UnitID, "CurArea", ref obj);
            if (obj == null || obj.ToString() == "")
            {
                rbAreaA.Checked = true;
            }
        }

        private Operation m_CurOpr;


        public bool StartProcess(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("LFID",UnitID);
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            m_CurOpr = Operation.StartProcess;
            btnOK.Text = "开始处理";
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号LF炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool StopProcess(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("LFID", UnitID);
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            m_CurOpr = Operation.StopProcess;
            btnOK.Text = "结束处理";
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号LF炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool SteelLeave(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("LFID", UnitID);
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            m_CurOpr = Operation.SteelLeave;
            btnOK.Text = "钢水离站";
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号LF炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool SoftStart(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("LFID", UnitID);
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            m_CurOpr = Operation.StartSoft;
            btnOK.Text = "软吹开始";
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号LF炉";
            return ShowDialog() == DialogResult.OK;
        }

        public bool SoftEnd(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("LFID", UnitID);
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            m_CurOpr = Operation.StopSoft;
            btnOK.Text = "软吹结束";
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1, 1) + "号LF炉";
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
                    case Operation.StartSoft:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdStartBlow;
                            paramStartBlow.ConstantValue = strArea;
                        }
                        break;
                    case Operation.StopSoft:
                        {
                            if (strArea.Length < 1)
                            {
                                MessageBox.Show("请选择工位！");
                                btnOK.DialogResult = DialogResult.None;
                                return;
                            }
                            cmd = cmdStopBlow;
                            paramStopBlow.ConstantValue = strArea;
                        }
                        break;
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