using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_r4 : spc.spclf
    {
        public zf_r4()
        {
            unit = "F4";
            qcitemcode = "R";
            qc_des = "4#LF¾«Á¶ÔüR";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

