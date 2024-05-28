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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> GetListAll()
        {
            return _customerDal.GetListAll();
        }

        public List<Customer> GetListAll(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.GetListAll(filter);
        }

        public void Insert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
