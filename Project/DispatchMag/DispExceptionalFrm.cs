using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace DispatchMag
{
    public partial class DispExceptionalFrm : DockContent, IMESForm
    {
        private string path = Application.StartupPath;

        public DispExceptionalFrm()
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

        private object objShiftID = "";
        private object objTeamID = "";

        private int SendFlag = 1;//0:失败;1:成功

        private string strcmbUnitID = "";//缓存选择工作中心
        private string strcmbShiftID = "";//缓存选择班次

        private string strCurIDObject = "";//缓存主信息当前选择的GUID
        private string strCurUnitID = "";//缓存主信息当前选择的工作中心

        private string strSortMain = "";//缓存主信息排序字段及排序方式
        private string strSortDetail = "";//缓存从信息排序字段及排序方式

        //界面加载
        private void DispExceptionalFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;

            /********************** 工 作 中 心 *************************/
            string strUnitIDSQL = "";
            strUnitIDSQL += " SELECT pk_center, center_name, center_code        ";
            strUnitIDSQL += "   FROM cbase_prod_center_infor                    ";
            strUnitIDSQL += "   WHERE SUBSTR (center_name, 1, 4) <= '1103'      ";
            strUnitIDSQL += "     AND SUBSTR (center_name, 1, 4) >= '1101'      ";
            strUnitIDSQL += "ORDER BY center_name                               ";

            dsUnitID.SourceMethod = strUnitIDSQL;
            
            cmbUnitID.Items.Clear();
            cmbUnitID.Items.Add("");
            if (dsUnitID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsUnitID.Tables[0].Rows.Count; i++)
                    cmbUnitID.Items.Add(dsUnitID.Tables[0].Rows[i]["center_code"].ToString());
            }
            /********************** 工 作 中 心 *************************/

            /**********************    班 次    *************************/
            string strShiftSQL = "";
            strShiftSQL += "  SELECT   pk_shift, shift_code, shift_name         ";
            strShiftSQL += "    FROM cbase_shift_infor                          ";
            strShiftSQL += "   WHERE LENGTH (shift_code) = 4                    ";
            strShiftSQL += "ORDER BY shift_code                                 ";
            dsShiftNC.SourceMethod = strShiftSQL;
            /**********************    班 次    *************************/

            cmbShiftID.Items.Clear();
            for (int j = 0; j < dsShiftNC.Tables[0].Rows.Count; j++)
                cmbShiftID.Items.Add(dsShiftNC.Tables[0].Rows[j]["shift_name"].ToString());

            /**********************    班 别    *************************/
            string strTeamSQL = "";
            strTeamSQL += "  SELECT   pk_team, team_code, team_name, pk_center  ";
            strTeamSQL += "    FROM cbase_team_infor                            ";
            strTeamSQL += "   WHERE SUBSTR (team_code, 1, 4) <= '1103'          ";
            strTeamSQL += "     AND SUBSTR (team_code, 1, 4) >= '1101'          ";
            strTeamSQL += "ORDER BY team_code                                   ";
            dsTeamNC.SourceMethod = strTeamSQL;
            /**********************    班 别    *************************/

            /********************** 异 常 代 码 *************************/
            string strItemsSql = "";
            strItemsSql += "SELECT pk_exception, exception_code, exception_name ";
            strItemsSql += "  FROM cbase_excep_infor                            ";
            strItemsSql += " WHERE LENGTH (exception_code) = 6                  ";
            strItemsSql += "   AND SUBSTR (exception_code, 1, 4) <= '1103'";
            strItemsSql += "   AND SUBSTR (exception_code, 1, 4) >= '1101'      ";

            dsItems.SourceMethod = strItemsSql;
            /********************** 异 常 代 码 *************************/
            string strSql = " CreateDate >= '" + dtStart.Text.Trim() + "'";
            if (strcmbUnitID != "")
            {
                strSql += strcmbUnitID;
            }
            strSql += " order by CreateDate desc,CreateTime desc";
            cmdpMain.ConstantValue = strSql;
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询主信息
        private void btnQuery_Click(object sender, EventArgs e)
        {
            cmdpMain.ConstantValue = "";

            string strSql = " CreateDate = '" + dtStart.Text.Trim() + "'";
            if (strcmbShiftID != "")
            {
                strSql += strcmbShiftID;
            }
            strSql += " order by CreateDate desc,CreateTime desc";
            cmdpMain.ConstantValue = strSql;
            dsMain.LoadData();
        }

        //新增主信息
        private void btnAddMain_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsMain.Tables[0].NewRow();
                newrow["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newrow["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd");
              
                string strTeamNC = "1001NC100000000049NL";
                string strShiftNC = "1001NC1000000000103W";
                
                if (objShiftID != null && objTeamID != null)
                {
                    if (objShiftID.ToString() == "1")
                        strShiftNC = "1001NC1000000000103W";
                    else if (objShiftID.ToString() == "2")
                        strShiftNC = "1001NC1000000000103X";
                    else if (objShiftID.ToString() == "3")
                        strShiftNC = "1001NC1000000000103Y";

                    if (objTeamID.ToString() == "1")
                        strTeamNC = "1001NC100000000049NL";
                    else if (objTeamID.ToString() == "2")
                        strTeamNC = "1001NC100000000044EI";
                    else if (objTeamID.ToString() == "3")
                        strTeamNC = "1001NC100000000049NL";
                    else if (objTeamID.ToString() == "4")
                        strTeamNC = "1001NC100000000044EQ";
                }
                newrow["UnitID"] = "1001NC100000000015QG";
                newrow["Shift"] = strShiftNC;
                newrow["Team"] = strTeamNC;

                newrow["Operator"] = Adapter.Session.User;

                dsMain.Tables[0].Rows.Add(newrow);
                bsMain.MoveFirst();

                while (((System.Data.DataRowView)(bsMain.Current)).Row != newrow && bsMain.Position < dsMain.Tables[0].Rows.Count - 1)
                {
                    bsMain.MoveNext();
                }
                DisExcepitonalShowFrm FrmMain = new DisExcepitonalShowFrm();
                FrmMain.ShowDialogEx(Adapter.Session, strSortMain, bsMain.Position, ref dsMain);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改主信息
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0 && dsMain.Tables[0].Rows.Count > 0)
            //{
            //    bsMain.Position = e.RowIndex;
            //    DisExcepitonalShowFrm FrmMain = new DisExcepitonalShowFrm();
            //    FrmMain.ShowDialogEx(Adapter.Session, strSortMain, bsMain.Position, ref dsMain);
            //    GC.Collect();
            //}
        }

        //删除主信息
        private void btnDelMain_Click(object sender, EventArgs e)
        {
            if (bsMain.Position >= 0)
                bsMain.RemoveCurrent();
        }

        //主信息保存
        private void btnConfirmMain_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            if (dsMain.GetChanges() == null)
                return;

            if (dsMain.UpdateData())
            {
                MessageBox.Show("主信息操作成功！", "提示");
                dsMain.LoadData();               
            }
            else
                MessageBox.Show("主信息操作失败！", "提示");
        }

        //主信息取消
        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            dsMain.LoadData();
        }

        //主信息换行时发生
        private void bsMain_CurrentChanged(object sender, EventArgs e)
        {
            if (dvMain.Rows.Count > 0)
            {
                try
                {
                    strCurIDObject = dvMain.Rows[bsMain.Position].Cells[IDObject_Main.Index].Value.ToString();
                    strCurUnitID = dvMain.Rows[bsMain.Position].Cells[unitIDDataGridViewTextBoxColumn.Index].Value.ToString();
                    if (strCurIDObject == "" || strCurUnitID == "")
                    {
                        dsDetail.Tables[0].Clear();
                        return;
                    }
                    
                    cmdpDetail.ConstantValue = "IDObject = '" + strCurIDObject + "' order by BeginTime";
                    if (dsDetail.GetChanges() == null)
                    {
                        dsDetail.Tables[0].Clear();
                        dsDetail.LoadData();
                        return;
                    }

                    //提示是否保存从信息
                    string strYes = MessageBox.Show("详细信息已被修改,是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
                    if (strYes == "Yes")
                    {
                        dsDetail.UpdateData();
                        dsDetail.LoadData();
                        return;
                    }
                    dsDetail.LoadData();
                }
                catch
                {
                    dsDetail.Tables[0].Clear();
                }
            }
            else
            {
                dsDetail.Tables[0].Clear();
            }
        }

        //新增详细信息
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (strCurIDObject == "" || strCurUnitID == "")
                    return;
                          
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsDetail.Tables[0].NewRow();

                newrow["IDObject"] = strCurIDObject;
                newrow["UnitID"] = strCurUnitID;
                newrow["BeginTime"] = DateTime.Now.ToString("HH:mm:ss");
                newrow["EndTime"] = DateTime.Now.ToString("HH:mm:ss");
                newrow["TimeSpan"] = 0;
                newrow["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newrow["Note"] = "";

                dsDetail.Tables[0].Rows.Add(newrow);
                bsDetail.MoveFirst();

                while ((bsDetail.Current as System.Data.DataRowView).Row != newrow || bsDetail.Position < dsDetail.Tables[0].Rows.Count - 1)
                {
                    bsDetail.MoveNext();
                }
                DisExcepitonalItemsShowFrm FrmDetail = new DisExcepitonalItemsShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, strSortDetail, bsDetail.Position, ref dsDetail);
                GC.Collect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改详细信息 
        private void dvDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsDetail.Tables[0].Rows.Count > 0)
            {
                bsDetail.Position = e.RowIndex;
                DisExcepitonalItemsShowFrm FrmDetail = new DisExcepitonalItemsShowFrm();
                FrmDetail.ShowDialogEx(Adapter.Session, strSortDetail, bsDetail.Position, ref dsDetail);
                GC.Collect();
            }
        }

        //删除详细信息
        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            if (bsDetail.Position >= 0)
                bsDetail.RemoveCurrent();
        }

        //详细信息保存
        private void btnConfirmDetail_Click(object sender, EventArgs e)
        {
            dvDetail.EndEdit();
            bsDetail.EndEdit();
            if (dsDetail.GetChanges() == null)
            {
                return;
            }
            if (dsDetail.UpdateData())
            {
                MessageBox.Show("详细操作成功！", "提示");
                dsDetail.LoadData();
            }
            else
            {
                MessageBox.Show("详细操作失败！", "提示");
            }
        }

        //详细信息取消
        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            dsDetail.LoadData();
        }

        private void dvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dsMain.GetChanges() != null || dsMain.Tables[0].Rows.Count < 1)
                DetailEnableSet(false);
            else
                DetailEnableSet(true);
        }

        private void dvMain_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortMain = ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

       
        private void dvDetail_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSortDetail = ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        //设置详细信息可用性
        private void DetailEnableSet(bool bFlag)
        {
            btnAddDetail.Enabled = bFlag;
            btnDelDetail.Enabled = bFlag;
            dvDetail.Enabled = bFlag;
            btnConfirmDetail.Enabled = bFlag;
            btnCancelDetail.Enabled = bFlag;
        }

        private void DispExceptionalFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnExlMain_Click(object sender, EventArgs e)
        {
           // CommDataMag.CommonMethed.PutIntoExcel("异常信息主信息", dvMain);　
        }

        private void btnQueryDetail_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnitID.Text.ToString() != "")
                strcmbUnitID = " and UnitID = '" + GetStrCodeByDesc(dsUnitID, cmbUnitID.Text.Trim(), "center_code", "pk_center") + "'";
            else
                strcmbUnitID = "";
        }

        //
        private void cmbShiftID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShiftID.Text.Trim() != "")
                strcmbShiftID = " and Shift = '" + GetStrCodeByDesc(dsShiftNC, cmbShiftID.Text.Trim(), "pk_shift", "shift_name") + "'";
            else
                strcmbShiftID = "";
        }

        private string GetStrCodeByDesc(DataSet ds, string strDes,string Code,string Code_Des)
        {
            try
            {
                string strID = "";
                string strCondition = "" + Code_Des + " = '" + strDes + "'";//center_code
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strID = DataRowTemp["" + Code + ""].ToString();//pk_center
                }
                return strID;
            }
            catch { return ""; }
        }

        //完全新增
        private void btnAddMainAll_Click(object sender, EventArgs e)
        {
            NewAllMainDataSet();
        }

        private void NewAllMainDataSet()
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //没有获取到当前班别班次
                if (objShiftID == null || objTeamID == null)
                    return;

                //设置NC班次
                string strShiftNC = "";
                string dtCreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string strCreateDate = DateTime.Now.ToString("yyyy-MM-dd");
                string strOperator = Adapter.Session.User;

                if (objShiftID != null)
                {
                    if (objShiftID.ToString() == "1")
                        strShiftNC = "1001NC1000000000103W";
                    else if (objShiftID.ToString() == "2")
                        strShiftNC = "1001NC1000000000103X";
                    else if (objShiftID.ToString() == "3")
                        strShiftNC = "1001NC1000000000103Y";
                    else
                    {
                        MessageBox.Show("出现异常情况，请联系维护人员检查CBase_All_Code数据库表Code_Group = 'ShiftID' 的班次信息！", "提示");
                        return;
                    }
                }
                /*********************** 1#BOF ****************************/
                DataRow drBOF1 = dsMain.Tables[0].NewRow();
                drBOF1["CreateTime"] = dtCreateTime;
                drBOF1["CreateDate"] = strCreateDate;
                drBOF1["UnitID"] = "1001NC100000000015QG";
                drBOF1["Shift"] = strShiftNC;
                drBOF1["Operator"] = strOperator;
                drBOF1["Team"] = GetStrCodeByDesc(dsTeamNC, "1101010" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drBOF1);
                /*********************** 1#BOF ****************************/

                //2#BOF
                DataRow drBOF2 = dsMain.Tables[0].NewRow();
                drBOF2["CreateTime"] = dtCreateTime;
                drBOF2["CreateDate"] = strCreateDate;
                drBOF2["UnitID"] = "1001NC100000000015QN";
                drBOF2["Shift"] = strShiftNC;
                drBOF2["Operator"] = strOperator;
                drBOF2["Team"] = GetStrCodeByDesc(dsTeamNC, "1101020" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drBOF2);

                //3#BOF
                DataRow drBOF3 = dsMain.Tables[0].NewRow();
                drBOF3["CreateTime"] = dtCreateTime;
                drBOF3["CreateDate"] = strCreateDate;
                drBOF3["UnitID"] = "1001NC100000000015QS";
                drBOF3["Shift"] = strShiftNC;
                drBOF3["Operator"] = strOperator;
                drBOF3["Team"] = GetStrCodeByDesc(dsTeamNC, "1101030" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drBOF3);

                //4#BOF
                DataRow drBOF4 = dsMain.Tables[0].NewRow();
                drBOF4["CreateTime"] = dtCreateTime;
                drBOF4["CreateDate"] = strCreateDate;
                drBOF4["UnitID"] = "1001NC100000000015QU";
                drBOF4["Shift"] = strShiftNC;
                drBOF4["Operator"] = strOperator;
                drBOF4["Team"] = GetStrCodeByDesc(dsTeamNC, "1101040" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drBOF4);

                //1#LF
                DataRow drLF1 = dsMain.Tables[0].NewRow();
                drLF1["CreateTime"] = dtCreateTime;
                drLF1["CreateDate"] = strCreateDate;
                drLF1["UnitID"] = "1001NC100000000015QW";
                drLF1["Shift"] = strShiftNC;
                drLF1["Operator"] = strOperator;
                drLF1["Team"] = GetStrCodeByDesc(dsTeamNC, "1102010" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drLF1);

                //2#LF
                DataRow drLF2 = dsMain.Tables[0].NewRow();
                drLF2["CreateTime"] = dtCreateTime;
                drLF2["CreateDate"] = strCreateDate;
                drLF2["UnitID"] = "1001NC100000000015R0";
                drLF2["Shift"] = strShiftNC;
                drLF2["Operator"] = strOperator;
                drLF2["Team"] = GetStrCodeByDesc(dsTeamNC, "1102020" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drLF2);

                //3#LF
                DataRow drLF3 = dsMain.Tables[0].NewRow();
                drLF3["CreateTime"] = dtCreateTime;
                drLF3["CreateDate"] = strCreateDate;
                drLF3["UnitID"] = "1001NC100000000015R2";
                drLF3["Shift"] = strShiftNC;
                drLF3["Operator"] = strOperator;
                drLF3["Team"] = GetStrCodeByDesc(dsTeamNC, "1102030" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drLF3);

                //５#LF
                DataRow drLF5 = dsMain.Tables[0].NewRow();
                drLF5["CreateTime"] = dtCreateTime;
                drLF5["CreateDate"] = strCreateDate;
                drLF5["UnitID"] = "1001NC100000002DPNCG";
                drLF5["Shift"] = strShiftNC;
                drLF5["Operator"] = strOperator;
                drLF5["Team"] = GetStrCodeByDesc(dsTeamNC, "1102050" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drLF5);

                //4#LF
                //add by hyh 2012-06-25
                DataRow drLF4 = dsMain.Tables[0].NewRow();
                drLF4["CreateTime"] = dtCreateTime;
                drLF4["CreateDate"] = strCreateDate;
                drLF4["UnitID"] = "1001NC100000001KDV0W";
                drLF4["Shift"] = strShiftNC;
                drLF4["Operator"] = strOperator;
                drLF4["Team"] = GetStrCodeByDesc(dsTeamNC, "1402010" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drLF4);
                //end

                //1#RH
                DataRow drRH1 = dsMain.Tables[0].NewRow();
                drRH1["CreateTime"] = dtCreateTime;
                drRH1["CreateDate"] = strCreateDate;
                drRH1["UnitID"] = "1001NC100000000015R3";
                drRH1["Shift"] = strShiftNC;
                drRH1["Operator"] = strOperator;
                drRH1["Team"] = GetStrCodeByDesc(dsTeamNC, "1102040" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drRH1);


                /*********************** 1#CCM ****************************/
                DataRow drCCM1 = dsMain.Tables[0].NewRow();
                drCCM1["CreateTime"] = dtCreateTime;
                drCCM1["CreateDate"] = strCreateDate;
                drCCM1["UnitID"] = "1001NC100000000015R4";
                drCCM1["Shift"] = strShiftNC;
                drCCM1["Operator"] = strOperator;
                drCCM1["Team"] = GetStrCodeByDesc(dsTeamNC, "1103010" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM1);
                /*********************** 1#CCM ****************************/

                /*********************** 2#CCM ****************************/
                DataRow drCCM2 = dsMain.Tables[0].NewRow();
                drCCM2["CreateTime"] = dtCreateTime;
                drCCM2["CreateDate"] = strCreateDate;
                drCCM2["UnitID"] = "1001NC100000000015R6";
                drCCM2["Shift"] = strShiftNC;
                drCCM2["Operator"] = strOperator;
                drCCM2["Team"] = GetStrCodeByDesc(dsTeamNC, "1103020" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM2);
                /*********************** 2#CCM ****************************/


                /*********************** 3#CCM ****************************/
                DataRow drCCM3 = dsMain.Tables[0].NewRow();
                drCCM3["CreateTime"] = dtCreateTime;
                drCCM3["CreateDate"] = strCreateDate;
                drCCM3["UnitID"] = "1001NC100000000015R7";
                drCCM3["Shift"] = strShiftNC;
                drCCM3["Operator"] = strOperator;
                drCCM3["Team"] = GetStrCodeByDesc(dsTeamNC, "1103030" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM3);
                /*********************** 3#CCM ****************************/


                /*********************** 4#CCM ****************************/
                DataRow drCCM4 = dsMain.Tables[0].NewRow();
                drCCM4["CreateTime"] = dtCreateTime;
                drCCM4["CreateDate"] = strCreateDate;
                drCCM4["UnitID"] = "1001NC100000000015R8";
                drCCM4["Shift"] = strShiftNC;
                drCCM4["Operator"] = strOperator;
                drCCM4["Team"] = GetStrCodeByDesc(dsTeamNC, "1103040" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM4);
                /*********************** 4#CCM ****************************/

                /*********************** 5#CCM ****************************/
                DataRow drCCM5 = dsMain.Tables[0].NewRow();
                drCCM5["CreateTime"] = dtCreateTime;
                drCCM5["CreateDate"] = strCreateDate;
                drCCM5["UnitID"] = "1001NC100000000015R9";
                drCCM5["Shift"] = strShiftNC;
                drCCM5["Operator"] = strOperator;
                drCCM5["Team"] = GetStrCodeByDesc(dsTeamNC, "1103050" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM5);
                /*********************** 5#CCM ****************************/

                /*********************** 7#CCM ****************************/
                DataRow drCCM7 = dsMain.Tables[0].NewRow();
                drCCM7["CreateTime"] = dtCreateTime;
                drCCM7["CreateDate"] = strCreateDate;
                drCCM7["UnitID"] = "1001NC100000002DPNDB";
                drCCM7["Shift"] = strShiftNC;
                drCCM7["Operator"] = strOperator;
                drCCM7["Team"] = GetStrCodeByDesc(dsTeamNC, "1103060" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM7);
                /*********************** 7#CCM ****************************/

                //6#铸机
                //add by hyh 2012-06-25
                DataRow drCCM6 = dsMain.Tables[0].NewRow();
                drCCM6["CreateTime"] = dtCreateTime;
                drCCM6["CreateDate"] = strCreateDate;
                drCCM6["UnitID"] = "1001NC100000001JTY8G";
                drCCM6["Shift"] = strShiftNC;
                drCCM6["Operator"] = strOperator;
                drCCM6["Team"] = GetStrCodeByDesc(dsTeamNC, "1403010" + objTeamID.ToString() + "", "PK_TEAM", "TEAM_CODE");
                dsMain.Tables[0].Rows.Add(drCCM6);
                //end
            }
            catch { }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string strXslt = @"ExceptionalData.xslt";
            //组织发送记录集
            DataSet dsM = new DataSet();
           
            if (dsMain.Tables[0].Rows.Count > 0)
            {
                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                string strObjectID = dvMain.CurrentRow.Cells["IDObject_Main"].Value.ToString();
                foreach(DataRow row in dsMain.Tables[0].Rows)
                {
                    if(row["IDObject"].ToString() == strObjectID)
                        tbM.ImportRow(row);

                }
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);
                
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            if (dsDetail.Tables[0].Rows.Count > 0)
            {
                DataTable tbS = new DataTable();
                tbS = dsDetail.Tables[0].Clone();
                tbS = dsDetail.Tables[0].Copy();
                tbS.TableName = "s1";
                dsM.Tables.Add(tbS);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }


            string strXML = NCTelDataMag.TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = NCTelDataMag.TelComm.TransferXML(strXML);
        }

        //2009-04-11 liuzhiqiang
        private void sendDataToNC()
        {
            string strXslt = @"ExceptionalMainData.xslt";            

            foreach (DataRow row in dsMain.Tables[0].Rows)
            {
                DataSet dsM = new DataSet();

                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                tbM.ImportRow(row);
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);

                string strXML = NCTelDataMag.TelComm.TranslateDataSetToNC(strXslt, dsM);
                string strRet = NCTelDataMag.TelComm.ErrorTransferXML(strXML);
                if (strRet != "1")
                {
                    SendFlag = 0;
                }
            }                      
        }

        private void btnMainDataToNC_Click(object sender, EventArgs e)
        {
            //2009-04-11 liuzhiqiang 上传NC只有主表记录的数据
            if (dvMain.RowCount == 0)
            {
                MessageBox.Show("请准备发送数据", "提示");
                return;
            }
            sendDataToNC();
            if (SendFlag == 0)
            {
                MessageBox.Show("发送NC数据失败", "提示");
                SendFlag = 1;
            }
            else
            {
                MessageBox.Show("发送NC数据成功", "提示");
                SendFlag = 1;
            }
        }

    }
}