namespace AuthProject.Models
{
    public class VMLogin
    {
        public string Email { get; set; } = string.Empty;
        public string PassWord { get; set; } = string.Empty;
        public bool KeepLoggedIn { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
