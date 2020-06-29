using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BFMag
{
    public partial class IronMagFrm : DockContent, IMESForm
    {
        public IronMagFrm()
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
        private string strSort = "";

        //�ؼ�����
        private void IronMagFrm_Load(object sender, EventArgs e)
        {

        }
        
        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //��ȡ������κ�
            
            //���һ�����ݣ�����Ӧ���ݽ������
            DataRow newrow = dsBFIron.Tables[0].NewRow();
            dsBFIron.Tables[0].Rows.Add(newrow);

            bsBFIron.MoveLast();//����ƶ������һ��
            IronInfoFrm Frm = new IronInfoFrm();
            Frm.ShowDialogEx(Adapter.Session, strSort, bsBFIron.Position, ref dsBFIron);
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsBFIron.Position >= 0)
                bsBFIron.RemoveCurrent();
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsBFIron.EndEdit();
            object objDel = null;
            if (dsBFIron.CommitDeleted(ref objDel))
            {
                if (objDel != null && Convert.ToInt32(objDel) < 1)
                    MessageBox.Show("ɾ��ʧ��,��ˮ��ʹ�ã�", "��ʾ");
                else if (objDel != null && Convert.ToInt32(objDel) > 0)
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
            }
            dsBFIron.LoadData();
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBFIron.RejectChanges();
            dsBFIron.LoadData();
        }

        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //bsBFIron.Position = e.RowIndex;
            //IronInfoFrm Frm = new IronInfoFrm();
            //Frm.ShowDialogEx(Adapter.Session,strSort, bsBFIron.Position, ref dsBFIron);
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void IronMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //��¯ί�е�����
        private void btnBFSample_Click(object sender, EventArgs e)
        {
            IronSampleFrm Frm = new IronSampleFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }

        //����ί�е�
        private void btnDisSSample_Click(object sender, EventArgs e)
        {
            DeSIronSheetFrm Frm = new DeSIronSheetFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsBFIron.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        //�Ҽ��˵������ԣ��ɼ�&&��������
        private void dvM_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                menuGross.Enabled = false;
                menuTare.Enabled = false;
                menuToIron.Enabled = false;
                menuToNC.Enabled = false;
                return;
            }

            if (e.RowIndex >= 0)
                bsBFIron.Position = e.RowIndex;

            //ȥ���־
            string strDestination = dvM.Rows[bsBFIron.Position].Cells["Destination"].Value.ToString();
            //��ˮ״̬
            string strIronStatus = dvM.Rows[bsBFIron.Position].Cells["IronStatus"].Value.ToString();
            //�ɷֱ�־
            string strAnalysisFlag = dvM.Rows[bsBFIron.Position].Cells["AnalysisFlag"].Value.ToString();
            //Ƥ�ر�־
            string strTareFlag = dvM.Rows[bsBFIron.Position].Cells["TareFlag"].Value.ToString();
            //ë�ر�־
            string strGrossFlag = dvM.Rows[bsBFIron.Position].Cells["GrossFlag"].Value.ToString();
            //�ɷ��͵��ı�־
            string strIronConfirm = dvM.Rows[bsBFIron.Position].Cells["IronConfirm"].Value.ToString();
            //��ˮ��Դ
            string strSource = dvM.Rows[bsBFIron.Position].Cells["Source"].Value.ToString();

            /************* �趨Ƥ�� ***********************/
            //����ΪƤ�ر�־Ϊ0���Ѿ��趨ë�ص���ˮ
            if (strTareFlag != "0" && strGrossFlag == "1")
                menuTare.Enabled = false;// && menuTare.Visible;
            else
                menuTare.Enabled = true;//&& menuTare.Visible;
            /************* �趨Ƥ�� ***********************/

            /************* �趨ë�� ***********************/
            //����Ϊ��ˮ״̬Ϊδ����ȥ��Ϊδָ������ˮ��
            if (strGrossFlag == "0" && strIronStatus == "0" && strDestination == "0")
                menuGross.Enabled = true;// && menuGross.Visible;
            else
                menuGross.Enabled = false;// && menuGross.Visible;
            /************* �趨ë�� ***********************/

            /************* ָ��ȥ���� ***********************/
            //����:ָ��ȥ����,����Ϊ��ˮ״̬Ϊδ����ȥ��Ϊδָ������ˮ��AnalysisFlag���ɷֱ�־��=1��
            if (strAnalysisFlag == "1" && strIronStatus == "0" && strDestination == "0")
                menuToIron.Enabled = true;// && menuToIron.Visible;
            else
                menuToIron.Enabled = false;// && menuToIron.Visible;
            /************* ָ��ȥ���� ***********************/

            /************* ��ȥ���� ***********************/
            if (strIronStatus == "0" && strGrossFlag == "1")
                menuToSteelAgain.Enabled = true;
            else
                menuToSteelAgain.Enabled = false;
            /************* ��ȥ���� ***********************/

            /************* ָ���ϴ�NC ***********************/
            if (strIronConfirm == "1")
                menuToNC.Enabled = true;// && menuToNC.Visible;
            else
                menuToNC.Enabled = false;// && menuToNC.Visible;
            /************* ָ���ϴ�NC ***********************/

            /************* ����վ��ˮ ***********************/
            if ((strIronStatus == "0" || strIronStatus == "1") && strSource == "0")
                menuSoureS.Enabled = true;// && menuSoureS.Visible;
            else
                menuSoureS.Enabled = false;// && menuSoureS.Visible;
            /************* ����վ��ˮ ***********************/

            /************* ��¯��ˮ ***********************/
            if ((strIronStatus == "0" || strIronStatus == "1") && strSource == "1")
                menuSouresHF.Enabled = true;// && menuSouresHF.Visible;
            else
                menuSouresHF.Enabled = false;// && menuSouresHF.Visible;
            /************* ��¯��ˮ ***********************/
        }

        //ë��
        private void menuGross_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronGrossFrm frm = new IronGrossFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
             //   dsBFIron.LoadData();
            }
            catch { }
        }

        //Ƥ��
        private void menuTare_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronTareFrm frm = new IronTareFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //ȥ����
        private void menuToIron_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronNetWeightFrm frm = new IronNetWeightFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //��ȥ����
        private void menuToSteelAgain_Click(object sender, EventArgs e)
        {
            try
            {
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells["MaterialID"].Value.ToString();
                DataSet dsSend = dsBFIron.Clone();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Destination"] = 1 ;//������2009-04-05��
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                cmdDesignatePath.Parameters[0].SourceObject = dsSend;
                if (cmdDesignatePath.Execute() >= 0)
                {
                    int iRet = (int)cmdDesignatePath.Command.Return;
                    if (iRet > 0)
                        MessageBox.Show("ָ���ɹ���", "��ʾ");
                    else
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                }
                else
                    MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //�ϴ�NC
        private void menuToNC_Click(object sender, EventArgs e)
        {
            try
            {
                string strTapNo = dvM.Rows[bsBFIron.Position].Cells[TAP_No.Index].Value.ToString();
                if (strTapNo == "")
                    return;

                string strMessage = MessageBox.Show("�Ƿ�ȷ���ϴ�NC��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strMessage != "Yes")
                    return;
                cmdSendIronDataToNC.Parameters[0].ConstantValue = strTapNo;
                

                //dsBFIron.LoadData();
            }
            catch { }
        }

        //����վ��ˮ
        private void menuSoureS_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Source"] = 1;
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                cmdModifySource.Parameters[0].SourceObject = dsSend;
                if (cmdModifySource.Execute() >= 0)
                {
                    //string strErrorCode = "0x" + string.Format("{0:X}", cmdModifySource.Command.ErrorCode);
                    //string Desc = CommDataMag.CommonMethed.GetErrorDescByErrorCode(Adapter, strErrorCode, "AppServer");
                    int iRet = Convert.ToInt32(cmdModifySource.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("ָ���ɹ���", "��ʾ");
                    else
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");

                }
                else
                    MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                //dsBFIron.LoadData();

            }
            catch { }
        }

        //��¯��ˮ
        private void menuSouresHF_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Source"] = 0;
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                cmdModifySource.Parameters[0].SourceObject = dsSend;
                if (cmdModifySource.Execute() >= 0)
                {
                    //string strErrorCode = cmdModifySource.Command.ErrorCode.ToString();
                    //string.Format("{0:X}", cmdFeedIrons.Command.ErrorCode));
                    int iRet = Convert.ToInt32(cmdModifySource.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("ָ���ɹ���","��ʾ");
                    else
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");

                }
                else
                    MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //������ɫ
        private void dvM_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
            string strIronStatus = dvM.Rows[e.RowIndex].Cells[IronStatus.Index].Value.ToString();
            switch (strIronStatus)
            {
                case "5":
                    //dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Control;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGreen;
                    break;
                case "1":
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Orange;
                    //dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Blue;
                    break;
                case "2":
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                    break;
                default:
                    break;
            }
        }

        //
        private void dvM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }


        //������ί�е�
        private void btnIronSlagSample_Click(object sender, EventArgs e)
        {
            IronSlagApplyFrm Frm = new IronSlagApplyFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }
        //���·���ί�е�
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            reSendApply Frm = new reSendApply();
            Frm.ShowDialogEx(Adapter.Session);
          
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ModifyIronTime Frm = new ModifyIronTime();
            Frm.ShowDialogEx(Adapter.Session);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ModifyIronWeight Frm = new ModifyIronWeight();
            Frm.ShowDialogEx(Adapter.Session);
        }



        ////ָ��ȥ��
        //private void menu_AssignDire_Click(object sender, EventArgs e)
        //{
        //    if (bsBFIron.Position < 0)
        //        return;

        //    if (sender.GetType().Name != "ToolStripMenuItem")
        //        return;

        //    ToolStripMenuItem menuSend = (ToolStripMenuItem)sender;
        //    if (menuSend.Tag.ToString() == "")
        //        return;

        //    try
        //    {
        //        if (sender.Equals(btnIron) || sender.Equals(menuIron))
        //        {
        //            float fNetwt = float.Parse(dvM.Rows[bsBFIron.Position].Cells[Net_Weight.Index].Value.ToString());
        //            if (fNetwt <= 0)
        //            {
        //                MessageBox.Show("���ر������\"0\"", "��ʾ");
        //                return;
        //            }
        //        }

        //        string strMaterialID = dvM.Rows[bsBFIron.Position].Cells["MaterialID"].Value.ToString();
        //        DataSet dsSend = dsBFIron.Clone();
        //        DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
        //        foreach (DataRow dr in drArray)
        //        {
        //            dr["Destination"] = menuSend.Tag.ToString(); ;//������2009-04-05��
        //            dsSend.Tables[0].ImportRow(dr);
        //        }
        //        dsSend.AcceptChanges();
        //        cmdDesignatePath.Parameters[0].SourceObject = dsSend;
        //        if (cmdDesignatePath.Execute() >= 0)
        //        {
        //            int iRet = (int)cmdDesignatePath.Command.Return;
        //            if (iRet > 0)
        //                MessageBox.Show("ָ���ɹ���", "��ʾ");
        //            else
        //                MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
        //        }
        //        else
        //            MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
        //        dsBFIron.LoadData();
        //    }
        //    catch { }
        //}

    }
}