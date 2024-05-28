using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.ViewComponents.Waybill
{
    public class ShowTable : ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }
    }
}
