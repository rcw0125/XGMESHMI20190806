using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class softblow4 : spc.spclf
    {
        public softblow4()
        {
            unit_like = "41%";
            qcitemcode = "SOFTBLOW_TIME";
            qc_des = "4#LF»Ì¥µ ±º‰";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "process";
            InitializeComponent();
        }
    }
}

