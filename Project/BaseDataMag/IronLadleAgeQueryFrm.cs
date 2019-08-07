using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace BaseDataMag
{
    public partial class IronLadleAgeQueryFrm : Form
    {
        public IronLadleAgeQueryFrm()
        {
            InitializeComponent();
        }

        private ArrayList alQuery = new ArrayList();
        public DialogResult ShowDialogEx(AppSvrIF.Session session, ArrayList al)
        {
            Adapter.Session = session;
            alQuery = al;
            dtStartTime.Value = DateTime.Now.AddDays(-1);
            dtEndTime.Value = DateTime.Now;
            return ShowDialog();
        }

        private void EnergyDataAddModFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsQuery.Tables[0].Clear();
            dsQuery.SourceMethod = "";
            dsQuery.SourceMethod = "select Tpc_No,count(*) as Age,sum(Net_Weight) as Weight from CBFIron where to_char(PRODUCTION_DATE,'yyyy-MM-dd HH:mm:ss') between '" + dtStartTime.Text.ToString() + "' and '" + dtEndTime.Text.ToString() + "' group by TPC_NO order by TPC_NO";
            string strCondition = "";
            for (int i = 0; i < alQuery.Count; i++)
            {
                if (strCondition == "")
                    strCondition += "Tpc_No = '" + alQuery[i] + "'";
                else
                    strCondition += "or Tpc_No = '" + alQuery[i] + "'";
            }
            bsQuery.Filter = strCondition;

        }
    }
}