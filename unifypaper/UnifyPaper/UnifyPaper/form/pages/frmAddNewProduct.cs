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
    public partial class frmAddNewProduct : Form
    {
        public frmAddNewProduct()
        {
            InitializeComponent();
        }
        Classes.Model.m_products mdl_prod = new Classes.Model.m_products();

        private void labelX9_Click(object sender, EventArgs e)
        {

        }


        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            minimumQuantity.Text = "";
            tbCurrentCost.Text = "";
            tbDescription.Text = "";
            tbProductCode.Text = "";
            tbQuantity.Text = "";
            tbStandardPrice.Text = "";
            tbSupplierContactNo.Text = "";
            tbSupplierName.Text = "";
            tbTaxCode.Text = "";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCurrentCost.Text != "" && tbDescription.Text != "" && tbProductCode.Text != "")
            {
                Classes.Entities.products prod = new Classes.Entities.products();
                prod.minimumQuantity = minimumQuantity.Text.ToString().Trim();
                prod.current_cost = tbCurrentCost.Text.ToString().Trim();
                prod.description = tbDescription.Text.ToString().Trim();
                prod.product_code = tbProductCode.Text.ToString().Trim();
                prod.quantity = tbQuantity.Text.ToString().Trim();
                prod.standard_price = tbStandardPrice.Text.ToString().Trim();
                prod.supplier_name = tbSupplierName.Text.ToString().Trim();
                prod.supplier_contact_no = tbSupplierContactNo.Text.ToString().Trim();
                prod.tax_code = tbTaxCode.Text.ToString().Trim();
                if (mdl_prod.addNewProduct(prod))
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("Please Fill Out Required Details");
            }
        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void tbCurrentCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
