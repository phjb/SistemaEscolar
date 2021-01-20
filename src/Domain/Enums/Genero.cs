using System.ComponentModel;

namespace Domain.Enums
{
    public enum Genero
    {
        [Description("Masculino")]
        MASCULINO = 1,

        [Description("Feminino")]
        FEMININO = 2,

        [Description("Outro")]
        OUTRO = 3
    }
}