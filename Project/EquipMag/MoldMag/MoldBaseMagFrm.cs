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
    public partial class MoldBaseMagFrm : DockContent, IMESForm
    {
        public MoldBaseMagFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

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


        //控件加载
        private void MoldBaseMagFrm_Load(object sender, EventArgs e)
        {
            cmdInstallStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_WAIT + "'";
            cmdInstallEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_REPAIR + "'";
            cmdOn.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_FREE + "'";

            cmdOffToBuild.Parameters[0].SourceFilter =
                "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_USE + "' and (Break_Face_Mea = 6 or Break_Face_Mea = 9 or Break_Face_Mea = 8 or Break_Face_Mea = 16 or Break_Face_Mea = 18) ";//modify by hyh  2012=-06-15

            cmdOff.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_USE + "' and Break_Face_Mea = 12";
            cmdCold.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_OFFLINE + "' and Break_Face_Mea = 12";
            cmdBuild.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_OFFLINE + "'  and Break_Face_Mea = 12";

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //装配开始
        private void btnInstallStrat_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdInstallStart))
            {
                cmdInstallStart.Execute();
            }
        }

        //装配结束
        private void btnInstallEnd_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdInstallEnd))
            {
                cmdInstallEnd.Execute();
            }
        }

        //换上[20081230Liao]
        private void btnOn_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();


            DataRow[] dr = dsMold.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_FREE + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("请选择一个\"状态为备用\"的结晶器", "提示", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("请\"只选择一个\"状态为备用的结晶器", "提示", MessageBoxButtons.OK);
                return;
            }
            string strMoldID = dr[0]["MoldID"].ToString();
            string strCCMID = dr[0]["UnitID"].ToString();
            int iFaceMea = Convert.ToInt16(dr[0]["Break_Face_Mea"]);

            MoldOnLineFrm Frm = new MoldOnLineFrm();
            Frm.ShowDialogEx(Adapter.Session, iFaceMea, strMoldID, strCCMID);
            GC.Collect();
        }

        //换下
        private void btnOff_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdOff))
            {
                string strShow = "";
                for (int i = 0; i < ((DataSet)(cmdOff.Parameters[0].Value)).Tables[0].Rows.Count; i++)
                {
                    strShow += ((DataSet)(cmdOff.Parameters[0].Value)).Tables[0].Rows[i]["MoldID"].ToString() + "\"";
                }
                if (MessageBox.Show("确认\"" + strShow + "结晶器结晶器下线检测？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                    cmdOff.Execute();
            }
        }

        //判断执行Cmd时是否有记录
        private bool JudgeValueRowCount(AppSvrHMI.L3Command cmd)
        {
            DataSet dsJudge = (DataSet)(cmd.Parameters[0].Value);
            if (dsJudge == null || dsJudge.Tables[0].Rows.Count < 1)
            {
                return false;
            }
            return true;
        }

        private void btnCold_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdCold))
            {
                cmdCold.Execute();
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdBuild))
            {
                cmdBuild.Execute();
            }
        }

        //1、2、3、4#铸机结晶器铜管下线待装
        private void btnOffToBuild_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            if (JudgeValueRowCount(cmdOffToBuild))
            {
                string strShow = "";
                for (int i = 0; i < ((DataSet)(cmdOffToBuild.Parameters[0].Value)).Tables[0].Rows.Count; i++)
                {
                    strShow += ((DataSet)(cmdOffToBuild.Parameters[0].Value)).Tables[0].Rows[i]["MoldID"].ToString() + "\"";
                }
                if (MessageBox.Show("确认\"" + strShow + "结晶器结晶器下线待装？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                    cmdOffToBuild.Execute();
            }
        }

        //数据完成邦定设置颜色
        private void dvMold_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //待装
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMold, "MoldID",
                "Status", CommDataMag.CommonData.CMOLD_STATUS_WAIT, SystemColors.Control, Color.Blue);

            //装配
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMold, "MoldID",
                "Status", CommDataMag.CommonData.CMOLD_STATUS_REPAIR, Color.DarkOrange, Color.Blue);

            //冷备
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMold, "MoldID",
                "Status", CommDataMag.CommonData.CMOLD_STATUS_FREE, Color.LightSeaGreen, Color.Yellow);

            //在线使用
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMold, "MoldID",
                "Status", CommDataMag.CommonData.CMOLD_STATUS_USE, Color.Red, Color.Blue);
           
            //下线检测
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMold, "MoldID",
                "Status", CommDataMag.CommonData.CMOLD_STATUS_OFFLINE, Color.Yellow, Color.Blue);

        }

        private void MoldBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvMold_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //换流别
        private void btnChangeFlowID_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();

            DataRow[] dr = dsMold.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_USE + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("请选择一个\"状态为在用\"的结晶器", "提示", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("请\"只选择一个\"状态为在用的结晶器", "提示", MessageBoxButtons.OK);
                return;
            }
            string strMoldID = dr[0]["MoldID"].ToString();
            string strCCMID = dr[0]["Cast_ID"].ToString();
            //int iFaceMea = Convert.ToInt16(dr[0]["Break_Face_Mea"]);

            ChangeFlowIDFrm Frm = new ChangeFlowIDFrm();
            if (Frm.ShowDialogEx(Adapter.Session, strMoldID, strCCMID) != DialogResult.OK)
                return;
            if (Frm.FlowID != "")
            {
                cmdChangeFlowID.Parameters[0].ConstantValue = strMoldID;
                cmdChangeFlowID.Parameters[1].ConstantValue = Frm.FlowID;
                if (cmdChangeFlowID.Execute() >= 0)
                {
                    string strShow = "";
                    int iRet = Convert.ToInt32(cmdChangeFlowID.Command.Return);
                    if (iRet <= 0)
                    {
                        switch (iRet)
                        {
                            case -1:
                                strShow = "没有断面尺寸或没有装配编号或则新流别和原流别相同！";
                                break;
                            case -2:
                                strShow = "当前不允许换流别，原因是所选流别上已经存在结晶器！";
                                break;
                            default:
                                break;
                        }
                        MessageBox.Show(strShow, "提示");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoldAddShowFrm frm = new MoldAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dvMold.EndEdit();
            bsMold.EndEdit();
            DataRow[] drArray = dsMold.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CMOLD_STATUS_WAIT + "'");
            if (drArray.Length < 1)
            {
                MessageBox.Show("请选择状态为\"待装\"的结晶器", "提示", MessageBoxButtons.OK);
                return;
            }
            string strMessage = "";
            for (int i = dsMold.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                if (dsMold.Tables[0].Rows[i]["CheckFlag"].ToString() == "1" && dsMold.Tables[0].Rows[i]["Status"].ToString() == "01")
                {
                    strMessage += dsMold.Tables[0].Rows[i]["MoldID"].ToString() + ",";
                    //dsMain.Tables[0].Rows.RemoveAt(i);
                }
            }
            strMessage = strMessage.Substring(0, strMessage.Length - 1);
            string deleteConfirm = MessageBox.Show("确认要删除" + strMessage + "号结晶器么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            for (int i = dvMold.RowCount - 1; i >= 0; i--)
            {
                if (dvMold.Rows[i].Cells["checkFlagDataGridViewTextBoxColumn"].Value.ToString() == "1" && dvMold.Rows[i].Cells["Status"].Value.ToString() == "01")
                {
                    bsMold.RemoveAt(i);
                }
            }
            object objDel = null;
            dsMold.CommitDeleted(ref objDel);
            if (objDel == null)
                MessageBox.Show("删除失败！", "提示");
            else
                MessageBox.Show("成功删除" + objDel + "条记录！", "提示");
            dsMold.LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //AppSvrHMI.L3DataSet ds = new AppSvrHMI.L3DataSet();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("PLC_Address");
            //dt.Columns.Add("Amount");
            //dt.Columns.Add("Discharge_Time");
            //dt.Columns.Add("PERMIT_DELETE_FLAG");
            
          
            //ds.Tables.Add(dt);
            //DataRow dr = ds.Tables[0].NewRow();
            //string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //dr[0] = "1"; dr[1] = "LF_004_LFAddition_Store01"; dr[2] = dateTime; dr[3] = "1";
            //ds.Tables[0].Rows.Add(dr);

            //cmdTest.Parameters[0].SourceObject = ds; cmdTest.Parameters[0].SourceProperty = "Table1";
            //cmdTest.Execute();


        }

     

    }
}