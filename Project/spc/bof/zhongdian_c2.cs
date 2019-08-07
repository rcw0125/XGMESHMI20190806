using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_c2 : spc.spcform
    {
        public zhongdian_c2()
        {
            unit = "Z2";
            unit_like = "22%";
            qcitemcode = "C";
            qctypecode = "GT";
            qc_des = "2#Â¯ÖÕµãC";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

