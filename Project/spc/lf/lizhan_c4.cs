using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class lizhan_c4 : spc.spclf
    {
        public lizhan_c4()
        {
            unit = "F4";
            qcitemcode = "C";
            qc_des = "4#LF¿Î’æC";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "lizhan";
            InitializeComponent();
        }
    }
}

