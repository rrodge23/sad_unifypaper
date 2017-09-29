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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        Classes.Database.database db = new Classes.Database.database();
        Classes.Model.m_products m_prod = new Classes.Model.m_products();
        private void lvsetting()
        {
            lvUser.Columns.Clear();

            if (lvUser.Columns.Count <= 0)
            {
                lvUser.Columns.Add("ID", 30);
                lvUser.Columns.Add("fullname", 100);
                lvUser.Columns.Add("schedule", 100);
                lvUser.Columns.Add("userlevel", 75);
            }
        }

        private void showNewAccount()
        {
            frmAddAccount faa = new frmAddAccount();
            faa.mainPageFrm = this;
            faa.ShowDialog();
        }

        public void loadData()
        {
            lvUser.Items.Clear();

            foreach (Classes.Entities.users u in db.getAllUser())
            {
                ListViewItem lv = new ListViewItem();

                lv.Text = u.ID;
                lv.SubItems.Add(u.fullname);
                lv.SubItems.Add(u.schedule);
                lv.SubItems.Add(u.userlevel);

                lvUser.Items.Add(lv);
            }
        }

        private void deleteData()
        {
            if (lvUser.Items.Count > 0)
            {
                if (lvUser.SelectedItems.Count > 0)
                {

                    if (MessageBox.Show("Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.deleteUserByID(lvUser.FocusedItem.Text);
                        loadData();
                    }
                }
            }
        }

        private void sideNavItem4_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem7_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void bubbleBar3_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            showNewAccount();
        }

        private void btnUpdateAccount_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnUpdateProduct_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProduct fup = new frmUpdateProduct();
            fup.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void btnUpdateCategory_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProductCategory fupc = new frmUpdateProductCategory();
            fupc.ShowDialog();
        }

     

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            dgLoadProductList();
            lvsetting();
            loadData();
            lbUsername.Text = Classes.Session.sessionUsers.username;
        }

        private void dgLoadProductList()
        {
            dgProductList.Rows.Clear();
            List<Classes.Entities.products> productInfo = new List<Classes.Entities.products>();
            //if(productInfo.Count > 0)
            //{
                productInfo = m_prod.getAllProductList();
                DataTable dgTable = new DataTable();
                dgTable.Columns.Add("ID", typeof(int));
                dgTable.Columns.Add("Product Code", typeof(string));
                dgTable.Columns.Add("Description", typeof(string));
                dgTable.Columns.Add("Category", typeof(string));
                dgTable.Columns.Add("Minimum Quantity", typeof(string));
                dgTable.Columns.Add("Standard Price", typeof(string));
                dgTable.Columns.Add("Selling Price", typeof(string));
                dgTable.Columns.Add("Quantity", typeof(string));
                dgTable.Columns.Add("Unit", typeof(string));
                dgTable.Columns.Add("Tax Code", typeof(string));
                dgTable.Columns.Add("Supplier Name", typeof(string));
                dgTable.Columns.Add("Supplier Contact No.", typeof(string));
                for(int i=0; i< productInfo.Count;i++)
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
                        productInfo[i].supplier_contact_no);  
                }
                dgProductList.DataSource = dgTable;
            //}
            
         
        }


        private void sideNavItem11_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem5_Click(object sender, EventArgs e)
        {
           
        }

        private void sideNavItem1_Click(object sender, EventArgs e)
        {

        }

        private void bubbleButton4_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmAddNewProduct fanp = new frmAddNewProduct();
            fanp.ShowDialog();
        }

        private void sideNavPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //UpdateUser
            frmUpdateAccount fua = new frmUpdateAccount();
            fua.ShowDialog();
        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //Delete Portion
            deleteData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmItemList fil = new frmItemList();
            fil.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {

        }

        private void bubbleButton8_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void bubbleButton10_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProduct fup = new frmUpdateProduct();
            fup.ShowDialog();
        }

        private void bubbleButton8_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmViewBelowMinimumProducts fvbmp = new frmViewBelowMinimumProducts();
            fvbmp.ShowDialog();
        }

        private void bubbleButton7_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmNewUserLevel fnul = new frmNewUserLevel();
            fnul.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            frmChangePassword fcp = new frmChangePassword();
            fcp.ShowDialog();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmChangeCashier fcc = new frmChangeCashier();
            fcc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelEx6_Click(object sender, EventArgs e)
        {

        }

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bubbleButton1_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
          
        }

        private void sideNav1_Click(object sender, EventArgs e)
        {

        }
    }
}
