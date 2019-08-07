using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class softblow3 : spc.spclf
    {
        public softblow3()
        {
            unit_like = "31%";
            qcitemcode = "SOFTBLOW_TIME";
            qc_des = "3#LF»Ì¥µ ±º‰";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "process";
            InitializeComponent();
        }
    }
}

