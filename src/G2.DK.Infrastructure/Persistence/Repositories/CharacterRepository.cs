using System.Collections.Generic;
using System.Threading.Tasks;
using G2.DK.Domain.Aggregates.Character;
using G2.DK.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace G2.DK.Infrastructure.Persistence.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly G2DbContext _dbContext;

        public CharacterRepository(G2DbContext dbContext) 
            => _dbContext = dbContext;

        public async Task<IEnumerable<Character>> GetAll() 
            => await _dbContext.Characters.ToListAsync();

        public async Task<Character> Get(int characterId)
            => await _dbContext.Characters.FirstOrDefaultAsync(x => x.Id == characterId);

        public async Task<int> Add(Character character)
        {
            _dbContext.Characters.Add(character);
            await _dbContext.SaveChangesAsync();

            return character.Id;
        }
    }
}
