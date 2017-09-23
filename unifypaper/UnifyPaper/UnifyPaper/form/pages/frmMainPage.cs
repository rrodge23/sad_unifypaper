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
            frmAddCategory fac = new frmAddCategory();
            fac.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProductCategory fupc = new frmUpdateProductCategory();
            fupc.ShowDialog();
        }

     

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            lvLoadProductList();
            lvsetting();
            loadData();
            lbUsername.Text = Classes.Session.sessionUsers.username;
        }

        private void lvLoadProductList()
        {
            lvProductList.Columns.Clear();

            if (lvProductList.Columns.Count <= 0)
            {
                lvProductList.Columns.Add("ID", 30);
                lvProductList.Columns.Add("Category", 100);
                lvProductList.Columns.Add("Product Code", 100);
                lvProductList.Columns.Add("Description", 100);
                lvProductList.Columns.Add("Minimum Quantity", 100);
                lvProductList.Columns.Add("Standard Price", 100);
                lvProductList.Columns.Add("Current Cost", 100);
                lvProductList.Columns.Add("Quantity", 100);
                lvProductList.Columns.Add("Tax Code", 100);
                lvProductList.Columns.Add("Supplier Name", 100);
                lvProductList.Columns.Add("Supplier Contact No.", 100);

                lvProductList.Items.Clear();

                foreach (Classes.Entities.products prod in m_prod.getAllProductList())
                {
                    ListViewItem productList = new ListViewItem();

                    productList.Text = prod.ID;
                    productList.SubItems.Add(prod.category);
                    productList.SubItems.Add(prod.product_code);
                    productList.SubItems.Add(prod.description);
                    productList.SubItems.Add(prod.minimumQuantity);
                    productList.SubItems.Add(prod.standard_price);
                    productList.SubItems.Add(prod.current_cost);
                    productList.SubItems.Add(prod.quantity);
                    productList.SubItems.Add(prod.tax_code);
                    productList.SubItems.Add(prod.supplier_name);
                    productList.SubItems.Add(prod.supplier_contact_no);
                    lvProductList.Items.Add(productList);
                }
            }
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
            frmAddCategory fac = new frmAddCategory();
            fac.ShowDialog();
        }
    }
}
