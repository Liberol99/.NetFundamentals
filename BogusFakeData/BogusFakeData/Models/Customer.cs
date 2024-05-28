using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BogusFakeData.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
    }
}