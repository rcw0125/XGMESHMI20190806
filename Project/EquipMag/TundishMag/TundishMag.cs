using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.TundishMag
{
    public partial class TundishMag : DockContent, IMESForm
    {
        public TundishMag()
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
         
        private string strcmbTundishID = "";//缓存ComboBox选择查询中包号
        private string strCurSQLMag = "";//缓存履历查询SourceCondition
        
        private string strCurTundishID = "";//缓存当前履历中选中中包号
        private string strCurInnerID = "";//缓存当前履历中选中永久层编号
        private string strCurWorkId = "";//缓存当前履历选中工作层编号
        private string strCurTundishNO = "";//缓存当前履历包次号

        private bool bLock = false;//标记当前选中履历是否被锁定/*2009-03-01*/

        //窗体加载
        private void TundishMag_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-3);
            dtEnd.Value = DateTime.Now;
            tsCmbTundishID.Items.Clear();
            tsCmbTundishID.Items.Add("");
            for (int iIDRow = 0; iIDRow < dsTundishID.Tables[0].Rows.Count; iIDRow++)
            {
                tsCmbTundishID.Items.Add(dsTundishID.Tables[0].Rows[iIDRow][0].ToString());
            }
            L3DataSetSourceCondition();
            //获取权限
            //设置Adapter
            
            uint uRight = Adapter.Session.GetResourceRights("Administrator");
            //if (uRight & (AppSvrIF.AccessRight.read | AppSvrIF.AccessRight.write | AppSvrIF.AccessRight.execute))
            //{   //有权限
                dsInnerBuild.L3DataAdapter = Adapter;
                dsInnerFire.L3DataAdapter = Adapter;
                dsDaub.L3DataAdapter = Adapter;
                dsOTFireInfo.L3DataAdapter = Adapter;
                dsTFFFireInfo.L3DataAdapter = Adapter;
                dsOTInstall.L3DataAdapter = Adapter;
                dsTFFInstall.L3DataAdapter = Adapter;

                dsRefraOT.L3DataAdapter = Adapter;
                dsRefraTFF.L3DataAdapter = Adapter;
            //}
            //else
            //{   //无权限
            //}
                
            //检查tab可用性
            //[20081229Liao]
            TabEnableSet();
        }

        //履历换行
        private void bsMag_CurrentChanged(object sender, EventArgs e)
        {
            //检查各个ds是否改变,提示保存
            try
            {
                DetailJudge();
                if (dsMag == null || dsMag.Tables[0].Rows.Count < 1)
                {
                    strCurTundishID = "";
                    strCurInnerID = "";
                    strCurWorkId = "";
                }
                else
                {
                    int iMagIndex = dsMag.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsMag.Current)).Row);
                    try
                    {
                        bLock = Convert.ToBoolean(dvMag.Rows[iMagIndex].Cells["ConfirmFlag"].Value);
                    }
                    catch{ bLock = false; }

                    if (bLock)
                        btnSave.Visible = false;
                    else
                        btnSave.Visible = true;

                    strCurTundishID = dsMag.Tables[0].Rows[iMagIndex]["TundishID"].ToString();
                    strCurInnerID = dsMag.Tables[0].Rows[iMagIndex]["InnerID"].ToString();
                    strCurWorkId = dsMag.Tables[0].Rows[iMagIndex]["WorkID"].ToString();
                    strCurTundishNO = dsMag.Tables[0].Rows[iMagIndex]["TundishNO"].ToString();
                }
                //给各个L3DataSet赋SourceCondition
                L3DataSetSourceCondition();
                //检查tab可用性
                TabEnableSet();
            }
            catch
            {
                strCurTundishID = "";
                strCurInnerID = "";
                strCurWorkId = "";
                strCurTundishNO = "";
                //给各个L3DataSet赋SourceCondition
                L3DataSetSourceCondition();
                //检查tab可用性
                TabEnableSet();
            }
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtS = Convert.ToDateTime(dtStart.Text);
                DateTime dtE = Convert.ToDateTime(dtEnd.Text + " 23:59:59");
                strCurSQLMag = "Creat_Time between '" + dtS + "' and '" + dtE + "'";
                if (strcmbTundishID != "")
                {
                    strCurSQLMag += " and TundishID = '" + strcmbTundishID + "'";
                }
                strCurSQLMag += " order by Creat_Time desc ,TundishID asc";
                dsMag.SourceCondition = strCurSQLMag;
            }
            catch { }
        }

        //缓存ComboBox选择查询中包号
        private void tsCmbTundishID_DropDownClosed(object sender, EventArgs e)
        {
            strcmbTundishID = tsCmbTundishID.Text.Trim();
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveJudge();
        }

        //给各个L3DataSet赋SourceCondition
        private void L3DataSetSourceCondition()
        {
            //永久层打结实绩
            dsInnerBuild.SourceCondition = "InnerID = '" + strCurInnerID + "'";
            //永久层烘烤实绩
            dsInnerFire.SourceCondition = "InnerID = '" + strCurInnerID + "'";
            //工作层涂抹/干振实绩
            dsDaub.SourceCondition = "WorkID = '" + strCurWorkId + "'";
            //上1、2#铸机热备烘烤实绩
            dsOTFireInfo.SourceCondition = "WorkID = '" + strCurWorkId + "'";
            //上3、4、5#铸机热备烘烤实绩
            dsTFFFireInfo.SourceCondition = "WorkID = '" + strCurWorkId + "'";
            //1、2铸机上件
            dsOTInstall.SourceCondition = "WorkID = '" + strCurWorkId + "'";
            //3、4、5铸机上件
            dsTFFInstall.SourceCondition = "WorkID = '" + strCurWorkId + "'";
            //1、2铸机耐材使用情况
            dsRefraOT.SourceCondition = "TundishNO = '" + strCurTundishNO + "'";
            //3、4、5铸机耐材使用情况
            dsRefraTFF.SourceCondition = "TundishNO = '" + strCurTundishNO + "'";
        }

        //检查所有详细信息的修改情况
        //提示用户保存情况
        private void DetailJudge()
        {
            //如果实绩被锁定，则不检查详细信息是否被修改
            if (bLock)
                return;
            bsInnerBuild.EndEdit();
            bsInnerFire.EndEdit();
            bsDaub.EndEdit();
            bsOTInstall.EndEdit();
            bsTFFInstall.EndEdit();
            bsOTFireInfo.EndEdit();
            bsTFFFireInfo.EndEdit();

            string strText = "";
            string strCaption = "提示!";
            object objRet = new object();

            //永久层打结实绩
            if (dsInnerBuild.GetChanges(DataRowState.Modified) != null)
            {
                strText = "永久层打结实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsInnerBuild.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "永久层打结实绩保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //永久层烘烤实绩
            if (dsInnerFire.GetChanges(DataRowState.Modified) != null)
            {
                strText = "永久层烘烤实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsInnerFire.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //工作层涂抹/干振实绩
            if (dsDaub.GetChanges(DataRowState.Modified) != null)
            {
                strText = "工作层涂抹/干振实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsDaub.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上1、2#铸机中包热备烘烤
            if (dsOTFireInfo.GetChanges(DataRowState.Modified) != null)
            {
                strText = "上1、2#铸机中包热备烘烤实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsOTFireInfo.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上3、4、5#铸机热备烘烤
            if (dsTFFFireInfo.GetChanges(DataRowState.Modified) != null)
            {
                //modify by hyh 2012-06-11
                strText = "上3/4/5/7/6#铸机中包热备烘烤实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsTFFFireInfo.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上1、2#铸机上件
            if (dsOTInstall.GetChanges(DataRowState.Modified) != null)
            {
                strText = "上1、2#铸机中包上件实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsOTInstall.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上3、4、5#铸机上件
            if (dsTFFInstall.GetChanges(DataRowState.Modified) != null)
            {
                //modify by hyh 2012-06-11
                strText = "上3/4/5/7/6#铸机中包上件实绩已被修改,是否保存？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsTFFInstall.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
        }

        //检查tab业内是否有数据
        //有数据则可用，否则不可用
        private void TabEnableSet()
        {
            //永久层打结
            if (!tabInnerBuild.IsDisposed)
            {
                if (dsInnerBuild.Tables[0].Rows.Count < 1)
                {
                    foreach (Control cInnerBuild in tabInnerBuild.Controls)
                    {
                        cInnerBuild.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control cInnerBuild in tabInnerBuild.Controls)
                    {
                        cInnerBuild.Enabled = true;
                    }
                }
            }
            //永久层烘烤
            if (!tabInnerFire.IsDisposed)
            {
                if (dsInnerFire.Tables[0].Rows.Count < 1)
                {
                    foreach (Control cInnerFire in tabInnerFire.Controls)
                    {
                        cInnerFire.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control cInnerFire in tabInnerFire.Controls)
                    {
                        cInnerFire.Enabled = true;
                    }
                }
            }
            //工作层涂抹\干振
            if (!tabDaub.IsDisposed)
            {
                if (dsDaub.Tables[0].Rows.Count < 1)
                {
                    foreach (Control cDaub in tabDaub.Controls)
                    {
                        cDaub.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control cDaub in tabDaub.Controls)
                    {
                        cDaub.Enabled = true;
                    }
                }
            }
            //热备烘烤
            if (!tabHotFire.IsDisposed)
            {
                //if (dsOTFireInfo.Tables[0].Rows.Count < 1)
                //{
                //    foreach (Control cOTFire in tabOTFire.Controls)
                //    {
                //        cOTFire.Enabled = false;
                //    }
                //}
                //else
                //{
                //    foreach (Control cOTFire in tabOTFire.Controls)
                //    {
                //        cOTFire.Enabled = true;
                //    }
                //}

                if (dsTFFFireInfo.Tables[0].Rows.Count < 1)
                {
                    foreach (Control cTFFFire in tabTFFFire.Controls)
                    {
                        cTFFFire.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control cTFFFire in tabTFFFire.Controls)
                    {
                        cTFFFire.Enabled = true;
                    }
                }
            }
            //上件
            if (!tabInstall.IsDisposed)
            {
                //if (dsOTInstall.Tables[0].Rows.Count < 1)
                //{
                //    foreach (Control cOTInstall in tabOTInstall.Controls)
                //    {
                //        cOTInstall.Enabled = false;
                //    }
                //}
                //else
                //{
                //    foreach (Control cOTInstall in tabOTInstall.Controls)
                //    {
                //        cOTInstall.Enabled = true;
                //    }
                //}

                if (dsTFFInstall.Tables[0].Rows.Count < 1)
                {
                    foreach (Control cTFFInstall in tabTFFInstall.Controls)
                    {
                        cTFFInstall.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control cTFFInstall in tabTFFInstall.Controls)
                    {
                        cTFFInstall.Enabled = true;
                    }
                }
            }

        }

        //保存检查
        private void SaveJudge()
        {
            bsInnerBuild.EndEdit();
            bsInnerFire.EndEdit();
            bsDaub.EndEdit();
            bsOTFireInfo.EndEdit();
            bsTFFFireInfo.EndEdit();
            bsOTInstall.EndEdit();
            bsTFFInstall.EndEdit();

            //dvRefraOT.EndEdit();
            bsRefraOT.EndEdit();
            dvRefraTFF.EndEdit();
            bsRefraTFF.EndEdit();

            string strText = "";
            string strCaption = "提示!";
            object objRet = new object();

            //永久层打结实绩
            if (dsInnerBuild.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对永久层打结实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsInnerBuild.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //永久层烘烤实绩
            if (dsInnerFire.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对永久层烘烤实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsInnerFire.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //工作层涂抹/干振实绩
            if (dsDaub.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对工作层涂抹/干振实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsDaub.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上1、2#铸机中包热备烘烤
            if (dsOTFireInfo.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对上1、2#铸机中包热备烘烤实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsOTFireInfo.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上3、4、5#铸机热备烘烤
            if (dsTFFFireInfo.GetChanges(DataRowState.Modified) != null)
            {
                //modify by hyh 2012-06-11
                strText = "确认保存对上3/4/5/7/6#铸机中包热备烘烤实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsTFFFireInfo.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上1、2#铸机上件
            if (dsOTInstall.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对上1、2#铸机中包上件实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsOTInstall.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
            //上3、4、5#铸机上件
            if (dsTFFInstall.GetChanges(DataRowState.Modified) != null)
            {
                //modify by hyh 2012-06-11
                strText = "确认保存对上3/4/5/7/6#铸机中包上件实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsTFFInstall.CommitModified(ref objRet);

                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }

            //上1、2#铸机耐材
            if (dsRefraOT.GetChanges(DataRowState.Modified) != null)
            {
                strText = "确认保存对上1/2#铸机中包上件实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsRefraOT.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }

            //上3、4、5#铸机耐材
            if (dsRefraTFF.GetChanges(DataRowState.Modified) != null)
            {
                //modify by hyh 2012-06-11
                strText = "确认保存对上3/4/5/7/6#铸机中包上件实绩的修改？";
                if (MessageBox.Show(strText, strCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    dsRefraTFF.CommitModified(ref objRet);
                    if (Convert.ToBoolean(objRet))
                    {
                        strText = "保存成功！";
                        MessageBox.Show(strText, strCaption,
                                           MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1,0);
        }

        private void dv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void TundishMag_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //锁定实绩/*2009-03-01*/
        private void btnDataConfirm_Click(object sender, EventArgs e)
        {
            int iMagIndex = dsMag.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsMag.Current)).Row);

            string strGUID = dvMag.Rows[iMagIndex].Cells["GUID"].Value.ToString();
            if (Adapter.Session.Set("XGMESLogic\\TundishMag\\CTundish_Use_Info\\" + strGUID, "Confirm_Flag", 1) >= 0)
            {
                MessageBox.Show("锁定实绩成功！", "提示", MessageBoxButtons.OK);
            }
        }

        private void dvMag_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMag, "TundishID", "ConfirmFlag", "1");
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("中包信息", dvMag);
        }

        private void tabTFFInstall_Click(object sender, EventArgs e)
        {

        }
    }
}