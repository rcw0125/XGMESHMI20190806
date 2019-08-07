using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class temp4 : spc.spclf
    {
        public temp4()
        {
            unit_like = "41%";
            qcitemcode = "FEEDWIRE_TEMP";
            qc_des = "4#LFÈí´µ¿ªÊ¼ÎÂ¶È";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S44";
            maintype = "process";
            InitializeComponent();
        }
    }
}

