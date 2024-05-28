using BusinessLayer.Abstract;
using BusinessLayer.AdoNet;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Validators;
using ErpIntro.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ErpIntro.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IProductService _productService;
        private readonly IAdoService _adoService;
        private readonly CustomerValidator _validator;

        public HomeController(IProductService productService, IConfiguration configuration, IAdoService adoService, CustomerValidator validator)
        {
            _productService = productService;
            _configuration = configuration;
            _adoService = adoService;
            _validator = validator;
        }

        public IActionResult Index()
        {
            string query = "select top 20 p.ProductName,c.CategoryName FROM Products p left join Categories c on c.CategoryID = p.CategoryID";
            return View(_adoService.SelectQuery(query));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CustomerVal(Customer customer)
        {
            ValidationResult validationResult = _validator.Validate(customer);

            if (validationResult.IsValid)
            {
                // Doğrulama başarılı, işlemi devam ettir
                return RedirectToAction("Index");
            }
            else
            {
                // Doğrulama başarısız, hataları göster
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(customer); // Hatalı girişlerle aynı sayfaya geri dön
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Theme()
        {
            return View();
        }
    }
}