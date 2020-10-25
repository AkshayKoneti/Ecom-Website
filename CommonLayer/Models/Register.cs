using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
  public  class Register
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string PrimaryAddress1 { get; set; }
        public string PrimaryAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
