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
        //MINIMUM PRODUCT ITEM QUANTITY
        public string quantity { get; set; }

        //
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
            initiateLoadProductList();
        }

        public void initiateLoadProductList()
        {
            dgProductList.DataSource = null;

            //if(productInfo.Count > 0)
            //{
            productList = m_prod.getAllProductListWithMinimumQuantity();
            DataTable dgTable = new DataTable();
            addDgProductColumn(dgTable);
            for (int i = 0; i < productList.Count; i++)
            {

                dgTable.Rows.Add(productList[i].ID,
                    productList[i].product_code,
                    productList[i].description,
                    productList[i].category,
                    productList[i].minimumQuantity,
                    productList[i].standard_price,
                    productList[i].selling_price,
                    productList[i].quantity,
                    productList[i].unit,
                    productList[i].tax_code,
                    productList[i].supplier_name,
                    productList[i].supplier_contact_no
                    
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
            if(e.ColumnIndex == 12 && e.RowIndex >= 0)
            {
                
                if(e.RowIndex != dgProductList.Rows.Count-1)
                {
                    frmProductExportQuantity fpeq = new frmProductExportQuantity();
                    fpeq.ShowDialog();
                    double o;
                    if (Double.TryParse(fpeq.quantity, out o) && fpeq.quantity != "0")
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
                        p.quantity = fpeq.quantity;
                        p.unit = dgProductList.Rows[e.RowIndex].Cells[8].Value.ToString();
                        p.tax_code = dgProductList.Rows[e.RowIndex].Cells[9].Value.ToString();
                        p.supplier_name = dgProductList.Rows[e.RowIndex].Cells[10].Value.ToString();
                        p.supplier_contact_no = dgProductList.Rows[e.RowIndex].Cells[11].Value.ToString();
                        dgProductList.Rows.RemoveAt(e.RowIndex);
                        productList.Remove(productList.ToList().Find(tmp => tmp.ID.Equals(p.ID)));
                        AddedProductList.Add(p);
                        loadAddedProductList();
                    }
                    else
                    {
                        MessageBox.Show("Quantity Should be a number");
                    }
                   
                    
                }
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
            if(e.ColumnIndex == 12 && e.RowIndex >= 0)
            {
                if(e.RowIndex != dgAddedProductMinimumQuantity.Rows.Count-1)
                {
                    Classes.Entities.products p = new Classes.Entities.products();
                    Classes.Entities.products addedP = new Classes.Entities.products();

                    p.ID = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[0].Value.ToString();
                    p.product_code = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[1].Value.ToString();
                    p.description = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[2].Value.ToString();
                    p.minimumQuantity = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[3].Value.ToString();
                    p.category = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[4].Value.ToString();
                    p.standard_price = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[5].Value.ToString();
                    p.selling_price = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[6].Value.ToString();
                    Classes.Entities.products tmpProd = new Classes.Entities.products();
                    tmpProd = m_prod.getProductByProductCode(p.product_code);
                    p.quantity = tmpProd.quantity; 
                    p.unit = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[8].Value.ToString();
                    p.tax_code = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[9].Value.ToString();
                    p.supplier_name = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[10].Value.ToString();
                    p.supplier_contact_no = dgAddedProductMinimumQuantity.Rows[e.RowIndex].Cells[11].Value.ToString();
                    dgAddedProductMinimumQuantity.Rows.RemoveAt(e.RowIndex);
                    AddedProductList.Remove(AddedProductList.ToList().Find(tmp => tmp.ID.Equals(p.ID)));
                    productList.Add(p);
                    loadProductList();
                    
                }
            }
        }

        private void loadProductList()
        {
            dgProductList.DataSource = null;
            dgProductList.Columns.Clear();
            DataTable tb = new DataTable();
            addDgProductColumn(tb);
            foreach (Classes.Entities.products prod in productList)
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

            dgProductList.DataSource = tb;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnAddItem";
            btn.Text = "Add";
            btn.UseColumnTextForButtonValue = true;
            dgProductList.Columns.Add(btn);
        }

        private void loadAddedProductList()
        {
            dgAddedProductMinimumQuantity.DataSource = null;
            dgAddedProductMinimumQuantity.Columns.Clear();
            DataTable tb = new DataTable();
            addDgProductColumn(tb);
            foreach (Classes.Entities.products prod in AddedProductList)
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

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            //BUTTON ADD ALL
            foreach(Classes.Entities.products prod in productList)
            {
                AddedProductList.Add(prod);
            }
            productList.Clear();
            dgProductList.DataSource = null;
            dgProductList.Columns.Clear();
            loadAddedProductList();
            DataTable tb = new DataTable();
            addDgProductColumn(tb);
            dgProductList.DataSource = tb;
      
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ///BUTTON REMOVE ALL
            foreach(Classes.Entities.products prod in AddedProductList)
            {
                productList.Add(prod);
            }
            dgAddedProductMinimumQuantity.DataSource = null;
            dgAddedProductMinimumQuantity.Columns.Clear();
            loadProductList();
            AddedProductList.Clear();
            
            DataTable tb = new DataTable();
            addDgProductColumn(tb);
            dgAddedProductMinimumQuantity.DataSource = tb;
            
        }

        private void btnPrintItems_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_3(object sender, PaintEventArgs e)
        {

        }

    }
}
