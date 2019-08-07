using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_c4 : spc.spcform
    {
        public jinzhan_c4()
        {
            unit = "Z4";
            unit_like = "24%";
            qcitemcode = "C";
            qctypecode = "GG";
            qc_des = "4#Â¯½øÕ¾C";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S24";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

