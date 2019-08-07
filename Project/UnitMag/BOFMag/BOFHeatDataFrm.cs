using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFHeatDataFrm : Form
    {
        public BOFHeatDataFrm()
        {
            InitializeComponent();
        }

        protected void HideAllTabPages()
        {
            while (tabCtrlMain.TabPages.Count > 0)
                tabCtrlMain.TabPages.RemoveAt(0);
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID, string HeatID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.set_URIParameters("HeatID", HeatID);

            Adapter.Session = session;
            lbHeatID.Text = HeatID;

            return ShowDialog();
        }

        // 进行吹炼开始操作
        public DialogResult BlowStart(AppSvrIF.Session sessoin, string UnitID, string HeatID)
        {
            HideAllTabPages();
            tabCtrlMain.TabPages.Add(tabBOFBlowStart);
            return ShowDialogEx(sessoin, UnitID, HeatID);
        }

        // 吹炼开始
        private void btnBOFBlowStart_Click(object sender, EventArgs e)
        {
            int iRet = cmdBOFBlowStart.Execute();
            if (iRet != 0 || (short)cmdBOFBlowStart.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdBOFBlowStart.Command.ErrorCode));
                MessageBox.Show("开吹失败！" + strReasultShow);
                btnBOFBlowStart.DialogResult = DialogResult.None;
                return;
            }
            //  [12/27/2008 sun]
            MessageBox.Show("开吹成功！", "提示");
            btnBOFBlowStart.DialogResult = DialogResult.OK;
        }

   
        private void BOFHeatDataFrm_Load(object sender, EventArgs e)
        {
        }

        private void dvInIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
       
    }
}