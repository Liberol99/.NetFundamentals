using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = customerManager.GetListAll();
            return View(values);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            customerManager.TAdd(customer);
            return RedirectToAction("Show", "Customer");
        }
        public IActionResult Update(int id)
        {
            var value = customerManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            customerManager.TUpdate(customer);
            return View(customer);
        }
        public IActionResult Delete(int id)
        {
            var value = customerManager.GetById(id);
            customerManager.TDelete(value);
            return View();
        }
    }
}
