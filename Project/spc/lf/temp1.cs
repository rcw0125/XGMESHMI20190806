using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class temp1 : spc.spclf
    {
        public temp1()
        {
            unit_like = "11%";
            qcitemcode = "FEEDWIRE_TEMP";
            qc_des = "1#LFÈí´µ¿ªÊ¼ÎÂ¶È";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
            maintype = "process";
            InitializeComponent();
        }
    }
}

