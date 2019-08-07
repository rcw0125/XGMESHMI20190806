using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class TappingPlanModifyFrm : Form
    {
        public TappingPlanModifyFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            

            return ShowDialog();
        }

        private void TappingPlanModifyFrm_Load(object sender, EventArgs e)
        {
            //向comboBox中添加描述
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count;i++)
            {
                tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
            tscmbCasterID.SelectedIndex = 0;
            tscmbCasterID_DropDownClosed(sender, e);

            dsChangePlanTime =(AppSvrHMI.L3DataSet) dsTapping.Clone();
        }

        private void tscmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //指定浇次第一炉
        private void btnCastingFirHeat_Click(object sender, EventArgs e)
        {
            int checkCount = 0;
            dvTapping.EndEdit();
            bsTapping.EndEdit();

            for (int i = 0; i < dsTapping.Tables[0].Rows.Count; i++)
            {
                if (dvTapping.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("只能选一条数据", "提示");
            }
            else
            {
                string check = MessageBox.Show("确认要指定浇次第一炉么？", "提示", 
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
                if (check == "OK")
                {
                    cmdFirst.Execute();
                    dsTapping.LoadData();
                    String returnFlag = cmdFirst.Command.Return.ToString();
                    if (returnFlag == "1" && dsTapping.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("指定浇次第一炉成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("指定浇次第一炉不成功！", "提示");
                    }
                }
                else
                {
                    dsTapping.LoadData();
                }
            }
        }

        //添加炉数到最近浇次
        private void btnAddNewHeatToCasting_Click(object sender, EventArgs e)
        {
            tstxtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.Text.Trim());
            string check = MessageBox.Show("确认要添加炉数到最近浇次么？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                //cmdAddHeats.Parameters[0].ConstantValue = tstxtCasterID.Text;
                cmdAddHeats.Execute();
                
                String returnFlag = cmdAddHeats.Command.Return.ToString();
                if (returnFlag == "1" )
                {
                    MessageBox.Show("指添加炉数到最近浇次成功！", "提示");
                }
                else
                {
                    MessageBox.Show("添加炉数到最近浇次不成功！", "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //指定去向
        private void btnDestination_Click(object sender, EventArgs e)
        {
            dvTapping.EndEdit();
            bsTapping.EndEdit();

            string check = MessageBox.Show("确认要指定去向么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdDestCfm.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdDestCfm.Command.Return.ToString();
                if (returnFlag == "1" && dsTapping.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("指定去向成功！", "提示");
                }
                else
                {
                    MessageBox.Show("指定去向不成功！", "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        private void tscmbCasterID_DropDownClosed(object sender, EventArgs e)
        {
            tstxtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.Text.Trim());
            dsTapping.LoadData();
        }

        //更改火车时刻表
        private void btnChangeTimeTable_Click(object sender, EventArgs e)
        {
            int checkCount = 0;
            dvTapping.EndEdit();
            bsTapping.EndEdit();

            for (int i = 0; i < dsTapping.Tables[0].Rows.Count; i++)
            {
                if (dvTapping.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("只能选一条数据", "提示");
            }
            else
            {
                string check = MessageBox.Show("确认要更改火车时刻表么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
                if (check == "OK")
                {
                    cmdChangeTime.Execute();
                    dsTapping.LoadData();
                    String returnFlag = cmdChangeTime.Command.Return.ToString();
                    string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                    if (returnFlag == "0" )
                    {
                        MessageBox.Show("更改火车时刻表成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("更改火车时刻表不成功！" + strShow, "提示");
                    }
                }
                else
                {
                    dsTapping.LoadData();
                }
            }
        }

        //取消浇次第一炉
        private void btnCancelCastinFirHeat_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("确认要取消浇次第一炉么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdFirstCancel.Parameters[0].ConstantValue = tstxtCasterID.Text;
                cmdFirstCancel.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdFirstCancel.Command.Return.ToString();
                if (returnFlag == "1" && dsTapping.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("取消浇次第一炉成功！", "提示");
                }
                else
                {
                    MessageBox.Show("取消浇次第一炉不成功！", "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改计划时间
        private void btnShowChangePlanTime_Click(object sender, EventArgs e)
        {
            //只选一行数据
            int checkCount = 0;
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            for (int i = 0; i < dsTapping.Tables[0].Rows.Count; i++)
            {
                if (dvTapping.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("只能选一条数据", "提示");
            }
            else
            {
                dsChangePlanTime.Tables[0].Clear();
                dsChangePlanTime.Tables[0].ImportRow(dsTapping.Tables[0].Select("CheckFlag = '1'")[0]);
                dsChangePlanTime.AcceptChanges();
                ChangePlanTimeFrm frm = new ChangePlanTimeFrm();
                frm.ShowDialogEx(Adapter.Session, dsChangePlanTime);
                dsTapping.LoadData();
            }
            
            
        }

        //转炉非作业时间
        private void btnShowWriteInTime_Click(object sender, EventArgs e)
        {
            //只选一行数据
            int checkCount = 0;
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            int iRet = -1;

            for (int i = 0; i < dsTapping.Tables[0].Rows.Count; i++)
            {
                if (dvTapping.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    checkCount++;
                    iRet = i;
                }
            }
            if (checkCount != 1)
            {
                MessageBox.Show("只能选一条数据", "提示");
            }
            else
            {
                dsWriteTime.Tables[0].Clear();
                DataRow newrow = dsWriteTime.Tables[0].NewRow();
                dsWriteTime.Tables[0].Rows.Add(newrow);
                dsWriteTime.Tables[0].Rows[0]["HeatID"] = dsTapping.Tables[0].Select("CheckFlag = '1'")[0]["HeatID"];
                WriteInTimeFrm frm = new WriteInTimeFrm();
                frm.ShowDialogEx(Adapter.Session, dsWriteTime);
                dsTapping.LoadData();
            }


        }

        private void dvTapping_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dvTapping.Rows[e.RowIndex].Cells[1].Value.ToString() == "1")
                dvTapping.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Red;
        }

        private void dvTapping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TappingPlanModifyFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}