using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class tapping_3 : spc.spcform
    {
        public tapping_3()
        {
            unit_like = "23%";
            qc_des = "3#Â¯³ö¸ÖÁ¿";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "tapping";
            InitializeComponent();
        }
    }
}

