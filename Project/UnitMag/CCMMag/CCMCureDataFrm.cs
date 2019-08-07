using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMCureDataFrm : Form
    {
        public CCMCureDataFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, bool bCheck, string strCCMID, string strHeatID)
        {
            if (strHeatID == "" || strCCMID == "")
            {
                MessageBox.Show("炉号或铸机号为空！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.No;
            }
            switch (strCCMID)
            {
                case CommDataMag.CommonData.CCM_UNIT_01ID:
                case CommDataMag.CommonData.CCM_UNIT_02ID:
                case CommDataMag.CommonData.CCM_UNIT_03ID:
                case CommDataMag.CommonData.CCM_UNIT_04ID:
                case CommDataMag.CommonData.CCM_UNIT_06ID:


                    UCCCM14CureData ucCCM14 = new UCCCM14CureData();
                    ucCCM14.Session = session;
                    ucCCM14.CCMID = strCCMID;
                    ucCCM14.HeatID = strHeatID;
                    ucCCM14.check = bCheck;
                    
                    panelctr.Controls.Clear();
                    panelctr.Controls.Add(ucCCM14);
                    ucCCM14.Dock = DockStyle.Fill;
                    break;
                case CommDataMag.CommonData.CCM_UNIT_05ID:
                    UCCCM5CureData ucCCM5 = new UCCCM5CureData();
                    ucCCM5.Session = session;
                    ucCCM5.CCMID = strCCMID;
                    ucCCM5.HeatID = strHeatID;
                    ucCCM5.check = bCheck;

                    panelctr.Controls.Clear();
                    panelctr.Controls.Add(ucCCM5);
                    ucCCM5.Dock = DockStyle.Fill;

                    break;

                case CommDataMag.CommonData.CCM_UNIT_07ID:

                    UCCCM7CureData ucCCM7 = new UCCCM7CureData();
                    ucCCM7.Session = session;
                    ucCCM7.CCMID = strCCMID;
                    ucCCM7.HeatID = strHeatID;
                    ucCCM7.check = bCheck;

                    panelctr.Controls.Clear();
                    panelctr.Controls.Add(ucCCM7);
                    ucCCM7.Dock = DockStyle.Fill;

                    break;
                default:
                    break;
            }
            return this.ShowDialog();
        }
    }
}