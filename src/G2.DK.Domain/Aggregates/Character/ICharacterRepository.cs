using System.Collections.Generic;
using System.Threading.Tasks;

namespace G2.DK.Domain.Aggregates.Character
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetAll();
        Task<Character> Get(int characterId);
        Task<int> Add(Character character);
    }
}
