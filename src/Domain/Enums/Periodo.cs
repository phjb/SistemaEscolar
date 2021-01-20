using System.ComponentModel;

namespace Domain.Enums
{
    public enum Periodo
    {
        [Description("Matutino")]
        MATUTINO = 1,

        [Description("Vespertino")]
        VESPERTINO = 2,
        
        [Description("Noturno")]
        NOTURNO = 3
    }
}