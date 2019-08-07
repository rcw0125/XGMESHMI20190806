using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class chengpin_p4 : spc.spcform
    {
        public chengpin_p4()
        {
            unit = "Z4";
            unit_like = "24%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "4#Â¯³ÉÆ·P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S24";
            maintype = "chengpin";
            InitializeComponent();
        }
    }
}

