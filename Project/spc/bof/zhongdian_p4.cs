using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_p4 : spc.spcform
    {
        public zhongdian_p4()
        {
            unit = "Z4";
            unit_like = "24%";
            qcitemcode = "P";
            qctypecode = "GT";
            qc_des = "4#Â¯ÖÕµãP";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S24";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

