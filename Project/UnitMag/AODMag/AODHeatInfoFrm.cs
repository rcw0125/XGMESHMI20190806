using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.AODMag
{
    public partial class AODHeatInfoFrm : Form
    {
        public AODHeatInfoFrm()
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

    

                //dsSumAddition
                dsSumAddition.SourceMethod = "select Element,sum(Weight) as Weight,TYPE from CAOD_ADDITION_DATA  where HeatID = '" + strHeatID + "' group by Element,type";

                //dsOxygen
                //dsOxygen.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsOxygenTap
    
                //dsProcess
                dsProcess.SourceCondition = "HeatID = '" + strHeatID + "'";

                //dsTapProcess
  
                //dsStatus
                string strSQL = "";
                strSQL += "select HeatID,case when status=0 then '�ȴ�' when status=1 then '����' when status=2 and step=0  then '��̼1'  ";
                strSQL += "when status=2 and step=1  then '��̼1'   when status=2 and step=2  then '��̼2'  when status=2 and step=3  then '��̼3'   when status=2 and step=4  then '��̼4'  ";
                strSQL += "when status=2 and step=5  then '��̼5'  when status=2 and step=6  then '��̼6' when status=2 and step=7  then '��̼7'   when status=2 and step=8  then '��̼8' ";
                strSQL += "when status=3 then '������ʼ'  when status=4 then '��������' when status=5 then '��ԭ' ";
                strSQL += " when status=6 then '���ֿ�ʼ' when status=7 then '���ֽ���' else '�ȴ�' end as Status,Change_Time from caod_process_Status  where  ";

                dsStatus.SourceMethod = strSQL + "HeatID = '" + strHeatID + "' order by Change_Time desc";

                //dsTemp
                dsTemp.SourceCondition = "HeatID = '" + strHeatID + "'";


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
               // dsIronLadleID.SourceMethod = "select IRONLADLENO,SOURCE from CIRON_DATA where HeatID = '" + strHeatID + "'";

                ////�ϸֶ���
                //string strSQLScrapid = "";
                //dsScrapID.SourceMethod = "select scrap_slot_id from cscrap_output_log where 1=2";
                //strSQLScrapid += "SELECT   SUBSTR (scrap_slot_id,                ";
                //strSQLScrapid += "                 1,                            ";
                //strSQLScrapid += "                 (LENGTH (scrap_slot_id) - 15) ";
                //strSQLScrapid += "                ) AS scrap_slot_id             ";
                //strSQLScrapid += "    FROM cscrap_output_log                     ";
                //strSQLScrapid += "   WHERE heatid =  '" + strHeatID + "'";
                //strSQLScrapid += "GROUP BY scrap_slot_id                         ";
                //dsScrapID.SourceMethod = strSQLScrapid;

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
                strBatch_mat_Man += "     AND (d.containerid = '13' OR d.containerid = '14' )";
                strBatch_mat_Man += "     AND c.alloy_code = e.code";
                strBatch_mat_Man += "     AND e.code_group = 'ALLOY_CODE'";
                strBatch_mat_Man += "     AND (e.code_function_group IS NULL OR e.code_function_group <> 'FeedWire'";
                strBatch_mat_Man += "         )";
                strBatch_mat_Man += "ORDER BY alloy_code";
                dsMat_Alloy_Add_Man.SourceMethod = strBatch_mat_Man;

                /* ת¯¯��Ͻ���� */


                /* ת¯ɢ״�ϼ��� */
                //strBatch_mat_Man = "";
                //dsBulk_Add_Man.SourceMethod = strBatch_mat_Man;
                //strBatch_mat_Man += "SELECT   distinct c.bulk_code, c.batch_id, c.materialid AS code,";
                //strBatch_mat_Man += "         e.code_des || '(' || c.batch_id || ')' AS code_des";
                //strBatch_mat_Man += "    FROM (SELECT a.materialid, a.POSITION AS pos, b.batch_id, b.bulk_code";
                //strBatch_mat_Man += "            FROM materialposition a, cbulk_data b";
                //strBatch_mat_Man += "           WHERE a.materialid = b.materialid";
                //strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 1, 3) = 'S83'";
                //strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'P'";
                //strBatch_mat_Man += "             AND SUBSTR (a.POSITION, 4, 1) <> 'N') c,";
                //strBatch_mat_Man += "         (SELECT *";
                //strBatch_mat_Man += "            FROM xgstorearea";
                //strBatch_mat_Man += "           WHERE SUBSTR (code, 1, 3) = 'S83') d,";
                //strBatch_mat_Man += "         cbase_all_code e";
                //strBatch_mat_Man += "   WHERE c.pos = d.code and d.containerid = '15'";
                ////strBatch_mat_Man += "   WHERE c.pos = d.code ";
                //strBatch_mat_Man += "     AND c.bulk_code = e.code";
                //strBatch_mat_Man += "     AND e.code_group = 'BULK_CODE'";
                //strBatch_mat_Man += "ORDER BY bulk_code";
                //dsBulk_Add_Man.SourceMethod = strBatch_mat_Man;
                //dsSCRAP_SLOT_ID.SourceMethod = "select SCRAP_SLOT_ID from CSCRAP_OUTPUT_LOG where HEATID='" + strCurHeatID + "'";

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
            btnDelChemical.Visible = false;
            btnDelBottomBlow.Visible = false;
            btnDelTopBlow.Visible = false;
            btnDelStatus.Visible = false;
            btnDelTemp.Visible = false;
       
            //btnDelOxygen.Visible = false;
   
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
            //if (dsSCRAP_SLOT_ID.Tables[0].Rows.Count != 0)
            //{
            //    string SCRAP_SLOT_ID = dsSCRAP_SLOT_ID.Tables[0].Rows[0][0].ToString();
            //    string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            //    string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            //    dsFG.SourceMethod = SQL1;
            //    dsST.SourceMethod = SQL2;
            //}

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
        
                //btnAddOxygen.Visible = true;
    
                fLPTemp.Visible = true;
                btnTempConfirm.Visible = true;

                //¯�μ���
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

                fLPBottomBlow.Visible = false;//UnLock;
                btnAddBottomBlow.Visible = false;//UnLock;

                fLPTopBlow.Visible = false;//UnLock;
                btnAddTopBlow.Visible = false;//UnLock;

                fLPStatus.Visible = false;//UnLock;
                btnAddStatus.Visible = false;//UnLock;

                fLPTemp.Visible = false;//UnLock;
                btnAddTemp.Visible = false;//UnLock;
      
                //btnAddOxygen.Visible = false;//UnLock;
      

                if (!UnLock)
                {
                    fLPBase.Visible = UnLock;
                    fLPProcess.Visible = UnLock;
                    fLPExcept.Visible = UnLock;
                    fLPRemark.Visible = UnLock;


                    btnAddAlloy.Visible = UnLock;
                    fLPAlloy.Visible = UnLock;


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
            //tbxTi.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxIronTemp.TextChanged += new EventHandler(pxControls_TextChanged);

            txtTappingTime.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSplashingTime.TextChanged += new EventHandler(pxControls_TextChanged);

            txtTapholeLife.TextChanged += new EventHandler(pxControls_TextChanged);
            txtSmeltPeriod.TextChanged += new EventHandler(pxControls_TextChanged);

            txtLanceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtFurnaceAge.TextChanged += new EventHandler(pxControls_TextChanged);
            txtLadleNo.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingWeight.TextChanged += new EventHandler(pxControls_TextChanged);

            txtLaCTemp.TextChanged += new EventHandler(pxControls_TextChanged);
            txtTappingTemp.TextChanged += new EventHandler(pxControls_TextChanged);

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

        private void btnDelMat_Click(object sender, EventArgs e)
        {
            if (bsMat.Current != null)
                bsMat.RemoveCurrent();
        }



        private void btnMatCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
          
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
       
        }

        private void btnAlloyCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
        
        }

        //¯��Ͻ�����

        private void btnDelTapAlloy_Click(object sender, EventArgs e)
        {
            if (bsTapAlloy.Current != null)
                bsTapAlloy.RemoveCurrent();
        }



        //ұ������
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


 

        private void btnTempConfirm_Click(object sender, EventArgs e)
        {
            dvTemp.EndEdit();
            bsTemp.EndEdit();

  

            //dvOxygen.EndEdit();
            //bsOxygen.EndEdit();


            //bOperation = (dsTemp.UpdateData()  && dsOxygen.UpdateData() );
            bOperation = (dsTemp.UpdateData());
            MessageShowOperation();
            dsTemp.LoadData();
    
            //dsOxygen.LoadData();
       
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsTemp.LoadData();
      
            //dsOxygen.LoadData();
 
        }

        ////��������
        //private void btnAddOxygen_Click(object sender, EventArgs e)
        //{
        //    DataRow newrow = dsOxygen.Tables[0].NewRow();
        //    newrow["HeatID"] = strCurHeatID;
        //    newrow["Measure_Time"] = System.DateTime.Now;
        //    newrow["Name"] = "1";
        //    dsOxygen.Tables[0].Rows.Add(newrow);
        //}

        //private void btnDelOxygen_Click(object sender, EventArgs e)
        //{
        //    if (bsOxygen.Current != null)
        //        bsOxygen.RemoveCurrent();
        //}



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
                            //if (dsScrapID.L3DataAdapter == null)
                            //    dsScrapID.L3DataAdapter = Adapter;

                            //if (dsIronLadleID.L3DataAdapter == null)
                            //    dsIronLadleID.L3DataAdapter = Adapter;

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

                        case "tabExcept":
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
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

        //private void dvOxygen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    try
        //    {
        //        for (int i = 0; i < dvOxygen.Rows.Count; i++)
        //        {
        //            if (dvOxygen.Rows[i].Cells["Name5"].Value.ToString() != "1")
        //                dvOxygen.Rows[i].ReadOnly = true;
        //            else
        //                dvOxygen.Rows[i].ReadOnly = false;
        //        }
        //    }
        //    catch { }
        //}




        private void dsMainMat_OnDataLoaded(object sender)
        {
            //try
            //{
            //    dsIronLadleID.LoadData();
            //    dsScrapID.LoadData();
            //}
            //catch { }
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



 


        //ɢ״��
        private void dvMat_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

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

