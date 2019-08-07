using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class DiapatchExceptionFrm : DockContent, IMESForm
    {
        public DiapatchExceptionFrm()
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

        DispatchLogFrm frmDispatchLog = new DispatchLogFrm();
        LogQueryFrm frmLogQuery = new LogQueryFrm();

        private string strCurHeatID = "";
        private string strCurSteelGrade = "";

        //改钢
        private void btnSteelExchange_Click(object sender, EventArgs e)
        {
            try
            {
                dvSteelExchange.EndEdit();
                bsSteelExange.EndEdit();

                dsExchangeSend.Tables[0].Clear();
                dsExchangeSend.Tables[0].ImportRow(dsSteelExchange.Tables[0].Select("CheckFlag = '1'")[0]);

                SteelExchangeFrm frm = new SteelExchangeFrm();
                frm.ShowDialogEx(Adapter.Session, dsExchangeSend);
                dsSteelExchange.LoadData();
            }
            catch { }
        }

        //钢水回炉
        private void btnSteelTurn_Click(object sender, EventArgs e)
        {
            try
            {
                dvSteelTurn.EndEdit();
                bsSteelTurn.EndEdit();

                dsTurnSend.Tables[0].Clear();
                dsTurnSend.Tables[0].ImportRow(dsSteelTurn.Tables[0].Select("CheckFlag = '1'")[0]);

                SteelTurnFrm frm = new SteelTurnFrm();
                frm.ShowDialogEx(Adapter.Session, dsTurnSend);
                dsSteelTurn.LoadData();
            }
            catch { }

        }

        //钢水返送
        private void btnSteelBack_Click(object sender, EventArgs e)
        {
            try
            {
                dvSteelBack.EndEdit();
                bsSteelBack.EndEdit();

                dsBackSend.Tables[0].Clear();
                dsBackSend.Tables[0].ImportRow(dsSteelBack.Tables[0].Select("CheckFlag = '1'")[0]);

                SteelBackFrm frm = new SteelBackFrm();
                frm.ShowDialogEx(Adapter.Session, dsBackSend);
                GC.Collect();
                dsSteelBack.LoadData();
            }
            catch { }

        }           

        //炉次分割
        private void btnSteelDiv_Click(object sender, EventArgs e)
        {
            try
            {
                dvSteelDiv.EndEdit();
                bsSteelDiv.EndEdit();

                dsDivSend.Tables[0].Clear();
                dsDivSend.Tables[0].ImportRow(dsSteelDiv.Tables[0].Select("CheckFlag = '1'")[0]);

                SteelDivFrm frm = new SteelDivFrm();
                frm.ShowDialogEx(Adapter.Session, dsDivSend);
                dsSteelDiv.LoadData();
            }
            catch { }
        }

        //退出
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvSteelBack_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dvSteelBack.Rows[e.RowIndex].Cells["BACK_FLAG"].Value.ToString() == "1")
                {
                    dvSteelBack.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void dvSteelTurn_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dvSteelTurn.Rows[e.RowIndex].Cells["TURN_FLAG"].Value.ToString() == "1")
                {
                    dvSteelTurn.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }

        private void dvSteelExchange_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if ( e.RowIndex < 0 )
                    return;
                if (dvSteelExchange.Rows[e.RowIndex].Cells["EX_FLAG"].Value.ToString() == "1")
                {
                    dvSteelExchange.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            catch
            {
            	
            }
        }

        //调度记事
        private void btnLog_Click(object sender, EventArgs e)
        {
            frmDispatchLog.ShowDialogEx(Adapter.Session);
        }

        //调度记事查询
        private void btnLogQuery_Click(object sender, EventArgs e)
        {
            frmLogQuery.ShowDialogEx(Adapter.Session);
        }


        //给转炉成品成份标准dvProductElement组织数据
        private void dvElementFormData()
        {
            try
            {
                if (dsEleStd == null || dsEleStd.Tables[0].Rows.Count != 1)
                {
                    if (dvLabElement.Rows.Count > 0)
                        dvLabElement.Rows.Clear();
                    return;
                }
                string[] strArrayType = new string[6];
                strArrayType[0] = "下限:";
                strArrayType[1] = "_Min";
                strArrayType[2] = "目标:";
                strArrayType[3] = "_Aim";
                strArrayType[4] = "上限:";
                strArrayType[5] = "_Max";

                dvLabElement.Rows.Clear();
                dvLabElement.Rows.Add(9);
                dvLabElement.Rows[0].Cells[0].Value = "";
                dvLabElement.Rows[0].Cells[1].Value = "C";
                dvLabElement.Rows[0].Cells[2].Value = "Si";
                dvLabElement.Rows[0].Cells[3].Value = "Mn";
                dvLabElement.Rows[0].Cells[4].Value = "P";
                dvLabElement.Rows[0].Cells[5].Value = "S";
                dvLabElement.Rows[0].Cells[6].Value = "Cu";
                dvLabElement.Rows[0].Cells[7].Value = "Ni";
                dvLabElement.Rows[0].Cells[8].Value = "Cr";
                dvLabElement.Rows[0].Cells[9].Value = "Mo";
                dvLabElement.Rows[0].Cells[10].Value = "V";
                dvLabElement.Rows[0].Cells[11].Value = "Nb";
                dvLabElement.Rows[0].Cells[12].Value = "Al";
                dvLabElement.Rows[0].Cells[13].Value = "AlS";
                dvLabElement.Rows[0].Cells[14].Value = "Ti";
                dvLabElement.Rows[0].Cells[15].Value = "B";

                for (int i = 0; i < 3; i++)
                {
                    dvLabElement.Rows[i + 1].Cells[0].Value = strArrayType[2 * i];
                    dvLabElement.Rows[i + 1].Cells[1].Value = dsEleStd.Tables[0].Rows[0]["C" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[2].Value = dsEleStd.Tables[0].Rows[0]["Si" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[3].Value = dsEleStd.Tables[0].Rows[0]["Mn" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[4].Value = dsEleStd.Tables[0].Rows[0]["P" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[5].Value = dsEleStd.Tables[0].Rows[0]["S" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[6].Value = dsEleStd.Tables[0].Rows[0]["Cu" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[7].Value = dsEleStd.Tables[0].Rows[0]["Ni" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[8].Value = dsEleStd.Tables[0].Rows[0]["Cr" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[9].Value = dsEleStd.Tables[0].Rows[0]["Mo" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[10].Value = dsEleStd.Tables[0].Rows[0]["V" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[11].Value = dsEleStd.Tables[0].Rows[0]["Nb" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[12].Value = dsEleStd.Tables[0].Rows[0]["Al" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[13].Value = dsEleStd.Tables[0].Rows[0]["AlS" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[14].Value = dsEleStd.Tables[0].Rows[0]["Ti" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 1].Cells[15].Value = dsEleStd.Tables[0].Rows[0]["B" + strArrayType[2 * i + 1]].ToString();
                }

                dvLabElement.Rows[5].Cells[0].Value = "";
                dvLabElement.Rows[5].Cells[1].Value = "Sb";
                dvLabElement.Rows[5].Cells[2].Value = "Sn";
                dvLabElement.Rows[5].Cells[3].Value = "As";
                dvLabElement.Rows[5].Cells[4].Value = "Zn";
                dvLabElement.Rows[5].Cells[5].Value = "Zr";
                dvLabElement.Rows[5].Cells[6].Value = "Ca";
                dvLabElement.Rows[5].Cells[7].Value = "W";
                dvLabElement.Rows[5].Cells[8].Value = "Pb";
                dvLabElement.Rows[5].Cells[9].Value = "Re";
                dvLabElement.Rows[5].Cells[10].Value = "Ceq";
                dvLabElement.Rows[5].Cells[11].Value = "N";
                dvLabElement.Rows[5].Cells[12].Value = "H";
                dvLabElement.Rows[5].Cells[13].Value = "O";
                dvLabElement.Rows[5].Cells[14].Value = "Other1";
                dvLabElement.Rows[5].Cells[15].Value = "Other2";
                for (int i = 0; i < 3; i++)
                {
                    dvLabElement.Rows[i + 6].Cells[0].Value = strArrayType[2 * i];
                    dvLabElement.Rows[i + 6].Cells[1].Value = dsEleStd.Tables[0].Rows[0]["Sb" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[2].Value = dsEleStd.Tables[0].Rows[0]["Sn" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[3].Value = dsEleStd.Tables[0].Rows[0]["As" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[4].Value = dsEleStd.Tables[0].Rows[0]["Zn" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[5].Value = dsEleStd.Tables[0].Rows[0]["Zr" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[6].Value = dsEleStd.Tables[0].Rows[0]["Ca" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[7].Value = dsEleStd.Tables[0].Rows[0]["W" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[8].Value = dsEleStd.Tables[0].Rows[0]["Pb" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[9].Value = dsEleStd.Tables[0].Rows[0]["Re" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[10].Value = dsEleStd.Tables[0].Rows[0]["Ceq" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[11].Value = dsEleStd.Tables[0].Rows[0]["N" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[12].Value = dsEleStd.Tables[0].Rows[0]["H" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[13].Value = dsEleStd.Tables[0].Rows[0]["O" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[14].Value = dsEleStd.Tables[0].Rows[0]["Other1" + strArrayType[2 * i + 1]].ToString();
                    dvLabElement.Rows[i + 6].Cells[15].Value = dsEleStd.Tables[0].Rows[0]["Other2" + strArrayType[2 * i + 1]].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //设置没有绑定源的DataGridView的属性
        private void SetDataGridView(DataGridView dv)
        {
            dv.AllowUserToAddRows = false;
            dv.BackgroundColor = System.Drawing.SystemColors.Control;
            dv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dv.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dv.AutoGenerateColumns = false;
            dv.ColumnHeadersVisible = false;
            dv.RowHeadersVisible = false;
            dv.ReadOnly = true;
            dv.MultiSelect = false;
            dv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;

        }

        private void DiapatchExceptionFrm_Load(object sender, EventArgs e)
        {
            SetDataGridView(dvLabElement);
            //tabSteelDiv.Dispose();
        }

        //
        private void dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strsenderName = ((DataGridView)sender).Name;
            switch (strsenderName)
            {
                case "dvSteelExchange":
                    if (e.RowIndex < 0)
                    {
                        strCurHeatID = "";
                        strCurSteelGrade = "";
                    }
                    else
                    {
                        strCurHeatID = dvSteelExchange.Rows[e.RowIndex].Cells[2].Value.ToString();
                        strCurSteelGrade = dvSteelExchange.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;
                   
                case "dvSteelTurn":
                    if (e.RowIndex < 0)
                    {
                        strCurHeatID = "";
                        strCurSteelGrade = "";
                    }
                    else
                    {
                        strCurHeatID = dvSteelTurn.Rows[e.RowIndex].Cells[2].Value.ToString();
                        strCurSteelGrade = dvSteelTurn.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;
                case "dvSteelBack":
                    if (e.RowIndex < 0)
                    {
                        strCurHeatID = "";
                        strCurSteelGrade = "";
                    }
                    else
                    {
                        strCurHeatID = dvSteelBack.Rows[e.RowIndex].Cells[2].Value.ToString();
                        strCurSteelGrade = dvSteelBack.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;
                case "dvSteelDiv":
                    if (e.RowIndex < 0)
                    {
                        strCurHeatID = "";
                        strCurSteelGrade = "";
                    }
                    else
                    {
                        strCurHeatID = dvSteelDiv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        strCurSteelGrade = dvSteelDiv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;
                default:
                    strCurHeatID = "";
                    strCurSteelGrade = "";
                    break;
            }
            dsHeatExcept.Tables[0].Clear();
            dsHeatExcept.SourceCondition = "HeatID = '" + strCurHeatID + "'";
            dsHeatExcept.L3DataAdapter = Adapter;
            dsHeatExcept.L3DataAdapter = null;

            dsEleStd.Tables[0].Clear();
            dsEleStd.SourceCondition = "SteelGradeIndex = '" + strCurSteelGrade + "'";
            dsEleStd.L3DataAdapter = Adapter;
            dvElementFormData();
            dsEleStd.L3DataAdapter = null;
        }

        // 刷新 [12/30/2008 sun]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsSteelExchange.LoadData();
            dsSteelTurn.LoadData();
            dsSteelBack.LoadData();
            dsSteelDiv.LoadData();
        }

        //设置选择列可用性(标志为1的不允许选择)[20081231Liao]
        private void dv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            switch (dv.Name)
            {
                //改钢申请
                case "dvSteelExchange":
                    CommDataMag.CommonMethed.SetDVSingleColEnable(dvSteelExchange, "EX_FLAG", "1");
                    break;

                //全回炉申请
                case "dvSteelTurn":
                    CommDataMag.CommonMethed.SetDVSingleColEnable(dvSteelTurn, "TURN_FLAG", "1");
                    break;

                //返送申请
                case "dvSteelBack":
                    CommDataMag.CommonMethed.SetDVSingleColEnable(dvSteelBack, "BACK_FLAG", "1");
                    break;

                //炉次分割申请
                case "dvSteelDiv":
                    CommDataMag.CommonMethed.SetDVSingleColEnable(dvSteelDiv, "DIV_FLAG", "1");
                    break;

                default:
                    break;
            }
        }

        private void DiapatchExceptionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}