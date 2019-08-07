using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MELTMag
{
    public partial class MELTSteelReturnAppFrm : Form
    {
        public MELTSteelReturnAppFrm()
        {
            InitializeComponent();
        }

        private string curUnitID = "";
        private string Class_URI = "";
        //private string BaseURI = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            curUnitID = UnitID;

            //�ѵ�ǰ�����¯��ȡ��[20081230Liao]
            //object objHeatID = null;
            //object objTreatNO = null;

            string strMessage = "��ǰû����ҵ¯��,����ʧ�ܣ�";

            int nUnitType = Convert.ToInt16((UnitID.Substring(1, 1)));
            switch (nUnitType)
            {
                case 2:
                    Class_URI = "XGMESLogic\\MELTMag\\CMELT_Unit_Mag\\S51";
                    break;
                case 3:
                    Class_URI = CommDataMag.CommonData.BOF_SIDE_CLASS_URI + UnitID;
                    break;
                case 4:
                    Class_URI = CommDataMag.CommonData.LF_CLASS_URI + UnitID;
                    break;
                case 5:
                    Class_URI = CommDataMag.CommonData.RH_CLASS_URI + UnitID;
                    break;
                case 6:
                    Class_URI = CommDataMag.CommonData.CCM_CLASS_URI + UnitID;
                    strMessage = "��������λû�����������ĸ�ˮ,����ʧ�ܣ�";
                    break;
                default:
                    break;
            }

            dsHeatID.SourceURI = Class_URI;
            dsHeatID.LoadData();
            if (dsHeatID.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show(strMessage, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.None;
            }
            cbxHeatID.Items.Clear();
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
            {
                cbxHeatID.Items.Add(dsHeatID.Tables[0].Rows[i][0].ToString());
            }
            cbxHeatID.SelectedIndex = 0;
            return ShowDialog();
        }
 
        private void btnOK_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("ȷ�ϻ�¯���룿", "��ʾ",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "Cancel") return;

            if (cbxReason.SelectedValue == null || cbxHeatID.Text.Trim() == "")
            {
                MessageBox.Show("��ѡ���¯ԭ���¯�ţ�");
                return;
            }

            cmdApply.Object = Class_URI;
            cmdApply.Method = "SteelReturnApp";
            cmdApply.Parameters.Clear();

            int nUnitType = Convert.ToInt16((curUnitID.Substring(1, 1)));
            int nUnitID = Convert.ToInt16((curUnitID.Substring(2, 1)));
            cmdApply.Parameters.Clear();//��ղ���
            if (nUnitType < 2)
            {
                MessageBox.Show("���빤λ������");
                return;
            }
            if (nUnitType < 4)
            {
                AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter1);
                AppSvrHMI.L3CommandParameter l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter2);
                AppSvrHMI.L3CommandParameter l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter3);
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
                if (nUnitID == 4)
                    cmdApply.Parameters[1].ConstantValue = "80";
                else
                    cmdApply.Parameters[1].ConstantValue = "50";
                cmdApply.Parameters[2].ConstantValue = cbxHeatID.Text.Trim();
            }
            else if (nUnitType > 3 && nUnitType < 6)
            {
                AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter1);
                AppSvrHMI.L3CommandParameter l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter2);
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
                cmdApply.Parameters[1].ConstantValue = cbxHeatID.Text.Trim();
            }
            else
            {
                AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
                cmdApply.Parameters.Add(l3CommandParameter1);
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
            }
            cmdApply.Object = Class_URI;
            int iRet = cmdApply.Execute();
            if (iRet != 0 || ((short)cmdApply.Command.Return) == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdApply.Command.ErrorCode));
                //MessageBox.Show(string.Format("ʧ�ܣ�����:{0:X},{1:X}", cmdApply.Command.ErrorCode, iRet));
                MessageBox.Show("ʧ�ܣ�" + strReasultShow);
            }
            else
            {
                MessageBox.Show("����ɹ����ȴ����Ȼ�¯����");
                Close();
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}