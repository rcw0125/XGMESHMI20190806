using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class wire3 : spc.spclf
    {
        public wire3()
        {
            unit_like = "31%";
            qcitemcode = "Ga";
            qc_des = "3#LF ∏∆œﬂŒπ»Î¡ø";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "wire";
            InitializeComponent();
        }
    }
}

