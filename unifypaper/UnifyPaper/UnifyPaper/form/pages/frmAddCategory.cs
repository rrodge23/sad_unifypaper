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
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
        }
        Classes.Model.m_products m_product = new Classes.Model.m_products();
        private void frmAddProductCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbCategoryName.Text != "")
            {
                string addProductCategoryResult = m_product.addProductCategory(tbCategoryName.Text.ToString().Trim());
                if (addProductCategoryResult != "0")
                {
                    MessageBox.Show(addProductCategoryResult);

                }
                else
                {
                    MessageBox.Show("Error in Inserting Product Category.");
                }
            }
        }
    }
}
