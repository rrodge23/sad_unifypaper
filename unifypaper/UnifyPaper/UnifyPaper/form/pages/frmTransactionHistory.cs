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
    public partial class frmTransactionHistory : Form
    {
        public frmTransactionHistory()
        {
            InitializeComponent();
        }
        Classes.Model.m_products m_prod = new Classes.Model.m_products();
        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();
        Classes.Entities.transaction currentTransaction = new Classes.Entities.transaction();
        List<Classes.Entities.products> productList = new List<Classes.Entities.products>();
        public string ID { get; set; }
        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            dgvTransactionList();
        }

        public void dgvTransactionList()
        {
            dgvTransactionDetails.DataSource = null;
            List<Classes.Entities.products> prodInfo = new List<Classes.Entities.products>();
            //if(productInfo.Count > 0)
            //{
           
            prodInfo = m_prod.SelectTransactionByID(this.ID);
            DataTable dgTable = new DataTable();
            dgTable.Columns.Add("Product Code", typeof(string));
            dgTable.Columns.Add("Description", typeof(string));
            dgTable.Columns.Add("Quantity", typeof(string));
            dgTable.Columns.Add("Unit", typeof(string));
            dgTable.Columns.Add("Price", typeof(string));
            dgTable.Columns.Add("Total Price", typeof(string));

            foreach (Classes.Entities.products i in prodInfo)
            {
                MessageBox.Show(i.description);
                dgTable.Rows.Add(i.product_code,
                    i.description,
                    i.quantity,
                    i.unit,
                    i.standard_price,
                    i.selling_price);
            }
            dgvTransactionDetails.DataSource = dgTable;
        }
    }

    
}
