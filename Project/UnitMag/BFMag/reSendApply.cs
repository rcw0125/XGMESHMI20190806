using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class reSendApply : Form
    {
        public reSendApply()
        {
            InitializeComponent();
            loadData();
        }
        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        public void loadData()
        {
            string strsql = "select distinct(tap_no) as Tap_No  from cbfiron where nc_confirm_flag=0";
            dsTapno.SourceMethod = strsql;
            dsTapno.LoadData();
            dataGridView1.DataSource = dsTapno.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count < 1)
            {
                return;
            }
            dsSendNo.Tables[0].Rows.Clear();
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((dataGridView1.Rows[i].Cells["Column1"].Value!=null)&&(dataGridView1.Rows[i].Cells["Column1"].Value.ToString() == "1"))
                    {
                      
                        DataRow newrow = dsSendNo.Tables[0].NewRow();
                        newrow["TAP_No"] = dataGridView1.Rows[i].Cells["Column2"].Value.ToString();
                        dsSendNo.Tables[0].Rows.Add(newrow);

                       // TAP_No
                    }
                   
                }
            }
            catch
            {
                return;
            }
            if (dsSendNo.Tables[0].Rows.Count < 1)
                return;
            try
            {
                cmdToLab.Parameters[0].SourceObject = dsSendNo;
                cmdToLab.Execute();
                int i = Convert.ToInt16(cmdToLab.Result.ToString());
                if (i >= 0)
                {
                    MessageBox.Show("发送成功");
                }
                else
                {
                    MessageBox.Show("发送失败" + i.ToString());
                }
            }
            catch
            {

                return;
            }
          
            //foreach (DataRow dr in dsSendNo.Tables[0].Rows)
            //{
            //    foreach (DataColumn col in dsSendNo.Tables[0].Columns)
            //    {
            //        MessageBox.Show(dr[col].ToString());
                
            //    }
            //}
            //MessageBox.Show(dsSendNo.Tables[0].Rows[0][0].ToString());
        }
    }
}