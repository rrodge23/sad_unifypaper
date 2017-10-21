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
                double o;
                int ex;
                Int32.TryParse(p.product_code,out ex);
                Int32.TryParse(p.quantity,out ex);
                double.TryParse(p.standard_price, out o);
                double.TryParse(p.selling_price, out o);
                Int32.TryParse(p.minimumQuantity, out ex);
                
                if(p.tax_code == "")
                {
                    Int32.TryParse(p.tax_code = "0",out ex);
                }

                if(p.supplier_contact_no == "")
                {
                    Int32.TryParse(p.supplier_contact_no = "0",out ex);
                }
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
                    sql = "INSERT INTO producttbl (category,product_code, description, minimum_qty, standard_price, selling_price,quantity,unit,tax_code,supplier_name,supplier_contact_no) VALUES (@category, @product_code,@description,@minimum_qty,@standard_price,@selling_price,@quantity,@unit,@tax_code,@supplier_name,@supplier_contact_no)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@category", p.category);
                    cmd.Parameters.AddWithValue("@product_code", p.product_code);
                    cmd.Parameters.AddWithValue("@description", p.description);
                    cmd.Parameters.AddWithValue("@minimum_qty", p.minimumQuantity);
                    cmd.Parameters.AddWithValue("@standard_price", p.standard_price);
                    cmd.Parameters.AddWithValue("@selling_price", p.selling_price);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);
                    cmd.Parameters.AddWithValue("@unit", p.unit);
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

        public bool deleteProduct(string ID)
        {

            bool isDelete = false;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM producttbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();

                    sql = "DELETE FROM producttbl WHERE ID LIKE @ID";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int delete = cmd.ExecuteNonQuery();

                    if (delete > 0)
                    {
                        isDelete = true;
                    }
                    else
                    {
                        isDelete = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return isDelete;
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
                        prod.selling_price = dr["selling_price"].ToString();
                        prod.quantity = dr["quantity"].ToString();
                        prod.unit = dr["unit"].ToString();
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

        public List<Classes.Entities.products> getAllProductListWithMinimumQuantity()
        {
            List<Classes.Entities.products> prodList = new List<Classes.Entities.products>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM producttbl WHERE quantity <= minimum_qty";
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
                        prod.selling_price = dr["selling_price"].ToString();
                        prod.quantity = dr["quantity"].ToString();
                        prod.unit = dr["unit"].ToString();
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
                string sql = "SELECT DISTINCT category FROM producttbl";
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prodCategory.Add(dr["category"].ToString());
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

        public bool updateProduct(Classes.Entities.products prod)
        {
            bool isUpdate = false;
            try
            {
                double o;
                int ex;
                Int32.TryParse(prod.product_code, out ex);
                Int32.TryParse(prod.quantity, out ex);
                double.TryParse(prod.standard_price, out o);
                double.TryParse(prod.selling_price, out o);
                Int32.TryParse(prod.minimumQuantity, out ex);
                int.TryParse(prod.tax_code, out ex);

                if (prod.tax_code == "")
                {
                    Int32.TryParse(prod.tax_code = "0", out ex);
                }

                if (prod.supplier_contact_no == "")
                {
                    Int32.TryParse(prod.supplier_contact_no = "0", out ex);
                }
                conn.Open();
                string sql = "SELECT * FROM producttbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", prod.ID);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    sql = "SELECT * FROM producttbl WHERE ID NOT LIKE @ID AND product_code=@product_code";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", prod.ID);
                    cmd.Parameters.AddWithValue("@product_code", prod.product_code);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        dr.Close();
                        sql = "UPDATE producttbl SET category=@category, product_code=@product_code, description=@description, minimum_qty=@minimum_qty, standard_price=@standard_price, selling_price=@selling_price, quantity=@quantity, unit=@unit, tax_code=@tax_code, supplier_name=@supplier_name, supplier_contact_no=@supplier_contact_no WHERE ID LIKE @ID";
                        cmd = new OleDbCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@category", prod.category);
                        cmd.Parameters.AddWithValue("@product_code", prod.product_code);
                        cmd.Parameters.AddWithValue("@description", prod.description);
                        cmd.Parameters.AddWithValue("@minimum_qty", prod.minimumQuantity);
                        cmd.Parameters.AddWithValue("@standard_price", prod.standard_price);
                        cmd.Parameters.AddWithValue("@selling_price", prod.selling_price);
                        cmd.Parameters.AddWithValue("@quantity", prod.quantity);
                        cmd.Parameters.AddWithValue("@unit", prod.unit);
                        cmd.Parameters.AddWithValue("@tax_code", prod.tax_code);
                        cmd.Parameters.AddWithValue("@supplier_name", prod.supplier_name);
                        cmd.Parameters.AddWithValue("@supplier_contact_no", prod.supplier_contact_no);
                        cmd.Parameters.AddWithValue("@ID", prod.ID);
                        int idUpdated = cmd.ExecuteNonQuery();
                        if (idUpdated > 0)
                        {
                            isUpdate = true;
                        }
                        else
                        {
                            isUpdate = false;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return isUpdate;
        }

        public List<string> getAllProdctUnit()
        {
            List<string> unit = new List<string>();
            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT unit FROM producttbl";
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        unit.Add(dr["unit"].ToString());
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

            return unit;
        }

        public List<Classes.Entities.products> getProductByMode(string inputString, string mode)
        {
            List<Classes.Entities.products> prodList = new List<Classes.Entities.products>();
            try
            {
                conn.Open();
                string sql = "";
                if(mode == "description")
                {
                     sql = "SELECT * FROM producttbl WHERE description LIKE '%"+inputString+"%'";
                }else if(mode == "category")
                {
                   
                     sql = "SELECT * FROM producttbl WHERE category='"+inputString+"'";
                }
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Classes.Entities.products prod = new Entities.products();
                        prod.ID = dr["ID"].ToString();
                        prod.category = dr["category"].ToString();
                        prod.description = dr["description"].ToString();
                        prod.product_code = dr["product_code"].ToString();
                        prod.minimumQuantity = dr["minimum_qty"].ToString();
                        prod.standard_price = dr["standard_price"].ToString();
                        prod.selling_price = dr["selling_price"].ToString();
                        prod.quantity = dr["quantity"].ToString();
                        prod.unit = dr["unit"].ToString();
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
        public Classes.Entities.products getProductByProductCode(string prod_code)
        {
           
            Classes.Entities.products prodList = new Classes.Entities.products();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM producttbl WHERE product_code=@product_code";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_code", prod_code);
                
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    prodList.ID = dr["ID"].ToString();
                    prodList.category = dr["category"].ToString();
                    prodList.description = dr["description"].ToString();
                    prodList.product_code = dr["product_code"].ToString();
                    prodList.minimumQuantity = dr["minimum_qty"].ToString();
                    prodList.standard_price = dr["standard_price"].ToString();
                    prodList.selling_price = dr["selling_price"].ToString();
                    prodList.quantity = dr["quantity"].ToString();
                    prodList.unit = dr["unit"].ToString();
                    prodList.supplier_name = dr["supplier_name"].ToString();
                    prodList.supplier_contact_no = dr["supplier_contact_no"].ToString();
                        

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
        public bool updateAllProductRowByField(string oldValue, string value, string field)
        {
            bool isProductinserted = false;
            Classes.Entities.products prod = new Entities.products();
            try
            {
                conn.Open();
                string sql = "";
               
                if(field == "category")
                {
                     sql = "UPDATE producttbl SET category=@value WHERE category=@oldValue";
                     cmd = new OleDbCommand(sql, conn);
                     cmd.Parameters.AddWithValue("@value", value);
                     cmd.Parameters.AddWithValue("@category", oldValue);
                }else if(field == "unit")
                {
                     sql = "UPDATE producttbl SET unit=@value WHERE unit=@oldValue";
                     cmd = new OleDbCommand(sql, conn);
                     cmd.Parameters.AddWithValue("@value", value);
                     cmd.Parameters.AddWithValue("@unit", oldValue);
                
                }
                
                
                int getIdUpdate = cmd.ExecuteNonQuery();
                if (getIdUpdate > 0)
                {
                    isProductinserted = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saveTransaction: " + ex.ToString());
            }
            finally
            {
                
                conn.Close();
            }
            return isProductinserted;
        }

        public List<Classes.Entities.products> SelectTransactionByID(string transaction_id)
        {
            List<Classes.Entities.products> prod = new List<Classes.Entities.products>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM transaction_itemtbl WHERE transaction_id=@transaction_id";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@transaction_id", Convert.ToInt32(transaction_id));
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Classes.Entities.products productInfo = new Classes.Entities.products();
                        productInfo.product_code = dr["product_code"].ToString();
                        productInfo.description = dr["product_description"].ToString();
                        productInfo.quantity = dr["quantity"].ToString();
                        productInfo.unit = dr["unit"].ToString();
                        productInfo.standard_price = dr["price"].ToString();
                        productInfo.selling_price = dr["total_price"].ToString();

                        prod.Add(productInfo);
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
            return prod;
        }
    }
}
