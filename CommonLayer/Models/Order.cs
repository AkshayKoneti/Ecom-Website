using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{

    public  class Order
    {
     
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public decimal SalesTax { get; set; }
        public string OrderDescription { get; set; }
        public string OrderStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Register Register { get; set; }
    }
}
