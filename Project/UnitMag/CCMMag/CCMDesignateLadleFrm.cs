using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMDesignateLadleFrm : Form
    {
        public CCMDesignateLadleFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("CCMID", UnitID);
            Adapter.Session = session;
            lbCCMID.Text = UnitID.Substring(UnitID.Length-1) + "号铸机";

            return ShowDialog();
        }

        private void btnConfirmHeat_Click(object sender, EventArgs e)
        {
            if (dvSteels.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择钢包！");
                return;
            }
            DataRowView rowView = dvSteels.SelectedRows[0].DataBoundItem as DataRowView;
            DataRow row = rowView.Row;
            DataSet ds = dsSteels.Clone();
            ds.Tables[0].ImportRow(row);
            paramSteel.SourceObject = ds;
            int iRet = cmdDesignate.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdDesignate.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdDesignate.Command.ErrorCode));
                MessageBox.Show("指定钢包失败！" + strReasultShow);
                return;
            }
            else
            {
                MessageBox.Show("指定钢包成功！", "提示");
            }
            dsSteels.LoadData();
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            int iRet = cmdArrive.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdArrive.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdArrive.Command.ErrorCode));
                MessageBox.Show("钢包到达失败！" + strReasultShow);
                return;
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("钢包到达成功！", "提示");
            }
            dsSteels.LoadData();
        }
    }
}