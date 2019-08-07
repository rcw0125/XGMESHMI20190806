using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class chengpin_p1 : spc.spcform
    {
        public chengpin_p1()
        {
            unit = "Z1";
            unit_like = "21%";
            qcitemcode = "P";
            qctypecode = "GG";
            qc_des = "1#Â¯³ÉÆ·P";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S21";
            maintype = "chengpin";
            InitializeComponent();
        }
    }
}

