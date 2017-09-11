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
                    sql = "INSERT INTO producttbl (product_code, description, standard_price, current_cost,quantity,tax_code,supplier_name,supplier_contact_no) VALUES (@product_code,@description,@standard_price,@current_cost,@quantity,@tax_code,@supplier_name,@supplier_contact_no)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@product_code", p.product_code);
                    cmd.Parameters.AddWithValue("@description", p.description);

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

    }
}
