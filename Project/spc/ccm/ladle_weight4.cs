using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class ladle_weight4 : spc.spclf
    {
        public ladle_weight4()
        {
            unit_like = "41%";
            qcitemcode = "CASTINGTUNDISHWEIGHT";
            qc_des = "4#铸机中包开浇重量";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S64";
            maintype = "weight";
            InitializeComponent();
        }
    }
}

