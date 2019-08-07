using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_p2 : spc.spcform
    {
        public zhongdian_p2()
        {
            unit = "Z2";
            unit_like = "22%";
            qcitemcode = "P";
            qctypecode = "GT";
            qc_des = "2#Â¯ÖÕµãP";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S22";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

