using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class lizhan_c3 : spc.spclf
    {
        public lizhan_c3()
        {
            unit = "F3";
            qcitemcode = "C";
            qc_des = "3#LF¿Î’æC";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "lizhan";
            InitializeComponent();
        }
    }
}

