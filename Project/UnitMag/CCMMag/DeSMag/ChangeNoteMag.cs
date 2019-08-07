using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class ChangeNoteMag : Form
    {
        public ChangeNoteMag()
        {
            InitializeComponent();
        }

        private string id = "";
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string MaterialID)
        {
            Adapter.Session = session;
            id = MaterialID;
            lbMaterialID.Text = id;
            dsNote.SourceCondition = "MATERIALID = '"+id+"'";
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsNote.EndEdit();
            if (dsNote.UpdateData())
            {
                MessageBox.Show("修改成功！", "提示");
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ChangeNoteMag_Load(object sender, EventArgs e)
        {
            txtNote.TextChanged += new EventHandler(txtReason_TextChanged);
        }
    }
}