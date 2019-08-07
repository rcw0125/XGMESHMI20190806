using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class ucLFAreaBrief : UserControl
    {
        public ucLFAreaBrief()
        {
            InitializeComponent();
        }

        public AppSvrHMI.L3Adapter Adapter
        {
            get { return txtLFCurArea.L3DataAdapter; }
            set
            {
                foreach (Control ctrl in panelMain.Controls)
                {
                    if (ctrl is AppSvrHMI.L3DataBox)
                    {
                        AppSvrHMI.L3DataBox dt = ctrl as AppSvrHMI.L3DataBox;
                        dt.L3DataAdapter = value;
                    }
                }
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is AppSvrHMI.L3DataBox)
                    {
                        AppSvrHMI.L3DataBox dt = ctrl as AppSvrHMI.L3DataBox;
                        dt.L3DataAdapter = value;
                    }
                }
            }
            
        }
        

        private void txtLFCurArea_TextChanged(object sender, EventArgs e)
        {
            if (txtLFCurArea.Text == "A" || txtLFCurArea.Text == "a")
            {
                lbLFAreaA.BackColor = Color.Salmon;
                lbLFAreaB.BackColor = Color.FromArgb(156, 220, 209);
            }
            else if (txtLFCurArea.Text == "B" || txtLFCurArea.Text == "b")
            {
                lbLFAreaA.BackColor = Color.FromArgb(156, 220, 209);
                lbLFAreaB.BackColor = Color.Salmon;
            }
            else
            {
                lbLFAreaA.BackColor = Color.FromArgb(156, 220, 209);
                lbLFAreaB.BackColor = Color.FromArgb(156, 220, 209);
            }
            if (OnHeatIDChanged != null)
                OnHeatIDChanged(this, new EventArgs());
        }

        public void RefreshData()
        {
            foreach (Control ctrl in panelMain.Controls)
            {
                if (ctrl is AppSvrHMI.L3DataBox)
                {
                    AppSvrHMI.L3DataBox dt = ctrl as AppSvrHMI.L3DataBox;
                    dt.LoadData();
                }
            }
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is AppSvrHMI.L3DataBox)
                {
                    AppSvrHMI.L3DataBox dt = ctrl as AppSvrHMI.L3DataBox;
                    dt.LoadData();
                }
            }
           
        }

        public string HeatID
        {
            get
            {
                if (txtLFCurArea.Text == "A")
                    return txtLFHeatIDA.Text;
                else if (txtLFCurArea.Text == "B")
                    return txtLFHeatIDB.Text;
                else
                    return "";
            }
        }

        public event EventHandler OnHeatIDChanged;
        

        private void txtLFSteelGradeIndexA_TextChanged(object sender, EventArgs e)
        {
            txtLFSteelGradeA.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(txtLFSteelGradeIndexA.L3DataAdapter, txtLFSteelGradeIndexA.Text.Trim());
        }

        private void txtLFSteelGradeIndexB_TextChanged(object sender, EventArgs e)
        {
            txtLFSteelGradeB.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(txtLFSteelGradeIndexB.L3DataAdapter, txtLFSteelGradeIndexB.Text.Trim());
        }

        //预约当前工位状态
        private void txtLFCurAreaStatusA_TextChanged(object sender, EventArgs e)
        {
            if (txtLFCurAreaStatusA.Text.Trim() == CommDataMag.CommonData.LFBlowBegin.ToString())
            {
                txtLFHeatIDA.ForeColor = Color.Salmon;
            }
            else
            {
                txtLFHeatIDA.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtLFCurAreaStatusB_TextChanged(object sender, EventArgs e)
        {
            if (txtLFCurAreaStatusB.Text.Trim() == CommDataMag.CommonData.LFBlowBegin.ToString())
            {
                txtLFHeatIDB.ForeColor = Color.Salmon;
            }
            else
            {
                txtLFHeatIDB.ForeColor = SystemColors.WindowText;
            }
        }

    }
}
