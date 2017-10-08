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
    public partial class frmViewBelowMinimumProducts : Form
    {
        public frmViewBelowMinimumProducts()
        {
            InitializeComponent();
        }

        List<Classes.Entities.products> productList = new List<Classes.Entities.products>();
        List<Classes.Entities.products> AddedProductList = new List<Classes.Entities.products>();
        Classes.Model.m_products m_prod = new Classes.Model.m_products();

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmViewBelowMinimumProducts_Load(object sender, EventArgs e)
        {
            loadProductList();
        }

        public void loadProductList()
        {
           
            dgProductList.DataSource = null;
            List<Classes.Entities.products> productInfo = new List<Classes.Entities.products>();
            //if(productInfo.Count > 0)
            //{
            productInfo = m_prod.getAllProductListWithMinimumQuantity();
            DataTable dgTable = new DataTable();
            addDgProductColumn(dgTable);
            for (int i = 0; i < productInfo.Count; i++)
            {
                
                dgTable.Rows.Add(productInfo[i].ID,
                    productInfo[i].product_code,
                    productInfo[i].description,
                    productInfo[i].category,
                    productInfo[i].minimumQuantity,
                    productInfo[i].standard_price,
                    productInfo[i].selling_price,
                    productInfo[i].quantity,
                    productInfo[i].unit,
                    productInfo[i].tax_code,
                    productInfo[i].supplier_name,
                    productInfo[i].supplier_contact_no
                    
                    );
            }
            
            
            dgProductList.DataSource = dgTable;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnAddItem";
            btn.Text = "Add";
            btn.UseColumnTextForButtonValue = true;
            dgProductList.Columns.Add(btn);
            
            //ADDED DATAGRID
            DataTable dgDataTable = new DataTable();
            addDgProductColumn(dgDataTable);
            dgAddedProductMinimumQuantity.DataSource = dgDataTable;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Action";
            btn1.Name = "btnRemoveItem";
            btn1.Text = "Remove";
            btn1.UseColumnTextForButtonValue = true;
            dgAddedProductMinimumQuantity.Columns.Add(btn1);
        }

        
        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 12)
            {
                
                Classes.Entities.products p = new Classes.Entities.products();
                Classes.Entities.products addedP = new Classes.Entities.products();

                p.ID = dgProductList.Rows[e.RowIndex].Cells[0].Value.ToString();
                p.product_code = dgProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
                p.description = dgProductList.Rows[e.RowIndex].Cells[2].Value.ToString();
                p.minimumQuantity = dgProductList.Rows[e.RowIndex].Cells[3].Value.ToString();
                p.category = dgProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
                p.standard_price = dgProductList.Rows[e.RowIndex].Cells[5].Value.ToString();
                p.selling_price = dgProductList.Rows[e.RowIndex].Cells[6].Value.ToString();
                p.quantity = dgProductList.Rows[e.RowIndex].Cells[7].Value.ToString();
                p.unit = dgProductList.Rows[e.RowIndex].Cells[8].Value.ToString();
                p.tax_code = dgProductList.Rows[e.RowIndex].Cells[9].Value.ToString();
                p.supplier_name = dgProductList.Rows[e.RowIndex].Cells[10].Value.ToString();
                p.supplier_contact_no = dgProductList.Rows[e.RowIndex].Cells[11].Value.ToString();
                dgProductList.Rows.RemoveAt(e.RowIndex);
                productList.Remove(productList.ToList().Find(tmp => tmp.ID.Equals(p.ID)));
                AddedProductList.Add(p);

                dgAddedProductMinimumQuantity.DataSource = null;
                dgAddedProductMinimumQuantity.Columns.Clear();
                DataTable tb = new DataTable();
                addDgProductColumn(tb);
                foreach(Classes.Entities.products prod in AddedProductList)
                {
                    tb.Rows.Add(prod.ID,
                                prod.product_code,
                                prod.description,
                                prod.category,
                                prod.minimumQuantity,
                                prod.standard_price,
                                prod.selling_price,
                                prod.quantity,
                                prod.unit,
                                prod.tax_code,
                                prod.supplier_name,
                                prod.supplier_contact_no
                               );
                 
                }
                dgAddedProductMinimumQuantity.DataSource = tb;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Action";
                btn.Name = "btnRemoveItem";
                btn.Text = "Remove";
                btn.UseColumnTextForButtonValue = true;
                dgAddedProductMinimumQuantity.Columns.Add(btn);
            }
        }

        private void addDgProductColumn(DataTable table)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Product Code", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Minimum Quantity", typeof(string));
            table.Columns.Add("Standard Price", typeof(string));
            table.Columns.Add("Selling Price", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Unit", typeof(string));
            table.Columns.Add("Tax Code", typeof(string));
            table.Columns.Add("Supplier Name", typeof(string));
            table.Columns.Add("Supplier Contact No.", typeof(string));
        }

        private void dgAddedProductMinimumQuantity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 12)
            {

            }
        }

    }
}
