using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class wire2 : spc.spclf
    {
        public wire2()
        {
            unit_like = "21%";
            qcitemcode = "Ga";
            qc_des = "2#LF ∏∆œﬂŒπ»Î¡ø";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "wire";
            InitializeComponent();
        }
    }
}

