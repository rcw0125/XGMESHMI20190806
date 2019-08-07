using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class ChangeGradeFrm : Form
    {
        public ChangeGradeFrm()
        {
            InitializeComponent();
        }
        private string curUnitID = "";
        private string Class_URI = "";
        private string BaseURI = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            curUnitID = UnitID;

            //�ѵ�ǰ�����¯��ȡ��[20081230Liao]
            object objHeatID = null;
            object objTreatNO = null;
            int nUnitType = Convert.ToInt16((UnitID.Substring(1, 1)));
            switch (nUnitType)
            {
                case 2:
                    {
                        Class_URI = CommDataMag.CommonData.BOF_CLASS_URI + UnitID;
                        Adapter.Session.Get(Class_URI, "HeatID", ref objHeatID);
                    }
                    break;
                case 3:
                    {
                        Class_URI = CommDataMag.CommonData.BOF_SIDE_CLASS_URI + UnitID;
                        Adapter.Session.Get(Class_URI, "HeatID", ref objHeatID);
                    }
                    break;
                case 4:
                    {
                        Class_URI = CommDataMag.CommonData.LF_CLASS_URI + UnitID;
                        BaseURI = CommDataMag.CommonData.LF_BASE_DATA_URI;
                        if (Adapter.Session.Get(Class_URI, "TreatNo", ref objTreatNO) >= 0)
                            if (objTreatNO != null)
                                Adapter.Session.Get(BaseURI + @"\" + objTreatNO.ToString(), "HeatID", ref objHeatID);
                            else
                                objHeatID = null;
                    }
                    break;
                case 5:
                    {
                        Class_URI = CommDataMag.CommonData.RH_CLASS_URI + UnitID;
                        BaseURI = CommDataMag.CommonData.RH_BASE_DATA_URI;

                        if (Adapter.Session.Get(Class_URI, "TreatNo", ref objTreatNO) >= 0)
                            if (objTreatNO != null)
                                Adapter.Session.Get(BaseURI + @"\" + objTreatNO.ToString(), "HeatID", ref objHeatID);
                            else
                                objHeatID = null;
                    }
                    break;
                case 6:
                    {
                        Class_URI = CommDataMag.CommonData.CCM_CLASS_URI + UnitID;
                        BaseURI = CommDataMag.CommonData.CCM_BASE_DATA_URI;

                        if (Adapter.Session.Get(Class_URI, "TreatNo", ref objTreatNO) >= 0)
                            if (objTreatNO != null)
                                Adapter.Session.Get(BaseURI + @"\" + objTreatNO.ToString(), "HeatID", ref objHeatID);
                            else
                                objHeatID = null;
                    }
                    break;
                default: break;
            }
            if (objHeatID != null && objHeatID.ToString() != "")
            {
                txtHeatID.Text = objHeatID.ToString();
                return ShowDialog();
            }
            else
            {
                MessageBox.Show("��ǰû����ҵ¯��,����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.None;
            }
        }

        private void BOFRequestChangingGradeFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxReason.SelectedValue == null)
            {
                MessageBox.Show("��ѡ��ĸ�ԭ��");
                return;
            }

            string check = MessageBox.Show("ȷ�ϸĸ����룿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (check != "Yes") return;

            cmdApply.Object = Class_URI;
            cmdApply.Method = "ChangeSteelGradeApp";
            cmdApply.Parameters.Clear();

            int nUnitType = Convert.ToInt16((curUnitID.Substring(1, 1)));
            int nUnitID = Convert.ToInt16((curUnitID.Substring(2, 1)));
            if (nUnitType > 6 || nUnitType < 2)
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
                cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();
                if (nUnitID == 4)
                    cmdApply.Parameters[1].ConstantValue = "80";
                else
                    cmdApply.Parameters[1].ConstantValue = "50";
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
                MessageBox.Show("����ɹ����ȴ����ȸĸ֣�");
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