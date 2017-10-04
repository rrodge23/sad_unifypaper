using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifyPaper.Classes.Entities
{
    class transaction
    {
        public transaction()
        {

        }
        public string ID { get; set; }
     
        private string transaction_dateContainer;
        public string transaction_date { 
            get { return this.transaction_dateContainer; } 
            set { DateTime date = Convert.ToDateTime(value);
                transaction_dateContainer = date.ToString("yyyy-MM-dd");
            } 
        }
        private string transaction_timeContainer;
        public string transaction_time
        {
            get { return this.transaction_timeContainer; }
            set
            {
                DateTime date = Convert.ToDateTime(value);
                transaction_timeContainer = date.ToString("HH:mm:ss");
            }
        }
        public int transaction_items { get; set; }
        public double transaction_cash { get; set; }
        public double transaction_total_amount { get; set; }
        public string transaction_cashier { get; set; }

        private List<products> productListContainer = new List<products>();

        public List<products> productList { 
            get {return this.productListContainer;} 
            set {this.productListContainer = value;} 
        }

        public int getTransactionProductQuantityByID(string ID)
        {
            products findProduct = new products();
            findProduct = this.productListContainer.ToList().Find(tempProduct => tempProduct.ID.Equals(ID));
            if (findProduct != null)
            {
                return Convert.ToInt32(findProduct.quantity);
            }
            else
            {
                return 0;
            }

        }

        public void addTransactionNewProduct(products prod)
        {
            if (this.productListContainer.ToList().FindAll(tempProduct => tempProduct.product_code.Equals(prod.product_code)).Count < 1)
            {
                this.productListContainer.Add(prod);
            }
            else
            {
                products tmpProduct = new products();
                tmpProduct = this.productListContainer.ToList().Find(tempProduct => tempProduct.product_code.Equals(prod.product_code));
                tmpProduct.quantity = prod.quantity;
            }
        }

        public void clearFields()
        {
            this.productListContainer.Clear();
        }

    }
}
