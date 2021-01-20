using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapping
{
    public class PessoaMapping: IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").IsRequired();
            builder.Property(p => p.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataNascimento).HasColumnName("data_nascimento").IsRequired();
            builder.Property(p => p.Genero).HasColumnName("genero").HasConversion<string>().IsRequired();
            builder.Property(p => p.Cpf).HasColumnName("cpf").HasColumnType("char(11)");
            builder.Property(p => p.EstadoCivil).HasColumnName("estado_civil").HasConversion<string>().IsRequired();
            builder.Property(p => p.Email).HasColumnName("email").HasMaxLength(50);
            builder.Property(p => p.Celular).HasColumnName("celular").HasMaxLength(15);
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasMaxLength(15);
            builder.Property(p => p.Ativo).HasColumnName("ativo").IsRequired();
            builder.Property(p => p.Foto).HasColumnName("foto");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro").IsRequired();
            builder.Property(p => p.DataAlteracao).HasColumnName("data_alteracao");
            builder.Property(p => p.DataExclusao).HasColumnName("data_exclusao");
            builder.Property(p => p.IdEndereco).HasColumnName("id_endereco");

            builder.HasOne(p => p.Endereco)
                .WithMany()
                .HasForeignKey(p => p.IdEndereco);

            builder.ToTable("pessoa","sistema_escolar");




        }
    }
}