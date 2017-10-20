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
    public partial class frmInputAdminPassword : Form
    {
        public frmInputAdminPassword()
        {
            InitializeComponent();
            tbAdminPassword.PasswordChar = '*';
        }

        Classes.Database.database db = new Classes.Database.database();
        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();

        public int transaction_ID { get; set; }
        private void frmInputAdminPassword_Load(object sender, EventArgs e)
        {
            tbAdminPassword.Focus();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbAdminPassword.Text.Count() > 0)
            {
                Classes.Entities.users usr = db.getUserAdmin();
                if(tbAdminPassword.Text.Trim() == usr.password)
                {
                    
                    if (m_trans.deleteTransaction(this.transaction_ID) == true)
                    {
                        MessageBox.Show("transaction successfully void");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Authorization Password");
                }
                this.Close();
            }
        }
    }
}
