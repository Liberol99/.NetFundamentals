using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.ViewComponents.Product
{
    public class ShowProducts : ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }
    }
}
