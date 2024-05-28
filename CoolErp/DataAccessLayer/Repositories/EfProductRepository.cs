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
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductListByCategoryAndSupplier()
        {
            using var context = new Context();
            var values = context.Set<Product>().Include("Category").Include("Supplier").ToList();
            return values;
        }
    }
}
