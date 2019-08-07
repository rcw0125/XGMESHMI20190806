using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class UCCCM7CureData : UserControl
    {
        public UCCCM7CureData()
        {
            InitializeComponent();
        }

        private bool m_check = false;
        private string m_CurHeatID = "";
        private string m_CurCCMID = "";

        private bool m_exist1_3th = false;
        private bool m_exist2_3th = false;

        public AppSvrIF.Session Session
        {
            get { return Adapter.Session; }
            set { Adapter.Session = value; }
        }

        public string CCMID
        {
            get { return m_CurCCMID; }
            set
            {
                m_CurCCMID = value;
            }
        }

        public string HeatID
        {
            get { return m_CurHeatID; }
            set
            {
                m_CurHeatID = value;
            }
        }

        public bool check
        {
            get { return m_check; }
            set
            {
                m_check = value;
            }
        }

        private void UCCCM5CureData_Load(object sender, EventArgs e)
        {
            ////二冷水
            //SetDataGridViewCellStyle(dvCoolWater, 2, dvCoolWater.Columns.Count - 2);
            ////辊缝值
            //SetDataGridViewCellStyle(dvRoller, 0, dvRoller.Columns.Count - 2);
            ////结晶器
            //SetDataGridViewCellStyle(dvMold, 0, 3);

            //SetDataGridViewCellStyle(dvMold, 12, dvMold.Columns.Count - 2);
            ////振动
            //SetDataGridViewCellStyle(dvOscillate, 1, dvOscillate.Columns.Count - 2);
            ////塞棒
            //SetDataGridViewCellStyle(dvPlugBar, 0, dvPlugBar.Columns.Count - 2);
            ////电磁搅拌
            //SetDataGridViewCellStyle(dvElectMix, 9, dvElectMix.Columns.Count - 6);

            txtCCMID.Text = CCMID;
            txtHeatID.Text = HeatID;

            //m_exist1_3th = GetGuid_CatchCount_Is3Th("1");
            //m_exist2_3th = GetGuid_CatchCount_Is3Th("2"); ;

            /*****************************SourceCondition*************************************/
            dsCoolGas.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";
            dsCoolGas.L3DataAdapter = Adapter;

            dsCoolWater.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsRoller.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsMold.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsLevel.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsOscillate.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsPlugBar.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsEnergy.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsElectMix.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";
            /*****************************SourceCondition*************************************/

            /**********************可修改性*****************************/
            SetAddVisible();

            fLPCoolGas.Visible = false;//check;
            fLPCoolWater.Visible = false;//check;
            fLPRoller.Visible = false;//check;
            fLPMold.Visible = false;//check;
            fLPOscillate.Visible = false;//check;
            fLPPlugBar.Visible = false;//check;
            fLPEnergy.Visible = false;//check;
            fLPElectMix.Visible = false;//check;
            fLPLevel.Visible = false;//check;
            /**********************可修改性****************************/
        }

        private void SetAddVisible()
        {
            btnCoolWaterAdd.Visible = false;//check && m_exist1_3th;
            btnMoldAdd.Visible = false;//check && m_exist1_3th;
            btnOscillateAdd.Visible = false;//check && m_exist1_3th;
            btnPlugBarAdd.Visible = false;//check && m_exist1_3th;
            btnEnergyAdd.Visible = false;//check && m_exist1_3th;
            btnElectMixAdd.Visible = false;//check && m_exist1_3th;

            btnCoolGasAdd.Visible = false;//check && m_exist2_3th;
            btnRollerAdd.Visible = false;//check && m_exist2_3th;

            btnLevelAdd.Visible = false;//check && m_exist2_3th;
        }

        //判断当前炉号对应采集次数为3是否存在数据，存在返回false，不存在返回true
        private bool GetGuid_CatchCount_Is3Th(string strNo)
        {
            if (strNo == null || strNo == "")
                return false;
            else if (strNo == "1")//
            {
                dsGUID.Tables[0].Rows.Clear();
                dsGUID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                dsGUID.SourceMethod = "select GUID ,HeatID,Catch_Count,LogTime from CCCM5_Runtime1_Data where HeatID = '" + HeatID + "' and Catch_Count = 3 ";
                dsGUID.L3DataAdapter = Adapter;
                dsGUID.L3DataAdapter = null;

                if (dsGUID.Tables[0].Rows.Count == 1)
                    return false;
                else
                    return true;
            }
            else if (strNo == "2")
            {
                dsGUID.Tables[0].Rows.Clear();
                dsGUID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                dsGUID.SourceMethod = "select GUID ,HeatID,Catch_Count,LogTime from CCCM5_Runtime2_Data where HeatID = '" + HeatID + "' and Catch_Count = 3 ";
                dsGUID.L3DataAdapter = Adapter;
                dsGUID.L3DataAdapter = null;

                if (dsGUID.Tables[0].Rows.Count == 1)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        //插入一条记录(当前炉号且对应采集次数为3)
        private bool InsertNewData1_CatchCountIs3th()
        {
            AppSvrHMI.L3DataSet ds = (AppSvrHMI.L3DataSet)dsGUID.Clone();
            ds.L3DataAdapter = Adapter;
            ds.SourceCondition = "HeatID = ''";
            ds.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            ds.SourceURI = "XGMESLogic\\CCMMag\\CCCM5_Runtime1_Data";

            ds.Tables[0].Rows.Add();
            ds.Tables[0].Rows[0]["GUID"] = "";
            ds.Tables[0].Rows[0]["HeatID"] = HeatID;
            ds.Tables[0].Rows[0]["CCMID"] = CCMID;
            ds.Tables[0].Rows[0]["Catch_Count"] = 3;
            ds.Tables[0].Rows[0]["LogTime"] = System.DateTime.Now;

            return ds.UpdateData();
        }

        private bool InsertNewData2_CatchCountIs3th()
        {
            AppSvrHMI.L3DataSet ds = (AppSvrHMI.L3DataSet)dsGUID.Clone();
            ds.L3DataAdapter = Adapter;
            ds.SourceCondition = "HeatID = ''";
            ds.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            ds.SourceURI = "XGMESLogic\\CCMMag\\CCCM5_Runtime2_Data";

            ds.Tables[0].Rows.Add();
            ds.Tables[0].Rows[0]["GUID"] = "";
            ds.Tables[0].Rows[0]["HeatID"] = HeatID;
            ds.Tables[0].Rows[0]["CCMID"] = CCMID;
            ds.Tables[0].Rows[0]["Catch_Count"] = 3;
            ds.Tables[0].Rows[0]["LogTime"] = System.DateTime.Now;

            return ds.UpdateData();
        }

        //判断当前炉号且采集次数为3的记录是否为空
        //空则增加记录
        //不空则修改数据
        //刷新数据
        private void RefreshData1()
        {
            dsCoolWater.LoadData();

            dsMold.LoadData();

            dsLevel.LoadData();

            dsLevel.LoadData();

            dsOscillate.LoadData();

            dsPlugBar.LoadData();

            dsEnergy.LoadData();

            dsElectMix.LoadData();
        }

        private void RefreshData2()
        {
            dsCoolGas.LoadData();

            dsRoller.LoadData();
        }

        private void dv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        //换tab页
        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    switch (e.TabPage.Name)
                    {
                        case "tabCoolWater":
                            if (dsCoolWater.L3DataAdapter == null)
                                dsCoolWater.L3DataAdapter = Adapter;
                            break;

                        case "tabRoller":
                            if (dsRoller.L3DataAdapter == null)
                                dsRoller.L3DataAdapter = Adapter;
                            break;

                        case "tabMold":
                            if (dsMold.L3DataAdapter == null)
                                dsMold.L3DataAdapter = Adapter;
                            break;

                        case "tabLevel":
                            if (dsLevel.L3DataAdapter == null)
                                dsLevel.L3DataAdapter = Adapter;
                            break;

                        case "tabOscillate":
                            if (dsOscillate.L3DataAdapter == null)
                                dsOscillate.L3DataAdapter = Adapter;
                            break;

                        case "tabPlugBar":
                            if (dsPlugBar.L3DataAdapter == null)
                                dsPlugBar.L3DataAdapter = Adapter;
                            break;

                        case "tabEnergy":
                            if (dsEnergy.L3DataAdapter == null)
                                dsEnergy.L3DataAdapter = Adapter;
                            break;

                        case "tabElectMix":
                            if (dsElectMix.L3DataAdapter == null)
                                dsElectMix.L3DataAdapter = Adapter;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            { }
        }

        //新增
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (m_exist1_3th)
                m_exist1_3th = !InsertNewData1_CatchCountIs3th();

            SetAddVisible();
            RefreshData1();
            return;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (m_exist2_3th)
                m_exist2_3th = !InsertNewData2_CatchCountIs3th();

            SetAddVisible();
            RefreshData2();
            return;
        }


        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Button btnConfirm = (Button)sender;
            try
            {
                switch (btnConfirm.Name)
                {
                    case "btnCoolGasConfirm":
                        dvCoolGas.EndEdit();
                        bsCoolGas.EndEdit();
                        MessageShowOperation(dsCoolGas.UpdateData());
                        break;

                    case "btnCoolWaterConfirm":
                        dvCoolWater.EndEdit();
                        bsCoolWater.EndEdit();
                        MessageShowOperation(dsCoolWater.UpdateData());
                        break;

                    case "btnRollerConfirm":
                        dvRoller.EndEdit();
                        bsRoller.EndEdit();
                        MessageShowOperation(dsRoller.UpdateData());
                        break;

                    case "btnMoldConfirm":
                        dvMold.EndEdit();
                        bsMold.EndEdit();
                        MessageShowOperation(dsMold.UpdateData());
                        break;

                    case "btnLevelConfirm":
                        dvLevel.EndEdit();
                        bsLevel.EndEdit();
                        MessageShowOperation(dsLevel.UpdateData());
                        break;

                    case "btnOscillateConfirm":
                        dvOscillate.EndEdit();
                        bsOscillate.EndEdit();
                        MessageShowOperation(dsOscillate.UpdateData());
                        break;

                    case "btnPlugBarConfirm":
                        dvPlugBar.EndEdit();
                        bsPlugBar.EndEdit();
                        MessageShowOperation(dsPlugBar.UpdateData());
                        break;

                    case "btnEnergyConfirm":
                        dvEnergy.EndEdit();
                        bsEnergy.EndEdit();
                        MessageShowOperation(dsEnergy.UpdateData());
                        break;

                    case "btnElectMixConfirm":
                        dvElectMix.EndEdit();
                        bsElectMix.EndEdit();
                        MessageShowOperation(dsElectMix.UpdateData());
                        break;
                    default:
                        break;
                }
            }
            catch
            { }
            SetAddVisible();
            RefreshData1();
            RefreshData2();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button btnCancel = (Button)sender;
            try
            {
                switch (btnCancel.Name)
                {
                    case "btnCoolGasCancel":
                        dsCoolGas.LoadData();
                        break;

                    case "btnCoolWaterCancel":
                        dsCoolWater.LoadData();
                        break;

                    case "btnRollerCancel":
                        dsRoller.LoadData();
                        break;

                    case "btnMoldCancel":
                        dsMold.LoadData();
                        break;

                    case "btnLevelCancel":
                        dsLevel.LoadData();
                        break;

                    case "btnOscillateCancel":
                        dsOscillate.LoadData();
                        break;

                    case "btnPlugBarCancel":
                        dsPlugBar.LoadData();
                        break;

                    case "btnEnergyCancel":
                        dsEnergy.LoadData();
                        break;

                    case "btnElectMixCancel":
                        dsElectMix.LoadData();
                        break;
                    default:
                        break;
                }
            }
            catch
            { }
        }

        //提示操作成功与否
        private void MessageShowOperation(bool bOperation)
        {
            if (bOperation)
            {
                MessageBox.Show("保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("保存失败！", "警告");
            }
        }

        private void SetDataGridViewCellStyle(DataGridView dv, int iCloStartIndex, int iCloEndIndex)
        {
            int idvCol = dv.Columns.Count;
            if (iCloStartIndex < 0 || iCloEndIndex > idvCol - 1)
                return;
            DataGridViewCellStyle dvCellStyle = new DataGridViewCellStyle();
            dvCellStyle.Format = "N3";
            dvCellStyle.NullValue = "0";
            for (int i = iCloStartIndex; i < iCloEndIndex; i++)
            {
                dv.Columns[i].DefaultCellStyle = dvCellStyle;
            }
        }


    }
}
