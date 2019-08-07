using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XGMESMain
{
    public partial class frmTipTeamIDChanged : Form
    {
        
        public frmTipTeamIDChanged(XGMESMain.frmMain mainFrm)
        {
            InitializeComponent();
            this.timerScan.Tick += new System.EventHandler(mainFrm.wartimer2_Tick);          
            timerScan.Enabled = true;
        }
    }
}