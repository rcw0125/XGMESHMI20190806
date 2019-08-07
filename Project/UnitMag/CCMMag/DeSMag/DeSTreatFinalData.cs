using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.DeSMag
{
    public partial class DeSTreatFinalData : DockContent, IMESForm
    {
        public DeSTreatFinalData()
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

        private void DeSTreatFinalData_Load(object sender, EventArgs e)
        {
            dtData.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtTAPNo.Text != "")
            {
                dsDeSInfo.SourceCondition = "TAP_No = '" + txtTAPNo.Text.Trim()+ "'";
            }
            else
            {
                dsDeSInfo.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by ProductionDate";
            }
            dsDeSInfo.LoadData();
        }

        //�޸�
        private void dvDeSData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string MaterialID = dvDeSData.Rows[e.RowIndex].Cells[0].Value.ToString();
                bool check = false;
                bool bLocked = false;

                //����ά��
                if (cxCheckFlag.Checked)
                    check = true;

                //ʵ��������־
                if (Convert.ToBoolean(dvDeSData.Rows[e.RowIndex].Cells["Locked"].Value))
                    bLocked = true;

                DeSTreatInfoFrm frmDeSTreatInfoFrm = new DeSTreatInfoFrm();
                frmDeSTreatInfoFrm.ShowDialogEx(Adapter.Session, bLocked, check, MaterialID);
                GC.Collect();
            }
            catch { }
        }

        //ʵ��ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sRet = "";
            try
            {
                string MaterialID = dvDeSData.CurrentRow.Cells[0].Value.ToString();
                string strYesNo = MessageBox.Show("ȷ�����ϱ�ʶΪ:\"" + MaterialID + "\"��ʵ����", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo == "Yes")
                {
                    cmdConfirm.Parameters[0].ConstantValue = MaterialID;
                    if (cmdConfirm.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdConfirm.Command.Return);
                        if (sRet == "0")
                            MessageBox.Show("ȷ�ϳɹ���", "��ʾ");
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("ȷ��ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("ȷ��ʧ�ܣ�", "��ʾ");
                }
                dsDeSInfo.LoadData();
            }
            catch { }
        }

        private void dvDeSData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvDeSData, "MaterialID", "Locked", "1");
        }
    }
}