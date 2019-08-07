using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class softblow2 : spc.spclf
    {
        public softblow2()
        {
            unit_like = "21%";
            qcitemcode = "SOFTBLOW_TIME";
            qc_des = "2#LF»Ì¥µ ±º‰";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "process";
            InitializeComponent();
        }
    }
}

