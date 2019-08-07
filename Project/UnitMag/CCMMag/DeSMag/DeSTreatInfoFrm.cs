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

                //设置各DataSet的SourceCondition
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
                MessageBox.Show("保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("保存失败！", "警告");
            }
        }

        //基本数据
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

        //脱硫数据
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

        //状态数据
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

        //实时数据
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
            //如果实际尚未锁定并且可以维护实绩
            if (UnLock && check)
            {
                //基本数据
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

                //脱硫数据
                FLPProcess.Visible = true;
                btnProcessConfirm.Visible = true;
                btnProcessCancel.Visible = true;
                //状态数据
                fLPStatus.Visible = true;
                btnStatusConfirm.Visible = true;
                btnStatusCancel.Visible = true;
                //实时数据
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