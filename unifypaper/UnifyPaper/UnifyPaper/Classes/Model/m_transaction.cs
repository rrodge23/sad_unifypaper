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
                cmd.Parameters.AddWithValue("@transaction_cash", Convert.ToDouble(trans.transaction_cash));
                cmd.Parameters.AddWithValue("@transaction_change", Convert.ToDouble(trans.transaction_change));
                cmd.Parameters.AddWithValue("@transaction_total_amount", Convert.ToDouble(trans.transaction_total_amount));
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
                    int quantity = 0;
                    if (dr.HasRows)
                    {
                        dr.Read();
                        quantity = Convert.ToInt32(dr["quantity"])- Convert.ToInt32(t.quantity);
                        dr.Close();
                    }

                    sql = "UPDATE producttbl SET quantity=@quantity WHERE product_code=@product_code";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
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

        public int transactionUpdate(Classes.Entities.transaction trans)
        {
            int transactionID = 0;
            try
            {

                conn.Open();
                string sql = "UPDATE transactiontbl SET transaction_date=@transaction_date,transaction_time=@transaction_time,transaction_cash=@transaction_cash,transaction_change=@transaction_change,transaction_total_amount=@transaction_total_amount,transaction_cashier=@transaction_cashier WHERE ID=@ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@transaction_date", trans.transaction_date);
                cmd.Parameters.AddWithValue("@transaction_time", trans.transaction_time);
                cmd.Parameters.AddWithValue("@transaction_cash", Convert.ToDouble(trans.transaction_cash));
                cmd.Parameters.AddWithValue("@transaction_change", Convert.ToDouble(trans.transaction_change));
                cmd.Parameters.AddWithValue("@transaction_total_amount", Convert.ToDouble(trans.transaction_total_amount));
                cmd.Parameters.AddWithValue("@transaction_cashier", trans.transaction_cashier);
                cmd.Parameters.AddWithValue("@ID", trans.ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show(trans.ID);
                sql = "DELETE FROM transaction_itemtbl WHERE transaction_id=@ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", trans.ID);
                cmd.ExecuteNonQuery();
                foreach (Classes.Entities.products t in trans.productList)
                {
                    sql = "INSERT INTO transaction_itemtbl (transaction_id,product_code,product_description,quantity,unit,price,total_price) VALUES (@transaction_id,@product_code,@product_description,@quantity,@unit,@price,@total_price)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@transaction_id", trans.ID);
                    cmd.Parameters.AddWithValue("@product_code", t.product_code);
                    cmd.Parameters.AddWithValue("@product_description", t.description);
                    cmd.Parameters.AddWithValue("@quantity", t.quantity);
                    cmd.Parameters.AddWithValue("@unit", t.unit);
                    cmd.Parameters.AddWithValue("@price", t.selling_price);
                    cmd.Parameters.AddWithValue("@total_price", Convert.ToDouble(t.selling_price) * Convert.ToDouble(t.quantity));
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

        public string getLatestTransactionID()
        {
            string transactionID = "";
            
            try
            {
                conn.Open();
                string sql = "SELECT * FROM transactiontbl ORDER By ID DESC";
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    transactionID = dr["ID"].ToString();
                
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

            return transactionID;
        }

        public Classes.Entities.transaction getPreviousTransactionByID(string ID)
        {
            Classes.Entities.transaction trans = new Entities.transaction();

            try
            {
                int o;
                double oo;
                if (Int32.TryParse(ID, out o))
                {
                    conn.Open();
                    string sql = "SELECT * FROM transactiontbl WHERE ID=@ID";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID",ID);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        
                        trans.ID = dr["ID"].ToString();
                        trans.transaction_date = dr["transaction_date"].ToString();
                        trans.transaction_time = dr["transaction_time"].ToString();
                        trans.transaction_change = Convert.ToDouble(dr["transaction_change"]);
                        trans.transaction_cash = Convert.ToDouble(dr["transaction_cash"]);
                        trans.transaction_total_amount = Convert.ToDouble(dr["transaction_total_amount"]);
                        trans.transaction_cashier = dr["transaction_cashier"].ToString();

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

            return trans;
        }

        public List<Classes.Entities.products> getPreviousTransactionItemsByID(string ID)
        {
            List<Classes.Entities.products> prodList = new List<Classes.Entities.products>();

            try
            {
                int o;

                if (Int32.TryParse(ID, out o))
                {
                    conn.Open();
                    string sql = "SELECT * FROM transaction_itemtbl WHERE transaction_id=@ID";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Classes.Entities.products p = new Entities.products();
                            p.ID = dr["ID"].ToString();
                            p.product_code = dr["product_code"].ToString();
                            p.description = dr["product_description"].ToString();
                            p.quantity = dr["quantity"].ToString();
                            p.unit = dr["unit"].ToString();
                            p.selling_price = dr["price"].ToString();

                            prodList.Add(p);
                        }
                        

                    }
                }else
                {
                    MessageBox.Show("input should be numerical");
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

        public bool deleteTransaction(int ID)
        {

            bool isDelete = false;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM transactiontbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();

                    sql = "DELETE FROM transactiontbl WHERE ID LIKE @ID";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int delete = cmd.ExecuteNonQuery();

                    if (delete > 0)
                    {
                        sql = "DELETE FROM transaction_itemtbl WHERE transaction_id=@id";
                        cmd = new OleDbCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        int delete_item = cmd.ExecuteNonQuery();
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

    }
}
