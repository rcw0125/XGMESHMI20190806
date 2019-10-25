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
    public partial class LfdhFrm : DockContent, IMESForm
    {
        public LfdhFrm()
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

            //            select e.lfid as 精炼炉,e.dl as 炉次总耗电,e.weight as 炉次钢水量,e.dunhao as 炉次吨耗电耗,f.ztdl as 当天耗电,
            //round(f.ztdl / e.weight, 1) as 实际电耗,round(f.ksdl, 2) as 当天开始电表数,round(f.jsdl, 2) as 当天结束电表数
            //from
            //(select a.lfid, a.dl, b.weight, round(a.dl / b.weight, 1) as dunhao
            //from(select lfid, sum(dl) as dl from xgwebrpt.TR_LF_ORIGINALDATA where logtime = '2019-08-29' group by lfid) a,
            //(select sum(steel_weight) as weight, lfid
            //from(select distinct(heatid), steel_weight, lfid from xgwebrpt.TR_LF_ORIGINALDATA where logtime = '2019-08-29')
            //group by lfid) b where a.lfid = b.lfid) e,
            //(select c.lfid,c.ksdl,c.jsdl,(c.jsdl - c.ksdl) * d.bl as ztdl
            //from(select lfid, max(val) as jsdl, min(val) as ksdl from ts_lf_dh where c_ts like '2019-08-29%' group by lfid) c,
            //(select lfid, emsaddress as bl from LFDIANBIAOPEIZHI) d where c.lfid = d.lfid) f
            //   where e.lfid = f.lfid order by e.lfid
            //select lfid as 炉座,dl as 炉次总电量,weight as 钢水量,dunhao as 炉次吨耗,dtdl as 当天实际电耗,sjdh as 实际吨耗,logtime as 时间 from XGWEBRPT.TS_lf_dhtj order by lfid, logtime
            string strStart = tdtstart.Value.ToString("yyyy-MM");
            //string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = " select lfid as 炉座,dl as 炉次总电量,weight as 钢水量,dunhao as 炉次吨耗,dtdl as 当天实际电耗,sjdh as 实际吨耗,logtime as 时间 ";
            strsql += "       from XGWEBRPT.TS_lf_dhtj where logtime like '"+strStart+"%' order by lfid, logtime ";
           
            //strsql += "    and   logtime <= '" + strEnd + "' order by treatno";

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='投料' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            tdtstart.Value = DateTime.Now;
            //tdtend.Value = DateTime.Now;
        }



        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("LF电耗统计", dvTel);
        }
    }

}