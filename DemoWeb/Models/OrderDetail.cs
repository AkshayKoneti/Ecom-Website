using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWeb.Models
{
        public  class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductsId { get; set; }
        public int Quantity { get; set; }
    
    }
}
