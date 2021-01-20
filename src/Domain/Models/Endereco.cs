using System;

namespace Domain.Models
{
    public class Endereco : Entity
    {
        public Endereco():base(Guid.NewGuid())
        {
            
        }
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int IdCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}