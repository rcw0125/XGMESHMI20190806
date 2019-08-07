using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag
{
    public partial class BofIronToBXGJudgeFrm : DockContent, IMESForm
    {
        string strCurHeatID = "";
        public BofIronToBXGJudgeFrm()
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


        //ˢ��
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsHeatID.LoadData();
        }


        //����
        private void btnJudge_Click(object sender, EventArgs e)
        {
            string AppID = "";
            string JudgeFlag = "";
            if (dsFinalChemical.Tables[0].Rows.Count >= 1)
            {
                int iCount = 0; int iFlag = 0;
                for (int i = 0; i < dsFinalChemical.Tables[0].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dvFinalChemical["CheckFlag", i].EditedFormattedValue) == true)
                        iCount++; iFlag = i;
                }
                if (iCount > 0 && iCount != 1)
                {
                    MessageBox.Show("��ֻѡ��һ������!", "��ʾ");
                    return;
                }
                else
                    AppID = dvFinalChemical["appIDDataGridViewTextBoxColumn1", iFlag].Value.ToString(); //ί�е���

            }

            if (rBtnYes.Checked == true)
            {
                JudgeFlag = "0";
            }
            if (rBtnNo.Checked == true)
            {
                JudgeFlag = "-1";
            }

            //У��
            if (strCurHeatID == "")
            {
                MessageBox.Show("��ѡ��¯��!", "��ʾ");
                return;
            }
            else if (dsFinalChemical.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("û��¯������Ϣ!", "��ʾ");
                return;
            }
            else if (AppID == "")
            {
                MessageBox.Show("��ѡ��ί�е����!", "��ʾ");
                return;
            }
            else if (JudgeFlag == "")
            {
                MessageBox.Show("��ѡ���Ƿ�ϸ�!", "��ʾ");
                return;
            }
            else if (strCurHeatID == "")
            {
                MessageBox.Show("¯��Ϊ��!", "��ʾ");
                return;
            }

            AppSvrHMI.L3DataSet dsTempt = new AppSvrHMI.L3DataSet();
            DataTable dt = new DataTable();
            dsTempt.Tables.Add(dt);
            dsTempt.Tables[0].Columns.Add("HeatID");
            dsTempt.Tables[0].Columns.Add("JudgeFlag");
            dsTempt.Tables[0].Columns.Add("AppID");
            dsTempt.Tables[0].Rows.Add(new string[] { strCurHeatID, JudgeFlag, AppID });

            cmdJudge.Parameters[0].SourceObject = dsTempt;
            //cmdJudge.Parameters[0].ConstantValue = dsTempt;
            try
            {
                int iRet = cmdJudge.Execute();
                if (iRet >= 0)
                {
                    if (Convert.ToInt32(cmdJudge.Command.Return) == 0)
                    {
                       // SetSourceCondition();
                       // SetL3DataAdpter();
                        dsHeatID.LoadData();
                      

                        MessageBox.Show("�����ɹ���", "��ʾ");
                    }
                    else if (Convert.ToInt32(cmdJudge.Command.Return) == -3)
                        MessageBox.Show("�Ѿ����У�", "��ʾ");
                    else
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                }
                else
                {
                    MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                }
            }
            catch { }

        }

        private void dvHeatExcept_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvRefineThirdEle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvFinalChemical_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

       
        private void SetL3Par(string strHeatID)
        {
            dsHeatGrade.SourceCondition = "HeatID='" + strHeatID + "'";
            dsHeatExcept.SourceCondition = "HeatID='" + strHeatID + "'";
            cmdChemicalStd.Parameters[0].ConstantValue = strHeatID;
            cmdFinalChemical.Parameters[0].ConstantValue = strHeatID;
            cmdRefineThirdEle.Parameters[0].ConstantValue = strHeatID;
            cmdChemicalStd.Adapter = Adapter;
            cmdFinalChemical.Adapter = Adapter;
            cmdRefineThirdEle.Adapter = Adapter;
        }

        private void dvHeatID_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvHeatID_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

        //ѡ��ĳ¯��
        private void dvHeatID_Click(object sender, EventArgs e)
        {
            if (dvHeatID.CurrentRow == null || dvHeatID.CurrentRow.Cells[0].Value == null)
            {

                dsHeatExcept.SourceCondition = "1=2";
                dsFinalChemical.L3DataAdapter = null;
                dsChemicalStd.L3DataAdapter = null;
                dsHeatExcept.L3DataAdapter = null;
                dsHeatGrade.L3DataAdapter = null;
                dsRefineThirdEle.L3DataAdapter = null;
                //load();
                return;
            }

            strCurHeatID = dvHeatID.CurrentRow.Cells[0].EditedFormattedValue.ToString();
            if (strCurHeatID == "")
                return;
            //����
            GetData();

            return;
        }

        //ˢ������
        private void GetData()
        {
            SetSourceCondition();
            SetL3DataAdpter();
            load();
        }

        //����SourceCondition
        private void SetSourceCondition()
        {
            disposed();
            //dsHeatGrade.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            dsHeatExcept.SourceCondition = " HeatID = '" + strCurHeatID + "' order by UnitTypeID desc ";
            cmdChemicalStd.Parameters[0].ConstantValue = strCurHeatID;
            cmdFinalChemical.Parameters[0].ConstantValue = strCurHeatID;
            cmdRefineThirdEle.Parameters[0].ConstantValue = strCurHeatID;
        }

        //����L3DataAdpter
        private void SetL3DataAdpter()
        {
            dsHeatExcept.L3DataAdapter = Adapter;
            dsChemicalStd.L3DataAdapter = Adapter;
            dsFinalChemical.L3DataAdapter = Adapter;
            dsRefineThirdEle.L3DataAdapter = Adapter;

        }

        private void load()
        {
            dsHeatGrade.LoadData();
            dsHeatExcept.LoadData();  //¯���쳣
            dsChemicalStd.LoadData();
            dsFinalChemical.LoadData();
            dsRefineThirdEle.LoadData();

        }

        private void disposed()
        {
            dsHeatGrade.Clear();
            dsHeatExcept.Clear();
            dsChemicalStd.Clear();
            dsFinalChemical.Clear();
            dsRefineThirdEle.Clear();
        }



      

   
    }
}