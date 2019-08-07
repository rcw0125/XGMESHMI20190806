using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_r5 : spc.spclf
    {
        public zf_r5()
        {
            unit = "F5";
            qcitemcode = "R";
            qc_des = "5#LF¾«Á¶ÔüR";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

