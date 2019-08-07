using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class rh_c1 : spc.spclf
    {
        public rh_c1()
        {
            unit = "R1";
            qcitemcode = "C";
            qc_des = "1#RHÂ¯-ÀëÕ¾C";
            DataObject = @"XGMESLogic\RHMag\CRH_Unit_Mag\S51";
            maintype = "rh";
            InitializeComponent();
        }
    }
}

