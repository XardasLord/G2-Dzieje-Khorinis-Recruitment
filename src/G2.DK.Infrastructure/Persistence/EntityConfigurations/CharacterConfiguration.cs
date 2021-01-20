using G2.DK.Domain.Aggregates.Character;
using G2.DK.Domain.Aggregates.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G2.DK.Infrastructure.Persistence.EntityConfigurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> entity)
        {
            entity.ToTable("Characters");
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("CharacterId")
                .UseIdentityColumn();

            entity.Property(e => e.Name)
                .HasColumnName("Name")
                .IsRequired();

            entity.Property(e => e.Description)
                .HasColumnName("Description")
                .IsRequired();
        }
    }
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.ToTable("Users");
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("UserId")
                .UseIdentityColumn();

            entity.Property(e => e.Login)
                .HasColumnName("Login")
                .IsRequired();

            entity.Property(e => e.Password)
                .HasColumnName("Password")
                .IsRequired();
        }
    }
}
