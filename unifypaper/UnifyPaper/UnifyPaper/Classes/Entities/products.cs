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
    }   
}
