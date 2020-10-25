using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWeb.Models
{
        public  class Product
    {
       
    
        public int ProductsId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public int AvailableSize { get; set; }
        public decimal Discount { get; set; }
    
        
    }
}
