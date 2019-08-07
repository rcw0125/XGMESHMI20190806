using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace ProcessDataMag
{
    public partial class TestMap : DockContent, IMESForm
    {
        public TestMap()
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

        //private int iRowCountPerPage = 30;//每页显示数据行数

        //private int iRowIndex = 0;//当前行索引
        //private int iPageIndex = 0;//当前页索引

        //private int iRowCount = 0;//记录行数总和
        //private int iPageCount = 0;//记录显示页数总和

        //元点坐标
        private int iX0 = 0;
        private int iY0 = 0;

        //Y轴顶点坐标
        private int iX1 = 0;
        private int iY1 = 0;
        
        //X轴顶点坐标
        private int iX2 = 0;
        private int iY2 = 0;

        private void TestMap_Load(object sender, EventArgs e)
        {

        } 

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //AppSvrHMI.L3DataSet ds = GetDataSet();
            //if (ds == null || ds.Tables[0].Rows.Count < 1)
            //    return;
            
            //iRowCount = ds.Tables[0].Rows.Count;
            //if (iRowCount % iRowCountPerPage > 1)
            //    iPageCount = iRowCount / iRowCountPerPage + 1;
            //else
            //    iPageCount = iRowCount / iRowCountPerPage;

            ShowMap();
        }

        private void ShowMap()
        {
            Bitmap bitm = new Bitmap(this.pbxMap.Width, this.pbxMap.Height);
            Graphics grap = Graphics.FromImage(bitm);
            grap.Clear(Color.White);

            Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            Font font1 = new System.Drawing.Font("宋体", 12, FontStyle.Regular);
            Font font2 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

            //X轴
            grap.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0f), iX0, iY0, iX2, iY2);
            //Y轴
            grap.DrawLine(new Pen(new SolidBrush(Color.Black), 2.0f), iX1, iY1 - 21, iX0, iY0);

            string[] Xaxle ={ 
            "210900001",
            "210900002",
            "210900003",
            "210900004",
            "210900005",
            "210900006",
            "210900007",
            "210900008",
            "210900009",
            "210900010",
            "210900011",
            "210900012",
            "210900013",
            "210900014",
            "210900015",
            "210900016",
            "210900017",
            "210900018",
            "210900019",
            "210900020",
            "210900021",
            "210900022",
            "210900023",
            "210900024",
           " 210900025",
           " 210900026",
           " 210900027",
           " 210900028",
           " 210900029",
           " 210900030"};
            string[] Yaxle ={ "1.0", "0.9", "0.8", "0.7", "0.6", "0.5", "0.4", "0.3", "0.2", "0.1", "0" };
            int jjjj = iY0 / 11;
            for (int i = 0; i < 11; i++)
            {
                grap.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0f), iX0, jjjj, iX2, jjjj);
                grap.DrawString(Yaxle[i].ToString(), font, Brushes.Black, 8, jjjj);
                jjjj = jjjj + iY1;
            }
            int kkkk = iX0;// (iX2 - 30) / 30;
            for (int i = 0; i <= 30; i++)
            {
                grap.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0f), kkkk, iY1 - 21, kkkk, iY0);
                if (i > 0)
                    grap.DrawString(Xaxle[i - 1].ToString(), font, Brushes.Black, kkkk - 30, iY0 + 20);
                kkkk = 30 + (i + 1) * (iX2 - 30) / 30;
            }
            //for (int i = 0; i <= 30; i++)
            //{
            //    grap.DrawString(i.ToString(), new Font("宋体", 9), new SolidBrush(Color.Black), 12 + i * 34, 15);

            //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 2.0f), 10 + i * 34, 20, 10 + i * 34, 380);

            //    //if (i < 30)
            //    //{
            //    //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 40 + i * 34 + 6 * 1, 32, 40 + i * 34 + 6 * 1, 40);
            //    //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 40 + i * 34 + 6 * 2, 32, 40 + i * 34 + 6 * 2, 40);
            //    //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0f), 40 + i * 34 + 6 * 3, 28, 40 + i * 34 + 6 * 3, 40);
            //    //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 40 + i * 34 + 6 * 4, 32, 40 + i * 34 + 6 * 4, 40);
            //    //    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 40 + i * 34 + 6 * 5, 32, 40 + i * 34 + 6 * 5, 40);
            //    //}
            //}

            //for (int j = 0; j < 9; j++)
            //{
            //    grap.DrawLine(new Pen(new SolidBrush(Color.Green), 20.0f), 40, 50 + 40 * j, 40 + 24 * 34, 50 + 40 * j);
            //}

            this.pbxMap.BackgroundImage = bitm;
        }

        private AppSvrHMI.L3DataSet  GetDataSet()
        {
            if (cmbBOFID.Text == "")
            {
                MessageBox.Show("请选择炉座！", "提示");
                return null;
            }
            if (cmbElement.Text == "")
            {
                MessageBox.Show("请选择成分！", "提示");
                return null;
            }
            string strSteelGradeCon = "";
            if (cmbSteelGrade.Text != "")
                strSteelGradeCon = " and a.SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";

            string strElement = cmbElement.Text;
            string strSQL = "";

            /********************************* 炉终样  *************************************************/
            strSQL += "  SELECT ROWNUM, heatid, ELEMENT, ele_min, ele_max";
            strSQL += " from( SELECT   a.heatid AS heatid, b." + strElement + " AS ELEMENT, c." + strElement + "_min AS ele_min,";
            strSQL += "         c." + strElement + "_max AS ele_max                                       ";
            strSQL += "    FROM cbof_base_data a, cqa_lab_element b, cqa_product_sheet c ";

            dsElement.SourceMethod = strSQL + " where 1=2";

            strSQL += "   WHERE SUBSTR (a.heatid, 2, 1) = '1'                            ";
            strSQL += "     AND TO_CHAR (a.productiondate, 'yyyy-MM') = '2009-03'        ";
            strSQL += "     AND a.heatid = b.heatid(+)                                   ";
            strSQL += "     AND b.unittypeid = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'                                       ";
            strSQL += "     AND b.sample_type = 'GZ'                                     ";
            strSQL += "     AND b.sample_count = '01'                                    ";
            strSQL += "     AND a.steelgradeindex = c.steelgradeindex                    ";
            strSQL += strSteelGradeCon;
            strSQL += "ORDER BY a.heatid    )                                             ";

            dsElement.SourceMethod = strSQL;
            return dsElement;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        //界面大小发生变化时
        private void TestMap_SizeChanged(object sender, EventArgs e)
        {
            int iHight = panel1.Height;
            int iWidth = panel1.Width;

            int iiii = (iWidth - 40) / 30;
            int bindex = (iHight - 80) / 11;
            int bbbb = bindex * 11;


            iX0 = 30;
            iY0 = (iHight - 80) / 11*11;

            iX1 = 30;
            iY1 = (iHight - 80) / 11;

            iX2 = 30 + (iWidth - 40) / 30 * 30;
            iY2 = (iHight - 80) / 11 * 11;
        }
    }
}