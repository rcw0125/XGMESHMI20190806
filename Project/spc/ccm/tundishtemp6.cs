using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class tundishtemp6 : spc.spclf
    {
        public tundishtemp6()
        {
            unit_like = "61%";
            qcitemcode = "TEMP";
            qc_des = "6#铸机中包温度";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S66";
            maintype = "tundishtemp";
            InitializeComponent();
        }
    }
}

