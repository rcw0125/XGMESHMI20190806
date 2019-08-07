using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class Remark : Form
    {
        public Remark()
        {
            InitializeComponent();
        }

        public bool remark(string heatid, string alarmtype, ref string yuanyin, ref string gaijin)
        {
            tbHeatid.Text = heatid;
            tbAlarmtype.Text = alarmtype;
            tbYuanyin.Text = yuanyin;
            tbGaijin.Text = gaijin;
            if (ShowDialog() != DialogResult.OK)
                return false;
            yuanyin = tbYuanyin.Text.Trim();
            gaijin = tbGaijin.Text.Trim();
            return true;
        }
    }
}