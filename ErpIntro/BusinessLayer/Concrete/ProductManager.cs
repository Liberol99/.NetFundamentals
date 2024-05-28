using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _producDal;

        public ProductManager(IProductDal producDal)
        {
            _producDal = producDal;
        }

        public void Delete(Product t)
        {
            _producDal.Delete(t);
        }

        public Product GetById(int id)
        {
            return _producDal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _producDal.GetListAll();
        }

        public List<Product> GetListAll(Expression<Func<Product, bool>> filter)
        {
            return _producDal.GetListAll(filter);
        }

        public void Insert(Product t)
        {
            _producDal.Insert(t);
        }

        public void Update(Product t)
        {
            _producDal.Update(t);
        }
    }
}
