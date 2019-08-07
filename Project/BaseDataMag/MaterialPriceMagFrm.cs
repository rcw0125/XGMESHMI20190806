using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;
using System.Data.OleDb;

namespace BaseDataMag
{
    public partial class MaterialPriceMagFrm : DockContent, IMESForm
    {
        public MaterialPriceMagFrm()
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

        private string strCon = "";
        private OleDbConnection myConn;
        private int iRowCount = 0;
        private int iColumnCount = 0;
        bool bAdded = false;

        private void MaterialPriceMagFrm_Load(object sender, EventArgs e)
        {

            strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\\Exl\\价格表.xls;Extended Properties=\"Excel 8.0\"";
            myConn = new OleDbConnection(strCon);

            dsMatCode.SourceMethod = "";
            string strCodeSQL = "";
            strCodeSQL += "     SELECT DISTINCT (code), code_des                        ";
            strCodeSQL += "       FROM cbase_all_code                                   ";
            strCodeSQL += "      WHERE (   code_group = 'ALLOY_CODE'                    ";
            strCodeSQL += "             OR code_group = 'BULK_CODE'                     ";
            strCodeSQL += "             OR code_group = 'Cost_Mat_Code'                 ";
            strCodeSQL += "             OR code_group = 'Cost_Medium'                   ";
            strCodeSQL += "             OR code_group = 'Ladle_Tundish_Refra_Cost'      ";
            strCodeSQL += "            )                                                ";
            strCodeSQL += "        AND code IS NOT NULL                                 ";
            strCodeSQL += "   ORDER BY code                                             ";

            dsMatCode.SourceMethod = strCodeSQL;

            dtStart.Value = DateTime.Now;

            cmbMatCode.Items.Clear();
            cmbMatCode.Items.Add("");
            for (int i = 0; i < dsMatCode.Tables[0].Rows.Count; i++)
                cmbMatCode.Items.Add(dsMatCode.Tables[0].Rows[i]["Code_Des"].ToString());

            cmdpMatPrice.ConstantValue = " Work_Year = '" + dtStart.Value.Year.ToString() + "' order by Work_Year,Material_Code";
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (strMatCode != "")
                cmdpMatPrice.ConstantValue = " Work_Year = '" + dtStart.Value.Year.ToString() 
                    + "' and Material_Code = '" + strMatCode + "' order by Work_Year,Material_Code";
            else
                cmdpMatPrice.ConstantValue = " Work_Year = '" + dtStart.Value.Year.ToString() + "' order by Work_Year,Material_Code";
            dsMatPrice.LoadData();
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMatPrice.Tables[0].NewRow();
            newrow["Material_Code"] = "";
            newrow["Material_Name"] = "";
            newrow["Standard_Price"] = 0;
            newrow["Budget_Price_Jan"] = 0;
            newrow["Budget_Price_Feb"] = 0;
            newrow["Budget_Price_Mar"] = 0;
            newrow["Budget_Price_Apr"] = 0;
            newrow["Budget_Price_May"] = 0;
            newrow["Budget_Price_Jun"] = 0;
            newrow["Budget_Price_Jul"] = 0;
            newrow["Budget_Price_Aug"] = 0;
            newrow["Budget_Price_Sep"] = 0;
            newrow["Budget_Price_Oct"] = 0;
            newrow["Budget_Price_Nov"] = 0;
            newrow["Budget_Price_Dec"] = 0;
            newrow["Work_Year"] = dtStart.Value.Year.ToString();
            newrow["Latest_Price"] = 0;
            dsMatPrice.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            //2009-08-20 sun
            dvMatPrice.EndEdit();
            bsMatPrice.EndEdit();
            int iCheckFlagCount = 0;
            for (int i = 0; i < dsMatPrice.Tables[0].Rows.Count; i++)
            {
                if (dsMatPrice.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    iCheckFlagCount++;
                }
            }
            if (iCheckFlagCount == 0)
            {
                MessageBox.Show("没有选择数据或者当前没有数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = dsMatPrice.Tables[0].Rows.Count-1; i >=0; i--)
            {
                if (dsMatPrice.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsMatPrice.Tables[0].Rows[i].Delete();
                }
            }
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvMatPrice.EndEdit();
            bsMatPrice.EndEdit();
            if (dsMatPrice.GetChanges(DataRowState.Added) != null)
                bAdded = true;
            else
                bAdded = false;
            if (dsMatPrice.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsMatPrice.LoadData();
                return;
            }
            //判断是否为添加
            if (bAdded)
            MessageBox.Show("操作失败！导入或添加数据可能在数据库中已存在！", "提示");
            else
            MessageBox.Show("操作失败！", "提示");
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsMatPrice.LoadData();
        }

        //打印
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("物料价格信息", dvMatPrice);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //容错
        private void dvMatPrice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private string strMatCode = "";
        //获取查询用物料代码
        private void cmbMatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            strMatCode = CommDataMag.CommonMethed.GetStrCodeByDesc(dsMatCode, cmbMatCode.Text.Trim());
        }

        //关闭窗体时释放
        private void MaterialPriceMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //新增时写入物料编码
        private void dvMatPrice_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dvMatPrice.CurrentCell.ColumnIndex != dvMatPrice.Columns["MATERIAL_NAME"].Index)
                return;
            dvMatPrice.CurrentRow.Cells["MATERIAL_CODE"].Value = dvMatPrice.CurrentRow.Cells["MATERIAL_NAME"].Value.ToString();
        }

