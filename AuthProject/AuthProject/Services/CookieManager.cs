using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;

namespace AuthProject.Services
{
    public class CookieManager : ICookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetCookie(string key, string value, DateTime expires)
        {
            if (_httpContextAccessor == null || _httpContextAccessor.HttpContext == null) return;
            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, new CookieOptions
            {
                Expires = expires,
                HttpOnly = true
            });
        }

        public string GetCookie(string key)
        {
            if (_httpContextAccessor == null || _httpContextAccessor.HttpContext == null || _httpContextAccessor.HttpContext.Request == null || _httpContextAccessor.HttpContext.Request.Cookies == null || _httpContextAccessor.HttpContext.Request.Cookies.Count() < 0 && !_httpContextAccessor.HttpContext.Request.Cookies.ContainsKey(key) || _httpContextAccessor.HttpContext.Request.Cookies[key] == null || string.IsNullOrEmpty(_httpContextAccessor.HttpContext.Request.Cookies[key])) return "Value Null";
            return _httpContextAccessor.HttpContext.Request.Cookies[key];
        }

        public void DeleteCookie(string key)
        {
            if (_httpContextAccessor == null || _httpContextAccessor.HttpContext == null) return;
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
