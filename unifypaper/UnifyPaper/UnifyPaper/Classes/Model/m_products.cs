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

    }
}
