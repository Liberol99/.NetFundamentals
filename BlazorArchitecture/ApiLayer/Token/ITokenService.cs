namespace ApiLayer.Token
{
    public interface ITokenService
    {
        public Token CreateToken(IConfiguration configuration);
    }
}
