using ApiLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiLayer.Repositories
{
    public class AccountingManager : IAccountingService
    {
        public void AddAccounting(Accounting accounting)
        {
            using var c = new Context();
            c.Set<Accounting>().Add(accounting);
            c.SaveChanges();
        }

        public void DeleteAccounting(int id)
        {
            using var c = new Context();
            var value = c.Set<Accounting>().Find(id);
            c.Set<Accounting>().Remove(value);
            c.SaveChanges();
        }

        public Accounting GetAccounting(int id)
        {
            using var c = new Context();
            return c.Set<Accounting>().Find(id);
        }

        public List<Accounting> GetAllAccounting()
        {
            using var c = new Context();
            return c.Set<Accounting>().ToList();
        }

        public void UpdateAccounting(Accounting accounting)
        {
            using var c = new Context();
            c.Set<Accounting>().Update(accounting);
            c.SaveChanges();
        }
    }
}