namespace AuthProject.Services
{
    public interface ICookieService
    {
        public void SetCookie(string key, string value, DateTime expires);
        public string GetCookie(string key);
        public void DeleteCookie(string key);
    }
}