using System.Threading.Tasks;
using G2.DK.Application.UseCases.Auth;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace G2.DK.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator) 
            => _mediator = mediator;

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<string>> Login(LoginCommand command)
            => Ok(await _mediator.Send(command));
    }
}
