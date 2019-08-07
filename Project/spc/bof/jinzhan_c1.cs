using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_c1 : spc.spcform
    {
        public jinzhan_c1()
        {
            unit = "Z1";
            unit_like = "21%";
            qcitemcode = "C";
            qctypecode = "GG";
            qc_des = "1#Â¯½øÕ¾C";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S21";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

