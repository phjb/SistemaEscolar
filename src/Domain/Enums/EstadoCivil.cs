using System.ComponentModel;

namespace Domain.Enums
{
    public enum EstadoCivil
    {
        [Description("Solteiro(a)")]
        SOLTEIRO = 1,

        [Description("Casado(a)")]
        CASADO = 2,

        [Description("Divorciado(a)")]
        DIVORCIADO = 3,

        [Description("Viuvo(a)")]
        VIUVO = 4,

        [Description("Separado(a)")]
        SEPARADO = 5
    }
}