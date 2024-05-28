using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class BankController : Controller
    {
        BankManager bankManager = new BankManager(new EfBankRepository());
        CustomerManager customerManager = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Show()
        {
            var values = bankManager.GetBankListWithCustomer();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var values1 = bankManager.GetListAll();
            var values2 = customerManager.GetListAll();
            var myTuple = (values1,values2);
            return View(myTuple);
        }
        [HttpPost]
        public IActionResult Add(Bank bank)
        {
            bankManager.TAdd(bank);
            return RedirectToAction("Show","Bank");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = bankManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Bank bank)
        {
            bankManager.TUpdate(bank);
            return View(bank);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = bankManager.GetById(id);
            bankManager.TDelete(value);
            return RedirectToAction("Show", "Bank");
        }
    }
}
