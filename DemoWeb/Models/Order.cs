using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWeb.Models
{
   
        public  class Order
    {
     
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public decimal SalesTax { get; set; }
        public string OrderDescription { get; set; }
        public string OrderStatus { get; set; }

    }
}
