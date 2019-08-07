using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.MoldMag
{
    public partial class MoldOnLineFrm : Form
    {
        public MoldOnLineFrm()
        {
            InitializeComponent();
        }

        private int iCurFace = 0;//断面尺寸
        private string strCCMID = "S60";//S60代表3、4号

        public DialogResult ShowDialogEx(AppSvrIF.Session session,int iFace, string strMoldID,string strTargetCCM)
        {
            Adapter.Session = session;

            //[20081230]
            //add by hyh 2012-06-11 固定结晶器只能上指定铸机  容错。
            strCCMID = strTargetCCM;
            //end
            iCurFace = iFace;
            dsMold.Tables[0].Rows.Clear();
            DataRow newrow = dsMold.Tables[0].NewRow();
            newrow["MoldID"] = strMoldID;
            dsMold.Tables[0].Rows.Add(newrow);
            bsMold.MoveFirst();


            return ShowDialog();
        }
        private void txtMoldID_TextChanged(object sender, EventArgs e)
        {
            //modify by hyh 2012-06-11
            /*
            switch (strCCMID)
            {
                case CommDataMag.CommonData.MOLD_FACEMEA_A:
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_01ID);
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_02ID);
                    break;
                case CommDataMag.CommonData.MOLD_FACEMEA_B:

                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_03ID);
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_04ID);
                    //add by hyh 2012-06-11
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_06ID);
                    //end
                    break;
                case CommDataMag.CommonData.MOLD_FACEMEA_C:
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_05ID);
                    cmbCastID.Items.Add(CommDataMag.CommonData.CCM_UNIT_07ID);
                    break;
                default:
                    break;
            }
             * */
            if (strCCMID.Equals("S60"))
                strCCMID = "3、4#铸机";
            cmbCastID.Items.Add(strCCMID);
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMold.EndEdit();

            if (cmdOn.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdOn.Command.Return);
                if (iRet > 0)
                {
                    MessageBox.Show("结晶器上线成功！", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("结晶器上线失败！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("结晶器上线失败！", "提示", MessageBoxButtons.OK);
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}