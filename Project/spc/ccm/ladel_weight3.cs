using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class ladel_weight3 : spc.spclf
    {
        public ladel_weight3()
        {
            unit_like = "31%";
            qcitemcode = "CASTINGTUNDISHWEIGHT";
            qc_des = "3#铸机中包开浇重量";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S63";
            maintype = "weight";
            InitializeComponent();
        }
    }
}

