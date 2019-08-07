using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class ladletemp_sub3 : spc.spclf
    {
        public ladletemp_sub3()
        {
            unit_like = "31%";
            qcitemcode = "TEMP";
            qc_des = "3#LF ´ó°üÎÂ½µ";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "ladletemp_sub";
            InitializeComponent();
        }
    }
}