        //完成数据绑定(限定历史记录不能修改关键字及其组成部分)
        private void dvMatPrice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dvMatPrice.Rows.Count < 1)
                    return;
                for (int i = 0; i < dvMatPrice.Rows.Count; i++)
                {
                    if (dvMatPrice.Rows[i].Cells["OBJECT_ID"].Value.ToString() != "")
                    {
                        dvMatPrice.Rows[i].Cells["WORK_YEAR"].ReadOnly = true;
                        //dvMatPrice.Rows[i].Cells["MATERIAL_CODE"].ReadOnly = true;
                        dvMatPrice.Rows[i].Cells["MATERIAL_NAME"].ReadOnly = true;
                    }
                }
            }
            catch { }
        }

        //导入EXCEL  2009-08-19 sun
        private void btnIncludeExcel_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }

            string strCom = " Select * FROM [Sheet1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsMatPrice.Tables[0].Rows.Clear();
            dsMatPrice.AcceptChanges();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                iRowCount = ds.Tables[0].Rows.Count + 1;
                iColumnCount = ds.Tables[0].Columns.Count;
                for (int i = 1; i < iRowCount - 1; i++)
                {
                    DataRow newrow = dsMatPrice.Tables[0].NewRow();
                    dsMatPrice.Tables[0].Rows.Add(newrow);
                    dsMatPrice.Tables[0].Rows[i - 1]["WORK_YEAR"] = ds.Tables[0].Rows[i]["WORK_YEAR"];
                    dsMatPrice.Tables[0].Rows[i - 1]["MATERIAL_CODE"] = ds.Tables[0].Rows[i]["MATERIAL_CODE"];
                    dsMatPrice.Tables[0].Rows[i - 1]["STANDARD_PRICE"] = ds.Tables[0].Rows[i]["STANDARD_PRICE"];
                    dsMatPrice.Tables[0].Rows[i - 1]["LATEST_PRICE"] = ds.Tables[0].Rows[i]["LATEST_PRICE"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_JAN"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_JAN"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_FEB"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_FEB"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_MAR"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_MAR"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_APR"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_APR"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_MAY"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_MAY"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_JUN"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_JUN"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_JUL"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_JUL"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_AUG"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_AUG"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_SEP"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_SEP"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_OCT"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_OCT"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_NOV"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_NOV"];
                    dsMatPrice.Tables[0].Rows[i - 1]["BUDGET_PRICE_DEC"] = ds.Tables[0].Rows[i]["BUDGET_PRICE_DEC"];
                    dsMatPrice.Tables[0].Rows[i-1]["MATERIAL_NAME"] = dsMatPrice.Tables[0].Rows[i-1]["MATERIAL_CODE"];
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("导入模板不存在，请找相关人员维护！", "提示");
            }
        }

        //2009-08-20 sun 全选菜单
        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsMatPrice.Tables[0].Rows.Count; i++)
            {
                dsMatPrice.Tables[0].Rows[i]["CheckFlag"] = 1;
            }
        }

    }
}