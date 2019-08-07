//add by hyh 2012-03-29
//新增铁水样报警显示界面
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag
{
    public partial class IronWarnDisplay : DockContent, IMESForm
    {
        public IronWarnDisplay()
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

        //导出到EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("铁水进站样信息",dvIronInfo );
        }

       
        private void IronWarnDisplay_Load(object sender, EventArgs e)
        {
            dtStart.Text = System.DateTime.Now.AddDays(-7).ToShortDateString();
            dtEnd.Text = System.DateTime.Now.ToShortDateString();
            //加载钢种下拉列表
            dsSteelGradeStd.LoadData();
            tsCmbSteelGrade.Items.Add("全部");
            tsCmbSteelGrade.Items.Add("清空");
            if (dsSteelGradeStd != null && dsSteelGradeStd.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsSteelGradeStd.Tables[0].Rows)
                {
                    string strSteelGrade = dr["SteelGrade"].ToString();
                    tsCmbSteelGrade.Items.Add(strSteelGrade);
                }
            }
            dvSteelGrade_SelectionChanged(null, null);
            tsCmbSteelGrade.SelectedIndex = 1;
            //btnQuery_Click(null, null);
           
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //dsSteelGradeStd.SourceCondition = "1=2";
            //dsSteelGradeStd.LoadData();
            tsCmbSteelGrade.SelectedIndex = 1;
            dsIronInfo.SourceCondition = "1=2";
            dsWeight.SourceMethod = "SELECT   tap_no, ROUND (SUM (net_weight), 2) AS weight  FROM cbfiron where 1=2  GROUP BY tap_no order by tap_no";
            dsIronInfo.Tables[0].Clear();
            dsWeight.Tables[0].Clear();
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            string strSQL = "";
            string strWeightSQL = "";

            strSQL = "Production_Date between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";
            strWeightSQL = " SELECT   tap_no, ROUND (SUM (net_weight), 2) AS weight  FROM cbfiron where Curr_Tare > 0";
            strWeightSQL += " and Production_Date between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";

            if (cmbSoure.Text.Trim() != "")
            {
                if (cmbSoure.Text.Trim().Substring(0, 1) != "2")
                {
                    strSQL += " and Source = '" + cmbSoure.Text.Trim().Substring(0, 1) + "'";
                    strWeightSQL += " and Source = '" + cmbSoure.Text.Trim().Substring(0, 1) + "'";
                }
            }

            if (cmbPath.Text.Trim() != "")
            {
                if (cmbPath.Text.Substring(0, 1) != "3")
                {
                    strSQL += " and Destination = '" + cmbPath.Text.Substring(0, 1) + "' ";

                    strWeightSQL += " and Destination = '" + cmbPath.Text.Substring(0, 1) + "' ";
                }
            }

            strSQL += " order by Production_Date asc";
            dsIronInfo.SourceCondition = strSQL;
            strWeightSQL += " GROUP BY tap_no order by tap_no";
            dsWeight.SourceMethod = strWeightSQL;
        }

        //绘制行级
        private void dvIronInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender,e);//绘制行级

        }

        //根据钢种显示、报警
        private void tsCmbSteelGrade_TextChanged(object sender, EventArgs e)
        {
            //dvSteelGrade的显示
            dsSteelGradeStd.Tables[0].Clear();
            if (tsCmbSteelGrade.Text.Equals("全部"))
                dsSteelGradeStd.SourceCondition = "1=1";
            else if(tsCmbSteelGrade.Text.Equals("清空"))
                dsSteelGradeStd.SourceCondition = "1=2";
            else
                dsSteelGradeStd.SourceCondition = "SteelGrade='" + tsCmbSteelGrade.Text + "'";
            dsSteelGradeStd.LoadData();
            //报警  超出上限 yellow  超出下限 blue
        }

        private void dvSteelGrade_SelectionChanged(object sender, EventArgs e)
        {
            //将颜色还原为无色
            setWarnToDvIronInfo("temp", "1", "2", false);
            if (dvSteelGrade.SelectedRows == null||dvSteelGrade.SelectedRows.Count==0)
            { 
                return;
            }
            string strMax = ""; string strMin = "";
            try
            {
                //C
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["cMaxDataGridViewTextBoxColumn"].Value.ToString();//C最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["cMinDataGridViewTextBoxColumn"].Value.ToString();//C最小
                setWarnToDvIronInfo("c", strMax, strMin,true);
                //Si
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["siMaxDataGridViewTextBoxColumn"].Value.ToString();//Si最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["siMinDataGridViewTextBoxColumn"].Value.ToString();//Si最小
                setWarnToDvIronInfo("si", strMax, strMin,true);
                //Mn
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["mnMaxDataGridViewTextBoxColumn"].Value.ToString();//Mn最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["mnMinDataGridViewTextBoxColumn"].Value.ToString();//Mn最小
                setWarnToDvIronInfo("mn", strMax, strMin,true);
                //P
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["pMaxDataGridViewTextBoxColumn"].Value.ToString();//P最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["pMinDataGridViewTextBoxColumn"].Value.ToString();//P最小
                setWarnToDvIronInfo("p", strMax, strMin,true);
                //S
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["sMaxDataGridViewTextBoxColumn"].Value.ToString();//S最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["sMinDataGridViewTextBoxColumn"].Value.ToString();//S最小
                setWarnToDvIronInfo("s", strMax, strMin,true);
                //Ti
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["tiMaxDataGridViewTextBoxColumn"].Value.ToString();//Ti最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["tiMinDataGridViewTextBoxColumn"].Value.ToString();//Ti最小
                setWarnToDvIronInfo("ti", strMax, strMin,true);
                //Sn
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["snMaxDataGridViewTextBoxColumn"].Value.ToString();//Sn最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["snMinDataGridViewTextBoxColumn"].Value.ToString();//Sn最小
                setWarnToDvIronInfo("sn", strMax, strMin,true);
                //Sb
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["sbMaxDataGridViewTextBoxColumn"].Value.ToString();//Sb最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["sbMinDataGridViewTextBoxColumn"].Value.ToString();//Sb最小
                setWarnToDvIronInfo("sb", strMax, strMin,true);
                //As
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["asMaxDataGridViewTextBoxColumn"].Value.ToString();//As最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["asMinDataGridViewTextBoxColumn"].Value.ToString();//As最小
                setWarnToDvIronInfo("as", strMax, strMin,true);
                //Pb
                strMax = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["pbMaxDataGridViewTextBoxColumn"].Value.ToString();//Pb最大
                strMin = ((DataGridViewRow)(dvSteelGrade.SelectedRows[0])).Cells["pbMinDataGridViewTextBoxColumn"].Value.ToString();//Pb最小
                setWarnToDvIronInfo("pb", strMax, strMin,true);
            }
            catch { }

        }

        //对dvIronInfo进行颜色分别显示报警
        private void setWarnToDvIronInfo(string strEle, string strMax, string strMin,bool isColor)
        {
            if ((strMax.Trim() == "" && strMin.Trim() == "") || (strMax.Trim() == "0" && strMin.Trim() == "0"))
                return;
            if (strMax == "")
                strMax = "0";
            if (strMin == "")
                strMin = "0";
            
            if (dvIronInfo == null || dvIronInfo.RowCount < 1)
                return;
            if (isColor)
            {
                for (int i = 0; i < dvIronInfo.RowCount; i++)
                {
                    try
                    {
                        string strValue = dvIronInfo[strEle.ToLower() + "DataGridViewTextBoxColumn", i].Value.ToString();
                        if (strValue == "")
                            continue;
                        if (Convert.ToDouble(strValue) > Convert.ToDouble(strMin) && Convert.ToDouble(strValue) < Convert.ToDouble(strMax))
                            continue;
                        //dvIronInfo[strEle.ToLower() + "DataGridViewTextBoxColumn", i].Style.ForeColor
                        if (Convert.ToDouble(strValue) > Convert.ToDouble(strMax))  //大于最大
                            dvIronInfo[strEle.ToLower() + "DataGridViewTextBoxColumn", i].Style.ForeColor = Color.Red;
                        if (Convert.ToDouble(strValue) < Convert.ToDouble(strMin))     //小于最小
                            dvIronInfo[strEle.ToLower() + "DataGridViewTextBoxColumn", i].Style.ForeColor = Color.Blue;
                    }
                    catch { continue; }

                }
            }
            else
            {
                for (int i = 0; i < dvIronInfo.RowCount; i++)
                {
                    for (int j = 0; j < dvIronInfo.ColumnCount; j++)
                    {
                        try
                        {
                            Color clr = dvIronInfo[1, i].Style.ForeColor;
                            dvIronInfo[j, i].Style.ForeColor = clr;
                        }
                        catch { continue; }
                    }
                }

            }

        }

        private void dvSteelGrade_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvIronInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void IronWarnDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvSteelGrade_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

 
       
 
      
    
    }
}