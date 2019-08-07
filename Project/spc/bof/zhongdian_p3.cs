using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_p3 : spc.spcform
    {
        public zhongdian_p3()
        {
            unit = "Z3";
            unit_like = "23%";
            qcitemcode = "P";
            qctypecode = "GT";
            qc_des = "3#Â¯ÖÕµãP";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S23";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

