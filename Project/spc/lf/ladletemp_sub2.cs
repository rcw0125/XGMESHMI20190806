using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class ladletemp_sub2 : spc.spclf
    {
        public ladletemp_sub2()
        {
            unit_like = "21%";
            qcitemcode = "TEMP";
            qc_des = "2#LF ´ó°üÎÂ½µ";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "ladletemp_sub";
            InitializeComponent();
        }
    }
}

