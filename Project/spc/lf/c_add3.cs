using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class c_add3 : spc.spclf
    {
        public c_add3()
        {
            unit_like = "31%";
            qcitemcode = "C";
            qc_des = "3#LF CÔöÁ¿";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "c_add";
            InitializeComponent();
        }
    }
}

