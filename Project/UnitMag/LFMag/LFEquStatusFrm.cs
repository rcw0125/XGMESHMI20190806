using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFEquStatusFrm : Form
    {
        public LFEquStatusFrm()
        {
            InitializeComponent();
        }

        private string cstrUnitType;
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            cstrUnitType = UnitID.Substring(1, 1);
            string csHint = "";
            if (cstrUnitType == "4")
            {
                Adapter.set_URIParameters("LFID", UnitID);
                csHint = @"��LF¯";
                this.Text = "LF¯�豸״̬ά��";//20081228Liao
                cmdChangeStatus.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            }
            else if (cstrUnitType == "5")
            {
                Adapter.set_URIParameters("RHID", UnitID);
                csHint = @"��RH¯";
                this.Text = "RH¯�豸״̬ά��";//20081228Liao
                cmdChangeStatus.Object = "XGMESLogic\\RHMag\\CRH_Unit_Mag\\{RHID}";
            }
            else if (cstrUnitType == "6")
            {
                Adapter.set_URIParameters("CCMID", UnitID);
                csHint = @"������";
                lbUnitName.Text = @"������:";//20081228Liao
                this.Text = "�����豸״̬ά��";//20081228Liao
                cmdChangeStatus.Object = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            }
            string id = UnitID.Substring(UnitID.Length - 1, 1);
            lbUnitID.Text = id + csHint;

            Adapter.Session = session;

            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (l3CommandParameter1.ConstantValue == null || l3CommandParameter1.ConstantValue.Length < 1)
            {
                MessageBox.Show("��ѡ��״̬��");
                btnOK.DialogResult = DialogResult.None;
                return;
            }

            int iRet = cmdChangeStatus.Execute();
            if (iRet != 0 || System.Convert.ToInt16(cmdChangeStatus.Command.Return) == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdChangeStatus.Command.ErrorCode));
                MessageBox.Show("�޸��豸״̬ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�޸��豸״̬�ɹ���", "��ʾ");
            }
        }

        private void OnStatusChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton))
                return;

            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                l3CommandParameter1.ConstantValue = btn.Tag.ToString();
            }
        }
    }
}