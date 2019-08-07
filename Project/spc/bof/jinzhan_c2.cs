using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_c2 : spc.spcform
    {
        public jinzhan_c2()
        {
            unit = "Z2";
            unit_like = "22%";
            qcitemcode = "C";
            qctypecode = "GG";
            qc_des = "2#Â¯½øÕ¾C";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

