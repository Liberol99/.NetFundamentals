using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BogusFakeData.Models
{
    public class CustomerAddress
    {
        public long AddressId { get; set; }
        public string Address { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}