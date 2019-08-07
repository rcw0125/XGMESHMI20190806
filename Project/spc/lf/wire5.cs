using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class wire5 : spc.spclf
    {
        public wire5()
        {
            unit_like = "51%";
            qcitemcode = "Ga";
            qc_des = "5#LF ∏∆œﬂŒπ»Î¡ø";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "wire";
            InitializeComponent();
        }
    }
}

