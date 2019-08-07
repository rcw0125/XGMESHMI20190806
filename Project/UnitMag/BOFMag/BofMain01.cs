using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFMain01 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public BOFMain01()
        {
            MainUnitType = UnitType.BOF;
            CurUnitID = 1;

            InitializeComponent();
        }
    }
}