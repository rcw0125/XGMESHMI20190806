using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHAttributeFrm : Form
    {
        public RHAttributeFrm()
        {
            InitializeComponent();
        }

        public string strUnitID = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;
            strUnitID = UnitID;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //  [2009-03-31 sun]
            bsRHUnit.EndEdit();
            if (dsRHUnit.UpdateData())
            {
                MessageBox.Show("�����޸ĳɹ���", "��ʾ");
            } 
            else
            {
                MessageBox.Show("�����޸Ĳ��ɹ���", "��ʾ");
            }
        }

        private void RHAttributeFrm_Load(object sender, EventArgs e)
        {
            dsRHUnit.SourceCondition = "name = '" + strUnitID + "'";
        }

    }
}