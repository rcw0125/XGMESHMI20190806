using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFMain02 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public LFMain02()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.LF;
            CurUnitID = 2;

            InitializeComponent();
        }
    }
}

