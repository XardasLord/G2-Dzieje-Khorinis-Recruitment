namespace G2.DK.Application.UseCases.Auth
{
    public class LoginCommandResponse
    {
        public string Token { get; }

        public LoginCommandResponse(string token) 
            => Token = token;
    }
}