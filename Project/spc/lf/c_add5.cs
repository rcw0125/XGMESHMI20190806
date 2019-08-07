using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class c_add5 : spc.spclf
    {
        public c_add5()
        {
            unit_like = "51%";
            qcitemcode = "C";
            qc_des = "5#LF CÔöÁ¿";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "c_add";
            InitializeComponent();
        }
    }
}

