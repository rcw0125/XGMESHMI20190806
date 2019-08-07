using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFDesignateLadleFrm : Form
    {
        public LFDesignateLadleFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("LFID", UnitID);
            Adapter.Session = session;
            lbLFID.Text = UnitID.Substring(UnitID.Length - 1) + "号LF炉";

            return ShowDialog();
        }

        private void btnConfirmHeat_Click(object sender, EventArgs e)
        {
            if (dvSteels.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择钢包！");
                return;
            }
            paramHeatID.ConstantValue = dvSteels.SelectedRows[0].Cells["HeatID"].Value.ToString();
            if (rbAreaA.Checked)
                paramArea.ConstantValue = "A";
            else if (rbAreaB.Checked)
                paramArea.ConstantValue = "B";
            else
            {
                MessageBox.Show("请选择工位！");
                return;
            }
            int iRet = cmdDesignate.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdDesignate.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdDesignate.Command.ErrorCode));
                MessageBox.Show("指定钢包失败！"+ strReasultShow);
                return;
            }
            dsSteels.LoadData();
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            if (rbAreaA.Checked)
                paramArriveArea.ConstantValue = "A";
            else if (rbAreaB.Checked)
                paramArriveArea.ConstantValue = "B";
            else
            {
                MessageBox.Show("请选择工位！");
                return;
            }
            int iRet = cmdArrive.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdArrive.Command.Return) == false)
            {

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