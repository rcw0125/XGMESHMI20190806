using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class temp3 : spc.spclf
    {
        public temp3()
        {
            unit_like = "31%";
            qcitemcode = "FEEDWIRE_TEMP";
            qc_des = "3#LFÈí´µ¿ªÊ¼ÎÂ¶È";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S43";
            maintype = "process";
            InitializeComponent();
        }
    }
}

