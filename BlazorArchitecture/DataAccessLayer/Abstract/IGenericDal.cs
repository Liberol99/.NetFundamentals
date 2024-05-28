namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Remove(T entity);
        public T GetById(long recId);
        public IEnumerable<T> GetAll();
    }
}