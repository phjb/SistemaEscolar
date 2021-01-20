using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapping
{
    public class EnderecoMapping: IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("id").IsRequired();
            builder.Property(e => e.Logradouro).HasColumnName("logradouro").IsRequired();
            builder.Property(e => e.Numero).HasColumnName("numero");
            builder.Property(e => e.Complemento).HasColumnName("complemento");
            builder.Property(e => e.Bairro).HasColumnName("bairro").IsRequired();
            builder.Property(e => e.Cep).HasColumnName("cep").HasColumnType("char(8)").IsRequired();
            builder.Property(e => e.IdCidade).HasColumnName("id_cidade");
            
            builder.HasOne(e => e.Cidade)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.IdCidade)
                .HasConstraintName("fk_e_cidade");
            
            builder.ToTable("endereco","sistema_escolar");

        }
    }
}