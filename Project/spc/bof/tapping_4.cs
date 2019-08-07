using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class tapping_4 : spc.spcform
    {
        public tapping_4()
        {
            unit_like = "24%";
            qc_des = "4#Â¯³ö¸ÖÁ¿";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S24";
            maintype = "tapping";
            InitializeComponent();
        }
    }
}

