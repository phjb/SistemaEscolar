using System.Security.AccessControl;
using System;

namespace Domain.Models
{
    public class AnoLetivo: Entity
    {
        public AnoLetivo():base(new Guid()) { }
        
        public string Ano { get; set; }        
        public DateTime DataInicio { get; set; }        
        public DateTime DataFinal { get; set; }
        public bool Vigente { get; set; }       
        
    }
}