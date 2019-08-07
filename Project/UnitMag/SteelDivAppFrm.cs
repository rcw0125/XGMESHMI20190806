using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public partial class SteelDivAppFrm : Form
    {
        public SteelDivAppFrm()
        {
            InitializeComponent();
        }
        private string curUnitID = "";
        private string Class_URI = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.Session = session;
            curUnitID = UnitID;

            object objHeatID = null;  //�ѵ�ǰ�����¯��ȡ��[20081230Liao]

            int nUnitType = Convert.ToInt16((UnitID.Substring(1, 1)));
            switch (nUnitType)
            {
                case 6:
                    {
                        Class_URI = CommDataMag.CommonData.CCM_CLASS_URI + UnitID;
                        Adapter.Session.Get(Class_URI, "NextHeatID", ref objHeatID);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("ȷ��¯�ηָ����룿", "��ʾ",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check != "OK") return;

            if (cbxReason.SelectedValue == null)
            {
                MessageBox.Show("��ѡ��¯�ηָ�ԭ��");
                return;
            }

            cmdApply.Object = Class_URI;
            cmdApply.Method = "DivideHeatApp";
            cmdApply.Parameters.Clear();

            int nUnitType = Convert.ToInt16((curUnitID.Substring(1, 1)));
            int nUnitID = Convert.ToInt16((curUnitID.Substring(2, 1)));
            if (nUnitType < 6)
            {
                MessageBox.Show("���빤λ������");
                return;
            }

            AppSvrHMI.L3CommandParameter l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            cmdApply.Parameters.Add(l3CommandParameter1);
            cmdApply.Parameters[0].ConstantValue = cbxReason.SelectedValue.ToString();

            cmdApply.Object = Class_URI;
            int iRet = cmdApply.Execute();
            if (iRet != 0 || (Convert.ToInt16(cmdApply.Command.Return)) == 0)
            {
                MessageBox.Show(string.Format("ʧ�ܣ�����:{0:X},{1:X}", cmdApply.Command.ErrorCode, iRet));
            }
            else
            {
                MessageBox.Show("����ɹ����ȴ�����¯�ηָ");
                Close();
            }
            return;
        }

        private void SteelDivAppFrm_Load(object sender, EventArgs e)
        {
            cbxReason.TextChanged += new EventHandler(pxControls_TextChanged);
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}