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
                MessageBox.Show("属性修改成功！", "提示");
            } 
            else
            {
                MessageBox.Show("属性修改不成功！", "提示");
            }
        }

        private void RHAttributeFrm_Load(object sender, EventArgs e)
        {
            dsRHUnit.SourceCondition = "name = '" + strUnitID + "'";
        }

    }
}