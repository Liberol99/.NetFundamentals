using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class OrderController : Controller
    {
        OrderManager orderManager = new OrderManager(new EfOrderRepository());
        CustomerManager customerManager = new CustomerManager(new EfCustomerRepository());
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeRepository());
        ShipperManager shipperManager = new ShipperManager(new EfShipperRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = orderManager.GetOrderListWithCustomerAndEmployeeAndShipper();
            return View(values);
        }
        public IActionResult Add()
        {
            var values1 = orderManager.GetListAll(); 
            var values2 = customerManager.GetListAll(); 
            var values3 = employeeManager.GetListAll(); 
            var values4 = shipperManager.GetListAll();
            var myTuple = (values1,values2,values3,values4);
            return View(myTuple);
        }
        [HttpPost]
        public IActionResult Add(Order order)
        {
            orderManager.TAdd(order);
            return RedirectToAction("Show","Order");
        }
        public IActionResult Update(int id)
        {
            var value = orderManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Order order)
        {
            orderManager.TUpdate(order);
            return View(order);
        }
        public IActionResult Delete(int id)
        {
            var value = orderManager.GetById(id);
            orderManager.TDelete(value);
            return RedirectToAction("Show", "Order");
        }
    }
}
