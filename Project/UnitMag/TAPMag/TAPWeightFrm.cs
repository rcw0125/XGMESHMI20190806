using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TAPWeightFrm : Form
    {
        public TAPWeightFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("TAPID", UnitID);
            Adapter.Session = session;
            //strHeatID = "";
            object objHeatID = null;
            Adapter.Session.Get("XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\" + UnitID, "HeatID", ref objHeatID);
            string strHeatID = objHeatID != null ? objHeatID.ToString() : "";
            if(strHeatID.Length ==9)
            {

                //strWeight = "";
                object objWeight = null;

                Adapter.Session.Get("MES\\MaterialData\\CSteel_Data\\" + strHeatID, "Weight", ref objWeight);
                string strWeight = objWeight != null ? objWeight.ToString() : "";
                txtWeight.Text = strWeight;
            }

            return ShowDialog();
        }

        private void txtWeight_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double f = double.Parse(txtWeight.Text);
            }
            catch
            {
                MessageBox.Show("请输入数字!");
                e.Cancel = true;
                return;
            }
            e.Cancel = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int iRet = cmdSetWeight.Execute();
            if (iRet != 0 || (short)cmdSetWeight.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdSetWeight.Command.ErrorCode));
                MessageBox.Show("设定重量失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("设定重量成功！", "提示");
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void TAPWeightFrm_Load(object sender, EventArgs e)
        {
            txtWeight.TextChanged += new EventHandler(pxControls_TextChanged);
        }
    }
}