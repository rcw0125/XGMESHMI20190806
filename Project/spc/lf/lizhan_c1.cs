using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class lizhan_c1 : spc.spclf
    {
        public lizhan_c1()

        {
            unit = "F1";
            qcitemcode = "C";
            qc_des = "1#LF¿Î’æC";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "lizhan";
            InitializeComponent();
        }
    }
}

