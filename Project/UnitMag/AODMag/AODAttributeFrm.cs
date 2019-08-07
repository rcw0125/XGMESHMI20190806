using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.AODMag
{
    public partial class AODAttributeFrm : Form
    {
        public AODAttributeFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.set_URIParameters("AODID", "S25");
            Adapter.Session = session;
             return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //  [12/27/2008 sun]
            if (txtCampaign.UpdateData() && txtFurnaceAge.UpdateData() && txtLanceAge.UpdateData() && l3DataBox1.UpdateData()&&txtFurnaceNo.UpdateData())
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