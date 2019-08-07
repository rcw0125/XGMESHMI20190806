using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHMain01 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public RHMain01()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.RH;
            CurUnitID = 1;

            InitializeComponent();
        }
    }
}

