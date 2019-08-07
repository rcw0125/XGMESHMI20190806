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

            //把当前机组的炉号取出[20081230Liao]
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
                MessageBox.Show("当前没有作业炉号,申请失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("请选择改钢原因！");
                return;
            }

            string check = MessageBox.Show("确认改钢申请？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (check != "Yes") return;

            cmdApply.Object = Class_URI;
            cmdApply.Method = "ChangeSteelGradeApp";
            cmdApply.Parameters.Clear();

            int nUnitType = Convert.ToInt16((curUnitID.Substring(1, 1)));
            int nUnitID = Convert.ToInt16((curUnitID.Substring(2, 1)));
            if (nUnitType > 6 || nUnitType < 2)
            {
                MessageBox.Show("申请工位不允许！");
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
                //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdApply.Command.ErrorCode, iRet));
                MessageBox.Show("失败！" + strReasultShow);
            }
            else
            {
                MessageBox.Show("申请成功，等待调度改钢！");
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