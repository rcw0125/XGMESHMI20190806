using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFLadleInfo : Form
    {
        public string ladleid = "";
        public LFLadleInfo()
        {
            InitializeComponent();
           
        }

        public void getLadleInfo(string ladleid)
        {
            if (ladleid == "")
            {
                return;
            }
            string sql = " select* from( ";
            sql += " select heatid as 炉号,cur_steelgrade as 钢种,(select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = CLF_LADLE_INFO.heatid) as 包次号,act_ladle_grade as 包况,ladle_age as 包龄, ";
            sql += " stop_time_len as 停用时长,temp as 上次二十分温降,maxtemp as 上次转包温降,c_ts as 时间 ";
            sql += " from CLF_LADLE_INFO  where ladleid = '"+ladleid+"' order by c_ts desc ";
            sql += " ) where rownum<= 10 ";
            var dt = UnitMag.MESTool.GetData(Adapter, sql);
            dataGridView1.DataSource = dt;
        }

        private void LFLadleInfo_Load(object sender, EventArgs e)
        {
            getLadleInfo(ladleid);
        }
    }
}
