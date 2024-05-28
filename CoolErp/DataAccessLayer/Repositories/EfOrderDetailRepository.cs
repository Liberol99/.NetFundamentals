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
    public class EfOrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailDal
    {
        public List<OrderDetail> GetOrderDetailWithOrderAndProduct()
        {
            using var c = new Context();
            var values = c.Set<OrderDetail>().Include("Order").Include("Product").ToList();
            return values;
        }
    }
}
