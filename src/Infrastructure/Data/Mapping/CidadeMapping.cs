using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapping
{
    public class CidadeMapping: IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("id").IsRequired();
            builder.Property(c => c.Nome).HasColumnName("nome").IsRequired();
            builder.Property(c => c.IdEstado).HasColumnName("id_estado").IsRequired();
            
            builder
                .HasOne(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey(c => c.IdEstado)
                .HasConstraintName("fk_c_estado");

            builder
                .HasMany(c => c.Enderecos)
                .WithOne(e => e.Cidade)
                .HasForeignKey(e => e.IdCidade);

            builder.ToTable("cidade","sistema_escolar");
        }
    }
}