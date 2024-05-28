using CoolSales.Models;
using CoolSales.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public void AddValue(Category t)
        {
            using var c = new Context();
            c.Set<Category>().Add(t);
            c.SaveChanges();
        }

        public void DeleteValue(int id)
        {
            using var c = new Context();
            var value = c.Set<Category>().Find(id);
            c.Set<Category>().Remove(value);
            c.SaveChanges();
        }

        public List<Category> GetAll()
        {
            using var c = new Context();
            return c.Set<Category>().ToList();
        }

        public Category GetValue(int id)
        {
            using var c = new Context();
            return c.Set<Category>().Where(x=>x.CategoryId==id).FirstOrDefault();
        }

        public void UpdateValue(Category t)
        {
            using var c = new Context();
            c.Set<Category>().Update(t);
            c.SaveChanges();
        }
    }
}
