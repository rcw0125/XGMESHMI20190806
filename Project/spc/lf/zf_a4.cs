using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_a4 : spc.spclf
    {
        public zf_a4()
        {
            unit = "F4";
            qcitemcode = "Al2O3";
            qc_des = "4#LF¾«Á¶ÔüAl2O3";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

