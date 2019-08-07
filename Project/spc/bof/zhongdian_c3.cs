using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_c3 : spc.spcform
    {
        public zhongdian_c3()
        {
            unit = "Z3";
            unit_like = "23%";
            qcitemcode = "C";
            qctypecode = "GT";
            qc_des = "3#Â¯ÖÕµãC";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

