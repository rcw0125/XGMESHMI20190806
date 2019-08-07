using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class SelProductPathFrm : Form
    {
        // string PROTOCOL = "";
        // string STEELGRADE = "";
        string PLANID = "";//订单号
        string standard = "";//规格
        string path = "";//工艺路径
        string gz = "";//钢种
        string zzbz = "";//制造标准
        string mCode = "";//物料代码
        string xy = "";//协议

        string FLAG = "";
        string tempt = "";//暂存炼钢记号
        public string returnFlag = "";
        public string isExcute = "";



        public SelProductPathFrm()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(AppSvrIF.Session session, string steelGrade, string NC, string PLANID1, ref string returnFlag, string productPath, string STD, string pStandard, string materialCode)
        {
            // dsProductPath.Tables[0].Clear();
            //XGMESLogic\PlanMag\CQA_STEELGRADEINDEX_R a,XGMESLogic\PlanMag\CQA_PRODUCT_SHEET b
            string strSQL =
                "SELECT a.STEELGRADEINDEX ,b.BOF_TYPE,b.LF_TYPE,b.RH_TYPE,b.CASTER_TYPE,b.AOD_TYPE "
                + " FROM CQA_STEELGRADEINDEX_R a,CQA_PRODUCT_SHEET b "
                + "WHERE a.USE_FLAG='0' and a.STEELGRADEINDEX=b.STEELGRADEINDEX and b.STEELGRADEINDEX IN( "
                + "select a.STEELGRADEINDEX from CQA_STEELGRADEINDEX_R a where a.STEELGRADE='" + steelGrade + "' "
                + "and a.PROTOCOL='" + NC + "' )";

            dsProductPath.SourceMethod = strSQL;
            Adapter.Session = session;
            //STEELGRADE = steelGrade;
            PLANID = PLANID1;
            path = productPath;
            gz = steelGrade;
            zzbz = pStandard;
            mCode = materialCode;
            standard = STD;
            xy = NC;

            if (ShowDialog() == DialogResult.OK)
            {
                returnFlag = tempt;

            }
            return DialogResult;
            //return ShowDialog();
        }

        private void SelProductPathFrm_Load(object sender, EventArgs e)
        {
            tsLblPLANID.Text = PLANID;
            tsLBLProductPath.Text = path;
            tsLblStandard.Text = standard;
            lblGZ.Text = gz;
            lblXY.Text = xy;
            lblWLDM.Text = mCode;
            lblZZBZ.Text = zzbz;
            string subStr = lblWLDM.Text.Substring(0,3);
            
            if (dsProductPath != null && dsProductPath.Tables[0].Rows.Count > 0)
            {
                //加载控件

                //加载panel
                Panel pl = new Panel();
                //pl.AllowDrop = true;
                //pl.AutoSize = true;
                pl.Dock = System.Windows.Forms.DockStyle.Fill;
                pl.AutoScroll = true;
                pl.Location = new System.Drawing.Point(0, 36);
                pl.Name = "panel1";

                for (int i = 0; i < dsProductPath.Tables[0].Rows.Count; i++)
                {
                    string STEELGRADEINDEX = "";
                    string strBOF = "";
                    string strAOD = "";
                    string strLF = "未确定LF";
                    string strRH = "";
                    string strCCM = "";

                    int iBof_Type = Convert.ToInt32(dsProductPath.Tables[0].Rows[i][1]);
                    switch (iBof_Type)
                    {
                        case 1:
                            strBOF = "1、2、3#转炉";
                            break;
                        case 2:
                            strBOF = "4#转炉";
                            break;
                        case 3:
                            strBOF = "AOD转炉";
                            break;
                        case 4:
                            strBOF = "熔化炉";
                            break;
                        default:
                            strBOF = "未知转炉";
                            break;
                    }

                    int iAod_Type = Convert.ToInt32(dsProductPath.Tables[0].Rows[i][5]);
                    switch (iAod_Type)
                    {
                        
                        case 5:
                            strAOD = "AOD转炉";
                            break;
                       
                        default:
                            strAOD = "未知路径";
                            break;
                    }
                    int iLF_Type = Convert.ToInt32(dsProductPath.Tables[0].Rows[i][2]);
                    switch (iLF_Type)
                    {
                        case 1:
                            strLF = "不经过LF";
                            break;
                        // modify by hyh 2012-06-07
                        case 2:
                            strLF = "1、2、4、5#LF";
                            break;
                        //end
                        case 3:
                            strLF = "3#LF";
                            break;
                        case 4:
                            strLF = "4#LF";
                            break;

                        default:
                            strLF = "未知LF路径";
                            break;
                    }

                    int iRH_Type = Convert.ToInt32(dsProductPath.Tables[0].Rows[i][3]);
                    switch (iRH_Type)
                    {
                        case 1:
                            strRH = "不经过RH";
                            break;
                        case 2:
                            strRH = "1#RH";
                            break;
                        default:
                            strRH = "未知RH";
                            break;
                    }

                    int iCCM_Type = Convert.ToInt32(dsProductPath.Tables[0].Rows[i][4]);
                    switch (iCCM_Type)
                    {
                        case 1:
                            strCCM = "1、2#铸机";
                            break;
                        case 2:
                            strCCM = "3、4#铸机";
                            break;
                        case 3:
                            strCCM = "5#铸机";
                            if (iLF_Type != 1)
                                strLF = "3#LF";
                            break;
                        case 4:
                            strCCM = "6#铸机";
                            break;
                        case 5:
                            strCCM = "7#铸机";
                            break;
                        default:
                            strCCM = "未知铸机";
                            break;
                    }

                    STEELGRADEINDEX = dsProductPath.Tables[0].Rows[i]["STEELGRADEINDEX"].ToString();

                    //加载RadioButton
                    RadioButton r = new RadioButton();
                    r.Name = "rBtn" + i;
                    r.AutoSize = true;
                    r.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    r.ForeColor = System.Drawing.Color.Red;
                    r.Location = new System.Drawing.Point(53, 74 + 80 * i);
                    r.Size = new System.Drawing.Size(124, 18);
                    int tempt = 0;
                    r.TabIndex = tempt;
                    tempt++;
                    r.TabStop = true;
                    r.Text = STEELGRADEINDEX;
                    r.UseVisualStyleBackColor = true;
                    pl.Controls.Add(r);
                    // r.MouseClick += new MouseEventHandler(r_MouseClick);
                    r.Click += new System.EventHandler(this.radioButton1_Click);

                    //加载TextBox
                    TextBox txt = new TextBox();

                    txt.Name = "txt" + i;
                    txt.Multiline = true;
                    txt.Size = new System.Drawing.Size(851, 33);
                    txt.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(139)));
                    txt.Location = new System.Drawing.Point(177, 67 + 80 * i);
                    txt.Text = "  " + strBOF + "--->" + strAOD + "--->" + strLF + "--->" + strRH + "--->" + strCCM;
                    txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    txt.ReadOnly = true;


                    pl.Controls.Add(txt);


                }
                this.Controls.Add(pl);
            }
        }


        //确定
        private void tsBtnOK_Click(object sender, EventArgs e)
        {
            if (tempt == "")
                return;
            if (lblWLDM.Text.Substring(0, 3) == "617")
            {
                //MessageBox.Show("所选订单是熔化炉工艺，是否进行排产？");
                //return;
                DialogResult dr1 = MessageBox.Show("所选订单是熔化炉工艺，是否进行排产？", "提示", MessageBoxButtons.YesNo);
                if (dr1 == DialogResult.Yes)
                {
                    returnFlag = tempt;
                    isExcute = "确定";
                    this.Dispose();
                }
                else
                    return;

            }
            else 
            {
            returnFlag = tempt;
            isExcute = "确定";
            this.Dispose();
            }
            //L3cmdpGenCasting.SourceProperty = "L3DataTable";
            //L3cmdpGenCasting.SourceObject = dsCasting;
            //cmdGenCasting.Execute();
            //textBox2.Text = PLANID;
            //textBox3.Text = tempt;

            //cmdSteelPlanPath.Execute();
            //FLAG = cmdSteelPlanPath.Command.Return.ToString();

        }

        //取消
        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            isExcute = "取消";
            this.Dispose();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                tempt = ((RadioButton)sender).Text;
            }

        }

        private void SelProductPathFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isExcute += "关闭";
        }


    }
}