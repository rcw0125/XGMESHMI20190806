using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TAPStartFrm : Form
    {
        public TAPStartFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("TAPID", UnitID);
            Adapter.Session = session;
            string strIdx = UnitID.Substring(UnitID.Length - 1, 1);
            lbTAPID.Text = strIdx + "号转炉炉后处理";

            return ShowDialog();
        }

        private void TAPStartFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dvSteels.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择钢水！");
                btnOK.DialogResult = DialogResult.None;
                return;
            }

            DataGridViewRow dvrow = dvSteels.SelectedRows[0];
            DataRowView view = dvrow.DataBoundItem as DataRowView;
            DataRow row = view.Row;

            DataSet ds = dsSteels.Clone();
            ds.Tables[0].ImportRow(row);

            paramSteels.SourceObject = ds;
            int iRet = cmdStartProc.Execute();
            if (iRet != 0 || (short)cmdStartProc.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdStartProc.Command.ErrorCode));
                MessageBox.Show("开始处理失败！" + strReasultShow);
            }
                //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("开始处理成功！", "提示");
            }
        }

        private void dvSteels_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}