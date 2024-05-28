using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class OrderDetailController : Controller
    {
        OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailRepository());
        OrderManager orderManager = new OrderManager(new EfOrderRepository());
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = orderDetailManager.GetOrderDetailWithOrderAndProduct();
            return View(values);
        }
        public IActionResult Add()
        {
            var values1 = orderManager.GetListAll();
            var values2 = productManager.GetListAll();
            var myTuple = (values1, values2);
            return View(myTuple);
        }
        [HttpPost]
        public IActionResult Add(OrderDetail orderDetail)
        {
            orderDetailManager.TAdd(orderDetail);
            return RedirectToAction("Show","OrderDetail");
        }
        public IActionResult Update(int id)
        {
            var value = orderDetailManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(OrderDetail orderDetail)
        {
            orderDetailManager.TUpdate(orderDetail);
            return View(orderDetail);
        }
        public IActionResult Delete(int id)
        {
            var value = orderDetailManager.GetById(id);
            orderDetailManager.TDelete(value);
            return RedirectToAction("Show", "OrderDetail");
        }
    }
}
