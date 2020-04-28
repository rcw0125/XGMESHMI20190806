using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;


namespace UnitMag
{
    public partial class trainWeiZhiFrm : DockContent, IMESForm
    {
        public trainWeiZhiFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion
        public static string strSQL = "";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //double dDateLength = Math.Round((tdtend.Value.ToOADate() - tdtstart.Value.ToOADate() + 1), 0);
            //if (dDateLength > 32)
            //{
            //    MessageBox.Show("���ѯʱ������һ�����ڵ����ݣ�", "��ʾ");
            //    return;
            //}
            ////            select a.heatid as ¯��,a.khssk as �ɻ���ʱ��,a.hssk as ʵ�ʻ���ʱ��,a.khstime as �ɻ���ʱ��,a.hstime as ʵ�ʻ���ʱ��, a.khstime - a.hstime as ��ֵ,
            ////       b.reblow_count as ��������,b.blowo2_time as ����ʱ��,b.blowo2_time - a.hstime as ��������ʱ���,round(c.ironweight, 1) as ��ˮ ,round(c.scrapweight, 1) as �ϸ�
            ////from CBOF_MQHS_TJ a,cbof_process_data b, cbof_feed_data c where a.heatid = b.heatid and a.heatid = c.heatid order by a.heatid desc;
            ////b.reblow_count as ��������,
            //string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            //string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            //string strsql = " select a.heatid as ¯��,a.khssk as �ɻ���ʱ��,a.hssk as ʵ�ʻ���ʱ��,a.khstime as �ɻ���ʱ��,a.hstime as ʵ�ʻ���ʱ��, a.khstime - a.hstime as ��ֵ,a.tqcount as ��ǹ����,";
            //strsql += "   b.reblow_count as ��������,b.blowo2_time as ����ʱ��,b.blowo2_time - a.hstime as ��������ʱ���,round(c.ironweight, 1) as ��ˮ ,round(c.scrapweight, 1) as �ϸ�,a.co5 as �����CO����,a.co8 as �����CO����, ";
            //strsql += "    To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd HH24:MI:SS') as ��������,(select wm_concat(remark) from cbof_heatremark where heatid=a.heatid and typeid=2 ) as ��ע ";
            //strsql += "    from CBOF_MQHS_TJ a,cbof_process_data b, cbof_feed_data c where a.heatid = b.heatid and a.heatid = c.heatid  and To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd') >= '" + strStart + "'";          
            //strsql += "    and  To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd') <= '" + strEnd + "' order by a.heatid desc";

            //var data = UnitMag.MESTool.GetData(Adapter, strsql);
            //dvTel.DataSource = data;
            //bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='Ͷ��' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

        }




        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //CommDataMag.CommonMethed.PutIntoExcel("ú������ͳ��", dvTel);
        }

        private void trainWeiZhiFrm_Load(object sender, EventArgs e)
        {
            ucTrain1.setno(" 8");
        }
        int startX = 10;
        private void button1_Click(object sender, EventArgs e)
        {

            getWeizhi();
        }

        public void getWeizhi()
        {
            var db = new DbHelp("192.168.36.162", "cmsdb", "sa", "xgmes");
            string sql = "select id,val from  L1OPC_TAG where id=4 ";
            var dt = db.Query(sql);
            var trainList = dt_to_list(dt);
            foreach (var item in trainList)
            {
                if (item.id == 4)
                {
                    int X = item.val;
                    if (X < 0)
                    {
                        X = 0;
                    }
                    else if(X>240)
                    {
                        X = 240;
                    }

                    ucTrain1.Location = new System.Drawing.Point(960-4*X, 41); 
                }
                
            }

        }

        public List<traininfo> dt_to_list(DataTable dt)
        {
            List<traininfo> trainlist = new List<traininfo>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    traininfo tinfo = new traininfo();
                    tinfo.id = Convert.ToInt16(item["id"]);
                    tinfo.val = Convert.ToInt16(item["val"]);
                    trainlist.Add(tinfo);
                }
            }
            return trainlist;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getWeizhi();
        }
    }

    public class traininfo
    {
        public int id { set; get; }
        public int val { set; get; }
    }
}