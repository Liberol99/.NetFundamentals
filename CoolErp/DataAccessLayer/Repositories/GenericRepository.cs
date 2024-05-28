using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            var value = c.Set<T>().Find(id);
            return value;
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            var values = c.Set<T>().ToList();
            return values;
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            var values = c.Set<T>().Where(filter).ToList();
            return values;
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Set<T>().Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
    }
}
