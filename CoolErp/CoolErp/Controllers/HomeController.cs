using BusinessLayer.Concrete;
using CoolErp.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoolErp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ProductManager productManager = new ProductManager(new EfProductRepository());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[AllowAnonymous]
        public IActionResult Index()
        {
            //Sisteme giriş yapan kişinin MAil'i bulunuyor.
            var usermail = User.Identity.Name;
            using var c = new Context();
            var EmployeeId = c.Set<Employee>().Where(x => x.Mail == usermail).Select(y=>y.EmployeeId).FirstOrDefault();
            var value = c.Employees.Find(EmployeeId);
            ViewBag.empId = EmployeeId;
            return View(value);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
