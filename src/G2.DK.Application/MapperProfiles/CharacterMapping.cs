using AutoMapper;
using G2.DK.Application.UseCases.Characters;
using G2.DK.Domain.Aggregates.Character;

namespace G2.DK.Application.MapperProfiles
{
    public class CharacterMapping : Profile
    {
        public CharacterMapping()
        {
            CreateMap<Character, CharacterDto>();
        }
    }
}
