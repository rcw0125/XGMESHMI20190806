using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TAPMain01 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public TAPMain01()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.TAP;
            CurUnitID = 1;

            InitializeComponent();
        }
    }
}

