using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class tundishtemp3 : spc.spclf
    {
        public tundishtemp3()
        {
            unit_like = "31%";
            qcitemcode = "TEMP";
            qc_des = "3#铸机中包温度";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S63";
            maintype = "tundishtemp";
            InitializeComponent();
        }
    }
}

