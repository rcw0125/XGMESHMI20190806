using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class c_add2 : spc.spclf
    {
        public c_add2()
        {
            unit_like = "21%";
            qcitemcode = "C";
            qc_des = "2#LF CÔöÁ¿";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "c_add";
            InitializeComponent();
        }
    }
}

