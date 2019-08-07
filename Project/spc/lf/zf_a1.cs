using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_a1 : spc.spclf
    {
        public zf_a1()
        {
            unit = "F1";
            qcitemcode = "Al2O3";
            qc_des = "1#LF¾«Á¶ÔüAl2O3";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

