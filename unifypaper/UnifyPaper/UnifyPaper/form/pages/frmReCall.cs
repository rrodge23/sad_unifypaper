using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper.form.pages
{
    public partial class frmReCall : Form
    {
        public frmReCall()
        {
            InitializeComponent();
        }


        //INITIATE
        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();
        Classes.Entities.transaction e_trans = new Classes.Entities.transaction();
        public frmMainPage mainpageFrm { get; set; }
        private void btnViewOrPrintPastSalesReceipt_Click(object sender, EventArgs e)
        {
            frmTransactionNumber ftn = new frmTransactionNumber();
            ftn.ShowDialog();
        }

        private void frmReCall_Load(object sender, EventArgs e)
        {
            displayLatestTransactionID();
        }

        private void displayLatestTransactionID()
        {
           
            lbLastTransaction.Text = m_trans.getLatestTransactionID();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            frmSalesReturn fsr = new frmSalesReturn();
            fsr.mainpageFrm = this.mainpageFrm;
            fsr.ShowDialog();
            
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            frmSalesVoid fsv = new frmSalesVoid();
            fsv.ShowDialog();
            displayLatestTransactionID();
        }
    }

    
}
