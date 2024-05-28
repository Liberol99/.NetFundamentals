using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoolErp.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Employee employee)
        {
            using var c = new Context();
            var value = c.Set<Employee>().Where(x => x.Mail == employee.Mail && x.Password == employee.Password).FirstOrDefault();
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,employee.Mail)
                };
                var useridentity = new ClaimsIdentity(claims,"y");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }
    }
}




//Context c = new Context();
//var value = c.Set<Employee>().Where(x => x.Mail == employee.Mail && x.Password == employee.Password).FirstOrDefault();
//if (value != null)
//{
//    HttpContext.Session.SetString("username", employee.Mail);
//    return RedirectToAction("Index", "Home");
//}
//else
//{
//    return View();
//}