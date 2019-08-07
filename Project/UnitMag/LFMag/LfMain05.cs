using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{     //Modify By HuYunHai  Begin 2011-02-15
    public partial class LfMain05 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public LfMain05()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.LF;      //主机主类型是 LF机主
            CurUnitID = 5;                                  //   当前工序ID

            InitializeComponent();
        }
    }

    //Modify End
}