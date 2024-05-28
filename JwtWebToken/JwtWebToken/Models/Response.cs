namespace JwtWebToken.Models
{
    public class Response
    {
        public string IsOk { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public object Data { get; set; } = 0;
    }
}
