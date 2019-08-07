using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class ucRHAreaBrief : UserControl
    {
        public ucRHAreaBrief()
        {
            InitializeComponent();
        }

        public AppSvrHMI.L3Adapter Adapter
        {
            get { return txtRHCurArea.L3DataAdapter; }
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

        private void txtRHCurArea_TextChanged(object sender, EventArgs e)
        {
            if (txtRHCurArea.Text == "A" || txtRHCurArea.Text == "a")
            {
                lbRHAreaA.BackColor = Color.Salmon;
                lbRHAreaB.BackColor = Color.FromArgb(156, 220, 209);
            }
            else if (txtRHCurArea.Text == "B" || txtRHCurArea.Text == "b")
            {
                lbRHAreaA.BackColor = Color.FromArgb(156, 220, 209);
                lbRHAreaB.BackColor = Color.Salmon;
            }
            else
            {
                lbRHAreaA.BackColor = Color.FromArgb(156, 220, 209);
                lbRHAreaB.BackColor = Color.FromArgb(156, 220, 209);
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
                if (txtRHCurArea.Text == "A")
                    return txtRHHeatIDA.Text;
                else if (txtRHCurArea.Text == "B")
                    return txtRHHeatIDB.Text;
                else
                    return "";
            }
        }

        public event EventHandler OnHeatIDChanged;

        private void txtRHSteelGradeIndexA_TextChanged(object sender, EventArgs e)
        {
            txtRHSteelGradeA.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(txtRHSteelGradeIndexA.L3DataAdapter, txtRHSteelGradeIndexA.Text.Trim());
        }

        private void txtRHSteelGradeIndexB_TextChanged(object sender, EventArgs e)
        {
            txtRHSteelGradeB.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(txtRHSteelGradeIndexB.L3DataAdapter, txtRHSteelGradeIndexB.Text.Trim());
        }

        //预约当前工位状态
        private void txtRHCurAreaStatusA_TextChanged(object sender, EventArgs e)
        {
            if (txtRHCurAreaStatusA.Text.Trim() == CommDataMag.CommonData.RHBlowBegin.ToString())
            {
                txtRHHeatIDA.ForeColor = Color.Salmon;
            }
            else
            {
                txtRHHeatIDA.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtRHCurAreaStatusB_TextChanged(object sender, EventArgs e)
        {
            if (txtRHCurAreaStatusB.Text.Trim() == CommDataMag.CommonData.RHBlowBegin.ToString())
            {
                txtRHHeatIDB.ForeColor = Color.Salmon;
            }
            else
            {
                txtRHHeatIDB.ForeColor = SystemColors.WindowText;
            }
        }

    }
}
