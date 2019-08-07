using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TAPEndFrm : Form
    {
        public TAPEndFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID,string HeatID)
        {
            Adapter.set_URIParameters("TAPID", UnitID);
            Adapter.set_URIParameters("HeatID", HeatID);
            Adapter.Session = session;
            lbHeatID.Text = HeatID;

            return ShowDialog();
        }

        private void TAPEndFrm_Load(object sender, EventArgs e)
        {
            DataRow row = dsProcData.Tables[0].NewRow();
            dsProcData.Tables[0].Rows.Add(row);

            foreach (Control c in panelProc.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // TODO : 记录吹氩方式和是否调温标志
            bsProcData.EndEdit();
            dvElements.EndEdit();

            int iRet=-1;
            if (dsElements.Tables[0].Rows.Count > 0)
            {
                iRet = cmdFeedElements.Execute();
                if (iRet != 0 || (short)cmdFeedElements.Command.Return == 0)
                {
                    MessageBox.Show(string.Format("添加喂丝记录失败！错误代码：{0:X}", cmdFeedElements.Command.ErrorCode));
                    btnOK.DialogResult = DialogResult.None;
                    return;
                }
            }

            iRet = cmdStopProc.Execute();
            if (iRet != 0 || (short)cmdStopProc.Command.Return == 0)
            {
                MessageBox.Show(string.Format("结束处理失败！错误代码：{0:X}", cmdStopProc.Command.ErrorCode));
                btnOK.DialogResult = DialogResult.None;
                return;
            }

            btnOK.DialogResult = DialogResult.OK;
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

    }
}