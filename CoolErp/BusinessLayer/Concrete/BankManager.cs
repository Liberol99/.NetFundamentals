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
    public class BankManager : IBankService
    {
        IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public List<Bank> GetBankListWithCustomer()
        {
            return _bankDal.GetBankListWithCustomer();
        }

        public Bank GetById(int id)
        {
            return _bankDal.GetById(id);
        }

        public List<Bank> GetListAll()
        {
            return _bankDal.GetListAll();
        }

        public List<Bank> GetListAll(Expression<Func<Bank, bool>> filter)
        {
            return _bankDal.GetListAll(filter);
        }

        public void TAdd(Bank t)
        {
            _bankDal.Insert(t);
        }

        public void TDelete(Bank t)
        {
            _bankDal.Delete(t);
        }

        public void TUpdate(Bank t)
        {
            _bankDal.Update(t);
        }
    }
}
