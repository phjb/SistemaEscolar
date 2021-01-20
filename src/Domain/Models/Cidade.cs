using System.Collections.Generic;

namespace Domain.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }
        public virtual  Estado Estado { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}