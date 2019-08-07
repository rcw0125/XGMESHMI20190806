using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BFMag
{
    public partial class IronInfoFrm : Form
    {
        public IronInfoFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strSort,int nPosition,ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsMain.DataSource = null;

            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
            bsMain.Position = nPosition;

            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void OnPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Control ctrl = sender as Control;
            if (e.KeyCode == Keys.Return)
            {
                Control next = ctrl.Parent.GetNextControl(ctrl, true);
                if (next != null)
                {
                    while (!next.TabStop)
                    {
                        next = ctrl.Parent.GetNextControl(next, true);
                        if (next == null)
                            break;
                    }
                }
                if (next == null)
                {
                    next = ctrl.Parent;
                }
                next.Focus();
            }
        }

        //private void GetBFChemcialData()
        //{
        //    dsChemical.L3DataAdapter = Adapter;
        //    dsChemical.LoadData();
        //    if (dsChemical.Tables[0].Rows.Count > 0)
        //    {
        //        ptbC.Text = dsChemical.Tables[0].Rows[0]["C"].ToString();
        //        ptbSi.Text = dsChemical.Tables[0].Rows[0]["Si"].ToString();
        //        ptbMn.Text = dsChemical.Tables[0].Rows[0]["Mn"].ToString();
        //        ptbP.Text = dsChemical.Tables[0].Rows[0]["P"].ToString();
        //        ptbS.Text = dsChemical.Tables[0].Rows[0]["S"].ToString();
        //        ptbTi.Text = dsChemical.Tables[0].Rows[0]["Ti"].ToString();
        //    }
        //}

        private void ptbWT_Leave(object sender, EventArgs e)
        {
            if (sender.GetType().Name != "PxTextBox")
                return;

            PxDataValid.PxTextBox ptbtxt = (PxDataValid.PxTextBox)sender;
            try
            {
                float fTare = 0;
                if (ptbTare.Text.Length > 0)
                    fTare = float.Parse(ptbTare.Text);

                float fCross = 0;
                if (ptbCross.Text.Length > 0)
                    fCross = float.Parse(ptbCross.Text); ;

                if (sender.Equals(ptbCross) && fCross < 47)
                {
                    MessageBox.Show("毛重至少大于47吨", "提示");
                    return;
                }

                float ftemp = fCross - fTare;
                ptbNet.Text = string.Format("{0:F}", ftemp);
            }
            catch { ptbtxt.Text = "0"; ptbNet.Text = "0"; }
        }
    }
}