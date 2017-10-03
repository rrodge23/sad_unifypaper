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
    public partial class frmTransactionSearchItem : Form
    {
        public frmTransactionSearchItem()
        {
            InitializeComponent();
        }
        public frmMainPage mainpageForm { get; set; }
        Classes.Model.m_products mdl_prod = new Classes.Model.m_products();

        private void frmTransactionSearchItem_Load(object sender, EventArgs e)
        {
            cmbCategory.AutoCompleteCustomSource.Clear();
            cmbCategory.Items.Clear();

            foreach (string category in mdl_prod.getAllProductCategory())
            {
                cmbCategory.AutoCompleteCustomSource.Add(category);
                cmbCategory.Items.Add(category);
                
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            if(tbItemCode.Text != "")
            {
                
                
                mainpageForm.transactionTextBoxInput(tbItemCode.Text.Trim());
                this.Close();
                
            }else if(tbDescription.Text != "")
            {
                List<Classes.Entities.products> getProductList = new List<Classes.Entities.products>();
                getProductList = mdl_prod.getProductByMode(tbDescription.Text, "description");
                if (getProductList.Count > 0)
                {
                    frmItemList fil = new frmItemList();
                    fil.searchName = tbDescription.Text.Trim();
                    fil.searchType = "description";
                    fil.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbError.Text = "No Product Description Match.";
                }
            }else if(cmbCategory.Text != "")
            {

                List<Classes.Entities.products> getProductList = new List<Classes.Entities.products>();
                getProductList = mdl_prod.getProductByMode(cmbCategory.Text, "category");
                if (getProductList.Count > 0)
                {
                    frmItemList fil = new frmItemList();
                    fil.searchName = cmbCategory.Text;
                    fil.searchType = "category";
                    fil.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbError.Text = "No Product Category Match.";
                }
            }

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            tbDescription.Text = "";
            cmbCategory.Text = "";
        }

        private void e(object sender, EventArgs e)
        {

        }

        private void tbDescription_Enter(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            tbItemCode.Text = "";
        }

        private void tbCategory_Enter(object sender, EventArgs e)
        {
            tbItemCode.Text = "";
            tbDescription.Text = "";
        }

        private void frmTransactionSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnCLose.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }
    }
}
