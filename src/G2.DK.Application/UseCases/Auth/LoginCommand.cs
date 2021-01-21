using MediatR;

namespace G2.DK.Application.UseCases.Auth
{
    public class LoginCommand : IRequest<LoginCommandResponse>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}