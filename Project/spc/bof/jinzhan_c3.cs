using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_c3 : spc.spcform
    {
        public jinzhan_c3()
        {
            unit = "Z3";
            unit_like = "23%";
            qcitemcode = "C";
            qctypecode = "GG";
            qc_des = "3#Â¯½øÕ¾C";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

