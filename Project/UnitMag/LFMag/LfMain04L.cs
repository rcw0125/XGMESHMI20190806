using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LfMain04L : UnitMag.Steel.BSteel
    {
        public LfMain04L()
        {
            MainUnitType = UnitMag.Steel.UnitType.LF;
            CurUnitID = 4;
            InitializeComponent();
        }
    }
}

