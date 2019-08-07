using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.ccm
{
    public partial class tundishtemp5 : spc.spclf
    {
        public tundishtemp5()
        {
            unit_like = "51%";
            qcitemcode = "TEMP";
            qc_des = "5#铸机中包温度";
            DataObject = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\S65";
            maintype = "tundishtemp";
            InitializeComponent();
        }
    }
}

