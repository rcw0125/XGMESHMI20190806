using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_p2 : spc.spcform
    {
        public jinzhan_p2()
        {
            unit = "Z2";
            unit_like = "22%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "2#Â¯½øÕ¾P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

