using BrechoDomain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrechoModelo.Infrastructure.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired().HasColumnType("varchar");
            builder.Property(p => p.ClienteId).HasMaxLength(100).IsRequired().HasColumnType("varchar");

            builder.Property(p => p.Valor)
                .HasColumnType("float");

            builder.Property(p => p.Disponivel)
                .HasColumnType("bit");

        }
    }
}
