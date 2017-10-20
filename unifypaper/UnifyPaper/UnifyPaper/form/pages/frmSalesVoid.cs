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
    public partial class frmSalesVoid : Form
    {
        public frmSalesVoid()
        {
            InitializeComponent();
        }

        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();

        private void frmSalesVoid_Load(object sender, EventArgs e)
        {
            tbTransactionID.Focus();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Void This Transaction?","Transaction Void", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int o;
            
                if (m_trans.getPreviousTransactionByID(tbTransactionID.Text.Trim()) != null && Int32.TryParse(tbTransactionID.Text.Trim(), out o))
                {
                    if (Classes.Session.sessionUsers.userlevel != "99")
                    {

                        frmInputAdminPassword fiap = new frmInputAdminPassword();
                        fiap.ShowDialog();
                        fiap.transaction_ID = Convert.ToInt32(tbTransactionID.Text.Trim());
                        this.Close();
                    }
                    else
                    {
                        if(m_trans.deleteTransaction(Convert.ToInt32(tbTransactionID.Text.Trim())))
                        {
                            MessageBox.Show("Transaction Successfully Voided.");
                            this.Close();
                        }else
                        {
                            MessageBox.Show("Invalid Transaction");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Transaction Number");
                }
            }
        }
    }
}
