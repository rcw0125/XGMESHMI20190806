using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class lizhan_c5 : spc.spclf
    {
        public lizhan_c5()
        {
            unit = "F5";
            qcitemcode = "C";
            qc_des = "5#LF¿Î’æC";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "lizhan";
            InitializeComponent();
        }
    }
}

