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
    public partial class frmSalesReturn : Form
    {
        public frmSalesReturn()
        {
            InitializeComponent();
        }

        public frmMainPage mainpageFrm { get; set; }
        public string ID { get; set; }
        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            this.ID = "0";
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.ID = tbTransactionID.Text.Trim();
            this.Close();
            Int32 o;
            if(tbTransactionID.Text.Trim() != "" && Int32.TryParse(tbTransactionID.Text.Trim(),out o))
            {
                
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }
    }
}
