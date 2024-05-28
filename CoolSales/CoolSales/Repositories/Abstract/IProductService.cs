using CoolSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        //List<Product> GetProductsWithCategoryAndVendor();
    }
}
