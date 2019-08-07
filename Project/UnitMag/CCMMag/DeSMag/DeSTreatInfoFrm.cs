using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace UnitMag.DeSMag
{
    public partial class DeSTreatInfoFrm : Form
    {
        public DeSTreatInfoFrm()
        {
            InitializeComponent();
        }

        private bool UnLock = false;
        private bool check = false;
        private string strCurMaterialID = "";
        private bool bOperation = false;

        public void ShowDialogEx(AppSvrIF.Session session, bool bLocked, bool CheckFlag, string strMaterialID)
        {
            try
            {
                UnLock = !bLocked;
                check = CheckFlag;
                strCurMaterialID = strMaterialID;
                txtMaterialID.Text = strCurMaterialID;

                //���ø�DataSet��SourceCondition
                //dsBase
                dsBase.SourceCondition = "MaterialID = '" + strMaterialID + "'";

                dsddd.SourceCondition = "MaterialID = '" + strMaterialID + "'";
                //dsProcess
                dsProcess.SourceCondition = "MaterialID = '" + strMaterialID + "' order by TreatNo";
                //dsStatus
                dsStatus.SourceCondition = "ID_Object = '" + strMaterialID + "' order by Change_Time desc";
                //dsRunTime
                dsRunTime.SourceCondition = "substr(ID_Object,1,11) = '" + strMaterialID + "' order by TreatNo";



                this.Adapter.Session = session;
                if (dsddd.Tables[0].Rows.Count > 0)
                {
                    int tempt = 0;
                    for (int i = 0; i < dsddd.Tables[0].Rows.Count; i++)
                    {
                        tempt += Convert.ToInt32(dsddd.Tables[0].Rows[i]["BLOWTIME"]);
                    }
                    txtBlowTimeTotal.Text = tempt.ToString();
                }
                else
                    txtBlowTimeTotal.Text = "0";

                Adapter.RefreshDataBindings();

                this.ShowDialog();
            }
            catch { }
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

        //��������
        private void btnProcessConfirm_Click(object sender, EventArgs e)
        {
            dvProcess.EndEdit();
            bsProcess.EndEdit();
            bOperation = dsProcess.UpdateData();
            MessageShowOperation();
            dsProcess.LoadData();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
        }

        //״̬����
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

        //ʵʱ����
        private void btnRunTimeConfirm_Click(object sender, EventArgs e)
        {
            dvRunTime.EndEdit();
            bsRunTime.EndEdit();
            bOperation = dsRunTime.UpdateData();
            MessageShowOperation();
            dsRunTime.LoadData();
        }

        private void btnRunTimeCancel_Click(object sender, EventArgs e)
        {
            dsRunTime.LoadData();
        }

        private void DeSTreatInfoFrm_Load(object sender, EventArgs e)
        {
            dvProcess.ReadOnly = false;
            dvProcess.Enabled = true;
            //���ʵ����δ�������ҿ���ά��ʵ��
            if (UnLock && check)
            {
                //��������
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

                //��������
                FLPProcess.Visible = true;
                btnProcessConfirm.Visible = true;
                btnProcessCancel.Visible = true;
                //״̬����
                fLPStatus.Visible = true;
                btnStatusConfirm.Visible = true;
                btnStatusCancel.Visible = true;
                //ʵʱ����
                fLPRunTime.Visible = true;
                btnRunTimeConfirm.Visible = true;
                btnRunTimeCancel.Visible = true;
            }
            else
            {
                FLPProcess.Visible = false;
                btnProcessConfirm.Visible = false;
                fLPStatus.Visible = false;
                btnStatusConfirm.Visible = false;
                fLPRunTime.Visible = false;
                btnRunTimeConfirm.Visible = false;
                if (!UnLock)
                {
                    fLPBase.Visible = UnLock;
                    btnBaseConfirm.Visible = UnLock;
                }
            }
        }

        private void txtMaterialID_TextChanged(object sender, EventArgs e)
        {
            //if (dsddd.Tables[0].Rows.Count > 0)
            //{
            //    int tempt = 0;
            //    for (int i = 0; i < dsddd.Tables[0].Rows.Count; i++)
            //    {
            //        tempt += Convert.ToInt32(dsddd.Tables[0].Rows[i]["BLOWTIME"]);
            //    }
            //    txtBlowTimeTotal.Text = tempt.ToString();
            //}
            //else
            //    txtBlowTimeTotal.Text = "0";
        }

       
    }
}