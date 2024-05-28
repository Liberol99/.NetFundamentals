using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Bank
    {
        public int BankId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal PaymentAmount { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime Expiration { get; set; }

    }
}
