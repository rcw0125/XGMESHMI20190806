using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_r3 : spc.spclf
    {
        public zf_r3()
        {
            unit = "F3";
            qcitemcode = "R";
            qc_des = "3#LF¾«Á¶ÔüR";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

