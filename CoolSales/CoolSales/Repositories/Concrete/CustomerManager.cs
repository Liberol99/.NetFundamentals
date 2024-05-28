using CoolSales.Models;
using CoolSales.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void AddValue(Customer t)
        {
            using var c = new Context();
            c.Set<Customer>().Add(t);
            c.SaveChanges();
        }

        public void DeleteValue(int id)
        {
            using var c = new Context();
            var value = c.Set<Customer>().Find(id);
            c.Set<Customer>().Remove(value);
            c.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            using var c = new Context();
            return c.Set<Customer>().ToList();
        }

        public Customer GetValue(int id)
        {
            using var c = new Context();
            return c.Set<Customer>().Where(x => x.CustomerId == id).FirstOrDefault();
        }

        public void UpdateValue(Customer t)
        {
            using var c = new Context();
            c.Set<Customer>().Update(t);
            c.SaveChanges();
        }
    }
}
