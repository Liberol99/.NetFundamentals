using Microsoft.AspNetCore.Identity;

namespace CoolBlog.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
    }
}
