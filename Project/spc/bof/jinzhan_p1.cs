using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class jinzhan_p1 : spc.spcform
    {
        public jinzhan_p1()
        {
            unit = "Z1";
            unit_like = "21%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "1#Â¯½øÕ¾P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S21";
            maintype = "jinzhan";
            InitializeComponent();
        }
    }
}

