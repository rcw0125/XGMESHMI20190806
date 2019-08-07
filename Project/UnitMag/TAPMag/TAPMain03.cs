using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TAPMain03 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public TAPMain03()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.TAP;
            CurUnitID = 3;

            InitializeComponent();
        }
    }
}

