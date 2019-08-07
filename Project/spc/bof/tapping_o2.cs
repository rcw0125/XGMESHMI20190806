using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class tapping_o2 : spc.spcform
    {
        public tapping_o2()
        {
            unit_like = "22%";
            qc_des = "2#Â¯³ö¸ÖÑõ";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "tapping_o";
            InitializeComponent();
        }
    }
}

