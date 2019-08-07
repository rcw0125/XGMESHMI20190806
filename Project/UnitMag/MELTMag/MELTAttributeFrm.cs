using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MELTMag
{
    public partial class MELTAttributeFrm : Form
    {
        public MELTAttributeFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.Session = session;
            lbBOFID.Text = UnitID;

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //  [12/27/2008 sun]
            //if (txtCampaign.UpdateData() && txtFurnaceAge.UpdateData() && txtLanceAge.UpdateData() && txtTapholeLife.UpdateData() && l3DataBox1.UpdateData())
            if (txtCampaign.UpdateData() && txtLanceAge.UpdateData() && txtTapholeLife.UpdateData() && l3DataBox1.UpdateData())
            {
                MessageBox.Show("属性修改成功！", "提示");
            } 
            else
            {
                MessageBox.Show("属性修改不成功！", "提示");
            }
            
            
            
            
        }

    }
}