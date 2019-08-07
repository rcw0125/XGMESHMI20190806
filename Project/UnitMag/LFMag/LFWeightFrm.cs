using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFWeightFrm : Form
    {
        string id = "";
        public LFWeightFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;
            id = UnitID;
            return ShowDialog();
        }

        private void dvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((cmdDesignate.Execute() >= 0) && (Convert.ToBoolean(cmdDesignate.Command.Return)))
            {
                MessageBox.Show("称重指定成功！", "提示");
            }
            else
            {
                MessageBox.Show("称重指定失败！", "提示");
            }
        }

        private void btnSetWeight_Click(object sender, EventArgs e)
        {
            if ((cmdSetWeight.Execute() >= 0) && (Convert.ToBoolean(cmdSetWeight.Command.Return)))
            {
                MessageBox.Show("设置重量成功！", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("设置重量失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvSteels_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (dvSteels.Rows.Count < 1 && id == "S45")
            //{
            //    btnDesignate.Enabled = true;
            //    btnSetWeight.Enabled = true;
            //}
            if (dvSteels.Rows.Count < 1 && id == "S43")
            {
                btnDesignate.Enabled = false;
                btnSetWeight.Enabled = false;
            }
            else
            {
                btnDesignate.Enabled = true;
                btnSetWeight.Enabled = true;
            }
        }
        /***********Modify By Huyunhai 2011-03-30*************/
        private void LFWeightFrm_Load(object sender, EventArgs e)
        {
            if (id=="S43")
            {
                cmdDesignate.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S43";
                cmdSetWeight.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S43";
                dsSteels.SourceURI = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S43";
                this.Text="3#LF 称重指定";
            }
            if (id=="S45")
            {
                cmdDesignate.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S45";
                cmdSetWeight.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S45";
                dsSteels.SourceURI = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S45";
                this.Text="5#LF 称重指定";
            }
        }
        /*******Modify End********/
    }
}