using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace StoreMag.AlloyStore
{
    /****************Modify Begin At 2011-02-16 家 By Huyunhai       (库管理中 新增“合金料仓料种维信息护查询”)******************/

    public partial class AlloyStoreMagQuery : DockContent, IMESForm
    {
        public AlloyStoreMagQuery()
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


        private void AlloyStoreMagQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory(); //释放内存
        }

        // 导出到EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (dvStore.Visible == true)
            {
                CommDataMag.CommonMethed.PutIntoExcel("合金料仓料种维护信息查询", dvStore);
            }
            if (dvMatStoreEmpt.Visible == true)
            {
                CommDataMag.CommonMethed.PutIntoExcel("料仓清零信息查询", dvMatStoreEmpt);
            }

        }

        private void AlloyStoreMagQuery_Load(object sender, EventArgs e)
        {
            // string d = comboBox1.DisplayMember;
            //加载ComboBox
            //if (dsMaterial != null && dsMaterial.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dsMaterial.Tables[0].Rows)
            //    {
            //        cmbMaterial.Items.Add(dr["StoreID"]);
            //    }
            //}
          // select a.ALLOY_CODE from CALLOY_DATA a,CALLOY_PROPCHANGE_LOG b 
            //dsTempt = CommDataMag.CommonMethed.GetdsStandard(Adapter, "");

        }



        private void toolStripToriDateTimePicker1_TextChanged(object sender, EventArgs e)
        {
            if (dvStore.Visible == true&&tsCmbType.Text=="物料维护")
            {
                dvMatStoreEmpt.Visible = false;
                dvStore.Visible = true;
                dvStore.Dock = DockStyle.Fill;
                if (toolStripToriDateTimePicker1.Text == "")
                {
                    dsAlloyMainInfoQuery.SourceCondition = "1=2";
                }
                else if (toolStripToriDateTimePicker1.Text.Equals("全部"))
                {
                    dsAlloyMainInfoQuery.SourceCondition = "";
                }
                else
                    dsAlloyMainInfoQuery.SourceCondition = " OperatorTime>='" + toolStripToriDateTimePicker1.Text.ToString() + " 00:00:00'" + " and OperatorTime<='" + toolStripToriDateTimePicker1.Text.ToString() + " 23:59:59' ";
            }

            if (dvMatStoreEmpt.Visible == true&&tsCmbType.Text=="料仓清零")
            {
                dvMatStoreEmpt.Visible = true;
                dvStore.Visible = false;
                dvMatStoreEmpt.Dock = DockStyle.Fill;
                if (toolStripToriDateTimePicker1.Text == "")
                {
                    dsMatStoreEmpt.SourceCondition = "1=2";
                }
                else if (toolStripToriDateTimePicker1.Text.Equals("全部"))
                {
                    dsMatStoreEmpt.SourceCondition = "";
                }
                else
                    dsMatStoreEmpt.SourceCondition = " LogDate>='" + toolStripToriDateTimePicker1.Text.ToString() + " 00:00'" + " and LogDate<='" + toolStripToriDateTimePicker1.Text.ToString() + " 23:59' ";

            }

        }

        /// <summary>
        /// 选择查询类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsCmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsCmbType.Text == "")
            {
                bdN1.BindingSource = null;
                dvStore.Visible = false;
                dvMatStoreEmpt.Visible = false;
            }
            else if (tsCmbType.Text == "料仓清零")
            {
                bdN1.BindingSource = bsMatSotreEmpt;
                dvMatStoreEmpt.Visible = true;
                dvStore.Visible = false;
                dvMatStoreEmpt.Dock = DockStyle.Fill;
            }
            else if (tsCmbType.Text == "物料维护")
            {
                bdN1.BindingSource = bsAlloyMainInfoQuery;
                dvStore.Visible = true;
                dvMatStoreEmpt.Visible = false;
                dvStore.Dock = DockStyle.Fill;
            }
        }

        private void dvMatStoreEmpt_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }






    }
    /*******END*******/
}
