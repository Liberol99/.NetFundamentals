using Bogus;
using CoolSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.BogusData
{
    public class FakeData
    {
        public static void CreateFakeData()
        {
            var productFaker = new Faker<Product>("en")
            .RuleFor(i => i.ProductName, i => i.Commerce.ProductName())
            .RuleFor(i => i.ProductDescription, i => i.Commerce.ProductDescription())
            .RuleFor(i => i.RetailPrice, i => i.Commerce.Price(5, 1000, 2).First())
            .RuleFor(i => i.QuantityOnHand, i => i.Finance.CreditCardCvv());


            List<Product> products = productFaker.Generate(20);

            using var c = new Context();
            c.Products.AddRange(products);
            c.SaveChanges();
        }
    }
}
