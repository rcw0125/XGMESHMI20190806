using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_a2 : spc.spclf
    {
        public zf_a2()
        {
            unit = "F2";
            qcitemcode = "Al2O3";
            qc_des = "2#LF������Al2O3";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

