using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class ladle_weight5 : spc.spclf
    {
        public ladle_weight5()
        {
            unit_like = "51%";
            qcitemcode = "CASTINGTUNDISHWEIGHT";
            qc_des = "5#铸机中包开浇重量";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S65";
            maintype = "weight";
            InitializeComponent();
        }
    }
}

