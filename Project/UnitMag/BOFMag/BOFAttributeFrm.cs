using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFAttributeFrm : Form
    {
        public BOFAttributeFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.Session = session;
            lbBOFID.Text = UnitID;
            if (session.User == "17318")
            {
                txtFurnaceAge.ReadOnly = false;
            }
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //  [12/27/2008 sun]
            //if (txtCampaign.UpdateData() && txtFurnaceAge.UpdateData() && txtLanceAge.UpdateData() && txtTapholeLife.UpdateData() && l3DataBox1.UpdateData())
            if (txtCampaign.UpdateData() && txtLanceAge.UpdateData() && txtTapholeLife.UpdateData() && l3DataBox1.UpdateData())
            {
                if (Adapter.Session.User == "17318")
                {
                    txtFurnaceAge.UpdateData();
                }
                MessageBox.Show("�����޸ĳɹ���", "��ʾ");
            } 
            else
            {
                MessageBox.Show("�����޸Ĳ��ɹ���", "��ʾ");
            }
            
            
            
            
        }

    }
}