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

        private void lvsetting()
        {
            lvUser.Columns.Clear();

            if (lvUser.Columns.Count <= 0)
            {
                lvUser.Columns.Add("ID", 30);
                lvUser.Columns.Add("fullname", 100);
                lvUser.Columns.Add("username", 100);
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
                lv.SubItems.Add(u.username);
                lv.SubItems.Add(u.userlevel);

                lvUser.Items.Add(lv);
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
            frmUpdateAccount faa = new frmUpdateAccount();
            faa.ShowDialog();
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
            
            lvsetting();
            loadData();
            lbUsername.Text = Classes.Session.sessionUsers.username;
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

        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

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
    }
}
