using System;
using System.Threading;
using System.Threading.Tasks;
using G2.DK.Application.Auth;
using G2.DK.Domain.Aggregates.User;
using MediatR;

namespace G2.DK.Application.UseCases.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;

        public LoginCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand query, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(query.Login)
                       ?? throw new Exception("Invalid credentials.");

            if (!PasswordManager.VerifyHashedPassword(user.Password, query.Password))
                throw new Exception("Invalid credentials.");

            var token = _authService.GenerateSecurityToken(user.Id, user.Login);

            return new LoginCommandResponse(token);
        }
    }
}