using G2.DK.Domain.Aggregates.Character;
using G2.DK.Domain.Aggregates.User;
using G2.DK.Infrastructure.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace G2.DK.Infrastructure.Persistence.DbContexts
{
    public class G2DbContext : DbContext
    { 
        public G2DbContext(DbContextOptions options) : base(options) {}

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder
                .ApplyConfiguration(new CharacterConfiguration())
                .ApplyConfiguration(new UserConfiguration());
    }
}
