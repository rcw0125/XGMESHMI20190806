using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class ladletemp_sub5 : spc.spclf
    {
        public ladletemp_sub5()
        {
            unit_like = "51%";
            qcitemcode = "TEMP";
            qc_des = "5#LF ´ó°üÎÂ½µ";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "ladletemp_sub";
            InitializeComponent();
        }
    }
}

