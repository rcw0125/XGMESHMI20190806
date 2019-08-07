using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class temp2 : spc.spclf
    {
        public temp2()
        {
            unit_like = "21%";
            qcitemcode = "FEEDWIRE_TEMP";
            qc_des = "2#LFÈí´µ¿ªÊ¼ÎÂ¶È";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S42";
            maintype = "process";
            InitializeComponent();
        }
    }
}

