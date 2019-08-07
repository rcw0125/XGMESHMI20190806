using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class c_add1 : spc.spclf
    {
        public c_add1()
        {
            unit_like = "11%";
            qcitemcode = "C";
            qc_des = "1#LF CÔöÁ¿";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "c_add";
            InitializeComponent();
        }
    }
}

