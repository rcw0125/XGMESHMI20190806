using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace NCTelDataMag
{
    public partial class HuiTui : DockContent, IMESForm
    {
        public HuiTui()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete BOFL2_Model_Data  where Name='" + textBox3.Text + "'";

            dsCBloom_Input.SourceMethod = sql;
            Adapter.RefreshDataBindings();
        }
    }
}