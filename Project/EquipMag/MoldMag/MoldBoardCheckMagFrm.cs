using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.MoldMag
{
    public partial class MoldBoardCheckMagFrm : DockContent, IMESForm
    {
        public MoldBoardCheckMagFrm()
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

        //private string strMoldID = "";
        private string strSql = "";
        private string strSort = "";

        private object objShiftID = "";
        private object objTeamID = "";

        private MoldBoardCheckMagShowFrm Frm = new MoldBoardCheckMagShowFrm();

        //�ؼ�����
        private void MoldBoardCheckMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbMoldID.Items.Clear();
            cmbMoldID.Items.Add("");
            if (dsMoldID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsMoldID.Tables[0].Rows.Count; i++)
                {
                    cmbMoldID.Items.Add(dsMoldID.Tables[0].Rows[i][0].ToString());
                }
            }

            cmbFac.Items.Clear();
            cmbFac.Items.Add("");
            if (dsCopperFac.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsCopperFac.Tables[0].Rows.Count; i++)
                {
                    cmbFac.Items.Add(dsCopperFac.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

                DataRow newrow = dsCheck.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["Install_Date"] = DateTime.Now.Date;
                newrow["CHECK_DATE"] = DateTime.Now.Date;
                newrow["Hit_Press_Flag"] = 1;
                newrow["Rep_Count"] = 0;
                newrow["Lug_Steel_Mea"] = 0;
                //newrow["Repair_Start_Time"] = DateTime.Now;
                //newrow["Repair_End_Time"] = DateTime.Now;
               
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsCheck.Tables[0].Rows.Add(newrow);
                bsCheck.MoveFirst();
                while (((System.Data.DataRowView)(bsCheck.Current)).Row != newrow && bsCheck.Position != dsCheck.Tables[0].Rows.Count - 1)
                {
                    bsCheck.MoveNext();
                }
                Frm.ShowDialogEx(Adapter.Session, strSort, bsCheck.Position, ref dsCheck);
            }
            catch { }
        }

        //�޸���Ϣ
        private void dvInstall_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsCheck.Tables[0].Rows.Count > 0)
            {
                Frm.ShowDialogEx(Adapter.Session, strSort, bsCheck.Position, ref dsCheck );
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCheck.Position>=0)
            {
                bsCheck.RemoveCurrent();
            }
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCheck.EndEdit();
            bsCheck.EndEdit();
            //bool bAdd = false;
            
            if (dsCheck.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsCheck.LoadData();
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            }
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsCheck.LoadData();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsCheck.SourceCondition = "";
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strSql = "Input_Time between '" + dtS + "' and '" + dtE + "'";
           
            if (cmbMoldID.Text.ToString() != "")
                strSql += " and MoldID = '" + cmbMoldID.Text + "'"; 
            
            if (cmbFac.Text != "")
                strSql += " and COPPER_FAC = '" + cmbFac.Text + "'";
          
            strSql += " order by Input_Time desc,MoldID asc";

            dsCheck.SourceCondition = strSql;
            dsCheck.LoadData();
        }

        private void dvInstall_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsCheck.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ᾧ��ͭ����ʵ��", dvCheck);
        }

        private void MoldBoardCheckMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvInstall_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}