using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EfBankRepository : GenericRepository<Bank>, IBankDal
    {
        public List<Bank> GetBankListWithCustomer()
        {
            using var c = new Context();
            var values = c.Set<Bank>().Include("Customer").ToList();
            return values;
        }
    }
}
