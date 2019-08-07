using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_r1 : spc.spclf
    {
        public zf_r1()
        {
            unit = "F1";
            qcitemcode = "R";
            qc_des = "1#LF¾«Á¶ÔüR";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}

