using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_p3 : spc.spcform
    {
        public jinzhan_p3()
        {
            unit = "Z3";
            unit_like = "23%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "3#Â¯½øÕ¾P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

