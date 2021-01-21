using System.Threading;
using System.Threading.Tasks;
using G2.DK.Domain.Aggregates.Character;
using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class AddCharacterCommandHandler : IRequestHandler<AddCharacterCommand, int>
    {
        private readonly ICharacterRepository _characterRepository;

        public AddCharacterCommandHandler(ICharacterRepository characterRepository)
            => _characterRepository = characterRepository;

        public async Task<int> Handle(AddCharacterCommand command, CancellationToken cancellationToken)
        {
            var characterToAdd = Character.Create(command.Name, command.Description);

            var characterId = await _characterRepository.Add(characterToAdd);

            return characterId;
        }
    }
}