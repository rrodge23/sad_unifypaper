using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UnifyPaper.Classes.Model
{
    class m_transaction : Classes.Database.database
    {
        public m_transaction()
        {

        }

        public int transactionTender(Classes.Entities.transaction trans)
        {
            int transactionID = 0;
            try
            {
                conn.Open();
                string sql = "INSERT INTO transactiontbl (transaction_date,transaction_time,transaction_cash,transaction_change,transaction_total_amount,transaction_cashier) VALUES (@transaction_date,@transaction_time,@transaction_cash,@transaction_change,@transaction_total_amount,@transaction_cashier)";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@transaction_date", trans.transaction_date);
                cmd.Parameters.AddWithValue("@transaction_time", trans.transaction_time);
                cmd.Parameters.AddWithValue("@transaction_cash", trans.transaction_cash);
                cmd.Parameters.AddWithValue("@transaction_change", trans.transaction_change);
                cmd.Parameters.AddWithValue("@transaction_total_amount", trans.transaction_total_amount);
                cmd.Parameters.AddWithValue("@transaction_cashier", trans.transaction_cashier);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";
                int last_insert = Convert.ToInt32(cmd.ExecuteScalar());
                transactionID = Convert.ToInt32(last_insert);
                foreach (Classes.Entities.products t in trans.productList)
                {
                    sql = "INSERT INTO transaction_itemtbl (transaction_id,product_code,product_description,quantity,unit,price,total_price) VALUES (@transaction_id,@product_code,@product_description,@quantity,@unit,@price,@total_price)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@transaction_id", last_insert);
                    cmd.Parameters.AddWithValue("@product_code", t.product_code);
                    cmd.Parameters.AddWithValue("@product_description", t.description);
                    cmd.Parameters.AddWithValue("@quantity", t.quantity);
                    cmd.Parameters.AddWithValue("@unit", t.unit);
                    cmd.Parameters.AddWithValue("@price", t.selling_price);
                    cmd.Parameters.AddWithValue("@total_price", Convert.ToDouble(t.selling_price) * Convert.ToDouble(t.quantity));
                    cmd.ExecuteNonQuery();

                    sql = "SELECT * FROM producttbl WHERE product_code=@product_code";
                    cmd = new OleDbCommand(sql,conn);
                    cmd.Parameters.AddWithValue("@product_code", t.product_code);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        int quantity = Convert.ToInt32(dr["quantity"]);
                        dr.Close();
                    }

                    sql = "UPDATE producttbl SET quantity=@quantity WHERE product_code=@product_code";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@quantity", t.quantity);
                    cmd.Parameters.AddWithValue("@product_code", t.product_code);
                    cmd.ExecuteNonQuery();
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
            return transactionID;
        }

        

    }
}
