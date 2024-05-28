using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using EntityLayer.Concrete;
using BusinessLayer.Abstract;
using BusinessLayer.AdoNet;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace ErpIntro.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAdoService _adoService;

        public LoginController(IProductService productService, IConfiguration configuration, IAdoService adoService)
        {
            _configuration = configuration;
            _adoService = adoService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser != null && claimUser.Identity != null && claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Employee employee)
        {
            DataTable dTable = _adoService.SelectQuery($"select top 1 RoleName from Roles where RoleID = (select top 1 RoleID from Employees where Email = '{employee.Email}' and Password='{employee.Password}')");

            if (dTable != null && dTable.Rows.Count > 0 && dTable.Rows[0] != null && dTable.Columns.Contains("RoleName") && dTable.Rows[0]["RoleName"]!=null)
            {
                string roleName = dTable.Rows[0]["RoleName"].ToString();
                if (string.IsNullOrEmpty(roleName)) return View();

                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, employee.Email),
                    new Claim(ClaimTypes.Role,roleName)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = employee.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "Kullanıcı bulunamadı !";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
