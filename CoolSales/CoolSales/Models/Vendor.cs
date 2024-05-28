using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendName { get; set; }
        public string VendStreetAddress { get; set; }
        public string VendCity { get; set; }
        public string VendState { get; set; }
        public string VendZipCode { get; set; }
        public string VendPhoneNumber { get; set; }
        public string VendFaxNumber { get; set; }
        public string VendWebPage { get; set; }
        public string VendEmailAddress { get; set; }
        public List<Product> Products { get; set; }
    }
}
