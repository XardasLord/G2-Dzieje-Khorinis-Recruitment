using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class GetCharacterQuery : IRequest<CharacterDto>
    {
        public int CharacterId { get; set; }
    }
}