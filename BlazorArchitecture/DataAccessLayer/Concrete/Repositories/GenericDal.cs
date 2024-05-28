using DataAccessLayer.Abstract;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var context = new Context();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public T GetById(long recId)
        {
            using var context = new Context();
            return context.Set<T>().Find(recId);
        }

        public IEnumerable<T> GetAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            using var context = new Context();
            context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Set<T>().Update(entity);
        }
    }
}