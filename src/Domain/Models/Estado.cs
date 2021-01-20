using System.Collections.Generic;

namespace Domain.Models
{
    public class Estado
    {
        public int Id { get; set; }        
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public IEnumerable<Cidade> Cidades { get; set; }
        
    }
}