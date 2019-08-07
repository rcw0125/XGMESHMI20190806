using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class chengpin_p3 : spc.spcform
    {
        public chengpin_p3()
        {
            unit = "Z3";
            unit_like = "23%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "3#Â¯³ÉÆ·P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "chengpin";
            InitializeComponent();
        }
    }
}

