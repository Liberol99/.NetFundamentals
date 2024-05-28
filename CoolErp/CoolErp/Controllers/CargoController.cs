using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class CargoController : Controller
    {
        ShipperManager shipperManager = new ShipperManager(new EfShipperRepository());
        ProductManager productManager = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {
            var values = shipperManager.GetListAll();
            var values2 = productManager.GetListAll();
            var myTuple = (values,values2);
            return View(myTuple);
        }
        public IActionResult Show(string string1,int sayi1)
        {
            var value = productManager.GetById(sayi1);
            ViewBag.shipperName = string1;
            return View(value);
        }
    }
}
