using Bogus;
using BogusFakeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace BogusFakeData
{
    public partial class _Default : Page
    {
        public static List<Customer> customerData { get; set; }
        public static List<CustomerAddress> addressData { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (customerData == null || customerData.Count() <= 0)
            {
                var faker = new Faker();
                var customerAddress = new Faker<CustomerAddress>()
                                    .RuleFor(c => c.AddressId, (f, c) => f.IndexFaker + 1)
                                    .RuleFor(c => c.Address, (f, c) => f.Address.StreetAddress(true));

                var customers = new Faker<Customer>()
                                    .RuleFor(c => c.CustomerId, (f, c) => f.IndexFaker + 1)
                                    .RuleFor(c => c.Name, (f, c) => f.Name.FullName())
                                    .RuleFor(c => c.Email, (f, c) => f.Internet.Email())
                                    .RuleFor(c => c.CustomerAddresses, f => customerAddress.Generate(f.Random.Int(min: 1, max: 5)));

                customerData = customers.Generate(10);
                addressData = customerAddress.Generate(10);
            }            
        }
    }
}