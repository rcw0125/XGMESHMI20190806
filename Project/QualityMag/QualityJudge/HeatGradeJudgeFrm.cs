using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityJudge
{
    public partial class HeatGradeJudgeFrm : DockContent, IMESForm
    {
        public HeatGradeJudgeFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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

        private double fweight = 0;
        private string strCurHeatID = "";
        private string strAppID = "";
        private double fBloomWeight = 0;//������кϸ�����������������ȡ����2009-03-02Liao��

        //����
        private void HeatGradeJudgeFrm_Load(object sender, EventArgs e)
        {
            SetSourceCondition();//�������ݼ�������
            SetL3DataAdpter();//����Adapter
            rbtnHotCheck.Checked = true;
            GetFinalHeatIDData(null, null);//��ȡ¯����Ϣ

            //�Ƿ����
            tbxWrongCount1.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxWrongCount2.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxWrongCount3.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        //��ȡ¯����Ϣ
        private void GetFinalHeatIDData(object sender, EventArgs e)
        {
            if (cbxCCMID.SelectedValue == null)
                return;
            cmdHeatID.Parameters[0].ConstantValue = cbxCCMID.SelectedValue.ToString();

            if (rbtnHotCheck.Checked)
            {
                cmdHeatID.Parameters[1].ConstantValue = rbtnHotCheck.Tag.ToString();
            }
            else if (rbtnUnFinalJudge.Checked)
            {
                cmdHeatID.Parameters[1].ConstantValue = rbtnUnFinalJudge.Tag.ToString();
            }
            else if (rbtnReFinalJudge.Checked)
            {
                cmdHeatID.Parameters[1].ConstantValue = rbtnReFinalJudge.Tag.ToString();
            }
            dsHeatID.LoadData();
        }

        private void GetHeatSurfaceJudgeData(string HeatID)
        {
            //string strObjID = "";
            //string Length = "";
            //object objTemp = null;
            //object objSteelGrade = null;
            //string strSteelGradeIndex = "";

            fBloomWeight = 0; 
            fweight = 0;
            //��ȡ��������������֧�����㵥λ���� 2009-06-01
            if(HeatID!="")
            {
                object objCalWeight = null;
                object objBloomCount = null;
                string strBoolmDataUri = "MES\\MaterialData\\CBloom_Data\\" + HeatID;

                Adapter.Session.Get(strBoolmDataUri, "Cal_Weight", ref objCalWeight);
                double dCalWeight = double.Parse(objCalWeight.ToString());

                Adapter.Session.Get(strBoolmDataUri, "Bloom_Count", ref objBloomCount);
                double dBloomCount = double.Parse(objBloomCount.ToString());

                if (dBloomCount > 0.0)
                    fweight = dCalWeight / dBloomCount;
            }
            if (dsSurfaceJudge.Tables[0].Rows.Count > 0)
            {
                /*2009-03-02*/
                try
                {
                    //��ȡ������������2009-03-02Liao��
                    string strBloomWeight = dsSurfaceJudge.Tables[0].Rows[0]["Right_Weight"].ToString();
                    fBloomWeight = double.Parse(strBloomWeight);
                }
                catch { fBloomWeight = 0;}
            }
        }

        private void GetHeatFinalJudgeData(string HeatID)
        {
            dsFinalJudge.Tables[0].Clear();
            if (HeatID.Length != 9)
                return;

            cmdFinalJudge.Parameters[0].ConstantValue = strCurHeatID;
            dsFinalJudge.L3DataAdapter = Adapter;
            dsFinalJudge.LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsFinalJudge.EndEdit();
            if (dsFinalJudge.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("û�����еĸ�����");
                return;
            }
            if (strAppID == "")
            {
                MessageBox.Show("û��ѡ�����еĳɷ֣�");
                return;
            }
            if (Convert.ToInt16(tbxRightCount.Text.Trim()) < 0)
            {
                MessageBox.Show("�ϸ�֧��С��0,���������У�", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dsFinalJudge.Tables[0].Rows[0]["PRE_STEELGRADEINDEX"] = lbPRESTEELGRADEINDEX.Text;
            dsFinalJudge.Tables[0].Rows[0]["STEELGRADEINDEX"] = lbSteelGradeIndex.Text;
            dsFinalJudge.Tables[0].Rows[0]["CUT_STEELGRADEINDEX"] = lbCutSteelIndex.Text;

            cmdHeatJudge.Parameters[0].ConstantValue = strCurHeatID;
            cmdHeatJudge.Parameters[1].SourceObject = dsFinalJudge;
            cmdHeatJudge.Parameters[2].ConstantValue = strAppID;

            int iRet = cmdHeatJudge.Execute();
            if (iRet != 0 || Convert.ToInt32(cmdHeatJudge.Command.Return) != 0)
            {
                MessageBox.Show(string.Format("ʧ�ܣ�����:{0:X},{1:D}", cmdHeatJudge.Command.ErrorCode, Convert.ToInt32(cmdHeatJudge.Command.Return)));
            }
            else
            {
                MessageBox.Show("���гɹ���", "��ʾ", MessageBoxButtons.OK);
                GetFinalHeatIDData(null, null);
            }
            strAppID = "";//���2009-02-21
        }

        //ѡ���¯�ű仯�������¼�
        private void bsHeatID_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                strCurHeatID = dvHeatID.Rows[bsHeatID.Position].Cells[hEATIDDataGridViewTextBoxColumn.Index].Value.ToString();
                string Status = dvHeatID.Rows[bsHeatID.Position].Cells[sTATUSDataGridViewTextBoxColumn.Index].Value.ToString();

                if (Status == "8")
                    cbxUnJudge.Checked = true;
            }
            catch
            {
                strCurHeatID = "";
            }
            if (strCurHeatID.Length != 9)
            {
                dsHeatGrade.Tables[0].Clear();
                dsHeatExcept.Tables[0].Clear();
                dsChemicalStd.Tables[0].Clear();
                dsFinalChemical.Tables[0].Clear();
                dsRefineThirdEle.Tables[0].Clear();
                dsSurfaceJudge.Tables[0].Clear();
                dsFinalJudge.Tables[0].Clear();
                return;
            }

            GetData();
            GetHeatFinalJudgeData(strCurHeatID);
            GetHeatSurfaceJudgeData(strCurHeatID);

            if (dsFinalJudge.Tables[0].Rows.Count < 1)
            {
                dsFinalJudge.Tables[0].Clear();
                if (dsSurfaceJudge.Tables[0].Rows.Count > 0)
                {
                    dsFinalJudge.Tables[0].ImportRow(dsSurfaceJudge.Tables[0].Rows[0]);
                    dsFinalJudge.Tables[0].Rows[0]["FINAL_STEELGRADEINDEX"] = lbSteelGradeIndex.Text.Trim();
                }
            }

            try
            {
                //��ȡ����
                if (lbSteelGradeIndex.Text.Trim() != "YY000000")
                {
                    l3cmdpSteelGrade.ConstantValue = lbSteelGradePre.Text.Trim();
                    l3cmdpSteelGradeIndex.ConstantValue = lbSteelGradeIndex.Text.Trim();
                }
                else
                {
                    l3cmdpSteelGrade.ConstantValue =
                        CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, dsSurfaceJudge.Tables[0].Rows[0]["STEELGRADEINDEX"].ToString());
                    l3cmdpSteelGradeIndex.ConstantValue = dsSurfaceJudge.Tables[0].Rows[0]["STEELGRADEINDEX"].ToString();
                }
                dsSteelGradeIndex.LoadData();
            }
            catch { }
        }

        //ˢ������
        private void GetData()
        {
            SetSourceCondition();

            dsHeatGrade.LoadData();
            dsHeatExcept.LoadData();
            dsChemicalStd.LoadData();
            dsFinalChemical.LoadData();
            dsRefineThirdEle.LoadData();
            dsSurfaceJudge.LoadData();
            dsFinalJudge.LoadData();
        }

        //����SourceCondition
        private void SetSourceCondition()
        {
            dsHeatGrade.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            dsHeatExcept.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            cmdChemicalStd.Parameters[0].ConstantValue = strCurHeatID;
            cmdFinalChemical.Parameters[0].ConstantValue = strCurHeatID;
            cmdRefineThirdEle.Parameters[0].ConstantValue = strCurHeatID;
            cmdSurfaceJudge.Parameters[0].ConstantValue = strCurHeatID;
            cmdFinalJudge.Parameters[0].ConstantValue = strCurHeatID;
        }

        //����L3DataAdpter
        private void SetL3DataAdpter()
        {
            dsHeatGrade.L3DataAdapter = Adapter;
            dsHeatGrade.L3DataAdapter = Adapter;
            dsChemicalStd.L3DataAdapter = Adapter;
            dsFinalChemical.L3DataAdapter = Adapter;
            dsRefineThirdEle.L3DataAdapter = Adapter;
            dsSurfaceJudge.L3DataAdapter = Adapter;
            dsFinalJudge.L3DataAdapter = Adapter;
        }

        //����
        private void ckbProcessType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(ckbProcessType.Checked))
                {
                    tbxRightCount.Text = txtTestCount.Text;
                    tbxRightWeight.Text = txtTestWeight.Text;

                    txtTestCount.Text = "0";
                    txtTestWeight.Text = "0";
                    cmbSteelGradeIndexFin.Enabled = true;
                }
                else
                {
                    txtTestCount.Text = tbxRightCount.Text;
                    txtTestWeight.Text = tbxRightWeight.Text;

                    tbxRightCount.Text = "0";
                    tbxRightWeight.Text = "0";

                    cmbSteelGradeIndexFin.Text = "YY000000";
                    cmbSteelGradeIndexFin.Enabled = false;
                }
            }
            catch { }

        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        /*********************�ɷֱ���***************************/
        //��Ʒ�ɷ�
        private void dvFinalChemical_Paint(object sender, PaintEventArgs e)
        {
            if (dvFinalChemical.Rows.Count < 1)
                return;
            for (int i = 0; i < dvFinalChemical.Rows.Count; i++)
            {
                if (dsChemicalStd.Tables[0].Rows.Count > 0)
                {
                    for (int j = CP.Index; j < Other3P.Index; j++)
                    {
                        DataGridViewCell cell = dvFinalChemical.Rows[i].Cells[j];
                        try
                        {
                            //��ȡʵ���ɷ�����
                            string strDataProName = dvFinalChemical.Columns[cell.ColumnIndex].DataPropertyName;
                            //ȡ������
                            double dRealValue = Convert.ToDouble(cell.Value.ToString());
                            //�ж��Ƿ�У��
                            if (dRealValue > 0)
                            {
                                double dStdMax = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Max"].ToString());
                                double dStdMin = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Min"].ToString());
                                CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
                            }
                        }
                        catch { }
                    }
                }
                //��Ʒ��
                if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GP)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.GreenYellow;
                }
                //�����а���
                else if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GL)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.Aquamarine;
                }
                //����
                else if (dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Value.ToString() == CommDataMag.CommonData.QA_Sample_Type_GE)
                {
                    dvFinalChemical.Rows[i].Cells["SAMPLE_TYPE1"].Style.BackColor = Color.Lime;
                }
            }
        }

        //������3����
        private void dvRefineThirdEle_Paint(object sender, PaintEventArgs e)
        {
            if (dvRefineThirdEle.Rows.Count < 1)
                return;
            for (int i = 0; i < dvRefineThirdEle.Rows.Count; i++)
            {
                if (dsChemicalStd.Tables[0].Rows.Count > 0)
                {
                    for (int j = CL.Index; j < Other3L.Index; j++)
                    {
                        DataGridViewCell cell = dvRefineThirdEle.Rows[i].Cells[j];
                        try
                        {
                            //��ȡʵ���ɷ�����
                            string strDataProName = dvRefineThirdEle.Columns[cell.ColumnIndex].DataPropertyName;
                            //ȡ������
                            double dRealValue = Convert.ToDouble(cell.Value.ToString());
                            //�ж��Ƿ�У��
                            if (dRealValue > 0)
                            {
                                double dStdMax = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Max"].ToString());
                                double dStdMin = Convert.ToDouble(dsChemicalStd.Tables[0].Rows[0][strDataProName + "_Min"].ToString());
                                CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
                            }
                        }
                        catch { }
                    }
                }
            }
        }

        private void dvHeatGrade_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //��������20081231Liao
        private void CalculateWeightNew(object sender, EventArgs e)
        {
            /*1������������֧�� == 0���������� == 0���ϸ�֧�� + ���ϸ���֧�� = ������֧����
              2������  �ϸ�֧�� == 0���ϸ����� == 0������ָ�� + ���ϸ���֧�� = ������֧����*/
            try
            {
               // bsFinalJudge.EndEdit();

                PxDataValid.PxTextBox ctrl = (PxDataValid.PxTextBox)sender;
                string strctrlText = ctrl.Text;
                switch (ctrl.Name)
                {
                    case "tbxWrongCount1":
                        tbxWrongWeight1.Text = Convert.ToString(Math.Round(fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)), 3));//string.Format("{0:F}", fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        break;

                    case "tbxWrongCount2":
                        tbxWrongWeight2.Text = Convert.ToString(Math.Round(fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)), 3));// string.Format("{0:F}", fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        break;

                    case "tbxWrongCount3":
                        tbxWrongWeight3.Text = Convert.ToString(Math.Round(fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)), 3));// string.Format("{0:F}", fweight * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        break;
                    default:
                        break;
                }


                string strCnt1 = tbxWrongCount1.Text; strCnt1.Trim();
                string strCnt2 = tbxWrongCount2.Text; strCnt2.Trim();
                string strCnt3 = tbxWrongCount3.Text; strCnt3.Trim();
                //���㲻�ϸ���֧��
                int iWrongCount = (strCnt1.Length < 1 ? 0 : Convert.ToInt32(strCnt1)) +
                    (strCnt2.Length < 1 ? 0 : Convert.ToInt32(strCnt2)) +
                    (strCnt3.Length < 1 ? 0 : Convert.ToInt32(strCnt3));

                //���ϸ���֧��
                tbxWrongCount.Text = iWrongCount.ToString();

                //���ϸ�������
                double WrongWeight = iWrongCount * fweight;
                tbxWrongWeight.Text = Convert.ToString(Math.Round(WrongWeight, 3));//string.Format("{0:F}", WrongWeight);

                //������֧��
                string strBloomCount = tbxBloomCount.Text; strBloomCount.Trim();
                int iBloomCount = strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount);

                //������
                if (!(ckbProcessType.Checked))
                {
                    //�ϸ�֧�� = ����֧�� - ���ϸ���֧��
                    int iRightCount = iBloomCount - iWrongCount;
                    tbxRightCount.Text = iRightCount.ToString();
                    //�ϸ����� = ���и����ϸ����� - ���ϸ�������2009-03-02Liao��
                    double dRightWeight = fBloomWeight - WrongWeight; //iRightCount * fweight;
                    tbxRightWeight.Text = Convert.ToString(Math.Round(dRightWeight, 3));//string.Format("{0:F}", dRightWeight);

                    return;
                }
                else
                {
                    //����֧�� = ����֧�� - ���ϸ���֧��
                    int iTestCount = iBloomCount - iWrongCount;
                    txtTestCount.Text = iTestCount.ToString();
                    //��������
                    double dTestWeight = iTestCount * fweight;
                    txtTestWeight.Text = Convert.ToString(Math.Round(dTestWeight, 3)); ;//string.Format("{0:F}", dTestWeight);

                    return;
                }
            }
            catch { }
        }

        //ԤԼ�ȼ��¼�[20090102Liao]
        private void l3dbxHotJudgeEvent_TextChanged(object sender, EventArgs e)
        {
            GetFinalHeatIDData(sender, e);
        }

        //ѡ��У��
        private void dv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dv = (DataGridView)sender;
                if (dv.Name == dvFinalChemical.Name)
                {��
                    dvFinalChemical.EndEdit();
                    //��ǰ�б�ѡ��
                    if (dvFinalChemical.Rows[bsFinalChemical.Position].Cells["CheckFlagFin"].Value.ToString() == "1")
                    {
                        strAppID = dvFinalChemical.Rows[bsFinalChemical.Position].Cells["APPIDFin"].Value.ToString();//ί�е����

                        int idvRow = dvFinalChemical.Rows.Count;
                        for (int i = 0; i < dvFinalChemical.CurrentRow.Index; i++)
                            if (dvFinalChemical.Rows[i].Cells[0].Value.ToString() == "1")
                                dvFinalChemical.Rows[i].Cells[0].Value = 0;

                        for (int j = dvFinalChemical.CurrentRow.Index + 1; j < idvRow; j++)
                            if (dvFinalChemical.Rows[j].Cells[0].Value.ToString() == "1")
                                dvFinalChemical.Rows[j].Cells[0].Value = 0;

                        int idvRefineRowCount = dvRefineThirdEle.Rows.Count;
                        for (int k = 0; k < idvRefineRowCount; k++)
                            dvRefineThirdEle.Rows[k].Cells["CheckFlag"].Value = 0;

                    }
                    else
                    {
                        strAppID = "";
                    }
                }
                else if (dv.Name == dvRefineThirdEle.Name)
                {
                    dvRefineThirdEle.EndEdit();
                    //��ǰ�б�ѡ��
                    if (dvRefineThirdEle.Rows[bsRefineThirdEle.Position].Cells["CheckFlag"].Value.ToString() == "1")
                    {
                        strAppID = dvRefineThirdEle.Rows[bsRefineThirdEle.Position].Cells["APPIDRef"].Value.ToString();

                        int idvRow = dvRefineThirdEle.Rows.Count;
                        for (int i = 0; i < dv.CurrentRow.Index; i++)
                            if (dvRefineThirdEle.Rows[i].Cells[0].Value.ToString() == "1")
                                dvRefineThirdEle.Rows[i].Cells[0].Value = 0;

                        for (int j = dv.CurrentRow.Index + 1; j < idvRow; j++)
                            if (dvRefineThirdEle.Rows[j].Cells[0].Value.ToString() == "1")
                                dvRefineThirdEle.Rows[j].Cells[0].Value = 0;

                        int idvFinRowCount = dvFinalChemical.Rows.Count;
                        for (int k = 0; k < idvFinRowCount; k++)
                            dvFinalChemical.Rows[k].Cells["CheckFlagFin"].Value = 0;

                    }
                    else
                    {
                        strAppID = "";
                    }
                }
                else
                {
                    strAppID = "";
                }
            }
            catch { strAppID = ""; }
        }

        private void HeatGradeJudgeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}