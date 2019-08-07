using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class TappingActFrm : Form
    {
        public TappingActFrm ()
        {
            InitializeComponent();
        }

        public void ShowDialogEx ( AppSvrIF.Session session  )
        {
            Adapter.Session = session;
            this.ShowDialog();
        }
        
        //ȷ��
        private void btnConfirm_Click ( object sender , EventArgs e )
        {
            dvTappingAct.EndEdit();
            bsTappingAct.EndEdit();

            dsTappingAct.UpdateData();
        }

        //�˳�
        private void btnExit_Click ( object sender , EventArgs e )
        {
            this.Close();
        }

        private void dvBOFStatus_DataError ( object sender , DataGridViewDataErrorEventArgs e )
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsTappingAct.RejectChanges();
        }

        private void dvTappingAct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //�ı䵥Ԫ�����ɫ��������Ϊ��ʱ�˳�
            if (e.RowIndex < 0)
                return;
            int nCol = e.ColumnIndex;
            //�޸������е�Ԫ�����ɫ
            if (nCol  == 1)
            {
                dvTappingAct.Columns[nCol].DefaultCellStyle.BackColor = Color.Silver;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TappingActFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void TappingActFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dsTappingAct.Tables[0].Rows.Count; i++)
            {
                dsTappingAct.Tables[0].Rows[i]["CreateDate"] = DateTime.Now;
            }
        }


    }
}