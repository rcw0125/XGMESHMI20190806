using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class softblow5 : spc.spclf
    {
        public softblow5()
        {
            unit_like = "51%";
            qcitemcode = "SOFTBLOW_TIME";
            qc_des = "5#LF»Ì¥µ ±º‰";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "process";
            InitializeComponent();
        }
    }
}

