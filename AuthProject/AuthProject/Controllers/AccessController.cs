using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AuthProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthProject.Controllers
{
    [AllowAnonymous]
    public class AccessController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser != null && claimUser.Identity != null && claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            VMLogin[] vMLogins = new VMLogin[] {
                new VMLogin(){Email="orkan.koroglu@sentez.com",PassWord="1905",Role="Admin" },
                new VMLogin(){Email="semih.ciftci@sentez.com",PassWord="1903",Role="User" },
            };
            
            if (vMLogins.Any(x=>x.Email == modelLogin.Email && x.PassWord == modelLogin.PassWord))
            {
                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim(ClaimTypes.Role,vMLogins.FirstOrDefault(x=>x.Email == modelLogin.Email && x.PassWord == modelLogin.PassWord).Role)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "Kullanıcı bulunamadı !";
            return View();
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
