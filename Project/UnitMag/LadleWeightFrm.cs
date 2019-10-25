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
            // 
    //        select heatid as ¯��,ladleno as �ְ�,grossweight as lfë��,tareweight as Ƥ��,kzweight as ����, ccmgrossweight as ���ë��,ccmtareweight as ����Ƥ��,ccmlasttareweight as ��¯Ƥ��

    //from CLF_LADLE_WEIGHT where To_Char(LOG_TIME, 'yyyy-mm-dd') = '2019-09-05' and heatid is not null order by log_time desc;
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            string strsql = " select heatid as ¯��,ladleno as �ְ�,weight as ����,grossweight as lfë��,tareweight as Ƥ��,kzweight as �۳�,area as �����, ccmgrossweight as ���ë��,ccmtareweight as ����Ƥ��,ccmlasttareweight as ��¯Ƥ��";
            strsql += "  ,case ccmgrossweight when null then 0 else ccmgrossweight-grossweight end as ë�ز�,(select round(remainweight,1) FROM cccm_heat_ladle where heatid=CLF_LADLE_WEIGHT.heatid and rownum=1) as ʣ��  ";
            strsql += "  ,ccminputareweight as ����Ƥ��,ccmgrossweight-weight-ccminputareweight as Ƥ�����,lfjyweight as ���� ";
            strsql += "  ,( select to_char(castingstarttime,'MM-dd HH24:MI') from cccm_process_data where heatid=CLF_LADLE_WEIGHT.heatid ) as ����ʱ��  ";
            strsql += "  ,( select wm_concat(remark)  from cccm_heat_remark where heatid=CLF_LADLE_WEIGHT.heatid) as ��ע  ";
            strsql += "   from CLF_LADLE_WEIGHT where  heatid is not null   and To_Char(LOG_TIME,'yyyy-mm-dd') >= '" + strStart + "'";          
            strsql += "    and  To_Char(LOG_TIME,'yyyy-mm-dd') <= '" + strEnd + "'order by log_time desc";

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