using JwtWebToken.Models;

namespace JwtWebToken.Services
{
    public interface ITokenService
    {
        public Token CreateToken(IConfiguration configuration);
    }
}
