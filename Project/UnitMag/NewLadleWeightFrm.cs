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
            double dDateLength = Math.Round((tdtend.Value.ToOADate() - tdtstart.Value.ToOADate() + 1), 0);
            if (dDateLength > 32)
            {
                MessageBox.Show("���ѯʱ������һ�����ڵ����ݣ�", "��ʾ");
                return;
            }
 //           select a.heatid as ¯��,a.ladleno as �ְ�,a.weight as ����,a.grossweight as lfë��,a.tareweight as Ƥ��,a.kzweight as �۳�,b.dabaobi as �����,
 //b.grossweight as ���ë��,b.tareweight as ����Ƥ�� ,b.grossweight - b.tareweight as ��ע��ˮ��,case b.grossweight when null then 0 else b.grossweight - a.grossweight end as ë�ز�,
 //b.remainweight as ʣ��    ,
 //(select to_char(castingstarttime, 'MM-dd HH24:MI') from cccm_process_data where heatid = a.heatid ) as ����ʱ��,castingtime as ��ע����,b.casting_weight as ��������,b.tundish_weight as �а�����,
 //b.zhupi_weight as ��������,zhupi_length as ��������,zhupi_danzhong as ����,
 //(select wm_concat(remark)  from cccm_heat_remark where heatid = a.heatid) as ��ע     from CLF_LADLE_WEIGHT a,CCCM_LADLE_WEIGHT b where a.heatid is not null
 //and a.heatid = b.heatid(+)
 // and To_Char(a.LOG_TIME,'yyyy-mm-dd') >= '2020-05-10'    and To_Char(a.LOG_TIME,'yyyy-mm-dd') <= '2020-05-25'order by a.log_time desc
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = "  select a.heatid as ¯��,a.ladleno as �ְ�,a.weight as ����,a.grossweight as lfë��,a.tareweight as Ƥ��,a.kzweight as �۳�,b.dabaobi as �����,";
            strsql += "  b.grossweight as ���ë��,b.tareweight as ����Ƥ�� ,b.grossweight - b.tareweight as ��ע��ˮ��,case b.grossweight when null then 0 else b.grossweight - a.grossweight end as ë�ز�,  ";
            strsql += "  b.remainweight as ʣ��    , ";
            strsql += "  (select to_char(castingstarttime, 'MM-dd HH24:MI') from cccm_process_data where heatid = a.heatid ) as ����ʱ��,castingtime as ��ע����,b.casting_weight as ��������,b.tundish_weight as �а�����,  ";
            strsql += "  b.zhupi_weight as ��������,zhupi_length as ��������,zhupi_danzhong as ����,  ";
            strsql += "  (select wm_concat(remark)  from cccm_heat_remark where heatid = a.heatid) as ��ע     from CLF_LADLE_WEIGHT a,CCCM_LADLE_WEIGHT b where a.heatid is not null  ";
            strsql += "  and a.heatid = b.heatid(+)  ";
            strsql += "   and To_Char(a.LOG_TIME,'yyyy-mm-dd') >= '"+strStart+"'    and To_Char(a.LOG_TIME,'yyyy-mm-dd') <= '"+strEnd+"'order by a.log_time desc";          
            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='Ͷ��' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

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
            CommDataMag.CommonMethed.PutIntoExcel("������ط���", dvTel);
        }

        private void dvTel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }

        private void dvTel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //ColumnIndex��˳���ǰ������ݿ��ѯ��˳������ģ���sql����ֶε�˳��
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