using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class ladletemp_sub4 : spc.spclf
    {
        public ladletemp_sub4()
        {
            unit_like = "41%";
            qcitemcode = "TEMP";
            qc_des = "4#LF ´ó°üÎÂ½µ";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "ladletemp_sub";
            InitializeComponent();
        }
    }
}

