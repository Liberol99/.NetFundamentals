using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustStreetAddress { get; set; }
        public string CustCity { get; set; }
        public List<Order> Orders { get; set; }
    }
}
