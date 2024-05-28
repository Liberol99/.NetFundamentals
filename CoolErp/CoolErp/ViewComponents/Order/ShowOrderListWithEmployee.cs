using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolErp.ViewComponents.Order
{
    public class ShowOrderListWithEmployee : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.OrderCount = c.Orders.Count();
            ViewBag.ProductCount = c.Products.Count();
            ViewBag.CustomerCount = c.Customers.Count();
            ViewBag.SupplierCount = c.Suppliers.Count();

            return View();
        }
    }
}
