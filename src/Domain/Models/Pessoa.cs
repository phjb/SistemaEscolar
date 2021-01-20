using Domain.Enums;
using System;

namespace Domain.Models
{
    public class Pessoa : Entity
    {
         public Pessoa() : base(Guid.NewGuid())
        {

        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; }
        public string Cpf { get; set; }
        public EstadoCivil EstadoCivil { get; set; }    
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Ativo { get; set; }
        public string Foto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
        
        public Guid? IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}