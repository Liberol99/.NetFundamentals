using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [AllowNull]
        public int VendorId { get; set; }
        [AllowNull]
        public Vendor Vendor { get; set; }
        [AllowNull]
        public int CategoryId { get; set; }
        [AllowNull]
        public Category Category { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal RetailPrice { get; set; }
        public string QuantityOnHand { get; set; }
        [AllowNull]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
