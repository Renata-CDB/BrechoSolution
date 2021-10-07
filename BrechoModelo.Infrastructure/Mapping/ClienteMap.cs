using BrechoDomain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrechoModelo.Infrastructure.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired().HasColumnType("varchar");
            builder.Property(c => c.Sobrenome).HasMaxLength(100).IsRequired().HasColumnType("varchar");
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired().HasColumnType("varchar");

            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(c => c.ClienteId);               

            builder.Property(c => c.Ativo)
                .HasColumnType("bit");
        }
    }
}
