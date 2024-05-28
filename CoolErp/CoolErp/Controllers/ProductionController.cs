using BusinessLayer.Concrete;
using CoolErp.Models;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CoolErp.Controllers
{
    public class ProductionController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult DailyPrice(int sayi1=1,decimal sayi2=1,decimal sayi3 = 1,decimal sayi4 = 1,decimal sayi5 = 1,decimal sayi6 = 1,decimal sayi7 = 1,decimal sayi8 = 1)
        {
            var value = productManager.GetById(sayi1);
            var Price = value.UnitPrice;
            var toplam = (sayi2 * Price) + (sayi3 * Price) + (sayi4 * Price) + (sayi5 * Price) + (sayi6 * Price) + (sayi7 * Price) + (sayi8 * Price);
            ViewBag.toplam = Math.Round(toplam,2);
            var values = productManager.GetProductListByCategoryAndSupplier();
            ViewBag.x1 = sayi2;
            ViewBag.x2 = sayi3;
            ViewBag.x3 = sayi4;
            ViewBag.x4 = sayi5;
            ViewBag.x5 = sayi6;
            ViewBag.x6 = sayi7;
            ViewBag.x7 = sayi8;
            return View(values);
        }
    }
}
