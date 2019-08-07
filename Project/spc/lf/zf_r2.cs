using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_r2 : spc.spclf
    {
        public zf_r2()
        {
            unit = "F2";
            qcitemcode = "R";
            qc_des = "2#LF¾«Á¶ÔüR";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

