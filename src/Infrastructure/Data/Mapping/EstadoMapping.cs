using System.Reflection;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapping
{
    public class EstadoMapping: IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).HasColumnName("nome").IsRequired();
            builder.Property(e => e.Sigla).HasColumnName("sigla").HasColumnType("char(2)").IsRequired();
            builder.HasMany(e => e.Cidades)
                .WithOne(c => c.Estado)
                .HasForeignKey(c => c.IdEstado);

            builder.ToTable("estado","sistema_escolar");

        }
    }
}