using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWeb.Models
{
    public class Auction
    {
        public long id { get; set; }
        public String  Catagory { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
    }
}