using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class LadlePlanMagFrm : DockContent, IMESForm
    {
        public LadlePlanMagFrm()
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

        private LadleFoldShowFrm LadleFoldShow = new LadleFoldShowFrm();//�۹�
        private LadlePourShowFrm LadlePourShow = new LadlePourShowFrm();//����
        private ChooseLadleShowFrm ChooseLadleShow = new ChooseLadleShowFrm();

        private string[,] strArrColor = new string[4, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control },
                { "02", CommDataMag.CommonData.Color_Code_Yellow },
                { "03", CommDataMag.CommonData.Color_Code_Red },
                { "04", CommDataMag.CommonData.Color_Code_Green } };

        private AppSvrHMI.L3DataSet dsChooseLadle = new AppSvrHMI.L3DataSet();


        //�ؼ�����
        private void LadlePlanMagFrm_Load(object sender, EventArgs e)
        {
            //string[,] strArrColor = 
            //  { { "01", CommDataMag.CommonData.Color_Code_Control },
            //    { "02", CommDataMag.CommonData.Color_Code_Yellow },
            //    { "03", CommDataMag.CommonData.Color_Code_Red },
            //    { "04", CommDataMag.CommonData.Color_Code_Green } };

            dsChooseLadle = (AppSvrHMI.L3DataSet)dsLadlePlan.Clone();

            tscmbBOFID.Items.Clear();
            tscmbCasterID.Items.Clear();
            for (int iBof = 0; iBof < dsBOFID.Tables[0].Rows.Count; iBof++)
            {
                tscmbBOFID.Items.Add(dsBOFID.Tables[0].Rows[iBof]["Code_Des"].ToString());
            }
            for (int iCast = 0; iCast < dsCasterID.Tables[0].Rows.Count; iCast++)
            {
                tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[iCast]["Code_Des"].ToString());
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void tscmbBOFID_DropDownClosed(object sender, EventArgs e)
        {
            txtBOFID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsBOFID, tscmbBOFID.Text);
        }

        private void tscmbCasterID_DropDownClosed(object sender, EventArgs e)
        {
            txtCastID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.Text);
        }

        //�۹�
        private void btnFold_Click(object sender, EventArgs e)
        {
            //DataSet dsFold = 
            //LadleFoldShow.ShowDialogEx(Adapter.Session);
        }

        //����
        private void btnPour_Click(object sender, EventArgs e)
        {
            //LadlePourShow.ShowDialogEx(Adapter.Session);
        }

        //ָ���ְ�
        private void btnSpecify_Click(object sender, EventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            DataSet dsSpecify = (DataSet)(cmdSpecify.Parameters[0].Value);
            if (dsSpecify != null && dsSpecify.Tables[0].Rows.Count > 0)
            {
                if (!GetdsSpecifyEqualCount(dsSpecify))
                {
                    cmdSpecify.Execute();
                    int iRet = Convert.ToInt16(cmdSpecify.Command.Return);
                    if (iRet < 1)
                    {
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("\" " + iRet + "\" ���ƻ�ָ���ɹ���", "��ʾ", MessageBoxButtons.OK);
                        dsLadlePlan.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("����ָ�������ܴ���ͬһ�ְ�ָ������ͬ�ְ��ƻ������飡", "��ʾ��", MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("û��ѡ�мƻ�������ѡ�мƻ�û��ѡ��ְ���",
                    "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsLadlePlan.SourceMethod = "QueryUnProcessLadlePlan";
            dsLadlePlan.LoadData();
        }

        private void dvLadlePlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //�Ҽ�ѡ��ָ���ְ�
        private void btnChooseLadle_Click(object sender, EventArgs e)
        {
            dsChooseLadle.Tables[0].Clear();
            int idsPosition = dsLadlePlan.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsLadlePlan.Current)).Row);
            dsChooseLadle.Tables[0].ImportRow(dsLadlePlan.Tables[0].Rows[idsPosition]);

            if (dsChooseLadle.Tables[0].Rows.Count != 1)
            {
                MessageBox.Show("�޷�ָ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChooseLadleShow.ShowDialogEx(Adapter.Session, ref dsChooseLadle);

            if (dsChooseLadle.Tables[0].Rows[0]["LadleID"] == null || dsChooseLadle.Tables[0].Rows[0]["LadleID"].ToString() == "")
            {
                dsLadlePlan.Tables[0].Rows[idsPosition]["LadleID"] = null;
            }
            else
            {
                dsLadlePlan.Tables[0].Rows[idsPosition]["LadleID"] = dsChooseLadle.Tables[0].Rows[0]["LadleID"].ToString();
            }
        }

        //��Ҫ�Ҽ�ʱ
        private void dvLadlePlan_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            //δ����
            if (dvLadlePlan.Rows[bsLadlePlan.Position].Cells["Status"].Value.ToString()
                != CommDataMag.CommonData.CLADLE_PLAN_STATUS_UNDESIGN)
            {
                btnChooseLadle.Enabled = false;
            }
            else
            {
                btnChooseLadle.Enabled = true;
            }

            //ִ��
            if (dvLadlePlan.Rows[bsLadlePlan.Position].Cells["Status"].Value.ToString()
                != CommDataMag.CommonData.CLADLE_PLAN_STATUS_EXCUTING)
            {
                btnPour.Enabled = false;
                btnFold.Enabled = false;
            }
            else
            {
                btnPour.Enabled = true;
                btnFold.Enabled = true;
            }
        }

        //ȡ��ָ��
        private void btnCancelSpecify_Click(object sender, EventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            DataSet dsCancel = (DataSet)(cmdCancel.Parameters[0].Value);

            if (dsCancel != null && dsCancel.Tables[0].Rows.Count > 0)
            {
                cmdCancel.Execute();

                int iRet = Convert.ToInt16(cmdCancel.Command.Return);
                if (iRet < 1)
                {
                    MessageBox.Show("ȡ��ָ��ʧ�ܣ�", "��ʾ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("\" " + iRet + "\" ���ƻ�ȡ��ָ���ɹ� ",
                        "��ʾ��", MessageBoxButtons.OK);
                    dsLadlePlan.LoadData();
                }
            }
            else
            {
                MessageBox.Show("û��ѡ�мƻ�������ѡ�мƻ�������ȡ��ָ����",
                    "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //�ж��Ƿ������ͬ�ְ���ָ������ͬ�ƻ��ƻ�
        private bool GetdsSpecifyEqualCount(DataSet dsSpecify)
        {
            string[] strArr = new string[dsSpecify.Tables[0].Rows.Count];
            for (int i = 0; i < dsSpecify.Tables[0].Rows.Count; i++)
            {
                strArr[i] = dsSpecify.Tables[0].Rows[i]["LadleID"].ToString();
            }
            if (CommDataMag.CommonMethed.GetEqualCount(strArr))
            {
                return true;
            }
            else { return false; }
        }

        //������ɫ
        private void dvLadlePlan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvLadlePlan, "STATUS", strArrColor);
        }
    }
}