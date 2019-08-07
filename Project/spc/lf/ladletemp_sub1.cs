using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class ladletemp_sub1 : spc.spclf
    {
        public ladletemp_sub1()
        {
            unit_like = "11%";
            qcitemcode = "TEMP";
            qc_des = "1#LF ´ó°üÎÂ½µ";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "ladletemp_sub";
            InitializeComponent();
        }
    }
}

