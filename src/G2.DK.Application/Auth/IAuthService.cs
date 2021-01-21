namespace G2.DK.Application.Auth
{
    public interface IAuthService
    {
        string GenerateSecurityToken(long userId, string login);
    }
}
