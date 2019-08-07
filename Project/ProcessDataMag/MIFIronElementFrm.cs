using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace ProcessDataMag
{
    public partial class MIFIronElementFrm : DockContent, IMESForm
    {
        public MIFIronElementFrm()
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

        //界面加载
        private void MIFIronElementFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsElement.Tables[0].Clear();

                LineProc.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
                string strAddress="";
                if (cmbMIFID.Text == "")
                {
                    MessageBox.Show("请选择混铁炉！", "提示");
                    return;
                }
                else
                {
                    if(cmbMIFID.Text == "1#混铁炉")
                    {
                        strAddress="H1";
                    }
                    else if(cmbMIFID.Text == "2#混铁炉")
                    {
                         strAddress="H2";
                    }
                    //add by hyh 2012-04-05
                    else if (cmbMIFID.Text == "3#混铁炉")
                    {
                        strAddress = "H3";
                    }
                    //end
                    else
                    {strAddress="";}
                }
                if(strAddress=="")
                {
                     MessageBox.Show("选择混铁炉不存在！", "提示");
                    return;
                }
                if (cmbElement.Text == "")
                {
                    MessageBox.Show("请选择成分！", "提示");
                    return;
                }
                if (cmbElement.Text.Trim() == "S")
                {
                    tChart1.Axes.Left.Maximum = 0.05;
                    tChart1.Axes.Left.Minimum = 0;
                }
                else if (cmbElement.Text.Trim() == "Si")
                {
                    tChart1.Axes.Left.Maximum = 0.8;
                    tChart1.Axes.Left.Minimum = 0.3;
                }
                else if (cmbElement.Text.Trim() == "P")
                {
                    tChart1.Axes.Left.Maximum = 0.09;
                    tChart1.Axes.Left.Minimum = 0.04;
                }

                dsElement.SourceMethod = "SELECT report_date,0 Element from cqa_iron_element where 1=2";
               
                string strElement = cmbElement.Text.Trim();
                string strSQL = "";

                strSQL += "  SELECT   report_date, " + strElement + " as Element                        ";
                strSQL += "    FROM cqa_iron_element                                                    ";
                strSQL += "   WHERE TO_CHAR (report_date, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'    ";
                strSQL += "         AND sample_address = '" + strAddress + "'                           ";
                strSQL += "ORDER BY report_date                                                         ";
               
                dsElement.SourceMethod = strSQL;
                if (dsElement.Tables[0].Rows.Count > 0)
                {
                    tChart1.Axes.Top.Minimum = Convert.ToDateTime(dsElement.Tables[0].Rows[0]["report_date"]).ToOADate();
                    tChart1.Axes.Top.Maximum = Convert.ToDateTime(dsElement.Tables[0].Rows[dsElement.Tables[0].Rows.Count - 1]["report_date"]).ToOADate();
                    tChart1.Axes.Top.EndPosition = Convert.ToDateTime(dsElement.Tables[0].Rows[dsElement.Tables[0].Rows.Count - 1]["report_date"]).ToOADate();

                }
                else
                {
                    tChart1.Axes.Top.Minimum = 0;
                    tChart1.Axes.Top.Maximum = 0;
                    tChart1.Axes.Top.EndPosition = 0;
                }
                LineProc.DataSource = dsElement;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
            catch
            {
                tChart1.Axes.Top.Minimum = 0;
                tChart1.Axes.Top.Maximum = 0;
                tChart1.Axes.Top.EndPosition = 0;

                LineProc.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current >= 1)
                {
                    this.tChart1.Page.Current = 1;
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current > 1)
                {
                    this.tChart1.Page.Previous();
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current < this.tChart1.Page.Count)
                {
                    this.tChart1.Page.Next();
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                this.tChart1.Page.Current = this.tChart1.Page.Count;
                tChart1.Refresh();
            }
            catch { }
        }
    }
}



 