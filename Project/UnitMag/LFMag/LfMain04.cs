using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LfMain04 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public LfMain04()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.LF;
            CurUnitID = 4;

            InitializeComponent();
        }
    }
}