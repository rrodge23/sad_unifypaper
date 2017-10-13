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
    public partial class frmProductExportQuantity : Form
    {
        public frmProductExportQuantity()
        {
            InitializeComponent();
            
        }
        public string quantity { get; set; }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.quantity = tbProductQuantity.Text.Trim();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProductExportQuantity_Load(object sender, EventArgs e)
        {
            this.quantity = "0";
        }
    }
}
