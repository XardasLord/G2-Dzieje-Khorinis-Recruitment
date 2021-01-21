using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using G2.DK.Domain.Aggregates.Character;
using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class GetAllCharactersQueryHandler : IRequestHandler<GetAllCharactersQuery, IEnumerable<CharacterDto>>
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public GetAllCharactersQueryHandler(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CharacterDto>> Handle(GetAllCharactersQuery request, CancellationToken cancellationToken)
        {
            var characters = await _characterRepository.GetAll();

            var characterDtos = _mapper.Map<IEnumerable<CharacterDto>>(characters);

            return characterDtos;
        }
    }
}