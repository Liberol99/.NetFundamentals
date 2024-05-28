using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoolErp.Controllers
{
    public class SalesController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult Index(int sayi1=1,decimal sayi2 = 1)
        {
            using var c = new Context();
            decimal value = c.Products.Where(x => x.ProductId == sayi1).Select(x => x.UnitsInStock).FirstOrDefault();
            var value2 = productManager.GetById(sayi1);
            //tek bir kolonu güncellemek için değerlerin aynı kalması lazım
            Product product = new Product();
            product.ProductName = value2.ProductName;
            product.ProductId = value2.ProductId;
            product.UnitsInStock = Convert.ToInt32((Convert.ToDecimal(value2.UnitsInStock) - sayi2));
            product.UnitsOnOrder = value2.UnitsOnOrder;
            product.SupplierId = value2.SupplierId;
            product.CategoryId = value2.CategoryId;
            product.Discounted = value2.Discounted;
            product.QuantityPerUnit = value2.QuantityPerUnit;
            product.UnitsInCost = value2.UnitsInCost;
            product.UnitPrice = value2.UnitPrice;
            productManager.TUpdate(product);
            ViewBag.kalan = product.UnitsInStock;
            ViewBag.ad = value2.ProductName;
            ViewBag.kdv = Convert.ToInt32(value2.UnitPrice*(Convert.ToDecimal((0.018))+sayi2));
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }
    }
}
