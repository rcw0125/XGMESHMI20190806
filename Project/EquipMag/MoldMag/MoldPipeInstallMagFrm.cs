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
    public partial class MoldPipeInstallMagFrm : DockContent, IMESForm
    {
        public MoldPipeInstallMagFrm()
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

        private string strCurSql = "";
        private object objShiftID = "";
        private object objTeamID = "";
        private string strSort = "";

        private MoldPipeInstallMagShowFrm frm = new MoldPipeInstallMagShowFrm();

        //�ؼ�����
        private void MoldPipeInstallMagFrm_Load(object sender, EventArgs e)
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
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsM.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["Install_Date"] = DateTime.Now;
              
                newrow["Repair_Start_Time"] = DateTime.Now;
                newrow["Repair_End_Time"] = DateTime.Now;
                newrow["Repair_Content"] = "";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();//
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }

                frm.ShowDialogEx(Adapter.Session, strSort, bsM.Position, ref dsM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸���Ϣ
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsM.Tables[0].Rows.Count > 0)
            {
                bsM.Position = e.RowIndex;
                frm.ShowDialogEx(Adapter.Session,  strSort,bsM.Position, ref dsM);
            }
        }


        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position >= 0)
            {
                bsM.RemoveCurrent();
            }
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsM.EndEdit();
            //bool bAdd = false;
            bool bMod = false;
            bool bDel = false;
            object objAdd = null;
            object objMod = null;
            object objDel = null;
            if (dsM.CommitAdded(ref objAdd))
            {
                if (objAdd.ToString() == "-1")
                {
                    MessageBox.Show("�ᾧ��Ϊ�ջ��Ҳ�����Ӧ��װ���ţ�", "��ʾ");
                    return;
                }
                if (objAdd.ToString() == "-3")
                {
                    MessageBox.Show("�Ѿ����ڵ�ǰ�ᾧ��ͭ�ܵ�װ���¼��������������", "��ʾ");
                    return;
                }
                //bAdd = true;
            }
            if (dsM.CommitModified(ref objMod))
            {
                if (objMod.ToString() == "1")
                    bMod = true;
            }
            if (dsM.CommitDeleted(ref objDel))
            {
                if (objDel.ToString() == "1")
                    bDel = true;
            }
            if ((objMod == null || bMod == true) && (objDel == null || bDel == true))
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                FormQueryString();
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            }
        }

        //��ѯ
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
          
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            
            if (cmbMoldID.Text != "")
                strCurSql += " and MOLDID = '" + cmbMoldID.Text + "'";
           
            if(cmbFac.Text!="")
                strCurSql += " and COPPER_FAC = '" + cmbFac.Text + "'";
          
            strCurSql += " order by Input_Time desc,MoldID asc";
          
            cmdM.Parameters[0].ConstantValue = strCurSql;
            dsM.LoadData();
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�ᾧ��ͭ��װ��ʵ��", dvM);
        }

        private void MoldPipeInstallMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}