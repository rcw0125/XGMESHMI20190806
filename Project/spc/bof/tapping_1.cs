using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class tapping_1 : spc.spcform
    {
        public tapping_1()
        {
            
            unit_like = "21%";
            qc_des = "1#Â¯³ö¸ÖÁ¿";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S21";
            maintype = "tapping";
            InitializeComponent();
        }
    }
}

