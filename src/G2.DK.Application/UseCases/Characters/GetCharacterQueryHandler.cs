using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using G2.DK.Domain.Aggregates.Character;
using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class GetCharacterQueryHandler : IRequestHandler<GetCharacterQuery, CharacterDto>
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public GetCharacterQueryHandler(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        public async Task<CharacterDto> Handle(GetCharacterQuery query, CancellationToken cancellationToken)
        {
            var character = await _characterRepository.Get(query.CharacterId);

            return _mapper.Map<CharacterDto>(character);
        }
    }
}