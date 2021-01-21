using G2.DK.Domain.Aggregates.Character;
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
}
