using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class chengpin_p2 : spc.spcform
    {
        public chengpin_p2()
        {
            unit = "Z2";
            unit_like = "22%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "2#Â¯³ÉÆ·P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "chengpin";
            InitializeComponent();
        }
    }
}

