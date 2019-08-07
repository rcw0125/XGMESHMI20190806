using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.AODMag
{
    public partial class AODDesignateLadleFrm : Form
    {
        public AODDesignateLadleFrm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
            AODMag01 a = new AODMag01();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("AODID", UnitID);
            Adapter.Session = session;
            lbAODID.Text = "AOD¯";

            return ShowDialog();
        }

        private void btnConfirmHeat_Click(object sender, EventArgs e)
        {
            if (dvSteels.SelectedRows.Count < 1)
            {
                MessageBox.Show("��ѡ��ְ���");
                return;
            }
            DataRowView rowView = dvSteels.SelectedRows[0].DataBoundItem as DataRowView;
            DataRow row = rowView.Row;
            DataSet ds = dsSteels.Clone();
            ds.Tables[0].ImportRow(row);
            paramSteel.SourceObject = ds;
            int iRet = cmdDesignate.Execute();
            if(iRet != 0 || Convert.ToBoolean(cmdDesignate.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdDesignate.Command.ErrorCode));
                MessageBox.Show("ָ���ְ�ʧ�ܣ�" + strReasultShow);
                return;
            }
            else
            {
                MessageBox.Show("ָ���ְ��ɹ���", "��ʾ");
            }
            dsSteels.LoadData();
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            int iRet = cmdArrive.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdArrive.Command.Return) == false)
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
