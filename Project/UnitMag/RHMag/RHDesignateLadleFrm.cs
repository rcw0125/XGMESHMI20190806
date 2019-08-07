using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHDesignateLadleFrm : Form
    {
        public RHDesignateLadleFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("RHID", UnitID);
            Adapter.Session = session;
            lbRHID.Text = UnitID.Substring(UnitID.Length - 1) + "��RH¯";

            return ShowDialog();
        }

        private void btnConfirmHeat_Click(object sender, EventArgs e)
        {
            if (dvSteels.SelectedRows.Count < 1)
            {
                MessageBox.Show("��ѡ��ְ���");
                return;
            }
            paramHeatID.ConstantValue = dvSteels.SelectedRows[0].Cells["HeatID"].Value.ToString();
            if (rbAreaA.Checked)
                paramArea.ConstantValue = "A";
            else if (rbAreaB.Checked)
                paramArea.ConstantValue = "B";
            else
            {
                MessageBox.Show("��ѡ��λ��");
                return;
            }
            int iRet = cmdDesignate.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdDesignate.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdDesignate.Command.ErrorCode));
                MessageBox.Show("ָ���ְ�ʧ�ܣ�" + strReasultShow);
                return;
            }
            dsSteels.LoadData();
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            if (rbAreaA.Checked)
                paramArriveArea.ConstantValue = "A";
            else if (rbAreaB.Checked)
                paramArriveArea.ConstantValue = "B";
            else
            {
                MessageBox.Show("��ѡ��λ��");
                return;
            }
            int iRet = cmdArrive.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdArrive.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdArrive.Command.ErrorCode));
                MessageBox.Show("�ְ�����ʧ�ܣ�" + strReasultShow);
                return;
            }
                //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�ְ�����ɹ���", "��ʾ");
            }
            dsSteels.LoadData();
        }
    }
}