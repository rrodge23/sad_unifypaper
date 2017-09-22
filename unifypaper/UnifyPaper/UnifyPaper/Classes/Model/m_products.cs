using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UnifyPaper.Classes.Model
{
    class m_products : Classes.Database.database
    {
        public m_products()
        {

        }

        public bool addNewProduct(Classes.Entities.products p)
        {
            int isProductInserted = 0;
            try 
	        {	        
		        conn.Open();
                string sql = "SELECT * FROM producttbl WHERE product_code LIKE @product_code";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_code", p.product_code);             
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int qty = Convert.ToInt32(dr["quantity"]);
                    dr.Close();
                    int sumProductQuantity = qty + Convert.ToInt32(p.quantity);
                    sql = "UPDATE producttbl SET quantity=@quantity WHERE product_code LIKE @product_code";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@quantity", sumProductQuantity.ToString());
                    cmd.Parameters.AddWithValue("@product_code", p.product_code);
                    int isUpdate = cmd.ExecuteNonQuery();
                    if (isUpdate <= 0)
                    {
                        isProductInserted = 0;
                    }
                    else 
                    {
                        isProductInserted = 1;
                    }

                }
                else
                {
                    dr.Close();
                    sql = "INSERT INTO producttbl (category,product_code, description, minimum_qty, standard_price, current_cost,quantity,tax_code,supplier_name,supplier_contact_no) VALUES (@category, @product_code,@description,@minimum_qty,@standard_price,@current_cost,@quantity,@tax_code,@supplier_name,@supplier_contact_no)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@category", p.category);
                    cmd.Parameters.AddWithValue("@product_code", p.product_code);
                    cmd.Parameters.AddWithValue("@description", p.description);
                    cmd.Parameters.AddWithValue("@minimum_qty", p.minimumQuantity);
                    cmd.Parameters.AddWithValue("@standard_price", p.standard_price);
                    cmd.Parameters.AddWithValue("@current_cost", p.current_cost);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);
                    cmd.Parameters.AddWithValue("@tax_code", p.tax_code);
                    cmd.Parameters.AddWithValue("@supplier_name", p.supplier_name);
                    cmd.Parameters.AddWithValue("@supplier_contact_no", p.supplier_contact_no);
                    isProductInserted = cmd.ExecuteNonQuery();

                }
	        }
	        catch (Exception e)
	        {
		        MessageBox.Show("Error: " + e);
	        }
            finally
            {
                dr.Close();
                conn.Close();
            }
            if (isProductInserted <= 0)
            {
                return false;
            }
            else 
            {
                return true;
            }

            
        }


        public string addProductCategory(string categoryName) {
            string isProductCategoryAdded = "";
            try
            {
                conn.Open();
                string sql = "SELECT * FROM product_categorytbl WHERE category_name LIKE @category_name";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@category_name", categoryName);
                dr = cmd.ExecuteReader();
                int isCategoryInserted = 0;
                if (dr.HasRows)
                {
                    isProductCategoryAdded = "Product Category Already Exist.";
                }
                else
                {
                    dr.Close();
                    sql = "INSERT INTO product_categorytbl (category_name) VALUES (@category_name)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@category_name", categoryName);

                    isCategoryInserted = cmd.ExecuteNonQuery();

                }
                if (!(isCategoryInserted > 0))
                {
                    isProductCategoryAdded = "0";
                }
                else
                {
                    isProductCategoryAdded = "Category Successfully Added !";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }    
                
            return isProductCategoryAdded;
        }

        public List<Classes.Entities.products> getAllProductList()
        {
            List<Classes.Entities.products> prodList = new List<Classes.Entities.products>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM producttbl";
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Classes.Entities.products prod = new Entities.products();
                        prod.ID = dr["ID"].ToString();
                        prod.category = dr["category"].ToString();
                        prod.product_code = dr["product_code"].ToString();
                        prod.description = dr["description"].ToString();
                        prod.minimumQuantity = dr["minimum_qty"].ToString();
                        prod.standard_price = dr["standard_price"].ToString();
                        prod.current_cost = dr["standard_price"].ToString();
                        prod.quantity = dr["quantity"].ToString();
                        prod.tax_code = dr["tax_code"].ToString();
                        prod.supplier_name = dr["supplier_name"].ToString();
                        prod.supplier_contact_no = dr["supplier_contact_no"].ToString();
                        prodList.Add(prod);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return prodList;
        }

        public List<string> getAllProductCategory()
        {
            List<string> prodCategory = new List<string>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM product_categorytbl";
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prodCategory.Add(dr["category_name"].ToString());
                    }
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }

            return prodCategory;
        }

    }
}
