using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHHeatInfoFrm : Form
    {
        public RHHeatInfoFrm()
        {
            InitializeComponent();
        }

        private bool UnLock = false;
        private bool check = false;

        private string strSteelGradeIndex = "";//当前炉号对应当前炼钢记号

        private string strCurHeatID = "";
        private string strCurTreatNO = "";
        private bool bOperation = false;

        public void ShowDialogEx(AppSvrIF.Session session, bool bLock, bool bCheckFlag, string HeatID, string TreatNo)
        {

            UnLock = !bLock;
            check = bCheckFlag;

            strCurHeatID = HeatID;
            strCurTreatNO = TreatNo;

            tbxHeatID.Text = HeatID;
            tbxTreatNo.Text = TreatNo;
            //设置各DataSet的SourceCondition

            //dsBase
            dsBase.SourceCondition = "TreatNo = '" + TreatNo + "'";

            //dsChemical
            dsChemical.SourceCondition = "HeatID = '" + HeatID + "' order by Report_Date desc";// and UNITTYPEID = '5' 


            //dsRemark
            dsRemark.SourceCondition = "TreatNo = '" + TreatNo + "'order by LogTime desc";


            //dsMat
            dsMat.SourceCondition = "TreatNo = '" + TreatNo + "'order by Discharge_Time desc";

            //dsOxygen
            dsOxygen.SourceCondition = "TreatNo = '" + TreatNo + "'order by MeasureTime desc";

            //dsProcess
            dsProcess.SourceCondition = "TreatNo = '" + TreatNo + "'";
            dsWholePumpTime.SourceCondition = "TreatNo = '" + TreatNo + "'";//add by hyh 2012-08-02

            //dsStatus
            dsStatus.SourceCondition = "TreatNo = '" + TreatNo + "'order by Change_Time desc";

            //dsTemp
            dsTemp.SourceCondition = "TreatNo = '" + TreatNo + "'order by MeasureTime desc";

            //dsWire
            dsWire.SourceCondition = "TreatNo = '" + TreatNo + "'order by WireTime desc";

            //炉次异常
            dsExcept.SourceCondition = "HeatID = '" + HeatID + "' and UnitTypeID = '5' and UnitID = '" + TreatNo.Substring(0, 1) + "'";
            dsTundishTemp.SourceCondition = "HeatID = '" + HeatID + "' order by MEASURE_TIME desc";

            //钢包信息
            dsLadleInfo.SourceCondition = "TreatNo = '" + TreatNo + "'";

            this.Adapter.Session = session;
            Adapter.RefreshDataBindings();
            this.ShowDialog();
        }

        private void RHHeatInfoFrm_Load(object sender, EventArgs e)
        {
            btnDelExcept.Visible = false;
            //如果实际尚未锁定并且可以维护实绩
            if (UnLock && check)
            {
                //基本数据
                pnlBase.Visible = true;
                btnBaseOK.Visible = true;
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

                //加料
                btnAddMat.Visible = true;
                pnlMat.Visible = true;
                btnMatOK.Visible = true;

                ////喂线数据
                btnWireAdd.Visible = true;
                pnlWire.Visible = true;
                btnWireConfirm.Visible = true;

                //精炼数据
                pnlProcess.Visible = true;
                btnPaocessOK.Visible = true;
                foreach (Control cBase in this.tabProcess.Controls)
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
                //钢包信息
                pnlLadleInfo.Visible = true;

                //炉次工艺异常
                btnAddExcept.Visible = true;
                fLPExcept.Visible = true;
                btnConfirmExcept.Visible = true;

                //成份数据
                btnAddChemical.Visible = true;
                pnlChemical.Visible = true;
                btnChemicalOK.Visible = true;

                //状态数据
                btnAddStatus.Visible = true;
                pnlStatus.Visible = true;
                btnStatusOK.Visible = true;

                //测温数据
                btnAddTemp.Visible = true;
                pnlTemp.Visible = true;
                btnTempOK.Visible = true;

                //定氧数据
                btnAddOxygen.Visible = true;
                pnlOxygen.Visible = true;
                btnOxygenOK.Visible = true;

                //记事数据
                btnAddRemark.Visible = true;
                pnlNote.Visible = true;
                btnNoteConfirm.Visible = true;

            }
            else
            {
                pnlChemical.Visible = false;//UnLock;
                btnAddChemical.Visible = false;// UnLock;

                //pnlMat.Visible = false; //UnLock;
                //btnAddMat.Visible = false; //UnLock;

                pnlOxygen.Visible = false; //UnLock;
                btnAddOxygen.Visible = false; //UnLock;

                pnlStatus.Visible = false; //UnLock;
                btnAddStatus.Visible = false; //UnLock;

                pnlTemp.Visible = false; // UnLock;
                btnAddTemp.Visible = false; //UnLock;

                //pnlWire.Visible = false; //UnLock;
                //btnWireAdd.Visible = false; //UnLock;

                if (!UnLock)
                {
                    pnlBase.Visible = UnLock;
                    pnlNote.Visible = UnLock;
                    pnlProcess.Visible = UnLock;
                    fLPExcept.Visible = UnLock;

                    pnlLadleInfo.Visible = UnLock;

                    btnAddRemark.Visible = UnLock;
                    btnAddExcept.Visible = UnLock;

                    //加料
                    btnAddMat.Visible = UnLock;
                    pnlMat.Visible = UnLock;
                    btnMatOK.Visible = UnLock;

                    ////喂线数据
                    btnWireAdd.Visible = UnLock;
                    pnlWire.Visible = UnLock;
                    btnWireConfirm.Visible = UnLock;
                }
            }
            //基本数据
            tbxPreHeatID.TextChanged += new EventHandler(pxControls_TextChangedBase);
            tbxSteelGradeIndex.TextChanged += new EventHandler(pxControls_TextChangedBase);
            cmbShift.TextChanged += new EventHandler(pxControls_TextChangedBase);
            cmbTeam.TextChanged += new EventHandler(pxControls_TextChangedBase);
            tbxHeadFurnace.TextChanged += new EventHandler(pxControls_TextChangedBase);
            //冶炼数据
            foreach (Control c in tabProcess.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChangedProcess);
                }
            }

            /* RH 炉加料 */
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
            strBatch_mat_Man += "     AND (d.containerid = '8' OR d.containerid = '3')";
            strBatch_mat_Man += "     AND c.alloy_code = e.code";
            strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'";
            strBatch_mat_Man += "     AND (e.code_function_group is null or e.code_function_group <> 'FeedWire') ";
            strBatch_mat_Man += "ORDER BY code_des";
            dsMat_Alloy_Add_Man.SourceMethod = strBatch_mat_Man;

            /* RH 炉喂线 */
            strBatch_mat_Man = "";
            dsWire_Add_man.SourceMethod = strBatch_mat_Man;
            strBatch_mat_Man += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,                       ";
            strBatch_mat_Man += "         e.code_des || '(' || c.batch_id || ')' AS code_des,e.code_function_group      ";
            strBatch_mat_Man += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
            strBatch_mat_Man += "            FROM materialposition a, calloy_data b                             ";
            strBatch_mat_Man += "           WHERE a.materialid = b.materialid                                   ";
            strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
            strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
            strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
            strBatch_mat_Man += "         (SELECT *                                                             ";
            strBatch_mat_Man += "            FROM xgstorearea                                                   ";
            strBatch_mat_Man += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
            strBatch_mat_Man += "         cbase_all_code e                                                      ";
            strBatch_mat_Man += "   WHERE c.pos = d.code                                                        ";
            strBatch_mat_Man += "     AND d.containerid = '3'                                                   ";
            strBatch_mat_Man += "     AND c.alloy_code = e.code                                                 ";
            strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'                                           ";
            strBatch_mat_Man += "     AND e.code_function_group = 'FeedWire'                                    ";
            strBatch_mat_Man += "ORDER BY code_des                                                            ";
            dsWire_Add_man.SourceMethod = strBatch_mat_Man;
        }

        //基本数据
        private void btnBaseOK_Click(object sender, EventArgs e)
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

        //加料数据
        private void btnAddMat_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["HeatID"] = strCurHeatID;
            newrow["DisCharge_Time"] = System.DateTime.Now;
            newrow["name"] = "1";
            dsMat.Tables[0].Rows.Add(newrow);
        }

        //确定
        private void btnMatOK_Click(object sender, EventArgs e)
        {
            dvMat.EndEdit();
            bsMat.EndEdit();
            for (int i = 0; i < dvMat.Rows.Count; i++)
            {
                if (dvMat.Rows[i].Cells["Element"].EditedFormattedValue.ToString() == "" && dvMat.Rows[i].Cells["Name_Mat"].Value.ToString() == "1")
                {
                    MessageBox.Show("辅料代码为空！", "提示", MessageBoxButtons.OK);
                    bsMat.Position = i;
                    return;
                }
            }
            bOperation = dsMat.UpdateData();
            MessageShowOperation();
            dsMat.LoadData();
        }

        private void btnMatCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
            this.Dispose();
        }

        //冶炼数据
        private void btnPaocessOK_Click(object sender, EventArgs e)
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

        //成分
        private void btnAddChemical_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsChemical.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["LogTime"] = System.DateTime.Now;
            newrow["Arrive_Date"] = System.DateTime.Now;
            newrow["Report_Date"] = System.DateTime.Now;
            dsChemical.Tables[0].Rows.Add(newrow);
        }

        private void btnChemicalOK_Click(object sender, EventArgs e)
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
        private void btnStatus_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsStatus.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["HeatID"] = strCurHeatID;
            newrow["Change_Time"] = System.DateTime.Now;
            dsStatus.Tables[0].Rows.Add(newrow);
        }

        private void btnStatusOK_Click(object sender, EventArgs e)
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

        //温度
        private void btnAddTemp_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTemp.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["MeasureTime"] = System.DateTime.Now;
            newrow["HeatID"] = strCurHeatID;
            dsTemp.Tables[0].Rows.Add(newrow);
        }

        private void btnTempOK_Click(object sender, EventArgs e)
        {
            dvTemp.EndEdit();
            bsTemp.EndEdit();
            bOperation = dsTemp.UpdateData();
            MessageShowOperation();
            dsTemp.LoadData();
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsTemp.LoadData();
        }

        //定氧
        private void btnAddOxygen_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsOxygen.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;//
            newrow["HeatID"] = strCurHeatID;
            newrow["MeasureTime"] = System.DateTime.Now;
            dsOxygen.Tables[0].Rows.Add(newrow);
        }
        private void btnOxygenOK_Click(object sender, EventArgs e)
        {
            dvOxygen.EndEdit();
            bsOxygen.EndEdit();
            bOperation = dsOxygen.UpdateData();
            MessageShowOperation();
            dsOxygen.LoadData();
        }

        private void btnOxygenCancel_Click(object sender, EventArgs e)
        {
            dsOxygen.LoadData();
        }

        //记事
        private void btnAddRemark_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsRemark.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["HeatID"] = strCurHeatID;
            newrow["LogTime"] = System.DateTime.Now;
            dsRemark.Tables[0].Rows.Add(newrow);
        }

        private void btnNoteConfirm_Click(object sender, EventArgs e)
        {
            dvRemark.EndEdit();
            bsRemark.EndEdit();
            bOperation = dsRemark.UpdateData();
            MessageShowOperation();
            dsRemark.LoadData();
        }

        private void btnNoteCancel_Click(object sender, EventArgs e)
        {
            dsRemark.LoadData();
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

        private void pxControls_TextChangedBase(object sender, EventArgs e)
        {
            btnBaseOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        private void pxControls_TextChangedProcess(object sender, EventArgs e)
        {
            btnPaocessOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void dvMat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //喂线数据
        private void btnWireAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsWire.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["HeatID"] = strCurHeatID;
            newrow["WireTime"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsWire.Tables[0].Rows.Add(newrow);
        }

        private void btnWireConfirm_Click(object sender, EventArgs e)
        {
            dvWire.EndEdit();
            bsWire.EndEdit();
            for (int i = 0; i < dvWire.Rows.Count; i++)
            {
                if (dvWire.Rows[i].Cells["WireCode"].EditedFormattedValue.ToString() == "" && dvWire.Rows[i].Cells["Name_Wire"].Value.ToString() == "1")
                {
                    MessageBox.Show("喂丝代码为空！", "提示", MessageBoxButtons.OK);
                    bsWire.Position = i;
                    return;
                }
            }
            bOperation = dsWire.UpdateData();
            MessageShowOperation();
            dsWire.LoadData();
        }

        private void btnWireCancel_Click(object sender, EventArgs e)
        {
            dsWire.LoadData();
        }

        private void tabCtrlMain_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    switch (e.TabPage.Name)
                    {
                        case "tabLFAddMat":
                            if (dsMat.L3DataAdapter == null)
                                dsMat.L3DataAdapter = Adapter;
                            break;
                        case "tabProcess":
                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;
                            if (dsWholePumpTime.L3DataAdapter == null)
                                dsWholePumpTime.L3DataAdapter = Adapter;
                            /*****Modify By huyunhai 2011-04-11***/
                            cmdTotalTime.Parameters[0].ConstantValue = strCurHeatID;
                            int iRot = cmdTotalTime.Execute();
                            if (iRot == 0)
                            {
                                if (Convert.ToInt64(cmdTotalTime.Command.Return) > 0)
                                {
                                    txtTotalTime.Text = cmdTotalTime.Command.Return.ToString()+"'";
                                }
                            }
                            /******Modify End*****/
                            break;
                        case "tabLadleInfo":
                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;
                            if (dsLadleInfo.Tables[0].Rows.Count < 1)
                            {             
                                dsLadleInfo.Tables[0].Rows.Add();
                                dsLadleInfo.Tables[0].Rows[0]["TreatNo"] = strCurTreatNO;
                                dsLadleInfo.Tables[0].Rows[0]["HeatId"] = strCurHeatID;
                            }
                            break;
                        case "tabChemical":
                            if (dsChemical.L3DataAdapter == null)
                                dsChemical.L3DataAdapter = Adapter;
                            break;
                        case "tabStatus":
                            if (dsStatus.L3DataAdapter == null)
                                dsStatus.L3DataAdapter = Adapter;
                            break;
                        case "tabTemp":
                            if (dsTemp.L3DataAdapter == null)
                                dsTemp.L3DataAdapter = Adapter;
                            break;
                        case "tabOxygen":
                            if (dsOxygen.L3DataAdapter == null)
                                dsOxygen.L3DataAdapter = Adapter;
                            break;
                        case "tabRemark":
                            if (dsRemark.L3DataAdapter == null)
                                dsRemark.L3DataAdapter = Adapter;
                            break;
                        case "tabWire":
                            if (dsWire.L3DataAdapter == null)
                                dsWire.L3DataAdapter = Adapter;
                            break;
                        case "tabExcept":
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
                            break;
                        /*****Modify by huyunhai*****/
                        case "tabTundishTemp":
                            if (dsTundishTemp.L3DataAdapter == null)
                                dsTundishTemp.L3DataAdapter = Adapter;
                            break;
                        /******Modify end********/
                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        private void btnAddExcept_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsExcept.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["UnitTypeID"] = "5";
            newrow["UnitID"] = strCurTreatNO.Substring(0, 1).ToString();
            newrow["Exceptional_Time"] = DateTime.Now;
            dsExcept.Tables[0].Rows.Add(newrow);
        }

        private void btnDelExcept_Click(object sender, EventArgs e)
        {
            if (bsExcept.Current != null)
                bsExcept.RemoveCurrent();
        }

        private void btnConfirmExcept_Click(object sender, EventArgs e)
        {
            dvExcept.EndEdit();
            bsExcept.EndEdit();

            if (dsExcept.GetChanges(DataRowState.Added) != null && dsExcept.GetChanges(DataRowState.Added).Tables[0].Rows.Count > 0)
            {
                cmdHeatExcept.Parameters[0].ConstantValue = strCurHeatID;
                cmdHeatExcept.Parameters[1].ConstantValue = "5";
                cmdHeatExcept.Parameters[2].ConstantValue = strCurTreatNO.Substring(0, 1).ToString();
                cmdHeatExcept.Parameters[3].SourceObject = dsExcept.GetChanges(DataRowState.Added);

                int iRet = cmdHeatExcept.Execute();
                if (iRet != 0 || (Convert.ToInt16(cmdHeatExcept.Command.Return)) != 0)
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdHeatExcept.Command.ErrorCode));
                    MessageBox.Show("失败！" + strReasultShow);
                }
                else
                {
                    MessageBox.Show("记录工艺异常成功！");
                }
            }
            if (dsExcept.GetChanges(DataRowState.Modified) != null && dsExcept.GetChanges(DataRowState.Modified).Tables[0].Rows.Count > 0)
            {
                object objMod = null;
                if (dsExcept.CommitModified(ref objMod))
                {
                    if (Convert.ToBoolean(objMod))
                    {
                        MessageBox.Show("修改成功！", "提示");
                    }
                }
            }
            dsExcept.LoadData();
        }

        private void btnCancelExcept_Click(object sender, EventArgs e)
        {
            dsExcept.LoadData();
        }

        private void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProcessTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtProcessTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtProcessTimeDis.Text = vsTime;
            }
        }

        private void txtSoftBlowTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtSoftBlowTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtSoftBlowTimeDis.Text = vsTime;
            }
        }

        //add by hyh 2012-08-02 新增全泵投用时间
        private void txtWholePumpTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtWholePumpTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtWholePumpTimeDis.Text = vsTime;
            }
        }

        private void dvBatchID_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
           
        }

        private void bsBatchID_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "BindingSource")
                    return;
                if (sender.Equals(bsMat))
                {
                    if ((!btnMatOK.Visible) || (bsMat.Position < 0))
                    {
                        cmb_Mat.Visible = false;
                        return;
                    }
                    if (((System.Data.DataRowView)(bsMat.Current)).Row["Name"].ToString() != "1")
                    {
                        cmb_Mat.Visible = false;
                        return;
                    }

                    string strOldValue = ((System.Data.DataRowView)(bsMat.Current)).Row["Batch_ID"].ToString(); //dvMat.Rows[bsMat.Position].Cells["Batch_ID_Mat"].Value.ToString();
                    string strAlloyCode = ((System.Data.DataRowView)(bsMat.Current)).Row["Element"].ToString();// dvMat.Rows[bsMat.Position].Cells["Element"].Value.ToString();

                    string strCode = strAlloyCode + strOldValue;

                    int iX = 0;
                    int iY = 0;

                    iX += dvMat.RowHeadersWidth;
                    for (int i = 0; i < dvMat.Columns["Element"].Index; i++)
                        iX += dvMat.Columns[i].Width;

                    iY += dvMat.ColumnHeadersHeight;
                    try
                    {
                        for (int j = 0; j < bsMat.Position + 1; j++)
                            iY += dvMat.Rows[j].Cells[0].Size.Height;
                    }
                    catch { iY += 23; }

                    try
                    {
                        cmb_Wire.Size = dvWire.Rows[bsWire.Position].Cells["Element"].Size;
                    }
                    catch { }
                    Point pp = new Point(iX, iY);
                    cmb_Mat.Location = pp;
                    try
                    {
                        cmb_Mat.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsMat_Alloy_Add_Man, strCode);
                    }
                    catch { cmb_Mat.Text = ""; }
                    cmb_Mat.Visible = true;
                }
                else if (sender.Equals(bsWire))
                {
                    if ((!btnWireConfirm.Visible) || (bsWire.Position < 0))
                    {
                        cmb_Wire.Visible = false;
                        return;
                    }
                    if (((System.Data.DataRowView)(bsWire.Current)).Row["Name"].ToString() != "1")
                    {
                        cmb_Wire.Visible = false;
                        return;
                    }
                    string strOldValue =  ((System.Data.DataRowView)(bsWire.Current)).Row["Batch_ID"].ToString();//dvWire.Rows[bsWire.Position].Cells["Batch_ID_Wire"].Value.ToString();
                    string strAlloyCode =  ((System.Data.DataRowView)(bsWire.Current)).Row["WireCode"].ToString();//dvWire.Rows[bsWire.Position].Cells["WireCode"].Value.ToString();
                    string strCode = strAlloyCode + strOldValue;

                    int iX = 0;
                    int iY = 0;

                    iX += dvWire.RowHeadersWidth;
                    for (int i = 0; i < dvWire.Columns["WireCode"].Index; i++)
                        iX += dvWire.Columns[i].Width;

                    iY += dvWire.ColumnHeadersHeight;
                    try
                    {
                        for (int j = 0; j < bsWire.Position + 1; j++)
                            iY += dvWire.Rows[j].Cells[0].Size.Height;
                    }
                    catch { iY += 23; }

                    try
                    {
                        cmb_Wire.Size = dvWire.Rows[bsWire.Position].Cells["WireCode"].Size;
                    }
                    catch { }
                    Point pp = new Point(iX, iY);
                    cmb_Wire.Location = pp;

                    try
                    {
                        cmb_Wire.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsWire_Add_man, strCode);
                    }
                    catch { cmb_Wire.Text = ""; }
                    cmb_Wire.Visible = true;
                }

            }
            catch
            {
                cmb_Mat.Visible = false;
                cmb_Wire.Visible = false;
            }
        }

        private void cmbBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (sender.GetType().Name != "ComboBox")
            //        return;
            //    if (sender.Equals(cmbBatch_Mat))
            //    {
            //        if (dvMat.Rows[bsMat.Position].Cells["Name_Mat"].Value.ToString() != "1")
            //            cmbBatch_Mat.Visible = false;
            //        else
            //        {
            //            cmbBatch_Mat.Visible = true;
            //            dvMat.Rows[bsMat.Position].Cells["Batch_ID_Mat"].Value = cmbBatch_Mat.Text;
            //        }
            //    }
            //    else if (sender.Equals(cmb_Wire))
            //    {
            //        if (dvWire.Rows[bsWire.Position].Cells["Name_Wire"].Value.ToString() != "1")
            //            cmb_Wire.Visible = false;
            //        else
            //        {
            //            cmb_Wire.Visible = true;
            //            dvWire.Rows[bsWire.Position].Cells["Batch_ID_Wire"].Value = cmb_Wire.Text;
            //        }
            //    }
            //}
            //catch { cmbBatch_Mat.Visible = false; }
        }

        private void dvBatchID_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "DataGridView")
                    return;
                if (sender.Equals(dvMat))
                {
                    if (dvMat.Rows.Count < 1)
                        return;
                    for (int i = 0; i < dvMat.Rows.Count; i++)
                    {
                        if (dvMat.Rows[i].Cells["Name_Mat"].Value.ToString() != "1")
                            dvMat.Rows[i].ReadOnly = true;
                        else
                            dvMat.Rows[i].ReadOnly = false;
                    }
                }
                else if (sender.Equals(dvWire))
                {
                    if (dvWire.Rows.Count < 1)
                        return;
                    for (int i = 0; i < dvWire.Rows.Count; i++)
                    {
                        if (dvWire.Rows[i].Cells["Name_Wire"].Value.ToString() != "1")
                            dvWire.Rows[i].ReadOnly = true;
                        else
                            dvWire.Rows[i].ReadOnly = false;
                    }
                }
            }
            catch { }
        }

        private void dvChemical_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (strSteelGradeIndex != "")
            //    CommDataMag.CommonMethed.dv_Info_Element_Cell_BaceColor(Adapter, dvChemical, strSteelGradeIndex, 5);
        }

        /**2009-04-21**/
        //加料
        private void cmb_Mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmb_Mat))
                {
                    if (dvMat.Rows[bsMat.Position].Cells["Name_Mat"].Value.ToString() != "1")
                        cmb_Mat.Visible = false;
                    else
                    {
                        cmb_Mat.Visible = true;

                        dvMat.Rows[bsMat.Position].Cells["Element"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsMat_Alloy_Add_Man, "Alloy_Code", "Code", cmb_Mat.SelectedValue.ToString());

                        dvMat.Rows[bsMat.Position].Cells["Batch_ID_Mat"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsMat_Alloy_Add_Man, "Batch_ID", "Code", cmb_Mat.SelectedValue.ToString());
                    }
                }
            }
            catch { cmb_Mat.Visible = false; }
        }

        //喂线
        private void cmb_Wire_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmb_Wire))
                {
                    if (dvWire.Rows[bsWire.Position].Cells["Name_Wire"].Value.ToString() != "1")
                        cmb_Wire.Visible = false;
                    else
                    {
                        cmb_Wire.Visible = true;

                        dvWire.Rows[bsWire.Position].Cells["WireCode"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "Alloy_Code", "Code", cmb_Wire.SelectedValue.ToString());

                        dvWire.Rows[bsWire.Position].Cells["Batch_ID_Wire"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "Batch_ID", "Code", cmb_Wire.SelectedValue.ToString());
                    }
                }
            }
            catch { cmb_Wire.Visible = false; }
        }

        private void dvWire_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvWire.CurrentCell.ColumnIndex == 3)
                {
                    dvWire.Rows[bsWire.Position].Cells["Amount"].Value = 0;
                    //合金代码
                    string strWireCode = dvWire.Rows[bsWire.Position].Cells["WireCode"].Value.ToString();

                    //根据合金代码查看功能组
                    if (CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "code_function_group", "Alloy_Code", strWireCode) != "FeedWire")
                        return;
                    object objCoefficient = null;
                    Adapter.Session.Get("XGMESLogic\\BaseDataMag\\CBase_Wire_Coefficient\\" + strWireCode, "Coefficient", ref objCoefficient);
                    if (objCoefficient == null)
                        objCoefficient = 0;
                    dvWire.Rows[bsWire.Position].Cells["Amount"].Value =
                       Math.Round(Convert.ToDouble(dvWire.Rows[bsWire.Position].Cells["Weight"].Value.ToString()) * Convert.ToDouble(objCoefficient), 3);
                }
            }
            catch { }
        }

        private void btnLadleInfoOK_Click(object sender, EventArgs e)
        {
            bsLadleInfo.EndEdit();
            bOperation = dsLadleInfo.UpdateData();
            MessageShowOperation();
            dsLadleInfo.LoadData();
        }

        private void btnLadleInfoCancel_Click(object sender, EventArgs e)
        {
            dsLadleInfo.LoadData();
        }

        private void dsBase_OnDataLoaded(object sender)
        {
            try
            {
                strSteelGradeIndex = dsBase.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            }
            catch { strSteelGradeIndex = ""; }
        }

      
        /***********Modify Begin At 2011-03-08 By Huyunhai************/
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (bsMat == null || bsMat.Count < 1 || bsMat.Current == null)
                return;
            DataGridViewSelectedRowCollection dsrc = dvMat.SelectedRows;
            if (dsrc.Count > 0 && dsrc != null)
            {
                foreach (DataGridViewRow dgvr in dsrc)
                {
                    dvMat.Rows.Remove(dgvr);
                }
            }

            if (DialogResult.OK.ToString() == (MessageBox.Show("确定删除指定数据行吗？", " 删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)).ToString())
            {
                btnMatOK_Click(sender, e);//  保存
            }
            else
                dsMat.LoadData();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

       
        /*********Modify END***********/


    }
}