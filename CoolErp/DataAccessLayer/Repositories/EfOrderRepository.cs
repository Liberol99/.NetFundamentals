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
    public class EfOrderRepository : GenericRepository<Order>, IOrderDal
    {
        public List<Order> GetOrderListWithCustomerAndEmployeeAndShipper()
        {
            using var c = new Context();
            var values = c.Set<Order>().Include("Customer").Include("Employee").Include("Shipper").ToList();
            return values;        
        }
    }
}
