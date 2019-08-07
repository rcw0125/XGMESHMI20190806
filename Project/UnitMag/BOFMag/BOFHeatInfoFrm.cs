using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFHeatInfoFrm : Form
    {
        public BOFHeatInfoFrm()
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
        private string strSteelGradeIndex = "";//��ǰ¯�Ŷ�Ӧ��ǰ���ּǺ�

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="bLocked">ʵ��������־:True ʵ��������,�����޸��κ�ʵ��;False ʵ����δ����,���޸Ĳ���ʵ��</param>
        /// <param name="CheckFlag">����ά����־:True ��ά����������,False ����������־</param>
        /// <param name="strHeatID">¯��</param>
        public void ShowDialogEx(AppSvrIF.Session session, bool bLocked, bool CheckFlag, string strHeatID, bool isOpenTxtTappingWeight)
        {
            try
            {
                UnLock = !bLocked;
                check = CheckFlag;
                strCurHeatID = strHeatID;
                txtHeatID.Text = strHeatID;
                isLockTxtTW = isOpenTxtTappingWeight;

                //���ø�DataSet��SourceCondition
                //dsBase
                dsBase.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsBottomBlow
                dsBottomBlow.SourceCondition = "HeatID = '" + strHeatID + "' order by Catch_Time desc";

                //dsChemical
                dsChemical.SourceCondition = "HeatID = '" + strHeatID + "' order by Report_Date desc";//and UNITTYPEID = '2' 

                //dsMainMat
                dsMainMat.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsMat
                dsMat.SourceCondition = "HeatID = '" + strHeatID + "' order by Type, Discharge_Time asc ";

                //dsTapAlloy
                dsTapAlloy.SourceCondition = " HeatID = '" + strHeatID + "' order by Discharge_Time desc";

                //dsSumAddition
                dsSumAddition.SourceMethod = "select * from VIEW_BOF_ADDITION where HeatID = '" + strHeatID + "'";

                //dsOxygen
                dsOxygen.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsOxygenTap
                dsOxygenTap.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsProcess
                dsProcess.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsTapProcess
                dsTapProcess.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsStatus
                dsStatus.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsTemp
                dsTemp.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsTempTap
                dsTempTap.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsTopBlow
                dsTopBlow.SourceCondition = "HeatID = '" + strHeatID + "' order by Catch_Time desc";

                //dsStatus
                dsStatus.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsRemark
                dsRemark.SourceCondition = "HeatID = '" + strHeatID + "'";



                //¯���쳣
                dsExcept.SourceCondition = "HeatID = '" + strHeatID + "' and UnitTypeID = '"
                   + strHeatID.Substring(0, 1) + "' and UnitID = '" + strHeatID.Substring(1, 1) + "'";

                //������
               // dsIronLadleID.SourceMethod = "select IRONLADLENO from CIRON_DATA where 1=2";
                dsIronLadleID.SourceMethod = "select IRONLADLENO,SOURCE from CIRON_DATA where HeatID = '" + strHeatID + "'";

                //�ϸֶ���
                string strSQLScrapid = "";
                dsScrapID.SourceMethod = "select scrap_slot_id from cscrap_output_log where 1=2";
                strSQLScrapid += "SELECT   SUBSTR (scrap_slot_id,                ";
                strSQLScrapid += "                 1,                            ";
                strSQLScrapid += "                 (LENGTH (scrap_slot_id) - 15) ";
                strSQLScrapid += "                ) AS scrap_slot_id             ";
                strSQLScrapid += "    FROM cscrap_output_log                     ";
                strSQLScrapid += "   WHERE heatid =  '" + strHeatID + "'";
                strSQLScrapid += "GROUP BY scrap_slot_id                         ";
                dsScrapID.SourceMethod = strSQLScrapid;

                /* ת¯�Ͻ���� */
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
                strBatch_mat_Man += "     AND (d.containerid = '1' OR d.containerid = '4' OR d.containerid = '5')";
                strBatch_mat_Man += "     AND c.alloy_code = e.code";
                strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'";
                strBatch_mat_Man += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire'";
                strBatch_mat_Man += "         )";
                strBatch_mat_Man += "ORDER BY alloy_code";
                dsMat_Alloy_Add_Man.SourceMethod = strBatch_mat_Man;

                /* ת¯¯��Ͻ���� */
                strBatch_mat_Man = "";
                dsWire_Add_man.SourceMethod = strBatch_mat_Man;
                strBatch_mat_Man += "SELECT  distinct c.alloy_code, c.batch_id, c.materialid AS code,";
                strBatch_mat_Man += "         e.code_des || '(' || c.batch_id || ')' AS code_des ,e.code_function_group";
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
                strBatch_mat_Man += "     AND (d.containerid = '1' OR d.containerid = '4' OR d.containerid = '5')";
                strBatch_mat_Man += "     AND c.alloy_code = e.code";
                strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'";
                strBatch_mat_Man += "ORDER BY alloy_code";
                dsWire_Add_man.SourceMethod = strBatch_mat_Man;

                /* ת¯ɢ״�ϼ��� */
                strBatch_mat_Man = "";
                dsBulk_Add_Man.SourceMethod = strBatch_mat_Man;
                strBatch_mat_Man += "SELECT   distinct c.bulk_code, c.batch_id, c.materialid AS code,";
                strBatch_mat_Man += "         e.code_des || '(' || c.batch_id || ')' AS code_des";
                strBatch_mat_Man += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.bulk_code";
                strBatch_mat_Man += "            FROM materialposition a, cbulk_data b";
                strBatch_mat_Man += "           WHERE a.materialid = b.materialid";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 1, 3) = 'S83'";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'";
                strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,";
                strBatch_mat_Man += "         (SELECT *";
                strBatch_mat_Man += "            FROM xgstorearea";
                strBatch_mat_Man += "           WHERE SUBSTR (code, 1, 3) = 'S83') d,";
                strBatch_mat_Man += "         cbase_all_code e";
                strBatch_mat_Man += "   WHERE c.pos = d.code";
                strBatch_mat_Man += "     AND c.bulk_code = e.code";
                strBatch_mat_Man += "     AND e.code_group = 'BULK_CODE'";
                strBatch_mat_Man += "ORDER BY bulk_code";
                dsBulk_Add_Man.SourceMethod = strBatch_mat_Man;
                dsSCRAP_SLOT_ID.SourceMethod = "select SCRAP_SLOT_ID from CSCRAP_OUTPUT_LOG where HEATID='" + strCurHeatID + "'";

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

        //���ݼ���
        private void BOFHeatInfoFrm_Load(object sender, EventArgs e)
        {
            //ȡ��ɾ����ť�ɼ���
            btnDelExcept.Visible = false;
            btnDelAlloy.Visible = false;
            btnDelTapAlloy.Visible = false;
            btnDelMat.Visible = false;
            btnDelChemical.Visible = false;
            btnDelBottomBlow.Visible = false;
            btnDelTopBlow.Visible = false;
            btnDelStatus.Visible = false;
            btnDelTemp.Visible = false;
            btnDelTempTap.Visible = false;
            btnDelOxygen.Visible = false;
            btnDelOxygenTap.Visible = false;
            btnRemarkDel.Visible = false;

            //huyunhai 
            //AppSvrHMI.L3DataSet dsdd = new AppSvrHMI.L3DataSet();
            //dsdd.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            //dsdd.SourceMethod = "select * from CIron_Data where HeatID = '" + strCurHeatID + "'";
            //dsdd.L3DataAdapter = Adapter;
            //dsdd.LoadData();

            /***Modify By Huyunhai 2011-03-26****/
            //if (dsdd.Tables[0].Rows.Count > 0)
            //{
            //    bool isOne = false;
            //    bool isTwo = false;
            //    for (int i = 0; i < dsdd.Tables[0].Rows.Count; i++)
            //    {
            //        if (dsdd.Tables[0].Rows[i]["SOURCE"].ToString() == "1")
            //            isOne = true;
            //        else if (dsdd.Tables[0].Rows[i]["SOURCE"].ToString() == "2")
            //            isTwo = true;
            //    }
            //    if (isOne && isTwo)
            //        pxTextBox6.Text = "1��2 �Ż���¯";
            //    else if (isOne && !isTwo)
            //        pxTextBox6.Text = "1 �Ż���¯";
            //    else if (!isOne && isTwo)
            //        pxTextBox6.Text = "2 �Ż���¯";
            //    else if (!isOne && !isTwo)
            //        pxTextBox6.Text = "����������¯";

            //}

            txtTappingWeight.ReadOnly = true;
            if (dsSCRAP_SLOT_ID.Tables[0].Rows.Count != 0)
            {
                string SCRAP_SLOT_ID = dsSCRAP_SLOT_ID.Tables[0].Rows[0][0].ToString();
                //string strHeatID = dsSCRAP_SLOT_ID.Tables[0].Rows[0][0].ToString()
                //string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
                string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID IN (SELECT SCRAP_SLOT_ID FROM CSCRAP_OUTPUT_LOG WHERE HEATID = '" + strCurHeatID + "') ";
                string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID IN (SELECT SCRAP_SLOT_ID FROM CSCRAP_OUTPUT_LOG WHERE HEATID = '" + strCurHeatID + "') ";
                dsFG.SourceMethod = SQL1;
                dsST.SourceMethod = SQL2;
            }

            /*****Modify End****/

            //���ʵ����δ�������ҿ���ά��ʵ��
            if (UnLock && check)
            {
                //��������
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

                //��ԭ������
                fLPMainMat.Visible = true;
                btnMainMatConfirm.Visible = true;

                //ұ������
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

                //�����쳣
                btnAddExcept.Visible = true;
                fLPExcept.Visible = true;
                btnConfirmExcept.Visible = true;

                //¯ǰ�Ͻ�
                btnAddAlloy.Visible = true;
                fLPAlloy.Visible = true;
                btnAlloyCanfirm.Visible = true;

                //¯��Ͻ�
                btnAddTapAlloy.Visible = true;
                fLPTapAlloy.Visible = true;
                btnTapAlloyConfirm.Visible = true;

                //ɢװ��
                btnAddMat.Visible = true;
                fLPMat.Visible = true;
                btnMatConfirm.Visible = true;

                //�ɷ�
                btnAddChemical.Visible = true;
                fLPChemical.Visible = true;
                btnChemicalConfirm.Visible = true;

                //�״�
                btnAddBottomBlow.Visible = true;
                fLPBottomBlow.Visible = true;
                btnBottomBlowConfirm.Visible = true;

                //����
                btnAddTopBlow.Visible = true;
                fLPTopBlow.Visible = true;
                btnTopBlowConfirm.Visible = true;

                //״̬
                btnAddStatus.Visible = true;
                fLPStatus.Visible = true;
                btnStatusConfirm.Visible = true;

                //���¶���
                btnAddTemp.Visible = true;
                btnAddTempTap.Visible = true;
                btnAddOxygen.Visible = true;
                btnAddOxygenTap.Visible = true;
                fLPTemp.Visible = true;
                btnTempConfirm.Visible = true;

                //¯�μ���
                fLPRemark.Visible = true;
                btnRemarkAdd.Visible = true;
                btnRemarkConfirm.Visible = true;
            }
            else
            {
                fLPMainMat.Visible = false;//UnLock;
                btnMainMatConfirm.Visible = false;//UnLock;

                //fLPMat.Visible = false;//UnLock;
                //btnAddMat.Visible = false;//UnLock;

                fLPChemical.Visible = false;//UnLock;
                btnAddChemical.Visible = false;//UnLock;

                fLPBottomBlow.Visible = false;//UnLock;
                btnAddBottomBlow.Visible = false;//UnLock;

                fLPTopBlow.Visible = false;//UnLock;
                btnAddTopBlow.Visible = false;//UnLock;

                fLPStatus.Visible = false;//UnLock;
                btnAddStatus.Visible = false;//UnLock;

                fLPTemp.Visible = false;//UnLock;
                btnAddTemp.Visible = false;//UnLock;
                btnAddTempTap.Visible = false;//UnLock;
                btnAddOxygen.Visible = false;//UnLock;
                btnAddOxygenTap.Visible = false;//UnLock;

                if (!UnLock)
                {
                    fLPBase.Visible = UnLock;
                    fLPProcess.Visible = UnLock;
                    fLPExcept.Visible = UnLock;
                    fLPRemark.Visible = UnLock;

                    fLPMat.Visible = UnLock;//UnLock;
                    btnAddMat.Visible = UnLock;//UnLock;

                    btnAddAlloy.Visible = UnLock;
                    fLPAlloy.Visible = UnLock;

                    btnAddTapAlloy.Visible = UnLock;
                    fLPTapAlloy.Visible = UnLock;

                    btnAddExcept.Visible = UnLock;

                }
            }
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxIronWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxScrapWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxPigIronWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxReHeatAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxC.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxSi.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxMn.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxP.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxS.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxTi.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxIronTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtBlowO2Time.TextChanged += new EventHandler(pxControls_TextChanged);
            txtReBlowTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSplashingTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingOxygen.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTapholeLife.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSmeltPeriod.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWaitingTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLanceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtFurnaceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLadleNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            txtReBlowCount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLaCTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSingleLaC.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        //��������
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

        //��ԭ������
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

        //ɢװ������
        private void btnAddMat_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Discharge_Time"] = System.DateTime.Now;
            newrow["Type"] = "1";//"9";[2009-04-02]
            newrow["Name"] = "1";
            dsMat.Tables[0].Rows.Add(newrow);
        }
        //private void txtSmeltPeriodis_TextChanged(object sender, EventArgs e)
        //{
        //    string str = txtSmeltPeriodis.Text;
        //    if (str != "")
        //    {
        //        int viTime = Convert.ToInt32(str);
        //        int viMin = Convert.ToInt32(viTime / 60);
        //        int viSec = viTime % 60;
        //        string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
        //        txtSmeltPeriod.Text = vsTime;
        //    }
        //}

        private void txtSmeltPeriodis_TextChanged(object sender, EventArgs e)
        {
            string str = txtSmeltPeriodis.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                double  vfTime = Convert.ToDouble(str);
                //double  viMin = Convert.ToDouble(vfTime / 60);
                double viMin = Math.Round((vfTime / 60 * 1.0), 2);
                //int viSec = viTime % 60;
                //string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                string vsTime = viMin.ToString();
                txtSmeltPeriod.Text = vsTime;
            }
        }
        private void btnDelMat_Click(object sender, EventArgs e)
        {
            if (bsMat.Current != null)
                bsMat.RemoveCurrent();
        }

        private void btnMatConfirm_Click(object sender, EventArgs e)
        {
            dvMat.EndEdit();
            bsMat.EndEdit();

            for (int i = 0; i < dvMat.Rows.Count; i++)
            {
                if (dvMat.Rows[i].Cells["dvcmbTapBulkCode"].EditedFormattedValue.ToString() == "" && dvMat.Rows[i].Cells["Name3"].Value.ToString() == "1")
                {
                    MessageBox.Show("�Ͻ����Ϊ�գ�", "��ʾ", MessageBoxButtons.OK);
                    bsMat.Position = i;
                    return;
                }
                //if ((dvMat.Rows[i].Cells["EnableFlagMat"].Value.ToString() == "1") && (dvMat.Rows[i].Cells["Batch_ID"].Value.ToString() == ""))
                //{
                //    MessageBox.Show("\"" + dvMat.Rows[i].Cells["dvcmbTapBulkCode"].EditedFormattedValue.ToString() + "\"δѡ�����κţ�", "��ʾ", MessageBoxButtons.OK);
                //    bsMat.Position = i;
                //    return;
                //}
            }

            bOperation = dsMat.UpdateData();
            MessageShowOperation();
            dsMat.LoadData();
            dsSumAddition.LoadData();
        }

        private void btnMatCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
            dsSumAddition.LoadData();
        }

        //¯ǰ�Ͻ�����
        private void btnAdAlloy_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Discharge_Time"] = System.DateTime.Now;
            newrow["Type"] = "5";
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
                    MessageBox.Show("�Ͻ����Ϊ�գ�", "��ʾ", MessageBoxButtons.OK);
                    bsAlloy.Position = i;
                    return;
                }
                //if ((dvAlloy.Rows[i].Cells["EnableFlag"].Value.ToString() == "1") && (dvAlloy.Rows[i].Cells["Batch_ID_Pre"].Value.ToString() == ""))
                //{
                //    MessageBox.Show("\"" + dvAlloy.Rows[i].Cells["dvcmbAlloyCode"].EditedFormattedValue.ToString() + "\"δѡ�����κţ�", "��ʾ", MessageBoxButtons.OK);
                //    bsAlloy.Position = i;
                //    return;
                //}
            }

            bOperation = dsMat.UpdateData();
            MessageShowOperation();
            dsMat.LoadData();
            dsSumAddition.LoadData();
        }

        private void btnAlloyCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
            dsSumAddition.LoadData();
        }

        //¯��Ͻ�����
        private void btnAddTapAlloy_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTapAlloy.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Discharge_Time"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsTapAlloy.Tables[0].Rows.Add(newrow);
        }

        private void btnDelTapAlloy_Click(object sender, EventArgs e)
        {
            if (bsTapAlloy.Current != null)
                bsTapAlloy.RemoveCurrent();
        }

        private void btnTapAlloyConfirm_Click(object sender, EventArgs e)
        {
            dvTapAlloy.EndEdit();
            bsTapAlloy.EndEdit();

            for (int i = 0; i < dvTapAlloy.Rows.Count; i++)
            {
                if (dvTapAlloy.Rows[i].Cells["dvcmbTapAlloyCode"].EditedFormattedValue.ToString() == "" && dvTapAlloy.Rows[i].Cells["Name2"].Value.ToString() == "1")
                {
                    MessageBox.Show("�Ͻ����Ϊ�գ�", "��ʾ", MessageBoxButtons.OK);
                    bsTapAlloy.Position = i;
                    return;
                }
                //if ((dvTapAlloy.Rows[i].Cells["EnableFlagTapAlloy"].Value.ToString() == "1") && (dvTapAlloy.Rows[i].Cells["Batch_IDTap"].Value.ToString() == ""))
                //{
                //    MessageBox.Show("\"" + dvTapAlloy.Rows[i].Cells["dvcmbTapAlloyCode"].EditedFormattedValue.ToString() + "\"δѡ�����κţ�", "��ʾ", MessageBoxButtons.OK);
                //    bsTapAlloy.Position = i;
                //    return;
                //}
            }

            bOperation = dsTapAlloy.UpdateData();
            MessageShowOperation();
            dsTapAlloy.LoadData();
            dsSumAddition.LoadData();
        }

        private void btnTapAlloyCancel_Click(object sender, EventArgs e)
        {
            dsTapAlloy.LoadData();
            dsSumAddition.LoadData();
        }
        //ұ������
        private void btnProcessConfirm_Click(object sender, EventArgs e)
        {
            bsProcess.EndEdit();
            bsTapProcess.EndEdit();
            bOperation = (dsProcess.UpdateData() && dsTapProcess.UpdateData());
            MessageShowOperation();
            dsProcess.LoadData();
            dsTapProcess.LoadData();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
            dsTapProcess.LoadData();
           
        }

        //�ɷ�����
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

        //�״�����
        private void btnAddBottomBlow_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBottomBlow.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Catch_Time"] = System.DateTime.Now;
            dsBottomBlow.Tables[0].Rows.Add(newrow);
        }

        private void btnDelBottomBlow_Click(object sender, EventArgs e)
        {
            if (bsBottomBlow.Current != null)
                bsBottomBlow.RemoveCurrent();
        }

        private void btnBottomBlowConfirm_Click(object sender, EventArgs e)
        {
            dvBottomBlow.EndEdit();
            bsBottomBlow.EndEdit();

            bOperation = dsBottomBlow.UpdateData();
            MessageShowOperation();
            dsBottomBlow.LoadData();
        }

        private void btnBottomBlowCancel_Click(object sender, EventArgs e)
        {
            dsBottomBlow.LoadData();
        }

        //��������
        private void btnAddTopBlow_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTopBlow.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Catch_Time"] = System.DateTime.Now;
            dsTopBlow.Tables[0].Rows.Add(newrow);
        }

        private void btnDelTopBlow_Click(object sender, EventArgs e)
        {
            if (bsTopBlow.Current != null)
                bsTopBlow.RemoveCurrent();
        }

        private void btnTopBlowConfirm_Click(object sender, EventArgs e)
        {
            dvTopBlow.EndEdit();
            bsTopBlow.EndEdit();
            bOperation = dsTopBlow.UpdateData();
            MessageShowOperation();
            dsTopBlow.LoadData();
        }

        private void btnTopBlowCancel_Click(object sender, EventArgs e)
        {
            dsTopBlow.LoadData();
        }

        //״̬����
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

        //��������
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

        private void btnAddTempTap_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTempTap.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["MeasureTime"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsTempTap.Tables[0].Rows.Add(newrow);
        }

        private void btnDelTempTap_Click(object sender, EventArgs e)
        {
            if (bsTempTap.Current != null)
                bsTempTap.RemoveCurrent();
        }

        private void btnTempConfirm_Click(object sender, EventArgs e)
        {
            dvTemp.EndEdit();
            bsTemp.EndEdit();
            dvTempTap.EndEdit();
            bsTempTap.EndEdit();

            dvOxygen.EndEdit();
            bsOxygen.EndEdit();

            dvOxygenTap.EndEdit();
            bsOxygenTap.EndEdit();

            bOperation = (dsTemp.UpdateData() && dsTempTap.UpdateData() && dsOxygen.UpdateData() && dsOxygenTap.UpdateData());
            MessageShowOperation();
            dsTemp.LoadData();
            dsTempTap.LoadData();
            dsOxygen.LoadData();
            dsOxygenTap.LoadData();
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsTemp.LoadData();
            dsTempTap.LoadData();
            dsOxygen.LoadData();
            dsOxygenTap.LoadData();
        }

        //��������
        private void btnAddOxygen_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsOxygen.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Measure_Time"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsOxygen.Tables[0].Rows.Add(newrow);
        }

        private void btnDelOxygen_Click(object sender, EventArgs e)
        {
            if (bsOxygen.Current != null)
                bsOxygen.RemoveCurrent();
        }

        private void btnAddOxygenTap_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsOxygenTap.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["MeasureTime"] = System.DateTime.Now;
            newrow["Name"] = "1";
            dsOxygenTap.Tables[0].Rows.Add(newrow);
        }

        private void btnDelOxygenTap_Click(object sender, EventArgs e)
        {
            if (bsOxygenTap.Current != null)
                bsOxygenTap.RemoveCurrent();
        }

        private void MessageShowOperation()
        {
            if (bOperation)
            {
                MessageBox.Show("����ɹ���", "��ʾ");
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "����");
            }
        }

        private void dv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //¯�μ���
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
                            if (dsScrapID.L3DataAdapter == null)
                                dsScrapID.L3DataAdapter = Adapter;

                            if (dsIronLadleID.L3DataAdapter == null)
                                dsIronLadleID.L3DataAdapter = Adapter;

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

                            if (dsTapProcess.L3DataAdapter == null)
                                dsTapProcess.L3DataAdapter = Adapter;
                            break;

                        case "tabExcept":
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
                            break;

                        case "tabTapAlloy":
                            if (dsTapAlloy.L3DataAdapter == null)
                                dsTapAlloy.L3DataAdapter = Adapter;
                            break;

                        case "tabSumAddition":
                            if (dsSumAddition.L3DataAdapter == null)
                                dsSumAddition.L3DataAdapter = Adapter;
                            break;

                        case "tabChemical":
                            if (dsChemical.L3DataAdapter == null)
                                dsChemical.L3DataAdapter = Adapter;
                            break;

                        case "tabBottomBlow":
                            if (dsBottomBlow.L3DataAdapter == null)
                                dsBottomBlow.L3DataAdapter = Adapter;
                            break;

                        case "tabTopBlow":
                            if (dsTopBlow.L3DataAdapter == null)
                                dsTopBlow.L3DataAdapter = Adapter;
                            break;

                        case "tabStatus":
                            if (dsStatus.L3DataAdapter == null)
                                dsStatus.L3DataAdapter = Adapter;
                            break;

                        case "tabTemp":
                            if (dsTemp.L3DataAdapter == null)
                                dsTemp.L3DataAdapter = Adapter;
                            if (dsTempTap.L3DataAdapter == null)
                                dsTempTap.L3DataAdapter = Adapter;
                            if (dsOxygen.L3DataAdapter == null)
                                dsOxygen.L3DataAdapter = Adapter;
                            if (dsOxygenTap.L3DataAdapter == null)
                                dsOxygenTap.L3DataAdapter = Adapter;
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

        //¯���쳣[2009-03-11 Liao]
        private void btnAddExcept_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsExcept.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["UnitTypeID"] = strCurHeatID.Substring(0, 1).ToString();
            newrow["UnitID"] = strCurHeatID.Substring(1, 1).ToString();
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
                cmdHeatExcept.Parameters[1].ConstantValue = strCurHeatID.Substring(0, 1).ToString();
                cmdHeatExcept.Parameters[2].ConstantValue = strCurHeatID.Substring(1, 1).ToString();
                cmdHeatExcept.Parameters[3].SourceObject = dsExcept.GetChanges(DataRowState.Added);

                int iRet = cmdHeatExcept.Execute();
                if (iRet != 0 || (Convert.ToInt16(cmdHeatExcept.Command.Return)) != 0)
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdHeatExcept.Command.ErrorCode));
                    MessageBox.Show("ʧ�ܣ�" + strReasultShow);
                }
                else
                {
                    MessageBox.Show("��¼�����쳣�ɹ���");
                }
            }
            if (dsExcept.GetChanges(DataRowState.Modified) != null && dsExcept.GetChanges(DataRowState.Modified).Tables[0].Rows.Count > 0)
            {
                object objMod = null;
                if (dsExcept.CommitModified(ref objMod))
                {
                    if (Convert.ToBoolean(objMod))
                    {
                        MessageBox.Show("�޸ĳɹ���", "��ʾ");
                    }
                }
            }
            dsExcept.LoadData();
        }

        private void btnCancelExcept_Click(object sender, EventArgs e)
        {
            dsExcept.LoadData();
        }

        //���ݰ�
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

        private void dvTapAlloy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvTapAlloy.Rows.Count; i++)
                {
                    if (dvTapAlloy.Rows[i].Cells["Name2"].Value.ToString() != "1")
                        dvTapAlloy.Rows[i].ReadOnly = true;
                    else
                        dvTapAlloy.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }

        private void dvMat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvMat.Rows.Count; i++)
                {
                    if (dvMat.Rows[i].Cells["Name3"].Value.ToString() != "1")
                        dvMat.Rows[i].ReadOnly = true;
                    else
                        dvMat.Rows[i].ReadOnly = false;
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

        private void dvOxygen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvOxygen.Rows.Count; i++)
                {
                    if (dvOxygen.Rows[i].Cells["Name5"].Value.ToString() != "1")
                        dvOxygen.Rows[i].ReadOnly = true;
                    else
                        dvOxygen.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }

        private void dvTempTap_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvTempTap.Rows.Count; i++)
                {
                    if (dvTempTap.Rows[i].Cells["Name6"].Value.ToString() != "1")
                        dvTempTap.Rows[i].ReadOnly = true;
                    else
                        dvTempTap.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }

        private void dvOxygenTap_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                for (int i = 0; i < dvOxygenTap.Rows.Count; i++)
                {
                    if (dvOxygenTap.Rows[i].Cells["Name7"].Value.ToString() != "1")
                        dvOxygenTap.Rows[i].ReadOnly = true;
                    else
                        dvOxygenTap.Rows[i].ReadOnly = false;
                }
            }
            catch { }
        }


        private void dsMainMat_OnDataLoaded(object sender)
        {
            try
            {
                dsIronLadleID.LoadData();
                dsScrapID.LoadData();
            }
            catch { }
        }


        //¯ǰ�Ͻ�
        private void dvAlloy_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        //¯ǰ�Ͻ�
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

        //¯ǰ�Ͻ�����
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


        //¯��Ͻ�
        private void dvTapAlloy_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvTapAlloy.CurrentCell.ColumnIndex == 2)
                {
                    dvTapAlloy.Rows[bsTapAlloy.Position].Cells["Weight"].Value = 0;
                    //�Ͻ����
                    string strTapAlloyCode = dvTapAlloy.Rows[bsTapAlloy.Position].Cells["dvcmbTapAlloyCode"].Value.ToString();

                    //���ݺϽ����鿴������
                    if (CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "code_function_group", "Alloy_Code", strTapAlloyCode) != "FeedWire")
                        return;
                    object objCoefficient = null;
                    Adapter.Session.Get("XGMESLogic\\BaseDataMag\\CBase_Wire_Coefficient\\" + strTapAlloyCode, "Coefficient", ref objCoefficient);
                    if (objCoefficient == null)
                        objCoefficient = 0;
                    dvTapAlloy.Rows[bsTapAlloy.Position].Cells["Weight"].Value =
                       Math.Round(Convert.ToDouble(dvTapAlloy.Rows[bsTapAlloy.Position].Cells["Length"].Value.ToString()) * Convert.ToDouble(objCoefficient), 3);
                }
            }
            catch { }
        }

        //¯��Ͻ�
        private void bsTapAlloy_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if ((!btnTapAlloyConfirm.Visible) || (bsTapAlloy.Position < 0))
                {
                    cmbTapBatchID.Visible = false;
                    return;
                }
                if (((System.Data.DataRowView)(bsTapAlloy.Current)).Row["Name"].ToString() != "1")
                {
                    cmbTapBatchID.Visible = false;
                    return;
                }

                string strOldValue = ((System.Data.DataRowView)(bsTapAlloy.Current)).Row["Batch_ID"].ToString();
                string strAlloyCode = ((System.Data.DataRowView)(bsTapAlloy.Current)).Row["Element"].ToString();

                string strCode = strAlloyCode + strOldValue;

                int iX = 0;
                int iY = 0;

                iX += dvTapAlloy.RowHeadersWidth;
                for (int i = 0; i < dvTapAlloy.Columns["dvcmbTapAlloyCode"].Index; i++)
                    iX += dvTapAlloy.Columns[i].Width;

                iY += dvTapAlloy.ColumnHeadersHeight;
                try
                {
                    for (int j = 0; j < bsTapAlloy.Position + 1; j++)
                        iY += dvTapAlloy.Rows[j].Cells[0].Size.Height;
                }
                catch { iY += 23; }

                try
                {
                    cmbTapBatchID.Size = dvTapAlloy.Rows[bsTapAlloy.Position].Cells["dvcmbTapAlloyCode"].Size;
                }
                catch { }
                Point pp = new Point(iX, iY);
                cmbTapBatchID.Location = pp;
                try
                {
                    cmbTapBatchID.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsWire_Add_man, strCode);
                }
                catch { cmbTapBatchID.Text = ""; }
                cmbTapBatchID.Visible = true;
            }
            catch { cmbTapBatchID.Visible = false; }
        }

        //¯��Ͻ�����
        private void cmbTapBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmbTapBatchID))
                {
                    if (dvTapAlloy.Rows[bsTapAlloy.Position].Cells["Name2"].Value.ToString() != "1")
                        cmbTapBatchID.Visible = false;
                    else
                    {
                        cmbTapBatchID.Visible = true;

                        dvTapAlloy.Rows[bsTapAlloy.Position].Cells["dvcmbTapAlloyCode"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "Alloy_Code", "Code", cmbTapBatchID.SelectedValue.ToString());

                        dvTapAlloy.Rows[bsTapAlloy.Position].Cells["Batch_IDTap"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsWire_Add_man, "Batch_ID", "Code", cmbTapBatchID.SelectedValue.ToString());
                    }
                }
                dvTapAlloy.EndEdit();
            }
            catch
            {
                cmbTapBatchID.Visible = false;
                dvTapAlloy.EndEdit();
            }
        }



        //ɢ״��
        private void dvMat_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        //ɢװ��
        private void bsMat_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if ((!btnMatConfirm.Visible) || (bsMat.Position < 0))
                {
                    cmbMatBatchID.Visible = false;
                    return;
                }
                if (((System.Data.DataRowView)(bsMat.Current)).Row["Name"].ToString() != "1")
                {
                    cmbMatBatchID.Visible = false;
                    return;
                }

                string strOldValue = ((System.Data.DataRowView)(bsMat.Current)).Row["Batch_ID"].ToString();
                string strAlloyCode = ((System.Data.DataRowView)(bsMat.Current)).Row["Element"].ToString();

                string strCode = strAlloyCode + strOldValue;

                int iX = 0;
                int iY = 0;

                iX += dvMat.RowHeadersWidth;
                for (int i = 0; i < dvMat.Columns["dvcmbTapBulkCode"].Index; i++)
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
                    cmbMatBatchID.Size = dvMat.Rows[bsMat.Position].Cells["dvcmbTapBulkCode"].Size;
                }
                catch { }
                Point pp = new Point(iX, iY);
                cmbMatBatchID.Location = pp;
                try
                {
                    cmbMatBatchID.Text = CommDataMag.CommonMethed.GetStrDescByCode(dsBulk_Add_Man, strCode);
                }
                catch { cmbMatBatchID.Text = ""; }
                cmbMatBatchID.Visible = true;
            }
            catch { cmbMatBatchID.Visible = false; }

        }

        //ɢװ������
        private void cmbMatBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;
                if (sender.Equals(cmbMatBatchID))
                {
                    if (dvMat.Rows[bsMat.Position].Cells["Name3"].Value.ToString() != "1")
                        cmbMatBatchID.Visible = false;
                    else
                    {
                        cmbMatBatchID.Visible = true;

                        dvMat.Rows[bsMat.Position].Cells["dvcmbTapBulkCode"].Value
                            =
                        CommDataMag.CommonMethed.GetStrCodeByDesc(dsBulk_Add_Man, "Bulk_Code", "Code", cmbMatBatchID.SelectedValue.ToString());

                        dvMat.Rows[bsMat.Position].Cells["Batch_ID"].Value
                            =
                            CommDataMag.CommonMethed.GetStrCodeByDesc(dsBulk_Add_Man, "Batch_ID", "Code", cmbMatBatchID.SelectedValue.ToString());
                    }
                }
            }
            catch { cmbMatBatchID.Visible = false; }
        }

        //�ɷֱ���
        private void dvChemical_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (strSteelGradeIndex != "")
            //    CommDataMag.CommonMethed.dv_Info_Element_Cell_BaceColor(Adapter, dvChemical, strSteelGradeIndex, 2);
        }

        //��ȡ���ּǺ�
        private void dsBase_OnDataLoaded(object sender)
        {
            try
            {
                strSteelGradeIndex = dsBase.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            }
            catch { strSteelGradeIndex = ""; }
        }

        //�����м� gridView
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

        //����¯�Ų���ϸֶ���
        private void txtHeatID_TextChanged(object sender, EventArgs e)
        {
            //string SCRAP_SLOT_ID = "";
            //if (txtHeatID.Text.Trim() == "")
            //    return;
            //if (dsSCRAP_SLOT_ID.Tables[0].Rows.Count < 1)
            //    return;
            //foreach (DataRow dr in dsSCRAP_SLOT_ID.Tables[0].Rows)
            //{
            //    if (dr["HeatID"].ToString().Equals(txtHeatID.Text.ToString()))
            //   {
            //       SCRAP_SLOT_ID = dr["Scrap_Slot_ID"].ToString();
            //   }

            //}
            //if (SCRAP_SLOT_ID == "")
            //    return;
            //string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            //string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            //dsFG.SourceMethod = SQL1;
            //dsST.SourceMethod = SQL2;
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

            ds.Tables[0].Rows.Add(new string[] { tt,cc,"2","0" });

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmdExcept.Parameters[0].ConstantValue="XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
                cmdExcept.Parameters[1].SourceObject = ds;
                //cmdExcept.Parameters[1].SourceProperty = "L3DataTable";
                int iRot = cmdExcept.Execute();
                if (iRot == 0)
                {
                    if (Convert.ToInt32(cmdExcept.Command.Return) == 0)
                    {
                        dsExceptCode.LoadData();
                        MessageBox.Show("�쳣���뱣��ɹ�!");
                       
                       // ds.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("�쳣���뱣��ʧ��!", "��ʾ");
                        txtExcept.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("�쳣���뱣��ʧ��!","��ʾ");
                    txtExcept.Text = "";
                    return;
                }
            }
        }

            //DataRow drNew = dsExceptCode.Tables[0].NewRow();


            //drNew["EXCEPTIONAL_CODE"] = Convert.ToString(tempt + 1);
            //drNew["EXCEPTIONAL_DES"] = txtExcept.Text.Trim();
            //drNew["UNIT"] = "2";
            //drNew["AUTO_JUDGE_FLAG"] = "0";


            //dsExceptCode.Tables[0].Rows.Add(drNew);
            //dsExceptCode.AcceptChanges();
           // dsExceptCode.UpdateData();


        }



    }

