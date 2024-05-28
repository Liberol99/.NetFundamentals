using CoolSales.Models;
using CoolSales.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Concrete
{
    public class ProductManager : IProductService
    {
        public void AddValue(Product t)
        {
            using var c = new Context();
            c.Set<Product>().Add(t);
            c.SaveChanges();
        }

        public void DeleteValue(int id)
        {
            using var c = new Context();
            var value = c.Set<Product>().Find(id);
            c.Set<Product>().Remove(value);
            c.SaveChanges();
        }

        public List<Product> GetAll()
        {
            using var c = new Context();
            //var values = c.Set<Product>().Include("Category").Include("Vendor").Select(x => new Product(){ProductId=x.ProductId ,ProductName=x.ProductName, ProductDescription=x.ProductDescription, QuantityOnHand=x.QuantityOnHand, RetailPrice=x.RetailPrice, CategoryId=x.CategoryId, VendorId = x.VendorId}).ToList();
            return c.Set<Product>().ToList();
            //return values;
        }

        

        public Product GetValue(int id)
        {
            using var c = new Context();
            return c.Set<Product>().Find(id);
        }

        public void UpdateValue(Product t)
        {
            using var c = new Context();
            c.Set<Product>().Update(t);
            c.SaveChanges();
        }
    }
}
