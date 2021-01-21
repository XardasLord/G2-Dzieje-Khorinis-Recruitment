using System.Threading.Tasks;
using G2.DK.Domain.Aggregates.User;
using G2.DK.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace G2.DK.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly G2DbContext _dbContext;

        public UserRepository(G2DbContext dbContext) 
            => _dbContext = dbContext;

        public Task<User> Get(string login)
            => _dbContext.Users.SingleOrDefaultAsync(x => x.Login == login);
    }
}