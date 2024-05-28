using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SupplierManager : ISuppliersService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public Supplier GetById(int id)
        {
            return _supplierDal.GetById(id);
        }

        public List<Supplier> GetListAll()
        {
            return _supplierDal.GetListAll();
        }

        public List<Supplier> GetListAll(Expression<Func<Supplier, bool>> filter)
        {
            return _supplierDal.GetListAll(filter);
        }

        public void TAdd(Supplier t)
        {
            _supplierDal.Insert(t);
        }

        public void TDelete(Supplier t)
        {
            _supplierDal.Delete(t);
        }

        public void TUpdate(Supplier t)
        {
            _supplierDal.Update(t);
        }
    }
}
