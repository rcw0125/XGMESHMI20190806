using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class UCCCM14CureData : UserControl
    {
        public UCCCM14CureData()
        {
            InitializeComponent();
        }

        private bool m_check = false;
        private string m_CurHeatID = "";
        private string m_CurCCMID = "";

        private bool m_exist_3th = false;

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

        private void UCCCM14CureData_Load(object sender, EventArgs e)
        {
            ////塞棒
            //SetDataGridViewCellStyle(dvPlugBar, 0, dvPlugBar.Columns.Count - 2);
            ////振动
            //SetDataGridViewCellStyle(dvOscillate, 1, dvOscillate.Columns.Count - 2);
            ////电磁搅拌
            //SetDataGridViewCellStyle(dvElectMix, 9, dvElectMix.Columns.Count - 6);
            ////二冷水
            //SetDataGridViewCellStyle(dvCool, 2, dvCool.Columns.Count - 2);
            ////结晶器
            //SetDataGridViewCellStyle(dvMold, 0, 3);

            txtCCMID.Text = CCMID;
            txtHeatID.Text = HeatID;

            //m_exist_3th = GetGuid_CatchCount_Is3Th(); ;

            /*****************************SourceCondition*************************************/
            dsEnergy.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";
            dsEnergy.L3DataAdapter = Adapter;

            dsPlugBar.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsOscillate.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsElectMix.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsCool.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsMold.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";

            dsEnd.SourceCondition = "HeatID = '" + HeatID + "' order by Catch_Count";
            /*****************************SourceCondition*************************************/

            /**********************可修改性*****************************/
            SetAddVisible();

            fLPEnergy.Visible = false;//check;
            fLPPlugBar.Visible = false;//check;
            fLPOscillate.Visible = false;//check;
            fLPElectMix.Visible = false;//check;
            fLPCool.Visible = false;//check;
            fLPMold.Visible = false;//check;
            fLPEnd.Visible = false;//check;
            /**********************可修改性****************************/
        }

        private void SetAddVisible()
        {
            btnEnergyAdd.Visible = false;//check && m_exist_3th;
            btnPlugBarAdd.Visible = false;//check && m_exist_3th;
            btnOscillateAdd.Visible = false;//check && m_exist_3th;
            btnElectMixAdd.Visible = false;//check && m_exist_3th;
            btnCoolAdd.Visible = false;//check && m_exist_3th;
            btnMoldAdd.Visible = false;//check && m_exist_3th;
            btnEndAdd.Visible = false;//check && m_exist_3th;
        }

        //判断当前炉号对应采集次数为3是否存在数据，存在返回false，不存在返回true
        private bool GetGuid_CatchCount_Is3Th()
        {
            dsGUID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            dsGUID.SourceMethod = "select GUID ,HeatID,Catch_Count,LogTime from CCCM_Runtime_Data where HeatID = '" + HeatID + "' and Catch_Count = 3 ";
            dsGUID.L3DataAdapter = Adapter;
            dsGUID.L3DataAdapter = null;

            if (dsGUID.Tables[0].Rows.Count == 1)
                return false;
            else
                return true;
        }

        //插入一条记录(当前炉号且对应采集次数为3)
        private bool InsertNewData_CatchCountIs3th()
        {
            AppSvrHMI.L3DataSet ds = (AppSvrHMI.L3DataSet)dsGUID.Clone();
            ds.L3DataAdapter = Adapter;
            ds.SourceCondition = "HeatID = ''";
            ds.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            ds.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Runtime_Data";

            ds.Tables[0].Rows.Add();
            ds.Tables[0].Rows[0]["GUID"] = "";
            ds.Tables[0].Rows[0]["HeatID"] = HeatID;
            ds.Tables[0].Rows[0]["CCMID"] = CCMID;
            ds.Tables[0].Rows[0]["Catch_Count"] = 3;
            ds.Tables[0].Rows[0]["LogTime"] = System.DateTime.Now;

            return ds.UpdateData();
        }

        //刷新数据
        private void RefreshData()
        {
            dsCool.LoadData();

            dsMold.LoadData();

            dsOscillate.LoadData();

            dsPlugBar.LoadData();

            dsEnergy.LoadData();

            dsElectMix.LoadData();

            dsEnd.LoadData();
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
                        case "tabCool":
                            if (dsCool.L3DataAdapter == null)
                                dsCool.L3DataAdapter = Adapter;
                            break;

                        case "tabMold":
                            if (dsMold.L3DataAdapter == null)
                                dsMold.L3DataAdapter = Adapter;
                            break;

                        case "tabOscillate":
                            if (dsOscillate.L3DataAdapter == null)
                                dsOscillate.L3DataAdapter = Adapter;
                            break;

                        case "tabPlugBar":
                            if (dsPlugBar.L3DataAdapter == null)
                                dsPlugBar.L3DataAdapter = Adapter;
                            break;

                        case "tabElectMix":
                            if (dsElectMix.L3DataAdapter == null)
                                dsElectMix.L3DataAdapter = Adapter;
                            break;
                        case "tabEnd": 
                            if (dsEnd.L3DataAdapter == null)
                                dsEnd.L3DataAdapter = Adapter;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m_exist_3th)
                m_exist_3th = !InsertNewData_CatchCountIs3th();

            SetAddVisible();
            RefreshData();
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
                    case "btnCoolConfirm":
                        dvCool.EndEdit();
                        bsCool.EndEdit();
                        MessageShowOperation(dsCool.UpdateData());
                        break;

                    case "btnMoldConfirm":
                        dvMold.EndEdit();
                        bsMold.EndEdit();
                        MessageShowOperation(dsMold.UpdateData());
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
                    case "btnEndConfirm":
                        dvEnd.EndEdit();
                        bsEnd.EndEdit();
                        MessageShowOperation(dsEnd.UpdateData());
                        break;
                    default:
                        break;
                }
            }
            catch
            { }
            SetAddVisible();
            RefreshData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button btnCancel = (Button)sender;
            try
            {
                switch (btnCancel.Name)
                {
                    case "btnCoolCancel":
                        dsCool.LoadData();
                        break;

                    case "btnMoldCancel":
                        dsMold.LoadData();
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

                    case "btnEndCancel":
                        dsEnd.LoadData();
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