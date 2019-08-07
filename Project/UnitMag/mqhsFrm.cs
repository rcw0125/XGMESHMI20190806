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
    public partial class mqhsFrm : DockContent, IMESForm
    {
        public mqhsFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

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
            double dDateLength = Math.Round((tdtend.Value.ToOADate() - tdtstart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            //            select a.heatid as 炉号,a.khssk as 可回收时刻,a.hssk as 实际回收时刻,a.khstime as 可回收时间,a.hstime as 实际回收时间, a.khstime - a.hstime as 差值,
            //       b.reblow_count as 补吹次数,b.blowo2_time as 供氧时间,b.blowo2_time - a.hstime as 供氧回收时间差,round(c.ironweight, 1) as 铁水 ,round(c.scrapweight, 1) as 废钢
            //from CBOF_MQHS_TJ a,cbof_process_data b, cbof_feed_data c where a.heatid = b.heatid and a.heatid = c.heatid order by a.heatid desc;
            //b.reblow_count as 补吹次数,
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = " select a.heatid as 炉号,a.khssk as 可回收时刻,a.hssk as 实际回收时刻,a.khstime as 可回收时间,a.hstime as 实际回收时间, a.khstime - a.hstime as 差值,a.tqcount as 提枪次数,";
            strsql += "   b.reblow_count as 补吹次数,b.blowo2_time as 供氧时间,b.blowo2_time - a.hstime as 供氧回收时间差,round(c.ironweight, 1) as 铁水 ,round(c.scrapweight, 1) as 废钢,a.co5 as 五万柜CO含量,a.co8 as 八万柜CO含量, ";
            strsql += "    To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd HH24:MI:SS') as 生产日期,(select wm_concat(remark) from cbof_heatremark where heatid=a.heatid and typeid=2 ) as 备注 ";
            strsql += "    from CBOF_MQHS_TJ a,cbof_process_data b, cbof_feed_data c where a.heatid = b.heatid and a.heatid = c.heatid  and To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd') >= '" + strStart + "'";          
            strsql += "    and  To_Char(b.CHARGING_START_TIME,'yyyy-mm-dd') <= '" + strEnd + "' order by a.heatid desc";

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='投料' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            tdtstart.Value = DateTime.Now;
            tdtend.Value = DateTime.Now;
        }



        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("煤气回收统计", dvTel);
        }
    }
}