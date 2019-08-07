using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class ladle_weight7 : spc.spclf
    {
        public ladle_weight7()
        {
            unit_like = "71%";
            qcitemcode = "CASTINGTUNDISHWEIGHT";
            qc_des = "7#铸机中包开浇重量";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S67";
            maintype = "weight";
            InitializeComponent();
        }
    }
}

