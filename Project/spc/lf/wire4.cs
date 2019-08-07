using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class wire4 : spc.spclf
    {
        public wire4()
        {
            unit_like = "41%";
            qcitemcode = "Ga";
            qc_des = "4#LF ∏∆œﬂŒπ»Î¡ø";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "wire";
            InitializeComponent();
        }
    }
}

