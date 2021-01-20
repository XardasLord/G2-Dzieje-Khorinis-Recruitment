using G2.DK.Domain.Aggregates.Character;
using G2.DK.Infrastructure.Persistence.DbContexts;
using G2.DK.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace G2.DK.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        private const string ConnectionStringConfigName = "G2ConnectionString";

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
            => services
                .AddDbContext<G2DbContext>(options =>
                {
                    options.EnableDetailedErrors();
                    options.UseSqlServer(configuration.GetConnectionString(ConnectionStringConfigName));
                })
                .AddScoped<ICharacterRepository, CharacterRepository>();
    }
}
