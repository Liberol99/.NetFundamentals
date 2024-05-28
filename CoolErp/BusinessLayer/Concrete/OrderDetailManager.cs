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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public OrderDetail GetById(int id)
        {
            var value = _orderDetailDal.GetById(id);
            return value;
        }

        public List<OrderDetail> GetListAll()
        {
            var values = _orderDetailDal.GetListAll();
            return values;
        }

        public List<OrderDetail> GetListAll(Expression<Func<OrderDetail, bool>> filter)
        {
            var values = _orderDetailDal.GetListAll(filter);
            return values;
        }

        public List<OrderDetail> GetOrderDetailWithOrderAndProduct()
        {
            var values = _orderDetailDal.GetOrderDetailWithOrderAndProduct();
            return values;
        }

        public void TAdd(OrderDetail t)
        {
            _orderDetailDal.Insert(t);
        }

        public void TDelete(OrderDetail t)
        {
            _orderDetailDal.Delete(t);
        }

        public void TUpdate(OrderDetail t)
        {
            _orderDetailDal.Update(t);
        }
    }
}
