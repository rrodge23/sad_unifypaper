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
                tmpProduct.quantity += prod.quantity;
            }
        }

    }
}
