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
    public partial class frmItemList : Form
    {
        public frmItemList()
        {
            InitializeComponent();
        }

        public string searchType { get; set; }
        public string searchName { get; set; }
        Classes.Model.m_products mdl_prod = new Classes.Model.m_products();

  

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmItemList_Load(object sender, EventArgs e)
        {
            loadItemColumns();
        }

        private void loadItemColumns()
        {
            
            dgProductList.DataSource = null;
            DataTable dgTable = new DataTable();
            dgTable.Columns.Add("Product Code", typeof(string));
            dgTable.Columns.Add("Description", typeof(string));
            dgTable.Columns.Add("Unit", typeof(string));
            dgTable.Columns.Add("Price", typeof(string));
            List<Classes.Entities.products> productList = new List<Classes.Entities.products>();
            productList = mdl_prod.getProductByMode(this.searchName,this.searchType);
            foreach (Classes.Entities.products prod in productList)
            {
               
                MessageBox.Show(prod.product_code);
               
                dgTable.Rows.Add(
                                
                                prod.product_code,
                                prod.description,
                                prod.unit,
                                Convert.ToDouble(prod.selling_price).ToString("###,###,###,##0,0.00")
                                );
               
            }
            dgProductList.DataSource = dgTable;

            //STYLE GRIDVIEW
            //STYLE GRIDVIEW
            dgProductList.BorderStyle = BorderStyle.None;
            dgProductList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgProductList.Columns[0].Width = 100;
            dgProductList.Columns[1].Width = 350;
            dgProductList.Columns[2].Width = 150;
            dgProductList.Columns[3].Width = 150;
        }

        private void dgProductList_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

    }
}
