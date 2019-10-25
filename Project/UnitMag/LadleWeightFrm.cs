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
    public partial class LadleWeightFrm : DockContent, IMESForm
    {
        public LadleWeightFrm()
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
            // 
    //        select heatid as 炉号,ladleno as 钢包,grossweight as lf毛重,tareweight as 皮重,kzweight as 渣重, ccmgrossweight as 大包毛重,ccmtareweight as 浇完皮重,ccmlasttareweight as 上炉皮重

    //from CLF_LADLE_WEIGHT where To_Char(LOG_TIME, 'yyyy-mm-dd') = '2019-09-05' and heatid is not null order by log_time desc;
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = " select heatid as 炉号,ladleno as 钢包,weight as 净重,grossweight as lf毛重,tareweight as 皮重,kzweight as 扣除,area as 大包臂, ccmgrossweight as 大包毛重,ccmtareweight as 浇完皮重,ccmlasttareweight as 上炉皮重";
            strsql += "  ,case ccmgrossweight when null then 0 else ccmgrossweight-grossweight end as 毛重差,(select round(remainweight,1) FROM cccm_heat_ladle where heatid=CLF_LADLE_WEIGHT.heatid and rownum=1) as 剩钢  ";
            strsql += "  ,ccminputareweight as 输入皮重,ccmgrossweight-weight-ccminputareweight as 皮重误差,lfjyweight as 浇余 ";
            strsql += "  ,( select to_char(castingstarttime,'MM-dd HH24:MI') from cccm_process_data where heatid=CLF_LADLE_WEIGHT.heatid ) as 开浇时间  ";
            strsql += "  ,( select wm_concat(remark)  from cccm_heat_remark where heatid=CLF_LADLE_WEIGHT.heatid) as 备注  ";
            strsql += "   from CLF_LADLE_WEIGHT where  heatid is not null   and To_Char(LOG_TIME,'yyyy-mm-dd') >= '" + strStart + "'";          
            strsql += "    and  To_Char(LOG_TIME,'yyyy-mm-dd') <= '" + strEnd + "'order by log_time desc";

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

            try
            {
                if (e.ColumnIndex == 10)
                {
                    if (e.Value != null && Math.Abs(Convert.ToDouble(e.Value)) > 1.5)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }

                }
            }
            catch
            {

            }

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

            try
            {
                if (e.ColumnIndex == 13)
                {

                    if (e.Value != null && Math.Abs(Convert.ToDouble(e.Value))> 1)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }

                }
            }
            catch
            {

            }

        }
    }
}