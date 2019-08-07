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
    public partial class MoldBoardInstallMagFrm : DockContent, IMESForm
    {
        public MoldBoardInstallMagFrm()
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

        private MoldBoardInstallMagShowFrm Frm = new MoldBoardInstallMagShowFrm();

        //�ؼ�����
        private void MoldBoardInstallMagFrm_Load(object sender, EventArgs e)
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

                DataRow newrow = dsInstall.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["Install_Date"] = DateTime.Now.Date;
                newrow["Hit_Press_Flag"] = 1;
                newrow["Rep_Count"] = 0;
                newrow["Lug_Steel_Mea"] = 0;
                newrow["Repair_Start_Time"] = DateTime.Now;
                newrow["Repair_End_Time"] = DateTime.Now;
               
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsInstall.Tables[0].Rows.Add(newrow);
                bsInstall.MoveFirst();
                while (((System.Data.DataRowView)(bsInstall.Current)).Row != newrow && bsInstall.Position != dsInstall.Tables[0].Rows.Count - 1)
                {
                    bsInstall.MoveNext();
                }
                Frm.ShowDialogEx(Adapter.Session, strSort, bsInstall.Position, ref dsInstall);
            }
            catch { }
        }

        //�޸���Ϣ
        private void dvInstall_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsInstall.Tables[0].Rows.Count > 0)
            {
                Frm.ShowDialogEx(Adapter.Session, strSort, bsInstall.Position, ref dsInstall );
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsInstall.Position>=0)
            {
                bsInstall.RemoveCurrent();
            }
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvInstall.EndEdit();
            bsInstall.EndEdit();
            //bool bAdd = false;
            bool bMod = false;
            bool bDel = false;
            object objAdd = null;
            object objMod = null;
            object objDel = null;
            if (dsInstall.CommitAdded(ref objAdd))
            {
                if (objAdd.ToString() == "-1")
                {
                    MessageBox.Show("�ᾧ��Ϊ�ջ��Ҳ�����Ӧ��װ���ţ�", "��ʾ");
                    return;
                }
                if (objAdd.ToString() == "-3")
                {
                    MessageBox.Show("�Ѿ����ڵ�ǰ�ᾧ��ͭ���װ���¼��������������", "��ʾ");
                    return;
                }
                //bAdd = true;
            }
            if (dsInstall.CommitModified(ref objMod))
            {
                if (objMod.ToString() == "1")
                    bMod = true;
            }
            if (dsInstall.CommitDeleted(ref objDel))
            {
                if (objDel.ToString() == "1")
                    bDel = true;
            }
            if ((objMod == null || bMod == true) && (objDel == null || bDel == true))
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsInstall.LoadData();
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            }
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsInstall.LoadData();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
           
            if (cmbMoldID.Text.ToString() != "")
                strSql += " and MoldID = '" + cmbMoldID.Text + "'"; 
            
            if (cmbFac.Text != "")
                strSql += " and COPPER_FAC = '" + cmbFac.Text + "'";
          
            strSql += " order by Input_Time desc,MoldID asc";
           
            cmdInstall.Parameters[0].ConstantValue = strSql;
            dsInstall.LoadData();
        }

        private void dvInstall_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsInstall.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ᾧ��ͭ��װ��ʵ��", dvInstall);
        }

        private void MoldBoardInstallMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvInstall_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}