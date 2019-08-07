using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class c_add4 : spc.spclf
    {
        public c_add4()
        {
            unit_like = "41%";
            qcitemcode = "C";
            qc_des = "4#LF CÔöÁ¿";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "c_add";
            InitializeComponent();
        }
    }
}

