using MediatR;

namespace G2.DK.Application.UseCases.Characters
{
    public class AddCharacterCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
