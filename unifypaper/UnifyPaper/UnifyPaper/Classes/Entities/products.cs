using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifyPaper.Classes.Entities
{
    class products
    {
        public string ID { get; set; }
        public string category { get; set; }
        public string product_code { get; set; }
        public string description { get; set; }
        public string minimumQuantity { get; set; }
        public string standard_price { get; set; }
        public string selling_price { get; set; }
        public string quantity { get; set; }
        public string unit { get; set; }
        public string tax_code { get; set; }
        public string supplier_name { get; set; }
        public string supplier_contact_no { get; set; }
        public products()
        {

        }
        public products(products p)
        {
            this.ID = p.ID;
            this.category = p.category;
            this.product_code = p.product_code;
            this.description = p.description;
            this.minimumQuantity = p.minimumQuantity;
            this.standard_price = p.standard_price;
            this.selling_price = p.selling_price;
            this.quantity = p.quantity;
            this.unit = p.unit;
            this.tax_code = p.tax_code;
            this.supplier_name = p.supplier_name;
            this.supplier_contact_no = p.supplier_contact_no;
        }
    }   
}
