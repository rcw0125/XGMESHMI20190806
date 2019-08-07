using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFHeatInfoFrm : Form
    {
        public LFHeatInfoFrm()
        {
            InitializeComponent();
        }

        private bool UnLock = false;
        private bool check = false;

        private bool bOperation = false;
        private string strCurHeatID = "";
        private string strCurTreatNO = "";

        private string strSteelGradeIndex = "";//当前炉号对应当前炼钢记号

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="bLock">实绩锁定标志:True 实绩已锁定,不可修改任何实绩;False 实绩尚未锁定,可修改部分实绩</param>
        /// <param name="bCheckFlag">数据维护标志:True 可维护所有数据,False 参照锁定标志</param>
        /// <param name="strTreatNo">处理号</param>
        /// <param name="strHeatID">炉号</param>
        /// <returns></returns>
        public DialogResult ShowDialogEx(AppSvrIF.Session session, bool bLock, bool bCheckFlag, string strTreatNo, string strHeatID)
        {

            UnLock = !bLock;
            check = bCheckFlag;

            tbxTreatNo.Text = strTreatNo;
            tbxHeatID.Text = strHeatID;
            strCurHeatID = strHeatID;
            strCurTreatNO = strTreatNo;

            dsBase.SourceCondition = " TreatNo = '" + strTreatNo + "'";

            dsMat.SourceCondition = " TreatNo = '" + strTreatNo + "' order by Discharge_Time desc";

            dsProcess.SourceCondition = " TreatNo = '" + strTreatNo + "'";

            dsStatus.SourceCondition = "TreatNo = '" + strTreatNo + "' order by Change_Time asc";

            dsTemp.SourceCondition = "TreatNo = '" + strTreatNo + "' order by MeasureTime desc";

            dsOxygen.SourceCondition = " TreatNo = '" + strTreatNo + "' order by Measure_Time desc";

            dsRemark.SourceCondition = " TreatNo = '" + strTreatNo + "' order by LogTime desc";

            dsChemical.SourceCondition = "HeatID = '" + strHeatID + "'order by Report_Date desc";// and UNITTYPEID = '4' 

            dsWire.SourceCondition = " TreatNo = '" + strTreatNo + "' order by WireTime desc";

            //炉次异常
            dsExcept.SourceCondition = "HeatID = '" + strHeatID + "' and UnitTypeID = '4' and UnitID = '" + strTreatNo.Substring(0, 1) + "'";

            //中包温度
            dsTundishTemp.SourceCondition = "HeatID = '" + strHeatID + "' order by MEASURE_TIME desc";

            //钢包信息
            dsLadleInfo.SourceCondition = "TreatNo = '" + strTreatNo + "'";

            //中包温度跟踪
            dsTempControl.SourceCondition = "HeatID = '" + strHeatID + "'";

            //加料
            string strSQL_BatchID = "";
            dsBatchID_Mat.SourceMethod = "";
            dsBatchID_Wire.SourceMethod = "";
            if (strTreatNo != "" && strTreatNo.Substring(0, 1) == "1")
            {
                #region  1 、2 LF 炉合金加料
                /* 1 、2 LF 炉合金加料 */
                strSQL_BatchID = "";
                strSQL_BatchID += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,               ";
                strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des                    ";
                strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                strSQL_BatchID += "         (SELECT *                                                             ";
                strSQL_BatchID += "            FROM xgstorearea                                                   ";
                strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                strSQL_BatchID += "         cbase_all_code e                                                      ";
                strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                strSQL_BatchID += "     AND (d.containerid = '2' OR d.containerid = '6')                          ";
                strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                strSQL_BatchID += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire' ";
                strSQL_BatchID += "         )                                                                     ";
                strSQL_BatchID += "ORDER BY code_des                                                            ";
                dsBatchID_Mat.SourceMethod = strSQL_BatchID;
                //喂线            
                /* 1 、2 LF 炉合金喂线 */
                strSQL_BatchID = "";
                strSQL_BatchID += "SELECT distinct  c.alloy_code, c.batch_id, c.materialid AS code,               ";
                strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des,e.code_function_group ";
                strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                strSQL_BatchID += "         (SELECT *                                                             ";
                strSQL_BatchID += "            FROM xgstorearea                                                   ";
                strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                strSQL_BatchID += "         cbase_all_code e                                                      ";
                strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                strSQL_BatchID += "     AND (d.containerid = '2' OR d.containerid = '6')                          ";
                strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                strSQL_BatchID += "     AND e.code_function_group = 'FeedWire'                                    ";
                strSQL_BatchID += "ORDER BY code_des                                                            ";
                dsBatchID_Wire.SourceMethod = strSQL_BatchID;
#endregion 
            }
            else
            {
                if (strTreatNo != "" && strTreatNo.Substring(0, 1) == "2")
                {
                    #region "1 、2 LF 炉合金加料"
                    /* 1 、2 LF 炉合金加料 */
                    strSQL_BatchID = "";
                    strSQL_BatchID += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,               ";
                    strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des                    ";
                    strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                    strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                    strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                    strSQL_BatchID += "         (SELECT *                                                             ";
                    strSQL_BatchID += "            FROM xgstorearea                                                   ";
                    strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                    strSQL_BatchID += "         cbase_all_code e                                                      ";
                    strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                    strSQL_BatchID += "     AND (d.containerid = '2' OR d.containerid = '7')                          ";
                    strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                    strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                    strSQL_BatchID += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire' ";
                    strSQL_BatchID += "         )                                                                     ";
                    strSQL_BatchID += "ORDER BY code_des                                                            ";
                    dsBatchID_Mat.SourceMethod = strSQL_BatchID;
                    //喂线            
                    /* 1 、2 LF 炉合金喂线 */
                    strSQL_BatchID = "";
                    strSQL_BatchID += "SELECT distinct  c.alloy_code, c.batch_id, c.materialid AS code,               ";
                    strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des,e.code_function_group ";
                    strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                    strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                    strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                    strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                    strSQL_BatchID += "         (SELECT *                                                             ";
                    strSQL_BatchID += "            FROM xgstorearea                                                   ";
                    strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                    strSQL_BatchID += "         cbase_all_code e                                                      ";
                    strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                    strSQL_BatchID += "     AND (d.containerid = '2' OR d.containerid = '7')                          ";
                    strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                    strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                    strSQL_BatchID += "     AND e.code_function_group = 'FeedWire'                                    ";
                    strSQL_BatchID += "ORDER BY code_des                                                            ";
                    dsBatchID_Wire.SourceMethod = strSQL_BatchID;
                    #endregion
                }
                else
                {
                    if (strTreatNo != "" && strTreatNo.Substring(0, 1) == "3")
                    {
                        #region "3 LF 炉合金加料"
                        /* 3 LF 炉合金加料 */
                        strSQL_BatchID = "";
                        strSQL_BatchID += "SELECT distinct  c.alloy_code, c.batch_id, c.materialid AS code,               ";
                        strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des                    ";
                        strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                        strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                        strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                        strSQL_BatchID += "         (SELECT *                                                             ";
                        strSQL_BatchID += "            FROM xgstorearea                                                   ";
                        strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                        strSQL_BatchID += "         cbase_all_code e                                                      ";
                        strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                        strSQL_BatchID += "     AND (d.containerid = '3' OR d.containerid = '8')                          ";
                        strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                        strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                        strSQL_BatchID += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire' ";
                        strSQL_BatchID += "         )                                                                     ";
                        strSQL_BatchID += "ORDER BY code_des                                                            ";
                        dsBatchID_Mat.SourceMethod = strSQL_BatchID;

                        /* 3 LF 炉合金喂线 */
                        strSQL_BatchID = "";
                        strSQL_BatchID += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,               ";
                        strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des, e.code_function_group ";
                        strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                        strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                        strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                        strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                        strSQL_BatchID += "         (SELECT *                                                             ";
                        strSQL_BatchID += "            FROM xgstorearea                                                   ";
                        strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                        strSQL_BatchID += "         cbase_all_code e                                                      ";
                        strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                        strSQL_BatchID += "     AND (d.containerid = '3' OR d.containerid = '8')                          ";
                        strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                        strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                        strSQL_BatchID += "     AND e.code_function_group = 'FeedWire'                                    ";
                        strSQL_BatchID += "ORDER BY code_des                                                            ";
                        dsBatchID_Wire.SourceMethod = strSQL_BatchID;
                        #endregion
                    }
                    else
                    {
                        if (strTreatNo != "" && strTreatNo.Substring(0, 1) == "4")
                        {
                            #region "4 LF 炉合金加料"
                            /* 4 LF 炉合金加料 */
                            strSQL_BatchID = "";
                            strSQL_BatchID += "SELECT distinct  c.alloy_code, c.batch_id, c.materialid AS code,               ";
                            strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des                    ";
                            strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                            strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                            strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                            strSQL_BatchID += "         (SELECT *                                                             ";
                            strSQL_BatchID += "            FROM xgstorearea                                                   ";
                            strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                            strSQL_BatchID += "         cbase_all_code e                                                      ";
                            strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                            strSQL_BatchID += "     AND (d.containerid = '11' OR d.containerid = '12')                          ";
                            strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                            strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                            strSQL_BatchID += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire' ";
                            strSQL_BatchID += "         )                                                                     ";
                            strSQL_BatchID += "ORDER BY code_des                                                            ";
                            dsBatchID_Mat.SourceMethod = strSQL_BatchID;

                            /* 4 LF 炉合金喂线 */
                            strSQL_BatchID = "";
                            strSQL_BatchID += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,               ";
                            strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des, e.code_function_group ";
                            strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                            strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                            strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                            strSQL_BatchID += "         (SELECT *                                                             ";
                            strSQL_BatchID += "            FROM xgstorearea                                                   ";
                            strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                            strSQL_BatchID += "         cbase_all_code e                                                      ";
                            strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                            strSQL_BatchID += "     AND (d.containerid = '11' OR d.containerid = '12')                          ";
                            strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                            strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                            strSQL_BatchID += "     AND e.code_function_group = 'FeedWire'                                    ";
                            strSQL_BatchID += "ORDER BY code_des                                                            ";
                            dsBatchID_Wire.SourceMethod = strSQL_BatchID;
                            #endregion
                         }
                        else 
                        {
                            #region "5 LF 炉合金加料"
                            /* 5 LF 炉合金加料 */
                            strSQL_BatchID = "";
                            strSQL_BatchID += "SELECT distinct  c.alloy_code, c.batch_id, c.materialid AS code,               ";
                            strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des                    ";
                            strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                            strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                            strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                            strSQL_BatchID += "         (SELECT *                                                             ";
                            strSQL_BatchID += "            FROM xgstorearea                                                   ";
                            strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                            strSQL_BatchID += "         cbase_all_code e                                                      ";
                            strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                            strSQL_BatchID += "     AND (d.containerid = '9' OR d.containerid = '10')                          ";
                            strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                            strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                            strSQL_BatchID += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire' ";
                            strSQL_BatchID += "         )                                                                     ";
                            strSQL_BatchID += "ORDER BY code_des                                                            ";
                            dsBatchID_Mat.SourceMethod = strSQL_BatchID;

                            /* 5 LF 炉合金喂线 */
                            strSQL_BatchID = "";
                            strSQL_BatchID += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,               ";
                            strSQL_BatchID += "         e.code_des || '(' || c.batch_id || ')' AS code_des, e.code_function_group ";
                            strSQL_BatchID += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.alloy_code     ";
                            strSQL_BatchID += "            FROM materialposition a, calloy_data b                             ";
                            strSQL_BatchID += "           WHERE a.materialid = b.materialid                                   ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 1, 3) = 'S81'                             ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'                              ";
                            strSQL_BatchID += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,                          ";
                            strSQL_BatchID += "         (SELECT *                                                             ";
                            strSQL_BatchID += "            FROM xgstorearea                                                   ";
                            strSQL_BatchID += "           WHERE SUBSTR (code, 1, 3) = 'S81') d,                               ";
                            strSQL_BatchID += "         cbase_all_code e                                                      ";
                            strSQL_BatchID += "   WHERE c.pos = d.code                                                        ";
                            strSQL_BatchID += "     AND (d.containerid = '9' OR d.containerid = '10')                          ";
                            strSQL_BatchID += "     AND c.alloy_code = e.code                                                 ";
                            strSQL_BatchID += "     AND e.code_group = 'ALLOY_CODE'                                           ";
                            strSQL_BatchID += "     AND e.code_function_group = 'FeedWire'                                    ";
                            strSQL_BatchID += "ORDER BY code_des                                                            ";
                            dsBatchID_Wire.SourceMethod = strSQL_BatchID;
                            #endregion
                        }
                    }
                }
            }

            Adapter.Session = session;
            Adapter.RefreshDataBindings();
            return ShowDialog();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnPaocessOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        //界面加载
        private void LFHeatInfoFrm_Load(object sender, EventArgs e)
        {
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
                //btnAddTemp.Visible = true;
                pnlTemp.Visible = true;
                btnTempOK.Visible = true;

                //定氧数据
                //btnAddOxygen.Visible = true;
                pnlOxygen.Visible = true;
                btnOxygenOK.Visible = true;

                //记事数据
                btnAddRemark.Visible = true;
                pnlNote.Visible = true;
                btnNoteConfirm.Visible = true;


                //中包温度跟踪
                
                
                button2.Visible = true;

                //喂线数据
                btnWireAdd.Visible = true;
                pnlWire.Visible = true;
                btnWireConfirm.Visible = true;
            }
            else
            {
                pnlChemical.Visible = false;//UnLock;
                btnAddChemical.Visible = false;// UnLock;

                pnlStatus.Visible = false;//UnLock;
                btnAddStatus.Visible = false;// UnLock;

                pnlLadleInfo.Visible = UnLock;

                pnlTemp.Visible = false;//UnLock;
                //btnAddTemp.Visible = false;// UnLock;
                
                
                pnlOxygen.Visible = false;//UnLock;
                //btnAddOxygen.Visible = false;//UnLock;
                if (!UnLock)
                {
                    pnlProcess.Visible = UnLock;
                    fLPExcept.Visible = UnLock;
                    pnlNote.Visible = UnLock;

                    pnlMat.Visible = UnLock;// ;false
                    pnlWire.Visible = UnLock;// ;false

                    btnAddMat.Visible = UnLock;//;false
                    btnWireAdd.Visible = UnLock;// ;false
                    button2.Visible = UnLock;//false;
                    btnAddExcept.Visible = UnLock;
                    btnAddRemark.Visible = UnLock;
                }
            }

            tbxTreatNo.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxPreHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxSteelGradeIndex.TextChanged += new EventHandler(pxControls_TextChanged);
            txtArrivalTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtProcessTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHeatTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHeatCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtProbeVonder.TextChanged += new EventHandler(pxControls_TextChanged);
            txtFeedWireTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtDepartureTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSoftBlowTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLidLife.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHoldBackTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLadleNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSteelWeight.TextChanged += new EventHandler(pxControls_TextChanged);

            if (UnLock)
            {
                if (dsProcess.Tables[0].Rows.Count < 1)
                {
                    DataRow newrow = dsProcess.Tables[0].NewRow();
                    dsProcess.Tables[0].Rows.Add(newrow);
                }
            }
        }

        //确认
        private void btnBaseOK_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            bOperation = dsBase.UpdateData();
            MessageShowOperation();
            dsBase.LoadData();
        }

        //取消
        private void btnBaseCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }

        //加料
        private void btnAddMat_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["TreatNo"] = tbxTreatNo.Text;
            newrow["HeatID"] = tbxHeatID.Text;
            newrow["Name"] = "1";
            newrow["Discharge_Time"] = System.DateTime.Now;
            dsMat.Tables[0].Rows.Add(newrow);
        }

        //        确定
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
        }

        //冶炼数据
        private void btnPaocessOK_Click(object sender, EventArgs e)
        {
            dsProcess.Tables[0].Rows[0]["MaterialID"] = tbxTreatNo.Text;
            dsProcess.Tables[0].Rows[0]["TreatNO"] = tbxTreatNo.Text;
            dsProcess.Tables[0].Rows[0]["HeatID"] = tbxHeatID.Text;
            bsProcess.EndEdit();
            bOperation = dsProcess.UpdateData();
            MessageShowOperation();
            dsProcess.LoadData();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
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

        private void btnNote_Click(object sender, EventArgs e)
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

        //定氧
        private void btnOxygen_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsOxygen.Tables[0].NewRow();
            newrow["TreatNo"] = tbxTreatNo.Text;
            newrow["HeatID"] = tbxHeatID.Text;
            newrow["Measure_Time"] = System.DateTime.Now;
            dsOxygen.Tables[0].Rows.Add(newrow);
        }

        private void btnNoteAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsRemark.Tables[0].NewRow();
            newrow["TreatNo"] = tbxTreatNo.Text;
            newrow["HeatID"] = tbxHeatID.Text;
            newrow["LogTime"] = System.DateTime.Now;
            dsRemark.Tables[0].Rows.Add(newrow);
        }

        //成份数据
        private void btnAddChemical_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsChemical.Tables[0].NewRow();//
            newrow["HeatID"] = tbxHeatID.Text;
            newrow["Arrive_Date"] = System.DateTime.Now;
            newrow["Report_Date"] = System.DateTime.Now;
            newrow["LogTime"] = System.DateTime.Now;
            dsChemical.Tables[0].Rows.Add(newrow);
        }

        private void btnChemicalOK_Click(object sender, EventArgs e)
        {
            dvChemical.EndEdit();
            bsBase.EndEdit();
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
            newrow["TreatNo"] = tbxTreatNo.Text;
            newrow["HeatID"] = tbxHeatID.Text;
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

        private void btnAddTemp_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTemp.Tables[0].NewRow();
            newrow["TreatNo"] = tbxTreatNo.Text;
            newrow["HeatID"] = tbxHeatID.Text;
            newrow["MeasureTime"] = System.DateTime.Now;
            dsTemp.Tables[0].Rows.Add(newrow);
        }

        //是否保存成功提示
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

        //
        private void dvMat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //
        private void dvStatus_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

      

        //喂线数据
        private void btnWireAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsWire.Tables[0].NewRow();
            newrow["TreatNo"] = strCurTreatNO;
            newrow["HeatID"] = strCurHeatID;
            newrow["Name"] = "1";
            newrow["WireTime"] = System.DateTime.Now;
            dsWire.Tables[0].Rows.Add(newrow);
        }

        //确定
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
                        case "tabExcept":
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
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
                            /*****Modify by huyunhai*****/
                        case "tabMidLandleTemp":
                            if (dsTundishTemp.L3DataAdapter == null)
                                dsTundishTemp.L3DataAdapter = Adapter;
                            break;
                        case "tabPage1":
                            if (dsTempControl.L3DataAdapter == null)
                                dsTempControl.L3DataAdapter = Adapter;
                            break;
                            /******Modify end********/
                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        //炉次异常
        private void btnAddExcept_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsExcept.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["UnitTypeID"] = "4";
            newrow["UnitID"] = strCurTreatNO.Substring(0, 1);
            newrow["Exceptional_Time"] = DateTime.Now;
            dsExcept.Tables[0].Rows.Add(newrow);
        }

        private void btnConfirmExcept_Click(object sender, EventArgs e)
        {
            dvExcept.EndEdit();
            bsExcept.EndEdit();

            if (dsExcept.GetChanges(DataRowState.Added) != null && dsExcept.GetChanges(DataRowState.Added).Tables[0].Rows.Count > 0)
            {
                cmdHeatExcept.Parameters[0].ConstantValue = strCurHeatID;
                cmdHeatExcept.Parameters[1].ConstantValue = "4";
                cmdHeatExcept.Parameters[2].ConstantValue = strCurTreatNO.Substring(0, 1);
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

        private void txtHeatTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtHeatTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtHeatTimeDis.Text = vsTime;
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

        private void txtHoldBackTime_TextChanged(object sender, EventArgs e)
        {
            string str = txtHoldBackTime.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtHoldBackTimeDis.Text = vsTime;
            }
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
                        cmbBatch_Mat.Visible = false;
                        return;
                    }
                    if (((System.Data.DataRowView)(bsMat.Current)).Row["Name"].ToString() != "1")
                    {
                        cmbBatch_Mat.Visible = false;
                        return;
                    }
                    string strOldValue = ((System.Data.DataRowView)(bsMat.Current)).Row["Batch_ID"].ToString();
                    string strAlloyCode = ((System.Data.DataRowView)(bsMat.Current)).Row["Element"].ToString();

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
                        cmbBatch_Mat.Size = dvWire.Rows[bsWire.Position].Cells["Element"].Size;
                    }
                    catch { }

                    Point pp = new Point(iX, iY);
                    cmbBatch_Mat.Location = pp;
                    try
                    {
                        cmbBatch_Mat.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsBatchID_Mat, strCode);
                    }
                    catch { cmbBatch_Mat.Text = ""; }
                    cmbBatch_Mat.Visible = true;
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

                    string strOldValue = ((System.Data.DataRowView)(bsWire.Current)).Row["Batch_ID"].ToString();
                    string strAlloyCode = ((System.Data.DataRowView)(bsWire.Current)).Row["WireCode"].ToString();
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
                        cmb_Wire.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsBatchID_Wire, strCode);
                    }
                    catch { cmb_Wire.Text = ""; }
                    cmb_Wire.Visible = true;
                }
            }
            catch
            {
                cmbBatch_Mat.Visible = false;
                cmb_Wire.Visible = false;
            }
        }

        private void cmbBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //    CommDataMag.CommonMethed.dv_Info_Element_Cell_BaceColor(Adapter, dvChemical, strSteelGradeIndex, 4);
        }

        //通过comboBox设置是否修改信息行 
        private void cmbBatch_Mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmbBatch_Mat))
                {
                    if (dvMat.Rows[bsMat.Position].Cells["Name_Mat"].Value.ToString() != "1") //如果标志为 ‘1’，才能修改
                        cmbBatch_Mat.Visible = false;
                    else
                    {
                        cmbBatch_Mat.Visible = true;

                        dvMat.Rows[bsMat.Position].Cells["Element"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsBatchID_Mat, "Alloy_Code", "Code", cmbBatch_Mat.SelectedValue.ToString());

                        dvMat.Rows[bsMat.Position].Cells["Batch_ID_Mat"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsBatchID_Mat, "Batch_ID", "Code", cmbBatch_Mat.SelectedValue.ToString());
                    }
                }
            }
            catch { cmbBatch_Mat.Visible = false; }
        }

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
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsBatchID_Wire, "Alloy_Code", "Code", cmb_Wire.SelectedValue.ToString());

                        dvWire.Rows[bsWire.Position].Cells["Batch_ID_Wire"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsBatchID_Wire, "Batch_ID", "Code", cmb_Wire.SelectedValue.ToString());
                    }
                }
            }
            catch { cmb_Wire.Visible = false; }
        }

        private void dvBatchID_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvWire.CurrentCell.ColumnIndex == 3)
                {
                    dvWire.Rows[bsWire.Position].Cells["Amount"].Value = 0;
                    //合金代码
                    string strWireCode = dvWire.Rows[bsWire.Position].Cells["WireCode"].Value.ToString();

                    //根据合金代码查看功能组
                    if (CommDataMag.CommonMethed.GetStrCodeByDesc(dsBatchID_Wire, "code_function_group", "Alloy_Code", strWireCode) != "FeedWire")
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //数据加载后20090904liao
        private void dsStatus_OnDataLoaded(object sender)
        {
            try
            {
                double dHotLengthCur = 0;//分段加热时长
                double dHotLengthTotal = 0;//累计加热时长
                string strHotStart = "";
                string strHotEnd = "";
                string strsql = "";
                int irow = dsStatus.Tables[0].Rows.Count;
                for (int i = 0; i < irow; i++)
                {
                    dHotLengthCur = 0;
                    if (Convert.ToInt32(dsStatus.Tables[0].Rows[i]["Status"].ToString()) == CommDataMag.CommonData.LFHeatBegin)
                    {
                        strHotStart =Convert.ToDateTime( dsStatus.Tables[0].Rows[i]["Change_Time"]).ToString("yyyy-MM-dd HH:mm:ss");
                        strsql = "SELECT gears                                                                                ";
                        strsql += "  FROM (SELECT   gears                                                                ";
                        strsql += "            FROM clf_heat_gears                                                       ";
                        strsql += "           WHERE treatno =  '" + strCurTreatNO + "'                                      ";
                        strsql += "             AND TO_CHAR (logtime, 'yyyy-mm-dd hh24:mi:ss') >=                          ";
                        strsql += "                                                         '" + strHotStart + "'      ";
                        strsql += "        ORDER BY logtime ASC)                                                          ";
                        strsql += " WHERE ROWNUM < 2                                                                      ";

                        dsHeatGears.SourceMethod = strsql;
                        dsHeatGears.LoadData();
                        if (dsHeatGears.Tables[0].Rows.Count > 0)
                        {
                            dsStatus.Tables[0].Rows[i]["Gears"] = dsHeatGears.Tables[0].Rows[0]["Gears"];
                        }
                    }
                    else if (Convert.ToInt32(dsStatus.Tables[0].Rows[i]["Status"].ToString()) == CommDataMag.CommonData.LFHeatEnd)
                    {
                        strHotEnd = Convert.ToDateTime(dsStatus.Tables[0].Rows[i]["Change_Time"]).ToString("yyyy-MM-dd HH:mm:ss");
                        strsql = "SELECT gears                                                                                ";
                        strsql += "  FROM (SELECT   gears                                                                ";
                        strsql += "            FROM clf_heat_gears                                                       ";
                        strsql += "           WHERE treatno =  '" + strCurTreatNO + "'                                      ";
                        strsql += "             AND TO_CHAR (logtime, 'yyyy-mm-dd hh24:mi:ss') <=                        ";
                        strsql += "                                                         '" + strHotEnd + "'      ";
                        strsql += "        ORDER BY logtime desc)                                                          ";
                        strsql += " WHERE ROWNUM < 2                                                                      ";

                        dsHeatGears.SourceMethod = strsql;
                        dsHeatGears.LoadData();
                        if (dsHeatGears.Tables[0].Rows.Count > 0)
                        {
                            dsStatus.Tables[0].Rows[i]["Gears"] = dsHeatGears.Tables[0].Rows[0]["Gears"];
                        }
                        if (strHotEnd != "" && strHotStart != "")
                            dHotLengthCur = Math.Round((Convert.ToDateTime(strHotEnd).ToOADate() - Convert.ToDateTime(strHotStart).ToOADate()) * 24 * 60, 1);
                    }
                    dHotLengthTotal += dHotLengthCur;
                    dsStatus.Tables[0].Rows[i]["Hot_Length_Cur"] = dHotLengthCur;
                    dsStatus.Tables[0].Rows[i]["Hot_Length_Total"] = dHotLengthTotal;
                }
            }
            catch { }
        }

        /********Mofify Begin At 2011-3-7 By Huyunhai************/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsMat == null || bsMat.Count < 1 || bsMat.Current == null)
                return;
            DataGridViewSelectedRowCollection dsrc = dvMat.SelectedRows;
            if (dsrc.Count>0&&dsrc!=null)
            {
                foreach (DataGridViewRow dgvr in dsrc)
                {
                    dvMat.Rows.Remove(dgvr);            
                }
            }

            if (DialogResult.OK.ToString()== (MessageBox.Show("确定删除指定数据行吗？", " 删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)).ToString())
            {
                btnMatOK_Click(sender, e);//  保存
            }
            else
                dsMat.LoadData();
            
        }

        private void txtExcept_Leave(object sender, EventArgs e)
        {
            if (txtExcept.Text.Trim() == "")
                return;
            int tempt = -1;
            foreach (DataRow dr in dsExceptCode.Tables[0].Rows)
            {
                string dd = dr["Exceptional_Code"].ToString();
                if (dd.Equals(""))
                    continue;
                if (Convert.ToInt32(dd) > tempt)
                {
                    tempt = Convert.ToInt32(dr["EXCEPTIONAL_CODE"]);
                }

            }
         
            AppSvrHMI.L3DataSet ds = new AppSvrHMI.L3DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].Columns.Add("EXCEPTIONAL_CODE");
            ds.Tables[0].Columns.Add("EXCEPTIONAL_DES");
            ds.Tables[0].Columns.Add("UNIT");
            ds.Tables[0].Columns.Add("AUTO_JUDGE_FLAG");

            string tt = Convert.ToString(tempt + 1);
            string cc = txtExcept.Text.Trim();

            ds.Tables[0].Rows.Add(new string[] { tt, cc, "4", "0" });

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmdExcept.Parameters[0].ConstantValue = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
                cmdExcept.Parameters[1].SourceObject = ds;
                //cmdExcept.Parameters[1].SourceProperty = "L3DataTable";
                int iRot = cmdExcept.Execute();
                if (iRot == 0)
                {
                    if (Convert.ToInt32(cmdExcept.Command.Return) == 0)
                    {
                        dsExceptCode.LoadData();
                        MessageBox.Show("异常代码保存成功!");

                        // ds.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("异常代码保存失败!", "提示");
                        txtExcept.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("异常代码保存失败!", "提示");
                    txtExcept.Text = "";
                    return;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            bsTempControl.EndEdit();
            bOperation = dsTempControl.UpdateData();
            MessageShowOperation();
            dsTempControl.LoadData();
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTempControl.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["CreateTime"] = DateTime.Now;
            dsTempControl.Tables[0].Rows.Add(newrow);
        }

      

     
        /**********Modify END**********/
    }
}