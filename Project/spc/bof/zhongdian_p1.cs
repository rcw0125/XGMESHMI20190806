using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class zhongdian_p1 : spc.spcform
    {
        public zhongdian_p1()
        {
            unit = "Z1";
            unit_like = "21%";
            qcitemcode = "P";
            qctypecode = "GT";
            qc_des = "1#Â¯ÖÕµãP";
            DataObject = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\S21";
            maintype = "zhongdian";
            InitializeComponent();
        }
    }
}

