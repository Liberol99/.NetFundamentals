using CoolBlog.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoolBlog.Controllers
{

    public class UserLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public UserLoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModelViewModel userSignInModelViewModel)
        {
            if (ModelState.IsValid) 
            { 
                var result = await _signInManager.PasswordSignInAsync(userSignInModelViewModel.UserName, userSignInModelViewModel.Password,true,true);
                if (result.Succeeded)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,userSignInModelViewModel.UserName)
                    };
                    var useridentity = new ClaimsIdentity(claims,"y");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return RedirectToAction("Index", "UserLogin");
                }
            }
            return View();
        }
    }
}
