using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace testWebService
{
    public partial class Form1 : Form
    {
        public testWebService.mes.WebService mes;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mes = new mes.WebService();
            var data = mes.GetMaterial("241806558");
            dataGridView1.DataSource = data.Tables[0];
            dataGridView2.DataSource = data.Tables[1];

        }
    }
}
