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

        private void frmSalesVoid_Load(object sender, EventArgs e)
        {

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Void This Transaction?","Transaction Void", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

            }
        }
    }
}
