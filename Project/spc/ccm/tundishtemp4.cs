using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class tundishtemp4 : spc.spclf
    {
        public tundishtemp4()
        {
            unit_like = "41%";
            qcitemcode = "TEMP";
            qc_des = "4#铸机中包温度";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S64";
            maintype = "tundishtemp";
            InitializeComponent();
        }
    }
}

