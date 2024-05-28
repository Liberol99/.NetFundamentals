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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public List<Order> GetListAll()
        {
            return _orderDal.GetListAll();
        }

        public List<Order> GetListAll(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.GetListAll(filter);
        }

        public List<Order> GetOrderListWithCustomerAndEmployeeAndShipper()
        {
            return _orderDal.GetOrderListWithCustomerAndEmployeeAndShipper();
        }

        public void TAdd(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
