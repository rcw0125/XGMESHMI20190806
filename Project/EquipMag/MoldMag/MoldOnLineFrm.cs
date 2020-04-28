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

        private int iCurFace = 0;//����ߴ�
        private string strCCMID = "S60";//S60����3��4��

        public DialogResult ShowDialogEx(AppSvrIF.Session session,int iFace, string strMoldID,string strTargetCCM)
        {
            Adapter.Session = session;

            //[20081230]
            //add by hyh 2012-06-11 �̶��ᾧ��ֻ����ָ������  �ݴ�
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
                strCCMID = "3��4#����";
            cmbCastID.Items.Add(strCCMID);
           // cmbCastID.SelectedIndex = 0;
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMold.EndEdit();

            if (cmdOn.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdOn.Command.Return);
                if (iRet > 0)
                {
                    MessageBox.Show("�ᾧ�����߳ɹ���", "��ʾ", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�ᾧ������ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("�ᾧ������ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
            }
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}