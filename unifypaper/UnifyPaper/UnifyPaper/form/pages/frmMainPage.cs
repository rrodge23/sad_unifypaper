﻿using System;
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
            sideNav1.IsMenuExpanded = false;
            btnSidenavHome.Select();

        }

        //INITIALIZE ITEMS
        public string oldProductValue { get; set; } //PRODUCT LIST
        Classes.Database.database db = new Classes.Database.database();
        Classes.Model.m_products m_prod = new Classes.Model.m_products();
        Classes.Model.m_transaction m_trans = new Classes.Model.m_transaction();
        Classes.Entities.transaction currentTransaction = new Classes.Entities.transaction();
        List<Classes.Entities.products> productList = new List<Classes.Entities.products>();

        Classes.Entities.products currentProduct = new Classes.Entities.products();

        bool isTransactionRecall = false;
        string salesReturnID = "0";
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
            displayCurrentTransactionItems();
            loadCurrentProduct();
            findTransactionProduct();
            transactionSettings();
            tbProductCode.Focus();
            dpTransactionDate.CustomFormat = "YYYY-mm-dd";
        }


        private void transactionSettings()
        {
            tbGrandtotal.Text = "";
            tbProductCode.Text = "";
            tbQty.Text = "";
            tbTransactionCash.Text = "";
            tbTransactionChange.Text = "";
            tbSubTotal.Text = "";
            tbTax.Text = "";
            lbTransactionProductDescription.Text = "";
            lbTransactionProductUnit.Text = "";
            
            dgTransactionList.BorderStyle = BorderStyle.None;
            dgTransactionList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgTransactionList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgTransactionList.DefaultCellStyle.ForeColor = Color.Black;
            dgTransactionList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgTransactionList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgTransactionList.EnableHeadersVisualStyles = false;
            dgTransactionList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgTransactionList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgTransactionList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgTransactionList.ColumnHeadersHeight = 25;
            dgTransactionList.BackgroundColor = Color.White;
            dgTransactionList.Columns[0].Width = 150;
            dgTransactionList.Columns[1].Width = 500;
            dgTransactionList.Columns[2].Width = 150;
            dgTransactionList.Columns[3].Width = 200;
            dgTransactionList.Columns[4].Width = 150;
            dgTransactionList.Columns[5].Width = 150;
        }

        private void loadCurrentProduct()
        {
            productList = m_prod.getAllProductList();
        }

        private void displayCurrentTransactionItems()
        {
            

            dgTransactionList.DataSource = null;
            calculateChange();
            DataTable dgTable = new DataTable();
            dgTable.Columns.Add("Product Code", typeof(string));
            dgTable.Columns.Add("Description", typeof(string));
            dgTable.Columns.Add("Quantity", typeof(string));
            dgTable.Columns.Add("Unit", typeof(string));
            dgTable.Columns.Add("Price", typeof(string));
            dgTable.Columns.Add("Total", typeof(string));

            
            double grandTotal = 0;

            foreach (Classes.Entities.products prod in currentTransaction.productList)
            {
              
                double totalProductPrice = Convert.ToDouble(prod.quantity) * Convert.ToDouble(prod.selling_price);
                dgTable.Rows.Add(
                                prod.product_code,
                                prod.description,
                                prod.quantity,
                                prod.unit,
                                Convert.ToDouble(prod.selling_price).ToString("###,###,###,##0,0.00"),
                                (Convert.ToDouble(prod.selling_price) * Convert.ToDouble(prod.quantity)).ToString("0.00")
                                );
                grandTotal += totalProductPrice;
            }
            dgTransactionList.DataSource = dgTable;

            //STYLE GRIDVIEW
            dgTransactionList.BorderStyle = BorderStyle.None;
            dgTransactionList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgTransactionList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgTransactionList.DefaultCellStyle.ForeColor = Color.Black;
            dgTransactionList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgTransactionList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgTransactionList.EnableHeadersVisualStyles = false;
            dgTransactionList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgTransactionList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgTransactionList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgTransactionList.BackgroundColor = Color.White;
            dgTransactionList.ColumnHeadersHeight = 25;
            dgTransactionList.Columns[0].Width = 150;
            dgTransactionList.Columns[1].Width = 500;
            dgTransactionList.Columns[2].Width = 150;
            dgTransactionList.Columns[3].Width = 200;
            dgTransactionList.Columns[4].Width = 150;
            dgTransactionList.Columns[5].Width = 150;

            //STYLE GRIDVIEW END

            double tmpProductPriceValue = Convert.ToDouble(grandTotal) * (Convert.ToDouble(12)/100.00);
            tbSubTotal.Text = (Convert.ToDouble(grandTotal) - tmpProductPriceValue).ToString("0.00");
            tbTax.Text = tmpProductPriceValue.ToString("0.00");
            tbGrandtotal.Text = grandTotal.ToString("0.00");
        }


        public void dgLoadProductList()
        {
            dgProductList.DataSource = null;
            List<Classes.Entities.products> productInfo = new List<Classes.Entities.products>();
            //if(productInfo.Count > 0)
            //{
                productInfo = m_prod.getAllProductList();
                DataTable dgTable = new DataTable();
                dgTable.Columns.Add("ID", typeof(string));
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
        }

        private void addTransactionProductItem()
        {
            if(currentProduct != null)
            {
                if (tbQty.Text.Trim() != "")
                {
                    double except;
                    Classes.Entities.products newProduct = new Classes.Entities.products(currentProduct);
                    if (tbQty.Text.Trim().Substring(0, 1) == "=")
                    {
                        
                        if (double.TryParse(tbQty.Text.Trim().Substring(1, tbQty.Text.Trim().Length - 1), out except))
                        {
                            newProduct.quantity = tbQty.Text.Trim().Substring(1,tbQty.Text.Trim().Length-1);
                        }
                        else
                        {
                            return;   
                        }
                    }
                    else
                    {
                        if (double.TryParse(tbQty.Text.Trim(), out except))
                        {
                            newProduct.quantity = tbQty.Text.Trim();
                        }
                        else
                        {
                            return;
                        }
                        
                    }
                        
                    currentTransaction.addTransactionNewProduct(newProduct);
                    currentProduct = null;
                    displayCurrentTransactionItems();
                    //FOCUS ON EXIST PRODUCT
                    if (tbProductCode.Text.Trim() != "")
                    {
                        int rowIndex = -1;
                        DataGridViewRow row = dgTransactionList.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(tbProductCode.Text)).First();
                        rowIndex = row.Index;
                        this.dgTransactionList.CurrentCell = this.dgTransactionList[0, rowIndex];
                        dgTransactionList.Rows[rowIndex].Selected = true;

                    }
                    
                    tbProductCode.Text = "";
                    lbTransactionProductDescription.Text = "";
                    tbQty.Text = "";
                    tbProductCode.Focus();
                    
                }
                else
                {
                    tbQty.Text = "1";
                    tbQty.Focus();
                }
            }
            
        }

        private void calculateChange()
        {
            double o;
            double change = 0;
            if(double.TryParse(tbTransactionCash.Text.Trim(), out o))
            {
                change = Convert.ToDouble(tbTransactionCash.Text.Trim()) - Convert.ToDouble(tbGrandtotal.Text);
            }
            tbTransactionChange.Text = change.ToString("0.00");
        }

        private void findTransactionProduct()
        {
            currentProduct = productList.ToList().Find(tempProduct => tempProduct.product_code.Equals(tbProductCode.Text.Trim()) && Convert.ToInt32(tempProduct.quantity) > 0);
          
            if (currentProduct != null)
            {
                lbTransactionProductUnit.Text = currentProduct.unit;
                lbTransactionProductDescription.Text = currentProduct.description;
                lbTransactionProductPrice.Text = Convert.ToDouble(currentProduct.selling_price).ToString("0.00");

            }
            else
            {
                lbTransactionProductUnit.Text = "";
                lbTransactionProductDescription.Text = "";
                lbTransactionProductPrice.Text = "";
            }
            
        }
        private void sideNavItem11_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem5_Click(object sender, EventArgs e)
        {
            //BUTTON ADMIN
            btnReCall.Visible = false;
            if (Classes.Session.sessionUsers.userlevel != "99")
            {
                MessageBox.Show("Only Admin is Authorize");

            }
          
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
        public void transactionTextBoxInput(string str)
        {
            tbProductCode.Text = str;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            tbProductCode.Text = "";
            frmTransactionSearchItem ftsi = new frmTransactionSearchItem();
            ftsi.mainpageForm = this;
            ftsi.ShowDialog();
            btnAddItem.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            removeItem();
        }

        private void removeItem()
        {
            if(MessageBox.Show("Remove This Item From List ?","Deleting",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                currentTransaction.productList.RemoveAt(dgTransactionList.CurrentRow.Index);
                dgTransactionList.Rows.RemoveAt(dgTransactionList.CurrentRow.Index);
                calculateChange();
            }
        }

        private void bubbleButton8_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            //BUTTON ADD
            addTransactionProductItem();
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


        private void btnTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnReCall_Click(object sender, EventArgs e)
        {
            frmReCall frc = new frmReCall();
            frc.mainpageFrm = this;
            frc.ShowDialog();
        }

        public void displaySalesReturnItems(string ID)
        {
            this.salesReturnID = ID;
            currentTransaction.productList = null;
            currentTransaction.productList = m_trans.getPreviousTransactionItemsByID(ID);
            displayCurrentTransactionItems();
            this.isTransactionRecall = true;
            
        }

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            frmTransactionOption fto = new frmTransactionOption();
            fto.ShowDialog();
        }

        private void sideNav1_Click(object sender, EventArgs e)
        {

        }

        private void sideNav1_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnSidenavHome.Focused)
            {
                btnReCall.Visible = true;
                btnTransaction.Visible = true;
            }
            else
            {
                btnTransaction.Visible = false;
                btnReCall.Visible = false;
            }
        }

        private void bubbleButton1_Click_2(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmAddNewProduct fanp = new frmAddNewProduct();
            fanp.mainpageFrm = this;
            fanp.ShowDialog();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {

        }

        private void dgProductList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (MessageBox.Show("Do You Want To Update This Record ?","Updating",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> rowItems = new List<string>();
                Classes.Entities.products prod = new Classes.Entities.products();
                foreach (DataGridViewCell cell in dgProductList.Rows[dgProductList.CurrentRow.Index].Cells)
                {
                    rowItems.Add(dgProductList.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString());
                }

                prod.ID = rowItems[0];
                prod.product_code = rowItems[1];
                prod.description = rowItems[2];
                prod.category = rowItems[3];
                prod.minimumQuantity = rowItems[4];
                prod.standard_price = rowItems[5];
                prod.selling_price = rowItems[6];
                prod.quantity = rowItems[7];
                prod.unit = rowItems[8];
                prod.tax_code = rowItems[9];
                prod.supplier_name = rowItems[10];
                prod.supplier_contact_no = rowItems[11];
                if (m_prod.updateProduct(prod))
                {
                    dgLoadProductList();
                    MessageBox.Show("Successfully Update", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    if (e.ColumnIndex == 3)
                    {
                        if (MessageBox.Show("Do you want to update all product rows in category field?", "Update Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            if (m_prod.updateAllProductRowByField(oldProductValue, dgProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "category"))
                            {
                                MessageBox.Show("Successfully Update", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                dgLoadProductList();
                               
                            }
                            else
                            {
                                MessageBox.Show("Error In Updating","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                
                            }
                            dgLoadProductList();
                        }

                    }
                    else if(e.ColumnIndex == 8)
                    {
                        if (MessageBox.Show("Do you want to update all product rows in unit field?", "Update Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (m_prod.updateAllProductRowByField(oldProductValue, dgProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "unit"))
                            {
                                MessageBox.Show("Successfully Update", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                dgLoadProductList();
                            }
                            else
                            {
                                MessageBox.Show("Error In Updating", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            dgLoadProductList();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Product Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgLoadProductList();
                }
            }
            else
            {
                dgLoadProductList();
            }

        }

        private void bubbleButton11_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
                if (MessageBox.Show("Do You Want To Delete This Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dgProductList.Rows[dgProductList.CurrentRow.Index].Cells[0].Value.ToString();
                    if (m_prod.deleteProduct(id))
                    {
                        MessageBox.Show("Successfully Deleted", "Product ID :" + id, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgLoadProductList();
                    }
                }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbProductCode_TextChanged(object sender, EventArgs e)
        {
            findTransactionProduct();
            
        }

        private void tbTransactionCash_TextChanged(object sender, EventArgs e)
        {
            calculateChange();
        }

        private void frmMainPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void sideNav2_Click(object sender, EventArgs e)
        {

        }

        private void frmMainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbProductCode.Text != "")
                {
                    addTransactionProductItem();
                }
                else
                {
                    if (tbQty.Text.Trim() != "")
                    {
                        double o;
                        if(tbQty.Text.ToString().Substring(0,1) == "=")
                        {
                            if (double.TryParse(tbQty.Text.ToString().Substring(1, tbQty.Text.ToString().Length-1), out o))
                            {
                                if(dgTransactionList.Rows.Count > 0)
                                {
                                    List<string> rowItems = new List<string>();

                                    foreach (DataGridViewCell cell in dgTransactionList.Rows[dgTransactionList.CurrentRow.Index].Cells)
                                    {
                                        rowItems.Add(dgTransactionList.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString());
                                    }
                                    this.currentProduct = new Classes.Entities.products();
                                    this.currentProduct.product_code = rowItems[0];
                                    this.currentProduct.description = rowItems[1];
                                    this.currentProduct.unit = rowItems[3];
                                    this.currentProduct.selling_price = rowItems[4];
                                    addTransactionProductItem();
                                }
                            }
                        }
                        
                    }
                    {
                        btnTransactionTender.PerformClick();
                    }
                    
                }
            }
            
            if (e.KeyCode == Keys.Delete)
            {

                removeItem();
            }

            if (e.KeyCode == Keys.Space)
            {
                btnSearchItem.PerformClick();
            }
        }

        private void dgTransactionList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbTransactionProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbProductCode_Enter(object sender, EventArgs e)
        {
            tbProductCode.Text = "";
        }

        private void clearField()
        {
            currentTransaction.clearFields();
            displayCurrentTransactionItems();
            lbTransactionProductDescription.Text = "";
            lbTransactionProductPrice.Text = "";
            lbTransactionProductUnit.Text = "";
            tbGrandtotal.Text = "";
            tbProductCode.Text = "";
            tbQty.Text = "";
            tbSubTotal.Text = "";
            tbTax.Text = "";
            tbTransactionCash.Text = "";
            tbTransactionChange.Text = "";
            tbProductCode.Focus();
        }
        private void btnTransactionTender_Click(object sender, EventArgs e)
        {
            if (tbTransactionCash.Text != "")
            {
                double o;
                if (double.TryParse(tbTransactionCash.Text.Trim(), out o))
                {
                    double transactionCashValue = Convert.ToDouble(tbTransactionCash.Text.Trim());
                    if (transactionCashValue > 0)
                    {
                        if(MessageBox.Show("Continue Transaction ?","Confirm Transaction",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (transactionCashValue >= Convert.ToDouble(tbGrandtotal.Text))
                            {
                                currentTransaction.transaction_cashier = Classes.Session.sessionUsers.username;
                                currentTransaction.transaction_time = dpTransactionDate.Value.ToString();
                                currentTransaction.transaction_date = dpTransactionDate.Value.ToString();
                                currentTransaction.transaction_cash = Convert.ToDouble(tbTransactionCash.Text.Trim());
                                currentTransaction.transaction_change = Convert.ToDouble(tbTransactionChange.Text.Trim());
                                currentTransaction.transaction_total_amount = Convert.ToDouble(tbGrandtotal.Text);
                                if (isTransactionRecall == false)
                                {
                                    
                                    int isTendered = m_trans.transactionTender(currentTransaction);
                                    if (isTendered > 0)
                                    {
                                        MessageBox.Show("Transaction Success ! TRANSACTION ID: " + isTendered);
                                        dgLoadProductList();
                                    }
                                    clearField();
                                }
                                else
                                {
                                    Classes.Entities.transaction salesReturnTrans = new Classes.Entities.transaction();
                                    salesReturnTrans = m_trans.getPreviousTransactionByID(this.salesReturnID);
                                    currentTransaction.ID = this.salesReturnID;
                                    if(salesReturnTrans.transaction_total_amount <= Convert.ToDouble(tbGrandtotal.Text))
                                    {
                                        m_trans.transactionUpdate(currentTransaction);
                                        MessageBox.Show("Successfull");
                                        isTransactionRecall = false;
                                        clearField();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Total Amount should be lesser than previous total amount");
                                    }
                                    

                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("cash must be greater than the total amount");
                            }
                        }
                        else
                        {
                            if(this.isTransactionRecall == true)
                            {
                                currentTransaction.productList = null;
                                this.isTransactionRecall = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("cash must be non-negative value");
                    }
                }
                else
                {
                    MessageBox.Show("Only Digit inputs are Allowed");
                }
            }
            else
            {
                tbTransactionCash.Focus();
            }
        }

        private void tbTransactionCash_TextChanged_1(object sender, EventArgs e)
        {
            if(tbTransactionCash.Text.Trim() != "")
            {
                double o;

                if(double.TryParse(tbTransactionCash.Text.Trim(),out o) && tbGrandtotal.Text != "")
                {
                    if (Convert.ToDouble(tbTransactionCash.Text.Trim().ToString()) >= Convert.ToDouble(tbGrandtotal.Text.ToString()))
                    {
                        tbTransactionChange.Text = (Convert.ToDouble(tbTransactionCash.Text.Trim()) - Convert.ToDouble(tbGrandtotal.Text)).ToString("0.00");
                    }
                }
            }
            
        }

        private void dgTransactionList_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void dgTransactionList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbQty.Focus();
        }

        private void btnSidenavHome_Click(object sender, EventArgs e)
        {
            loadCurrentProduct();
            btnReCall.Visible = true;
        }

        private void dgTransactionList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dgProductList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldProductValue = dgProductList.Rows[dgProductList.CurrentRow.Index].Cells[dgProductList.CurrentCell.ColumnIndex].Value.ToString();
        }

        private void dgProductList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bubbleBar1_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmAddAccount fac = new frmAddAccount();
            fac.mainPageFrm = this;
            fac.ShowDialog();
        }

        private void btnDelete_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if(lvUser.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Do you want to delete this record ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ID = lvUser.SelectedItems[0].Text.ToString();
                    if (db.deleteUserByID(ID))
                    {
                        MessageBox.Show("User Successfuly DELETED !","DELETED !",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        loadData();
                    }
                    
                }
            }
        }

        
    }
}
