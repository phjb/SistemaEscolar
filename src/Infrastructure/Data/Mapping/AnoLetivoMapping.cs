using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapping
{
    public class AnoLetivoMapping : IEntityTypeConfiguration<AnoLetivo>
    {
        public void Configure(EntityTypeBuilder<AnoLetivo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("id").IsRequired();
            builder.Property(a => a.Ano).HasColumnName("ano").HasColumnType("char(4)").IsRequired();
            builder.Property(a => a.Vigente).HasColumnName("vigente").IsRequired();
            builder.Property(a => a.DataInicio).HasColumnName("data_inicio").IsRequired();
            builder.Property(a => a.DataFinal).HasColumnName("data_final").IsRequired();

            builder.ToTable("ano_letivo","sistema_escolar");
        }
    }
}