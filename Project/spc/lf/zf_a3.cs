using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_a3 : spc.spclf
    {
        public zf_a3()
        {
            unit = "F3";
            qcitemcode = "Al2O3";
            qc_des = "3#LF¾«Á¶ÔüAl2O3";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

