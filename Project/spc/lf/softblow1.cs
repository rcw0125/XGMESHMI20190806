using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class softblow1 : spc.spclf
    {
        public softblow1()
        {
            unit_like = "11%";
            qcitemcode = "SOFTBLOW_TIME";
            qc_des = "1#LF»Ì¥µ ±º‰";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "process";
            InitializeComponent();
        }
    }
}

