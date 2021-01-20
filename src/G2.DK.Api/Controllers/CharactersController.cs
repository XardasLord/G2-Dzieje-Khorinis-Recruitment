using System.Threading.Tasks;
using G2.DK.Application.UseCases.Characters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace G2.DK.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CharactersController(IMediator mediator)
            => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacter(int id)
            => Ok(await _mediator.Send(new GetCharacterQuery { CharacterId = id }));

        [HttpGet]
        public async Task<IActionResult> GetCharacters()
            => Ok(await _mediator.Send(new GetAllCharactersQuery()));

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterCommand command)
        {
            var characterId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetCharacter), new { id = characterId }, characterId);
        }
    }
}
