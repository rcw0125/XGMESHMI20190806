using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SbMag
{
    public partial class sbyb : Form
    {
        public sbyb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LgWR.sbgl sbfw = new LgWR.sbgl();
            var data = sbfw.GetDjjl("2019-06","","");
            dataGridView1.DataSource = data;
        }

        private void sbyb_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CommDataMag.CommonMethed.PutIntoExcelforsbgl("设备点检月报", dataGridView1);
        }



    }
}
