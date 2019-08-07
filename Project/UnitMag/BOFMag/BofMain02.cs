using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFMain02 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public BOFMain02()
        {
            MainUnitType = UnitType.BOF;
            CurUnitID = 2;

            InitializeComponent();
        }
    }
}

