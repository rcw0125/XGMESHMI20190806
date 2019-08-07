using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class LadleUseMagShowFrm : Form
    {
        //[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]//����Win API
        //public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);
        //int GW_CHILD = 5;

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        //public const int EM_SETREADONLY = 0xcf;

        public LadleUseMagShowFrm()
        {
            InitializeComponent();
            //IntPtr editHandle = GetWindow(cmdAutoFlow.Handle, GW_CHILD);//��ȡComAutoFlow���
            //SendMessage(editHandle, EM_SETREADONLY, 1, 0);//����Ϊֻ����
        }

        private string strLadleID = "";
        private string strLadleType = "";//�ְ�����
        private AppSvrHMI.L3DataSet dsHistory = new AppSvrHMI.L3DataSet();
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, bool bComFlag, int iPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            if (!bComFlag)//��û�п�ʼ����
                dsLadleID.SourceCondition = "STATUS = '07' order by LadleID";
            else
                dsLadleID.SourceCondition = null;
            Adapter.Session = session;
            cmbLadleID.TextChanged += new EventHandler(pxControls_TextChangedFact);
            cmbBOFID.TextChanged += new EventHandler(pxControls_TextChangedFact);

            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
            bsMain.Position = iPosition;
            
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void LadleUseMagShowFrm_Load(object sender, EventArgs e)
        {
            dsHistory = (AppSvrHMI.L3DataSet)dsMain.Clone();
            dsHistory.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;

            txtLadleAge.TextChanged += new EventHandler(pxControls_TextChangedFact);
            txtBOFID.TextChanged += new EventHandler(pxControls_TextChangedFact);
            txtFireTimeLen.TextChanged += new EventHandler(pxControls_TextChangedFact);

            txtRemnantWT.TextChanged += new EventHandler(pxControls_TextChangedFact);
            rtxtNote.TextChanged += new EventHandler(pxControls_TextChangedFact);

            txtStopTimeLen.TextChanged += new EventHandler(pxControls_TextChangedFact);
            foreach (Control c in gbxAge.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChangedFact);
                }
            }
            //cmbSkBoardKeep.ErropPr = errorProvider1;
        }

        //ѡ��ְ���
        //ͨ���ְ��Ż�ȡ��Ӧ�ְ����һ���ϼ�ʵ��
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (strLadleID == "")
                return;

            GetMachineAge();


            GetTime();
        }

        private void dtSeatOKTime_ValueChanged(object sender, EventArgs e)
        {
            //����ְ�ͣ��ʱ��
            double dStop = dtArriveTime.Value.ToOADate();
            double dOK = dtSeatOKTime.Value.ToOADate();

            double dTotal = Math.Round((dOK - dStop) * 24, 2);
            if (dTotal < 24)
            {
                txtStopTimeLen.Text = dTotal.ToString();
            }
        }

        private void cmbLadleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            strLadleID = cmbLadleID.Text.Trim();

            DataRow[] dr = dsLadleID.Tables[0].Select("LadleID = '" + strLadleID + "'");
            if (dr.Length < 1)
                return;
            int i = dsLadleID.Tables[0].Rows.IndexOf(dr[0]);
            strLadleType = dsLadleID.Tables[0].Rows[i]["LadleType"].ToString();

            if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_COM_50)
            {
                cmbOffReason.DataSource = null;
                cmbOffReason.DataSource = dsComLadleThrow;
                cmbOffReason.DisplayMember = "L3DataTable.Code_Des";
                cmbOffReason.ValueMember = "L3DataTable.Code";
            }
            else
            {
                cmbOffReason.DataSource = null;
                cmbOffReason.DataSource = dsFinLadleThrow;
                cmbOffReason.DisplayMember = "L3DataTable.Code_Des";
                cmbOffReason.ValueMember = "L3DataTable.Code";
            } 


        }

        //��ȡ��һ¯ͣ��ʱ�䡢�°�ʱ����Ϣ
        private void GetTime()
        {
            dsGetTime.Tables[0].Clear();
            cmdGetTime.Parameters[0].ConstantValue = strLadleID;
            dsGetTime.L3DataAdapter = Adapter;
            dsGetTime.L3DataAdapter = null;

            if (dsGetTime.Tables[0].Rows.Count < 1)
            {
                dtIrrEndTime.Value = Convert.ToDateTime("1899-12-30");
                dtOffLadleTime.Value = Convert.ToDateTime("1899-12-30");
            }
            else
            {
                dtIrrEndTime.Value = Convert.ToDateTime(dsGetTime.Tables[0].Rows[0]["Casting_Stop_Time"].ToString());
                dtOffLadleTime.Value = Convert.ToDateTime(dsGetTime.Tables[0].Rows[0]["Departure_Time"].ToString());
            }
        }

        //�����������
        private void GetMachineAge()
        {
            dsHistory.Tables[0].Clear();
            dsHistory.SourceMethod = "select * from (select * from CLadle_Use where LadleID = '" + strLadleID + "' order by Input_time desc) where rownum <2 ";
            dsHistory.L3DataAdapter = Adapter;
            dsHistory.L3DataAdapter = null;
            try
            {
                int iLadleAge = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Ladle_Age"].ToString()) + 1;
                int iFrame = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Frame"].ToString()) + 1;
                int iSplint = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Splint"].ToString()) + 1;
                int iSpringBox = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["SpringBox"].ToString()) + 1;
                int iJoint = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Joint"].ToString()) + 1;
                int iJointSafetyPin = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Joint_Safety_Pin"].ToString()) + 1;
                int iLongAxes = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Long_Axes"].ToString()) + 1;
                int iShortAxes = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Short_Axes"].ToString()) + 1;
                int iChassis = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Chassis"].ToString()) + 1;
                int iProtectBoard = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Protect_Board"].ToString()) + 1;
                int iUpTightenMachine = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Up_Tighten_Machine"].ToString()) + 1;
                int iBreatheBriUp = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Breathe_Bri_Up"].ToString()) + 1;
                int iBreatheBriLow = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Breathe_Bri_Low"].ToString()) + 1;
                int iWaterGap = Convert.ToInt16(dsHistory.Tables[0].Rows[0]["Water_Gap"].ToString()) + 1;

                txtLadleAge.Text = iLadleAge.ToString();
                txtFrame.Text = iFrame.ToString();
                txtSplint.Text = iSplint.ToString();
                txtSpringBox.Text = iSpringBox.ToString();
                txtJoint.Text = iJoint.ToString();
                txtJointSafetyPin.Text = iJointSafetyPin.ToString();
                txtLongAxes.Text = iLongAxes.ToString();
                txtShortAxes.Text = iShortAxes.ToString();
                txtChassis.Text = iChassis.ToString();
                txtProtectBoard.Text = iProtectBoard.ToString();
                txtWaterGap.Text = iWaterGap.ToString();

                if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_COM_50)//50t����ְ�
                {
                    txtBreatheBriUp.Text = iBreatheBriUp.ToString();
                    txtBreatheBriLow.Text = "0";
                }
                else if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_FIN_50)//50t�����ְ�
                {
                    txtBreatheBriUp.Text = iBreatheBriUp.ToString();
                    txtBreatheBriLow.Text = "0";
                }
                else if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_FIN_80)//80t�����ְ�
                {
                    txtUpTightenMachine.Text = iUpTightenMachine.ToString();
                    txtBreatheBriUp.Text = iBreatheBriUp.ToString();
                    txtBreatheBriLow.Text = iBreatheBriLow.ToString();
                }
                else
                {
                    MessageBox.Show("����û�ж���ְ����ͣ�", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                txtLadleAge.Text = "1";
                txtFrame.Text = "1";
                txtSplint.Text = "1";
                txtSpringBox.Text = "1";
                txtJoint.Text = "1";
                txtJointSafetyPin.Text = "1";
                txtLongAxes.Text = "1";
                txtShortAxes.Text = "1";
                txtChassis.Text = "1";
                txtProtectBoard.Text = "1";
                txtUpTightenMachine.Text = "1";
                txtWaterGap.Text = "1";

                if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_COM_50)//50t����ְ�
                {
                    txtUpTightenMachine.Text = "0";
                    txtBreatheBriUp.Text = "1";
                    txtBreatheBriLow.Text = "0";
                }
                else if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_FIN_50)//50t�����ְ�
                {
                    txtUpTightenMachine.Text = "0";
                    txtBreatheBriUp.Text = "1";
                    txtBreatheBriLow.Text = "0";
                }
                else if (strLadleType == CommDataMag.CommonData.LADLE_TYPE_FIN_80)//80t�����ְ�
                {
                    txtUpTightenMachine.Text = "1";
                    txtBreatheBriUp.Text = "1";
                    txtBreatheBriLow.Text = "1";
                }
            }
        }

        //�������2009-02-20�����շ��Ӽ���2009-03-03��
        //private void btnCalculate_Click(object sender, EventArgs e)
        //{
        //    double dStopTime = Math.Round((dtTapTime.Value.ToOADate() - dtIrrEndTime.Value.ToOADate()) * 24 * 60, 0);
        //    //double dStopTime = Math.Round((dtSeatOKTime.Value.ToOADate() - dtArriveTime.Value.ToOADate()) * 24 * 60, 0);
        //    txtStopTimeLen.Text = dStopTime.ToString();
        //    if (dStopTime > 24 * 60)
        //    {
        //        cmbLadleGrade.Text = "D";
        //        cmbLadleGrade_Act.Text = "D";
        //        return;
        //    }
        //    switch (strLadleType)
        //    {
        //        case CommDataMag.CommonData.LADLE_TYPE_COM_50:
        //            if (dStopTime <= 1.5 * 60)
        //            {
        //                cmbLadleGrade.Text = "A";
        //                cmbLadleGrade_Act.Text = "A";
        //            }
        //            else
        //                if ((1.5 * 60 < dStopTime) && (dStopTime <= 2.5 * 60))
        //                {
        //                    cmbLadleGrade.Text = "B";
        //                    cmbLadleGrade_Act.Text = "B";
        //                }
        //                else
        //                    if ((2.5 * 60 < dStopTime) && (dStopTime <= 4.5 * 60))
        //                    {
        //                        cmbLadleGrade.Text = "C";
        //                        cmbLadleGrade_Act.Text = "C";
        //                    }
        //                    else
        //                    {
        //                        cmbLadleGrade.Text = "D";
        //                        cmbLadleGrade_Act.Text = "D";
        //                    }
        //            break;

        //        case CommDataMag.CommonData.LADLE_TYPE_FIN_50:
        //            if (dStopTime <= 2.5 * 60)
        //            {
        //                cmbLadleGrade.Text = "A";
        //                cmbLadleGrade_Act.Text = "A";
        //            }
        //            else
        //                if ((2.5 * 60 < dStopTime) && (dStopTime <= 4.5 * 60))
        //                {
        //                    cmbLadleGrade.Text = "B";
        //                    cmbLadleGrade_Act.Text = "B";
        //                }
        //                else
        //                    if ((4.5 * 60 < dStopTime) && (dStopTime <= 6.5 * 60))
        //                    {
        //                        cmbLadleGrade.Text = "C";
        //                        cmbLadleGrade_Act.Text = "C";
        //                    }
        //                    else
        //                    {
        //                        cmbLadleGrade.Text = "D";
        //                        cmbLadleGrade_Act.Text = "D";
        //                    }

        //            break;

        //        case CommDataMag.CommonData.LADLE_TYPE_FIN_80:
        //            if (dStopTime <= 4 * 60)
        //            {
        //                cmbLadleGrade.Text = "A";
        //                cmbLadleGrade_Act.Text = "A";
        //            }
        //            else
        //                if ((4 * 60 < dStopTime) && (dStopTime <= 8 * 60))
        //                {
        //                    cmbLadleGrade.Text = "B";
        //                    cmbLadleGrade_Act.Text = "B";
        //                }
        //                else
        //                    if ((8 * 60 < dStopTime) && (dStopTime <= 12 * 60))
        //                    {
        //                        cmbLadleGrade.Text = "C";
        //                        cmbLadleGrade_Act.Text = "C";
        //                    }
        //                    else
        //                    {
        //                        cmbLadleGrade.Text = "D";
        //                        cmbLadleGrade_Act.Text = "D";
        //                    }
        //            break;
        //        default:
        //            cmbLadleGrade.Text = "D";
        //            cmbLadleGrade_Act.Text = "D";
        //            break;
        //    }
        //}

        //�������2009-02-20�����շ��Ӽ���2009-03-03��
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dStopTime = Math.Round((dtTapTime.Value.ToOADate() - dtIrrEndTime.Value.ToOADate()) * 24 * 60, 0);
           
            txtStopTimeLen.Text = dStopTime.ToString();
            int WallTemp = Convert.ToInt32("0" + txtWallTemp.Text);
           
            switch (strLadleType)
            {
                case CommDataMag.CommonData.LADLE_TYPE_COM_50:
                    if (dStopTime <= 1.5 * 60)
                    {
                        cmbLadleGrade.Text = "A";
                        cmbLadleGrade_Act.Text = "A";
                    }
                    else
                        if ((1.5 * 60 < dStopTime) && (dStopTime <= 2.5 * 60))
                        {
                            cmbLadleGrade.Text = "B";
                            cmbLadleGrade_Act.Text = "B";
                        }
                        else
                            if ((2.5 * 60 < dStopTime) && (dStopTime <= 4.5 * 60))
                            {
                                cmbLadleGrade.Text = "C";
                                cmbLadleGrade_Act.Text = "C";
                            }
                            else
                            {
                                cmbLadleGrade.Text = "D";
                                cmbLadleGrade_Act.Text = "D";
                            }
                    break;

                case CommDataMag.CommonData.LADLE_TYPE_FIN_50:
                    if (dStopTime <= 1.5 * 60 && pxComboBox1.Text == "")
                    {
                        cmbLadleGrade.Text = "A1";
                        cmbLadleGrade_Act.Text = "A1";
                        txtWallTemp.Enabled = false;
                        //txtWallTemp.ErropPr.ContainerControl = null;
                    }
                    else
                        if ((1.5 * 60 < dStopTime) && (dStopTime <= 2.5 * 60) && pxComboBox1.Text == "")
                        {
                            cmbLadleGrade.Text = "A2";
                            cmbLadleGrade_Act.Text = "A2";
                            txtWallTemp.Enabled = false;
                            //txtWallTemp.ErropPr.ContainerControl = null;
                        }
                        else
                            if ((2.5 * 60 < dStopTime) && (dStopTime <= 3.5 * 60) && pxComboBox1.Text == "")
                            {
                                cmbLadleGrade.Text = "B1";
                                cmbLadleGrade_Act.Text = "B1";
                                txtWallTemp.Enabled = false;
                                //txtWallTemp.ErropPr.ContainerControl = null;
                            }
                            else
                                if ((3.5 * 60 < dStopTime) && (dStopTime <= 4.5 * 60) && pxComboBox1.Text == "")
                                {
                                   
                                        cmbLadleGrade.Text = "B2";
                                        cmbLadleGrade_Act.Text = "B2";
                                        txtWallTemp.Enabled = false;
                                        //txtWallTemp.ErropPr.ContainerControl = null;
                                        //txtWallTemp.ErropPr.Clear();
                                    
                                   
                                }
                                else
                                    if (pxComboBox1.Text != ""  && (dStopTime <= 4.5 * 60))
                                    {
                                        cmbLadleGrade.Text = "B3";
                                        cmbLadleGrade_Act.Text = "B3";
                                        txtWallTemp.Enabled = false;
                                        //txtWallTemp.ErropPr.ContainerControl = null;
                                        //txtWallTemp.ErropPr.Clear();
                                    }
                                    else
                                        if ((4.5 * 60 < dStopTime) && (dStopTime <= 5.5 * 60) )
                                        {
                                            cmbLadleGrade.Text = "C1";
                                            cmbLadleGrade_Act.Text = "C1";
                                            if (WallTemp < 600 && WallTemp > 0)
                                            {
                                                cmbLadleGrade.Text = "D2";
                                                cmbLadleGrade_Act.Text = "D2";
                                            }
                                            txtWallTemp.Enabled = true;
                                            txtWallTemp.ErropPr = errorProvider1;
                                            errorProvider1.SetError(txtWallTemp, "�����");
                                            
                                            
                                        }
                                        else
                                            if ((5.5 * 60 < dStopTime) && (dStopTime <= 6.5 * 60) )
                                            {
                                                cmbLadleGrade.Text = "C2";
                                                cmbLadleGrade_Act.Text = "C2";
                                                if (WallTemp < 600 && WallTemp > 0)
                                                {
                                                    cmbLadleGrade.Text = "D2";
                                                    cmbLadleGrade_Act.Text = "D2";
                                                }
                                                txtWallTemp.Enabled = true;
                                                txtWallTemp.ErropPr = errorProvider1;
                                                errorProvider1.SetError(txtWallTemp, "�����");
                                               
                                            }
                                            else
                                                if (dStopTime > 12 * 60 )
                                                {
                                                    cmbLadleGrade.Text = "D1";
                                                    cmbLadleGrade_Act.Text = "D1";
                                                    if (WallTemp < 600 && WallTemp > 0)
                                                    {
                                                        cmbLadleGrade.Text = "D2";
                                                        cmbLadleGrade_Act.Text = "D2";
                                                    }
                                                    txtWallTemp.Enabled = true;
                                                    txtWallTemp.ErropPr = errorProvider1;
                                                    errorProvider1.SetError(txtWallTemp, "�����");
                                                   
                                                    //return;
                                                }

                                                //else if (WallTemp < 600)
                                                //{
                                                //    cmbLadleGrade.Text = "D2";
                                                //    cmbLadleGrade_Act.Text = "D2";
                                                  
                                                //}
                    break;
                case CommDataMag.CommonData.LADLE_TYPE_FIN_80:
                    if (dStopTime <= 2 * 60 && pxComboBox1.Text == "")
                    {
                        cmbLadleGrade.Text = "A1";
                        cmbLadleGrade_Act.Text = "A1";
                        txtWallTemp.Enabled = false;
                        //txtWallTemp.ErropPr.ContainerControl = null;
                    }
                    else if ((2 * 60 < dStopTime) && (dStopTime <= 4 * 60) && pxComboBox1.Text == "")
                    {
                        cmbLadleGrade.Text = "A2";
                        cmbLadleGrade_Act.Text = "A2";
                        txtWallTemp.Enabled = false;
                        //txtWallTemp.ErropPr.ContainerControl = null;
                    }
                    else
                        if ((4 * 60 < dStopTime) && (dStopTime <= 6 * 60) && pxComboBox1.Text == "")
                        {
                            
                            
                                cmbLadleGrade.Text = "B1";
                                cmbLadleGrade_Act.Text = "B1";
                                txtWallTemp.Enabled = false;
                           
                        
                        }
                        else
                            if ((6 * 60 < dStopTime) && (dStopTime <= 8 * 60) && pxComboBox1.Text == "")
                            {
                                
                                    cmbLadleGrade.Text = "B2";
                                    cmbLadleGrade_Act.Text = "B2";
                                    txtWallTemp.Enabled = false ;
                                    //txtWallTemp.ErropPr.Clear();
                                    //txtWallTemp.ErropPr.ContainerControl = null;
                                    
                                
                                
                            }
                            else
                                if (pxComboBox1.Text != "" && (dStopTime <= 8 * 60))
                                {
                                    cmbLadleGrade.Text = "B3";
                                    cmbLadleGrade_Act.Text = "B3";
                                    txtWallTemp.Enabled = false;
                                    //txtWallTemp.ErropPr.ContainerControl = null;
                                }
                                else
                                    if ((8 * 60 < dStopTime) && (dStopTime <= 10 * 60))
                                    {
                                        cmbLadleGrade.Text = "C1";
                                        cmbLadleGrade_Act.Text = "C1";
                                        if (WallTemp < 600 && WallTemp > 0)
                                        {
                                            cmbLadleGrade.Text = "D2";
                                            cmbLadleGrade_Act.Text = "D2";
                                        }
                                        txtWallTemp.Enabled = true;
                                        txtWallTemp.ErropPr = errorProvider1;
                                        errorProvider1.SetError(txtWallTemp, "�����");
                                        
                                    }
                                    else
                                        if ((10 * 60 < dStopTime) && (dStopTime <= 12 * 60) )
                                        {
                                            cmbLadleGrade.Text = "C2";
                                            cmbLadleGrade_Act.Text = "C2";
                                            if (WallTemp < 600 && WallTemp > 0)
                                            {
                                                cmbLadleGrade.Text = "D2";
                                                cmbLadleGrade_Act.Text = "D2";
                                            }
                                            txtWallTemp.Enabled = true;
                                            txtWallTemp.ErropPr = errorProvider1;
                                            errorProvider1.SetError(txtWallTemp, "�����");
                                           
                                        }
                                        else
                                            if (dStopTime > 12 * 60  )
                                            {
                                                cmbLadleGrade.Text = "D1";
                                                cmbLadleGrade_Act.Text = "D1";
                                                if (WallTemp < 600 && WallTemp > 0)
                                                {
                                                    cmbLadleGrade.Text = "D2";
                                                    cmbLadleGrade_Act.Text = "D2";
                                                }
                                                txtWallTemp.Enabled = true;
                                                txtWallTemp.ErropPr = errorProvider1;
                                                errorProvider1.SetError(txtWallTemp, "�����");
                                                
                                                
                                            }

                                            //else if (WallTemp < 600)
                                            //{
                                            //    cmbLadleGrade.Text = "D2";
                                            //    cmbLadleGrade_Act.Text = "D2";
                                                
                                            //}
                    break;
                
            }
        }

        private void pxControls_TextChangedFact(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1, 0);
        }

        //�ְ�������
        private void cmbLadleCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLadleCheck.SelectedValue == null)
                    return;
                if (cmbLadleCheck.SelectedValue != null)
                {
                    cmbOffReason.Text = "";//˦��ԭ��

                    if (rtxtNote.Text.Trim() == "")
                        rtxtNote.Text = cmbLadleCheck.Text;
                    else
                        rtxtNote.Text += "," + cmbLadleCheck.Text;
                }
            }
            catch { }
        }

        //�ְ��ⲿ���
        private void cmbLableOutCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLableOutCheck.SelectedValue == null)
                    return;
                if (cmbLableOutCheck.SelectedValue != null)
                {
                    cmbOffReason.Text = "";
                    if (rtxtNote.Text.Trim() == "")
                        rtxtNote.Text = cmbLableOutCheck.Text;
                    else
                        rtxtNote.Text += "," + cmbLableOutCheck.Text;

                }
            }
            catch
            {
            }
        }

        //˦��ԭ��
        private void cmbOffReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*****Modify By Huyunhai 2011-3-22****/

                if (cmbOffReason.SelectedValue == null)
                    return;
                if (cmbOffReason.SelectedValue != null)
                {
                   object d= cmbOffReason.SelectedValue;
                    cmbLadleCheck.Text = "";
                }
                /******Modify END******/
            }
            catch { }
        }

        //ѡ��ע2009-05-07
        private void cmbNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNote.Text == "")
                return;

            //2009-06-04
            cmbLadleGrade_Act.Text = "";

            if (rtxtNote.Text.Trim() == "")
                rtxtNote.Text = cmbNote.Text.Trim();
            else
                rtxtNote.Text += "," + cmbNote.Text;
        }

        private void txtWallTemp_TextChanged(object sender, EventArgs e)
        {
            txtWallTemp.EnableNull = true;
            int WallTemp = Convert.ToInt32("0" + txtWallTemp.Text);
            btnCalculate.PerformClick();

            if (WallTemp < 600 && WallTemp > 0)
                {
                    cmbLadleGrade.Text = "D2";
                    cmbLadleGrade_Act.Text = "D2";

                }
            
            
            
        }

        private void txtWallTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //����0~9����Ӧ��keycharΪ48~57��С������46��Backspace��8
            e.Handled = true;
            //����0-9��Backspace del ��Ч
            if ((e.KeyChar >= 47 && e.KeyChar <= 58) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                MessageBox.Show("���������֣�");
            if (e.KeyChar == 46)                       //С����      
            {
                if (textBox1.Text.Length <= 0)
                    e.Handled = true;           //С���㲻���ڵ�һλ      
                else
                {
                    float f;
                    if (float.TryParse(textBox1.Text + e.KeyChar.ToString(), out f))
                    {
                        e.Handled = false;
                    }
                }
            }

            //if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;
            //}
            //else
            //    MessageBox.Show("���������֣�");
        }


       



    }
}