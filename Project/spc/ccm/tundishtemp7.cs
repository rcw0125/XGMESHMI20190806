using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class tundishtemp7 : spc.spclf
    {
        public tundishtemp7()
        {
            unit_like = "71%";
            qcitemcode = "TEMP";
            qc_des = "7#铸机中包温度";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S67";
            maintype = "tundishtemp";
            InitializeComponent();
        }
    }
}

