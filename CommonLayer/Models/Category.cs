using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Desribtion { get; set; }
        public string Active { get; set; }
        public virtual ICollection<Product> Products { get; set; }


    }
}
