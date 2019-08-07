using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class temp5 : spc.spclf
    {
        public temp5()
        {
            unit_like = "51%";
            qcitemcode = "FEEDWIRE_TEMP";
            qc_des = "5#LFÈí´µ¿ªÊ¼ÎÂ¶È";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "process";
            InitializeComponent();
        }
    }
}

