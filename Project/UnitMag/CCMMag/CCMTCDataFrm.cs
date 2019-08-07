using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMTCDataFrm : Form
    {
        public CCMTCDataFrm()
        {
            InitializeComponent();
        }

        private int iLastCastingNum = 0;
        private int iLastTundishNum = 0;

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            try
            {
                if (UnitID == null || UnitID.Length != 3 || UnitID.Substring(1, 1).ToString() != "6")
                {
                    MessageBox.Show("异常退出，原因是没有找到相应的铸机！", "提示");
                    return DialogResult.No;
                }

                Adapter.set_URIParameters("CCMID", UnitID);
                txtCCMID.Text = UnitID;

                Adapter.Session = session;
                Adapter.RefreshDataBindings();

                if (dbxTreatNO.Text.Trim() == "")
                {
                    MessageBox.Show("异常退出，原因是没有找到相应的处理号！", "提示");
                    return DialogResult.No;
                }

                //查询过程数据
                dsProcessData.SourceCondition = "TreatNo = '" + dbxTreatNO.Text + "'";
                if (dsProcessData.Tables[0].Rows.Count != 1)
                {
                    MessageBox.Show("没有查找到连铸实绩记录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return DialogResult.None;
                }

                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void CCMTCDataFrm_Load(object sender, EventArgs e)
        {
            iLastCastingNum = txtCastingHeatNum.Text.Trim().Length < 1 ? 0 : Convert.ToInt32(txtCastingHeatNum.Text.Trim());
            iLastTundishNum = txtTundishHeatNum.Text.Trim().Length < 1 ? 0 : Convert.ToInt32(txtTundishHeatNum.Text.Trim());
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bsProcessData.EndEdit();
                int iCastingHeatNum = txtCastingHeatNum.Text.Trim().Length < 1 ? 0 : Convert.ToInt32(txtCastingHeatNum.Text.Trim());
                int iTundishHeatNum = txtTundishHeatNum.Text.Trim().Length < 1 ? 0 : Convert.ToInt32(txtTundishHeatNum.Text.Trim());

                if (iLastCastingNum == iCastingHeatNum && iLastTundishNum == iTundishHeatNum)
                {
                    MessageBox.Show("没有作修改！","提示");
                    return;
                }
                string strProcessDataObj = CommDataMag.CommonData.CCM_PROCESS_DATA_URI + dbxTreatNO.Text;

                int iSucces = 0;
                if (iLastCastingNum != iCastingHeatNum)
                {

                    //浇次内炉数
                    iSucces += Adapter.Session.Set(strProcessDataObj, "Casting_HeatNum", iCastingHeatNum);

                    //浇次数据
                    string strCastingDataObj = "";
                    if (txtCastingNo.Text != "")
                    {
                        strCastingDataObj = @"XGMESLogic\CCMMag\CCCM_Casting_Data\" + txtCastingNo.Text.Trim();
                        iSucces += Adapter.Session.Set(strCastingDataObj, "HeatCount", iCastingHeatNum);
                    }
                }
                if (iLastTundishNum != iTundishHeatNum)
                {
                    //包次内炉数
                    iSucces += Adapter.Session.Set(strProcessDataObj, "Tundish_HeatNum", iTundishHeatNum);

                    //包次数据
                    string strTundishDataObj = "";
                    if (txtTundishNo.Text != "")
                    {
                        strTundishDataObj = @"XGMESLogic\CCMMag\CCCM_Tundish_Data\" + txtTundishNo.Text.Trim();
                        iSucces += Adapter.Session.Set(strTundishDataObj, "HeatCount", iTundishHeatNum);
                    }
                }

                if (iSucces == 0)
                {
                    MessageBox.Show("修正成功！", "提示");
                    this.Close();
                }
                else
                    MessageBox.Show("修正失败！", "提示");

            }
            catch { }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
  