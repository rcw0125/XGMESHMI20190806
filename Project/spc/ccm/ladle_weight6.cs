using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class ladle_weight6 : spc.spclf
    {
        public ladle_weight6()
        {
            unit_like = "61%";
            qcitemcode = "CASTINGTUNDISHWEIGHT";
            qc_des = "6#铸机中包开浇重量";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S66";
            maintype = "weight";
            InitializeComponent();
        }
    }
}

