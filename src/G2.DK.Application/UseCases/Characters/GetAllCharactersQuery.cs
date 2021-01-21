using System.Collections.Generic;
using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class GetAllCharactersQuery : IRequest<IEnumerable<CharacterDto>>
    {
    }
}
