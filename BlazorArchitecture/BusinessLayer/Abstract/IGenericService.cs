namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void Update(T entity);
        public T GetById(long recId);
        public IEnumerable<T> GetAll();
    }
}