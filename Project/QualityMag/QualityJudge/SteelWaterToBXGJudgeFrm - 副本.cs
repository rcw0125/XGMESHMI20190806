using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace QualityMag.QualityJudge
{
    public partial class SteelWaterToBXGJudgeFrm : DockContent, IMESForm
    {

        string strCurHeatID = "";

        public SteelWaterToBXGJudgeFrm()
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


        private void SteelWaterToBXGJudgeFrm_Load(object sender, EventArgs e)
        {
            SetSourceCondition();
            SetL3DataAdpter();
           // load();
            dsHeatID.LoadData();
            dvHeatID_Click(sender, e);
        }

        //绘制行
        private void dvHeatID_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

        private void dvHeatGrade_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

        private void dvHeatExcept_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

        private void dvFinalChemical_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

        private void dvRefineThirdEle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }



        //刷新数据
        private void GetData()
        {
            SetSourceCondition();
            SetL3DataAdpter();
            load();

        }

        private void load()
        {
            dsHeatGrade.LoadData();
            dsHeatExcept.LoadData();  //炉次异常
            dsChemicalStd.LoadData();
            dsFinalChemical.LoadData();
            dsRefineThirdEle.LoadData();
           
        }

        private void disposed()
        {
            dsHeatGrade.Clear();
            dsHeatExcept.Clear(); 
            dsChemicalStd.Clear();
            dsFinalChemical.Clear();
            dsRefineThirdEle.Clear();
        }

        //设置SourceCondition
        private void SetSourceCondition()
        {
            disposed();
            //dsHeatGrade.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            dsHeatExcept.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            dsHeatExcept.L3DataAdapter = Adapter;
            dsHeatExcept.LoadData();
            cmdChemicalStd.Parameters[0].ConstantValue = strCurHeatID;
            cmdFinalChemical.Parameters[0].ConstantValue = strCurHeatID;
            cmdRefineThirdEle.Parameters[0].ConstantValue = strCurHeatID;
        }

        //设置L3DataAdpter
        private void SetL3DataAdpter()
        {
            dsHeatExcept.L3DataAdapter = Adapter;
            dsChemicalStd.L3DataAdapter = Adapter;
            dsFinalChemical.L3DataAdapter = Adapter;
            dsRefineThirdEle.L3DataAdapter = Adapter;
            cmdChemicalStd.Adapter = Adapter;
            cmdFinalChemical.Adapter = Adapter;
            cmdRefineThirdEle.Adapter = Adapter;
       
        }

        /*********成分报警***********/


        //铁中样成分
        private void dvFinalChemical_Paint(object sender, PaintEventArgs e)
        {
            #region 铁中样
            if (dvFinalChemical.Rows.Count < 1)
                return;
            for (int i = 0; i < dvFinalChemical.Rows.Count; i++)
            {
                if (dsChemicalStd.Tables[0].Rows.Count > 0)
                {
                    for (int j = CP.Index; j < Other3P.Index; j++)
                    {
                        DataGridViewCell cell = dvFinalChemical.Rows[i].Cells[j];
                        try
                        {
                            //获取实绩成分列名
                            string strDataProName = dvFinalChemical.Columns[cell.ColumnIndex].DataPropertyName;
                            //取出数据
                            double dRealValue = Convert.ToDouble(cell.Value.ToString());
                            //判断是否校验
                            if (dRealValue > 0)
                            {
                                double dStdMax = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Max"].ToString());
                                double dStdMin = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Min"].ToString());
                                CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
                            }
                        }
                        catch { }
                    }
                }
                //成品样
                if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GP)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.GreenYellow;
                }
                //连铸中包样
                else if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GL)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.Aquamarine;
                }
                //割样
                else if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GE)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.Lime;
                }
            }
            #endregion
        }

        // 炉中样成分
        private void dvRefineThirdEle_Paint(object sender, PaintEventArgs e)
        {
            #region 炉中样
            if (dvRefineThirdEle.Rows.Count < 1)
                return;
            for (int i = 0; i < dvRefineThirdEle.Rows.Count; i++)
            {
                if (dsChemicalStd.Tables[0].Rows.Count > 0)
                {
                    for (int j = CL.Index; j < Other3L.Index; j++)
                    {
                        DataGridViewCell cell = dvRefineThirdEle.Rows[i].Cells[j];
                        try
                        {
                            //获取实绩成分列名
                            string strDataProName = dvRefineThirdEle.Columns[cell.ColumnIndex].DataPropertyName;
                            //取出数据
                            double dRealValue = Convert.ToDouble(cell.Value.ToString());
                            //判断是否校验
                            if (dRealValue > 0)
                            {
                                double dStdMax = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Max"].ToString());
                                double dStdMin = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Min"].ToString());
                                CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
                            }
                        }
                        catch { }
                    }
                }
            }
            #endregion
        }

        //判定
        private void btnJudge_Click(object sender, EventArgs e)
        {
            string AppID = "";
            string JudgeFlag = "";
            if (dsFinalChemical.Tables[0].Rows.Count >= 1)
            {
                for (int i = 0; i < dsFinalChemical.Tables[0].Rows.Count; i++)
                {
                    //object d = dvFinalChemical["CheckFlagFin", i].EditedFormattedValue.ToString();
                    //if (dvFinalChemical["CheckFlagFin", i].Value == null)
                    //    continue;
                    //if (dvFinalChemical["CheckFlagFin", i].Value.ToString() == "1")
                    //{
                    if (Convert.ToBoolean(dvFinalChemical["CheckFlagFin", i].EditedFormattedValue)==true)
                    {
                        AppID = dvFinalChemical["APPIDFin", i].Value.ToString(); //委托单号
                        break;
                    }

                }
            }

            if (rBtnYes.Checked == true)
            {
                JudgeFlag = "0";
            }
            if (rBtnNo.Checked == true)
            {
                JudgeFlag = "-1";
            }

            //校验
            if (strCurHeatID == "")
            {
                MessageBox.Show("请选择炉号!", "提示");
                return;
            }
            else if (dsFinalChemical.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("没有炉中样信息!", "提示");
                return;
            }
            else if (AppID == "")
            {
                MessageBox.Show("请选择委托单编号!", "提示");
                return;
            }
            else if (JudgeFlag == "")
            {
                MessageBox.Show("请选择是否合格!", "提示");
                return;
            }
            else if (strCurHeatID == "")
            {
                MessageBox.Show("炉号为空!", "提示");
                return;
            }

            AppSvrHMI.L3DataSet dsTempt = new AppSvrHMI.L3DataSet();
            DataTable dt = new DataTable();
            dsTempt.Tables.Add(dt);
            dsTempt.Tables[0].Columns.Add("HeatID");
            dsTempt.Tables[0].Columns.Add("JudgeFlag");
            dsTempt.Tables[0].Columns.Add("AppID");
            dsTempt.Tables[0].Rows.Add(new string[] { strCurHeatID, JudgeFlag, AppID });

            cmdJudge.Parameters[0].SourceObject = dsTempt;
            //cmdJudge.Parameters[0].ConstantValue = dsTempt;
            try
            {
                int iRet = cmdJudge.Execute();
                if (iRet >= 0)
                {
                    if (Convert.ToInt32(cmdJudge.Command.Return) == 0)
                    {
                        SetSourceCondition();
                        SetL3DataAdpter();
                        dsHeatID.LoadData();
                        dvHeatID_Click(sender, e);

                        MessageBox.Show("操作成功！","提示");
                    }
                    else if (Convert.ToInt32(cmdJudge.Command.Return) == -3)
                        MessageBox.Show("已经终判！","提示");
                    else
                        MessageBox.Show("操作失败！","提示");
                }
                else
                {
                    MessageBox.Show("操作失败！", "提示");
                }
            }
            catch { }


        }

        private void dvFinalChemical_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        //刷新
        private void btnLoad_Click(object sender, EventArgs e)
        {
            SetSourceCondition();
            SetL3DataAdpter();
            dsHeatID.LoadData();
            dvHeatID_Click(sender, e);
        }

        private void dvHeatID_Click(object sender, EventArgs e)
        {
            if (dvHeatID.CurrentRow == null||dvHeatID.CurrentRow.Cells[0].Value==null)
            {
         
                dsHeatExcept.SourceCondition = "1=2";
                dsFinalChemical.L3DataAdapter = null;
                dsChemicalStd.L3DataAdapter = null;
                dsHeatExcept.L3DataAdapter = null;
                dsHeatGrade.L3DataAdapter = null;
                dsRefineThirdEle.L3DataAdapter = null;
                //load();
                return;
            }

            strCurHeatID = dvHeatID.CurrentRow.Cells[0].EditedFormattedValue.ToString();
            if (strCurHeatID == "")
                return;
            //加载
            GetData();

            return;
           

        }

        


    }
}