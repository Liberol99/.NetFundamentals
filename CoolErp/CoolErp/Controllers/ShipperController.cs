using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class ShipperController : Controller
    {
        ShipperManager shipperManager = new ShipperManager(new EfShipperRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = shipperManager.GetListAll();
            return View(values);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Shipper shipper)
        {
            shipperManager.TAdd(shipper);
            return RedirectToAction("Show","Shipper");
        }
        public IActionResult Update(int id)
        {
            var value = shipperManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Shipper shipper)
        {
            shipperManager.TUpdate(shipper);
            return View(shipper);

        }
        public IActionResult Delete(int id)
        {
            var value = shipperManager.GetById(id);
            shipperManager.TDelete(value);
            return RedirectToAction("Show","Shipper");
        }
    }
}
