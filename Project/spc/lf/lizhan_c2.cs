using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class lizhan_c2 : spc.spclf
    {
        public lizhan_c2()
        {
            unit = "F2";
            qcitemcode = "C";
            qc_des = "2#LF¿Î’æC";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "lizhan";
            InitializeComponent();
        }
    }
}

