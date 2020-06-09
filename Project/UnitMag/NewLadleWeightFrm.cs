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
    public partial class NewLadleWeightFrm : DockContent, IMESForm
    {
        public NewLadleWeightFrm()
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
            if (dDateLength > 32)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
 //           select a.heatid as 炉号,a.ladleno as 钢包,a.weight as 净重,a.grossweight as lf毛重,a.tareweight as 皮重,a.kzweight as 扣除,b.dabaobi as 大包臂,
 //b.grossweight as 大包毛重,b.tareweight as 浇完皮重 ,b.grossweight - b.tareweight as 浇注钢水量,case b.grossweight when null then 0 else b.grossweight - a.grossweight end as 毛重差,
 //b.remainweight as 剩钢    ,
 //(select to_char(castingstarttime, 'MM-dd HH24:MI') from cccm_process_data where heatid = a.heatid ) as 开浇时间,castingtime as 浇注周期,b.casting_weight as 理论重量,b.tundish_weight as 中包重量,
 //b.zhupi_weight as 铸坯重量,zhupi_length as 铸坯长度,zhupi_danzhong as 单重,
 //(select wm_concat(remark)  from cccm_heat_remark where heatid = a.heatid) as 备注     from CLF_LADLE_WEIGHT a,CCCM_LADLE_WEIGHT b where a.heatid is not null
 //and a.heatid = b.heatid(+)
 // and To_Char(a.LOG_TIME,'yyyy-mm-dd') >= '2020-05-10'    and To_Char(a.LOG_TIME,'yyyy-mm-dd') <= '2020-05-25'order by a.log_time desc
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = "  select a.heatid as 炉号,a.ladleno as 钢包,a.weight as 净重,a.grossweight as lf毛重,a.tareweight as 皮重,a.kzweight as 扣除,b.dabaobi as 大包臂,";
            strsql += "  b.grossweight as 大包毛重,b.tareweight as 浇完皮重 ,b.grossweight - b.tareweight as 浇注钢水量,case b.grossweight when null then 0 else b.grossweight - a.grossweight end as 毛重差,  ";
            strsql += "  b.remainweight as 剩钢    , ";
            strsql += "  (select to_char(castingstarttime, 'MM-dd HH24:MI') from cccm_process_data where heatid = a.heatid ) as 开浇时间,castingtime as 浇注周期,b.casting_weight as 理论重量,b.tundish_weight as 中包重量,  ";
            strsql += "  b.zhupi_weight as 铸坯重量,zhupi_length as 铸坯长度,zhupi_danzhong as 单重,  ";
            strsql += "  (select wm_concat(remark)  from cccm_heat_remark where heatid = a.heatid) as 备注     from CLF_LADLE_WEIGHT a,CCCM_LADLE_WEIGHT b where a.heatid is not null  ";
            strsql += "  and a.heatid = b.heatid(+)  ";
            strsql += "   and To_Char(a.LOG_TIME,'yyyy-mm-dd') >= '"+strStart+"'    and To_Char(a.LOG_TIME,'yyyy-mm-dd') <= '"+strEnd+"'order by a.log_time desc";          
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
            CommDataMag.CommonMethed.PutIntoExcel("大包称重分析", dvTel);
        }

        private void dvTel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }

        private void dvTel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //ColumnIndex的顺序是按照数据库查询的顺序而来的，即sql语句字段的顺序
            //string temp = "";
            //if (e.Value != null)
            //{
            //    temp = e.ColumnIndex + e.Value.ToString();
            //}

            //try
            //{
            //    if (e.ColumnIndex == 10)
            //    {
            //        if (e.Value != null && Math.Abs(Convert.ToDouble(e.Value)) > 1.5)
            //        {
            //            e.CellStyle.BackColor = Color.Yellow;
            //        }

            //    }
            //}
            //catch
            //{

            //}

            try
            {
                if (e.ColumnIndex == 11)
                {
                    if (e.Value != null && Convert.ToDouble(e.Value) > 2)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }
            }
            catch
            {

            }

            //try
            //{
            //    if (e.ColumnIndex == 13)
            //    {

            //        if (e.Value != null && Math.Abs(Convert.ToDouble(e.Value))> 1)
            //        {
            //            e.CellStyle.BackColor = Color.Yellow;
            //        }

            //    }
            //}
            //catch
            //{

            //}

        }
    }
}