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
            MainUnitType = UnitMag.BOFMag.UnitType.LF;      //������������ LF����
            CurUnitID = 5;                                  //   ��ǰ����ID

            InitializeComponent();
        }
    }

    //Modify End
}