using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DEPMag
{
    public partial class DEPHeatInfoFrm : Form
    {
        public DEPHeatInfoFrm()
        {
            InitializeComponent();
        }

        private void btnFeedIron_Click(object sender, EventArgs e)
        {

        }
        private bool UnLock = false;
        private bool check = false;
        private bool isLockTxtTW = false;
        private string strCurHeatID = "";
        private bool bOperation = false;
        private string strSteelGradeIndex = "";//当前炉号对应当前炼钢记号

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="bLocked">实绩锁定标志:True 实绩已锁定,不可修改任何实绩;False 实绩尚未锁定,可修改部分实绩</param>
        /// <param name="CheckFlag">数据维护标志:True 可维护所有数据,False 参照锁定标志</param>
        /// <param name="strHeatID">炉号</param>
        public void ShowDialogEx(AppSvrIF.Session session, bool bLocked, bool CheckFlag, string strHeatID, string strIronLadle)
        {
            try
            {
                UnLock = !bLocked;
                check = CheckFlag;
                strCurHeatID = strHeatID;
                txtHeatID.Text = strHeatID;
                txtIronLadle.Text = strIronLadle;

                //设置各DataSet的SourceCondition
                //dsBase
                dsBase.SourceCondition = "IRONLADLE = '" + strIronLadle + "'";

                //dsBottomBlow
               // dsBottomBlow.SourceCondition = "IRONLADLE = '" + strIronLadle + "' order by Catch_Time desc";

                //dsChemical
                dsChemical.SourceCondition = "HeatID = '" + strHeatID + "' order by Report_Date desc";//and UNITTYPEID = '2' 

                //
             
               
                //dsMainMat
                dsMainMat.SourceCondition = "MaterialID = '" + strIronLadle + "'";


                //dsMat
                dsMat.SourceCondition = "HeatID = '" + strHeatID + "' order by Type, Discharge_Time asc ";

    

    
                //dsProcess
                dsProcess.SourceCondition = "IRONLADLE = '" + strIronLadle + "'";

             
                dsStatus.SourceCondition =  "HeatID = '" + strHeatID + "' order by Change_Time desc";

                //dsTemp
                dsTemp.SourceCondition = "HeatID = '" + strHeatID + "'";

                dsSumAddition.SourceMethod = "select Element,trunc(sum(Weight),2) as Weight,TYPE from CDEP_ADDITION_DATA  where HeatID = '" + strHeatID + "' group by Element,type";

                //dsRemark
                dsRemark.SourceCondition = "HeatID = '" + strHeatID + "'";


                /* 转炉合金加料 */
                string strBatch_mat_Man = "";
                dsMat_Alloy_Add_Man.SourceMethod = strBatch_mat_Man;
                strBatch_mat_Man += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,";
                strBatch_mat_Man += "         e.code_des || '(' || c.batch_id || ')' AS code_des";
                strBatch_mat_Man += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code";
                strBatch_mat_Man += "            FROM materialposition a, calloy_data b";
                strBatch_mat_Man += "           WHERE a.materialid = b.materialid";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,";
                strBatch_mat_Man += "         (SELECT *";
                strBatch_mat_Man += "            FROM xgstorearea";
                strBatch_mat_Man += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,";
                strBatch_mat_Man += "         cbase_all_code e";
                strBatch_mat_Man += "   WHERE c.pos = d.code";
                strBatch_mat_Man += "     AND d.containerid = '15' ";
                strBatch_mat_Man += "     AND c.alloy_code = e.code";
                strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'";
                strBatch_mat_Man += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire'";
                strBatch_mat_Man += "         )";
                strBatch_mat_Man += "ORDER BY alloy_code";
                dsMat_Alloy_Add_Man.SourceMethod = strBatch_mat_Man;

    
                this.Adapter.Session = session;

                Adapter.RefreshDataBindings();

                this.ShowDialog();
            }
            catch { }
        }


        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnProcessConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        //数据加载
        private void BOFHeatInfoFrm_Load(object sender, EventArgs e)
        {
            //取消删除按钮可见性
         
            btnDelAlloy.Visible = false;
            btnDelChemical.Visible = false;
          
            btnDelStatus.Visible = false;
            btnDelTemp.Visible = false;
       
            //btnDelOxygen.Visible = false;
   
            btnRemarkDel.Visible = false;

     



            //如果实际尚未锁定并且可以维护实绩
            if (UnLock && check)
            {
                //基本数据
                fLPBase.Visible = true;
                btnBaseConfirm.Visible = true;
                foreach (Control cBase in this.tabBase.Controls)
                {
                    if (cBase.GetType().Name == "TextBox")
                        ((TextBox)cBase).ReadOnly = false;

                    else if (cBase.GetType().Name == "ComboBox")
                        ((ComboBox)cBase).Enabled = true;

                    else if (cBase.GetType().Name == "PxTextBox")
                        ((PxDataValid.PxTextBox)cBase).ReadOnly = false;

                    else if (cBase.GetType().Name == "PxComboBox")
                        ((PxDataValid.PxComboBox)cBase).Enabled = true;

                    else if (cBase.GetType().Name == "DateTimePicker")
                        ((DateTimePicker)cBase).Enabled = true;
                }

                //主原料数据
                fLPMainMat.Visible = true;
                btnMainMatConfirm.Visible = true;

                //冶炼数据
                fLPProcess.Visible = true;
                btnProcessConfirm.Visible = true;
                foreach (Control cProcess in this.tabProcess.Controls)
                {
                    if (cProcess.GetType().Name == "TextBox")
                        ((TextBox)cProcess).ReadOnly = false;

                    else if (cProcess.GetType().Name == "ComboBox")
                        ((ComboBox)cProcess).Enabled = true;

                    else if (cProcess.GetType().Name == "PxTextBox")
                        ((PxDataValid.PxTextBox)cProcess).ReadOnly = false;

                    else if (cProcess.GetType().Name == "PxComboBox")
                        ((PxDataValid.PxComboBox)cProcess).Enabled = true;

                    else if (cProcess.GetType().Name == "DateTimePicker")
                        ((DateTimePicker)cProcess).Enabled = true;
                }

          
                //炉前合金
                btnAddAlloy.Visible = true;
                fLPAlloy.Visible = true;
                btnAlloyCanfirm.Visible = true;



                //成分
                btnAddChemical.Visible = true;
                fLPChemical.Visible = true;
                btnChemicalConfirm.Visible = true;

              

                //状态
                btnAddStatus.Visible = true;
                fLPStatus.Visible = true;
                btnStatusConfirm.Visible = true;

                //测温定氧
                btnAddTemp.Visible = true;
        
                //btnAddOxygen.Visible = true;
    
                fLPTemp.Visible = true;
                btnTempConfirm.Visible = true;

                //炉次记事
                fLPRemark.Visible = true;
                btnRemarkAdd.Visible = true;
                btnRemarkConfirm.Visible = true;
            }
            else
            {
                fLPMainMat.Visible = true;//UnLock;
                btnMainMatConfirm.Visible = true;//UnLock;

                //fLPMat.Visible = false;//UnLock;
                //btnAddMat.Visible = false;//UnLock;

                fLPChemical.Visible = false;//UnLock;
                btnAddChemical.Visible = false;//UnLock;

 

                fLPStatus.Visible = false;//UnLock;
                btnAddStatus.Visible = false;//UnLock;

                fLPTemp.Visible = false;//UnLock;
                btnAddTemp.Visible = false;//UnLock;
      
                //btnAddOxygen.Visible = false;//UnLock;
      

                if (!UnLock)
                {
                    fLPBase.Visible = UnLock;
                    fLPProcess.Visible = UnLock;
           
                    fLPRemark.Visible = UnLock;


                    btnAddAlloy.Visible = UnLock;
                    fLPAlloy.Visible = UnLock;


   

                }
            }
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxIronWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            //tbxScrapWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            //tbxPigIronWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            //tbxReHeatAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxC.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxSi.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxMn.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxP.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxS.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxTi.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxIronTemp.TextChanged += new EventHandler(pxControls_TextChanged);

            txtTappingTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSplashingTime.TextChanged += new EventHandler(pxControls_TextChanged);

            txtTapholeLife.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSmeltPeriod.TextChanged += new EventHandler(pxControls_TextChanged);

            txtLanceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtFurnaceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtLadleNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingWeight.TextChanged += new EventHandler(pxControls_TextChanged);

            txtLaCTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtIronLadle1.TextChanged += new EventHandler(pxControls_TextChanged);

        }

        //基本数据
        private void btnBaseConfirm_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            bOperation = dsBase.UpdateData();
            MessageShowOperation();
            dsBase.LoadData();
        }

        private void btnBaseCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }

        //主原料数据
        private void btnMainMatConfirm_Click(object sender, EventArgs e)
        {
            bsMainMat.EndEdit();
            bOperation = dsMainMat.UpdateData();
            MessageShowOperation();
            dsMainMat.LoadData();
        }

        private void btnMainMatCancel_Click(object sender, EventArgs e)
        {
            dsMainMat.LoadData();
        }



        private void btnDelMat_Click(object sender, EventArgs e)
        {
            //if (bsMat.Current != null)
            //    bsMat.RemoveCurrent();
        }



        private void btnMatCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
          
        }

        //炉前合金数据
        private void btnAdAlloy_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Discharge_Time"] = System.DateTime.Now;
            //newrow["Type"] = "5";
            newrow["Name"] = "1";
            dsMat.Tables[0].Rows.Add(newrow);
        }

        private void btnDelAlloy_Click(object sender, EventArgs e)
        {
            if (bsAlloy.Current != null)
                bsAlloy.RemoveCurrent();
        }

        private void btnAlloyConfirm_Click(object sender, EventArgs e)
        {
            dvAlloy.EndEdit();
            bsAlloy.EndEdit();

            for (int i = 0; i < dvAlloy.Rows.Count; i++)
            {
                if (dvAlloy.Rows[i].Cells["dvcmbAlloyCode"].EditedFormattedValue.ToString() == "" && dvAlloy.Rows[i].Cells["Name1"].Value.ToString() == "1")
                {
                    MessageBox.Show("合金代码为空！", "提示", MessageBoxButtons.OK);
                    bsAlloy.Position = i;
                    return;
                }
     
            }

            bOperation = dsMat.UpdateData();
            MessageShowOperation();
            dsMat.LoadData();
       
        }

        private void btnAlloyCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
        
        }



        //冶炼数据
        private void btnProcessConfirm_Click(object sender, EventArgs e)
        {
            bsProcess.EndEdit();
     
            bOperation = dsProcess.UpdateData();
            MessageShowOperation();
            dsProcess.LoadData();
            
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
      
           
        }

        //成份数据
        private void btnAddChemical_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsChemical.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["LogTime"] = System.DateTime.Now;
            newrow["Arrive_Date"] = System.DateTime.Now;
            newrow["Report_Date"] = System.DateTime.Now;
            dsChemical.Tables[0].Rows.Add(newrow);
        }

        private void btnDelChemical_Click(object sender, EventArgs e)
        {
            if (bsChemical.Current != null)
                bsChemical.RemoveCurrent();
        }

        private void btnChemicalConfirm_Click(object sender, EventArgs e)
        {
            dvChemical.EndEdit();
            bsChemical.EndEdit();
            bOperation = dsChemical.UpdateData();
            MessageShowOperation();
            dsChemical.LoadData();
        }

        private void btnChemicalCancel_Click(object sender, EventArgs e)
        {
            dsChemical.LoadData();
        }





        //状态数据
        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsStatus.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Change_Time"] = System.DateTime.Now;
            dsStatus.Tables[0].Rows.Add(newrow);
        }

        private void btnDelStatus_Click(object sender, EventArgs e)
        {
            if (bsStatus.Current != null)
                bsStatus.RemoveCurrent();
        }

        private void btnStatusConfirm_Click(object sender, EventArgs e)
        {
            dvStatus.EndEdit();
            bsStatus.EndEdit();
            bOperation = dsStatus.UpdateData();
            MessageShowOperation();
            dsStatus.LoadData();
        }

        private void btnStatusCancel_Click(object sender, EventArgs e)
        {
            dsStatus.LoadData();
        }

        //测温数据
        private void btnAddTemp_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTemp.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Temp_Time"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsTemp.Tables[0].Rows.Add(newrow);
        }

        private void btnDelTemp_Click(object sender, EventArgs e)
        {
            if (bsTemp.Current != null)
                bsTemp.RemoveCurrent();
        }


        private void txtIronLadle1_TextChanged(object sender, EventArgs e)
        {
            string str = txtIronLadle1.Text.Substring (0,3);
            textBox2.Text = str;
        }

        private void txtTappingTime_TextChanged(object sender, EventArgs e)
        {
            string str1 = txtTappingTime.Text;
            if (str1 != "")
            {
                int viTime = Convert.ToInt32(str1);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtTappingTime.Text = vsTime;
            }
        }

        private void txtSplashingTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtSplashingTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtSplashingTime.Text = vsTime;
            }
        }
        

        private void btnTempConfirm_Click(object sender, EventArgs e)
        {
            dvTemp.EndEdit();
            bsTemp.EndEdit();

  



            bOperation = (dsTemp.UpdateData());
            MessageShowOperation();
            dsTemp.LoadData();

       
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsTemp.LoadData();
      
            //dsOxygen.LoadData();
 
        }




        private void MessageShowOperation()
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

        private void dv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //炉次记事
        private void btnRemarkAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsRemark.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Log_Time"] = System.DateTime.Now;
            dsRemark.Tables[0].Rows.Add(newrow);
        }

        private void btnRemarkDel_Click(object sender, EventArgs e)
        {
            if (bsRemark.Current != null)
                bsRemark.RemoveCurrent();
        }

        private void btnRemarkConfirm_Click(object sender, EventArgs e)
        {
            dvRemark.EndEdit();
            bsRemark.EndEdit();
            bOperation = dsRemark.UpdateData();
            MessageShowOperation();
            dsRemark.LoadData();
        }
        private void btnRemarkCancel_Click(object sender, EventArgs e)
        {
            dsRemark.LoadData();
        }

        private void bnTemp_RefreshItems(object sender, EventArgs e)
        {

        }
        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTeam.SelectedValue != null && cmbTeam.SelectedValue.ToString() != "")
                {
                    string strUnitID = "S2" + strCurHeatID.Substring(1, 1).ToString();
                    dsDuty.SourceCondition = "UnitID = '" + strUnitID + "' and Team = '" + cmbTeam.SelectedValue.ToString() + "'";

                    if (dsDuty.Tables[0].Rows.Count > 0)
                    {
                        tbxHeadFurnace.Text = dsDuty.Tables[0].Rows[0]["HeadFurnace"].ToString();
                        tbxAssistant.Text = dsDuty.Tables[0].Rows[0]["Assistant"].ToString();
                        tbxSecondHand.Text = dsDuty.Tables[0].Rows[0]["SecondHand"].ToString();
                    }
                }
            }
            catch { }

        }

        private void tabCtrlMain_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    switch (e.TabPage.Name)
                    {
                        case "tabMainMat":

                            if (dsMainMat.L3DataAdapter == null)
                                dsMainMat.L3DataAdapter = Adapter;
                            break;

                        case "tabMat":
                        case "tabAlloy":
                            if (dsMat.L3DataAdapter == null)
                                dsMat.L3DataAdapter = Adapter;
                            break;

                        case "tabProcess":
                            /****Modify By Huyunhai****/
                            if (isLockTxtTW == true)
                                txtTappingWeight.ReadOnly = false;
                            /*****Modify End******/
                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;

                          
                            break;

                     

                        case "tabChemical":
                            if (dsChemical.L3DataAdapter == null)
                                dsChemical.L3DataAdapter = Adapter;
                            break;

                        case "tabSumAddition":
                            if (dsSumAddition.L3DataAdapter == null)
                                dsSumAddition.L3DataAdapter = Adapter;
                            break;
               
                        

                        case "tabStatus":
                            if (dsStatus.L3DataAdapter == null)
                                dsStatus.L3DataAdapter = Adapter;
                            break;

                        case "tabTemp":
                            if (dsTemp.L3DataAdapter == null)
                                dsTemp.L3DataAdapter = Adapter;
         
                            //if (dsOxygen.L3DataAdapter == null)
                            //    dsOxygen.L3DataAdapter = Adapter;
                
                            break;

                        case "tabRemark":
                            if (dsRemark.L3DataAdapter == null)
                                dsRemark.L3DataAdapter = Adapter;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch { }
        }



        //数据绑定
        private void dvAlloy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvAlloy.Rows.Count; i++)
                {
                    if (dvAlloy.Rows[i].Cells["Name1"].Value.ToString() != "1")
                        dvAlloy.Rows[i].ReadOnly = true;
                    else
                        dvAlloy.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }





        private void dvTemp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvTemp.Rows.Count; i++)
                {
                    if (dvTemp.Rows[i].Cells["Name4"].Value.ToString() != "1")
                        dvTemp.Rows[i].ReadOnly = true;
                    else
                        dvTemp.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }





        private void dsMainMat_OnDataLoaded(object sender)
        {
            //try
            //{
            //    dsIronLadleID.LoadData();
            //    dsScrapID.LoadData();
            //}
            //catch { }
        }


        //炉前合金
        private void dvAlloy_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        //炉前合金
        private void bsAlloy_CurrentChanged(object sender, EventArgs e)
        {
            if ((!btnAlloyCanfirm.Visible) || (bsAlloy.Position < 0))
            {
                cmbBatchID.Visible = false;
                return;
            }
            if (((System.Data.DataRowView)(bsAlloy.Current)).Row["Name"].ToString() != "1")
            {
                cmbBatchID.Visible = false;
                return;
            }

            string strOldValue = ((System.Data.DataRowView)(bsAlloy.Current)).Row["Batch_ID"].ToString(); //dvMat.Rows[bsMat.Position].Cells["Batch_ID_Mat"].Value.ToString();
            string strAlloyCode = ((System.Data.DataRowView)(bsAlloy.Current)).Row["Element"].ToString();// dvMat.Rows[bsMat.Position].Cells["Element"].Value.ToString();

            string strCode = strAlloyCode + strOldValue;

            int iX = 0;
            int iY = 0;

            iX += dvAlloy.RowHeadersWidth;
            for (int i = 0; i < dvAlloy.Columns["dvcmbAlloyCode"].Index; i++)
                iX += dvAlloy.Columns[i].Width;

            iY += dvAlloy.ColumnHeadersHeight;
            try
            {
                for (int j = 0; j < bsAlloy.Position + 1; j++)
                    iY += dvAlloy.Rows[j].Cells[0].Size.Height;
            }
            catch { iY += 23; }

            try
            {
                cmbBatchID.Size = dvAlloy.Rows[bsAlloy.Position].Cells["dvcmbAlloyCode"].Size;
            }
            catch { }
            Point pp = new Point(iX, iY);
            cmbBatchID.Location = pp;
            try
            {
                cmbBatchID.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsMat_Alloy_Add_Man, strCode);
            }
            catch { cmbBatchID.Text = ""; }
            cmbBatchID.Visible = true;
        }

        //炉前合金数据
        private void cmbBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmbBatchID))
                {
                    if (dvAlloy.Rows[bsAlloy.Position].Cells["Name1"].Value.ToString() != "1")
                        cmbBatchID.Visible = false;
                    else
                    {
                        cmbBatchID.Visible = true;

                        dvAlloy.Rows[bsAlloy.Position].Cells["dvcmbAlloyCode"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsMat_Alloy_Add_Man, "Alloy_Code", "Code", cmbBatchID.SelectedValue.ToString());

                        dvAlloy.Rows[bsAlloy.Position].Cells["Batch_ID_Pre"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsMat_Alloy_Add_Man, "Batch_ID", "Code", cmbBatchID.SelectedValue.ToString());
                    }
                }
            }
            catch { cmbBatchID.Visible = false; }
        }



 



      


        //成分报警
        private void dvChemical_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (strSteelGradeIndex != "")
            //    CommDataMag.CommonMethed.dv_Info_Element_Cell_BaceColor(Adapter, dvChemical, strSteelGradeIndex, 2);
        }

        //获取炼钢记号
        private void dsBase_OnDataLoaded(object sender)
        {
            try
            {
                strSteelGradeIndex = dsBase.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            }
            catch { strSteelGradeIndex = ""; }
        }

        //绘制行级 gridView
        private void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView ss = (DataGridView)sender;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X - 10, e.RowBounds.Location.Y,
                ss.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                ss.RowHeadersDefaultCellStyle.Font, rectangle,
                ss.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            //DataRow newrow = dsMat.Tables[0].NewRow();
            //newrow["HeatID"] = strCurHeatID;
            //newrow["Discharge_Time"] = System.DateTime.Now;
            //newrow["Type"] = "5";
            //newrow["Name"] = "1";
            //dsMat.Tables[0].Rows.Add(newrow);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }




   



        }



    }

